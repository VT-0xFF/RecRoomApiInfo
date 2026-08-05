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
public sealed class PEEGADDKCBD<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class CEECLCOKEIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::PEEGADDKCBD<T> IFGOPHHFHDO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] LJJHNDEACIH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public CEECLCOKEIF(global::PEEGADDKCBD<T> IFGOPHHFHDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BKFEKMPLHED : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::PEEGADDKCBD<T> <>4__this;

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
		public BKFEKMPLHED(int <>1__state)
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
	private const int LKOKKMGDDDO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> MHFCFOLLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int NAPGCONFIHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T MJCFBIMFFNK
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
	private bool NNIBKOJBFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HKINNMIALFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool EDNHJGFBFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BACNEHOFKKO
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
	public int OAHKGMMAIIG
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
	public PEEGADDKCBD(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public PEEGADDKCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void OKMFLBBLACE(int CPOAAGLEIPE, T CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void BPJGFIPNNHC(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] ADDGACCNMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void HIMGKLIIPCL(NativeArray<T> ECEFKNGMHII, int NKBOPBAMDKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::PEEGADDKCBD<>.BKFEKMPLHED))]
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
	public int EAKNCNMGFIF(T CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool IHKCCNMHHEB(T CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void GKNBJNPILGD(int EOJCNLMMCAP, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void OLPGKOOGHBJ(int EOJCNLMMCAP, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void LMJADNDAMJI(int EOJCNLMMCAP, int JBINMJEHBFH, int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int FJKKBDOLPLH(int CPOAAGLEIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T LEDAOLOAPNE(int CPOAAGLEIPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void CHCFDGAFCHO(int CPOAAGLEIPE, T CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void KBHEDAEBGNJ(int CPOAAGLEIPE, T CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void LFGAGBMOJLI(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int PIDBCNOFPJD(int NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int CCPELLDNLED(int NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void OOPDDMGIMPE(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void IEAAHKCPGEG(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T CLADCMPMKDN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T ENHCMLCDCJM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void ECDEDOFLKFL(int CPOAAGLEIPE, IReadOnlyCollection<T> AEBOLACOCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void IIMBCCJPKMG(int CPOAAGLEIPE, int LGCAPNHMDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void EMIMPIIKCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void GHEECJKALKL(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void DHPHEFJMAPE(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void KJAMDEJNFMP(int JBINMJEHBFH, int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T AAMOGOPBBKB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T DFOKCBDCLMM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CNPKDPIJOGH]
public static class KJJAALKDNFL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE2B0", Offset = "0x2FCD0B0", VA = "0x182FCE2B0")]
	static KJJAALKDNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25DB620", Offset = "0x25DA420", VA = "0x1825DB620")]
	public static void HGFFGJANEIJ<T>(T ALDENJHFODN, ref T ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE1E0", Offset = "0x2FCCFE0", VA = "0x182FCE1E0")]
	public static void HGFFGJANEIJ(FixedString32 ALDENJHFODN, ref string ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDFF0", Offset = "0x2FCCDF0", VA = "0x182FCDFF0")]
	public static void HGFFGJANEIJ(string ALDENJHFODN, ref FixedString32 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE240", Offset = "0x2FCD040", VA = "0x182FCE240")]
	public static void HGFFGJANEIJ(FixedString64 ALDENJHFODN, ref string ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE110", Offset = "0x2FCCF10", VA = "0x182FCE110")]
	public static void HGFFGJANEIJ(string ALDENJHFODN, ref FixedString64 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE210", Offset = "0x2FCD010", VA = "0x182FCE210")]
	public static void HGFFGJANEIJ(OHALJBLPHEL ALDENJHFODN, ref Vector3 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE030", Offset = "0x2FCCE30", VA = "0x182FCE030")]
	public static void HGFFGJANEIJ(Vector3 ALDENJHFODN, ref OHALJBLPHEL ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE0C0", Offset = "0x2FCCEC0", VA = "0x182FCE0C0")]
	public static void HGFFGJANEIJ(DHFLIEAMNDN ALDENJHFODN, ref Vector4 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDF40", Offset = "0x2FCCD40", VA = "0x182FCDF40")]
	public static void HGFFGJANEIJ(Vector4 ALDENJHFODN, ref DHFLIEAMNDN ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE0C0", Offset = "0x2FCCEC0", VA = "0x182FCE0C0")]
	public static void HGFFGJANEIJ(DHFLIEAMNDN ALDENJHFODN, ref Quaternion ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDF40", Offset = "0x2FCCD40", VA = "0x182FCDF40")]
	public static void HGFFGJANEIJ(Quaternion ALDENJHFODN, ref DHFLIEAMNDN ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE090", Offset = "0x2FCCE90", VA = "0x182FCE090")]
	public static void HGFFGJANEIJ(OHALJBLPHEL ALDENJHFODN, ref float3 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE030", Offset = "0x2FCCE30", VA = "0x182FCE030")]
	public static void HGFFGJANEIJ(float3 ALDENJHFODN, ref OHALJBLPHEL ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE270", Offset = "0x2FCD070", VA = "0x182FCE270")]
	public static void HGFFGJANEIJ(DHFLIEAMNDN ALDENJHFODN, ref float4 ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDF40", Offset = "0x2FCCD40", VA = "0x182FCDF40")]
	public static void HGFFGJANEIJ(float4 ALDENJHFODN, ref DHFLIEAMNDN ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE270", Offset = "0x2FCD070", VA = "0x182FCE270")]
	public static void HGFFGJANEIJ(DHFLIEAMNDN ALDENJHFODN, ref quaternion ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE170", Offset = "0x2FCCF70", VA = "0x182FCE170")]
	public static void HGFFGJANEIJ(quaternion ALDENJHFODN, ref DHFLIEAMNDN ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDFB0", Offset = "0x2FCCDB0", VA = "0x182FCDFB0")]
	public static void HGFFGJANEIJ(Entity ALDENJHFODN, ref AKPALCMJPCN ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE0F0", Offset = "0x2FCCEF0", VA = "0x182FCE0F0")]
	public static void HGFFGJANEIJ(AKPALCMJPCN ALDENJHFODN, ref Entity ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PNDCBMPMNFM]
public class PIPININCHPF : ComponentSystem, OMEPFIBEFCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AACHPGDKAKL KNNIEFOMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NMDCIMKFCEN EOOBNKAGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F17AE0", Offset = "0x2F168E0", VA = "0x182F17AE0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
	public PIPININCHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PNDCBMPMNFM]
[UpdateInGroup(typeof(IMAHCPEKDHM))]
internal class LFBOLEIJFAF : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2AB0", Offset = "0x2FD18B0", VA = "0x182FD2AB0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2CF0", Offset = "0x2FD1AF0", VA = "0x182FD2CF0")]
	[Preserve]
	private void DCAMJGJKNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public LFBOLEIJFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[PNDCBMPMNFM]
[UpdateInGroup(typeof(IMAHCPEKDHM))]
internal class LCAIDAHLLME : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0980", Offset = "0x2FCF780", VA = "0x182FD0980", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public LCAIDAHLLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F730", Offset = "0x2F0E530", VA = "0x182F0F730")]
		public static ObjectModelConfigAsset LCHFLOFMIGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x79C840", Offset = "0x79B640", VA = "0x18079C840")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[IDOCBBAEIFB(JHEANMHFGAO.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int PEBOJACILFM = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly JFPIEAPAMJM MCHCOEKKPGN;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x42FE300", Offset = "0x42FD100", VA = "0x1842FE300")]
			public static BDCMCEOAOGF FLHMMPOOJFA(int DEAHCEAMBLM)
			{
				return default(BDCMCEOAOGF);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x42FE170", Offset = "0x42FCF70", VA = "0x1842FE170")]
			private static void CCAAJNJGJAC(IMKMJFJEHIJ BMEKEFGFGPG, IMKMJFJEHIJ EKCIANENBNL, BDCMCEOAOGF CONHLPJBCJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x42FE6F0", Offset = "0x42FD4F0", VA = "0x1842FE6F0")]
			public static int MINNOMDFNIP(GameObject AAMBGNNHMBI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x42FE8C0", Offset = "0x42FD6C0", VA = "0x1842FE8C0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void PNLOBNFKEAM(IMKMJFJEHIJ NAKKFJMFOAE, int DEAHCEAMBLM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static HKDBAIGILEN DHPFLPHCDGG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static AMKKONJMFJF APJIEBMMBFG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static HKDBAIGILEN EFMEONGMFIA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FF60", Offset = "0x2F0ED60", VA = "0x182F0FF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2F111D0", Offset = "0x2F0FFD0", VA = "0x182F111D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static AMKKONJMFJF NGGGJBCAGBA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2F10610", Offset = "0x2F0F410", VA = "0x182F10610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2F10EF0", Offset = "0x2F0FCF0", VA = "0x182F10EF0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool KFODAIONJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2F10730", Offset = "0x2F0F530", VA = "0x182F10730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static AACHPGDKAKL KNNIEFOMKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FD40", Offset = "0x2F0EB40", VA = "0x182F0FD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static NMDCIMKFCEN EOOBNKAGIEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FDE0", Offset = "0x2F0EBE0", VA = "0x182F0FDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static HNBHMAHMNDN HONDPGGHJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2F112B0", Offset = "0x2F100B0", VA = "0x182F112B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static EACEJDIFHIM NBDJLKNOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2F10D40", Offset = "0x2F0FB40", VA = "0x182F10D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static LMLOCAEKAJL ADKKADHFEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FFC0", Offset = "0x2F0EDC0", VA = "0x182F0FFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static HBOFDJIDNOO ACGHEKPJOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2F109B0", Offset = "0x2F0F7B0", VA = "0x182F109B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool HACMLPKIAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2F0F7D0", Offset = "0x2F0E5D0", VA = "0x182F0F7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool IPFLNGLLPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2F10DC0", Offset = "0x2F0FBC0", VA = "0x182F10DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool JFGLLJMJKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2F10A30", Offset = "0x2F0F830", VA = "0x182F10A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool ANPDPPMCBKH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2F10040", Offset = "0x2F0EE40", VA = "0x182F10040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2F11170", Offset = "0x2F0FF70", VA = "0x182F11170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool FCCBHFDMAGA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FC80", Offset = "0x2F0EA80", VA = "0x182F0FC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2F11330", Offset = "0x2F10130", VA = "0x182F11330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action ALPMDICHCGA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2F10510", Offset = "0x2F0F310", VA = "0x182F10510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2F0FE60", Offset = "0x2F0EC60", VA = "0x182F0FE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2F102A0", Offset = "0x2F0F0A0", VA = "0x182F102A0")]
		public static IMKMJFJEHIJ GGBDBGCDFJE(GameObject AAMBGNNHMBI)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FCE0", Offset = "0x2F0EAE0", VA = "0x182F0FCE0")]
		public static bool CLCKABPAAHG(ByteString HDHLDBBIAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2F10890", Offset = "0x2F0F690", VA = "0x182F10890")]
		public static HGGBOIBCHBA JHCEJFGPANG(BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F8B0", Offset = "0x2F0E6B0", VA = "0x182F0F8B0")]
		public static (ByteString, IDisposable) APDPBGNCGIO()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FA00", Offset = "0x2F0E800", VA = "0x182F0FA00")]
		public static (ByteString, IDisposable) BGIOBHKLGKJ(IEnumerable<IMKMJFJEHIJ> BECONHIACLM)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2F0FB50", Offset = "0x2F0E950", VA = "0x182F0FB50")]
		public static bool BHCMDJPIBKP(GameObject AAMBGNNHMBI, out BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2F10C20", Offset = "0x2F0FA20", VA = "0x182F10C20")]
		public static bool KJJPEDFDMJF(IEnumerable<CEJNCBODCBD> HLMMLGBNPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2F11390", Offset = "0x2F10190", VA = "0x182F11390")]
		public static void POPODDHKMKK(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2F10390", Offset = "0x2F0F190", VA = "0x182F10390")]
		public static Task HBGLFDIBEPF(bool INLFOKCKKHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2F101C0", Offset = "0x2F0EFC0", VA = "0x182F101C0")]
		private static AMKKONJMFJF GDCNIKDCKPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2F100A0", Offset = "0x2F0EEA0", VA = "0x182F100A0")]
		private static bool GBPCFHKINIA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[IDOCBBAEIFB(JHEANMHFGAO.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2F162F0", Offset = "0x2F150F0", VA = "0x182F162F0")]
		public static bool PIDMHCABFMB(ILANHKOILOA EPALBCHLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F15AD0", Offset = "0x2F148D0", VA = "0x182F15AD0")]
		public static ILANHKOILOA CBFNCDGCFPB(GameObject AAMBGNNHMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2F15D00", Offset = "0x2F14B00", VA = "0x182F15D00")]
		public static ILANHKOILOA CBFNCDGCFPB(GameObject AAMBGNNHMBI, BDCMCEOAOGF CONHLPJBCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2F161F0", Offset = "0x2F14FF0", VA = "0x182F161F0")]
		public static bool IMCBCMOLCJL(GameObject BEPEHBCCEGM, string EELPCBACAFO, bool GNPLFOLGKLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2F15F00", Offset = "0x2F14D00", VA = "0x182F15F00")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void CMEKPNJNPMI(GameObject BEPEHBCCEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2F16100", Offset = "0x2F14F00", VA = "0x182F16100")]
		[CompilerGenerated]
		internal static string DIJBLEGAHKD((GameObject go, string prefabName) GLNACLILDAP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, CMEGKHBIEMH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool CKBGNMHNINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public IMKMJFJEHIJ HMGKGGLBAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IMKMJFJEHIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x779C00", Offset = "0x778A00", VA = "0x180779C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[IDOCBBAEIFB(JHEANMHFGAO.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, ILANHKOILOA, CMEGKHBIEMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string MAKOCEGHAAH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LHNKGGLPOHF NNMLCFCBKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IMKMJFJEHIJ LNCGECBHMHD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IMKMJFJEHIJ HMGKGGLBAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3510CD0", Offset = "0x350FAD0", VA = "0x183510CD0", Slot = "15")]
			get
			{
				return default(IMKMJFJEHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public HGGBOIBCHBA BLCJDOLCLLF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3510D80", Offset = "0x350FB80", VA = "0x183510D80", Slot = "6")]
			get
			{
				return default(HGGBOIBCHBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool CKBGNMHNINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3510CC0", Offset = "0x350FAC0", VA = "0x183510CC0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LHNKGGLPOHF IGIAPHFBJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x783910", Offset = "0x782710", VA = "0x180783910", Slot = "7")]
			get
			{
				return default(LHNKGGLPOHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private NMDCIMKFCEN EOOBNKAGIEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x35102D0", Offset = "0x350F0D0", VA = "0x1835102D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OKNLNFBIJGH BOCCCPDAMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3510270", Offset = "0x350F070", VA = "0x183510270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BCNBOCBJCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> GHILICHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3510B80", Offset = "0x350F980", VA = "0x183510B80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3510DB0", Offset = "0x350FBB0", VA = "0x183510DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ILANHKOILOA> OABCEOIABFN
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3510C20", Offset = "0x350FA20", VA = "0x183510C20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3510E50", Offset = "0x350FC50", VA = "0x183510E50", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3510090", Offset = "0x350EE90", VA = "0x183510090")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3510950", Offset = "0x350F750", VA = "0x183510950", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3510600", Offset = "0x350F400", VA = "0x183510600", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x35108C0", Offset = "0x350F6C0", VA = "0x1835108C0", Slot = "10")]
		public void OnEmbody(CIHNJOKIFOM PGJEGNBAENG, IMKMJFJEHIJ LNCGECBHMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3510940", Offset = "0x350F740", VA = "0x183510940", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x35106B0", Offset = "0x350F4B0", VA = "0x1835106B0", Slot = "12")]
		public void OnDisembody(bool EFBHMADLAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x35104A0", Offset = "0x350F2A0", VA = "0x1835104A0")]
		private void NCKLCJPIDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3510AA0", Offset = "0x350F8A0", VA = "0x183510AA0")]
		private void PCPDDHPEIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x35103B0", Offset = "0x350F1B0", VA = "0x1835103B0")]
		private void FFHIOLECNCL(bool KKFENDOGFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x35105A0", Offset = "0x350F3A0", VA = "0x1835105A0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xEEB540", Offset = "0xEEA340", VA = "0x180EEB540", Slot = "9")]
		private GameObject DMNLKMHFLBE()
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
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[IDOCBBAEIFB(JHEANMHFGAO.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FJNOGBCPDIO ALIKCOAJHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2F21920", Offset = "0x2F20720", VA = "0x182F21920", Slot = "6")]
			get
			{
				return default(FJNOGBCPDIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F218C0", Offset = "0x2F206C0", VA = "0x182F218C0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[IDOCBBAEIFB(JHEANMHFGAO.Registration)]
	public class TransformEntity : MonoBehaviour, CMEGKHBIEMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private FJNOGBCPDIO prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IMKMJFJEHIJ NAKKFJMFOAE;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual FJNOGBCPDIO ALIKCOAJHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080", Slot = "6")]
			get
			{
				return default(FJNOGBCPDIO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x76DC00", Offset = "0x76CA00", VA = "0x18076DC00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IMKMJFJEHIJ HMGKGGLBAPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x787590", Offset = "0x786390", VA = "0x180787590", Slot = "5")]
			get
			{
				return default(IMKMJFJEHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CKBGNMHNINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x944F40", Offset = "0x943D40", VA = "0x180944F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity FEOLBGIIBMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal LMLOCAEKAJL ADKKADHFEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal OKNLNFBIJGH HDLBIPNLHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x32860E0", Offset = "0x3284EE0", VA = "0x1832860E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3285C30", Offset = "0x3284A30", VA = "0x183285C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3285CE0", Offset = "0x3284AE0", VA = "0x183285CE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3285DD0", Offset = "0x3284BD0", VA = "0x183285DD0")]
		internal void GIHONBOCKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3285C40", Offset = "0x3284A40", VA = "0x183285C40")]
		private bool BJMEJAEGDEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3285C00", Offset = "0x3284A00", VA = "0x183285C00")]
		private void AIALPHNEPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3285CE0", Offset = "0x3284AE0", VA = "0x183285CE0")]
		internal void GHJILDGPFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3286150", Offset = "0x3284F50", VA = "0x183286150")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3286230", Offset = "0x3285030", VA = "0x183286230")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[IHOFDNBJLIN(typeof(AMKKONJMFJF), new string[] { })]
[BEHFJGBFKGL(typeof(NCEPMNGGADP))]
public class BDKFFIEKJCB : AMKKONJMFJF, HPIGFHAGGMG, NCEPMNGGADP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IMCAFFIABPB PIMEDEKHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NMDCIMKFCEN GINNLCCNCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FKJLGPBPIDL MHJJJMOMFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DLFIMMPKEOH HPEJLCLAJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DLGFIBKMHIF FKIJDDCGHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IMCAFFIABPB KNNIEFOMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IDJFGKMJFPG GGGDIHGAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NMDCIMKFCEN EOOBNKAGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public DLFIMMPKEOH LIEIAPCKLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DLGFIBKMHIF HOIEGKOONMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NOIGHNNNJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FED80", Offset = "0x6FDB80", VA = "0x1806FED80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OHGLCGABLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x34F8130", Offset = "0x34F6F30", VA = "0x1834F8130", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OLNJDKMAFEA GFDJNCCCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xCF6040", Offset = "0xCF4E40", VA = "0x180CF6040", Slot = "10")]
		get
		{
			return default(OLNJDKMAFEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34F7EF0", Offset = "0x34F6CF0", VA = "0x1834F7EF0")]
	public static BDKFFIEKJCB FBMANFCLCAO(IMCAFFIABPB PIMEDEKHCHH, GBFMPENIGFN FELMKIDGPKI = GBFMPENIGFN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void CHAKAGIPAFC(IMCAFFIABPB PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void CKJIANDHAPE(IMCAFFIABPB PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34F7FE0", Offset = "0x34F6DE0", VA = "0x1834F7FE0", Slot = "11")]
	public void GEMGHIFELBL(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FDE540", Offset = "0x2FDD340", VA = "0x182FDE540")]
	private void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34F8140", Offset = "0x34F6F40", VA = "0x1834F8140")]
	private void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34F7E90", Offset = "0x34F6C90", VA = "0x1834F7E90", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BDKFFIEKJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CJEFPAKJNEP
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x34FC530", Offset = "0x34FB330", VA = "0x1834FC530")]
	public static HGGBOIBCHBA KKPFEJHGOEM(this AMKKONJMFJF APJIEBMMBFG, BDCMCEOAOGF CONHLPJBCJE, FJNOGBCPDIO CEBPAJMCGMI)
	{
		return default(HGGBOIBCHBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34FC410", Offset = "0x34FB210", VA = "0x1834FC410")]
	public static CBPNDIDMMGD KHLFPHLBOAJ(this AMKKONJMFJF APJIEBMMBFG)
	{
		return default(CBPNDIDMMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x34FC230", Offset = "0x34FB030", VA = "0x1834FC230")]
	public static IMKMJFJEHIJ GGBDBGCDFJE(this AMKKONJMFJF APJIEBMMBFG, Entity JCNIDEIPPBD)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34FC2E0", Offset = "0x34FB0E0", VA = "0x1834FC2E0")]
	public static IMKMJFJEHIJ GGBDBGCDFJE(this AMKKONJMFJF APJIEBMMBFG, BDCMCEOAOGF CONHLPJBCJE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34FC670", Offset = "0x34FB470", VA = "0x1834FC670")]
	public static BDCMCEOAOGF MBLCFJOHPHH(this AMKKONJMFJF APJIEBMMBFG, IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(BDCMCEOAOGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum GBFMPENIGFN
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
[IHOFDNBJLIN(typeof(DLGFIBKMHIF), new string[] { })]
public class JDLECIHPKJO : DLGFIBKMHIF, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[CEFONNIACOK]
	private NCEPMNGGADP LBJPFNIJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private IMCAFFIABPB PIMEDEKHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private LPDKJACLMMI HPEJLCLAJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FKJLGPBPIDL MHJJJMOMFAI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action IPPOAEOJPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC88C0", Offset = "0x2FC76C0", VA = "0x182FC88C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8650", Offset = "0x2FC7450", VA = "0x182FC8650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8960", Offset = "0x2FC7760", VA = "0x182FC8960", Slot = "16")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8830", Offset = "0x2FC7630", VA = "0x182FC8830", Slot = "13")]
	public void MHDCMBKNFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "6")]
	public void HONKAOILKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8720", Offset = "0x2FC7520", VA = "0x182FC8720", Slot = "7")]
	public void KHEHIHNKCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8520", Offset = "0x2FC7320", VA = "0x182FC8520", Slot = "8")]
	public void BEDFBHAHODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x23BB540", Offset = "0x23BA340", VA = "0x1823BB540", Slot = "9")]
	public void GGJDMBHNAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC84D0", Offset = "0x2FC72D0", VA = "0x182FC84D0", Slot = "10")]
	public void AMKOLHJMLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8770", Offset = "0x2FC7570", VA = "0x182FC8770", Slot = "11")]
	public bool KJJPEDFDMJF(IEnumerable<CEJNCBODCBD> HLMMLGBNPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8600", Offset = "0x2FC7400", VA = "0x182FC8600", Slot = "12")]
	public void CMDOKGNAEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8870", Offset = "0x2FC7670", VA = "0x182FC8870", Slot = "14")]
	public void MICHBNPALAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC85A0", Offset = "0x2FC73A0", VA = "0x182FC85A0", Slot = "15")]
	public void BHLFCOMJKGA(bool LEDCGOCCGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC86F0", Offset = "0x2FC74F0", VA = "0x182FC86F0")]
	private void JOIIKANJLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JDLECIHPKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IHOFDNBJLIN(typeof(DLFIMMPKEOH), new string[] { })]
public class MCHBKDALNCC : DLFIMMPKEOH, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CEFONNIACOK]
	private NCEPMNGGADP LBJPFNIJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private IMCAFFIABPB PIMEDEKHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LPDKJACLMMI HPEJLCLAJEO;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F02110", Offset = "0x2F00F10", VA = "0x182F02110", Slot = "6")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F01F90", Offset = "0x2F00D90", VA = "0x182F01F90", Slot = "4")]
	public ByteString APDPBGNCGIO(out IDisposable MJNBAGFEJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F01FF0", Offset = "0x2F00DF0", VA = "0x182F01FF0", Slot = "5")]
	public void DHABJCANOEO(ByteString PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MCHBKDALNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class OENAJOMCEIO<T> : global::HMJPHMAEHEN<T>, global::BPLIOBAGCJM<BDCMCEOAOGF, T>, global::BBNPIPJMFCO<BDCMCEOAOGF>, PKDFMMCFBEC, IDisposable, ABFPBMDJHKI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::BBNPIPJMFCO<Entity> PEJFAKHLGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate FNFOFDDCKIE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3B52E20", Offset = "0x3B51C20", VA = "0x183B52E20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type DKNGEPPLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B48DC0", Offset = "0x3B47BC0", VA = "0x183B48DC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KKDMPHCELIM KCABIIODKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3B498C0", Offset = "0x3B486C0", VA = "0x183B498C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int MJEADEHJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3B51410", Offset = "0x3B50210", VA = "0x183B51410", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DHCFGDAAPFD CNCFLBBGDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B4E340", Offset = "0x3B4D140", VA = "0x183B4E340", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2773E70", Offset = "0x2772C70", VA = "0x182773E70", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3B50D00", Offset = "0x3B4FB00", VA = "0x183B50D00", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MLHMLJKCLJD<BDCMCEOAOGF> ALPMDICHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3B51160", Offset = "0x3B4FF60", VA = "0x183B51160", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3B4EAB0", Offset = "0x3B4D8B0", VA = "0x183B4EAB0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x36B3EE0", Offset = "0x36B2CE0", VA = "0x1836B3EE0")]
	public OENAJOMCEIO(global::BBNPIPJMFCO<Entity> PEJFAKHLGCN, LMLOCAEKAJL NGPKJGJONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B49580", Offset = "0x3B48380", VA = "0x183B49580")]
	private Entity CIMBGCEMMDH(BDCMCEOAOGF CONHLPJBCJE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x36AC530", Offset = "0x36AB330", VA = "0x1836AC530")]
	private BDCMCEOAOGF CIMBGCEMMDH(Entity JCNIDEIPPBD)
	{
		return default(BDCMCEOAOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3B484F0", Offset = "0x3B472F0", VA = "0x183B484F0", Slot = "4")]
	public T BPAEGFNIDAI(BDCMCEOAOGF CONHLPJBCJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B52AE0", Offset = "0x3B518E0", VA = "0x183B52AE0")]
	public bool NIPKJFNBLBF(BDCMCEOAOGF CONHLPJBCJE, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B46130", Offset = "0x3B44F30", VA = "0x183B46130")]
	public bool BDFMFLCCNJF(BDCMCEOAOGF CONHLPJBCJE, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B50890", Offset = "0x3B4F690", VA = "0x183B50890", Slot = "9")]
	public bool HKAKAEDOFMA(BDCMCEOAOGF CONHLPJBCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B49110", Offset = "0x3B47F10", VA = "0x183B49110", Slot = "26")]
	public object CGCJIPFENIG(BDCMCEOAOGF CONHLPJBCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B450E0", Offset = "0x3B43EE0", VA = "0x183B450E0")]
	public bool BCCIDAIILGF(BDCMCEOAOGF CONHLPJBCJE, in object BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B477B0", Offset = "0x3B465B0", VA = "0x183B477B0")]
	public void BPAEGFNIDAI(BDCMCEOAOGF CONHLPJBCJE, in IADENELHJPC NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B527F0", Offset = "0x3B515F0", VA = "0x183B527F0")]
	public bool NIPKJFNBLBF(BDCMCEOAOGF CONHLPJBCJE, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B460B0", Offset = "0x3B44EB0", VA = "0x183B460B0")]
	public bool BDFMFLCCNJF(BDCMCEOAOGF CONHLPJBCJE, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x36A8E00", Offset = "0x36A7C00", VA = "0x1836A8E00", Slot = "22")]
	public void ABOJAHHKNKA(LMJKNNOOLMK LHNPCANBMJO, [Optional] object KPEPJOHCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B43FC0", Offset = "0x3B42DC0", VA = "0x183B43FC0", Slot = "15")]
	public void ABOJAHHKNKA(BDCMCEOAOGF ANFHHLAHMJD, OAGIJOPMPLM LHNPCANBMJO, object KPEPJOHCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E3E0", Offset = "0x3B4D1E0", VA = "0x183B4E3E0", Slot = "14")]
	public bool DMNJIELPLLP(BDCMCEOAOGF ACLNLJOHHEH, BDCMCEOAOGF ALDENJHFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2640800", Offset = "0x263F600", VA = "0x182640800", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B54280", Offset = "0x3B53080", VA = "0x183B54280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x37D0550", Offset = "0x37CF350", VA = "0x1837D0550")]
	public string KBFCGINLFPD(in KNIHKHKCMFB FEKFEMKDLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3B50540", Offset = "0x3B4F340", VA = "0x183B50540")]
	private void GGCHGCCMHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3B53180", Offset = "0x3B51F80", VA = "0x183B53180")]
	private void OEEKJCNMLCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AD30", Offset = "0x3B49B30", VA = "0x183B4AD30")]
	private void DAHGNKMNKAF(Entity JCNIDEIPPBD, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F1E0", Offset = "0x3B4DFE0", VA = "0x183B4F1E0")]
	private void GAPDIDKIKJJ(Entity JCNIDEIPPBD, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DDA0", Offset = "0x3B4CBA0", VA = "0x183B4DDA0")]
	[Conditional("DEBUG_BUILD")]
	private static void DENMHEEKHPH(Entity JCNIDEIPPBD, BDCMCEOAOGF CONHLPJBCJE, string MIJBBGDIDLJ, string LPFBEMKEFPN, [CallerMemberName] string FJKILFKOOBJ = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2EF20B0", Offset = "0x2EF0EB0", VA = "0x182EF20B0", Slot = "5")]
	private bool LBBIHBIJKLL(BDCMCEOAOGF ANFHHLAHMJD, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x31CEA90", Offset = "0x31CD890", VA = "0x1831CEA90", Slot = "6")]
	private bool GFGGCMEJKKN(BDCMCEOAOGF ANFHHLAHMJD, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2C34DC0", Offset = "0x2C33BC0", VA = "0x182C34DC0", Slot = "10")]
	private bool EGICIOJOMKA(BDCMCEOAOGF ANFHHLAHMJD, in object BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x36A9590", Offset = "0x36A8390", VA = "0x1836A9590", Slot = "11")]
	private void BBLKDLHENGD(BDCMCEOAOGF ANFHHLAHMJD, in IADENELHJPC NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x36B2060", Offset = "0x36B0E60", VA = "0x1836B2060", Slot = "12")]
	private bool KLACDGLKCDM(BDCMCEOAOGF ANFHHLAHMJD, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x36B2090", Offset = "0x36B0E90", VA = "0x1836B2090", Slot = "13")]
	private bool LGLJKJLHHOA(BDCMCEOAOGF ANFHHLAHMJD, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC210", Offset = "0x2FDB010", VA = "0x182FDC210", Slot = "16")]
	private string HACPHIJCHEC(in KNIHKHKCMFB NLHFEJHKLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class FKLAAKHFBCC<T> : global::EEMMAJNELDH<T>, global::BPLIOBAGCJM<IMKMJFJEHIJ, T>, global::BBNPIPJMFCO<IMKMJFJEHIJ>, PKDFMMCFBEC, IDisposable, HFFBKOKLMCH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::BBNPIPJMFCO<Entity> PEJFAKHLGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate FNFOFDDCKIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LMPHGOGJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x37D09F0", Offset = "0x37CF7F0", VA = "0x1837D09F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type DKNGEPPLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x37CEEE0", Offset = "0x37CDCE0", VA = "0x1837CEEE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public KKDMPHCELIM KCABIIODKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x37CEFB0", Offset = "0x37CDDB0", VA = "0x1837CEFB0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MJEADEHJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x37D04B0", Offset = "0x37CF2B0", VA = "0x1837D04B0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DHCFGDAAPFD CNCFLBBGDII
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x37CF8D0", Offset = "0x37CE6D0", VA = "0x1837CF8D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x36D0870", Offset = "0x36CF670", VA = "0x1836D0870", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x36D6BB0", Offset = "0x36D59B0", VA = "0x1836D6BB0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MLHMLJKCLJD<IMKMJFJEHIJ> ALPMDICHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x37D0300", Offset = "0x37CF100", VA = "0x1837D0300", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x37CFA60", Offset = "0x37CE860", VA = "0x1837CFA60", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x36B3EE0", Offset = "0x36B2CE0", VA = "0x1836B3EE0")]
	public FKLAAKHFBCC(global::BBNPIPJMFCO<Entity> PEJFAKHLGCN, LMLOCAEKAJL NGPKJGJONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x23040F0", Offset = "0x2302EF0", VA = "0x1823040F0")]
	private Entity CIMBGCEMMDH(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x36D0BC0", Offset = "0x36CF9C0", VA = "0x1836D0BC0")]
	private IMKMJFJEHIJ CIMBGCEMMDH(Entity JCNIDEIPPBD)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x37CE780", Offset = "0x37CD580", VA = "0x1837CE780", Slot = "4")]
	public T BPAEGFNIDAI(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37D07E0", Offset = "0x37CF5E0", VA = "0x1837D07E0")]
	public bool NIPKJFNBLBF(IMKMJFJEHIJ NAKKFJMFOAE, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x37CE540", Offset = "0x37CD340", VA = "0x1837CE540")]
	public bool BDFMFLCCNJF(IMKMJFJEHIJ NAKKFJMFOAE, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37D0180", Offset = "0x37CEF80", VA = "0x1837D0180", Slot = "9")]
	public bool HKAKAEDOFMA(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x36D09F0", Offset = "0x36CF7F0", VA = "0x1836D09F0", Slot = "26")]
	public object CGCJIPFENIG(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37CE180", Offset = "0x37CCF80", VA = "0x1837CE180")]
	public bool BCCIDAIILGF(IMKMJFJEHIJ NAKKFJMFOAE, in object BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37CED80", Offset = "0x37CDB80", VA = "0x1837CED80")]
	public void BPAEGFNIDAI(IMKMJFJEHIJ NAKKFJMFOAE, in IADENELHJPC NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x36D78F0", Offset = "0x36D66F0", VA = "0x1836D78F0")]
	public bool NIPKJFNBLBF(IMKMJFJEHIJ NAKKFJMFOAE, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x36CCF50", Offset = "0x36CBD50", VA = "0x1836CCF50")]
	public bool BDFMFLCCNJF(IMKMJFJEHIJ NAKKFJMFOAE, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x36A8E00", Offset = "0x36A7C00", VA = "0x1836A8E00", Slot = "22")]
	public void ABOJAHHKNKA(LMJKNNOOLMK LHNPCANBMJO, [Optional] object KPEPJOHCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37CDDF0", Offset = "0x37CCBF0", VA = "0x1837CDDF0", Slot = "15")]
	public void ABOJAHHKNKA(IMKMJFJEHIJ ANFHHLAHMJD, OAGIJOPMPLM LHNPCANBMJO, object KPEPJOHCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x36D3FC0", Offset = "0x36D2DC0", VA = "0x1836D3FC0", Slot = "14")]
	public bool DMNJIELPLLP(IMKMJFJEHIJ ACLNLJOHHEH, IMKMJFJEHIJ ALDENJHFODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x37CFF50", Offset = "0x37CED50", VA = "0x1837CFF50")]
	private void GGCHGCCMHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x37D0A40", Offset = "0x37CF840", VA = "0x1837D0A40")]
	private void OEEKJCNMLCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x37CF490", Offset = "0x37CE290", VA = "0x1837CF490")]
	private void DAHGNKMNKAF(Entity JCNIDEIPPBD, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x37CFBC0", Offset = "0x37CE9C0", VA = "0x1837CFBC0")]
	private void GAPDIDKIKJJ(Entity JCNIDEIPPBD, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x36D4880", Offset = "0x36D3680", VA = "0x1836D4880", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x37D0E80", Offset = "0x37CFC80", VA = "0x1837D0E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x37D0550", Offset = "0x37CF350", VA = "0x1837D0550")]
	public string KBFCGINLFPD(in KNIHKHKCMFB FEKFEMKDLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x36D6BF0", Offset = "0x36D59F0", VA = "0x1836D6BF0", Slot = "5")]
	private bool MKKBIHOMJFE(IMKMJFJEHIJ ANFHHLAHMJD, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x36DA5B0", Offset = "0x36D93B0", VA = "0x1836DA5B0", Slot = "6")]
	private bool OPLNHBIHEDB(IMKMJFJEHIJ ANFHHLAHMJD, in T BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2C34DF0", Offset = "0x2C33BF0", VA = "0x182C34DF0", Slot = "10")]
	private bool JGJOGFFJDLP(IMKMJFJEHIJ ANFHHLAHMJD, in object BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x36D76B0", Offset = "0x36D64B0", VA = "0x1836D76B0", Slot = "11")]
	private void JJDMPJNGLJJ(IMKMJFJEHIJ ANFHHLAHMJD, in IADENELHJPC NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x36CB9E0", Offset = "0x36CA7E0", VA = "0x1836CB9E0", Slot = "12")]
	private bool ACGAKLIEBPK(IMKMJFJEHIJ ANFHHLAHMJD, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x36D78B0", Offset = "0x36D66B0", VA = "0x1836D78B0", Slot = "13")]
	private bool KFEDGEFAOKD(IMKMJFJEHIJ ANFHHLAHMJD, in KNIHKHKCMFB BHOEDLDNCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC210", Offset = "0x2FDB010", VA = "0x182FDC210", Slot = "16")]
	private string GGFAKBLLHBC(in KNIHKHKCMFB NLHFEJHKLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NMIDBELFOCE : IDisposable, DEKIJBAJIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FBIDPFBEOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public NMIDBELFOCE(NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2F06AA0", Offset = "0x2F058A0", VA = "0x182F06AA0", Slot = "6")]
	public IMKMJFJEHIJ OMIIJOHNBCN(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2F06A90", Offset = "0x2F05890", VA = "0x182F06A90", Slot = "7")]
	public Entity OMIIJOHNBCN(Entity JCNIDEIPPBD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2F069F0", Offset = "0x2F057F0", VA = "0x182F069F0", Slot = "8")]
	public IEnumerable<IMKMJFJEHIJ> OMIIJOHNBCN(IEnumerable<IMKMJFJEHIJ> BECONHIACLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2F06990", Offset = "0x2F05790", VA = "0x182F06990", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly JFPIEAPAMJM GEGBABBBCEI;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int AKKJIFMHCGJ;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static DEKIJBAJIKE HICKLGICLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool HMLBGELOFJL;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> FBIDPFBEOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x327E360", Offset = "0x327D160", VA = "0x18327E360")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool LELALLAJPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x327E4D0", Offset = "0x327D2D0", VA = "0x18327E4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x327E470", Offset = "0x327D270", VA = "0x18327E470")]
		public static SerializationRemapScope KOHHLOCCKEH()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x327E880", Offset = "0x327D680", VA = "0x18327E880")]
		public SerializationRemapScope(DEKIJBAJIKE LMLKMFOBFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x327E250", Offset = "0x327D050", VA = "0x18327E250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x327E690", Offset = "0x327D490", VA = "0x18327E690")]
		public static IMKMJFJEHIJ OMIIJOHNBCN(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x327E560", Offset = "0x327D360", VA = "0x18327E560")]
		public static Entity OMIIJOHNBCN(Entity JCNIDEIPPBD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
[IHOFDNBJLIN(typeof(NIEGKKHMPPB), new string[] { "Editor" })]
public sealed class NIEGKKHMPPB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void MCGOLKFEIMJ(BDCMCEOAOGF IMLGNKIMLEB, NKCOMLBHOPC PHAPMEHMHAK, bool NPNAOPNCCBD);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void PBCKCBECLDE(BDCMCEOAOGF IMLGNKIMLEB, bool NPNAOPNCCBD);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void GAIIOHNPAPI(BDCMCEOAOGF IMLGNKIMLEB, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB NLHFEJHKLAH, bool NPNAOPNCCBD);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event MCGOLKFEIMJ LIHMMEBKPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2F06600", Offset = "0x2F05400", VA = "0x182F06600")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2F068F0", Offset = "0x2F056F0", VA = "0x182F068F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event PBCKCBECLDE JNDIGCMDLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2F066A0", Offset = "0x2F054A0", VA = "0x182F066A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2F06850", Offset = "0x2F05650", VA = "0x182F06850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event GAIIOHNPAPI NHMJNGKKJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2F06560", Offset = "0x2F05360", VA = "0x182F06560")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2F06740", Offset = "0x2F05540", VA = "0x182F06740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2F06810", Offset = "0x2F05610", VA = "0x182F06810")]
	[Conditional("UNITY_EDITOR")]
	public void MPICHOIJBCK(BDCMCEOAOGF IMLGNKIMLEB, in NKCOMLBHOPC PHAPMEHMHAK, bool NPNAOPNCCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2F06830", Offset = "0x2F05630", VA = "0x182F06830")]
	[Conditional("UNITY_EDITOR")]
	public void NNHPHFFCDJN(BDCMCEOAOGF IMLGNKIMLEB, bool NPNAOPNCCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2F067E0", Offset = "0x2F055E0", VA = "0x182F067E0")]
	[Conditional("UNITY_EDITOR")]
	public void LJDDLOEGJHN(BDCMCEOAOGF IMLGNKIMLEB, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB NLHFEJHKLAH, bool NPNAOPNCCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NIEGKKHMPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[IHOFDNBJLIN(typeof(JODABNJDPMN), new string[] { "Editor" })]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
public sealed class JODABNJDPMN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void JCHIPMKNBCA(BDCMCEOAOGF CONHLPJBCJE, NKCOMLBHOPC PHAPMEHMHAK, bool NPNAOPNCCBD);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void BDBPLIMMGAL(BDCMCEOAOGF CONHLPJBCJE, bool NPNAOPNCCBD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void NFEOMPODECH(BDCMCEOAOGF CONHLPJBCJE, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB NLHFEJHKLAH, bool NPNAOPNCCBD, bool NLNCEDLGPPG);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void EJLCBEKHGOF(BDCMCEOAOGF CONHLPJBCJE, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void CIOPIOCGAFI(AJALNLHPDCN ANFHHLAHMJD, ReadOnlyMemory<byte> GFDIIEHKLPK);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> NDKPBHOKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBB20", Offset = "0x2FCA920", VA = "0x182FCBB20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB740", Offset = "0x2FCA540", VA = "0x182FCB740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> AKOFHCCPHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC0A0", Offset = "0x2FCAEA0", VA = "0x182FCC0A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBF40", Offset = "0x2FCAD40", VA = "0x182FCBF40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event JCHIPMKNBCA LIHMMEBKPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBA80", Offset = "0x2FCA880", VA = "0x182FCBA80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC4B0", Offset = "0x2FCB2B0", VA = "0x182FCC4B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event BDBPLIMMGAL JNDIGCMDLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBBE0", Offset = "0x2FCA9E0", VA = "0x182FCBBE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC190", Offset = "0x2FCAF90", VA = "0x182FCC190")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event JCHIPMKNBCA KMMJPHNJBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBD50", Offset = "0x2FCAB50", VA = "0x182FCBD50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB8A0", Offset = "0x2FCA6A0", VA = "0x182FCB8A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event BDBPLIMMGAL IJJGINFLAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB940", Offset = "0x2FCA740", VA = "0x182FCB940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC230", Offset = "0x2FCB030", VA = "0x182FCC230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event NFEOMPODECH NHMJNGKKJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB800", Offset = "0x2FCA600", VA = "0x182FCB800")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBC80", Offset = "0x2FCAA80", VA = "0x182FCBC80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event EJLCBEKHGOF JKEFKEIENOH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC410", Offset = "0x2FCB210", VA = "0x182FCC410")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC000", Offset = "0x2FCAE00", VA = "0x182FCC000")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> LJAJJBLHMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB9E0", Offset = "0x2FCA7E0", VA = "0x182FCB9E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBDF0", Offset = "0x2FCABF0", VA = "0x182FCBDF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event CIOPIOCGAFI EHLNKCONHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2FCC2D0", Offset = "0x2FCB0D0", VA = "0x182FCC2D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB610", Offset = "0x2FCA410", VA = "0x182FCB610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2FCBD20", Offset = "0x2FCAB20", VA = "0x182FCBD20")]
	[Conditional("UNITY_EDITOR")]
	public void IGNKEFCOANA(BDCMCEOAOGF CONHLPJBCJE, in NKCOMLBHOPC PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2FCBE90", Offset = "0x2FCAC90", VA = "0x182FCBE90")]
	[Conditional("UNITY_EDITOR")]
	public void JMGJMPPAMNG(BDCMCEOAOGF CONHLPJBCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC160", Offset = "0x2FCAF60", VA = "0x182FCC160")]
	[Conditional("UNITY_EDITOR")]
	public void NJIHKIKOFHF(BDCMCEOAOGF CONHLPJBCJE, in NKCOMLBHOPC PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB5F0", Offset = "0x2FCA3F0", VA = "0x182FCB5F0")]
	[Conditional("UNITY_EDITOR")]
	public void AADDMLHAHAD(BDCMCEOAOGF CONHLPJBCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC370", Offset = "0x2FCB170", VA = "0x182FCC370")]
	[Conditional("UNITY_EDITOR")]
	public void PFANLMPIDOG(BDCMCEOAOGF CONHLPJBCJE, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB NLHFEJHKLAH, bool NLNCEDLGPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB6B0", Offset = "0x2FCA4B0", VA = "0x182FCB6B0")]
	[Conditional("UNITY_EDITOR")]
	public void AINFMBNGMJG(BDCMCEOAOGF CONHLPJBCJE, OJNODEDDEDC PEJFAKHLGCN, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2FCBEE0", Offset = "0x2FCACE0", VA = "0x182FCBEE0")]
	[Conditional("UNITY_EDITOR")]
	public void LAAFFJKNALD(string EOPECGOILOC, object GFDIIEHKLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCBEB0", Offset = "0x2FCACB0", VA = "0x182FCBEB0")]
	[Conditional("UNITY_EDITOR")]
	public void KCLAIKKMHHP(AJALNLHPDCN ANFHHLAHMJD, ReadOnlyMemory<byte> GFDIIEHKLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC3A0", Offset = "0x2FCB1A0", VA = "0x182FCC3A0")]
	[Conditional("UNITY_EDITOR")]
	public void PHLBDJOJNDP(World PGJEGNBAENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB6D0", Offset = "0x2FCA4D0", VA = "0x182FCB6D0")]
	[Conditional("UNITY_EDITOR")]
	public void ANAEHJNODPC(World PGJEGNBAENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JODABNJDPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IHOFDNBJLIN(typeof(FHCCLCMHLIE), new string[] { })]
public class FLFDKDPCOCF : FHCCLCMHLIE
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9B40", Offset = "0x2FB8940", VA = "0x182FB9B40", Slot = "5")]
	public void IOOPGNNOBMN(object GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9960", Offset = "0x2FB8760", VA = "0x182FB9960", Slot = "6")]
	public void EDDMNNONKJB(object GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9A50", Offset = "0x2FB8850", VA = "0x182FB9A50", Slot = "7")]
	public void HPPMMBFFJMF(object GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9C30", Offset = "0x2FB8A30", VA = "0x182FB9C30", Slot = "4")]
	public IDisposable JBKCKAPGIKA(object GNDOGDAIOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FLFDKDPCOCF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	[IHOFDNBJLIN(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	internal class BulkInstantiateSceneObjectService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string ODADOPMABAP = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[CEFONNIACOK]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[CEFONNIACOK]
		private OKNLNFBIJGH AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery IGPLKKIDFJP;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x34F9EE0", Offset = "0x34F8CE0", VA = "0x1834F9EE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34FB4D0", Offset = "0x34FA2D0", VA = "0x1834FB4D0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x34F9ED0", Offset = "0x34F8CD0", VA = "0x1834F9ED0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x34FA880", Offset = "0x34F9680", VA = "0x1834FA880")]
		public bool KJJPEDFDMJF(IEnumerable<CEJNCBODCBD> HDDGHAIKGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x34F9DC0", Offset = "0x34F8BC0", VA = "0x1834F9DC0")]
		public static bool DIHKNODLAGE(CEJNCBODCBD MGDDHKPDDMF, out BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x34F9F30", Offset = "0x34F8D30", VA = "0x1834F9F30")]
		private void GLAIIFODDJI(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM, IEnumerable<CEJNCBODCBD> HDDGHAIKGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x34FB2A0", Offset = "0x34FA0A0", VA = "0x1834FB2A0")]
		private void MNCAPDOJLNF(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x34F9710", Offset = "0x34F8510", VA = "0x1834F9710")]
		private void BDLALHHPJAD(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM, BDCMCEOAOGF CONHLPJBCJE, string EOPECGOILOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x34FA350", Offset = "0x34F9150", VA = "0x1834FA350")]
		private void HJBOCOEDKPO(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x34FAA00", Offset = "0x34F9800", VA = "0x1834FAA00")]
		private void MFPDGOKOOGN(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM, List<CEJNCBODCBD> HPIKHLNMPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x34F9BF0", Offset = "0x34F89F0", VA = "0x1834F9BF0")]
		private NativeList<BDCMCEOAOGF> CKIENGEDCCA(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM)
		{
			return default(NativeList<BDCMCEOAOGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x34FA6B0", Offset = "0x34F94B0", VA = "0x1834FA6B0")]
		private NativeArray<Entity> IPCMEDIOHAI(NativeList<BDCMCEOAOGF> FHGCCHGBNCL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x34FA2B0", Offset = "0x34F90B0", VA = "0x1834FA2B0")]
		private static void HEGDAMMBFOO(Dictionary<BDCMCEOAOGF, CEJNCBODCBD> IEPEFMMEENM, BDCMCEOAOGF CONHLPJBCJE, CEJNCBODCBD MGDDHKPDDMF, string EOPECGOILOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[KBDLNAGCCOG(DADIFNCKKPF.Application)]
	[IHOFDNBJLIN(typeof(DebugWorldsService), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool OHGLCGABLDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x350CED0", Offset = "0x350BCD0", VA = "0x18350CED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x350CF10", Offset = "0x350BD10", VA = "0x18350CF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool IIPNLIGHOMN
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x350CF50", Offset = "0x350BD50", VA = "0x18350CF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x350CF90", Offset = "0x350BD90", VA = "0x18350CF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public void GIJCHAFNBFJ(string EOPECGOILOC, EntityManager OFPCNLPKKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public static void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[IHOFDNBJLIN(typeof(FKJLGPBPIDL), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
internal class FKJLGPBPIDL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool OHGLCGABLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7923A0", Offset = "0x7911A0", VA = "0x1807923A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DJJLCOCOLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x792390", Offset = "0x791190", VA = "0x180792390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7923B0", Offset = "0x7911B0", VA = "0x1807923B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FKJLGPBPIDL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[IHOFDNBJLIN(typeof(LPDKJACLMMI), new string[] { })]
	[BEHFJGBFKGL(typeof(SerializationService))]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	internal class SerializationService : LPDKJACLMMI, IDisposable, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly JFPIEAPAMJM ALNODAEDDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[CEFONNIACOK]
		private DHLEDJLMPCL MIABCNNFJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[CEFONNIACOK]
		private FKJLGPBPIDL MHJJJMOMFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BJGLINLPDPK CLFJBPHOFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private FPACKJBANFG BPDIMANFJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope MJNBAGFEJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? FOMNKCKJIOO;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool MCGOLFOKPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3280070", Offset = "0x327EE70", VA = "0x183280070", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x327FDF0", Offset = "0x327EBF0", VA = "0x18327FDF0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool NFJALLCHGON
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x925EB0", Offset = "0x924CB0", VA = "0x180925EB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x926640", Offset = "0x925440", VA = "0x180926640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FPACKJBANFG KMFBHJCCJKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3280630", Offset = "0x327F430", VA = "0x183280630", Slot = "16")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x327F780", Offset = "0x327E580", VA = "0x18327F780", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x327F3C0", Offset = "0x327E1C0", VA = "0x18327F3C0")]
		public static bool CLCKABPAAHG(ByteString HDHLDBBIAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		public void MJAIAGJDALG(BJGLINLPDPK PLFNKOGOLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x327EE40", Offset = "0x327DC40", VA = "0x18327EE40", Slot = "5")]
		public void BDKKBIGILPH(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32806D0", Offset = "0x327F4D0", VA = "0x1832806D0", Slot = "6")]
		public Task PLAPINBICDP(bool INLFOKCKKHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x327EB80", Offset = "0x327D980", VA = "0x18327EB80", Slot = "7")]
		public ByteString APDPBGNCGIO(out IDisposable MJNBAGFEJDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x327EC60", Offset = "0x327DA60", VA = "0x18327EC60", Slot = "19")]
		public ByteString APDPBGNCGIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x327F720", Offset = "0x327E520", VA = "0x18327F720", Slot = "9")]
		public bool DHABJCANOEO(ByteString HGLLGIEKCON, OEIPICBBOEI FELMKIDGPKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x327F0A0", Offset = "0x327DEA0", VA = "0x18327F0A0")]
		private bool BICPBCCMAJD(ByteString HGLLGIEKCON, OEIPICBBOEI FELMKIDGPKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x327F990", Offset = "0x327E790", VA = "0x18327F990", Slot = "8")]
		public void JCFCKBODFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x327E910", Offset = "0x327D710", VA = "0x18327E910", Slot = "10")]
		public bool AMKOLHJMLPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x327FE00", Offset = "0x327EC00", VA = "0x18327FE00", Slot = "11")]
		public bool KJJPEDFDMJF(IEnumerable<CEJNCBODCBD> HLMMLGBNPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x327EF10", Offset = "0x327DD10", VA = "0x18327EF10")]
		public bool BEHCKMJBBCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x327F4F0", Offset = "0x327E2F0", VA = "0x18327F4F0", Slot = "12")]
		public bool CMDOKGNAEJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32802A0", Offset = "0x327F0A0", VA = "0x1832802A0")]
		public void MNIAEKFCBMM(FPACKJBANFG.HAABJNPFPGA.OAFOIKHKFFO MDANIEOCOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x327FB60", Offset = "0x327E960", VA = "0x18327FB60")]
		private bool JHIGGCGHKEK(ByteString HGLLGIEKCON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3280080", Offset = "0x327EE80", VA = "0x183280080")]
		private void LKEHEKOKKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x32805D0", Offset = "0x327F3D0", VA = "0x1832805D0")]
		private ByteString PDGLGHNFFBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3280760", Offset = "0x327F560", VA = "0x183280760")]
		private ByteString PPOPHLPBCFH(ByteString HDHLDBBIAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3280530", Offset = "0x327F330", VA = "0x183280530")]
		private FPACKJBANFG.HAABJNPFPGA.OAFOIKHKFFO OMJJBJKJOAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x327F960", Offset = "0x327E760", VA = "0x18327F960")]
		private void IEEHFNFJNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x32800D0", Offset = "0x327EED0", VA = "0x1832800D0", Slot = "13")]
		public bool MICHBNPALAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x327EFF0", Offset = "0x327DDF0", VA = "0x18327EFF0", Slot = "14")]
		public void BHLFCOMJKGA(bool LEDCGOCCGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x327F790", Offset = "0x327E590", VA = "0x18327F790")]
		private void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IHOFDNBJLIN(typeof(OHOMOGIIAEB), new string[] { })]
[BEHFJGBFKGL(typeof(DHLEDJLMPCL))]
internal class DHLEDJLMPCL : OHOMOGIIAEB
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action KHEHIHNKCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x350AF80", Offset = "0x3509D80", VA = "0x18350AF80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x350A940", Offset = "0x3509740", VA = "0x18350A940", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<DEKIJBAJIKE> PHMFNFGLMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x350AE40", Offset = "0x3509C40", VA = "0x18350AE40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x350ABC0", Offset = "0x35099C0", VA = "0x18350ABC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action MNGGHMENCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x350A9E0", Offset = "0x35097E0", VA = "0x18350A9E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x350AEE0", Offset = "0x3509CE0", VA = "0x18350AEE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action INDNNHEPFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x350AA80", Offset = "0x3509880", VA = "0x18350AA80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x350AC60", Offset = "0x3509A60", VA = "0x18350AC60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<DEKIJBAJIKE> KEKCFEACECL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x350ADA0", Offset = "0x3509BA0", VA = "0x18350ADA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x350AB20", Offset = "0x3509920", VA = "0x18350AB20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1272B50", Offset = "0x1271950", VA = "0x181272B50")]
	public void JCFCKBODFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1502630", Offset = "0x1501430", VA = "0x181502630")]
	public void MIALCINFPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x14C4F30", Offset = "0x14C3D30", VA = "0x1814C4F30")]
	public void OBKJBKGHDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x350AD50", Offset = "0x3509B50", VA = "0x18350AD50")]
	public void HDICNKFBKHG(DEKIJBAJIKE HICKLGICLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x350AD00", Offset = "0x3509B00", VA = "0x18350AD00")]
	public void GIJCPKCHJPA(DEKIJBAJIKE HICKLGICLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DHLEDJLMPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[IHOFDNBJLIN(typeof(HBOFDJIDNOO), new string[] { })]
public class JKGBOFDFJEM : HBOFDJIDNOO, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents DMDBPDDAOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private DOAPHHBMBCB KKGLMHJCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService BNOABMBMCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::EEMMAJNELDH<IMKMJFJEHIJ> KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3E0", Offset = "0x6F91E0", VA = "0x1806FA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA090", Offset = "0x2FC8E90", VA = "0x182FCA090")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D4890", Offset = "0x7D3690", VA = "0x1807D4890", Slot = "14")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FCADA0", Offset = "0x2FC9BA0", VA = "0x182FCADA0", Slot = "15")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA3B0", Offset = "0x2FC91B0", VA = "0x182FCA3B0", Slot = "16")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x15023B0", Offset = "0x15011B0", VA = "0x1815023B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DBA0", Offset = "0x2F0C9A0", VA = "0x182F0DBA0")]
	private IMKMJFJEHIJ PPLPBHGMJOC(Entity JCNIDEIPPBD)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA6C0", Offset = "0x2FC94C0", VA = "0x182FCA6C0", Slot = "4")]
	public IMKMJFJEHIJ KKMEGKLDKFD(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA4A0", Offset = "0x2FC92A0", VA = "0x182FCA4A0", Slot = "19")]
	public void KJBBIGONIBL(ref List<IMKMJFJEHIJ> CECFOEGDIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9D00", Offset = "0x2FC8B00", VA = "0x182FC9D00", Slot = "20")]
	public IEnumerable<IMKMJFJEHIJ> BDMPNKHFGBN(IMKMJFJEHIJ NAKKFJMFOAE, bool KLLDICHECHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA110", Offset = "0x2FC8F10", VA = "0x182FCA110", Slot = "21")]
	public IMKMJFJEHIJ GIJAHIEFAEE(IMKMJFJEHIJ NAKKFJMFOAE, int CPOAAGLEIPE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA9C0", Offset = "0x2FC97C0", VA = "0x182FCA9C0", Slot = "22")]
	public int MEOHJPAAIHH(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA820", Offset = "0x2FC9620", VA = "0x182FCA820", Slot = "8")]
	public int LJKMOLNNOHK(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FCAAE0", Offset = "0x2FC98E0", VA = "0x182FCAAE0", Slot = "9")]
	public OMPPKAOKMDG NLNLCLKDHPE(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(OMPPKAOKMDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FCABD0", Offset = "0x2FC99D0", VA = "0x182FCABD0", Slot = "23")]
	public bool OCEFHAOBIAK(IMKMJFJEHIJ NAKKFJMFOAE, out OMPPKAOKMDG MCDDMOKEEEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA2E0", Offset = "0x2FC90E0", VA = "0x182FCA2E0", Slot = "24")]
	public IEnumerable<IMKMJFJEHIJ> JCHDAOHELMN(IMKMJFJEHIJ NAKKFJMFOAE, bool KLLDICHECHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9F20", Offset = "0x2FC8D20", VA = "0x182FC9F20", Slot = "12")]
	public IMKMJFJEHIJ EJCADAELLDF(IMKMJFJEHIJ ABKMOKFEPEA, IMKMJFJEHIJ PCFJLKDJIEJ)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA750", Offset = "0x2FC9550", VA = "0x182FCA750", Slot = "13")]
	public bool LDLIMOIODDC(IMKMJFJEHIJ ABKMOKFEPEA, IMKMJFJEHIJ PCFJLKDJIEJ, out IMKMJFJEHIJ NENMNHLIAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9FF0", Offset = "0x2FC8DF0", VA = "0x182FC9FF0", Slot = "5")]
	public IMKMJFJEHIJ FANBPIBOJLO(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA0E0", Offset = "0x2FC8EE0", VA = "0x182FCA0E0", Slot = "11")]
	public bool FMNODEAAPBM(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ FPEOKJIPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA720", Offset = "0x2FC9520", VA = "0x182FCA720", Slot = "25")]
	public bool KMJPAMBDEGI(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ CPAHKPHLOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9E80", Offset = "0x2FC8C80", VA = "0x182FC9E80", Slot = "10")]
	public bool DPFODLBBOCH(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ ABKMOKFEPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9DD0", Offset = "0x2FC8BD0", VA = "0x182FC9DD0", Slot = "6")]
	public bool CNEDMMKBPIO(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ AABHIBJPKOH, bool HBGMGPFBFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9EB0", Offset = "0x2FC8CB0", VA = "0x182FC9EB0", Slot = "7")]
	public bool EBAMJBKGNPF(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ AABHIBJPKOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JKGBOFDFJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(BIOAEAGLHAC), new string[] { })]
internal class BIOAEAGLHAC : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[CEFONNIACOK]
	private FKJKMJONNAG KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, CBIMKPJBECO> GEDJCMKMJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x34F9110", Offset = "0x34F7F10", VA = "0x1834F9110", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x34F89E0", Offset = "0x34F77E0", VA = "0x1834F89E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x34F8DF0", Offset = "0x34F7BF0", VA = "0x1834F8DF0")]
	public CBIMKPJBECO JGLLAIGDIPJ(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x34F8EF0", Offset = "0x34F7CF0", VA = "0x1834F8EF0")]
	public CBIMKPJBECO JGLLAIGDIPJ(OJNODEDDEDC OINBNOFPHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x34F8C60", Offset = "0x34F7A60", VA = "0x1834F8C60")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x34F9160", Offset = "0x34F7F60", VA = "0x1834F9160")]
	public BIOAEAGLHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CBIMKPJBECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<GFMDAEHFIFG> OIFNJIHDKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<MPFLPHHMMLG> KLCIMAEDBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<FIIDJEFPAIP> NILNDNCMLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<MPFLPHHMMLG> MBIGPIGNPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<GFMDAEHFIFG> LKHOALBPEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90")]
		get
		{
			return default(NativeList<GFMDAEHFIFG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<MPFLPHHMMLG> GMDBDIOGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x787590", Offset = "0x786390", VA = "0x180787590")]
		get
		{
			return default(NativeList<MPFLPHHMMLG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<FIIDJEFPAIP> ACDBEHFNMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F2B80", Offset = "0x9F1980", VA = "0x1809F2B80")]
		get
		{
			return default(NativeList<FIIDJEFPAIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<MPFLPHHMMLG> FBHAFAIEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7E0300", Offset = "0x7DF100", VA = "0x1807E0300")]
		get
		{
			return default(NativeList<MPFLPHHMMLG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle BCDFBJNPPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x787460", Offset = "0x786260", VA = "0x180787460")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15A5720", Offset = "0x15A4520", VA = "0x1815A5720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NOIGHNNNJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7716B0", Offset = "0x7704B0", VA = "0x1807716B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool NNBGDDNCINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x34FBF40", Offset = "0x34FAD40", VA = "0x1834FBF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x34FBFF0", Offset = "0x34FADF0", VA = "0x1834FBFF0")]
	public CBIMKPJBECO(Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x34FBD80", Offset = "0x34FAB80", VA = "0x1834FBD80")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x34FBE10", Offset = "0x34FAC10", VA = "0x1834FBE10")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x34FBA50", Offset = "0x34FA850", VA = "0x1834FBA50")]
	public void AHKNMMEAEHA(Entity JCNIDEIPPBD, Entity NPPHDNLMMMJ, Entity BANCJNAJPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[IHOFDNBJLIN(typeof(OOOCCFLPCBC), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
public class OOOCCFLPCBC : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[CEFONNIACOK]
	private SceneService JKMDIALCHLK;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A0D0", Offset = "0x2F08ED0", VA = "0x182F0A0D0", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A0B0", Offset = "0x2F08EB0", VA = "0x182F0A0B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public OOOCCFLPCBC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[IHOFDNBJLIN(typeof(PhotonInstanceCleanupService), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Lifecycle)]
	[KBDLNAGCCOG(DADIFNCKKPF.PhotonRoom)]
	public class PhotonInstanceCleanupService : OMEPFIBEFCP, FEBFHBLLFPI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private DLGFIBKMHIF AIKJACDDALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NCEPMNGGADP LBJPFNIJFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> LBDJPOEPJKD;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2F19050", Offset = "0x2F17E50", VA = "0x182F19050", Slot = "5")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2F19490", Offset = "0x2F18290", VA = "0x182F19490", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2F193B0", Offset = "0x2F181B0", VA = "0x182F193B0")]
		public void KGGCGLDLAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2F190B0", Offset = "0x2F17EB0", VA = "0x182F190B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2F191A0", Offset = "0x2F17FA0", VA = "0x182F191A0")]
		public void JBJHBCMJPCF(global::CGFMCBPNJIE<int> CLBELNCNPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2F19450", Offset = "0x2F18250", VA = "0x182F19450")]
		public void ONMBFACILIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class MEFPLJGJIHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint IEGNLEOLMOJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint GHFMAMNDFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xD773E0", Offset = "0xD761E0", VA = "0x180D773E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2F02250", Offset = "0x2F01050", VA = "0x182F02250")]
	public BDCMCEOAOGF IFFLAKBDKBE()
	{
		return default(BDCMCEOAOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F021A0", Offset = "0x2F00FA0", VA = "0x182F021A0")]
	public void CLEKLENIGGC(BDCMCEOAOGF CONHLPJBCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x17B9510", Offset = "0x17B8310", VA = "0x1817B9510", Slot = "6")]
	public virtual void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected MEFPLJGJIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(FDEPNHHLDLD), new string[] { })]
internal sealed class FDEPNHHLDLD : MEFPLJGJIHM, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[CEFONNIACOK]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint NMNAALMKBCK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint GHFMAMNDFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8BB0", Offset = "0x2FB79B0", VA = "0x182FB8BB0", Slot = "7")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8B60", Offset = "0x2FB7960", VA = "0x182FB8B60")]
	private void PBAKCPKHKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8B00", Offset = "0x2FB7900", VA = "0x182FB8B00", Slot = "6")]
	public override void CELKGMNMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
	public FDEPNHHLDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IHOFDNBJLIN(typeof(ALIEOEHNBBG), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
internal sealed class ALIEOEHNBBG : MEFPLJGJIHM
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint GHFMAMNDFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
	public ALIEOEHNBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(IEFBGJOIBOH), new string[] { })]
internal sealed class IEFBGJOIBOH : MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[CEFONNIACOK]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery HKMEDOFAKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery LALCHMOLPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery DLBIHEPPKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery LLFOGOJGBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery ADADBHIFOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery IECPFOCPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3E80", Offset = "0x2FC2C80", VA = "0x182FC3E80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery BLIJHJLKBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery FBCOBAGDCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x746150", Offset = "0x744F50", VA = "0x180746150")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery GAOGDOOHDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x704D90", Offset = "0x703B90", VA = "0x180704D90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery CIBBOCPENAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x787460", Offset = "0x786260", VA = "0x180787460")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery BLEPFFOEHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x787550", Offset = "0x786350", VA = "0x180787550")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery BDCDFGCEPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3E00", Offset = "0x2FC2C00", VA = "0x182FC3E00")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int PKDJMFGNNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3F10", Offset = "0x2FC2D10", VA = "0x182FC3F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int KCLKMFOHLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3D80", Offset = "0x2FC2B80", VA = "0x182FC3D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int EAILJEJLPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3ED0", Offset = "0x2FC2CD0", VA = "0x182FC3ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int DDHFFOGCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3B30", Offset = "0x2FC2930", VA = "0x182FC3B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int HHILPCAMHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3EF0", Offset = "0x2FC2CF0", VA = "0x182FC3EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int MEDOAJJMPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3B50", Offset = "0x2FC2950", VA = "0x182FC3B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4430", Offset = "0x2FC3230", VA = "0x182FC4430", Slot = "5")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3F90", Offset = "0x2FC2D90", VA = "0x182FC3F90", Slot = "6")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3F30", Offset = "0x2FC2D30", VA = "0x182FC3F30")]
	private EntityQueryDesc KEJKNOJDNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3DA0", Offset = "0x2FC2BA0", VA = "0x182FC3DA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3B70", Offset = "0x2FC2970", VA = "0x182FC3B70")]
	public KHOBILPJMOD CBAPKKMLAOE(IMKMJFJEHIJ LNCGECBHMHD)
	{
		return default(KHOBILPJMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3C20", Offset = "0x2FC2A20", VA = "0x182FC3C20")]
	public KHOBILPJMOD CBAPKKMLAOE(Entity JCNIDEIPPBD)
	{
		return default(KHOBILPJMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3CD0", Offset = "0x2FC2AD0", VA = "0x182FC3CD0")]
	public FJNOGBCPDIO COMINONLBDJ(Entity JCNIDEIPPBD)
	{
		return default(FJNOGBCPDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4480", Offset = "0x2FC3280", VA = "0x182FC4480")]
	public IEFBGJOIBOH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[IDOCBBAEIFB(JHEANMHFGAO.All)]
	[IHOFDNBJLIN(typeof(LMLOCAEKAJL), new string[] { })]
	public class ObjectService : OMEPFIBEFCP, LMLOCAEKAJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly JFPIEAPAMJM BJHBFEKHEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[CEFONNIACOK]
		private NMDCIMKFCEN GINNLCCNCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[CEFONNIACOK]
		private ObjectLifecycleService OLBEJFPALDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[CEFONNIACOK]
		private ObjectEmbodimentService BNOABMBMCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[CEFONNIACOK]
		private ObjectInstantiationService EDGDLJOHDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[CEFONNIACOK]
		private IEFBGJOIBOH KKGLMHJCDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService GCEPJPIBHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public NMDCIMKFCEN EOOBNKAGIEH
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int PKDJMFGNNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2F14F00", Offset = "0x2F13D00", VA = "0x182F14F00", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int KCLKMFOHLMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2F14380", Offset = "0x2F13180", VA = "0x182F14380", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int EAILJEJLPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2F14AE0", Offset = "0x2F138E0", VA = "0x182F14AE0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int DDHFFOGCHCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2F13EA0", Offset = "0x2F12CA0", VA = "0x182F13EA0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int HHILPCAMHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2F14CD0", Offset = "0x2F13AD0", VA = "0x182F14CD0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int MEDOAJJMPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2F14060", Offset = "0x2F12E60", VA = "0x182F14060", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<IMKMJFJEHIJ, FJNOGBCPDIO> DONEGBAALDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2F146E0", Offset = "0x2F134E0", VA = "0x182F146E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2F13F20", Offset = "0x2F12D20", VA = "0x182F13F20", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<IMKMJFJEHIJ> NBEONMEFCOH
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2F13BE0", Offset = "0x2F129E0", VA = "0x182F13BE0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2F14F20", Offset = "0x2F13D20", VA = "0x182F14F20", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2F157C0", Offset = "0x2F145C0", VA = "0x182F157C0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2F14450", Offset = "0x2F13250", VA = "0x182F14450", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2F15570", Offset = "0x2F14370", VA = "0x182F15570")]
		private void OPJDOKBPJEA(Entity JCNIDEIPPBD, FJNOGBCPDIO CEBPAJMCGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2F150B0", Offset = "0x2F13EB0", VA = "0x182F150B0")]
		private void JEONFDCBMKM(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2F15A30", Offset = "0x2F14830", VA = "0x182F15A30")]
		internal IMKMJFJEHIJ PPLPBHGMJOC(Entity JCNIDEIPPBD)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2F14780", Offset = "0x2F13580", VA = "0x182F14780", Slot = "41")]
		public OMPPKAOKMDG FHDNDEDEEBD()
		{
			return default(OMPPKAOKMDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2F14FC0", Offset = "0x2F13DC0", VA = "0x182F14FC0", Slot = "42")]
		public OMPPKAOKMDG ILGEBNEDHFM()
		{
			return default(OMPPKAOKMDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2F14920", Offset = "0x2F13720", VA = "0x182F14920", Slot = "43")]
		public OMPPKAOKMDG FKFBLCFCBGH()
		{
			return default(OMPPKAOKMDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2F14100", Offset = "0x2F12F00", VA = "0x182F14100", Slot = "10")]
		public KHOBILPJMOD CBAPKKMLAOE(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(KHOBILPJMOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2F14280", Offset = "0x2F13080", VA = "0x182F14280", Slot = "11")]
		public FJNOGBCPDIO COMINONLBDJ(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(FJNOGBCPDIO);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2F143A0", Offset = "0x2F131A0", VA = "0x182F143A0")]
		private OMPPKAOKMDG DNPHNNIAFJM(EntityQuery KFFFLMFFADE)
		{
			return default(OMPPKAOKMDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2F14E70", Offset = "0x2F13C70", VA = "0x182F14E70", Slot = "33")]
		public bool HKAKAEDOFMA(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2F145D0", Offset = "0x2F133D0", VA = "0x182F145D0", Slot = "29")]
		public void ECKNMJDFBGK(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2F14B00", Offset = "0x2F13900", VA = "0x182F14B00", Slot = "30")]
		public void FOPACEHLIHG(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2F142E0", Offset = "0x2F130E0", VA = "0x182F142E0", Slot = "31")]
		public void DJMNLJGHIEI(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2F14B60", Offset = "0x2F13960", VA = "0x182F14B60", Slot = "22")]
		public HGGBOIBCHBA GCKBCNOJALH(FJNOGBCPDIO CEBPAJMCGMI, bool FCOKMKIPNPC)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2F14C50", Offset = "0x2F13A50", VA = "0x182F14C50", Slot = "23")]
		public HGGBOIBCHBA GCKBCNOJALH(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2F15610", Offset = "0x2F14410", VA = "0x182F15610", Slot = "24")]
		public HGGBOIBCHBA PFACIDCOHNN(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2F15230", Offset = "0x2F14030", VA = "0x182F15230", Slot = "25")]
		public HGGBOIBCHBA KKPFEJHGOEM(BDCMCEOAOGF CONHLPJBCJE, FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2F15460", Offset = "0x2F14260", VA = "0x182F15460", Slot = "44")]
		public HGGBOIBCHBA LMMKKCJMDFJ(int JPFPMCNODPG, FJNOGBCPDIO CEBPAJMCGMI, GameObject AAMBGNNHMBI)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2F15190", Offset = "0x2F13F90", VA = "0x182F15190", Slot = "26")]
		public CBPNDIDMMGD KHLFPHLBOAJ()
		{
			return default(CBPNDIDMMGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2F14820", Offset = "0x2F13620", VA = "0x182F14820", Slot = "45")]
		public GFLJOONMADA FJAMIAFEIPO(BFOCONIHCAE MAIOHDHBGKE)
		{
			return default(GFLJOONMADA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2F14150", Offset = "0x2F12F50", VA = "0x182F14150", Slot = "27")]
		public AKAFLDCKNNF CNBKCLGBMEL()
		{
			return default(AKAFLDCKNNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2F156A0", Offset = "0x2F144A0", VA = "0x182F156A0", Slot = "28")]
		public CDCIJEANHCF PGNBFOLHCCA(IEAEMGCPMCM MAIOHDHBGKE)
		{
			return default(CDCIJEANHCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2F14130", Offset = "0x2F12F30", VA = "0x182F14130", Slot = "12")]
		public void CBFNCDGCFPB(BDCMCEOAOGF CONHLPJBCJE, ILANHKOILOA GKFKLPMILMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2F149C0", Offset = "0x2F137C0", VA = "0x182F149C0", Slot = "13")]
		public HGGBOIBCHBA FKKCMHIMFCG(IMKMJFJEHIJ NAKKFJMFOAE, [Optional] object INDCJAMMAIN)
		{
			return default(HGGBOIBCHBA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2F13FC0", Offset = "0x2F12DC0", VA = "0x182F13FC0", Slot = "14")]
		public bool BEEDIGPHJBK(IMKMJFJEHIJ NAKKFJMFOAE, out ILANHKOILOA DGEANHLCFIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2F15140", Offset = "0x2F13F40", VA = "0x182F15140", Slot = "46")]
		public Transform JLNLJGDDDCO(IMKMJFJEHIJ NAKKFJMFOAE, [Optional] object INDCJAMMAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2F14690", Offset = "0x2F13490", VA = "0x182F14690", Slot = "16")]
		public bool EPBDFGPFLJL(IMKMJFJEHIJ NAKKFJMFOAE, out Transform GPMKACFJLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2F14DE0", Offset = "0x2F13BE0", VA = "0x182F14DE0", Slot = "17")]
		public bool HDLCOKAKBGL(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2F13EC0", Offset = "0x2F12CC0", VA = "0x182F13EC0")]
		public bool AKLOGHCFNOH(ILANHKOILOA NLHFEJHKLAH, [Optional] object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2F13EF0", Offset = "0x2F12CF0", VA = "0x182F13EF0", Slot = "47")]
		public bool AKLOGHCFNOH(IMKMJFJEHIJ NAKKFJMFOAE, [Optional] object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2F142C0", Offset = "0x2F130C0", VA = "0x182F142C0", Slot = "48")]
		public void DHJDFLHNBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2F13CF0", Offset = "0x2F12AF0", VA = "0x182F13CF0", Slot = "15")]
		public void AJDKCPEAODO(ILANHKOILOA BLIKPCIFNNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2F14E30", Offset = "0x2F13C30", VA = "0x182F14E30", Slot = "49")]
		public void HJJFHLFMMMF(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2F14080", Offset = "0x2F12E80", VA = "0x182F14080", Slot = "18")]
		public bool BNAIPFKHFLN(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2F14200", Offset = "0x2F13000", VA = "0x182F14200", Slot = "19")]
		public bool COJBMENHFIP(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2F13C80", Offset = "0x2F12A80", VA = "0x182F13C80", Slot = "50")]
		public bool AHFOKADJNJA(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2F14620", Offset = "0x2F13420", VA = "0x182F14620", Slot = "51")]
		public bool EOKIBAAHBEM(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2F15400", Offset = "0x2F14200", VA = "0x182F15400", Slot = "32")]
		public NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)> LHCKMOLIBHC(NativeArray<IMKMJFJEHIJ> KELBJKLPPLD, Allocator HIEJKCFDMDD)
		{
			return default(NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2F154D0", Offset = "0x2F142D0", VA = "0x182F154D0", Slot = "21")]
		public BDCMCEOAOGF MBLCFJOHPHH(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(BDCMCEOAOGF);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2F14CF0", Offset = "0x2F13AF0", VA = "0x182F14CF0", Slot = "20")]
		public IMKMJFJEHIJ GGBDBGCDFJE(BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2F15070", Offset = "0x2F13E70", VA = "0x182F15070")]
		private void JACHLAPAPMF(FJNOGBCPDIO CEBPAJMCGMI, IMKMJFJEHIJ NAKKFJMFOAE, BDCMCEOAOGF CONHLPJBCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(LDDHDONLPKD), new string[] { })]
internal sealed class LDDHDONLPKD : OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService EDGDLJOHDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[CEFONNIACOK]
	private IEFBGJOIBOH KKGLMHJCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[CEFONNIACOK]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1730", Offset = "0x2FD0530", VA = "0x182FD1730", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2FD11A0", Offset = "0x2FCFFA0", VA = "0x182FD11A0")]
	public NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)> LHCKMOLIBHC(NativeArray<IMKMJFJEHIJ> KELBJKLPPLD, Allocator HIEJKCFDMDD)
	{
		return default(NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0C60", Offset = "0x2FCFA60", VA = "0x182FD0C60")]
	private void IBFAHHFCMHH(NativeMultiHashMap<int, (IMKMJFJEHIJ src, IMKMJFJEHIJ dst)> HAMHDKBOELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2FD12A0", Offset = "0x2FD00A0", VA = "0x182FD12A0")]
	private void OAGPEAMKAFI(NativeMultiHashMap<int, (IMKMJFJEHIJ src, IMKMJFJEHIJ dst)> HAMHDKBOELM, int CEBPAJMCGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0AD0", Offset = "0x2FCF8D0", VA = "0x182FD0AD0")]
	private void EOCPLEPJKAP(NativeMultiHashMap<int, (IMKMJFJEHIJ src, IMKMJFJEHIJ dst)> HAMHDKBOELM, int CEBPAJMCGMI, GGBNGHABEPC KELFDPANAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0E40", Offset = "0x2FCFC40", VA = "0x182FD0E40")]
	private NativeMultiHashMap<int, (IMKMJFJEHIJ, IMKMJFJEHIJ)> LFLHMGLKNIL(Allocator HIEJKCFDMDD, NativeArray<IMKMJFJEHIJ> KELBJKLPPLD, out NativeArray<(IMKMJFJEHIJ src, IMKMJFJEHIJ dst)> CFHLDEMCECD)
	{
		return default(NativeMultiHashMap<int, (IMKMJFJEHIJ, IMKMJFJEHIJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LDDHDONLPKD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	[BEHFJGBFKGL(typeof(TransformService))]
	[IHOFDNBJLIN(typeof(OKNLNFBIJGH), new string[] { })]
	public class TransformService : OKNLNFBIJGH, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly JFPIEAPAMJM JDIDIAKPNBA;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly JFPIEAPAMJM ACJJENBPCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GDIPKNJIAPN AGNCLNMMDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HBOFDJIDNOO DNJLLPNDOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase AAIHEOKBHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService BDIHCGGPFJK;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x3288460", Offset = "0x3287260", VA = "0x183288460")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private LOOMEBBKBLB PMPGCJKHBAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x32876B0", Offset = "0x32864B0", VA = "0x1832876B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x328AFB0", Offset = "0x3289DB0", VA = "0x18328AFB0", Slot = "33")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x328AAC0", Offset = "0x32898C0", VA = "0x18328AAC0", Slot = "34")]
		public bool MKPOMHDEPJB(Transform GPMKACFJLBP, out IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3286C80", Offset = "0x3285A80", VA = "0x183286C80", Slot = "35")]
		public Transform BMNKFDJOEBA(Entity JCNIDEIPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3288240", Offset = "0x3287040", VA = "0x183288240", Slot = "30")]
		public bool EPBDFGPFLJL(Entity JCNIDEIPPBD, out Transform GPMKACFJLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x32862F0", Offset = "0x32850F0", VA = "0x1832862F0")]
		private void AFCPMHEFGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x328A5E0", Offset = "0x32893E0", VA = "0x18328A5E0", Slot = "29")]
		public void LIHDMEPJAKC(Entity JCNIDEIPPBD, out Matrix4x4 FPBDAADLPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x328ADC0", Offset = "0x3289BC0", VA = "0x18328ADC0", Slot = "4")]
		public void PCPDDHPEIPN(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3287BF0", Offset = "0x32869F0", VA = "0x183287BF0")]
		public void ECEMCPHCDDN(Entity JCNIDEIPPBD, Vector3 BELKCDDMLBN, Quaternion DADJJDDMKJP, Vector3 FAOLJIDKEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3289FD0", Offset = "0x3288DD0", VA = "0x183289FD0")]
		public void LBDFDPCCEOG(Entity JCNIDEIPPBD, Vector3 BELKCDDMLBN, Quaternion DADJJDDMKJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3287AB0", Offset = "0x32868B0", VA = "0x183287AB0", Slot = "27")]
		public void EBHPDFMFCAI(Entity JCNIDEIPPBD, out Matrix4x4 LDPEGCBPJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3286D40", Offset = "0x3285B40", VA = "0x183286D40")]
		public void CAACLNOFFIE(Entity JCNIDEIPPBD, in Matrix4x4 FPBDAADLPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3288330", Offset = "0x3287130", VA = "0x183288330")]
		public void FMAPMMCLCMO(Entity JCNIDEIPPBD, in Matrix4x4 FPBDAADLPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3286690", Offset = "0x3285490", VA = "0x183286690")]
		public void BDIFJGEJEMO(Entity JCNIDEIPPBD, in Matrix4x4 ACGFFPDDBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3286850", Offset = "0x3285650", VA = "0x183286850", Slot = "5")]
		public void BFFMDELNFNL(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x32888E0", Offset = "0x32876E0", VA = "0x1832888E0", Slot = "6")]
		public Vector3 HCJAEDLBAGF(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3288140", Offset = "0x3286F40", VA = "0x183288140", Slot = "7")]
		public void ENJJLFEINGI(Entity JCNIDEIPPBD, Quaternion NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x328A730", Offset = "0x3289530", VA = "0x18328A730", Slot = "8")]
		public Quaternion MBGCPJOGBNP(Entity JCNIDEIPPBD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3287240", Offset = "0x3286040", VA = "0x183287240", Slot = "12")]
		public void CGMKNEBKBLJ(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3287770", Offset = "0x3286570", VA = "0x183287770", Slot = "11")]
		public Vector3 DNNFPMOCDCL(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x328AD20", Offset = "0x3289B20", VA = "0x18328AD20")]
		public void ONOHHCKOJID(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x328AC80", Offset = "0x3289A80", VA = "0x18328AC80")]
		private Vector3 NEGKFAEOEAJ(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x328A0E0", Offset = "0x3288EE0", VA = "0x18328A0E0", Slot = "14")]
		public float LDHBCBADDEJ(Entity JCNIDEIPPBD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x32887D0", Offset = "0x32875D0", VA = "0x1832887D0", Slot = "13")]
		public void HAAHPFAHMEJ(Entity JCNIDEIPPBD, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x328A9D0", Offset = "0x32897D0", VA = "0x18328A9D0")]
		private float MJJHDACMDLF(Entity JCNIDEIPPBD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3287620", Offset = "0x3286420", VA = "0x183287620")]
		public void DGIAKCAGCFF(Entity JCNIDEIPPBD, float PDPBAFNGHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x32865B0", Offset = "0x32853B0", VA = "0x1832865B0", Slot = "16")]
		public Vector3 BALPMMBMCKA(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3288000", Offset = "0x3286E00", VA = "0x183288000", Slot = "15")]
		public void ELIAFMHPKHI(Entity JCNIDEIPPBD, Vector3 DLOKAKGFINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3287ED0", Offset = "0x3286CD0", VA = "0x183287ED0")]
		private Vector3 EIKFBFFPNIE(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3286BB0", Offset = "0x32859B0", VA = "0x183286BB0")]
		public void BMBDFOOBMPA(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3286310", Offset = "0x3285110", VA = "0x183286310")]
		[Conditional("DEBUG_BUILD")]
		private void AIDIMGFHAJL(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3286970", Offset = "0x3285770", VA = "0x183286970", Slot = "36")]
		public void BHBIKOKDHLG(Entity JCNIDEIPPBD, Vector3 CBAKPHLPCPB, Quaternion HKMKNOBAIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3289E00", Offset = "0x3288C00", VA = "0x183289E00", Slot = "9")]
		public void JOGAOOJELFB(Entity JCNIDEIPPBD, out Vector3 CBAKPHLPCPB, out Quaternion HKMKNOBAIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3287AC0", Offset = "0x32868C0", VA = "0x183287AC0", Slot = "10")]
		public void EBJGFCKBMBK(Entity JCNIDEIPPBD, out Vector3 CBAKPHLPCPB, out Quaternion HKMKNOBAIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3289A90", Offset = "0x3288890", VA = "0x183289A90", Slot = "37")]
		public void JJABBICOJND(Entity JCNIDEIPPBD, Vector3 CBAKPHLPCPB, Quaternion HKMKNOBAIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3287460", Offset = "0x3286260", VA = "0x183287460")]
		public void CMGNLCOCOBC(Entity JCNIDEIPPBD, Vector3 CBAKPHLPCPB, Quaternion HKMKNOBAIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3287880", Offset = "0x3286680", VA = "0x183287880", Slot = "17")]
		public void DPKFNLPOHFL(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3286AD0", Offset = "0x32858D0", VA = "0x183286AD0", Slot = "18")]
		public Vector3 BJBMOADNGFH(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x32884B0", Offset = "0x32872B0", VA = "0x1832884B0", Slot = "19")]
		public void GACCOAADHKK(Entity JCNIDEIPPBD, Quaternion NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x32864C0", Offset = "0x32852C0", VA = "0x1832864C0", Slot = "20")]
		public Quaternion AJGGFOGDDGC(Entity JCNIDEIPPBD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x328A180", Offset = "0x3288F80", VA = "0x18328A180", Slot = "22")]
		public void LDICJCPPBPJ(Entity JCNIDEIPPBD, Vector3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3287DE0", Offset = "0x3286BE0", VA = "0x183287DE0", Slot = "21")]
		public Vector3 EIEMNDJCACF(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x32889F0", Offset = "0x32877F0", VA = "0x1832889F0", Slot = "23")]
		public void HMEMPLELKAL(Entity JCNIDEIPPBD, float DLILBFBMPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3287CC0", Offset = "0x3286AC0", VA = "0x183287CC0", Slot = "24")]
		public float EIDGJENIECB(Entity JCNIDEIPPBD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x32895A0", Offset = "0x32883A0", VA = "0x1832895A0", Slot = "25")]
		public void JHKCMLLHDJF(Entity JCNIDEIPPBD, Vector3 ACFJMNNMEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3287100", Offset = "0x3285F00", VA = "0x183287100", Slot = "26")]
		public Vector3 CFJKNOOICOA(Entity JCNIDEIPPBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3288B60", Offset = "0x3287960", VA = "0x183288B60", Slot = "31")]
		public void IGGGKJHELMN(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3289CB0", Offset = "0x3288AB0", VA = "0x183289CB0")]
		private IMKMJFJEHIJ JMBELMNNBEN(Transform GPMKACFJLBP)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x328B0C0", Offset = "0x3289EC0", VA = "0x18328B0C0")]
		private static TransformEntity PJLCDMCLHBL(FJNOGBCPDIO MAIOHDHBGKE, GameObject BEPEHBCCEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3287340", Offset = "0x3286140", VA = "0x183287340", Slot = "32")]
		public void CKGLMGEACNO(Entity JCNIDEIPPBD, Entity NPPHDNLMMMJ, Entity BANCJNAJPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3289F50", Offset = "0x3288D50", VA = "0x183289F50")]
		private BKJMJLOMMGE JOGAOOJELFB(Entity JCNIDEIPPBD)
		{
			return default(BKJMJLOMMGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x32886F0", Offset = "0x32874F0", VA = "0x1832886F0")]
		private bool GPEBAEKAPGD(Entity JCNIDEIPPBD, out Entity AABHIBJPKOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x328A820", Offset = "0x3289620", VA = "0x18328A820")]
		private void MCGJAFKKECD(Entity JCNIDEIPPBD, out Matrix4x4 FPBDAADLPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3289200", Offset = "0x3288000", VA = "0x183289200")]
		private void INFKNFCONDA(Entity JCNIDEIPPBD, out Matrix4x4 ACGFFPDDBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3288130", Offset = "0x3286F30", VA = "0x183288130", Slot = "28")]
		private void ENDHFEMJDLO(Entity JCNIDEIPPBD, in Matrix4x4 LDPEGCBPJII)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
[IHOFDNBJLIN(typeof(NEEPOGHONIF), new string[] { })]
internal sealed class NEEPOGHONIF : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[CEFONNIACOK]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F042D0", Offset = "0x2F030D0", VA = "0x182F042D0", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F04260", Offset = "0x2F03060", VA = "0x182F04260", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NEEPOGHONIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(ACJKPEJPKLF), new string[] { })]
public class ACJKPEJPKLF
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct PFDNLGAMIBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ACJKPEJPKLF AABHIBJPKOH;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x327AB30", Offset = "0x3279930", VA = "0x18327AB30")]
		public PFDNLGAMIBM(ACJKPEJPKLF AABHIBJPKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x327AB10", Offset = "0x3279910", VA = "0x18327AB10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DGBILGNGFKL;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AFGECBABPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1855CF0", Offset = "0x1854AF0", VA = "0x181855CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action LGEJMFPFBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x34F3E60", Offset = "0x34F2C60", VA = "0x1834F3E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x34F3F50", Offset = "0x34F2D50", VA = "0x1834F3F50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x34F3F20", Offset = "0x34F2D20", VA = "0x1834F3F20")]
	public PFDNLGAMIBM IMJGNBDBMAF()
	{
		return default(PFDNLGAMIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A91CD0", Offset = "0x1A90AD0", VA = "0x181A91CD0")]
	public void PAMBHHOPEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x34F3F00", Offset = "0x34F2D00", VA = "0x1834F3F00")]
	public void GIOOCDIJACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ACJKPEJPKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IHOFDNBJLIN(typeof(LFIGBHNMABJ), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
public class LFIGBHNMABJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DGBILGNGFKL;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool OHGLCGABLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x945830", Offset = "0x944630", VA = "0x180945830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9458C0", Offset = "0x9446C0", VA = "0x1809458C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LFIGBHNMABJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[IHOFDNBJLIN(typeof(EnableComponentSystemsInScope), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : OMEPFIBEFCP, BELKGIBIHCD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct IEMCKDNAHKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> NDMCOHAPOGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> AJGFBNHKPHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> HNAFJIPPBFK;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x42F93B0", Offset = "0x42F81B0", VA = "0x1842F93B0")]
			public IEMCKDNAHKF(NativeArray<int> NDMCOHAPOGH, NativeArray<int> AJGFBNHKPHM, Dictionary<ComponentSystemBase, int> HNAFJIPPBFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x42F9130", Offset = "0x42F7F30", VA = "0x1842F9130")]
			public void GAHIMLOJCLF(IEnumerable<ComponentSystemBase> GINNLCCNCAC, DADIFNCKKPF MDKIAFPBKNH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class JJDLMEMNOBL : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public JJDLMEMNOBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x42FB7B0", Offset = "0x42FA5B0", VA = "0x1842FB7B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x42FB980", Offset = "0x42FA780", VA = "0x1842FB980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x42FB8D0", Offset = "0x42FA6D0", VA = "0x1842FB8D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x42FB8D0", Offset = "0x42FA6D0", VA = "0x1842FB8D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const DADIFNCKKPF NHABOLLKGGM = DADIFNCKKPF.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly JFPIEAPAMJM AGBJFGKHCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private AACHPGDKAKL PIMEDEKHCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> HKFBEJAKJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> OFABIHLFGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int CPFPNOFCGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DADIFNCKKPF BEMAJICFBEO;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3511F60", Offset = "0x3510D60", VA = "0x183511F60", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x3511890", Offset = "0x3510690", VA = "0x183511890", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3511990", Offset = "0x3510790", VA = "0x183511990")]
		[IteratorStateMachine(typeof(JJDLMEMNOBL))]
		private IEnumerable<ComponentSystemBase> EPMNAKLONBE(int HJHFBPCCKIM, int HDNNAAICFFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3511980", Offset = "0x3510780", VA = "0x183511980", Slot = "5")]
		public void ENPLJCHABLD(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3511BE0", Offset = "0x35109E0", VA = "0x183511BE0")]
		private void LNAICIAMJEM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3511D30", Offset = "0x3510B30", VA = "0x183511D30")]
		public void LNAICIAMJEM(DADIFNCKKPF FMAACKDHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3511070", Offset = "0x350FE70", VA = "0x183511070")]
		private void AMOLNENNEMO(DADIFNCKKPF FMAACKDHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3510EF0", Offset = "0x350FCF0", VA = "0x183510EF0")]
		private void AFEIAHIAGHD(DADIFNCKKPF FMAACKDHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3511B80", Offset = "0x3510980", VA = "0x183511B80")]
		private void LJLGCCCPMJF(DADIFNCKKPF FMAACKDHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3511A80", Offset = "0x3510880", VA = "0x183511A80")]
		private void IIMCAEGPGOI(int HJHFBPCCKIM, int HDNNAAICFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3511FE0", Offset = "0x3510DE0", VA = "0x183511FE0")]
		private void POPODDHKMKK(int HJHFBPCCKIM, int HDNNAAICFFH, bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3511E30", Offset = "0x3510C30", VA = "0x183511E30")]
		private int NBMIIPEMGDD(DADIFNCKKPF FMAACKDHLEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3511300", Offset = "0x3510100", VA = "0x183511300")]
		private bool DLEPGPIOGKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3510F80", Offset = "0x350FD80", VA = "0x183510F80")]
		private Dictionary<ComponentSystemBase, int> ALOKEFGAPOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3511B40", Offset = "0x3510940", VA = "0x183511B40")]
		private void IPFHGBCKNHI(NativeArray<int> NDMCOHAPOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3511EB0", Offset = "0x3510CB0", VA = "0x183511EB0")]
		private void OGMJJJANNOF(NativeArray<int> AJGFBNHKPHM, NativeArray<int> NDMCOHAPOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3511920", Offset = "0x3510720", VA = "0x183511920")]
		private static DADIFNCKKPF ECEOIDABKDE(Type MAIOHDHBGKE, DADIFNCKKPF IMIKACAODIP)
		{
			return default(DADIFNCKKPF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3512130", Offset = "0x3510F30", VA = "0x183512130")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3511A20", Offset = "0x3510820", VA = "0x183511A20")]
		[CompilerGenerated]
		private void IDGJMEMFAMI(OMEPFIBEFCP OOAACPHHBJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3511E50", Offset = "0x3510C50", VA = "0x183511E50")]
		[CompilerGenerated]
		private void OEOPEOOFJGH(GLCKJEOBJPN OOAACPHHBJI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[IDOCBBAEIFB(JHEANMHFGAO.WorldService)]
	[IHOFDNBJLIN(typeof(PFJMLCCOCEN), new string[] { })]
	public class TickService : OMEPFIBEFCP, PFJMLCCOCEN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker CAFICAPJNOA;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker OPDFDAJNPBD;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker CBFCOIKDCHG;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker LLCBLBNAMDJ;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker AOHAKMJEEEI;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker JLLABHJGJBI;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker OIIAPNIIEKJ;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker OFFMBOJDFHB;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker DJEHOLAANEN;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker MFADMGCPKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CEFONNIACOK]
		private LPDKJACLMMI HPEJLCLAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CEFONNIACOK]
		private FKJLGPBPIDL EOGAJJMLIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[CEFONNIACOK]
		private TransformOwnershipPhase AOAKEGHEIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[CEFONNIACOK]
		private TimeService HLDBOKPBKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private PANKPCMPIOD PGJEGNBAENG;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool MLNLGGPPNMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3285420", Offset = "0x3284220", VA = "0x183285420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool LKJGHNBMELA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x3284C70", Offset = "0x3283A70", VA = "0x183284C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool GJEDPDNAJFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x3285420", Offset = "0x3284220", VA = "0x183285420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool FBDIKJHKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3285420", Offset = "0x3284220", VA = "0x183285420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x32855B0", Offset = "0x32843B0", VA = "0x1832855B0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x32849D0", Offset = "0x32837D0", VA = "0x1832849D0", Slot = "14")]
		public void GGMJPAKPLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x3285490", Offset = "0x3284290", VA = "0x183285490", Slot = "15")]
		public void OONLPLMGEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3284780", Offset = "0x3283580", VA = "0x183284780", Slot = "5")]
		public void EAGLKEHBMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3284AF0", Offset = "0x32838F0", VA = "0x183284AF0", Slot = "6")]
		public void GPDALJMOAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x32852A0", Offset = "0x32840A0", VA = "0x1832852A0", Slot = "7")]
		public void LEJNPEMLHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x3284600", Offset = "0x3283400", VA = "0x183284600", Slot = "8")]
		public void CHCICAOAOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3284850", Offset = "0x3283650", VA = "0x183284850", Slot = "9")]
		public void EFKCCJEDADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3284D10", Offset = "0x3283B10", VA = "0x183284D10", Slot = "10")]
		public void JMKICCGMNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x3284530", Offset = "0x3283330", VA = "0x183284530", Slot = "11")]
		public void BICBBFLCAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
		public void OMNCBBOOOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3285150", Offset = "0x3283F50", VA = "0x183285150", Slot = "12")]
		public void KJLMLJCOPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[IHOFDNBJLIN(typeof(CIHNJOKIFOM), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.WorldService)]
	public class WorldService : CIHNJOKIFOM, IDisposable, FEBFHBLLFPI, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private PANKPCMPIOD PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private JODABNJDPMN CKHENOELGFL;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public PANKPCMPIOD LKMGEGIOGFC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public LOOMEBBKBLB PMPGCJKHBAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2FC7F40", Offset = "0x2FC6D40", VA = "0x182FC7F40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x3293930", Offset = "0x3292730", VA = "0x183293930", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool NOIGHNNNJBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x32934E0", Offset = "0x32922E0", VA = "0x1832934E0", Slot = "10")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x3293970", Offset = "0x3292770", VA = "0x183293970", Slot = "11")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x3293820", Offset = "0x3292620", VA = "0x183293820")]
		private void FBMANFCLCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x32935F0", Offset = "0x32923F0", VA = "0x1832935F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x3293950", Offset = "0x3292750", VA = "0x183293950", Slot = "8")]
		public ComponentSystemBase NOIFGMLGCAB(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IHOFDNBJLIN(typeof(LGAEEHKGJMJ), new string[] { })]
public sealed class NEKMBKHBBMN : LGAEEHKGJMJ, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JCNEMNNOOAJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x42FB3C0", Offset = "0x42FA1C0", VA = "0x1842FB3C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x795390", Offset = "0x794190", VA = "0x180795390")]
		[DebuggerHidden]
		public JCNEMNNOOAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x42FB0B0", Offset = "0x42F9EB0", VA = "0x1842FB0B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x42FB380", Offset = "0x42FA180", VA = "0x1842FB380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x42FB2E0", Offset = "0x42FA0E0", VA = "0x1842FB2E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x42FB2E0", Offset = "0x42FA0E0", VA = "0x1842FB2E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[CEFONNIACOK]
	private HIAEEIHDIIB KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly LHJBDMEGAAJ FCNKIHLBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, MPKDBPOCPEM> FBNMGIFIACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, HDDDDGJLPGP> LIOIIBPLHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<HFFBKOKLMCH> NLCDNMCJCIL;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HDDDDGJLPGP CKEGHOJFEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2F04460", Offset = "0x2F03260", VA = "0x182F04460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<HFFBKOKLMCH> MIJPOIBLLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2F05290", Offset = "0x2F04090", VA = "0x182F05290", Slot = "8")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2F05150", Offset = "0x2F03F50", VA = "0x182F05150", Slot = "9")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2F04B00", Offset = "0x2F03900", VA = "0x182F04B00", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2F05200", Offset = "0x2F04000", VA = "0x182F05200", Slot = "6")]
	public bool NOMJCFCNIPM(HFFBKOKLMCH PEJFAKHLGCN, out HDDDDGJLPGP BNOLJGPLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2F04C70", Offset = "0x2F03A70", VA = "0x182F04C70")]
	private void ILEEOIOKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2F04690", Offset = "0x2F03490", VA = "0x182F04690")]
	private void DEMEPCCDJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2F04830", Offset = "0x2F03630", VA = "0x182F04830")]
	private MPKDBPOCPEM DHGLIGLNMKE(string HFCHLKENEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2F04460", Offset = "0x2F03260", VA = "0x182F04460")]
	private MPKDBPOCPEM EIMLNLBHMNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2F04890", Offset = "0x2F03690", VA = "0x182F04890")]
	private MPKDBPOCPEM DLEGBEAMKCM(string HFCHLKENEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2F044C0", Offset = "0x2F032C0", VA = "0x182F044C0")]
	private MPKDBPOCPEM CNDFBIMJDBG(string BOFDAKKMDPM, string INDCJAMMAIN, [Optional] MPKDBPOCPEM FIJKLPJLCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2F050E0", Offset = "0x2F03EE0", VA = "0x182F050E0")]
	[IteratorStateMachine(typeof(JCNEMNNOOAJ))]
	private IEnumerable<(string, string)> JMELKMMHPJM(string HFCHLKENEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2F043A0", Offset = "0x2F031A0", VA = "0x182F043A0")]
	private bool AJNCIDNFLNN(HFFBKOKLMCH PEJFAKHLGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2F05000", Offset = "0x2F03E00", VA = "0x182F05000")]
	private LHJBDMEGAAJ JHNEIECDPIK(HFFBKOKLMCH PEJFAKHLGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2F04C20", Offset = "0x2F03A20", VA = "0x182F04C20")]
	private LHJBDMEGAAJ GLMJELPGBNE(HFFBKOKLMCH PEJFAKHLGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2F04B90", Offset = "0x2F03990", VA = "0x182F04B90")]
	private LHJBDMEGAAJ FBCBEGAPLHL(HFFBKOKLMCH PEJFAKHLGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3157650", Offset = "0x3156450", VA = "0x183157650")]
	private T BCAHEPILBKE<T>(HFFBKOKLMCH PEJFAKHLGCN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2F043F0", Offset = "0x2F031F0", VA = "0x182F043F0")]
	private FieldInfo BHJBPJOCHCG(HFFBKOKLMCH PEJFAKHLGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2F052F0", Offset = "0x2F040F0", VA = "0x182F052F0")]
	public NEKMBKHBBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2F05170", Offset = "0x2F03F70", VA = "0x182F05170")]
	[CompilerGenerated]
	private int MMDBAKKCNFO(HFFBKOKLMCH FEIPFLDEPBD, HFFBKOKLMCH MIECAKFJHNF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class MPKDBPOCPEM : HDDDDGJLPGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string PKPCHELKOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly MPKDBPOCPEM FIJKLPJLCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<MPKDBPOCPEM> HMMOJKADOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<HFFBKOKLMCH> KELFDPANAFC;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string COPKKNCDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public HDDDDGJLPGP DLBHELDMJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<HDDDDGJLPGP> FNMIKJGJIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<HFFBKOKLMCH> OHNHILBEHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2F03C70", Offset = "0x2F02A70", VA = "0x182F03C70")]
	public MPKDBPOCPEM(string EOPECGOILOC, MPKDBPOCPEM AABHIBJPKOH)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[IHOFDNBJLIN(typeof(EACEJDIFHIM), new string[] { })]
	[BEHFJGBFKGL(typeof(HistoryService))]
	[IDOCBBAEIFB(JHEANMHFGAO.History)]
	public class HistoryService : OMEPFIBEFCP, IDisposable, EACEJDIFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum ODHLHPMKKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct HGPOLOFLODE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly ODHLHPMKKMJ COPNPHNEBCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService CAEONEDMKLM;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x42F87E0", Offset = "0x42F75E0", VA = "0x1842F87E0")]
			public HGPOLOFLODE(HistoryService CAEONEDMKLM, bool EGLABBIELCJ, uint CPFPNOFCGCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x42F87B0", Offset = "0x42F75B0", VA = "0x1842F87B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class BFEJJANFGOO
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct ONKOCOGKHNA : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly BFEJJANFGOO NPAKBFKDFCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool GJELCFEMHPI;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x42FDAB0", Offset = "0x42FC8B0", VA = "0x1842FDAB0")]
				public ONKOCOGKHNA(BFEJJANFGOO NPAKBFKDFCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x42FBFF0", Offset = "0x42FADF0", VA = "0x1842FBFF0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct LHDFEADGPJM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly BFEJJANFGOO NPAKBFKDFCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool GJELCFEMHPI;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x42FC020", Offset = "0x42FAE20", VA = "0x1842FC020")]
				public LHDFEADGPJM(BFEJJANFGOO NPAKBFKDFCJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x42FBFF0", Offset = "0x42FADF0", VA = "0x1842FBFF0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService IHAEDFCLCCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool AAKGODMMAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int MGJDHJDLFGE;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x42F2FD0", Offset = "0x42F1DD0", VA = "0x1842F2FD0")]
			public BFEJJANFGOO(HistoryService IHAEDFCLCCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x42F2F50", Offset = "0x42F1D50", VA = "0x1842F2F50")]
			public bool FIPGABGIEAL(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x42F2F80", Offset = "0x42F1D80", VA = "0x1842F2F80")]
			public LHDFEADGPJM GLDDABJCJAB()
			{
				return default(LHDFEADGPJM);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x42F2F00", Offset = "0x42F1D00", VA = "0x1842F2F00")]
			public ONKOCOGKHNA BNFACLOILNG()
			{
				return default(ONKOCOGKHNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class GFDLFHDEKKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public GFDLFHDEKKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x42F7010", Offset = "0x42F5E10", VA = "0x1842F7010")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class JLPNNIDDANM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public JLPNNIDDANM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x42FB9C0", Offset = "0x42FA7C0", VA = "0x1842FB9C0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class KLNJINKEBBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public KLNJINKEBBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x42FBF50", Offset = "0x42FAD50", VA = "0x1842FBF50")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction AKFHMFMJOKJ;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction PALNLEHLKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private PDFOJHCNMBL GCLEAIGFIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer KPBLCONHBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer CFIGMOEOCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private LBGCJNBFBNO FGLNLHJKOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase AOAKEGHEIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService JHJMMPDELAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DLOEKBIBCPN AKIHFGNBNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ODHLHPMKKMJ FNOFCEODIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private BFEJJANFGOO NPAKBFKDFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private JCNNKENHPEL LGKCMFHIBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private FKJKMJONNAG JFPJMBHPBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private OJNODEDDEDC IDNLJAJLAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete GHFPFLJBFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint MIKPFDLCHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint BFBBMHIJGOE;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private BFEJJANFGOO GGIMGDPBICO
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool FIDINOCAKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2FC2DC0", Offset = "0x2FC1BC0", VA = "0x182FC2DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool GNKMLDFICFN
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2FC23C0", Offset = "0x2FC11C0", VA = "0x182FC23C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool BNIFKLHPBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x2FC2D30", Offset = "0x2FC1B30", VA = "0x182FC2D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int NNGMKMBEDAG
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x2FC1CD0", Offset = "0x2FC0AD0", VA = "0x182FC1CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int DKKAPDJANJI
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2FC12F0", Offset = "0x2FC00F0", VA = "0x182FC12F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool EFHMHJKNKLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2FC1410", Offset = "0x2FC0210", VA = "0x182FC1410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool POIDKIJKGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2FC2D20", Offset = "0x2FC1B20", VA = "0x182FC2D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool COBKOGAPACM
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xC0BF80", Offset = "0xC0AD80", VA = "0x180C0BF80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xC0BFB0", Offset = "0xC0ADB0", VA = "0x180C0BFB0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer PDBILDPEBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2FC3460", Offset = "0x2FC2260", VA = "0x182FC3460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action HIHNBCOCIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2FC27E0", Offset = "0x2FC15E0", VA = "0x182FC27E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2FC2AA0", Offset = "0x2FC18A0", VA = "0x182FC2AA0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action OBBKCOBKEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2FC1350", Offset = "0x2FC0150", VA = "0x182FC1350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2FC2260", Offset = "0x2FC1060", VA = "0x182FC2260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2FB0", Offset = "0x2FC1DB0", VA = "0x182FC2FB0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2FC17D0", Offset = "0x2FC05D0", VA = "0x182FC17D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2FC29E0", Offset = "0x2FC17E0", VA = "0x182FC29E0")]
		private void LIBPOOIBLCP(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2460", Offset = "0x2FC1260", VA = "0x182FC2460")]
		private void GNFEAAMAOFA(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OKALBBANNMK, KNIHKHKCMFB BHOEDLDNCKL, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2B40", Offset = "0x2FC1940", VA = "0x182FC2B40")]
		private void MIMMJJFEINP(BDCMCEOAOGF LNCGECBHMHD, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2980", Offset = "0x2FC1780", VA = "0x182FC2980", Slot = "14")]
		public IDisposable KHHLBIBJADM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1600", Offset = "0x2FC0400", VA = "0x182FC1600", Slot = "9")]
		public IDisposable BDOPMKEJCBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1A70", Offset = "0x2FC0870", VA = "0x182FC1A70", Slot = "6")]
		public UndoAction EDCAOJBJHEB()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC25A0", Offset = "0x2FC13A0", VA = "0x182FC25A0", Slot = "15")]
		public RedoAction HNKGPMDFKPJ()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1420", Offset = "0x2FC0220", VA = "0x182FC1420", Slot = "16")]
		public UndoAction BABDMBCGFOP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2480", Offset = "0x2FC1280", VA = "0x182FC2480", Slot = "7")]
		public RedoAction HNKGPMDFKPJ(UndoAction INOJNNAPINL)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC14E0", Offset = "0x2FC02E0", VA = "0x182FC14E0", Slot = "8")]
		public UndoAction BABDMBCGFOP(RedoAction INOJNNAPINL)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2FC26C0", Offset = "0x2FC14C0", VA = "0x182FC26C0")]
		public bool IMBALGGIHAM(LFPLGBDKHIN KNAOJDHLNKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2210", Offset = "0x2FC1010", VA = "0x182FC2210", Slot = "17")]
		public void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2300", Offset = "0x2FC1100", VA = "0x182FC2300")]
		public void GCKBCNOJALH(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2FC28A0", Offset = "0x2FC16A0", VA = "0x182FC28A0")]
		public void KBCIFPMGFDE(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, in KNIHKHKCMFB BHOEDLDNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2160", Offset = "0x2FC0F60", VA = "0x182FC2160")]
		public void ENDFHLMLEGP(BDCMCEOAOGF LNCGECBHMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1B30", Offset = "0x2FC0930", VA = "0x182FC1B30")]
		private void EECOIIBCAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1310", Offset = "0x2FC0110", VA = "0x182FC1310")]
		private void AAPIAAHLLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2880", Offset = "0x2FC1680", VA = "0x182FC2880")]
		private void JDLOHIFCAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1D70", Offset = "0x2FC0B70", VA = "0x182FC1D70")]
		private MDPPGJCIMDN EMANCJLNOJA()
		{
			return default(MDPPGJCIMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1660", Offset = "0x2FC0460", VA = "0x182FC1660")]
		private uint CEGODKDKEBB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC13F0", Offset = "0x2FC01F0", VA = "0x182FC13F0")]
		private bool ACANGCMLJFE(out MDPPGJCIMDN KKJDJCJOLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2F90", Offset = "0x2FC1D90", VA = "0x182FC2F90")]
		private bool OKDLELDHCHG(out MDPPGJCIMDN KKJDJCJOLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2D60", Offset = "0x2FC1B60", VA = "0x182FC2D60")]
		private RedoAction NMGNDJKJJLJ(MDPPGJCIMDN KKJDJCJOLIF)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2660", Offset = "0x2FC1460", VA = "0x182FC2660")]
		private UndoAction IDINLBEOPMK(MDPPGJCIMDN KKJDJCJOLIF)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1E70", Offset = "0x2FC0C70", VA = "0x182FC1E70")]
		private MDPPGJCIMDN EMEHNIEOGLC(MDPPGJCIMDN KKJDJCJOLIF, ActionBuffer GIEECHBCPFD, bool EGLABBIELCJ)
		{
			return default(MDPPGJCIMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2700", Offset = "0x2FC1500", VA = "0x182FC2700")]
		private void IOFHLLNAMDP(Action KKJDJCJOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2707240", Offset = "0x2706040", VA = "0x182707240")]
		private T IOFHLLNAMDP<T>(Func<T> HFEABCHFANG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2130", Offset = "0x2FC0F30", VA = "0x182FC2130")]
		private HGPOLOFLODE EMEJFPCEMBO(bool EGLABBIELCJ, uint CPFPNOFCGCI)
		{
			return default(HGPOLOFLODE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3550", Offset = "0x2FC2350", VA = "0x182FC3550")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1680", Offset = "0x2FC0480", VA = "0x182FC1680")]
		[CompilerGenerated]
		private UndoAction DAPLDGNLEKF()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2E20", Offset = "0x2FC1C20", VA = "0x182FC2E20")]
		[CompilerGenerated]
		private RedoAction OIHDLCDLBEA()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1B70", Offset = "0x2FC0970", VA = "0x182FC1B70")]
		[CompilerGenerated]
		private UndoAction EFDNALGJNLB()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PGCICDHGEGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> ECEFKNGMHII;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public PGCICDHGEGC(NativeArray<byte> ECEFKNGMHII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2F17660", Offset = "0x2F16460", VA = "0x182F17660")]
	public static PGCICDHGEGC CILEDLHNJIF(NativeArray<byte> ECEFKNGMHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T CEGHJCCFJNH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> GCFCJONHNOD<T>(int LNKONGJEECL, Allocator HIEJKCFDMDD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> EELGFIPHLGN<T>(Allocator HIEJKCFDMDD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EBMKENPMANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> ECEFKNGMHII;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public EBMKENPMANN(NativeArray<byte> ECEFKNGMHII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x350E160", Offset = "0x350CF60", VA = "0x18350E160")]
	public static EBMKENPMANN CILEDLHNJIF(NativeArray<byte> ECEFKNGMHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2FADE60", Offset = "0x2FACC60", VA = "0x182FADE60")]
	public T CEGHJCCFJNH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> GCFCJONHNOD<T>(int LNKONGJEECL, Allocator HIEJKCFDMDD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PNNDOKLNOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> ECEFKNGMHII;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public PNNDOKLNOEJ(NativeArray<byte> ECEFKNGMHII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2F18730", Offset = "0x2F17530", VA = "0x182F18730")]
	public static PNNDOKLNOEJ CILEDLHNJIF(NativeArray<byte> ECEFKNGMHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x24B1740", Offset = "0x24B0540", VA = "0x1824B1740")]
	public void GACKPBNPFPB<T>(in T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x24B1640", Offset = "0x24B0440", VA = "0x1824B1640")]
	public void DDCJCMMKIAK<T>(NativeArray<T> ALDENJHFODN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void OCHCKFLKNNG<T>(NativeArray<T> NLHFEJHKLAH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CNKHDKEMMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x34FD010", Offset = "0x34FBE10", VA = "0x1834FD010")]
	public static Span<byte> BLGONHIIEGC(this NativeArray<byte> ECEFKNGMHII)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x34FD1A0", Offset = "0x34FBFA0", VA = "0x1834FD1A0")]
	public static ReadOnlySpan<byte> MOGNBEODGJK(this NativeArray<byte> ECEFKNGMHII)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x34FD120", Offset = "0x34FBF20", VA = "0x1834FD120")]
	public static NativeArray<byte> JOINJODBLFH(this NativeArray<byte> ECEFKNGMHII, int HJHFBPCCKIM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x34FD0A0", Offset = "0x34FBEA0", VA = "0x1834FD0A0")]
	public static NativeArray<byte> DFHOFBJFMGI(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x268F320", Offset = "0x268E120", VA = "0x18268F320")]
	public static NativeArray<byte> DFHOFBJFMGI<T>(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x34FD320", Offset = "0x34FC120", VA = "0x1834FD320")]
	public static NativeArray<byte> OAKPBKEBJJG(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x268F380", Offset = "0x268E180", VA = "0x18268F380")]
	public static NativeArray<byte> OAKPBKEBJJG<T>(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x34FD390", Offset = "0x34FC190", VA = "0x1834FD390")]
	public static NativeArray<byte> PHGFPFMAGBC(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x268F3E0", Offset = "0x268E1E0", VA = "0x18268F3E0")]
	public static NativeArray<byte> PHGFPFMAGBC<T>(this NativeArray<byte> ECEFKNGMHII, int PHHDFCFDFMP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AKKAKHLPDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public AKKAKHLPDGP(NativeList<byte> LLMBPPCBLOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x34F5E70", Offset = "0x34F4C70", VA = "0x1834F5E70")]
	public static AKKAKHLPDGP CILEDLHNJIF(NativeList<byte> ECEFKNGMHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void GACKPBNPFPB<T>(in T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void DDCJCMMKIAK<T>(NativeArray<T> NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void OCHCKFLKNNG<T>(NativeArray<T> NLHFEJHKLAH) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.PropertyChanges)]
	public class PropertyChangeNetworkRouter : FEBFHBLLFPI, OMEPFIBEFCP, LMJKNNOOLMK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[CEFONNIACOK]
		private OHDGPNFCBOA AGODLEOBGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[CEFONNIACOK]
		private PCBBMIOOLHO KELFDPANAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CEFONNIACOK]
		private ACJKPEJPKLF PHFBLMNIKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CEFONNIACOK]
		private PropertyChangeRouterService JHJMMPDELAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private PDFOJHCNMBL PCEDOMDPLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NPDABACFLDM OPKNDGMEEDM;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public PDFOJHCNMBL ENBPHNEIFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F540", Offset = "0x2F1E340", VA = "0x182F1F540")]
		public PDFOJHCNMBL.BHMCKKLOBCG IMJGNBDBMAF()
		{
			return default(PDFOJHCNMBL.BHMCKKLOBCG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2F1ED70", Offset = "0x2F1DB70", VA = "0x182F1ED70", Slot = "4")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F880", Offset = "0x2F1E680", VA = "0x182F1F880", Slot = "5")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EEE0", Offset = "0x2F1DCE0", VA = "0x182F1EEE0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F100", Offset = "0x2F1DF00", VA = "0x182F1F100")]
		public void EDCAOJBJHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F210", Offset = "0x2F1E010", VA = "0x182F1F210")]
		public void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F770", Offset = "0x2F1E570", VA = "0x182F1F770")]
		private void NPOHIEKPAJG(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EE60", Offset = "0x2F1DC60", VA = "0x182F1EE60")]
		private void DMBCPEBDLFI(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OKALBBANNMK, KNIHKHKCMFB BHOEDLDNCKL, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EC90", Offset = "0x2F1DA90", VA = "0x182F1EC90")]
		private void BBLEBJJHLNM(BDCMCEOAOGF LNCGECBHMHD, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F260", Offset = "0x2F1E060", VA = "0x182F1F260")]
		private void GNOOJGLJKOE(NPDABACFLDM HOKEJKCPCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F580", Offset = "0x2F1E380", VA = "0x182F1F580")]
		private void JMAJAOKPPEM(NPDABACFLDM HOKEJKCPCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F6B0", Offset = "0x2F1E4B0", VA = "0x182F1F6B0")]
		private void MNGBBPMEIAL(NPDABACFLDM HOKEJKCPCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F860", Offset = "0x2F1E660", VA = "0x182F1F860")]
		private void PAMBHHOPEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F240", Offset = "0x2F1E040", VA = "0x182F1F240")]
		private void GIOOCDIJACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FB00", Offset = "0x2F1E900", VA = "0x182F1FB00")]
		private void PPANGDEAPBB(NPDABACFLDM HOKEJKCPCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3E121D0", Offset = "0x3E10FD0", VA = "0x183E121D0", Slot = "6")]
		private void KKNAHOIILNG<TKey, T>(global::BPLIOBAGCJM<TKey, T> PEJFAKHLGCN, object KPEPJOHCOMD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[IDOCBBAEIFB(JHEANMHFGAO.History)]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void BLMAGLFFOOI(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC, bool ODPGOFFGFGJ);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void HJDNIPOJOOF(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OKALBBANNMK, KNIHKHKCMFB BHOEDLDNCKL, bool ODPGOFFGFGJ);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void HCEAOHMAMAJ(BDCMCEOAOGF LNCGECBHMHD, bool ODPGOFFGFGJ);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public BLMAGLFFOOI FBMANFCLCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HJDNIPOJOOF KJNOOEBCDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public HCEAOHMAMAJ ECKNMJDFBGK;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FC10", Offset = "0x2F1EA10", VA = "0x182F1FC10")]
		public void GCKBCNOJALH(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FC30", Offset = "0x2F1EA30", VA = "0x182F1FC30")]
		public void KBCIFPMGFDE(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, in KNIHKHKCMFB OKALBBANNMK, in KNIHKHKCMFB BHOEDLDNCKL, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FBF0", Offset = "0x2F1E9F0", VA = "0x182F1FBF0")]
		public void ENDFHLMLEGP(BDCMCEOAOGF LNCGECBHMHD, bool ODPGOFFGFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(MPOIBFDCCKD))]
	[IDOCBBAEIFB(JHEANMHFGAO.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class MPOIBFDCCKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer IHLLHGOCNMO;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int OAHKGMMAIIG
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x327A080", Offset = "0x3278E80", VA = "0x18327A080")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public NLLNOAJLLIO[] ONGEBNHOCGL
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x3279EC0", Offset = "0x3278CC0", VA = "0x183279EC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
			public MPOIBFDCCKD(ActionBuffer OKPHPBJOGPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x3279F90", Offset = "0x3278D90", VA = "0x183279F90")]
			[CompilerGenerated]
			private NLLNOAJLLIO JHHCNIJKACP(MDPPGJCIMDN KKJDJCJOLIF)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class NLLNOAJLLIO : LMJKNNOOLMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer IHLLHGOCNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly MDPPGJCIMDN KKJDJCJOLIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(NPDABACFLDM, string, object)> MIABCNNFJEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private EBMKENPMANN EDHAMFMKJBA;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int OAHKGMMAIIG
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x327A6C0", Offset = "0x32794C0", VA = "0x18327A6C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(NPDABACFLDM, string, object)> DGFPPFKEMED
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x327AA50", Offset = "0x3279850", VA = "0x18327AA50")]
			public NLLNOAJLLIO(ActionBuffer OKPHPBJOGPN, MDPPGJCIMDN KKJDJCJOLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x327A5C0", Offset = "0x32793C0", VA = "0x18327A5C0")]
			private string CJGBJLLLKBF(NPDABACFLDM OPKNDGMEEDM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x327A710", Offset = "0x3279510", VA = "0x18327A710")]
			private void KKLPLLLGLNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DF7520", Offset = "0x3DF6320", VA = "0x183DF7520", Slot = "4")]
			public void OENOFEPKBLK<TKey, T>(global::BPLIOBAGCJM<TKey, T> PEJFAKHLGCN, [Optional] object KPEPJOHCOMD) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> GCNPDCEJPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<MDPPGJCIMDN> OOFFJALPOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly MBFEKPEMPJN MPANKAMHAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JCNNKENHPEL LGKCMFHIBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly PCBBMIOOLHO KELFDPANAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool DJNPAOJCELD;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public MENPPPPJDFA MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x34F65E0", Offset = "0x34F53E0", VA = "0x1834F65E0")]
			get
			{
				return default(MENPPPPJDFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int OAHKGMMAIIG
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x34F68F0", Offset = "0x34F56F0", VA = "0x1834F68F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x34F6D10", Offset = "0x34F5B10", VA = "0x1834F6D10")]
		public ActionBuffer(JCNNKENHPEL LGKCMFHIBND, PCBBMIOOLHO KELFDPANAFC, bool DJNPAOJCELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x34F6930", Offset = "0x34F5730", VA = "0x1834F6930")]
		public bool LGGEEFDDKPE(out MDPPGJCIMDN KKJDJCJOLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x34F6570", Offset = "0x34F5370", VA = "0x1834F6570")]
		public void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x34F62E0", Offset = "0x34F50E0", VA = "0x1834F62E0")]
		public MDPPGJCIMDN EDCAOJBJHEB(DBLLNNMCKGJ MIABCNNFJEA, DLOEKBIBCPN AKIHFGNBNLH, uint ECKIKLNEPOB)
		{
			return default(MDPPGJCIMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x34F6A20", Offset = "0x34F5820", VA = "0x1834F6A20")]
		public bool NEOHDALJLOM(uint ECKIKLNEPOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x34F6620", Offset = "0x34F5420", VA = "0x1834F6620")]
		public bool JGDDNNFDFBM(uint ECKIKLNEPOB, out MDPPGJCIMDN INOJNNAPINL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x34F6100", Offset = "0x34F4F00", VA = "0x1834F6100")]
		public void AFIKKILFKKJ(MDPPGJCIMDN INOJNNAPINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x34F5FC0", Offset = "0x34F4DC0", VA = "0x1834F5FC0")]
		[Conditional("DEBUG_BUILD")]
		private void AFHILGLOHPB(MDPPGJCIMDN INOJNNAPINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x34F6420", Offset = "0x34F5220", VA = "0x1834F6420")]
		private void EMEHNIEOGLC(MDPPGJCIMDN NJHINPMDBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x34F6A50", Offset = "0x34F5850", VA = "0x1834F6A50")]
		private void ODGPLELPOJJ(EBMKENPMANN COKKCIPPNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x34F69C0", Offset = "0x34F57C0", VA = "0x1834F69C0")]
		private void NBEKPOMPFJK(MDPPGJCIMDN KKJDJCJOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x34F6810", Offset = "0x34F5610", VA = "0x1834F6810")]
		private EBMKENPMANN JGFCPJADECN(MDPPGJCIMDN KKJDJCJOLIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x34F6270", Offset = "0x34F5070", VA = "0x1834F6270", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class MBFEKPEMPJN : LMJKNNOOLMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly JCNNKENHPEL LGKCMFHIBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly PCBBMIOOLHO KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private BDCMCEOAOGF LNCGECBHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private EBMKENPMANN HMOBAAJADCE;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x87BC00", Offset = "0x87AA00", VA = "0x18087BC00")]
	public MBFEKPEMPJN(JCNNKENHPEL LGKCMFHIBND, PCBBMIOOLHO KELFDPANAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E61AE0", Offset = "0x2E608E0", VA = "0x182E61AE0", Slot = "4")]
	public void OENOFEPKBLK<TKey, T>(global::BPLIOBAGCJM<TKey, T> EEJLFKLMKKA, [Optional] object KPEPJOHCOMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F01EC0", Offset = "0x2F00CC0", VA = "0x182F01EC0")]
	public void ABOJAHHKNKA(NPDABACFLDM OPKNDGMEEDM, ref EBMKENPMANN COKKCIPPNKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PDFOJHCNMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct BHMCKKLOBCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly PDFOJHCNMBL AABHIBJPKOH;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x42F3030", Offset = "0x42F1E30", VA = "0x1842F3030")]
		public BHMCKKLOBCG(PDFOJHCNMBL AABHIBJPKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x42F3010", Offset = "0x42F1E10", VA = "0x1842F3010", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected DBLLNNMCKGJ MIABCNNFJEA;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public DBLLNNMCKGJ DGFPPFKEMED
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2F16800", Offset = "0x2F15600", VA = "0x182F16800")]
		get
		{
			return default(DBLLNNMCKGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool PABJIHCLIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2F164D0", Offset = "0x2F152D0", VA = "0x182F164D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F16920", Offset = "0x2F15720", VA = "0x182F16920")]
	public PDFOJHCNMBL(DBLLNNMCKGJ.DMDKKGEDHAF JDEMBOJCMAM = DBLLNNMCKGJ.DMDKKGEDHAF.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F165B0", Offset = "0x2F153B0", VA = "0x182F165B0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F165C0", Offset = "0x2F153C0", VA = "0x182F165C0")]
	public void GCKBCNOJALH(BDCMCEOAOGF LNCGECBHMHD, NKCOMLBHOPC KDKIGLANKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F167A0", Offset = "0x2F155A0", VA = "0x182F167A0")]
	public void KBCIFPMGFDE(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F164F0", Offset = "0x2F152F0", VA = "0x182F164F0")]
	public void ENDFHLMLEGP(BDCMCEOAOGF LNCGECBHMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F16840", Offset = "0x2F15640", VA = "0x182F16840")]
	public void PAMBHHOPEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F16690", Offset = "0x2F15490", VA = "0x182F16690")]
	public void GIOOCDIJACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F164E0", Offset = "0x2F152E0", VA = "0x182F164E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F16770", Offset = "0x2F15570", VA = "0x182F16770")]
	public BHMCKKLOBCG IMJGNBDBMAF()
	{
		return default(BHMCKKLOBCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NPDABACFLDM : IComparable<NPDABACFLDM>, IEquatable<NPDABACFLDM>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NPDABACFLDM PEBOJACILFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public BDCMCEOAOGF LNCGECBHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public OJNODEDDEDC OINBNOFPHAF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F07650", Offset = "0x2F06450", VA = "0x182F07650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
	public NPDABACFLDM(BDCMCEOAOGF LNCGECBHMHD, OJNODEDDEDC OINBNOFPHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2F07640", Offset = "0x2F06440", VA = "0x182F07640")]
	public void PJENBBOJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F07440", Offset = "0x2F06240", VA = "0x182F07440", Slot = "4")]
	public int CompareTo(NPDABACFLDM ONICAEEHHFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F07660", Offset = "0x2F06460", VA = "0x182F07660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F07480", Offset = "0x2F06280", VA = "0x182F07480", Slot = "0")]
	public override bool Equals(object BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F07520", Offset = "0x2F06320", VA = "0x182F07520", Slot = "5")]
	public bool Equals(NPDABACFLDM ONICAEEHHFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F075B0", Offset = "0x2F063B0", VA = "0x182F075B0")]
	public static bool LHMNPGMNIAC(NPDABACFLDM PLAIMEGKAGI, NPDABACFLDM PENEJEHLCIP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F075F0", Offset = "0x2F063F0", VA = "0x182F075F0")]
	public static bool NGBHPPLJJAJ(NPDABACFLDM PLAIMEGKAGI, NPDABACFLDM PENEJEHLCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F07570", Offset = "0x2F06370", VA = "0x182F07570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[IDOCBBAEIFB(JHEANMHFGAO.History)]
	public class GatherPropertiesForUndelete : OAGIJOPMPLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private JCNNKENHPEL LGKCMFHIBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private BDCMCEOAOGF LNCGECBHMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService IHAEDFCLCCH;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2FBEA70", Offset = "0x2FBD870", VA = "0x182FBEA70")]
		public void LMJMBOAMHCJ(BDCMCEOAOGF LNCGECBHMHD, JCNNKENHPEL LGKCMFHIBND, HistoryService IHAEDFCLCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE9A0", Offset = "0x2FBD7A0", VA = "0x182FBE9A0", Slot = "4")]
		private void CIMNMLDCKNH(PKDFMMCFBEC PEJFAKHLGCN, in KNIHKHKCMFB NLHFEJHKLAH, object KPEPJOHCOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class AAMJDPHCBHB
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x34F3BD0", Offset = "0x34F29D0", VA = "0x1834F3BD0")]
	public static void JMAJAOKPPEM(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM, NKCOMLBHOPC KDKIGLANKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x34F3960", Offset = "0x34F2760", VA = "0x1834F3960")]
	public static void ECCLPMNACDE(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x34F3D70", Offset = "0x34F2B70", VA = "0x1834F3D70")]
	public static void MNGBBPMEIAL(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x34F3AA0", Offset = "0x34F28A0", VA = "0x1834F3AA0")]
	public static void IPIDFKBIOKG(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x34F3DC0", Offset = "0x34F2BC0", VA = "0x1834F3DC0")]
	public static NKCOMLBHOPC PAOPJMMHEJJ(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM)
	{
		return default(NKCOMLBHOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x262E4A0", Offset = "0x262D2A0", VA = "0x18262E4A0")]
	public static T GNHHPPPBLDO<T>(DBLLNNMCKGJ MIABCNNFJEA, NPDABACFLDM OPKNDGMEEDM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x262E4C0", Offset = "0x262D2C0", VA = "0x18262E4C0")]
	public static T GNHHPPPBLDO<T>(ref EBMKENPMANN PHAPMEHMHAK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x34F3E10", Offset = "0x34F2C10", VA = "0x1834F3E10")]
	public static NKCOMLBHOPC PAOPJMMHEJJ(ref EBMKENPMANN PHAPMEHMHAK)
	{
		return default(NKCOMLBHOPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DBLLNNMCKGJ : IEnumerable<NPDABACFLDM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum DMDKKGEDHAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct HAPBEDFANJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly DBLLNNMCKGJ LLMBPPCBLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DLOEKBIBCPN AKIHFGNBNLH;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3279290", Offset = "0x3278090", VA = "0x183279290")]
		public HAPBEDFANJB(DBLLNNMCKGJ LLMBPPCBLOM, DLOEKBIBCPN AKIHFGNBNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3278DA0", Offset = "0x3277BA0", VA = "0x183278DA0")]
		public void KLHMLIHLNCO(NativeList<byte> IFCPBBBMBJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3278C60", Offset = "0x3277A60", VA = "0x183278C60")]
		private void FMCAIOCFMKH(NPDABACFLDM OPKNDGMEEDM, ref PNNDOKLNOEJ DKKLGJNICJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3278980", Offset = "0x3277780", VA = "0x183278980")]
		private void BAPBAKHABNF(NPDABACFLDM OPKNDGMEEDM, ref PNNDOKLNOEJ DKKLGJNICJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3278CB0", Offset = "0x3277AB0", VA = "0x183278CB0")]
		private NativeArray<byte> ILLNBFNIHDO(NativeList<byte> IFCPBBBMBJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3279040", Offset = "0x3277E40", VA = "0x183279040")]
		private NativeArray<byte> OPIIFNCNAAC(NativeList<byte> IFCPBBBMBJL, int LNKONGJEECL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3278A10", Offset = "0x3277810", VA = "0x183278A10")]
		private int COCLOJDANOC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3279130", Offset = "0x3277F30", VA = "0x183279130")]
		private bool PMCLPJGHIFP(NPDABACFLDM OPKNDGMEEDM, out NativeArray<byte> PCOEAAHDNMD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct NBJKLICIIGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> PHAPMEHMHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DBLLNNMCKGJ LLMBPPCBLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly NPDABACFLDM HOKEJKCPCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int HJHFBPCCKIM;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x327A520", Offset = "0x3279320", VA = "0x18327A520")]
		internal NBJKLICIIGO(DBLLNNMCKGJ LLMBPPCBLOM, NPDABACFLDM HOKEJKCPCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x327A310", Offset = "0x3279110", VA = "0x18327A310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x327A340", Offset = "0x3279140", VA = "0x18327A340")]
		public void FBAAOJLBBPL(NativeArray<byte> NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x327A2B0", Offset = "0x32790B0", VA = "0x18327A2B0")]
		public void CNOKJCODPMJ(NativeArray<byte> NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x327A2A0", Offset = "0x32790A0", VA = "0x18327A2A0")]
		public void BAPBAKHABNF(in KNIHKHKCMFB NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3DF64C0", Offset = "0x3DF52C0", VA = "0x183DF64C0")]
		public void BAPBAKHABNF<T>(T NLHFEJHKLAH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x327A3A0", Offset = "0x32791A0", VA = "0x18327A3A0")]
		private void OBHFMFPPFFJ(int NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x327A470", Offset = "0x3279270", VA = "0x18327A470")]
		private void OBHFMFPPFFJ(in KNIHKHKCMFB NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x327A410", Offset = "0x3279210", VA = "0x18327A410")]
		private unsafe void OBHFMFPPFFJ(void* BAPIJOGFIJJ, int LNKONGJEECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x327A340", Offset = "0x3279140", VA = "0x18327A340")]
		private void OBHFMFPPFFJ(NativeArray<byte> ALDENJHFODN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CODINCGDCGL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private DBLLNNMCKGJ LLMBPPCBLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> PHAPMEHMHAK;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3277790", Offset = "0x3276590", VA = "0x183277790")]
		internal CODINCGDCGL(DBLLNNMCKGJ LLMBPPCBLOM, NativeArray<byte> PHAPMEHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x32775D0", Offset = "0x32763D0", VA = "0x1832775D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x32776D0", Offset = "0x32764D0", VA = "0x1832776D0")]
		public NativeArray<byte> GCFCJONHNOD(int LNKONGJEECL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x32775E0", Offset = "0x32763E0", VA = "0x1832775E0")]
		public NativeArray<byte> EELGFIPHLGN()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0520", Offset = "0x3DEF320", VA = "0x183DF0520")]
		public T CEGHJCCFJNH<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x32774D0", Offset = "0x32762D0", VA = "0x1832774D0")]
		public void CEGHJCCFJNH(in IADENELHJPC NLHFEJHKLAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct ALIKEALHCDB : IEnumerator<NPDABACFLDM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<NPDABACFLDM> ECEFKNGMHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int CPOAAGLEIPE;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public NPDABACFLDM MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x3276D00", Offset = "0x3275B00", VA = "0x183276D00", Slot = "4")]
			get
			{
				return default(NPDABACFLDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3276CB0", Offset = "0x3275AB0", VA = "0x183276CB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3276CF0", Offset = "0x3275AF0", VA = "0x183276CF0")]
		internal ALIKEALHCDB(NativeList<NPDABACFLDM> ALDENJHFODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3276B70", Offset = "0x3275970", VA = "0x183276B70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3276C70", Offset = "0x3275A70", VA = "0x183276C70", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct MOJILABILMG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int DNKBNAGPFHI = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int OEJPPMLBLOB = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int OGCIHEIDHPE = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> PHAPMEHMHAK;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool AMFLHOGACPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3279A70", Offset = "0x3278870", VA = "0x183279A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int IDDDGHJOEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x3279AF0", Offset = "0x32788F0", VA = "0x183279AF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x3279990", Offset = "0x3278790", VA = "0x183279990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public DMDKKGEDHAF LOLGAPIPFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x3279980", Offset = "0x3278780", VA = "0x183279980")]
			get
			{
				return default(DMDKKGEDHAF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3279A00", Offset = "0x3278800", VA = "0x183279A00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool PABJIHCLIDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x3279970", Offset = "0x3278770", VA = "0x183279970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x3279A10", Offset = "0x3278810", VA = "0x183279A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool NELHMAINAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x32799F0", Offset = "0x32787F0", VA = "0x1832799F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x32799A0", Offset = "0x32787A0", VA = "0x1832799A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3279B00", Offset = "0x3278900", VA = "0x183279B00")]
		public MOJILABILMG(DMDKKGEDHAF JDEMBOJCMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x32799C0", Offset = "0x32787C0", VA = "0x1832799C0")]
		private int BPAEGFNIDAI(int JBINMJEHBFH, int KJHDKMLNANG = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3279AB0", Offset = "0x32788B0", VA = "0x183279AB0")]
		private void NIPKJFNBLBF(int JBINMJEHBFH, int NLHFEJHKLAH, int KJHDKMLNANG = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3279A30", Offset = "0x3278830", VA = "0x183279A30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int DPMMPOAOLDF = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int CKMGGHGAMPO = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly NPDABACFLDM GEAEGOCBKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<NPDABACFLDM, int> DCHANNODNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<NPDABACFLDM> MIABCNNFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> OFABIHLFGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> BKAPKMOODJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> PHAPMEHMHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private MOJILABILMG FGGPHJMDLJN;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PABJIHCLIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3509090", Offset = "0x3507E90", VA = "0x183509090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NNBGDDNCINI
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x35098A0", Offset = "0x35086A0", VA = "0x1835098A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int IDDDGHJOEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3509990", Offset = "0x3508790", VA = "0x183509990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int OLDMPHNDNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3509420", Offset = "0x3508220", VA = "0x183509420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3509770", Offset = "0x3508570", VA = "0x183509770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3509300", Offset = "0x3508100", VA = "0x183509300")]
	public static DBLLNNMCKGJ FBMANFCLCAO(DMDKKGEDHAF JDEMBOJCMAM = DMDKKGEDHAF.Last, int NKMNNHEDMEC = 16, int FMGLIPLLAKH = 256)
	{
		return default(DBLLNNMCKGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3509D80", Offset = "0x3508B80", VA = "0x183509D80")]
	private DBLLNNMCKGJ(DMDKKGEDHAF JDEMBOJCMAM, int NKMNNHEDMEC, int FMGLIPLLAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3509220", Offset = "0x3508020", VA = "0x183509220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x35094A0", Offset = "0x35082A0", VA = "0x1835094A0")]
	public NBJKLICIIGO GNOOJGLJKOE(NPDABACFLDM HOKEJKCPCMA)
	{
		return default(NBJKLICIIGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x35090A0", Offset = "0x3507EA0", VA = "0x1835090A0")]
	public CODINCGDCGL BAOJNCPNKDE(NPDABACFLDM HOKEJKCPCMA)
	{
		return default(CODINCGDCGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x3509530", Offset = "0x3508330", VA = "0x183509530")]
	public bool KHPEOEBAJNP(NPDABACFLDM HOKEJKCPCMA, out CODINCGDCGL INJKNDGHKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3509720", Offset = "0x3508520", VA = "0x183509720")]
	public bool LCEKCENKGMH(NPDABACFLDM HOKEJKCPCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x35098C0", Offset = "0x35086C0", VA = "0x1835098C0")]
	public bool MMLAGFPEHFA(NPDABACFLDM HOKEJKCPCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x35097B0", Offset = "0x35085B0", VA = "0x1835097B0")]
	public void LPLBELHMIIP(NativeList<byte> IFCPBBBMBJL, DLOEKBIBCPN AKIHFGNBNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x26A3F60", Offset = "0x26A2D60", VA = "0x1826A3F60")]
	public T GMDGPINAMDC<T>(NPDABACFLDM HOKEJKCPCMA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x3509340", Offset = "0x3508140", VA = "0x183509340")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3509460", Offset = "0x3508260", VA = "0x183509460")]
	public ALIKEALHCDB FGLPNHJPKAJ()
	{
		return default(ALIKEALHCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x35099A0", Offset = "0x35087A0", VA = "0x1835099A0")]
	private void OELDNGHMEHK(NPDABACFLDM HOKEJKCPCMA, int HJHFBPCCKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3509B90", Offset = "0x3508990", VA = "0x183509B90")]
	private void PJENBBOJIDK(int JGADMOFPNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3509130", Offset = "0x3507F30", VA = "0x183509130")]
	private void BJIECMCNDMB(NPDABACFLDM HOKEJKCPCMA, int HJHFBPCCKIM, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x26A40F0", Offset = "0x26A2EF0", VA = "0x1826A40F0")]
	private static T GMDGPINAMDC<T>(NativeArray<byte> ECEFKNGMHII, int JBINMJEHBFH = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3509CC0", Offset = "0x3508AC0", VA = "0x183509CC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3509C80", Offset = "0x3508A80", VA = "0x183509C80", Slot = "4")]
	private IEnumerator<NPDABACFLDM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class FHMPFLCEOEJ<T> : MILJNGODHBE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x37C5D20", Offset = "0x37C4B20", VA = "0x1837C5D20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x37C5DB0", Offset = "0x37C4BB0", VA = "0x1837C5DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x31C9B20", Offset = "0x31C8920", VA = "0x1831C9B20")]
	public FHMPFLCEOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	internal class CleanupRigidbodyExImpl : MILJNGODHBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x34FF120", Offset = "0x34FDF20", VA = "0x1834FF120", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x34FF1C0", Offset = "0x34FDFC0", VA = "0x1834FF1C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class NPHEHGEAMII : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery BPNFEGGGKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2F07AD0", Offset = "0x2F068D0", VA = "0x182F07AD0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2F07A00", Offset = "0x2F06800", VA = "0x182F07A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2F07A90", Offset = "0x2F06890", VA = "0x182F07A90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public NPHEHGEAMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal class NNPHOJHNHIM : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService ONMBPLEPNKE;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2F07020", Offset = "0x2F05E20", VA = "0x182F07020", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2F06FB0", Offset = "0x2F05DB0", VA = "0x182F06FB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public NNPHOJHNHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService AGNCLNMMDFI;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x350DBA0", Offset = "0x350C9A0", VA = "0x18350DBA0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x350D6F0", Offset = "0x350C4F0", VA = "0x18350D6F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x350D780", Offset = "0x350C580", VA = "0x18350D780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	[IHOFDNBJLIN(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<BAIGIFBNIFD>> PFLNNONBGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3508860", Offset = "0x3507660", VA = "0x183508860", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x3508210", Offset = "0x3507010", VA = "0x183508210")]
		public void DAGDOJLIMAD(NativeListAsync<BAIGIFBNIFD> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x35083F0", Offset = "0x35071F0", VA = "0x1835083F0")]
		public void FPDMPMBOOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x3508280", Offset = "0x3507080", VA = "0x183508280", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3508900", Offset = "0x3507700", VA = "0x183508900")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[IHOFDNBJLIN(typeof(LGGDNINFBGJ), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public class PhysicsService : OMEPFIBEFCP, GLCKJEOBJPN, LGGDNINFBGJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly JFPIEAPAMJM IIPLGJBKFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager OFPCNLPKKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private DPDPICMJPAD HOPEBHNKJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService NANMPEAOEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::GEDNEEKEDFO<DAKOKJOLEOO> GHIOLBEEBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<IMKMJFJEHIJ, DAKOKJOLEOO> MJPCCCFGMHO
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2F1C450", Offset = "0x2F1B250", VA = "0x182F1C450", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2F1C5B0", Offset = "0x2F1B3B0", VA = "0x182F1C5B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C650", Offset = "0x2F1B450", VA = "0x182F1C650", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C1B0", Offset = "0x2F1AFB0", VA = "0x182F1C1B0", Slot = "5")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BF80", Offset = "0x2F1AD80", VA = "0x182F1BF80", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C0E0", Offset = "0x2F1AEE0", VA = "0x182F1C0E0", Slot = "8")]
		public bool FNOICPDMJKK(IMKMJFJEHIJ NAKKFJMFOAE, out Collider KAGGBODOCIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C4F0", Offset = "0x2F1B2F0", VA = "0x182F1C4F0")]
		private void NJCHMPLLGCD(Entity JCNIDEIPPBD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OMHFAAGAIBL, KNIHKHKCMFB KMCDOHPNFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BEC0", Offset = "0x2F1ACC0", VA = "0x182F1BEC0", Slot = "9")]
		public void CMAKHIDGIGD(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[IHOFDNBJLIN(typeof(EKNANNBDCIH), new string[] { })]
	public class RbexService : OMEPFIBEFCP, EKNANNBDCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private FJMONGKKEFI FMKOGDOKBBJ;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2F22690", Offset = "0x2F21490", VA = "0x182F22690")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2F24BC0", Offset = "0x2F239C0", VA = "0x182F24BC0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2F24520", Offset = "0x2F23320", VA = "0x182F24520", Slot = "6")]
		public GJBJJKLJFJI OBNOJBPEDIO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2F23210", Offset = "0x2F22010", VA = "0x182F23210", Slot = "5")]
		public void KCNBBMHIOEH(IMKMJFJEHIJ NAKKFJMFOAE, GJBJJKLJFJI NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2F23550", Offset = "0x2F22350", VA = "0x182F23550", Slot = "34")]
		public CollisionDetectionMode KOOCDEMCGFJ(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2F228F0", Offset = "0x2F216F0", VA = "0x182F228F0", Slot = "35")]
		public void GGGGIEMBCKE(IMKMJFJEHIJ NAKKFJMFOAE, CollisionDetectionMode NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2F21C20", Offset = "0x2F20A20", VA = "0x182F21C20", Slot = "36")]
		public PHMDEGBGMEP BPCAFKMFOCB(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(PHMDEGBGMEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2F21EB0", Offset = "0x2F20CB0", VA = "0x182F21EB0", Slot = "37")]
		public void DAEJJDOGKOF(IMKMJFJEHIJ NAKKFJMFOAE, PHMDEGBGMEP NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2F21A10", Offset = "0x2F20810", VA = "0x182F21A10", Slot = "38")]
		public bool ALKHMBKCGEG(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2F230B0", Offset = "0x2F21EB0", VA = "0x182F230B0", Slot = "39")]
		public void JGCDMJCDKAL(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2F23440", Offset = "0x2F22240", VA = "0x182F23440", Slot = "40")]
		public IMKMJFJEHIJ KKMEGKLDKFD(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2F225B0", Offset = "0x2F213B0", VA = "0x182F225B0", Slot = "41")]
		public void FGPEIDKNALP(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2F22490", Offset = "0x2F21290", VA = "0x182F22490", Slot = "42")]
		public IMKMJFJEHIJ FANBPIBOJLO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2F21E30", Offset = "0x2F20C30", VA = "0x182F21E30", Slot = "43")]
		public void CNEDMMKBPIO(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2F21F50", Offset = "0x2F20D50", VA = "0x182F21F50", Slot = "7")]
		public void DCMJCJJFMCK(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2F24250", Offset = "0x2F23050", VA = "0x182F24250", Slot = "8")]
		public void NFAGHCDLJNP(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2F23A00", Offset = "0x2F22800", VA = "0x182F23A00", Slot = "9")]
		public int LJKMOLNNOHK(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2F22960", Offset = "0x2F21760", VA = "0x182F22960", Slot = "10")]
		public IMKMJFJEHIJ GIJAHIEFAEE(IMKMJFJEHIJ NAKKFJMFOAE, int CPOAAGLEIPE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2F23120", Offset = "0x2F21F20", VA = "0x182F23120", Slot = "11")]
		public void JMFPMOMEALN(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2F22C90", Offset = "0x2F21A90", VA = "0x182F22C90", Slot = "12")]
		public void IBBGLKCDNEB(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN, IMKMJFJEHIJ NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2F22060", Offset = "0x2F20E60", VA = "0x182F22060", Slot = "13")]
		public void DDJPIIFCLED(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2F22150", Offset = "0x2F20F50", VA = "0x182F22150", Slot = "14")]
		public bool EHMFNGAGPLH(IMKMJFJEHIJ NAKKFJMFOAE, out IMKMJFJEHIJ NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2F233C0", Offset = "0x2F221C0", VA = "0x182F233C0", Slot = "15")]
		public void KHHDBDMFHBM(IMKMJFJEHIJ NAKKFJMFOAE, float3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2F23F90", Offset = "0x2F22D90", VA = "0x182F23F90", Slot = "16")]
		public bool NDCFGKPEDGH(IMKMJFJEHIJ NAKKFJMFOAE, out float3 NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2F22E50", Offset = "0x2F21C50", VA = "0x182F22E50", Slot = "17")]
		public void ICKKANAGLDP(IMKMJFJEHIJ NAKKFJMFOAE, float3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2F243C0", Offset = "0x2F231C0", VA = "0x182F243C0", Slot = "18")]
		public bool NNBLFPICLJM(IMKMJFJEHIJ NAKKFJMFOAE, out float3 NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2F235B0", Offset = "0x2F223B0", VA = "0x182F235B0", Slot = "26")]
		public float3 KPMGFFBHICG(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2F222B0", Offset = "0x2F210B0", VA = "0x182F222B0", Slot = "27")]
		public void EILFHKFGLGP(IMKMJFJEHIJ NAKKFJMFOAE, float3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2F22B50", Offset = "0x2F21950", VA = "0x182F22B50", Slot = "28")]
		public float HHIFBJGHKBF(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2F22420", Offset = "0x2F21220", VA = "0x182F22420", Slot = "29")]
		public void ENLGJFLNHCE(IMKMJFJEHIJ NAKKFJMFOAE, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2F220F0", Offset = "0x2F20EF0", VA = "0x182F220F0", Slot = "30")]
		public float ECOLBFAFLMK(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2F22A80", Offset = "0x2F21880", VA = "0x182F22A80", Slot = "31")]
		public void GODBLHBGMJM(IMKMJFJEHIJ NAKKFJMFOAE, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2F24CE0", Offset = "0x2F23AE0", VA = "0x182F24CE0", Slot = "32")]
		public bool PNMCDDNKEOA(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2F21930", Offset = "0x2F20730", VA = "0x182F21930", Slot = "33")]
		public void ABAEOAIJJCA(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2F249C0", Offset = "0x2F237C0", VA = "0x182F249C0", Slot = "19")]
		public void OOFKIAOGFHJ(IMKMJFJEHIJ NAKKFJMFOAE, float3 NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2F23E00", Offset = "0x2F22C00", VA = "0x182F23E00", Slot = "20")]
		public bool NAAMGADNPPL(IMKMJFJEHIJ NAKKFJMFOAE, out float3 NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2F21BB0", Offset = "0x2F209B0", VA = "0x182F21BB0", Slot = "21")]
		public void BPAIMMNKAEK(IMKMJFJEHIJ NAKKFJMFOAE, quaternion NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2F24630", Offset = "0x2F23430", VA = "0x182F24630", Slot = "22")]
		public bool ODHJHIPFJPO(IMKMJFJEHIJ NAKKFJMFOAE, out quaternion NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2F23690", Offset = "0x2F22490", VA = "0x182F23690", Slot = "23")]
		public bool LFBBEBCLBLB(IMKMJFJEHIJ NAKKFJMFOAE, out float3 GDFDPHGBNHC, out quaternion OLDCBCKLKEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2F22AF0", Offset = "0x2F218F0", VA = "0x182F22AF0", Slot = "44")]
		public HOMJCDNLJOD HFMBHOIIMOK(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(HOMJCDNLJOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2F24C70", Offset = "0x2F23A70", VA = "0x182F24C70", Slot = "45")]
		public void PNLFBKMKICK(IMKMJFJEHIJ NAKKFJMFOAE, HOMJCDNLJOD NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2F24A40", Offset = "0x2F23840", VA = "0x182F24A40", Slot = "72")]
		public void PBJJPACKCDN(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2F22390", Offset = "0x2F21190", VA = "0x182F22390", Slot = "73")]
		public void EMFKBKFLCPP(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2F22740", Offset = "0x2F21540", VA = "0x182F22740", Slot = "74")]
		public bool GCIANLIAKEA(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2F21CC0", Offset = "0x2F20AC0", VA = "0x182F21CC0", Slot = "81")]
		public void CICCHLOKGIG(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2F22DC0", Offset = "0x2F21BC0", VA = "0x182F22DC0", Slot = "82")]
		public void IBBJAIFCCOO(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2F21A70", Offset = "0x2F20870", VA = "0x182F21A70", Slot = "83")]
		public bool BBOELPKNOCJ(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2F23900", Offset = "0x2F22700", VA = "0x182F23900", Slot = "84")]
		public IEnumerable<object> LFJKGKMJKKO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2F21B50", Offset = "0x2F20950", VA = "0x182F21B50", Slot = "46")]
		public bool BJPALACEALM(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2F22330", Offset = "0x2F21130", VA = "0x182F22330", Slot = "47")]
		public void ELKHKGIIPJA(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2F22F60", Offset = "0x2F21D60", VA = "0x182F22F60", Slot = "48")]
		public bool IKJCBDBODME(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2F22BB0", Offset = "0x2F219B0", VA = "0x182F22BB0", Slot = "49")]
		public void HMOLJFJONBL(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2F21AF0", Offset = "0x2F208F0", VA = "0x182F21AF0", Slot = "50")]
		public bool BGCGHIIOMPB(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2F21D50", Offset = "0x2F20B50", VA = "0x182F21D50", Slot = "51")]
		public void CJDLAGLMBOM(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2F23050", Offset = "0x2F21E50", VA = "0x182F23050", Slot = "52")]
		public RigidbodyConstraints JFMCLDGPNLO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2F219A0", Offset = "0x2F207A0", VA = "0x182F219A0", Slot = "53")]
		public void AKFNBDJNDMJ(IMKMJFJEHIJ NAKKFJMFOAE, RigidbodyConstraints NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2F22630", Offset = "0x2F21430", VA = "0x182F22630", Slot = "54")]
		public float FIKIJAENONN(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2F23B70", Offset = "0x2F22970", VA = "0x182F23B70", Slot = "55")]
		public void MAJINKNGOGB(IMKMJFJEHIJ NAKKFJMFOAE, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2F227C0", Offset = "0x2F215C0", VA = "0x182F227C0", Slot = "56")]
		public float GCJCHOMMLLO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2F21DC0", Offset = "0x2F20BC0", VA = "0x182F21DC0", Slot = "57")]
		public void CKKCENJPCFI(IMKMJFJEHIJ NAKKFJMFOAE, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2F24960", Offset = "0x2F23760", VA = "0x182F24960", Slot = "58")]
		public bool OJJADFHKJHH(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2F24790", Offset = "0x2F23590", VA = "0x182F24790", Slot = "59")]
		public void ODJJPFJHIMM(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2F23630", Offset = "0x2F22430", VA = "0x182F23630", Slot = "60")]
		public bool LDKOHFNAHLN(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2F232C0", Offset = "0x2F220C0", VA = "0x182F232C0", Slot = "61")]
		public void KECFOLFNBKA(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2F24AD0", Offset = "0x2F238D0", VA = "0x182F24AD0", Slot = "62")]
		public int PFIGDPNPOKO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2F22540", Offset = "0x2F21340", VA = "0x182F22540", Slot = "63")]
		public void FDCHEAFCJDG(IMKMJFJEHIJ NAKKFJMFOAE, int NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2F24B30", Offset = "0x2F23930", VA = "0x182F24B30", Slot = "64")]
		public Rigidbody PHBNEMIMCIN(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2F240F0", Offset = "0x2F22EF0", VA = "0x182F240F0", Slot = "65")]
		public void NEJBKIDMCPE(IMKMJFJEHIJ NAKKFJMFOAE, Rigidbody NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2F234C0", Offset = "0x2F222C0", VA = "0x182F234C0", Slot = "75")]
		public void KNJJCMKLKIK(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2F226B0", Offset = "0x2F214B0", VA = "0x182F226B0", Slot = "76")]
		public void GCAOOKGNGMJ(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2F245B0", Offset = "0x2F233B0", VA = "0x182F245B0", Slot = "77")]
		public bool OCBCCEBOPEM(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2F24D40", Offset = "0x2F23B40", VA = "0x182F24D40", Slot = "66")]
		public object PODLHPJIMAD(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2F24800", Offset = "0x2F23600", VA = "0x182F24800", Slot = "67")]
		public void OFJNENCECLP(IMKMJFJEHIJ NAKKFJMFOAE, object NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F22ED0", Offset = "0x2F21CD0", VA = "0x182F22ED0", Slot = "68")]
		public object IKFGKOCOBIP(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F23CA0", Offset = "0x2F22AA0", VA = "0x182F23CA0", Slot = "69")]
		public void MMLFJONBKGA(IMKMJFJEHIJ NAKKFJMFOAE, object NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F23C40", Offset = "0x2F22A40", VA = "0x182F23C40", Slot = "70")]
		public float MICPHFDDHKM(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F22C20", Offset = "0x2F21A20", VA = "0x182F22C20", Slot = "71")]
		public void HPMLJAFDPLE(IMKMJFJEHIJ NAKKFJMFOAE, float NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F23330", Offset = "0x2F22130", VA = "0x182F23330", Slot = "78")]
		public void KGMGDBPICAI(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F22FC0", Offset = "0x2F21DC0", VA = "0x182F22FC0", Slot = "79")]
		public void JAOHCOGBOLK(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F23AF0", Offset = "0x2F228F0", VA = "0x182F23AF0", Slot = "80")]
		public bool LKJAGCPFDNK(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F24360", Offset = "0x2F23160", VA = "0x182F24360", Slot = "24")]
		public void NLGBABBCEDF(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F23BE0", Offset = "0x2F229E0", VA = "0x182F23BE0", Slot = "25")]
		public void MGMDHEKPIOA(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x358FDB0", Offset = "0x358EBB0", VA = "0x18358FDB0")]
		private void ICDNEEGOGLF<T>(IMKMJFJEHIJ NAKKFJMFOAE, bool NLHFEJHKLAH) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x358FD50", Offset = "0x358EB50", VA = "0x18358FD50")]
		private bool FGDPMKCFKIH<T>(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x358FE00", Offset = "0x358EC00", VA = "0x18358FE00")]
		private void IHKCCNMHHEB<T>(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x358EF70", Offset = "0x358DD70", VA = "0x18358EF70")]
		private bool BIEGELDBEJH<TC, TV>(IMKMJFJEHIJ NAKKFJMFOAE, Func<TC, TV> HFEABCHFANG, out TV NLHFEJHKLAH) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x358EEF0", Offset = "0x358DCF0", VA = "0x18358EEF0")]
		private bool BIEGELDBEJH<T>(IMKMJFJEHIJ NAKKFJMFOAE, out T NLHFEJHKLAH) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x358FF20", Offset = "0x358ED20", VA = "0x18358FF20")]
		private T OIIGJEECIIB<T>(IMKMJFJEHIJ NAKKFJMFOAE) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x358F750", Offset = "0x358E550", VA = "0x18358F750")]
		private void CMOKDPCMAON<T>(IMKMJFJEHIJ NAKKFJMFOAE, T NLHFEJHKLAH) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x358F0F0", Offset = "0x358DEF0", VA = "0x18358F0F0")]
		private void CIOOJPACMAJ<T>(IMKMJFJEHIJ NAKKFJMFOAE, T NLHFEJHKLAH) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x358EEF0", Offset = "0x358DCF0", VA = "0x18358EEF0")]
		private bool BDBHLMMFHKP<T>(IMKMJFJEHIJ NAKKFJMFOAE, out T NLHFEJHKLAH) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3590370", Offset = "0x358F170", VA = "0x183590370")]
		private T PPLFGIGAMIC<T>(IMKMJFJEHIJ NAKKFJMFOAE) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x358EEF0", Offset = "0x358DCF0", VA = "0x18358EEF0")]
		private void GLEEGHOHMJI<T>(IMKMJFJEHIJ NAKKFJMFOAE, T NLHFEJHKLAH) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x358FCA0", Offset = "0x358EAA0", VA = "0x18358FCA0")]
		private void FABDCHMCJJK<T>(IMKMJFJEHIJ NAKKFJMFOAE, T NLHFEJHKLAH) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2F23F60", Offset = "0x2F22D60", VA = "0x182F23F60")]
		private IMKMJFJEHIJ NBOAGGNNBEC(Entity JCNIDEIPPBD)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F22820", Offset = "0x2F21620", VA = "0x182F22820")]
		private DynamicBuffer<Entity> GCPOHCCJKJP(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x358FE60", Offset = "0x358EC60", VA = "0x18358FE60")]
		private void MEOFNIAFBEN<T>(IMKMJFJEHIJ NAKKFJMFOAE, object NLHFEJHKLAH, Func<object, T> HFEABCHFANG) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void KKLPLLLGLNM<T>(ref global::FEMGHOFDHBI<T> DOKHJFOLKHN) where T : struct, GLIHFOOKOJB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void KKLPLLLGLNM<TC, TV>(ref global::AHICODAJBCD<TC, TV> DOKHJFOLKHN) where TC : struct, GLIHFOOKOJB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	[IHOFDNBJLIN(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class DFNEEJCCGLL : IEnumerable<GJBJJKLJFJI>, IEnumerable, IEnumerator<GJBJJKLJFJI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private GJBJJKLJFJI <>2__current;

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
			private GJBJJKLJFJI System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public DFNEEJCCGLL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x42F4FC0", Offset = "0x42F3DC0", VA = "0x1842F4FC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x42F4C80", Offset = "0x42F3A80", VA = "0x1842F4C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x42F5040", Offset = "0x42F3E40", VA = "0x1842F5040")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x42F4F80", Offset = "0x42F3D80", VA = "0x1842F4F80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x42F4ED0", Offset = "0x42F3CD0", VA = "0x1842F4ED0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GJBJJKLJFJI> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x42F4ED0", Offset = "0x42F3CD0", VA = "0x1842F4ED0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> LKDELFMLJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2FCFF90", Offset = "0x2FCED90", VA = "0x182FCFF90", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF2C0", Offset = "0x2FCE0C0", VA = "0x182FCF2C0")]
		public void DAGDOJLIMAD(NativeArray<Entity> NMONLDLIICI, bool HFJDBOHNFCL, bool CKBNFDILDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF530", Offset = "0x2FCE330", VA = "0x182FCF530")]
		public void FPDMPMBOOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF740", Offset = "0x2FCE540", VA = "0x182FCF740")]
		private void JEPKAHGEIDH(NativeArray<Entity> NMONLDLIICI, bool HFJDBOHNFCL, bool CKBNFDILDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2FCFF00", Offset = "0x2FCED00", VA = "0x182FCFF00")]
		[IteratorStateMachine(typeof(DFNEEJCCGLL))]
		private IEnumerable<GJBJJKLJFJI> KJCKIPCOLBF(NativeArray<Entity> NMONLDLIICI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF3E0", Offset = "0x2FCE1E0", VA = "0x182FCF3E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2FD0030", Offset = "0x2FCEE30", VA = "0x182FD0030")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[IHOFDNBJLIN(typeof(FKJKMJONNAG), new string[] { })]
public class HPDLMBKBAGE : FKJKMJONNAG, IEnumerable<CPLDKIAEKDJ>, IEnumerable, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[CEFONNIACOK]
	private BCPGEMGIKGA KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> BMALMIHFDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private OBDPNCIHMDI NENIOPMLJLN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0E30", Offset = "0x2FBFC30", VA = "0x182FC0E30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CPLDKIAEKDJ MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0AF0", Offset = "0x2FBF8F0", VA = "0x182FC0AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public CPLDKIAEKDJ MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0AF0", Offset = "0x2FBF8F0", VA = "0x182FC0AF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0AA0", Offset = "0x2FBF8A0", VA = "0x182FC0AA0", Slot = "11")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0E50", Offset = "0x2FBFC50", VA = "0x182FC0E50", Slot = "12")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0B10", Offset = "0x2FBF910", VA = "0x182FC0B10")]
	private void EKNLHMNOELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F230", Offset = "0x2E2E030", VA = "0x182E2F230")]
	private string HINPMCHOIEB(string EOPECGOILOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0710", Offset = "0x2FBF510", VA = "0x182FC0710", Slot = "7")]
	public CPLDKIAEKDJ ACFIHABKNJF(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC07F0", Offset = "0x2FBF5F0", VA = "0x182FC07F0")]
	private bool BBIEECLADFN(Type JANOPLPFDEP, string EOPECGOILOC, out CPLDKIAEKDJ DCLGFFDBANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0ED0", Offset = "0x2FBFCD0", VA = "0x182FC0ED0", Slot = "8")]
	public OJNODEDDEDC PLHOHJEDHBG(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return default(OJNODEDDEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0E10", Offset = "0x2FBFC10", VA = "0x182FC0E10", Slot = "9")]
	public IEnumerator<CPLDKIAEKDJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0E10", Offset = "0x2FBFC10", VA = "0x182FC0E10", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0FE0", Offset = "0x2FBFDE0", VA = "0x182FC0FE0")]
	public HPDLMBKBAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[DefaultMember("Item")]
public interface DLOEKBIBCPN
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABHLBDNBALA(OJNODEDDEDC NEMDNBLCKKH, out int MBCLCCPKDLG);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[IHOFDNBJLIN(typeof(DLOEKBIBCPN), new string[] { })]
public class MINJNIDLPJL : OMEPFIBEFCP, GLCKJEOBJPN, DLOEKBIBCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CEFONNIACOK]
	private PCBBMIOOLHO KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<OJNODEDDEDC, int> ONLNJGFFHME;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x2F02310", Offset = "0x2F01110", VA = "0x182F02310", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F022A0", Offset = "0x2F010A0", VA = "0x182F022A0", Slot = "6")]
	public bool ABHLBDNBALA(OJNODEDDEDC NEMDNBLCKKH, out int MBCLCCPKDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F025F0", Offset = "0x2F013F0", VA = "0x182F025F0", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F02370", Offset = "0x2F01170", VA = "0x182F02370", Slot = "5")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F02380", Offset = "0x2F01180", VA = "0x182F02380")]
	private void NFPCHCCJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F02650", Offset = "0x2F01450", VA = "0x182F02650")]
	public MINJNIDLPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[IHOFDNBJLIN(typeof(PCBBMIOOLHO), new string[] { })]
[DefaultMember("Item")]
public class EOGEFNDFDGP : PCBBMIOOLHO, IEnumerable<ABFPBMDJHKI>, IEnumerable, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, LMJKNNOOLMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[CEFONNIACOK]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[CEFONNIACOK]
	private FKJKMJONNAG JFPJMBHPBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private ABFPBMDJHKI[] CNNGGOPJIIM;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x350EA90", Offset = "0x350D890", VA = "0x18350EA90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ABFPBMDJHKI MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x350E830", Offset = "0x350D630", VA = "0x18350E830", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ABFPBMDJHKI MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x350E830", Offset = "0x350D630", VA = "0x18350E830", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "10")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x350EAA0", Offset = "0x350D8A0", VA = "0x18350EAA0", Slot = "11")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "12")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x350E700", Offset = "0x350D500", VA = "0x18350E700", Slot = "6")]
	public ABFPBMDJHKI ACFIHABKNJF(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x350ED40", Offset = "0x350DB40", VA = "0x18350ED40", Slot = "7")]
	public OJNODEDDEDC PLHOHJEDHBG(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return default(OJNODEDDEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x350E9B0", Offset = "0x350D7B0", VA = "0x18350E9B0", Slot = "8")]
	public IEnumerator<ABFPBMDJHKI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x350EE10", Offset = "0x350DC10", VA = "0x18350EE10", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x266F910", Offset = "0x266E710", VA = "0x18266F910", Slot = "13")]
	public void OENOFEPKBLK<TKey, T>(global::BPLIOBAGCJM<TKey, T> PEJFAKHLGCN, [Optional] object KPEPJOHCOMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x350E870", Offset = "0x350D670", VA = "0x18350E870", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EOGEFNDFDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x350E830", Offset = "0x350D630", VA = "0x18350E830")]
	[CompilerGenerated]
	private ABFPBMDJHKI GDNPMNJLFOA(int MHNCIMAMLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[IHOFDNBJLIN(typeof(HIAEEIHDIIB), new string[] { })]
public class BIJENAHCFMO : HIAEEIHDIIB, IEnumerable<HFFBKOKLMCH>, IEnumerable, OMEPFIBEFCP, GLCKJEOBJPN, LMJKNNOOLMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[CEFONNIACOK]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[CEFONNIACOK]
	private FKJKMJONNAG JFPJMBHPBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private HFFBKOKLMCH[] CNNGGOPJIIM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x34F8850", Offset = "0x34F7650", VA = "0x1834F8850", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HFFBKOKLMCH MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x34F8350", Offset = "0x34F7150", VA = "0x1834F8350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HFFBKOKLMCH MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x34F8350", Offset = "0x34F7150", VA = "0x1834F8350", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x34F88A0", Offset = "0x34F76A0", VA = "0x1834F88A0", Slot = "9")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x34F85F0", Offset = "0x34F73F0", VA = "0x1834F85F0", Slot = "10")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x34F8510", Offset = "0x34F7310", VA = "0x1834F8510")]
	private HFFBKOKLMCH ICCHOHMFFFO(int CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x34F8230", Offset = "0x34F7030", VA = "0x1834F8230", Slot = "6")]
	public HFFBKOKLMCH ACFIHABKNJF(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x34F8910", Offset = "0x34F7710", VA = "0x1834F8910", Slot = "14")]
	public OJNODEDDEDC PLHOHJEDHBG(DHKEKNILOEA MIJBBGDIDLJ)
	{
		return default(OJNODEDDEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x34F8400", Offset = "0x34F7200", VA = "0x1834F8400", Slot = "7")]
	public IEnumerator<HFFBKOKLMCH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x34F8400", Offset = "0x34F7200", VA = "0x1834F8400", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBFC0", Offset = "0x2CBADC0", VA = "0x182CBBFC0", Slot = "11")]
	public void OENOFEPKBLK<TKey, T>(global::BPLIOBAGCJM<TKey, T> PEJFAKHLGCN, [Optional] object KPEPJOHCOMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x34F8360", Offset = "0x34F7160", VA = "0x1834F8360", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BIJENAHCFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x34F8350", Offset = "0x34F7150", VA = "0x1834F8350")]
	[CompilerGenerated]
	private HFFBKOKLMCH GDNPMNJLFOA(int MHNCIMAMLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[IHOFDNBJLIN(typeof(BCPGEMGIKGA), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
internal class BCPGEMGIKGA : OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private FKJKMJONNAG JFPJMBHPBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private HIAEEIHDIIB LGMIBNBPIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private PCBBMIOOLHO FDFBJDJOHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::LJJOMMCCIHN<GGBNGHABEPC> EBDKEFMKHKM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OBDPNCIHMDI BAGPKPOGCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x34F7D60", Offset = "0x34F6B60", VA = "0x1834F7D60", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x34F7C70", Offset = "0x34F6A70", VA = "0x1834F7C70")]
	private void NPNIFBMHOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB85F0", Offset = "0x2CB73F0", VA = "0x182CB85F0")]
	public T AIOKIGDPGAH<T>() where T : GGBNGHABEPC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x34F7A00", Offset = "0x34F6800", VA = "0x1834F7A00")]
	public CPLDKIAEKDJ ACMAKBLILAM(DHKEKNILOEA EOPECGOILOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::GEDNEEKEDFO<T> ACMAKBLILAM<T>(DHKEKNILOEA EOPECGOILOC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x34F7AD0", Offset = "0x34F68D0", VA = "0x1834F7AD0")]
	public HFFBKOKLMCH DICMIBCPEHK(DHKEKNILOEA EOPECGOILOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2CB8620", Offset = "0x2CB7420", VA = "0x182CB8620")]
	public global::FKLAAKHFBCC<T> DICMIBCPEHK<T>(DHKEKNILOEA EOPECGOILOC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x34F7BA0", Offset = "0x34F69A0", VA = "0x1834F7BA0")]
	public ABFPBMDJHKI EBAEJCGINBD(DHKEKNILOEA EOPECGOILOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::OENAJOMCEIO<T> EBAEJCGINBD<T>(DHKEKNILOEA EOPECGOILOC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BCPGEMGIKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class EFMPCIMNFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2FB3780", Offset = "0x2FB2580", VA = "0x182FB3780")]
	public static global::GEDNEEKEDFO<T> ACMAKBLILAM<T>(this BCPGEMGIKGA IKCMBGMJLFD, global::GCBCNLLOIDF<T> EOPECGOILOC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::FKLAAKHFBCC<T> DICMIBCPEHK<T>(this BCPGEMGIKGA IKCMBGMJLFD, global::GCBCNLLOIDF<T> EOPECGOILOC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::OENAJOMCEIO<T> EBAEJCGINBD<T>(this BCPGEMGIKGA IKCMBGMJLFD, global::GCBCNLLOIDF<T> EOPECGOILOC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[IHOFDNBJLIN(typeof(FMIBKDAOKJK), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
public class FMIBKDAOKJK : OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private JCNNKENHPEL LGKCMFHIBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private OJNODEDDEDC[] AFBKGBNHFLP;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9E70", Offset = "0x2FB8C70", VA = "0x182FB9E70", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9D50", Offset = "0x2FB8B50", VA = "0x182FB9D50")]
	public void FFHIOLECNCL(BDCMCEOAOGF CONHLPJBCJE, bool KKFENDOGFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FMIBKDAOKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[IHOFDNBJLIN(typeof(GGLAJINKDBI), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
public sealed class GGLAJINKDBI : OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class NACGDGDILNK : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
		[DebuggerHidden]
		public NACGDGDILNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x42FCAA0", Offset = "0x42FB8A0", VA = "0x1842FCAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x42FC6F0", Offset = "0x42FB4F0", VA = "0x1842FC6F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x42FCB20", Offset = "0x42FB920", VA = "0x1842FCB20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x42FCA60", Offset = "0x42FB860", VA = "0x1842FCA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x42FC9D0", Offset = "0x42FB7D0", VA = "0x1842FC9D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x42FC9D0", Offset = "0x42FB7D0", VA = "0x1842FC9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string EHCBHBAHBMN = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, MEGGFKEIKBC> MDMDLDCEJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> IALGJLMEMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> EDGDLJOHDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private HIAEEIHDIIB KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private OHOMOGIIAEB HPEJLCLAJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private LOOMEBBKBLB OHIOGOMEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::EEMMAJNELDH<MEGGFKEIKBC> OGCIJKDONBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject KDKGCOBMFOO;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE270", Offset = "0x2FBD070", VA = "0x182FBE270", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2FBDFE0", Offset = "0x2FBCDE0", VA = "0x182FBDFE0", Slot = "5")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD120", Offset = "0x2FBBF20", VA = "0x182FBD120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE210", Offset = "0x2FBD010", VA = "0x182FBE210")]
	private void MGMPMIMJBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCCF0", Offset = "0x2FBBAF0", VA = "0x182FBCCF0")]
	internal void DAGHKNCBILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2FBDA70", Offset = "0x2FBC870", VA = "0x182FBDA70")]
	private void GAGILHENJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD2C0", Offset = "0x2FBC0C0", VA = "0x182FBD2C0")]
	private void EFMBFPDJNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE220", Offset = "0x2FBD020", VA = "0x182FBE220")]
	[IteratorStateMachine(typeof(NACGDGDILNK))]
	private IEnumerable<RRCustomPropTag> NHBOJGNAFCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD410", Offset = "0x2FBC210", VA = "0x182FBD410")]
	private void FJBJMBOGAKG(IMKMJFJEHIJ NAKKFJMFOAE, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCBB0", Offset = "0x2FBB9B0", VA = "0x182FBCBB0")]
	private void CBFNCDGCFPB(SerializableGuid LAJNKLHJFND, GameObject AAMBGNNHMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2FBDC50", Offset = "0x2FBCA50", VA = "0x182FBDC50")]
	private void KAJJMHFOJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD890", Offset = "0x2FBC690", VA = "0x182FBD890")]
	private bool FPDGKAENNJM(MEGGFKEIKBC LBHPHCGLAPK, Transform AABHIBJPKOH, out GameObject JKPACBEDIJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD3C0", Offset = "0x2FBC1C0", VA = "0x182FBD3C0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE340", Offset = "0x2FBD140", VA = "0x182FBE340")]
	public GGLAJINKDBI()
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
		public SerializableGuid JBEAGOHGACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2F21840", Offset = "0x2F20640", VA = "0x182F21840")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[IHOFDNBJLIN(typeof(KELIBFAGBMD), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
public class KELIBFAGBMD : OMEPFIBEFCP
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string MLBNCOEMECP = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService JKMDIALCHLK;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCB70", Offset = "0x2FCB970", VA = "0x182FCCB70", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KELIBFAGBMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[IHOFDNBJLIN(typeof(ODOJLIOPOBD), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
public class ODOJLIOPOBD : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[CEFONNIACOK]
	private EnableComponentSystemsInScope KLLLOBFFONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[CEFONNIACOK]
	private SceneService JKMDIALCHLK;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2F07F20", Offset = "0x2F06D20", VA = "0x182F07F20", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2F07EB0", Offset = "0x2F06CB0", VA = "0x182F07EB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2F07E90", Offset = "0x2F06C90", VA = "0x182F07E90")]
	private void DDJKINEDHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2F07EF0", Offset = "0x2F06CF0", VA = "0x182F07EF0")]
	private void OONNFBOELKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ODOJLIOPOBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[IHOFDNBJLIN(typeof(HNBHMAHMNDN), new string[] { })]
public class LDKHPMNEKHI : OMEPFIBEFCP, GLCKJEOBJPN, HNBHMAHMNDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private HBOFDJIDNOO DNJLLPNDOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private GEIDDPKLKIB OLEAPCHOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService NANMPEAOEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem FFGAFIAFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int JBDKBKDBAOO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool HACMLPKIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1810", Offset = "0x2FD0610", VA = "0x182FD1810", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public IMKMJFJEHIJ BDGABILJKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2FD2520", Offset = "0x2FD1320", VA = "0x182FD2520", Slot = "9")]
		get
		{
			return default(IMKMJFJEHIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1F40", Offset = "0x2FD0D40", VA = "0x182FD1F40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HGGBOIBCHBA JBONHKAKMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1CE0", Offset = "0x2FD0AE0", VA = "0x182FD1CE0", Slot = "11")]
		get
		{
			return default(HGGBOIBCHBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1F40", Offset = "0x2FD0D40", VA = "0x182FD1F40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HGGBOIBCHBA HLOPPHBDGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2FD17C0", Offset = "0x2FD05C0", VA = "0x182FD17C0", Slot = "13")]
		get
		{
			return default(HGGBOIBCHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint DGLBFHOMLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2FD1D30", Offset = "0x2FD0B30", VA = "0x182FD1D30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HIAHHACBIMC ENPLJCHABLD
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2FD18F0", Offset = "0x2FD06F0", VA = "0x182FD18F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2FD2480", Offset = "0x2FD1280", VA = "0x182FD2480", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2560", Offset = "0x2FD1360", VA = "0x182FD2560", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2FD21E0", Offset = "0x2FD0FE0", VA = "0x182FD21E0", Slot = "5")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1990", Offset = "0x2FD0790", VA = "0x182FD1990", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1FE0", Offset = "0x2FD0DE0", VA = "0x182FD1FE0")]
	private void JJHMDEOOMDG(Entity JCNIDEIPPBD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OMHFAAGAIBL, KNIHKHKCMFB KMCDOHPNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1A40", Offset = "0x2FD0840", VA = "0x182FD1A40", Slot = "14")]
	public IMKMJFJEHIJ EJCADAELLDF(IMKMJFJEHIJ ABKMOKFEPEA, IMKMJFJEHIJ PCFJLKDJIEJ)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2380", Offset = "0x2FD1180", VA = "0x182FD2380", Slot = "15")]
	public bool LDLIMOIODDC(IMKMJFJEHIJ ABKMOKFEPEA, IMKMJFJEHIJ PCFJLKDJIEJ, out IMKMJFJEHIJ NENMNHLIAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1B50", Offset = "0x2FD0950", VA = "0x182FD1B50", Slot = "16")]
	public void FDNNLMFDKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1850", Offset = "0x2FD0650", VA = "0x182FD1850", Slot = "17")]
	public void CDNNMHOEMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1DE0", Offset = "0x2FD0BE0", VA = "0x182FD1DE0", Slot = "18")]
	public bool HNBNJKHALNB(IMKMJFJEHIJ INOJNNAPINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1F40", Offset = "0x2FD0D40", VA = "0x182FD1F40")]
	private void NNGEEIGHCEC(IMKMJFJEHIJ IGDCADCJHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LDKHPMNEKHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[IHOFDNBJLIN(typeof(KFEPKLKEFHI), new string[] { })]
public class ALKFPFFLBHA : OMEPFIBEFCP, KFEPKLKEFHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x34F5F40", Offset = "0x34F4D40", VA = "0x1834F5F40", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x34F5ED0", Offset = "0x34F4CD0", VA = "0x1834F5ED0", Slot = "5")]
	public void BILJDNPINHB(IMKMJFJEHIJ LNCGECBHMHD, bool NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x26366D0", Offset = "0x26354D0", VA = "0x1826366D0")]
	private void NIPKJFNBLBF<T>(IMKMJFJEHIJ LNCGECBHMHD, bool NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ALKFPFFLBHA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[IHOFDNBJLIN(typeof(OCCBDFCJBCE), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.RenderEffects)]
	public class SelectionService : OMEPFIBEFCP, OCCBDFCJBCE
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager OFPCNLPKKAK;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x327E180", Offset = "0x327CF80", VA = "0x18327E180", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x327E110", Offset = "0x327CF10", VA = "0x18327E110", Slot = "5")]
		public void MHMFJHIGDKA(IMKMJFJEHIJ LNCGECBHMHD, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x327E0A0", Offset = "0x327CEA0", VA = "0x18327E0A0", Slot = "6")]
		public void IDEGCAPPENK(IMKMJFJEHIJ LNCGECBHMHD, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x26366D0", Offset = "0x26354D0", VA = "0x1826366D0")]
		private void NIPKJFNBLBF<T>(IMKMJFJEHIJ LNCGECBHMHD, bool NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
[IHOFDNBJLIN(typeof(BLJIOMMNMFL), new string[] { })]
internal sealed class BLJIOMMNMFL : OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[CEFONNIACOK]
	private ObjectEmbodimentService BNOABMBMCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[CEFONNIACOK]
	private CIHNJOKIFOM JNAMKKKCPOF;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x34F9290", Offset = "0x34F8090", VA = "0x1834F9290", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BLJIOMMNMFL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	[IHOFDNBJLIN(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : OMEPFIBEFCP, BJGLINLPDPK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly JFPIEAPAMJM ALNODAEDDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[CEFONNIACOK]
		private PFJMLCCOCEN BPPPDOJBHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[CEFONNIACOK]
		private SerializationService HPEJLCLAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[CEFONNIACOK]
		private DHLEDJLMPCL MIABCNNFJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[CEFONNIACOK]
		private DebugWorldsService PGGJGAMHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[CEFONNIACOK]
		private BulkInstantiateSceneObjectService NGFCPMFCFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private AACHPGDKAKL PIMEDEKHCHH;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private FPACKJBANFG KMFBHJCCJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x98D410", Offset = "0x98C210", VA = "0x18098D410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x3293300", Offset = "0x3292100", VA = "0x183293300", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL MJBLAAMKPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x3292870", Offset = "0x3291670", VA = "0x183292870", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x3293030", Offset = "0x3291E30", VA = "0x183293030", Slot = "6")]
		public bool LCBGEEBPBFP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x3292850", Offset = "0x3291650", VA = "0x183292850", Slot = "7")]
		public bool DCNDPLOHEIC(IEnumerable<CEJNCBODCBD> HLMMLGBNPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3292BA0", Offset = "0x32919A0", VA = "0x183292BA0", Slot = "5")]
		public ByteString KMECCADFFHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3292B80", Offset = "0x3291980", VA = "0x183292B80")]
		private void KKCCNIBLJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3293190", Offset = "0x3291F90", VA = "0x183293190")]
		private void LOOFHAINJIM(NMIDBELFOCE HICKLGICLEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3292320", Offset = "0x3291120", VA = "0x183292320")]
		private void APIGIIENFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x32928A0", Offset = "0x32916A0", VA = "0x1832928A0")]
		private void HGIBEBAFAKP(DEKIJBAJIKE HICKLGICLEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x3292800", Offset = "0x3291600", VA = "0x183292800", Slot = "8")]
		public void CMDOKGNAEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3293260", Offset = "0x3292060", VA = "0x183293260")]
		private NMIDBELFOCE NCHHMPOJIIL(EntityManager CAIPFEPMOOI, EntityManager EIKNGLIFFBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[IHOFDNBJLIN(typeof(JFNKEAHHGDB), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
public class JFNKEAHHGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<IEAEMGCPMCM, string> JFIEAHBGPCJ;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8A10", Offset = "0x2FC7810", VA = "0x182FC8A10")]
	public GameObject CBNPLBANDLC(IEAEMGCPMCM HAGLMDCKBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8AE0", Offset = "0x2FC78E0", VA = "0x182FC8AE0")]
	public JFNKEAHHGDB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(TimeService), new string[] { })]
	public class TimeService : FEBFHBLLFPI, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[CEFONNIACOK]
		private SingletonComponentService CEALJEMJGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool HCHJAJFGPGF;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData EOILNLNFDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x3285AF0", Offset = "0x32848F0", VA = "0x183285AF0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x32859B0", Offset = "0x32847B0", VA = "0x1832859B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FMEJLEMFLIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x7D2430", Offset = "0x7D1230", VA = "0x1807D2430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA40120", Offset = "0xA3EF20", VA = "0x180A40120", Slot = "4")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x3285B60", Offset = "0x3284960", VA = "0x183285B60", Slot = "5")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x3285A30", Offset = "0x3284830", VA = "0x183285A30")]
		public void KPLDPGJHGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	[IHOFDNBJLIN(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private OKNLNFBIJGH AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::GEDNEEKEDFO<Entity> AABHIBJPKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService BDIHCGGPFJK;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x3281E40", Offset = "0x3280C40", VA = "0x183281E40", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3281D10", Offset = "0x3280B10", VA = "0x183281D10", Slot = "5")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3281B30", Offset = "0x3280930", VA = "0x183281B30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3281BD0", Offset = "0x32809D0", VA = "0x183281BD0")]
		private void HDKEFBMPFBM(Entity JCNIDEIPPBD, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[IDOCBBAEIFB(JHEANMHFGAO.Services)]
	[IHOFDNBJLIN(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[CEFONNIACOK]
		private LFIGBHNMABJ INLFOKCKKHD;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private LLJGCKODBAN AEBGJDIENFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x2FB4B40", Offset = "0x2FB3940", VA = "0x182FB4B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private HFNPNHJJGJF OLNOJKBCLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x2FB4AF0", Offset = "0x2FB38F0", VA = "0x182FB4AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4B90", Offset = "0x2FB3990", VA = "0x182FB4B90", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4AD0", Offset = "0x2FB38D0", VA = "0x182FB4AD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[IHOFDNBJLIN(typeof(NNENOKBACOO), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
public class NNENOKBACOO : HPIGFHAGGMG, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class LIJMNMEFCKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AACHPGDKAKL services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LIJMNMEFCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x42FC060", Offset = "0x42FAE60", VA = "0x1842FC060")]
		internal void <InitReferences>b__0(OMEPFIBEFCP svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JBKDKALOOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AACHPGDKAKL services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public JBKDKALOOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x42FAF90", Offset = "0x42F9D90", VA = "0x1842FAF90")]
		internal void <InitExternal>b__0(GLCKJEOBJPN svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[CEFONNIACOK]
	private CIHNJOKIFOM JNAMKKKCPOF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public OLNJDKMAFEA GFDJNCCCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xCF6040", Offset = "0xCF4E40", VA = "0x180CF6040", Slot = "4")]
		get
		{
			return default(OLNJDKMAFEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private PANKPCMPIOD LKMGEGIOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2F06AF0", Offset = "0x2F058F0", VA = "0x182F06AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2F06DA0", Offset = "0x2F05BA0", VA = "0x182F06DA0", Slot = "5")]
	public void GEMGHIFELBL(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2F06B40", Offset = "0x2F05940", VA = "0x182F06B40", Slot = "6")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2F06ED0", Offset = "0x2F05CD0", VA = "0x182F06ED0", Slot = "7")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2F06DF0", Offset = "0x2F05BF0", VA = "0x182F06DF0", Slot = "8")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2F06C70", Offset = "0x2F05A70", VA = "0x182F06C70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x315C510", Offset = "0x315B310", VA = "0x18315C510")]
	private void PFLHBMADADC<T>(Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NNENOKBACOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class GJFGNIEAJCP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> JMHMBGJOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> IHLLHGOCNMO;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To MJCFBIMFFNK
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
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public GJFGNIEAJCP(Func<From, To> BFDJLDFAEFL, Func<To, From> JMHMBGJOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] ECEFKNGMHII, int NKBOPBAMDKF)
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
	public int IndexOf(To CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int CPOAAGLEIPE, To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
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
public class HGFDPLGAGJL<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> JMHMBGJOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A8C7F0", Offset = "0x3A8B5F0", VA = "0x183A8C7F0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A8C850", Offset = "0x3A8B650", VA = "0x183A8C850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A8C7C0", Offset = "0x3A8B5C0", VA = "0x183A8C7C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2990", Offset = "0x2EF1790", VA = "0x182EF2990")]
	public HGFDPLGAGJL(Func<From, To> BFDJLDFAEFL, Func<To, From> JMHMBGJOCJM, bool DCLDMIHOKIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C410", Offset = "0x3A8B210", VA = "0x183A8C410", Slot = "11")]
	public void Add(To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x31876E0", Offset = "0x31864E0", VA = "0x1831876E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C470", Offset = "0x3A8B270", VA = "0x183A8C470", Slot = "13")]
	public bool Contains(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C4D0", Offset = "0x3A8B2D0", VA = "0x183A8C4D0", Slot = "14")]
	public void CopyTo(To[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C5E0", Offset = "0x3A8B3E0", VA = "0x183A8C5E0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C650", Offset = "0x3A8B450", VA = "0x183A8C650", Slot = "6")]
	public int IndexOf(To CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C6B0", Offset = "0x3A8B4B0", VA = "0x183A8C6B0", Slot = "7")]
	public void Insert(int CPOAAGLEIPE, To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C760", Offset = "0x3A8B560", VA = "0x183A8C760", Slot = "15")]
	public bool Remove(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C730", Offset = "0x3A8B530", VA = "0x183A8C730", Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F080", Offset = "0x2F4DE80", VA = "0x182F4F080", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class CMBGHMJNMFB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> JMHMBGJOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> ECEFKNGMHII;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x3586AE0", Offset = "0x35858E0", VA = "0x183586AE0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x3586B30", Offset = "0x3585930", VA = "0x183586B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3586AA0", Offset = "0x35858A0", VA = "0x183586AA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B11300", Offset = "0x2B10100", VA = "0x182B11300")]
	public CMBGHMJNMFB(Func<From, To> BFDJLDFAEFL, Func<To, From> JMHMBGJOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x35866B0", Offset = "0x35854B0", VA = "0x1835866B0", Slot = "11")]
	public void Add(To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x35866F0", Offset = "0x35854F0", VA = "0x1835866F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3586730", Offset = "0x3585530", VA = "0x183586730", Slot = "13")]
	public bool Contains(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x35867F0", Offset = "0x35855F0", VA = "0x1835867F0", Slot = "14")]
	public void CopyTo(To[] ECEFKNGMHII, int NKBOPBAMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x35868B0", Offset = "0x35856B0", VA = "0x1835868B0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3586970", Offset = "0x3585770", VA = "0x183586970", Slot = "6")]
	public int IndexOf(To CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x35869E0", Offset = "0x35857E0", VA = "0x1835869E0", Slot = "7")]
	public void Insert(int CPOAAGLEIPE, To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3586A60", Offset = "0x3585860", VA = "0x183586A60", Slot = "15")]
	public bool Remove(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x3586A20", Offset = "0x3585820", VA = "0x183586A20", Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A99E90", Offset = "0x2A98C90", VA = "0x182A99E90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class PGNCGFKAPCE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> BFDJLDFAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> JMHMBGJOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To MJCFBIMFFNK
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
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool MIBACEBEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public PGNCGFKAPCE(Func<From, To> BFDJLDFAEFL, Func<To, From> JMHMBGJOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] ECEFKNGMHII, int NKBOPBAMDKF)
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
	public int IndexOf(To CDHGABCIPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int CPOAAGLEIPE, To CDHGABCIPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To CDHGABCIPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int CPOAAGLEIPE)
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
public static class AFICONGHCMA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string KJFGGCKNGKH = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string KFCPKKOPHIH = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string MBJGHLAKEND = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string AMGLMGDGFBM = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string CNAKCODHCHJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string DHPFGKMBGPM = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string FACOCNGKOCD = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string ABBMDHJKFOB = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class JHPNHODGIDF
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class KCBICDPOBJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AACHPGDKAKL services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KCBICDPOBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x42FBA20", Offset = "0x42FA820", VA = "0x1842FBA20")]
		internal void <InitServices>b__1(OMEPFIBEFCP svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x42FBA80", Offset = "0x42FA880", VA = "0x1842FBA80")]
		internal void <InitServices>b__2(GLCKJEOBJPN svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9AB0", Offset = "0x2FC88B0", VA = "0x182FC9AB0")]
	public static void LDODGHMLHOD(this PANKPCMPIOD PGJEGNBAENG, AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CBA0", Offset = "0x2D4B9A0", VA = "0x182D4CBA0")]
	public static void PFLHBMADADC<T>(this PANKPCMPIOD PGJEGNBAENG, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CA00", Offset = "0x2D4B800", VA = "0x182D4CA00")]
	public static void KDMOMBDOKDP<T>(this PANKPCMPIOD PGJEGNBAENG, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C2C0", Offset = "0x2D4B0C0", VA = "0x182D4C2C0")]
	public static void DOAFJJAIOKO<T>(this PANKPCMPIOD PGJEGNBAENG, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C620", Offset = "0x2D4B420", VA = "0x182D4C620")]
	public static void GFEKDPDEGHI<T>(this PANKPCMPIOD PGJEGNBAENG, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C470", Offset = "0x2D4B270", VA = "0x182D4C470")]
	public static void FOMIHBBOFEM<T>(this PANKPCMPIOD PGJEGNBAENG, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C890", Offset = "0x2D4B690", VA = "0x182D4C890")]
	public static void KDMOMBDOKDP<T>(IEnumerable<ComponentSystemBase> GINNLCCNCAC, Action<T> MLKLJHDBDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C7D0", Offset = "0x2D4B5D0", VA = "0x182D4C7D0")]
	private static void IPBJAONGLLF<T>(object HDNGIEMACBN, Action<T> MLKLJHDBDNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class FKIOEBEJGAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class OGPLEHNHKCO
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F08EE0", Offset = "0x2F07CE0", VA = "0x182F08EE0")]
	public static void HJOMDIEHILL(ComponentSystemBase HDNGIEMACBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class HNJHNDIAFBC
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool LGJOKLEHNHL<T>(ref T FEIPFLDEPBD, ref T MIECAKFJHNF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MOAKENMPDKO
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class PMJEEFGEHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PMJEEFGEHBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F03B60", Offset = "0x2F02960", VA = "0x182F03B60")]
	public static string ILFGGLMBOMK(Transform GPMKACFJLBP, Transform INOJNNAPINL)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[IDOCBBAEIFB(JHEANMHFGAO.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3280A00", Offset = "0x327F800", VA = "0x183280A00")]
		public static void HAGKABNBGAM(this IMCAFFIABPB PIMEDEKHCHH, GBFMPENIGFN FELMKIDGPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3280900", Offset = "0x327F700", VA = "0x183280900")]
		public static void APCLPOCCPAF(this IMCAFFIABPB PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3280C30", Offset = "0x327FA30", VA = "0x183280C30")]
		public static void HAGKABNBGAM(this IMCAFFIABPB PIMEDEKHCHH, [Optional] string[] DMAEIODNGJP, [Optional] string[] IKCDBMLAMHO, [Optional] string[] GHPDNDGBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3280FF0", Offset = "0x327FDF0", VA = "0x183280FF0")]
		public static void MGOKNFOOHHD(this IMCAFFIABPB PIMEDEKHCHH, params string[] MPJGMJFEFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3280D40", Offset = "0x327FB40", VA = "0x183280D40")]
		public static void IDCBPCEJIOE(this IMCAFFIABPB PIMEDEKHCHH, params string[] MPJGMJFEFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3280DF0", Offset = "0x327FBF0", VA = "0x183280DF0")]
		private static string[] KDIONEGBJIB(GBFMPENIGFN FELMKIDGPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x32810A0", Offset = "0x327FEA0", VA = "0x1832810A0")]
		private static bool MMOOCGPKDFA(GBFMPENIGFN FELMKIDGPKI, out string[] LHLPMKLMGNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0")]
		private static bool KJBKMGNLFCP()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class KFLEOJAAILO : KEKECGOIGFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo CAPGOAECIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] GLNACLILDAP;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDE90", Offset = "0x2FCCC90", VA = "0x182FCDE90")]
	public KFLEOJAAILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action DCHAGMNOHFN();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDE50", Offset = "0x2FCCC50", VA = "0x182FCDE50")]
	public MethodInfo KDOABMBOHFJ(Action KKJDJCJOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDCA0", Offset = "0x2FCCAA0", VA = "0x182FCDCA0", Slot = "4")]
	public void CBFNCDGCFPB(Type MAIOHDHBGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class ELHHABEANFE : KFLEOJAAILO
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum OGHHICAIEOP
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x350E450", Offset = "0x350D250", VA = "0x18350E450", Slot = "5")]
	public override Action DCHAGMNOHFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void CBLKMJMFPNL<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x350E4E0", Offset = "0x350D2E0", VA = "0x18350E4E0")]
	[Preserve]
	public void FJGCHFPFHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F04250", Offset = "0x2F03050", VA = "0x182F04250")]
	protected ELHHABEANFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class NDKGIKKFLPO : KFLEOJAAILO
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2F04130", Offset = "0x2F02F30", VA = "0x182F04130", Slot = "5")]
	public override Action DCHAGMNOHFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IMLGDEJNAAJ<T>() where T : KMDKEJKOJFC;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2F041C0", Offset = "0x2F02FC0", VA = "0x182F041C0")]
	[Preserve]
	public void FJGCHFPFHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2F04250", Offset = "0x2F03050", VA = "0x182F04250")]
	protected NDKGIKKFLPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class ENIACGFCBLO : KFLEOJAAILO
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x350E5E0", Offset = "0x350D3E0", VA = "0x18350E5E0", Slot = "5")]
	public override Action DCHAGMNOHFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void FPDJAALKDOB<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x350E670", Offset = "0x350D470", VA = "0x18350E670")]
	[Preserve]
	public void FJGCHFPFHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2F04250", Offset = "0x2F03050", VA = "0x182F04250")]
	protected ENIACGFCBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class HPNMDFMHLMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1060", Offset = "0x2FBFE60", VA = "0x182FC1060")]
	public static Entity BNFMNCPFIJE(this EntityManager OFPCNLPKKAK)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class JHCCHODPIBL : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2A90170", Offset = "0x2A8EF70", VA = "0x182A90170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x42FB5E0", Offset = "0x42FA3E0", VA = "0x1842FB5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x42F2B80", Offset = "0x42F1980", VA = "0x1842F2B80")]
			[DebuggerHidden]
			public JHCCHODPIBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x42FB410", Offset = "0x42FA210", VA = "0x1842FB410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x42FB5A0", Offset = "0x42FA3A0", VA = "0x1842FB5A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x42FB4F0", Offset = "0x42FA2F0", VA = "0x1842FB4F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x42FB4F0", Offset = "0x42FA2F0", VA = "0x1842FB4F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class BACDBMDPNEF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2A90170", Offset = "0x2A8EF70", VA = "0x182A90170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x42F2A50", Offset = "0x42F1850", VA = "0x1842F2A50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x42F2B80", Offset = "0x42F1980", VA = "0x1842F2B80")]
			[DebuggerHidden]
			public BACDBMDPNEF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x42F2AA0", Offset = "0x42F18A0", VA = "0x1842F2AA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x42F2770", Offset = "0x42F1570", VA = "0x1842F2770", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x42F2B30", Offset = "0x42F1930", VA = "0x1842F2B30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x42F2A10", Offset = "0x42F1810", VA = "0x1842F2A10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x42F2960", Offset = "0x42F1760", VA = "0x1842F2960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x42F2960", Offset = "0x42F1760", VA = "0x1842F2960", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class DHMALJCLCEH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2A90170", Offset = "0x2A8EF70", VA = "0x182A90170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x42F54A0", Offset = "0x42F42A0", VA = "0x1842F54A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x42F2B80", Offset = "0x42F1980", VA = "0x1842F2B80")]
			[DebuggerHidden]
			public DHMALJCLCEH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x42F54F0", Offset = "0x42F42F0", VA = "0x1842F54F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x42F5090", Offset = "0x42F3E90", VA = "0x1842F5090", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x42F55C0", Offset = "0x42F43C0", VA = "0x1842F55C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x42F5610", Offset = "0x42F4410", VA = "0x1842F5610")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x42F5460", Offset = "0x42F4260", VA = "0x1842F5460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x42F53C0", Offset = "0x42F41C0", VA = "0x1842F53C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x42F53C0", Offset = "0x42F41C0", VA = "0x1842F53C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8350", Offset = "0x2FB7150", VA = "0x182FB8350")]
		public static Entity LFEBGMBMHJG(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB73B0", Offset = "0x2FB61B0", VA = "0x182FB73B0")]
		public static DynamicBuffer<ChildrenData> EAKPBKDKIGN(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB79A0", Offset = "0x2FB67A0", VA = "0x182FB79A0")]
		public static DynamicBuffer<ChildrenData> JALFFLFAMPP(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7E10", Offset = "0x2FB6C10", VA = "0x182FB7E10")]
		public static NativeArray<Entity> KDKNGGGODPP(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Allocator HIEJKCFDMDD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8630", Offset = "0x2FB7430", VA = "0x182FB8630")]
		public static bool NJOLCEIMOBF(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Allocator HIEJKCFDMDD, out NativeArray<Entity> DICFMMCJMPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB84D0", Offset = "0x2FB72D0", VA = "0x182FB84D0")]
		public static NativeArray<Entity> NBNMNMOCKHA(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7760", Offset = "0x2FB6560", VA = "0x182FB7760")]
		public static Entity GIJAHIEFAEE(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, int CPOAAGLEIPE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2FB83C0", Offset = "0x2FB71C0", VA = "0x182FB83C0")]
		public static int LJKMOLNNOHK(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7BB0", Offset = "0x2FB69B0", VA = "0x182FB7BB0")]
		public static void JHNKJMCGOEF(NativeArray<Entity> DMDBPDDAOHM, NativeArray<Entity> GJFKHPNECKG, EntityManager OFPCNLPKKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7440", Offset = "0x2FB6240", VA = "0x182FB7440")]
		public static int EPGDIDPLFCO(this EntityManager OFPCNLPKKAK, Entity AABHIBJPKOH, Entity CPAHKPHLOLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7580", Offset = "0x2FB6380", VA = "0x182FB7580")]
		public static bool FMNODEAAPBM(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Entity FPEOKJIPIBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7030", Offset = "0x2FB5E30", VA = "0x182FB7030")]
		public static IEnumerable<Entity> BDMPNKHFGBN(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8040", Offset = "0x2FB6E40", VA = "0x182FB8040")]
		public static bool KMJPAMBDEGI(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Entity CPAHKPHLOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7220", Offset = "0x2FB6020", VA = "0x182FB7220")]
		public static bool DPFODLBBOCH(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Entity ABKMOKFEPEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8730", Offset = "0x2FB7530", VA = "0x182FB8730")]
		public static NativeList<Entity> OFPGEPIEFNM(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, bool KLLDICHECHI = false, Allocator HIEJKCFDMDD = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7A30", Offset = "0x2FB6830", VA = "0x182FB7A30")]
		public static IEnumerable<Entity> JCHDAOHELMN(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7F40", Offset = "0x2FB6D40", VA = "0x182FB7F40")]
		public static Entity KKMEGKLDKFD(this EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB80F0", Offset = "0x2FB6EF0", VA = "0x182FB80F0")]
		public static bool LDLIMOIODDC(this EntityManager OFPCNLPKKAK, Entity ABKMOKFEPEA, Entity PCFJLKDJIEJ, out Entity NENMNHLIAAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB76E0", Offset = "0x2FB64E0", VA = "0x182FB76E0")]
		internal static void FPFBAKJMFOD(EntityManager OFPCNLPKKAK, Entity AABHIBJPKOH, Entity CPAHKPHLOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6F30", Offset = "0x2FB5D30", VA = "0x182FB6F30")]
		internal static void ACEIIMOJPFG(EntityManager OFPCNLPKKAK, Entity AABHIBJPKOH, Entity CPAHKPHLOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2FB74F0", Offset = "0x2FB62F0", VA = "0x182FB74F0")]
		[IteratorStateMachine(typeof(JHCCHODPIBL))]
		private static IEnumerable<Entity> FIDNMEFMIEF(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7890", Offset = "0x2FB6690", VA = "0x182FB7890")]
		[IteratorStateMachine(typeof(BACDBMDPNEF))]
		private static IEnumerable<Entity> HKGDGHJOONO(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7920", Offset = "0x2FB6720", VA = "0x182FB7920")]
		[IteratorStateMachine(typeof(DHMALJCLCEH))]
		private static IEnumerable<Entity> IDBHOJMPHLG(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7140", Offset = "0x2FB5F40", VA = "0x182FB7140")]
		private static bool DFHEMGFNFLM(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Entity FPEOKJIPIBA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[IHOFDNBJLIN(typeof(NMDCIMKFCEN), new string[] { })]
public class DNCELJACFDO : NMDCIMKFCEN, HPIGFHAGGMG, BELKGIBIHCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private AACHPGDKAKL PIMEDEKHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private PFJMLCCOCEN BPPPDOJBHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private AMKKONJMFJF APJIEBMMBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private HBOFDJIDNOO DNJLLPNDOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private OKNLNFBIJGH AGNKGGODJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private LPDKJACLMMI HPEJLCLAJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private LCDLBBFGMKH LPPHPBKBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private HIAEEIHDIIB KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private NEEEMKFPJPC HGENJADDDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private NLHOPPOCDJH JBLAFOGLPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private HNBHMAHMNDN INJKNDGHKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EACEJDIFHIM IHAEDFCLCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private LGGDNINFBGJ KNDHCIOHLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private KFEPKLKEFHI GOJDJCEIGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private OCCBDFCJBCE LOAGBNNGBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private CAAGPBCIJFG IGJJMKAMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private NHOHKFBEOBA KEGKLKBALIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private EKNANNBDCIH FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AACHPGDKAKL KNNIEFOMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public IDJFGKMJFPG GGGDIHGAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CIHNJOKIFOM LKMGEGIOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PFJMLCCOCEN CJGPHEGLOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public AMKKONJMFJF NGGGJBCAGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LMLOCAEKAJL ADKKADHFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HBOFDJIDNOO ACGHEKPJOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public OKNLNFBIJGH HDLBIPNLHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LPDKJACLMMI LIEIAPCKLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x77F2A0", Offset = "0x77E0A0", VA = "0x18077F2A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LCDLBBFGMKH PBPDIFDHPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA40", Offset = "0x7CE840", VA = "0x1807CFA40", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public HIAEEIHDIIB OHNHILBEHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public NEEEMKFPJPC PBCFDNIAJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NLHOPPOCDJH FGFLKLNKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705950", VA = "0x180706B50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HNBHMAHMNDN HONDPGGHJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x73BC80", Offset = "0x73AA80", VA = "0x18073BC80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public EACEJDIFHIM NBDJLKNOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BD0", Offset = "0x7C19D0", VA = "0x1807C2BD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LGGDNINFBGJ BGKDJEIGNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x771990", Offset = "0x770790", VA = "0x180771990", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public KFEPKLKEFHI EJCIAJLMPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x771980", Offset = "0x770780", VA = "0x180771980", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public OCCBDFCJBCE MPGJHOFODNM
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x70D1B0", Offset = "0x70BFB0", VA = "0x18070D1B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public CAAGPBCIJFG MDMMJGANAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C70", Offset = "0x7B0A70", VA = "0x1807B1C70", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public NHOHKFBEOBA LBANADMOMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x702370", Offset = "0x701170", VA = "0x180702370", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public EKNANNBDCIH OLCPPNNCMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x702430", Offset = "0x701230", VA = "0x180702430", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public OLNJDKMAFEA GFDJNCCCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7FC980", Offset = "0x7FB780", VA = "0x1807FC980", Slot = "21")]
		get
		{
			return default(OLNJDKMAFEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x350BC40", Offset = "0x350AA40", VA = "0x18350BC40", Slot = "22")]
	public void GEMGHIFELBL(AACHPGDKAKL MJBLAAMKPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x20CE420", Offset = "0x20CD220", VA = "0x1820CE420", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x350BC20", Offset = "0x350AA20", VA = "0x18350BC20", Slot = "23")]
	public void ENPLJCHABLD(AACHPGDKAKL MJBLAAMKPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DNCELJACFDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class OFHHPBBJAIN : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GCEHKNLLIFP : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public OFHHPBBJAIN <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x42F6EE0", Offset = "0x42F5CE0", VA = "0x1842F6EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public GCEHKNLLIFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x42F6D30", Offset = "0x42F5B30", VA = "0x1842F6D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x42F6EA0", Offset = "0x42F5CA0", VA = "0x1842F6EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong MMPOEFEPMCN = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong BJEPOMGAPLK = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int GDOALNOLOGL = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int JKBACPJLBEK = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int DKNMIBIGAPG = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int NMANJKKOHII = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> IIJPCEBFOFB;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x76DC00", Offset = "0x76CA00", VA = "0x18076DC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int KCECLIHPABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x76DBF0", Offset = "0x76C9F0", VA = "0x18076DBF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FB0", Offset = "0x7B2DB0", VA = "0x1807B3FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2F081B0", Offset = "0x2F06FB0", VA = "0x182F081B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2F084B0", Offset = "0x2F072B0", VA = "0x182F084B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2F08D20", Offset = "0x2F07B20", VA = "0x182F08D20")]
	public OFHHPBBJAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2F08DA0", Offset = "0x2F07BA0", VA = "0x182F08DA0")]
	public OFHHPBBJAIN(int OOBELNNEIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2F080D0", Offset = "0x2F06ED0", VA = "0x182F080D0")]
	public bool BFLFIBDNABK(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2F08990", Offset = "0x2F07790", VA = "0x182F08990")]
	public bool MAMAFBMKEFK(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2F08910", Offset = "0x2F07710", VA = "0x182F08910")]
	public bool KJIDODHKFMI(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2F083A0", Offset = "0x2F071A0", VA = "0x182F083A0")]
	public bool FFNEOGDCCGC(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2F08C90", Offset = "0x2F07A90", VA = "0x182F08C90")]
	public void OPDEOLEOGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2F08660", Offset = "0x2F07460", VA = "0x182F08660")]
	public void JJJMDFHHDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2F08A80", Offset = "0x2F07880", VA = "0x182F08A80")]
	public void NIPKJFNBLBF(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2F082A0", Offset = "0x2F070A0", VA = "0x182F082A0")]
	public void FDAOBHPPNLM(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2F083B0", Offset = "0x2F071B0", VA = "0x182F083B0")]
	public bool GKBGONHPONF(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2F08B70", Offset = "0x2F07970", VA = "0x182F08B70")]
	public void OOLENKOABJK(int JBINMJEHBFH, int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2F08750", Offset = "0x2F07550", VA = "0x182F08750")]
	public void JNEGLGJJOOL(int ILLPDGGOCDH, int GCOJDPEAAEE, int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2F07F90", Offset = "0x2F06D90", VA = "0x182F07F90")]
	public int AHKNMMEAEHA(int PHHDFCFDFMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2F08060", Offset = "0x2F06E60", VA = "0x182F08060")]
	public int AHKNMMEAEHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2F08250", Offset = "0x2F07050", VA = "0x182F08250")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2F08440", Offset = "0x2F07240", VA = "0x182F08440", Slot = "4")]
	[IteratorStateMachine(typeof(GCEHKNLLIFP))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2F08440", Offset = "0x2F07240", VA = "0x182F08440", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class EPDNNPJILPJ<T> : global::KOPOKIGNCLO<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::BNBELMFBMBL<T> EOMLOOPPNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::KJMPGKEHMEA<T> MALIJIGPIHG;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x18DA7B0", Offset = "0x18D95B0", VA = "0x1818DA7B0")]
	public EPDNNPJILPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7CA0", Offset = "0x1FE6AA0", VA = "0x181FE7CA0")]
	public EPDNNPJILPJ(global::BNBELMFBMBL<T> EOMLOOPPNMB, global::KJMPGKEHMEA<T> MALIJIGPIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7960", Offset = "0x1FE6760", VA = "0x181FE7960", Slot = "11")]
	public override T DHABJCANOEO(AIDLDPNCNPK BGJAFFALONI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x1FE75B0", Offset = "0x1FE63B0", VA = "0x181FE75B0", Slot = "12")]
	public override void APDPBGNCGIO(AIDLDPNCNPK BGJAFFALONI, T NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class PKIGDNBMDDF
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x24B0AA0", Offset = "0x24AF8A0", VA = "0x1824B0AA0")]
	public static OJNODEDDEDC CBFNCDGCFPB<T>(this NIBCIDPINPC KELFDPANAFC, global::GCBCNLLOIDF<T> EOPECGOILOC, global::BNBELMFBMBL<T> EOMLOOPPNMB, global::KJMPGKEHMEA<T> MALIJIGPIHG) where T : struct
	{
		return default(OJNODEDDEDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class MBFMFCPJHML<T> : global::EPDNNPJILPJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x35E2BE0", Offset = "0x35E19E0", VA = "0x1835E2BE0")]
	public MBFMFCPJHML(T FEFPPFDPNGK, T PEEJGOJECJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DGDJIFNCHOB<T> : global::KOPOKIGNCLO<T> where T : struct, KMDKEJKOJFC
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2B09FE0", Offset = "0x2B08DE0", VA = "0x182B09FE0", Slot = "11")]
	public override T DHABJCANOEO(AIDLDPNCNPK BGJAFFALONI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2B09F80", Offset = "0x2B08D80", VA = "0x182B09F80", Slot = "12")]
	public override void APDPBGNCGIO(AIDLDPNCNPK BGJAFFALONI, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x2780C20", Offset = "0x277FA20", VA = "0x182780C20")]
	public DGDJIFNCHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class HDFDKHMKJKE : KFEKKDAOOBI
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type PFDGKGEFAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void DHABJCANOEO(AIDLDPNCNPK BGJAFFALONI, in IADENELHJPC NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void APDPBGNCGIO(AIDLDPNCNPK BGJAFFALONI, in KNIHKHKCMFB NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ABOJAHHKNKA(AIDLDPNCNPK BGJAFFALONI, HGLHDIGEBEH LHNPCANBMJO, [Optional] object KPEPJOHCOMD);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected HDFDKHMKJKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class KOPOKIGNCLO<T> : HDFDKHMKJKE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type PFDGKGEFAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2EF4DC0", Offset = "0x2EF3BC0", VA = "0x182EF4DC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T DHABJCANOEO(AIDLDPNCNPK BGJAFFALONI);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void APDPBGNCGIO(AIDLDPNCNPK BGJAFFALONI, T NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x2EF46E0", Offset = "0x2EF34E0", VA = "0x182EF46E0", Slot = "8")]
	public override void DHABJCANOEO(AIDLDPNCNPK BGJAFFALONI, in IADENELHJPC INOJNNAPINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2EF3D00", Offset = "0x2EF2B00", VA = "0x182EF3D00", Slot = "9")]
	public override void APDPBGNCGIO(AIDLDPNCNPK BGJAFFALONI, in KNIHKHKCMFB HOKEJKCPCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2EF3400", Offset = "0x2EF2200", VA = "0x182EF3400", Slot = "10")]
	public override void ABOJAHHKNKA(AIDLDPNCNPK BGJAFFALONI, HGLHDIGEBEH LHNPCANBMJO, object KPEPJOHCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40")]
	protected KOPOKIGNCLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class HHDCPCNHFFB
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class DPDPICIDDNP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class KCBOKDCKHPK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
			public KCBOKDCKHPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB3A0", Offset = "0x2BBA1A0", VA = "0x182BBB3A0")]
			internal void <RegisterFixedString>b__0(AIDLDPNCNPK p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB6D0", Offset = "0x2BBA4D0", VA = "0x182BBB6D0")]
			internal T <RegisterFixedString>b__1(AIDLDPNCNPK p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x42F58E0", Offset = "0x42F46E0", VA = "0x1842F58E0")]
		public static void DHGMIFGIAFN(KAEDKLOMOOC DODHBPGDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0F50", Offset = "0x3DEFD50", VA = "0x183DF0F50")]
		private static void OEHHFKKILHM<T>(KAEDKLOMOOC DODHBPGDFOJ, int PEEJGOJECJH) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0870", Offset = "0x3DEF670", VA = "0x183DF0870")]
		private static void KPONOHPIHOC<T>(AIDLDPNCNPK BDHLMGMJDKP, T PALFKPAOLKL, int PEEJGOJECJH) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0900", Offset = "0x3DEF700", VA = "0x183DF0900")]
		private static T MEAHBOFODND<T>(AIDLDPNCNPK BDHLMGMJDKP, int PEEJGOJECJH) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DPDPICIDDNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BDEKPDMOFOE : ELHHABEANFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private KAEDKLOMOOC DODHBPGDFOJ;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x3DDF230", Offset = "0x3DDE030", VA = "0x183DDF230", Slot = "6")]
		public override void CBLKMJMFPNL<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x42F2E40", Offset = "0x42F1C40", VA = "0x1842F2E40")]
		public static void FFPCBODHNGJ(KAEDKLOMOOC DODHBPGDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x42F2EF0", Offset = "0x42F1CF0", VA = "0x1842F2EF0")]
		public BDEKPDMOFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBECB0", Offset = "0x2FBDAB0", VA = "0x182FBECB0")]
	public static void GOBIPEIBMCP(KAEDKLOMOOC DODHBPGDFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2701190", Offset = "0x26FFF90", VA = "0x182701190")]
	public static void MFEAOJMLELN<T>(KAEDKLOMOOC DODHBPGDFOJ, global::BNBELMFBMBL<T> EOMLOOPPNMB, global::KJMPGKEHMEA<T> MALIJIGPIHG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2701120", Offset = "0x26FFF20", VA = "0x182701120")]
	public static void EACDMHHKMNH<T>(KAEDKLOMOOC AEKMALFGMGM) where T : struct, KMDKEJKOJFC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
public interface KAEDKLOMOOC : global::NECBJHIPAMH<KAEDKLOMOOC>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBFNCDGCFPB(Type MAIOHDHBGKE, KFEKKDAOOBI AEKMALFGMGM);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOMGGBPLIIB(Type MAIOHDHBGKE, out KFEKKDAOOBI AEKMALFGMGM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class CEEGDPNEJGD
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x34FC0E0", Offset = "0x34FAEE0", VA = "0x1834FC0E0")]
	public static void CBFNCDGCFPB(this KAEDKLOMOOC CAEONEDMKLM, KFEKKDAOOBI AEKMALFGMGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[IHOFDNBJLIN(typeof(NIBCIDPINPC), new string[] { })]
public sealed class NFPLKLNKCDL : NIBCIDPINPC, global::NECBJHIPAMH<NIBCIDPINPC>, FEBFHBLLFPI, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<OJNODEDDEDC, KFEKKDAOOBI> DODHBPGDFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private KAEDKLOMOOC NJIEAPMGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private PCBBMIOOLHO KELFDPANAFC;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool CLKALDFFMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F05C10", Offset = "0x2F04A10", VA = "0x182F05C10")]
	public NFPLKLNKCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F05C90", Offset = "0x2F04A90", VA = "0x182F05C90")]
	public NFPLKLNKCDL(Dictionary<OJNODEDDEDC, KFEKKDAOOBI> DODHBPGDFOJ, bool FIMFGADFPND = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F054D0", Offset = "0x2F042D0", VA = "0x182F054D0", Slot = "7")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F05AC0", Offset = "0x2F048C0", VA = "0x182F05AC0", Slot = "8")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F056A0", Offset = "0x2F044A0", VA = "0x182F056A0", Slot = "9")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F05B40", Offset = "0x2F04940", VA = "0x182F05B40", Slot = "4")]
	public OJNODEDDEDC PLHOHJEDHBG(DHKEKNILOEA EOPECGOILOC)
	{
		return default(OJNODEDDEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F05530", Offset = "0x2F04330", VA = "0x182F05530", Slot = "5")]
	public void CBFNCDGCFPB(OJNODEDDEDC NEMDNBLCKKH, KFEKKDAOOBI AEKMALFGMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F05980", Offset = "0x2F04780", VA = "0x182F05980")]
	[Conditional("DEBUG_BUILD")]
	private void PDCACCMDFFL(OJNODEDDEDC NEMDNBLCKKH, Type MAIOHDHBGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F057D0", Offset = "0x2F045D0", VA = "0x182F057D0", Slot = "6")]
	public bool OOMGGBPLIIB(OJNODEDDEDC NEMDNBLCKKH, out KFEKKDAOOBI AEKMALFGMGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F056F0", Offset = "0x2F044F0", VA = "0x182F056F0", Slot = "10")]
	public NIBCIDPINPC GABOFFCLEDK()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[IHOFDNBJLIN(typeof(KAEDKLOMOOC), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.TypeSerializer)]
	public sealed class TypeSerializerService : FEBFHBLLFPI, KAEDKLOMOOC, global::NECBJHIPAMH<KAEDKLOMOOC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, KFEKKDAOOBI> DODHBPGDFOJ;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool CLKALDFFMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x7D2430", Offset = "0x7D1230", VA = "0x1807D2430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x328B7F0", Offset = "0x328A5F0", VA = "0x18328B7F0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x328B870", Offset = "0x328A670", VA = "0x18328B870")]
		public TypeSerializerService(Dictionary<Type, KFEKKDAOOBI> DODHBPGDFOJ, bool FIMFGADFPND = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x328B460", Offset = "0x328A260", VA = "0x18328B460", Slot = "4")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x328B4C0", Offset = "0x328A2C0", VA = "0x18328B4C0", Slot = "5")]
		public void CBFNCDGCFPB(Type MAIOHDHBGKE, KFEKKDAOOBI AEKMALFGMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x328B6C0", Offset = "0x328A4C0", VA = "0x18328B6C0", Slot = "6")]
		public bool OOMGGBPLIIB(Type MAIOHDHBGKE, out KFEKKDAOOBI AEKMALFGMGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x328B5E0", Offset = "0x328A3E0", VA = "0x18328B5E0", Slot = "7")]
		public KAEDKLOMOOC GABOFFCLEDK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[IHOFDNBJLIN(typeof(NOEBODBPNME), new string[] { })]
internal sealed class NDGABJHFBKH : NOEBODBPNME, FEBFHBLLFPI, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<OJNODEDDEDC, PLNGMOLLGPO> EJGMKDNMCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private PCBBMIOOLHO KELFDPANAFC;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F03D90", Offset = "0x2F02B90", VA = "0x182F03D90", Slot = "6")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F04050", Offset = "0x2F02E50", VA = "0x182F04050", Slot = "7")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F03DE0", Offset = "0x2F02BE0", VA = "0x182F03DE0", Slot = "4")]
	public void CBFNCDGCFPB(OJNODEDDEDC OINBNOFPHAF, Type PNMMDFKDIEJ, PLNGMOLLGPO MPJDGACEMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F03E50", Offset = "0x2F02C50", VA = "0x182F03E50", Slot = "5")]
	public bool DNFFFDKHOAK(OJNODEDDEDC OINBNOFPHAF, out PLNGMOLLGPO MPJDGACEMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F03EC0", Offset = "0x2F02CC0", VA = "0x182F03EC0")]
	[Conditional("DEBUG_BUILD")]
	private void ECDAHFAKEDN(OJNODEDDEDC OINBNOFPHAF, Type PNMMDFKDIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F040B0", Offset = "0x2F02EB0", VA = "0x182F040B0")]
	public NDGABJHFBKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[IHOFDNBJLIN(typeof(EMANECLMCBG), new string[] { })]
internal sealed class DAGMKNHKFOI : EMANECLMCBG, MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly OFHHPBBJAIN ANNOBHNINDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<BDCMCEOAOGF, int> LGBENACNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> LACFGPFMJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[CEFONNIACOK]
	private PCBBMIOOLHO KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[CEFONNIACOK]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int FEMDKFLCAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x3508980", Offset = "0x3507780", VA = "0x183508980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool OHGLCGABLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA370", Offset = "0x6F9170", VA = "0x1806FA370", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3F0", Offset = "0x6F91F0", VA = "0x1806FA3F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x35089D0", Offset = "0x35077D0", VA = "0x1835089D0", Slot = "6")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x3508F10", Offset = "0x3507D10", VA = "0x183508F10", Slot = "7")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x3508E60", Offset = "0x3507C60", VA = "0x183508E60", Slot = "8")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x3508BA0", Offset = "0x35079A0", VA = "0x183508BA0")]
	private void FEPOFIPJDCC(IMKMJFJEHIJ NAKKFJMFOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x3508AE0", Offset = "0x35078E0", VA = "0x183508AE0", Slot = "4")]
	public bool CPPJNDKDDAF(BDCMCEOAOGF CONHLPJBCJE, OJNODEDDEDC PEJFAKHLGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x3508C40", Offset = "0x3507A40", VA = "0x183508C40", Slot = "5")]
	public void HMLEFFALFJA(BDCMCEOAOGF CONHLPJBCJE, Span<OJNODEDDEDC> KELFDPANAFC, bool OFKKCNIPDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x35089D0", Offset = "0x35077D0", VA = "0x1835089D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x3508F90", Offset = "0x3507D90", VA = "0x183508F90")]
	public DAGMKNHKFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class CAOMKIIOICD
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x34FB9D0", Offset = "0x34FA7D0", VA = "0x1834FB9D0")]
	public static void OCDCDHICHFB(this AIDLDPNCNPK BGJAFFALONI, ReadOnlyMemory<byte> JKABNMJHPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2852E20", Offset = "0x2851C20", VA = "0x182852E20")]
	public static void EMPHHNJGCIE<T>(this AIDLDPNCNPK BGJAFFALONI, in T NLHFEJHKLAH) where T : struct, KMDKEJKOJFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2852F50", Offset = "0x2851D50", VA = "0x182852F50")]
	public static T OICHMECOMIE<T>(this AIDLDPNCNPK BGJAFFALONI) where T : struct, KMDKEJKOJFC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x34FB7F0", Offset = "0x34FA5F0", VA = "0x1834FB7F0")]
	public static void EMPHHNJGCIE(this AIDLDPNCNPK BGJAFFALONI, NPKFDILEBLG GCDBHOLPJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x34FB6A0", Offset = "0x34FA4A0", VA = "0x1834FB6A0")]
	public static NPKFDILEBLG CLAELJKDJJG(this AIDLDPNCNPK BGJAFFALONI)
	{
		return default(NPKFDILEBLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x34FB820", Offset = "0x34FA620", VA = "0x1834FB820")]
	public static void NPEODDGFMPP(this AIDLDPNCNPK AGODLEOBGCG, uint IMBELAEHNLB, bool KMFCPGGICGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x34FB6D0", Offset = "0x34FA4D0", VA = "0x1834FB6D0")]
	public static uint DIFMFNELELG(this AIDLDPNCNPK EDHAMFMKJBA, bool KMFCPGGICGK = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class NOGDPJBJKGP
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class NIJAMHLCDGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public NIJAMHLCDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x3958AB0", Offset = "0x39578B0", VA = "0x183958AB0")]
		internal void <GetByteEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x3958B20", Offset = "0x3957920", VA = "0x183958B20")]
		internal T <GetByteEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class KGFKBCIFHBA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public KGFKBCIFHBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2721750", Offset = "0x2720550", VA = "0x182721750")]
		internal void <GetSByteEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x27217C0", Offset = "0x27205C0", VA = "0x1827217C0")]
		internal T <GetSByteEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class DGBLFEDLHCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public DGBLFEDLHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B07C50", Offset = "0x2B06A50", VA = "0x182B07C50")]
		internal void <GetShortEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B07CC0", Offset = "0x2B06AC0", VA = "0x182B07CC0")]
		internal T <GetShortEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class KMOGONNOPDH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public KMOGONNOPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2EF17F0", Offset = "0x2EF05F0", VA = "0x182EF17F0")]
		internal void <GetUShortEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2EF1860", Offset = "0x2EF0660", VA = "0x182EF1860")]
		internal T <GetUShortEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class KAFIMEFBFMG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public KAFIMEFBFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7E10", Offset = "0x2BB6C10", VA = "0x182BB7E10")]
		internal void <GetIntEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7E70", Offset = "0x2BB6C70", VA = "0x182BB7E70")]
		internal T <GetIntEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class MEAOKHEHOLK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public MEAOKHEHOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x35E3C30", Offset = "0x35E2A30", VA = "0x1835E3C30")]
		internal void <GetUIntEnumDelegates>b__0(AIDLDPNCNPK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x35E3C90", Offset = "0x35E2A90", VA = "0x1835E3C90")]
		internal T <GetUIntEnumDelegates>b__1(AIDLDPNCNPK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x315CB80", Offset = "0x315B980", VA = "0x18315CB80")]
	public static void PDBCGENHKOC<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x315C790", Offset = "0x315B590", VA = "0x18315C790")]
	private static void AMHBMEJJOJO<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x315C790", Offset = "0x315B590", VA = "0x18315C790")]
	private static void KJJAKDCCCPK<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x315CA30", Offset = "0x315B830", VA = "0x18315CA30")]
	private static void EHMGIPKKAEC<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x315CA30", Offset = "0x315B830", VA = "0x18315CA30")]
	private static void MGNOFKPJGEC<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x315C8E0", Offset = "0x315B6E0", VA = "0x18315C8E0")]
	private static void BFILGNCNNLJ<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x315C8E0", Offset = "0x315B6E0", VA = "0x18315C8E0")]
	private static void JIGBBLNFKIP<T>(T FEFPPFDPNGK, T PEEJGOJECJH, out global::BNBELMFBMBL<T> LNFLLGNOOCO, out global::KJMPGKEHMEA<T> AAFGNCCBCGO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class ICBNCLFOIEA : GCICBKANCPJ, GLCKJEOBJPN
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3980", Offset = "0x2FC2780", VA = "0x182FC3980", Slot = "4")]
	private void EGLCJFOJBPC(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void BNNDPFBAPHC(NIBCIDPINPC KELFDPANAFC);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
	protected ICBNCLFOIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[GAJBPDLFFFM(typeof(LocalPoseData))]
public sealed class CLKFHKEDDOJ : ICBNCLFOIEA
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x34FCDC0", Offset = "0x34FBBC0", VA = "0x1834FCDC0", Slot = "5")]
	protected override void BNNDPFBAPHC(NIBCIDPINPC KELFDPANAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	public CLKFHKEDDOJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class CopyAuthorityToEntity : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery MPHPCFPIGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery BCOJLOLFDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery KNDJOOCLKGA;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x3505AE0", Offset = "0x35048E0", VA = "0x183505AE0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x3505710", Offset = "0x3504510", VA = "0x183505710", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x3505890", Offset = "0x3504690", VA = "0x183505890", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x3505860", Offset = "0x3504660", VA = "0x183505860", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x3504E70", Offset = "0x3503C70", VA = "0x183504E70")]
		private void CJGFMPMKOMK(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x35051B0", Offset = "0x3503FB0", VA = "0x1835051B0")]
		private void DGMIBFLNKCJ(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x3505350", Offset = "0x3504150", VA = "0x183505350")]
		private void HEHAEAGCNHE(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x3504CC0", Offset = "0x3503AC0", VA = "0x183504CC0")]
		private void AKGDKJCNAMD(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x35058D0", Offset = "0x35046D0", VA = "0x1835058D0")]
		private void PFJANKPLNDP(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x3505630", Offset = "0x3504430", VA = "0x183505630")]
		private void NEACHDKEIOB(IMKMJFJEHIJ NAKKFJMFOAE, int NMNAALMKBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class KFECNGLFMND : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD750", Offset = "0x2FCC550", VA = "0x182FCD750", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD2C0", Offset = "0x2FCC0C0", VA = "0x182FCD2C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD380", Offset = "0x2FCC180", VA = "0x182FCD380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCCE0", Offset = "0x2FCBAE0", VA = "0x182FCCCE0")]
	private void CAHNMAKCGJJ(NativeArray<Entity> NMONLDLIICI, NativeList<Entity> PFLNNONBGPB, ComponentDataFromEntity<COPAJAFJFEM> IJOEBIJBBIP, BufferFromEntity<ChildrenData> KPBICDEAJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public KFECNGLFMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class BPLHJONLBIG : ParentSystemBase<AuthoredParentData, ELDKDELLPKL, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x34F9690", Offset = "0x34F8490", VA = "0x1834F9690", Slot = "14")]
	protected override EntityQueryDesc PODANEEBOCM(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C40", Offset = "0x7E5A40", VA = "0x1807E6C40", Slot = "15")]
	protected override EntityQueryDesc DMOPJDLEFMN(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x34F95D0", Offset = "0x34F83D0", VA = "0x1834F95D0", Slot = "16")]
	protected override EntityQueryDesc NFDCBKLHGKK(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x34F9610", Offset = "0x34F8410", VA = "0x1834F9610", Slot = "17")]
	protected override EntityQueryDesc OONDKELLBLM(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x34F96D0", Offset = "0x34F84D0", VA = "0x1834F96D0")]
	public BPLHJONLBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x34F9650", Offset = "0x34F8450", VA = "0x1834F9650", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class GGODNKKCHMO : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object MPOILIHDNKI;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE760", Offset = "0x2FBD560", VA = "0x182FBE760", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE440", Offset = "0x2FBD240", VA = "0x182FBE440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE4E0", Offset = "0x2FBD2E0", VA = "0x182FBE4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public GGODNKKCHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class LONHFFCMLAC : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object MPOILIHDNKI;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3A00", Offset = "0x2FD2800", VA = "0x182FD3A00", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2FD36E0", Offset = "0x2FD24E0", VA = "0x182FD36E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3780", Offset = "0x2FD2580", VA = "0x182FD3780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public LONHFFCMLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct HECFBGPACJG : ISystemStateBufferElementData, IBufferElementData, IEquatable<HECFBGPACJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public GICLJBAANOA EFHAIHKDJDK;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE8C0", Offset = "0x2FBD6C0", VA = "0x182FBE8C0", Slot = "4")]
	public bool Equals(HECFBGPACJG ONICAEEHHFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0")]
	public static HECFBGPACJG CILEDLHNJIF(GICLJBAANOA EFHAIHKDJDK)
	{
		return default(HECFBGPACJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct OGADGEFMKPO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public GICLJBAANOA EFHAIHKDJDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0")]
	public static OGADGEFMKPO CILEDLHNJIF(GICLJBAANOA EFHAIHKDJDK)
	{
		return default(OGADGEFMKPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class MNOBPJAJLFE : IKKOBNHPDIF
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2F03930", Offset = "0x2F02730", VA = "0x182F03930", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2F03AC0", Offset = "0x2F028C0", VA = "0x182F03AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2F02920", Offset = "0x2F01720", VA = "0x182F02920")]
	protected MNOBPJAJLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[KJJBONLHBEH]
internal abstract class IKKOBNHPDIF : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected EKNANNBDCIH FBJBBGAMODK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6B20", Offset = "0x2FC5920", VA = "0x182FC6B20", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6620", Offset = "0x2FC5420", VA = "0x182FC6620")]
	protected void LDPKANBOKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2FC68A0", Offset = "0x2FC56A0", VA = "0x182FC68A0")]
	protected void OCGMMILKGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2FC65B0", Offset = "0x2FC53B0", VA = "0x182FC65B0")]
	protected OMPPKAOKMDG DNPHNNIAFJM()
	{
		return default(OMPPKAOKMDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	protected IKKOBNHPDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class MNFJLJHKNFB : IKKOBNHPDIF
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2F026F0", Offset = "0x2F014F0", VA = "0x182F026F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2F02880", Offset = "0x2F01680", VA = "0x182F02880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2F02920", Offset = "0x2F01720", VA = "0x182F02920")]
	protected MNFJLJHKNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class LFPILGFDEEE : IKKOBNHPDIF
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2D70", Offset = "0x2FD1B70", VA = "0x182FD2D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2E80", Offset = "0x2FD1C80", VA = "0x182FD2E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	protected LFPILGFDEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class GALOABHKPFH : MNOBPJAJLFE
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA330", Offset = "0x2FB9130", VA = "0x182FBA330", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA320", Offset = "0x2FB9120", VA = "0x182FBA320")]
	public GALOABHKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class NFCPNILJCAE : MNFJLJHKNFB
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2F05460", Offset = "0x2F04260", VA = "0x182F05460", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2F02920", Offset = "0x2F01720", VA = "0x182F02920")]
	public NFCPNILJCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CPNAMJIGGHM : LFPILGFDEEE
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x34FD410", Offset = "0x34FC210", VA = "0x1834FD410", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x2F02920", Offset = "0x2F01720", VA = "0x182F02920")]
	public CPNAMJIGGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class DGGJDAMKIKM : MNOBPJAJLFE
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x350A5B0", Offset = "0x35093B0", VA = "0x18350A5B0", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA320", Offset = "0x2FB9120", VA = "0x182FBA320")]
	public DGGJDAMKIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class GAFCGBHMJGB : MNFJLJHKNFB
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA2B0", Offset = "0x2FB90B0", VA = "0x182FBA2B0", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA320", Offset = "0x2FB9120", VA = "0x182FBA320")]
	public GAFCGBHMJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class IAJHJFNOPLM : LFPILGFDEEE
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override MMOCPMLAADL JAECIOCNFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3910", Offset = "0x2FC2710", VA = "0x182FC3910", Slot = "15")]
		get
		{
			return default(MMOCPMLAADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public IAJHJFNOPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct HFNMOBBBIKD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct PDOPELNFGOB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct DPMLDCJHMBM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct MMOCPMLAADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType MLHEJANLOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType OLELIGEEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object INDCJAMMAIN;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2F026D0", Offset = "0x2F014D0", VA = "0x182F026D0")]
	public MMOCPMLAADL(ComponentType MLHEJANLOCD, ComponentType OLELIGEEOMM, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x2E7BD50", Offset = "0x2E7AB50", VA = "0x182E7BD50")]
	public static MMOCPMLAADL CIMBGCEMMDH<TReq, TTag>(object INDCJAMMAIN)
	{
		return default(MMOCPMLAADL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class KEPGFJADDAI
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string OPAOGGANFID = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string LELMDJDBLCL = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly MMOCPMLAADL MPGJHOFODNM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly MMOCPMLAADL NBHPLLANNMH;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct GICLJBAANOA : global::IODKAPMFEOL<GICLJBAANOA>, MNGNANHHIDL, IEquatable<GICLJBAANOA>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE910", Offset = "0x2FBD710", VA = "0x182FBE910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE8C0", Offset = "0x2FBD6C0", VA = "0x182FBE8C0", Slot = "8")]
	public bool Equals(GICLJBAANOA ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE950", Offset = "0x2FBD750", VA = "0x182FBE950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[KJJBONLHBEH]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Connectables)]
	public class UpdateConnectableVisuals : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct OFCDOKNBIFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public GICLJBAANOA EFHAIHKDJDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 CBAKPHLPCPB;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x42FD860", Offset = "0x42FC660", VA = "0x1842FD860")]
			public OFCDOKNBIFJ(GICLJBAANOA EFHAIHKDJDK, float3 CBAKPHLPCPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x42FD840", Offset = "0x42FC640", VA = "0x1842FD840")]
			public void FEOJDFBNKMA(out GICLJBAANOA EFHAIHKDJDK, out float3 CBAKPHLPCPB)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct GCFPELCJJIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<OFCDOKNBIFJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
			public GCFPELCJJIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<OGADGEFMKPO> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct ELBKIKPFAEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<OFCDOKNBIFJ> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
			public ELBKIKPFAEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<HECFBGPACJG> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct GLJFOGILGKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<OFCDOKNBIFJ> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
			public GLJFOGILGKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in EIGLNCKKHLK com, in DynamicBuffer<HECFBGPACJG> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HFPKOGAKCCH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct EIEPPABKBEA
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct EDGBECBPJBM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KDMPNAMEEHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<OGADGEFMKPO>.Runtime LHEHFFFONPO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> MOCBCEHMADM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<OGADGEFMKPO> NHHLKLNHPAL;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x42F5B80", Offset = "0x42F4980", VA = "0x1842F5B80")]
				public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x42F5AC0", Offset = "0x42F48C0", VA = "0x1842F5AC0")]
				public EDGBECBPJBM GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(EDGBECBPJBM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals LCKGDDDEJNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<OFCDOKNBIFJ> LLMBPPCBLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private EIEPPABKBEA BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EIEPPABKBEA.EDGBECBPJBM* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x42F82A0", Offset = "0x42F70A0", VA = "0x1842F82A0")]
			internal void MGNBBMBPACH(Entity JCNIDEIPPBD, WorldPoseData NBHBCPCHBOE, in DynamicBuffer<OGADGEFMKPO> NNMLCFCBKLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x42F84E0", Offset = "0x42F72E0", VA = "0x1842F84E0", Slot = "5")]
			public void ReadFromDisplayClass(ref GCFPELCJJIG MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x42F8510", Offset = "0x42F7310", VA = "0x1842F8510", Slot = "6")]
			public void WriteToDisplayClass(ref GCFPELCJJIG MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x42F7FD0", Offset = "0x42F6DD0", VA = "0x1842F7FD0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x42F80B0", Offset = "0x42F6EB0", VA = "0x1842F80B0")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref EIEPPABKBEA.EDGBECBPJBM HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x42F8260", Offset = "0x42F7060", VA = "0x1842F8260")]
			public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP, ref GCFPELCJJIG MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x42F81F0", Offset = "0x42F6FF0", VA = "0x1842F81F0")]
			public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KGEECOHKECA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct INMPJPJNBBM
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct CLPBKCNHPPB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KDMPNAMEEHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<HECFBGPACJG>.Runtime LHEHFFFONPO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> MOCBCEHMADM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<HECFBGPACJG> NHHLKLNHPAL;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x42FAF20", Offset = "0x42F9D20", VA = "0x1842FAF20")]
				public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x42FAE80", Offset = "0x42F9C80", VA = "0x1842FAE80")]
				public CLPBKCNHPPB GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(CLPBKCNHPPB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<OFCDOKNBIFJ> LLMBPPCBLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private INMPJPJNBBM BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe INMPJPJNBBM.CLPBKCNHPPB* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x42FBD20", Offset = "0x42FAB20", VA = "0x1842FBD20")]
			internal void MGNBBMBPACH(in WorldPoseData NBHBCPCHBOE, in DynamicBuffer<HECFBGPACJG> NNMLCFCBKLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C4C0", VA = "0x18098D6C0", Slot = "5")]
			public void ReadFromDisplayClass(ref ELBKIKPFAEK MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x42FBAE0", Offset = "0x42FA8E0", VA = "0x1842FBAE0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x42FBBB0", Offset = "0x42FA9B0", VA = "0x1842FBBB0")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref INMPJPJNBBM.CLPBKCNHPPB HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x42FBC80", Offset = "0x42FAA80", VA = "0x1842FBC80")]
			public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP, ref ELBKIKPFAEK MLHGGHKOFFG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HFJHGIFEEBP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct NFBOFFCBAGD
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct MNPJEPMOKBL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KDMPNAMEEHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<EIGLNCKKHLK>.Runtime EPALCKHMLCJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<HECFBGPACJG>.Runtime LHEHFFFONPO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> MOCBCEHMADM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<EIGLNCKKHLK> EAMJNPCNCOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<HECFBGPACJG> NHHLKLNHPAL;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x42FCD00", Offset = "0x42FBB00", VA = "0x1842FCD00")]
				public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x42FCC30", Offset = "0x42FBA30", VA = "0x1842FCC30")]
				public MNPJEPMOKBL GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(MNPJEPMOKBL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<OFCDOKNBIFJ> LLMBPPCBLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private NFBOFFCBAGD BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NFBOFFCBAGD.MNPJEPMOKBL* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x42F7E70", Offset = "0x42F6C70", VA = "0x1842F7E70")]
			internal void MGNBBMBPACH(in WorldPoseData NBHBCPCHBOE, in EIGLNCKKHLK JNCHDDMHKLM, in DynamicBuffer<HECFBGPACJG> NNMLCFCBKLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C4C0", VA = "0x18098D6C0", Slot = "5")]
			public void ReadFromDisplayClass(ref GLJFOGILGKC MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x42F7C90", Offset = "0x42F6A90", VA = "0x1842F7C90", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x42F7D10", Offset = "0x42F6B10", VA = "0x1842F7D10")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref NFBOFFCBAGD.MNPJEPMOKBL HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x42F7E30", Offset = "0x42F6C30", VA = "0x1842F7E30")]
			public void LCKNJMOMOJE(UpdateConnectableVisuals BLFNFNLAGKP, ref GLJFOGILGKC MLHGGHKOFFG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery EDDOMJAAAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery HEFKHMMAIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery BANLIAHJCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery FLEKKMONMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery NHNDGEPJLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery LNFJAABBLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery OONCFBPPOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery HFNDAEAEHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery CMGHGEFEPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery EALCELGLKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::OBLKPMNJCIK<GICLJBAANOA, EAHMEFMNIMN> LKPJHKMAMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private NHOHKFBEOBA KEGKLKBALIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private HNBHMAHMNDN INJKNDGHKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private BLIDIHGADJO LMFOFJAAHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery NLAJNOFDFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker ELMLHANMAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery FKGBNCPLCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery CDCPJCPLODI;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int OAHKGMMAIIG
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x328E950", Offset = "0x328D750", VA = "0x18328E950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x328E990", Offset = "0x328D790", VA = "0x18328E990")]
		internal EAHMEFMNIMN LBHONAJOFIB(GICLJBAANOA EFHAIHKDJDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x3290240", Offset = "0x328F040", VA = "0x183290240", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x328FB70", Offset = "0x328E970", VA = "0x18328FB70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x328FDF0", Offset = "0x328EBF0", VA = "0x18328FDF0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x328FF80", Offset = "0x328ED80", VA = "0x18328FF80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x328FDB0", Offset = "0x328EBB0", VA = "0x18328FDB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x328CDB0", Offset = "0x328BBB0", VA = "0x18328CDB0")]
		private void GACHIMIPDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x32900F0", Offset = "0x328EEF0", VA = "0x1832900F0")]
		private void PGKBJCMPHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x328E540", Offset = "0x328D340", VA = "0x18328E540")]
		private void KBKKHHPLIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x328FFC0", Offset = "0x328EDC0", VA = "0x18328FFC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x328C490", Offset = "0x328B290", VA = "0x18328C490")]
		private void CAMMFFCGHBK(EntityQuery MPHPCFPIGKM, EntityQuery OHNIAEDHHJI, EntityQuery BCOJLOLFDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x328D820", Offset = "0x328C620", VA = "0x18328D820")]
		private void IHKCCNMHHEB(EntityQuery BCOJLOLFDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x328C010", Offset = "0x328AE10", VA = "0x18328C010")]
		private void BGJJCFFHOLF(NativeArrayAsync<Entity> GHCGBKCPINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x328DF40", Offset = "0x328CD40", VA = "0x18328DF40")]
		private void JDKBAMFEAPL(NativeArrayAsync<Entity> FLBELIMGOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x328C2F0", Offset = "0x328B0F0", VA = "0x18328C2F0")]
		private void BJBHFEOOKDN(NativeArrayAsync<Entity> MLBJEGEDKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x328CC40", Offset = "0x328BA40", VA = "0x18328CC40")]
		private void FIJMNNCKCIH(NativeList<GICLJBAANOA> FIHCJOHAJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x328EE90", Offset = "0x328DC90", VA = "0x18328EE90")]
		private NativeList<GICLJBAANOA> LMCOJGENEDE(NativeArray<Entity> NMONLDLIICI)
		{
			return default(NativeList<GICLJBAANOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x328CEC0", Offset = "0x328BCC0", VA = "0x18328CEC0")]
		private void HAKOMOOIHKG(NativeArray<Entity> NMONLDLIICI, NativeList<GICLJBAANOA> FIHCJOHAJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x328F4E0", Offset = "0x328E2E0", VA = "0x18328F4E0")]
		private void OONDHGLHFAB(NativeArray<Entity> MHJEDDDBFPK, NativeArray<Entity> NJEKBJIPOCA, NativeList<GICLJBAANOA> LACFGPFMJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x328E9E0", Offset = "0x328D7E0", VA = "0x18328E9E0")]
		private void LFBPNODGFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x328CB00", Offset = "0x328B900", VA = "0x18328CB00")]
		private NativeListAsync<OFCDOKNBIFJ> FBIMHJOKKIF(EntityQuery KFFFLMFFADE, Func<NativeList<OFCDOKNBIFJ>, JobHandle> OCIMILANCBE)
		{
			return default(NativeListAsync<OFCDOKNBIFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x328C970", Offset = "0x328B770", VA = "0x18328C970")]
		private JobHandle FAAMLBLEAGC(NativeList<OFCDOKNBIFJ> LLMBPPCBLOM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x3290390", Offset = "0x328F190", VA = "0x183290390")]
		private JobHandle POJLIIEGKMK(NativeList<OFCDOKNBIFJ> LLMBPPCBLOM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x328F3B0", Offset = "0x328E1B0", VA = "0x18328F3B0")]
		private JobHandle MKMPECCIHAH(NativeList<OFCDOKNBIFJ> LLMBPPCBLOM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x328DCB0", Offset = "0x328CAB0", VA = "0x18328DCB0")]
		private void JBAKAJANAOC(NativeListAsync<OFCDOKNBIFJ> LLMBPPCBLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x328E2B0", Offset = "0x328D0B0", VA = "0x18328E2B0")]
		private void JNHFGOABKBG(NativeListAsync<OFCDOKNBIFJ> LLMBPPCBLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x328E8F0", Offset = "0x328D6F0", VA = "0x18328E8F0")]
		private bool KEJGECIHODK(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x328D4E0", Offset = "0x328C2E0", VA = "0x18328D4E0")]
		private NativeArray<Entity> HNFAENLKPKG(Entity JCNIDEIPPBD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x328DAF0", Offset = "0x328C8F0", VA = "0x18328DAF0")]
		private GICLJBAANOA IOEOKDIGEOK(NativeList<GICLJBAANOA> LACFGPFMJOO)
		{
			return default(GICLJBAANOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x3290300", Offset = "0x328F100", VA = "0x183290300")]
		private void PLHDAHEGCBI(GICLJBAANOA EFHAIHKDJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x328FA10", Offset = "0x328E810", VA = "0x18328FA10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x328D8F0", Offset = "0x328C6F0", VA = "0x18328D8F0")]
		public static EntityQuery ILCHOPELNMA(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x328E050", Offset = "0x328CE50", VA = "0x18328E050")]
		public static EntityQuery JLALMBFHMDA(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x328D5B0", Offset = "0x328C3B0", VA = "0x18328D5B0")]
		public static EntityQuery IELHHKMHFBE(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[IDOCBBAEIFB(JHEANMHFGAO.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private HBOFDJIDNOO DNJLLPNDOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private DEKEDKADICH ECOGALGGFCH;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E330", Offset = "0x2F1D130", VA = "0x182F1E330", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E9F0", Offset = "0x2F1D7F0", VA = "0x182F1E9F0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E430", Offset = "0x2F1D230", VA = "0x182F1E430", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class IELBGDDHIGP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public ILANHKOILOA BNOABMBMCLM;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IELBGDDHIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	public IELBGDDHIGP(ILANHKOILOA BNOABMBMCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4490", Offset = "0x2FC3290", VA = "0x182FC4490", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class BJJDPDBJIFF : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService BDIHCGGPFJK;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x34F9230", Offset = "0x34F8030", VA = "0x1834F9230", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x34F91E0", Offset = "0x34F7FE0", VA = "0x1834F91E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x34F9210", Offset = "0x34F8010", VA = "0x1834F9210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	protected BJJDPDBJIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class AGMJJGBMNLJ : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery OCLCGNDBFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery MFPBEFMDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery DGFAGJBGGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery LKANBHICCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService HKALIKEJAOE;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int BFNEFNAAHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x34F48A0", Offset = "0x34F36A0", VA = "0x1834F48A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int AMAEFFCJNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x34F44F0", Offset = "0x34F32F0", VA = "0x1834F44F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x34F48B0", Offset = "0x34F36B0", VA = "0x1834F48B0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x34F4680", Offset = "0x34F3480", VA = "0x1834F4680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x34F4880", Offset = "0x34F3680", VA = "0x1834F4880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x34F4060", Offset = "0x34F2E60", VA = "0x1834F4060")]
	public int FDHCONDBMJA(SceneTag LJBGPBIAJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x34F4610", Offset = "0x34F3410", VA = "0x1834F4610")]
	public int LFKGNMEFEEE(SceneTag LJBGPBIAJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x34F4170", Offset = "0x34F2F70", VA = "0x1834F4170")]
	protected void HGEGDCIGMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x34F4500", Offset = "0x34F3300", VA = "0x1834F4500")]
	protected void LEPKLCFCOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x34F4630", Offset = "0x34F3430", VA = "0x1834F4630")]
	public NativeArrayAsync<Entity> NPAFEJLFCJI(SceneTag LJBGPBIAJII, Allocator HIEJKCFDMDD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x34F44A0", Offset = "0x34F32A0", VA = "0x1834F44A0")]
	public NativeArrayAsync<Entity> KGFILCFBGAM(SceneTag LJBGPBIAJII, Allocator HIEJKCFDMDD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x34F4080", Offset = "0x34F2E80", VA = "0x1834F4080")]
	public bool GFBNMPFMGIF(SceneTag LJBGPBIAJII, out NativeArrayAsync<Entity> BNOABMBMCLM, Allocator HIEJKCFDMDD = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x34F4110", Offset = "0x34F2F10", VA = "0x1834F4110")]
	public bool HDLCOKAKBGL(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x34F43D0", Offset = "0x34F31D0", VA = "0x1834F43D0")]
	public ILANHKOILOA IBHPDBMOBBN(Entity JCNIDEIPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x34F3FF0", Offset = "0x34F2DF0", VA = "0x1834F3FF0")]
	public bool BEEDIGPHJBK(Entity JCNIDEIPPBD, out IELBGDDHIGP BNOABMBMCLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x34F4390", Offset = "0x34F3190", VA = "0x1834F4390")]
	public void IBGCJPGENLD(Entity JCNIDEIPPBD, IELBGDDHIGP BNOABMBMCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x34F4440", Offset = "0x34F3240", VA = "0x1834F4440")]
	public bool IDCJIKFHJCG(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void AEANKNFCOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public AGMJJGBMNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class LNONDAMMDKA : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery GDJOIBAIHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private IDJFGKMJFPG JPLBGCKPACG;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3690", Offset = "0x2FD2490", VA = "0x182FD3690", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2FD32F0", Offset = "0x2FD20F0", VA = "0x182FD32F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2FD33B0", Offset = "0x2FD21B0", VA = "0x182FD33B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x25EF1F0", Offset = "0x25EDFF0", VA = "0x1825EF1F0")]
	private bool LAAFODPPOMH<TComponentData>(EntityQuery KFFFLMFFADE, out NativeArray<Entity> NMONLDLIICI, out NativeArray<TComponentData> ELCPBBOBCBJ) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3280", Offset = "0x2FD2080", VA = "0x182FD3280")]
	public ILANHKOILOA IBHPDBMOBBN(Entity JCNIDEIPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public LNONDAMMDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[IDOCBBAEIFB(JHEANMHFGAO.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery LNMLDKDAEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery HAPNDKAINOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery DMLJAFDGOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery KNDJOOCLKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x3281A90", Offset = "0x3280890", VA = "0x183281A90", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x3281730", Offset = "0x3280530", VA = "0x183281730", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x3281960", Offset = "0x3280760", VA = "0x183281960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x32812F0", Offset = "0x32800F0", VA = "0x1832812F0")]
		private void AHKNMMEAEHA(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x3281360", Offset = "0x3280160", VA = "0x183281360")]
		private void IHKCCNMHHEB(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x32818F0", Offset = "0x32806F0", VA = "0x1832818F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x32813D0", Offset = "0x32801D0", VA = "0x1832813D0")]
		private void LFELGENEHGK(EntityQuery KFFFLMFFADE, bool KOFABCECKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class JGGBNHPFHIB : MILJNGODHBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct HCJBMCBJAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public HCJBMCBJAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HGBNPLMKOEK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct CCJIGKOOBEH
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct CBDFEJBHCJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PAMLPJKKBKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime FKFKCBNMFJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime HKKGPBLEPEG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LCJNJDIMDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> NKCPMBLMGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> HOPCMIHGKJG;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x42F3DA0", Offset = "0x42F2BA0", VA = "0x1842F3DA0")]
			public void LCKNJMOMOJE(JGGBNHPFHIB BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x42F3CE0", Offset = "0x42F2AE0", VA = "0x1842F3CE0")]
			public CBDFEJBHCJJ GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(CBDFEJBHCJJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private CCJIGKOOBEH BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CCJIGKOOBEH.CBDFEJBHCJJ* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x42F8750", Offset = "0x42F7550", VA = "0x1842F8750")]
		internal void MGNBBMBPACH(Entity FNMGGGFHOJG, SplineShapeData CEIGCFEFIIO, DynamicBuffer<LinkedEntityGroup> IHLLHGOCNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x42F8550", Offset = "0x42F7350", VA = "0x1842F8550", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x42F8620", Offset = "0x42F7420", VA = "0x1842F8620")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref CCJIGKOOBEH.CBDFEJBHCJJ HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x42F8740", Offset = "0x42F7540", VA = "0x1842F8740")]
		public void LCKNJMOMOJE(JGGBNHPFHIB BLFNFNLAGKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BJPHFBFOOCO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct CBNBJPKIFLP
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct NMKLCJOJBPH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODJFOOEANFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime OOCCKOJDFOP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ODFFMDBBEKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> CBJDMMKOJAH;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x42F3C80", Offset = "0x42F2A80", VA = "0x1842F3C80")]
			public void LCKNJMOMOJE(JGGBNHPFHIB BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x42F3C00", Offset = "0x42F2A00", VA = "0x1842F3C00")]
			public NMKLCJOJBPH GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(NMKLCJOJBPH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> DDADDBIDKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private CBNBJPKIFLP BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CBNBJPKIFLP.NMKLCJOJBPH* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x42F3680", Offset = "0x42F2480", VA = "0x1842F3680")]
		internal void MGNBBMBPACH(Entity PGMACOBHFKJ, SplinePointParentData OICNIGILNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x115CAF0", Offset = "0x115B8F0", VA = "0x18115CAF0", Slot = "5")]
		public void ReadFromDisplayClass(ref HCJBMCBJAGD MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x42F34A0", Offset = "0x42F22A0", VA = "0x1842F34A0", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x42F3540", Offset = "0x42F2340", VA = "0x1842F3540")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref CBNBJPKIFLP.NMKLCJOJBPH HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x42F35F0", Offset = "0x42F23F0", VA = "0x1842F35F0")]
		public void LCKNJMOMOJE(JGGBNHPFHIB BLFNFNLAGKP, ref HCJBMCBJAGD MLHGGHKOFFG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery ADGOJDEEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery NJDJFFFMLPG;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC96C0", Offset = "0x2FC84C0", VA = "0x182FC96C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9770", Offset = "0x2FC8570", VA = "0x182FC9770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public JGGBNHPFHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9420", Offset = "0x2FC8220", VA = "0x182FC9420", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9120", Offset = "0x2FC7F20", VA = "0x182FC9120")]
	public static EntityQuery JPOOLLGFFGI(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC92C0", Offset = "0x2FC80C0", VA = "0x182FC92C0")]
	public static EntityQuery OHFGMDLJEMN(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public sealed class LMDNBNIAAFC : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private BIOAEAGLHAC FCCENJDDDBA;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FD30B0", Offset = "0x2FD1EB0", VA = "0x182FD30B0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3090", Offset = "0x2FD1E90", VA = "0x182FD3090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public LMDNBNIAAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class PMPELLKJFPP : MILJNGODHBE, GLCKJEOBJPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct HBFMDACHBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<MPFLPHHMMLG> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<FIIDJEFPAIP> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<MPFLPHHMMLG> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public HBFMDACHBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, JCEHBDNJLFJ previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__2(Entity entity, JCEHBDNJLFJ previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct HMPCMDKOLIG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct GFADJNGHHNG
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct INMEFEEDBMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime IKFLJPOHIFH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> INNFIGCJHIP;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x42F6FB0", Offset = "0x42F5DB0", VA = "0x1842F6FB0")]
			public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x42F6F30", Offset = "0x42F5D30", VA = "0x1842F6F30")]
			public INMEFEEDBMA GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(INMEFEEDBMA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<MPFLPHHMMLG> KLCIMAEDBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private GFADJNGHHNG BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GFADJNGHHNG.INMEFEEDBMA* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x42F90B0", Offset = "0x42F7EB0", VA = "0x1842F90B0")]
		internal void MGNBBMBPACH(Entity JCNIDEIPPBD, ParentData PCEDOMDPLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C4C0", VA = "0x18098D6C0", Slot = "5")]
		public void ReadFromDisplayClass(ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x42F8ED0", Offset = "0x42F7CD0", VA = "0x1842F8ED0", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x42F8F70", Offset = "0x42F7D70", VA = "0x1842F8F70")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref GFADJNGHHNG.INMEFEEDBMA HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x42F9020", Offset = "0x42F7E20", VA = "0x1842F9020")]
		public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP, ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FFFEBOGAGLI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct EDJENDODHFB
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct OOEBFFIHGIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime IKFLJPOHIFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<JCEHBDNJLFJ>.Runtime FGFDJOPIKND;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> INNFIGCJHIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JCEHBDNJLFJ> JNANFONEPFA;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x42F5A40", Offset = "0x42F4840", VA = "0x1842F5A40")]
			public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x42F59A0", Offset = "0x42F47A0", VA = "0x1842F59A0")]
			public OOEBFFIHGIJ GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(OOEBFFIHGIJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<FIIDJEFPAIP> NILNDNCMLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private EDJENDODHFB BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EDJENDODHFB.OOEBFFIHGIJ* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x42F64C0", Offset = "0x42F52C0", VA = "0x1842F64C0")]
		internal void MGNBBMBPACH(Entity JCNIDEIPPBD, ParentData PCEDOMDPLLE, JCEHBDNJLFJ KICPEGHPDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x42F6580", Offset = "0x42F5380", VA = "0x1842F6580", Slot = "5")]
		public void ReadFromDisplayClass(ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x42F62D0", Offset = "0x42F50D0", VA = "0x1842F62D0", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x42F63A0", Offset = "0x42F51A0", VA = "0x1842F63A0")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref EDJENDODHFB.OOEBFFIHGIJ HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x42F6480", Offset = "0x42F5280", VA = "0x1842F6480")]
		public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP, ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FMNKPIMNIKN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct FJHIHHMJNBM
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct MJJCMAJNFMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<JCEHBDNJLFJ>.Runtime FGFDJOPIKND;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<JCEHBDNJLFJ> JNANFONEPFA;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x42F6610", Offset = "0x42F5410", VA = "0x1842F6610")]
			public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x42F6590", Offset = "0x42F5390", VA = "0x1842F6590")]
			public MJJCMAJNFMO GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(MJJCMAJNFMO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<MPFLPHHMMLG> MBIGPIGNPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private FJHIHHMJNBM BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FJHIHHMJNBM.MJJCMAJNFMO* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x42F6850", Offset = "0x42F5650", VA = "0x1842F6850")]
		internal void MGNBBMBPACH(Entity JCNIDEIPPBD, JCEHBDNJLFJ KICPEGHPDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x42F68D0", Offset = "0x42F56D0", VA = "0x1842F68D0", Slot = "5")]
		public void ReadFromDisplayClass(ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x42F6670", Offset = "0x42F5470", VA = "0x1842F6670", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x42F6710", Offset = "0x42F5510", VA = "0x1842F6710")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref FJHIHHMJNBM.MJJCMAJNFMO HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x42F67C0", Offset = "0x42F55C0", VA = "0x1842F67C0")]
		public void LCKNJMOMOJE(PMPELLKJFPP BLFNFNLAGKP, ref HBFMDACHBCJ MLHGGHKOFFG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private CBIMKPJBECO EBLDCMDPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery EANCJFPMIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery ABPNPOFHMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery MHDDOMAIDGE;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F18100", Offset = "0x2F16F00", VA = "0x182F18100", Slot = "14")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F18470", Offset = "0x2F17270", VA = "0x182F18470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public PMPELLKJFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F18410", Offset = "0x2F17210", VA = "0x182F18410", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F17CA0", Offset = "0x2F16AA0", VA = "0x182F17CA0")]
	public static EntityQuery GEMMFCBKONI(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2F181E0", Offset = "0x2F16FE0", VA = "0x182F181E0")]
	public static EntityQuery LCPCLDNPAOL(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2F17F00", Offset = "0x2F16D00", VA = "0x182F17F00")]
	public static EntityQuery IADELGOOOLM(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[IDOCBBAEIFB(JHEANMHFGAO.Connectables)]
	public class InitializeRigidbodyExHierarchy : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private OGIEPIPKEEN JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6B90", Offset = "0x2FC5990", VA = "0x182FC6B90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6E10", Offset = "0x2FC5C10", VA = "0x182FC6E10", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6C20", Offset = "0x2FC5A20", VA = "0x182FC6C20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class JCIOAPBCLBB : ParentSystemBase<ParentData, JCEHBDNJLFJ, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC70E0", Offset = "0x2FC5EE0", VA = "0x182FC70E0", Slot = "14")]
	protected override EntityQueryDesc PODANEEBOCM(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C40", Offset = "0x7E5A40", VA = "0x1807E6C40", Slot = "15")]
	protected override EntityQueryDesc DMOPJDLEFMN(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7020", Offset = "0x2FC5E20", VA = "0x182FC7020", Slot = "16")]
	protected override EntityQueryDesc NFDCBKLHGKK(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7060", Offset = "0x2FC5E60", VA = "0x182FC7060", Slot = "17")]
	protected override EntityQueryDesc OONDKELLBLM(EntityQueryDesc KFFFLMFFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7120", Offset = "0x2FC5F20", VA = "0x182FC7120")]
	public JCIOAPBCLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2FC70A0", Offset = "0x2FC5EA0", VA = "0x182FC70A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : MILJNGODHBE where ParentData : struct, IComponentData, FJOBGJJBDLN where PreviousParentData : struct, IComponentData, FJOBGJJBDLN where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, FJOBGJJBDLN
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct NGNNGDFLEFD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter JFKCCEAALFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MKEFEKFJEDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter EJOCALGCLMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> NFNJPACJLLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> MIHAPFLGLKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType DAJAAMDDCGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint CGAOIBNOEBI;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x3957180", Offset = "0x3955F80", VA = "0x183957180", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct FKLFAFDCBOK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> EJOCALGCLMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> HIEJPGCHCNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> DHNEJEMIEIH;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x36DAD30", Offset = "0x36D9B30", VA = "0x1836DAD30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct LNBAMDJHKEA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> JFKCCEAALFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MKEFEKFJEDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> EJOCALGCLMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> HIEJPGCHCNN;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3209780", Offset = "0x3208580", VA = "0x183209780")]
			private int BICBICLIAMF(DynamicBuffer<ChildrenData> GJFKHPNECKG, Entity JCNIDEIPPBD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3209620", Offset = "0x3208420", VA = "0x183209620")]
			private void ALCBPHOEBJE(Entity AABHIBJPKOH, DynamicBuffer<ChildrenData> GJFKHPNECKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3209D90", Offset = "0x3208B90", VA = "0x183209D90")]
			private void HECMCFEMEHK(Entity AABHIBJPKOH, DynamicBuffer<ChildrenData> GJFKHPNECKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x32099A0", Offset = "0x32087A0", VA = "0x1832099A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct OBKIACHANNA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> HCMJJJCFIDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> IAJCOJILOEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> HIEJPGCHCNN;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2947890", Offset = "0x2946690", VA = "0x182947890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery ILHOAPHIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery ELHGBFBLBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery HKLOECGINCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery AILPPJKFCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker LPMKEFMOBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker EEBAEOCENEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker NKKKKJHPFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker GFMIHFJBIDC;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2C48580", Offset = "0x2C47380", VA = "0x182C48580")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2C469D0", Offset = "0x2C457D0", VA = "0x182C469D0")]
		private int BICBICLIAMF(DynamicBuffer<ChildrenData> GJFKHPNECKG, Entity JCNIDEIPPBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2C482C0", Offset = "0x2C470C0", VA = "0x182C482C0")]
		private void PIONHCMMDAH(Entity HEFMLIDNBAL, Entity IJPPGMLPBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x7E6C40", Offset = "0x7E5A40", VA = "0x1807E6C40", Slot = "14")]
		protected virtual EntityQueryDesc PODANEEBOCM(EntityQueryDesc KFFFLMFFADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x7E6C40", Offset = "0x7E5A40", VA = "0x1807E6C40", Slot = "15")]
		protected virtual EntityQueryDesc DMOPJDLEFMN(EntityQueryDesc KFFFLMFFADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x7E6C40", Offset = "0x7E5A40", VA = "0x1807E6C40", Slot = "16")]
		protected virtual EntityQueryDesc NFDCBKLHGKK(EntityQueryDesc KFFFLMFFADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc OONDKELLBLM(EntityQueryDesc KFFFLMFFADE);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2C47F20", Offset = "0x2C46D20", VA = "0x182C47F20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2C46AC0", Offset = "0x2C458C0", VA = "0x182C46AC0")]
		private void GNACLKOPHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2C46720", Offset = "0x2C45520", VA = "0x182C46720")]
		private void AHDIODMKLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2C47220", Offset = "0x2C46020", VA = "0x182C47220")]
		private JobHandle MPIDLPJMCLG(JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2C46C60", Offset = "0x2C45A60", VA = "0x182C46C60")]
		private void KIHDGGICKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2C481F0", Offset = "0x2C46FF0", VA = "0x182C481F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2C481C0", Offset = "0x2C46FC0", VA = "0x182C481C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public abstract class IFMNIPACFHB : MILJNGODHBE, GLCKJEOBJPN
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct BNOJFJOHNOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> FBLEIMACDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> PGAIJKEOHHN;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x42F3B10", Offset = "0x42F2910", VA = "0x1842F3B10")]
		public BNOJFJOHNOP(NativeList<Entity> FBLEIMACDHL, NativeList<Entity> PGAIJKEOHHN, JobHandle FMCMEMBCJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x42F3A90", Offset = "0x42F2890", VA = "0x1842F3A90")]
		public JobHandle MJMFPIFFLKE(JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x42F3A00", Offset = "0x42F2800", VA = "0x1842F3A00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct HECJCMAHGGO : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum FPKDPPNKKGJ
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
		public NativeList<Entity> HEKJCCIPPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> DGPGPBMFPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> CJHIGLFOHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> PDPNPIOLDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity ONCKEAJNFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity FLJPPEJDIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GECNGBKOJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int KEGOPNHCKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int IFEHKINHPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private FPKDPPNKKGJ ABGIIBAPFBG;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x42F73D0", Offset = "0x42F61D0", VA = "0x1842F73D0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x42F7340", Offset = "0x42F6140", VA = "0x1842F7340")]
		private void EODGDCCDCOK(Entity JCNIDEIPPBD, bool AGBHJHOBAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x42F7A80", Offset = "0x42F6880", VA = "0x1842F7A80")]
		private void OPEGNPJFHML(Entity JCNIDEIPPBD, bool AGBHJHOBAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x42F7560", Offset = "0x42F6360", VA = "0x1842F7560")]
		public BNOJFJOHNOP HCEPBKMIMLG(NativeArray<Entity> CECFOEGDIKH, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x42F7A00", Offset = "0x42F6800", VA = "0x1842F7A00")]
		public BNOJFJOHNOP LNHHAKHJEOH(NativeArray<Entity> CECFOEGDIKH, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x42F7260", Offset = "0x42F6060", VA = "0x1842F7260")]
		public BNOJFJOHNOP EFGLHCFFAFJ(NativeList<MPFLPHHMMLG> LLMBPPCBLOM, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x42F7920", Offset = "0x42F6720", VA = "0x1842F7920")]
		public BNOJFJOHNOP KLAEOJPNNLA(NativeList<MPFLPHHMMLG> LLMBPPCBLOM, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x42F7840", Offset = "0x42F6640", VA = "0x1842F7840")]
		public BNOJFJOHNOP IHNHHHLLAIP(NativeList<FIIDJEFPAIP> LLMBPPCBLOM, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x5399EB0", Offset = "0x5398CB0", VA = "0x185399EB0")]
		private BNOJFJOHNOP HDEGJAGCBNH<T>(NativeList<T> LLMBPPCBLOM, int LACIHBKCBEC, int PNOFNEEEEFP, FPKDPPNKKGJ FOMLKLNHMAJ, JobHandle AGAPNFNLCKG) where T : struct
		{
			return default(BNOJFJOHNOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x42F75E0", Offset = "0x42F63E0", VA = "0x1842F75E0")]
		private BNOJFJOHNOP HDEGJAGCBNH(NativeArray<Entity> NMONLDLIICI, int LACIHBKCBEC, int PNOFNEEEEFP, FPKDPPNKKGJ FOMLKLNHMAJ, JobHandle AGAPNFNLCKG)
		{
			return default(BNOJFJOHNOP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery IOHGMENEJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery NFBHLIKMPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private CBIMKPJBECO OLBPGLMNELM;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType AGHOPJPODLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType FGAGFABJPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType BBCCCMGGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6430", Offset = "0x2FC5230", VA = "0x182FC6430")]
	protected IFMNIPACFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5060", Offset = "0x2FC3E60", VA = "0x182FC5060", Slot = "14")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5390", Offset = "0x2FC4190", VA = "0x182FC5390", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC55C0", Offset = "0x2FC43C0", VA = "0x182FC55C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x1064690", Offset = "0x1063490", VA = "0x181064690", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4F90", Offset = "0x2FC3D90", VA = "0x182FC4F90")]
	private void GNAIPCAALBA(NativeArray<Entity> LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4EF0", Offset = "0x2FC3CF0", VA = "0x182FC4EF0")]
	private void ENMMBFODKLB(NativeArray<Entity> LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5140", Offset = "0x2FC3F40", VA = "0x182FC5140")]
	private void LLCDCLJBLNO(BNOJFJOHNOP GDLEFNCPEAO, string PLIBKGJBAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5280", Offset = "0x2FC4080", VA = "0x182FC5280")]
	private void LLCDCLJBLNO(NativeListAsync<Entity> KCMEHLOMBAL, string PLIBKGJBAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4DB0", Offset = "0x2FC3BB0", VA = "0x182FC4DB0")]
	private void EDNOGPNJIIF(BNOJFJOHNOP GDLEFNCPEAO, string PLIBKGJBAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4CA0", Offset = "0x2FC3AA0", VA = "0x182FC4CA0")]
	private void EDNOGPNJIIF(NativeListAsync<Entity> KCMEHLOMBAL, string PLIBKGJBAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4FF0", Offset = "0x2FC3DF0", VA = "0x182FC4FF0")]
	private bool HLHDENOJJFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public class JNOFGCKGCPE : MILJNGODHBE, OMEPFIBEFCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct OFKPPHAOENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public JNOFGCKGCPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public OFKPPHAOENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BIJPBOMOBOP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct HEDPBKDFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct DNBCGCICBMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime OKJKDDKELNN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JDPAJEOAJHB;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x42F7BA0", Offset = "0x42F69A0", VA = "0x1842F7BA0")]
			public void LCKNJMOMOJE(JNOFGCKGCPE BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x42F7B90", Offset = "0x42F6990", VA = "0x1842F7B90")]
			public DNBCGCICBMO GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(DNBCGCICBMO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JNOFGCKGCPE LCKGDDDEJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer IBKPHGENLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private HEDPBKDFNLF BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HEDPBKDFNLF.DNBCGCICBMO* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x42F3320", Offset = "0x42F2120", VA = "0x1842F3320")]
		internal void MGNBBMBPACH(Entity ABJFFBJEJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x42F3430", Offset = "0x42F2230", VA = "0x1842F3430", Slot = "5")]
		public void ReadFromDisplayClass(ref OFKPPHAOENF MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x42F3460", Offset = "0x42F2260", VA = "0x1842F3460", Slot = "6")]
		public void WriteToDisplayClass(ref OFKPPHAOENF MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x42F31B0", Offset = "0x42F1FB0", VA = "0x1842F31B0", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x42F3200", Offset = "0x42F2000", VA = "0x1842F3200")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref HEDPBKDFNLF.DNBCGCICBMO HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x42F32E0", Offset = "0x42F20E0", VA = "0x1842F32E0")]
		public void LCKNJMOMOJE(JNOFGCKGCPE BLFNFNLAGKP, ref OFKPPHAOENF MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x42F3270", Offset = "0x42F2070", VA = "0x1842F3270")]
		public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private JMLEPKCFOGD PKKDAEJOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private DPDPICMJPAD COKKDJMMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery PCGEGHPHIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker KEHLENCFPGA;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB3E0", Offset = "0x2FCA1E0", VA = "0x182FCB3E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB590", Offset = "0x2FCA390", VA = "0x182FCB590", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB440", Offset = "0x2FCA240", VA = "0x182FCB440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public JNOFGCKGCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB300", Offset = "0x2FCA100", VA = "0x182FCB300", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB130", Offset = "0x2FC9F30", VA = "0x182FCB130")]
	public static EntityQuery CEFJLDCKDBL(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[KJJBONLHBEH]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public class FKOOHODNGOC : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private DPDPICMJPAD COKKDJMMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService AGNCLNMMDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2FB98F0", Offset = "0x2FB86F0", VA = "0x182FB98F0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9500", Offset = "0x2FB8300", VA = "0x182FB9500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2FB95A0", Offset = "0x2FB83A0", VA = "0x182FB95A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public FKOOHODNGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct NHOOCLLBAHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public OPIFAPKDMPP EFHAIHKDJDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E30", Offset = "0x6F6C30", VA = "0x1806F7E30")]
	public static NHOOCLLBAHA CILEDLHNJIF(in OPIFAPKDMPP DKPIDJOPOME)
	{
		return default(NHOOCLLBAHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E30", Offset = "0x6F6C30", VA = "0x1806F7E30")]
	public static OPIFAPKDMPP CILEDLHNJIF(in NHOOCLLBAHA OAENBCACIBG)
	{
		return default(OPIFAPKDMPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class JMLEPKCFOGD : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB070", Offset = "0x2FC9E70", VA = "0x182FCB070", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	public JMLEPKCFOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public class JCPBJHFPMIP : MILJNGODHBE, OMEPFIBEFCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct OPNOGMIJPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public JCPBJHFPMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public OPNOGMIJPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__0(Entity e, NHOOCLLBAHA ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct INFEGOIHEKE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct HFIMDEABEIF
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct GLHKOLCKAIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime OKJKDDKELNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<NHOOCLLBAHA>.Runtime NKALIGLLFID;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JDPAJEOAJHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<NHOOCLLBAHA> LHCPGOBPKKA;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x42F7C30", Offset = "0x42F6A30", VA = "0x1842F7C30")]
			public void LCKNJMOMOJE(JCPBJHFPMIP BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x42F7BB0", Offset = "0x42F69B0", VA = "0x1842F7BB0")]
			public GLHKOLCKAIE GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(GLHKOLCKAIE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public JCPBJHFPMIP LCKGDDDEJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer IBKPHGENLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private HFIMDEABEIF BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HFIMDEABEIF.GLHKOLCKAIE* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x42FAD80", Offset = "0x42F9B80", VA = "0x1842FAD80")]
		internal void MGNBBMBPACH(Entity ABJFFBJEJDK, NHOOCLLBAHA IEONMCJLJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x42F3430", Offset = "0x42F2230", VA = "0x1842F3430", Slot = "5")]
		public void ReadFromDisplayClass(ref OPNOGMIJPLB MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x42F3460", Offset = "0x42F2260", VA = "0x1842F3460", Slot = "6")]
		public void WriteToDisplayClass(ref OPNOGMIJPLB MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x42FAB30", Offset = "0x42F9930", VA = "0x1842FAB30", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x42FABD0", Offset = "0x42F99D0", VA = "0x1842FABD0")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref HFIMDEABEIF.GLHKOLCKAIE HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x42FACF0", Offset = "0x42F9AF0", VA = "0x1842FACF0")]
		public void LCKNJMOMOJE(JCPBJHFPMIP BLFNFNLAGKP, ref OPNOGMIJPLB MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x42FAC80", Offset = "0x42F9A80", VA = "0x1842FAC80")]
		public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private JMLEPKCFOGD PKKDAEJOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private DPDPICMJPAD COKKDJMMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery MDCOGNDCLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker PNHKFDPJKJF;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7410", Offset = "0x2FC6210", VA = "0x182FC7410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2FC75D0", Offset = "0x2FC63D0", VA = "0x182FC75D0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7470", Offset = "0x2FC6270", VA = "0x182FC7470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public JCPBJHFPMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7330", Offset = "0x2FC6130", VA = "0x182FC7330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7160", Offset = "0x2FC5F60", VA = "0x182FC7160")]
	public static EntityQuery KOKPDIIOCAN(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct KIDJLGICDPD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public OBJHEKJMJHJ AGNKGGODJFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, BCGDFNNBADB> NMONLDLIICI;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x42FBEB0", Offset = "0x42FACB0", VA = "0x1842FBEB0")]
			public KIDJLGICDPD(int FPMMBKCOHLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x42FBE30", Offset = "0x42FAC30", VA = "0x1842FBE30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct DKCHPKEALLG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> IIHAPBKPIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> BFFHCPKJJFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MDLBGHPNDHG;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x42F5740", Offset = "0x42F4540", VA = "0x1842F5740", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct BIIAJDBPGLH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> IIHAPBKPIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MDLBGHPNDHG;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x42F3060", Offset = "0x42F1E60", VA = "0x1842F3060", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private DPDPICMJPAD COKKDJMMOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery MPHBNHFFCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery FGLAFNFAAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery JGPIONLEKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery KJNMBNPEGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery PPIMLFIIJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle DFOLAOFIEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private KIDJLGICDPD DENLNADBAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private KIDJLGICDPD OBFFMLJKPML;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BBB0", Offset = "0x2F1A9B0", VA = "0x182F1BBB0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B150", Offset = "0x2F19F50", VA = "0x182F1B150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AB80", Offset = "0x2F19980", VA = "0x182F1AB80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B410", Offset = "0x2F1A210", VA = "0x182F1B410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AA40", Offset = "0x2F19840", VA = "0x182F1AA40")]
		private void ALNAFNLEKGF(EntityQuery KFFFLMFFADE, out (NativeArrayAsync<NHOOCLLBAHA> handles, NativeArrayAsync<DCNPECHIJBP> bounds) PHAPMEHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2F1BC10", Offset = "0x2F1AA10", VA = "0x182F1BC10")]
		private void PNIAOAOFFAK((NativeArrayAsync<NHOOCLLBAHA> handles, NativeArrayAsync<DCNPECHIJBP> bounds) PHAPMEHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AB80", Offset = "0x2F19980", VA = "0x182F1AB80")]
		private void CGJHHDMEALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B010", Offset = "0x2F19E10", VA = "0x182F1B010")]
		private void OJGMDNBKGLF(EntityQuery KFFFLMFFADE, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<NHOOCLLBAHA> handles) PHAPMEHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AD20", Offset = "0x2F19B20", VA = "0x182F1AD20")]
		private void IDBCDJPAIHN((NativeArrayAsync<Entity> entities, NativeArrayAsync<NHOOCLLBAHA> handles) PHAPMEHMHAK, KIDJLGICDPD INAHGNNJAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2F1ABC0", Offset = "0x2F199C0", VA = "0x182F1ABC0")]
		private JobHandle FBLCDMJFKGK(KIDJLGICDPD INAHGNNJAEA, ComponentDataFromEntity<WorldPoseData> IIHAPBKPIDO, ComponentDataFromEntity<WorldUniformScaleData> MDLBGHPNDHG, ComponentDataFromEntity<WorldDeformableScaleData> BFFHCPKJJFL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A910", Offset = "0x2F19710", VA = "0x182F1A910")]
		private JobHandle AIGJFGFMHON(KIDJLGICDPD INAHGNNJAEA, ComponentDataFromEntity<WorldPoseData> IIHAPBKPIDO, ComponentDataFromEntity<WorldUniformScaleData> MDLBGHPNDHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct PBHAFCMIJCL : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[KJJBONLHBEH]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public class SplineLocalBoundsSystem : MILJNGODHBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct NCBOFMKGBIO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> OKFHBNJJBJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> KOFGKMCKPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<DCNPECHIJBP> EHKCDMLCBGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, BCGDFNNBADB>.ParallelWriter ABFMNFIIGGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter AHHCKOFABJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter LGJDCAKNBEC;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x42FCB70", Offset = "0x42FB970", VA = "0x1842FCB70", Slot = "4")]
			public void Execute(int CPOAAGLEIPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct EMMNLCBDNHL : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> HGFBEKHJCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> CAFDKACDNEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> GMCAPBAAGCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> MHLOADKADMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DCNPECHIJBP> EADNBCHNIMD;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x42F6040", Offset = "0x42F4E40", VA = "0x1842F6040", Slot = "4")]
			public void Execute(int CPOAAGLEIPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery PAALBFAIHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery KLKPGMJJOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery ODNDKCGHDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery HHMECGOFMBB;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x3283DB0", Offset = "0x3282BB0", VA = "0x183283DB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x3283FC0", Offset = "0x3282DC0", VA = "0x183283FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x32837D0", Offset = "0x32825D0", VA = "0x1832837D0")]
		private JobHandle FAEBJADDNBO(NativeArrayAsync<Entity> ECEFKNGMHII, int LNKONGJEECL, JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x32838B0", Offset = "0x32826B0", VA = "0x1832838B0")]
		private JobHandle FAEBJADDNBO(NativeArray<Entity> OLDGAJKGCPB, int LNKONGJEECL, [Optional] JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x3283420", Offset = "0x3282220", VA = "0x183283420")]
		private NativeArrayAsync<Entity> BHGFMLIFFGE(EntityQuery KFFFLMFFADE)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x3282FD0", Offset = "0x3281DD0", VA = "0x183282FD0")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) BDGJGGIEFIG(NativeArrayAsync<Entity> MCGPLHPFOKA)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x3283BF0", Offset = "0x32829F0", VA = "0x183283BF0")]
		private void GJABDONBPCL(out NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3283B60", Offset = "0x3282960", VA = "0x183283B60")]
		private void FHMOGLCPFFD(NativeList<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3283A90", Offset = "0x3282890", VA = "0x183283A90")]
		private void FHMOGLCPFFD(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x3283C80", Offset = "0x3282A80", VA = "0x183283C80")]
		private void OKFEJJOEKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void AOOENCBBPNL(int IDDAAFNFFFG, int ALPHDAKPGOB, int MPNBCKLNKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x32834A0", Offset = "0x32822A0", VA = "0x1832834A0")]
		private static DCNPECHIJBP DCCMFMPAELE(NativeArray<Entity> CIOANGEOAIB, ComponentDataFromEntity<SplinePointPositionData> GMCAPBAAGCK, ComponentDataFromEntity<SplinePointScaleData> MHLOADKADMM)
		{
			return default(DCNPECHIJBP);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct KDKBEKKFHLA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[KJJBONLHBEH]
	[IDOCBBAEIFB(JHEANMHFGAO.Lifecycle)]
	public class DestroyLocalObjects : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[CEFONNIACOK]
		private ObjectNetworkToLocalMapService GCEPJPIBHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[CEFONNIACOK]
		private ObjectLifecycleService OLBEJFPALDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery MLGIDGADDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery CHLEFKCCMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery KNDJOOCLKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x350D580", Offset = "0x350C380", VA = "0x18350D580", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x350D5F0", Offset = "0x350C3F0", VA = "0x18350D5F0")]
		public bool POJFGNCEGIK(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x350D430", Offset = "0x350C230", VA = "0x18350D430", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x350D190", Offset = "0x350BF90", VA = "0x18350D190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x350D560", Offset = "0x350C360", VA = "0x18350D560", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C2B410", Offset = "0x1C2A210", VA = "0x181C2B410", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x350D190", Offset = "0x350BF90", VA = "0x18350D190")]
		private void GILFOFFAPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x350D0E0", Offset = "0x350BEE0", VA = "0x18350D0E0")]
		private void FMEKHIDGAIJ(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x350D2F0", Offset = "0x350C0F0", VA = "0x18350D2F0")]
		private void OLEFPLKKKGF(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x350CFD0", Offset = "0x350BDD0", VA = "0x18350CFD0")]
		private void CNLAAENDOEF(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x350D1D0", Offset = "0x350BFD0", VA = "0x18350D1D0")]
		private void KAECCHENEIO(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[IDOCBBAEIFB(JHEANMHFGAO.NetworkSend)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static MPBDMNOPGNJ[] HACLEFBHNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private FCIALOLMHBO BOECJKACLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private FKJKMJONNAG MMBNBBIKDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService DMLNIFBLILM;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6900", Offset = "0x2FB5700", VA = "0x182FB6900", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6840", Offset = "0x2FB5640", VA = "0x182FB6840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FB62B0", Offset = "0x2FB50B0", VA = "0x182FB62B0")]
		private void KLHHJNGBGFI(MPBDMNOPGNJ GPOGNDEOKKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private void NINELKANOMI(Entity JCNIDEIPPBD, BDCMCEOAOGF CONHLPJBCJE, CPLDKIAEKDJ DCLGFFDBANO, AABBPIJDNKN JHALDLCMCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[IDOCBBAEIFB(JHEANMHFGAO.Callbacks)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public sealed class PropertyEventCallbacks : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService OBAPIKNALOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService DMLNIFBLILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase GPOGNDEOKKI;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2F217B0", Offset = "0x2F205B0", VA = "0x182F217B0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2F216B0", Offset = "0x2F204B0", VA = "0x182F216B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[IDOCBBAEIFB(JHEANMHFGAO.NetworkSend)]
	internal class TransmitNetworkDataSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private LCDLBBFGMKH LPPHPBKBDNN;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x328B410", Offset = "0x328A210", VA = "0x18328B410", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x328B3C0", Offset = "0x328A1C0", VA = "0x18328B3C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[KJJBONLHBEH]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public class CalculateCullingBandChanges : MILJNGODHBE, FEBFHBLLFPI, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct BGPCAMKAGHC : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType ALJGKFLBEFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> POHMIOAOMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<BAIGIFBNIFD>.ParallelWriter EGCPAHIHHEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<KBNJPBPCLFN> GOJNIGEEGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 INOJNNAPINL;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 BKBNJGMHFKF;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 FFLILPPPMHK;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 FBDNHDLEPOL;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x3276F70", Offset = "0x3275D70", VA = "0x183276F70", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int FIIMBJILBOA = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double KIMJOIIPMEK = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery GDBMLBDMEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery CMINCBADBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double KIFOBBHCGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService CEBBPLPFFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService HLDBOKPBKCE;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x34FD480", Offset = "0x34FC280", VA = "0x1834FD480", Slot = "14")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x34FDBB0", Offset = "0x34FC9B0", VA = "0x1834FDBB0", Slot = "15")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x34FD840", Offset = "0x34FC640", VA = "0x1834FD840", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x34FD990", Offset = "0x34FC790", VA = "0x1834FD990", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x34FD490", Offset = "0x34FC290", VA = "0x1834FD490")]
		private bool JDJLHNJGKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x34FD500", Offset = "0x34FC300", VA = "0x1834FD500")]
		private void OFAMGJCBGEO(EntityQuery KFFFLMFFADE, float3 BGBCLMMMEPI, string EOPECGOILOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct BAIGIFBNIFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity JCNIDEIPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public GHFALBJGKOG OMHFAAGAIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public GHFALBJGKOG KMCDOHPNFGD;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public class ProcessCullingBandChangeCallbacks : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService CEBBPLPFFAL;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E270", Offset = "0x2F1D070", VA = "0x182F1E270", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E250", Offset = "0x2F1D050", VA = "0x182F1E250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[IDOCBBAEIFB(JHEANMHFGAO.Connectables)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class UpdateInertialProperties : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery MIFCGJNFEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private ONAHJACNKFM MBGELFEBAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x32922B0", Offset = "0x32910B0", VA = "0x1832922B0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x3291F80", Offset = "0x3290D80", VA = "0x183291F80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x3292010", Offset = "0x3290E10", VA = "0x183292010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[KJJBONLHBEH]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GMHCOAPAJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BAPKENMFLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MONOEKNGMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService FBKJCDMBIGI;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6140", Offset = "0x2FB4F40", VA = "0x182FB6140", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5C10", Offset = "0x2FB4A10", VA = "0x182FB5C10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5010", Offset = "0x2FB3E10", VA = "0x182FB5010")]
		private void GBKHBNBODEM(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LLMBPPCBLOM, EntityQueryDesc LBIKOPDLJJJ, bool EBGNLMABMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5120", Offset = "0x2FB3F20", VA = "0x182FB5120")]
		private void GBKHBNBODEM(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LLMBPPCBLOM, EntityQueryDesc LBIKOPDLJJJ, bool EBGNLMABMPJ, bool POJKCICHJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5E70", Offset = "0x2FB4C70", VA = "0x182FB5E70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5810", Offset = "0x2FB4610", VA = "0x182FB5810")]
		private void MNLNBCJHPMD(EntityQuery KFFFLMFFADE, bool DONOJKBLFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5A00", Offset = "0x2FB4800", VA = "0x182FB5A00")]
		private void ODEDHDDGMLP(EntityQuery KFFFLMFFADE, bool CKBNFDILDMN, bool DONOJKBLFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5520", Offset = "0x2FB4320", VA = "0x182FB5520")]
		private void KCOOPHELOJA(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4CA0", Offset = "0x2FB3AA0", VA = "0x182FB4CA0")]
		private void DDMNKJLODDJ(NativeList<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5260", Offset = "0x2FB4060", VA = "0x182FB5260")]
		private void IEAKIBBDFBP(NativeArray<Entity> NMONLDLIICI, bool CKBNFDILDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4E10", Offset = "0x2FB3C10", VA = "0x182FB4E10")]
		private NativeList<Entity> DIOKMDJDGCE(NativeArray<Entity> NMONLDLIICI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2FB4C60", Offset = "0x2FB3A60", VA = "0x182FB4C60")]
		private NativeList<Entity> CICAPLKBMEK(NativeArray<Entity> NMONLDLIICI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2FB57D0", Offset = "0x2FB45D0", VA = "0x182FB57D0")]
		private NativeList<Entity> KKNLFJDCHAJ(NativeArray<Entity> NMONLDLIICI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5380", Offset = "0x2FB4180", VA = "0x182FB5380")]
		private NativeList<Entity> JBDOGAMEEGP(NativeArray<Entity> NMONLDLIICI, bool AJGDCOABOCI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5740", Offset = "0x2FB4540", VA = "0x182FB5740")]
		private EDFLCJEELHO KJCKIPCOLBF(NativeArray<Entity> NMONLDLIICI)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(EDFLCJEELHO);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2FB61E0", Offset = "0x2FB4FE0", VA = "0x182FB61E0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService FBKJCDMBIGI;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E2E0", Offset = "0x2F1D0E0", VA = "0x182F1E2E0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E2C0", Offset = "0x2F1D0C0", VA = "0x182F1E2C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : EJELJBKAGMA
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery KCJMJOPEJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery NJPNOKPKOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery KOLDEIMPPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery AEGLEKNEKGH;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x350CC40", Offset = "0x350BA40", VA = "0x18350CC40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x350CE00", Offset = "0x350BC00", VA = "0x18350CE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x350CA00", Offset = "0x350B800", VA = "0x18350CA00")]
		private void ODDAPNMGMPK(EntityQuery KFFFLMFFADE, bool LONHIAHINDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x350C7C0", Offset = "0x350B5C0", VA = "0x18350C7C0")]
		private void IBCEMMMDBDD(EntityQuery KFFFLMFFADE, bool LONHIAHINDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class AssignPlayerIdsSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery ONOJPJMMNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery KMEJGEMGDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService JKMDIALCHLK;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x34F7940", Offset = "0x34F6740", VA = "0x1834F7940", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x34F7810", Offset = "0x34F6610", VA = "0x1834F7810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x34F7920", Offset = "0x34F6720", VA = "0x1834F7920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x34F7700", Offset = "0x34F6500", VA = "0x1834F7700")]
		private void OEDLNCGPLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x34F7130", Offset = "0x34F5F30", VA = "0x1834F7130")]
		private void DAAEFJBNHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x34F73E0", Offset = "0x34F61E0", VA = "0x1834F73E0")]
		private void IFMDPDOAJJJ(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x34F72A0", Offset = "0x34F60A0", VA = "0x1834F72A0")]
		private void EJKGDGBAODC(NativeArray<Entity> NMONLDLIICI, int NOALGJGMNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x34F7020", Offset = "0x34F5E20", VA = "0x1834F7020")]
		private void CFKGHCBOCIO(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x34F6FC0", Offset = "0x34F5DC0", VA = "0x1834F6FC0")]
		private void BLIGNGKOAEE(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void DAOMFJBCHLO(int NMNAALMKBCK, Transform GPMKACFJLBP, Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class JMNJMEMFENB
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB0A0", Offset = "0x2FC9EA0", VA = "0x182FCB0A0")]
	public static bool DIFMJOODLMG(this SystemBase HDNGIEMACBN, out Entity JCNIDEIPPBD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery POPKJIBBJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private HNBHMAHMNDN CIDENEAGPMC;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x34FF6A0", Offset = "0x34FE4A0", VA = "0x1834FF6A0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x34FF570", Offset = "0x34FE370", VA = "0x1834FF570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x34FF630", Offset = "0x34FE430", VA = "0x1834FF630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<HBLIFCNOHFG>, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string CDMDFIDHDII = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private KFEPKLKEFHI GOJDJCEIGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery HODEPFEJIFH;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity PNCHCCBCBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2F017C0", Offset = "0x2F005C0", VA = "0x182F017C0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2F01820", Offset = "0x2F00620", VA = "0x182F01820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity HBFFNJHEAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2F01760", Offset = "0x2F00560", VA = "0x182F01760")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public IMKMJFJEHIJ DGHMPMGCAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2F01410", Offset = "0x2F00210", VA = "0x182F01410")]
			get
			{
				return default(IMKMJFJEHIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2F01DC0", Offset = "0x2F00BC0", VA = "0x182F01DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public IMKMJFJEHIJ GKGCHAEGADM
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2F01B60", Offset = "0x2F00960", VA = "0x182F01B60")]
			get
			{
				return default(IMKMJFJEHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2F01C30", Offset = "0x2F00A30", VA = "0x182F01C30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2F01D50", Offset = "0x2F00B50", VA = "0x182F01D50", Slot = "15")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2F01CD0", Offset = "0x2F00AD0", VA = "0x182F01CD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2F01A10", Offset = "0x2F00810", VA = "0x182F01A10", Slot = "14")]
		protected override void MKCEFCADILP(NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> NJOIEGHAAKG, NativeArray<Entity> CBMFOKNHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2F01880", Offset = "0x2F00680", VA = "0x182F01880")]
		private void KHLPECPPMCP(NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> CBMFOKNHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2F014A0", Offset = "0x2F002A0", VA = "0x182F014A0")]
		private void HLJEPGJHEPC(Entity JCNIDEIPPBD, Entity JEFOOLHINEM, Entity ADPFLKPDPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2E61050", Offset = "0x2E5FE50", VA = "0x182E61050")]
		private bool OOMGGBPLIIB<T>(out T NLHFEJHKLAH) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2E60F90", Offset = "0x2E5FD90", VA = "0x182E60F90")]
		private void MELDEDNCFHO<T>(T NLHFEJHKLAH) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2F01990", Offset = "0x2F00790", VA = "0x182F01990")]
		public bool MHANNKIPPCE(IMKMJFJEHIJ CGFCOLOADKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2F01960", Offset = "0x2F00760", VA = "0x182F01960")]
		private static bool MBDNCPPJGAK(IMKMJFJEHIJ KEIOJEIDOCI, IMKMJFJEHIJ EIDOHCOHJAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2F01E80", Offset = "0x2F00C80", VA = "0x182F01E80")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2F01BF0", Offset = "0x2F009F0", VA = "0x182F01BF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x3508170", Offset = "0x3506F70", VA = "0x183508170", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x3507C80", Offset = "0x3506A80", VA = "0x183507C80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x3507D20", Offset = "0x3506B20", VA = "0x183507D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3507A20", Offset = "0x3506820", VA = "0x183507A20")]
		private NativeArray<Entity> HEPBBABFIIB(int PHHDFCFDFMP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3507B70", Offset = "0x3506970", VA = "0x183507B70")]
		private void HPCDFJFDDDO(NativeArray<Entity> NMJILLINPEG, NativeArray<Entity> JDMLFNGHGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	internal class HideRemotePivotsNotInScope : MILJNGODHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery BHDCHONJGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery AAPNPICEBEH;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1160", Offset = "0x2FBFF60", VA = "0x182FC1160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1250", Offset = "0x2FC0050", VA = "0x182FC1250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class FKDDDHHIHLM
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string DLHHGKHFCLB = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x2281460", Offset = "0x2280260", VA = "0x182281460")]
	public static NativeArray<T> HDEGJAGCBNH<T>(NativeArray<Entity> NMONLDLIICI, EntityManager OFPCNLPKKAK) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9070", Offset = "0x2FB7E70", VA = "0x182FB9070")]
	public static void FBIGEDFAOEF(EntityQuery KFFFLMFFADE, EntityManager OFPCNLPKKAK, LMLOCAEKAJL NGPKJGJONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2FB91B0", Offset = "0x2FB7FB0", VA = "0x182FB91B0")]
	public static void GEOPDLMANMF(NativeArray<Entity> NMJILLINPEG, LMLOCAEKAJL NGPKJGJONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2FB92E0", Offset = "0x2FB80E0", VA = "0x182FB92E0")]
	public static void HPLEJAKMPLD(NativeArray<Entity> NMJILLINPEG, LMLOCAEKAJL NGPKJGJONLG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService OLBEJFPALDA;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x3291EA0", Offset = "0x3290CA0", VA = "0x183291EA0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x3291DF0", Offset = "0x3290BF0", VA = "0x183291DF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x3291E90", Offset = "0x3290C90", VA = "0x183291E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x32915E0", Offset = "0x32903E0", VA = "0x1832915E0")]
		private void NEDOPCHKLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x32914D0", Offset = "0x32902D0", VA = "0x1832914D0")]
		private void LIJBJPEKLMF(NativeArray<Entity> NMJILLINPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3290520", Offset = "0x328F320", VA = "0x183290520")]
		private void DMCKLNCCLOO(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3291280", Offset = "0x3290080", VA = "0x183291280")]
		private void JPBOPKPMBFD(NativeArray<Entity> JDMLFNGHGCN, NativeArray<RigidTransform> PLKIEGDEKOJ, NativeArray<RigidTransform> NHNAIMDGGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3290DF0", Offset = "0x328FBF0", VA = "0x183290DF0")]
		private void ENHIPLFHGOA(NativeArray<RigidTransform> NHNAIMDGGNG, NativeArray<Entity> JDMLFNGHGCN, NativeList<Entity> LMBOLMJIJEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class PostGameplayOnScopeChange : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery POPKJIBBJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery IANOJGAIPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CA80", Offset = "0x2F1B880", VA = "0x182F1CA80", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C870", Offset = "0x2F1B670", VA = "0x182F1C870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C9C0", Offset = "0x2F1B7C0", VA = "0x182F1C9C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C800", Offset = "0x2F1B600", VA = "0x182F1C800")]
		private void CPCBMJHMKEF(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal class PreventDisembodiedScopesSystem : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery LIBLGCNHEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents DMDBPDDAOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private HNBHMAHMNDN CIDENEAGPMC;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E170", Offset = "0x2F1CF70", VA = "0x182F1E170", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DF30", Offset = "0x2F1CD30", VA = "0x182F1DF30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DFD0", Offset = "0x2F1CDD0", VA = "0x182F1DFD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DFE0", Offset = "0x2F1CDE0", VA = "0x182F1DFE0")]
		private void PBHJMCHPKEK(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<GAIOHDNMDPO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x327C170", Offset = "0x327AF70", VA = "0x18327C170", Slot = "14")]
		protected override void MKCEFCADILP(NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> NJOIEGHAAKG, NativeArray<Entity> CBMFOKNHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x327C0A0", Offset = "0x327AEA0", VA = "0x18327C0A0")]
		[BurstCompile]
		private static void MKCEFCADILP(NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> CBMFOKNHJLK, ComponentDataFromEntity<global::EBAIHBJNDNK> ECONGJPAAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x327C300", Offset = "0x327B100", VA = "0x18327C300")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x327C2C0", Offset = "0x327B0C0", VA = "0x18327C2C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[IDOCBBAEIFB(JHEANMHFGAO.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : MILJNGODHBE where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery DDFECMDJJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery DKNHAJIHMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery MENOEFFIONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery HDANAPBDACG;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x31C8E40", Offset = "0x31C7C40", VA = "0x1831C8E40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x31C9210", Offset = "0x31C8010", VA = "0x1831C9210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x31C91E0", Offset = "0x31C7FE0", VA = "0x1831C91E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x31C96E0", Offset = "0x31C84E0", VA = "0x1831C96E0")]
		private void PHCGACEFICC(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x31C7DC0", Offset = "0x31C6BC0", VA = "0x1831C7DC0")]
		private void FPDPBHLAFCL(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x31C85A0", Offset = "0x31C73A0", VA = "0x1831C85A0")]
		private void LMKHFBJELDG(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void MKCEFCADILP(NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> NJOIEGHAAKG, NativeArray<Entity> CBMFOKNHJLK);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x31C9B20", Offset = "0x31C8920", VA = "0x1831C9B20")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class NOFOMJJCLDI : MILJNGODHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> KKGLMHJCDFC;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2F07070", Offset = "0x2F05E70", VA = "0x182F07070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2F07270", Offset = "0x2F06070", VA = "0x182F07270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2F073C0", Offset = "0x2F061C0", VA = "0x182F073C0")]
	public NOFOMJJCLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct KBCPHCMJIHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int HGGIJKLHICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int LFENOMEJLFM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x11280C0", Offset = "0x1126EC0", VA = "0x1811280C0")]
	public static Entity CILEDLHNJIF(KBCPHCMJIHN PHAPMEHMHAK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x11280C0", Offset = "0x1126EC0", VA = "0x1811280C0")]
	public static KBCPHCMJIHN CILEDLHNJIF(Entity JCNIDEIPPBD)
	{
		return default(KBCPHCMJIHN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct KCMDENBDHPN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct LEHIHKILMLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType DLNLFAKMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> AJGFBNHKPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> DHFMBEEMNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> NMONLDLIICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> FEGHGIBGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> KICPEGHPDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> PCEDOMDPLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int BLHAJHGIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int HIGCFCCAPNB;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool EEOKAFICCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2FD2930", Offset = "0x2FD1730", VA = "0x182FD2930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2A50", Offset = "0x2FD1850", VA = "0x182FD2A50")]
	public LEHIHKILMLK(ComponentType DLNLFAKMGEH, NativeList<int> AJGFBNHKPHM, NativeList<int> DHFMBEEMNGL, NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> FEGHGIBGJDO, NativeArray<byte> KICPEGHPDNA, NativeArray<byte> PCEDOMDPLLE, int BLHAJHGIOOO, int HIGCFCCAPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2710", Offset = "0x2FD1510", VA = "0x182FD2710")]
	private KNIHKHKCMFB FKGHKCMGMKB(NativeArray<byte> ECEFKNGMHII, int CPOAAGLEIPE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T FKGHKCMGMKB<T>(NativeArray<byte> ECEFKNGMHII, int CPOAAGLEIPE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD29B0", Offset = "0x2FD17B0", VA = "0x182FD29B0")]
	public KNIHKHKCMFB KMBDHMNPMOE(int CPOAAGLEIPE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T KMBDHMNPMOE<T>(int CPOAAGLEIPE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2A00", Offset = "0x2FD1800", VA = "0x182FD2A00")]
	public KNIHKHKCMFB MANIOKNKFKJ(int CPOAAGLEIPE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T MANIOKNKFKJ<T>(int CPOAAGLEIPE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2630", Offset = "0x2FD1430", VA = "0x182FD2630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct IFJHKNELHMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<ICJIKKGKAKN> KELFDPANAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType DLNLFAKMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int BLHAJHGIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int HIGCFCCAPNB;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4C70", Offset = "0x2FC3A70", VA = "0x182FC4C70")]
	public IFJHKNELHMM(ComponentType DLNLFAKMGEH, int BLHAJHGIOOO, int HIGCFCCAPNB, EntityQuery KFFFLMFFADE, NativeArray<ICJIKKGKAKN> KELFDPANAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4C20", Offset = "0x2FC3A20", VA = "0x182FC4C20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct LCMNOMEBEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int CPOAAGLEIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int MCLEOJIDIIG;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
	public LCMNOMEBEGG(int CPOAAGLEIPE, int MCLEOJIDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct ICJIKKGKAKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int JBINMJEHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int MBCLCCPKDLG;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
	public ICJIKKGKAKN(int JBINMJEHBFH, int MBCLCCPKDLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct AABBPIJDNKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly OJNODEDDEDC NEMDNBLCKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int BLHAJHGIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* KICPEGHPDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* PCEDOMDPLLE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool FFNEOGDCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x34F3930", Offset = "0x34F2730", VA = "0x1834F3930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public OJNODEDDEDC NOKJCDGHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0")]
		get
		{
			return default(OJNODEDDEDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x34F3840", Offset = "0x34F2640", VA = "0x1834F3840")]
	public KNIHKHKCMFB EJPLOLFINLB(Type MAIOHDHBGKE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x34F3750", Offset = "0x34F2550", VA = "0x1834F3750")]
	public KNIHKHKCMFB EAKBKPHIBHL(Type MAIOHDHBGKE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2620010", Offset = "0x261EE10", VA = "0x182620010")]
	public T EJPLOLFINLB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x261FFF0", Offset = "0x261EDF0", VA = "0x18261FFF0")]
	public T EAKBKPHIBHL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x34F3940", Offset = "0x34F2740", VA = "0x1834F3940")]
	public unsafe AABBPIJDNKN(OJNODEDDEDC NEMDNBLCKKH, int MBCLCCPKDLG, byte* KICPEGHPDNA, byte* PCEDOMDPLLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class DHHPHFJDJBJ : EKBCLFGBMGC, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService DMLNIFBLILM;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract MPBDMNOPGNJ BJEBEHPHDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x350A8F0", Offset = "0x35096F0", VA = "0x18350A8F0", Slot = "17")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x350A860", Offset = "0x3509660", VA = "0x18350A860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x350A620", Offset = "0x3509420", VA = "0x18350A620", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	protected DHHPHFJDJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class LNBIDIJGHHI
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] LCMAJMGANNH;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class PFFHCOJLDFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, IFJHKNELHMM> KEOBONJEKEO;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public IFJHKNELHMM MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x2F16AF0", Offset = "0x2F158F0", VA = "0x182F16AF0")]
		get
		{
			return default(IFJHKNELHMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2F172B0", Offset = "0x2F160B0", VA = "0x182F172B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2F17550", Offset = "0x2F16350", VA = "0x182F17550")]
	public PFFHCOJLDFL(CIHNJOKIFOM JNAMKKKCPOF, JFPIEAPAMJM MCHCOEKKPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2F16A80", Offset = "0x2F15880", VA = "0x182F16A80")]
	public bool AMKBCCEHNAL(ComponentType DLNLFAKMGEH, out IFJHKNELHMM MDANIEOCOKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x2F17170", Offset = "0x2F15F70", VA = "0x182F17170")]
	public Dictionary<ComponentType, IFJHKNELHMM>.Enumerator FGLPNHJPKAJ()
	{
		return default(Dictionary<ComponentType, IFJHKNELHMM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2F16B80", Offset = "0x2F15980", VA = "0x182F16B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2F16D10", Offset = "0x2F15B10", VA = "0x182F16D10")]
	private void ELCBPDJCJHC(IEnumerable<GGBNGHABEPC> JBMEHLGEBBB, EntityManager OFPCNLPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2F17200", Offset = "0x2F16000", VA = "0x182F17200")]
	private static int HKKGHCPGBNA(GGBNGHABEPC EBDKEFMKHKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2F17300", Offset = "0x2F16100", VA = "0x182F17300")]
	private static NativeArray<ICJIKKGKAKN> KODAFBLFLHI(GGBNGHABEPC EBDKEFMKHKM, Allocator HIEJKCFDMDD = Allocator.Persistent)
	{
		return default(NativeArray<ICJIKKGKAKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface DFHBAHEACEE
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool EEOKAFICCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World HNNGMFGFANA
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDHJGMKHPMO(out NativeArray<int> OKAJHMMGLNJ, Allocator HIEJKCFDMDD);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFKFKGLDKNJ(ComponentType DLNLFAKMGEH, out LEHIHKILMLK LIEJDKCHOLJ, out IFJHKNELHMM NCJAMNCMCDH);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CFKFKGLDKNJ(ComponentType DLNLFAKMGEH, out LEHIHKILMLK LIEJDKCHOLJ);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LEHIHKILMLK ECIIGNAKOPE(ComponentType DLNLFAKMGEH);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DHPCBFPABEE DCNDHADLFNM();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMHNLPENPMH(JobHandle FMCMEMBCJOJ);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
internal interface MJDNLBEBKGH
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World HNNGMFGFANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	PFFHCOJLDFL GAJGIMCGONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	GFBEOCDMBIH BCOFLIABIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, AABBPIJDNKN> GHMMGCLGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle JKOIALMDDFK
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
	bool KKLPLLLGLNM();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDAOBHPPNLM();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEKIKEOGMJJ(ComponentType DLNLFAKMGEH, in LEHIHKILMLK CBKNNPPJIPM);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FBMGHAHDOLF(FJNOGBCPDIO CEBPAJMCGMI, out Entity BCDGDEJOBOG);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct DHPCBFPABEE
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct HJLCIEGHNFH : IEnumerator<AABBPIJDNKN>, IEnumerator, IDisposable, IEnumerable<AABBPIJDNKN>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, AABBPIJDNKN> IEPEFMMEENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity JCNIDEIPPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> IOPPKEOOBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private AABBPIJDNKN PCEDOMDPLLE;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public AABBPIJDNKN MPEDNLDPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x7739A0", Offset = "0x7727A0", VA = "0x1807739A0", Slot = "4")]
			get
			{
				return default(AABBPIJDNKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x3279510", Offset = "0x3278310", VA = "0x183279510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x3279560", Offset = "0x3278360", VA = "0x183279560")]
		internal HJLCIEGHNFH(NativeMultiHashMap<Entity, AABBPIJDNKN> IEPEFMMEENM, Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x3279300", Offset = "0x3278100", VA = "0x183279300", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x32792D0", Offset = "0x32780D0", VA = "0x1832792D0")]
		public HJLCIEGHNFH FGLPNHJPKAJ()
		{
			return default(HJLCIEGHNFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x32793D0", Offset = "0x32781D0", VA = "0x1832793D0", Slot = "9")]
		private IEnumerator<AABBPIJDNKN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x3279470", Offset = "0x3278270", VA = "0x183279470", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly MJDNLBEBKGH NNMLCFCBKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle DBPAOFHPBPP;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int EELFOAFMNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x350B280", Offset = "0x350A080", VA = "0x18350B280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x350B370", Offset = "0x350A170", VA = "0x18350B370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x244CE20", Offset = "0x244BC20", VA = "0x18244CE20")]
	public DHPCBFPABEE(MJDNLBEBKGH NNMLCFCBKLN, JobHandle DBPAOFHPBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x350B020", Offset = "0x3509E20", VA = "0x18350B020")]
	public bool FEKMPKPDNDF(Allocator HIEJKCFDMDD, out NativeKeyValueArrays<Entity, AABBPIJDNKN> DGEANHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x350B450", Offset = "0x350A250", VA = "0x18350B450")]
	public bool PHGEHCJENCG(Allocator HIEJKCFDMDD, out (NativeArray<Entity> entities, int uniqueCount) DGEANHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x350B160", Offset = "0x3509F60", VA = "0x18350B160")]
	public HJLCIEGHNFH GOGMGJFCLJB(Entity JCNIDEIPPBD)
	{
		return default(HJLCIEGHNFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class GFBEOCDMBIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<IFJHKNELHMM> LLMBPPCBLOM;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public IFJHKNELHMM MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC500", Offset = "0x2FBB300", VA = "0x182FBC500")]
		get
		{
			return default(IFJHKNELHMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2FBCA80", Offset = "0x2FBB880", VA = "0x182FBCA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCAC0", Offset = "0x2FBB8C0", VA = "0x182FBCAC0")]
	public GFBEOCDMBIH(PFFHCOJLDFL KEOBONJEKEO, CIHNJOKIFOM JNAMKKKCPOF, JFPIEAPAMJM MCHCOEKKPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCA00", Offset = "0x2FBB800", VA = "0x182FBCA00")]
	public List<IFJHKNELHMM>.Enumerator FGLPNHJPKAJ()
	{
		return default(List<IFJHKNELHMM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC590", Offset = "0x2FBB390", VA = "0x182FBC590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC700", Offset = "0x2FBB500", VA = "0x182FBC700")]
	private void ELCBPDJCJHC(PFFHCOJLDFL KEOBONJEKEO, EntityManager OFPCNLPKKAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class GAOHFHDCKGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService EDGDLJOHDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::LJJOMMCCIHN<GGBNGHABEPC> NENIOPMLJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World ILDDDCMMPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> JCGEPMMMEIN;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBC10", Offset = "0x2FBAA10", VA = "0x182FBBC10")]
	public GAOHFHDCKGK(ObjectInstantiationService EDGDLJOHDGN, CIHNJOKIFOM JNAMKKKCPOF, JFPIEAPAMJM MCHCOEKKPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA830", Offset = "0x2FB9630", VA = "0x182FBA830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA7D0", Offset = "0x2FB95D0", VA = "0x182FBA7D0")]
	public bool CIIKBEGAIPK(FJNOGBCPDIO CEBPAJMCGMI, out Entity BCDGDEJOBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAA40", Offset = "0x2FB9840", VA = "0x182FBAA40")]
	private void IPHPOHOCKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB600", Offset = "0x2FBA400", VA = "0x182FBB600")]
	private EntityArchetype NGPDJICGGHF(EntityArchetype CHBELPOLEMB)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA3A0", Offset = "0x2FB91A0", VA = "0x182FBA3A0")]
	public static void BMIENDIEDNP(EntityManager CAIPFEPMOOI, EntityManager EIKNGLIFFBD, NativeArray<Entity> FBCKFKMPEEC, NativeArray<EntityArchetype> BIAPCKOHNDI, [Optional] NativeArray<Entity> EJLGCHIJHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB0A0", Offset = "0x2FB9EA0", VA = "0x182FBB0A0")]
	[Conditional("DEBUG_BUILD")]
	private static void JDGHJKDPECF(NativeArray<EntityArchetype> AGILCDPGHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB210", Offset = "0x2FBA010", VA = "0x182FBB210")]
	private static string KBFCGINLFPD(EntityArchetype PAMNOPDNHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA900", Offset = "0x2FB9700", VA = "0x182FBA900")]
	[CompilerGenerated]
	internal static void HPDJNNPLOFC(ref Span<ComponentType> AFAKHPHJKEO, ComponentType NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB450", Offset = "0x2FBA250", VA = "0x182FBB450")]
	[CompilerGenerated]
	internal static void LFPGDBDOKAL(Span<ComponentType> ECEFKNGMHII, ref Span<ComponentType> AFAKHPHJKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBB30", Offset = "0x2FBA930", VA = "0x182FBBB30")]
	[CompilerGenerated]
	internal static void NPIPCNNDPHH(Span<ComponentType> ECEFKNGMHII, ref Span<ComponentType> AFAKHPHJKEO, ComponentType MLHEJANLOCD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[IDOCBBAEIFB(JHEANMHFGAO.PropertyChanges)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld ONIGIGAGDPJ;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x34F6F00", Offset = "0x34F5D00", VA = "0x1834F6F00", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x34F6E50", Offset = "0x34F5C50", VA = "0x1834F6E50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[IDOCBBAEIFB(JHEANMHFGAO.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : MILJNGODHBE, OMEPFIBEFCP, GLCKJEOBJPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct NANCKFNJIML : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> NEKJKMCBMCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> ACFIIPCAFEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<ICJIKKGKAKN> OHNHILBEHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<LCMNOMEBEGG>.ParallelWriter MGNAGGALNPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int EOLNOOMCMMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int BEMGNKAOJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker EENACPEMILE;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x327A160", Offset = "0x3278F60", VA = "0x18327A160", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x327A0D0", Offset = "0x3278ED0", VA = "0x18327A0D0")]
			private unsafe int CJJDNFOMOLI(byte* MNFKCEAEFPP, byte* BJCJNGNNING)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct JIBEBHNBFLO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> AJGFBNHKPHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> JCEBKIOBKHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<LCMNOMEBEGG> PFLNNONBGPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker EENACPEMILE;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x32797F0", Offset = "0x32785F0", VA = "0x1832797F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct MPGINLICFED : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> FKCJLLCPEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity ANDOCIGPBHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int BLHAJHGIOOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker EENACPEMILE;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x3279D70", Offset = "0x3278B70", VA = "0x183279D70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct DLDCKNIIFIE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, AABBPIJDNKN> OBJGOEEIBOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> KICPEGHPDNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> PCEDOMDPLLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<ICJIKKGKAKN> CHPIHHGKGHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> DHFMBEEMNGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> AJGFBNHKPHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int MFGAEEMHHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int HIGCFCCAPNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker EENACPEMILE;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x32777D0", Offset = "0x32765D0", VA = "0x1832777D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker OPMGMKEIDFJ;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker FBDNKJHPMNG;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker MEOAEBNIKKK;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker DBNHFKCDBDK;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker ONFGODBPJDD;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker MANJNKMMCDF;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker FHGFCKCOGPF;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker NOHJDOCOIPP;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker BNBPGNEOLHN;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker PAPAOALJOMG;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker PIBODCGMLBA;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker AEGKFMELCEP;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker KLHKAPFOHHL;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker CDBDBHHFJGP;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker MFEMEBJNDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService DMLNIFBLILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery MPHPCFPIGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery BCOJLOLFDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery KNDJOOCLKGA;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World HNNGMFGFANA
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x34FFEA0", Offset = "0x34FECA0", VA = "0x1834FFEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private MJDNLBEBKGH IGIAPHFBJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x3501C50", Offset = "0x3500A50", VA = "0x183501C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x35029A0", Offset = "0x35017A0", VA = "0x1835029A0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "15")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x35026A0", Offset = "0x35014A0", VA = "0x1835026A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x3502860", Offset = "0x3501660", VA = "0x183502860", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x35027F0", Offset = "0x35015F0", VA = "0x1835027F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x34FFF60", Offset = "0x34FED60", VA = "0x1834FFF60")]
		private void AOGKJPFDCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x3500E70", Offset = "0x34FFC70", VA = "0x183500E70")]
		internal void GBGIIAPIPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x3500E90", Offset = "0x34FFC90", VA = "0x183500E90")]
		private void GBGIIAPIPDP(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x3500C30", Offset = "0x34FFA30", VA = "0x183500C30")]
		private void FOBOGJMLMFK(NativeArray<Entity> FBCKFKMPEEC, NativeArray<RRObjectPrefabData> OGGMFLALMHE, ref NativeArray<Entity> EKGFIALGONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x3500320", Offset = "0x34FF120", VA = "0x183500320")]
		internal void DAPGIJFEIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3500340", Offset = "0x34FF140", VA = "0x183500340")]
		private void DAPGIJFEIMM(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x34FF740", Offset = "0x34FE540", VA = "0x1834FF740")]
		internal void ACLGAOMNCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x3500950", Offset = "0x34FF750", VA = "0x183500950")]
		private void FFGAIAGOKNO(MJDNLBEBKGH NNMLCFCBKLN, IFJHKNELHMM NCJAMNCMCDH, bool PDBEDJPMBCG, ref JobHandle ALCNEINANFL, ref JobHandle BNGBNOPPBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x3502670", Offset = "0x3501470", VA = "0x183502670")]
		internal bool OPALCCLNFNM(in IFJHKNELHMM BJCJNGNNING, out JobHandle EFHAIHKDJDK, out LEHIHKILMLK OLMNPHBJDNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x3501C70", Offset = "0x3500A70", VA = "0x183501C70")]
		private bool OPALCCLNFNM(in IFJHKNELHMM BJCJNGNNING, bool PDBEDJPMBCG, out JobHandle EFHAIHKDJDK, out LEHIHKILMLK OLMNPHBJDNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3501A90", Offset = "0x3500890", VA = "0x183501A90")]
		internal (NativeList<int>, NativeList<int>) LAGAJLOAHKH(NativeList<LCMNOMEBEGG> PFLNNONBGPB, int FPMMBKCOHLA, JobHandle AGAPNFNLCKG, out JobHandle FMCMEMBCJOJ, Allocator HIEJKCFDMDD = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x35019E0", Offset = "0x35007E0", VA = "0x1835019E0")]
		internal static NativeArray<Entity> KACPEEIABNK(EntityQuery KFFFLMFFADE, out JobHandle LJKBBJLLNDJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x3500740", Offset = "0x34FF540", VA = "0x183500740")]
		internal static NativeArray<byte> FDJGBENOILP(int NJGGJPEFKKD, out JobHandle POHFLIKNBMI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x35018D0", Offset = "0x35006D0", VA = "0x1835018D0")]
		internal static NativeArray<byte> IHLAJKPHCML(EntityQuery KFFFLMFFADE, int CABFLHODPAB, out JobHandle POHFLIKNBMI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x3500220", Offset = "0x34FF020", VA = "0x183500220")]
		internal static NativeArray<Entity> BHGFMLIFFGE(EntityQuery KFFFLMFFADE, out JobHandle NAPHCLGAJKP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x3501660", Offset = "0x3500460", VA = "0x183501660")]
		internal NativeArray<byte> HNLHKGHONCP(NativeArray<Entity> NMONLDLIICI, IFJHKNELHMM NCJAMNCMCDH, JobHandle AGAPNFNLCKG, out JobHandle FMCMEMBCJOJ, Allocator HIEJKCFDMDD = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x35007C0", Offset = "0x34FF5C0", VA = "0x1835007C0")]
		internal JobHandle FEDGLGACNDG(in LEHIHKILMLK PHAPMEHMHAK, in IFJHKNELHMM NCJAMNCMCDH, NativeMultiHashMap<Entity, AABBPIJDNKN> OBJGOEEIBOB, JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x14DBCC0", Offset = "0x14DAAC0", VA = "0x1814DBCC0")]
		private JobHandle HGFHPHBLBNF(JobHandle MMNANIFKACM, JobHandle PDPBMCDLJEL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x14DBCC0", Offset = "0x14DAAC0", VA = "0x1814DBCC0")]
		private JobHandle HGFHPHBLBNF(JobHandle MMNANIFKACM, JobHandle PDPBMCDLJEL, JobHandle ENJBBFJMMIO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[IDOCBBAEIFB(JHEANMHFGAO.RenderEffects)]
	internal class PropagateHoverRootTag : IFMNIPACFHB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct HNMLMNIJIFP : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType AGHOPJPODLK
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EB00", Offset = "0x2F1D900", VA = "0x182F1EB00", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FGAGFABJPGB
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EAD0", Offset = "0x2F1D8D0", VA = "0x182F1EAD0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType BBCCCMGGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EB30", Offset = "0x2F1D930", VA = "0x182F1EB30", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EB60", Offset = "0x2F1D960", VA = "0x182F1EB60")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[IDOCBBAEIFB(JHEANMHFGAO.RenderEffects)]
	internal class PropagateSelectionRootTag : IFMNIPACFHB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct HEIGDHCDGLA : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType AGHOPJPODLK
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EBA0", Offset = "0x2F1D9A0", VA = "0x182F1EBA0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType FGAGFABJPGB
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EB70", Offset = "0x2F1D970", VA = "0x182F1EB70", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType BBCCCMGGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EBD0", Offset = "0x2F1D9D0", VA = "0x182F1EBD0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EB60", Offset = "0x2F1D960", VA = "0x182F1EB60")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[KJJBONLHBEH]
public class IEOGDLGIMGD : EJELJBKAGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4500", Offset = "0x2FC3300", VA = "0x182FC4500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4590", Offset = "0x2FC3390", VA = "0x182FC4590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public IEOGDLGIMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[KJJBONLHBEH]
public class AIDHNGOCLEF : EJELJBKAGMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct ENEBMAKMDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public ENEBMAKMDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct FGADLFAMLMJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct GLMNLAODEMO
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct JDFPCDNCLKP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime NEKPPBFLAMD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> GPDIHJAMCGF;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x42F70F0", Offset = "0x42F5EF0", VA = "0x1842F70F0")]
			public void LCKNJMOMOJE(AIDHNGOCLEF BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x42F7070", Offset = "0x42F5E70", VA = "0x1842F7070")]
			public JDFPCDNCLKP GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(JDFPCDNCLKP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager OFPCNLPKKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> GNLOMKJNGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private GLMNLAODEMO BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GLMNLAODEMO.JDFPCDNCLKP* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DACHFMAKJHG;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x3278140", Offset = "0x3276F40", VA = "0x183278140")]
		internal void MGNBBMBPACH(Entity JCNIDEIPPBD, SplinePointParentData LKPMINMHIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x32781B0", Offset = "0x3276FB0", VA = "0x1832781B0", Slot = "5")]
		public void ReadFromDisplayClass(ref ENEBMAKMDJC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x32781C0", Offset = "0x3276FC0", VA = "0x1832781C0", Slot = "6")]
		public void WriteToDisplayClass(ref ENEBMAKMDJC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x3277F70", Offset = "0x3276D70", VA = "0x183277F70", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x3277FE0", Offset = "0x3276DE0", VA = "0x183277FE0")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref GLMNLAODEMO.JDFPCDNCLKP HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x3278100", Offset = "0x3276F00", VA = "0x183278100")]
		public void LCKNJMOMOJE(AIDHNGOCLEF BLFNFNLAGKP, ref ENEBMAKMDJC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x3278090", Offset = "0x3276E90", VA = "0x183278090")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery ADGOJDEEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker NBIJEHHPJEC;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x34F4CA0", Offset = "0x34F3AA0", VA = "0x1834F4CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public AIDHNGOCLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x34F4A70", Offset = "0x34F3870", VA = "0x1834F4A70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x34F4910", Offset = "0x34F3710", VA = "0x1834F4910")]
	public static EntityQuery JPOOLLGFFGI(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[KJJBONLHBEH]
public class ICKGEBOJKNH : EJELJBKAGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery BHPDPHAKBMH;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC39E0", Offset = "0x2FC27E0", VA = "0x182FC39E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3A70", Offset = "0x2FC2870", VA = "0x182FC3A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public ICKGEBOJKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(IEOGDLGIMGD))]
public class JMBEMMFMPNM : MILJNGODHBE
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FCAE70", Offset = "0x2FC9C70", VA = "0x182FCAE70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public JMBEMMFMPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class KFFGJIGMDFL : EJELJBKAGMA, OMEPFIBEFCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct MCFLFKLKOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<BDCMCEOAOGF, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public MCFLFKLKOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CGFHNECFPHB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct PMGPOCCHPBN
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct JKNNELLDANF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BJKNEBPDPCL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> HHKMNGKGJNH;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x42FE0A0", Offset = "0x42FCEA0", VA = "0x1842FE0A0")]
			public void LCKNJMOMOJE(KFFGJIGMDFL BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x42FE020", Offset = "0x42FCE20", VA = "0x1842FE020")]
			public JKNNELLDANF GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(JKNNELLDANF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<BDCMCEOAOGF, Entity> IEPEFMMEENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private PMGPOCCHPBN BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PMGPOCCHPBN.JKNNELLDANF* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x42F4070", Offset = "0x42F2E70", VA = "0x1842F4070")]
		internal void MGNBBMBPACH(Entity JCNIDEIPPBD, ObjectNetworkIdComponentData BEFAGCDEHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C4C0", VA = "0x18098D6C0", Slot = "5")]
		public void ReadFromDisplayClass(ref MCFLFKLKOOC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x245E710", Offset = "0x245D510", VA = "0x18245E710", Slot = "6")]
		public void WriteToDisplayClass(ref MCFLFKLKOOC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x42F3E20", Offset = "0x42F2C20", VA = "0x1842F3E20", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x42F3EC0", Offset = "0x42F2CC0", VA = "0x1842F3EC0")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref PMGPOCCHPBN.JKNNELLDANF HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x42F3FE0", Offset = "0x42F2DE0", VA = "0x1842F3FE0")]
		public void LCKNJMOMOJE(KFFGJIGMDFL BLFNFNLAGKP, ref MCFLFKLKOOC MLHGGHKOFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x42F3F70", Offset = "0x42F2D70", VA = "0x1842F3F70")]
		public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService GCEPJPIBHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery ADGOJDEEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker NBIJEHHPJEC;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDC40", Offset = "0x2FCCA40", VA = "0x182FCDC40", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FCDB00", Offset = "0x2FCC900", VA = "0x182FCDB00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public KFFGJIGMDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD900", Offset = "0x2FCC700", VA = "0x182FCD900", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD7A0", Offset = "0x2FCC5A0", VA = "0x182FCD7A0")]
	public static EntityQuery JPOOLLGFFGI(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class DFOOMIILLOG : EJELJBKAGMA, OMEPFIBEFCP
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MPEPJCKHPID : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct IMKBDKAPGFK
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct EPGKOAHCCLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime FEONKABINHD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> APHFJMJCGHD;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x42FAAD0", Offset = "0x42F98D0", VA = "0x1842FAAD0")]
			public void LCKNJMOMOJE(DFOOMIILLOG BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x42FAA50", Offset = "0x42F9850", VA = "0x1842FAA50")]
			public EPGKOAHCCLF GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
			{
				return default(EPGKOAHCCLF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public DFOOMIILLOG KJLACBGDELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private IMKBDKAPGFK BAJKJFFAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IMKBDKAPGFK.EPGKOAHCCLF* MGLHGIKIIAD;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x3279D50", Offset = "0x3278B50", VA = "0x183279D50")]
		public void MGNBBMBPACH(Entity JCNIDEIPPBD, ParentData DGODKHBPMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3279B80", Offset = "0x3278980", VA = "0x183279B80", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3279BF0", Offset = "0x32789F0", VA = "0x183279BF0")]
		public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref IMKBDKAPGFK.EPGKOAHCCLF HCNHMEDKGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3279D10", Offset = "0x3278B10", VA = "0x183279D10")]
		public void LCKNJMOMOJE(DFOOMIILLOG BLFNFNLAGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x3279CA0", Offset = "0x3278AA0", VA = "0x183279CA0")]
		public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery ADGOJDEEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker NBIJEHHPJEC;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x350A550", Offset = "0x3509350", VA = "0x18350A550", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x350A440", Offset = "0x3509240", VA = "0x18350A440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public DFOOMIILLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x3509EF0", Offset = "0x3508CF0", VA = "0x183509EF0")]
	[CompilerGenerated]
	private void IPBGICHNKJF(Entity JCNIDEIPPBD, ParentData DGODKHBPMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x350A240", Offset = "0x3509040", VA = "0x18350A240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x350A0E0", Offset = "0x3508EE0", VA = "0x18350A0E0")]
	public static EntityQuery JPOOLLGFFGI(ComponentSystemBase BLFNFNLAGKP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class DMPEOBHOIAE : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int IODMDLFGLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery KFFFLMFFADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs EDGDLJOHDGN;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x350BBD0", Offset = "0x350A9D0", VA = "0x18350BBD0", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x350B910", Offset = "0x350A710", VA = "0x18350B910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x350B9F0", Offset = "0x350A7F0", VA = "0x18350B9F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x350B5C0", Offset = "0x350A3C0", VA = "0x18350B5C0")]
	private void CMGHBDKHNMI(Entity JCNIDEIPPBD, FJNOGBCPDIO CEBPAJMCGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public DMPEOBHOIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	[UpdateBefore(typeof(DMPEOBHOIAE))]
	public class PostLoadAddSceneTagEntity : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService JKMDIALCHLK;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CD00", Offset = "0x2F1BB00", VA = "0x182F1CD00", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CB40", Offset = "0x2F1B940", VA = "0x182F1CB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[COEFBNKMAPI(DADIFNCKKPF.OMRoom)]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	public class PostLoadInitializeNetworkId : MILJNGODHBE, OMEPFIBEFCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct JKGJDFFJNCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<BDCMCEOAOGF, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
			public JKGJDFFJNCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct IFHJOBJELDI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct PAGADPOOIOH
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct COPOIEDKDAP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime GGLBHNPLAIP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BJKNEBPDPCL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex LCGGFINGHNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> HHKMNGKGJNH;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x42FDBA0", Offset = "0x42FC9A0", VA = "0x1842FDBA0")]
				public void LCKNJMOMOJE(PostLoadInitializeNetworkId BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x42FDAF0", Offset = "0x42FC8F0", VA = "0x1842FDAF0")]
				public COPOIEDKDAP GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(COPOIEDKDAP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<BDCMCEOAOGF, Entity> IEPEFMMEENM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private PAGADPOOIOH BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PAGADPOOIOH.COPOIEDKDAP* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DACHFMAKJHG;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x42F96A0", Offset = "0x42F84A0", VA = "0x1842F96A0")]
			internal void MGNBBMBPACH(Entity JCNIDEIPPBD, int GJANFGHKCEO, ref ObjectNetworkIdComponentData BEFAGCDEHKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C4C0", VA = "0x18098D6C0", Slot = "5")]
			public void ReadFromDisplayClass(ref JKGJDFFJNCN MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x245E710", Offset = "0x245D510", VA = "0x18245E710", Slot = "6")]
			public void WriteToDisplayClass(ref JKGJDFFJNCN MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x42F93D0", Offset = "0x42F81D0", VA = "0x1842F93D0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x42F94C0", Offset = "0x42F82C0", VA = "0x1842F94C0")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref PAGADPOOIOH.COPOIEDKDAP HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x42F9600", Offset = "0x42F8400", VA = "0x1842F9600")]
			public void LCKNJMOMOJE(PostLoadInitializeNetworkId BLFNFNLAGKP, ref JKGJDFFJNCN MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x42F9590", Offset = "0x42F8390", VA = "0x1842F9590")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[CEFONNIACOK]
		private ObjectNetworkToLocalMapService GCEPJPIBHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[CEFONNIACOK]
		private SceneService AGNCLNMMDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery KFFFLMFFADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery PNADOJOJBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker FBMOFFGIMGK;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DAF0", Offset = "0x2F1C8F0", VA = "0x182F1DAF0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DA50", Offset = "0x2F1C850", VA = "0x182F1DA50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D6F0", Offset = "0x2F1C4F0", VA = "0x182F1D6F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D6F0", Offset = "0x2F1C4F0", VA = "0x182F1D6F0")]
		public void OJMCIGIGCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CDA0", Offset = "0x2F1BBA0", VA = "0x182F1CDA0")]
		private void ACIJLLLIMDA(NativeHashMap<BDCMCEOAOGF, Entity> IEPEFMMEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D2F0", Offset = "0x2F1C0F0", VA = "0x182F1D2F0")]
		private void NNEEAHOEBLK(NativeHashMap<BDCMCEOAOGF, Entity> IEPEFMMEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D7C0", Offset = "0x2F1C5C0", VA = "0x182F1D7C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D550", Offset = "0x2F1C350", VA = "0x182F1D550")]
		public static EntityQuery ODCGFNEGFNP(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class FCAGNNLLEFB : MILJNGODHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery OCLCGNDBFKN;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2FB89D0", Offset = "0x2FB77D0", VA = "0x182FB89D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8A60", Offset = "0x2FB7860", VA = "0x182FB8A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public FCAGNNLLEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class AIOKGCEPNJN : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::LJJOMMCCIHN<BFFPNPLHNJH> PGFCCIGKKOA;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x34F5C00", Offset = "0x34F4A00", VA = "0x1834F5C00", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x34F5900", Offset = "0x34F4700", VA = "0x1834F5900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x34F5770", Offset = "0x34F4570", VA = "0x1834F5770")]
	private void KIHMIEGHFHC(NativeList<EntityArchetype> AGILCDPGHJI, NativeHashMap<int, BCGDFNNBADB> JJLDGJJJFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x34F4F60", Offset = "0x34F3D60", VA = "0x1834F4F60")]
	private Span<int> CKCGFPNCNCP(EntityArchetype PAMNOPDNHEK)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x34F50A0", Offset = "0x34F3EA0", VA = "0x1834F50A0")]
	private bool FAMNMGKOIAL(int CABFLHODPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x34F5170", Offset = "0x34F3F70", VA = "0x1834F5170")]
	private void KGIHJNBDJLP(NativeHashMap<int, BCGDFNNBADB> JJLDGJJJFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public AIOKGCEPNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	public class PreSerializeRemoveEntities : MILJNGODHBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery ENJJFHBPCEG;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DBB0", Offset = "0x2F1C9B0", VA = "0x182F1DBB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DE30", Offset = "0x2F1CC30", VA = "0x182F1DE30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[IDOCBBAEIFB(JHEANMHFGAO.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : MILJNGODHBE, OMEPFIBEFCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct DOEGCMBDALG
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
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
			public DOEGCMBDALG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x3277F60", Offset = "0x3276D60", VA = "0x183277F60")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct PLAKLJDIDAD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> AJGFBNHKPHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> FEGHGIBGJDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity DGPMHALDBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> PCEDOMDPLLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int BLHAJHGIOOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType DLNLFAKMGEH;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x42FDE20", Offset = "0x42FCC20", VA = "0x1842FDE20")]
			internal void MGNBBMBPACH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x42FDFE0", Offset = "0x42FCDE0", VA = "0x1842FDFE0", Slot = "5")]
			public void ReadFromDisplayClass(ref DOEGCMBDALG MLHGGHKOFFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x42FDDF0", Offset = "0x42FCBF0", VA = "0x1842FDDF0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x42FDE00", Offset = "0x42FCC00", VA = "0x1842FDE00")]
			public void LCKNJMOMOJE(ShadowWorldApplyPropertyDifferencesToShadowWorld BLFNFNLAGKP, ref DOEGCMBDALG MLHGGHKOFFG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService DMLNIFBLILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle JBCGFEDAKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle CFENAPGOBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private DFHBAHEACEE NNMLCFCBKLN;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x32825F0", Offset = "0x32813F0", VA = "0x1832825F0", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x3281F00", Offset = "0x3280D00", VA = "0x183281F00")]
		public JobHandle EBHMHONOANK(JobHandle AGAPNFNLCKG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x3282250", Offset = "0x3281050", VA = "0x183282250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x3281F40", Offset = "0x3280D40", VA = "0x183281F40")]
		private bool EIMJIPBGEEC(JobHandle AGAPNFNLCKG, int CABFLHODPAB, out JobHandle KAGFFFJIJNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(HDPIHGBOAMO))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class GHJJFJMMKKA : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE7E0", Offset = "0x2FBD5E0", VA = "0x182FBE7E0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public GHJJFJMMKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(COIKOELAAFL))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class EFPEMLLAPPL : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x350E1C0", Offset = "0x350CFC0", VA = "0x18350E1C0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public EFPEMLLAPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(DPLAFAILNFE))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class FDOBOIJFAOC : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8C50", Offset = "0x2FB7A50", VA = "0x182FB8C50", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public FDOBOIJFAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(ECOAHKAJBBE))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class LLJGCKODBAN : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2F10", Offset = "0x2FD1D10", VA = "0x182FD2F10", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public LLJGCKODBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class DIFENJOHLLI : DHHPHFJDJBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override MPBDMNOPGNJ BJEBEHPHDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC980", Offset = "0x7FB780", VA = "0x1807FC980", Slot = "18")]
		get
		{
			return default(MPBDMNOPGNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public DIFENJOHLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(DNOJLBBKABM))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class ONNNAONBLPL : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2F091B0", Offset = "0x2F07FB0", VA = "0x182F091B0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public ONNNAONBLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class KLJIGLGNKDA : IHIDDBECDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public KLJIGLGNKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class FJOFOAIILED : DHHPHFJDJBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override MPBDMNOPGNJ BJEBEHPHDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "18")]
		get
		{
			return default(MPBDMNOPGNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9060", Offset = "0x2FB7E60", VA = "0x182FB9060")]
	public FJOFOAIILED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[PNDCBMPMNFM]
[ExecuteAlways]
[UpdateInGroup(typeof(JOIIIDFJBFG))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class MNIDPMAPOCM : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2F02930", Offset = "0x2F01730", VA = "0x182F02930", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public MNIDPMAPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class OKLCDHAIMEM : IHIDDBECDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public OKLCDHAIMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class PAOHDBAGNKA : IHIDDBECDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public PAOHDBAGNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class HHEDCFDBOPM : MILJNGODHBE
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public HHEDCFDBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[KJJBONLHBEH]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
public class EMPHBIGLBDH : MILJNGODHBE, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService HLDBOKPBKCE;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x350E590", Offset = "0x350D390", VA = "0x18350E590", Slot = "14")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x350E570", Offset = "0x350D370", VA = "0x18350E570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public EMPHBIGLBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct IPGOKPJPNOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float FEABDPOCALI = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> ECIOBOINEEM;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x32795F0", Offset = "0x32783F0", VA = "0x1832795F0", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x32797B0", Offset = "0x32785B0", VA = "0x1832797B0")]
			private bool JGIENEGKPGA(float3 KMCDOHPNFGD, float3 OMHFAAGAIBL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x3279580", Offset = "0x3278380", VA = "0x183279580")]
			private bool CCCFHDNEOAP(quaternion KMCDOHPNFGD, quaternion OMHFAAGAIBL)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct AOOPGMMOIKN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> DBEEGLOILAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> EKOPMNLPIEK;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x3276D50", Offset = "0x3275B50", VA = "0x183276D50", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly JFPIEAPAMJM CPAAJODBDBE;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly JFPIEAPAMJM PGJHMECGKOD;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly JFPIEAPAMJM PEMAIPJMGBK;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker ENDJDFCEABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private PFDBDLPMGFL MKGCDPCNJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x3505F40", Offset = "0x3504D40", VA = "0x183505F40", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x3505BA0", Offset = "0x35049A0", VA = "0x183505BA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x3505BD0", Offset = "0x35049D0", VA = "0x183505BD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class RegisterTransforms : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LMDBILAEJHD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct PKEIECFHFJL
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct BJEIMGDPAAK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<DFJCMDDKHKJ>.Runtime PJMPJEFEKPG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime AHINAFKKGOE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<DFJCMDDKHKJ> NHGBFFOIEMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> MIMNMHPDGPJ;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x42FDD70", Offset = "0x42FCB70", VA = "0x1842FDD70")]
				public void LCKNJMOMOJE(RegisterTransforms BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x42FDCB0", Offset = "0x42FCAB0", VA = "0x1842FDCB0")]
				public BJEIMGDPAAK GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(BJEIMGDPAAK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private PKEIECFHFJL BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PKEIECFHFJL.BJEIMGDPAAK* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OPAIIHPGPKD;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x42FC530", Offset = "0x42FB330", VA = "0x1842FC530")]
			internal void MGNBBMBPACH(Entity JCNIDEIPPBD, DFJCMDDKHKJ NKBOPBAMDKF, Transform GPMKACFJLBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x42FC2E0", Offset = "0x42FB0E0", VA = "0x1842FC2E0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x42FC3D0", Offset = "0x42FB1D0", VA = "0x1842FC3D0")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, ref PKEIECFHFJL.BJEIMGDPAAK HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x42FC520", Offset = "0x42FB320", VA = "0x1842FC520")]
			public void LCKNJMOMOJE(RegisterTransforms BLFNFNLAGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x42FC4B0", Offset = "0x42FB2B0", VA = "0x1842FC4B0")]
			public unsafe static void KCFOCILGNEE(ArchetypeChunkIterator* FLOHLFGOOMF, void* JBBJDJGADDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LKFCIJOKILM : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct DHPNJGCCEPK
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct PBLDFENJKIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LBDCAMMAAFJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<DFJCMDDKHKJ>.Runtime PJMPJEFEKPG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity HJDFNNAJEEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<DFJCMDDKHKJ> NHGBFFOIEMC;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x42F56E0", Offset = "0x42F44E0", VA = "0x1842F56E0")]
				public void LCKNJMOMOJE(RegisterTransforms BLFNFNLAGKP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x42F5660", Offset = "0x42F4460", VA = "0x1842F5660")]
				public PBLDFENJKIC GMGNLPAILMF(ref ArchetypeChunk JABEBAMHGPL, int JDDOKINLNEG, int LCBBIABGIAP)
				{
					return default(PBLDFENJKIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private DHPNJGCCEPK BAJKJFFAEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DHPNJGCCEPK.PBLDFENJKIC* MGLHGIKIIAD;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x42FC200", Offset = "0x42FB000", VA = "0x1842FC200")]
			internal void MGNBBMBPACH(Entity JCNIDEIPPBD, DFJCMDDKHKJ NKBOPBAMDKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x42FC0C0", Offset = "0x42FAEC0", VA = "0x1842FC0C0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x42FC150", Offset = "0x42FAF50", VA = "0x1842FC150")]
			public void FMFBJBODBLD(ref ArchetypeChunk GEBAOPIJCJA, [NoAlias] ref DHPNJGCCEPK.PBLDFENJKIC HCNHMEDKGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x42F56E0", Offset = "0x42F44E0", VA = "0x1842F56E0")]
			public void LCKNJMOMOJE(RegisterTransforms BLFNFNLAGKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private PFDBDLPMGFL MKGCDPCNJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery PAPKLMMAIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery PGGOAHGJJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery BPIBNGBFOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery EENNMODHMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery LGPDGHEMCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker NJJEKPJNBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery OCAJIPPBJBI;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x327C000", Offset = "0x327AE00", VA = "0x18327C000", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x327BAB0", Offset = "0x327A8B0", VA = "0x18327BAB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x327BCC0", Offset = "0x327AAC0", VA = "0x18327BCC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x327AE40", Offset = "0x3279C40", VA = "0x18327AE40")]
		private void HIJIFJHDGKE(EntityQuery KFFFLMFFADE, OBJHEKJMJHJ IEPAKMKMPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x327BD90", Offset = "0x327AB90", VA = "0x18327BD90")]
		private void PCHBMHLEBPI(EntityQuery KFFFLMFFADE, OBJHEKJMJHJ IEPAKMKMPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x327BC60", Offset = "0x327AA60", VA = "0x18327BC60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x327B250", Offset = "0x327A050", VA = "0x18327B250")]
		private void LMOLPDPBEIP(NativeArray<Entity> NMONLDLIICI, OBJHEKJMJHJ IEPAKMKMPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x327B390", Offset = "0x327A190", VA = "0x18327B390")]
		[BurstCompile]
		internal static void MAOCAFGJKLN(NativeArray<DFJCMDDKHKJ> ECAJIMILHMA, ComponentDataFromEntity<DFJCMDDKHKJ> JFECOIBPJGD, OBJHEKJMJHJ IEPAKMKMPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void AKPKAHKPMGN(Transform GPMKACFJLBP, Entity JCNIDEIPPBD, int CPOAAGLEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void BOBACEONNCJ(Entity JCNIDEIPPBD, int CPOAAGLEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void HIKFNGANDGJ(int CPOAAGLEIPE, OBJHEKJMJHJ IEPAKMKMPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x327AC60", Offset = "0x3279A60", VA = "0x18327AC60")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void CGDFKAFLFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x327B840", Offset = "0x327A640", VA = "0x18327B840", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x327B6A0", Offset = "0x327A4A0", VA = "0x18327B6A0")]
		public static EntityQuery MDLNKFPAEAM(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x327B080", Offset = "0x3279E80", VA = "0x18327B080")]
		public static EntityQuery KIJMPFEDNED(ComponentSystemBase BLFNFNLAGKP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	public class CopyTransformDataToGameObjects : MILJNGODHBE, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct EIMFDPOLNMB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> ECIOBOINEEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x3277A50", Offset = "0x3276850", VA = "0x183277A50", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct LDGABBENMCH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DBEEGLOILAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x32798D0", Offset = "0x32786D0", VA = "0x1832798D0", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PHCAHIBPJIN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DBEEGLOILAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> EKOPMNLPIEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> NMONLDLIICI;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x327AB60", Offset = "0x3279960", VA = "0x18327AB60", Slot = "4")]
			public void Execute(int CPOAAGLEIPE, TransformAccess GPMKACFJLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly JFPIEAPAMJM CPAAJODBDBE;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly JFPIEAPAMJM PGJHMECGKOD;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly JFPIEAPAMJM PEMAIPJMGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private PFDBDLPMGFL MKGCDPCNJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery LFNBNDOOLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery BIFKPBNCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery HHIADICDPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray PGFPNINHDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray JHMCLFMOBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray KLALIOBAKLI;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x3506D40", Offset = "0x3505B40", VA = "0x183506D40", Slot = "14")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x3506270", Offset = "0x3505070", VA = "0x183506270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x3506460", Offset = "0x3505260", VA = "0x183506460", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x35064F0", Offset = "0x35052F0", VA = "0x1835064F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x3506520", Offset = "0x3505320", VA = "0x183506520", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x35060F0", Offset = "0x3504EF0", VA = "0x1835060F0")]
		private NativeArray<Entity> OBLOJKKELOO(NativeArray<DFJCMDDKHKJ> AJGFBNHKPHM, NativeList<Entity> FBCKFKMPEEC, TransformAccessArray CLILJOEPNMN, TransformAccessArray CMPLDKONCNL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
	public class CopyTransformParentsToGameObjects : MILJNGODHBE, GLCKJEOBJPN
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private BIOAEAGLHAC FCCENJDDDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private CBIMKPJBECO BAPHNFLMDKN;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DFD0", Offset = "0x2F1CDD0", VA = "0x182F1DFD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x35070C0", Offset = "0x3505EC0", VA = "0x1835070C0", Slot = "14")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x3507290", Offset = "0x3506090", VA = "0x183507290", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x3506EA0", Offset = "0x3505CA0", VA = "0x183506EA0")]
		private static void EDGOIIHJNAC(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, Entity AABHIBJPKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x3507020", Offset = "0x3505E20", VA = "0x183507020")]
		private static bool EPBDFGPFLJL(EntityManager OFPCNLPKKAK, Entity JCNIDEIPPBD, out Transform GPMKACFJLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[IDOCBBAEIFB(JHEANMHFGAO.TransformSyncing)]
	public class L2PToL2WHierarchy : MILJNGODHBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct CMCAENMHNOK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> OEBEJFELHHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> EIBJKNGCNBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> PDPNPIOLDCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CJJAFGOJJML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> MMOGBIHKAPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> NJFHFCAKBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint CGAOIBNOEBI;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x42F4BB0", Offset = "0x42F39B0", VA = "0x1842F4BB0")]
			[Conditional("DEBUG_BUILD")]
			private void JJKCCHAFJKG(Entity JCNIDEIPPBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x42F44C0", Offset = "0x42F32C0", VA = "0x1842F44C0", Slot = "4")]
			public void Execute(ArchetypeChunk GEBAOPIJCJA, int CPOAAGLEIPE, int OAHIKLNKOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x42F47B0", Offset = "0x42F35B0", VA = "0x1842F47B0")]
			private void IPFAEDAILAJ(float4x4 DFNDKHOODOB, Entity JCNIDEIPPBD, bool BKMCKCDACBE, int ACNLMINHECG = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery AJJKAPMEJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery PBMPBLLEHHJ;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x2FD00B0", Offset = "0x2FCEEB0", VA = "0x182FD00B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2FD01D0", Offset = "0x2FCEFD0", VA = "0x182FD01D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class LPKONMFKPEM : CJCMIOIDEAO
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct JICPPPDMANG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> OEBEJFELHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> MMOGBIHKAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint CGAOIBNOEBI;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x42FB630", Offset = "0x42FA430", VA = "0x1842FB630", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int CPOAAGLEIPE, int OAHIKLNKOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x42FB730", Offset = "0x42FA530", VA = "0x1842FB730")]
		public bool LGJOKLEHNHL(ArchetypeChunk GEBAOPIJCJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery AJJKAPMEJML;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2F011E0", Offset = "0x2EFFFE0", VA = "0x182F011E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2F01310", Offset = "0x2F00110", VA = "0x182F01310", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BFOGDNFKDPF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public LPKONMFKPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class BMLMKAFFODA : CJCMIOIDEAO
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct EMJIFFPEJAK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> CMAAEDNDDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> EDPNGMNFBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> JFDPJKLLNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> LGGABMMKFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint CGAOIBNOEBI;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x3277B30", Offset = "0x3276930", VA = "0x183277B30", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int CPOAAGLEIPE, int OAHIKLNKOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x3277EE0", Offset = "0x3276CE0", VA = "0x183277EE0")]
		public bool LGJOKLEHNHL(ArchetypeChunk GEBAOPIJCJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery AGNKGGODJFF;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x34F9350", Offset = "0x34F8150", VA = "0x1834F9350", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x34F9460", Offset = "0x34F8260", VA = "0x1834F9460", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BFOGDNFKDPF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public BMLMKAFFODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class NGJMNNLMAHA : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct AAGCIKEOFOF : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> BFBCNFFNJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> KICHIFNBGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> EPFJLFDBPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> NBIHKBENPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint CGAOIBNOEBI;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x42F1F80", Offset = "0x42F0D80", VA = "0x1842F1F80", Slot = "4")]
		public void Execute(ArchetypeChunk GEBAOPIJCJA, int CPOAAGLEIPE, int OAHIKLNKOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x42F2690", Offset = "0x42F1490", VA = "0x1842F2690")]
		public bool LGJOKLEHNHL(ArchetypeChunk GEBAOPIJCJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery AGNKGGODJFF;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2F05D50", Offset = "0x2F04B50", VA = "0x182F05D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2F05E80", Offset = "0x2F04C80", VA = "0x182F05E80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BFOGDNFKDPF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	public NGJMNNLMAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[IDOCBBAEIFB(JHEANMHFGAO.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : IFMNIPACFHB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct BAGBMFOACHM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType AGHOPJPODLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EC30", Offset = "0x2F1DA30", VA = "0x182F1EC30", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType FGAGFABJPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EC00", Offset = "0x2F1DA00", VA = "0x182F1EC00", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType BBCCCMGGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2F1EC60", Offset = "0x2F1DA60", VA = "0x182F1EC60", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EB60", Offset = "0x2F1D960", VA = "0x182F1EB60")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[NMAJANCAMID(LDINJCOIDIB.Game)]
public class OOAEDCGDDCE : HKIHDNKIHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type MGBLAHCHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2F099D0", Offset = "0x2F087D0", VA = "0x182F099D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] EOBKPCMNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2F09A40", Offset = "0x2F08840", VA = "0x182F09A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public OOAEDCGDDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[NMAJANCAMID(LDINJCOIDIB.Loading)]
public class GEBNNOBCGFD : HKIHDNKIHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type MGBLAHCHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] EOBKPCMNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBD00", Offset = "0x2FBAB00", VA = "0x182FBBD00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GEBNNOBCGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class IAICHLIFPJL : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2FC35D0", Offset = "0x2FC23D0", VA = "0x182FC35D0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public IAICHLIFPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[NMAJANCAMID(LDINJCOIDIB.Saving)]
public class FKKJMFDBBGH : HKIHDNKIHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type MGBLAHCHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] EOBKPCMNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9410", Offset = "0x2FB8210", VA = "0x182FB9410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FKKJMFDBBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class AJJEHLNCFHB : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x34F5CA0", Offset = "0x34F4AA0", VA = "0x1834F5CA0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public AJJEHLNCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[NMAJANCAMID(LDINJCOIDIB.Simulation)]
public class PHGFCOJOADD : HKIHDNKIHGD
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type MGBLAHCHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2F176C0", Offset = "0x2F164C0", VA = "0x182F176C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] EOBKPCMNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2F17730", Offset = "0x2F16530", VA = "0x182F17730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PHGFCOJOADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[IHOFDNBJLIN(typeof(PDAAHKOFNIC), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
internal class PDAAHKOFNIC : GLCKJEOBJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::KJCGMHBOMNB<AuthoredParentData, ELDKDELLPKL, HNEJHFIBHAG, AuthoredChildrenData> EOKMLBKBEGJ;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2F16430", Offset = "0x2F15230", VA = "0x182F16430", Slot = "4")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PDAAHKOFNIC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(EntityHierarchyParents), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	internal sealed class EntityHierarchyParents : OMEPFIBEFCP, GLCKJEOBJPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[CEFONNIACOK]
		private OKNLNFBIJGH AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[CEFONNIACOK]
		private PropertyChangeNetworkRouter BDGEIMPBEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::GEDNEEKEDFO<Entity> PEJFAKHLGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::KJCGMHBOMNB<ParentData, JCEHBDNJLFJ, KGGJOEIDDFJ, ChildrenData> EOKMLBKBEGJ;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6E70", Offset = "0x2FB5C70", VA = "0x182FB6E70", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6D70", Offset = "0x2FB5B70", VA = "0x182FB6D70", Slot = "5")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6D20", Offset = "0x2FB5B20", VA = "0x182FB6D20")]
		public Entity FANBPIBOJLO(Entity JCNIDEIPPBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6CC0", Offset = "0x2FB5AC0", VA = "0x182FB6CC0")]
		public bool EBAMJBKGNPF(Entity JCNIDEIPPBD, Entity BANCJNAJPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6C20", Offset = "0x2FB5A20", VA = "0x182FB6C20")]
		public bool CNEDMMKBPIO(Entity JCNIDEIPPBD, Entity BANCJNAJPLD, bool HBGMGPFBFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x2FB6A40", Offset = "0x2FB5840", VA = "0x182FB6A40")]
		private bool BHFBGHNENCH(Entity JCNIDEIPPBD, Entity BANCJNAJPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(DOAPHHBMBCB), new string[] { })]
internal sealed class DOAPHHBMBCB : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[CEFONNIACOK]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery AHIPHDKNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x350C0D0", Offset = "0x350AED0", VA = "0x18350C0D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x350C6C0", Offset = "0x350B4C0", VA = "0x18350C6C0", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x350C0B0", Offset = "0x350AEB0", VA = "0x18350C0B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x350C120", Offset = "0x350AF20", VA = "0x18350C120")]
	public bool FMNODEAAPBM(Entity JCNIDEIPPBD, Entity FPEOKJIPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x350BF30", Offset = "0x350AD30", VA = "0x18350BF30")]
	public IEnumerable<Entity> BDMPNKHFGBN(Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x350C3A0", Offset = "0x350B1A0", VA = "0x18350C3A0")]
	public bool KMJPAMBDEGI(Entity JCNIDEIPPBD, Entity CPAHKPHLOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x350BFF0", Offset = "0x350ADF0", VA = "0x18350BFF0")]
	public bool DPFODLBBOCH(Entity JCNIDEIPPBD, Entity ABKMOKFEPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x350C5E0", Offset = "0x350B3E0", VA = "0x18350C5E0")]
	public NativeList<Entity> OFPGEPIEFNM(Entity JCNIDEIPPBD, bool KLLDICHECHI = false, Allocator HIEJKCFDMDD = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x350C1E0", Offset = "0x350AFE0", VA = "0x18350C1E0")]
	public IEnumerable<Entity> JCHDAOHELMN(Entity JCNIDEIPPBD, bool KLLDICHECHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x350C2F0", Offset = "0x350B0F0", VA = "0x18350C2F0")]
	public Entity KKMEGKLDKFD(Entity JCNIDEIPPBD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x350C2A0", Offset = "0x350B0A0", VA = "0x18350C2A0")]
	public NativeArray<Entity> KJBBIGONIBL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x350C460", Offset = "0x350B260", VA = "0x18350C460")]
	public bool LDLIMOIODDC(Entity ABKMOKFEPEA, Entity PCFJLKDJIEJ, out Entity NENMNHLIAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x350C530", Offset = "0x350B330", VA = "0x18350C530")]
	private Entity LFEBGMBMHJG(Entity JCNIDEIPPBD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public DOAPHHBMBCB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x24B3DA0", Offset = "0x24B2BA0", VA = "0x1824B3DA0")]
		public static void KKLPLLLGLNM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(AACHPGDKAKL PIMEDEKHCHH, global::GCBCNLLOIDF<Entity> MIJBBGDIDLJ, out global::KJCGMHBOMNB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> MOOLOPNEPBE) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, FJOBGJJBDLN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, FJOBGJJBDLN, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2F19010", Offset = "0x2F17E10", VA = "0x182F19010")]
		public static bool HODOOOBIMIA(HGGBOIBCHBA MECIOPPHKDA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class KJCGMHBOMNB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, FJOBGJJBDLN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, FJOBGJJBDLN, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::GEDNEEKEDFO<Entity> PEJFAKHLGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly IEFBGJOIBOH DKONDMNMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly ABFPBMDJHKI AABHIBJPKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly CBIMKPJBECO BAPHNFLMDKN;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x2729910", Offset = "0x2728710", VA = "0x182729910")]
	public KJCGMHBOMNB(AACHPGDKAKL PIMEDEKHCHH, global::GCBCNLLOIDF<Entity> MIJBBGDIDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x2728CB0", Offset = "0x2727AB0", VA = "0x182728CB0")]
	private bool LLGOOLMDAAB(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x2728D10", Offset = "0x2727B10", VA = "0x182728D10")]
	private bool NDOMFMMEDPJ(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x27285F0", Offset = "0x27273F0", VA = "0x1827285F0")]
	public bool EBAMJBKGNPF(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x27287E0", Offset = "0x27275E0", VA = "0x1827287E0")]
	public bool KCNDFGIAEDL(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x2728810", Offset = "0x2727610", VA = "0x182728810")]
	private bool KCNDFGIAEDL(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD, bool NOJABMGNAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void HOOEKCFOOAA(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void CGLHLAFLDNE(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void CIMDEAGEGCA(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void GMPJAGFDDPJ(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void CKPFEBENNCO(Entity JCNIDEIPPBD, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x2728620", Offset = "0x2727420", VA = "0x182728620")]
	private bool FMNODEAAPBM(Entity JCNIDEIPPBD, Entity FPEOKJIPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x2728E90", Offset = "0x2727C90", VA = "0x182728E90")]
	private void OAFPAINMHBC(Entity JCNIDEIPPBD, in Entity NPPHDNLMMMJ, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x2729120", Offset = "0x2727F20", VA = "0x182729120")]
	private void PHNIADLENHH(Entity JCNIDEIPPBD, in Entity NPPHDNLMMMJ, in Entity BANCJNAJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x27282D0", Offset = "0x27270D0", VA = "0x1827282D0")]
	private bool BIEELKOPLHL(NAJNNEBKKFH EAJHBIDMLML, in BDCMCEOAOGF IIOPJBKIFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x2728D60", Offset = "0x2727B60", VA = "0x182728D60")]
	private void NFAGHCDLJNP(Entity AABHIBJPKOH, Entity CPAHKPHLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x2728560", Offset = "0x2727360", VA = "0x182728560")]
	private void DCMJCJJFMCK(Entity AABHIBJPKOH, Entity CPAHKPHLOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private void HIKFNGANDGJ(Entity JCNIDEIPPBD, Entity NPPHDNLMMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private void AKPKAHKPMGN(Entity JCNIDEIPPBD, Entity BANCJNAJPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct CKDLLMNEAKK : GLIHFOOKOJB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public DBABCCFIPAO OAHDEFOEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E30", Offset = "0x6F6C30", VA = "0x1806F7E30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DBABCCFIPAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x704F60", Offset = "0x703D60", VA = "0x180704F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[IHOFDNBJLIN(typeof(ObjectEmbodimentService), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IDOCBBAEIFB(JHEANMHFGAO.Embodiment)]
	internal sealed class ObjectEmbodimentService : MDIBAMHLODM, FEBFHBLLFPI, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService OLBEJFPALDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[CEFONNIACOK]
		private OKNLNFBIJGH AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[CEFONNIACOK]
		private OHOMOGIIAEB HPEJLCLAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[CEFONNIACOK]
		private FJMONGKKEFI FCFKEEDHMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[CEFONNIACOK]
		private TransformOwnershipPhase GPOGNDEOKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<BDCMCEOAOGF, ILANHKOILOA> KNOKJNPAKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private AGMJJGBMNLJ AFODJKHJNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2F0BE50", Offset = "0x2F0AC50", VA = "0x182F0BE50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int BFNEFNAAHHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2F0DBD0", Offset = "0x2F0C9D0", VA = "0x182F0DBD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int AMAEFFCJNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2F0CDC0", Offset = "0x2F0BBC0", VA = "0x182F0CDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x22B82C0", Offset = "0x22B70C0", VA = "0x1822B82C0", Slot = "4")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DE10", Offset = "0x2F0CC10", VA = "0x182F0DE10", Slot = "5")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B4D0", Offset = "0x2F0A2D0", VA = "0x182F0B4D0")]
		public void EBKKMJJHLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CC70", Offset = "0x2F0BA70", VA = "0x182F0CC70", Slot = "6")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B3A0", Offset = "0x2F0A1A0", VA = "0x182F0B3A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BCA0", Offset = "0x2F0AAA0", VA = "0x182F0BCA0")]
		public int FDHCONDBMJA(SceneTag LJBGPBIAJII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D180", Offset = "0x2F0BF80", VA = "0x182F0D180")]
		public int LFKGNMEFEEE(SceneTag LJBGPBIAJII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B520", Offset = "0x2F0A320", VA = "0x182F0B520")]
		public bool ECFCGCIPLEM(Entity JCNIDEIPPBD, Allocator HIEJKCFDMDD, out NativeList<Entity> HBGAEDMOEND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C730", Offset = "0x2F0B530", VA = "0x182F0C730")]
		public bool JAKFMDOCBOB(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C020", Offset = "0x2F0AE20", VA = "0x182F0C020")]
		public bool HDLCOKAKBGL(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AAC0", Offset = "0x2F098C0", VA = "0x182F0AAC0")]
		public bool BEEDIGPHJBK(Entity JCNIDEIPPBD, out ILANHKOILOA BNOABMBMCLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AB30", Offset = "0x2F09930", VA = "0x182F0AB30")]
		private bool BEEDIGPHJBK(Transform GPMKACFJLBP, out ILANHKOILOA BNOABMBMCLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C440", Offset = "0x2F0B240", VA = "0x182F0C440")]
		private void IBGCJPGENLD(Entity JCNIDEIPPBD, ILANHKOILOA BNOABMBMCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C4D0", Offset = "0x2F0B2D0", VA = "0x182F0C4D0")]
		private bool IDCJIKFHJCG(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AC60", Offset = "0x2F09A60", VA = "0x182F0AC60")]
		public void CBFNCDGCFPB(BDCMCEOAOGF CONHLPJBCJE, ILANHKOILOA GKFKLPMILMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CDE0", Offset = "0x2F0BBE0", VA = "0x182F0CDE0")]
		public bool LANGLAOEIME(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A640", Offset = "0x2F09440", VA = "0x182F0A640")]
		public bool AKLOGHCFNOH(IMKMJFJEHIJ NAKKFJMFOAE, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A260", Offset = "0x2F09060", VA = "0x182F0A260")]
		public bool AKLOGHCFNOH(Entity JCNIDEIPPBD, [Optional] object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A620", Offset = "0x2F09420", VA = "0x182F0A620")]
		public bool AKLOGHCFNOH(ILANHKOILOA MECIOPPHKDA, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C040", Offset = "0x2F0AE40", VA = "0x182F0C040")]
		public bool HJJFHLFMMMF(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C410", Offset = "0x2F0B210", VA = "0x182F0C410")]
		public bool HJJFHLFMMMF(ILANHKOILOA BNOABMBMCLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A2B0", Offset = "0x2F090B0", VA = "0x182F0A2B0")]
		public bool AKLOGHCFNOH(ILANHKOILOA BNOABMBMCLM, [Optional] object INDCJAMMAIN, bool AJKJHFCHOAK = false, bool MJGDELPDOOK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CA20", Offset = "0x2F0B820", VA = "0x182F0CA20")]
		public Transform JLNLJGDDDCO(Entity JCNIDEIPPBD, [Optional] object INDCJAMMAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B7E0", Offset = "0x2F0A5E0", VA = "0x182F0B7E0")]
		public bool EPBDFGPFLJL(Entity JCNIDEIPPBD, out Transform GPMKACFJLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BD60", Offset = "0x2F0AB60", VA = "0x182F0BD60")]
		public ILANHKOILOA FKKCMHIMFCG(Entity JCNIDEIPPBD, [Optional] object INDCJAMMAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B110", Offset = "0x2F09F10", VA = "0x182F0B110")]
		public void DHJDFLHNBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B8B0", Offset = "0x2F0A6B0", VA = "0x182F0B8B0")]
		public void FBDBFOFJBCO(SceneTag LJBGPBIAJII, bool GNJPHMABINM, global::CGFMCBPNJIE<int> JLDDHHCOPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D5C0", Offset = "0x2F0C3C0", VA = "0x182F0D5C0")]
		private void NELOIJDJOKC(Entity JCNIDEIPPBD, bool GNJPHMABINM, bool MDPBFBAGJBF, global::CGFMCBPNJIE<int> JLDDHHCOPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BCC0", Offset = "0x2F0AAC0", VA = "0x182F0BCC0")]
		private void FEEDJKDDCEF(Entity JCNIDEIPPBD, ILANHKOILOA BNOABMBMCLM, bool GNJPHMABINM, bool MDPBFBAGJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CC20", Offset = "0x2F0BA20", VA = "0x182F0CC20")]
		public ILANHKOILOA KBDJBOGOFAM(Entity JCNIDEIPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ABE0", Offset = "0x2F099E0", VA = "0x182F0ABE0")]
		public bool BNAIPFKHFLN(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B090", Offset = "0x2F09E90", VA = "0x182F0B090")]
		public bool COJBMENHFIP(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B770", Offset = "0x2F0A570", VA = "0x182F0B770")]
		public bool EOKIBAAHBEM(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A1F0", Offset = "0x2F08FF0", VA = "0x182F0A1F0")]
		public bool AHFOKADJNJA(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A120", Offset = "0x2F08F20", VA = "0x182F0A120")]
		public bool AHFOKADJNJA(DBABCCFIPAO EFHAIHKDJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void AEANKNFCOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BEA0", Offset = "0x2F0ACA0", VA = "0x182F0BEA0")]
		private void GMNIDCGPDJJ(bool CGLPJIONAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CB90", Offset = "0x2F0B990", VA = "0x182F0CB90")]
		private bool JMCDFKMOEMG(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C980", Offset = "0x2F0B780", VA = "0x182F0C980")]
		private ILANHKOILOA JIMCGLLNBFD(Entity JCNIDEIPPBD, object INDCJAMMAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D2C0", Offset = "0x2F0C0C0", VA = "0x182F0D2C0")]
		private ILANHKOILOA MAELANEFCIF(Entity JCNIDEIPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DBF0", Offset = "0x2F0C9F0", VA = "0x182F0DBF0")]
		private (Vector3, Quaternion, Vector3) PFEJCLCGIHA(Entity JCNIDEIPPBD)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D4B0", Offset = "0x2F0C2B0", VA = "0x182F0D4B0")]
		private void MEMIOIGMCHM(Entity JCNIDEIPPBD, FJNOGBCPDIO CEBPAJMCGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BF60", Offset = "0x2F0AD60", VA = "0x182F0BF60")]
		private void GPFONEKFPPE(IMKMJFJEHIJ NAKKFJMFOAE, ILANHKOILOA GKFKLPMILMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D1A0", Offset = "0x2F0BFA0", VA = "0x182F0D1A0")]
		private void LJGHBHGNJKF(ILANHKOILOA GKFKLPMILMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AE60", Offset = "0x2F09C60", VA = "0x182F0AE60")]
		private void CKFHFKOIJPD(ILANHKOILOA BNOABMBMCLM, Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C4F0", Offset = "0x2F0B2F0", VA = "0x182F0C4F0")]
		private void INJBLGNALCD(Entity JCNIDEIPPBD, ILANHKOILOA BNOABMBMCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DAC0", Offset = "0x2F0C8C0", VA = "0x182F0DAC0")]
		private void NMFNFMDGJCM(Entity JCNIDEIPPBD, Transform GPMKACFJLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DBA0", Offset = "0x2F0C9A0", VA = "0x182F0DBA0")]
		private IMKMJFJEHIJ OHCNPCAHHHM(Entity JCNIDEIPPBD)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DF90", Offset = "0x2F0CD90", VA = "0x182F0DF90")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A9F0", Offset = "0x2F097F0", VA = "0x182F0A9F0")]
		[CompilerGenerated]
		private void AMBJLOKEAGL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class NCIDDMDDFGN
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2F03D70", Offset = "0x2F02B70", VA = "0x182F03D70")]
	public static ILANHKOILOA FKKCMHIMFCG(this ObjectEmbodimentService BDIHCGGPFJK, IMKMJFJEHIJ NAKKFJMFOAE, [Optional] object INDCJAMMAIN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[IHOFDNBJLIN(typeof(ObjectLifecycleService), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Lifecycle)]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	internal sealed class ObjectLifecycleService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService BNOABMBMCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private JODABNJDPMN CKHENOELGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects MMHMLKIBHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2F0F240", Offset = "0x2F0E040", VA = "0x182F0F240")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, FJNOGBCPDIO> DONEGBAALDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2F0F1A0", Offset = "0x2F0DFA0", VA = "0x182F0F1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E9A0", Offset = "0x2F0D7A0", VA = "0x182F0E9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> BJHABEDGKAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2F0F2D0", Offset = "0x2F0E0D0", VA = "0x182F0F2D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2F0F500", Offset = "0x2F0E300", VA = "0x182F0F500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F600", Offset = "0x2F0E400", VA = "0x182F0F600", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x15023B0", Offset = "0x15011B0", VA = "0x1815023B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F370", Offset = "0x2F0E170", VA = "0x182F0F370")]
		public bool HKAKAEDOFMA(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EA40", Offset = "0x2F0D840", VA = "0x182F0EA40")]
		internal void CBFLEMHMOAD(Entity JCNIDEIPPBD, FJNOGBCPDIO CEBPAJMCGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F290", Offset = "0x2F0E090", VA = "0x182F0F290")]
		public void FOPACEHLIHG(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F4B0", Offset = "0x2F0E2B0", VA = "0x182F0F4B0")]
		public void KHLIDCHCHCH(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F3F0", Offset = "0x2F0E1F0", VA = "0x182F0F3F0")]
		private bool HPHCLPNOHOG(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EFA0", Offset = "0x2F0DDA0", VA = "0x182F0EFA0")]
		public void ECKNMJDFBGK(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EDE0", Offset = "0x2F0DBE0", VA = "0x182F0EDE0")]
		private bool DOKDKDNIMJP(Entity JCNIDEIPPBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ED50", Offset = "0x2F0DB50", VA = "0x182F0ED50")]
		public void DJMNLJGHIEI(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F5A0", Offset = "0x2F0E3A0", VA = "0x182F0F5A0")]
		private void OGKHNLGHKIE(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EAA0", Offset = "0x2F0D8A0", VA = "0x182F0EAA0")]
		private void CEBJFJNLFBA(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ED00", Offset = "0x2F0DB00", VA = "0x182F0ED00")]
		public void CNLAAENDOEF(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private void HJIFNPKBEGK(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E7A0", Offset = "0x2F0D5A0", VA = "0x182F0E7A0")]
		private void ANBFODMLBPG(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(ObjectPrefabs), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Prefabs)]
	internal class ObjectPrefabs : LICICFNIOJE, OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class OKNDJHDJPGE : IEnumerable<(IEAEMGCPMCM, FJNOGBCPDIO)>, IEnumerable, IEnumerator<(IEAEMGCPMCM, FJNOGBCPDIO)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (IEAEMGCPMCM primitiveType, FJNOGBCPDIO prefabType) <>2__current;

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
			private (IEAEMGCPMCM, FJNOGBCPDIO) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x2A90170", Offset = "0x2A8EF70", VA = "0x182A90170", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((IEAEMGCPMCM, FJNOGBCPDIO));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x42FDA60", Offset = "0x42FC860", VA = "0x1842FDA60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x42F2B80", Offset = "0x42F1980", VA = "0x1842F2B80")]
			[DebuggerHidden]
			public OKNDJHDJPGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x42FD880", Offset = "0x42FC680", VA = "0x1842FD880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x42FDA20", Offset = "0x42FC820", VA = "0x1842FDA20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x42FD980", Offset = "0x42FC780", VA = "0x1842FD980", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(IEAEMGCPMCM, FJNOGBCPDIO)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x42FD980", Offset = "0x42FC780", VA = "0x1842FD980", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<FJNOGBCPDIO, Entity> EDGDLJOHDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<FJNOGBCPDIO, EntityArchetype> AGILCDPGHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<IEAEMGCPMCM, FJNOGBCPDIO> AJCNPCGKNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<BFOCONIHCAE, FJNOGBCPDIO> HDALHFFMFFD;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int OAHKGMMAIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2F12C90", Offset = "0x2F11A90", VA = "0x182F12C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2F12600", Offset = "0x2F11400", VA = "0x182F12600")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2F13210", Offset = "0x2F12010", VA = "0x182F13210", Slot = "5")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2F11F90", Offset = "0x2F10D90", VA = "0x182F11F90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2F12790", Offset = "0x2F11590", VA = "0x182F12790")]
		internal IEnumerable<Type> HBLEKDJNGPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2F11E60", Offset = "0x2F10C60", VA = "0x182F11E60")]
		internal IJIDHKFHCOH COINLCMJONI(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2F122C0", Offset = "0x2F110C0", VA = "0x182F122C0")]
		public EntityArchetype EAMBANJMEFE(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2F12320", Offset = "0x2F11120", VA = "0x182F12320")]
		public NativeHashMap<int, EntityArchetype> ECFHHCHLAOD(Allocator HIEJKCFDMDD = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2F11D80", Offset = "0x2F10B80", VA = "0x182F11D80")]
		public bool CGKAOIAIGLH(FJNOGBCPDIO CEBPAJMCGMI, out EntityArchetype PAMNOPDNHEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2F131A0", Offset = "0x2F11FA0", VA = "0x182F131A0", Slot = "4")]
		[IteratorStateMachine(typeof(OKNDJHDJPGE))]
		public IEnumerable<(IEAEMGCPMCM, FJNOGBCPDIO)> PCELEAIKOFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2F12CE0", Offset = "0x2F11AE0", VA = "0x182F12CE0")]
		public Entity LHCKMOLIBHC(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2F11ED0", Offset = "0x2F10CD0", VA = "0x182F11ED0")]
		public FJNOGBCPDIO COMINONLBDJ(BFOCONIHCAE MAIOHDHBGKE)
		{
			return default(FJNOGBCPDIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2F11F30", Offset = "0x2F10D30", VA = "0x182F11F30")]
		public FJNOGBCPDIO COMINONLBDJ(IEAEMGCPMCM MAIOHDHBGKE)
		{
			return default(FJNOGBCPDIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2F12620", Offset = "0x2F11420", VA = "0x182F12620")]
		public NativeHashMap<int, Entity> GKDDLPHNHII(Allocator HIEJKCFDMDD = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2F12C40", Offset = "0x2F11A40", VA = "0x182F12C40")]
		public IEnumerable<FJNOGBCPDIO> JMIDBEOBEAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2F13140", Offset = "0x2F11F40", VA = "0x182F13140")]
		public Entity OAGABIFMDEK(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2F11DF0", Offset = "0x2F10BF0", VA = "0x182F11DF0")]
		public bool CIIKBEGAIPK(FJNOGBCPDIO CEBPAJMCGMI, out Entity BCDGDEJOBOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2F127F0", Offset = "0x2F115F0", VA = "0x182F127F0")]
		private void IJFNCFNNDPO(IJIDHKFHCOH CIBKMAHLAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2F12DF0", Offset = "0x2F11BF0", VA = "0x182F12DF0")]
		internal void LJGDKACDKBO(FJNOGBCPDIO CEBPAJMCGMI, ComponentTypeList EIGPIJPJEJB, NLMJMBFOPDM MGGDKNIBBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2F124A0", Offset = "0x2F112A0", VA = "0x182F124A0")]
		private void FIGHMPIKLKK(FJNOGBCPDIO CEBPAJMCGMI, ComponentTypeList ELCPBBOBCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2F13020", Offset = "0x2F11E20", VA = "0x182F13020")]
		internal Entity LPMKLHLMEEA(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2F13640", Offset = "0x2F12440", VA = "0x182F13640")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum MPBDMNOPGNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface GNPPALLBBNK
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World HNNGMFGFANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	PFFHCOJLDFL GAJGIMCGONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class JDCIHALPMPG : MJDNLBEBKGH, DFHBAHEACEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly EJHMLJPFJGO DBNNLOLDDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly MPBDMNOPGNJ GPOGNDEOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<LEHIHKILMLK> OOFPNGJHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, AABBPIJDNKN> JGKGLGIPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> KMFADCDJJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle MDFCFGMGHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle GLGNKMAFJBC;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World FOIKLOLCMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC80B0", Offset = "0x2FC6EB0", VA = "0x182FC80B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private PFFHCOJLDFL EBGHJCALJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7F40", Offset = "0x2FC6D40", VA = "0x182FC7F40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private GFBEOCDMBIH JKHJMEHCBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x833030", Offset = "0x831E30", VA = "0x180833030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, AABBPIJDNKN> JLLFNDGKCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x746150", Offset = "0x744F50", VA = "0x180746150", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, AABBPIJDNKN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle LHJAKALABPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x787580", Offset = "0x786380", VA = "0x180787580", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0xC0BFF0", Offset = "0xC0ADF0", VA = "0x180C0BFF0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool FMKNMGLFNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7A90", Offset = "0x2FC6890", VA = "0x182FC7A90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World LNFCPGHLDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7D10", Offset = "0x2FC6B10", VA = "0x182FC7D10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8420", Offset = "0x2FC7220", VA = "0x182FC8420")]
	public JDCIHALPMPG(EJHMLJPFJGO DBNNLOLDDNP, MPBDMNOPGNJ GPOGNDEOKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7630", Offset = "0x2FC6430", VA = "0x182FC7630", Slot = "11")]
	private void AFLDFHOMLIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8330", Offset = "0x2FC7130", VA = "0x182FC8330", Slot = "10")]
	private bool NAPMENGGNDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7E50", Offset = "0x2FC6C50", VA = "0x182FC7E50", Slot = "12")]
	private void IAMDPAAGCJO(ComponentType DLNLFAKMGEH, in LEHIHKILMLK CBKNNPPJIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2FC79E0", Offset = "0x2FC67E0", VA = "0x182FC79E0", Slot = "13")]
	private bool CGADKOLCMBC(FJNOGBCPDIO CEBPAJMCGMI, out Entity BCDGDEJOBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7D70", Offset = "0x2FC6B70", VA = "0x182FC7D70", Slot = "16")]
	private bool GHPAGNEPEMN(out NativeArray<int> OKAJHMMGLNJ, Allocator HIEJKCFDMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7860", Offset = "0x2FC6660", VA = "0x182FC7860", Slot = "17")]
	private bool BNHMEDMDMOK(ComponentType DLNLFAKMGEH, out LEHIHKILMLK LIEJDKCHOLJ, out IFJHKNELHMM NCJAMNCMCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7730", Offset = "0x2FC6530", VA = "0x182FC7730", Slot = "18")]
	private bool BNHMEDMDMOK(ComponentType DLNLFAKMGEH, out LEHIHKILMLK LIEJDKCHOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7640", Offset = "0x2FC6440", VA = "0x182FC7640", Slot = "19")]
	private LEHIHKILMLK ANPDPJDCINK(ComponentType DLNLFAKMGEH)
	{
		return default(LEHIHKILMLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7A50", Offset = "0x2FC6850", VA = "0x182FC7A50", Slot = "20")]
	private DHPCBFPABEE COJPFCEKCNA()
	{
		return default(DHPCBFPABEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7E10", Offset = "0x2FC6C10", VA = "0x182FC7E10", Slot = "21")]
	private void HMJLEGGFDLJ(JobHandle FMCMEMBCJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7AA0", Offset = "0x2FC68A0", VA = "0x182FC7AA0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8110", Offset = "0x2FC6F10", VA = "0x182FC8110")]
	private bool MBCFBLBOACK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7F60", Offset = "0x2FC6D60", VA = "0x182FC7F60")]
	private int LJIOOPBOBPP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class EJHMLJPFJGO : GNPPALLBBNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public CIHNJOKIFOM JNAMKKKCPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService EDGDLJOHDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public PFFHCOJLDFL KEOBONJEKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public GFBEOCDMBIH CABHHDBCLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public GAOHFHDCKGK JCGEPMMMEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World HNNGMFGFANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x350E3F0", Offset = "0x350D1F0", VA = "0x18350E3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PFFHCOJLDFL GAJGIMCGONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EJHMLJPFJGO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(PropertyDiffStateService), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.PropertyChanges)]
	internal class PropertyDiffStateService : OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct GMNKCLOGNOJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly MPBDMNOPGNJ FBMCJFKFBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService CAEONEDMKLM;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x42F7170", Offset = "0x42F5F70", VA = "0x1842F7170")]
			public GMNKCLOGNOJ(PropertyDiffStateService CAEONEDMKLM, MPBDMNOPGNJ MGEFCIPPPDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x42F7150", Offset = "0x42F5F50", VA = "0x1842F7150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly EJHMLJPFJGO DBNNLOLDDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly JDCIHALPMPG[] FCHMDKBHOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private MPBDMNOPGNJ NGNJMKPDFFH;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public GNPPALLBBNK JFCPNDPDLIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public DFHBAHEACEE DCPHLJGJFFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2C24C40", Offset = "0x2C23A40", VA = "0x182C24C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public MJDNLBEBKGH PMHHDKKFMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2C24C40", Offset = "0x2C23A40", VA = "0x182C24C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0xD35690", Offset = "0xD34490", VA = "0x180D35690")]
		public DFHBAHEACEE BMDMLHEKGFI(MPBDMNOPGNJ GPOGNDEOKKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0xD35690", Offset = "0xD34490", VA = "0x180D35690")]
		public MJDNLBEBKGH PHDENLJCMMN(MPBDMNOPGNJ GPOGNDEOKKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F201B0", Offset = "0x2F1EFB0", VA = "0x182F201B0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FE30", Offset = "0x2F1EC30", VA = "0x182F1FE30", Slot = "5")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FDD0", Offset = "0x2F1EBD0", VA = "0x182F1FDD0")]
		public void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2F1FCF0", Offset = "0x2F1EAF0", VA = "0x182F1FCF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2F20190", Offset = "0x2F1EF90", VA = "0x182F20190")]
		public GMNKCLOGNOJ MDAAGCOMNLM(MPBDMNOPGNJ GPOGNDEOKKI)
		{
			return default(GMNKCLOGNOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2F20280", Offset = "0x2F1F080", VA = "0x182F20280")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	[IHOFDNBJLIN(typeof(SceneService), new string[] { })]
	internal class SceneService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag LFBNNNCIBFF;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string FADPIGFMFKJ = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string AOLDHHMGAFH = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[CEFONNIACOK]
		private PFJMLCCOCEN BPPPDOJBHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[CEFONNIACOK]
		private ObjectEmbodimentService BNOABMBMCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[CEFONNIACOK]
		private IEFBGJOIBOH KKGLMHJCDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[CEFONNIACOK]
		private SingletonComponentService ODKOLPJKECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[CEFONNIACOK]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[CEFONNIACOK]
		private PhotonInstanceCleanupService JCKNJAFABAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery CCNMKJKDEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery BIJJFNLDHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery BNIOHEFIOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity ABOJNEDMPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool GFPBEENKENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x327C9C0", Offset = "0x327B7C0", VA = "0x18327C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> KIACHNJMLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x9E3700", Offset = "0x9E2500", VA = "0x1809E3700")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x9E3820", Offset = "0x9E2620", VA = "0x1809E3820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity PKLFBOPEAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x327CBE0", Offset = "0x327B9E0", VA = "0x18327CBE0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag MGAACJHLDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x327DBE0", Offset = "0x327C9E0", VA = "0x18327DBE0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity OOMAOOHFDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x327DBE0", Offset = "0x327C9E0", VA = "0x18327DBE0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x327CD40", Offset = "0x327BB40", VA = "0x18327CD40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x327C970", Offset = "0x327B770", VA = "0x18327C970")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x327DED0", Offset = "0x327CCD0", VA = "0x18327DED0", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x327C770", Offset = "0x327B570", VA = "0x18327C770", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x327DFF0", Offset = "0x327CDF0", VA = "0x18327DFF0")]
		public void PNFABOMPPKH(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x327C550", Offset = "0x327B350", VA = "0x18327C550")]
		public NativeArray<Entity> CMCNFADMFOO(Allocator HIEJKCFDMDD = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x327C7C0", Offset = "0x327B5C0", VA = "0x18327C7C0")]
		public void FKALNGJAHLJ(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x327CFA0", Offset = "0x327BDA0", VA = "0x18327CFA0")]
		public Entity KFLFMEHKHGE(string EOPECGOILOC = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x327DBC0", Offset = "0x327C9C0", VA = "0x18327DBC0")]
		public void NENJFECEKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x327C5C0", Offset = "0x327B3C0", VA = "0x18327C5C0")]
		public void DDJKINEDHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x327CA70", Offset = "0x327B870", VA = "0x18327CA70")]
		public void HBAKOLJBINM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x327CD30", Offset = "0x327BB30", VA = "0x18327CD30")]
		public void HOCEDNAMGFH(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x327CDB0", Offset = "0x327BBB0", VA = "0x18327CDB0")]
		public bool IDPCMGALPBE(Entity LJBGPBIAJII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x327CF90", Offset = "0x327BD90", VA = "0x18327CF90")]
		public void KEGCDFNELEF(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x327CE60", Offset = "0x327BC60", VA = "0x18327CE60")]
		public string JECFGLJEFDF(Entity LJBGPBIAJII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		public void BKBHMDHJBDL(Entity LJBGPBIAJII, string EOPECGOILOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x327CF70", Offset = "0x327BD70", VA = "0x18327CF70")]
		public bool KBDFMJDNMGE(string EOPECGOILOC, out Entity LJBGPBIAJII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x327CAD0", Offset = "0x327B8D0", VA = "0x18327CAD0")]
		public void HJKENOMIJFF(Entity LJBGPBIAJII, bool GDOPFNLIAMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x327C3B0", Offset = "0x327B1B0", VA = "0x18327C3B0")]
		public void BAEODNFBJJM(Entity JCNIDEIPPBD, bool CPOEEJMJPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x327C340", Offset = "0x327B140", VA = "0x18327C340")]
		public void BAEODNFBJJM(NativeArray<Entity> NMONLDLIICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x327C430", Offset = "0x327B230", VA = "0x18327C430")]
		public void BAEODNFBJJM(EntityQuery KFFFLMFFADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x327D8F0", Offset = "0x327C6F0", VA = "0x18327D8F0")]
		public void MKFONFEKPIK(Entity JCNIDEIPPBD, Entity LJBGPBIAJII, bool CPOEEJMJPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x327D710", Offset = "0x327C510", VA = "0x18327D710")]
		public void MKFONFEKPIK(NativeArray<Entity> NMONLDLIICI, Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x327D660", Offset = "0x327C460", VA = "0x18327D660")]
		public void MKFONFEKPIK(EntityQuery KFFFLMFFADE, Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x327D4B0", Offset = "0x327C2B0", VA = "0x18327D4B0")]
		private void MJKPKNFFKCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x327D3D0", Offset = "0x327C1D0", VA = "0x18327D3D0")]
		private void LEGHJLJPDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x327CBE0", Offset = "0x327B9E0", VA = "0x18327CBE0")]
		private Entity LLJDDOFALMH()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x327C8C0", Offset = "0x327B6C0", VA = "0x18327C8C0")]
		private void FKONKPLLGCH(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x327D300", Offset = "0x327C100", VA = "0x18327D300")]
		private void KNANHBIOCIK(EntityQuery AKGIAIMIPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x327D020", Offset = "0x327BE20", VA = "0x18327D020")]
		private void KNANHBIOCIK(NativeArray<Entity> AGNCLNMMDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x327D400", Offset = "0x327C200", VA = "0x18327D400")]
		private void LHNDEIAIHLN(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x327DC30", Offset = "0x327CA30", VA = "0x18327DC30")]
		private void OIOHGMGOONJ(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x327DD60", Offset = "0x327CB60", VA = "0x18327DD60")]
		private void ONGOCHOBHLI(SceneTag KGKHMGHLEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x327C580", Offset = "0x327B380", VA = "0x18327C580")]
		private void CPDOMCNOAAI(SceneTag KGKHMGHLEEI, global::CGFMCBPNJIE<int> JLDDHHCOPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x327C5E0", Offset = "0x327B3E0", VA = "0x18327C5E0")]
		private void DPNGOEDENHK(SceneTag KGKHMGHLEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x327DB20", Offset = "0x327C920", VA = "0x18327DB20")]
		private void NDCEEGBGGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x578EF10", Offset = "0x578DD10", VA = "0x18578EF10")]
		private void CAPJCIIAOGB<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GNAOHMKEHFK(SceneTag KGKHMGHLEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x327CA10", Offset = "0x327B810", VA = "0x18327CA10")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GCDFPOBCIKO(EntityQuery KFFFLMFFADE, string EOPECGOILOC, SceneTag KGKHMGHLEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x327C520", Offset = "0x327B320", VA = "0x18327C520")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BNKEGNJCBPJ(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BDKAJHNFDAG(Entity LJBGPBIAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[KBDLNAGCCOG(DADIFNCKKPF.PhotonRoom)]
	[IHOFDNBJLIN(typeof(GDIPKNJIAPN), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	internal class UnitySceneService : OMEPFIBEFCP, GDIPKNJIAPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[CEFONNIACOK]
		private SceneService AGNCLNMMDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> PNOLKHJIOEC;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x328BAE0", Offset = "0x328A8E0", VA = "0x18328BAE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x328BD90", Offset = "0x328AB90", VA = "0x18328BD90", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x328BE20", Offset = "0x328AC20", VA = "0x18328BE20", Slot = "5")]
		public void PNFABOMPPKH(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x328BB30", Offset = "0x328A930", VA = "0x18328BB30", Slot = "6")]
		public bool HAGOMPLGOEG(IMKMJFJEHIJ NAKKFJMFOAE, Transform GPMKACFJLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x328BD20", Offset = "0x328AB20", VA = "0x18328BD20")]
		private bool NGBNCMJNKFL(Scene LJBGPBIAJII, out Entity FKFDINFPHNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x328BF90", Offset = "0x328AD90", VA = "0x18328BF90")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	[IHOFDNBJLIN(typeof(SingletonComponentService), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	internal sealed class SingletonComponentService : OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[CEFONNIACOK]
		private IEFBGJOIBOH KKGLMHJCDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity JCNIDEIPPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList ELCPBBOBCBJ;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int OAHKGMMAIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x3282C00", Offset = "0x3281A00", VA = "0x183282C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity FEOLBGIIBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager OJBGCHBGJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x3282A10", Offset = "0x3281810", VA = "0x183282A10")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x57907F0", Offset = "0x578F5F0", VA = "0x1857907F0")]
		public T BPAEGFNIDAI<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x57908B0", Offset = "0x578F6B0", VA = "0x1857908B0")]
		public void NIPKJFNBLBF<T>(T NLHFEJHKLAH) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x3282F10", Offset = "0x3281D10", VA = "0x183282F10", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x3282A60", Offset = "0x3281860", VA = "0x183282A60", Slot = "5")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x3282A60", Offset = "0x3281860", VA = "0x183282A60")]
		private void NNMOIJIKOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x3282740", Offset = "0x3281540", VA = "0x183282740", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x3282C10", Offset = "0x3281A10", VA = "0x183282C10")]
		private ComponentTypeList MPKHOKDMJMN()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void LPNNKECAMBD(int PHHDFCFDFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		private static void IEGDPGOBJNM(Type MAIOHDHBGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x32826A0", Offset = "0x32814A0", VA = "0x1832826A0")]
		private static void BKJAHHIBHNK(Type MAIOHDHBGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct KBJDKGDILGB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
[IHOFDNBJLIN(typeof(FJMONGKKEFI), new string[] { })]
internal sealed class FJMONGKKEFI : OMEPFIBEFCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[CEFONNIACOK]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::AHICODAJBCD<PMKLOAKAKED, Entity> PEBMAAAMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::FEMGHOFDHBI<FEOOIJNFKLL> CGKKKFKPHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::FEMGHOFDHBI<GKBEFCFPFLP> HPLKCKDNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::FEMGHOFDHBI<OHHCFFJFKDM> JOHCLEHGDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::FEMGHOFDHBI<NHDKFDCJNKN> LEHDPJKLEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::FEMGHOFDHBI<CKDLLMNEAKK> BDIHCGGPFJK;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::CGDDICCPEIB<Entity> HBBDKOPHBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public BGOPFALLDEO LPNCPAKDKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public BGOPFALLDEO HDKGDGNNBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public BGOPFALLDEO IEHOHHEJBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public BGOPFALLDEO NJGBBEHBKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public BGOPFALLDEO HLBHDNJLABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8F00", Offset = "0x2FB7D00", VA = "0x182FB8F00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8F50", Offset = "0x2FB7D50", VA = "0x182FB8F50", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8E10", Offset = "0x2FB7C10", VA = "0x182FB8E10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x22807C0", Offset = "0x227F5C0", VA = "0x1822807C0")]
	private void KKLPLLLGLNM<T>(ref global::FEMGHOFDHBI<T> DOKHJFOLKHN) where T : struct, GLIHFOOKOJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x22807C0", Offset = "0x227F5C0", VA = "0x1822807C0")]
	private void KKLPLLLGLNM<TC, TV>(ref global::AHICODAJBCD<TC, TV> DOKHJFOLKHN) where TC : struct, GLIHFOOKOJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FJMONGKKEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[IHOFDNBJLIN(typeof(PFDBDLPMGFL), new string[] { })]
[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
internal sealed class PFDBDLPMGFL : FEBFHBLLFPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private OBJHEKJMJHJ ELIKMDAMIGJ;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public OBJHEKJMJHJ OIOHHIPCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x244E000", Offset = "0x244CE00", VA = "0x18244E000")]
		get
		{
			return default(OBJHEKJMJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2F169E0", Offset = "0x2F157E0", VA = "0x182F169E0", Slot = "4")]
	public void BMOJFJKBKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2F16A70", Offset = "0x2F15870", VA = "0x182F16A70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PFDBDLPMGFL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(TransformOwnershipPhase), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum KGDLFNAGBHB
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct LFEFFFFPEFL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private KGDLFNAGBHB GPACBAPIHAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase AABHIBJPKOH;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x42FBFA0", Offset = "0x42FADA0", VA = "0x1842FBFA0")]
			public LFEFFFFPEFL(TransformOwnershipPhase AABHIBJPKOH, KGDLFNAGBHB GPOGNDEOKKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x42FBF80", Offset = "0x42FAD80", VA = "0x1842FBF80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public KGDLFNAGBHB GPOGNDEOKKI;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public KGDLFNAGBHB AELFAHOAGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
			get
			{
				return default(KGDLFNAGBHB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x768440", Offset = "0x767240", VA = "0x180768440")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool LIIGCNIECBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xF8D150", Offset = "0xF8BF50", VA = "0x180F8D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool ELENGNOMKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x243EF10", Offset = "0x243DD10", VA = "0x18243EF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x3286270", Offset = "0x3285070", VA = "0x183286270")]
		public LFEFFFFPEFL ELCGCEAOAMG()
		{
			return default(LFEFFFFPEFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x3286240", Offset = "0x3285040", VA = "0x183286240")]
		public LFEFFFFPEFL BGEOJHIHNIE()
		{
			return default(LFEFFFFPEFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[IHOFDNBJLIN(typeof(CAAGPBCIJFG), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Circuits)]
	public class CircuitsService : OMEPFIBEFCP, CAAGPBCIJFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[CEFONNIACOK]
		private NDNLEMDBPDG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager OFPCNLPKKAK;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x34FEC60", Offset = "0x34FDA60", VA = "0x1834FEC60", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x34FE040", Offset = "0x34FCE40", VA = "0x1834FE040", Slot = "5")]
		public bool HCOCBHHMKIO(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x34FEB70", Offset = "0x34FD970", VA = "0x1834FEB70", Slot = "7")]
		public bool PHGPJAEJJNO(IMKMJFJEHIJ NAKKFJMFOAE, out Guid PMONFGDLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x34FE1B0", Offset = "0x34FCFB0", VA = "0x1834FE1B0", Slot = "8")]
		public Guid IDANNJMEKON(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x34FED00", Offset = "0x34FDB00", VA = "0x1834FED00", Slot = "9")]
		public void PKLGGLHHPHF(IMKMJFJEHIJ NAKKFJMFOAE, Guid PMONFGDLPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x34FEA80", Offset = "0x34FD880", VA = "0x1834FEA80", Slot = "10")]
		public bool MGDLLDMLJLP(IMKMJFJEHIJ NAKKFJMFOAE, out Guid GCICBCMOAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x34FDF30", Offset = "0x34FCD30", VA = "0x1834FDF30", Slot = "11")]
		public Guid GOMHCNDENNJ(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x34FE820", Offset = "0x34FD620", VA = "0x1834FE820", Slot = "12")]
		public void MCFONEHALDL(IMKMJFJEHIJ NAKKFJMFOAE, Guid GCICBCMOAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x34FE2C0", Offset = "0x34FD0C0", VA = "0x1834FE2C0", Slot = "13")]
		public bool IFMMIPBAJAM(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x34FE140", Offset = "0x34FCF40", VA = "0x1834FE140", Slot = "14")]
		public void HEEMEECFPPH(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x34FE460", Offset = "0x34FD260", VA = "0x1834FE460", Slot = "15")]
		public void IOOIOIIBLEB(IMKMJFJEHIJ INOJNNAPINL, IMKMJFJEHIJ AABHIBJPKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x34FEF60", Offset = "0x34FDD60", VA = "0x1834FEF60")]
		private void PNJPLBEIEMD(CABOOPAOGML FELGODJOFIB, IMKMJFJEHIJ AABHIBJPKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x34FDC90", Offset = "0x34FCA90", VA = "0x1834FDC90")]
		private void AFGNEOFDKED(CABOOPAOGML FELGODJOFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x34FE310", Offset = "0x34FD110", VA = "0x1834FE310")]
		private bool IIMNLDLJANH(HGGBOIBCHBA BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x34FDE20", Offset = "0x34FCC20", VA = "0x1834FDE20")]
		private bool BIEOJAIMJGN(HGGBOIBCHBA BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x34FDED0", Offset = "0x34FCCD0", VA = "0x1834FDED0", Slot = "6")]
		public bool BNHIBKDDJPG(IMKMJFJEHIJ LNCGECBHMHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[IHOFDNBJLIN(typeof(NHOHKFBEOBA), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Connectables)]
	internal class ConnectableService : NHOHKFBEOBA, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class GFEPPDHPGJB : IEnumerable<IMKMJFJEHIJ>, IEnumerable, IEnumerator<IMKMJFJEHIJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private IMKMJFJEHIJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private IMKMJFJEHIJ localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public IMKMJFJEHIJ <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private IMKMJFJEHIJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(IMKMJFJEHIJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x32787C0", Offset = "0x32775C0", VA = "0x1832787C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x795390", Offset = "0x794190", VA = "0x180795390")]
			[DebuggerHidden]
			public GFEPPDHPGJB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x3278810", Offset = "0x3277610", VA = "0x183278810", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x32783D0", Offset = "0x32771D0", VA = "0x1832783D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x32788E0", Offset = "0x32776E0", VA = "0x1832788E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x3278930", Offset = "0x3277730", VA = "0x183278930")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x3278780", Offset = "0x3277580", VA = "0x183278780", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x32786D0", Offset = "0x32774D0", VA = "0x1832786D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IMKMJFJEHIJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x32786D0", Offset = "0x32774D0", VA = "0x1832786D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly JFPIEAPAMJM IIPLGJBKFLA;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int HLHEPIIOMME = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int GLFBGLGOFEB = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private OKNLNFBIJGH AGNKGGODJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private IDJFGKMJFPG JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService NANMPEAOEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::GEDNEEKEDFO<Entity> NHMGAHPAOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::GEDNEEKEDFO<float3> KAJPMKGLGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::GEDNEEKEDFO<quaternion> AAEIMPFHJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::GEDNEEKEDFO<Entity> AABHIBJPKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::GEDNEEKEDFO<float3> BELKCDDMLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::GEDNEEKEDFO<quaternion> DADJJDDMKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> LMEPPHBMKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> OMOBFPJOMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery AHIPHDKNHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<EAHMEFMNIMN> PNLLBHLABPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x702430", Offset = "0x701230", VA = "0x180702430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x7025E0", Offset = "0x7013E0", VA = "0x1807025E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<IMKMJFJEHIJ, IMKMJFJEHIJ> GNNKDHNHLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x3504440", Offset = "0x3503240", VA = "0x183504440", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x3503A00", Offset = "0x3502800", VA = "0x183503A00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<IMKMJFJEHIJ, IMKMJFJEHIJ> EOBBDINECHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x3503AA0", Offset = "0x35028A0", VA = "0x183503AA0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x3503690", Offset = "0x3502490", VA = "0x183503690", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<IMKMJFJEHIJ, IMKMJFJEHIJ, IMKMJFJEHIJ> NLIFIMKDJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x3504AE0", Offset = "0x35038E0", VA = "0x183504AE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x3503B40", Offset = "0x3502940", VA = "0x183503B40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<IMKMJFJEHIJ> HKIMAGJHBFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x3503360", Offset = "0x3502160", VA = "0x183503360", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x35038B0", Offset = "0x35026B0", VA = "0x1835038B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x35047F0", Offset = "0x35035F0", VA = "0x1835047F0", Slot = "25")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x3503C80", Offset = "0x3502A80", VA = "0x183503C80", Slot = "26")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x3502F80", Offset = "0x3501D80", VA = "0x183502F80", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x3503130", Offset = "0x3501F30", VA = "0x183503130")]
		private void ELKLMODGLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x3504970", Offset = "0x3503770", VA = "0x183504970")]
		private void PJMLJAPFANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x3504220", Offset = "0x3503020", VA = "0x183504220")]
		private void LHCMJIKMBNA(Entity JCNIDEIPPBD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OMHFAAGAIBL, KNIHKHKCMFB KMCDOHPNFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x35043E0", Offset = "0x35031E0", VA = "0x1835043E0")]
		private void LHPBELBOMIO(Entity JCNIDEIPPBD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OMHFAAGAIBL, KNIHKHKCMFB KMCDOHPNFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x14DBCC0", Offset = "0x14DAAC0", VA = "0x1814DBCC0", Slot = "14")]
		public IMKMJFJEHIJ LGOJKKNGHJM(IMKMJFJEHIJ NAKKFJMFOAE, int LKJHPHCFFNF)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x17FB250", Offset = "0x17FA050", VA = "0x1817FB250", Slot = "15")]
		public Color KDFCEBMBJGJ(IMKMJFJEHIJ NAKKFJMFOAE, int LKJHPHCFFNF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x35034B0", Offset = "0x35022B0", VA = "0x1835034B0", Slot = "16")]
		public float3 FGDFONPPFGA(IMKMJFJEHIJ NAKKFJMFOAE, int LKJHPHCFFNF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x3503950", Offset = "0x3502750", VA = "0x183503950", Slot = "17")]
		public bool HMHIFBMHKHO(IMKMJFJEHIJ NAKKFJMFOAE, IMKMJFJEHIJ NIOPFEILAMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3503400", Offset = "0x3502200", VA = "0x183503400", Slot = "18")]
		public IMKMJFJEHIJ FFJAMPLPPAC(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3502DA0", Offset = "0x3501BA0", VA = "0x183502DA0", Slot = "21")]
		public void ABBKJEJCOMJ(IMKMJFJEHIJ NAKKFJMFOAE, Vector3 MFFGKJEKPKE, Quaternion JOGKAFHKAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3503BE0", Offset = "0x35029E0", VA = "0x183503BE0", Slot = "23")]
		public float3 JPELOMHECCE(OCPOEPHJLEB DPJMCPPCMHK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x35044E0", Offset = "0x35032E0", VA = "0x1835044E0", Slot = "24")]
		public quaternion OBDKJDNIMGI(OCPOEPHJLEB DPJMCPPCMHK)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3504120", Offset = "0x3502F20", VA = "0x183504120", Slot = "28")]
		public RigidTransform LFAMODFABBO(OCPOEPHJLEB DPJMCPPCMHK)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x3503730", Offset = "0x3502530", VA = "0x183503730", Slot = "22")]
		public bool GEHAIDHGELJ(IMKMJFJEHIJ NAKKFJMFOAE, out RigidTransform EGECNCPDFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3502EF0", Offset = "0x3501CF0", VA = "0x183502EF0", Slot = "19")]
		[IteratorStateMachine(typeof(GFEPPDHPGJB))]
		public IEnumerable<IMKMJFJEHIJ> ANODGCAGODI(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x3504690", Offset = "0x3503490", VA = "0x183504690", Slot = "20")]
		public IMKMJFJEHIJ OPCAHMNPLGD(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x3503190", Offset = "0x3501F90", VA = "0x183503190", Slot = "29")]
		public void ENMGPBAJPFN(ref List<IMKMJFJEHIJ> CECFOEGDIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x3504570", Offset = "0x3503370", VA = "0x183504570")]
		private Entity OPCAHMNPLGD(Entity JCNIDEIPPBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3504C10", Offset = "0x3503A10", VA = "0x183504C10")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[IDOCBBAEIFB(JHEANMHFGAO.Prefabs)]
	[IHOFDNBJLIN(typeof(ObjectInstantiationService), new string[] { })]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	internal sealed class ObjectInstantiationService : OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[CEFONNIACOK]
		private CIHNJOKIFOM PGJEGNBAENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[CEFONNIACOK]
		private ALIEOEHNBBG PDJKOADBJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[CEFONNIACOK]
		private FDEPNHHLDLD ECMGKBGCJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[CEFONNIACOK]
		private ObjectNetworkToLocalMapService GCEPJPIBHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[CEFONNIACOK]
		private ObjectLifecycleService OLBEJFPALDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[CEFONNIACOK]
		private ObjectPrefabs EDGDLJOHDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[CEFONNIACOK]
		private LDDHDONLPKD FOEONDLIJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private JODABNJDPMN CKHENOELGFL;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int KCLKMFOHLMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2F0E250", Offset = "0x2F0D050", VA = "0x182F0E250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E620", Offset = "0x2F0D420", VA = "0x182F0E620", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E580", Offset = "0x2F0D380", VA = "0x182F0E580")]
		public Entity PFACIDCOHNN(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E470", Offset = "0x2F0D270", VA = "0x182F0E470")]
		public Entity KKPFEJHGOEM(BDCMCEOAOGF CONHLPJBCJE, FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E390", Offset = "0x2F0D190", VA = "0x182F0E390")]
		public Entity GCKBCNOJALH(FJNOGBCPDIO CEBPAJMCGMI, bool FCOKMKIPNPC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E380", Offset = "0x2F0D180", VA = "0x182F0E380")]
		public Entity GCKBCNOJALH(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E240", Offset = "0x2F0D040", VA = "0x182F0E240")]
		public Entity CNBKCLGBMEL()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E5A0", Offset = "0x2F0D3A0", VA = "0x182F0E5A0")]
		public Entity PGNBFOLHCCA(IEAEMGCPMCM MAIOHDHBGKE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E300", Offset = "0x2F0D100", VA = "0x182F0E300")]
		public Entity FJAMIAFEIPO(BFOCONIHCAE MAIOHDHBGKE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E4D0", Offset = "0x2F0D2D0", VA = "0x182F0E4D0")]
		public NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)> LHCKMOLIBHC(NativeArray<IMKMJFJEHIJ> KELBJKLPPLD, Allocator HIEJKCFDMDD)
		{
			return default(NativeArray<(IMKMJFJEHIJ, IMKMJFJEHIJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E420", Offset = "0x2F0D220", VA = "0x182F0E420")]
		public IEnumerable<FJNOGBCPDIO> JMIDBEOBEAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E2A0", Offset = "0x2F0D0A0", VA = "0x182F0E2A0")]
		public EntityArchetype EAMBANJMEFE(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E520", Offset = "0x2F0D320", VA = "0x182F0E520")]
		public Entity OAGABIFMDEK(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E010", Offset = "0x2F0CE10", VA = "0x182F0E010")]
		private Entity BPKAJCNFKNO(FJNOGBCPDIO CEBPAJMCGMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E090", Offset = "0x2F0CE90", VA = "0x182F0E090")]
		private Entity BPKAJCNFKNO(FJNOGBCPDIO CEBPAJMCGMI, bool FCOKMKIPNPC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E120", Offset = "0x2F0CF20", VA = "0x182F0E120")]
		private Entity BPKAJCNFKNO(FJNOGBCPDIO CEBPAJMCGMI, BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[IHOFDNBJLIN(typeof(DPDPICMJPAD), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public sealed class PhysicsSceneColliderService : DPDPICMJPAD, OEHPEGMEEGJ, FEBFHBLLFPI, OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string POFHKFHGIHO = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int AONFADHKODC = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int FKMGEILEBGH = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[CEFONNIACOK]
		private OHOMOGIIAEB HPEJLCLAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] OEDEGBNCFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] DDCNCHECHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::OBLKPMNJCIK<OPIFAPKDMPP, BoxCollider> LLFHLEKPIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene LJBGPBIAJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene EPFMOIICCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject BCDGDEJOBOG;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int EJLIBPPLCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2F198D0", Offset = "0x2F186D0", VA = "0x182F198D0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2F19550", Offset = "0x2F18350", VA = "0x182F19550", Slot = "9")]
		public void BMOJFJKBKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A800", Offset = "0x2F19600", VA = "0x182F1A800", Slot = "10")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2F19BA0", Offset = "0x2F189A0", VA = "0x182F19BA0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A420", Offset = "0x2F19220", VA = "0x182F1A420", Slot = "4")]
		public OPIFAPKDMPP MOOBHJFGCCP(Entity JCNIDEIPPBD)
		{
			return default(OPIFAPKDMPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2F19910", Offset = "0x2F18710", VA = "0x182F19910", Slot = "5")]
		public void DGMCMDIMKJO(NativeArray<OPIFAPKDMPP> KGOPFMGEEOF, NativeArray<DCNPECHIJBP> KHDGHDAJIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2F19DC0", Offset = "0x2F18BC0", VA = "0x182F19DC0", Slot = "6")]
		public void GGGMMMAPJDL(OPIFAPKDMPP EFHAIHKDJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A2C0", Offset = "0x2F190C0", VA = "0x182F1A2C0", Slot = "7")]
		public bool JLFKJGEAMCH(OPIFAPKDMPP EFHAIHKDJDK, out Collider KAGGBODOCIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2F19FB0", Offset = "0x2F18DB0", VA = "0x182F19FB0")]
		public bool JEFIOCCBAIC(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, Allocator HIEJKCFDMDD, out NativeArray<Entity> NMONLDLIICI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A3D0", Offset = "0x2F191D0", VA = "0x182F1A3D0")]
		private void MKGAKHMDFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x703CF0", Offset = "0x702AF0", VA = "0x180703CF0")]
		private void IFCOEMLOAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A5B0", Offset = "0x2F193B0", VA = "0x182F1A5B0")]
		private void NIPCOOGDCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xD42840", Offset = "0xD41640", VA = "0x180D42840")]
		private void CFCDMJAKJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2F19E90", Offset = "0x2F18C90", VA = "0x182F19E90")]
		private BoxCollider ILKBAJDFDMP(Entity JCNIDEIPPBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2F19B20", Offset = "0x2F18920", VA = "0x182F19B20")]
		private void DOLDPAENCIE(BoxCollider KMFLPGANCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A570", Offset = "0x2F19370", VA = "0x182F1A570")]
		[Conditional("UNITY_EDITOR")]
		private void NCNOMNJLIEH(GameObject AAMBGNNHMBI, Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A610", Offset = "0x2F19410", VA = "0x182F1A610")]
		private void PBOCNCCHIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2F19CB0", Offset = "0x2F18AB0", VA = "0x182F19CB0")]
		private void EPJPAJFFBND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2F196C0", Offset = "0x2F184C0", VA = "0x182F196C0")]
		private void CFHDMNCCDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A360", Offset = "0x2F19160", VA = "0x182F1A360")]
		private void KAPHGMEAKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A600", Offset = "0x2F19400", VA = "0x182F1A600")]
		private void OFEPKBEGAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A390", Offset = "0x2F19190", VA = "0x182F1A390")]
		private void MBKOLKIGBCG(Scene PJOGBBEECJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2F19CA0", Offset = "0x2F18AA0", VA = "0x182F19CA0", Slot = "8")]
		private bool EAINCKILGBJ(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, Allocator HIEJKCFDMDD, out NativeArray<Entity> NMONLDLIICI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[IHOFDNBJLIN(typeof(NLHOPPOCDJH), new string[] { })]
public sealed class CJPOHPIDOPK : NLHOPPOCDJH, OMEPFIBEFCP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct DHMMPHOJNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float JCCNICLOFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint AMGJBIFICNF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private OEHPEGMEEGJ PGDGEJJDCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private HKCFLKKELHP MICDOLPJABP;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x34FCD50", Offset = "0x34FBB50", VA = "0x1834FCD50", Slot = "5")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x34FC7A0", Offset = "0x34FB5A0", VA = "0x1834FC7A0")]
	public bool JEFIOCCBAIC(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, out GOKILNDMBEE KBCOPOLIJPB, out Entity FEFGIJKLDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x34FCC50", Offset = "0x34FBA50", VA = "0x1834FCC50")]
	public static bool PADFCBIIOGL(in Span<GOKILNDMBEE> CLMDOHKHKCP, float EMEIKNNEGHK, out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x34FCC20", Offset = "0x34FBA20", VA = "0x1834FCC20")]
	public static float OGLKHNEMLCG(float JCCNICLOFED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public CJPOHPIDOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x34FC790", Offset = "0x34FB590", VA = "0x1834FC790", Slot = "4")]
	private bool HHLLJBPAPBH(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, out GOKILNDMBEE KBCOPOLIJPB, out Entity FEFGIJKLDHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[IHOFDNBJLIN(typeof(HKCFLKKELHP), new string[] { })]
public sealed class NHAJFFDKICA : HKCFLKKELHP, OMEPFIBEFCP
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct IHJCCIEKNAC : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> NMONLDLIICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 COKNMHKADEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 JEDOGDJCING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> HEPEKIDHCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> GCGJEIMIKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> CAFDKACDNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> BLLHHJMMJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> MHLOADKADMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<GOKILNDMBEE> GEPKBMGLJCP;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly GOKILNDMBEE PAJAABOPFGL;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x42F9950", Offset = "0x42F8750", VA = "0x1842F9950", Slot = "4")]
		public void Execute(int CPOAAGLEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x42FA5C0", Offset = "0x42F93C0", VA = "0x1842FA5C0")]
		private static float3 LEAHDHDLFLH(in float4x4 KPMBAPECPPG, in float3 BDHLMGMJDKP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x42FA400", Offset = "0x42F9200", VA = "0x1842FA400")]
		private static float3 LCAEPNOHPCN(in float4x4 KPMBAPECPPG, in float3 IJADEPADDKL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x42FA300", Offset = "0x42F9100", VA = "0x1842FA300")]
		private static float3 IANIJKOHEHF(in float4x4 KPMBAPECPPG, in float3 BDHLMGMJDKP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x42F9730", Offset = "0x42F8530", VA = "0x1842F9730")]
		private static float3 CCBAKPIBCNC(in float4x4 KPMBAPECPPG, in float3 IJADEPADDKL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x42FA690", Offset = "0x42F9490", VA = "0x1842FA690")]
		private bool MIFKOHCPLCK(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, in NativeArray<Entity> IMMNELOICBP, out float3 KBCOPOLIJPB, out float3 FBLODFOLDGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x42F9C30", Offset = "0x42F8A30", VA = "0x1842F9C30")]
		public static bool HFGLJLLPPAO(in float3 OOANACINKLJ, in float3 JOCIKFKONAL, in float3 DDBKAFDLLPL, in float3 IICBCHIGHEA, float DGKPNEBCGBH, float LOGEMHNKGGE, out float KFBDCAJNIAB, out float3 CJONLFIMNPH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x2F064E0", Offset = "0x2F052E0", VA = "0x182F064E0", Slot = "5")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x2F05FF0", Offset = "0x2F04DF0", VA = "0x182F05FF0")]
	public void JEFIOCCBAIC(in NativeArray<Entity> NMONLDLIICI, in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, in NativeArray<GOKILNDMBEE> EFKDIEDEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NHAJFFDKICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x2F064D0", Offset = "0x2F052D0", VA = "0x182F064D0", Slot = "4")]
	private void OCDMOBBPAMI(in NativeArray<Entity> NMONLDLIICI, in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, in NativeArray<GOKILNDMBEE> EFKDIEDEPHN)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[IDOCBBAEIFB(JHEANMHFGAO.Embodiment)]
	[KBDLNAGCCOG(DADIFNCKKPF.OMRoom)]
	[IHOFDNBJLIN(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[CEFONNIACOK]
		private CIHNJOKIFOM JNAMKKKCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[CEFONNIACOK]
		private ALIEOEHNBBG FIJPDDLDGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[CEFONNIACOK]
		private FDEPNHHLDLD FILGANKAPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private LMLOCAEKAJL NGPKJGJONLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<BDCMCEOAOGF, Entity> HPCNOIHFFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager OFPCNLPKKAK;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<BDCMCEOAOGF, Entity> EOPHGCPPPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2B80", Offset = "0x9F1980", VA = "0x1809F2B80")]
			get
			{
				return default(NativeHashMap<BDCMCEOAOGF, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint LIEFMBNMGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2F11570", Offset = "0x2F10370", VA = "0x182F11570")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool NOIGHNNNJBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x71BCF0", Offset = "0x71AAF0", VA = "0x18071BCF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x71C1E0", Offset = "0x71AFE0", VA = "0x18071C1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2F11C10", Offset = "0x2F10A10", VA = "0x182F11C10", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2F116D0", Offset = "0x2F104D0", VA = "0x182F116D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2F11740", Offset = "0x2F10540", VA = "0x182F11740")]
		public void FDAOBHPPNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2F117C0", Offset = "0x2F105C0", VA = "0x182F117C0")]
		public void FHJHDJOKGDB(BDCMCEOAOGF CONHLPJBCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2F11BE0", Offset = "0x2F109E0", VA = "0x182F11BE0")]
		private IMKMJFJEHIJ OHCNPCAHHHM(Entity JCNIDEIPPBD)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2F11980", Offset = "0x2F10780", VA = "0x182F11980")]
		public IMKMJFJEHIJ GGBDBGCDFJE(BDCMCEOAOGF CONHLPJBCJE)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2F11AC0", Offset = "0x2F108C0", VA = "0x182F11AC0")]
		public BDCMCEOAOGF MBLCFJOHPHH(IMKMJFJEHIJ NAKKFJMFOAE)
		{
			return default(BDCMCEOAOGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2F11B50", Offset = "0x2F10950", VA = "0x182F11B50")]
		public void ODEIKJNGINL(Entity JCNIDEIPPBD, BDCMCEOAOGF CONHLPJBCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2F115A0", Offset = "0x2F103A0", VA = "0x182F115A0")]
		public void BFBBOHNNCOO(Entity JCNIDEIPPBD, BDCMCEOAOGF CONHLPJBCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2F11A60", Offset = "0x2F10860", VA = "0x182F11A60")]
		public void JBLJACDKNAJ(Entity JCNIDEIPPBD, BDCMCEOAOGF CONHLPJBCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2F11600", Offset = "0x2F10400", VA = "0x182F11600")]
		public void CELBAFBLABA(Entity JCNIDEIPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
	[IHOFDNBJLIN(typeof(PropertyEventCallbacksService), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Callbacks)]
	public class PropertyEventCallbacksService : OMEPFIBEFCP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct GIHDEDEDBKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public OBKLONFHNKC JDLJMIHPPKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type MAIOHDHBGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int MBCLCCPKDLG;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct FLPPNEJACCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public GIHDEDEDBKK[] KELFDPANAFC;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void OBKLONFHNKC(Entity JCNIDEIPPBD, OJNODEDDEDC OINBNOFPHAF, KNIHKHKCMFB OMHFAAGAIBL, KNIHKHKCMFB KMCDOHPNFGD);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<OJNODEDDEDC, OBKLONFHNKC> DNGICEGFANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, FLPPNEJACCH> LPBDAEECLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private FKJKMJONNAG KELFDPANAFC;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action GPFLPCKEKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2F20580", Offset = "0x2F1F380", VA = "0x182F20580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2F20B70", Offset = "0x2F1F970", VA = "0x182F20B70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action IBHEOOCECEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2F20A30", Offset = "0x2F1F830", VA = "0x182F20A30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2F20AD0", Offset = "0x2F1F8D0", VA = "0x182F20AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2F21550", Offset = "0x2F20350", VA = "0x182F21550", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2F20620", Offset = "0x2F1F420", VA = "0x182F20620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2F20410", Offset = "0x2F1F210", VA = "0x182F20410")]
		public void CBFNCDGCFPB(OJNODEDDEDC OINBNOFPHAF, OBKLONFHNKC JDLJMIHPPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2F20320", Offset = "0x2F1F120", VA = "0x182F20320")]
		public void APEOGIALEBE(OJNODEDDEDC OINBNOFPHAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2F206B0", Offset = "0x2F1F4B0", VA = "0x182F206B0")]
		internal void FEFPINJPBHN(DFHBAHEACEE NNMLCFCBKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2F21010", Offset = "0x2F1FE10", VA = "0x182F21010")]
		private void NNGPGCMBMKP(DFHBAHEACEE NNMLCFCBKLN, int CABFLHODPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2F20C10", Offset = "0x2F1FA10", VA = "0x182F20C10")]
		private void MPLMPGACHIL(CPLDKIAEKDJ DCLGFFDBANO, KKDMPHCELIM CPAFPGDNJPD, GIHDEDEDBKK PDBHOJABDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2F20E90", Offset = "0x2F1FC90", VA = "0x182F20E90")]
		private FLPPNEJACCH NFOGHBJMGGM(CPLDKIAEKDJ DCLGFFDBANO, KKDMPHCELIM CPAFPGDNJPD)
		{
			return default(FLPPNEJACCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F20940", Offset = "0x2F1F740", VA = "0x182F20940")]
		private GIHDEDEDBKK HFGFFGKIBHD(FLPPNEJACCH NCJAMNCMCDH, CPLDKIAEKDJ DCLGFFDBANO, KKDMPHCELIM CPAFPGDNJPD)
		{
			return default(GIHDEDEDBKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2F215F0", Offset = "0x2F203F0", VA = "0x182F215F0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[IHOFDNBJLIN(typeof(NEEEMKFPJPC), new string[] { })]
public class EPPMBPMJCCG : OMEPFIBEFCP, GLCKJEOBJPN, NEEEMKFPJPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class FGNNCJONGIJ : IEnumerable<IMKMJFJEHIJ>, IEnumerable, IEnumerator<IMKMJFJEHIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private IMKMJFJEHIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public EPPMBPMJCCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private IMKMJFJEHIJ splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public IMKMJFJEHIJ <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private IMKMJFJEHIJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IMKMJFJEHIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x3278380", Offset = "0x3277180", VA = "0x183278380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x795390", Offset = "0x794190", VA = "0x180795390")]
		[DebuggerHidden]
		public FGNNCJONGIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x32781D0", Offset = "0x3276FD0", VA = "0x1832781D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x3278340", Offset = "0x3277140", VA = "0x183278340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x3278290", Offset = "0x3277090", VA = "0x183278290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IMKMJFJEHIJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x3278290", Offset = "0x3277090", VA = "0x183278290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private LMLOCAEKAJL NGPKJGJONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private FKPEDAMHJJH MJPOAMJOPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService EDGDLJOHDGN;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x350F610", Offset = "0x350E410", VA = "0x18350F610")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private LOOMEBBKBLB PMPGCJKHBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x350F460", Offset = "0x350E260", VA = "0x18350F460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3510000", Offset = "0x350EE00", VA = "0x183510000", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x350FA10", Offset = "0x350E810", VA = "0x18350FA10", Slot = "5")]
	public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x350F520", Offset = "0x350E320", VA = "0x18350F520", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x350EE30", Offset = "0x350DC30", VA = "0x18350EE30")]
	private void AOAMHOBPBNE(Entity DGAMHGMJHFH, in KNIHKHKCMFB KLKADDCIMNA, in KNIHKHKCMFB BHOEDLDNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x350F0B0", Offset = "0x350DEB0", VA = "0x18350F0B0", Slot = "14")]
	public IMKMJFJEHIJ CNBKCLGBMEL()
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x350F6F0", Offset = "0x350E4F0", VA = "0x18350F6F0", Slot = "10")]
	public void IEPMJPAHHMB(IMKMJFJEHIJ NAKKFJMFOAE, HEGNJCHGKGH FGGPHJMDLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x350FB10", Offset = "0x350E910", VA = "0x18350FB10", Slot = "9")]
	public HEGNJCHGKGH KPEGAGPAFGN(IMKMJFJEHIJ NAKKFJMFOAE)
	{
		return default(HEGNJCHGKGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x350FBD0", Offset = "0x350E9D0", VA = "0x18350FBD0", Slot = "11")]
	public IMKMJFJEHIJ NGHNFHGLHAB(IMKMJFJEHIJ FNMGGGFHOJG, [Optional] Vector3? CBAKPHLPCPB, [Optional] Quaternion? HKMKNOBAIAN, [Optional] Vector3? CPAOPLMBGGO)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x350F5D0", Offset = "0x350E3D0", VA = "0x18350F5D0", Slot = "15")]
	public IMKMJFJEHIJ FKNDAHHNPEB(IMKMJFJEHIJ FLIMFNBNPOG, int CPOAAGLEIPE, [Optional] Vector3? CBAKPHLPCPB, [Optional] Quaternion? HKMKNOBAIAN, [Optional] Vector3? CPAOPLMBGGO)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x350F1D0", Offset = "0x350DFD0", VA = "0x18350F1D0", Slot = "7")]
	public IMKMJFJEHIJ DALEMNBJEKF(IMKMJFJEHIJ FLIMFNBNPOG, int CPOAAGLEIPE)
	{
		return default(IMKMJFJEHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x350F110", Offset = "0x350DF10", VA = "0x18350F110", Slot = "16")]
	public void DAHPIPDMFIB(IMKMJFJEHIJ FLIMFNBNPOG, IMKMJFJEHIJ PGMACOBHFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x350F2C0", Offset = "0x350E0C0", VA = "0x18350F2C0", Slot = "12")]
	public void DDIAJGLGPPK(IMKMJFJEHIJ FLIMFNBNPOG, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x350F870", Offset = "0x350E670", VA = "0x18350F870", Slot = "17")]
	public void KCNGBOLMHGM(IMKMJFJEHIJ FLIMFNBNPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x350FED0", Offset = "0x350ECD0", VA = "0x18350FED0", Slot = "8")]
	public int NIENHGPOBNO(IMKMJFJEHIJ FLIMFNBNPOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x350F660", Offset = "0x350E460", VA = "0x18350F660", Slot = "6")]
	[IteratorStateMachine(typeof(FGNNCJONGIJ))]
	public IEnumerable<IMKMJFJEHIJ> GAIFBGPGLGH(IMKMJFJEHIJ FLIMFNBNPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x350FF70", Offset = "0x350ED70", VA = "0x18350FF70")]
	private bool OABDOHLFPFE(IMKMJFJEHIJ FLIMFNBNPOG, out NativeArray<Entity> GJFKHPNECKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x350F7B0", Offset = "0x350E5B0", VA = "0x18350F7B0")]
	private NativeArray<Entity> IJBDJNEILIB(IMKMJFJEHIJ FLIMFNBNPOG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EPPMBPMJCCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[KBDLNAGCCOG(DADIFNCKKPF.LoadInstance)]
[IHOFDNBJLIN(typeof(LBGCJNBFBNO), new string[] { })]
internal sealed class LBGCJNBFBNO : OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private CIHNJOKIFOM PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase AOAKEGHEIPE;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private PANKPCMPIOD LKMGEGIOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2FD04F0", Offset = "0x2FCF2F0", VA = "0x182FD04F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0900", Offset = "0x2FCF700", VA = "0x182FD0900", Slot = "4")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0810", Offset = "0x2FCF610", VA = "0x182FD0810")]
	public void MODAIBPECHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0540", Offset = "0x2FCF340", VA = "0x182FD0540")]
	public void ABDNHCCGLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public LBGCJNBFBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct OJNNDEHILJM : IEquatable<OJNNDEHILJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int CABFLHODPAB;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type DKNGEPPLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2F08F30", Offset = "0x2F07D30", VA = "0x182F08F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x2F09140", Offset = "0x2F07F40", VA = "0x182F09140")]
	public OJNNDEHILJM(Type MAIOHDHBGKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x2F08FE0", Offset = "0x2F07DE0", VA = "0x182F08FE0")]
	public static OJNNDEHILJM CILEDLHNJIF(Type MAIOHDHBGKE)
	{
		return default(OJNNDEHILJM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x2F08F90", Offset = "0x2F07D90", VA = "0x182F08F90")]
	public static Type CILEDLHNJIF(OJNNDEHILJM EFHAIHKDJDK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x796BB0", Offset = "0x7959B0", VA = "0x180796BB0")]
	public static bool LHMNPGMNIAC(OJNNDEHILJM FEIPFLDEPBD, OJNNDEHILJM MIECAKFJHNF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x796BB0", Offset = "0x7959B0", VA = "0x180796BB0")]
	public static bool NGBHPPLJJAJ(OJNNDEHILJM FEIPFLDEPBD, OJNNDEHILJM MIECAKFJHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x796770", Offset = "0x795570", VA = "0x180796770", Slot = "4")]
	public bool Equals(OJNNDEHILJM ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2F09040", Offset = "0x2F07E40", VA = "0x182F09040", Slot = "0")]
	public override bool Equals(object BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2F090C0", Offset = "0x2F07EC0", VA = "0x182F090C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class JOMHPBIGKNB
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> NNADBGGOBKG;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> HBNBAIDDOHP;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCA00", Offset = "0x2FCB800", VA = "0x182FCCA00")]
	static JOMHPBIGKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2D51A00", Offset = "0x2D50800", VA = "0x182D51A00")]
	public static bool AHKNMMEAEHA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC6C0", Offset = "0x2FCB4C0", VA = "0x182FCC6C0")]
	public static bool AHKNMMEAEHA(Type MAIOHDHBGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC550", Offset = "0x2FCB350", VA = "0x182FCC550")]
	private static bool AHKNMMEAEHA(Type MAIOHDHBGKE, out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2D51A90", Offset = "0x2D50890", VA = "0x182D51A90")]
	public static int MGMLNFFFDMH<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC7D0", Offset = "0x2FCB5D0", VA = "0x182FCC7D0")]
	public static int MGMLNFFFDMH(Type MAIOHDHBGKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2D51B20", Offset = "0x2D50920", VA = "0x182D51B20")]
	public static bool OOMGGBPLIIB<T>(out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC960", Offset = "0x2FCB760", VA = "0x182FCC960")]
	public static bool OOMGGBPLIIB(Type MAIOHDHBGKE, out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC730", Offset = "0x2FCB530", VA = "0x182FCC730")]
	public static Type BPAEGFNIDAI(int CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2FCC840", Offset = "0x2FCB640", VA = "0x182FCC840")]
	public static bool OOMGGBPLIIB(int CPOAAGLEIPE, out Type MAIOHDHBGKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct KINCKNPNDIJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] PHAPMEHMHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int LNKONGJEECL;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x79A680", Offset = "0x799480", VA = "0x18079A680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x26ABF00", Offset = "0x26AAD00", VA = "0x1826ABF00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> JEMMLABOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2727C70", Offset = "0x2726A70", VA = "0x182727C70")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x944F20", Offset = "0x943D20", VA = "0x180944F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2727D10", Offset = "0x2726B10", VA = "0x182727D10")]
	public KINCKNPNDIJ(int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2727BC0", Offset = "0x27269C0", VA = "0x182727BC0")]
	public int EAKNCNMGFIF(T NLHFEJHKLAH, int HJHFBPCCKIM, int PHHDFCFDFMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x2727B00", Offset = "0x2726900", VA = "0x182727B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct HFFODAECLOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::KINCKNPNDIJ<T> PHAPMEHMHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int LNKONGJEECL;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A330", Offset = "0x3A89130", VA = "0x183A8A330")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x3A8B8A0", Offset = "0x3A8A6A0", VA = "0x183A8B8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int BACNEHOFKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x3A8B5D0", Offset = "0x3A8A3D0", VA = "0x183A8B5D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x3A8A280", Offset = "0x3A89080", VA = "0x183A8A280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool AMFLHOGACPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3A8B590", Offset = "0x3A8A390", VA = "0x183A8B590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> JEMMLABOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x3A8B950", Offset = "0x3A8A750", VA = "0x183A8B950")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x3A8BB10", Offset = "0x3A8A910", VA = "0x183A8BB10")]
	public HFFODAECLOL(int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B330", Offset = "0x3A8A130", VA = "0x183A8B330")]
	public T ILBOKHBKFKC(int CPOAAGLEIPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AF80", Offset = "0x3A89D80", VA = "0x183A8AF80")]
	public void GBFAGOOAGLL(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x3A8ABF0", Offset = "0x3A899F0", VA = "0x183A8ABF0")]
	public void FIBCHCNCEOP(Span<T> LLMBPPCBLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A170", Offset = "0x3A88F70", VA = "0x183A8A170")]
	public void AHKNMMEAEHA(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A3C0", Offset = "0x3A891C0", VA = "0x183A8A3C0")]
	private void CEOEBJAEGBM(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A8F0", Offset = "0x3A896F0", VA = "0x183A8A8F0")]
	public void EMAILJOLPAC(Span<T> ICBAFEALNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A670", Offset = "0x3A89470", VA = "0x183A8A670")]
	public void DPCAGKMPFGI(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AD60", Offset = "0x3A89B60", VA = "0x183A8AD60")]
	public void FKOJFFBCIAG(int OFMHMNPPJFE, int HDNNAAICFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A2D0", Offset = "0x3A890D0", VA = "0x183A8A2D0")]
	public void BPJGFIPNNHC(int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B380", Offset = "0x3A8A180", VA = "0x183A8B380")]
	public void KJAMDEJNFMP(int OFMHMNPPJFE, int HDNNAAICFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AB30", Offset = "0x3A89930", VA = "0x183A8AB30")]
	public void FHNNPPFOHLP(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A5B0", Offset = "0x3A893B0", VA = "0x183A8A5B0")]
	public void CMOMMBPGIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A720", Offset = "0x3A89520", VA = "0x183A8A720")]
	public int EAKNCNMGFIF(T NLHFEJHKLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B8F0", Offset = "0x3A8A6F0", VA = "0x183A8B8F0")]
	public bool PGDHOKOGAJF(T NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A6D0", Offset = "0x3A894D0", VA = "0x183A8A6D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3A8BAA0", Offset = "0x3A8A8A0", VA = "0x183A8BAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A540", Offset = "0x3A89340", VA = "0x183A8A540")]
	public static Span<T> CILEDLHNJIF(global::HFFODAECLOL<T> LLMBPPCBLOM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B760", Offset = "0x3A8A560", VA = "0x183A8B760")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NKAGKPANKIE(int NLHFEJHKLAH, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void NJCLIDAJKFG(int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B600", Offset = "0x3A8A400", VA = "0x183A8B600")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NJCLIDAJKFG(int LNKONGJEECL, int CPOAAGLEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x3A8AFF0", Offset = "0x3A89DF0", VA = "0x183A8AFF0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HCMHCEIFHNL(int NLHFEJHKLAH, int LNKONGJEECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8B130", Offset = "0x3A89F30", VA = "0x183A8B130")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void HNLDDFNKNBO(int OFMHMNPPJFE, int HDNNAAICFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A7B0", Offset = "0x3A895B0", VA = "0x183A8A7B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void EAOIDOIJCON(int NLHFEJHKLAH, int LNKONGJEECL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct OBJHEKJMJHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int KLKGCBMJKOM = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> NMONLDLIICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray AGNKGGODJFF;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2F07DB0", Offset = "0x2F06BB0", VA = "0x182F07DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> FJCLNBHGECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x705A20", Offset = "0x704820", VA = "0x180705A20")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray LMDEEKODBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool NOIGHNNNJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2F07C00", Offset = "0x2F06A00", VA = "0x182F07C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2F07E10", Offset = "0x2F06C10", VA = "0x182F07E10")]
	public OBJHEKJMJHJ(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2F07D60", Offset = "0x2F06B60", VA = "0x182F07D60")]
	public Entity FEAAFLDMJMG(int CPOAAGLEIPE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2F07BF0", Offset = "0x2F069F0", VA = "0x182F07BF0")]
	public Transform BMNKFDJOEBA(int CPOAAGLEIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2F07DC0", Offset = "0x2F06BC0", VA = "0x182F07DC0")]
	public void PLJMDNIMDEI(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2F07B20", Offset = "0x2F06920", VA = "0x182F07B20")]
	public int AHKNMMEAEHA(Transform GPMKACFJLBP, Entity JCNIDEIPPBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2F07C20", Offset = "0x2F06A20", VA = "0x182F07C20")]
	public int DPCAGKMPFGI(int CPOAAGLEIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2F07CA0", Offset = "0x2F06AA0", VA = "0x182F07CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2F07D20", Offset = "0x2F06B20", VA = "0x182F07D20")]
	private void EAOKPKPHFIL(int DOICJGOFEBA = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class PONHAEIBCHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<OJNNDEHILJM, int2> AHBHLCDKCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> IHLLHGOCNMO;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x2F18F70", Offset = "0x2F17D70", VA = "0x182F18F70")]
	public PONHAEIBCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2F18B60", Offset = "0x2F17960", VA = "0x182F18B60")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void NIPKJFNBLBF<T>(T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T BPAEGFNIDAI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2F18CE0", Offset = "0x2F17AE0", VA = "0x182F18CE0")]
	public void NIPKJFNBLBF(Type MAIOHDHBGKE, KNIHKHKCMFB NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2F18790", Offset = "0x2F17590", VA = "0x182F18790")]
	public KNIHKHKCMFB BPAEGFNIDAI(Type MAIOHDHBGKE)
	{
		return default(KNIHKHKCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2F18A20", Offset = "0x2F17820", VA = "0x182F18A20")]
	private NativeArray<byte> COMCMIEIKGH(int2 BBGFBIBNDMO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2F18AC0", Offset = "0x2F178C0", VA = "0x182F18AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x2F18BC0", Offset = "0x2F179C0", VA = "0x182F18BC0", Slot = "1")]
	~PONHAEIBCHG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct KEGPIDGNOOK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::KEGPIDGNOOK<T> CILEDLHNJIF(T NLHFEJHKLAH)
	{
		return default(global::KEGPIDGNOOK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T CILEDLHNJIF(global::KEGPIDGNOOK<T> IMIKACAODIP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class NPEDJOPINEI
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly PONHAEIBCHG JFIBMNPPOLI;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x2F077C0", Offset = "0x2F065C0", VA = "0x182F077C0")]
	internal static void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void NIPKJFNBLBF<T>(T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2F07870", Offset = "0x2F06670", VA = "0x182F07870")]
	public static void NIPKJFNBLBF(Type MAIOHDHBGKE, KNIHKHKCMFB NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T BPAEGFNIDAI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2F07720", Offset = "0x2F06520", VA = "0x182F07720")]
	public static KNIHKHKCMFB BPAEGFNIDAI(Type MAIOHDHBGKE)
	{
		return default(KNIHKHKCMFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class JHJFLAFJGGM : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly JHJFLAFJGGM LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC99B0", Offset = "0x2FC87B0", VA = "0x182FC99B0", Slot = "4")]
	public bool Equals(LinkedEntityGroup PAMKNJCGOGK, LinkedEntityGroup IOAMOMOPNDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC99D0", Offset = "0x2FC87D0", VA = "0x182FC99D0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup BLIKPCIFNNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public JHJFLAFJGGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class FNIJJEONDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void AGIHFOAKCIH(in Vector3 CBAKPHLPCPB, in Quaternion HKMKNOBAIAN, in Vector3 CPAOPLMBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void CCEEIKGJGLG(in Vector3 FFKFFLDNDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void MDMEBCKEJDL(in Quaternion HKMKNOBAIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void LLACCIJFFNN(in Vector3 JPDBJBDKCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void JOHNHHHOMCB(in Vector3 JPDBJBDKCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void LKIPPJCFDAP(in float OFNAPBBDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA100", Offset = "0x2FB8F00", VA = "0x182FBA100")]
	[Conditional("DEBUG_BUILD")]
	public static void BECAHDNPFPC(in float3 NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	[Conditional("DEBUG_BUILD")]
	public static void HJGNPAHFGNL(in float NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA1E0", Offset = "0x2FB8FE0", VA = "0x182FBA1E0")]
	[Conditional("DEBUG_BUILD")]
	public static void HJGNPAHFGNL(in Vector3 NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA1B0", Offset = "0x2FB8FB0", VA = "0x182FBA1B0")]
	[Conditional("DEBUG_BUILD")]
	public static void HJGNPAHFGNL(in Quaternion NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA260", Offset = "0x2FB9060", VA = "0x182FBA260")]
	[Conditional("DEBUG_BUILD")]
	public static void MCMKMHPJGOF(in float NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA270", Offset = "0x2FB9070", VA = "0x182FBA270")]
	[Conditional("DEBUG_BUILD")]
	public static void MCMKMHPJGOF(in Vector3 NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA230", Offset = "0x2FB9030", VA = "0x182FBA230")]
	[Conditional("DEBUG_BUILD")]
	public static void MCMKMHPJGOF(in Quaternion NLHFEJHKLAH, string GNDOGDAIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public FNIJJEONDLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct FIIDJEFPAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity JCNIDEIPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity NPPHDNLMMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity BANCJNAJPLD;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8E00", Offset = "0x2FB7C00", VA = "0x182FB8E00")]
	public FIIDJEFPAIP(Entity JCNIDEIPPBD, Entity NPPHDNLMMMJ, Entity BANCJNAJPLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8DA0", Offset = "0x2FB7BA0", VA = "0x182FB8DA0")]
	public static FIIDJEFPAIP CILEDLHNJIF((Entity entity, Entity oldParent, Entity newParent) IHBMEJHGODH)
	{
		return default(FIIDJEFPAIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8DE0", Offset = "0x2FB7BE0", VA = "0x182FB8DE0")]
	public void FEOJDFBNKMA(out Entity JCNIDEIPPBD, out Entity NPPHDNLMMMJ, out Entity BANCJNAJPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct MPFLPHHMMLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity JCNIDEIPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity AABHIBJPKOH;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x9454A0", Offset = "0x9442A0", VA = "0x1809454A0")]
	public MPFLPHHMMLG(Entity JCNIDEIPPBD, Entity AABHIBJPKOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2F03C30", Offset = "0x2F02A30", VA = "0x182F03C30")]
	public static MPFLPHHMMLG CILEDLHNJIF((Entity entity, Entity parent) IHBMEJHGODH)
	{
		return default(MPFLPHHMMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2F03C60", Offset = "0x2F02A60", VA = "0x182F03C60")]
	public void FEOJDFBNKMA(out Entity JCNIDEIPPBD, out Entity AABHIBJPKOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct GKIPNPMIFPA<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle EFHAIHKDJDK;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool BLGOFDIEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2F07650", Offset = "0x2F06450", VA = "0x182F07650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x3C28B10", Offset = "0x3C27910", VA = "0x183C28B10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x3C28A50", Offset = "0x3C27850", VA = "0x183C28A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3C28BB0", Offset = "0x3C279B0", VA = "0x183C28BB0")]
	public GKIPNPMIFPA(T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3C28A20", Offset = "0x3C27820", VA = "0x183C28A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum CGKILEGAHAC
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct GFMDAEHFIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public CGKILEGAHAC ALNFHILNCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int JGADMOFPNFE;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
	public GFMDAEHFIFG(CGKILEGAHAC ALNFHILNCAP, int JGADMOFPNFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x11280C0", Offset = "0x1126EC0", VA = "0x1811280C0")]
	public static GFMDAEHFIFG CILEDLHNJIF((CGKILEGAHAC eventType, int eventIndex) PAMKNJCGOGK)
	{
		return default(GFMDAEHFIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCBA0", Offset = "0x2FBB9A0", VA = "0x182FBCBA0")]
	public void FEOJDFBNKMA(out CGKILEGAHAC ALNFHILNCAP, out int JGADMOFPNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[IHOFDNBJLIN(typeof(OEHPEGMEEGJ), new string[] { })]
public sealed class IGHEFEKNELA : OEHPEGMEEGJ, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private DPDPICMJPAD COKKDJMMOMH;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6560", Offset = "0x2FC5360", VA = "0x182FC6560", Slot = "5")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6470", Offset = "0x2FC5270", VA = "0x182FC6470")]
	public bool JEFIOCCBAIC(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, Allocator HIEJKCFDMDD, out NativeArray<Entity> NMONLDLIICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public IGHEFEKNELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6470", Offset = "0x2FC5270", VA = "0x182FC6470", Slot = "4")]
	private bool EAINCKILGBJ(in float3 LPHFKJJAHJH, in float3 HHGBGELADCO, float EMEIKNNEGHK, Allocator HIEJKCFDMDD, out NativeArray<Entity> NMONLDLIICI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[PNDCBMPMNFM]
[UpdateInGroup(typeof(FHFPMBJNELD))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class EABHDDDCACP : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x350DC40", Offset = "0x350CA40", VA = "0x18350DC40", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public EABHDDDCACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[PNDCBMPMNFM]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
[UpdateInGroup(typeof(IGJOIFIIHPO))]
public sealed class EIJJKPJPFFK : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x350E310", Offset = "0x350D110", VA = "0x18350E310", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public EIJJKPJPFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[PNDCBMPMNFM]
[UpdateInGroup(typeof(AFJALALCJFF))]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
internal sealed class GEIHJGOADIK : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBDF0", Offset = "0x2FBABF0", VA = "0x182FBBDF0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public GEIHJGOADIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class NFMHDAONJHO : IHIDDBECDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public NFMHDAONJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[PNDCBMPMNFM]
[ExecuteAlways]
[COEFBNKMAPI(DADIFNCKKPF.LoadInstance)]
[UpdateInGroup(typeof(JCJGFNBHNFK))]
internal sealed class HFNPNHJJGJF : EKBCLFGBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x2FBEBD0", Offset = "0x2FBD9D0", VA = "0x182FBEBD0", Slot = "16")]
	protected override ComponentSystemBase BGHBIDDOHOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2F03920", Offset = "0x2F02720", VA = "0x182F03920")]
	public HFNPNHJJGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[GFOMBCHLLFP(typeof(AuthoredLocalPoseData))]
public sealed class PKKPNECKGPA : LLBOOMFFHNM
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2F17C10", Offset = "0x2F16A10", VA = "0x182F17C10", Slot = "8")]
	protected override bool MCOFNAKFFJL(ReadOnlySpan<AuthoredLocalPoseData> ICBAFEALNLG, FFMBNOGKKDB BNNDCBJIDKG, out ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2F17B50", Offset = "0x2F16950", VA = "0x182F17B50", Slot = "9")]
	protected override bool HMPPLMKKCJK(int CPFPNOFCGCI, Span<AuthoredLocalPoseData> ICBAFEALNLG, in ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2F17C90", Offset = "0x2F16A90", VA = "0x182F17C90")]
	public PKKPNECKGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[GFOMBCHLLFP(typeof(LocalPoseData))]
public sealed class JBOCNNCJGDI : BNIHDPDMPHG
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6F90", Offset = "0x2FC5D90", VA = "0x182FC6F90", Slot = "8")]
	protected override bool MCOFNAKFFJL(ReadOnlySpan<LocalPoseData> ICBAFEALNLG, FFMBNOGKKDB BNNDCBJIDKG, out ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6ED0", Offset = "0x2FC5CD0", VA = "0x182FC6ED0", Slot = "9")]
	protected override bool HMPPLMKKCJK(int CPFPNOFCGCI, Span<LocalPoseData> ICBAFEALNLG, in ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7010", Offset = "0x2FC5E10", VA = "0x182FC7010")]
	public JBOCNNCJGDI()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : GIHBEMJPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x3293A10", Offset = "0x3292810", VA = "0x183293A10", Slot = "6")]
		public sealed override void HAGKABNBGAM(BFAIPCIBIIK JDLJMIHPPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x3294A30", Offset = "0x3293830", VA = "0x183294A30", Slot = "4")]
		public sealed override void HLFKGNEPEFG()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x2FCEC90", Offset = "0x2FCDA90", VA = "0x182FCEC90")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x2FCEDA0", Offset = "0x2FCDBA0", VA = "0x182FCEDA0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
