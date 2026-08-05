using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class JGJHEAOPGME<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class GBIGHOGHPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::JGJHEAOPGME<T> GJPLAEOKFJB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] DHLMDDOAPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public GBIGHOGHPEM(global::JGJHEAOPGME<T> GJPLAEOKFJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JAIOGPNDHLB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::JGJHEAOPGME<T> <>4__this;

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
		public JAIOGPNDHLB(int <>1__state)
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
	private const int GKCEFICFLBH = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> LFMMPPEBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int CHMAOLJMIAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T MGJNMHFDFJH
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
	private bool EFLLLAPDHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JIPGMKBKOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool IEPILJLJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KEHBMLJLDDD
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
	public int MNCJKLLDCNE
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
	public JGJHEAOPGME(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public JGJHEAOPGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void HEMGPKDBBCO(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void GEPHADMCPNH(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JEAKIKGHNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void NLFEHPHFDHE(NativeArray<T> DEJEDNNJILK, int AGJLGNIMOFB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::JGJHEAOPGME<>.JAIOGPNDHLB))]
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
	public int FKENAIAHEAH(T GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool AKJLIPOIGHF(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void OOJBCJGOOPE(int GDBOCMJFLPN, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void DFDPHHKCJAP(int GDBOCMJFLPN, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KFAOHMONGMK(int GDBOCMJFLPN, int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int MPGOCOIHIGI(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T PBNKPOHJMOI(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void DEMOOPIFEAO(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void PJGLHCABIJC(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void CIEHCDKIDPP(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int NKHPNAKGHAD(int IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int PKHHAPBEOGG(int IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void AGMEFFIEGAJ(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void DFHIAMPIJMA(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T CGDEAHEHCMG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T BFABFGGPDGG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void OGKDPNNMGEE(int AIPHGHFENPJ, IReadOnlyCollection<T> FLHDOCMLBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void EEEDNKEJIMM(int AIPHGHFENPJ, int DHBJDMINJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void BIDHJKJAKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void IOCBCFGGGMF(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void FKIAPFJCOHA(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void GIBODEFMDLL(int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T BDKBGKOIIKM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T AFMOCBFFKLG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NAOJPPNIGOE]
public static class HLHFCCFHJJE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26E9E80", Offset = "0x26E8C80", VA = "0x1826E9E80")]
	static HLHFCCFHJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2233660", Offset = "0x2232460", VA = "0x182233660")]
	public static void KLHMDOLPFPN<T>(T ICAAAENIBKC, ref T PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26E9E50", Offset = "0x26E8C50", VA = "0x1826E9E50")]
	public static void KLHMDOLPFPN(FixedString32 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D70", Offset = "0x26E8B70", VA = "0x1826E9D70")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString32 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26E9CE0", Offset = "0x26E8AE0", VA = "0x1826E9CE0")]
	public static void KLHMDOLPFPN(FixedString64 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26E9D10", Offset = "0x26E8B10", VA = "0x1826E9D10")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString64 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x207AAC0", Offset = "0x20798C0", VA = "0x18207AAC0")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref Vector3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C10", Offset = "0x26E8A10", VA = "0x1826E9C10")]
	public static void KLHMDOLPFPN(Vector3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x207A8F0", Offset = "0x20796F0", VA = "0x18207A8F0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Vector4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C70", Offset = "0x26E8A70", VA = "0x1826E9C70")]
	public static void KLHMDOLPFPN(Vector4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x207A8F0", Offset = "0x20796F0", VA = "0x18207A8F0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C70", Offset = "0x26E8A70", VA = "0x1826E9C70")]
	public static void KLHMDOLPFPN(Quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26E9DB0", Offset = "0x26E8BB0", VA = "0x1826E9DB0")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref float3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C10", Offset = "0x26E8A10", VA = "0x1826E9C10")]
	public static void KLHMDOLPFPN(float3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26E9BB0", Offset = "0x26E89B0", VA = "0x1826E9BB0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref float4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26E9C70", Offset = "0x26E8A70", VA = "0x1826E9C70")]
	public static void KLHMDOLPFPN(float4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26E9BB0", Offset = "0x26E89B0", VA = "0x1826E9BB0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26E9DE0", Offset = "0x26E8BE0", VA = "0x1826E9DE0")]
	public static void KLHMDOLPFPN(quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x26E9B70", Offset = "0x26E8970", VA = "0x1826E9B70")]
	public static void KLHMDOLPFPN(Entity ICAAAENIBKC, ref EAGBNLPLMDM PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26E9BF0", Offset = "0x26E89F0", VA = "0x1826E9BF0")]
	public static void KLHMDOLPFPN(EAGBNLPLMDM ICAAAENIBKC, ref Entity PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CIHFPOEPMJE]
public class BCACDHDIFBD : ComponentSystem, FDFFINEAOHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FFPEBHHNJFF AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBF60", Offset = "0x2AEAD60", VA = "0x182AEBF60", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public BCACDHDIFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu]
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
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2721A40", Offset = "0x2720840", VA = "0x182721A40")]
		public static ObjectModelConfigAsset KAFDHDNKOOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC042B0", Offset = "0xC030B0", VA = "0x180C042B0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[IFBLAMOEMKH(CMGBDLINHMB.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public const int JHKNBKMIJJL = 0;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private static readonly CGJHBFGPOOL LEOCGNJBNFD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3525020", Offset = "0x3523E20", VA = "0x183525020")]
			public static NMEJDFJAOOA PFOPLNMMKLA(int MNMNCDHLGJH)
			{
				return default(NMEJDFJAOOA);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x3524E90", Offset = "0x3523C90", VA = "0x183524E90")]
			public static int LFKBGMJBMBB(GameObject BFJMKCMPBKG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3524E10", Offset = "0x3523C10", VA = "0x183524E10")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void JIPGEOIILEP(PMMHBDBEGAM ADGJAILKBPO, int MNMNCDHLGJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ELODGKLHEKG BGLEKJNFDOI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static DDMIOFGHMGI BHLMCOMCAMI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static ELODGKLHEKG EFMLHEELPHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2722C60", Offset = "0x2721A60", VA = "0x182722C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2722190", Offset = "0x2720F90", VA = "0x182722190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DDMIOFGHMGI HODIGNDEBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2723070", Offset = "0x2721E70", VA = "0x182723070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2721AE0", Offset = "0x27208E0", VA = "0x182721AE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MDOCPLGNBCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2722B00", Offset = "0x2721900", VA = "0x182722B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2721D20", Offset = "0x2720B20", VA = "0x182721D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BFIAFBHOKLF GMAGOKAFPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2722460", Offset = "0x2721260", VA = "0x182722460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LBPAJLMGMFA CPAHMDPHOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x27224E0", Offset = "0x27212E0", VA = "0x1827224E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2722FF0", Offset = "0x2721DF0", VA = "0x182722FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HFHHBKPAPIM HCLFBFBADHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2721DA0", Offset = "0x2720BA0", VA = "0x182721DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static bool EDGBECOMPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2722A20", Offset = "0x2721820", VA = "0x182722A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool GMLOKFCDNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2722270", Offset = "0x2721070", VA = "0x182722270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2722980", Offset = "0x2721780", VA = "0x182722980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LOJJPMJMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2722F90", Offset = "0x2721D90", VA = "0x182722F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2722DF0", Offset = "0x2721BF0", VA = "0x182722DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool BPFJNFDNOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2723190", Offset = "0x2721F90", VA = "0x182723190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2722920", Offset = "0x2721720", VA = "0x182722920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2722690", Offset = "0x2721490", VA = "0x182722690")]
		public static PMMHBDBEGAM GJELMEFNGNA(GameObject BFJMKCMPBKG)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2722E50", Offset = "0x2721C50", VA = "0x182722E50")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2722070", Offset = "0x2720E70", VA = "0x182722070")]
		public static FEMMDHLANDH DKMHCFMKGGH(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(FEMMDHLANDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2721E20", Offset = "0x2720C20", VA = "0x182721E20")]
		public static (ByteString, IDisposable) DGAMFOBEJMM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27227F0", Offset = "0x27215F0", VA = "0x1827227F0")]
		public static (ByteString, IDisposable) HDNBNFDBMMB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2722CC0", Offset = "0x2721AC0", VA = "0x182722CC0")]
		public static bool LBJNANMCLGI(GameObject BFJMKCMPBKG, out NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2722560", Offset = "0x2721360", VA = "0x182722560")]
		public static bool GEMFNDMEEJL(GameObject BFJMKCMPBKG, out bool OBANFJOJHJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2722EB0", Offset = "0x2721CB0", VA = "0x182722EB0")]
		private static DDMIOFGHMGI NKHKIKEOPBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2721F50", Offset = "0x2720D50", VA = "0x182721F50")]
		private static bool DHBLOAHEADB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HGOFHAOIHFG
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26E9870", Offset = "0x26E8670", VA = "0x1826E9870")]
	public static GIALAGJINEB PJHBAIJLMNC(GameObject BFJMKCMPBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26E9670", Offset = "0x26E8470", VA = "0x1826E9670")]
	public static GIALAGJINEB PJHBAIJLMNC(GameObject BFJMKCMPBKG, NMEJDFJAOOA DBGIPPEDJIM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DisembodiedObjectView : MonoBehaviour, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1995830", Offset = "0x1994630", VA = "0x181995830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GIALAGJINEB, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const string OJHHLHMINPH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KGMBEEPIDCF PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PMMHBDBEGAM JBKJOONHJLG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6619F0", Offset = "0x6607F0", VA = "0x1806619F0", Slot = "11")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public FEMMDHLANDH MDKCEMLOLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFBDA0", Offset = "0x2AFABA0", VA = "0x182AFBDA0", Slot = "4")]
			get
			{
				return default(FEMMDHLANDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB3E0", Offset = "0x2AFA1E0", VA = "0x182AFB3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DDPHBMAAHDP IKBMNLNHFOK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB430", Offset = "0x2AFA230", VA = "0x182AFB430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public KGMBEEPIDCF FMNNHJPPEJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x661740", Offset = "0x660540", VA = "0x180661740", Slot = "5")]
			get
			{
				return default(KGMBEEPIDCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BHCFKCKKCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x65BD70", Offset = "0x65AB70", VA = "0x18065BD70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7B1470", Offset = "0x7B0270", VA = "0x1807B1470", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CPGENINLLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2AFBD00", Offset = "0x2AFAB00", VA = "0x182AFBD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2AFBDD0", Offset = "0x2AFABD0", VA = "0x182AFBDD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB2E0", Offset = "0x2AFA0E0", VA = "0x182AFB2E0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA90", Offset = "0x2AFA890", VA = "0x182AFBA90", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB6B0", Offset = "0x2AFA4B0", VA = "0x182AFB6B0", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA00", Offset = "0x2AFA800", VA = "0x182AFBA00", Slot = "8")]
		public void OnEmbody(EHIDJEIAFME HADAJAKADAH, PMMHBDBEGAM JBKJOONHJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA80", Offset = "0x2AFA880", VA = "0x182AFBA80", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7D0", Offset = "0x2AFA5D0", VA = "0x182AFB7D0", Slot = "10")]
		public void OnDisembody(bool KPMBBBPBAKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBBB0", Offset = "0x2AFA9B0", VA = "0x182AFBBB0")]
		private void PFPDCNMEFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB5F0", Offset = "0x2AFA3F0", VA = "0x182AFB5F0")]
		private void GDCFJBLAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB4B0", Offset = "0x2AFA2B0", VA = "0x182AFB4B0")]
		private void FKLGBDDBJBJ(bool MAGLHKOAFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC82B10", Offset = "0xC81910", VA = "0x180C82B10", Slot = "7")]
		private GameObject LAGCEEBLEDM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[IFBLAMOEMKH(CMGBDLINHMB.Registration)]
	public sealed class TransformEntity : MonoBehaviour, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private CBLLNBPHCKJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PMMHBDBEGAM ADGJAILKBPO;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CBLLNBPHCKJ KCIEHLAFPHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
			get
			{
				return default(CBLLNBPHCKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x745C70", Offset = "0x744A70", VA = "0x180745C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA51550", Offset = "0xA50350", VA = "0x180A51550", Slot = "4")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal DDPHBMAAHDP LLJLHOBLFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2735FC0", Offset = "0x2734DC0", VA = "0x182735FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2735FB0", Offset = "0x2734DB0", VA = "0x182735FB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x27363B0", Offset = "0x27351B0", VA = "0x1827363B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x27360D0", Offset = "0x2734ED0", VA = "0x1827360D0")]
		internal void ILMEFAAGLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2736030", Offset = "0x2734E30", VA = "0x182736030")]
		private bool HDNEEALHHIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27364A0", Offset = "0x27352A0", VA = "0x1827364A0")]
		private void NEKOIANILKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x27363B0", Offset = "0x27351B0", VA = "0x1827363B0")]
		internal void LKKBDAMJBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x27364C0", Offset = "0x27352C0", VA = "0x1827364C0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x27365A0", Offset = "0x27353A0", VA = "0x1827365A0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EBJHGMECDNA(typeof(DDMIOFGHMGI), new string[] { })]
public class AOMGPGIGOPG : OAKPEHJFEOH, DDMIOFGHMGI, HECIIBPMLDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private AJDCMAAKGND FJKJAKKFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EEDGKMIDAFH JLJNFPKFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9140", Offset = "0x7C7F40", VA = "0x1807C9140", Slot = "18")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AJDCMAAKGND AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GMLOKFCDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7490", Offset = "0x2AE6290", VA = "0x182AE7490", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE77A0", Offset = "0x2AE65A0", VA = "0x182AE77A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7870", Offset = "0x2AE6670", VA = "0x182AE7870", Slot = "19")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7860", Offset = "0x2AE6660", VA = "0x182AE7860")]
	private void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7610", Offset = "0x2AE6410", VA = "0x182AE7610")]
	private void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7430", Offset = "0x2AE6230", VA = "0x182AE7430", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE76A0", Offset = "0x2AE64A0", VA = "0x182AE76A0", Slot = "7")]
	public void HJFKJCGGCHL(ByteString JANIFNADDOP, FIIDIKCOABM IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7350", Offset = "0x2AE6150", VA = "0x182AE7350", Slot = "4")]
	public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7570", Offset = "0x2AE6370", VA = "0x182AE7570", Slot = "5")]
	public void HFLDMAMBPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7100", Offset = "0x2AE5F00", VA = "0x182AE7100", Slot = "6")]
	public void BFNLLBCKDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7830", Offset = "0x2AE6630", VA = "0x182AE7830", Slot = "9")]
	public void JIIFFIDEOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7170", Offset = "0x2AE5F70", VA = "0x182AE7170", Slot = "8")]
	public void BKCJFNGCBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7500", Offset = "0x2AE6300", VA = "0x182AE7500", Slot = "10")]
	public void GMLAJKAIPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7950", Offset = "0x2AE6750", VA = "0x182AE7950", Slot = "11")]
	public void NBAPLGNMALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7820", Offset = "0x2AE6620", VA = "0x182AE7820", Slot = "12")]
	public void HLFKKGKEHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7830", Offset = "0x2AE6630", VA = "0x182AE7830")]
	private void JEFLCDJFCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7260", Offset = "0x2AE6060", VA = "0x182AE7260")]
	public static AOMGPGIGOPG DAKLFHBAJIH(AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ = HNBJONKGAEL.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private static void EAKJLDOOHJN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private static void GNNLGEBIEFN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public AOMGPGIGOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NLMGFEDBPGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26FA130", Offset = "0x26F8F30", VA = "0x1826FA130")]
	public static FEMMDHLANDH PACACJLKIEO(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x26F9E30", Offset = "0x26F8C30", VA = "0x1826F9E30")]
	public static DJFJGAJKGKD GEAJKNPCODP(this DDMIOFGHMGI BHLMCOMCAMI)
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x26F9F50", Offset = "0x26F8D50", VA = "0x1826F9F50")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26FA000", Offset = "0x26F8E00", VA = "0x1826FA000")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x26F9D10", Offset = "0x26F8B10", VA = "0x1826F9D10")]
	public static NMEJDFJAOOA GAGENPHPDNI(this DDMIOFGHMGI BHLMCOMCAMI, PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(NMEJDFJAOOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Flags]
public enum HNBJONKGAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class PLGEJPKBGNG<T> : global::ABNAOGMKEDJ<T>, global::ALFHNNMHDGP<NMEJDFJAOOA, T>, global::HCIKOPDBING<NMEJDFJAOOA>, FJCEHGNCBHG, IDisposable, AEFHEEDIBGN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::HCIKOPDBING<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate MDIMLNIMDAB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x306D370", Offset = "0x306C170", VA = "0x18306D370", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3068900", Offset = "0x3067700", VA = "0x183068900", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x306A770", Offset = "0x3069570", VA = "0x18306A770", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3069D20", Offset = "0x3068B20", VA = "0x183069D20", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x306AB20", Offset = "0x3069920", VA = "0x18306AB20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xD66150", Offset = "0xD64F50", VA = "0x180D66150", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3069E50", Offset = "0x3068C50", VA = "0x183069E50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event global::NICCPCBLAIH<NMEJDFJAOOA> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x306A8C0", Offset = "0x30696C0", VA = "0x18306A8C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x306D470", Offset = "0x306C270", VA = "0x18306D470", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x306FC00", Offset = "0x306EA00", VA = "0x18306FC00")]
	public PLGEJPKBGNG(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3068E20", Offset = "0x3067C20", VA = "0x183068E20")]
	private Entity ANJHDLDNACK(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3068BA0", Offset = "0x30679A0", VA = "0x183068BA0")]
	private NMEJDFJAOOA ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3069870", Offset = "0x3068670", VA = "0x183069870", Slot = "4")]
	public T BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x306F270", Offset = "0x306E070", VA = "0x18306F270")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x306A1D0", Offset = "0x3068FD0", VA = "0x18306A1D0")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3068A80", Offset = "0x3067880", VA = "0x183068A80", Slot = "9")]
	public bool AEBBOEKMPNE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x306A670", Offset = "0x3069470", VA = "0x18306A670", Slot = "26")]
	public object FLHIMLEJDFE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x306DC80", Offset = "0x306CA80", VA = "0x18306DC80")]
	public bool NBGPFIAMPKG(NMEJDFJAOOA DBGIPPEDJIM, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3069800", Offset = "0x3068600", VA = "0x183069800")]
	public void BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x306F1F0", Offset = "0x306DFF0", VA = "0x18306F1F0")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x306A590", Offset = "0x3069390", VA = "0x18306A590")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x306B490", Offset = "0x306A290", VA = "0x18306B490", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x306B4C0", Offset = "0x306A2C0", VA = "0x18306B4C0", Slot = "15")]
	public void ICJPMMDCBBM(NMEJDFJAOOA CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x306BB40", Offset = "0x306A940", VA = "0x18306BB40", Slot = "14")]
	public bool JACHHKBDHDB(NMEJDFJAOOA PLPKOODJAKN, NMEJDFJAOOA ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22F34A0", Offset = "0x22F22A0", VA = "0x1822F34A0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x306FA20", Offset = "0x306E820", VA = "0x18306FA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3069C80", Offset = "0x3068A80", VA = "0x183069C80")]
	public string DJJBAGBAKMA(in MJADMLMEADH OGIKPKOLMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x306BC00", Offset = "0x306AA00", VA = "0x18306BC00")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x306B050", Offset = "0x3069E50", VA = "0x18306B050")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x306E530", Offset = "0x306D330", VA = "0x18306E530")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x306DF20", Offset = "0x306CD20", VA = "0x18306DF20")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x306CF10", Offset = "0x306BD10", VA = "0x18306CF10")]
	[Conditional("DEBUG_BUILD")]
	private static void JPOLNLNMBAE(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, string JLHBKPIPBGO, string NFDEPNCPAAF, [CallerMemberName] string NNNOJJMLEJC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3025050", Offset = "0x3023E50", VA = "0x183025050", Slot = "5")]
	private bool PPEIKBCIMKI(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E650", Offset = "0x2C9D450", VA = "0x182C9E650", Slot = "6")]
	private bool OBPBBKFDOHC(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E8F0", Offset = "0x2C9D6F0", VA = "0x182C9E8F0", Slot = "23")]
	private string FPCADNMOMEL(in MJADMLMEADH IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2110", Offset = "0x2EC0F10", VA = "0x182EC2110", Slot = "10")]
	private bool NEAKLMKNCOA(NMEJDFJAOOA CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2490", Offset = "0x2EC1290", VA = "0x182EC2490", Slot = "11")]
	private void KLMFLIMPFDG(NMEJDFJAOOA CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x306F1C0", Offset = "0x306DFC0", VA = "0x18306F1C0", Slot = "12")]
	private bool PDKGBKGOCBI(NMEJDFJAOOA CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x262BE20", Offset = "0x262AC20", VA = "0x18262BE20", Slot = "13")]
	private bool FIDMHDJBIOF(NMEJDFJAOOA CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class JEBFFIPPOIH<T> : global::IHEHHPCDJON<T>, global::ALFHNNMHDGP<PMMHBDBEGAM, T>, global::HCIKOPDBING<PMMHBDBEGAM>, FJCEHGNCBHG, IDisposable, EMNNOKKNGJD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::HCIKOPDBING<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate MDIMLNIMDAB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x398DE60", Offset = "0x398CC60", VA = "0x18398DE60", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3987440", Offset = "0x3986240", VA = "0x183987440", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x398A7D0", Offset = "0x39895D0", VA = "0x18398A7D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3989480", Offset = "0x3988280", VA = "0x183989480", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x398AF70", Offset = "0x3989D70", VA = "0x18398AF70", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x31BAB10", Offset = "0x31B9910", VA = "0x1831BAB10", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3989510", Offset = "0x3988310", VA = "0x183989510", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::NICCPCBLAIH<PMMHBDBEGAM> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x398AC30", Offset = "0x3989A30", VA = "0x18398AC30", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x398E210", Offset = "0x398D010", VA = "0x18398E210", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x306FC00", Offset = "0x306EA00", VA = "0x18306FC00")]
	public JEBFFIPPOIH(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xE75FC0", Offset = "0xE74DC0", VA = "0x180E75FC0")]
	private Entity ANJHDLDNACK(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x31B6280", Offset = "0x31B5080", VA = "0x1831B6280")]
	private PMMHBDBEGAM ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3987A80", Offset = "0x3986880", VA = "0x183987A80", Slot = "4")]
	public T BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3991FD0", Offset = "0x3990DD0", VA = "0x183991FD0")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x398A260", Offset = "0x3989060", VA = "0x18398A260")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39879E0", Offset = "0x39867E0", VA = "0x1839879E0", Slot = "9")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x398A510", Offset = "0x3989310", VA = "0x18398A510", Slot = "25")]
	public object FLHIMLEJDFE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x398E420", Offset = "0x398D220", VA = "0x18398E420")]
	public bool NBGPFIAMPKG(PMMHBDBEGAM ADGJAILKBPO, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3988730", Offset = "0x3987530", VA = "0x183988730")]
	public void BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3992260", Offset = "0x3991060", VA = "0x183992260")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3989CC0", Offset = "0x3988AC0", VA = "0x183989CC0")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x306B490", Offset = "0x306A290", VA = "0x18306B490", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x398C1E0", Offset = "0x398AFE0", VA = "0x18398C1E0", Slot = "15")]
	public void ICJPMMDCBBM(PMMHBDBEGAM CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x398C970", Offset = "0x398B770", VA = "0x18398C970", Slot = "14")]
	public bool JACHHKBDHDB(PMMHBDBEGAM PLPKOODJAKN, PMMHBDBEGAM ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x398D3F0", Offset = "0x398C1F0", VA = "0x18398D3F0")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x398BA60", Offset = "0x398A860", VA = "0x18398BA60")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x39908F0", Offset = "0x398F6F0", VA = "0x1839908F0")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x398F6D0", Offset = "0x398E4D0", VA = "0x18398F6D0")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x31B76B0", Offset = "0x31B64B0", VA = "0x1831B76B0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3992870", Offset = "0x3991670", VA = "0x183992870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x31B7720", Offset = "0x31B6520", VA = "0x1831B7720", Slot = "5")]
	private bool PPNEGJFMBIG(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x31B74E0", Offset = "0x31B62E0", VA = "0x1831B74E0", Slot = "6")]
	private bool DILFBGCJNPO(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1E93950", Offset = "0x1E92750", VA = "0x181E93950", Slot = "10")]
	private bool FOPKGOLPICI(PMMHBDBEGAM CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x31B74A0", Offset = "0x31B62A0", VA = "0x1831B74A0", Slot = "11")]
	private void CLFJPJOHFLN(PMMHBDBEGAM CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x31B62B0", Offset = "0x31B50B0", VA = "0x1831B62B0", Slot = "12")]
	private bool BKBNACBCEKH(PMMHBDBEGAM CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x31B7460", Offset = "0x31B6260", VA = "0x1831B7460", Slot = "13")]
	private bool CFCCOPIDEGA(PMMHBDBEGAM CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BGDMNMCCMEA : IDisposable, FCMCKNEAHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> IJGJHLABOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public BGDMNMCCMEA(NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC130", Offset = "0x2AEAF30", VA = "0x182AEC130", Slot = "6")]
	public PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC180", Offset = "0x2AEAF80", VA = "0x182AEC180", Slot = "7")]
	public Entity LOPGGIPACEB(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC090", Offset = "0x2AEAE90", VA = "0x182AEC090", Slot = "8")]
	public IEnumerable<PMMHBDBEGAM> LOPGGIPACEB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC030", Offset = "0x2AEAE30", VA = "0x182AEC030", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string BMODMKCBMOD = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly CGJHBFGPOOL PDDKNMFMJJE;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int OOPKEADKOMM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static FCMCKNEAHLO EJEJEGHNJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GJHJIKOKLHN;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> IJGJHLABOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2731200", Offset = "0x2730000", VA = "0x182731200")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static bool KCEMFBBKHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2731480", Offset = "0x2730280", VA = "0x182731480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2731420", Offset = "0x2730220", VA = "0x182731420")]
		public static SerializationRemapScope HJFBIOMPHCC()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2731830", Offset = "0x2730630", VA = "0x182731830")]
		public SerializationRemapScope(FCMCKNEAHLO EENEGLPEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2731310", Offset = "0x2730110", VA = "0x182731310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2731640", Offset = "0x2730440", VA = "0x182731640")]
		public static PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2731510", Offset = "0x2730310", VA = "0x182731510")]
		public static Entity LOPGGIPACEB(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EBJHGMECDNA(typeof(IIBEBFFOKJL), new string[] { })]
public class OCMPGHBIMFF : IIBEBFFOKJL
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x26FAAF0", Offset = "0x26F98F0", VA = "0x1826FAAF0", Slot = "5")]
	public void JFDBCBPNEOB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x26FACB0", Offset = "0x26F9AB0", VA = "0x1826FACB0", Slot = "6")]
	public void MBNNIDDPDHD(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x26FABD0", Offset = "0x26F99D0", VA = "0x1826FABD0", Slot = "7")]
	public void LCIAGECPLHB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x26FA9E0", Offset = "0x26F97E0", VA = "0x1826FA9E0", Slot = "4")]
	public IDisposable JDMAFJDBIBL(object GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OCMPGHBIMFF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
	[BPIBJJPJLCE(EEJHBIOBFFI.Application)]
	[EBJHGMECDNA(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal struct KFLLPAHAEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public KFLLPAHAEEL(string KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public void JACHHKBDHDB(EntityManager KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public void ICKDJJKFGLI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public KFLLPAHAEEL FNIGECDGEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KFLLPAHAEEL DBKAECNFAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KFLLPAHAEEL ONMLJOIBOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KFLLPAHAEEL KGNOJPDHANN;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8E80", Offset = "0x2AF7C80", VA = "0x182AF8E80")]
		public DebugWorldsService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8E40", Offset = "0x2AF7C40", VA = "0x182AF8E40", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[EBJHGMECDNA(typeof(GKHHEJLDBHG), new string[] { })]
public class JINAIKLGNJK : GKHHEJLDBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool OLEICDNJIKK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GMLOKFCDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x1806B19D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x26EF650", Offset = "0x26EE450", VA = "0x1826EF650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<bool> BNMEEFBEKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x26EF510", Offset = "0x26EE310", VA = "0x1826EF510", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x26EF5B0", Offset = "0x26EE3B0", VA = "0x1826EF5B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public JINAIKLGNJK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Timing" })]
	[EBJHGMECDNA(typeof(NEKBEAHJEHF), new string[] { })]
	[LFOIMLBAPLC(typeof(SerializationService))]
	[JAPBKNDOGGF(typeof(PKDAIMBJGBM))]
	internal class SerializationService : NEKBEAHJEHF, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const string AJJLNOEBKLI = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly CGJHBFGPOOL IMLOALHAGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private DDMIOFGHMGI BHLMCOMCAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private KFOEJBPDGJE CBNJNNIOIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private GKHHEJLDBHG PMDPJJKFBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private OKJLDANCMCA BFHLJMMPIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private SerializationRemapScope AEPEDHEDMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HDOIPKADCBB EMOEAFOOMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool? JNGDEDPKOCO;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IPBKBIPNEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7FB510", Offset = "0x7FA310", VA = "0x1807FB510", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x1CD3760", Offset = "0x1CD2560", VA = "0x181CD3760", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public OKJLDANCMCA GDFHIAHBADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27324A0", Offset = "0x27312A0", VA = "0x1827324A0", Slot = "11")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2732FE0", Offset = "0x2731DE0", VA = "0x182732FE0")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
		public void ENDOHEJKOHJ(KFOEJBPDGJE MPCCHNGMGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2733110", Offset = "0x2731F10", VA = "0x182733110", Slot = "4")]
		public void PNIPCIGLEJN(bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2731D40", Offset = "0x2730B40", VA = "0x182731D40", Slot = "5")]
		public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2731B30", Offset = "0x2730930", VA = "0x182731B30", Slot = "14")]
		public ByteString DGAMFOBEJMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2732560", Offset = "0x2731360", VA = "0x182732560", Slot = "7")]
		public bool HJFKJCGGCHL(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2732D10", Offset = "0x2731B10", VA = "0x182732D10")]
		private bool NBKHPGGLIHK(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x27318C0", Offset = "0x27306C0", VA = "0x1827318C0", Slot = "8")]
		public bool BKCJFNGCBCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2731970", Offset = "0x2730770", VA = "0x182731970", Slot = "6")]
		public void CNJFHELJLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2732100", Offset = "0x2730F00", VA = "0x182732100", Slot = "9")]
		public bool GMLAJKAIPOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2732A80", Offset = "0x2731880", VA = "0x182732A80", Slot = "10")]
		public bool NBAPLGNMALE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2732890", Offset = "0x2731690", VA = "0x182732890")]
		public bool MMOICLPGKEH(OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC PAKEAHNPOIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2731E20", Offset = "0x2730C20", VA = "0x182731E20")]
		private bool DMJJLNOKELC(ByteString FOEBAOOBLLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x27327D0", Offset = "0x27315D0", VA = "0x1827327D0")]
		private void MMAGGEBNBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2732770", Offset = "0x2731570", VA = "0x182732770")]
		private ByteString MAMBKODCLGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2732380", Offset = "0x2731180", VA = "0x182732380")]
		private ByteString HBCCKENAPKC(ByteString OFOCCMMPKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2732F30", Offset = "0x2731D30", VA = "0x182732F30")]
		private OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC NEIODFJCEMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x27325A0", Offset = "0x27313A0", VA = "0x1827325A0")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x27320C0", Offset = "0x2730EC0", VA = "0x1827320C0")]
		private void FCMNIGJBIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EBJHGMECDNA(typeof(PKDAIMBJGBM), new string[] { })]
[LFOIMLBAPLC(typeof(HDOIPKADCBB))]
internal class HDOIPKADCBB : PKDAIMBJGBM
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BFNLLBCKDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x26E90A0", Offset = "0x26E7EA0", VA = "0x1826E90A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x26E8F10", Offset = "0x26E7D10", VA = "0x1826E8F10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<FCMCKNEAHLO> BPONCGIEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x26E9140", Offset = "0x26E7F40", VA = "0x1826E9140", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x26E91E0", Offset = "0x26E7FE0", VA = "0x1826E91E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FOPGIPKMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x26E8C90", Offset = "0x26E7A90", VA = "0x1826E8C90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x26E8D30", Offset = "0x26E7B30", VA = "0x1826E8D30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action COINHAMMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x26E8E70", Offset = "0x26E7C70", VA = "0x1826E8E70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x26E8DD0", Offset = "0x26E7BD0", VA = "0x1826E8DD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FCMCKNEAHLO> JJFNHBNBCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x26E8FB0", Offset = "0x26E7DB0", VA = "0x1826E8FB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x26E9280", Offset = "0x26E8080", VA = "0x1826E9280", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xE2B5A0", Offset = "0xE2A3A0", VA = "0x180E2B5A0")]
	public void PIGAGAELBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xE2AFD0", Offset = "0xE29DD0", VA = "0x180E2AFD0")]
	public void CIAGNPLALDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x10BCF30", Offset = "0x10BBD30", VA = "0x1810BCF30")]
	public void EFEJPAIAAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x26E8C40", Offset = "0x26E7A40", VA = "0x1826E8C40")]
	public void ALBKGGMPMOC(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x26E9050", Offset = "0x26E7E50", VA = "0x1826E9050")]
	public void KFCLMAMBJOK(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public HDOIPKADCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[EBJHGMECDNA(typeof(AOAMPDCFJGB), new string[] { })]
public class IDOLLILKDHO : FDFFINEAOHD, AOAMPDCFJGB
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly ProfilerMarker KIIIAPAGLNM;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly ProfilerMarker JHKAEHBMPCA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly ProfilerMarker GBBPEDCPGHL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly ProfilerMarker FGJPMONHLNN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ProfilerMarker MGHLBJHBPLL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly ProfilerMarker MPLLODHNIEL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly ProfilerMarker LPLKIDNMNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ProfilerMarker KICBMHNCMGI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ProfilerMarker DGDHODOGGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EHIDJEIAFME CANCHCAFIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private GKHHEJLDBHG GPMKOKBNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x26EB3A0", Offset = "0x26EA1A0", VA = "0x1826EB3A0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x26EB040", Offset = "0x26E9E40", VA = "0x1826EB040", Slot = "12")]
	public void BDKHMFMCKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26EB160", Offset = "0x26E9F60", VA = "0x1826EB160", Slot = "6")]
	public void EOCBAKHJMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26EB8F0", Offset = "0x26EA6F0", VA = "0x1826EB8F0", Slot = "5")]
	public void OEOHKCEFKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x26EB470", Offset = "0x26EA270", VA = "0x1826EB470", Slot = "7")]
	public void ICCPPCIFMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x26EB740", Offset = "0x26EA540", VA = "0x1826EB740", Slot = "8")]
	public void MLLCJLEMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x26EBAA0", Offset = "0x26EA8A0", VA = "0x1826EBAA0", Slot = "9")]
	public void PGLCPONIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x26EB620", Offset = "0x26EA420", VA = "0x1826EB620", Slot = "10")]
	public void LMBOMCOLOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x26EB310", Offset = "0x26EA110", VA = "0x1826EB310", Slot = "11")]
	public void FPGOANAJIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public IDOLLILKDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[EBJHGMECDNA(typeof(EHIDJEIAFME), new string[] { })]
public class OGEMFIKMOPN : EHIDJEIAFME, IDisposable, DFDLCPDHDGP
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PGLNEDJDCBK NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x26FADF0", Offset = "0x26F9BF0", VA = "0x1826FADF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x26FB150", Offset = "0x26F9F50", VA = "0x1826FB150", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x65B260", Offset = "0x65A060", VA = "0x18065B260", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x26FB190", Offset = "0x26F9F90", VA = "0x1826FB190", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x26FAE10", Offset = "0x26F9C10", VA = "0x1826FAE10")]
	private void DAKLFHBAJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x26FAF20", Offset = "0x26F9D20", VA = "0x1826FAF20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x26FB170", Offset = "0x26F9F70", VA = "0x1826FB170", Slot = "8")]
	public ComponentSystemBase IDMEFHDLGGA(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OGEMFIKMOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[JAPBKNDOGGF(typeof(ODMPAIDMGCI))]
[EBJHGMECDNA(typeof(NAPHDGPNDCH), new string[] { })]
public sealed class NCLHCLNIFGK : NAPHDGPNDCH, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GGLLCOLGDHJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x351CE10", Offset = "0x351BC10", VA = "0x18351CE10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
		[DebuggerHidden]
		public GGLLCOLGDHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x351CB00", Offset = "0x351B900", VA = "0x18351CB00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x351CDD0", Offset = "0x351BBD0", VA = "0x18351CDD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x351CD30", Offset = "0x351BB30", VA = "0x18351CD30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x351CD30", Offset = "0x351BB30", VA = "0x18351CD30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DNKAAMBGEFF KNPJEFPACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<string, PKIFOJFOFHC> PHKFDNECCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<int, NCDGLNOPNGL> DMILEGDMGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<EMNNOKKNGJD> FADJGCICDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NCDGLNOPNGL FHAGMECFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x26F8050", Offset = "0x26F6E50", VA = "0x1826F8050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public List<EMNNOKKNGJD> BOGKNNCHPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x26F85E0", Offset = "0x26F73E0", VA = "0x1826F85E0", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x26F8640", Offset = "0x26F7440", VA = "0x1826F8640", Slot = "9")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x26F8100", Offset = "0x26F6F00", VA = "0x1826F8100", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x26F81C0", Offset = "0x26F6FC0", VA = "0x1826F81C0", Slot = "6")]
	public bool EJLFOMONOPL(EMNNOKKNGJD HLOAMKBCFBD, out NCDGLNOPNGL DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x26F8250", Offset = "0x26F7050", VA = "0x1826F8250")]
	private void FOCPGJGONGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x26F7E40", Offset = "0x26F6C40", VA = "0x1826F7E40")]
	private void APBHIJLNDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26F8A40", Offset = "0x26F7840", VA = "0x1826F8A40")]
	private PKIFOJFOFHC LPFOILFAPFC(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x26F8050", Offset = "0x26F6E50", VA = "0x1826F8050")]
	private PKIFOJFOFHC BKPMIANNEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x26F86F0", Offset = "0x26F74F0", VA = "0x1826F86F0")]
	private PKIFOJFOFHC LBDCBPBHNLB(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x26F8B80", Offset = "0x26F7980", VA = "0x1826F8B80")]
	private PKIFOJFOFHC OFOHMPAICFE(string KCGMDGFIHOJ, string MKDOEIGPNGM, [Optional] PKIFOJFOFHC IIIKGDMPMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26F8150", Offset = "0x26F6F50", VA = "0x1826F8150")]
	[IteratorStateMachine(typeof(GGLLCOLGDHJ))]
	private IEnumerable<(string, string)> EJBCDJMKBBP(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x26F80B0", Offset = "0x26F6EB0", VA = "0x1826F80B0")]
	private bool CDFGJLPMPCC(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x26F8960", Offset = "0x26F7760", VA = "0x1826F8960")]
	private DNKAAMBGEFF LBOIIOKBPNJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x26F8B30", Offset = "0x26F7930", VA = "0x1826F8B30")]
	private DNKAAMBGEFF MKACELIKLKJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x26F8660", Offset = "0x26F7460", VA = "0x1826F8660")]
	private DNKAAMBGEFF LAHFFPPDBFL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x30D2E80", Offset = "0x30D1C80", VA = "0x1830D2E80")]
	private T PPKNOAEFHAP<T>(EMNNOKKNGJD HLOAMKBCFBD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x26F7FE0", Offset = "0x26F6DE0", VA = "0x1826F7FE0")]
	private FieldInfo BGIHODPKJOL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x26F8C90", Offset = "0x26F7A90", VA = "0x1826F8C90")]
	public NCLHCLNIFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x26F8AA0", Offset = "0x26F78A0", VA = "0x1826F8AA0")]
	[CompilerGenerated]
	private int MDCDJBFGPDN(EMNNOKKNGJD BMPDKJEHGIN, EMNNOKKNGJD BMMLDIMMAAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PKIFOJFOFHC : NCDGLNOPNGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly string ILLEEGLFOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly PKIFOJFOFHC IIIKGDMPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly List<PKIFOJFOFHC> DLDFJOLGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly List<EMNNOKKNGJD> GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string NJKFNDEJKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NCDGLNOPNGL CPANCPIMLED
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<NCDGLNOPNGL> LFOFBANACAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerable<EMNNOKKNGJD> LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2726D70", Offset = "0x2725B70", VA = "0x182726D70")]
	public PKIFOJFOFHC(string BEMAPDNKPAD, PKIFOJFOFHC ADECAOLBLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EBJHGMECDNA(typeof(HFHHBKPAPIM), new string[] { })]
public class FJOBIMGBAGC : HFHHBKPAPIM, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private EntityHierarchyParents OBEJKCLINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityHierarchyChildren FALFIAAPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private FGBIJEJJFBL MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public global::IHEHHPCDJON<PMMHBDBEGAM> JPFILNDPPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67EA40", Offset = "0x67D840", VA = "0x18067EA40", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67EB70", Offset = "0x67D970", VA = "0x18067EB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1E5A140", Offset = "0x1E58F40", VA = "0x181E5A140", Slot = "13")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x26E4C00", Offset = "0x26E3A00", VA = "0x1826E4C00", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x26E4DA0", Offset = "0x26E3BA0", VA = "0x1826E4DA0", Slot = "15")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x18A5050", Offset = "0x18A3E50", VA = "0x1818A5050", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x26E4960", Offset = "0x26E3760", VA = "0x1826E4960")]
	private PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x26E4A20", Offset = "0x26E3820", VA = "0x1826E4A20", Slot = "18")]
	public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x26E5240", Offset = "0x26E4040", VA = "0x1826E5240", Slot = "19")]
	public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x26E50A0", Offset = "0x26E3EA0", VA = "0x1826E50A0", Slot = "20")]
	public IEnumerable<PMMHBDBEGAM> NJHHOCACKHJ(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x26E5030", Offset = "0x26E3E30", VA = "0x1826E5030", Slot = "21")]
	public PMMHBDBEGAM NFFPNEMPLNO(PMMHBDBEGAM ADGJAILKBPO, int AIPHGHFENPJ)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x26E4A80", Offset = "0x26E3880", VA = "0x1826E4A80", Slot = "22")]
	public int EPCJNDKBFAD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x26E4BD0", Offset = "0x26E39D0", VA = "0x1826E4BD0", Slot = "7")]
	public int HDHNEFAFOAJ(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x26E4D00", Offset = "0x26E3B00", VA = "0x1826E4D00", Slot = "8")]
	public CAOGEMEHCPI HNFHCHPIHGD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26E5170", Offset = "0x26E3F70", VA = "0x1826E5170", Slot = "23")]
	public IEnumerable<PMMHBDBEGAM> OEMKFPIEJOP(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x26E4F60", Offset = "0x26E3D60", VA = "0x1826E4F60", Slot = "11")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x26E4E90", Offset = "0x26E3C90", VA = "0x1826E4E90", Slot = "12")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x26E4990", Offset = "0x26E3790", VA = "0x1826E4990", Slot = "4")]
	public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x26E49F0", Offset = "0x26E37F0", VA = "0x1826E49F0", Slot = "10")]
	public bool BEBDCGNEJPP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x26E4B70", Offset = "0x26E3970", VA = "0x1826E4B70", Slot = "24")]
	public bool FLMGCLJOAAP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26E4BA0", Offset = "0x26E39A0", VA = "0x1826E4BA0", Slot = "9")]
	public bool GOENCLMLMME(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x26E4D70", Offset = "0x26E3B70", VA = "0x1826E4D70", Slot = "5")]
	public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ, bool CAMPEPOCDEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x26E4B40", Offset = "0x26E3940", VA = "0x1826E4B40", Slot = "6")]
	public bool FKEELJGEBOF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public FJOBIMGBAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(CMEEFJNDPID), new string[] { })]
internal class CMEEFJNDPID : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<int, MFLHDAEOBPP> JHBFHOMOMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GNLAPDIIDJD GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE930", Offset = "0x2AED730", VA = "0x182AEE930", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7E0", Offset = "0x2AED5E0", VA = "0x182AEE7E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE480", Offset = "0x2AED280", VA = "0x182AEE480")]
	public MFLHDAEOBPP ABLADMHFHAN(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE690", Offset = "0x2AED490", VA = "0x182AEE690")]
	public MFLHDAEOBPP ABLADMHFHAN(JLCDNMLCNEN ABEODFEGJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE980", Offset = "0x2AED780", VA = "0x182AEE980")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEAA0", Offset = "0x2AED8A0", VA = "0x182AEEAA0")]
	public CMEEFJNDPID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MFLHDAEOBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NativeList<MIFKFPHADFM> EJGHENKOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeList<FDCGJNDCDCD> AOAOEICHLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<MIFKFPHADFM> NFIMDAGFELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<MIFKFPHADFM> EGCAEICEBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<FDCGJNDCDCD> BMKLKAAONKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA51550", Offset = "0xA50350", VA = "0x180A51550")]
		get
		{
			return default(NativeList<FDCGJNDCDCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<MIFKFPHADFM> LCLCNLCOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xE68A70", Offset = "0xE67870", VA = "0x180E68A70")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x727620", Offset = "0x726420", VA = "0x180727620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x26F75E0", Offset = "0x26F63E0", VA = "0x1826F75E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x26F7670", Offset = "0x26F6470", VA = "0x1826F7670")]
	public MFLHDAEOBPP(Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x26F7570", Offset = "0x26F6370", VA = "0x1826F7570")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x26F7480", Offset = "0x26F6280", VA = "0x1826F7480")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x26F72B0", Offset = "0x26F60B0", VA = "0x1826F72B0")]
	public void HEFJCCLOLGO(Entity GEEFHDFLBEH, Entity POICJGPACMK, Entity JDMCICBCFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LFOIMLBAPLC(typeof(BBNANJDJDKF))]
[EBJHGMECDNA(typeof(LBPAJLMGMFA), new string[] { })]
public class BBNANJDJDKF : FDFFINEAOHD, IDisposable, LBPAJLMGMFA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private enum INAFJKBPCEO
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct OAGDPOPOBDF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly INAFJKBPCEO CPLIIAMHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly BBNANJDJDKF FPFLBEGAJEB;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3522FE0", Offset = "0x3521DE0", VA = "0x183522FE0")]
		public OAGDPOPOBDF(BBNANJDJDKF FPFLBEGAJEB, bool NGKHKIFAGPC, uint JKGBPKEJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3522FB0", Offset = "0x3521DB0", VA = "0x183522FB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PNNNHCANNGD
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct AJCNCDCKOAB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private readonly PNNNHCANNGD EHDENJOEBEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private readonly bool BPIFNHNEEBD;

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x3518A00", Offset = "0x3517800", VA = "0x183518A00")]
			public AJCNCDCKOAB(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x35189D0", Offset = "0x35177D0", VA = "0x1835189D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct DOAEDIHIIDP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private readonly PNNNHCANNGD EHDENJOEBEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private readonly bool BPIFNHNEEBD;

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x351AB30", Offset = "0x3519930", VA = "0x18351AB30")]
			public DOAEDIHIIDP(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x35189D0", Offset = "0x35177D0", VA = "0x1835189D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly BBNANJDJDKF OPAAEBMKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool MBDMKKDGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int MBNNEEAGIFH;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3524880", Offset = "0x3523680", VA = "0x183524880")]
		public PNNNHCANNGD(BBNANJDJDKF OPAAEBMKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3524850", Offset = "0x3523650", VA = "0x183524850")]
		public bool HMALHJBFIIP(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3524800", Offset = "0x3523600", VA = "0x183524800")]
		public DOAEDIHIIDP FNMAGCAMFPK()
		{
			return default(DOAEDIHIIDP);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x35247B0", Offset = "0x35235B0", VA = "0x1835247B0")]
		public AJCNCDCKOAB ABFMMCMGHGO()
		{
			return default(AJCNCDCKOAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CICGAJDCBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public BBNANJDJDKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public CICGAJDCBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x35192A0", Offset = "0x35180A0", VA = "0x1835192A0")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HOJHEDFHLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BBNANJDJDKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HOJHEDFHLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x351DC70", Offset = "0x351CA70", VA = "0x18351DC70")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AIKAHALICHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AIKAHALICHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x35189A0", Offset = "0x35177A0", VA = "0x1835189A0")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly UndoAction DBFLOLENENK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly RedoAction GFIEGPGNDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AJAOFNBLAEO PPHDMDBEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private ActionBuffer GCCMPHNKPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private ActionBuffer HHJLGKKPKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private KDMAIHKHEJC FDMIOBNNFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private OMEALIIIEBE HKLMDPOAHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private INAFJKBPCEO BEACHIEJLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private PNNNHCANNGD EHDENJOEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private uint LNCJKCEPMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private uint IFPFCIKMOGE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	private PNNNHCANNGD DICJHKJIJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool IELLIODAPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAD00", Offset = "0x2AE9B00", VA = "0x182AEAD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ILEGIBFBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAE60", Offset = "0x2AE9C60", VA = "0x182AEAE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool BACABGEDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA7A0", Offset = "0x2AE95A0", VA = "0x182AEA7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int INCFKNAHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAF80", Offset = "0x2AE9D80", VA = "0x182AEAF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int HCNKINHMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA310", Offset = "0x2AE9110", VA = "0x182AEA310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private bool MJOAJNDMFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBE60", Offset = "0x2AEAC60", VA = "0x182AEBE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool PJMIIPMPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA260", Offset = "0x2AE9060", VA = "0x182AEA260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FMOJPHEMMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDC0", Offset = "0x7ADBC0", VA = "0x1807AEDC0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x80C410", Offset = "0x80B210", VA = "0x18080C410", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private ActionBuffer DBNCPCPCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAD60", Offset = "0x2AE9B60", VA = "0x182AEAD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action FAKJDHABAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBB10", Offset = "0x2AEA910", VA = "0x182AEBB10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA1C0", Offset = "0x2AE8FC0", VA = "0x182AEA1C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action DMBICFDMLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB120", Offset = "0x2AE9F20", VA = "0x182AEB120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA270", Offset = "0x2AE9070", VA = "0x182AEA270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA8B0", Offset = "0x2AE96B0", VA = "0x182AEA8B0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA360", Offset = "0x2AE9160", VA = "0x182AEA360", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9F40", Offset = "0x2AE8D40", VA = "0x182AE9F40", Slot = "14")]
	public IDisposable AJCNPDBBLIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB1C0", Offset = "0x2AE9FC0", VA = "0x182AEB1C0", Slot = "9")]
	public IDisposable KEPOHAOMOBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA100", Offset = "0x2AE8F00", VA = "0x182AEA100", Slot = "6")]
	public UndoAction BBALAJBEALO()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBDA0", Offset = "0x2AEABA0", VA = "0x182AEBDA0", Slot = "15")]
	public RedoAction PFKEPJGCIIA()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB8F0", Offset = "0x2AEA6F0", VA = "0x182AEB8F0", Slot = "16")]
	public UndoAction NLLJNOLHHMN()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBC80", Offset = "0x2AEAA80", VA = "0x182AEBC80", Slot = "7")]
	public RedoAction PFKEPJGCIIA(UndoAction MCOKHJALNGG)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB9B0", Offset = "0x2AEA7B0", VA = "0x182AEB9B0", Slot = "8")]
	public UndoAction NLLJNOLHHMN(RedoAction MCOKHJALNGG)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAF20", Offset = "0x2AE9D20", VA = "0x182AEAF20")]
	public bool JFPKNALJNDC(DIBKGKEHLCJ JCCOIDOODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAD70", Offset = "0x2AE9B70", VA = "0x182AEAD70", Slot = "17")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA7F0", Offset = "0x2AE95F0", VA = "0x182AEA7F0")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBBB0", Offset = "0x2AEA9B0", VA = "0x182AEBBB0")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB040", Offset = "0x2AE9E40", VA = "0x182AEB040")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBAD0", Offset = "0x2AEA8D0", VA = "0x182AEBAD0")]
	private void NNGDKFKGMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB830", Offset = "0x2AEA630", VA = "0x182AEB830")]
	private void NIMADPCBEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAC90", Offset = "0x2AE9A90", VA = "0x182AEAC90")]
	private void IBAEKFOLKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB220", Offset = "0x2AEA020", VA = "0x182AEB220")]
	private DNOIGEFBDOI MLMOINDGNGJ()
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAF60", Offset = "0x2AE9D60", VA = "0x182AEAF60")]
	private uint JIKCNGKHDPO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB870", Offset = "0x2AEA670", VA = "0x182AEB870")]
	private bool NKGHIOOOGEE(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA6A0", Offset = "0x2AE94A0", VA = "0x182AEA6A0")]
	private bool GJMFNEDBEBJ(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA640", Offset = "0x2AE9440", VA = "0x182AEA640")]
	private RedoAction GEFPBOMIEMC(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB890", Offset = "0x2AEA690", VA = "0x182AEB890")]
	private UndoAction NKGPADIEHKE(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB440", Offset = "0x2AEA240", VA = "0x182AEB440")]
	private DNOIGEFBDOI MNKKCLEBONM(DNOIGEFBDOI CGKOOFFNHKL, ActionBuffer PNPICJPKOOO, bool NGKHKIFAGPC)
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA6C0", Offset = "0x2AE94C0", VA = "0x182AEA6C0")]
	private void GKPICFMHNIB(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x24957B0", Offset = "0x24945B0", VA = "0x1824957B0")]
	private T GKPICFMHNIB<T>(Func<T> CLLGAPDCKOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB0F0", Offset = "0x2AE9EF0", VA = "0x182AEB0F0")]
	private OAGDPOPOBDF JPAKMGAOJKH(bool NGKHKIFAGPC, uint JKGBPKEJAFA)
	{
		return default(OAGDPOPOBDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBF40", Offset = "0x2AEAD40", VA = "0x182AEBF40")]
	public BBNANJDJDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA490", Offset = "0x2AE9290", VA = "0x182AEA490")]
	[CompilerGenerated]
	private UndoAction EFENJMFOEMJ()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAB20", Offset = "0x2AE9920", VA = "0x182AEAB20")]
	[CompilerGenerated]
	private RedoAction HJCBNPKGOOM()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9FA0", Offset = "0x2AE8DA0", VA = "0x182AE9FA0")]
	[CompilerGenerated]
	private UndoAction AMDOEENGPLP()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ALOABDNNCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public ALOABDNNCOH(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5EA0", Offset = "0x2AE4CA0", VA = "0x182AE5EA0")]
	public static ALOABDNNCOH PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	public T ICHDBDEGGEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	public NativeArray<T> EKHBPDLBOLE<T>(int GKPOMAIMOAK, Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	public NativeArray<T> KIDLKJHGFME<T>(Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DFNLOEACJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public DFNLOEACJNA(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6120", Offset = "0x2AF4F20", VA = "0x182AF6120")]
	public static DFNLOEACJNA PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x235F460", Offset = "0x235E260", VA = "0x18235F460")]
	public T ICHDBDEGGEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	public NativeArray<T> EKHBPDLBOLE<T>(int GKPOMAIMOAK, Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LADBHLGEIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public LADBHLGEIAG(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x26F39A0", Offset = "0x26F27A0", VA = "0x1826F39A0")]
	public static LADBHLGEIAG PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x241B410", Offset = "0x241A210", VA = "0x18241B410")]
	public void KLNDOHCMIPB<T>(in T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x241B310", Offset = "0x241A110", VA = "0x18241B310")]
	public void JBAHKNIGOHH<T>(NativeArray<T> ICAAAENIBKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	public void KGBDFBDIBBA<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FIKHFBIOBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x26E45A0", Offset = "0x26E33A0", VA = "0x1826E45A0")]
	public static Span<byte> IDMCGBAPNDN(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x26E4730", Offset = "0x26E3530", VA = "0x1826E4730")]
	public static ReadOnlySpan<byte> OKENLMHDDLL(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x26E4520", Offset = "0x26E3320", VA = "0x1826E4520")]
	public static NativeArray<byte> DPOLEKKKHDH(this NativeArray<byte> DEJEDNNJILK, int FOACNEHDHLI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x26E46B0", Offset = "0x26E34B0", VA = "0x1826E46B0")]
	public static NativeArray<byte> OJEJJAOBCPK(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2B256E0", Offset = "0x2B244E0", VA = "0x182B256E0")]
	public static NativeArray<byte> OJEJJAOBCPK<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x26E44B0", Offset = "0x26E32B0", VA = "0x1826E44B0")]
	public static NativeArray<byte> DHJIGDKLEJD(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2B24140", Offset = "0x2B22F40", VA = "0x182B24140")]
	public static NativeArray<byte> DHJIGDKLEJD<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x26E4630", Offset = "0x26E3430", VA = "0x1826E4630")]
	public static NativeArray<byte> JNBHMLCCDDP(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2B241A0", Offset = "0x2B22FA0", VA = "0x182B241A0")]
	public static NativeArray<byte> JNBHMLCCDDP<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OGDIBALDCID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NativeList<byte> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public OGDIBALDCID(NativeList<byte> LPDILHBGHIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x26FAD90", Offset = "0x26F9B90", VA = "0x1826FAD90")]
	public static OGDIBALDCID PAAEKNCKHBI(NativeList<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	public void KLNDOHCMIPB<T>(in T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	public void JBAHKNIGOHH<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	public void KGBDFBDIBBA<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	[EBJHGMECDNA(typeof(PropertyChangeNetworkRouter), new string[] { })]
	public class PropertyChangeNetworkRouter : DFDLCPDHDGP, FDFFINEAOHD, GMPBHDKHOML, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private AJAOFNBLAEO MGGGHPDHPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DOAILCELKFK MLMFBHHJDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private GKJELINCFGM GMKKBMEMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KPOGCKFKBHN LDKIDFGEOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private FNGBJBLKAGG OOCIDKJPIOF;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AJAOFNBLAEO FOPMCHJHEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x272D210", Offset = "0x272C010", VA = "0x18272D210")]
		public AJAOFNBLAEO.FLKBEGGKJAK EMJANLIPHLL()
		{
			return default(AJAOFNBLAEO.FLKBEGGKJAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x272D3C0", Offset = "0x272C1C0", VA = "0x18272D3C0", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x272D230", Offset = "0x272C030", VA = "0x18272D230", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x272D2E0", Offset = "0x272C0E0", VA = "0x18272D2E0")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x272CC80", Offset = "0x272BA80", VA = "0x18272CC80")]
		public void BBALAJBEALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x272CDB0", Offset = "0x272BBB0", VA = "0x18272CDB0")]
		private void CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x272D440", Offset = "0x272C240", VA = "0x18272D440")]
		private void PMHJCCMIPME(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x272D300", Offset = "0x272C100", VA = "0x18272D300")]
		private void JGHIEEKMOGH(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x272D1F0", Offset = "0x272BFF0", VA = "0x18272D1F0")]
		private void EIOFHIIOEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x272D420", Offset = "0x272C220", VA = "0x18272D420")]
		private void OFHHJDAAEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x272D0E0", Offset = "0x272BEE0", VA = "0x18272D0E0")]
		private void DBNOLHGKCJK(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3967600", Offset = "0x3966400", VA = "0x183967600", Slot = "6")]
		private void CPJJPHAHFBM<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, object NAHJDDBGMOA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x272D1D0", Offset = "0x272BFD0", VA = "0x18272D1D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EBJHGMECDNA(typeof(EHEEEHIAJEK), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class EHEEEHIAJEK : FDFFINEAOHD, CDAFEBOKDJF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly GMMEMAKMEGH CELOJELHLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private GNLAPDIIDJD GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private BBNANJDJDKF OPAAEBMKPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PropertyChangeNetworkRouter DOCHMGEDDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private JLCDNMLCNEN FKKCKLABEMK;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAD00", Offset = "0x2AF9B00", VA = "0x182AFAD00", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAF20", Offset = "0x2AF9D20", VA = "0x182AFAF20", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAC20", Offset = "0x2AF9A20", VA = "0x182AFAC20")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB100", Offset = "0x2AF9F00", VA = "0x182AFB100")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2AFADE0", Offset = "0x2AF9BE0", VA = "0x182AFADE0")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAB70", Offset = "0x2AF9970", VA = "0x182AFAB70")]
	private void GNAEPMLLAHH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB020", Offset = "0x2AF9E20", VA = "0x182AFB020")]
	public void NNLLHPJFGFJ(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAA50", Offset = "0x2AF9850", VA = "0x182AFAA50")]
	private void FOIPNFGCADH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB190", Offset = "0x2AF9F90", VA = "0x182AFB190")]
	public EHEEEHIAJEK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[DebuggerTypeProxy(typeof(CDHPABBFADE))]
	[IFBLAMOEMKH(CMGBDLINHMB.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		internal class CDHPABBFADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private readonly ActionBuffer CLABEIKAHOI;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public int MNCJKLLDCNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x3519090", Offset = "0x3517E90", VA = "0x183519090")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public PNOAMILFIOA[] EKMFDNHBMAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x35190E0", Offset = "0x3517EE0", VA = "0x1835190E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
			public CDHPABBFADE(ActionBuffer NGHDPLBLION)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x35191B0", Offset = "0x3517FB0", VA = "0x1835191B0")]
			[CompilerGenerated]
			private PNOAMILFIOA POCDMFGJEKO(DNOIGEFBDOI CGKOOFFNHKL)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal class PNOAMILFIOA : GMPBHDKHOML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private readonly ActionBuffer CLABEIKAHOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private readonly DNOIGEFBDOI CGKOOFFNHKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<(FNGBJBLKAGG, string, object)> EMOEAFOOMOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private DFNLOEACJNA ANKKMEDLEHC;

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public int MNCJKLLDCNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x3524C00", Offset = "0x3523A00", VA = "0x183524C00")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public List<(FNGBJBLKAGG, string, object)> NHKMBMIHGFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x3524D50", Offset = "0x3523B50", VA = "0x183524D50")]
			public PNOAMILFIOA(ActionBuffer NGHDPLBLION, DNOIGEFBDOI CGKOOFFNHKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3524C50", Offset = "0x3523A50", VA = "0x183524C50")]
			private string MNNGHMGNCLK(FNGBJBLKAGG OOCIDKJPIOF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x35248C0", Offset = "0x35236C0", VA = "0x1835248C0")]
			private void ENJHCNHMIBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x27EC650", Offset = "0x27EB450", VA = "0x1827EC650", Slot = "4")]
			public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeList<byte> MMEEGBIBNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Stack<DNOIGEFBDOI> MNEJHIAAOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly KANEHMFPCBA PCOFEBKMEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly PFMJKBAICGE DOPKECBLDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GKJELINCFGM GMKKBMEMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly bool LFNJOLCMBEF;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public MIDCJAGGIEB MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7EF0", Offset = "0x2AE6CF0", VA = "0x182AE7EF0")]
			get
			{
				return default(MIDCJAGGIEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7EB0", Offset = "0x2AE6CB0", VA = "0x182AE7EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8710", Offset = "0x2AE7510", VA = "0x182AE8710")]
		public ActionBuffer(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP, bool LFNJOLCMBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2AE79C0", Offset = "0x2AE67C0", VA = "0x182AE79C0")]
		public bool AOHIPLPKOPI(out DNOIGEFBDOI CGKOOFFNHKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7F30", Offset = "0x2AE6D30", VA = "0x182AE7F30")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7A50", Offset = "0x2AE6850", VA = "0x182AE7A50")]
		public DNOIGEFBDOI BBALAJBEALO(PCCDBOGEHKL EMOEAFOOMOP, OMEALIIIEBE HKLMDPOAHBO, uint MACLFOOLELI)
		{
			return default(DNOIGEFBDOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8690", Offset = "0x2AE7490", VA = "0x182AE8690")]
		public bool PGPNAAAHLHB(uint MACLFOOLELI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8230", Offset = "0x2AE7030", VA = "0x182AE8230")]
		public bool NLOBGHHGCBK(uint MACLFOOLELI, out DNOIGEFBDOI MCOKHJALNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7B90", Offset = "0x2AE6990", VA = "0x182AE7B90")]
		public void BICGJHKILCF(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7FA0", Offset = "0x2AE6DA0", VA = "0x182AE7FA0")]
		[Conditional("DEBUG_BUILD")]
		private void LICEHBBBAGP(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2AE80E0", Offset = "0x2AE6EE0", VA = "0x182AE80E0")]
		private void MNKKCLEBONM(DNOIGEFBDOI CPFNLJNHLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8420", Offset = "0x2AE7220", VA = "0x182AE8420")]
		private void NNPIEJGEBCL(DFNLOEACJNA PNAPLCCMKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7D00", Offset = "0x2AE6B00", VA = "0x182AE7D00")]
		private void DFGKMIHFNDC(DNOIGEFBDOI CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7DD0", Offset = "0x2AE6BD0", VA = "0x182AE7DD0")]
		private DFNLOEACJNA GMMABANMJAE(DNOIGEFBDOI CGKOOFFNHKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7D60", Offset = "0x2AE6B60", VA = "0x182AE7D60", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class KANEHMFPCBA : GMPBHDKHOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private DFNLOEACJNA NBEICHBHPDD;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6E67F0", Offset = "0x6E55F0", VA = "0x1806E67F0")]
	public KANEHMFPCBA(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2404800", Offset = "0x2403600", VA = "0x182404800", Slot = "4")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> OEIAJJJNONB, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x26EF910", Offset = "0x26EE710", VA = "0x1826EF910")]
	public void ICJPMMDCBBM(FNGBJBLKAGG OOCIDKJPIOF, ref DFNLOEACJNA PNAPLCCMKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AJAOFNBLAEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct FLKBEGGKJAK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly AJAOFNBLAEO ADECAOLBLPJ;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x351BFD0", Offset = "0x351ADD0", VA = "0x18351BFD0")]
		public FLKBEGGKJAK(AJAOFNBLAEO ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x351BFB0", Offset = "0x351ADB0", VA = "0x18351BFB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected PCCDBOGEHKL EMOEAFOOMOP;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public PCCDBOGEHKL NHKMBMIHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5A50", Offset = "0x2AE4850", VA = "0x182AE5A50")]
		get
		{
			return default(PCCDBOGEHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IDBIMIDLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5B70", Offset = "0x2AE4970", VA = "0x182AE5B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5D10", Offset = "0x2AE4B10", VA = "0x182AE5D10")]
	public AJAOFNBLAEO(PCCDBOGEHKL.NJDDOFJAKLO FLLNAFOKHKF = PCCDBOGEHKL.NJDDOFJAKLO.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5A40", Offset = "0x2AE4840", VA = "0x182AE5A40")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5950", Offset = "0x2AE4750", VA = "0x182AE5950")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5C80", Offset = "0x2AE4A80", VA = "0x182AE5C80")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5A90", Offset = "0x2AE4890", VA = "0x182AE5A90")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5820", Offset = "0x2AE4620", VA = "0x182AE5820")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5B80", Offset = "0x2AE4980", VA = "0x182AE5B80")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5810", Offset = "0x2AE4610", VA = "0x182AE5810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4720", VA = "0x182AE5920")]
	public FLKBEGGKJAK EMJANLIPHLL()
	{
		return default(FLKBEGGKJAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FNGBJBLKAGG : IComparable<FNGBJBLKAGG>, IEquatable<FNGBJBLKAGG>
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static readonly FNGBJBLKAGG JHKNBKMIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public JLCDNMLCNEN ABEODFEGJBP;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2527610", Offset = "0x2526410", VA = "0x182527610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x661A30", Offset = "0x660830", VA = "0x180661A30")]
	public FNGBJBLKAGG(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6300", Offset = "0x26E5100", VA = "0x1826E6300")]
	public void CIELANHJLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x26E6350", Offset = "0x26E5150", VA = "0x1826E6350", Slot = "4")]
	public int CompareTo(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x26E6510", Offset = "0x26E5310", VA = "0x1826E6510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x26E6390", Offset = "0x26E5190", VA = "0x1826E6390", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x26E6430", Offset = "0x26E5230", VA = "0x1826E6430", Slot = "5")]
	public bool Equals(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x26E6310", Offset = "0x26E5110", VA = "0x1826E6310")]
	public static bool CJJJLAGEFIA(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x26E64C0", Offset = "0x26E52C0", VA = "0x1826E64C0")]
	public static bool HNHKEOFMCPG(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x26E6480", Offset = "0x26E5280", VA = "0x1826E6480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GMMEMAKMEGH : FFKLAMKJFED
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private BBNANJDJDKF OPAAEBMKPAD;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x26E8000", Offset = "0x26E6E00", VA = "0x1826E8000")]
	public void FMDFEBBBNGL(NMEJDFJAOOA JBKJOONHJLG, PFMJKBAICGE DOPKECBLDKN, BBNANJDJDKF OPAAEBMKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x26E8110", Offset = "0x26E6F10", VA = "0x1826E8110", Slot = "4")]
	private void JIBFDNGLIKM(FJCEHGNCBHG HLOAMKBCFBD, in MJADMLMEADH IGJPNMBCJPK, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GMMEMAKMEGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CEGIDICONDL
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2AECC80", Offset = "0x2AEBA80", VA = "0x182AECC80")]
	public static void PMHJCCMIPME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2AECA20", Offset = "0x2AEB820", VA = "0x182AECA20")]
	public static void DFCNCGBBNCO(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2AECB90", Offset = "0x2AEB990", VA = "0x182AECB90")]
	public static void JGHIEEKMOGH(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2AECAE0", Offset = "0x2AEB8E0", VA = "0x182AECAE0")]
	public static void DPKALFJIABE(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2AECC30", Offset = "0x2AEBA30", VA = "0x182AECC30")]
	public static EGINIKJHFLB OCMFIABCIME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
		return default(EGINIKJHFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x24ACF10", Offset = "0x24ABD10", VA = "0x1824ACF10")]
	public static T JDBCMJCKMFA<T>(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x24ACEE0", Offset = "0x24ABCE0", VA = "0x1824ACEE0")]
	public static T JDBCMJCKMFA<T>(ref DFNLOEACJNA JANIFNADDOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2AECBE0", Offset = "0x2AEB9E0", VA = "0x182AECBE0")]
	public static EGINIKJHFLB OCMFIABCIME(ref DFNLOEACJNA JANIFNADDOP)
	{
		return default(EGINIKJHFLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PCCDBOGEHKL : IEnumerable<FNGBJBLKAGG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum NJDDOFJAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private struct JHIJODPMNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly OMEALIIIEBE HKLMDPOAHBO;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3520390", Offset = "0x351F190", VA = "0x183520390")]
		public JHIJODPMNDK(PCCDBOGEHKL LPDILHBGHIJ, OMEALIIIEBE HKLMDPOAHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3520060", Offset = "0x351EE60", VA = "0x183520060")]
		public void OHOPKGJFIIG(NativeList<byte> KCFDLMABGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x351FB90", Offset = "0x351E990", VA = "0x18351FB90")]
		private void DIDCFOHFPIO(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3520300", Offset = "0x351F100", VA = "0x183520300")]
		private void OPFBMFPCDAI(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x351FAA0", Offset = "0x351E8A0", VA = "0x18351FAA0")]
		private NativeArray<byte> DGGBLLIKJKE(NativeList<byte> KCFDLMABGLC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x351FBE0", Offset = "0x351E9E0", VA = "0x18351FBE0")]
		private NativeArray<byte> DPFFEOIDPFJ(NativeList<byte> KCFDLMABGLC, int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x351FCD0", Offset = "0x351EAD0", VA = "0x18351FCD0")]
		private int FFCFNADCOCO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x351FF00", Offset = "0x351ED00", VA = "0x18351FF00")]
		private bool HNHCDLDCBKL(FNGBJBLKAGG OOCIDKJPIOF, out NativeArray<byte> JGJDDPHHAJI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct AHPENAOMGDJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private NativeList<byte> JANIFNADDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly FNGBJBLKAGG IKPEGPHMIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly int FOACNEHDHLI;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3518900", Offset = "0x3517700", VA = "0x183518900")]
		internal AHPENAOMGDJ(PCCDBOGEHKL LPDILHBGHIJ, FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3518680", Offset = "0x3517480", VA = "0x183518680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3518710", Offset = "0x3517510", VA = "0x183518710")]
		public void MNMMOHPJBAG(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x35186B0", Offset = "0x35174B0", VA = "0x1835186B0")]
		public void LOAAJLCEDOJ(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x35188F0", Offset = "0x35176F0", VA = "0x1835188F0")]
		public void OPFBMFPCDAI(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x23C6A90", Offset = "0x23C5890", VA = "0x1823C6A90")]
		public void OPFBMFPCDAI<T>(T IGJPNMBCJPK) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x35187D0", Offset = "0x35175D0", VA = "0x1835187D0")]
		private void OIBAELPIFGF(int IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3518840", Offset = "0x3517640", VA = "0x183518840")]
		private void OIBAELPIFGF(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3518770", Offset = "0x3517570", VA = "0x183518770")]
		private unsafe void OIBAELPIFGF(void* JKEHENDBNEL, int GKPOMAIMOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3518710", Offset = "0x3517510", VA = "0x183518710")]
		private void OIBAELPIFGF(NativeArray<byte> ICAAAENIBKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct FLIPDAJLJCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private NativeArray<byte> JANIFNADDOP;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x351BF70", Offset = "0x351AD70", VA = "0x18351BF70")]
		internal FLIPDAJLJCG(PCCDBOGEHKL LPDILHBGHIJ, NativeArray<byte> JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x351BCB0", Offset = "0x351AAB0", VA = "0x18351BCB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x351BCC0", Offset = "0x351AAC0", VA = "0x18351BCC0")]
		public NativeArray<byte> EKHBPDLBOLE(int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x351BE80", Offset = "0x351AC80", VA = "0x18351BE80")]
		public NativeArray<byte> KIDLKJHGFME()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x23CAF30", Offset = "0x23C9D30", VA = "0x1823CAF30")]
		public T ICHDBDEGGEB<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x351BD80", Offset = "0x351AB80", VA = "0x18351BD80")]
		public void ICHDBDEGGEB(in ECNLJAAGJFG IGJPNMBCJPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct KGGCAOCDBPP : IEnumerator<FNGBJBLKAGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly NativeArray<FNGBJBLKAGG> DEJEDNNJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public FNGBJBLKAGG MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x3520AD0", Offset = "0x351F8D0", VA = "0x183520AD0", Slot = "4")]
			get
			{
				return default(FNGBJBLKAGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x3520A90", Offset = "0x351F890", VA = "0x183520A90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1220", Offset = "0x2AE0020", VA = "0x182AE1220")]
		internal KGGCAOCDBPP(NativeArray<FNGBJBLKAGG> ICAAAENIBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x35209E0", Offset = "0x351F7E0", VA = "0x1835209E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3520A50", Offset = "0x351F850", VA = "0x183520A50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct BICHFACMBJK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private const int DKADNKFJDKJ = 0;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private const int IOOEBBLHIFL = 1;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private const int PFMHMNGIHBF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeArray<int> JANIFNADDOP;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public int LPNHFLONAAC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x3518DA0", Offset = "0x3517BA0", VA = "0x183518DA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x3518E60", Offset = "0x3517C60", VA = "0x183518E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public NJDDOFJAKLO MHCBPJALCOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x3518E10", Offset = "0x3517C10", VA = "0x183518E10")]
			get
			{
				return default(NJDDOFJAKLO);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3518E50", Offset = "0x3517C50", VA = "0x183518E50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool IDBIMIDLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x3518E40", Offset = "0x3517C40", VA = "0x183518E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x3518DF0", Offset = "0x3517BF0", VA = "0x183518DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool LCHHGMADKKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x3518E70", Offset = "0x3517C70", VA = "0x183518E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x3518E20", Offset = "0x3517C20", VA = "0x183518E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3518EC0", Offset = "0x3517CC0", VA = "0x183518EC0")]
		public BICHFACMBJK(NJDDOFJAKLO FLLNAFOKHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3518D70", Offset = "0x3517B70", VA = "0x183518D70")]
		private int BOPAOPJOHPG(int LBACAALGKLG, int ADAGEIIBOOC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3518E80", Offset = "0x3517C80", VA = "0x183518E80")]
		private void PIGMJENILDA(int LBACAALGKLG, int IGJPNMBCJPK, int ADAGEIIBOOC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3518DB0", Offset = "0x3517BB0", VA = "0x183518DB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private const int ECAOKMMBJDB = -1;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private const int LFMBNNMLIHP = 0;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly FNGBJBLKAGG CIGDCEBOJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private NativeHashMap<FNGBJBLKAGG, int> JLJODCBLLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeList<FNGBJBLKAGG> EMOEAFOOMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private NativeList<int> NDAADHJDJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NativeList<byte> FCLBNFFJEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeList<byte> JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private BICHFACMBJK PJGALDPNBKH;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool IDBIMIDLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2725690", Offset = "0x2724490", VA = "0x182725690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2725630", Offset = "0x2724430", VA = "0x182725630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPNHFLONAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2725250", Offset = "0x2724050", VA = "0x182725250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int FDLFNBJLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2725650", Offset = "0x2724450", VA = "0x182725650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2725350", Offset = "0x2724150", VA = "0x182725350")]
	public static PCCDBOGEHKL DAKLFHBAJIH(NJDDOFJAKLO FLLNAFOKHKF = NJDDOFJAKLO.Last, int MBPNGLLEBOJ = 16, int DJJPPHBDPJF = 256)
	{
		return default(PCCDBOGEHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2725D50", Offset = "0x2724B50", VA = "0x182725D50")]
	private PCCDBOGEHKL(NJDDOFJAKLO FLLNAFOKHKF, int MBPNGLLEBOJ, int DJJPPHBDPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2725390", Offset = "0x2724190", VA = "0x182725390", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x27251C0", Offset = "0x2723FC0", VA = "0x1827251C0")]
	public AHPENAOMGDJ CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(AHPENAOMGDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x27256A0", Offset = "0x27244A0", VA = "0x1827256A0")]
	public FLIPDAJLJCG KHOGOOFJPNF(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(FLIPDAJLJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2725970", Offset = "0x2724770", VA = "0x182725970")]
	public bool MJGILDABEFF(FNGBJBLKAGG IKPEGPHMIII, out FLIPDAJLJCG KKJNDEPMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2725730", Offset = "0x2724530", VA = "0x182725730")]
	public bool LMPMKEPAAAO(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2725070", Offset = "0x2723E70", VA = "0x182725070")]
	public bool AFAPKFKLOPA(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2725B60", Offset = "0x2724960", VA = "0x182725B60")]
	public void OEICDAKEGLC(NativeList<byte> KCFDLMABGLC, OMEALIIIEBE HKLMDPOAHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8160", Offset = "0x2AD6F60", VA = "0x182AD8160")]
	public T FMDMOKNGPIL<T>(FNGBJBLKAGG IKPEGPHMIII) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2725560", Offset = "0x2724360", VA = "0x182725560")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2725140", Offset = "0x2723F40", VA = "0x182725140")]
	public KGGCAOCDBPP BALJJOIEHDJ()
	{
		return default(KGGCAOCDBPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2725780", Offset = "0x2724580", VA = "0x182725780")]
	private void MCFOLNMELLB(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2725260", Offset = "0x2724060", VA = "0x182725260")]
	private void CIELANHJLDB(int GKNKFNJFDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2725470", Offset = "0x2724270", VA = "0x182725470")]
	private void FMBEEPJHKAK(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2F6E9B0", Offset = "0x2F6D7B0", VA = "0x182F6E9B0")]
	private static T FMDMOKNGPIL<T>(NativeArray<byte> DEJEDNNJILK, int LBACAALGKLG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2725C90", Offset = "0x2724A90", VA = "0x182725C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2725C50", Offset = "0x2724A50", VA = "0x182725C50", Slot = "4")]
	private IEnumerator<FNGBJBLKAGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal abstract class LBBEJFMFHLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private uint CLHKJFCIEDM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public abstract uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9240", Offset = "0x7F8040", VA = "0x1807F9240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x26F3A00", Offset = "0x26F2800", VA = "0x1826F3A00")]
	public NMEJDFJAOOA GAPONIFMOKO()
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x26F3A50", Offset = "0x26F2850", VA = "0x1826F3A50")]
	public void LHCAAPHDADA(NMEJDFJAOOA BHJEHPEEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xDFD210", Offset = "0xDFC010", VA = "0x180DFD210", Slot = "6")]
	public virtual void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	protected LBBEJFMFHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[EBJHGMECDNA(typeof(ADONFIKCCKK), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class ADONFIKCCKK : LBBEJFMFHLN, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private uint BCGICHENIFM;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public override uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x661750", Offset = "0x660550", VA = "0x180661750", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4610", Offset = "0x2AE3410", VA = "0x182AE4610", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE45C0", Offset = "0x2AE33C0", VA = "0x182AE45C0")]
	private void FIDHMGDKEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4560", Offset = "0x2AE3360", VA = "0x182AE4560", Slot = "6")]
	public override void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public ADONFIKCCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[EBJHGMECDNA(typeof(HOLDGPOECHF), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class HOLDGPOECHF : LBBEJFMFHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public override uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x65B5A0", Offset = "0x65A3A0", VA = "0x18065B5A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public HOLDGPOECHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[JAPBKNDOGGF(typeof(ObjectEmbodimentService))]
[JAPBKNDOGGF(typeof(ObjectNetworkToLocalMapService))]
[JAPBKNDOGGF(typeof(CLDGLLOBFOG))]
[EBJHGMECDNA(typeof(GALJPCEPKLP), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class GALJPCEPKLP : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private AOAMPDCFJGB BECAEADJGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EnableComponentSystemsInScope LONAHEEOECC;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x26E7080", Offset = "0x26E5E80", VA = "0x1826E7080")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x26E70D0", Offset = "0x26E5ED0", VA = "0x1826E70D0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6DD0", Offset = "0x26E5BD0", VA = "0x1826E6DD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private void ODFDNIMGHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C80", Offset = "0x26E5A80", VA = "0x1826E6C80")]
	private void BBOJCHACFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GALJPCEPKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(CLDGLLOBFOG), new string[] { })]
internal sealed class CLDGLLOBFOG : BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private EntityQuery JPMMLGEJNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private EntityQuery ABBKLHAPGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private EntityQuery HELHJFODOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private EntityQuery BCEHNLIAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private EntityQuery BGNODAFLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDDC0", Offset = "0x2AECBC0", VA = "0x182AEDDC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EntityQuery FDBIBPLOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE68A70", Offset = "0xE67870", VA = "0x180E68A70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EntityQuery CNOAPBHNMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x898200", Offset = "0x897000", VA = "0x180898200")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EntityQuery HCHPCGPFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x725E70", Offset = "0x724C70", VA = "0x180725E70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EntityQuery JNPBIGEPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE320", Offset = "0x2AED120", VA = "0x182AEE320")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE300", Offset = "0x2AED100", VA = "0x182AEE300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE460", Offset = "0x2AED260", VA = "0x182AEE460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE3A0", Offset = "0x2AED1A0", VA = "0x182AEE3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDEB0", Offset = "0x2AECCB0", VA = "0x182AEDEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDA50", Offset = "0x2AEC850", VA = "0x182AEDA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDED0", Offset = "0x2AECCD0", VA = "0x182AEDED0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDFF0", Offset = "0x2AECDF0", VA = "0x182AEDFF0", Slot = "6")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDD60", Offset = "0x2AECB60", VA = "0x182AEDD60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDCC0", Offset = "0x2AECAC0", VA = "0x182AEDCC0")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA70", Offset = "0x2AEC870", VA = "0x182AEDA70")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDE10", Offset = "0x2AECC10", VA = "0x182AEDE10")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDB60", Offset = "0x2AEC960", VA = "0x182AEDB60")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM JBKJOONHJLG)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDC10", Offset = "0x2AECA10", VA = "0x182AEDC10")]
	public PDCBPHNLNBN BPHEMGAFBAH(Entity GEEFHDFLBEH)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDF40", Offset = "0x2AECD40", VA = "0x182AEDF40")]
	public CBLLNBPHCKJ KEOMIGEONAO(Entity GEEFHDFLBEH)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE3C0", Offset = "0x2AED1C0", VA = "0x182AEE3C0")]
	private CAOGEMEHCPI PFOKOGKMFHO(EntityQuery JFPFDEFJDBP)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1864B50", Offset = "0x1863950", VA = "0x181864B50")]
	public CLDGLLOBFOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[EBJHGMECDNA(typeof(CBIPFLGDJEF), new string[] { })]
public class EAGKPAGKLLG : FDFFINEAOHD, CBIPFLGDJEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private EEDGKMIDAFH JLJNFPKFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ObjectLifecycleService NEINDNLHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA870", Offset = "0x2AF9670", VA = "0x182AFA870", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9A0", Offset = "0x2AF97A0", VA = "0x182AFA9A0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA970", Offset = "0x2AF9770", VA = "0x182AFA970", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9C80", Offset = "0x2AF8A80", VA = "0x182AF9C80", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF92C0", Offset = "0x2AF80C0", VA = "0x182AF92C0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HJDHFKEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA470", Offset = "0x2AF9270", VA = "0x182AFA470", Slot = "43")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA720", Offset = "0x2AF9520", VA = "0x182AFA720", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<PMMHBDBEGAM, CBLLNBPHCKJ> PENFFKIPBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA300", Offset = "0x2AF9100", VA = "0x182AFA300", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9880", Offset = "0x2AF8680", VA = "0x182AF9880", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<PMMHBDBEGAM> NNDDOAEECDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA240", Offset = "0x2AF9040", VA = "0x182AFA240", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9BE0", Offset = "0x2AF89E0", VA = "0x182AF9BE0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9D30", Offset = "0x2AF8B30", VA = "0x182AF9D30", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF96E0", Offset = "0x2AF84E0", VA = "0x182AF96E0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA490", Offset = "0x2AF9290", VA = "0x182AFA490")]
	private void LCDPHGCPODA(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF97F0", Offset = "0x2AF85F0", VA = "0x182AF97F0")]
	private void ECCCDPILENL(Entity GEEFHDFLBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AF92A0", Offset = "0x2AF80A0", VA = "0x182AF92A0")]
	internal PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9610", Offset = "0x2AF8410", VA = "0x182AF9610", Slot = "39")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9340", Offset = "0x2AF8140", VA = "0x182AF9340", Slot = "40")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9AF0", Offset = "0x2AF88F0", VA = "0x182AF9AF0", Slot = "41")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9450", Offset = "0x2AF8250", VA = "0x182AF9450", Slot = "10")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA3A0", Offset = "0x2AF91A0", VA = "0x182AFA3A0", Slot = "11")]
	public CBLLNBPHCKJ KEOMIGEONAO(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9270", Offset = "0x2AF8070", VA = "0x182AF9270", Slot = "32")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9220", Offset = "0x2AF8020", VA = "0x182AF9220", Slot = "28")]
	public void ACKFNLGGLJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF95A0", Offset = "0x2AF83A0", VA = "0x182AF95A0", Slot = "29")]
	public void CHMNDPKCMOJ(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA7F0", Offset = "0x2AF95F0", VA = "0x182AFA7F0", Slot = "30")]
	public void NONGHDEHHOE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9CB0", Offset = "0x2AF8AB0", VA = "0x182AF9CB0", Slot = "22")]
	public FEMMDHLANDH HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA660", Offset = "0x2AF9460", VA = "0x182AFA660", Slot = "23")]
	public FEMMDHLANDH MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA8A0", Offset = "0x2AF96A0", VA = "0x182AFA8A0", Slot = "24")]
	public FEMMDHLANDH PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50", Slot = "25")]
	public DJFJGAJKGKD GEAJKNPCODP()
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9F90", Offset = "0x2AF8D90", VA = "0x182AF9F90", Slot = "42")]
	public MIABGLBICKE IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
	{
		return default(MIABGLBICKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9920", Offset = "0x2AF8720", VA = "0x182AF9920", Slot = "26")]
	public POGPGKFDCLE FECCIBCHBLN()
	{
		return default(POGPGKFDCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA740", Offset = "0x2AF9540", VA = "0x182AFA740", Slot = "27")]
	public DJFHIDPOABC NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
	{
		return default(DJFHIDPOABC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA9D0", Offset = "0x2AF97D0", VA = "0x182AFA9D0", Slot = "12")]
	public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA550", Offset = "0x2AF9350", VA = "0x182AFA550", Slot = "13")]
	public FEMMDHLANDH LFOFKHPGLIF(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9550", Offset = "0x2AF8350", VA = "0x182AF9550", Slot = "14")]
	public bool CECLHLMOAFB(PMMHBDBEGAM ADGJAILKBPO, out GIALAGJINEB BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA820", Offset = "0x2AF9620", VA = "0x182AFA820", Slot = "45")]
	public Transform OFFKLJGCIOM(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF99D0", Offset = "0x2AF87D0", VA = "0x182AF99D0", Slot = "16")]
	public bool FPFNOLCEKGF(PMMHBDBEGAM ADGJAILKBPO, out Transform BCHADNCHEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9510", Offset = "0x2AF8310", VA = "0x182AF9510", Slot = "17")]
	public bool CDOIOEBAIAC(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9320", Offset = "0x2AF8120", VA = "0x182AF9320")]
	public bool BHOEHOJGMNO(GIALAGJINEB IGJPNMBCJPK, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2AF92F0", Offset = "0x2AF80F0", VA = "0x182AF92F0", Slot = "46")]
	public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9F20", Offset = "0x2AF8D20", VA = "0x182AF9F20", Slot = "47")]
	public void HKEPNALNJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA030", Offset = "0x2AF8E30", VA = "0x182AFA030", Slot = "15")]
	public void IIHMCLDDPGI(GIALAGJINEB CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA6E0", Offset = "0x2AF94E0", VA = "0x182AFA6E0", Slot = "48")]
	public void NIMKLNCMIKA(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2AF96C0", Offset = "0x2AF84C0", VA = "0x182AF96C0", Slot = "18")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2AF95F0", Offset = "0x2AF83F0", VA = "0x182AF95F0", Slot = "19")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA2E0", Offset = "0x2AF90E0", VA = "0x182AFA2E0", Slot = "49")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA530", Offset = "0x2AF9330", VA = "0x182AFA530", Slot = "50")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9F40", Offset = "0x2AF8D40", VA = "0x182AF9F40", Slot = "31")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9A20", Offset = "0x2AF8820", VA = "0x182AF9A20", Slot = "21")]
	public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9BA0", Offset = "0x2AF89A0", VA = "0x182AF9BA0", Slot = "20")]
	public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public EAGKPAGKLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(JGLKPBCBPCD), new string[] { })]
internal sealed class JGLKPBCBPCD : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x26EEC60", Offset = "0x26EDA60", VA = "0x1826EEC60", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x26EF180", Offset = "0x26EDF80", VA = "0x1826EF180")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x26EF280", Offset = "0x26EE080", VA = "0x1826EF280")]
	private void PGEFBEAPHNN(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x26EECF0", Offset = "0x26EDAF0", VA = "0x1826EECF0")]
	private void HJMHHOHEACI(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x26EEAD0", Offset = "0x26ED8D0", VA = "0x1826EEAD0")]
	private void EKHJMELAAHL(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP, NOBHGMEMAKH GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x26EE7A0", Offset = "0x26ED5A0", VA = "0x1826EE7A0")]
	private NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)> CCCJOFIOKGC(Allocator JEOILJEOOOI, NativeArray<PMMHBDBEGAM> CGGBICHOEDC, out NativeArray<(PMMHBDBEGAM src, PMMHBDBEGAM dst)> DCMEPDOGCMK)
	{
		return default(NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public JGLKPBCBPCD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics, new string[] { "Callbacks" })]
	[EBJHGMECDNA(typeof(DOFEFFJAEBG), new string[] { })]
	public class PhysicsService : FDFFINEAOHD, CDAFEBOKDJF, DOFEFFJAEBG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private const string NGJFDPMAJJK = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CGJHBFGPOOL OHFHPDHGMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private KNJHNLNIBIP MFJHDOKFILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private PropertyEventCallbacksService OBJALHMPDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private global::ONBLNDNGCOE<AGIBDFHOBNC> NABMMLICENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<PMMHBDBEGAM, AGIBDFHOBNC> LKKOAGECGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x272A880", Offset = "0x2729680", VA = "0x18272A880", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x272A920", Offset = "0x2729720", VA = "0x18272A920", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x272ABE0", Offset = "0x27299E0", VA = "0x18272ABE0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x272AD00", Offset = "0x2729B00", VA = "0x18272AD00", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x272A9C0", Offset = "0x27297C0", VA = "0x18272A9C0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x272AB20", Offset = "0x2729920", VA = "0x18272AB20", Slot = "8")]
		public void EGOGCMBFKGF(PMMHBDBEGAM ADGJAILKBPO, Vector3 BOMEDIENHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x272B120", Offset = "0x2729F20", VA = "0x18272B120", Slot = "9")]
		public bool MJEKGLFLNDP(PMMHBDBEGAM ADGJAILKBPO, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x272AFA0", Offset = "0x2729DA0", VA = "0x18272AFA0")]
		private void LEIMCIGPFAK(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x272B060", Offset = "0x2729E60", VA = "0x18272B060", Slot = "10")]
		public void MHGCCIIFFLE(PMMHBDBEGAM ADGJAILKBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
[EBJHGMECDNA(typeof(GNLAPDIIDJD), new string[] { })]
[JAPBKNDOGGF(typeof(ADBFMIBHACH))]
public class AGLAMIGKINP : GNLAPDIIDJD, IEnumerable<EGNDHFFDDFH>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<(Type, string), int> OMMBLPLAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private ADBFMIBHACH GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private HJJIPEEBILL KCINBNOPKJE;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2AE55F0", Offset = "0x2AE43F0", VA = "0x182AE55F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5660", Offset = "0x2AE4460", VA = "0x182AE5660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5660", Offset = "0x2AE4460", VA = "0x182AE5660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5610", Offset = "0x2AE4410", VA = "0x182AE5610", Slot = "11")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2AE51E0", Offset = "0x2AE3FE0", VA = "0x182AE51E0", Slot = "12")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "13")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4EC0", Offset = "0x2AE3CC0", VA = "0x182AE4EC0")]
	private void AEEMLNFIALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x14E6200", Offset = "0x14E5000", VA = "0x1814E6200")]
	private string MPJCBKINOFO(string BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5510", Offset = "0x2AE4310", VA = "0x182AE5510", Slot = "7")]
	public EGNDHFFDDFH HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5260", Offset = "0x2AE4060", VA = "0x182AE5260")]
	private bool HINDNOFJKBF(Type CJJNIEGEMMA, string BEMAPDNKPAD, out EGNDHFFDDFH KOPJKHIOCNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5680", Offset = "0x2AE4480", VA = "0x182AE5680", Slot = "8")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE51C0", Offset = "0x2AE3FC0", VA = "0x182AE51C0", Slot = "9")]
	public IEnumerator<EGNDHFFDDFH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE51C0", Offset = "0x2AE3FC0", VA = "0x182AE51C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5790", Offset = "0x2AE4590", VA = "0x182AE5790")]
	public AGLAMIGKINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[DefaultMember("Item")]
public interface OMEALIIIEBE
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMJKEHCEABE(JLCDNMLCNEN FCDKMJOKGIE, out int MNKEEJPGFOP);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
[EBJHGMECDNA(typeof(OMEALIIIEBE), new string[] { })]
[JAPBKNDOGGF(typeof(GKJELINCFGM))]
public class MOHCPMJFOKI : FDFFINEAOHD, CDAFEBOKDJF, OMEALIIIEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<JLCDNMLCNEN, int> IPOKFIMAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x26F7A70", Offset = "0x26F6870", VA = "0x1826F7A70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x26F7D50", Offset = "0x26F6B50", VA = "0x1826F7D50", Slot = "6")]
	public bool MMJKEHCEABE(JLCDNMLCNEN FCDKMJOKGIE, out int MNKEEJPGFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A10", Offset = "0x26F6810", VA = "0x1826F7A10", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x26F7AD0", Offset = "0x26F68D0", VA = "0x1826F7AD0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x26F7AE0", Offset = "0x26F68E0", VA = "0x1826F7AE0")]
	private void LFFDHDOPOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x26F7DC0", Offset = "0x26F6BC0", VA = "0x1826F7DC0")]
	public MOHCPMJFOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[JAPBKNDOGGF(typeof(GNLAPDIIDJD))]
[EBJHGMECDNA(typeof(GKJELINCFGM), new string[] { })]
[DefaultMember("Item")]
public class CGONEFNHILL : GKJELINCFGM, IEnumerable<AEFHEEDIBGN>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, GMPBHDKHOML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private AEFHEEDIBGN[] NBOEFHBOIKI;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2AED900", Offset = "0x2AEC700", VA = "0x182AED900", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2AED910", Offset = "0x2AEC710", VA = "0x182AED910", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED910", Offset = "0x2AEC710", VA = "0x182AED910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2AED510", Offset = "0x2AEC310", VA = "0x182AED510", Slot = "11")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "12")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2AED7D0", Offset = "0x2AEC5D0", VA = "0x182AED7D0", Slot = "6")]
	public AEFHEEDIBGN HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2AED950", Offset = "0x2AEC750", VA = "0x182AED950", Slot = "7")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2AED430", Offset = "0x2AEC230", VA = "0x182AED430", Slot = "8")]
	public IEnumerator<AEFHEEDIBGN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA20", Offset = "0x2AEC820", VA = "0x182AEDA20", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1F71080", Offset = "0x1F6FE80", VA = "0x181F71080", Slot = "13")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2AED2F0", Offset = "0x2AEC0F0", VA = "0x182AED2F0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public CGONEFNHILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2AED910", Offset = "0x2AEC710", VA = "0x182AED910")]
	[CompilerGenerated]
	private AEFHEEDIBGN IGLPAHEFELC(int HLAPKJLCEDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[EBJHGMECDNA(typeof(ODMPAIDMGCI), new string[] { })]
[DefaultMember("Item")]
[JAPBKNDOGGF(typeof(GNLAPDIIDJD))]
public class GGHCOKGNGOO : ODMPAIDMGCI, IEnumerable<EMNNOKKNGJD>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, GMPBHDKHOML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EMNNOKKNGJD[] NBOEFHBOIKI;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x26E7640", Offset = "0x26E6440", VA = "0x1826E7640", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x26E7200", Offset = "0x26E6000", VA = "0x1826E7200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x26E7200", Offset = "0x26E6000", VA = "0x1826E7200", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "9")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x26E74A0", Offset = "0x26E62A0", VA = "0x1826E74A0", Slot = "10")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x26E7690", Offset = "0x26E6490", VA = "0x1826E7690", Slot = "11")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x26E7210", Offset = "0x26E6010", VA = "0x1826E7210")]
	private EMNNOKKNGJD CPBKPKLOJMD(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x26E7520", Offset = "0x26E6320", VA = "0x1826E7520", Slot = "6")]
	public EMNNOKKNGJD HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26E78F0", Offset = "0x26E66F0", VA = "0x1826E78F0", Slot = "15")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x26E7390", Offset = "0x26E6190", VA = "0x1826E7390", Slot = "7")]
	public IEnumerator<EMNNOKKNGJD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x26E7390", Offset = "0x26E6190", VA = "0x1826E7390", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x221C110", Offset = "0x221AF10", VA = "0x18221C110", Slot = "12")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x26E72F0", Offset = "0x26E60F0", VA = "0x1826E72F0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GGHCOKGNGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x26E7200", Offset = "0x26E6000", VA = "0x1826E7200")]
	[CompilerGenerated]
	private EMNNOKKNGJD ABGGFBEDOBE(int HLAPKJLCEDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(ADBFMIBHACH), new string[] { })]
internal class ADBFMIBHACH : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private ODMPAIDMGCI OLJNNGMFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private GKJELINCFGM EGIBEGMAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private global::IGNGPODGPHC<NOBHGMEMAKH> NKEPAMLDENG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HJJIPEEBILL CHLPOINJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x661A20", Offset = "0x660820", VA = "0x180661A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3750", Offset = "0x2AE2550", VA = "0x182AE3750", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3880", Offset = "0x2AE2680", VA = "0x182AE3880")]
	private void HMAJIKOHHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0950", Offset = "0x1EDF750", VA = "0x181EE0950")]
	public T EPMJKFNKDLP<T>() where T : NOBHGMEMAKH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3680", Offset = "0x2AE2480", VA = "0x182AE3680")]
	public EGNDHFFDDFH GMMNBLBMMPB(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public global::ONBLNDNGCOE<T> GMMNBLBMMPB<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3970", Offset = "0x2AE2770", VA = "0x182AE3970")]
	public EMNNOKKNGJD OMLLLFEDHJG(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0980", Offset = "0x1EDF780", VA = "0x181EE0980")]
	public global::JEBFFIPPOIH<T> OMLLLFEDHJG<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE35B0", Offset = "0x2AE23B0", VA = "0x182AE35B0")]
	public AEFHEEDIBGN EMKLPEKGEPH(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	public global::PLGEJPKBGNG<T> EMKLPEKGEPH<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ADBFMIBHACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EMAOGJDPBOP
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x1DEEF30", Offset = "0x1DEDD30", VA = "0x181DEEF30")]
	public static global::ONBLNDNGCOE<T> GMMNBLBMMPB<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	public static global::JEBFFIPPOIH<T> OMLLLFEDHJG<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	public static global::PLGEJPKBGNG<T> EMKLPEKGEPH<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[EBJHGMECDNA(typeof(OCLNFBFGOOC), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class OCLNFBFGOOC : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private JLCDNMLCNEN[] JEGGLKCLIJM;

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x26FA750", Offset = "0x26F9550", VA = "0x1826FA750", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x26FA630", Offset = "0x26F9430", VA = "0x1826FA630")]
	public void FKLGBDDBJBJ(NMEJDFJAOOA DBGIPPEDJIM, bool MAGLHKOAFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OCLNFBFGOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[EBJHGMECDNA(typeof(LBLGPHMGKFA), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public sealed class LBLGPHMGKFA : FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IHAMDNKGAMG : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
		[DebuggerHidden]
		public IHAMDNKGAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x351E260", Offset = "0x351D060", VA = "0x18351E260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x351DEB0", Offset = "0x351CCB0", VA = "0x18351DEB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x351E2E0", Offset = "0x351D0E0", VA = "0x18351E2E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x351E220", Offset = "0x351D020", VA = "0x18351E220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x351E190", Offset = "0x351CF90", VA = "0x18351E190", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x351E190", Offset = "0x351CF90", VA = "0x18351E190", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private const string NHCIPBOBODG = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Dictionary<SerializableGuid, BFFEIPJHCFH> LAFMBKIIGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<SerializableGuid> DOPICACJAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly Dictionary<SerializableGuid, GameObject> JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private PKDAIMBJGBM MIFANJIIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private DFDDJEKPLDJ ECAHBHLDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private global::IHEHHPCDJON<BFFEIPJHCFH> FLHKKEEAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private GameObject FECBBILGDKA;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x26F4840", Offset = "0x26F3640", VA = "0x1826F4840", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x26F4A70", Offset = "0x26F3870", VA = "0x1826F4A70", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x26F3D00", Offset = "0x26F2B00", VA = "0x1826F3D00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x26F4960", Offset = "0x26F3760", VA = "0x1826F4960")]
	private void KBHLNDOADGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x26F3EA0", Offset = "0x26F2CA0", VA = "0x1826F3EA0")]
	internal void ECILECGFMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x26F3B20", Offset = "0x26F2920", VA = "0x1826F3B20")]
	private void CGKODKCKODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x26F4970", Offset = "0x26F3770", VA = "0x1826F4970")]
	private void KDDGLAAKJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x26F3AD0", Offset = "0x26F28D0", VA = "0x1826F3AD0")]
	[IteratorStateMachine(typeof(IHAMDNKGAMG))]
	private IEnumerable<RRCustomPropTag> ANMBLEBPGJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x26F4DE0", Offset = "0x26F3BE0", VA = "0x1826F4DE0")]
	private void PPFNHMEHPFK(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x26F4CA0", Offset = "0x26F3AA0", VA = "0x1826F4CA0")]
	private void PJHBAIJLMNC(SerializableGuid AJPBBJHOAOB, GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x26F44B0", Offset = "0x26F32B0", VA = "0x1826F44B0")]
	private void GPFDDAHKJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x26F42D0", Offset = "0x26F30D0", VA = "0x1826F42D0")]
	private bool GGBFCLPHGOL(BFFEIPJHCFH CFEEPLDMJBH, Transform ADECAOLBLPJ, out GameObject HFEGMKMMHDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x26F4910", Offset = "0x26F3710", VA = "0x1826F4910")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x26F5260", Offset = "0x26F4060", VA = "0x1826F5260")]
	public LBLGPHMGKFA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public SerializableGuid JBDHDOEDCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x272FA20", Offset = "0x272E820", VA = "0x18272FA20")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[EBJHGMECDNA(typeof(BFIAFBHOKLF), new string[] { })]
public class IOJAIHLOPHA : FDFFINEAOHD, CDAFEBOKDJF, BFIAFBHOKLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private HFHHBKPAPIM ALAACDKEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private COOKMJFPBMI GPLMNCJOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private PropertyEventCallbacksService OBJALHMPDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private LocalPlayerScopeSystem BDDGLOLJIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int EFANBPJHNAH;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EDGBECOMPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x26EDBE0", Offset = "0x26EC9E0", VA = "0x1826EDBE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PMMHBDBEGAM LKMLFJFEBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x26EDAB0", Offset = "0x26EC8B0", VA = "0x1826EDAB0", Slot = "9")]
		get
		{
			return default(PMMHBDBEGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x26ED420", Offset = "0x26EC220", VA = "0x1826ED420", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FEMMDHLANDH JBJKLMKLHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x26ED4F0", Offset = "0x26EC2F0", VA = "0x1826ED4F0", Slot = "11")]
		get
		{
			return default(FEMMDHLANDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x26ED420", Offset = "0x26EC220", VA = "0x1826ED420", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FEMMDHLANDH PNIDHCNENFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x26EE0A0", Offset = "0x26ECEA0", VA = "0x1826EE0A0", Slot = "13")]
		get
		{
			return default(FEMMDHLANDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private uint JBAKEFOCCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x26ED440", Offset = "0x26EC240", VA = "0x1826ED440")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event OJPGCAPGDDC JOAFAFDLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x26ED260", Offset = "0x26EC060", VA = "0x1826ED260", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x26EE160", Offset = "0x26ECF60", VA = "0x1826EE160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x26ED9E0", Offset = "0x26EC7E0", VA = "0x1826ED9E0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x26EDF00", Offset = "0x26ECD00", VA = "0x1826EDF00", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x26ED670", Offset = "0x26EC470", VA = "0x1826ED670", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x26EDD00", Offset = "0x26ECB00", VA = "0x1826EDD00")]
	private void KAPLCEIDAGN(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x26EE300", Offset = "0x26ED100", VA = "0x1826EE300", Slot = "14")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x26EE200", Offset = "0x26ED000", VA = "0x1826EE200", Slot = "15")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x26ED300", Offset = "0x26EC100", VA = "0x1826ED300", Slot = "16")]
	public void CCAIPLKNAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x26ED720", Offset = "0x26EC520", VA = "0x1826ED720", Slot = "17")]
	public void FGMIMAHOJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x26ED530", Offset = "0x26EC330", VA = "0x1826ED530", Slot = "18")]
	public bool DAKLMMCBBPP(PMMHBDBEGAM MCOKHJALNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x26ED740", Offset = "0x26EC540", VA = "0x1826ED740")]
	private void GENGBJFCHLO(PMMHBDBEGAM OKOHPFKFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public IOJAIHLOPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EBJHGMECDNA(typeof(EIANDBIEFDL), new string[] { })]
public class IIKMDNJBDND : FDFFINEAOHD, EIANDBIEFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x26ECEB0", Offset = "0x26EBCB0", VA = "0x1826ECEB0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x26ECF30", Offset = "0x26EBD30", VA = "0x1826ECF30", Slot = "5")]
	public void NBAKEOIBLIK(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2239DE0", Offset = "0x2238BE0", VA = "0x182239DE0")]
	private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public IIKMDNJBDND()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[IFBLAMOEMKH(CMGBDLINHMB.RenderEffects)]
	[EBJHGMECDNA(typeof(MMBKMNPPHBO), new string[] { })]
	public class SelectionService : FDFFINEAOHD, MMBKMNPPHBO
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2731130", Offset = "0x272FF30", VA = "0x182731130", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x27310C0", Offset = "0x272FEC0", VA = "0x1827310C0", Slot = "5")]
		public void EOAAHJFAPLD(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2731050", Offset = "0x272FE50", VA = "0x182731050", Slot = "6")]
		public void ADKFGLBEHNJ(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2239DE0", Offset = "0x2238BE0", VA = "0x182239DE0")]
		private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public SelectionService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Timing" })]
	[EBJHGMECDNA(typeof(WorldSerialization), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class WorldSerialization : FDFFINEAOHD, KFOEJBPDGJE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const string AJJLNOEBKLI = "Timing";

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly CGJHBFGPOOL IMLOALHAGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private FFPEBHHNJFF FJKJAKKFINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private AOAMPDCFJGB BECAEADJGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private SerializationService MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private HDOIPKADCBB EMOEAFOOMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CLDGLLOBFOG MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private DebugWorldsService GPMCBBBGNCC;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private OKJLDANCMCA GDFHIAHBADI
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1BAF660", Offset = "0x1BAE460", VA = "0x181BAF660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2740FF0", Offset = "0x273FDF0", VA = "0x182740FF0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF OIDEMDEBBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2740CE0", Offset = "0x273FAE0", VA = "0x182740CE0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2740BF0", Offset = "0x273F9F0", VA = "0x182740BF0", Slot = "6")]
		public bool DNGEMHOMPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x27407D0", Offset = "0x273F5D0", VA = "0x1827407D0", Slot = "5")]
		public ByteString CCMIFLHPNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2741120", Offset = "0x273FF20", VA = "0x182741120")]
		private void IPCEHEDJHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2741140", Offset = "0x273FF40", VA = "0x182741140")]
		private void JJNPPBKAHKI(BGDMNMCCMEA EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x27412B0", Offset = "0x27400B0", VA = "0x1827412B0")]
		private void LLEPKDOKEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2740D10", Offset = "0x273FB10", VA = "0x182740D10")]
		private void EJCNAFIENPL(FCMCKNEAHLO EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2741210", Offset = "0x2740010", VA = "0x182741210")]
		private BGDMNMCCMEA KJCCHBMKBGB(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(BHBAMFCLELG), new string[] { })]
public class BHBAMFCLELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Dictionary<FEJKANODFOG, string> ALEBIABAGDJ;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC190", Offset = "0x2AEAF90", VA = "0x182AEC190")]
	public GameObject EFFOEIOONDP(FEJKANODFOG GKODFJAPBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC260", Offset = "0x2AEB060", VA = "0x182AEC260")]
	public BHBAMFCLELG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[EBJHGMECDNA(typeof(DDPHBMAAHDP), new string[] { })]
	[LFOIMLBAPLC(typeof(TransformService))]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	public class TransformService : DDPHBMAAHDP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private HFHHBKPAPIM ALAACDKEEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TransformOwnershipPhase NLIPLDKFGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private global::ONBLNDNGCOE<Entity> ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private ObjectEmbodimentService KFHKDGFGKJJ;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x27371C0", Offset = "0x2735FC0", VA = "0x1827371C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private DFDDJEKPLDJ KAAPDHONNOL
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x2736AE0", Offset = "0x27358E0", VA = "0x182736AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2738420", Offset = "0x2737220", VA = "0x182738420", Slot = "33")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x27398A0", Offset = "0x27386A0", VA = "0x1827398A0", Slot = "34")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2737120", Offset = "0x2735F20", VA = "0x182737120", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2738DA0", Offset = "0x2737BA0", VA = "0x182738DA0", Slot = "36")]
		public bool IOHJIAHINHM(Transform BCHADNCHEKP, out PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x27368A0", Offset = "0x27356A0", VA = "0x1827368A0", Slot = "37")]
		public Transform AGDAIJOCIIH(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2737570", Offset = "0x2736370", VA = "0x182737570", Slot = "31")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2738270", Offset = "0x2737070", VA = "0x182738270")]
		private void HENEKLJDAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2737210", Offset = "0x2736010", VA = "0x182737210", Slot = "30")]
		public void ENFIJGJBBJC(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2737660", Offset = "0x2736460", VA = "0x182737660", Slot = "4")]
		public void GDCFJBLAEFP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2738F50", Offset = "0x2737D50", VA = "0x182738F50")]
		public void JEGCOBOINFI(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM, Vector3 GBBNBELINHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x273A860", Offset = "0x2739660", VA = "0x18273A860")]
		public void NGNDAEDIDAG(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2736BA0", Offset = "0x27359A0", VA = "0x182736BA0", Slot = "28")]
		public void CLBIJEMJFKN(Entity GEEFHDFLBEH, out Matrix4x4 BCODGFOGAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2739B20", Offset = "0x2738920", VA = "0x182739B20")]
		public void LNHEHKAHOPF(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2737F90", Offset = "0x2736D90", VA = "0x182737F90")]
		public void GOHBEINHDHC(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2738950", Offset = "0x2737750", VA = "0x182738950")]
		public void HMFCIDKHEJF(Entity GEEFHDFLBEH, in Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x273B230", Offset = "0x273A030", VA = "0x18273B230", Slot = "5")]
		public void PDEOAGACCIA(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x273A660", Offset = "0x2739460", VA = "0x18273A660", Slot = "6")]
		public Vector3 MENJJILCEHP(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2736E60", Offset = "0x2735C60", VA = "0x182736E60", Slot = "7")]
		public void DICBINCKBKB(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2738290", Offset = "0x2737090", VA = "0x182738290", Slot = "8")]
		public Quaternion HFMCOFNJPOM(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2737360", Offset = "0x2736160", VA = "0x182737360", Slot = "13")]
		public void FJBCKGJLCCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2736790", Offset = "0x2735590", VA = "0x182736790", Slot = "12")]
		public Vector3 ADKCLDGGKHN(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2736960", Offset = "0x2735760", VA = "0x182736960")]
		public void CAPNDLGCLCP(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2738380", Offset = "0x2737180", VA = "0x182738380")]
		private Vector3 HFOHMELCAED(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2737EF0", Offset = "0x2736CF0", VA = "0x182737EF0", Slot = "15")]
		public float GLBJOAHKOIN(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2737460", Offset = "0x2736260", VA = "0x182737460", Slot = "14")]
		public void FLDLJJGDOIN(Entity GEEFHDFLBEH, float IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2739150", Offset = "0x2737F50", VA = "0x182739150")]
		private float KAGCJCCHFLP(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x273A970", Offset = "0x2739770", VA = "0x18273A970")]
		public void NLIANMKJJCD(Entity GEEFHDFLBEH, float BIOIOGONEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2736A00", Offset = "0x2735800", VA = "0x182736A00", Slot = "17")]
		public Vector3 CCONMBLCOJG(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2739020", Offset = "0x2737E20", VA = "0x182739020", Slot = "16")]
		public void JOAFHOOPBPB(Entity GEEFHDFLBEH, Vector3 GBIIEKALBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x273B100", Offset = "0x2739F00", VA = "0x18273B100")]
		private Vector3 OOIEPNCLMGM(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x273B350", Offset = "0x273A150", VA = "0x18273B350")]
		public void PMEJAEPCJDL(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x27380C0", Offset = "0x2736EC0", VA = "0x1827380C0")]
		[Conditional("DEBUG_BUILD")]
		private void HBGIOGJMJCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2738C00", Offset = "0x2737A00", VA = "0x182738C00", Slot = "9")]
		public void IGIMCPAJODD(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2736C90", Offset = "0x2735A90", VA = "0x182736C90", Slot = "10")]
		public void DFMLGPGOEDO(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2736660", Offset = "0x2735460", VA = "0x182736660", Slot = "11")]
		public void ABEECJHILAL(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2737850", Offset = "0x2736650", VA = "0x182737850", Slot = "38")]
		public void GEPKONEEJLH(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2736F60", Offset = "0x2735D60", VA = "0x182736F60")]
		public void DNJDKAOKGCC(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x273AAE0", Offset = "0x27398E0", VA = "0x18273AAE0", Slot = "18")]
		public void OFKNBPADOEM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2736BB0", Offset = "0x27359B0", VA = "0x182736BB0", Slot = "19")]
		public Vector3 CLFJCLPAKBH(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x273AD10", Offset = "0x2739B10", VA = "0x18273AD10", Slot = "20")]
		public void OHEACAODJHG(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2738B10", Offset = "0x2737910", VA = "0x182738B10", Slot = "21")]
		public Quaternion HPOEHICNFDK(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2739EE0", Offset = "0x2738CE0", VA = "0x182739EE0", Slot = "23")]
		public void LPJGJCPGHDM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x273A770", Offset = "0x2739570", VA = "0x18273A770", Slot = "22")]
		public Vector3 NDKBPDMGFLI(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x273A340", Offset = "0x2739140", VA = "0x18273A340", Slot = "24")]
		public void MCOFOPEKKHL(Entity GEEFHDFLBEH, float NOGNCKMINCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2737A70", Offset = "0x2736870", VA = "0x182737A70", Slot = "25")]
		public float GIPJABDAFPD(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2739430", Offset = "0x2738230", VA = "0x182739430", Slot = "26")]
		public void KGIMIHGFFKJ(Entity GEEFHDFLBEH, Vector3 HLJBHGNEKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x27399E0", Offset = "0x27387E0", VA = "0x1827399E0", Slot = "27")]
		public Vector3 LHBMJKPGAEL(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2738520", Offset = "0x2737320", VA = "0x182738520", Slot = "32")]
		public void HLDLPBDPLCI(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2739370", Offset = "0x2738170", VA = "0x182739370")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2739240", Offset = "0x2738040", VA = "0x182739240")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2736DE0", Offset = "0x2735BE0", VA = "0x182736DE0")]
		private CBEDOBDLKDB DFMLGPGOEDO(Entity GEEFHDFLBEH)
		{
			return default(CBEDOBDLKDB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x273AA00", Offset = "0x2739800", VA = "0x18273AA00")]
		private bool OEKEPNLPDKP(Entity GEEFHDFLBEH, out Entity ADECAOLBLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x273AF50", Offset = "0x2739D50", VA = "0x18273AF50")]
		private void OHEIMGGEINO(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2737B90", Offset = "0x2736990", VA = "0x182737B90")]
		public void GJOIDGHOKGE(Entity GEEFHDFLBEH, out Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x27399D0", Offset = "0x27387D0", VA = "0x1827399D0", Slot = "29")]
		private void KJADEHNJKGD(Entity GEEFHDFLBEH, in Matrix4x4 BCODGFOGAPK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(KPOGCKFKBHN), new string[] { })]
public class KPOGCKFKBHN
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KPAELHCBEAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly KPOGCKFKBHN ADECAOLBLPJ;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3520E30", Offset = "0x351FC30", VA = "0x183520E30")]
		public KPAELHCBEAM(KPOGCKFKBHN ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3520E10", Offset = "0x351FC10", VA = "0x183520E10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int KCHJKGPLKKO;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LEONOJPKKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE92050", Offset = "0xE90E50", VA = "0x180E92050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action DMGKGMNLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x26F3490", Offset = "0x26F2290", VA = "0x1826F3490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x26F33F0", Offset = "0x26F21F0", VA = "0x1826F33F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x26F33C0", Offset = "0x26F21C0", VA = "0x1826F33C0")]
	public KPAELHCBEAM EMJANLIPHLL()
	{
		return default(KPAELHCBEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x16A9020", Offset = "0x16A7E20", VA = "0x1816A9020")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x26F3530", Offset = "0x26F2330", VA = "0x1826F3530")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public KPOGCKFKBHN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[EBJHGMECDNA(typeof(EnableComponentSystemsInScope), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	[JAPBKNDOGGF(typeof(EHIDJEIAFME))]
	public class EnableComponentSystemsInScope : FDFFINEAOHD, NHJNEKFPLIJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private World HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private NativeArray<int> DAJONPKEEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private NativeArray<int> NDAADHJDJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int JKGBPKEJAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private EEJHBIOBFFI MGGPFLNEAJJ;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC250", Offset = "0x2AFB050", VA = "0x182AFC250", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEB0", Offset = "0x2AFACB0", VA = "0x182AFBEB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC3B0", Offset = "0x2AFB1B0", VA = "0x182AFC3B0", Slot = "5")]
		public void JOAFAFDLHBM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC000", Offset = "0x2AFAE00", VA = "0x182AFC000")]
		public void FDGIICJJLJE(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC8E0", Offset = "0x2AFB6E0", VA = "0x182AFC8E0")]
		private void LLAMLFGGEPA(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA30", Offset = "0x2AFB830", VA = "0x182AFCA30")]
		private void LMKNIIFIMNG(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF40", Offset = "0x2AFAD40", VA = "0x182AFBF40")]
		private void EPINLCBCGAP(int FOACNEHDHLI, int CBNJCJLIEMJ, bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBA0", Offset = "0x2AFB9A0", VA = "0x182AFCBA0")]
		private int PDBNPGHGLHE(EEJHBIOBFFI PBOJAOCFJPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC420", Offset = "0x2AFB220", VA = "0x182AFC420")]
		private bool KICPHIFHCNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC170", Offset = "0x2AFAF70", VA = "0x182AFC170")]
		private void HDGEFIDHCGK(NativeArray<int> PNDAKPENJKM, NativeArray<int> LGLGGCHFNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE70", Offset = "0x2AFAC70", VA = "0x182AFBE70")]
		private void CPBEAMDOLJN(NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC300", Offset = "0x2AFB100", VA = "0x182AFC300")]
		private void IECNCFOJGPG(NativeArray<int> LGLGGCHFNDI, NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC10", Offset = "0x2AFBA10", VA = "0x182AFCC10")]
		public EnableComponentSystemsInScope()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[EBJHGMECDNA(typeof(ANEHAPKAFCD), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class ANEHAPKAFCD : HECIIBPMLDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class HLNEBDOHNJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public FFPEBHHNJFF services;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HLNEBDOHNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x351DBB0", Offset = "0x351C9B0", VA = "0x18351DBB0")]
		internal void <InitPhase>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x351DC10", Offset = "0x351CA10", VA = "0x18351DC10")]
		internal void <InitPhase>b__2(CDAFEBOKDJF svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private EHIDJEIAFME CANCHCAFIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7C9140", Offset = "0x7C7F40", VA = "0x1807C9140", Slot = "4")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6D70", Offset = "0x2AE5B70", VA = "0x182AE6D70", Slot = "5")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6C40", Offset = "0x2AE5A40", VA = "0x182AE6C40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ANEHAPKAFCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DefaultMember("Item")]
public class NCKDDKEMJGP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public DynamicBuffer<From> CLABEIKAHOI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	public NCKDDKEMJGP(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class PGBBKILBNAD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public List<From> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3056260", Offset = "0x3055060", VA = "0x183056260", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x30562C0", Offset = "0x30550C0", VA = "0x1830562C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3056230", Offset = "0x3055030", VA = "0x183056230", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F3E0", VA = "0x1806A05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x30561A0", Offset = "0x3054FA0", VA = "0x1830561A0")]
	public PGBBKILBNAD(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3055DF0", Offset = "0x3054BF0", VA = "0x183055DF0", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x262ED90", Offset = "0x262DB90", VA = "0x18262ED90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3055E50", Offset = "0x3054C50", VA = "0x183055E50", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3055EB0", Offset = "0x3054CB0", VA = "0x183055EB0", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3055FC0", Offset = "0x3054DC0", VA = "0x183055FC0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3056030", Offset = "0x3054E30", VA = "0x183056030", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3056090", Offset = "0x3054E90", VA = "0x183056090", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x3056140", Offset = "0x3054F40", VA = "0x183056140", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x3056110", Offset = "0x3054F10", VA = "0x183056110", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x25B6BD0", Offset = "0x25B59D0", VA = "0x1825B6BD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public class KNDIDAPDONF<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeArray<From> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3075390", Offset = "0x3074190", VA = "0x183075390", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x30753E0", Offset = "0x30741E0", VA = "0x1830753E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3075350", Offset = "0x3074150", VA = "0x183075350", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x27AF680", Offset = "0x27AE480", VA = "0x1827AF680")]
	public KNDIDAPDONF(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3074F60", Offset = "0x3073D60", VA = "0x183074F60", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3074FA0", Offset = "0x3073DA0", VA = "0x183074FA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3074FE0", Offset = "0x3073DE0", VA = "0x183074FE0", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x30750A0", Offset = "0x3073EA0", VA = "0x1830750A0", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3075160", Offset = "0x3073F60", VA = "0x183075160", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x3075220", Offset = "0x3074020", VA = "0x183075220", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3075290", Offset = "0x3074090", VA = "0x183075290", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3075310", Offset = "0x3074110", VA = "0x183075310", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x30752D0", Offset = "0x30740D0", VA = "0x1830752D0", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1D320A0", Offset = "0x1D30EA0", VA = "0x181D320A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DefaultMember("Item")]
public class LLBGABNCGEJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeList<From> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	public LLBGABNCGEJ(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class NBEPJKAFHML
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public const string MNAGNEHNCEE = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public const string MPECDOEEIGK = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public const string MMGGLJBDGDG = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public const string CFIMOCOJMOE = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public const string BDLELEHKMNJ = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public const string NJHPMBPGDDO = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public const string LDNLNLAAHDN = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class IOGKAJICPOH
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class IJICCCLBHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public FFPEBHHNJFF services;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public IJICCCLBHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x351E9C0", Offset = "0x351D7C0", VA = "0x18351E9C0")]
		internal void <InitServices>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x351EA20", Offset = "0x351D820", VA = "0x18351EA20")]
		internal void <InitServices>b__2(CDAFEBOKDJF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x26ED010", Offset = "0x26EBE10", VA = "0x1826ED010")]
	public static void JIBLLCBPHAA(this PGLNEDJDCBK HADAJAKADAH, FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x22B5BE0", Offset = "0x22B49E0", VA = "0x1822B5BE0")]
	public static void AEFBIIJCLFD<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x22B6220", Offset = "0x22B5020", VA = "0x1822B6220")]
	public static void MJOOJNAOFOC<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x22B5C50", Offset = "0x22B4A50", VA = "0x1822B5C50")]
	public static void BHGNGPPJFFM<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x22B5E00", Offset = "0x22B4C00", VA = "0x1822B5E00")]
	public static void EOBOHMBELMH<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x22B5FB0", Offset = "0x22B4DB0", VA = "0x1822B5FB0")]
	public static void HNBFGOPBLKN<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x22B6160", Offset = "0x22B4F60", VA = "0x1822B6160")]
	private static void IDDAEDDBEDN<T>(object CHJMLFMLCJF, Action<T> MBOOMOIFJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BKHFLJJOFIO
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class CIJOCBAKOBP
{
	[Cpp2IlInjected.Token(Token = "0x6000457")]
	public static bool HDCJELIGLFP<T>(ref T BMPDKJEHGIN, ref T BMMLDIMMAAK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class AKFJIKPOECJ
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class ACKFBCCPEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ACKFBCCPEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5DD0", Offset = "0x2AE4BD0", VA = "0x182AE5DD0")]
	public static string NOGDNDDIJIP(Transform BCHADNCHEKP, Transform MCOKHJALNGG)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[IFBLAMOEMKH(CMGBDLINHMB.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x27333E0", Offset = "0x27321E0", VA = "0x1827333E0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2733B30", Offset = "0x2732930", VA = "0x182733B30")]
		public static void MJAGDEDIGFF(this AJDCMAAKGND FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x27332D0", Offset = "0x27320D0", VA = "0x1827332D0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, [Optional] string[] NHEECPNNGOE, [Optional] string[] BCGBBPKGNDB, [Optional] string[] ELPAIOJMBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2733A80", Offset = "0x2732880", VA = "0x182733A80")]
		public static void HIILFCBENND(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x27339D0", Offset = "0x27327D0", VA = "0x1827339D0")]
		public static void EIENEIBFFPP(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x27337D0", Offset = "0x27325D0", VA = "0x1827337D0")]
		private static string[] DOBIMILCEFD(HNBJONKGAEL IDKBHBKJHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2733610", Offset = "0x2732410", VA = "0x182733610")]
		private static bool BLKLDHBOHAG(HNBJONKGAEL IDKBHBKJHPJ, out string[] BCCBKDAADNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820")]
		private static bool LEEDEPDGAPN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class MLBHKFFBLLH : LBLNCNBBMIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MethodInfo GOMGLHMMBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Type[] KMLLOCJHKPB;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7960", Offset = "0x26F6760", VA = "0x1826F7960")]
	public MLBHKFFBLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EHLKLCIKDHM();

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26F7770", Offset = "0x26F6570", VA = "0x1826F7770")]
	public MethodInfo EPIONIGHEEB(Action CGKOOFFNHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x26F77B0", Offset = "0x26F65B0", VA = "0x1826F77B0", Slot = "4")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class PKCAMOGFFFG : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private enum NBFCGEIILFL
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2726C50", Offset = "0x2725A50", VA = "0x182726C50", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BJCNAIMNHPD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2726CE0", Offset = "0x2725AE0", VA = "0x182726CE0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x26F5B40", Offset = "0x26F4940", VA = "0x1826F5B40")]
	protected PKCAMOGFFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class NDKHFJCHDBL : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x26F8E00", Offset = "0x26F7C00", VA = "0x1826F8E00", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DCHPHCIDLGC<T>() where T : KCJNPCKFNOM;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x26F8E90", Offset = "0x26F7C90", VA = "0x1826F8E90")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x26F5B40", Offset = "0x26F4940", VA = "0x1826F5B40")]
	protected NDKHFJCHDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class LICOIIFNCGA : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x26F5A20", Offset = "0x26F4820", VA = "0x1826F5A20", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EJLHODOHNCH<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x26F5AB0", Offset = "0x26F48B0", VA = "0x1826F5AB0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5B40", Offset = "0x26F4940", VA = "0x1826F5B40")]
	protected LICOIIFNCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[EBJHGMECDNA(typeof(EEDGKMIDAFH), new string[] { })]
public class NIDJLFGOJGK : EEDGKMIDAFH, HECIIBPMLDM, NHJNEKFPLIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private FFPEBHHNJFF FJKJAKKFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private AOAMPDCFJGB BECAEADJGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private DDMIOFGHMGI BHLMCOMCAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private HFHHBKPAPIM ALAACDKEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private DDPHBMAAHDP JKOOEKEEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private NEKBEAHJEHF MIFANJIIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private ELFIPEDOAPI ABCMOBMIIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GKHHEJLDBHG GPMKOKBNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private BPHIPABMBKD KPHHOAEPKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NKGHFOCFECH BALPJAJPMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private BFIAFBHOKLF KKJNDEPMACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private LBPAJLMGMFA OPAAEBMKPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private DOFEFFJAEBG GIINIEFOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private EIANDBIEFDL EFHJAGIMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private MMBKMNPPHBO BPCACFGHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private LIACDBEGOKA OPGPMBODILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FFPEBHHNJFF AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EHIDJEIAFME NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public AOAMPDCFJGB KHNOEBOIBMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DDMIOFGHMGI HODIGNDEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CBIPFLGDJEF OFOEMMHFELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HFHHBKPAPIM HCLFBFBADHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x67EA40", Offset = "0x67D840", VA = "0x18067EA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DDPHBMAAHDP LLJLHOBLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6570F0", Offset = "0x655EF0", VA = "0x1806570F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NEKBEAHJEHF ENPNLKBHPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6570A0", Offset = "0x655EA0", VA = "0x1806570A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ELFIPEDOAPI NFMMDNGOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GKHHEJLDBHG PFJBMLEAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x655EB0", VA = "0x1806570B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ODMPAIDMGCI LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BPHIPABMBKD ACECADJDOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NKGHFOCFECH IJPKIJCIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x657050", Offset = "0x655E50", VA = "0x180657050", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BFIAFBHOKLF GMAGOKAFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6E78E0", Offset = "0x6E66E0", VA = "0x1806E78E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LBPAJLMGMFA CPAHMDPHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x780680", Offset = "0x77F480", VA = "0x180780680", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DOFEFFJAEBG IGCBBCBKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x705590", Offset = "0x704390", VA = "0x180705590", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EIANDBIEFDL MEPAMLDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x70BBF0", Offset = "0x70A9F0", VA = "0x18070BBF0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MMBKMNPPHBO JELINFEJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x657060", Offset = "0x655E60", VA = "0x180657060", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LIACDBEGOKA HOBOELBHFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x657070", Offset = "0x655E70", VA = "0x180657070", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6674E0", Offset = "0x6662E0", VA = "0x1806674E0", Slot = "21")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x26F8FB0", Offset = "0x26F7DB0", VA = "0x1826F8FB0", Slot = "22")]
	public void KEACOMCKNJG(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x26F8F80", Offset = "0x26F7D80", VA = "0x1826F8F80", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x26F8F90", Offset = "0x26F7D90", VA = "0x1826F8F90", Slot = "23")]
	public void JOAFAFDLHBM(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public NIDJLFGOJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DefaultMember("Item")]
public class PPONMINLDEP : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JEEFNHOFEFA : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PPONMINLDEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x655EE0", VA = "0x1806570E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x351F060", Offset = "0x351DE60", VA = "0x18351F060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
		[DebuggerHidden]
		public JEEFNHOFEFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x351EEB0", Offset = "0x351DCB0", VA = "0x18351EEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x351F020", Offset = "0x351DE20", VA = "0x18351F020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	protected const ulong DEMMEADCPJL = 1uL;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	protected const ulong MJBKKMOHDOD = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	protected const int KGOEHDPKCJP = 8;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	protected const int NNDEKIHAIIL = 6;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public const int NLLLGGCLIPE = 64;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	protected const int OKOEIFKEDOH = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly List<ulong> OAMKHBKCHHA;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x745C70", Offset = "0x744A70", VA = "0x180745C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int OFOJBFDCABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x65C630", Offset = "0x65B430", VA = "0x18065C630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6B06A0", Offset = "0x6AF4A0", VA = "0x1806B06A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2727940", Offset = "0x2726740", VA = "0x182727940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2727090", Offset = "0x2725E90", VA = "0x182727090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2727D40", Offset = "0x2726B40", VA = "0x182727D40")]
	public PPONMINLDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2727DC0", Offset = "0x2726BC0", VA = "0x182727DC0")]
	public PPONMINLDEP(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2726FB0", Offset = "0x2725DB0", VA = "0x182726FB0")]
	public bool EDEOOALDLJB(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x27279E0", Offset = "0x27267E0", VA = "0x1827279E0")]
	public bool KGJNCFBHIBI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2727BC0", Offset = "0x27269C0", VA = "0x182727BC0")]
	public bool OHAHAJGPFNC(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2727D30", Offset = "0x2726B30", VA = "0x182727D30")]
	public bool PPICPACFBLI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2727790", Offset = "0x2726590", VA = "0x182727790")]
	public void JGFIDBHEAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2727AD0", Offset = "0x27268D0", VA = "0x182727AD0")]
	public void OAHEOEBHHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2727C40", Offset = "0x2726A40", VA = "0x182727C40")]
	public void PIGMJENILDA(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2727690", Offset = "0x2726490", VA = "0x182727690")]
	public void IIOELKEIHEG(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2727400", Offset = "0x2726200", VA = "0x182727400")]
	public bool FLEBLELMNAN(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2727820", Offset = "0x2726620", VA = "0x182727820")]
	public void KDOMIKFMFKI(int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2727240", Offset = "0x2726040", VA = "0x182727240")]
	public void EPIIJGJJGPF(int DOOFIFHOCKH, int JBFIBBGJOJJ, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2727570", Offset = "0x2726370", VA = "0x182727570")]
	public int HEFJCCLOLGO(int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2727500", Offset = "0x2726300", VA = "0x182727500")]
	public int HEFJCCLOLGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2727640", Offset = "0x2726440", VA = "0x182727640")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2727490", Offset = "0x2726290", VA = "0x182727490", Slot = "4")]
	[IteratorStateMachine(typeof(JEEFNHOFEFA))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2727490", Offset = "0x2726290", VA = "0x182727490", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NACIFLLMCPL<T> : global::DEKKGELEEDA<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	protected global::ADPPKKLLOAG<T> NHGODJCEDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	protected global::AEIJCHDEEMK<T> HEEJCHPDFDL;

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x144DDD0", Offset = "0x144CBD0", VA = "0x18144DDD0")]
	public NACIFLLMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1E84070", Offset = "0x1E82E70", VA = "0x181E84070")]
	public NACIFLLMCPL(global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1E83D30", Offset = "0x1E82B30", VA = "0x181E83D30", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1E83980", Offset = "0x1E82780", VA = "0x181E83980", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class CLBPJFGNMHN
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F801E0", Offset = "0x1F7EFE0", VA = "0x181F801E0")]
	public static JLCDNMLCNEN PJHBAIJLMNC<T>(this KJJHEOCLACN GMKKBMEMHOP, global::NBBJGEJPPKL<T> BEMAPDNKPAD, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
		return default(JLCDNMLCNEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class DJACPONAHMA<T> : global::NACIFLLMCPL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x45590A0", Offset = "0x4557EA0", VA = "0x1845590A0")]
	public DJACPONAHMA(T OCIAEJCLHLN, T GEOHKIDILGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public sealed class NCLKMOCKEDG<T> : global::DEKKGELEEDA<T> where T : struct, KCJNPCKFNOM
{
	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FD40", Offset = "0x2C9EB40", VA = "0x182C9FD40", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FCE0", Offset = "0x2C9EAE0", VA = "0x182C9FCE0", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x213C880", Offset = "0x213B680", VA = "0x18213C880")]
	public NCLKMOCKEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public abstract class GBBOPLOPEEF : PPMKAONFAIG
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract Type HCCKNPIKABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO, in ECNLJAAGJFG IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, in MJADMLMEADH IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ICJPMMDCBBM(LIEODINBDBP IONGKOPBOLO, JIOPCPMKLHK EMCMEEJENIP, [Optional] object NAHJDDBGMOA);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	protected GBBOPLOPEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class DEKKGELEEDA<T> : GBBOPLOPEEF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override Type HCCKNPIKABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x25B83F0", Offset = "0x25B71F0", VA = "0x1825B83F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x25B8E20", Offset = "0x25B7C20", VA = "0x1825B8E20", Slot = "8")]
	public override void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO, in ECNLJAAGJFG MCOKHJALNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x25B77D0", Offset = "0x25B65D0", VA = "0x1825B77D0", Slot = "9")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, in MJADMLMEADH IKPEGPHMIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x25B9780", Offset = "0x25B8580", VA = "0x1825B9780", Slot = "10")]
	public override void ICJPMMDCBBM(LIEODINBDBP IONGKOPBOLO, JIOPCPMKLHK EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1985630", Offset = "0x1984430", VA = "0x181985630")]
	protected DEKKGELEEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class FBGKEJBNGOK
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class HOOIBEGJHHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class IEPGJEEIGBK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
			public IEPGJEEIGBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x166FF10", Offset = "0x166ED10", VA = "0x18166FF10")]
			internal void <RegisterFixedString>b__0(LIEODINBDBP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x1670180", Offset = "0x166EF80", VA = "0x181670180")]
			internal T <RegisterFixedString>b__1(LIEODINBDBP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x351DDF0", Offset = "0x351CBF0", VA = "0x18351DDF0")]
		public static void FKHONKNHOOA(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x23D4430", Offset = "0x23D3230", VA = "0x1823D4430")]
		private static void NOIBEAIHDLK<T>(CHKDLDDGMPK NIGMPMDPOOJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x23D43A0", Offset = "0x23D31A0", VA = "0x1823D43A0")]
		private static void DCJPAFAMHDK<T>(LIEODINBDBP JOLHNMOCKDJ, T HFMHCLGICNJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x23D3D50", Offset = "0x23D2B50", VA = "0x1823D3D50")]
		private static T BJAEKAJKDLH<T>(LIEODINBDBP JOLHNMOCKDJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public HOOIBEGJHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class LODMJJFLPCO : PKCAMOGFFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CHKDLDDGMPK NIGMPMDPOOJ;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x23D5500", Offset = "0x23D4300", VA = "0x1823D5500", Slot = "6")]
		public override void BJCNAIMNHPD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x3522790", Offset = "0x3521590", VA = "0x183522790")]
		public static void JFALGCMELEE(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x3522820", Offset = "0x3521620", VA = "0x183522820")]
		public LODMJJFLPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE8C0", Offset = "0x2AFD6C0", VA = "0x182AFE8C0")]
	public static void CNHPCJEGFKL(CHKDLDDGMPK NIGMPMDPOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B18FF0", Offset = "0x2B17DF0", VA = "0x182B18FF0")]
	public static void CNAHKNDDACG<T>(CHKDLDDGMPK NIGMPMDPOOJ, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B19080", Offset = "0x2B17E80", VA = "0x182B19080")]
	public static void FAGHPJDNCAK<T>(CHKDLDDGMPK CFPIMFIOLEF) where T : struct, KCJNPCKFNOM
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public interface CHKDLDDGMPK : global::OBFHJMKGHOD<CHKDLDDGMPK>
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJHBAIJLMNC(Type NKICFHCCMMH, PPMKAONFAIG CFPIMFIOLEF);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMEGLCAMII(Type NKICFHCCMMH, out PPMKAONFAIG CFPIMFIOLEF);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DPPLDJKKNOC
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8D40", Offset = "0x2AF7B40", VA = "0x182AF8D40")]
	public static void PJHBAIJLMNC(this CHKDLDDGMPK FPFLBEGAJEB, PPMKAONFAIG CFPIMFIOLEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[EBJHGMECDNA(typeof(KJJHEOCLACN), new string[] { })]
public sealed class GMOBIMICHHB : KJJHEOCLACN, global::OBFHJMKGHOD<KJJHEOCLACN>, DFDLCPDHDGP, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly Dictionary<JLCDNMLCNEN, PPMKAONFAIG> NIGMPMDPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private CHKDLDDGMPK BIFJGDEEJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool ELCPFKDMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F3E0", VA = "0x1806A05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x26E8A30", Offset = "0x26E7830", VA = "0x1826E8A30")]
	public GMOBIMICHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x26E8970", Offset = "0x26E7770", VA = "0x1826E8970")]
	public GMOBIMICHHB(Dictionary<JLCDNMLCNEN, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x26E8300", Offset = "0x26E7100", VA = "0x1826E8300", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x26E8230", Offset = "0x26E7030", VA = "0x1826E8230", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x26E82B0", Offset = "0x26E70B0", VA = "0x1826E82B0", Slot = "9")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x26E88A0", Offset = "0x26E76A0", VA = "0x1826E88A0", Slot = "4")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x26E8730", Offset = "0x26E7530", VA = "0x1826E8730", Slot = "5")]
	public void PJHBAIJLMNC(JLCDNMLCNEN FCDKMJOKGIE, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x26E8360", Offset = "0x26E7160", VA = "0x1826E8360")]
	[Conditional("DEBUG_BUILD")]
	private void KMADGIFDFIH(JLCDNMLCNEN FCDKMJOKGIE, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x26E84A0", Offset = "0x26E72A0", VA = "0x1826E84A0", Slot = "6")]
	public bool KNMEGLCAMII(JLCDNMLCNEN FCDKMJOKGIE, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x26E8650", Offset = "0x26E7450", VA = "0x1826E8650", Slot = "10")]
	public KJJHEOCLACN NFHKLFECJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[EBJHGMECDNA(typeof(CHKDLDDGMPK), new string[] { })]
public sealed class FLHLECHEOIJ : DFDLCPDHDGP, CHKDLDDGMPK, global::OBFHJMKGHOD<CHKDLDDGMPK>
{
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Dictionary<Type, PPMKAONFAIG> NIGMPMDPOOJ;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool ELCPFKDMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x65B260", Offset = "0x65A060", VA = "0x18065B260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x776830", Offset = "0x775630", VA = "0x180776830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x26E5F60", Offset = "0x26E4D60", VA = "0x1826E5F60")]
	public FLHLECHEOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26E5EA0", Offset = "0x26E4CA0", VA = "0x1826E5EA0")]
	public FLHLECHEOIJ(Dictionary<Type, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26E5B20", Offset = "0x26E4920", VA = "0x1826E5B20", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26E5D40", Offset = "0x26E4B40", VA = "0x1826E5D40", Slot = "5")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26E5B80", Offset = "0x26E4980", VA = "0x1826E5B80", Slot = "6")]
	public bool KNMEGLCAMII(Type NKICFHCCMMH, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26E5C60", Offset = "0x26E4A60", VA = "0x1826E5C60", Slot = "7")]
	public CHKDLDDGMPK NFHKLFECJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[EBJHGMECDNA(typeof(ANCDIMIFACP), new string[] { })]
internal sealed class IHNICGPMMOD : ANCDIMIFACP, DFDLCPDHDGP, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private readonly Dictionary<JLCDNMLCNEN, DOGACPAEELJ> LJPDJMMJGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x26ECD00", Offset = "0x26EBB00", VA = "0x1826ECD00", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x26ECCA0", Offset = "0x26EBAA0", VA = "0x1826ECCA0", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x26ECDC0", Offset = "0x26EBBC0", VA = "0x1826ECDC0", Slot = "4")]
	public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN, DOGACPAEELJ OEINDPCLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x26ECD50", Offset = "0x26EBB50", VA = "0x1826ECD50", Slot = "5")]
	public bool NKPEADBAMEJ(JLCDNMLCNEN ABEODFEGJBP, out DOGACPAEELJ OEINDPCLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x26ECB10", Offset = "0x26EB910", VA = "0x1826ECB10")]
	[Conditional("DEBUG_BUILD")]
	private void HBPBOKBOOKK(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x26ECE30", Offset = "0x26EBC30", VA = "0x1826ECE30")]
	public IHNICGPMMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[EBJHGMECDNA(typeof(PCFOCDMILKJ), new string[] { })]
[JAPBKNDOGGF(typeof(GKJELINCFGM))]
internal sealed class FHIOIFIIDCJ : PCFOCDMILKJ, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private readonly PPONMINLDEP JFPMOMMEDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private readonly Dictionary<NMEJDFJAOOA, int> OCDJPBMHOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private readonly Stack<int> NFMFOGHBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private int BBJPEJLDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x26E4360", Offset = "0x26E3160", VA = "0x1826E4360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool DEFKNPLGKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6B19C0", Offset = "0x6B07C0", VA = "0x1806B19C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7BD500", Offset = "0x7BC300", VA = "0x1807BD500", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x26E3DB0", Offset = "0x26E2BB0", VA = "0x1826E3DB0", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x26E3F60", Offset = "0x26E2D60", VA = "0x1826E3F60", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x26E4090", Offset = "0x26E2E90", VA = "0x1826E4090", Slot = "8")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x26E3EC0", Offset = "0x26E2CC0", VA = "0x1826E3EC0")]
	private void EHKNKBCLFJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x26E3FE0", Offset = "0x26E2DE0", VA = "0x1826E3FE0", Slot = "4")]
	public bool JKMNJDNCGFM(NMEJDFJAOOA DBGIPPEDJIM, JLCDNMLCNEN HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x26E4140", Offset = "0x26E2F40", VA = "0x1826E4140", Slot = "5")]
	public void NCKAKJEMCHK(NMEJDFJAOOA DBGIPPEDJIM, Span<JLCDNMLCNEN> GMKKBMEMHOP, bool IFINFNLHHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x26E3DB0", Offset = "0x26E2BB0", VA = "0x1826E3DB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x26E43B0", Offset = "0x26E31B0", VA = "0x1826E43B0")]
	public FHIOIFIIDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class DIFANBBCPAA
{
	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6240", Offset = "0x2AF5040", VA = "0x182AF6240")]
	public static void ADGGKAPKBFK(this LIEODINBDBP IONGKOPBOLO, ReadOnlyMemory<byte> HFNFJCAIOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2362930", Offset = "0x2361730", VA = "0x182362930")]
	public static void FJGIJIFMICL<T>(this LIEODINBDBP IONGKOPBOLO, in T IGJPNMBCJPK) where T : struct, KCJNPCKFNOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2362A60", Offset = "0x2361860", VA = "0x182362A60")]
	public static T INFOCGEPMKK<T>(this LIEODINBDBP IONGKOPBOLO) where T : struct, KCJNPCKFNOM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2AF62C0", Offset = "0x2AF50C0", VA = "0x182AF62C0")]
	public static void FJGIJIFMICL(this LIEODINBDBP IONGKOPBOLO, AHHBCIFGLKD MKJJIEOPNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2AF62F0", Offset = "0x2AF50F0", VA = "0x182AF62F0")]
	public static AHHBCIFGLKD IHHICDGMLOH(this LIEODINBDBP IONGKOPBOLO)
	{
		return default(AHHBCIFGLKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6440", Offset = "0x2AF5240", VA = "0x182AF6440")]
	public static void PDMBADLPGPD(this LIEODINBDBP MLMFBHHJDGG, uint KDILLIFJBAB, bool IKEEKKBIKHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6320", Offset = "0x2AF5120", VA = "0x182AF6320")]
	public static uint IJJMPDCGMOF(this LIEODINBDBP ANKKMEDLEHC, bool IKEEKKBIKHE = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class JDFCCEAHJKH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MCMDIKCOCPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public MCMDIKCOCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2D07A60", Offset = "0x2D06860", VA = "0x182D07A60")]
		internal void <GetByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2D07AD0", Offset = "0x2D068D0", VA = "0x182D07AD0")]
		internal T <GetByteEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class PODBDOJNCKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public PODBDOJNCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x35080C0", Offset = "0x3506EC0", VA = "0x1835080C0")]
		internal void <GetSByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x3508130", Offset = "0x3506F30", VA = "0x183508130")]
		internal T <GetSByteEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class DPJDMLFJDBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public DPJDMLFJDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x34B6ED0", Offset = "0x34B5CD0", VA = "0x1834B6ED0")]
		internal void <GetShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x34B6F40", Offset = "0x34B5D40", VA = "0x1834B6F40")]
		internal T <GetShortEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DDDLHDLIJED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public DDDLHDLIJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x25B5A30", Offset = "0x25B4830", VA = "0x1825B5A30")]
		internal void <GetUShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x25B5AA0", Offset = "0x25B48A0", VA = "0x1825B5AA0")]
		internal T <GetUShortEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MDNDOBPABLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public MDNDOBPABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AE90", Offset = "0x2D09C90", VA = "0x182D0AE90")]
		internal void <GetIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AEF0", Offset = "0x2D09CF0", VA = "0x182D0AEF0")]
		internal T <GetIntEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EKJHNAHJOMP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public EKJHNAHJOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x1995780", Offset = "0x1994580", VA = "0x181995780")]
		internal void <GetUIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x19957E0", Offset = "0x19945E0", VA = "0x1819957E0")]
		internal T <GetUIntEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x22C6FA0", Offset = "0x22C5DA0", VA = "0x1822C6FA0")]
	public static void JFLMAPNOFGN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x22C6D00", Offset = "0x22C5B00", VA = "0x1822C6D00")]
	private static void BLMDOAOIMHH<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x22C6D00", Offset = "0x22C5B00", VA = "0x1822C6D00")]
	private static void POPMCBJMLJP<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x22C6BB0", Offset = "0x22C59B0", VA = "0x1822C6BB0")]
	private static void MIOBCDGBBAN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x22C6BB0", Offset = "0x22C59B0", VA = "0x1822C6BB0")]
	private static void AOFHIEHMIOC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x22C6E50", Offset = "0x22C5C50", VA = "0x1822C6E50")]
	private static void JGHCKDJLCEC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x22C6E50", Offset = "0x22C5C50", VA = "0x1822C6E50")]
	private static void IINAIGGFAAD<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class CPJOAFBACJL : BOLFBGCGJHF, CDAFEBOKDJF
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEF10", Offset = "0x2AEDD10", VA = "0x182AEEF10", Slot = "4")]
	private void LKONOPAGGKI(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	protected CPJOAFBACJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[AGGLFMPJHMG(typeof(LocalPoseData))]
public sealed class BLHLFHAGAIK : CPJOAFBACJL
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC660", Offset = "0x2AEB460", VA = "0x182AEC660", Slot = "5")]
	protected override void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
	public BLHLFHAGAIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[InternalBufferCapacity(1)]
internal struct LNHLLFKMJJK : ISystemStateBufferElementData, IBufferElementData, IEquatable<LNHLLFKMJJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public HDIMMDIONOF MIGDJNOKMHC;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x26E8B60", Offset = "0x26E7960", VA = "0x1826E8B60", Slot = "4")]
	public bool Equals(LNHLLFKMJJK HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static LNHLLFKMJJK PAAEKNCKHBI(HDIMMDIONOF MIGDJNOKMHC)
	{
		return default(LNHLLFKMJJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[InternalBufferCapacity(4)]
internal struct BCGNKDMNODC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public HDIMMDIONOF MIGDJNOKMHC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static BCGNKDMNODC PAAEKNCKHBI(HDIMMDIONOF MIGDJNOKMHC)
	{
		return default(BCGNKDMNODC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct HDIMMDIONOF : global::OCGKPONDJPA<HDIMMDIONOF>, GPAFGALANDE, IEquatable<HDIMMDIONOF>
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x73E0D0", Offset = "0x73CED0", VA = "0x18073E0D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xC46420", Offset = "0xC45220", VA = "0x180C46420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x73E0B0", Offset = "0x73CEB0", VA = "0x18073E0B0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xC49E10", Offset = "0xC48C10", VA = "0x180C49E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x26E8BB0", Offset = "0x26E79B0", VA = "0x1826E8BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x26E8B60", Offset = "0x26E7960", VA = "0x1826E8B60", Slot = "8")]
	public bool Equals(HDIMMDIONOF HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x26E8BF0", Offset = "0x26E79F0", VA = "0x1826E8BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class FPEBBPOHPPF : ParentSystemBase<AuthoredParentData, HDLOBHOIHNH, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x26E6BB0", Offset = "0x26E59B0", VA = "0x1826E6BB0", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E00", Offset = "0x6C2C00", VA = "0x1806C3E00", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x26E6B70", Offset = "0x26E5970", VA = "0x1826E6B70", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x26E6B30", Offset = "0x26E5930", VA = "0x1826E6B30", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C30", Offset = "0x26E5A30", VA = "0x1826E6C30")]
	public FPEBBPOHPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x26E6BF0", Offset = "0x26E59F0", VA = "0x1826E6BF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[IFBLAMOEMKH(CMGBDLINHMB.Connectables)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public class UpdateConnectableVisuals : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		private struct DAOGBIHJNFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public HDIMMDIONOF MIGDJNOKMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public float3 EIIEKPIPEEF;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x351A1D0", Offset = "0x3518FD0", VA = "0x18351A1D0")]
			public DAOGBIHJNFE(HDIMMDIONOF MIGDJNOKMHC, float3 EIIEKPIPEEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x351A1B0", Offset = "0x3518FB0", VA = "0x18351A1B0")]
			public void PIELOEDOOJA(out HDIMMDIONOF MIGDJNOKMHC, out float3 EIIEKPIPEEF)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private struct MAJDNBHGGKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public MAJDNBHGGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<BCGNKDMNODC> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private struct IDCMJDPABOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public IDCMJDPABOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<LNHLLFKMJJK> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private struct HFPHMGCFMCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public HFPHMGCFMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in CAJJCLKLGOM com, in DynamicBuffer<LNHLLFKMJJK> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LHPEMGIFDKN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A3")]
			private struct KLCIBDBGDKE
			{
				[Cpp2IlInjected.Token(Token = "0x20000A4")]
				public struct ODNGCGDEBMO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000223")]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000224")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000225")]
					public LambdaParameterValueProvider_DynamicBuffer<BCGNKDMNODC>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000220")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000221")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000222")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<BCGNKDMNODC> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x3520D90", Offset = "0x351FB90", VA = "0x183520D90")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0x3520CD0", Offset = "0x351FAD0", VA = "0x183520CD0")]
				public ODNGCGDEBMO LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(ODNGCGDEBMO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public UpdateConnectableVisuals OGFKLGAJDGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private KLCIBDBGDKE JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KLCIBDBGDKE.ODNGCGDEBMO* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x3521210", Offset = "0x3520010", VA = "0x183521210")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, WorldPoseData JFKBEONBDEB, in DynamicBuffer<BCGNKDMNODC> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x3521450", Offset = "0x3520250", VA = "0x183521450", Slot = "5")]
			public void ReadFromDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x3521480", Offset = "0x3520280", VA = "0x183521480", Slot = "6")]
			public void WriteToDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x3520F40", Offset = "0x351FD40", VA = "0x183520F40", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x35210D0", Offset = "0x351FED0", VA = "0x1835210D0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref KLCIBDBGDKE.ODNGCGDEBMO PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x3521090", Offset = "0x351FE90", VA = "0x183521090")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x3521020", Offset = "0x351FE20", VA = "0x183521020")]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct ENDBCHEICFA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			private struct KDBKHHONECG
			{
				[Cpp2IlInjected.Token(Token = "0x20000A7")]
				[NoAlias]
				public struct CLJCBBMJEAI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400022B")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400022C")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000229")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x6000595")]
				[Cpp2IlInjected.Address(RVA = "0x3520750", Offset = "0x351F550", VA = "0x183520750")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000596")]
				[Cpp2IlInjected.Address(RVA = "0x35206B0", Offset = "0x351F4B0", VA = "0x1835206B0")]
				public CLJCBBMJEAI LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(CLJCBBMJEAI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			private KDBKHHONECG JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KDBKHHONECG.CLJCBBMJEAI* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x351B800", Offset = "0x351A600", VA = "0x18351B800")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
			public void ReadFromDisplayClass(ref IDCMJDPABOF CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x351B5C0", Offset = "0x351A3C0", VA = "0x18351B5C0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x351B730", Offset = "0x351A530", VA = "0x18351B730")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KDBKHHONECG.CLJCBBMJEAI PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x351B690", Offset = "0x351A490", VA = "0x18351B690")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref IDCMJDPABOF CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct IIBJIOOCOBL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A9")]
			private struct NBEECHMBMMD
			{
				[Cpp2IlInjected.Token(Token = "0x20000AA")]
				[NoAlias]
				public struct AEMNPDNKMCB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000233")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000234")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<CAJJCLKLGOM>.Runtime PDGFBALHOAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000235")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000230")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000231")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<CAJJCLKLGOM> PFFOLDMEOOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0x3522BD0", Offset = "0x35219D0", VA = "0x183522BD0")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0x3522B00", Offset = "0x3521900", VA = "0x183522B00")]
				public AEMNPDNKMCB LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(AEMNPDNKMCB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private NBEECHMBMMD JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NBEECHMBMMD.AEMNPDNKMCB* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x351E510", Offset = "0x351D310", VA = "0x18351E510")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in CAJJCLKLGOM LCODFDEFNPG, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
			public void ReadFromDisplayClass(ref HFPHMGCFMCO CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x351E330", Offset = "0x351D130", VA = "0x18351E330", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x351E3F0", Offset = "0x351D1F0", VA = "0x18351E3F0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref NBEECHMBMMD.AEMNPDNKMCB PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x351E3B0", Offset = "0x351D1B0", VA = "0x18351E3B0")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref HFPHMGCFMCO CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private EntityQuery DHJICPEOEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private EntityQuery LKEANLPNLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private EntityQuery MKGEPDNHDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private EntityQuery HINGOOJNECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private EntityQuery OJEDGKDPNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private EntityQuery LOKLOJOMFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private EntityQuery MCDIDIBLHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private EntityQuery LMCBNGAADFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private EntityQuery BDLIIGOHHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private EntityQuery GGKKMBAOJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private global::OPFKIBDDGAC<HDIMMDIONOF, ODDCBCICFNM> EOGGCJMEACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private JLCJAEGDOGE CFPCEBNDHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BFIAFBHOKLF KKJNDEPMACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private LEFOFMICAIA PEMCBJCDENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private EntityQuery BOKIIBPIGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private ProfilerMarker PPNHEPGICAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private EntityQuery DGANBMPFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private EntityQuery AOLEJCLKADJ;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x273D270", Offset = "0x273C070", VA = "0x18273D270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x273BEC0", Offset = "0x273ACC0", VA = "0x18273BEC0")]
		internal ODDCBCICFNM DBLMFLLDADB(HDIMMDIONOF MIGDJNOKMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x273CF50", Offset = "0x273BD50", VA = "0x18273CF50", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x273EAC0", Offset = "0x273D8C0", VA = "0x18273EAC0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x273EC50", Offset = "0x273DA50", VA = "0x18273EC50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x273E880", Offset = "0x273D680", VA = "0x18273E880", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x273B870", Offset = "0x273A670", VA = "0x18273B870")]
		private void AMGJKIINAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x273BD70", Offset = "0x273AB70", VA = "0x18273BD70")]
		private void BGLGGKOKAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x273E1A0", Offset = "0x273CFA0", VA = "0x18273E1A0")]
		private void KLKFABFKPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x273EC90", Offset = "0x273DA90", VA = "0x18273EC90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x273DA70", Offset = "0x273C870", VA = "0x18273DA70")]
		private void JBCFLHJDAGD(EntityQuery BCEJPCNJJCE, EntityQuery JEGEKBCLIDO, EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x273B7A0", Offset = "0x273A5A0", VA = "0x18273B7A0")]
		private void AKJLIPOIGHF(EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x273D010", Offset = "0x273BE10", VA = "0x18273D010")]
		private void HLKMKDJBMNE(global::OHBAMBCHLEK<Entity> PFHHBJBMJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x273F590", Offset = "0x273E390", VA = "0x18273F590")]
		private void POCPHLCGLHH(global::OHBAMBCHLEK<Entity> CDCMOCAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x273CCF0", Offset = "0x273BAF0", VA = "0x18273CCF0")]
		private void FKDOMINAOPC(global::OHBAMBCHLEK<Entity> OIJFDMIKPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x273C3C0", Offset = "0x273B1C0", VA = "0x18273C3C0")]
		private void DLKDNGDBFPE(NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x273C530", Offset = "0x273B330", VA = "0x18273C530")]
		private NativeList<HDIMMDIONOF> EHCMIFOEHDA(NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(NativeList<HDIMMDIONOF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x273EF60", Offset = "0x273DD60", VA = "0x18273EF60")]
		private void PFLKGFHEELP(NativeArray<Entity> FBMJMNCDHDM, NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x273D2B0", Offset = "0x273C0B0", VA = "0x18273D2B0")]
		private void IFKFOBFCAHC(NativeArray<Entity> BFNKKPHBOMC, NativeArray<Entity> DPOBAKHBGJO, NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x273BF10", Offset = "0x273AD10", VA = "0x18273BF10")]
		private void DCPFKPHFGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x273CBB0", Offset = "0x273B9B0", VA = "0x18273CBB0")]
		private global::AFBJNMJHLIH<DAOGBIHJNFE> FDHHLJMLGBG(EntityQuery JFPFDEFJDBP, Func<NativeList<DAOGBIHJNFE>, JobHandle> PJIHFBPLBLO)
		{
			return default(global::AFBJNMJHLIH<DAOGBIHJNFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x273B980", Offset = "0x273A780", VA = "0x18273B980")]
		private JobHandle BADABDFPCNL(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x273CA70", Offset = "0x273B870", VA = "0x18273CA70")]
		private JobHandle EKOHHILIPNF(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x273E550", Offset = "0x273D350", VA = "0x18273E550")]
		private JobHandle MGHJLADJONE(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x273B510", Offset = "0x273A310", VA = "0x18273B510")]
		private void AKCJIAKBIJA(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x273D7E0", Offset = "0x273C5E0", VA = "0x18273D7E0")]
		private void IGPOMOKCBNF(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x273CE10", Offset = "0x273BC10", VA = "0x18273CE10")]
		private bool GOJFDMOJAKO(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x273CE70", Offset = "0x273BC70", VA = "0x18273CE70")]
		private NativeArray<Entity> GPCOJPDJHCG(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x273EDA0", Offset = "0x273DBA0", VA = "0x18273EDA0")]
		private HDIMMDIONOF PANOFCIBOHH(NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
			return default(HDIMMDIONOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x273DEA0", Offset = "0x273CCA0", VA = "0x18273DEA0")]
		private void JLABOBGJOHB(HDIMMDIONOF MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2725EC0", Offset = "0x2724CC0", VA = "0x182725EC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x273E680", Offset = "0x273D480", VA = "0x18273E680")]
		public static EntityQuery NGOKAPGAKBC(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x273BB10", Offset = "0x273A910", VA = "0x18273BB10")]
		public static EntityQuery BEACGJJJMMJ(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x273DF30", Offset = "0x273CD30", VA = "0x18273DF30")]
		public static EntityQuery KACGELCIFII(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class JGNGJMNAFKA : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private ObjectEmbodimentService KFHKDGFGKJJ;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x26EF460", Offset = "0x26EE260", VA = "0x1826EF460", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x26EF4C0", Offset = "0x26EE2C0", VA = "0x1826EF4C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x26EF4F0", Offset = "0x26EE2F0", VA = "0x1826EF4F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	protected JGNGJMNAFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class FBGPKGAHMCA : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private EntityQuery JEDIHPJPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private EntityQuery JAEMJPPGJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EntityQuery LCANOIDKHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EntityQuery MOOHGBALNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private ObjectEmbodimentService NDHAELBFJCF;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int HJDHFKEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B00960", Offset = "0x2AFF760", VA = "0x182B00960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C40", Offset = "0x2AFFA40", VA = "0x182B00C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B00810", Offset = "0x2AFF610", VA = "0x182B00810", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B00C50", Offset = "0x2AFFA50", VA = "0x182B00C50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B00E40", Offset = "0x2AFFC40", VA = "0x182B00E40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B00970", Offset = "0x2AFF770", VA = "0x182B00970")]
	protected void LCIEOJEPMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B00360", Offset = "0x2AFF160", VA = "0x182B00360")]
	protected void BCMMENNOOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B00870", Offset = "0x2AFF670", VA = "0x182B00870")]
	private bool KJBCNCCLGDG(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<EMPKMDMEDJP> AGFPEFOAJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B006A0", Offset = "0x2AFF4A0", VA = "0x182B006A0")]
	public global::OHBAMBCHLEK<Entity> DJEDMHNKNKM(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B00760", Offset = "0x2AFF560", VA = "0x182B00760")]
	public global::OHBAMBCHLEK<Entity> FEEJMBLMDJL(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B006E0", Offset = "0x2AFF4E0", VA = "0x182B006E0")]
	public bool EBCBHCDIKAJ(Allocator JEOILJEOOOI, out global::OHBAMBCHLEK<Entity> DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B005D0", Offset = "0x2AFF3D0", VA = "0x182B005D0")]
	public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B007A0", Offset = "0x2AFF5A0", VA = "0x182B007A0")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B00630", Offset = "0x2AFF430", VA = "0x182B00630")]
	public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B00320", Offset = "0x2AFF120", VA = "0x182B00320")]
	public void AOPNOMOLIPC(Entity GEEFHDFLBEH, HDIAJFLHONH DNCNJICBAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B00BE0", Offset = "0x2AFF9E0", VA = "0x182B00BE0")]
	public bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public FBGPKGAHMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class HDIAJFLHONH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public GIALAGJINEB DNCNJICBAHE;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public HDIAJFLHONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
	public HDIAJFLHONH(GIALAGJINEB DNCNJICBAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class AEKANGFCDAO : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private EntityQuery IKPKMFGJGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4AC0", Offset = "0x2AE38C0", VA = "0x182AE4AC0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4B10", Offset = "0x2AE3910", VA = "0x182AE4B10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4BD0", Offset = "0x2AE39D0", VA = "0x182AE4BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1BC0", Offset = "0x1EE09C0", VA = "0x181EE1BC0")]
	private bool KJBCNCCLGDG<TComponentData>(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<TComponentData> CGPLPFBCOHF) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4A50", Offset = "0x2AE3850", VA = "0x182AE4A50")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public AEKANGFCDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private EntityQuery FHLFFMDFBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private EntityQuery NJEIDEGDHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private EntityQuery OLGKCFEPIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x2734010", Offset = "0x2732E10", VA = "0x182734010", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2734060", Offset = "0x2732E60", VA = "0x182734060", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x27341D0", Offset = "0x2732FD0", VA = "0x1827341D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2733CC0", Offset = "0x2732AC0", VA = "0x182733CC0")]
		private void ENDJPLBKPHO(EntityQuery JFPFDEFJDBP, bool CJONJKNGENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMAGEIGMADI))]
public class FLHBJAPMFOE : IKEIJDHBAML
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public FLHBJAPMFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public abstract class KKPNBIDGCGE : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private CMEEFJNDPID OAACGCFNLFM;

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x26F2E20", Offset = "0x26F1C20", VA = "0x1826F2E20", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x26F2E80", Offset = "0x26F1C80", VA = "0x1826F2E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	protected KKPNBIDGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class NIENIENGCDI : IKEIJDHBAML, CDAFEBOKDJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KDOOAAPMPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NativeList<MIFKFPHADFM> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NativeList<FDCGJNDCDCD> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public NativeList<MIFKFPHADFM> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public KDOOAAPMPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, HHCGCCCMOPE previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__2(Entity entity, HHCGCCCMOPE previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct OMIFHIDJDJH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		private struct JGCFLCKJLMG
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			[NoAlias]
			public struct CJKCAPBAJNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KABOPAPBNNB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> LMJMEJIPPCK;

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x351FA40", Offset = "0x351E840", VA = "0x18351FA40")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x351F9C0", Offset = "0x351E7C0", VA = "0x18351F9C0")]
			public CJKCAPBAJNG LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(CJKCAPBAJNG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public NativeList<MIFKFPHADFM> EJGHENKOJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private JGCFLCKJLMG JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JGCFLCKJLMG.CJKCAPBAJNG* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x3523B50", Offset = "0x3522950", VA = "0x183523B50")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3523970", Offset = "0x3522770", VA = "0x183523970", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3523AA0", Offset = "0x35228A0", VA = "0x183523AA0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JGCFLCKJLMG.CJKCAPBAJNG PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3523A10", Offset = "0x3522810", VA = "0x183523A10")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct CNCDGCENJNB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		private struct HOLILIMPEPD
		{
			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[NoAlias]
			public struct OCBILNBJBML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000259")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KABOPAPBNNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE>.Runtime IOOBKKDKNIM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> LMJMEJIPPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE> BBMMEHFCFGH;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x351DD70", Offset = "0x351CB70", VA = "0x18351DD70")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x351DCD0", Offset = "0x351CAD0", VA = "0x18351DCD0")]
			public OCBILNBJBML LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(OCBILNBJBML);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NativeList<FDCGJNDCDCD> AOAOEICHLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private HOLILIMPEPD JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HOLILIMPEPD.OCBILNBJBML* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3519640", Offset = "0x3518440", VA = "0x183519640")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x3519700", Offset = "0x3518500", VA = "0x183519700", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3519450", Offset = "0x3518250", VA = "0x183519450", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3519560", Offset = "0x3518360", VA = "0x183519560")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref HOLILIMPEPD.OCBILNBJBML PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3519520", Offset = "0x3518320", VA = "0x183519520")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NLFHHEBNEHB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private struct KAOAJFMCLOO
		{
			[Cpp2IlInjected.Token(Token = "0x20000BC")]
			[NoAlias]
			public struct MHJPNNPCLFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE>.Runtime IOOBKKDKNIM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE> BBMMEHFCFGH;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x3520650", Offset = "0x351F450", VA = "0x183520650")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x35205D0", Offset = "0x351F3D0", VA = "0x1835205D0")]
			public MHJPNNPCLFK LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MHJPNNPCLFK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NativeList<MIFKFPHADFM> NFIMDAGFELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private KAOAJFMCLOO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KAOAJFMCLOO.MHJPNNPCLFK* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3522E40", Offset = "0x3521C40", VA = "0x183522E40")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x3522EC0", Offset = "0x3521CC0", VA = "0x183522EC0", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x3522C60", Offset = "0x3521A60", VA = "0x183522C60", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x3522D90", Offset = "0x3521B90", VA = "0x183522D90")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KAOAJFMCLOO.MHJPNNPCLFK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x3522D00", Offset = "0x3521B00", VA = "0x183522D00")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private MFLHDAEOBPP JLGDDMFNKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private EntityQuery PEPHMBJGIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private EntityQuery GPKOHCPPELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private EntityQuery JOMHNLJLCKH;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x26F96E0", Offset = "0x26F84E0", VA = "0x1826F96E0", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x26F9A50", Offset = "0x26F8850", VA = "0x1826F9A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public NIENIENGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x26F99F0", Offset = "0x26F87F0", VA = "0x1826F99F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x26F9480", Offset = "0x26F8280", VA = "0x1826F9480")]
	public static EntityQuery HJIOGFGIOPK(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x26F97C0", Offset = "0x26F85C0", VA = "0x1826F97C0")]
	public static EntityQuery OFEBIIBCALM(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x26F9280", Offset = "0x26F8080", VA = "0x1826F9280")]
	public static EntityQuery FMJJEMBGJDL(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class LFLBNLDBEKG : ParentSystemBase<ParentData, HHCGCCCMOPE, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x26F5960", Offset = "0x26F4760", VA = "0x1826F5960", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E00", Offset = "0x6C2C00", VA = "0x1806C3E00", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x26F5920", Offset = "0x26F4720", VA = "0x1826F5920", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x26F58E0", Offset = "0x26F46E0", VA = "0x1826F58E0", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x26F59E0", Offset = "0x26F47E0", VA = "0x1826F59E0")]
	public LFLBNLDBEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x26F59A0", Offset = "0x26F47A0", VA = "0x1826F59A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : DBEHBMCDNIE where ParentData : struct, IComponentData, LJBPPGAHFFJ where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[BurstCompile]
		private struct PONKHBDJFMP : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter LGLGJICGDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter KAEFBIEAHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public NativeHashMap<Entity, int>.ParallelWriter LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public ArchetypeChunkComponentType<PreviousParentData> IIAEBCGKKEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> PGHIPBBDPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			[ReadOnly]
			public ArchetypeChunkEntityType DLIGLBABHFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public uint AEPGONMKGBO;

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1070", Offset = "0x2AAFE70", VA = "0x182AB1070", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[BurstCompile]
		private struct GEMJCKJFEBC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			[ReadOnly]
			public NativeHashMap<Entity, int> LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public NativeList<Entity> KEACBGMPABP;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x21C7EE0", Offset = "0x21C6CE0", VA = "0x1821C7EE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[BurstCompile]
		private struct GEEOIALOAMJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> LGLGJICGDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> KAEFBIEAHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			[ReadOnly]
			public NativeHashMap<Entity, int> LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x21C6B30", Offset = "0x21C5930", VA = "0x1821C6B30")]
			private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x21C69D0", Offset = "0x21C57D0", VA = "0x1821C69D0")]
			private void GGDHNAHHAOK(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x21C6E80", Offset = "0x21C5C80", VA = "0x1821C6E80")]
			private void LLJMGCBHJMB(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x21C65B0", Offset = "0x21C53B0", VA = "0x1821C65B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[BurstCompile]
		private struct MEEINAIJODP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			public NativeArray<Entity> GLLJFEKGHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			public NativeList<Entity> NEAKJMIFMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2D0B650", Offset = "0x2D0A450", VA = "0x182D0B650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		protected EntityQuery DJOOGAALAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		protected EntityQuery NFIJMBBEFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		protected EntityQuery HJKBACBKGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		protected EntityQuery MAMPFFHAMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		protected ProfilerMarker JBGNHGGIFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		protected ProfilerMarker FOIFMNENJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		protected ProfilerMarker EHGOOOIKIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		protected ProfilerMarker NKJJFFCGELJ;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB600", Offset = "0x2ABA400", VA = "0x182ABB600")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAC60", Offset = "0x2AB9A60", VA = "0x182ABAC60")]
		private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA9A0", Offset = "0x2AB97A0", VA = "0x182ABA9A0")]
		private void HAEJNAPBJEK(Entity AIANMNKPJDO, Entity ICOEFFELKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E00", Offset = "0x6C2C00", VA = "0x1806C3E00", Slot = "14")]
		protected virtual EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E00", Offset = "0x6C2C00", VA = "0x1806C3E00", Slot = "15")]
		protected virtual EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E00", Offset = "0x6C2C00", VA = "0x1806C3E00", Slot = "16")]
		protected virtual EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB000", Offset = "0x2AB9E00", VA = "0x182ABB000", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAE40", Offset = "0x2AB9C40", VA = "0x182ABAE40")]
		private void KFFENDCIJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA600", Offset = "0x2AB9400", VA = "0x182ABA600")]
		private void EDOBDLADANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9580", Offset = "0x2AB8380", VA = "0x182AB9580")]
		private void AJNECNOFGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9F60", Offset = "0x2AB8D60", VA = "0x182AB9F60")]
		private void DIBNIDMHLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB540", Offset = "0x2ABA340", VA = "0x182ABB540", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x167C6C0", Offset = "0x167B4C0", VA = "0x18167C6C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[AlwaysUpdateSystem]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : IKEIJDHBAML, CDAFEBOKDJF where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		private struct AGNHJPPPNED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public global::AFBJNMJHLIH<Entity> MMHAHCJBHGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			public global::AFBJNMJHLIH<Entity> HPHEMDOFNNP;

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x2280920", Offset = "0x227F720", VA = "0x182280920")]
			public AGNHJPPPNED(NativeList<Entity> MMHAHCJBHGK, NativeList<Entity> HPHEMDOFNNP, JobHandle AADBABLKHJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x2280490", Offset = "0x227F290", VA = "0x182280490")]
			public JobHandle IBPCJLOGNIJ(JobHandle GINKINFGNEP)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x2280610", Offset = "0x227F410", VA = "0x182280610")]
			public void ICKDJJKFGLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[BurstCompile]
		private struct MANBCFEMMMC : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000C6")]
			[Flags]
			public enum JKKPLNLGLBI
			{
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				ReadParentFromArray = 1,
				[Cpp2IlInjected.Token(Token = "0x400028E")]
				FetchParentFromEntity = 2,
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				AncestorTagValue = 4,
				[Cpp2IlInjected.Token(Token = "0x4000290")]
				ConstNoAncestorTag = 0,
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				ConstHasAncestorTag = 4
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			[WriteOnly]
			public NativeList<Entity> PFFFDGGJNNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			[WriteOnly]
			public NativeList<Entity> PPIJMDDCAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			[ReadOnly]
			public NativeArray<Entity> MBFIPMKAEEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> ALANNIIDHOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> OMPKNGGDAOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> PDHIELHHNIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> DOIFFICECOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			public int BJNNEGIPGIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			public int BGIAACHOOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private JKKPLNLGLBI JMJCIMAHPFC;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x2D00970", Offset = "0x2CFF770", VA = "0x182D00970", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x2D012C0", Offset = "0x2D000C0", VA = "0x182D012C0")]
			private void GJJCPKFPJDJ(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x2D01CE0", Offset = "0x2D00AE0", VA = "0x182D01CE0")]
			private void IJHEEAOHCEG(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x2D00080", Offset = "0x2CFEE80", VA = "0x182D00080")]
			public AGNHJPPPNED ABHIGKNBIPJ(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x2D00E30", Offset = "0x2CFFC30", VA = "0x182D00E30")]
			public AGNHJPPPNED GHIBFNJEHGI(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x2D00530", Offset = "0x2CFF330", VA = "0x182D00530")]
			public AGNHJPPPNED CPCMEDGJJJN(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x2D01F10", Offset = "0x2D00D10", VA = "0x182D01F10")]
			public AGNHJPPPNED LPLFIDJHJFJ(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x2D00170", Offset = "0x2CFEF70", VA = "0x182D00170")]
			public AGNHJPPPNED CMFGMGFGOBH(NativeList<FDCGJNDCDCD> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x26AAF00", Offset = "0x26A9D00", VA = "0x1826AAF00")]
			private AGNHJPPPNED HBPLCHGJNEG<T>(NativeList<T> LPDILHBGHIJ, int OJMDGHDFJIL, int CACEIMFJAFJ, JKKPLNLGLBI CIJCIMPGNPO, JobHandle GINKINFGNEP) where T : struct
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x2D015E0", Offset = "0x2D003E0", VA = "0x182D015E0")]
			private AGNHJPPPNED HBPLCHGJNEG(NativeArray<Entity> FBMJMNCDHDM, int OJMDGHDFJIL, int CACEIMFJAFJ, JKKPLNLGLBI CIJCIMPGNPO, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EntityQuery GLHIIMDAKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private EntityQuery LKOHBDGDHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private MFLHDAEOBPP MCFBCIDCFAP;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FF10", Offset = "0x2E2ED10", VA = "0x182E2FF10", Slot = "14")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2E30060", Offset = "0x2E2EE60", VA = "0x182E30060", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2E31950", Offset = "0x2E30750", VA = "0x182E31950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FFF0", Offset = "0x2E2EDF0", VA = "0x182E2FFF0")]
		private void LCPKFCMPMKO(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2E32430", Offset = "0x2E31230", VA = "0x182E32430")]
		private void POMGPNKGHPB(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F930", Offset = "0x2E2E730", VA = "0x182E2F930")]
		private void GLNCJCIJIBI(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F6F0", Offset = "0x2E2E4F0", VA = "0x182E2F6F0")]
		private void GLNCJCIJIBI(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FAB0", Offset = "0x2E2E8B0", VA = "0x182E2FAB0")]
		private void GNHEPKEENCP(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F990", Offset = "0x2E2E790", VA = "0x182E2F990")]
		private void GNHEPKEENCP(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2E2F570", Offset = "0x2E2E370", VA = "0x182E2F570")]
		private bool DDDCGGOHCCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2E32510", Offset = "0x2E31310", VA = "0x182E32510")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x167C6C0", Offset = "0x167B4C0", VA = "0x18167C6C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public class KLGOENHKPJC : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct IAHDCCHPIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public KLGOENHKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public IAHDCCHPIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OMNKGEPLMCG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		private struct DJLDJBNGFAG
		{
			[Cpp2IlInjected.Token(Token = "0x20000CB")]
			public struct MOBCKLINCAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029E")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x351AB20", Offset = "0x3519920", VA = "0x18351AB20")]
			public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x351AB10", Offset = "0x3519910", VA = "0x18351AB10")]
			public MOBCKLINCAK LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MOBCKLINCAK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public KLGOENHKPJC OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private DJLDJBNGFAG JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DJLDJBNGFAG.MOBCKLINCAK* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x3523D40", Offset = "0x3522B40", VA = "0x183523D40")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x351C670", Offset = "0x351B470", VA = "0x18351C670", Slot = "5")]
		public void ReadFromDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x351C6A0", Offset = "0x351B4A0", VA = "0x18351C6A0", Slot = "6")]
		public void WriteToDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x3523BD0", Offset = "0x35229D0", VA = "0x183523BD0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x3523CD0", Offset = "0x3522AD0", VA = "0x183523CD0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJLDJBNGFAG.MOBCKLINCAK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x3523C90", Offset = "0x3522A90", VA = "0x183523C90")]
		public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ, ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x3523C20", Offset = "0x3522A20", VA = "0x183523C20")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private OPIMGAOPDNP IEBLHHMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private EntityQuery CJLGOGEHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private ProfilerMarker PNOEOGONAOK;

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x26F31B0", Offset = "0x26F1FB0", VA = "0x1826F31B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x26F3070", Offset = "0x26F1E70", VA = "0x1826F3070", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x26F3210", Offset = "0x26F2010", VA = "0x1826F3210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public KLGOENHKPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x26F30D0", Offset = "0x26F1ED0", VA = "0x1826F30D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x26F2EA0", Offset = "0x26F1CA0", VA = "0x1826F2EA0")]
	public static EntityQuery DJJPMPNEMLM(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct JLKFGGHMAGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public NCGEEIAJEOJ MIGDJNOKMHC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0")]
	public static JLKFGGHMAGN PAAEKNCKHBI(in NCGEEIAJEOJ PMFKMFEMMLL)
	{
		return default(JLKFGGHMAGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6788A0", Offset = "0x6776A0", VA = "0x1806788A0")]
	public static NCGEEIAJEOJ PAAEKNCKHBI(in JLKFGGHMAGN EJIKNKJOMGE)
	{
		return default(NCGEEIAJEOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OPIMGAOPDNP : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	public OPIMGAOPDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[AlwaysUpdateSystem]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public class LIICBMDDEGK : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct AKNNNKDPIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public LIICBMDDEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public AKNNNKDPIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity e, JLKFGGHMAGN ch)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct FNBILDILKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public LIICBMDDEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public FNBILDILKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnStopRunning>b__0(Entity e, JLKFGGHMAGN ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HDILDIBMMFF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private struct NMLINPPPECO
		{
			[Cpp2IlInjected.Token(Token = "0x20000D3")]
			public struct MHFMMOIBIIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				public LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN>.Runtime HGNBDPOMEEO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN> BPNCNKJCBKJ;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x3522F50", Offset = "0x3521D50", VA = "0x183522F50")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x3522ED0", Offset = "0x3521CD0", VA = "0x183522ED0")]
			public MHFMMOIBIIB LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MHFMMOIBIIB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public LIICBMDDEGK OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private NMLINPPPECO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NMLINPPPECO.MHFMMOIBIIB* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x351D330", Offset = "0x351C130", VA = "0x18351D330")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x351C670", Offset = "0x351B470", VA = "0x18351C670", Slot = "5")]
		public void ReadFromDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x351C6A0", Offset = "0x351B4A0", VA = "0x18351C6A0", Slot = "6")]
		public void WriteToDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x351D0E0", Offset = "0x351BEE0", VA = "0x18351D0E0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x351D280", Offset = "0x351C080", VA = "0x18351D280")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref NMLINPPPECO.MHFMMOIBIIB PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x351D1F0", Offset = "0x351BFF0", VA = "0x18351D1F0")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x351D180", Offset = "0x351BF80", VA = "0x18351D180")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FPBOKPJKAED : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		private struct HBMIEJLNNIO
		{
			[Cpp2IlInjected.Token(Token = "0x20000D6")]
			public struct EFMILKILIAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BA")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				public LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN>.Runtime HGNBDPOMEEO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN> BPNCNKJCBKJ;

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x351D080", Offset = "0x351BE80", VA = "0x18351D080")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x351D000", Offset = "0x351BE00", VA = "0x18351D000")]
			public EFMILKILIAD LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(EFMILKILIAD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public LIICBMDDEGK OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private HBMIEJLNNIO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HBMIEJLNNIO.EFMILKILIAD* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x351C5E0", Offset = "0x351B3E0", VA = "0x18351C5E0")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x351C670", Offset = "0x351B470", VA = "0x18351C670", Slot = "5")]
		public void ReadFromDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x351C6A0", Offset = "0x351B4A0", VA = "0x18351C6A0", Slot = "6")]
		public void WriteToDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x351C390", Offset = "0x351B190", VA = "0x18351C390", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x351C530", Offset = "0x351B330", VA = "0x18351C530")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref HBMIEJLNNIO.EFMILKILIAD PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x351C4A0", Offset = "0x351B2A0", VA = "0x18351C4A0")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x351C430", Offset = "0x351B230", VA = "0x18351C430")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private OPIMGAOPDNP IEBLHHMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private EntityQuery BCHHFMJGEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private ProfilerMarker MPJNLAAFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EntityQuery NDAGCLCGEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private ProfilerMarker LEGMFMODAFF;

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x26F6170", Offset = "0x26F4F70", VA = "0x1826F6170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x26F5CB0", Offset = "0x26F4AB0", VA = "0x1826F5CB0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x26F6330", Offset = "0x26F5130", VA = "0x1826F6330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x26F61D0", Offset = "0x26F4FD0", VA = "0x1826F61D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public LIICBMDDEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5EE0", Offset = "0x26F4CE0", VA = "0x1826F5EE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x26F5D10", Offset = "0x26F4B10", VA = "0x1826F5D10")]
	public static EntityQuery OCKMBBOCGBB(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x26F5B50", Offset = "0x26F4950", VA = "0x1826F5B50")]
	public static EntityQuery ABBNPOOIDCD(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		private struct EODFPBLFDAC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public OCGCGAIFBCP JKOOEKEEBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeHashMap<Entity, NOAPHGCLLPE> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x351B990", Offset = "0x351A790", VA = "0x18351B990")]
			public EODFPBLFDAC(int CHMDLBBFMNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x351B910", Offset = "0x351A710", VA = "0x18351B910", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		[BurstCompile]
		private struct GMLIDOBPOBJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> MEMMPBDNNLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x351CE60", Offset = "0x351BC60", VA = "0x18351CE60", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[BurstCompile]
		private struct CDDINBANFKP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF;

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x3518F40", Offset = "0x3517D40", VA = "0x183518F40", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private KNJHNLNIBIP LJDEGJIIHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private EntityQuery FIDKDOPGOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery MCPGOBGPBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery POLHGANDILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery KINEGBHPHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private EntityQuery OEEJLMIMECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private JobHandle HIHNNPBLPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private EODFPBLFDAC ADGNOGNDDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private EODFPBLFDAC OMACGAGIGDP;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x2729AC0", Offset = "0x27288C0", VA = "0x182729AC0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x2729CA0", Offset = "0x2728AA0", VA = "0x182729CA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x2729790", Offset = "0x2728590", VA = "0x182729790", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x2729F60", Offset = "0x2728D60", VA = "0x182729F60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x2729640", Offset = "0x2728440", VA = "0x182729640")]
		private void DHPGCLJNPJK(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x27293E0", Offset = "0x27281E0", VA = "0x1827293E0")]
		private void DHKMNNMGPIP((global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2729790", Offset = "0x2728590", VA = "0x182729790")]
		private void DLKGHKOHLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x2729B20", Offset = "0x2728920", VA = "0x182729B20")]
		private void LPGHLJOJNNO(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x27297D0", Offset = "0x27285D0", VA = "0x1827297D0")]
		private void FKCBBLHJAGG((global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP, EODFPBLFDAC MLBCCNCBNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2729280", Offset = "0x2728080", VA = "0x182729280")]
		private JobHandle AJCBDGEMENL(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF, ComponentDataFromEntity<WorldDeformableScaleData> MEMMPBDNNLF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x272A700", Offset = "0x2729500", VA = "0x18272A700")]
		private JobHandle PNAGBJKIAEM(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct ANELNBAODPG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public class SplineLocalBoundsSystem : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[BurstCompile]
		private struct ALNJHHOHGKN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			[ReadOnly]
			public NativeArray<Entity> BPAIPDBBMKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[ReadOnly]
			public ComponentDataFromEntity<NMNILGJABIA> GLPJJILGBMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			[WriteOnly]
			public NativeHashMap<Entity, NOAPHGCLLPE>.ParallelWriter EGCEADMKGDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter NGHNAKHFJLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CCMPNPBLPBI;

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x3518A50", Offset = "0x3517850", VA = "0x183518A50", Slot = "4")]
			public void Execute(int AIPHGHFENPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[BurstCompile]
		private struct HIPBCIEBIFN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			[ReadOnly]
			public NativeArray<Entity> DNFMACODOBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> DFBLOLNPNMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<NMNILGJABIA> OLNDMCHODOK;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x351D970", Offset = "0x351C770", VA = "0x18351D970", Slot = "4")]
			public void Execute(int AIPHGHFENPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EntityQuery NBKMKNDMGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private EntityQuery NFEBOEPJBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery OMPBDFCDNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private EntityQuery MAHGBGIGFIP;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x27356B0", Offset = "0x27344B0", VA = "0x1827356B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x27358C0", Offset = "0x27346C0", VA = "0x1827358C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2734DE0", Offset = "0x2733BE0", VA = "0x182734DE0")]
		private JobHandle IFMKCBJGODA(global::OHBAMBCHLEK<Entity> DEJEDNNJILK, int GKPOMAIMOAK, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2734C30", Offset = "0x2733A30", VA = "0x182734C30")]
		private JobHandle IFMKCBJGODA(NativeArray<Entity> CBMKCDPBEFL, int GKPOMAIMOAK, [Optional] JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2734BB0", Offset = "0x27339B0", VA = "0x182734BB0")]
		private global::OHBAMBCHLEK<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x27351E0", Offset = "0x2733FE0", VA = "0x1827351E0")]
		private (global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>) KGNGLHHBOIF(global::OHBAMBCHLEK<Entity> IHHKNLGEIBC)
		{
			return default((global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2735630", Offset = "0x2734430", VA = "0x182735630")]
		private void MDFBNLLMBAL(out NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x2734B20", Offset = "0x2733920", VA = "0x182734B20")]
		private void GADDBAKKCIJ(NativeList<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x2734A50", Offset = "0x2733850", VA = "0x182734A50")]
		private void GADDBAKKCIJ(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x2735E40", Offset = "0x2734C40", VA = "0x182735E40")]
		private void PADOHENKGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void BDDEIBJJOOM(int JDBHHBAPLEC, int EBEKBFLPPDI, int JLFOKLBEGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x2734EC0", Offset = "0x2733CC0", VA = "0x182734EC0")]
		private static NMNILGJABIA KGMOBBJGBFA(NativeArray<Entity> BJFBKLCPENG, ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI)
		{
			return default(NMNILGJABIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct KFACGEHEJME : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	public class DestroyLocalObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private EntityQuery LBFBIMKMJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7860", Offset = "0x2AE6660", VA = "0x182AE7860", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9070", Offset = "0x2AF7E70", VA = "0x182AF9070")]
		public bool LGKONKIAJFF(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9120", Offset = "0x2AF7F20", VA = "0x182AF9120", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91C0", Offset = "0x2AF7FC0", VA = "0x182AF91C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91C0", Offset = "0x2AF7FC0", VA = "0x182AF91C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91B0", Offset = "0x2AF7FB0", VA = "0x182AF91B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8F60", Offset = "0x2AF7D60", VA = "0x182AF8F60")]
		private void EGJEFCCBJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private GENGCCLJKNG ODPIFDMCMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private GNLAPDIIDJD PBHPBFOABAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		protected abstract ComputePropertyDifferences PLIOAOLEJFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFBA20", VA = "0x182AFCC20", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD00", Offset = "0x2AFBB00", VA = "0x182AFCD00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private void NDIGJPFLJCC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, EGNDHFFDDFH KOPJKHIOCNP, OJINANPDCIH NLBBBEBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[IFBLAMOEMKH(CMGBDLINHMB.Callbacks)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public abstract class PropertyEventCallbacks : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private PropertyEventCallbacksService AMENCMGDIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x272F980", Offset = "0x272E780", VA = "0x18272F980", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x272FA00", Offset = "0x272E800", VA = "0x18272FA00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[IFBLAMOEMKH(CMGBDLINHMB.NetworkSend)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public abstract class TransmitNetworkDataSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private ELFIPEDOAPI ABCMOBMIIII;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x273B470", Offset = "0x273A270", VA = "0x18273B470", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x273B4C0", Offset = "0x273A2C0", VA = "0x18273B4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class AssignPlayerIdsSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EntityQuery DGODDAHBCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private EntityQuery JBEOGAIFCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[ReadOnly]
		private EntityQuery EBIFBEJLAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private EntityQuery MPBFJGPNEKF;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public Entity EKAMJAPOMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9180", Offset = "0x2AE7F80", VA = "0x182AE9180")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9830", Offset = "0x2AE8630", VA = "0x182AE9830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2AE91C0", Offset = "0x2AE7FC0", VA = "0x182AE91C0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2AE99A0", Offset = "0x2AE87A0", VA = "0x182AE99A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9AB0", Offset = "0x2AE88B0", VA = "0x182AE9AB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9730", Offset = "0x2AE8530", VA = "0x182AE9730")]
		private void LJCCOJCHEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8F30", Offset = "0x2AE7D30", VA = "0x182AE8F30")]
		private void BMCHDCHCPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9210", Offset = "0x2AE8010", VA = "0x182AE9210")]
		private void ILJGDNMJKHN(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9070", Offset = "0x2AE7E70", VA = "0x182AE9070")]
		private void DMHGNPDJMNM(NativeArray<Entity> FBMJMNCDHDM, int DLAMHLJBGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9560", Offset = "0x2AE8360", VA = "0x182AE9560")]
		private void LFHDCJBBCEF(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9890", Offset = "0x2AE8690", VA = "0x182AE9890", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal static class HLAPFDOEBDD
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x26E9A10", Offset = "0x26E8810", VA = "0x1826E9A10")]
	public static bool DKPJLCCLCBP(this SystemBase CHJMLFMLCJF, out Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x26E9AA0", Offset = "0x26E88A0", VA = "0x1826E9AA0")]
	public static Entity LLGPMPGENGG(this SystemBase CHJMLFMLCJF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x26E9AF0", Offset = "0x26E88F0", VA = "0x1826E9AF0")]
	public static bool OMPMAIGNFHI(this SystemBase CHJMLFMLCJF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class ClearScopeOnLocalPlayerChangeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private EntityQuery LLPPGDLKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private BFIAFBHOKLF PDKGNHLLFLM;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEF70", Offset = "0x2AEDD70", VA = "0x182AEEF70", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEFC0", Offset = "0x2AEDDC0", VA = "0x182AEEFC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF080", Offset = "0x2AEDE80", VA = "0x182AEF080", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class LocalPlayerScopeSystem : ScopeSystemBase<BLHDIOPAIBE>, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private const string HPBFOFBCDNL = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EIANDBIEFDL EFHJAGIMGON;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public PMMHBDBEGAM EPGKNIGBDIO
		{
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x26F7130", Offset = "0x26F5F30", VA = "0x1826F7130")]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x26F6AD0", Offset = "0x26F58D0", VA = "0x1826F6AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private Entity LMAFPGJBCOD
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x26F6640", Offset = "0x26F5440", VA = "0x1826F6640")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x26F6500", Offset = "0x26F5300", VA = "0x1826F6500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public PMMHBDBEGAM GFMJMLPAANG
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x26F70A0", Offset = "0x26F5EA0", VA = "0x1826F70A0")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private Entity JFIFMEDJPFH
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x26F6BF0", Offset = "0x26F59F0", VA = "0x1826F6BF0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private Entity EKAMJAPOMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x26E9AA0", Offset = "0x26E88A0", VA = "0x1826E9AA0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public bool OMPMAIGNFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x26E9AF0", Offset = "0x26E88F0", VA = "0x1826E9AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x200F080", Offset = "0x200DE80", VA = "0x18200F080")]
		private bool KNMEGLCAMII<T>(out T IGJPNMBCJPK) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x26F6A60", Offset = "0x26F5860", VA = "0x1826F6A60", Slot = "15")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x26F6910", Offset = "0x26F5710", VA = "0x1826F6910", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x26F6F80", Offset = "0x26F5D80", VA = "0x1826F6F80")]
		private void OADCKFPFFGH(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x26F6C50", Offset = "0x26F5A50", VA = "0x1826F6C50")]
		private void NFALKLLLDCK(Entity GEEFHDFLBEH, Entity EFBHGFLNMOL, Entity NMGCEMAHJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x26F6780", Offset = "0x26F5580", VA = "0x1826F6780")]
		public bool EICFBDDCOOP(PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x26F66A0", Offset = "0x26F54A0", VA = "0x1826F66A0")]
		public static bool EICFBDDCOOP(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x26F6610", Offset = "0x26F5410", VA = "0x1826F6610")]
		private static bool DAAPIBBOKEK(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM KEHNEFAKJHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x26F7210", Offset = "0x26F6010", VA = "0x1826F7210")]
		protected LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x26F7060", Offset = "0x26F5E60", VA = "0x1826F7060", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class CreateContainerPivotOnEnterScopeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private EntityQuery CMMFELFHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private EntityQuery CPOPPALLOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E00", Offset = "0x2AF4C00", VA = "0x182AF5E00", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5FA0", Offset = "0x2AF4DA0", VA = "0x182AF5FA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6090", Offset = "0x2AF4E90", VA = "0x182AF6090", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x273FD90", Offset = "0x273EB90", VA = "0x18273FD90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5A00", Offset = "0x2AF4800", VA = "0x182AF5A00")]
		private void AGAHNEENAIJ(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E50", Offset = "0x2AF4C50", VA = "0x182AF5E50")]
		private NativeArray<Entity> LNJBOOCCPIP(int KOHJDBBJEKM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF58F0", Offset = "0x2AF46F0", VA = "0x182AF58F0")]
		private void AFILCMPMJKA(NativeArray<Entity> GAHODJODMJJ, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class HideRemotePivotsNotInScope : IKEIJDHBAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private EntityQuery DAIJJFFLMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private EntityQuery FDHGHMAJGBH;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x26EA910", Offset = "0x26E9710", VA = "0x1826EA910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x26EAA00", Offset = "0x26E9800", VA = "0x1826EAA00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal static class AECBFKJNNGA
{
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public const string AACNNCACGNO = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x1EE18F0", Offset = "0x1EE06F0", VA = "0x181EE18F0")]
	public static NativeArray<T> HBPLCHGJNEG<T>(NativeArray<Entity> FBMJMNCDHDM, EntityManager LKEHNCAJHHL) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE47E0", Offset = "0x2AE35E0", VA = "0x182AE47E0")]
	public static void LAEFBOJIAPA(EntityQuery JFPFDEFJDBP, EntityManager LKEHNCAJHHL, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4920", Offset = "0x2AE3720", VA = "0x182AE4920")]
	public static void NEMIIJCJFIP(NativeArray<Entity> GAHODJODMJJ, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE46B0", Offset = "0x2AE34B0", VA = "0x182AE46B0")]
	public static void CJHLMFNABNI(NativeArray<Entity> GAHODJODMJJ, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class UpdateContainerPivotOnExitScopeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private EntityQuery KOGECCAAMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private EntityQuery CPOPPALLOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TransformService JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x273FC00", Offset = "0x273EA00", VA = "0x18273FC00", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x273FC90", Offset = "0x273EA90", VA = "0x18273FC90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x273FDD0", Offset = "0x273EBD0", VA = "0x18273FDD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x273FD90", Offset = "0x273EB90", VA = "0x18273FD90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x27400A0", Offset = "0x273EEA0", VA = "0x1827400A0")]
		private void PECPIDEHGKO(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x273F660", Offset = "0x273E460", VA = "0x18273F660")]
		private void EFKFBMCBMDD(NativeArray<Entity> GAHODJODMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x273FDF0", Offset = "0x273EBF0", VA = "0x18273FDF0")]
		private void PBOECKKHLJF(NativeArray<Entity> EINOFMLPJHG, NativeArray<LocalPoseData> JGADCCMGEIF, NativeArray<LocalPoseData> HFODADOKCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x273F770", Offset = "0x273E570", VA = "0x18273F770")]
		private void FDKBODHDOJB(NativeArray<LocalPoseData> HFODADOKCEH, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal class PostGameplayOnScopeChange : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private EntityQuery LLPPGDLKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private EntityQuery PPOBNDMKLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x272B280", Offset = "0x272A080", VA = "0x18272B280", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x272B370", Offset = "0x272A170", VA = "0x18272B370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x272B4C0", Offset = "0x272A2C0", VA = "0x18272B4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x272B2F0", Offset = "0x272A0F0", VA = "0x18272B2F0")]
		private void HIHNOHBHBBE(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class PreventDisembodiedScopesSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private EntityQuery IDJABCMMDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private EntityHierarchyParents OBEJKCLINIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private BFIAFBHOKLF PDKGNHLLFLM;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x272C960", Offset = "0x272B760", VA = "0x18272C960", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x272CB80", Offset = "0x272B980", VA = "0x18272CB80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x272CC20", Offset = "0x272BA20", VA = "0x18272CC20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x272C9F0", Offset = "0x272B7F0", VA = "0x18272C9F0")]
		private void MNFFEEFIGII(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class RemotePlayerScopeSystem : ScopeSystemBase<HEMEHLBJFKC>
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2730EF0", Offset = "0x272FCF0", VA = "0x182730EF0", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2731010", Offset = "0x272FE10", VA = "0x182731010")]
		protected RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2730FD0", Offset = "0x272FDD0", VA = "0x182730FD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : IKEIJDHBAML where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private EntityQuery EGICKNMHNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private EntityQuery AHNEKGJOFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private EntityQuery JOCMBLHEFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private EntityQuery JMBBDNFBMCE;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x3022290", Offset = "0x3021090", VA = "0x183022290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x3022490", Offset = "0x3021290", VA = "0x183022490", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x3022460", Offset = "0x3021260", VA = "0x183022460", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x30210A0", Offset = "0x301FEA0", VA = "0x1830210A0")]
		private void HCGMHFGHPIN(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x30218E0", Offset = "0x30206E0", VA = "0x1830218E0")]
		private void KDNOANLPMGP(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x3020C60", Offset = "0x301FA60", VA = "0x183020C60")]
		private void GOHGPJKLGME(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ);

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E32510", Offset = "0x2E31310", VA = "0x182E32510")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x167C6C0", Offset = "0x167B4C0", VA = "0x18167C6C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class DHBELNJEOID
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6180", Offset = "0x2AF4F80", VA = "0x182AF6180")]
	public static EntityQuery NJIBEHKJADN(SystemBase BFAGCHAFHGP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public abstract class COFDLBBLFME : IKEIJDHBAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private List<(EntityQuery, ComponentType)> MAPPBNAKEFG;

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEB20", Offset = "0x2AED920", VA = "0x182AEEB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEED20", Offset = "0x2AEDB20", VA = "0x182AEED20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEE70", Offset = "0x2AEDC70", VA = "0x182AEEE70")]
	protected COFDLBBLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct AOEOIHKBMAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public int KIJOKCLKDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public int FOEMNAHJKFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE70E0", Offset = "0x2AE5EE0", VA = "0x182AE70E0")]
	public static Entity PAAEKNCKHBI(AOEOIHKBMAM JANIFNADDOP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE70E0", Offset = "0x2AE5EE0", VA = "0x182AE70E0")]
	public static AOEOIHKBMAM PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(AOEOIHKBMAM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct PKIJMDIMCFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct KGFPMIPOKMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public readonly ComponentType MOBCJNJMMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public readonly NativeList<int> LGLGGCHFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public readonly NativeList<int> BIFPHOBHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public readonly NativeArray<Entity> FBMJMNCDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public readonly NativeArray<Entity> IBIIGMBFOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public readonly NativeArray<byte> HFLCHCKFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public readonly NativeArray<byte> MGGGHPDHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public readonly int NADGDGHIKPA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool EPOFMKLFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x26F0210", Offset = "0x26EF010", VA = "0x1826F0210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x26F0460", Offset = "0x26EF260", VA = "0x1826F0460")]
	public KGFPMIPOKMG(ComponentType MOBCJNJMMEJ, NativeList<int> LGLGGCHFNDI, NativeList<int> BIFPHOBHALN, NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> IBIIGMBFOIM, NativeArray<byte> HFLCHCKFKDH, NativeArray<byte> MGGGHPDHPFB, int KCCDKALEDML, int NADGDGHIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x26F0330", Offset = "0x26EF130", VA = "0x1826F0330")]
	private MJADMLMEADH PNJDJJFNFLF(NativeArray<byte> DEJEDNNJILK, int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	private T PNJDJJFNFLF<T>(NativeArray<byte> DEJEDNNJILK, int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x26F0290", Offset = "0x26EF090", VA = "0x1826F0290")]
	public MJADMLMEADH GKPDOKJPEED(int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	public T GKPDOKJPEED<T>(int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x26F02E0", Offset = "0x26EF0E0", VA = "0x1826F02E0")]
	public MJADMLMEADH OEIHOJFDKCP(int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	public T OEIHOJFDKCP<T>(int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x26F0130", Offset = "0x26EEF30", VA = "0x1826F0130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct OOPIHDDHHBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public readonly EntityQuery JFPFDEFJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public readonly NativeArray<BCDDMNDBEPL> GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly ComponentType MOBCJNJMMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public readonly int NADGDGHIKPA;

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x26FBE70", Offset = "0x26FAC70", VA = "0x1826FBE70")]
	public OOPIHDDHHBC(ComponentType MOBCJNJMMEJ, int KCCDKALEDML, int NADGDGHIKPA, EntityQuery JFPFDEFJDBP, NativeArray<BCDDMNDBEPL> GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x26FBE20", Offset = "0x26FAC20", VA = "0x1826FBE20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct LPFMODCHECN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public int AIPHGHFENPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public int AKFBHCBICCK;

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x661A30", Offset = "0x660830", VA = "0x180661A30")]
	public LPFMODCHECN(int AIPHGHFENPJ, int AKFBHCBICCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct BCDDMNDBEPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly int LBACAALGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly int MNKEEJPGFOP;

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x661A30", Offset = "0x660830", VA = "0x180661A30")]
	public BCDDMNDBEPL(int LBACAALGKLG, int MNKEEJPGFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct OJINANPDCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private readonly JLCDNMLCNEN FCDKMJOKGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private unsafe readonly byte* HFLCHCKFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private unsafe readonly byte* MGGGHPDHPFB;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x26FBC20", Offset = "0x26FAA20", VA = "0x1826FBC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JLCDNMLCNEN MELPOBPKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x73E0D0", Offset = "0x73CED0", VA = "0x18073E0D0")]
		get
		{
			return default(JLCDNMLCNEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x26FBB30", Offset = "0x26FA930", VA = "0x1826FBB30")]
	public MJADMLMEADH HDCMLBDCJJA(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x26FBA40", Offset = "0x26FA840", VA = "0x1826FBA40")]
	public MJADMLMEADH GFNEMCGEDBG(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2AD36D0", Offset = "0x2AD24D0", VA = "0x182AD36D0")]
	public T HDCMLBDCJJA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD36B0", Offset = "0x2AD24B0", VA = "0x182AD36B0")]
	public T GFNEMCGEDBG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x26FBC30", Offset = "0x26FAA30", VA = "0x1826FBC30")]
	public unsafe OJINANPDCIH(JLCDNMLCNEN FCDKMJOKGIE, int MNKEEJPGFOP, byte* HFLCHCKFKDH, byte* MGGGHPDHPFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class ABKHAGPBKLD
{
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] EJEHGEPFBHN;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[DefaultMember("Item")]
internal class KHMLGNFANIM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly Dictionary<ComponentType, OOPIHDDHHBC> OGMAGPEPNJD;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OOPIHDDHHBC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x26F27E0", Offset = "0x26F15E0", VA = "0x1826F27E0")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x26F2140", Offset = "0x26F0F40", VA = "0x1826F2140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x26F2870", Offset = "0x26F1670", VA = "0x1826F2870")]
	public KHMLGNFANIM(EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x26F1E60", Offset = "0x26F0C60", VA = "0x1826F1E60")]
	public Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x26F1EF0", Offset = "0x26F0CF0", VA = "0x1826F1EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x26F2190", Offset = "0x26F0F90", VA = "0x1826F2190")]
	private void HPONDOAJJHH(IEnumerable<NOBHGMEMAKH> OIAKNBEOLFI, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x26F2090", Offset = "0x26F0E90", VA = "0x1826F2090")]
	private static int ENPKMHCCDBP(NOBHGMEMAKH NKEPAMLDENG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x26F2590", Offset = "0x26F1390", VA = "0x1826F2590")]
	private static NativeArray<BCDDMNDBEPL> JMPOIHCJABA(NOBHGMEMAKH NKEPAMLDENG, Allocator JEOILJEOOOI = Allocator.Persistent)
	{
		return default(NativeArray<BCDDMNDBEPL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal interface ENNNNIELFIE
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNOGEFCJAHA(out NativeArray<int> GIFGJKHKEEO, Allocator JEOILJEOOOI);

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNONBKCFIBM(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM, out OOPIHDDHHBC OHDDMIOPOFC);

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CNONBKCFIBM(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM);

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGFPMIPOKMG LLEEHJNOAAG(ComponentType MOBCJNJMMEJ);

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDJKLEJHIMN PNHJFEJPCLI();

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBLEDCNCJNE(JobHandle AADBABLKHJM);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal interface OOGJNFIJHKM
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	KHMLGNFANIM MIENOIKPNME
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	FLHBGDILJIB FADKFKBHKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	NativeMultiHashMap<Entity, OJINANPDCIH> PHCMCBBDLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	JobHandle PADNOHKIAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ENJHCNHMIBP();

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IIOELKEIHEG();

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBLEDHIOMOJ(ComponentType MOBCJNJMMEJ, in KGFPMIPOKMG CKIPEJKPEDD);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MDJGBAHBHDF(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA);
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal struct IDJKLEJHIMN
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public struct IKALGBFDLKF : IEnumerator<OJINANPDCIH>, IEnumerator, IDisposable, IEnumerable<OJINANPDCIH>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly NativeMultiHashMap<Entity, OJINANPDCIH> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly Entity GEEFHDFLBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private NativeMultiHashMapIterator<Entity> LDCEDIKEFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private OJINANPDCIH MGGGHPDHPFB;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public OJINANPDCIH MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xAB2EB0", Offset = "0xAB1CB0", VA = "0x180AB2EB0", Slot = "4")]
			get
			{
				return default(OJINANPDCIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x351ECC0", Offset = "0x351DAC0", VA = "0x18351ECC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x351ED10", Offset = "0x351DB10", VA = "0x18351ED10")]
		internal IKALGBFDLKF(NativeMultiHashMap<Entity, OJINANPDCIH> AHGHAANFJKO, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x351EAB0", Offset = "0x351D8B0", VA = "0x18351EAB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x351EA80", Offset = "0x351D880", VA = "0x18351EA80")]
		public IKALGBFDLKF BALJJOIEHDJ()
		{
			return default(IKALGBFDLKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x351EB80", Offset = "0x351D980", VA = "0x18351EB80", Slot = "9")]
		private IEnumerator<OJINANPDCIH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x351EC20", Offset = "0x351DA20", VA = "0x18351EC20", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly OOGJNFIJHKM PBHDPEJBGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly JobHandle LDGJAMKHEKK;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public int NNCFHMJODME
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x26EAF50", Offset = "0x26E9D50", VA = "0x1826EAF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x26EAE70", Offset = "0x26E9C70", VA = "0x1826EAE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x1D363E0", Offset = "0x1D351E0", VA = "0x181D363E0")]
	public IDJKLEJHIMN(OOGJNFIJHKM PBHDPEJBGCP, JobHandle LDGJAMKHEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x26EABC0", Offset = "0x26E99C0", VA = "0x1826EABC0")]
	public bool LFPECKBHFGD(Allocator JEOILJEOOOI, out NativeKeyValueArrays<Entity, OJINANPDCIH> BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x26EAD00", Offset = "0x26E9B00", VA = "0x1826EAD00")]
	public bool OHNDCDIKBDP(Allocator JEOILJEOOOI, out (NativeArray<Entity> entities, int uniqueCount) BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x26EAAA0", Offset = "0x26E98A0", VA = "0x1826EAAA0")]
	public IKALGBFDLKF JADCFAPLAGP(Entity GEEFHDFLBEH)
	{
		return default(IKALGBFDLKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[DefaultMember("Item")]
internal class FLHBGDILJIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly List<OOPIHDDHHBC> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public OOPIHDDHHBC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x26E59B0", Offset = "0x26E47B0", VA = "0x1826E59B0")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x26E5660", Offset = "0x26E4460", VA = "0x1826E5660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x26E5A40", Offset = "0x26E4840", VA = "0x1826E5A40")]
	public FLHBGDILJIB(KHMLGNFANIM OGMAGPEPNJD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x26E5470", Offset = "0x26E4270", VA = "0x1826E5470")]
	public List<OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(List<OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x26E54F0", Offset = "0x26E42F0", VA = "0x1826E54F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x26E56A0", Offset = "0x26E44A0", VA = "0x1826E56A0")]
	private void HPONDOAJJHH(KHMLGNFANIM OGMAGPEPNJD, EntityManager LKEHNCAJHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class KHFNLIHOAGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private readonly global::IGNGPODGPHC<NOBHGMEMAKH> KCINBNOPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly World IBLOHKEKNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private NativeHashMap<int, Entity> CMAOMHCKFPP;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x26F1D70", Offset = "0x26F0B70", VA = "0x1826F1D70")]
	public KHFNLIHOAGK(ObjectInstantiationService JOIDICOJLFD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x26F0A20", Offset = "0x26EF820", VA = "0x1826F0A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x26F1D10", Offset = "0x26F0B10", VA = "0x1826F1D10")]
	public bool PAOEPCHIOGM(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x26F1100", Offset = "0x26EFF00", VA = "0x1826F1100")]
	private void HNFMJBMJBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x26F0BD0", Offset = "0x26EF9D0", VA = "0x1826F0BD0")]
	private EntityArchetype GKNJFAJHABG(EntityArchetype OOHCFEPBGBM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x26F17A0", Offset = "0x26F05A0", VA = "0x1826F17A0")]
	public static void NCGALFHGLGH(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM, NativeArray<Entity> ILCJJBCCAGM, NativeArray<EntityArchetype> BKODCBPDBIK, [Optional] NativeArray<Entity> ONMAHEPEOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x26F04C0", Offset = "0x26EF2C0", VA = "0x1826F04C0")]
	[Conditional("DEBUG_BUILD")]
	private static void ACPJOHFDGIN(NativeArray<EntityArchetype> PCOKMHJEFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x26F0630", Offset = "0x26EF430", VA = "0x1826F0630")]
	private static string DJJBAGBAKMA(EntityArchetype CEINJAHAPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x26F1BD0", Offset = "0x26F09D0", VA = "0x1826F1BD0")]
	[CompilerGenerated]
	internal static void NKMGFOJCFAM(ref Span<ComponentType> KNAJFGDPKPI, ComponentType IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x26F0870", Offset = "0x26EF670", VA = "0x1826F0870")]
	[CompilerGenerated]
	internal static void DMGAMDDOCDE(Span<ComponentType> DEJEDNNJILK, ref Span<ComponentType> KNAJFGDPKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x26F0AF0", Offset = "0x26EF8F0", VA = "0x1826F0AF0")]
	[CompilerGenerated]
	internal static void EPDINGLADHB(Span<ComponentType> DEJEDNNJILK, ref Span<ComponentType> KNAJFGDPKPI, ComponentType EGABNOLNFHL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : IKEIJDHBAML, FDFFINEAOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private struct OCDBFAEFGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public NANEHBACIAB dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public OCDBFAEFGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct BGCOJNMGLJI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeArray<byte> MGGGHPDHPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			[ReadOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			[ReadOnly]
			public NativeArray<Entity> IBIIGMBFOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public int KCCDKALEDML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public NANEHBACIAB AMMLAKHCLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public ComponentType MOBCJNJMMEJ;

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x3518B50", Offset = "0x3517950", VA = "0x183518B50")]
			internal void POIJCEOICMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x3518D30", Offset = "0x3517B30", VA = "0x183518D30", Slot = "5")]
			public void ReadFromDisplayClass(ref OCDBFAEFGHA CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x3518B20", Offset = "0x3517920", VA = "0x183518B20", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x3518B30", Offset = "0x3517930", VA = "0x183518B30")]
			public void LONPEHHIFCO(ApplyPropertyDifferences OJEDNGBIKHJ, ref OCDBFAEFGHA CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private JobHandle FIOOOJDOILM;

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8BF0", Offset = "0x2AE79F0", VA = "0x182AE8BF0")]
		public void NBKICENBLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8850", Offset = "0x2AE7650", VA = "0x182AE8850", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8C00", Offset = "0x2AE7A00", VA = "0x182AE8C00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2AE88B0", Offset = "0x2AE76B0", VA = "0x182AE88B0")]
		private bool LEJMLOLKJEH(JobHandle GINKINFGNEP, int DBMJEOKPFJK, out JobHandle HGFNJFOEEBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	public abstract class ComputePropertyDifferences : IKEIJDHBAML, FDFFINEAOHD, CDAFEBOKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[BurstCompile]
		internal struct JFBEBAGCFEB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			[ReadOnly]
			public NativeArray<byte> EJDBONNMMDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			[ReadOnly]
			public NativeArray<byte> NCIKCPKLKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			[ReadOnly]
			public NativeArray<BCDDMNDBEPL> LBNDLOLGMOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			[WriteOnly]
			public NativeList<LPFMODCHECN>.ParallelWriter EKMDPNPLADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int GEPNPGHOBIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public int GLIHDHAEEAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x351F7F0", Offset = "0x351E5F0", VA = "0x18351F7F0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x351F930", Offset = "0x351E730", VA = "0x18351F930")]
			private unsafe int MCFODCBHGPN(byte* AELLFIOGOHK, byte* AFOPPLDIMJL)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000106")]
		[BurstCompile]
		internal struct ILMKIIPAAMK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			[WriteOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[WriteOnly]
			public NativeList<int> AJIAONFFBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			public NativeList<LPFMODCHECN> NKIDNGPMNIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x351ED30", Offset = "0x351DB30", VA = "0x18351ED30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[BurstCompile]
		internal struct FNIFCNLMEHC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[WriteOnly]
			public NativeArray<byte> BOCOGMLMHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			[ReadOnly]
			public NANEHBACIAB KLJAIKAEOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public int KCCDKALEDML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x351C2D0", Offset = "0x351B0D0", VA = "0x18351C2D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		internal struct FEFJBCDDGMN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, OJINANPDCIH> ABCKJKCJCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			[ReadOnly]
			public NativeArray<byte> HFLCHCKFKDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			[ReadOnly]
			public NativeArray<byte> MGGGHPDHPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			[ReadOnly]
			public NativeArray<BCDDMNDBEPL> FDGKFNNIPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			[ReadOnly]
			public NativeList<int> BIFPHOBHALN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			[ReadOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public int IDGLNJOODCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public int NADGDGHIKPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x351BA30", Offset = "0x351A830", VA = "0x18351BA30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static readonly ProfilerMarker HFFLPBGKLCB;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static readonly ProfilerMarker LHCPPGHLFHL;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private static readonly ProfilerMarker GDFHFKNOPJG;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static readonly ProfilerMarker BDCKOLMOJAM;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static readonly ProfilerMarker LNJKEENAKOC;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly ProfilerMarker MHAPLOBPLDG;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private static readonly ProfilerMarker MGMAGANFCLL;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static readonly ProfilerMarker KGBMPNKIBFB;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private static readonly ProfilerMarker EJAHOKMFGKK;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private static readonly ProfilerMarker ICEKLAOGBOF;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private static readonly ProfilerMarker LCGCFHENCCK;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static readonly ProfilerMarker LLPDGBKLMIM;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private static readonly ProfilerMarker HBJCPEAJCBO;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static readonly ProfilerMarker KCDINPDGCHE;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private static readonly ProfilerMarker LNKJBOMHCHC;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private static readonly ProfilerMarker HGFOBFEGEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private OOGJNFIJHKM PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private ApplyPropertyDifferences IFIIKHCNKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private EntityQuery PHLPAFIELFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private EntityQuery AJFALAKCPBE;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected abstract ApplyPropertyDifferences ENAAOEAAPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		internal World EKGNNGCIOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0880", Offset = "0x2AEF680", VA = "0x182AF0880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2AF08D0", Offset = "0x2AEF6D0", VA = "0x182AF08D0")]
		internal OOPIHDDHHBC JPFLOFLDECE(ComponentType MOBCJNJMMEJ)
		{
			return default(OOPIHDDHHBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0670", Offset = "0x2AEF470", VA = "0x182AF0670", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "15")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1D80", Offset = "0x2AF0B80", VA = "0x182AF1D80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1F00", Offset = "0x2AF0D00", VA = "0x182AF1F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1EB0", Offset = "0x2AF0CB0", VA = "0x182AF1EB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF03D0", Offset = "0x2AEF1D0", VA = "0x182AF03D0")]
		private void HBHPPBAOFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF07C0", Offset = "0x2AEF5C0", VA = "0x182AF07C0")]
		private void INCMDNPILLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFD60", Offset = "0x2AEEB60", VA = "0x182AEFD60")]
		internal void GMIGFAPKFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F50", Offset = "0x2AEFD50", VA = "0x182AF0F50")]
		private void NFCNLMCJHOB(NativeArray<Entity> ILCJJBCCAGM, NativeArray<RRObjectPrefabData> JKOPBJFEFEF, ref NativeArray<Entity> KDHNBJIDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1A50", Offset = "0x2AF0850", VA = "0x182AF1A50")]
		internal void OKKCHMJBCGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1310", Offset = "0x2AF0110", VA = "0x182AF1310")]
		internal void OBCFLPAOMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0970", Offset = "0x2AEF770", VA = "0x182AF0970")]
		private void KABEHEPCGAC(OOPIHDDHHBC OHDDMIOPOFC, bool HMEODMGMEGG, ref JobHandle AIDIOJAAFGP, ref JobHandle KAPIJFGKJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF150", Offset = "0x2AEDF50", VA = "0x182AEF150")]
		internal bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF180", Offset = "0x2AEDF80", VA = "0x182AEF180")]
		private bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, bool HMEODMGMEGG, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0D90", Offset = "0x2AEFB90", VA = "0x182AF0D90")]
		internal (NativeList<int>, NativeList<int>) NAOECJJCONG(NativeList<LPFMODCHECN> NKIDNGPMNIO, int CHMDLBBFMNF, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C60", Offset = "0x2AEFA60", VA = "0x182AF0C60")]
		internal static NativeArray<Entity> MKPDAOMPGOI(EntityQuery JFPFDEFJDBP, out JobHandle FMGGAIEOAAJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0D10", Offset = "0x2AEFB10", VA = "0x182AF0D10")]
		internal static NativeArray<byte> MPCBBJPLGID(int HFAIGCGNPJJ, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2020", Offset = "0x2AF0E20", VA = "0x182AF2020")]
		internal static NativeArray<byte> PCMGJIFBGKI(EntityQuery JFPFDEFJDBP, int DBMJEOKPFJK, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2AF06C0", Offset = "0x2AEF4C0", VA = "0x182AF06C0")]
		internal static NativeArray<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP, out JobHandle DJHMNGMPAKO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFB30", Offset = "0x2AEE930", VA = "0x182AEFB30")]
		internal NativeArray<byte> DGBMLKNPFDC(NativeArray<Entity> FBMJMNCDHDM, OOPIHDDHHBC OHDDMIOPOFC, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1180", Offset = "0x2AEFF80", VA = "0x182AF1180")]
		internal JobHandle NOHHIGNKGIH(in KGFPMIPOKMG JANIFNADDOP, in OOPIHDDHHBC OHDDMIOPOFC, NativeMultiHashMap<Entity, OJINANPDCIH> ABCKJKCJCPN, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBACF0", Offset = "0x1EB9AF0", VA = "0x181EBACF0")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x1EBACF0", Offset = "0x1EB9AF0", VA = "0x181EBACF0")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL, JobHandle GOLOIKHJMLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal abstract class HONFBOGIPMF : PropagateTagsBase<global::GHPEDNEJKIN, global::EILCDGAAILO, HONFBOGIPMF.JBNNOCDHICP>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public struct JBNNOCDHICP : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x26EA8A0", Offset = "0x26E96A0", VA = "0x1826EA8A0")]
	protected HONFBOGIPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x26EA860", Offset = "0x26E9660", VA = "0x1826EA860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class JCNKOHLNAFM : PropagateTagsBase<GGDHNMAPAGC, global::DBMDLLBHCCH, JCNKOHLNAFM.ICDCINMBABM>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public struct ICDCINMBABM : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x26EE4B0", Offset = "0x26ED2B0", VA = "0x1826EE4B0")]
	protected JCNKOHLNAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x26EE470", Offset = "0x26ED270", VA = "0x1826EE470", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public class OHMOPMJJDKB : IKMBABCDPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct NBGBOCPANJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public NBGBOCPANJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DDIHMJEEMOL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct MLMMHHHANLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000111")]
			[NoAlias]
			public struct MANHBOFMDNE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime ENILDBPKNCE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> BCIMJMKNBHB;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x3522AB0", Offset = "0x35218B0", VA = "0x183522AB0")]
			public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x3522A60", Offset = "0x3521860", VA = "0x183522A60")]
			public MANHBOFMDNE LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MANHBOFMDNE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public NativeArray<int> DEJEDNNJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private MLMMHHHANLA JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MLMMHHHANLA.MANHBOFMDNE* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x351A8F0", Offset = "0x35196F0", VA = "0x18351A8F0")]
		internal void POIJCEOICMD(ref AuthoredLocalPoseData AFCNGEGHGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
		public void ReadFromDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x27EFE20", Offset = "0x27EEC20", VA = "0x1827EFE20", Slot = "6")]
		public void WriteToDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x351A6F0", Offset = "0x35194F0", VA = "0x18351A6F0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x351A860", Offset = "0x3519660", VA = "0x18351A860")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref MLMMHHHANLA.MANHBOFMDNE PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x351A7E0", Offset = "0x35195E0", VA = "0x18351A7E0")]
		public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ, ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x351A770", Offset = "0x3519570", VA = "0x18351A770")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x26FB670", Offset = "0x26FA470", VA = "0x1826FB670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public OHMOPMJJDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x26FB440", Offset = "0x26FA240", VA = "0x1826FB440", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x26FB2E0", Offset = "0x26FA0E0", VA = "0x1826FB2E0")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public class PFEBNMLDBNN : IKMBABCDPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct NJCMAMLFFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public NJCMAMLFFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OCONCNFPECJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		private struct ADBCNNNDBIF
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			[NoAlias]
			public struct LPAMGAOACHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime JOAIOBDGKIN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> BEMKKGLAMNI;

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x3518620", Offset = "0x3517420", VA = "0x183518620")]
			public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x35185A0", Offset = "0x35173A0", VA = "0x1835185A0")]
			public LPAMGAOACHH LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(LPAMGAOACHH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NativeList<Entity> OPCIALJIHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private ADBCNNNDBIF JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ADBCNNNDBIF.LPAMGAOACHH* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x35232B0", Offset = "0x35220B0", VA = "0x1835232B0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, SplinePointData EFCGBFLJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x3523330", Offset = "0x3522130", VA = "0x183523330", Slot = "5")]
		public void ReadFromDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x3523340", Offset = "0x3522140", VA = "0x183523340", Slot = "6")]
		public void WriteToDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x3523040", Offset = "0x3521E40", VA = "0x183523040", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x35231E0", Offset = "0x3521FE0", VA = "0x1835231E0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref ADBCNNNDBIF.LPAMGAOACHH PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3523150", Offset = "0x3521F50", VA = "0x183523150")]
		public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ, ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x35230E0", Offset = "0x3521EE0", VA = "0x1835230E0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x2726410", Offset = "0x2725210", VA = "0x182726410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public PFEBNMLDBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x27261E0", Offset = "0x2724FE0", VA = "0x1827261E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x2726080", Offset = "0x2724E80", VA = "0x182726080")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class OJGBHFKCJPI : IKMBABCDPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery FNAJLFPJAMF;

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x26FB8F0", Offset = "0x26FA6F0", VA = "0x1826FB8F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x26FB980", Offset = "0x26FA780", VA = "0x1826FB980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public OJGBHFKCJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class FPDBMMINPKE : IKMBABCDPGL, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NCDNPKIEBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NativeHashMap<NMEJDFJAOOA, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public NCDNPKIEBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FMIFEIFJMHK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct LAPBODDGOML
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct NLJBKLBFFEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400039C")]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400039D")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HKIKOLJKOJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NCMBEACEFPL;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x3520EE0", Offset = "0x351FCE0", VA = "0x183520EE0")]
			public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x3520E60", Offset = "0x351FC60", VA = "0x183520E60")]
			public NLJBKLBFFEL LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(NLJBKLBFFEL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public NativeHashMap<NMEJDFJAOOA, Entity> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private LAPBODDGOML JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LAPBODDGOML.NLJBKLBFFEL* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x351C250", Offset = "0x351B050", VA = "0x18351C250")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
		public void ReadFromDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x27EFE20", Offset = "0x27EEC20", VA = "0x1827EFE20", Slot = "6")]
		public void WriteToDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x351C000", Offset = "0x351AE00", VA = "0x18351C000", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x351C1A0", Offset = "0x351AFA0", VA = "0x18351C1A0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref LAPBODDGOML.NLJBKLBFFEL PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x351C110", Offset = "0x351AF10", VA = "0x18351C110")]
		public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ, ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x351C0A0", Offset = "0x351AEA0", VA = "0x18351C0A0")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6790", Offset = "0x26E5590", VA = "0x1826E6790", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x26E69F0", Offset = "0x26E57F0", VA = "0x1826E69F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public FPDBMMINPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x26E67F0", Offset = "0x26E55F0", VA = "0x1826E67F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x26E6630", Offset = "0x26E5430", VA = "0x1826E6630")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	public class PostLoadInitializeEmbodiment : IKEIJDHBAML, FDFFINEAOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct NOBGLALBIFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public NativeList<NMEJDFJAOOA> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
			public NOBGLALBIFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct DDBFAFGDOKI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000120")]
			private struct JJJMBMHAJFM
			{
				[Cpp2IlInjected.Token(Token = "0x2000121")]
				[NoAlias]
				public struct BIBGDKACDOE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B5")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LJPEGFFCJJB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> LPKJKPMAGGP;

				[Cpp2IlInjected.Token(Token = "0x60007C4")]
				[Cpp2IlInjected.Address(RVA = "0x3520450", Offset = "0x351F250", VA = "0x183520450")]
				public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007C5")]
				[Cpp2IlInjected.Address(RVA = "0x35203D0", Offset = "0x351F1D0", VA = "0x1835203D0")]
				public BIBGDKACDOE LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(BIBGDKACDOE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public NativeList<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public NativeList<NMEJDFJAOOA> FCIMMLKHDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public BufferFromEntity<ChildrenData> GMMBHFBGHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public ComponentDataFromEntity<SerializedEmbodiedData> EGEINCHHHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> ICMCNPOMNAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private JJJMBMHAJFM JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JJJMBMHAJFM.BIBGDKACDOE* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x351A620", Offset = "0x3519420", VA = "0x18351A620")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x351A1F0", Offset = "0x3518FF0", VA = "0x18351A1F0")]
			internal void AHPPNJDCFGE(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x351A410", Offset = "0x3519210", VA = "0x18351A410")]
			internal void MHKDKCMMGOB(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x351A650", Offset = "0x3519450", VA = "0x18351A650", Slot = "5")]
			public void ReadFromDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x351A6A0", Offset = "0x35194A0", VA = "0x18351A6A0", Slot = "6")]
			public void WriteToDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x351A270", Offset = "0x3519070", VA = "0x18351A270", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x351A570", Offset = "0x3519370", VA = "0x18351A570")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JJJMBMHAJFM.BIBGDKACDOE PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x351A380", Offset = "0x3519180", VA = "0x18351A380")]
			public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ, ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0x351A310", Offset = "0x3519110", VA = "0x18351A310")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private EntityQuery JEDIHPJPGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery FICAHAEACNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private ProfilerMarker PBHBLBOAIEH;

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x272BC30", Offset = "0x272AA30", VA = "0x18272BC30", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x272C500", Offset = "0x272B300", VA = "0x18272C500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x272C590", Offset = "0x272B390", VA = "0x18272C590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x272C050", Offset = "0x272AE50", VA = "0x18272C050")]
		private void IDNMGGHJMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x272BCE0", Offset = "0x272AAE0", VA = "0x18272BCE0")]
		private NativeArray<AHCKAEEHFIB> HKPBMMABDCH(NativeArray<NMEJDFJAOOA> FCIMMLKHDCA)
		{
			return default(NativeArray<AHCKAEEHFIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x272B7E0", Offset = "0x272A5E0", VA = "0x18272B7E0")]
		private void DJDHPKIOLBP(NativeList<Entity> FBMJMNCDHDM, NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x272B5F0", Offset = "0x272A3F0", VA = "0x18272B5F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BPIIJFOCCLI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void BBKLLPAMBEI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x272C3C0", Offset = "0x272B1C0", VA = "0x18272C3C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x272BA30", Offset = "0x272A830", VA = "0x18272BA30")]
		public static EntityQuery FGDPGIDECFK(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public class LCICNAGLPHM : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct JPBFPLOPAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public NativeHashMap<NMEJDFJAOOA, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public JPBFPLOPAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x3518A40", Offset = "0x3517840", VA = "0x183518A40")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EMNNMNEAMOI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		private struct JLKLPEALCDA
		{
			[Cpp2IlInjected.Token(Token = "0x2000126")]
			[NoAlias]
			public struct KDNLOCBNAPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003C3")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40003C4")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime OPJHNHKMNMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003C5")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HKIKOLJKOJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex IHDKDECCAIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NCMBEACEFPL;

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x3520560", Offset = "0x351F360", VA = "0x183520560")]
			public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x35204B0", Offset = "0x351F2B0", VA = "0x1835204B0")]
			public KDNLOCBNAPC LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(KDNLOCBNAPC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public NativeHashMap<NMEJDFJAOOA, Entity> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private JLKLPEALCDA JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JLKLPEALCDA.KDNLOCBNAPC* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x351B530", Offset = "0x351A330", VA = "0x18351B530")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, int GHHKILHNDGM, ref ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x351A9C0", Offset = "0x35197C0", VA = "0x18351A9C0", Slot = "5")]
		public void ReadFromDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x27EFE20", Offset = "0x27EEC20", VA = "0x1827EFE20", Slot = "6")]
		public void WriteToDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x351B260", Offset = "0x351A060", VA = "0x18351B260", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x351B460", Offset = "0x351A260", VA = "0x18351B460")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JLKLPEALCDA.KDNLOCBNAPC PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x351B3C0", Offset = "0x351A1C0", VA = "0x18351B3C0")]
		public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ, ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x351B350", Offset = "0x351A150", VA = "0x18351B350")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x26F54E0", Offset = "0x26F42E0", VA = "0x1826F54E0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x26F5770", Offset = "0x26F4570", VA = "0x1826F5770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public LCICNAGLPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x26F5540", Offset = "0x26F4340", VA = "0x1826F5540", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x26F5380", Offset = "0x26F4180", VA = "0x1826F5380")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public class PLPPACFFCAP : IKEIJDHBAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private EntityQuery JEDIHPJPGKK;

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x2726E70", Offset = "0x2725C70", VA = "0x182726E70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x2726F00", Offset = "0x2725D00", VA = "0x182726F00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public PLPPACFFCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public class AMAAPGIIJHF : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6710", Offset = "0x2AE5510", VA = "0x182AE6710", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE68B0", Offset = "0x2AE56B0", VA = "0x182AE68B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6500", Offset = "0x2AE5300", VA = "0x182AE6500")]
	private void FFOKAPOGCOP(NativeList<EntityArchetype> PCOKMHJEFGC, NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5F00", Offset = "0x2AE4D00", VA = "0x182AE5F00")]
	private void AFHJJEPEJLJ(NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public AMAAPGIIJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6770", Offset = "0x2AE5570", VA = "0x182AE6770")]
	[CompilerGenerated]
	internal static Span<int> IGCPCFNHMGP(EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
	public class PreSerializeRemoveEntities : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery AJFALAKCPBE;

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x272C680", Offset = "0x272B480", VA = "0x18272C680", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x272C8D0", Offset = "0x272B6D0", VA = "0x18272C8D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(NGBOFDOMIKJ))]
internal sealed class MAINBLDADFG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public MAINBLDADFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(ILHIKHAIJNM))]
internal sealed class CNPNLBBJAOK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public CNPNLBBJAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(BINCJPPOHMK))]
internal sealed class PMAGEIGMADI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public PMAGEIGMADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(FNPHKNFELIE))]
internal sealed class HODOFLBPGBO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public HODOFLBPGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(KAHDFHOCEMC))]
internal sealed class MNIPDJHOGDG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public MNIPDJHOGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KIABADAKEGB))]
internal sealed class PMDCPHBIDCC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public PMDCPHBIDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(HEEHHHHFPDD))]
internal sealed class KBAINBIJCDH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public KBAINBIJCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANCFDIJGMDO))]
internal sealed class BOKPOOFDOKN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public BOKPOOFDOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(LKLKPHFEOKG))]
internal sealed class DNGIILCGBEO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public DNGIILCGBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(LKLKPHFEOKG))]
[UpdateAfter(typeof(DNGIILCGBEO))]
internal sealed class CDBKMKJLKKC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public CDBKMKJLKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		[BurstCompile]
		private struct IIPNAIJDHIF : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private const float AHIMGNBOEJC = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> GPCFFPMNMLM;

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x351E770", Offset = "0x351D570", VA = "0x18351E770", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x351E970", Offset = "0x351D770", VA = "0x18351E970")]
			private bool OEJCMGLLIOO(float3 HFFCNNKMKHP, float3 BEIKMLIBFDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x351E930", Offset = "0x351D730", VA = "0x18351E930")]
			private bool NPFGHMKIMNJ(quaternion HFFCNNKMKHP, quaternion BEIKMLIBFDO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		[BurstCompile]
		private struct KFFLJJOOPHA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> GMEGLFBPIDK;

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x35207C0", Offset = "0x351F5C0", VA = "0x1835207C0", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private const string NHFDFKOOOOF = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private const string CBDDNPHPNBI = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string KABICPHJLAF = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private static readonly CGJHBFGPOOL MKLINGFHCIM;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private static readonly CGJHBFGPOOL BPEILADNFEG;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly CGJHBFGPOOL FIKEHMDLMKE;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly ProfilerMarker EELFJGIGFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4700", Offset = "0x2AF3500", VA = "0x182AF4700", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4770", Offset = "0x2AF3570", VA = "0x182AF4770", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF47A0", Offset = "0x2AF35A0", VA = "0x182AF47A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public class RegisterTransforms : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct PJOACMEEDMC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200013A")]
			private struct DJDPHGMGJMA
			{
				[Cpp2IlInjected.Token(Token = "0x200013B")]
				public struct CKMANEENGDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003ED")]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003EE")]
					public LambdaParameterValueProvider_IComponentData<INDEJLDCMLL>.Runtime JPCBBCIAMNI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003EF")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FAIKLINAJOF;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003EA")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003EB")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<INDEJLDCMLL> JKAAIMKLMDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003EC")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> JCDIDPCDLIJ;

				[Cpp2IlInjected.Token(Token = "0x600081E")]
				[Cpp2IlInjected.Address(RVA = "0x351AA90", Offset = "0x3519890", VA = "0x18351AA90")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081F")]
				[Cpp2IlInjected.Address(RVA = "0x351A9D0", Offset = "0x35197D0", VA = "0x18351A9D0")]
				public CKMANEENGDF LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(CKMANEENGDF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private DJDPHGMGJMA JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DJDPHGMGJMA.CKMANEENGDF* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x35246B0", Offset = "0x35234B0", VA = "0x1835246B0")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB, Transform BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x3524460", Offset = "0x3523260", VA = "0x183524460", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x35245D0", Offset = "0x35233D0", VA = "0x1835245D0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJDPHGMGJMA.CKMANEENGDF PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x35245C0", Offset = "0x35233C0", VA = "0x1835245C0")]
			public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x3524550", Offset = "0x3523350", VA = "0x183524550")]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct CPBEDJELIGE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200013D")]
			private struct EEBIJFAKLBA
			{
				[Cpp2IlInjected.Token(Token = "0x200013E")]
				[NoAlias]
				public struct MGHMNDLNIIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003F4")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003F5")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<INDEJLDCMLL>.Runtime JPCBBCIAMNI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F2")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003F3")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<INDEJLDCMLL> JKAAIMKLMDE;

				[Cpp2IlInjected.Token(Token = "0x6000824")]
				[Cpp2IlInjected.Address(RVA = "0x35197A0", Offset = "0x35185A0", VA = "0x1835197A0")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000825")]
				[Cpp2IlInjected.Address(RVA = "0x351ADB0", Offset = "0x3519BB0", VA = "0x18351ADB0")]
				public MGHMNDLNIIC LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(MGHMNDLNIIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private EEBIJFAKLBA JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EEBIJFAKLBA.MGHMNDLNIIC* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x35198B0", Offset = "0x35186B0", VA = "0x1835198B0")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x3519710", Offset = "0x3518510", VA = "0x183519710", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x3519800", Offset = "0x3518600", VA = "0x183519800")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref EEBIJFAKLBA.MGHMNDLNIIC PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x35197A0", Offset = "0x35185A0", VA = "0x1835197A0")]
			public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private KPIOIDPOAPF CAIOPLIIMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery NDMNKFHMCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private EntityQuery JKELFFGDBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private EntityQuery HPCILLJOCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private EntityQuery DDEINPBMMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery FLHELAMPBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private ProfilerMarker LCDJLPNKIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private EntityQuery AAINMHLOKDI;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2730090", Offset = "0x272EE90", VA = "0x182730090", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2730970", Offset = "0x272F770", VA = "0x182730970", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2730B90", Offset = "0x272F990", VA = "0x182730B90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2730C70", Offset = "0x272FA70", VA = "0x182730C70")]
		private void PPELDHCHHMJ(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x27300E0", Offset = "0x272EEE0", VA = "0x1827300E0")]
		private void IOJMOKCIKNO(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2730B40", Offset = "0x272F940", VA = "0x182730B40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x272FAA0", Offset = "0x272E8A0", VA = "0x18272FAA0")]
		private void CPKICJNHJPO(NativeArray<Entity> FBMJMNCDHDM, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x272FBE0", Offset = "0x272E9E0", VA = "0x18272FBE0")]
		[BurstCompile]
		internal static void FAELDAKLBND(NativeArray<INDEJLDCMLL> GIOJGEAAIGM, ComponentDataFromEntity<INDEJLDCMLL> KBPACPMPIMI, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void NIDLIBPLDNN(Transform BCHADNCHEKP, Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void NPJCMGIJMNE(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void CPDILHHAHEB(int AIPHGHFENPJ, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2730510", Offset = "0x272F310", VA = "0x182730510")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void OPLEJMMLBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x27306F0", Offset = "0x272F4F0", VA = "0x1827306F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x272FEF0", Offset = "0x272ECF0", VA = "0x18272FEF0")]
		public static EntityQuery GODINDNLLMP(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2730340", Offset = "0x272F140", VA = "0x182730340")]
		public static EntityQuery NJKKLDIFDNH(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		[BurstCompile]
		private struct CLACACONJLJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> GPCFFPMNMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x3519300", Offset = "0x3518100", VA = "0x183519300", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000141")]
		[BurstCompile]
		private struct JCEDPFPGCOO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x351EE10", Offset = "0x351DC10", VA = "0x18351EE10", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000142")]
		[BurstCompile]
		private struct IICPLHBHFEF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> GMEGLFBPIDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x351E670", Offset = "0x351D470", VA = "0x18351E670", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private const string NHFDFKOOOOF = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private const string CBDDNPHPNBI = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private const string KABICPHJLAF = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private static readonly CGJHBFGPOOL MKLINGFHCIM;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private static readonly CGJHBFGPOOL BPEILADNFEG;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private static readonly CGJHBFGPOOL FIKEHMDLMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private JobHandle BCHMEFEMADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private EntityQuery EFJEBABOMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private EntityQuery HJAKPLOEGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private EntityQuery MJIKGPBIFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TransformAccessArray GGLKPEACCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TransformAccessArray LIHDEBMOAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TransformAccessArray FPBDBLCKLAP;

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4C30", Offset = "0x2AF3A30", VA = "0x182AF4C30", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4E00", Offset = "0x2AF3C00", VA = "0x182AF4E00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4FD0", Offset = "0x2AF3DD0", VA = "0x182AF4FD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5060", Offset = "0x2AF3E60", VA = "0x182AF5060", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xA51550", Offset = "0xA50350", VA = "0x180A51550")]
		internal JobHandle GEIIGNLGFLC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5090", Offset = "0x2AF3E90", VA = "0x182AF5090", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4C80", Offset = "0x2AF3A80", VA = "0x182AF4C80")]
		private NativeArray<Entity> NHEOCOGPCFH(NativeArray<INDEJLDCMLL> LGLGGCHFNDI, NativeList<Entity> ILCJJBCCAGM, TransformAccessArray FECNFHOPJJE, TransformAccessArray NAMIGGEMGEK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public class ADBJNMLEGAN : IKEIJDHBAML, CDAFEBOKDJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private CMEEFJNDPID OAACGCFNLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private MFLHDAEOBPP IMFCFJELJOA;

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3B40", Offset = "0x2AE2940", VA = "0x182AE3B40", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3E20", Offset = "0x2AE2C20", VA = "0x182AE3E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3C40", Offset = "0x2AE2A40", VA = "0x182AE3C40")]
	private static void LONBOHKOAAL(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3A40", Offset = "0x2AE2840", VA = "0x182AE3A40")]
	private static Transform AGDAIJOCIIH(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public ADBJNMLEGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	public class L2PToL2WHierarchy : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		[BurstCompile]
		private struct JEHIBCPBPMB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> ADIINOLLBBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> GKPACHGNFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> ALANNIIDHOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> GIOOLDCFFAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public ArchetypeChunkComponentType<LocalToWorldData> GFBOPBKNLLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> GABAHDLHLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public uint AEPGONMKGBO;

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0x351F390", Offset = "0x351E190", VA = "0x18351F390")]
			[Conditional("DEBUG_BUILD")]
			private void FHMJJINLJDI(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x351F0B0", Offset = "0x351DEB0", VA = "0x18351F0B0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x351F460", Offset = "0x351E260", VA = "0x18351F460")]
			private void NHEIJOMNPLK(float4x4 NJANOBLLHHA, Entity GEEFHDFLBEH, bool LNFKOFMNKEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private EntityQuery KCHNAHKCDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private EntityQuery KNEGHICNEHB;

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x26F3550", Offset = "0x26F2350", VA = "0x1826F3550", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x26F3670", Offset = "0x26F2470", VA = "0x1826F3670", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
public class KFLEDGAOGNG : DBEHBMCDNIE
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[BurstCompile]
	private struct ACFDEOCKIGP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> ADIINOLLBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public ArchetypeChunkComponentType<LocalToWorldData> GFBOPBKNLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x35183B0", Offset = "0x35171B0", VA = "0x1835183B0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x35184B0", Offset = "0x35172B0", VA = "0x1835184B0")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private EntityQuery KCHNAHKCDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x26EFE00", Offset = "0x26EEC00", VA = "0x1826EFE00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x26EFF30", Offset = "0x26EED30", VA = "0x1826EFF30", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public KFLEDGAOGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public class JDGKDHAHBBO : DBEHBMCDNIE
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[BurstCompile]
	private struct EHBNHDHMMAE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> IJHPKNLIJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public ArchetypeChunkComponentType<WorldPoseData> OMPLHMDAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> ACNCLNFGPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> BFHMONPABJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x351AE30", Offset = "0x3519C30", VA = "0x18351AE30", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x351B1E0", Offset = "0x3519FE0", VA = "0x18351B1E0")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x26EE520", Offset = "0x26ED320", VA = "0x1826EE520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x26EE630", Offset = "0x26ED430", VA = "0x1826EE630", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public JDGKDHAHBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public class KIJDBALHHDP : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[BurstCompile]
	private struct CPHELAJIMLM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> PDFJLIDONJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BEIEHFAKLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> ECMMBBKJIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public ArchetypeChunkComponentType<LocalToParentData> FOPCECKNIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x3519990", Offset = "0x3518790", VA = "0x183519990", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x351A0D0", Offset = "0x3518ED0", VA = "0x18351A0D0")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x26F2B80", Offset = "0x26F1980", VA = "0x1826F2B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x26F2CB0", Offset = "0x26F1AB0", VA = "0x1826F2CB0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	public KIJDBALHHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class FJKACBADHOD : PropagateTagsBase<global::FHJAIHIHEFP, global::LGPDLCPKLCK, FJKACBADHOD.MFEFNLPKLJK>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct MFEFNLPKLJK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x26E48F0", Offset = "0x26E36F0", VA = "0x1826E48F0")]
	protected FJKACBADHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x26E48B0", Offset = "0x26E36B0", VA = "0x1826E48B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[AAFIHLNHDHN(LBGCMANLNFC.Game)]
public class PFFJFKNCGNH : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x27266D0", Offset = "0x27254D0", VA = "0x1827266D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x2726740", Offset = "0x2725540", VA = "0x182726740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public PFFJFKNCGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[AAFIHLNHDHN(LBGCMANLNFC.Loading)]
public class BPIHAHBKMAO : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x65B5A0", Offset = "0x65A3A0", VA = "0x18065B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC910", Offset = "0x2AEB710", VA = "0x182AEC910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public BPIHAHBKMAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public sealed class OHBEPLANKDB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public OHBEPLANKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(OHBEPLANKDB))]
public sealed class CNDMKJANPBA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public CNDMKJANPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(OHBEPLANKDB))]
[UpdateAfter(typeof(CNDMKJANPBA))]
public sealed class EADAPMIJCBG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public EADAPMIJCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[AAFIHLNHDHN(LBGCMANLNFC.Saving)]
public class OMIDCKKPCGF : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x65B5A0", Offset = "0x65A3A0", VA = "0x18065B5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x26FBCD0", Offset = "0x26FAAD0", VA = "0x1826FBCD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000863")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OMIDCKKPCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public sealed class EHOCPENPMLI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public EHOCPENPMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[AAFIHLNHDHN(LBGCMANLNFC.Simulation)]
public class BBGLFICDIOD : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9B20", Offset = "0x2AE8920", VA = "0x182AE9B20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9B90", Offset = "0x2AE8990", VA = "0x182AE9B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public BBGLFICDIOD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[IFBLAMOEMKH(CMGBDLINHMB.Prefabs)]
	[JAPBKNDOGGF(typeof(EHIDJEIAFME))]
	[EBJHGMECDNA(typeof(ObjectPrefabs), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	internal class ObjectPrefabs : MKHGKLCBKJA, FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		[CompilerGenerated]
		private sealed class MCGFPAMHCAG : IEnumerable<(FEJKANODFOG, CBLLNBPHCKJ)>, IEnumerable, IEnumerator<(FEJKANODFOG, CBLLNBPHCKJ)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private (FEJKANODFOG primitiveType, CBLLNBPHCKJ prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			private (FEJKANODFOG, CBLLNBPHCKJ) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000884")]
				[Cpp2IlInjected.Address(RVA = "0x1FCAAF0", Offset = "0x1FC98F0", VA = "0x181FCAAF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((FEJKANODFOG, CBLLNBPHCKJ));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000886")]
				[Cpp2IlInjected.Address(RVA = "0x3522A10", Offset = "0x3521810", VA = "0x183522A10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x351CAD0", Offset = "0x351B8D0", VA = "0x18351CAD0")]
			[DebuggerHidden]
			public MCGFPAMHCAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x3522830", Offset = "0x3521630", VA = "0x183522830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x35229D0", Offset = "0x35217D0", VA = "0x1835229D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x3522930", Offset = "0x3521730", VA = "0x183522930", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(FEJKANODFOG, CBLLNBPHCKJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x3522930", Offset = "0x3521730", VA = "0x183522930", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private readonly Dictionary<CBLLNBPHCKJ, Entity> JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private readonly Dictionary<CBLLNBPHCKJ, EntityArchetype> PCOKMHJEFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private readonly Dictionary<FEJKANODFOG, CBLLNBPHCKJ> NLNEHKJGGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private readonly Dictionary<EFCIKLEKING, CBLLNBPHCKJ> MGPDLKOBGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private DLKHAAIDMDD EAIMAINFOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private World HADAJAKADAH;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0x2724190", Offset = "0x2722F90", VA = "0x182724190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public GCGDMFPPNPN FCKIDLDDAFK
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x1FD2E10", Offset = "0x1FD1C10", VA = "0x181FD2E10")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2723D80", Offset = "0x2722B80", VA = "0x182723D80", Slot = "6")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x2723980", Offset = "0x2722780", VA = "0x182723980", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2724BE0", Offset = "0x27239E0", VA = "0x182724BE0")]
		internal IEnumerable<Type> OEDOHBCLBMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2723D10", Offset = "0x2722B10", VA = "0x182723D10")]
		internal BKMFLCIMEEJ HBMJOEAILCE(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2723CB0", Offset = "0x2722AB0", VA = "0x182723CB0")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2724630", Offset = "0x2723430", VA = "0x182724630", Slot = "4")]
		[IteratorStateMachine(typeof(MCGFPAMHCAG))]
		public IEnumerable<(FEJKANODFOG, CBLLNBPHCKJ)> LMEBMBJEMGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x27241E0", Offset = "0x2722FE0", VA = "0x1827241E0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x27243B0", Offset = "0x27231B0", VA = "0x1827243B0")]
		public CBLLNBPHCKJ KEOMIGEONAO(EFCIKLEKING NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x2724350", Offset = "0x2723150", VA = "0x182724350")]
		public CBLLNBPHCKJ KEOMIGEONAO(FEJKANODFOG NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x2724C10", Offset = "0x2723A10", VA = "0x182724C10")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x27242F0", Offset = "0x27230F0", VA = "0x1827242F0")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x2724800", Offset = "0x2723600", VA = "0x182724800")]
		private void MNFFEOCLIEH(BKMFLCIMEEJ HPFLFGLJAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2724410", Offset = "0x2723210", VA = "0x182724410")]
		internal void LHGLALOAHCC(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE IIHOIPENPMG, EHGHKOOKADN POGEIAMADJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x27246A0", Offset = "0x27234A0", VA = "0x1827246A0")]
		private void MMDBJIABBFK(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE CGPLPFBCOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2723860", Offset = "0x2722660", VA = "0x182723860")]
		internal Entity AIOJPOPMMMF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2724CB0", Offset = "0x2723AB0", VA = "0x182724CB0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal class DLKHAAIDMDD : GCGDMFPPNPN
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public AMFJBNENFOE LGJENDFKIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2AF65F0", Offset = "0x2AF53F0", VA = "0x182AF65F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AMFJBNENFOE OAEAENIOOID
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF68F0", Offset = "0x2AF56F0", VA = "0x182AF68F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public AMFJBNENFOE JOCENFLBGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6A40", Offset = "0x2AF5840", VA = "0x182AF6A40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AMFJBNENFOE IMJLAOKPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6AB0", Offset = "0x2AF58B0", VA = "0x182AF6AB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public AMFJBNENFOE DPGICPLHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6960", Offset = "0x2AF5760", VA = "0x182AF6960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AMFJBNENFOE PHENHNFCBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF66C0", Offset = "0x2AF54C0", VA = "0x182AF66C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public AMFJBNENFOE OLMDPKCBJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF67A0", Offset = "0x2AF55A0", VA = "0x182AF67A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public AMFJBNENFOE LFKFPFBGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2AF69D0", Offset = "0x2AF57D0", VA = "0x182AF69D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public AMFJBNENFOE MJDPGHDIINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6810", Offset = "0x2AF5610", VA = "0x182AF6810", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public AMFJBNENFOE PDGMPBFKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6730", Offset = "0x2AF5530", VA = "0x182AF6730", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public AMFJBNENFOE HAIAIHGAAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6650", Offset = "0x2AF5450", VA = "0x182AF6650", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public AMFJBNENFOE CPBAJJIFKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6880", Offset = "0x2AF5680", VA = "0x182AF6880", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6B20", Offset = "0x2AF5920", VA = "0x182AF6B20")]
	public DLKHAAIDMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[EBJHGMECDNA(typeof(BEPDNGBBFFI), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
internal sealed class BEPDNGBBFFI : DFDLCPDHDGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private OCGCGAIFBCP MJPMAIINMJI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public OCGCGAIFBCP HKAJEAEBCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1D374C0", Offset = "0x1D362C0", VA = "0x181D374C0")]
		get
		{
			return default(OCGCGAIFBCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBFE0", Offset = "0x2AEADE0", VA = "0x182AEBFE0", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBFD0", Offset = "0x2AEADD0", VA = "0x182AEBFD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public BEPDNGBBFFI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[EBJHGMECDNA(typeof(TransformOwnershipPhase), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		public enum MLCNOFLLEIM
		{
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x200015D")]
		public struct CLMGIJDALIL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private MLCNOFLLEIM OIDAMDBPCLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private readonly TransformOwnershipPhase ADECAOLBLPJ;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x3519400", Offset = "0x3518200", VA = "0x183519400")]
			public CLMGIJDALIL(TransformOwnershipPhase ADECAOLBLPJ, MLCNOFLLEIM KDNCNAFJOGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x35193E0", Offset = "0x35181E0", VA = "0x1835193E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public MLCNOFLLEIM KDNCNAFJOGD;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public MLCNOFLLEIM AOLPLBAILPC
		{
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
			get
			{
				return default(MLCNOFLLEIM);
			}
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x6618F0", Offset = "0x6606F0", VA = "0x1806618F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool CBAABLKMGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x9B27E0", Offset = "0x9B15E0", VA = "0x1809B27E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public bool HIIFNADKFDK
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x1258070", Offset = "0x1256E70", VA = "0x181258070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x27365E0", Offset = "0x27353E0", VA = "0x1827365E0")]
		public CLMGIJDALIL POFMOHBMMAH()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x27365B0", Offset = "0x27353B0", VA = "0x1827365B0")]
		public CLMGIJDALIL LOCJGLBKDKE()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
[EBJHGMECDNA(typeof(LIACDBEGOKA), new string[] { })]
public class CFPONONCGHH : FDFFINEAOHD, LIACDBEGOKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AED0E0", Offset = "0x2AEBEE0", VA = "0x182AED0E0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AED160", Offset = "0x2AEBF60", VA = "0x182AED160", Slot = "5")]
	public bool ILHNLLKCKAB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AECD80", Offset = "0x2AEBB80", VA = "0x182AECD80", Slot = "6")]
	public bool AOLBOGHMBHA(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AED220", Offset = "0x2AEC020", VA = "0x182AED220", Slot = "7")]
	public Guid MOIDJDIBHBB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AECE70", Offset = "0x2AEBC70", VA = "0x182AECE70", Slot = "8")]
	public void BIKJHANLAHD(PMMHBDBEGAM ADGJAILKBPO, Guid ELBCBEIBJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2AED1C0", Offset = "0x2AEBFC0", VA = "0x182AED1C0", Slot = "9")]
	public void MLGEPCENHDG(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public CFPONONCGHH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[EBJHGMECDNA(typeof(JLCJAEGDOGE), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.Connectables, new string[] { "Callbacks" })]
	internal class ConnectableService : JLCJAEGDOGE, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		[CompilerGenerated]
		private sealed class OFDNGLGGDAP : IEnumerable<PMMHBDBEGAM>, IEnumerable, IEnumerator<PMMHBDBEGAM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private PMMHBDBEGAM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private PMMHBDBEGAM localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PMMHBDBEGAM <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700010C")]
			private PMMHBDBEGAM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D0")]
				[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(PMMHBDBEGAM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D2")]
				[Cpp2IlInjected.Address(RVA = "0x35237B0", Offset = "0x35225B0", VA = "0x1835237B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
			[DebuggerHidden]
			public OFDNGLGGDAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x3523800", Offset = "0x3522600", VA = "0x183523800", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0x3523350", Offset = "0x3522150", VA = "0x183523350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0x35238D0", Offset = "0x35226D0", VA = "0x1835238D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CF")]
			[Cpp2IlInjected.Address(RVA = "0x3523920", Offset = "0x3522720", VA = "0x183523920")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x3523770", Offset = "0x3522570", VA = "0x183523770", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x35236C0", Offset = "0x35224C0", VA = "0x1835236C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PMMHBDBEGAM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x35236C0", Offset = "0x35224C0", VA = "0x1835236C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private const string NGJFDPMAJJK = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private static readonly CGJHBFGPOOL OHFHPDHGMLC;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public const int JCOCKGOINEB = 0;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public const int EEHIPFHEGAP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private PropertyEventCallbacksService OBJALHMPDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private global::NNBBLOFFBOH<AuthoredParentData, HDLOBHOIHNH, BAODGLPKBEK, AuthoredChildrenData> NHFJEOKEMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private global::ONBLNDNGCOE<Entity> NAFDIGNBMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private global::ONBLNDNGCOE<float3> MJBDIBLDIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private global::ONBLNDNGCOE<quaternion> BJCEANOAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private global::ONBLNDNGCOE<Entity> ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private global::ONBLNDNGCOE<float3> LHHNEMEAJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private global::ONBLNDNGCOE<quaternion> FBGPAJBMOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private HashSet<Entity> KMIFGBJDAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private HashSet<Entity> LEGGAOCFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private EntityQuery NPAEJDGHJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public Func<ODDCBCICFNM> EDJMPJLFAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x657080", Offset = "0x655E80", VA = "0x180657080", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0x678830", Offset = "0x677630", VA = "0x180678830", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> MEOPOOCHEFC
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3200", Offset = "0x2AF2000", VA = "0x182AF3200", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3460", Offset = "0x2AF2260", VA = "0x182AF3460", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> GPBFDMJOLDA
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x2AF28D0", Offset = "0x2AF16D0", VA = "0x182AF28D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3D80", Offset = "0x2AF2B80", VA = "0x182AF3D80", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM, PMMHBDBEGAM> KABKMNGALNG
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4090", Offset = "0x2AF2E90", VA = "0x182AF4090", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3FF0", Offset = "0x2AF2DF0", VA = "0x182AF3FF0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PMMHBDBEGAM> FCKEPJEGAEI
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4130", Offset = "0x2AF2F30", VA = "0x182AF4130", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3760", Offset = "0x2AF2560", VA = "0x182AF3760", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3500", Offset = "0x2AF2300", VA = "0x182AF3500", Slot = "23")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3890", Offset = "0x2AF2690", VA = "0x182AF3890", Slot = "24")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E70", Offset = "0x2AF1C70", VA = "0x182AF2E70", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2BF0", Offset = "0x2AF19F0", VA = "0x182AF2BF0")]
		private void DDHFANMADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2760", Offset = "0x2AF1560", VA = "0x182AF2760")]
		private void BGIGHDKDABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF32A0", Offset = "0x2AF20A0", VA = "0x182AF32A0")]
		private void FAKMPPADCJM(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E10", Offset = "0x2AF1C10", VA = "0x182AF2E10")]
		private void DOLAONIGMDJ(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x1EBACF0", Offset = "0x1EB9AF0", VA = "0x181EBACF0", Slot = "14")]
		public PMMHBDBEGAM BBBMNFOODKF(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B490", Offset = "0x114A290", VA = "0x18114B490", Slot = "15")]
		public Color EHCGLGLIIHP(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3020", Offset = "0x2AF1E20", VA = "0x182AF3020", Slot = "16")]
		public float3 EDBIPCCLEHA(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3680", Offset = "0x2AF2480", VA = "0x182AF3680", Slot = "17")]
		public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FKDHOLGPOMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AF26B0", Offset = "0x2AF14B0", VA = "0x182AF26B0", Slot = "18")]
		public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AF41D0", Offset = "0x2AF2FD0", VA = "0x182AF41D0", Slot = "21")]
		public void PKDJCLPCGDK(PMMHBDBEGAM ADGJAILKBPO, Vector3 ONIGPANBOIK, Quaternion INKFPMJDIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2510", Offset = "0x2AF1310", VA = "0x182AF2510", Slot = "26")]
		public (Vector3, Quaternion) ABEECJHILAL(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C50", Offset = "0x2AF1A50", VA = "0x182AF2C50", Slot = "27")]
		public (Vector3, Quaternion) DFMLGPGOEDO(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3E20", Offset = "0x2AF2C20", VA = "0x182AF3E20", Slot = "22")]
		public (Vector3, Quaternion, bool) LAGGPCHAALA(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3800", Offset = "0x2AF2600", VA = "0x182AF3800", Slot = "19")]
		[IteratorStateMachine(typeof(OFDNGLGGDAP))]
		public IEnumerable<PMMHBDBEGAM> KICEPBHGBMN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2A90", Offset = "0x2AF1890", VA = "0x182AF2A90", Slot = "20")]
		public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF43F0", Offset = "0x2AF31F0", VA = "0x182AF43F0", Slot = "28")]
		public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2970", Offset = "0x2AF1770", VA = "0x182AF2970")]
		private Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4650", Offset = "0x2AF3450", VA = "0x182AF4650")]
		public ConnectableService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public struct EMPKMDMEDJP : global::OCGKPONDJPA<EMPKMDMEDJP>, GPAFGALANDE, IEquatable<EMPKMDMEDJP>
{
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly EMPKMDMEDJP JHKNBKMIJJL;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x73E0D0", Offset = "0x73CED0", VA = "0x18073E0D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xC46420", Offset = "0xC45220", VA = "0x180C46420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x73E0B0", Offset = "0x73CEB0", VA = "0x18073E0B0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xC49E10", Offset = "0xC48C10", VA = "0x180C49E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB250", Offset = "0x2AFA050", VA = "0x182AFB250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB200", Offset = "0x2AFA000", VA = "0x182AFB200", Slot = "8")]
	public bool Equals(EMPKMDMEDJP HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB290", Offset = "0x2AFA090", VA = "0x182AFB290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public struct NOHNMMEJGLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public EMPKMDMEDJP MIGDJNOKMHC;
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct IEEGJNHOIPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private const int EBIBIOGKCAO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private readonly Stack<HashSet<object>> NFMFOGHBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private global::OPFKIBDDGAC<EMPKMDMEDJP, HashSet<object>> BNCBNBFPBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x26EC880", Offset = "0x26EB680", VA = "0x1826EC880")]
	public IEEGJNHOIPN(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x26EC3F0", Offset = "0x26EB1F0", VA = "0x1826EC3F0")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x26EC270", Offset = "0x26EB070", VA = "0x1826EC270")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x26EC5D0", Offset = "0x26EB3D0", VA = "0x1826EC5D0")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x26EC610", Offset = "0x26EB410", VA = "0x1826EC610")]
	public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x26EC6B0", Offset = "0x26EB4B0", VA = "0x1826EC6B0")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x26EC4F0", Offset = "0x26EB2F0", VA = "0x1826EC4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x26EC790", Offset = "0x26EB590", VA = "0x1826EC790")]
	private void NKCCEGIINBM(HashSet<object> ILPGJLCJEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x26EC1A0", Offset = "0x26EAFA0", VA = "0x1826EC1A0")]
	private bool CLAJAHGNDCP(Entity GEEFHDFLBEH, out EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x26EC800", Offset = "0x26EB600", VA = "0x1826EC800")]
	private void ONNCBMCEBOI(Entity GEEFHDFLBEH, EMPKMDMEDJP MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x26EC140", Offset = "0x26EAF40", VA = "0x1826EC140")]
	private bool BJEHCIFKJPO(EMPKMDMEDJP FHNOFBNPNEA, out HashSet<object> ILPGJLCJEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x26EC530", Offset = "0x26EB330", VA = "0x1826EC530")]
	private HashSet<object> IGNPALKHEKJ()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	[EBJHGMECDNA(typeof(ObjectEmbodimentService), new string[] { })]
	internal sealed class ObjectEmbodimentService : BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private readonly Dictionary<NMEJDFJAOOA, GIALAGJINEB> LEFBOBIDMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private PKDAIMBJGBM MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private FBGPKGAHMCA MMOBPIBHCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private IEEGJNHOIPN EGOIANHHAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private EntityHierarchyChildren FALFIAAPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TransformOwnershipPhase KDNCNAFJOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x26FD7A0", Offset = "0x26FC5A0", VA = "0x1826FD7A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public int HJDHFKEEIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x26FE550", Offset = "0x26FD350", VA = "0x1826FE550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public int AKKJDCEMEPC
		{
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x26FF220", Offset = "0x26FE020", VA = "0x1826FF220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<FEMMDHLANDH> HOEKIBHIEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x26FEAA0", Offset = "0x26FD8A0", VA = "0x1826FEAA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0x26FF240", Offset = "0x26FE040", VA = "0x1826FF240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<FEMMDHLANDH> PKHHOODAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0x26FBF40", Offset = "0x26FAD40", VA = "0x1826FBF40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0x26FDE50", Offset = "0x26FCC50", VA = "0x1826FDE50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x26FE300", Offset = "0x26FD100", VA = "0x1826FE300", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x26FDA70", Offset = "0x26FC870", VA = "0x1826FDA70", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x26FE310", Offset = "0x26FD110", VA = "0x1826FE310", Slot = "6")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x26FD5C0", Offset = "0x26FC3C0", VA = "0x1826FD5C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x26FE670", Offset = "0x26FD470", VA = "0x1826FE670")]
		public bool MBFENICDONN(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeList<Entity> FEGJPLALHAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x26FCCB0", Offset = "0x26FBAB0", VA = "0x1826FCCB0")]
		public global::OHBAMBCHLEK<Entity> CAKLBPIABDK(Allocator JEOILJEOOOI)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x26FCCF0", Offset = "0x26FBAF0", VA = "0x1826FCCF0")]
		public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x26FCDC0", Offset = "0x26FBBC0", VA = "0x1826FCDC0")]
		public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x26FCD10", Offset = "0x26FBB10", VA = "0x1826FCD10")]
		private bool CECLHLMOAFB(Transform BCHADNCHEKP, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x26FDF70", Offset = "0x26FCD70", VA = "0x1826FDF70")]
		internal bool IFBJDDLJDKH(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x26FBEA0", Offset = "0x26FACA0", VA = "0x1826FBEA0")]
		private void AOPNOMOLIPC(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x26FE860", Offset = "0x26FD660", VA = "0x1826FE860")]
		private bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x26FF8A0", Offset = "0x26FE6A0", VA = "0x1826FF8A0")]
		public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x26FCE30", Offset = "0x26FBC30", VA = "0x1826FCE30")]
		public bool CGFONLINMHA(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x26FBFE0", Offset = "0x26FADE0", VA = "0x1826FBFE0")]
		public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x26FC8C0", Offset = "0x26FB6C0", VA = "0x1826FC8C0")]
		public bool BHOEHOJGMNO(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x26FC460", Offset = "0x26FB260", VA = "0x1826FC460")]
		public bool BHOEHOJGMNO(GIALAGJINEB LFIMBOIOPFD, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x26FED90", Offset = "0x26FDB90", VA = "0x1826FED90")]
		public bool NIMKLNCMIKA(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x26FF1F0", Offset = "0x26FDFF0", VA = "0x1826FF1F0")]
		public bool NIMKLNCMIKA(GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x26FC480", Offset = "0x26FB280", VA = "0x1826FC480")]
		public bool BHOEHOJGMNO(GIALAGJINEB DNCNJICBAHE, [Optional] object MKDOEIGPNGM, bool EFJKFNKFDIO = false, bool NEGBKBLGNAB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x26FF2E0", Offset = "0x26FE0E0", VA = "0x1826FF2E0")]
		public Transform OFFKLJGCIOM(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x26FD8D0", Offset = "0x26FC6D0", VA = "0x1826FD8D0")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x26FE580", Offset = "0x26FD380", VA = "0x1826FE580")]
		public GIALAGJINEB LFOFKHPGLIF(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x26FDC50", Offset = "0x26FCA50", VA = "0x1826FDC50")]
		public void HKEPNALNJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x26FC910", Offset = "0x26FB710", VA = "0x1826FC910")]
		public void CAANKKMCLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x26FDFF0", Offset = "0x26FCDF0", VA = "0x1826FDFF0")]
		private void JCMLAECOIFB(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x26FDF20", Offset = "0x26FCD20", VA = "0x1826FDF20")]
		public GIALAGJINEB HOAGOKEBLHG(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x26FD370", Offset = "0x26FC170", VA = "0x1826FD370")]
		public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x26FD2A0", Offset = "0x26FC0A0", VA = "0x1826FD2A0")]
		public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x26FE570", Offset = "0x26FD370", VA = "0x1826FE570")]
		public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x26FDFA0", Offset = "0x26FCDA0", VA = "0x1826FDFA0")]
		public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x26FDF90", Offset = "0x26FCD90", VA = "0x1826FDF90")]
		public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x26FD2B0", Offset = "0x26FC0B0", VA = "0x1826FD2B0")]
		private void CLPLDICPPAA(bool BDEMLJAFCKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x26FE880", Offset = "0x26FD680", VA = "0x1826FE880")]
		private bool MFHKGCFEGBK(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x26FE4E0", Offset = "0x26FD2E0", VA = "0x1826FE4E0")]
		private GIALAGJINEB KJMFLPPNFBI(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x26FE910", Offset = "0x26FD710", VA = "0x1826FE910")]
		private GIALAGJINEB MPPPPPDCDEK(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x26FF4D0", Offset = "0x26FE2D0", VA = "0x1826FF4D0")]
		private (Vector3, Quaternion, Vector3) PCNHGAJFKOM(Entity GEEFHDFLBEH)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x26FF9D0", Offset = "0x26FE7D0", VA = "0x1826FF9D0")]
		private void PNLNEOCBNMO(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x26FF6F0", Offset = "0x26FE4F0", VA = "0x1826FF6F0")]
		private void PIOCBLOBICC(PMMHBDBEGAM ADGJAILKBPO, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x26FEB40", Offset = "0x26FD940", VA = "0x1826FEB40")]
		private void NABOMLEGBEG(GIALAGJINEB DNCNJICBAHE, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x26FD380", Offset = "0x26FC180", VA = "0x1826FD380")]
		private void DMCLGDJIJOA(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x26FD7F0", Offset = "0x26FC5F0", VA = "0x1826FD7F0")]
		private void FCNAKMLEAJB(Entity GEEFHDFLBEH, Transform BCHADNCHEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x26FDEF0", Offset = "0x26FCCF0", VA = "0x1826FDEF0")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x26FFE90", Offset = "0x26FEC90", VA = "0x1826FFE90")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x26FD9A0", Offset = "0x26FC7A0", VA = "0x1826FD9A0")]
		[CompilerGenerated]
		private void GGDOECEHMDE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal static class DBCLMMKJJBA
{
	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6100", Offset = "0x2AF4F00", VA = "0x182AF6100")]
	public static GIALAGJINEB LFOFKHPGLIF(this ObjectEmbodimentService KFHKDGFGKJJ, PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[EBJHGMECDNA(typeof(EntityHierarchyChildren), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private FGBIJEJJFBL MAPPBNAKEFG;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD3F0", Offset = "0x2AFC1F0", VA = "0x182AFD3F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD530", Offset = "0x2AFC330", VA = "0x182AFD530", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD910", Offset = "0x2AFC710", VA = "0x182AFD910")]
		internal void LPGPGLILELA(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDA90", Offset = "0x2AFC890", VA = "0x182AFDA90")]
		internal void MAEAMPCOPIO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDE30", Offset = "0x2AFCC30", VA = "0x182AFDE30")]
		private int NGIIJLPJFKN(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD5B0", Offset = "0x2AFC3B0", VA = "0x182AFD5B0")]
		internal DynamicBuffer<ChildrenData> IBBBKOHNJEB(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD680", Offset = "0x2AFC480", VA = "0x182AFD680")]
		internal DynamicBuffer<ChildrenData> INNICMNBKHH(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDB60", Offset = "0x2AFC960", VA = "0x182AFDB60")]
		public NativeArray<Entity> MMEBCOLEPOK(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD750", Offset = "0x2AFC550", VA = "0x182AFD750")]
		public bool JHKJHDCPCPH(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeArray<Entity> GDEADEABPNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD2C0", Offset = "0x2AFC0C0", VA = "0x182AFD2C0")]
		public NativeArray<Entity> DOINHDHLNBE(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDD20", Offset = "0x2AFCB20", VA = "0x182AFDD20")]
		public Entity NFFPNEMPLNO(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD440", Offset = "0x2AFC240", VA = "0x182AFD440")]
		public int HDHNEFAFOAJ(Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[EBJHGMECDNA(typeof(EntityHierarchyEvents), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class EntityHierarchyEvents : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private ObjectEmbodimentService DNCNJICBAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE0C0", Offset = "0x2AFCEC0", VA = "0x182AFE0C0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDF70", Offset = "0x2AFCD70", VA = "0x182AFDF70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private void HIHKANDABHD(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private void OOCJGKPDIGM(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private void EHKNKBCLFJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	[EBJHGMECDNA(typeof(EntityHierarchyParents), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class EntityHierarchyParents : FDFFINEAOHD, CDAFEBOKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private global::ONBLNDNGCOE<Entity> HLOAMKBCFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PropertyChangeNetworkRouter DOCHMGEDDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private global::NNBBLOFFBOH<ParentData, HHCGCCCMOPE, KKLIIHKDOLM, ChildrenData> NHFJEOKEMOJ;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE650", Offset = "0x2AFD450", VA = "0x182AFE650", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE770", Offset = "0x2AFD570", VA = "0x182AFE770", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE3C0", Offset = "0x2AFD1C0", VA = "0x182AFE3C0")]
		public Entity AILCCJELIAN(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE5F0", Offset = "0x2AFD3F0", VA = "0x182AFE5F0")]
		public bool FKEELJGEBOF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE6D0", Offset = "0x2AFD4D0", VA = "0x182AFE6D0")]
		public bool JCGFFABNCHF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ, bool CAMPEPOCDEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE410", Offset = "0x2AFD210", VA = "0x182AFE410")]
		private bool DMPHBHLECHG(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[EBJHGMECDNA(typeof(FGBIJEJJFBL), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class FGBIJEJJFBL : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class KHFHHBDLGJP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x1FCAAF0", Offset = "0x1FC98F0", VA = "0x181FCAAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x3520C80", Offset = "0x351FA80", VA = "0x183520C80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x351CAD0", Offset = "0x351B8D0", VA = "0x18351CAD0")]
		[DebuggerHidden]
		public KHFHHBDLGJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x3520AF0", Offset = "0x351F8F0", VA = "0x183520AF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x3520C40", Offset = "0x351FA40", VA = "0x183520C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3520B90", Offset = "0x351F990", VA = "0x183520B90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x3520B90", Offset = "0x351F990", VA = "0x183520B90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class GCOAHNELPOE : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0x1FCAAF0", Offset = "0x1FC98F0", VA = "0x181FCAAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0x351C9A0", Offset = "0x351B7A0", VA = "0x18351C9A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x351CAD0", Offset = "0x351B8D0", VA = "0x18351CAD0")]
		[DebuggerHidden]
		public GCOAHNELPOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x351C9F0", Offset = "0x351B7F0", VA = "0x18351C9F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x351C6E0", Offset = "0x351B4E0", VA = "0x18351C6E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x351CA80", Offset = "0x351B880", VA = "0x18351CA80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x351C960", Offset = "0x351B760", VA = "0x18351C960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x351C8B0", Offset = "0x351B6B0", VA = "0x18351C8B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x351C8B0", Offset = "0x351B6B0", VA = "0x18351C8B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class HFALFENBENM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x1FCAAF0", Offset = "0x1FC98F0", VA = "0x181FCAAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x351D7B0", Offset = "0x351C5B0", VA = "0x18351D7B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x351CAD0", Offset = "0x351B8D0", VA = "0x18351CAD0")]
		[DebuggerHidden]
		public HFALFENBENM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x351D800", Offset = "0x351C600", VA = "0x18351D800", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x351D3C0", Offset = "0x351C1C0", VA = "0x18351D3C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x351D8D0", Offset = "0x351C6D0", VA = "0x18351D8D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x351D920", Offset = "0x351C720", VA = "0x18351D920")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x351D770", Offset = "0x351C570", VA = "0x18351D770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x351D6C0", Offset = "0x351C4C0", VA = "0x18351D6C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x351D6C0", Offset = "0x351C4C0", VA = "0x18351D6C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private EntityHierarchyParents OBEJKCLINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private EntityHierarchyChildren FALFIAAPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery NPAEJDGHJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2B01330", Offset = "0x2B00130", VA = "0x182B01330")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x2B01520", Offset = "0x2B00320", VA = "0x182B01520", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2B01310", Offset = "0x2B00110", VA = "0x182B01310", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2B00ED0", Offset = "0x2AFFCD0", VA = "0x182B00ED0")]
	public bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x2B010A0", Offset = "0x2AFFEA0", VA = "0x182B010A0")]
	public bool BKLGLKDLCLG(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2B01980", Offset = "0x2B00780", VA = "0x182B01980")]
	public IEnumerable<Entity> NJHHOCACKHJ(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x2B01680", Offset = "0x2B00480", VA = "0x182B01680")]
	[IteratorStateMachine(typeof(KHFHHBDLGJP))]
	private IEnumerable<Entity> JFPEENCJEGK(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2B01420", Offset = "0x2B00220", VA = "0x182B01420")]
	public bool FLMGCLJOAAP(Entity GEEFHDFLBEH, Entity NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2B01500", Offset = "0x2B00300", VA = "0x182B01500")]
	public bool GOENCLMLMME(Entity GEEFHDFLBEH, Entity PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2B01A90", Offset = "0x2B00890", VA = "0x182B01A90")]
	public IEnumerable<Entity> OEMKFPIEJOP(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00180", VA = "0x182B01380")]
	[IteratorStateMachine(typeof(GCOAHNELPOE))]
	private IEnumerable<Entity> FBIGMHMMJEL(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2B01290", Offset = "0x2B00090", VA = "0x182B01290")]
	[IteratorStateMachine(typeof(HFALFENBENM))]
	private IEnumerable<Entity> DFAOJBFPFIP(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2B011B0", Offset = "0x2AFFFB0", VA = "0x182B011B0")]
	public Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2B01BA0", Offset = "0x2B009A0", VA = "0x182B01BA0")]
	public NativeArray<Entity> PPDLNFBKINL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x2B01720", Offset = "0x2B00520", VA = "0x182B01720")]
	public bool MKDAEBPAGML(Entity PJCDGLCJFAM, Entity EJPDMNHPBOC, out Entity CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public FGBIJEJJFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal static class HGHIJDIADBD
{
	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x26E9410", Offset = "0x26E8210", VA = "0x1826E9410")]
	public static void JHDCICGDBOE(NativeArray<Entity> OBEJKCLINIG, NativeArray<Entity> FALFIAAPAEL, EntityManager LKEHNCAJHHL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x2F79E60", Offset = "0x2F78C60", VA = "0x182F79E60")]
		public static void ENJHCNHMIBP<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO, out global::NNBBLOFFBOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> PAOPFHIHHOM) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LJBPPGAHFFJ, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x2727F00", Offset = "0x2726D00", VA = "0x182727F00")]
		public static bool AJJHCHEFKLC(FEMMDHLANDH LFIMBOIOPFD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class NNBBLOFFBOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LJBPPGAHFFJ, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private readonly global::ONBLNDNGCOE<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly CLDGLLOBFOG DBBEFAPFBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly AEFHEEDIBGN ADECAOLBLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly MFLHDAEOBPP IMFCFJELJOA;

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FD00", Offset = "0x2B5EB00", VA = "0x182B5FD00")]
	public NNBBLOFFBOH(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F5F0", Offset = "0x2B5E3F0", VA = "0x182B5F5F0")]
	private bool PLEKBFHCCPD(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EB30", Offset = "0x2B5D930", VA = "0x182B5EB30")]
	private bool HPNGKKCNHEG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EEC0", Offset = "0x2B5DCC0", VA = "0x182B5EEC0")]
	public bool KKFDIADEDKB(Entity GEEFHDFLBEH, in Entity JDMCICBCFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private static void KPJGGNLILMC(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private static void FHBPHLLELDP(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x2B5E840", Offset = "0x2B5D640", VA = "0x182B5E840")]
	private bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x2B5E920", Offset = "0x2B5D720", VA = "0x182B5E920")]
	private void FHIFJDEGHPP(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EB80", Offset = "0x2B5D980", VA = "0x182B5EB80")]
	private void JCMJBKEMIAG(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F0F0", Offset = "0x2B5DEF0", VA = "0x182B5F0F0")]
	private bool LPNAJKOBPJM(IKKLLNPBAHK NDCABLNNFKI, in NMEJDFJAOOA HOAPGBAADBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EA00", Offset = "0x2B5D800", VA = "0x182B5EA00")]
	private void FIGNIJGDPHJ(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F4D0", Offset = "0x2B5E2D0", VA = "0x182B5F4D0")]
	private void NKNHNPFFGPO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private void CPDILHHAHEB(Entity GEEFHDFLBEH, Entity POICJGPACMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	private void NIDLIBPLDNN(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[EBJHGMECDNA(typeof(ObjectInstantiationService), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Prefabs)]
	internal sealed class ObjectInstantiationService : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private HOLDGPOECHF DOBDPEFBFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ADONFIKCCKK ANKEDBGLNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private ObjectNetworkToLocalMapService DNGOCFEOHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private ObjectPrefabs JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private JGLKPBCBPCD BKOBBOPLKAF;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public int PNKDFLFLNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0x2700340", Offset = "0x26FF140", VA = "0x182700340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x26FFF50", Offset = "0x26FED50", VA = "0x1826FFF50", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x27000B0", Offset = "0x26FEEB0", VA = "0x1827000B0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x2700130", Offset = "0x26FEF30", VA = "0x182700130")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x2700230", Offset = "0x26FF030", VA = "0x182700230")]
		public Entity MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2700360", Offset = "0x26FF160", VA = "0x182700360")]
		public Entity PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x26FFF40", Offset = "0x26FED40", VA = "0x1826FFF40")]
		public Entity HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x26FFF10", Offset = "0x26FED10", VA = "0x1826FFF10")]
		public Entity FECCIBCHBLN()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2700300", Offset = "0x26FF100", VA = "0x182700300")]
		public Entity NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x27001D0", Offset = "0x26FEFD0", VA = "0x1827001D0")]
		public Entity IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2700060", Offset = "0x26FEE60", VA = "0x182700060")]
		public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x2700400", Offset = "0x26FF200", VA = "0x182700400")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x26FFF20", Offset = "0x26FED20", VA = "0x1826FFF20")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2700210", Offset = "0x26FF010", VA = "0x182700210")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x2700250", Offset = "0x26FF050", VA = "0x182700250")]
		private Entity NDGGKFMBDOG(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[EBJHGMECDNA(typeof(KNJHNLNIBIP), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public sealed class PhysicsSceneColliderService : KNJHNLNIBIP, IELCPLOPIMJ, DFDLCPDHDGP, FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private const string JIILKFCDDFC = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private const int NPFCCJEHOFB = -1;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private const int HKFAFMJLFBC = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private PKDAIMBJGBM MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private Collider[] DBPEFBBOHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private RaycastHit[] CBGLGEGNBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private global::OPFKIBDDGAC<NCGEEIAJEOJ, BoxCollider> FFHHLJJGJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private Scene DBCGBCALMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private PhysicsScene OKKMKGAJAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private GameObject AAICEAICAMA;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public int KHIICLPNKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x2727F50", Offset = "0x2726D50", VA = "0x182727F50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x2728EF0", Offset = "0x2727CF0", VA = "0x182728EF0", Slot = "9")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x2728850", Offset = "0x2727650", VA = "0x182728850", Slot = "10")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x27282D0", Offset = "0x27270D0", VA = "0x1827282D0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2727F90", Offset = "0x2726D90", VA = "0x182727F90", Slot = "4")]
		public NCGEEIAJEOJ ANGLAMGMPLO(Entity GEEFHDFLBEH)
		{
			return default(NCGEEIAJEOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x27283D0", Offset = "0x27271D0", VA = "0x1827283D0", Slot = "5")]
		public void EKKHEBFMCND(NativeArray<NCGEEIAJEOJ> AGFPEFOAJDF, NativeArray<NMNILGJABIA> HEICMLFEKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x2728200", Offset = "0x2727000", VA = "0x182728200", Slot = "6")]
		public void DHBLDBLJOBK(NCGEEIAJEOJ MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x2728990", Offset = "0x2727790", VA = "0x182728990", Slot = "7")]
		public bool IAJFOCJNBCA(NCGEEIAJEOJ MIGDJNOKMHC, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x2728A30", Offset = "0x2727830", VA = "0x182728A30")]
		public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x27285F0", Offset = "0x27273F0", VA = "0x1827285F0")]
		private void GHANMEIKHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xA59F90", Offset = "0xA58D90", VA = "0x180A59F90")]
		private void LKLIONOAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2729060", Offset = "0x2727E60", VA = "0x182729060")]
		private void KCGIMLCGKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xE2C310", Offset = "0xE2B110", VA = "0x180E2C310")]
		private void LJFJDLJMDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x27280E0", Offset = "0x2726EE0", VA = "0x1827280E0")]
		private BoxCollider BILPPOGKOPN(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x2728910", Offset = "0x2727710", VA = "0x182728910")]
		private void HHCGJADMOEJ(BoxCollider AGOKDHIHIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2728D40", Offset = "0x2727B40", VA = "0x182728D40")]
		[Conditional("UNITY_EDITOR")]
		private void IGOHFKMBNPC(GameObject BFJMKCMPBKG, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2728D80", Offset = "0x2727B80", VA = "0x182728D80")]
		private void JMHGIBDONMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x27290F0", Offset = "0x2727EF0", VA = "0x1827290F0")]
		private void MLCJNMBAIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2728640", Offset = "0x2727440", VA = "0x182728640")]
		private void GOMKMNLDGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2729200", Offset = "0x2728000", VA = "0x182729200")]
		private void OOIJGHCNGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x27285E0", Offset = "0x27273E0", VA = "0x1827285E0")]
		private void FFAGAJBIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x27290B0", Offset = "0x2727EB0", VA = "0x1827290B0")]
		private void MHJIMLLCPKK(Scene LKJDNOKNMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2727F40", Offset = "0x2726D40", VA = "0x182727F40", Slot = "8")]
		private bool AIPCIMOHECK(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[EBJHGMECDNA(typeof(NKGHFOCFECH), new string[] { })]
public sealed class GMCCOMDABLK : NKGHFOCFECH, FDFFINEAOHD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	private struct OKDMOHDNODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float ACDBJHBECNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public uint NDFNJFAPKCG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private IELCPLOPIMJ MDCHDMDOFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private ILPNMBANAND DOGGJPFEOPM;

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x26E7AD0", Offset = "0x26E68D0", VA = "0x1826E7AD0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x26E7B40", Offset = "0x26E6940", VA = "0x1826E7B40")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, out LAGADACOOOP PEIHFKCOJDK, out Entity GOCCFAICBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x26E79D0", Offset = "0x26E67D0", VA = "0x1826E79D0")]
	public static bool GJAKEOAPIFJ(in Span<LAGADACOOOP> ENFPPCCMHCG, float JEIPODGPOFH, out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FC0", Offset = "0x26E6DC0", VA = "0x1826E7FC0")]
	public static float MMELGNPDJMN(float ACDBJHBECNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public GMCCOMDABLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x26E79C0", Offset = "0x26E67C0", VA = "0x1826E79C0", Slot = "4")]
	private bool EPIBGFALCPB(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, out LAGADACOOOP PEIHFKCOJDK, out Entity GOCCFAICBMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[EBJHGMECDNA(typeof(ILPNMBANAND), new string[] { })]
public sealed class FNEJDFJNBNC : ILPNMBANAND, FDFFINEAOHD
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[BurstCompile]
	private struct LMBAEKFAPPD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		[ReadOnly]
		public NativeArray<Entity> FBMJMNCDHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[ReadOnly]
		public float3 HKLGJBALGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		[ReadOnly]
		public float3 LIMDOIGEJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> DCIHBCMAMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> PJFDNFCKIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DFBLOLNPNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		[WriteOnly]
		public NativeArray<LAGADACOOOP> FHNGOIIKONC;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private static readonly LAGADACOOOP COKEECJOHCL;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x3521590", Offset = "0x3520390", VA = "0x183521590", Slot = "4")]
		public void Execute(int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x35214C0", Offset = "0x35202C0", VA = "0x1835214C0")]
		private static float3 EPBEPIAADBN(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x3521870", Offset = "0x3520670", VA = "0x183521870")]
		private static float3 KHIMFCKDMNI(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x3522100", Offset = "0x3520F00", VA = "0x183522100")]
		private static float3 LOOFFKKDFMB(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x3522500", Offset = "0x3521300", VA = "0x183522500")]
		private static float3 NFEOPCKOOAA(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x3522200", Offset = "0x3521000", VA = "0x183522200")]
		private bool MOMMEFDGJGO(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<Entity> CNEMJNCMMKA, out float3 PEIHFKCOJDK, out float3 BJLFJKGMNHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x3521A30", Offset = "0x3520830", VA = "0x183521A30")]
		public static bool KJBDHLGAJIO(in float3 EENGOCNGPNB, in float3 DCOMCKGCKBH, in float3 PAOFDIIDBMK, in float3 JCOAFPHKEFN, float IADELNJNICE, float GIDFBHLFDCN, out float MGEGOIPHNMM, out float3 JLKDEHPMNLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x26E6040", Offset = "0x26E4E40", VA = "0x1826E6040", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x26E60C0", Offset = "0x26E4EC0", VA = "0x1826E60C0")]
	public void IGDPCCPOHMI(in NativeArray<Entity> FBMJMNCDHDM, in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<LAGADACOOOP> CLHAIOKMEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public FNEJDFJNBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x26E60C0", Offset = "0x26E4EC0", VA = "0x1826E60C0", Slot = "4")]
	private void IMFKKNMDJCL(in NativeArray<Entity> FBMJMNCDHDM, in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<LAGADACOOOP> CLHAIOKMEPP)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	[EBJHGMECDNA(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private ObjectEmbodimentService DNCNJICBAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private ObjectNetworkToLocalMapService DNGOCFEOHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private EntityHierarchyChildren FALFIAAPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private FGBIJEJJFBL MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityHierarchyParents OBEJKCLINIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private FOLBJCBGIIH OLOICGJGAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2700A60", Offset = "0x26FF860", VA = "0x182700A60")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Entity, CBLLNBPHCKJ> PENFFKIPBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x2700DC0", Offset = "0x26FFBC0", VA = "0x182700DC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x27009C0", Offset = "0x26FF7C0", VA = "0x1827009C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Entity> NNDDOAEECDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x2700CB0", Offset = "0x26FFAB0", VA = "0x182700CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2700AB0", Offset = "0x26FF8B0", VA = "0x182700AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2700B50", Offset = "0x26FF950", VA = "0x182700B50", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xE77FC0", Offset = "0xE76DC0", VA = "0x180E77FC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2700610", Offset = "0x26FF410", VA = "0x182700610")]
		public bool AEBBOEKMPNE(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2700FB0", Offset = "0x26FFDB0", VA = "0x182700FB0")]
		internal void MDCLCNEPJCC(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x27008B0", Offset = "0x26FF6B0", VA = "0x1827008B0")]
		public void CHMNDPKCMOJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2700470", Offset = "0x26FF270", VA = "0x182700470")]
		public void ACKFNLGGLJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2700E60", Offset = "0x26FFC60", VA = "0x182700E60")]
		private bool KNCDHIHBFDG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2701270", Offset = "0x2700070", VA = "0x182701270")]
		public void NONGHDEHHOE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2700990", Offset = "0x26FF790", VA = "0x182700990")]
		private void ELCHMDLCCOO(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2701010", Offset = "0x26FFE10", VA = "0x182701010")]
		private void MLDIKEFLBDK(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2700680", Offset = "0x26FF480", VA = "0x182700680")]
		public void ANPFAIODGJP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2700D50", Offset = "0x26FFB50", VA = "0x182700D50")]
		private void IOMGEBLBJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2701350", Offset = "0x2700150", VA = "0x182701350")]
		private void PFBEKIDPBBJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	[EBJHGMECDNA(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private NativeHashMap<NMEJDFJAOOA, Entity> CJKCJJEOEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		internal NativeHashMap<NMEJDFJAOOA, Entity> OIPFJLJMGIK
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
			get
			{
				return default(NativeHashMap<NMEJDFJAOOA, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x2723610", Offset = "0x2722410", VA = "0x182723610", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x27233B0", Offset = "0x27221B0", VA = "0x1827233B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x2723710", Offset = "0x2722510", VA = "0x182723710")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2723530", Offset = "0x2722330", VA = "0x182723530")]
		public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x27234A0", Offset = "0x27222A0", VA = "0x1827234A0")]
		public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(NMEJDFJAOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x2723410", Offset = "0x2722210", VA = "0x182723410")]
		public void EJEGPNOCOKC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x27232F0", Offset = "0x27220F0", VA = "0x1827232F0")]
		public void ABMEIFNFFHC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x2723350", Offset = "0x2722150", VA = "0x182723350")]
		public void CDADDOFNGMF(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x2723740", Offset = "0x2722540", VA = "0x182723740")]
		public void JPHKACHFAFL(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[IFBLAMOEMKH(CMGBDLINHMB.Callbacks)]
	[EBJHGMECDNA(typeof(PropertyEventCallbacksService), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	public class PropertyEventCallbacksService : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		private struct DCHLEFALAMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public PDEHMHFLINN GKAOJENLDLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public Type NKICFHCCMMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public int MNKEEJPGFOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200017A")]
		private struct PMOFFFGGJHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public DCHLEFALAMC[] GMKKBMEMHOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200017B")]
		public delegate void PDEHMHFLINN(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP);

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly Dictionary<JLCDNMLCNEN, PDEHMHFLINN> LMCPFDKFLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly Dictionary<int, PMOFFFGGJHG> OGKAHIOEBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private GNLAPDIIDJD GMKKBMEMHOP;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action DLAHLFPKNNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x272F4E0", Offset = "0x272E2E0", VA = "0x18272F4E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x272EAF0", Offset = "0x272D8F0", VA = "0x18272EAF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action JHLJECICLDM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0x272EE10", Offset = "0x272DC10", VA = "0x18272EE10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x272E680", Offset = "0x272D480", VA = "0x18272E680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x272EAA0", Offset = "0x272D8A0", VA = "0x18272EAA0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x272F580", Offset = "0x272E380", VA = "0x18272F580")]
		public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, PDEHMHFLINN GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x272E9B0", Offset = "0x272D7B0", VA = "0x18272E9B0")]
		public void GGCGIGPFIFL(JLCDNMLCNEN ABEODFEGJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x272E720", Offset = "0x272D520", VA = "0x18272E720")]
		internal void FHDIKKJPLIH(ENNNNIELFIE PBHDPEJBGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x272EFA0", Offset = "0x272DDA0", VA = "0x18272EFA0")]
		private void OIBABOHHOLL(ENNNNIELFIE PBHDPEJBGCP, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x272EB90", Offset = "0x272D990", VA = "0x18272EB90")]
		private void MDLNEFCJMKP(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ, DCHLEFALAMC JNJBGLDKDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x272F6F0", Offset = "0x272E4F0", VA = "0x18272F6F0")]
		private PMOFFFGGJHG PKOKBHBEBMA(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(PMOFFFGGJHG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x272EEB0", Offset = "0x272DCB0", VA = "0x18272EEB0")]
		private DCHLEFALAMC NEENEBAPNFF(PMOFFFGGJHG OHDDMIOPOFC, EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(DCHLEFALAMC);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x272F8C0", Offset = "0x272E6C0", VA = "0x18272F8C0")]
		public PropertyEventCallbacksService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[LFOIMLBAPLC(typeof(PropertyDiffStateService))]
	[EBJHGMECDNA(typeof(OOGJNFIJHKM), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	internal class PropertyDiffStateService : FDFFINEAOHD, CDAFEBOKDJF, OOGJNFIJHKM, ENNNNIELFIE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private readonly List<KGFPMIPOKMG> CMONDGCDAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private ObjectInstantiationService JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private KHMLGNFANIM OGMAGPEPNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private FLHBGDILJIB MOLNMFIKIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private KHFNLIHOAGK CMAOMHCKFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private NativeMultiHashMap<Entity, OJINANPDCIH> OBKNHCLLMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private NativeHashMap<int, int> KGFFLOAPJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private JobHandle FIOOOJDOILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private JobHandle CHHFKDPPCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public bool EPOFMKLFDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0x272DC00", Offset = "0x272CA00", VA = "0x18272DC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		private World CDCACCPAOCG
		{
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0x272D5C0", Offset = "0x272C3C0", VA = "0x18272D5C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		private KHMLGNFANIM LDGABFOLHPO
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		private FLHBGDILJIB AEBPELGCMAE
		{
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private NativeMultiHashMap<Entity, OJINANPDCIH> KIMKKCDAMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0xDFFEF0", Offset = "0xDFECF0", VA = "0x180DFFEF0", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, OJINANPDCIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private JobHandle KGPNKIOBFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x725E70", Offset = "0x724C70", VA = "0x180725E70", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD59C0", Offset = "0xCD47C0", VA = "0x180CD59C0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private World FHMGFHBGODL
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0x272E460", Offset = "0x272D260", VA = "0x18272E460", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0x272E060", Offset = "0x272CE60", VA = "0x18272E060", Slot = "13")]
		private void KAGLHGCNNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x272DB30", Offset = "0x272C930", VA = "0x18272DB30", Slot = "12")]
		private bool EJMMANHCLCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x272E4C0", Offset = "0x272D2C0", VA = "0x18272E4C0", Slot = "14")]
		private void OILCIAOINAE(ComponentType MOBCJNJMMEJ, in KGFPMIPOKMG CKIPEJKPEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x272D620", Offset = "0x272C420", VA = "0x18272D620", Slot = "15")]
		private bool BDCPHGNPOML(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x272DA20", Offset = "0x272C820", VA = "0x18272DA20", Slot = "17")]
		private bool DGCDCNDHLEP(out NativeArray<int> GIFGJKHKEEO, Allocator JEOILJEOOOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x272D8B0", Offset = "0x272C6B0", VA = "0x18272D8B0", Slot = "18")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM, out OOPIHDDHHBC OHDDMIOPOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x272D780", Offset = "0x272C580", VA = "0x18272D780", Slot = "19")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x272DC10", Offset = "0x272CA10", VA = "0x18272DC10", Slot = "20")]
		private KGFPMIPOKMG FOCBFEBAJIA(ComponentType MOBCJNJMMEJ)
		{
			return default(KGFPMIPOKMG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x272E020", Offset = "0x272CE20", VA = "0x18272E020", Slot = "21")]
		private IDJKLEJHIMN JJLGELLAIAH()
		{
			return default(IDJKLEJHIMN);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x272E070", Offset = "0x272CE70", VA = "0x18272E070", Slot = "22")]
		private void KFPANNFHALE(JobHandle AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x272DD00", Offset = "0x272CB00", VA = "0x18272DD00", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x272E0B0", Offset = "0x272CEB0", VA = "0x18272E0B0", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x272DAC0", Offset = "0x272C8C0", VA = "0x18272DAC0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x272DD70", Offset = "0x272CB70", VA = "0x18272DD70")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x272E240", Offset = "0x272D040", VA = "0x18272E240")]
		private bool KPPCAAEGNKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x272D640", Offset = "0x272C440", VA = "0x18272D640")]
		private int BKKNNDPJILH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x272E600", Offset = "0x272D400", VA = "0x18272E600")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[EBJHGMECDNA(typeof(BPHIPABMBKD), new string[] { })]
public class DNANFJBCKGI : FDFFINEAOHD, CDAFEBOKDJF, BPHIPABMBKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class DPHJPJNOBMC : IEnumerable<KBKPPGIKIHI>, IEnumerable, IEnumerator<KBKPPGIKIHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private KBKPPGIKIHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public DNANFJBCKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private GINMLCILJIO spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public GINMLCILJIO <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private KBKPPGIKIHI System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KBKPPGIKIHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x351AD60", Offset = "0x3519B60", VA = "0x18351AD60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
		[DebuggerHidden]
		public DPHJPJNOBMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x351AB70", Offset = "0x3519970", VA = "0x18351AB70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x351AD20", Offset = "0x3519B20", VA = "0x18351AD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x351AC70", Offset = "0x3519A70", VA = "0x18351AC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBKPPGIKIHI> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x351AC70", Offset = "0x3519A70", VA = "0x18351AC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private BKDDNHHHPLM ELCOJELDKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2AF81B0", Offset = "0x2AF6FB0", VA = "0x182AF81B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7CF0", Offset = "0x2AF6AF0", VA = "0x182AF7CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2AF84C0", Offset = "0x2AF72C0", VA = "0x182AF84C0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x2AF88B0", Offset = "0x2AF76B0", VA = "0x182AF88B0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7E60", Offset = "0x2AF6C60", VA = "0x182AF7E60", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7F10", Offset = "0x2AF6D10", VA = "0x182AF7F10")]
	private void EICDFLNDJBL(Entity GOLAIHPPLOC, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8390", Offset = "0x2AF7190", VA = "0x182AF8390", Slot = "12")]
	public GINMLCILJIO FECCIBCHBLN()
	{
		return default(GINMLCILJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8530", Offset = "0x2AF7330", VA = "0x182AF8530", Slot = "6")]
	public KBKPPGIKIHI IJFDDHEFOFO(GINMLCILJIO FHFFEBCPBGH, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2AF87E0", Offset = "0x2AF75E0", VA = "0x182AF87E0", Slot = "13")]
	public KBKPPGIKIHI JMLJEPFIPII(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8A40", Offset = "0x2AF7840", VA = "0x182AF8A40", Slot = "7")]
	public KBKPPGIKIHI NJFFFBEOAPH(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8430", Offset = "0x2AF7230", VA = "0x182AF8430", Slot = "14")]
	public void FPKPDGILOEA(GINMLCILJIO FHFFEBCPBGH, KBKPPGIKIHI IJKNBPEODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8B50", Offset = "0x2AF7950", VA = "0x182AF8B50", Slot = "8")]
	public void NJOOFBGDBOP(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8200", Offset = "0x2AF7000", VA = "0x182AF8200", Slot = "15")]
	public void FBLDKFMNKLA(GINMLCILJIO FHFFEBCPBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF89B0", Offset = "0x2AF77B0", VA = "0x182AF89B0", Slot = "9")]
	public int NDMAOJDGOIJ(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8820", Offset = "0x2AF7620", VA = "0x182AF8820", Slot = "10")]
	[IteratorStateMachine(typeof(DPHJPJNOBMC))]
	public IEnumerable<KBKPPGIKIHI> JONBNEOMLDM(GINMLCILJIO FHFFEBCPBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7C70", Offset = "0x2AF6A70", VA = "0x182AF7C70")]
	private bool CEMJEJEEHLM(GINMLCILJIO FHFFEBCPBGH, out NativeArray<Entity> FALFIAAPAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7DB0", Offset = "0x2AF6BB0", VA = "0x182AF7DB0")]
	private NativeArray<Entity> DDIENHKLDME(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public DNANFJBCKGI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	[JAPBKNDOGGF(typeof(GALJPCEPKLP))]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[EBJHGMECDNA(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private CLDGLLOBFOG MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private Entity GEEFHDFLBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private AMFJBNENFOE CGPLPFBCOHF;

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0x2734510", Offset = "0x2733310", VA = "0x182734510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2734450", Offset = "0x2733250", VA = "0x182734450")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		public T BOPAOPJOHPG<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		public void PIGMJENILDA<T>(T IGJPNMBCJPK) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x27344A0", Offset = "0x27332A0", VA = "0x1827344A0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2734520", Offset = "0x2733320", VA = "0x182734520", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2734520", Offset = "0x2733320", VA = "0x182734520")]
		private void POCLKGKAOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2734320", Offset = "0x2733120", VA = "0x182734320", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2734770", Offset = "0x2733570", VA = "0x182734770")]
		private void NAHHLBGMLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x27347D0", Offset = "0x27335D0", VA = "0x1827347D0")]
		private AMFJBNENFOE NCHIKKFEHMO()
		{
			return default(AMFJBNENFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void GGNCAOJPKHM(int KOHJDBBJEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		private static void EIHGDBDAHDH(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2734690", Offset = "0x2733490", VA = "0x182734690")]
		private static void LOJMGLBFGPE(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct GBEAIPCECGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(KDMAIHKHEJC), new string[] { })]
internal sealed class KDMAIHKHEJC : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private PGLNEDJDCBK NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x26EF9E0", Offset = "0x26EE7E0", VA = "0x1826EF9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x26EFB20", Offset = "0x26EE920", VA = "0x1826EFB20", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x26EFA30", Offset = "0x26EE830", VA = "0x1826EFA30")]
	public void CHDHGKDAAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x26EFBA0", Offset = "0x26EE9A0", VA = "0x1826EFBA0")]
	public void IBCENBBDMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public KDMAIHKHEJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[DefaultMember("Item")]
public struct MFEBELNBKCH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private T[] JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private int GKPOMAIMOAK;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x73E080", Offset = "0x73CE80", VA = "0x18073E080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BC70", Offset = "0x2D0AA70", VA = "0x182D0BC70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BA60", Offset = "0x2D0A860", VA = "0x182D0BA60")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x79AF80", Offset = "0x799D80", VA = "0x18079AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BCB0", Offset = "0x2D0AAB0", VA = "0x182D0BCB0")]
	public MFEBELNBKCH(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BBC0", Offset = "0x2D0A9C0", VA = "0x182D0BBC0")]
	public int FKENAIAHEAH(T IGJPNMBCJPK, int FOACNEHDHLI, int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BB00", Offset = "0x2D0A900", VA = "0x182D0BB00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[DefaultMember("Item")]
public struct EEHAAMAOJOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private global::MFEBELNBKCH<T> JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private int GKPOMAIMOAK;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x19843E0", Offset = "0x19831E0", VA = "0x1819843E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x19847E0", Offset = "0x19835E0", VA = "0x1819847E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x1984470", Offset = "0x1983270", VA = "0x181984470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x19844A0", Offset = "0x19832A0", VA = "0x1819844A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x1984730", Offset = "0x1983530", VA = "0x181984730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x1982F70", Offset = "0x1981D70", VA = "0x181982F70")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x1984910", Offset = "0x1983710", VA = "0x181984910")]
	public EEHAAMAOJOL(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x1984050", Offset = "0x1982E50", VA = "0x181984050")]
	public T IGMIKAKFNBO(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x1984770", Offset = "0x1983570", VA = "0x181984770")]
	public void OMAKEOAANBD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x19836B0", Offset = "0x19824B0", VA = "0x1819836B0")]
	public void FFDHMAEECPB(Span<T> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x1983B80", Offset = "0x1982980", VA = "0x181983B80")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x1983530", Offset = "0x1982330", VA = "0x181983530")]
	private void EEGKOIJBHKM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x19844F0", Offset = "0x19832F0", VA = "0x1819844F0")]
	public void MBOIAEPEMME(Span<T> JJDMEICMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x1983C90", Offset = "0x1982A90", VA = "0x181983C90")]
	public void HGIANMDOCHF(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x1983E30", Offset = "0x1982C30", VA = "0x181983E30")]
	public void IAAJAJFGFOI(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x1983910", Offset = "0x1982710", VA = "0x181983910")]
	public void GEPHADMCPNH(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x1983970", Offset = "0x1982770", VA = "0x181983970")]
	public void GIBODEFMDLL(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x1983180", Offset = "0x1981F80", VA = "0x181983180")]
	public void BGHIEJLNECC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x19830C0", Offset = "0x1981EC0", VA = "0x1819830C0")]
	public void BBOHILHOBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x1983820", Offset = "0x1982620", VA = "0x181983820")]
	public int FKENAIAHEAH(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x19838B0", Offset = "0x19826B0", VA = "0x1819838B0")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x19834E0", Offset = "0x19822E0", VA = "0x1819834E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x19848A0", Offset = "0x19836A0", VA = "0x1819848A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1984830", Offset = "0x1983630", VA = "0x181984830")]
	public static Span<T> PAAEKNCKHBI(global::EEHAAMAOJOL<T> LPDILHBGHIJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x1983CF0", Offset = "0x1982AF0", VA = "0x181983CF0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HNMIBHLBDII(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x1983380", Offset = "0x1982180", VA = "0x181983380")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x19842A0", Offset = "0x19830A0", VA = "0x1819842A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JFHKONJONGN(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x19840A0", Offset = "0x1982EA0", VA = "0x1819840A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IKHHFLADOBF(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x1983240", Offset = "0x1982040", VA = "0x181983240")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void BNEPCCGICDC(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public struct OCGCGAIFBCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private const int GCKDIBNBCAH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private NativeList<Entity> FBMJMNCDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private TransformAccessArray JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x26FA4E0", Offset = "0x26F92E0", VA = "0x1826FA4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NativeList<Entity> FKGLBEIKFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x15465A0", Offset = "0x15453A0", VA = "0x1815465A0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public TransformAccessArray MIBENKEEEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x26FA5B0", Offset = "0x26F93B0", VA = "0x1826FA5B0")]
	public OCGCGAIFBCP(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x26FA300", Offset = "0x26F9100", VA = "0x1826FA300")]
	public Entity FHABAEEIJEG(int AIPHGHFENPJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x26FA270", Offset = "0x26F9070", VA = "0x1826FA270")]
	public Transform AGDAIJOCIIH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x26FA560", Offset = "0x26F9360", VA = "0x1826FA560")]
	public void OCPJNJBCKID(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x26FA4F0", Offset = "0x26F92F0", VA = "0x1826FA4F0")]
	public void KAJJOIIPMBP(int ALHAMICPFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x26FA390", Offset = "0x26F9190", VA = "0x1826FA390")]
	public int HEFJCCLOLGO(Transform BCHADNCHEKP, Entity GEEFHDFLBEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x26FA460", Offset = "0x26F9260", VA = "0x1826FA460")]
	public int HGIANMDOCHF(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x26FA280", Offset = "0x26F9080", VA = "0x1826FA280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x26FA350", Offset = "0x26F9150", VA = "0x1826FA350")]
	private void FNBNOKMLGIF(int DCJPACPBNKG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class KGDDGEFLMIG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly KGDDGEFLMIG FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x26F0030", Offset = "0x26EEE30", VA = "0x1826F0030", Slot = "4")]
	public bool Equals(LinkedEntityGroup KNMKEOOODCL, LinkedEntityGroup EMKKILCIAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x26F0050", Offset = "0x26EEE50", VA = "0x1826F0050", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup CCPIHKCBGHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public KGDDGEFLMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IGLJAEKGNEC
{
	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void LNDIKNLGIEH(in Vector3 EIIEKPIPEEF, in Quaternion DCNMMHNEEEM, in Vector3 AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void NHIEEINNCGK(in Vector3 FKJNMOFLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void DNCOFNHLFPC(in Quaternion DCNMMHNEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void BMHDOAFDPBP(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void MDDHPCEHPAL(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void JCHLNHFKDOP(in float PJFFAKJCJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x26EC960", Offset = "0x26EB760", VA = "0x1826EC960")]
	[Conditional("DEBUG_BUILD")]
	public static void AGDNCCDMFDB(in float3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x26ECA40", Offset = "0x26EB840", VA = "0x1826ECA40")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x26ECA10", Offset = "0x26EB810", VA = "0x1826ECA10")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x26ECAD0", Offset = "0x26EB8D0", VA = "0x1826ECAD0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x26ECA90", Offset = "0x26EB890", VA = "0x1826ECA90")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x26ECAE0", Offset = "0x26EB8E0", VA = "0x1826ECAE0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public IGLJAEKGNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public struct FDCGJNDCDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public Entity GEEFHDFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Entity POICJGPACMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Entity JDMCICBCFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x2B00EC0", Offset = "0x2AFFCC0", VA = "0x182B00EC0")]
	public FDCGJNDCDCD(Entity GEEFHDFLBEH, Entity POICJGPACMK, Entity JDMCICBCFIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2B00E60", Offset = "0x2AFFC60", VA = "0x182B00E60")]
	public static FDCGJNDCDCD PAAEKNCKHBI((Entity entity, Entity oldParent, Entity newParent) HBFAFBABGFI)
	{
		return default(FDCGJNDCDCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2B00EA0", Offset = "0x2AFFCA0", VA = "0x182B00EA0")]
	public void PIELOEDOOJA(out Entity GEEFHDFLBEH, out Entity POICJGPACMK, out Entity JDMCICBCFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public struct MIFKFPHADFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Entity GEEFHDFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public Entity ADECAOLBLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xC4DB30", Offset = "0xC4C930", VA = "0x180C4DB30")]
	public MIFKFPHADFM(Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x26F7730", Offset = "0x26F6530", VA = "0x1826F7730")]
	public static MIFKFPHADFM PAAEKNCKHBI((Entity entity, Entity parent) HBFAFBABGFI)
	{
		return default(MIFKFPHADFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x26F7760", Offset = "0x26F6560", VA = "0x1826F7760")]
	public void PIELOEDOOJA(out Entity GEEFHDFLBEH, out Entity ADECAOLBLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
public struct FIGGIAMEMEL<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private GCHandle MIGDJNOKMHC;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool PDJPNKJGJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2527610", Offset = "0x2526410", VA = "0x182527610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x2527650", Offset = "0x2526450", VA = "0x182527650")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x2527550", Offset = "0x2526350", VA = "0x182527550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x25276F0", Offset = "0x25264F0", VA = "0x1825276F0")]
	public FIGGIAMEMEL(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x2527620", Offset = "0x2526420", VA = "0x182527620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[EBJHGMECDNA(typeof(IELCPLOPIMJ), new string[] { })]
public sealed class HENNBGFOJIG : IELCPLOPIMJ, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x26E93C0", Offset = "0x26E81C0", VA = "0x1826E93C0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x26E9320", Offset = "0x26E8120", VA = "0x1826E9320")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public HENNBGFOJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x26E9320", Offset = "0x26E8120", VA = "0x1826E9320", Slot = "4")]
	private bool AIPCIMOHECK(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EHOCPENPMLI))]
public sealed class GMIMCOGLPJE : PLPPACFFCAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public GMIMCOGLPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EHOCPENPMLI))]
[UpdateAfter(typeof(GMIMCOGLPJE))]
public sealed class IJOIPEJPICK : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x26ECFA0", Offset = "0x26EBDA0", VA = "0x1826ECFA0")]
	public IJOIPEJPICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(IJOIPEJPICK))]
[UpdateInGroup(typeof(EHOCPENPMLI))]
public sealed class CLFNFKBCGBM : AMAAPGIIJHF
{
	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public CLFNFKBCGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class LCBHOHHGHKC : PFEBNMLDBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public LCBHOHHGHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x26F5370", Offset = "0x26F4170", VA = "0x1826F5370", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class GMEILMIGPCC : OJGBHFKCJPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public GMEILMIGPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class INIBCJCKAJO : OHMOPMJJDKB
{
	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public INIBCJCKAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x26ED000", Offset = "0x26EBE00", VA = "0x1826ED000", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(CNDMKJANPBA))]
public sealed class CECHAALAEKE : LFLBNLDBEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x2AECA10", Offset = "0x2AEB810", VA = "0x182AECA10")]
	public CECHAALAEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x2AECA00", Offset = "0x2AEB800", VA = "0x182AECA00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(CDBKMKJLKKC))]
internal class CKKALKMOKJO : FPDBMMINPKE
{
	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public CKKALKMOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA40", Offset = "0x2AEC840", VA = "0x182AEDA40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal sealed class FKMLGBNBFBP : LCICNAGLPHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public FKMLGBNBFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x26E5460", Offset = "0x26E4260", VA = "0x1826E5460", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(FKMLGBNBFBP))]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal class BKGKPEPJGBD : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC600", Offset = "0x2AEB400", VA = "0x182AEC600")]
	public BKGKPEPJGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC5F0", Offset = "0x2AEB3F0", VA = "0x182AEC5F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[AlwaysUpdateSystem]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
[UpdateAfter(typeof(BKGKPEPJGBD))]
internal sealed class JJDKNFOLILB : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	protected override ApplyPropertyDifferences ENAAOEAAPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x26EF6B0", Offset = "0x26EE4B0", VA = "0x1826EF6B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x26EF700", Offset = "0x26EE500", VA = "0x1826EF700")]
	public JJDKNFOLILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(JJDKNFOLILB))]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal sealed class GEBOIHKOPFE : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x26E71A0", Offset = "0x26E5FA0", VA = "0x1826E71A0")]
	public GEBOIHKOPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
[UpdateAfter(typeof(JJDKNFOLILB))]
internal sealed class AMECLKKDJMI : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public AMECLKKDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class GACJCKKDMNG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public GACJCKKDMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class ECEGKIHDGFD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public ECEGKIHDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
[UpdateAfter(typeof(GACJCKKDMNG))]
internal sealed class NENDFNPOJPJ : FBGPKGAHMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public NENDFNPOJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(NENDFNPOJPJ))]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal sealed class MLBONNHEEBM : AEKANGFCDAO
{
	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public MLBONNHEEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class NGBLKHHEAGD : SetInactiveEmbodiedObjectsWithHiddenTag
{
	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x26F8F20", Offset = "0x26F7D20", VA = "0x1826F8F20")]
	public NGBLKHHEAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
[UpdateAfter(typeof(NENDFNPOJPJ))]
internal sealed class EOBDBGNACIJ : KKPNBIDGCGE
{
	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public EOBDBGNACIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class ONKALMKAIOC : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x26FBDC0", Offset = "0x26FABC0", VA = "0x1826FBDC0")]
	public ONKALMKAIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[AlwaysUpdateSystem]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
internal sealed class KIHDPJGMJJH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	protected override ApplyPropertyDifferences ENAAOEAAPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x26F2AD0", Offset = "0x26F18D0", VA = "0x1826F2AD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x26F2B20", Offset = "0x26F1920", VA = "0x1826F2B20")]
	public KIHDPJGMJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(KIHDPJGMJJH))]
internal sealed class OIMLEGBPLFN : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x26FB890", Offset = "0x26FA690", VA = "0x1826FB890")]
	public OIMLEGBPLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(KIHDPJGMJJH))]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
internal sealed class ICCDPIAHMDJ : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public ICCDPIAHMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(ICCDPIAHMDJ))]
internal sealed class HAPKDLHLLNK : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	protected override ComputePropertyDifferences PLIOAOLEJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x26E8AB0", Offset = "0x26E78B0", VA = "0x1826E8AB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x26E8B00", Offset = "0x26E7900", VA = "0x1826E8B00")]
	public HAPKDLHLLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(HAPKDLHLLNK))]
internal sealed class LBMJPGBICJG : COFDLBBLFME
{
	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x26F5360", Offset = "0x26F4160", VA = "0x1826F5360")]
	public LBMJPGBICJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GACJCKKDMNG))]
internal sealed class KPIOIDPOAPF : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x26F3360", Offset = "0x26F2160", VA = "0x1826F3360")]
	public KPIOIDPOAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GACJCKKDMNG))]
internal sealed class LIAPPGHFBHP : ADBJNMLEGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public LIAPPGHFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal class GALCAOICMCH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public GALCAOICMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
[UpdateAfter(typeof(GALCAOICMCH))]
internal sealed class PEAAFEMGPGI : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x2726020", Offset = "0x2724E20", VA = "0x182726020")]
	public PEAAFEMGPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x2725EC0", Offset = "0x2724CC0", VA = "0x182725EC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(GALCAOICMCH))]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal sealed class PPDBMLODJIJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public PPDBMLODJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PPDBMLODJIJ))]
internal sealed class MEJEFNLMBKN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public MEJEFNLMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(MEJEFNLMBKN))]
[UpdateInGroup(typeof(PPDBMLODJIJ))]
internal sealed class KADFNFOEOAP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public KADFNFOEOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class ANMEJHAGKIA : KLGOENHKPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public ANMEJHAGKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7070", Offset = "0x2AE5E70", VA = "0x182AE7070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(ANMEJHAGKIA))]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class PPMEIMCCAOK : LIICBMDDEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public PPMEIMCCAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x2726FA0", Offset = "0x2725DA0", VA = "0x182726FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PPMEIMCCAOK))]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class DBCHEHOIOIP : OPIMGAOPDNP
{
	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public DBCHEHOIOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KADFNFOEOAP))]
[UpdateAfter(typeof(DBCHEHOIOIP))]
internal class EECKJDEKOJB : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA9F0", Offset = "0x2AF97F0", VA = "0x182AFA9F0")]
	public EECKJDEKOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(MEJEFNLMBKN))]
internal sealed class ANPNHPCAMFO : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7080", Offset = "0x2AE5E80", VA = "0x182AE7080")]
	public ANPNHPCAMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
internal sealed class OOKIAPDOEHI : KIJDBALHHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	public OOKIAPDOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
[UpdateAfter(typeof(OOKIAPDOEHI))]
internal sealed class DPONPGEEDIB : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8CE0", Offset = "0x2AF7AE0", VA = "0x182AF8CE0")]
	public DPONPGEEDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(OOKIAPDOEHI))]
[UpdateInGroup(typeof(GALCAOICMCH))]
internal sealed class GFIPLMLCHMO : KFLEDGAOGNG
{
	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public GFIPLMLCHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
[UpdateAfter(typeof(GFIPLMLCHMO))]
[UpdateAfter(typeof(DPONPGEEDIB))]
internal sealed class IBPAJMPFBFI : JDGKDHAHBBO
{
	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public IBPAJMPFBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal class POGFIDCHONA : TransmitNetworkDataSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public POGFIDCHONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(MAINBLDADFG))]
internal sealed class JLDJFEGGDEB : PostGameplayOnScopeChange
{
	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x26EF760", Offset = "0x26EE560", VA = "0x1826EF760")]
	public JLDJFEGGDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class FOLBJCBGIIH : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x26E65D0", Offset = "0x26E53D0", VA = "0x1826E65D0")]
	public FOLBJCBGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
[UpdateAfter(typeof(FOLBJCBGIIH))]
internal class PJIMJKALPBO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public PJIMJKALPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PJIMJKALPBO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class ANGAHLPODJB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public ANGAHLPODJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
[UpdateAfter(typeof(PJIMJKALPBO))]
internal sealed class FLPLKEOOONA : UpdateContainerPivotOnExitScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x26E5FE0", Offset = "0x26E4DE0", VA = "0x1826E5FE0")]
	public FLPLKEOOONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(ANGAHLPODJB))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class KJAMHHLDILO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public KJAMHHLDILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(KJAMHHLDILO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class FBNOFIPNOAF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public FBNOFIPNOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PJIMJKALPBO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class APNEBBLNJPL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public APNEBBLNJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(APNEBBLNJPL))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class PENDCJNCAKL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public PENDCJNCAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class COIHLHAIHGH : JCNKOHLNAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEF00", Offset = "0x2AEDD00", VA = "0x182AEEF00")]
	public COIHLHAIHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEEF0", Offset = "0x2AEDCF0", VA = "0x182AEEEF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class ILPLPCIBBLN : HONFBOGIPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x26EA8A0", Offset = "0x26E96A0", VA = "0x1826EA8A0")]
	public ILPLPCIBBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x26EA860", Offset = "0x26E9660", VA = "0x1826EA860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class GEECICKCDBG : FJKACBADHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x26E48F0", Offset = "0x26E36F0", VA = "0x1826E48F0")]
	public GEECICKCDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x26E48B0", Offset = "0x26E36B0", VA = "0x1826E48B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class BNNCLJEALME : ClearScopeOnLocalPlayerChangeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC8B0", Offset = "0x2AEB6B0", VA = "0x182AEC8B0")]
	public BNNCLJEALME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class JAMJMHEDCEK : PreventDisembodiedScopesSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x26EE410", Offset = "0x26ED210", VA = "0x1826EE410")]
	public JAMJMHEDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class OLNOAPMHJBG : LocalPlayerScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x26FBC50", Offset = "0x26FAA50", VA = "0x1826FBC50")]
	public OLNOAPMHJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x26F7060", Offset = "0x26F5E60", VA = "0x1826F7060", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class NJEIHAGLBFJ : RemotePlayerScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x26F9D00", Offset = "0x26F8B00", VA = "0x1826F9D00")]
	public NJEIHAGLBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x26F9CF0", Offset = "0x26F8AF0", VA = "0x1826F9CF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
[UpdateAfter(typeof(OLNOAPMHJBG))]
internal sealed class MDAJDPGBJDN : CreateContainerPivotOnEnterScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x26F7250", Offset = "0x26F6050", VA = "0x1826F7250")]
	public MDAJDPGBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
[UpdateAfter(typeof(OLNOAPMHJBG))]
internal sealed class FJKAGFHOPBN : HideRemotePivotsNotInScope
{
	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
	public FJKAGFHOPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(FBNOFIPNOAF))]
internal sealed class AELKEOLNOPE : NIENIENGCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x26E7FF0", Offset = "0x26E6DF0", VA = "0x1826E7FF0")]
	public AELKEOLNOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4EB0", Offset = "0x2AE3CB0", VA = "0x182AE4EB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(FBNOFIPNOAF))]
[UpdateAfter(typeof(AELKEOLNOPE))]
internal sealed class OJKNBAKPKML : LFLBNLDBEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x26F59E0", Offset = "0x26F47E0", VA = "0x1826F59E0")]
	public OJKNBAKPKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x26F59A0", Offset = "0x26F47A0", VA = "0x1826F59A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
internal sealed class PAGPIOFHJHL : FPEBBPOHPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2725060", Offset = "0x2723E60", VA = "0x182725060")]
	public PAGPIOFHJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x2725050", Offset = "0x2723E50", VA = "0x182725050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
internal sealed class HHFIOBDONHP : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x26E99B0", Offset = "0x26E87B0", VA = "0x1826E99B0")]
	public HHFIOBDONHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x26E99A0", Offset = "0x26E87A0", VA = "0x1826E99A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
[UpdateAfter(typeof(HHFIOBDONHP))]
internal sealed class BJBDOLOLDMK : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC590", Offset = "0x2AEB390", VA = "0x182AEC590")]
	public BJBDOLOLDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PJIMJKALPBO))]
internal sealed class LOCFIPGKIGE : AssignPlayerIdsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x26F64A0", Offset = "0x26F52A0", VA = "0x1826F64A0")]
	public LOCFIPGKIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x26F6490", Offset = "0x26F5290", VA = "0x1826F6490", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[FLIEEAHPEDE(typeof(AuthoredLocalPoseData))]
public sealed class KAEFPHLHLJO : BEDDJBOFBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x26EF880", Offset = "0x26EE680", VA = "0x1826EF880", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<AuthoredLocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x26EF7C0", Offset = "0x26EE5C0", VA = "0x1826EF7C0", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<AuthoredLocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x26EF900", Offset = "0x26EE700", VA = "0x1826EF900")]
	public KAEFPHLHLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[FLIEEAHPEDE(typeof(LocalPoseData))]
public sealed class KHPALNDLCHF : PPFAMFIEDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x26F2A40", Offset = "0x26F1840", VA = "0x1826F2A40", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<LocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x26F2980", Offset = "0x26F1780", VA = "0x1826F2980", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<LocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x26F2AC0", Offset = "0x26F18C0", VA = "0x1826F2AC0")]
	public KHPALNDLCHF()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[Preserve]
	internal class _RRAssemblyIndex : ICKAPGKMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2741750", Offset = "0x2740550", VA = "0x182741750", Slot = "6")]
		public sealed override void ADPJAIEJIPK(BDNCAKHHJCI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2742330", Offset = "0x2741130", VA = "0x182742330", Slot = "4")]
		public sealed override void GEKIOEINPME()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2E10", Offset = "0x2AE1C10", VA = "0x182AE2E10")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2F20", Offset = "0x2AE1D20", VA = "0x182AE2F20")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001D2")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
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
