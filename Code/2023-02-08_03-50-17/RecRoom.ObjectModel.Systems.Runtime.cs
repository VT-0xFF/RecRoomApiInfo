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
public sealed class CFEHIJCPKBI<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class BEIIODIFJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::CFEHIJCPKBI<T> FHIDFKFMMBI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] HEBONKLIJJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public BEIIODIFJEH(global::CFEHIJCPKBI<T> FHIDFKFMMBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BJGEJHNFOEG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::CFEHIJCPKBI<T> <>4__this;

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
		public BJGEJHNFOEG(int <>1__state)
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
	private const int PAKFOOIBKFN = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> BOAKCFDNEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int NGNCBPKGJMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T BADELHLICNG
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
	private bool JPFCFFDFJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool BCEPJIBALLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool BJGFFKGKHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LOFJCNPKFOE
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
	public int EKAGFOMELON
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
	public CFEHIJCPKBI(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public CFEHIJCPKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void ECGADGBFHDM(int DJIEOHJNDEK, T BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void FOJICMFLHIC(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] EPIODPKLAPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void EAOJLKNNPGK(NativeArray<T> HDCHHDPICKJ, int HKFDIPJFPLD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::CFEHIJCPKBI<>.BJGEJHNFOEG))]
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
	public int DMLIELKNFBC(T BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool PPEAGPDBOCM(T BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void CECDIBOMBID(int ODNMAKOIMEP, int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void LPALFCEDGDE(int ODNMAKOIMEP, int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void AJPGGKHEMOE(int ODNMAKOIMEP, int OMMIHDFOJDN, int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int JPKEEBNJOFO(int DJIEOHJNDEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T ABEEDMFDFKI(int DJIEOHJNDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void HPDNOCKLHAE(int DJIEOHJNDEK, T BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void FOGDILABCIK(int DJIEOHJNDEK, T BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void FLFAKHLKFCG(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int BFADAOFOOIH(int DPJGMDFEIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int ACKPCICCKCC(int DPJGMDFEIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void BKMKIOOAMBG(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void NIFFNIJHBEM(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T OKJAGHGGDIC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T JHCDDFCJOLF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void CCILPNGGPML(int DJIEOHJNDEK, IReadOnlyCollection<T> NHMINHLCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void BHDFCJGCLNM(int DJIEOHJNDEK, int BOLMNAPGADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void IPPMPNLAGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void FNOPOOPMAPJ(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void BEBCLGEKAKL(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void IKAJAOLCJMN(int OMMIHDFOJDN, int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T BHPCCCPOMJF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T ODNIIAPEEFN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[PDCFFDBAKMH]
public static class AKPEMJCHPML
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D20", Offset = "0x8F2B20", VA = "0x1808F3D20")]
	static AKPEMJCHPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43174D0", Offset = "0x43162D0", VA = "0x1843174D0")]
	public static void JEIFDJOGNMH<T>(T IDEEEMMOHPP, ref T AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8F3A70", Offset = "0x8F2870", VA = "0x1808F3A70")]
	public static void JEIFDJOGNMH(FixedString32 IDEEEMMOHPP, ref string AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8F3CA0", Offset = "0x8F2AA0", VA = "0x1808F3CA0")]
	public static void JEIFDJOGNMH(string IDEEEMMOHPP, ref FixedString32 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8F3AA0", Offset = "0x8F28A0", VA = "0x1808F3AA0")]
	public static void JEIFDJOGNMH(FixedString64 IDEEEMMOHPP, ref string AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8F3B10", Offset = "0x8F2910", VA = "0x1808F3B10")]
	public static void JEIFDJOGNMH(string IDEEEMMOHPP, ref FixedString64 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3B70", Offset = "0x8F2970", VA = "0x1808F3B70")]
	public static void JEIFDJOGNMH(BBPBNFPGNBK IDEEEMMOHPP, ref Vector3 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3BA0", Offset = "0x8F29A0", VA = "0x1808F3BA0")]
	public static void JEIFDJOGNMH(Vector3 IDEEEMMOHPP, ref BBPBNFPGNBK AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3A40", Offset = "0x8F2840", VA = "0x1808F3A40")]
	public static void JEIFDJOGNMH(HNEGIKIEIFD IDEEEMMOHPP, ref Vector4 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8F39D0", Offset = "0x8F27D0", VA = "0x1808F39D0")]
	public static void JEIFDJOGNMH(Vector4 IDEEEMMOHPP, ref HNEGIKIEIFD AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3A40", Offset = "0x8F2840", VA = "0x1808F3A40")]
	public static void JEIFDJOGNMH(HNEGIKIEIFD IDEEEMMOHPP, ref Quaternion AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8F39D0", Offset = "0x8F27D0", VA = "0x1808F39D0")]
	public static void JEIFDJOGNMH(Quaternion IDEEEMMOHPP, ref HNEGIKIEIFD AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8F3C70", Offset = "0x8F2A70", VA = "0x1808F3C70")]
	public static void JEIFDJOGNMH(BBPBNFPGNBK IDEEEMMOHPP, ref float3 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8F3BA0", Offset = "0x8F29A0", VA = "0x1808F3BA0")]
	public static void JEIFDJOGNMH(float3 IDEEEMMOHPP, ref BBPBNFPGNBK AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8F3AD0", Offset = "0x8F28D0", VA = "0x1808F3AD0")]
	public static void JEIFDJOGNMH(HNEGIKIEIFD IDEEEMMOHPP, ref float4 AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8F39D0", Offset = "0x8F27D0", VA = "0x1808F39D0")]
	public static void JEIFDJOGNMH(float4 IDEEEMMOHPP, ref HNEGIKIEIFD AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8F3AD0", Offset = "0x8F28D0", VA = "0x1808F3AD0")]
	public static void JEIFDJOGNMH(HNEGIKIEIFD IDEEEMMOHPP, ref quaternion AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8F3C00", Offset = "0x8F2A00", VA = "0x1808F3C00")]
	public static void JEIFDJOGNMH(quaternion IDEEEMMOHPP, ref HNEGIKIEIFD AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8F3CE0", Offset = "0x8F2AE0", VA = "0x1808F3CE0")]
	public static void JEIFDJOGNMH(Entity IDEEEMMOHPP, ref EJPJBEJFDAI AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F27B0", VA = "0x1808F39B0")]
	public static void JEIFDJOGNMH(EJPJBEJFDAI IDEEEMMOHPP, ref Entity AJPBOMDMGOF, IFAEDNBIFMG LAKAALEJDAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LFNIFJENOAD]
public class IBHHHMBGELB : ComponentSystem, KPALCLLIODG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KEOFLKLFAOP NHHMGEAMLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EJJKOHOJBIP IGKGCEECDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BE0", Offset = "0x6CF9E0", VA = "0x1806D0BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA2DB40", Offset = "0xA2C940", VA = "0x180A2DB40", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
	public IBHHHMBGELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LFNIFJENOAD]
[UpdateInGroup(typeof(LOCGKPAFLNE))]
internal class IICKBEEDHOL : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA2E730", Offset = "0xA2D530", VA = "0x180A2E730", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA2E6B0", Offset = "0xA2D4B0", VA = "0x180A2E6B0")]
	[Preserve]
	private void EIOANHBICHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public IICKBEEDHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[LFNIFJENOAD]
[UpdateInGroup(typeof(LOCGKPAFLNE))]
internal class JIDDIGPEHIL : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA31B60", Offset = "0xA30960", VA = "0x180A31B60", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public JIDDIGPEHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B6FB0", Offset = "0x8B5DB0", VA = "0x1808B6FB0")]
		public static ObjectModelConfigAsset GDJFEBPMBDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71DC30", Offset = "0x71CA30", VA = "0x18071DC30")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[KNPMBINOPIG(MLNJOBCAIAM.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int LMFLNMNCHIB = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly EKGLDANHPKF CGFIKJKJOPN;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x11B4C10", Offset = "0x11B3A10", VA = "0x1811B4C10")]
			public static IJJNJPIJDOH PMALCFANNBP(int KMJDCHACKCM)
			{
				return default(IJJNJPIJDOH);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x11B4A80", Offset = "0x11B3880", VA = "0x1811B4A80")]
			private static void PABAFMBLMJG(LEDHMIGLCGN GCJOKEMNCLL, LEDHMIGLCGN HCPCOLPECAG, IJJNJPIJDOH OJMDJGIIFAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x11B48B0", Offset = "0x11B36B0", VA = "0x1811B48B0")]
			public static int GBCBIKOHPIG(GameObject NGIKODIIBGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x11B4830", Offset = "0x11B3630", VA = "0x1811B4830")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void DECHIIPPCOE(LEDHMIGLCGN NFBLCBCBMID, int KMJDCHACKCM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static AMNHNFNHFNB JANAFEEBPPF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static OELGFEKAJPK HDNILMEAKCP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static AMNHNFNHFNB OJDJDNHAHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F60", Offset = "0x8B6D60", VA = "0x1808B7F60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8B7950", Offset = "0x8B6750", VA = "0x1808B7950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OELGFEKAJPK NNIAMACHFOF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8B7190", Offset = "0x8B5F90", VA = "0x1808B7190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7C60", Offset = "0x8B6A60", VA = "0x1808B7C60")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MDCACPCHPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8B80A0", Offset = "0x8B6EA0", VA = "0x1808B80A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static KEOFLKLFAOP NHHMGEAMLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8B89D0", Offset = "0x8B77D0", VA = "0x1808B89D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EJJKOHOJBIP IGKGCEECDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B7560", Offset = "0x8B6360", VA = "0x1808B7560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static EJHGJPDMMNM HAMEEEFHFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EE0", Offset = "0x8B6CE0", VA = "0x1808B7EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static OHLEPJKHPFA DJAIIFDPHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8B7B60", Offset = "0x8B6960", VA = "0x1808B7B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NLEJJFIEGLH MDMIPFGDGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8B8AD0", Offset = "0x8B78D0", VA = "0x1808B8AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static OJCNMNJFNCK BFOFAHABICK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B7BE0", Offset = "0x8B69E0", VA = "0x1808B7BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool OAKAGHDKDFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B7050", Offset = "0x8B5E50", VA = "0x1808B7050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool EMBIIMNIJCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8B8410", Offset = "0x8B7210", VA = "0x1808B8410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool OOBGMIPFOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B8870", Offset = "0x8B7670", VA = "0x1808B8870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7130", Offset = "0x8B5F30", VA = "0x1808B7130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool LDIJCKPNHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8A70", Offset = "0x8B7870", VA = "0x1808B8A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B8810", Offset = "0x8B7610", VA = "0x1808B8810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action OOKJCGCOOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7730", Offset = "0x8B6530", VA = "0x1808B7730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8B88D0", Offset = "0x8B76D0", VA = "0x1808B88D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8320", Offset = "0x8B7120", VA = "0x1808B8320")]
		public static LEDHMIGLCGN KOOGDODNOPA(GameObject NGIKODIIBGN)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B75E0", Offset = "0x8B63E0", VA = "0x1808B75E0")]
		public static bool ENAAFDBOFON(ByteString KLGAKJLGGNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8200", Offset = "0x8B7000", VA = "0x1808B8200")]
		public static HMIODAKHEJO KODCGENEFMG(IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A30", Offset = "0x8B6830", VA = "0x1808B7A30")]
		public static (ByteString, IDisposable) HGGLACGHMAP()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B72B0", Offset = "0x8B60B0", VA = "0x1808B72B0")]
		public static (ByteString, IDisposable) CDPPOOBHDOD(IEnumerable<LEDHMIGLCGN> HNMDOPMMKGC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8B8600", Offset = "0x8B7400", VA = "0x1808B8600")]
		public static bool LHIOPFCGLGN(GameObject NGIKODIIBGN, out IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B7640", Offset = "0x8B6440", VA = "0x1808B7640")]
		public static bool ENACFKHBIEI(IEnumerable<KGIJKPANHFI> IDNOGKNDBCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B8730", Offset = "0x8B7530", VA = "0x1808B8730")]
		public static void MFIAHAGDMBM(bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B73E0", Offset = "0x8B61E0", VA = "0x1808B73E0")]
		public static Task CPOMKFJJNLN(bool BBEGNBBGFBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FC0", Offset = "0x8B6DC0", VA = "0x1808B7FC0")]
		private static OELGFEKAJPK JGGDCGOCJCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8B7830", Offset = "0x8B6630", VA = "0x1808B7830")]
		private static bool GMDLPOFICOJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[KNPMBINOPIG(MLNJOBCAIAM.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD440", Offset = "0x8BC240", VA = "0x1808BD440")]
		public static bool JPLAFPPCEOG(EBIEHGPCOMI IFMOPIHOLKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6F0", Offset = "0x8BC4F0", VA = "0x1808BD6F0")]
		public static EBIEHGPCOMI OBNDPKOJMJJ(GameObject NGIKODIIBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4F0", Offset = "0x8BC2F0", VA = "0x1808BD4F0")]
		public static EBIEHGPCOMI OBNDPKOJMJJ(GameObject NGIKODIIBGN, IJJNJPIJDOH OJMDJGIIFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BD050", Offset = "0x8BBE50", VA = "0x1808BD050")]
		public static bool CKAMHJKDGOH(GameObject OPJJDKDMJMI, string JHKCJACNFGI, bool CCJMMJOHFPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BD240", Offset = "0x8BC040", VA = "0x1808BD240")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void GAENLDLMIJJ(GameObject OPJJDKDMJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BD150", Offset = "0x8BBF50", VA = "0x1808BD150")]
		[CompilerGenerated]
		internal static string DPKBDHBMNCD((GameObject go, string prefabName) NHMGHNFFDAC)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, KAMPONHOOAP
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool NBPFEPIMLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public LEDHMIGLCGN GMALDCOBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(LEDHMIGLCGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x90CDC0", Offset = "0x90BBC0", VA = "0x18090CDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[KNPMBINOPIG(MLNJOBCAIAM.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, EBIEHGPCOMI, KAMPONHOOAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string MLAMPJJPIEH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MEAJAPBMBEM AJCEDEPGCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LEDHMIGLCGN BHMKDBDFPKN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LEDHMIGLCGN GMALDCOBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA1BF90", Offset = "0xA1AD90", VA = "0x180A1BF90", Slot = "15")]
			get
			{
				return default(LEDHMIGLCGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HMIODAKHEJO FPPNINBECNC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C040", Offset = "0xA1AE40", VA = "0x180A1C040", Slot = "6")]
			get
			{
				return default(HMIODAKHEJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NBPFEPIMLLF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA1BF80", Offset = "0xA1AD80", VA = "0x180A1BF80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public MEAJAPBMBEM EFFJPHMPJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6F7190", Offset = "0x6F5F90", VA = "0x1806F7190", Slot = "7")]
			get
			{
				return default(MEAJAPBMBEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private EJJKOHOJBIP IGKGCEECDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA1B590", Offset = "0xA1A390", VA = "0x180A1B590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private OIHJCGPPHNA HOJGLIDPCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA1B530", Offset = "0xA1A330", VA = "0x180A1B530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool FGPPGDIHIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x701090", Offset = "0x6FFE90", VA = "0x180701090", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> FOHLHEEJFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE40", Offset = "0xA1AC40", VA = "0x180A1BE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA1C070", Offset = "0xA1AE70", VA = "0x180A1C070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EBIEHGPCOMI> IJHAHAENICM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA1BEE0", Offset = "0xA1ACE0", VA = "0x180A1BEE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AF10", VA = "0x180A1C110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1B350", Offset = "0xA1A150", VA = "0x180A1B350")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCA0", Offset = "0xA1AAA0", VA = "0x180A1BCA0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA1B950", Offset = "0xA1A750", VA = "0x180A1B950", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC10", Offset = "0xA1AA10", VA = "0x180A1BC10", Slot = "10")]
		public void OnEmbody(NMDJLEODPOP DJCIICEJFGH, LEDHMIGLCGN BHMKDBDFPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC90", Offset = "0xA1AA90", VA = "0x180A1BC90", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BA00", Offset = "0xA1A800", VA = "0x180A1BA00", Slot = "12")]
		public void OnDisembody(bool BIFLJHNPPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B7F0", Offset = "0xA1A5F0", VA = "0x180A1B7F0")]
		private void LHFIBCILCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B760", Offset = "0xA1A560", VA = "0x180A1B760")]
		private void GIIKEKNMBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B670", Offset = "0xA1A470", VA = "0x180A1B670")]
		private void FCIGKGBOOFD(bool NBFHLGOBGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B8F0", Offset = "0xA1A6F0", VA = "0x180A1B8F0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F90", Offset = "0x6F6D90", VA = "0x1806F7F90", Slot = "9")]
		private GameObject HIBDEKJJEGM()
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

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[KNPMBINOPIG(MLNJOBCAIAM.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override FIMAOKHBMMB FIKANEODELD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C86F0", Offset = "0x8C74F0", VA = "0x1808C86F0", Slot = "6")]
			get
			{
				return default(FIMAOKHBMMB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C8690", Offset = "0x8C7490", VA = "0x1808C8690")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[KNPMBINOPIG(MLNJOBCAIAM.Registration)]
	public class TransformEntity : MonoBehaviour, KAMPONHOOAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private FIMAOKHBMMB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private LEDHMIGLCGN NFBLCBCBMID;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual FIMAOKHBMMB FIKANEODELD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30", Slot = "6")]
			get
			{
				return default(FIMAOKHBMMB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x804EF0", Offset = "0x803CF0", VA = "0x180804EF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LEDHMIGLCGN GMALDCOBEHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0", Slot = "5")]
			get
			{
				return default(LEDHMIGLCGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool NBPFEPIMLLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x98D710", Offset = "0x98C510", VA = "0x18098D710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x98D4F0", Offset = "0x98C2F0", VA = "0x18098D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity LKLOOGFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal NLEJJFIEGLH MDMIPFGDGLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal OIHJCGPPHNA GLICBEHNJOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x98D170", Offset = "0x98BF70", VA = "0x18098D170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x98D0C0", Offset = "0x98BEC0", VA = "0x18098D0C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x98D500", Offset = "0x98C300", VA = "0x18098D500")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x98D1E0", Offset = "0x98BFE0", VA = "0x18098D1E0")]
		internal void FKIENGHPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x98D0D0", Offset = "0x98BED0", VA = "0x18098D0D0")]
		private bool CNGBGGEBAAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98D680", Offset = "0x98C480", VA = "0x18098D680")]
		private void PECNDNNKGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x98D500", Offset = "0x98C300", VA = "0x18098D500")]
		internal void JNKEIDPDMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x98D5F0", Offset = "0x98C3F0", VA = "0x18098D5F0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C500", VA = "0x18098D700")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BKADEOMONEA(typeof(MMMOGKKJIOI))]
[HLJOGLEHOLC(typeof(OELGFEKAJPK), new string[] { })]
public class KGABLAJFBEF : HFPPOJKCJCC, KHPJCBNLGJJ, OELGFEKAJPK, GHBKMHMLIAD, MMMOGKKJIOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GMLDFADABOI OPNLEKFMABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EJJKOHOJBIP LHNNPMPCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private CNJANGGLMNJ FEBCBLODHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EHKKFECMDED EHALDMHGANA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED00", Offset = "0xA2DB00", VA = "0x180A2ED00", Slot = "19")]
		get
		{
			return default(EHKKFECMDED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GMLDFADABOI NHHMGEAMLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public CCMKEKPGHLC PGMNHIJIBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EJJKOHOJBIP IGKGCEECDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MCKHJMONIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x98D710", Offset = "0x98C510", VA = "0x18098D710", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EEONKLFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xA341A0", Offset = "0xA32FA0", VA = "0x180A341A0", Slot = "20")]
	public void HFIDPCJBPHP(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA34150", Offset = "0xA32F50", VA = "0x180A34150")]
	private void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xA33DB0", Offset = "0xA32BB0", VA = "0x180A33DB0")]
	private void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA33FA0", Offset = "0xA32DA0", VA = "0x180A33FA0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xA34160", Offset = "0xA32F60", VA = "0x180A34160", Slot = "10")]
	public void GPFCEGAIKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void LFPOOINCNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA340E0", Offset = "0xA32EE0", VA = "0x180A340E0", Slot = "5")]
	public void FDLPMJPOIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA33F50", Offset = "0xA32D50", VA = "0x180A33F50", Slot = "6")]
	public void DLHHMJENLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xA343A0", Offset = "0xA331A0", VA = "0x180A343A0", Slot = "7")]
	public void IKKMMNAIGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xA34000", Offset = "0xA32E00", VA = "0x180A34000", Slot = "8")]
	public bool ENACFKHBIEI(IEnumerable<KGIJKPANHFI> IDNOGKNDBCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xA34540", Offset = "0xA33340", VA = "0x180A34540", Slot = "9")]
	public void JLEDNMLPELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA33D40", Offset = "0xA32B40", VA = "0x180A33D40", Slot = "11")]
	public void BANEDGGLFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xA345E0", Offset = "0xA333E0", VA = "0x180A345E0", Slot = "12")]
	public void OIGDMJFCIGC(bool AMOGCEDILFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xA345B0", Offset = "0xA333B0", VA = "0x180A345B0")]
	private void JMDOAAFILDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xA342B0", Offset = "0xA330B0", VA = "0x180A342B0", Slot = "13")]
	public ByteString HGGLACGHMAP(out IDisposable IGJHMGIGCAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xA34410", Offset = "0xA33210", VA = "0x180A34410", Slot = "14")]
	public void IMPOKOFCPDO(ByteString CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA33E60", Offset = "0xA32C60", VA = "0x180A33E60")]
	public static KGABLAJFBEF DIMOBFAICBM(GMLDFADABOI OPNLEKFMABF, JFBGCEOLBKN POLNGKBPPLK = JFBGCEOLBKN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void LNLCPABGNJN(GMLDFADABOI OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void PLNMOKPAGCN(GMLDFADABOI OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KGABLAJFBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HPCAGKJKHPN
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0xA2AD80", Offset = "0xA29B80", VA = "0x180A2AD80")]
	public static HMIODAKHEJO NMBKONPBDBE(this OELGFEKAJPK HDNILMEAKCP, IJJNJPIJDOH OJMDJGIIFAA, FIMAOKHBMMB JPILKLCBOKG)
	{
		return default(HMIODAKHEJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0xA2AC60", Offset = "0xA29A60", VA = "0x180A2AC60")]
	public static GCEEIMOEHKJ MMBIBOHEECG(this OELGFEKAJPK HDNILMEAKCP)
	{
		return default(GCEEIMOEHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xA2ABB0", Offset = "0xA299B0", VA = "0x180A2ABB0")]
	public static LEDHMIGLCGN KOOGDODNOPA(this OELGFEKAJPK HDNILMEAKCP, Entity DNMNICOEECM)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0xA2AA80", Offset = "0xA29880", VA = "0x180A2AA80")]
	public static LEDHMIGLCGN KOOGDODNOPA(this OELGFEKAJPK HDNILMEAKCP, IJJNJPIJDOH OJMDJGIIFAA)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29760", VA = "0x180A2A960")]
	public static IJJNJPIJDOH DHOBLPLBCCE(this OELGFEKAJPK HDNILMEAKCP, LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(IJJNJPIJDOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum JFBGCEOLBKN
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class PEDBMPAMMKB<T> : global::PALJGLHCJPN<T>, global::CHKLHNJIEBJ<IJJNJPIJDOH, T>, global::PANPJDPIOFA<IJJNJPIJDOH>, LIOAALAFEGF, IDisposable, ENGJLAFCBJI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::PANPJDPIOFA<Entity> JHGILNGJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate OOMGHANCGMO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JBOBPFKLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x51F2830", Offset = "0x51F1630", VA = "0x1851F2830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type FCBCFKMJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x51E7940", Offset = "0x51E6740", VA = "0x1851E7940", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LNOFNLNFGAL NIPPOIEDBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x51F20B0", Offset = "0x51F0EB0", VA = "0x1851F20B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BCPGDMEDKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5201340", Offset = "0x5200140", VA = "0x185201340", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LDEFMJJCDDF NCEDAFKLJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x51E7F30", Offset = "0x51E6D30", VA = "0x1851E7F30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF700", Offset = "0x2CFE500", VA = "0x182CFF700", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x51B2B30", Offset = "0x51B1930", VA = "0x1851B2B30", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::NHIIIGIJKBI<IJJNJPIJDOH> OOKJCGCOOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x51F3470", Offset = "0x51F2270", VA = "0x1851F3470", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5204320", Offset = "0x5203120", VA = "0x185204320", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x37712B0", Offset = "0x37700B0", VA = "0x1837712B0")]
	public PEDBMPAMMKB(global::PANPJDPIOFA<Entity> JHGILNGJHFB, NLEJJFIEGLH OONGFKGINCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x51F1630", Offset = "0x51F0430", VA = "0x1851F1630")]
	private Entity EEILILFBJJA(IJJNJPIJDOH OJMDJGIIFAA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x51B1B10", Offset = "0x51B0910", VA = "0x1851B1B10")]
	private IJJNJPIJDOH EEILILFBJJA(Entity DNMNICOEECM)
	{
		return default(IJJNJPIJDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x51F7270", Offset = "0x51F6070", VA = "0x1851F7270", Slot = "4")]
	public T HEOCMNIHPLM(IJJNJPIJDOH OJMDJGIIFAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x51FD0C0", Offset = "0x51FBEC0", VA = "0x1851FD0C0")]
	public bool LMMFIPJEJPN(IJJNJPIJDOH OJMDJGIIFAA, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x51EE300", Offset = "0x51ED100", VA = "0x1851EE300")]
	public bool CJEGMEKBMEG(IJJNJPIJDOH OJMDJGIIFAA, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x51F5C10", Offset = "0x51F4A10", VA = "0x1851F5C10", Slot = "9")]
	public bool GPGONAPLKOC(IJJNJPIJDOH OJMDJGIIFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x51C1040", Offset = "0x51BFE40", VA = "0x1851C1040", Slot = "26")]
	public object NKOGCKLALCN(IJJNJPIJDOH OJMDJGIIFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5203010", Offset = "0x5201E10", VA = "0x185203010")]
	public bool OEDHDIGIDFK(IJJNJPIJDOH OJMDJGIIFAA, in object IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x51B6D90", Offset = "0x51B5B90", VA = "0x1851B6D90")]
	public void HEOCMNIHPLM(IJJNJPIJDOH OJMDJGIIFAA, in CBPKPEEEACL DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x51BC9B0", Offset = "0x51BB7B0", VA = "0x1851BC9B0")]
	public bool LMMFIPJEJPN(IJJNJPIJDOH OJMDJGIIFAA, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x51AEDE0", Offset = "0x51ADBE0", VA = "0x1851AEDE0")]
	public bool CJEGMEKBMEG(IJJNJPIJDOH OJMDJGIIFAA, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x376E9A0", Offset = "0x376D7A0", VA = "0x18376E9A0", Slot = "22")]
	public void JIGGKPCGAGJ(AEKODNEMCEK IGBHFDGFHIO, [Optional] object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x51FB520", Offset = "0x51FA320", VA = "0x1851FB520", Slot = "15")]
	public void JIGGKPCGAGJ(IJJNJPIJDOH CKMEBFKEHMO, FICEBFAABIF IGBHFDGFHIO, object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51C3480", Offset = "0x51C2280", VA = "0x1851C3480", Slot = "14")]
	public bool PCMCEDJAJPL(IJJNJPIJDOH AJPBOMDMGOF, IJJNJPIJDOH IDEEEMMOHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F05900", Offset = "0x2F04700", VA = "0x182F05900", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5204E30", Offset = "0x5203C30", VA = "0x185204E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x376BE50", Offset = "0x376AC50", VA = "0x18376BE50")]
	public string ENMJHLPNDLG(in LDOGLLBKONE OGKLHAJDLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x51F0B10", Offset = "0x51EF910", VA = "0x1851F0B10")]
	private void EBPEJCGGOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x51F5500", Offset = "0x51F4300", VA = "0x1851F5500")]
	private void GJBDNDMOGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x51EC1C0", Offset = "0x51EAFC0", VA = "0x1851EC1C0")]
	private void BOKIIFEGMGF(Entity DNMNICOEECM, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x51F9610", Offset = "0x51F8410", VA = "0x1851F9610")]
	private void JHGLFCHJKPE(Entity DNMNICOEECM, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x51FE500", Offset = "0x51FD300", VA = "0x1851FE500")]
	[Conditional("DEBUG_BUILD")]
	private static void MMGFLIMHPMO(Entity DNMNICOEECM, IJJNJPIJDOH OJMDJGIIFAA, string MEBPKBJLLDI, string DFFGKIMLEMB, [CallerMemberName] string LKBOLAOCAEA = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C84CE0", Offset = "0x3C83AE0", VA = "0x183C84CE0", Slot = "5")]
	private bool JBJBPGPNDKJ(IJJNJPIJDOH CKMEBFKEHMO, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C85160", Offset = "0x3C83F60", VA = "0x183C85160", Slot = "6")]
	private bool NFGBGCKGMAH(IJJNJPIJDOH CKMEBFKEHMO, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x49E9F90", Offset = "0x49E8D90", VA = "0x1849E9F90", Slot = "10")]
	private bool HKECDMIKGNB(IJJNJPIJDOH CKMEBFKEHMO, in object IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x51AFA10", Offset = "0x51AE810", VA = "0x1851AFA10", Slot = "11")]
	private void EBKFBAEOHBM(IJJNJPIJDOH CKMEBFKEHMO, in CBPKPEEEACL DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x51AF9E0", Offset = "0x51AE7E0", VA = "0x1851AF9E0", Slot = "12")]
	private bool CPPNLILBFPE(IJJNJPIJDOH CKMEBFKEHMO, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x51BB6A0", Offset = "0x51BA4A0", VA = "0x1851BB6A0", Slot = "13")]
	private bool KAEMKAJEKKN(IJJNJPIJDOH CKMEBFKEHMO, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3769120", Offset = "0x3767F20", VA = "0x183769120", Slot = "16")]
	private string DPENCDMDBFM(in LDOGLLBKONE DPJGMDFEIDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class GGJMPKJGDJM<T> : global::DNHLENHGBPH<T>, global::CHKLHNJIEBJ<LEDHMIGLCGN, T>, global::PANPJDPIOFA<LEDHMIGLCGN>, LIOAALAFEGF, IDisposable, ABFMHNDOCPA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::PANPJDPIOFA<Entity> JHGILNGJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate OOMGHANCGMO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string JBOBPFKLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x376C270", Offset = "0x376B070", VA = "0x18376C270", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type FCBCFKMJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3769060", Offset = "0x3767E60", VA = "0x183769060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LNOFNLNFGAL NIPPOIEDBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x376C130", Offset = "0x376AF30", VA = "0x18376C130", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BCPGDMEDKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x376FBE0", Offset = "0x376E9E0", VA = "0x18376FBE0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LDEFMJJCDDF NCEDAFKLJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3769290", Offset = "0x3768090", VA = "0x183769290", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3770910", Offset = "0x376F710", VA = "0x183770910", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x376C060", Offset = "0x376AE60", VA = "0x18376C060", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::NHIIIGIJKBI<LEDHMIGLCGN> OOKJCGCOOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x376C4B0", Offset = "0x376B2B0", VA = "0x18376C4B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3770E30", Offset = "0x376FC30", VA = "0x183770E30", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x37712B0", Offset = "0x37700B0", VA = "0x1837712B0")]
	public GGJMPKJGDJM(global::PANPJDPIOFA<Entity> JHGILNGJHFB, NLEJJFIEGLH OONGFKGINCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2729000", Offset = "0x2727E00", VA = "0x182729000")]
	private Entity EEILILFBJJA(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x376BE20", Offset = "0x376AC20", VA = "0x18376BE20")]
	private LEDHMIGLCGN EEILILFBJJA(Entity DNMNICOEECM)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x376D8F0", Offset = "0x376C6F0", VA = "0x18376D8F0", Slot = "4")]
	public T HEOCMNIHPLM(LEDHMIGLCGN NFBLCBCBMID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x376FA30", Offset = "0x376E830", VA = "0x18376FA30")]
	public bool LMMFIPJEJPN(LEDHMIGLCGN NFBLCBCBMID, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x376ACE0", Offset = "0x3769AE0", VA = "0x18376ACE0")]
	public bool CJEGMEKBMEG(LEDHMIGLCGN NFBLCBCBMID, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x376D2B0", Offset = "0x376C0B0", VA = "0x18376D2B0", Slot = "9")]
	public bool GPGONAPLKOC(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x376FE50", Offset = "0x376EC50", VA = "0x18376FE50", Slot = "26")]
	public object NKOGCKLALCN(LEDHMIGLCGN NFBLCBCBMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x376FEC0", Offset = "0x376ECC0", VA = "0x18376FEC0")]
	public bool OEDHDIGIDFK(LEDHMIGLCGN NFBLCBCBMID, in object IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x376D870", Offset = "0x376C670", VA = "0x18376D870")]
	public void HEOCMNIHPLM(LEDHMIGLCGN NFBLCBCBMID, in CBPKPEEEACL DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x376F910", Offset = "0x376E710", VA = "0x18376F910")]
	public bool LMMFIPJEJPN(LEDHMIGLCGN NFBLCBCBMID, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x376AC50", Offset = "0x3769A50", VA = "0x18376AC50")]
	public bool CJEGMEKBMEG(LEDHMIGLCGN NFBLCBCBMID, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x376E9A0", Offset = "0x376D7A0", VA = "0x18376E9A0", Slot = "22")]
	public void JIGGKPCGAGJ(AEKODNEMCEK IGBHFDGFHIO, [Optional] object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x376ECE0", Offset = "0x376DAE0", VA = "0x18376ECE0", Slot = "15")]
	public void JIGGKPCGAGJ(LEDHMIGLCGN CKMEBFKEHMO, FICEBFAABIF IGBHFDGFHIO, object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3770950", Offset = "0x376F750", VA = "0x183770950", Slot = "14")]
	public bool PCMCEDJAJPL(LEDHMIGLCGN AJPBOMDMGOF, LEDHMIGLCGN IDEEEMMOHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x376BBF0", Offset = "0x376A9F0", VA = "0x18376BBF0")]
	private void EBPEJCGGOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x376CDD0", Offset = "0x376BBD0", VA = "0x18376CDD0")]
	private void GJBDNDMOGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3769B50", Offset = "0x3768950", VA = "0x183769B50")]
	private void BOKIIFEGMGF(Entity DNMNICOEECM, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x376E630", Offset = "0x376D430", VA = "0x18376E630")]
	private void JHGLFCHJKPE(Entity DNMNICOEECM, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x376B2C0", Offset = "0x376A0C0", VA = "0x18376B2C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37710D0", Offset = "0x376FED0", VA = "0x1837710D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x376BE50", Offset = "0x376AC50", VA = "0x18376BE50")]
	public string ENMJHLPNDLG(in LDOGLLBKONE OGKLHAJDLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x376A810", Offset = "0x3769610", VA = "0x18376A810", Slot = "5")]
	private bool CFBDKHKIDNF(LEDHMIGLCGN CKMEBFKEHMO, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x376E5F0", Offset = "0x376D3F0", VA = "0x18376E5F0", Slot = "6")]
	private bool HFCLJKNDAHN(LEDHMIGLCGN CKMEBFKEHMO, in T IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x376F160", Offset = "0x376DF60", VA = "0x18376F160", Slot = "10")]
	private bool KIFDAKMDIFK(LEDHMIGLCGN CKMEBFKEHMO, in object IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x376D530", Offset = "0x376C330", VA = "0x18376D530", Slot = "11")]
	private void HAGDCEEAOLK(LEDHMIGLCGN CKMEBFKEHMO, in CBPKPEEEACL DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x376B280", Offset = "0x376A080", VA = "0x18376B280", Slot = "12")]
	private bool DLHEOHAOAEN(LEDHMIGLCGN CKMEBFKEHMO, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x376B2F0", Offset = "0x376A0F0", VA = "0x18376B2F0", Slot = "13")]
	private bool EAECKLHKNKC(LEDHMIGLCGN CKMEBFKEHMO, in LDOGLLBKONE IOMHKOCLPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3769120", Offset = "0x3767F20", VA = "0x183769120", Slot = "16")]
	private string BDNFAMGLHJL(in LDOGLLBKONE DPJGMDFEIDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EMPIKNKKIIH : IDisposable, KHBAIADNABO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> CAHPJEMBGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x909CA0", Offset = "0x908AA0", VA = "0x180909CA0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public EMPIKNKKIIH(NativeArray<EntityRemapUtility.EntityRemapInfo> EGBMIILGDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x90ECA0", Offset = "0x90DAA0", VA = "0x18090ECA0", Slot = "6")]
	public LEDHMIGLCGN FEMJPBHNFKG(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DAF0", VA = "0x18090ECF0", Slot = "7")]
	public Entity FEMJPBHNFKG(Entity DNMNICOEECM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x90EC00", Offset = "0x90DA00", VA = "0x18090EC00", Slot = "8")]
	public IEnumerable<LEDHMIGLCGN> FEMJPBHNFKG(IEnumerable<LEDHMIGLCGN> HNMDOPMMKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x90EBA0", Offset = "0x90D9A0", VA = "0x18090EBA0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly EKGLDANHPKF ACLHFICLHIO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int HFHGPJNINAN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static KHBAIADNABO PEPOBPKKBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool LPDIFAGNDMH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> CAHPJEMBGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x985B70", Offset = "0x984970", VA = "0x180985B70")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool HDPFLLBOJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9856E0", Offset = "0x9844E0", VA = "0x1809856E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x985B10", Offset = "0x984910", VA = "0x180985B10")]
		public static SerializationRemapScope LGDEMHCHPHO()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x985D10", Offset = "0x984B10", VA = "0x180985D10")]
		public SerializationRemapScope(KHBAIADNABO HPJMAGIAJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x985770", Offset = "0x984570", VA = "0x180985770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9859B0", Offset = "0x9847B0", VA = "0x1809859B0")]
		public static LEDHMIGLCGN FEMJPBHNFKG(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x985880", Offset = "0x984680", VA = "0x180985880")]
		public static Entity FEMJPBHNFKG(Entity DNMNICOEECM)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HLJOGLEHOLC(typeof(ELHOKCELKIA), new string[] { "Editor" })]
[ACKKCMMHKFG(MNIFKKPEEPE.Application)]
public sealed class ELHOKCELKIA
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void DPKLOMDMHOE(IJJNJPIJDOH MPCGLDPGOID, JPLAKIBMLBH CPLKBCGCHAN, bool OBEMFGFMMKN);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void GBLIFNLPFDB(IJJNJPIJDOH MPCGLDPGOID, bool OBEMFGFMMKN);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void AMLPDBODNKC(IJJNJPIJDOH MPCGLDPGOID, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE DPJGMDFEIDL, bool OBEMFGFMMKN);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DPKLOMDMHOE MJAMAOHEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x90E2D0", Offset = "0x90D0D0", VA = "0x18090E2D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x90E170", Offset = "0x90CF70", VA = "0x18090E170")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GBLIFNLPFDB ELGEBKPMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x90E030", Offset = "0x90CE30", VA = "0x18090E030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x90E0D0", Offset = "0x90CED0", VA = "0x18090E0D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event AMLPDBODNKC AINFOHHJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x90E390", Offset = "0x90D190", VA = "0x18090E390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x90E230", Offset = "0x90D030", VA = "0x18090E230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x90E210", Offset = "0x90D010", VA = "0x18090E210")]
	[Conditional("UNITY_EDITOR")]
	public void HDHNHFLKPOO(IJJNJPIJDOH MPCGLDPGOID, in JPLAKIBMLBH CPLKBCGCHAN, bool OBEMFGFMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x90E370", Offset = "0x90D170", VA = "0x18090E370")]
	[Conditional("UNITY_EDITOR")]
	public void NAJPCCHBLCG(IJJNJPIJDOH MPCGLDPGOID, bool OBEMFGFMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x90E430", Offset = "0x90D230", VA = "0x18090E430")]
	[Conditional("UNITY_EDITOR")]
	public void PFHGAGDDPDD(IJJNJPIJDOH MPCGLDPGOID, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE DPJGMDFEIDL, bool OBEMFGFMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public ELHOKCELKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[HLJOGLEHOLC(typeof(JMGAEOJCJBO), new string[] { "Editor" })]
[ACKKCMMHKFG(MNIFKKPEEPE.Application)]
public sealed class JMGAEOJCJBO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void LPGJAAHBEGH(IJJNJPIJDOH OJMDJGIIFAA, JPLAKIBMLBH CPLKBCGCHAN, bool OBEMFGFMMKN);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void PJMMDGJOEEA(IJJNJPIJDOH OJMDJGIIFAA, bool OBEMFGFMMKN);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void NHLNIJHDGLF(IJJNJPIJDOH OJMDJGIIFAA, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE DPJGMDFEIDL, bool OBEMFGFMMKN, bool MNBNBBMBHBI);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void CEDPLMGHGBO(IJJNJPIJDOH OJMDJGIIFAA, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void LHDIAEJHHOG(DNAANJIGDPC CKMEBFKEHMO, ReadOnlyMemory<byte> GGOKHMJBGJO);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event LPGJAAHBEGH MJAMAOHEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA33660", Offset = "0xA32460", VA = "0x180A33660")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA33390", Offset = "0xA32190", VA = "0x180A33390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event PJMMDGJOEEA ELGEBKPMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA32F90", Offset = "0xA31D90", VA = "0x180A32F90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA330D0", Offset = "0xA31ED0", VA = "0x180A330D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event LPGJAAHBEGH OKMJDHMHMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA332B0", Offset = "0xA320B0", VA = "0x180A332B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA33930", Offset = "0xA32730", VA = "0x180A33930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PJMMDGJOEEA ECGPBLMPLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA33210", Offset = "0xA32010", VA = "0x180A33210")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA337F0", Offset = "0xA325F0", VA = "0x180A337F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event NHLNIJHDGLF AINFOHHJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA339D0", Offset = "0xA327D0", VA = "0x180A339D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA33490", Offset = "0xA32290", VA = "0x180A33490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event CEDPLMGHGBO BLCOLMCKPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA33A70", Offset = "0xA32870", VA = "0x180A33A70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA33030", Offset = "0xA31E30", VA = "0x180A33030")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> GOBKHHNFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA33170", Offset = "0xA31F70", VA = "0x180A33170")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA33720", Offset = "0xA32520", VA = "0x180A33720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event LHDIAEJHHOG FOOKHJJMBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA33530", Offset = "0xA32330", VA = "0x180A33530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA33890", Offset = "0xA32690", VA = "0x180A33890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA33460", Offset = "0xA32260", VA = "0x180A33460")]
	[Conditional("UNITY_EDITOR")]
	public void GOCBKOEPLBO(IJJNJPIJDOH OJMDJGIIFAA, in JPLAKIBMLBH CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA33700", Offset = "0xA32500", VA = "0x180A33700")]
	[Conditional("UNITY_EDITOR")]
	public void LLLPOLBIDOJ(IJJNJPIJDOH OJMDJGIIFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA337C0", Offset = "0xA325C0", VA = "0x180A337C0")]
	[Conditional("UNITY_EDITOR")]
	public void MEENLFMIHNI(IJJNJPIJDOH OJMDJGIIFAA, in JPLAKIBMLBH CPLKBCGCHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA33350", Offset = "0xA32150", VA = "0x180A33350")]
	[Conditional("UNITY_EDITOR")]
	public void FLBIBPPOHJP(IJJNJPIJDOH OJMDJGIIFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA335D0", Offset = "0xA323D0", VA = "0x180A335D0")]
	[Conditional("UNITY_EDITOR")]
	public void IJPPOAGHIGK(IJJNJPIJDOH OJMDJGIIFAA, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE DPJGMDFEIDL, bool MNBNBBMBHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xA33370", Offset = "0xA32170", VA = "0x180A33370")]
	[Conditional("UNITY_EDITOR")]
	public void GEGMBIOMHAC(IJJNJPIJDOH OJMDJGIIFAA, INOPGIMBOKC JHGILNGJHFB, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xA33600", Offset = "0xA32400", VA = "0x180A33600")]
	[Conditional("UNITY_EDITOR")]
	public void KAGAPENFJLI(string CCEKFDNIAPD, object GGOKHMJBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xA33430", Offset = "0xA32230", VA = "0x180A33430")]
	[Conditional("UNITY_EDITOR")]
	public void GMICMPKKBOM(DNAANJIGDPC CKMEBFKEHMO, ReadOnlyMemory<byte> GGOKHMJBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public JMGAEOJCJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HLJOGLEHOLC(typeof(CMECNGNHFLI), new string[] { })]
public class CMOIILJOLJM : CMECNGNHFLI
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA20", Offset = "0x8FC820", VA = "0x1808FDA20", Slot = "5")]
	public void LKNHLHDGEJN(object IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8FD930", Offset = "0x8FC730", VA = "0x1808FD930", Slot = "6")]
	public void KMANIENLMJO(object IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB10", Offset = "0x8FC910", VA = "0x1808FDB10", Slot = "7")]
	public void MIGBAFAHCGI(object IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8FD810", Offset = "0x8FC610", VA = "0x1808FD810", Slot = "4")]
	public IDisposable EADBFNIJGLF(object IACFBMPPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CMOIILJOLJM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[HLJOGLEHOLC(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	internal class BulkInstantiateSceneObjectService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string CBALANGMOPL = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[AGIJCBMCMGO]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[AGIJCBMCMGO]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[AGIJCBMCMGO]
		private OIHJCGPPHNA PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery LJJFEBPHLOD;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8FB030", Offset = "0x8F9E30", VA = "0x1808FB030")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9240", Offset = "0x8F8040", VA = "0x1808F9240", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA440", Offset = "0x8F9240", VA = "0x1808FA440", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA450", Offset = "0x8F9250", VA = "0x1808FA450")]
		public bool ENACFKHBIEI(IEnumerable<KGIJKPANHFI> BBGJPDONBBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF20", Offset = "0x8F9D20", VA = "0x1808FAF20")]
		public static bool LDEBANPHGPP(KGIJKPANHFI GKLLPHJPFFI, out IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7A0", Offset = "0x8F95A0", VA = "0x1808FA7A0")]
		private void GAPJGHBCKFA(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA, IEnumerable<KGIJKPANHFI> BBGJPDONBBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8FACF0", Offset = "0x8F9AF0", VA = "0x1808FACF0")]
		private void JGNHGBPDJEI(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FC0", Offset = "0x8F8DC0", VA = "0x1808F9FC0")]
		private void DJENNMBEFJK(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA, IJJNJPIJDOH OJMDJGIIFAA, string CCEKFDNIAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8F93C0", Offset = "0x8F81C0", VA = "0x1808F93C0")]
		private void CFADHLLEHCK(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8F9720", Offset = "0x8F8520", VA = "0x1808F9720")]
		private void DHPCBHADAME(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA, List<KGIJKPANHFI> ODAGIMEJDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB20", Offset = "0x8F9920", VA = "0x1808FAB20")]
		private NativeList<IJJNJPIJDOH> HIIONFPHGGF(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA)
		{
			return default(NativeList<IJJNJPIJDOH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5D0", Offset = "0x8F93D0", VA = "0x1808FA5D0")]
		private NativeArray<Entity> FEGACCMEDGD(NativeList<IJJNJPIJDOH> DNBBAENMIBN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8FB080", Offset = "0x8F9E80", VA = "0x1808FB080")]
		private static void PKOGCLEOKOF(Dictionary<IJJNJPIJDOH, KGIJKPANHFI> EJIPNPFMBNA, IJJNJPIJDOH OJMDJGIIFAA, KGIJKPANHFI GKLLPHJPFFI, string CCEKFDNIAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ACKKCMMHKFG(MNIFKKPEEPE.Application)]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	[HLJOGLEHOLC(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool EEONKLFELKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x90C610", Offset = "0x90B410", VA = "0x18090C610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x90C5D0", Offset = "0x90B3D0", VA = "0x18090C5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool EFEJMEIFANB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x90C650", Offset = "0x90B450", VA = "0x18090C650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x90C590", Offset = "0x90B390", VA = "0x18090C590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public void MKKENGABBGM(string CCEKFDNIAPD, EntityManager ECFOMHOIDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public static void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HLJOGLEHOLC(typeof(CNJANGGLMNJ), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.Application)]
internal class CNJANGGLMNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool EEONKLFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E8110", Offset = "0x8E6F10", VA = "0x1808E8110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FCE20", VA = "0x1808FE020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool OJFAOMIMLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8E8120", Offset = "0x8E6F20", VA = "0x1808E8120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8FE030", Offset = "0x8FCE30", VA = "0x1808FE030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CNJANGGLMNJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BKADEOMONEA(typeof(SerializationService))]
	[HLJOGLEHOLC(typeof(AKKBHFINLKC), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	internal class SerializationService : AKKBHFINLKC, IDisposable, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly EKGLDANHPKF NCAKIFNFNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[AGIJCBMCMGO]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[AGIJCBMCMGO]
		private EMEFJJPEKKP PHBHDKPPOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[AGIJCBMCMGO]
		private CNJANGGLMNJ FEBCBLODHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BMCBJIJOKNO CMKDILJPEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private HAELDGHLPLD NCPHHFHPMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope IGJHMGIGCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? JDHHHIPIDMI;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool DNNLLIBDHPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x985DA0", Offset = "0x984BA0", VA = "0x180985DA0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x986020", Offset = "0x984E20", VA = "0x180986020", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HBFEKJLMECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6F7020", Offset = "0x6F5E20", VA = "0x1806F7020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x986320", Offset = "0x985120", VA = "0x180986320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public HAELDGHLPLD OOAHONOPJGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x985F80", Offset = "0x984D80", VA = "0x180985F80", Slot = "16")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x986330", Offset = "0x985130", VA = "0x180986330", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x986390", Offset = "0x985190", VA = "0x180986390")]
		public static bool ENAAFDBOFON(ByteString KLGAKJLGGNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BE0", Offset = "0x6CF9E0", VA = "0x1806D0BE0")]
		public void OFGKPJCOPGP(BMCBJIJOKNO EEEOKEEMKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9874A0", Offset = "0x9862A0", VA = "0x1809874A0", Slot = "5")]
		public void KDHNCCKHKHJ(bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x987BA0", Offset = "0x9869A0", VA = "0x180987BA0", Slot = "6")]
		public Task MGDMIJOJFMM(bool BBEGNBBGFBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x986DE0", Offset = "0x985BE0", VA = "0x180986DE0", Slot = "7")]
		public ByteString HGGLACGHMAP(out IDisposable IGJHMGIGCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x986C00", Offset = "0x985A00", VA = "0x180986C00", Slot = "19")]
		public ByteString HGGLACGHMAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x987210", Offset = "0x986010", VA = "0x180987210", Slot = "9")]
		public bool IMPOKOFCPDO(ByteString DBBHHOAFCKJ, CPPFNCIAGDJ POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x986840", Offset = "0x985640", VA = "0x180986840")]
		private bool FFFOLKPFNDM(ByteString DBBHHOAFCKJ, CPPFNCIAGDJ POLNGKBPPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x987740", Offset = "0x986540", VA = "0x180987740", Slot = "8")]
		public void LCPLMLHAHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x986FA0", Offset = "0x985DA0", VA = "0x180986FA0", Slot = "10")]
		public bool IKKMMNAIGBK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9864C0", Offset = "0x9852C0", VA = "0x1809864C0", Slot = "11")]
		public bool ENACFKHBIEI(IEnumerable<KGIJKPANHFI> IDNOGKNDBCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x986EC0", Offset = "0x985CC0", VA = "0x180986EC0")]
		public bool IHONJIOMNKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x987270", Offset = "0x986070", VA = "0x180987270", Slot = "12")]
		public bool JLEDNMLPELE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x987910", Offset = "0x986710", VA = "0x180987910")]
		public void MCLCILHLDPL(HAELDGHLPLD.MGAOHJGFOJI.FAPLOIPGKKI LIMMJLMICDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x986030", Offset = "0x984E30", VA = "0x180986030")]
		private bool CLEKDOOLLDO(ByteString DBBHHOAFCKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x986340", Offset = "0x985140", VA = "0x180986340")]
		private void EFDMLHENAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9862C0", Offset = "0x9850C0", VA = "0x1809862C0")]
		private ByteString DCLMLDBLIMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x986730", Offset = "0x985530", VA = "0x180986730")]
		private ByteString FEOOHGENIEC(ByteString KLGAKJLGGNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x986B60", Offset = "0x985960", VA = "0x180986B60")]
		private HAELDGHLPLD.MGAOHJGFOJI.FAPLOIPGKKI GBBJPLDLBEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x987C30", Offset = "0x986A30", VA = "0x180987C30")]
		private void MMCKAEGCPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x985DB0", Offset = "0x984BB0", VA = "0x180985DB0", Slot = "13")]
		public bool BANEDGGLFNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x987C60", Offset = "0x986A60", VA = "0x180987C60", Slot = "14")]
		public void OIGDMJFCIGC(bool AMOGCEDILFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x987570", Offset = "0x986370", VA = "0x180987570")]
		private void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HLJOGLEHOLC(typeof(JPBNEEDJLKP), new string[] { })]
[BKADEOMONEA(typeof(EMEFJJPEKKP))]
internal class EMEFJJPEKKP : JPBNEEDJLKP
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action FDLPMJPOIID
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x90E9A0", Offset = "0x90D7A0", VA = "0x18090E9A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x90E5A0", Offset = "0x90D3A0", VA = "0x18090E5A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KHBAIADNABO> LOPFKNGBHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x90E720", Offset = "0x90D520", VA = "0x18090E720", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x90EA40", Offset = "0x90D840", VA = "0x18090EA40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action MACAHLMGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x90E7C0", Offset = "0x90D5C0", VA = "0x18090E7C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x90EB00", Offset = "0x90D900", VA = "0x18090EB00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MKKPMEJJNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x90E860", Offset = "0x90D660", VA = "0x18090E860", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x90E900", Offset = "0x90D700", VA = "0x18090E900", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<KHBAIADNABO> PCNLPJEHCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x90E460", Offset = "0x90D260", VA = "0x18090E460", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x90E500", Offset = "0x90D300", VA = "0x18090E500", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x90E690", Offset = "0x90D490", VA = "0x18090E690")]
	public void LCPLMLHAHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x90EAE0", Offset = "0x90D8E0", VA = "0x18090EAE0")]
	public void PNGLOPGOGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x90E6B0", Offset = "0x90D4B0", VA = "0x18090E6B0")]
	public void LFJBKJPNDPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x90E6D0", Offset = "0x90D4D0", VA = "0x18090E6D0")]
	public void LMFGDAEKAGN(KHBAIADNABO PEPOBPKKBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x90E640", Offset = "0x90D440", VA = "0x18090E640")]
	public void JGJBGJPADJH(KHBAIADNABO PEPOBPKKBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public EMEFJJPEKKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[HLJOGLEHOLC(typeof(OJCNMNJFNCK), new string[] { })]
public class HKGIAEKDKIG : OJCNMNJFNCK, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents PADELIJHEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private LEBPMDNKHBB LCJHLEPBNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService EAFONAFODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::DNHLENHGBPH<LEDHMIGLCGN> HKFFKPMFCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A70", Offset = "0x6C4870", VA = "0x1806C5A70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D4460", Offset = "0x6D3260", VA = "0x1806D4460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA27F50", Offset = "0xA26D50", VA = "0x180A27F50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xA27790", Offset = "0xA26590", VA = "0x180A27790", Slot = "14")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xA27330", Offset = "0xA26130", VA = "0x180A27330", Slot = "15")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xA27D20", Offset = "0xA26B20", VA = "0x180A27D20", Slot = "16")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5490", VA = "0x1808B6690", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x8B34C0", Offset = "0x8B22C0", VA = "0x1808B34C0")]
	private LEDHMIGLCGN LPHLHJIADFE(Entity DNMNICOEECM)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0xA27400", Offset = "0xA26200", VA = "0x180A27400", Slot = "4")]
	public LEDHMIGLCGN CONDOMCIIBM(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0xA27910", Offset = "0xA26710", VA = "0x180A27910", Slot = "19")]
	public void IJFGJNIGJLA(ref List<LEDHMIGLCGN> FAEPHALCHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xA27FA0", Offset = "0xA26DA0", VA = "0x180A27FA0", Slot = "20")]
	public IEnumerable<LEDHMIGLCGN> LIKIKMEKNMI(LEDHMIGLCGN NFBLCBCBMID, bool EIKBGGPMPHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA275C0", Offset = "0xA263C0", VA = "0x180A275C0", Slot = "21")]
	public LEDHMIGLCGN FPACLIHAMAM(LEDHMIGLCGN NFBLCBCBMID, int DJIEOHJNDEK)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0xA27B40", Offset = "0xA26940", VA = "0x180A27B40", Slot = "22")]
	public int JEFEAOAIBKL(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0xA26F50", Offset = "0xA25D50", VA = "0x180A26F50", Slot = "8")]
	public int AFINJGDAMJP(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xA282B0", Offset = "0xA270B0", VA = "0x180A282B0", Slot = "9")]
	public CNNILEPOHAI NCNAENHJAIP(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(CNNILEPOHAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0xA270F0", Offset = "0xA25EF0", VA = "0x180A270F0", Slot = "23")]
	public bool AOHKCGFLBAJ(LEDHMIGLCGN NFBLCBCBMID, out CNNILEPOHAI LEIIJCHNPCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0xA283A0", Offset = "0xA271A0", VA = "0x180A283A0", Slot = "24")]
	public IEnumerable<LEDHMIGLCGN> OLAHGGADNDF(LEDHMIGLCGN NFBLCBCBMID, bool EIKBGGPMPHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0xA27840", Offset = "0xA26640", VA = "0x180A27840", Slot = "12")]
	public LEDHMIGLCGN IEFPBIBEMHK(LEDHMIGLCGN MOKGIKPKEBG, LEDHMIGLCGN PABKONOGBKI)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA262F0", VA = "0x180A274F0", Slot = "13")]
	public bool ELMNJLIGOFH(LEDHMIGLCGN MOKGIKPKEBG, LEDHMIGLCGN PABKONOGBKI, out LEDHMIGLCGN BDKHOEDMNIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xA277A0", Offset = "0xA265A0", VA = "0x180A277A0", Slot = "5")]
	public LEDHMIGLCGN GCHFIHMHOPE(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0xA27C60", Offset = "0xA26A60", VA = "0x180A27C60", Slot = "11")]
	public bool JNLEIODLHDK(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN NKHKMPCFDCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0xA27E10", Offset = "0xA26C10", VA = "0x180A27E10", Slot = "25")]
	public bool LDGJJGLOIFM(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN JJJNIHBIILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xA281A0", Offset = "0xA26FA0", VA = "0x180A281A0", Slot = "10")]
	public bool MIOBDMMEPAF(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN MOKGIKPKEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA28470", Offset = "0xA27270", VA = "0x180A28470", Slot = "6")]
	public bool OLGACPEMICJ(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN KICGHGEEADG, bool JMPINMPLJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0xA272C0", Offset = "0xA260C0", VA = "0x180A272C0", Slot = "7")]
	public bool BBFMINOPBKF(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN KICGHGEEADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public HKGIAEKDKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(CCKFACOPIOK), new string[] { })]
internal class CCKFACOPIOK : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[AGIJCBMCMGO]
	private GNIJOOFEPBL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, DBEKECCGIHJ> GNKJHGPPBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8FB320", Offset = "0x8FA120", VA = "0x1808FB320", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8FB370", Offset = "0x8FA170", VA = "0x1808FB370", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8FB810", Offset = "0x8FA610", VA = "0x1808FB810")]
	public DBEKECCGIHJ FIPFPNOHFMH(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8FB5F0", Offset = "0x8FA3F0", VA = "0x1808FB5F0")]
	public DBEKECCGIHJ FIPFPNOHFMH(INOPGIMBOKC JFGKEENDEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8FB910", Offset = "0x8FA710", VA = "0x1808FB910")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8FBAA0", Offset = "0x8FA8A0", VA = "0x1808FBAA0")]
	public CCKFACOPIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class DBEKECCGIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<JMPBHAINDLE> MKDMMGKEGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<KFJMJFAJGPB> PKNFMDNGPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<DHHOEPAHABD> DLGBIBLJAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<KFJMJFAJGPB> PPIHKFKCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<JMPBHAINDLE> NLFNJJNKMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x909CA0", Offset = "0x908AA0", VA = "0x180909CA0")]
		get
		{
			return default(NativeList<JMPBHAINDLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<KFJMJFAJGPB> MAEGICIMGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0")]
		get
		{
			return default(NativeList<KFJMJFAJGPB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<DHHOEPAHABD> IDEEODCAAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B9410", Offset = "0x8B8210", VA = "0x1808B9410")]
		get
		{
			return default(NativeList<DHHOEPAHABD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<KFJMJFAJGPB> OLAMJMHAABP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x909E90", Offset = "0x908C90", VA = "0x180909E90")]
		get
		{
			return default(NativeList<KFJMJFAJGPB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle HGBKEDLLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x909EA0", Offset = "0x908CA0", VA = "0x180909EA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9098F0", Offset = "0x9086F0", VA = "0x1809098F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MCKHJMONIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9098E0", Offset = "0x9086E0", VA = "0x1809098E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KPKEJCNLKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x909DE0", Offset = "0x908BE0", VA = "0x180909DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x909EB0", Offset = "0x908CB0", VA = "0x180909EB0")]
	public DBEKECCGIHJ(Allocator CMCENMLGNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908A10", VA = "0x180909C10")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x909CB0", Offset = "0x908AB0", VA = "0x180909CB0")]
	public void LFLAMKKDLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x909900", Offset = "0x908700", VA = "0x180909900")]
	public void EKGLGHAFJEH(Entity DNMNICOEECM, Entity JEAPMLEICDM, Entity DDNBMNPALIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HLJOGLEHOLC(typeof(MJHHIFBOFOO), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
public class MJHHIFBOFOO : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[AGIJCBMCMGO]
	private SceneService BBLHCHIFBMC;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8A94B0", Offset = "0x8A82B0", VA = "0x1808A94B0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8A9500", Offset = "0x8A8300", VA = "0x1808A9500", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public MJHHIFBOFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class NCFMPJKEBIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint KAMCAHAKAJK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint JMLONEFIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B60", Offset = "0x8A8960", VA = "0x1808A9B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B90", Offset = "0x8A8990", VA = "0x1808A9B90")]
	public IJJNJPIJDOH JFJCELDCOFK()
	{
		return default(IJJNJPIJDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8A9BE0", Offset = "0x8A89E0", VA = "0x1808A9BE0")]
	public void LMFJABMLCDG(IJJNJPIJDOH OJMDJGIIFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B80", Offset = "0x8A8980", VA = "0x1808A9B80", Slot = "6")]
	public virtual void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected NCFMPJKEBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(DJLEFFBIDHF), new string[] { })]
internal sealed class DJLEFFBIDHF : NCFMPJKEBIE, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[AGIJCBMCMGO]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint BBBGEOBCIIP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint JMLONEFIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x749E00", Offset = "0x748C00", VA = "0x180749E00", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x90BAE0", Offset = "0x90A8E0", VA = "0x18090BAE0", Slot = "7")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x90BA90", Offset = "0x90A890", VA = "0x18090BA90")]
	private void AFHOJHEICJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x90BB80", Offset = "0x90A980", VA = "0x18090BB80", Slot = "6")]
	public override void FLOLCMPEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
	public DJLEFFBIDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HLJOGLEHOLC(typeof(NOOFHADLCDP), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal sealed class NOOFHADLCDP : NCFMPJKEBIE
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint JMLONEFIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NOOFHADLCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(HGLBLJEIAMO), new string[] { })]
internal sealed class HGLBLJEIAMO : MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery MAPEKKPPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery HMFOAPCKMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery BKGJGAJPLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery BHLLCGNGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery JOOCBNKMIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery FEHKPNCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA26C60", Offset = "0xA25A60", VA = "0x180A26C60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery EDCOOFMPMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery DCEIPCDAKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6DBC60", Offset = "0x6DAA60", VA = "0x1806DBC60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery BFIHPILNLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x970830", Offset = "0x96F630", VA = "0x180970830")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery NPKHILLLBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x909EA0", Offset = "0x908CA0", VA = "0x180909EA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery AANJKBOHCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA26CB0", Offset = "0xA25AB0", VA = "0x180A26CB0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery MEAOAJELPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA263A0", Offset = "0xA251A0", VA = "0x180A263A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int PDOLEKFLOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA26580", Offset = "0xA25380", VA = "0x180A26580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JMMHIHALELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA265A0", Offset = "0xA253A0", VA = "0x180A265A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int HHAMODJGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA267A0", Offset = "0xA255A0", VA = "0x180A267A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int LEGOPGAHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA26CC0", Offset = "0xA25AC0", VA = "0x180A26CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int FLPCGNOMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA265C0", Offset = "0xA253C0", VA = "0x180A265C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int HEMNEACKHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA26CE0", Offset = "0xA25AE0", VA = "0x180A26CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA26420", Offset = "0xA25220", VA = "0x180A26420", Slot = "5")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA267C0", Offset = "0xA255C0", VA = "0x180A267C0", Slot = "6")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA26740", Offset = "0xA25540", VA = "0x180A26740")]
	private EntityQueryDesc GMEGIAHKIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA26520", Offset = "0xA25320", VA = "0x180A26520", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA265E0", Offset = "0xA253E0", VA = "0x180A265E0")]
	public CKIGPKJBBEE GHDBNJKOJMG(LEDHMIGLCGN BHMKDBDFPKN)
	{
		return default(CKIGPKJBBEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA26690", Offset = "0xA25490", VA = "0x180A26690")]
	public CKIGPKJBBEE GHDBNJKOJMG(Entity DNMNICOEECM)
	{
		return default(CKIGPKJBBEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xA26470", Offset = "0xA25270", VA = "0x180A26470")]
	public FIMAOKHBMMB DMBLIFKAIJH(Entity DNMNICOEECM)
	{
		return default(FIMAOKHBMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xA26D00", Offset = "0xA25B00", VA = "0x180A26D00")]
	public HGLBLJEIAMO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[KNPMBINOPIG(MLNJOBCAIAM.All)]
	[HLJOGLEHOLC(typeof(NLEJJFIEGLH), new string[] { })]
	public class ObjectService : KPALCLLIODG, NLEJJFIEGLH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly EKGLDANHPKF KICKBGBJGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[AGIJCBMCMGO]
		private EJJKOHOJBIP LHNNPMPCLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[AGIJCBMCMGO]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[AGIJCBMCMGO]
		private ObjectLifecycleService EEIMFPOJEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[AGIJCBMCMGO]
		private ObjectEmbodimentService EAFONAFODFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[AGIJCBMCMGO]
		private ObjectInstantiationService ONDFKMMBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[AGIJCBMCMGO]
		private HGLBLJEIAMO LCJHLEPBNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService JKFEKEAGDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public EJJKOHOJBIP IGKGCEECDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int PDOLEKFLOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA10", Offset = "0x8BA810", VA = "0x1808BBA10", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int JMMHIHALELI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8BBAD0", Offset = "0x8BA8D0", VA = "0x1808BBAD0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int HHAMODJGJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF40", Offset = "0x8BAD40", VA = "0x1808BBF40", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int LEGOPGAHLOK
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8BCDF0", Offset = "0x8BBBF0", VA = "0x1808BCDF0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int FLPCGNOMGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBAF0", Offset = "0x8BA8F0", VA = "0x1808BBAF0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int HEMNEACKHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8BCE60", Offset = "0x8BBC60", VA = "0x1808BCE60", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<LEDHMIGLCGN, FIMAOKHBMMB> MNADECFAHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8BB170", Offset = "0x8B9F70", VA = "0x1808BB170", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8BB570", Offset = "0x8BA370", VA = "0x1808BB570", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<LEDHMIGLCGN> OGCBDFLOBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD50", Offset = "0x8BBB50", VA = "0x1808BCD50", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8BC870", Offset = "0x8BB670", VA = "0x1808BC870", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8BA060", VA = "0x1808BB260", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BB830", Offset = "0x8BA630", VA = "0x1808BB830", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE80", Offset = "0x8BBC80", VA = "0x1808BCE80")]
		private void PFPICGPAPDA(Entity DNMNICOEECM, FIMAOKHBMMB JPILKLCBOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8BC930", Offset = "0x8BB730", VA = "0x1808BC930")]
		private void NIOKIPEJBCN(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5E0", Offset = "0x8BB3E0", VA = "0x1808BC5E0")]
		internal LEDHMIGLCGN LPHLHJIADFE(Entity DNMNICOEECM)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF60", Offset = "0x8BAD60", VA = "0x1808BBF60", Slot = "41")]
		public CNNILEPOHAI JMOFOHKGJHM()
		{
			return default(CNNILEPOHAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7C0", Offset = "0x8BB5C0", VA = "0x1808BC7C0", Slot = "42")]
		public CNNILEPOHAI NDHAJPPNHKE()
		{
			return default(CNNILEPOHAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4D0", Offset = "0x8BA2D0", VA = "0x1808BB4D0", Slot = "43")]
		public CNNILEPOHAI BPPJCOGNHHN()
		{
			return default(CNNILEPOHAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC0", Offset = "0x8BAAC0", VA = "0x1808BBCC0", Slot = "10")]
		public CKIGPKJBBEE GHDBNJKOJMG(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(CKIGPKJBBEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7A0", Offset = "0x8BA5A0", VA = "0x1808BB7A0", Slot = "11")]
		public FIMAOKHBMMB DMBLIFKAIJH(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(FIMAOKHBMMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BC670", Offset = "0x8BB470", VA = "0x1808BC670")]
		private CNNILEPOHAI MGIFCDBFEED(EntityQuery EFCFIFNMPEK)
		{
			return default(CNNILEPOHAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCF0", Offset = "0x8BAAF0", VA = "0x1808BBCF0", Slot = "33")]
		public bool GPGONAPLKOC(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7E0", Offset = "0x8BA5E0", VA = "0x1808BB7E0", Slot = "29")]
		public void DMKMELLNHHE(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8BC230", Offset = "0x8BB030", VA = "0x1808BC230", Slot = "30")]
		public void KJOGCPPIFAO(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA30", Offset = "0x8BA830", VA = "0x1808BBA30", Slot = "31")]
		public void EJJEEPIOMOI(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE00", Offset = "0x8BAC00", VA = "0x1808BBE00", Slot = "22")]
		public HMIODAKHEJO HANFBOOMCII(FIMAOKHBMMB JPILKLCBOKG, bool LEELDADPDHC)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD80", Offset = "0x8BAB80", VA = "0x1808BBD80", Slot = "23")]
		public HMIODAKHEJO HANFBOOMCII(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1A0", Offset = "0x8BAFA0", VA = "0x1808BC1A0", Slot = "24")]
		public HMIODAKHEJO KFPFEMMHDDG(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9C0", Offset = "0x8BB7C0", VA = "0x1808BC9C0", Slot = "25")]
		public HMIODAKHEJO NMBKONPBDBE(IJJNJPIJDOH OJMDJGIIFAA, FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC600", Offset = "0x8BB400", VA = "0x1808BC600", Slot = "44")]
		public HMIODAKHEJO MBNCJBGKLAA(int EPEKMECFDIJ, FIMAOKHBMMB JPILKLCBOKG, GameObject NGIKODIIBGN)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8BC720", Offset = "0x8BB520", VA = "0x1808BC720", Slot = "26")]
		public GCEEIMOEHKJ MMBIBOHEECG()
		{
			return default(GCEEIMOEHKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0A0", Offset = "0x8BAEA0", VA = "0x1808BC0A0", Slot = "45")]
		public LGOMFCINEEK KCCBGGDPNAH(GGPGKEMMOBN LAKBKKJKBPK)
		{
			return default(LGOMFCINEEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF20", Offset = "0x8BBD20", VA = "0x1808BCF20", Slot = "27")]
		public ENGDHDFLPEN PMJHHFAPJMP()
		{
			return default(ENGDHDFLPEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC10", Offset = "0x8BBA10", VA = "0x1808BCC10", Slot = "28")]
		public HMIEOIHMPGF OAEDBDNFBBP(MKFEGIBJCLL LAKBKKJKBPK)
		{
			return default(HMIEOIHMPGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD30", Offset = "0x8BBB30", VA = "0x1808BCD30", Slot = "12")]
		public void OBNDPKOJMJJ(IJJNJPIJDOH OJMDJGIIFAA, EBIEHGPCOMI NINEKIGDNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB10", Offset = "0x8BA910", VA = "0x1808BBB10", Slot = "13")]
		public HMIODAKHEJO GEKAIKIDDEH(LEDHMIGLCGN NFBLCBCBMID, [Optional] object DPODOOAHECI)
		{
			return default(HMIODAKHEJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8BC000", Offset = "0x8BAE00", VA = "0x1808BC000", Slot = "14")]
		public bool JOBPINEJIPE(LEDHMIGLCGN NFBLCBCBMID, out EBIEHGPCOMI LILKGIPDCFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEF0", Offset = "0x8BACF0", VA = "0x1808BBEF0", Slot = "46")]
		public Transform HIJGCJPBNOE(LEDHMIGLCGN NFBLCBCBMID, [Optional] object DPODOOAHECI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE10", Offset = "0x8BBC10", VA = "0x1808BCE10", Slot = "16")]
		public bool PBBNBKDNKEE(LEDHMIGLCGN NFBLCBCBMID, out Transform HAFNICDKMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8BA010", VA = "0x1808BB210", Slot = "17")]
		public bool BEGPOELPKJE(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB100", Offset = "0x8B9F00", VA = "0x1808BB100")]
		public bool AGHGLADNMDE(EBIEHGPCOMI DPJGMDFEIDL, [Optional] object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9ED0", VA = "0x1808BB0D0", Slot = "47")]
		public bool AGHGLADNMDE(LEDHMIGLCGN NFBLCBCBMID, [Optional] object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC910", Offset = "0x8BB710", VA = "0x1808BC910", Slot = "48")]
		public void NGJHIIPHIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3F0", Offset = "0x8BB1F0", VA = "0x1808BC3F0", Slot = "15")]
		public void LCHDJDDIBCM(EBIEHGPCOMI LOPIEGGIDMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5A0", Offset = "0x8BB3A0", VA = "0x1808BC5A0", Slot = "49")]
		public void LFGAABNLBMD(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB90", Offset = "0x8BB990", VA = "0x1808BCB90", Slot = "18")]
		public bool OADOIGGJJMA(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8BB610", Offset = "0x8BA410", VA = "0x1808BB610", Slot = "19")]
		public bool CINGDJMBNFK(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8BB730", Offset = "0x8BA530", VA = "0x1808BB730", Slot = "50")]
		public bool DMANKIDBMNB(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8BC290", Offset = "0x8BB090", VA = "0x1808BC290", Slot = "51")]
		public bool KKDJDPJBDPA(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9B0", Offset = "0x8BA7B0", VA = "0x1808BB9B0", Slot = "32")]
		public NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)> ECIGONMMNAN(NativeArray<LEDHMIGLCGN> KCACLEAMEOJ, Allocator CMCENMLGNBG)
		{
			return default(NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8BB690", Offset = "0x8BA490", VA = "0x1808BB690", Slot = "21")]
		public IJJNJPIJDOH DHOBLPLBCCE(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(IJJNJPIJDOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8BC300", Offset = "0x8BB100", VA = "0x1808BC300", Slot = "20")]
		public LEDHMIGLCGN KOOGDODNOPA(IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8BB130", Offset = "0x8B9F30", VA = "0x1808BB130")]
		private void AHACEMPEGFN(FIMAOKHBMMB JPILKLCBOKG, LEDHMIGLCGN NFBLCBCBMID, IJJNJPIJDOH OJMDJGIIFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HLJOGLEHOLC(typeof(BKCKABBABHB), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal sealed class BKCKABBABHB : KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService ONDFKMMBLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[AGIJCBMCMGO]
	private HGLBLJEIAMO LCJHLEPBNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8F7C40", Offset = "0x8F6A40", VA = "0x1808F7C40", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8F7CD0", Offset = "0x8F6AD0", VA = "0x1808F7CD0")]
	public NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)> ECIGONMMNAN(NativeArray<LEDHMIGLCGN> KCACLEAMEOJ, Allocator CMCENMLGNBG)
	{
		return default(NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8F86D0", Offset = "0x8F74D0", VA = "0x1808F86D0")]
	private void ODNEMCFKJFD(NativeMultiHashMap<int, (LEDHMIGLCGN src, LEDHMIGLCGN dst)> ACCAPEDDNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8F8240", Offset = "0x8F7040", VA = "0x1808F8240")]
	private void LGLLEHKJENH(NativeMultiHashMap<int, (LEDHMIGLCGN src, LEDHMIGLCGN dst)> ACCAPEDDNJD, int JPILKLCBOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8F7DD0", Offset = "0x8F6BD0", VA = "0x1808F7DD0")]
	private void EJALOOOKKJD(NativeMultiHashMap<int, (LEDHMIGLCGN src, LEDHMIGLCGN dst)> ACCAPEDDNJD, int JPILKLCBOKG, LKKPMGMGFIA DPFFDAKDAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8F7F60", Offset = "0x8F6D60", VA = "0x1808F7F60")]
	private NativeMultiHashMap<int, (LEDHMIGLCGN, LEDHMIGLCGN)> KDMBIDJMKEF(Allocator CMCENMLGNBG, NativeArray<LEDHMIGLCGN> KCACLEAMEOJ, out NativeArray<(LEDHMIGLCGN src, LEDHMIGLCGN dst)> NJPGMLLIJDN)
	{
		return default(NativeMultiHashMap<int, (LEDHMIGLCGN, LEDHMIGLCGN)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public BKCKABBABHB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BKADEOMONEA(typeof(TransformService))]
	[HLJOGLEHOLC(typeof(OIHJCGPPHNA), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	public class TransformService : OIHJCGPPHNA, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly EKGLDANHPKF HAACODADIAK;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly EKGLDANHPKF KCCJMJEJEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private GKCAMNIKIBB HAOGFLCGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private OJCNMNJFNCK DELEODDAJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase MBBHEEBDGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService CFFMBLMAMOD;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x991840", Offset = "0x990640", VA = "0x180991840")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private AHFPALIMFBF PDMIOCKKDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x98F900", Offset = "0x98E700", VA = "0x18098F900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x98EC60", Offset = "0x98DA60", VA = "0x18098EC60", Slot = "33")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x98F9C0", Offset = "0x98E7C0", VA = "0x18098F9C0", Slot = "34")]
		public bool EPIBFHHLLBP(Transform HAFNICDKMAH, out LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x990BE0", VA = "0x180991DE0", Slot = "35")]
		public Transform MKNIBCLKJEB(Entity DNMNICOEECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x992700", Offset = "0x991500", VA = "0x180992700", Slot = "30")]
		public bool PBBNBKDNKEE(Entity DNMNICOEECM, out Transform HAFNICDKMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x992590", Offset = "0x991390", VA = "0x180992590")]
		private void ODJBEEMOBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x990130", Offset = "0x98EF30", VA = "0x180990130", Slot = "29")]
		public void GDAOKHAHDPL(Entity DNMNICOEECM, out Matrix4x4 PDLKMNAGPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x990280", Offset = "0x98F080", VA = "0x180990280", Slot = "4")]
		public void GIIKEKNMBDG(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x991D10", Offset = "0x990B10", VA = "0x180991D10")]
		public void MIGAMDNKLCG(Entity DNMNICOEECM, Vector3 OECGCOHJOHK, Quaternion JILDBBFONDK, Vector3 DFOFCFHFJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x98F050", Offset = "0x98DE50", VA = "0x18098F050")]
		public void CLHJOENGBGD(Entity DNMNICOEECM, Vector3 OECGCOHJOHK, Quaternion JILDBBFONDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9925B0", Offset = "0x9913B0", VA = "0x1809925B0", Slot = "27")]
		public void OHFJOCAEEKP(Entity DNMNICOEECM, out Matrix4x4 LCGBCICOIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x990620", Offset = "0x98F420", VA = "0x180990620")]
		public void HCAGLDJFHNK(Entity DNMNICOEECM, in Matrix4x4 PDLKMNAGPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9920F0", Offset = "0x990EF0", VA = "0x1809920F0")]
		public void MNEBECANHOM(Entity DNMNICOEECM, in Matrix4x4 PDLKMNAGPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x98FF70", Offset = "0x98ED70", VA = "0x18098FF70")]
		public void FPENIGODLJN(Entity DNMNICOEECM, in Matrix4x4 PFDKENMJIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x98DE90", Offset = "0x98CC90", VA = "0x18098DE90", Slot = "5")]
		public void ALJGAMLLCGO(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x990510", Offset = "0x98F310", VA = "0x180990510", Slot = "6")]
		public Vector3 HBMFAMCIDAA(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x990AD0", Offset = "0x98F8D0", VA = "0x180990AD0", Slot = "7")]
		public void IBBKHHPKJKF(Entity DNMNICOEECM, Quaternion DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9911C0", Offset = "0x98FFC0", VA = "0x1809911C0", Slot = "8")]
		public Quaternion JPIOJNBLAAN(Entity DNMNICOEECM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x992300", Offset = "0x991100", VA = "0x180992300", Slot = "12")]
		public void NEEEPLNCGIM(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9910B0", Offset = "0x98FEB0", VA = "0x1809910B0", Slot = "11")]
		public Vector3 JKAAAHCDIMG(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9924F0", Offset = "0x9912F0", VA = "0x1809924F0")]
		public void OAJFOEIAJCO(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x98EFB0", Offset = "0x98DDB0", VA = "0x18098EFB0")]
		private Vector3 CJPEEPMGFNO(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x990470", Offset = "0x98F270", VA = "0x180990470", Slot = "14")]
		public float GODEFEGIENF(Entity DNMNICOEECM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x98FB80", Offset = "0x98E980", VA = "0x18098FB80", Slot = "13")]
		public void FADEOPKBMMG(Entity DNMNICOEECM, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x991A50", Offset = "0x990850", VA = "0x180991A50")]
		private float LNEOHLGDMCN(Entity DNMNICOEECM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x98F2C0", Offset = "0x98E0C0", VA = "0x18098F2C0")]
		public void DGKDNDLIBGJ(Entity DNMNICOEECM, float OFOLMILNANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x992220", Offset = "0x991020", VA = "0x180992220", Slot = "16")]
		public Vector3 NCIIMAANMGD(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x98E640", Offset = "0x98D440", VA = "0x18098E640", Slot = "15")]
		public void BFJKOMNBPEK(Entity DNMNICOEECM, Vector3 NEBNHDGDGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98EC40", VA = "0x18098FE40")]
		private Vector3 FOLDKCOAMEJ(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9913D0", Offset = "0x9901D0", VA = "0x1809913D0")]
		public void LFIHBOKLHNN(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x990BD0", Offset = "0x98F9D0", VA = "0x180990BD0")]
		[Conditional("DEBUG_BUILD")]
		private void INFDNBPAPCO(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x98F350", Offset = "0x98E150", VA = "0x18098F350", Slot = "36")]
		public void DJKDECILDIL(Entity DNMNICOEECM, Vector3 PGEIGNJBBKG, Quaternion BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x991B40", Offset = "0x990940", VA = "0x180991B40", Slot = "9")]
		public void MBBGNEFFCIB(Entity DNMNICOEECM, out Vector3 PGEIGNJBBKG, out Quaternion BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x991FC0", Offset = "0x990DC0", VA = "0x180991FC0", Slot = "10")]
		public void MMNJMEMJLDF(Entity DNMNICOEECM, out Vector3 PGEIGNJBBKG, out Quaternion BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x98F4B0", Offset = "0x98E2B0", VA = "0x18098F4B0", Slot = "37")]
		public void EFILOGGCJKP(Entity DNMNICOEECM, Vector3 PGEIGNJBBKG, Quaternion BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x991890", Offset = "0x990690", VA = "0x180991890")]
		public void LLNFJIDKNNH(Entity DNMNICOEECM, Vector3 PGEIGNJBBKG, Quaternion BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x98E410", Offset = "0x98D210", VA = "0x18098E410", Slot = "17")]
		public void BBJLCPPEKPI(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x990EF0", Offset = "0x98FCF0", VA = "0x180990EF0", Slot = "18")]
		public Vector3 JACAMCEFJKA(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x98ED70", Offset = "0x98DB70", VA = "0x18098ED70", Slot = "19")]
		public void CHEOPAEBHOD(Entity DNMNICOEECM, Quaternion DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9909E0", Offset = "0x98F7E0", VA = "0x1809909E0", Slot = "20")]
		public Quaternion HPGDNCBCPOF(Entity DNMNICOEECM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x98DFB0", Offset = "0x98CDB0", VA = "0x18098DFB0", Slot = "22")]
		public void ANLEPMPGOPG(Entity DNMNICOEECM, Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x992400", Offset = "0x991200", VA = "0x180992400", Slot = "21")]
		public Vector3 NNMHDJDBEKM(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x990D80", Offset = "0x98FB80", VA = "0x180990D80", Slot = "23")]
		public void IPNOACMECKK(Entity DNMNICOEECM, float LMKPHHFIFKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9912B0", Offset = "0x9900B0", VA = "0x1809912B0", Slot = "24")]
		public float LDGCOFMOFOL(Entity DNMNICOEECM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x98E770", Offset = "0x98D570", VA = "0x18098E770", Slot = "25")]
		public void BIAIACGBEEM(Entity DNMNICOEECM, Vector3 CKKBFNDEEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9925C0", Offset = "0x9913C0", VA = "0x1809925C0", Slot = "26")]
		public Vector3 OHJJMDCPEKN(Entity DNMNICOEECM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x98D7F0", Offset = "0x98C5F0", VA = "0x18098D7F0", Slot = "31")]
		public void AHKMKELLENB(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x98F160", Offset = "0x98DF60", VA = "0x18098F160")]
		private LEDHMIGLCGN CLKDLKNIIKA(Transform HAFNICDKMAH)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x98F6D0", Offset = "0x98E4D0", VA = "0x18098F6D0")]
		private static TransformEntity EGPLOFKNLCC(FIMAOKHBMMB LAKBKKJKBPK, GameObject OPJJDKDMJMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x991EA0", Offset = "0x990CA0", VA = "0x180991EA0", Slot = "32")]
		public void MLBEBLFILJH(Entity DNMNICOEECM, Entity JEAPMLEICDM, Entity DDNBMNPALIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x991C90", Offset = "0x990A90", VA = "0x180991C90")]
		private GBLOMBGGABH MBBGNEFFCIB(Entity DNMNICOEECM)
		{
			return default(GBLOMBGGABH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x990FD0", Offset = "0x98FDD0", VA = "0x180990FD0")]
		private bool JCCMCJMNDCD(Entity DNMNICOEECM, out Entity KICGHGEEADG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x98FC90", Offset = "0x98EA90", VA = "0x18098FC90")]
		private void FIJDCHIGJGJ(Entity DNMNICOEECM, out Matrix4x4 PDLKMNAGPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9914A0", Offset = "0x9902A0", VA = "0x1809914A0")]
		private void LGJHOKLBEEJ(Entity DNMNICOEECM, out Matrix4x4 PFDKENMJIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x98F2B0", Offset = "0x98E0B0", VA = "0x18098F2B0", Slot = "28")]
		private void COPJKDFBDGO(Entity DNMNICOEECM, in Matrix4x4 LCGBCICOIEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HLJOGLEHOLC(typeof(OKANLNHOJFA), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
internal sealed class OKANLNHOJFA : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[AGIJCBMCMGO]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA40", Offset = "0x8AE840", VA = "0x1808AFA40", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AE910", VA = "0x1808AFB10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OKANLNHOJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(NMBPIPNKHEJ), new string[] { })]
public class NMBPIPNKHEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct MOKLPHINMOH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly NMBPIPNKHEJ KICGHGEEADG;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x11B16B0", Offset = "0x11B04B0", VA = "0x1811B16B0")]
		public MOKLPHINMOH(NMBPIPNKHEJ KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x11B1690", Offset = "0x11B0490", VA = "0x1811B1690", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int OKJBAJEHMKO;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool KGMPBOBPPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB510", Offset = "0x8AA310", VA = "0x1808AB510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action MBLIFDFICBI
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB520", Offset = "0x8AA320", VA = "0x1808AB520")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB5D0", Offset = "0x8AA3D0", VA = "0x1808AB5D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA2E0", VA = "0x1808AB4E0")]
	public MOKLPHINMOH DHOMDKBMEAO()
	{
		return default(MOKLPHINMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5C0", Offset = "0x8AA3C0", VA = "0x1808AB5C0")]
	public void HHMLPPFKGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4C0", Offset = "0x8AA2C0", VA = "0x1808AB4C0")]
	public void CJNGJFGDDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NMBPIPNKHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HLJOGLEHOLC(typeof(OOONNEPHJGJ), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
public class OOONNEPHJGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int OKJBAJEHMKO;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool EEONKLFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B1700", Offset = "0x8B0500", VA = "0x1808B1700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B16F0", Offset = "0x8B04F0", VA = "0x1808B16F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OOONNEPHJGJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[HLJOGLEHOLC(typeof(EnableComponentSystemsInScope), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	public class EnableComponentSystemsInScope : KPALCLLIODG, JOFACKOFGKP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct MOCOPJFBIDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> HEJCFGLIBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> BCPNDHEOJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> GAJIMKDNMHE;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x11B1670", Offset = "0x11B0470", VA = "0x1811B1670")]
			public MOCOPJFBIDD(NativeArray<int> HEJCFGLIBDO, NativeArray<int> BCPNDHEOJLP, Dictionary<ComponentSystemBase, int> GAJIMKDNMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x11B13F0", Offset = "0x11B01F0", VA = "0x1811B13F0")]
			public void GFOBDFKLBFO(IEnumerable<ComponentSystemBase> LHNNPMPCLEE, MNIFKKPEEPE FNHNOIKKNMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class CLNPEEGEIDC : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
			[DebuggerHidden]
			public CLNPEEGEIDC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x97E430", Offset = "0x97D230", VA = "0x18097E430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x97E600", Offset = "0x97D400", VA = "0x18097E600", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x97E550", Offset = "0x97D350", VA = "0x18097E550", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x97E550", Offset = "0x97D350", VA = "0x18097E550", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const MNIFKKPEEPE MPMBJINBJEJ = MNIFKKPEEPE.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly EKGLDANHPKF LJAOPHEPIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private KEOFLKLFAOP OPNLEKFMABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> FOBHOKGKMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> LNAHDBNHMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int LLNMOPOJDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MNIFKKPEEPE MPHKIPGCOPH;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1B0", Offset = "0xA1AFB0", VA = "0x180A1C1B0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA1C520", Offset = "0xA1B320", VA = "0x180A1C520", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA1D240", Offset = "0xA1C040", VA = "0x180A1D240")]
		[IteratorStateMachine(typeof(CLNPEEGEIDC))]
		private IEnumerable<ComponentSystemBase> OOGGBKNDDFM(int CPMHNPIOINN, int DAFMFEFJEFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C380", Offset = "0xA1B180", VA = "0x180A1C380", Slot = "5")]
		public void OEAHENINFEJ(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1C380", Offset = "0xA1B180", VA = "0x180A1C380")]
		private void CHICMKPJIFN(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xA1C280", Offset = "0xA1B080", VA = "0x180A1C280")]
		public void CHICMKPJIFN(MNIFKKPEEPE PBMOKHNJPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA20", Offset = "0xA1B820", VA = "0x180A1CA20")]
		private void NOFKFHNKBGL(MNIFKKPEEPE PBMOKHNJPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA1C910", Offset = "0xA1B710", VA = "0x180A1C910")]
		private void MOLFCECGLMP(MNIFKKPEEPE PBMOKHNJPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9A0", Offset = "0xA1B7A0", VA = "0x180A1C9A0")]
		private void MOPDHEMKDOC(MNIFKKPEEPE PBMOKHNJPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA1C400", Offset = "0xA1B200", VA = "0x180A1C400")]
		private void CKBCFFOFKJC(int CPMHNPIOINN, int DAFMFEFJEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA1C850", Offset = "0xA1B650", VA = "0x180A1C850")]
		private void MFIAHAGDMBM(int CPMHNPIOINN, int DAFMFEFJEFF, bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA00", Offset = "0xA1B800", VA = "0x180A1CA00")]
		private int NNHLJFMBHNL(MNIFKKPEEPE PBMOKHNJPEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCB0", Offset = "0xA1BAB0", VA = "0x180A1CCB0")]
		private bool OMFCJAMINCE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C720", Offset = "0xA1B520", VA = "0x180A1C720")]
		private Dictionary<ComponentSystemBase, int> JAGJKJONMHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C810", Offset = "0xA1B610", VA = "0x180A1C810")]
		private void KDCMBNPIAOH(NativeArray<int> HEJCFGLIBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C610", Offset = "0xA1B410", VA = "0x180A1C610")]
		private void FKJMKMFHFNB(NativeArray<int> BCPNDHEOJLP, NativeArray<int> HEJCFGLIBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5B0", Offset = "0xA1B3B0", VA = "0x180A1C5B0")]
		private static MNIFKKPEEPE FFJHHBJHMIE(Type LAKBKKJKBPK, MNIFKKPEEPE HCMHCJOGKFN)
		{
			return default(MNIFKKPEEPE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA1D360", Offset = "0xA1C160", VA = "0x180A1D360")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4C0", Offset = "0xA1B2C0", VA = "0x180A1C4C0")]
		[CompilerGenerated]
		private void CKONFNPBPHE(KPALCLLIODG GCJKFCJAILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B4C0", VA = "0x180A1C6C0")]
		[CompilerGenerated]
		private void GJOHNPEPKJD(DOKJEHLBPKM GCJKFCJAILD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[KNPMBINOPIG(MLNJOBCAIAM.WorldService)]
	[HLJOGLEHOLC(typeof(DDLBEFNOPIH), new string[] { })]
	public class TickService : KPALCLLIODG, DDLBEFNOPIH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker LILOLELNAHE;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker NMMFJLBJGPC;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker EIEEAJFECKH;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker OICFOKBHAEE;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker IKOLIHLJJIP;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker HKCOLGFEKHJ;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker FLJPJCEHGBK;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker NPOIPPMEPPP;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker OHNJAHLNFGM;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker INPJIFLLAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[AGIJCBMCMGO]
		private AKKBHFINLKC GABFGDHMPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[AGIJCBMCMGO]
		private CNJANGGLMNJ MCEAMOLJBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[AGIJCBMCMGO]
		private TransformOwnershipPhase BOKGOPOBBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[AGIJCBMCMGO]
		private TimeService DNJNINLCKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PLMMGPNIKJM DJCIICEJFGH;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool FDPGHNPDEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x98B9D0", Offset = "0x98A7D0", VA = "0x18098B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool KNPALPNCGIO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98B7A0", VA = "0x18098C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool BJFDEJAEBGO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x98B9D0", Offset = "0x98A7D0", VA = "0x18098B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool GOKBJNPBOBG
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x98B9D0", Offset = "0x98A7D0", VA = "0x18098B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x98BA40", Offset = "0x98A840", VA = "0x18098BA40", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x98C7B0", Offset = "0x98B5B0", VA = "0x18098C7B0", Slot = "14")]
		public void LJKPELPFOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x98C690", Offset = "0x98B490", VA = "0x18098C690", Slot = "15")]
		public void KNKBNOLABMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x98C8D0", Offset = "0x98B6D0", VA = "0x18098C8D0", Slot = "5")]
		public void MKFDELOHIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x98BBB0", Offset = "0x98A9B0", VA = "0x18098BBB0", Slot = "6")]
		public void CGBFDHAFNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x98BD30", Offset = "0x98AB30", VA = "0x18098BD30", Slot = "7")]
		public void DLOEAJEFHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x98C3C0", Offset = "0x98B1C0", VA = "0x18098C3C0", Slot = "8")]
		public void FIJHKOLNNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x98CA40", Offset = "0x98B840", VA = "0x18098CA40", Slot = "9")]
		public void PMOJNLJAGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x98BEB0", Offset = "0x98ACB0", VA = "0x18098BEB0", Slot = "10")]
		public void ECJCJJMKAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x98C2F0", Offset = "0x98B0F0", VA = "0x18098C2F0", Slot = "11")]
		public void FFBDAECCKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
		public void AONCMKKGODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x98C540", Offset = "0x98B340", VA = "0x18098C540", Slot = "12")]
		public void JHFNHHOBPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[KNPMBINOPIG(MLNJOBCAIAM.WorldService)]
	[HLJOGLEHOLC(typeof(NMDJLEODPOP), new string[] { })]
	public class WorldService : NMDJLEODPOP, IDisposable, CCIFGMMGDFO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PLMMGPNIKJM DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public PLMMGPNIKJM CPBIHJAENHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public AHFPALIMFBF PDMIOCKKDOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8FC970", Offset = "0x8FB770", VA = "0x1808FC970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x99AD70", Offset = "0x999B70", VA = "0x18099AD70", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool MCKHJMONIDM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x84C980", Offset = "0x84B780", VA = "0x18084C980", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x99AC40", Offset = "0x999A40", VA = "0x18099AC40", Slot = "10")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x99A900", Offset = "0x999700", VA = "0x18099A900")]
		private void DIMOBFAICBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x99AA10", Offset = "0x999810", VA = "0x18099AA10", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x99AD50", Offset = "0x999B50", VA = "0x18099AD50", Slot = "8")]
		public ComponentSystemBase IGJBJDPNBIP(Type LAKBKKJKBPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HLJOGLEHOLC(typeof(LAMLAPALOBA), new string[] { })]
public sealed class NFEDBJAEEJN : LAMLAPALOBA, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PHCNBMABONG : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x11B44C0", Offset = "0x11B32C0", VA = "0x1811B44C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x97F080", Offset = "0x97DE80", VA = "0x18097F080")]
		[DebuggerHidden]
		public PHCNBMABONG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x11B41B0", Offset = "0x11B2FB0", VA = "0x1811B41B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x11B4480", Offset = "0x11B3280", VA = "0x1811B4480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x11B43E0", Offset = "0x11B31E0", VA = "0x1811B43E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x11B43E0", Offset = "0x11B31E0", VA = "0x1811B43E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[AGIJCBMCMGO]
	private EJBFOOGDBBL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly KEOEEIKLOKB BEFOJALFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, CKKGOFMNGGN> IALLAMALHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, OAHAFKHKFID> EAPLHPDBGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<ABFMHNDOCPA> MIPKJMJLGAI;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OAHAFKHKFID AMMAKNCCHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8AADD0", Offset = "0x8A9BD0", VA = "0x1808AADD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<ABFMHNDOCPA> LFJLGLMEJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8AA620", Offset = "0x8A9420", VA = "0x1808AA620", Slot = "8")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AB060", Offset = "0x8A9E60", VA = "0x1808AB060", Slot = "9")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8AAD40", Offset = "0x8A9B40", VA = "0x1808AAD40", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AB220", Offset = "0x8AA020", VA = "0x1808AB220", Slot = "6")]
	public bool MDBIAPNEHBB(ABFMHNDOCPA JHGILNGJHFB, out OAHAFKHKFID ALGIJJJDBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA710", Offset = "0x8A9510", VA = "0x1808AA710")]
	private void CCDFJCBJECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AB080", Offset = "0x8A9E80", VA = "0x1808AB080")]
	private void LMLDHKPEKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8A9AE0", VA = "0x1808AACE0")]
	private CKKGOFMNGGN DPEIGCBGGPI(string JGIDPGOFOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x8AADD0", Offset = "0x8A9BD0", VA = "0x1808AADD0")]
	private CKKGOFMNGGN FDEJAHMMHLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA3B0", Offset = "0x8A91B0", VA = "0x1808AA3B0")]
	private CKKGOFMNGGN AMACNJBEJBM(string JGIDPGOFOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AABD0", Offset = "0x8A99D0", VA = "0x1808AABD0")]
	private CKKGOFMNGGN DILBBOJNJBI(string PAEKKCIOLNB, string DPODOOAHECI, [Optional] CKKGOFMNGGN JECBPALNCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFF0", Offset = "0x8A9DF0", VA = "0x1808AAFF0")]
	[IteratorStateMachine(typeof(PHCNBMABONG))]
	private IEnumerable<(string, string)> JONAPEAPMLM(string JGIDPGOFOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8AAE30", Offset = "0x8A9C30", VA = "0x1808AAE30")]
	private bool HKODJJEHEMK(ABFMHNDOCPA JHGILNGJHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x8AAF10", Offset = "0x8A9D10", VA = "0x1808AAF10")]
	private KEOEEIKLOKB IINDAHKGEJM(ABFMHNDOCPA JHGILNGJHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x8AAB80", Offset = "0x8A9980", VA = "0x1808AAB80")]
	private KEOEEIKLOKB CEJNCMELJLN(ABFMHNDOCPA JHGILNGJHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA680", Offset = "0x8A9480", VA = "0x1808AA680")]
	private KEOEEIKLOKB CAMANIPNMNA(ABFMHNDOCPA JHGILNGJHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2970", Offset = "0x3EC1770", VA = "0x183EC2970")]
	private T ABFAHJIFDHL<T>(ABFMHNDOCPA JHGILNGJHFB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8AAAA0", Offset = "0x8A98A0", VA = "0x1808AAAA0")]
	private FieldInfo CCLHFAFGDFA(ABFMHNDOCPA JHGILNGJHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AB2B0", Offset = "0x8AA0B0", VA = "0x1808AB2B0")]
	public NFEDBJAEEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AAE80", Offset = "0x8A9C80", VA = "0x1808AAE80")]
	[CompilerGenerated]
	private int ICHHNGNIDCO(ABFMHNDOCPA EFBCPNIKEHB, ABFMHNDOCPA BFLEMGIJKLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class CKKGOFMNGGN : OAHAFKHKFID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string JMHPNOOJPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly CKKGOFMNGGN JECBPALNCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<CKKGOFMNGGN> FONEELNIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<ABFMHNDOCPA> DPFFDAKDAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string DIEOCGMMBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OAHAFKHKFID JIOHJKKDDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<OAHAFKHKFID> CFCCINEFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<ABFMHNDOCPA> ACKMLANOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4F0", Offset = "0x8FB2F0", VA = "0x1808FC4F0")]
	public CKKGOFMNGGN(string CCEKFDNIAPD, CKKGOFMNGGN KICGHGEEADG)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[KNPMBINOPIG(MLNJOBCAIAM.History)]
	[HLJOGLEHOLC(typeof(OHLEPJKHPFA), new string[] { })]
	[BKADEOMONEA(typeof(HistoryService))]
	public class HistoryService : KPALCLLIODG, IDisposable, OHLEPJKHPFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum JDFHDHPMMMI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct IJNLOJEJJDG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly JDFHDHPMMMI ECIKFFIEJCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService ILCANNFLEKH;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x11AE580", Offset = "0x11AD380", VA = "0x1811AE580")]
			public IJNLOJEJJDG(HistoryService ILCANNFLEKH, bool ECFKCMOLBCH, uint LLNMOPOJDNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x11AE550", Offset = "0x11AD350", VA = "0x1811AE550", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class JFGMMNPLFGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct PAADLIJBPHP : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly JFGMMNPLFGF AACLNJEGPKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool PNKAJMDHOKA;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x11B24A0", Offset = "0x11B12A0", VA = "0x1811B24A0")]
				public PAADLIJBPHP(JFGMMNPLFGF AACLNJEGPKC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x11AB940", Offset = "0x11AA740", VA = "0x1811AB940", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct DIOAKINJLCN : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly JFGMMNPLFGF AACLNJEGPKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool PNKAJMDHOKA;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x11AB970", Offset = "0x11AA770", VA = "0x1811AB970")]
				public DIOAKINJLCN(JFGMMNPLFGF AACLNJEGPKC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x11AB940", Offset = "0x11AA740", VA = "0x1811AB940", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService KMJKOFEFKDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool CHPPJCGLGAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int IPNIDFBHPNL;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x11AE8C0", Offset = "0x11AD6C0", VA = "0x1811AE8C0")]
			public JFGMMNPLFGF(HistoryService KMJKOFEFKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x11AE840", Offset = "0x11AD640", VA = "0x1811AE840")]
			public bool FELNEMGIDBJ(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x11AE7F0", Offset = "0x11AD5F0", VA = "0x1811AE7F0")]
			public DIOAKINJLCN BMHNBLDDDGH()
			{
				return default(DIOAKINJLCN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x11AE870", Offset = "0x11AD670", VA = "0x1811AE870")]
			public PAADLIJBPHP OIFKCBOOPBM()
			{
				return default(PAADLIJBPHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class DLGLNLOOEHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public DLGLNLOOEHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x11AB9B0", Offset = "0x11AA7B0", VA = "0x1811AB9B0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class NNLDIFEEMOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public NNLDIFEEMOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x11B2360", Offset = "0x11B1160", VA = "0x1811B2360")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class GFFDHNPPBEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public GFFDHNPPBEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x11ADC70", Offset = "0x11ACA70", VA = "0x1811ADC70")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction BDADONFDCNK;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction LNMBNIOMKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private APICLBAFCOB JLONLEGNOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer LNOKHPPPCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer DJLLPLNLHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private PPGCMHGINPA KECAOHFFGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase BOKGOPOBBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService MHPMBEPIJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private NANPEJGFFMP DKAAAJJFJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private JDFHDHPMMMI ILJHABCLBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private JFGMMNPLFGF AACLNJEGPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private MGBEEKHCHKI JDKCPIMOLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private GNIJOOFEPBL EHJHPJFNBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private INOPGIMBOKC OMDDDKNLHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete BDBBGHFILPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint EMNEKAMJBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint PEHAKLDIBFF;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private JFGMMNPLFGF NMCEEEPJEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CA0", Offset = "0x6C4AA0", VA = "0x1806C5CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool KOFHJMNEFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0xA2C810", Offset = "0xA2B610", VA = "0x180A2C810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool BDDDPKJDFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xA2CFA0", Offset = "0xA2BDA0", VA = "0x180A2CFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool IDKDNMLONCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xA2CDD0", Offset = "0xA2BBD0", VA = "0x180A2CDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int LGHMOKLDHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA2CF00", Offset = "0xA2BD00", VA = "0x180A2CF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int AJAGKFMFLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xA2BCF0", Offset = "0xA2AAF0", VA = "0x180A2BCF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool CBEDDJIHLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xA2C6A0", Offset = "0xA2B4A0", VA = "0x180A2C6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool AOENKFKBEFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xA2B2E0", Offset = "0xA2A0E0", VA = "0x180A2B2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool AAIENALKFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA2C760", Offset = "0xA2B560", VA = "0x180A2C760", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA2C6B0", Offset = "0xA2B4B0", VA = "0x180A2C6B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer DNCNCABOAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xA2D100", Offset = "0xA2BF00", VA = "0x180A2D100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action NPCOIAFMEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D110", Offset = "0xA2BF10", VA = "0x180A2D110", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xA2C6C0", Offset = "0xA2B4C0", VA = "0x180A2C6C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action FONCCEIKLIH
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B050", Offset = "0xA29E50", VA = "0x180A2B050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xA2C770", Offset = "0xA2B570", VA = "0x180A2C770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA2B2F0", Offset = "0xA2A0F0", VA = "0x180A2B2F0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA2BA50", Offset = "0xA2A850", VA = "0x180A2BA50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7A0", Offset = "0xA2A5A0", VA = "0x180A2B7A0")]
		private void BLPALNJIPNH(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA2C3E0", Offset = "0xA2B1E0", VA = "0x180A2C3E0")]
		private void GPNBKIBAPKK(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE BKAFFHIFHPM, LDOGLLBKONE IOMHKOCLPDA, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA2C400", Offset = "0xA2B200", VA = "0x180A2C400")]
		private void HAKMLLPIMBA(IJJNJPIJDOH BHMKDBDFPKN, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA2D040", Offset = "0xA2BE40", VA = "0x180A2D040", Slot = "14")]
		public IDisposable NJCJCCFOAGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA2D0A0", Offset = "0xA2BEA0", VA = "0x180A2D0A0", Slot = "9")]
		public IDisposable NLHMCCHGDPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA2BE50", Offset = "0xA2AC50", VA = "0x180A2BE50", Slot = "6")]
		public UndoAction EICKMOKHEKA()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA2C1D0", Offset = "0xA2AFD0", VA = "0x180A2C1D0", Slot = "15")]
		public RedoAction FLIEIJALDOK()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA2CBD0", Offset = "0xA2B9D0", VA = "0x180A2CBD0", Slot = "16")]
		public UndoAction LDOALAMNFKC()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA2C290", Offset = "0xA2B090", VA = "0x180A2C290", Slot = "7")]
		public RedoAction FLIEIJALDOK(UndoAction KMOIJDECCNO)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA2CC90", Offset = "0xA2BA90", VA = "0x180A2CC90", Slot = "8")]
		public UndoAction LDOALAMNFKC(RedoAction KMOIJDECCNO)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA2B240", Offset = "0xA2A040", VA = "0x180A2B240")]
		public bool BDPCIFPKPJB(BEIDPKHJMEO NGMBEOINPCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA2CB80", Offset = "0xA2B980", VA = "0x180A2CB80", Slot = "17")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5E0", Offset = "0xA2B3E0", VA = "0x180A2C5E0")]
		public void HANFBOOMCII(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD10", Offset = "0xA2AB10", VA = "0x180A2BD10")]
		public void ECPOOLKGHLI(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, in LDOGLLBKONE IOMHKOCLPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B9A0", Offset = "0xA2A7A0", VA = "0x180A2B9A0")]
		public void DJPALPFNMAG(IJJNJPIJDOH BHMKDBDFPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA2C870", Offset = "0xA2B670", VA = "0x180A2C870")]
		private void JLDOMOCNCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B960", Offset = "0xA2A760", VA = "0x180A2B960")]
		private void CPAKGJHNMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D1D0", Offset = "0xA2BFD0", VA = "0x180A2D1D0")]
		private void OGCJNODFBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA2CE00", Offset = "0xA2BC00", VA = "0x180A2CE00")]
		private ADCFADFAFOA MOBNNFNBKAD()
		{
			return default(ADCFADFAFOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA2B940", Offset = "0xA2A740", VA = "0x180A2B940")]
		private uint CKNLLGENNPE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA2CDB0", Offset = "0xA2BBB0", VA = "0x180A2CDB0")]
		private bool LNCMKLHLKFD(out ADCFADFAFOA CIAILAMJPDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA2D1B0", Offset = "0xA2BFB0", VA = "0x180A2D1B0")]
		private bool OFNOILHOLLC(out ADCFADFAFOA CIAILAMJPDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA2B280", Offset = "0xA2A080", VA = "0x180A2B280")]
		private RedoAction BGKLKFOCMOL(ADCFADFAFOA CIAILAMJPDB)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDF0", Offset = "0xA2ABF0", VA = "0x180A2BDF0")]
		private UndoAction EEPKIPLFNKO(ADCFADFAFOA CIAILAMJPDB)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AD10", VA = "0x180A2BF10")]
		private ADCFADFAFOA FHHNCOOEGJJ(ADCFADFAFOA CIAILAMJPDB, ActionBuffer GKPMHIJMNMG, bool ECFKCMOLBCH)
		{
			return default(ADCFADFAFOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA2B860", Offset = "0xA2A660", VA = "0x180A2B860")]
		private void CEBJLOLPKBJ(Action CIAILAMJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3B4DF00", Offset = "0x3B4CD00", VA = "0x183B4DF00")]
		private T CEBJLOLPKBJ<T>(Func<T> LHLDMHIEOEA)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA2C3B0", Offset = "0xA2B1B0", VA = "0x180A2C3B0")]
		private IJNLOJEJJDG GHADDICGBOJ(bool ECFKCMOLBCH, uint LLNMOPOJDNH)
		{
			return default(IJNLOJEJJDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D2D0", Offset = "0xA2C0D0", VA = "0x180A2D2D0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0F0", Offset = "0xA29EF0", VA = "0x180A2B0F0")]
		[CompilerGenerated]
		private UndoAction AKANOGLLNLG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA2CA10", Offset = "0xA2B810", VA = "0x180A2CA10")]
		[CompilerGenerated]
		private RedoAction KIMFIEPDICF()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA2C8B0", Offset = "0xA2B6B0", VA = "0x180A2C8B0")]
		[CompilerGenerated]
		private UndoAction KGIMGEOBJFB()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PNKLNOOMHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> HDCHHDPICKJ;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public PNKLNOOMHHK(NativeArray<byte> HDCHHDPICKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8BFFC0", Offset = "0x8BEDC0", VA = "0x1808BFFC0")]
	public static PNKLNOOMHHK LJJFBFNEMCH(NativeArray<byte> HDCHHDPICKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T LIJGPBIDLCM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> GMPPLKCMOGG<T>(int EOKNLPLGCDF, Allocator CMCENMLGNBG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> IKLFFMFDMBI<T>(Allocator CMCENMLGNBG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GCHEHJNJOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> HDCHHDPICKJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public GCHEHJNJOIB(NativeArray<byte> HDCHHDPICKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xA22710", Offset = "0xA21510", VA = "0x180A22710")]
	public static GCHEHJNJOIB LJJFBFNEMCH(NativeArray<byte> HDCHHDPICKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3A85FC0", Offset = "0x3A84DC0", VA = "0x183A85FC0")]
	public T LIJGPBIDLCM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> GMPPLKCMOGG<T>(int EOKNLPLGCDF, Allocator CMCENMLGNBG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JFPPGOINKFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> HDCHHDPICKJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public JFPPGOINKFM(NativeArray<byte> HDCHHDPICKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xA316A0", Offset = "0xA304A0", VA = "0x180A316A0")]
	public static JFPPGOINKFM LJJFBFNEMCH(NativeArray<byte> HDCHHDPICKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x321A6A0", Offset = "0x32194A0", VA = "0x18321A6A0")]
	public void MAMGNGMFNLJ<T>(in T DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x321A5A0", Offset = "0x32193A0", VA = "0x18321A5A0")]
	public void BGAGJMKDDNG<T>(NativeArray<T> IDEEEMMOHPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void NBMANPOHKNH<T>(NativeArray<T> DPJGMDFEIDL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DDFDAJNHIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x90B480", Offset = "0x90A280", VA = "0x18090B480")]
	public static Span<byte> GIHODIDPLIC(this NativeArray<byte> HDCHHDPICKJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x90B300", Offset = "0x90A100", VA = "0x18090B300")]
	public static ReadOnlySpan<byte> BNKPFIDKFFB(this NativeArray<byte> HDCHHDPICKJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x90B510", Offset = "0x90A310", VA = "0x18090B510")]
	public static NativeArray<byte> GIKKBNIGIND(this NativeArray<byte> HDCHHDPICKJ, int CPMHNPIOINN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x90B610", Offset = "0x90A410", VA = "0x18090B610")]
	public static NativeArray<byte> LHOAFCLJMBM(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E7B0", Offset = "0x3C2D5B0", VA = "0x183C2E7B0")]
	public static NativeArray<byte> LHOAFCLJMBM<T>(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x90B290", Offset = "0x90A090", VA = "0x18090B290")]
	public static NativeArray<byte> AIDLAPJFIEC(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D210", Offset = "0x3C2C010", VA = "0x183C2D210")]
	public static NativeArray<byte> AIDLAPJFIEC<T>(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x90B590", Offset = "0x90A390", VA = "0x18090B590")]
	public static NativeArray<byte> IOFEKGBBNOP(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3C2D270", Offset = "0x3C2C070", VA = "0x183C2D270")]
	public static NativeArray<byte> IOFEKGBBNOP<T>(this NativeArray<byte> HDCHHDPICKJ, int KNPCAAMBLKA = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NBPLKDEODHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
	public NBPLKDEODHI(NativeList<byte> GHOABBJLFEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9770", Offset = "0x8A8570", VA = "0x1808A9770")]
	public static NBPLKDEODHI LJJFBFNEMCH(NativeList<byte> HDCHHDPICKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void MAMGNGMFNLJ<T>(in T DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void BGAGJMKDDNG<T>(NativeArray<T> DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void NBMANPOHKNH<T>(NativeArray<T> DPJGMDFEIDL) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.PropertyChanges)]
	public class PropertyChangeNetworkRouter : CCIFGMMGDFO, KPALCLLIODG, AEKODNEMCEK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[AGIJCBMCMGO]
		private MBIKMDBBBBB LKPFOEGOGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[AGIJCBMCMGO]
		private LLLCOEENCOL DPFFDAKDAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[AGIJCBMCMGO]
		private NMBPIPNKHEJ AENGNPFLNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[AGIJCBMCMGO]
		private PropertyChangeRouterService MHPMBEPIJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private APICLBAFCOB HDIELKAGPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private GGFDBJACKCK EMMPBMHAKKB;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public APICLBAFCOB EHENGPHNIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F00", Offset = "0x8C4D00", VA = "0x1808C5F00")]
		public APICLBAFCOB.JLCOCDMCIIB DHOMDKBMEAO()
		{
			return default(APICLBAFCOB.JLCOCDMCIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8C62B0", Offset = "0x8C50B0", VA = "0x1808C62B0", Slot = "4")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C40", Offset = "0x8C4A40", VA = "0x1808C5C40", Slot = "5")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F20", Offset = "0x8C4D20", VA = "0x1808C5F20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8C6140", Offset = "0x8C4F40", VA = "0x1808C6140")]
		public void EICKMOKHEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8C68D0", Offset = "0x8C56D0", VA = "0x1808C68D0")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8C6250", Offset = "0x8C5050", VA = "0x1808C6250")]
		private void EPEGGFKFKJO(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8C68F0", Offset = "0x8C56F0", VA = "0x1808C68F0")]
		private void LOOHDGGOLII(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE BKAFFHIFHPM, LDOGLLBKONE IOMHKOCLPDA, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8C6280", Offset = "0x8C5080", VA = "0x1808C6280")]
		private void FDNLILPGHIB(IJJNJPIJDOH BHMKDBDFPKN, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8C6330", Offset = "0x8C5130", VA = "0x1808C6330")]
		private void IEJMLEPLKCB(GGFDBJACKCK PHBCKPEIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8C6780", Offset = "0x8C5580", VA = "0x1808C6780")]
		private void JNKKNJCBCIF(GGFDBJACKCK PHBCKPEIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6930", Offset = "0x8C5730", VA = "0x1808C6930")]
		private void MHLJNADILKO(GGFDBJACKCK PHBCKPEIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6310", Offset = "0x8C5110", VA = "0x1808C6310")]
		private void HHMLPPFKGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EC0", Offset = "0x8C4CC0", VA = "0x1808C5EC0")]
		private void CJNGJFGDDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6690", Offset = "0x8C5490", VA = "0x1808C6690")]
		private void JFLOJJNAIGI(GGFDBJACKCK PHBCKPEIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4551D30", Offset = "0x4550B30", VA = "0x184551D30", Slot = "6")]
		private void AFHJOJOGOJO<TKey, T>(global::CHKLHNJIEBJ<TKey, T> JHGILNGJHFB, object IEGGGFEMEIG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[KNPMBINOPIG(MLNJOBCAIAM.History)]
	[HLJOGLEHOLC(typeof(PropertyChangeRouterService), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void KALLFKPIGNK(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH, bool GNFONLPKJON);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void GMCJNJBEGKH(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE BKAFFHIFHPM, LDOGLLBKONE IOMHKOCLPDA, bool GNFONLPKJON);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void AOHFJFNDHEO(IJJNJPIJDOH BHMKDBDFPKN, bool GNFONLPKJON);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public KALLFKPIGNK DIMOBFAICBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public GMCJNJBEGKH ECBDKLMGEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AOHFJFNDHEO DMKMELLNHHE;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AD0", Offset = "0x8C58D0", VA = "0x1808C6AD0")]
		public void HANFBOOMCII(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A60", Offset = "0x8C5860", VA = "0x1808C6A60")]
		public void ECPOOLKGHLI(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, in LDOGLLBKONE BKAFFHIFHPM, in LDOGLLBKONE IOMHKOCLPDA, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A40", Offset = "0x8C5840", VA = "0x1808C6A40")]
		public void DJPALPFNMAG(IJJNJPIJDOH BHMKDBDFPKN, bool GNFONLPKJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(CNECAMIKPJE))]
	[KNPMBINOPIG(MLNJOBCAIAM.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class CNECAMIKPJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer NGFFBKNAABM;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int EKAGFOMELON
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x97E730", Offset = "0x97D530", VA = "0x18097E730")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public EKPKIMEDKLC[] EAPGMINLAKN
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x97E780", Offset = "0x97D580", VA = "0x18097E780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
			public CNECAMIKPJE(ActionBuffer NIKCGANGFIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x97E640", Offset = "0x97D440", VA = "0x18097E640")]
			[CompilerGenerated]
			private EKPKIMEDKLC ACALCGJFKJO(ADCFADFAFOA CIAILAMJPDB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class EKPKIMEDKLC : AEKODNEMCEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer NGFFBKNAABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly ADCFADFAFOA CIAILAMJPDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(GGFDBJACKCK, string, object)> PHBHDKPPOAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private GCHEHJNJOIB DFCMBLHIHLK;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int EKAGFOMELON
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x97FBC0", Offset = "0x97E9C0", VA = "0x18097FBC0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(GGFDBJACKCK, string, object)> GIICOEAMJAH
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x97FF50", Offset = "0x97ED50", VA = "0x18097FF50")]
			public EKPKIMEDKLC(ActionBuffer NIKCGANGFIN, ADCFADFAFOA CIAILAMJPDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x97FAC0", Offset = "0x97E8C0", VA = "0x18097FAC0")]
			private string AONPELGKKEK(GGFDBJACKCK EMMPBMHAKKB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x97FC10", Offset = "0x97EA10", VA = "0x18097FC10")]
			private void NEOFEBEOAIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4C13410", Offset = "0x4C12210", VA = "0x184C13410", Slot = "4")]
			public void ACKGONCECJP<TKey, T>(global::CHKLHNJIEBJ<TKey, T> JHGILNGJHFB, [Optional] object IEGGGFEMEIG) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> POLNENKGJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<ADCFADFAFOA> LMPFMKGEMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly CJKIGKDNCIP GCKGFMJHHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly MGBEEKHCHKI JDKCPIMOLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly LLLCOEENCOL DPFFDAKDAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool JGPLPEFDJNB;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public COCJKEEAFIC NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8F5D90", Offset = "0x8F4B90", VA = "0x1808F5D90")]
			get
			{
				return default(COCJKEEAFIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int EKAGFOMELON
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8F5580", Offset = "0x8F4380", VA = "0x1808F5580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8F60E0", Offset = "0x8F4EE0", VA = "0x1808F60E0")]
		public ActionBuffer(MGBEEKHCHKI JDKCPIMOLEC, LLLCOEENCOL DPFFDAKDAHJ, bool JGPLPEFDJNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F40", Offset = "0x8F4D40", VA = "0x1808F5F40")]
		public bool OPIKBANMPAL(out ADCFADFAFOA CIAILAMJPDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8F5AD0", Offset = "0x8F48D0", VA = "0x1808F5AD0")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8F5820", Offset = "0x8F4620", VA = "0x1808F5820")]
		public ADCFADFAFOA EICKMOKHEKA(DCJJOKEDCAG PHBHDKPPOAA, NANPEJGFFMP DKAAAJJFJPB, uint KEBIIGCHJFL)
		{
			return default(ADCFADFAFOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8F5F10", Offset = "0x8F4D10", VA = "0x1808F5F10")]
		public bool ONOIEHEHCFA(uint KEBIIGCHJFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x8F55C0", Offset = "0x8F43C0", VA = "0x1808F55C0")]
		public bool CPKHJNKGBJK(uint KEBIIGCHJFL, out ADCFADFAFOA KMOIJDECCNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8F5410", Offset = "0x8F4210", VA = "0x1808F5410")]
		public void BFDEFIGCILA(ADCFADFAFOA KMOIJDECCNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8F5DD0", Offset = "0x8F4BD0", VA = "0x1808F5DD0")]
		[Conditional("DEBUG_BUILD")]
		private void OJAMKEHFAAN(ADCFADFAFOA KMOIJDECCNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8F5960", Offset = "0x8F4760", VA = "0x1808F5960")]
		private void FHHNCOOEGJJ(ADCFADFAFOA HMLJHJMMFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x8F5B40", Offset = "0x8F4940", VA = "0x1808F5B40")]
		private void OANOMPEGDKP(GCHEHJNJOIB BFHFIJBBMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A70", Offset = "0x8F4870", VA = "0x1808F5A70")]
		private void GIGIEGFKMDG(ADCFADFAFOA CIAILAMJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FD0", Offset = "0x8F4DD0", VA = "0x1808F5FD0")]
		private GCHEHJNJOIB PGDCAJLKBDA(ADCFADFAFOA CIAILAMJPDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F57B0", Offset = "0x8F45B0", VA = "0x1808F57B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CJKIGKDNCIP : AEKODNEMCEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MGBEEKHCHKI JDKCPIMOLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly LLLCOEENCOL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private IJJNJPIJDOH BHMKDBDFPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private GCHEHJNJOIB KMFBDBPLNLG;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8FC090", Offset = "0x8FAE90", VA = "0x1808FC090")]
	public CJKIGKDNCIP(MGBEEKHCHKI JDKCPIMOLEC, LLLCOEENCOL DPFFDAKDAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x33382D0", Offset = "0x33370D0", VA = "0x1833382D0", Slot = "4")]
	public void ACKGONCECJP<TKey, T>(global::CHKLHNJIEBJ<TKey, T> IFKCLNGLPHO, [Optional] object IEGGGFEMEIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF00", Offset = "0x8FAD00", VA = "0x1808FBF00")]
	public void JIGGKPCGAGJ(GGFDBJACKCK EMMPBMHAKKB, ref GCHEHJNJOIB BFHFIJBBMPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class APICLBAFCOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct JLCOCDMCIIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly APICLBAFCOB KICGHGEEADG;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x980CC0", Offset = "0x97FAC0", VA = "0x180980CC0")]
		public JLCOCDMCIIB(APICLBAFCOB KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x980CA0", Offset = "0x97FAA0", VA = "0x180980CA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected DCJJOKEDCAG PHBHDKPPOAA;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DCJJOKEDCAG GIICOEAMJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F52D0", Offset = "0x8F40D0", VA = "0x1808F52D0")]
		get
		{
			return default(DCJJOKEDCAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DCCHNNPIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F5310", Offset = "0x8F4110", VA = "0x1808F5310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8F5320", Offset = "0x8F4120", VA = "0x1808F5320")]
	public APICLBAFCOB(DCJJOKEDCAG.FOIPKFABLDK GENNIEOCFED = DCJJOKEDCAG.FOIPKFABLDK.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8F52C0", Offset = "0x8F40C0", VA = "0x1808F52C0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8F50D0", Offset = "0x8F3ED0", VA = "0x1808F50D0")]
	public void HANFBOOMCII(IJJNJPIJDOH BHMKDBDFPKN, JPLAKIBMLBH BJDLJGFHCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8F5040", Offset = "0x8F3E40", VA = "0x1808F5040")]
	public void ECPOOLKGHLI(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x8F4F50", Offset = "0x8F3D50", VA = "0x1808F4F50")]
	public void DJPALPFNMAG(IJJNJPIJDOH BHMKDBDFPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x8F51C0", Offset = "0x8F3FC0", VA = "0x1808F51C0")]
	public void HHMLPPFKGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8F4E20", Offset = "0x8F3C20", VA = "0x1808F4E20")]
	public void CJNGJFGDDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8F5030", Offset = "0x8F3E30", VA = "0x1808F5030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8F4F20", Offset = "0x8F3D20", VA = "0x1808F4F20")]
	public JLCOCDMCIIB DHOMDKBMEAO()
	{
		return default(JLCOCDMCIIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GGFDBJACKCK : IComparable<GGFDBJACKCK>, IEquatable<GGFDBJACKCK>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly GGFDBJACKCK LMFLNMNCHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public IJJNJPIJDOH BHMKDBDFPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public INOPGIMBOKC JFGKEENDEHE;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA22C50", Offset = "0xA21A50", VA = "0x180A22C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
	public GGFDBJACKCK(IJJNJPIJDOH BHMKDBDFPKN, INOPGIMBOKC JFGKEENDEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xA22C40", Offset = "0xA21A40", VA = "0x180A22C40")]
	public void JOBLPEANAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xA22A90", Offset = "0xA21890", VA = "0x180A22A90", Slot = "4")]
	public int CompareTo(GGFDBJACKCK BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xA22CB0", Offset = "0xA21AB0", VA = "0x180A22CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xA22B60", Offset = "0xA21960", VA = "0x180A22B60", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xA22B10", Offset = "0xA21910", VA = "0x180A22B10", Slot = "5")]
	public bool Equals(GGFDBJACKCK BNIMMCIKNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xA22AD0", Offset = "0xA218D0", VA = "0x180A22AD0")]
	public static bool EKDLGPJCFAN(GGFDBJACKCK KGHGGFICJIM, GGFDBJACKCK KEDFPGEDLPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xA22C60", Offset = "0xA21A60", VA = "0x180A22C60")]
	public static bool OBFGMGBJCFC(GGFDBJACKCK KGHGGFICJIM, GGFDBJACKCK KEDFPGEDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xA22C00", Offset = "0xA21A00", VA = "0x180A22C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[KNPMBINOPIG(MLNJOBCAIAM.History)]
	public class GatherPropertiesForUndelete : FICEBFAABIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private MGBEEKHCHKI JDKCPIMOLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private IJJNJPIJDOH BHMKDBDFPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService KMJKOFEFKDJ;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA242D0", Offset = "0xA230D0", VA = "0x180A242D0")]
		public void MNEEOHBBMNB(IJJNJPIJDOH BHMKDBDFPKN, MGBEEKHCHKI JDKCPIMOLEC, HistoryService KMJKOFEFKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA24200", Offset = "0xA23000", VA = "0x180A24200", Slot = "4")]
		private void CHDOHNBDDEM(LIOAALAFEGF JHGILNGJHFB, in LDOGLLBKONE DPJGMDFEIDL, object IEGGGFEMEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NCBGNFOKPJC
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8A9950", Offset = "0x8A8750", VA = "0x1808A9950")]
	public static void JNKKNJCBCIF(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB, JPLAKIBMLBH BJDLJGFHCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8A9A50", Offset = "0x8A8850", VA = "0x1808A9A50")]
	public static void JOCEOKNDIIB(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8A9B10", Offset = "0x8A8910", VA = "0x1808A9B10")]
	public static void MHLJNADILKO(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8A9800", Offset = "0x8A8600", VA = "0x1808A9800")]
	public static void BDJBEDDIBEF(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A9900", Offset = "0x8A8700", VA = "0x1808A9900")]
	public static JPLAKIBMLBH HHCGDDGNBBL(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB)
	{
		return default(JPLAKIBMLBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0C50", Offset = "0x3EBFA50", VA = "0x183EC0C50")]
	public static T COIKAKPFLEO<T>(DCJJOKEDCAG PHBHDKPPOAA, GGFDBJACKCK EMMPBMHAKKB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0C70", Offset = "0x3EBFA70", VA = "0x183EC0C70")]
	public static T COIKAKPFLEO<T>(ref GCHEHJNJOIB CPLKBCGCHAN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8A98B0", Offset = "0x8A86B0", VA = "0x1808A98B0")]
	public static JPLAKIBMLBH HHCGDDGNBBL(ref GCHEHJNJOIB CPLKBCGCHAN)
	{
		return default(JPLAKIBMLBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct DCJJOKEDCAG : IEnumerable<GGFDBJACKCK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum FOIPKFABLDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct PMLPOKPMEJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly DCJJOKEDCAG GHOABBJLFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly NANPEJGFFMP DKAAAJJFJPB;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x982180", Offset = "0x980F80", VA = "0x180982180")]
		public PMLPOKPMEJK(DCJJOKEDCAG GHOABBJLFEA, NANPEJGFFMP DKAAAJJFJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x981EE0", Offset = "0x980CE0", VA = "0x180981EE0")]
		public void PHDNOOKLLIA(NativeList<byte> PIJFOMBKKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x981900", Offset = "0x980700", VA = "0x180981900")]
		private void JCDJEFJJOLA(GGFDBJACKCK EMMPBMHAKKB, ref JFPPGOINKFM PADBGPIMFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x981870", Offset = "0x980670", VA = "0x180981870")]
		private void GGCAPBCAOAC(GGFDBJACKCK EMMPBMHAKKB, ref JFPPGOINKFM PADBGPIMFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x981950", Offset = "0x980750", VA = "0x180981950")]
		private NativeArray<byte> KOBEBPGHGHE(NativeList<byte> PIJFOMBKKIM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x981C90", Offset = "0x980A90", VA = "0x180981C90")]
		private NativeArray<byte> MICKKGBMODP(NativeList<byte> PIJFOMBKKIM, int EOKNLPLGCDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x981A40", Offset = "0x980840", VA = "0x180981A40")]
		private int KPIFCAIAMHA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x981D80", Offset = "0x980B80", VA = "0x180981D80")]
		private bool OOFFGNFDFOO(GGFDBJACKCK EMMPBMHAKKB, out NativeArray<byte> HOFNBNKAFHH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OMKCCBBKLIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> CPLKBCGCHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private DCJJOKEDCAG GHOABBJLFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly GGFDBJACKCK PHBCKPEIIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int CPMHNPIOINN;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9815C0", Offset = "0x9803C0", VA = "0x1809815C0")]
		internal OMKCCBBKLIM(DCJJOKEDCAG GHOABBJLFEA, GGFDBJACKCK PHBCKPEIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x981340", Offset = "0x980140", VA = "0x180981340", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x981380", Offset = "0x980180", VA = "0x180981380")]
		public void NEJIHBIBPGD(NativeArray<byte> DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x981560", Offset = "0x980360", VA = "0x180981560")]
		public void NMCHLMFAPPM(NativeArray<byte> DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x981370", Offset = "0x980170", VA = "0x180981370")]
		public void GGCAPBCAOAC(in LDOGLLBKONE DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C36010", Offset = "0x4C34E10", VA = "0x184C36010")]
		public void GGCAPBCAOAC<T>(T DPJGMDFEIDL) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x9813E0", Offset = "0x9801E0", VA = "0x1809813E0")]
		private void GNMBLLMGANH(int DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x981450", Offset = "0x980250", VA = "0x180981450")]
		private void GNMBLLMGANH(in LDOGLLBKONE DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x981500", Offset = "0x980300", VA = "0x180981500")]
		private unsafe void GNMBLLMGANH(void* HKBFBINIMLD, int EOKNLPLGCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x981380", Offset = "0x980180", VA = "0x180981380")]
		private void GNMBLLMGANH(NativeArray<byte> IDEEEMMOHPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct NBICDLHBBDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private DCJJOKEDCAG GHOABBJLFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> CPLKBCGCHAN;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x980FB0", Offset = "0x97FDB0", VA = "0x180980FB0")]
		internal NBICDLHBBDC(DCJJOKEDCAG GHOABBJLFEA, NativeArray<byte> CPLKBCGCHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x980CF0", Offset = "0x97FAF0", VA = "0x180980CF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x980D00", Offset = "0x97FB00", VA = "0x180980D00")]
		public NativeArray<byte> GMPPLKCMOGG(int EOKNLPLGCDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x980DC0", Offset = "0x97FBC0", VA = "0x180980DC0")]
		public NativeArray<byte> IKLFFMFDMBI()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x4C35F70", Offset = "0x4C34D70", VA = "0x184C35F70")]
		public T LIJGPBIDLCM<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x980EB0", Offset = "0x97FCB0", VA = "0x180980EB0")]
		public void LIJGPBIDLCM(in CBPKPEEEACL DPJGMDFEIDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct EELHAPPMBAP : IEnumerator<GGFDBJACKCK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<GGFDBJACKCK> HDCHHDPICKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int DJIEOHJNDEK;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public GGFDBJACKCK NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x97FA70", Offset = "0x97E870", VA = "0x18097FA70", Slot = "4")]
			get
			{
				return default(GGFDBJACKCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x97FA20", Offset = "0x97E820", VA = "0x18097FA20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x97FA60", Offset = "0x97E860", VA = "0x18097FA60")]
		internal EELHAPPMBAP(NativeList<GGFDBJACKCK> IDEEEMMOHPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x97F8E0", Offset = "0x97E6E0", VA = "0x18097F8E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x97F9E0", Offset = "0x97E7E0", VA = "0x18097F9E0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct PDCPMFLJACD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int KJJBFHNLMMM = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int CPACIGCOMMM = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int JAEJEPAIPLL = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> CPLKBCGCHAN;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool AODFAOEBKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x981740", Offset = "0x980540", VA = "0x180981740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int COCCCCMAKEK
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x981680", Offset = "0x980480", VA = "0x180981680")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x9817E0", Offset = "0x9805E0", VA = "0x1809817E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FOIPKFABLDK AJIDLMHDDLO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x9817C0", Offset = "0x9805C0", VA = "0x1809817C0")]
			get
			{
				return default(FOIPKFABLDK);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x9816D0", Offset = "0x9804D0", VA = "0x1809816D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool DCCHNNPIGNI
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x9817D0", Offset = "0x9805D0", VA = "0x1809817D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x981660", Offset = "0x980460", VA = "0x180981660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool CLGLMBNHIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x981730", Offset = "0x980530", VA = "0x180981730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x9816E0", Offset = "0x9804E0", VA = "0x1809816E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9817F0", Offset = "0x9805F0", VA = "0x1809817F0")]
		public PDCPMFLJACD(FOIPKFABLDK GENNIEOCFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x981700", Offset = "0x980500", VA = "0x180981700")]
		private int HEOCMNIHPLM(int OMMIHDFOJDN, int JMFEKBHMJGH = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x981780", Offset = "0x980580", VA = "0x180981780")]
		private void LMMFIPJEJPN(int OMMIHDFOJDN, int DPJGMDFEIDL, int JMFEKBHMJGH = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x981690", Offset = "0x980490", VA = "0x180981690", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int BADGJDBEAMB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int GIGGDOICGGJ = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly GGFDBJACKCK HGNFLBKPKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<GGFDBJACKCK, int> OHMIHBLGJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<GGFDBJACKCK> PHBHDKPPOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> LNAHDBNHMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> KBMFHKMDHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> CPLKBCGCHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private PDCPMFLJACD LNCKHCKJOFM;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DCCHNNPIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x90AE80", Offset = "0x909C80", VA = "0x18090AE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KPKEJCNLKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x90AE60", Offset = "0x909C60", VA = "0x18090AE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int COCCCCMAKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x90A4B0", Offset = "0x9092B0", VA = "0x18090A4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int GACDEAHBPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x90A7D0", Offset = "0x9095D0", VA = "0x18090A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x90AA00", Offset = "0x909800", VA = "0x18090AA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x90A4C0", Offset = "0x9092C0", VA = "0x18090A4C0")]
	public static DCJJOKEDCAG DIMOBFAICBM(FOIPKFABLDK GENNIEOCFED = FOIPKFABLDK.Last, int ODPDBLCAFKE = 16, int NEFEDDJCJPC = 256)
	{
		return default(DCJJOKEDCAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x90B0B0", Offset = "0x909EB0", VA = "0x18090B0B0")]
	private DCJJOKEDCAG(FOIPKFABLDK GENNIEOCFED, int ODPDBLCAFKE, int NEFEDDJCJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x90A500", Offset = "0x909300", VA = "0x18090A500", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x90AA40", Offset = "0x909840", VA = "0x18090AA40")]
	public OMKCCBBKLIM IEJMLEPLKCB(GGFDBJACKCK PHBCKPEIIAK)
	{
		return default(OMKCCBBKLIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x90ADD0", Offset = "0x909BD0", VA = "0x18090ADD0")]
	public NBICDLHBBDC MDJHMOMMLCL(GGFDBJACKCK PHBCKPEIIAK)
	{
		return default(NBICDLHBBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x90A810", Offset = "0x909610", VA = "0x18090A810")]
	public bool HANMOHMHPPP(GGFDBJACKCK PHBCKPEIIAK, out NBICDLHBBDC BJBHFOGLCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x90AF60", Offset = "0x909D60", VA = "0x18090AF60")]
	public bool PFGOGDMEBFM(GGFDBJACKCK PHBCKPEIIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x90AE90", Offset = "0x909C90", VA = "0x18090AE90")]
	public bool OEKEOEDIALH(GGFDBJACKCK PHBCKPEIIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x90ACE0", Offset = "0x909AE0", VA = "0x18090ACE0")]
	public void LNFMINJCAEE(NativeList<byte> PIJFOMBKKIM, NANPEJGFFMP DKAAAJJFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C28960", Offset = "0x3C27760", VA = "0x183C28960")]
	public T JEIOEOGODCD<T>(GGFDBJACKCK PHBCKPEIIAK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x90ABC0", Offset = "0x9099C0", VA = "0x18090ABC0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x90ACA0", Offset = "0x909AA0", VA = "0x18090ACA0")]
	public EELHAPPMBAP LEIFMBFFFGJ()
	{
		return default(EELHAPPMBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x90A5E0", Offset = "0x9093E0", VA = "0x18090A5E0")]
	private void EMLNFNDDGNC(GGFDBJACKCK PHBCKPEIIAK, int CPMHNPIOINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x90AAD0", Offset = "0x9098D0", VA = "0x18090AAD0")]
	private void JOBLPEANAPC(int EPHAANJKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x90A3C0", Offset = "0x9091C0", VA = "0x18090A3C0")]
	private void AJGALBPOLKG(GGFDBJACKCK PHBCKPEIIAK, int CPMHNPIOINN, int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C288E0", Offset = "0x3C276E0", VA = "0x183C288E0")]
	private static T JEIOEOGODCD<T>(NativeArray<byte> HDCHHDPICKJ, int OMMIHDFOJDN = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x90AFF0", Offset = "0x909DF0", VA = "0x18090AFF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x90AFB0", Offset = "0x909DB0", VA = "0x18090AFB0", Slot = "4")]
	private IEnumerator<GGFDBJACKCK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class PFGKDLMBIEP<T> : KDFOLIPKNOC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x3FBFCE0", Offset = "0x3FBEAE0", VA = "0x183FBFCE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3FBFE00", Offset = "0x3FBEC00", VA = "0x183FBFE00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3C801E0", Offset = "0x3C7EFE0", VA = "0x183C801E0")]
	public PFGKDLMBIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	internal class CleanupRigidbodyExImpl : KDFOLIPKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x900150", Offset = "0x8FEF50", VA = "0x180900150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9001F0", Offset = "0x8FEFF0", VA = "0x1809001F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class EHCGFDPCKCC : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery OFDMKLKDDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x90DC70", Offset = "0x90CA70", VA = "0x18090DC70", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x90DCC0", Offset = "0x90CAC0", VA = "0x18090DCC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x90DD50", Offset = "0x90CB50", VA = "0x18090DD50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public EHCGFDPCKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal class MNBJJBGFNFD : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService BGOCKMMIJDD;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8A9520", Offset = "0x8A8320", VA = "0x1808A9520", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x8A9570", Offset = "0x8A8370", VA = "0x1808A9570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public MNBJJBGFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService HAOGFLCGAPO;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x90CDE0", Offset = "0x90BBE0", VA = "0x18090CDE0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x90CE30", Offset = "0x90BC30", VA = "0x18090CE30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x90CEC0", Offset = "0x90BCC0", VA = "0x18090CEC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[HLJOGLEHOLC(typeof(CullingBandService), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class CullingBandService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<NativeListAsync<GNNNKOIJOAL>> CBFHGBBDIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x9095E0", Offset = "0x9083E0", VA = "0x1809095E0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x909630", Offset = "0x908430", VA = "0x180909630")]
		public void DOGMOICPFLK(NativeListAsync<GNNNKOIJOAL> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x909170", Offset = "0x907F70", VA = "0x180909170")]
		public void AHFLBLDKDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x9096A0", Offset = "0x9084A0", VA = "0x1809096A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x909860", Offset = "0x908660", VA = "0x180909860")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[HLJOGLEHOLC(typeof(ONNDHBLELDO), new string[] { })]
	public class PhysicsService : KPALCLLIODG, DOKJEHLBPKM, ONNDHBLELDO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly EKGLDANHPKF JIHLMGONGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager ECFOMHOIDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private IMIJPLGBEGF IDKPAJDFEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService KOJBMKIIGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::AMBLIANEJIB<NLDEMLNMJPF> OAAHBMCLEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<LEDHMIGLCGN, NLDEMLNMJPF> HDJAGMMFJDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x8C3680", Offset = "0x8C2480", VA = "0x1808C3680", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x8C35E0", Offset = "0x8C23E0", VA = "0x1808C35E0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F30", Offset = "0x8C1D30", VA = "0x1808C2F30", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x8C3340", Offset = "0x8C2140", VA = "0x1808C3340", Slot = "5")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8C3050", Offset = "0x8C1E50", VA = "0x1808C3050", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8C3270", Offset = "0x8C2070", VA = "0x1808C3270", Slot = "8")]
		public bool JEIDKDMNDII(LEDHMIGLCGN NFBLCBCBMID, out Collider OGJBFFBMNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8C31B0", Offset = "0x8C1FB0", VA = "0x1808C31B0")]
		private void GHJJKEDMFKB(Entity DNMNICOEECM, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE EPJLLOJPHCA, LDOGLLBKONE ABCKFOPNDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E70", Offset = "0x8C1C70", VA = "0x1808C2E70", Slot = "9")]
		public void AHAMLKEEIHE(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[HLJOGLEHOLC(typeof(HKGBKCLENBH), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class RbexService : KPALCLLIODG, HKGBKCLENBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private EHFLPEEKACO LGOMFHMIPEG;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD50", Offset = "0x8C9B50", VA = "0x1808CAD50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8C8CF0", Offset = "0x8C7AF0", VA = "0x1808C8CF0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1B0", Offset = "0x8C8FB0", VA = "0x1808CA1B0", Slot = "6")]
		public BNKCFHLNIJK HOGJBONEJDB(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA870", VA = "0x1808CBA70", Slot = "5")]
		public void PMALMMEDHFM(LEDHMIGLCGN NFBLCBCBMID, BNKCFHLNIJK DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8CAFE0", Offset = "0x8C9DE0", VA = "0x1808CAFE0", Slot = "34")]
		public CollisionDetectionMode LKJCFDNNEHB(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B20", Offset = "0x8C8920", VA = "0x1808C9B20", Slot = "35")]
		public void FHDJECEDLCN(LEDHMIGLCGN NFBLCBCBMID, CollisionDetectionMode DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8CB620", Offset = "0x8CA420", VA = "0x1808CB620", Slot = "36")]
		public HDCNNOKEHCC NANPEIJPIPC(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(HDCNNOKEHCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8CA650", Offset = "0x8C9450", VA = "0x1808CA650", Slot = "37")]
		public void JJLNLAGIAGK(LEDHMIGLCGN NFBLCBCBMID, HDCNNOKEHCC DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FC0", Offset = "0x8C7DC0", VA = "0x1808C8FC0", Slot = "38")]
		public bool CMNKKPPJLMH(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8C9290", Offset = "0x8C8090", VA = "0x1808C9290", Slot = "39")]
		public void CPFELHGDCHK(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8C9210", Offset = "0x8C8010", VA = "0x1808C9210", Slot = "40")]
		public LEDHMIGLCGN CONDOMCIIBM(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E40", Offset = "0x8C7C40", VA = "0x1808C8E40", Slot = "41")]
		public void BOLJMGLGNNB(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C8BB0", VA = "0x1808C9DB0", Slot = "42")]
		public LEDHMIGLCGN GCHFIHMHOPE(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8CB900", Offset = "0x8CA700", VA = "0x1808CB900", Slot = "43")]
		public void OLGACPEMICJ(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA450", Offset = "0x8C9250", VA = "0x1808CA450", Slot = "7")]
		public void IEFILFBALKN(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA240", Offset = "0x8C9040", VA = "0x1808CA240", Slot = "8")]
		public void IBNDOHPBODA(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8C8AE0", Offset = "0x8C78E0", VA = "0x1808C8AE0", Slot = "9")]
		public int AFINJGDAMJP(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9C20", Offset = "0x8C8A20", VA = "0x1808C9C20", Slot = "10")]
		public LEDHMIGLCGN FPACLIHAMAM(LEDHMIGLCGN NFBLCBCBMID, int DJIEOHJNDEK)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8C9E40", VA = "0x1808CB040", Slot = "11")]
		public void LKJEHPEHDGO(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8C9CB0", VA = "0x1808CAEB0", Slot = "12")]
		public void LKDEFMKAHOC(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI, LEDHMIGLCGN DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8C9020", Offset = "0x8C7E20", VA = "0x1808C9020", Slot = "13")]
		public void CNMKOEKHENG(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x8C9630", Offset = "0x8C8430", VA = "0x1808C9630", Slot = "14")]
		public bool EAHEOLCPOGJ(LEDHMIGLCGN NFBLCBCBMID, out LEDHMIGLCGN DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE30", Offset = "0x8C9C30", VA = "0x1808CAE30", Slot = "15")]
		public void LKDAGEHNHJF(LEDHMIGLCGN NFBLCBCBMID, float3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4C0", Offset = "0x8CA2C0", VA = "0x1808CB4C0", Slot = "16")]
		public bool MMIPEDBMADG(LEDHMIGLCGN NFBLCBCBMID, out float3 DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8C8700", Offset = "0x8C7500", VA = "0x1808C8700", Slot = "17")]
		public void AADBGGAEOKF(LEDHMIGLCGN NFBLCBCBMID, float3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8CB290", Offset = "0x8CA090", VA = "0x1808CB290", Slot = "18")]
		public bool MDNFNAAGPGI(LEDHMIGLCGN NFBLCBCBMID, out float3 DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x8CA910", Offset = "0x8C9710", VA = "0x1808CA910", Slot = "26")]
		public float3 KJGDAJGBFIO(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8CBB20", Offset = "0x8CA920", VA = "0x1808CBB20", Slot = "27")]
		public void PNEKFJPINIP(LEDHMIGLCGN NFBLCBCBMID, float3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C90", Offset = "0x8C7A90", VA = "0x1808C8C90", Slot = "28")]
		public float AOJHIAPOEAA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9EC0", Offset = "0x8C8CC0", VA = "0x1808C9EC0", Slot = "29")]
		public void GMPNFBPKBLA(LEDHMIGLCGN NFBLCBCBMID, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C30", Offset = "0x8C7A30", VA = "0x1808C8C30", Slot = "30")]
		public float AOCKFPNPOGA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8CA250", VA = "0x1808CB450", Slot = "31")]
		public void MFHHGKALMKG(LEDHMIGLCGN NFBLCBCBMID, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8CB810", Offset = "0x8CA610", VA = "0x1808CB810", Slot = "32")]
		public bool NMEBEJMNHFB(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x8CAA60", Offset = "0x8C9860", VA = "0x1808CAA60", Slot = "33")]
		public void KOOBIBFLBIJ(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x8C9300", Offset = "0x8C8100", VA = "0x1808C9300", Slot = "19")]
		public void DAMJOFDDNNP(LEDHMIGLCGN NFBLCBCBMID, float3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x8CB130", Offset = "0x8C9F30", VA = "0x1808CB130", Slot = "20")]
		public bool MDKJADLHJJK(LEDHMIGLCGN NFBLCBCBMID, out float3 DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x8C99C0", Offset = "0x8C87C0", VA = "0x1808C99C0", Slot = "21")]
		public void EOHFMFAKKNI(LEDHMIGLCGN NFBLCBCBMID, quaternion DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8CABF0", Offset = "0x8C99F0", VA = "0x1808CABF0", Slot = "22")]
		public bool LECNGEEMGKK(LEDHMIGLCGN NFBLCBCBMID, out quaternion DPJGMDFEIDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8C87E0", Offset = "0x8C75E0", VA = "0x1808C87E0", Slot = "23")]
		public bool AEAFLHPDLKJ(LEDHMIGLCGN NFBLCBCBMID, out float3 CONMONEDOJH, out quaternion GIIFDANDIBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BD0", Offset = "0x8C79D0", VA = "0x1808C8BD0", Slot = "44")]
		public NNIOOPPGOBD ALLNAILJBEA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(NNIOOPPGOBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8CB980", Offset = "0x8CA780", VA = "0x1808CB980", Slot = "45")]
		public void PBPAMOKKDGJ(LEDHMIGLCGN NFBLCBCBMID, NNIOOPPGOBD DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8CB870", Offset = "0x8CA670", VA = "0x1808CB870", Slot = "72")]
		public void OBAEDCBFPKE(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8CA020", Offset = "0x8C8E20", VA = "0x1808CA020", Slot = "73")]
		public void HBCMCMPMODA(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x8CB9F0", Offset = "0x8CA7F0", VA = "0x1808CB9F0", Slot = "74")]
		public bool PLABPNGBDOI(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B90", Offset = "0x8C8990", VA = "0x1808C9B90", Slot = "81")]
		public void FKPMDOKLBOE(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x8CB6C0", Offset = "0x8CA4C0", VA = "0x1808CB6C0", Slot = "82")]
		public void NHABILOOMPC(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA830", Offset = "0x8C9630", VA = "0x1808CA830", Slot = "83")]
		public bool JNDBKNHNCEH(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA0B0", Offset = "0x8C8EB0", VA = "0x1808CA0B0", Slot = "84")]
		public IEnumerable<object> HBCMHAEDCNK(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA7D0", Offset = "0x8C95D0", VA = "0x1808CA7D0", Slot = "46")]
		public bool JNCHBODMJAJ(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA8B0", Offset = "0x8C96B0", VA = "0x1808CA8B0", Slot = "47")]
		public void KGHMFKCDDJF(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8C9B70", VA = "0x1808CAD70", Slot = "48")]
		public bool LJBNDJFJLCI(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8CA6F0", Offset = "0x8C94F0", VA = "0x1808CA6F0", Slot = "49")]
		public void JLEPJFEMELP(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8CB7B0", Offset = "0x8CA5B0", VA = "0x1808CB7B0", Slot = "50")]
		public bool NIGFIAJPGOJ(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8CA760", Offset = "0x8C9560", VA = "0x1808CA760", Slot = "51")]
		public void JLMOFDGNENL(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8C8780", Offset = "0x8C7580", VA = "0x1808C8780", Slot = "52")]
		public RigidbodyConstraints ADONAPNHHAK(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8CA350", Offset = "0x8C9150", VA = "0x1808CA350", Slot = "53")]
		public void ICHPBMFGCAG(LEDHMIGLCGN NFBLCBCBMID, RigidbodyConstraints DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3F0", Offset = "0x8CA1F0", VA = "0x1808CB3F0", Slot = "54")]
		public float MEDGHACECAK(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x8CA560", Offset = "0x8C9360", VA = "0x1808CA560", Slot = "55")]
		public void ILHBMJBJLNP(LEDHMIGLCGN NFBLCBCBMID, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8CB750", Offset = "0x8CA550", VA = "0x1808CB750", Slot = "56")]
		public float NHJNCCLBLKD(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8C8EC0", Offset = "0x8C7CC0", VA = "0x1808C8EC0", Slot = "57")]
		public void CBOLBKMCOGG(LEDHMIGLCGN NFBLCBCBMID, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9550", Offset = "0x8C8350", VA = "0x1808C9550", Slot = "58")]
		public bool DOPMHIJMBIJ(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8C94E0", Offset = "0x8C82E0", VA = "0x1808C94E0", Slot = "59")]
		public void DDEENHKHBND(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8C9E60", Offset = "0x8C8C60", VA = "0x1808C9E60", Slot = "60")]
		public bool GDDEIFCIJGK(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DD0", Offset = "0x8C7BD0", VA = "0x1808C8DD0", Slot = "61")]
		public void BMJPKMAIGHM(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8C9AC0", Offset = "0x8C88C0", VA = "0x1808C9AC0", Slot = "62")]
		public int FFACHGJKKGA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9950", Offset = "0x8C8750", VA = "0x1808C9950", Slot = "63")]
		public void ELIPDFPLIEM(LEDHMIGLCGN NFBLCBCBMID, int DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8C9A30", Offset = "0x8C8830", VA = "0x1808C9A30", Slot = "64")]
		public Rigidbody FEFPFIBJHPG(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8C90B0", Offset = "0x8C7EB0", VA = "0x1808C90B0", Slot = "65")]
		public void COMDDIHIACB(LEDHMIGLCGN NFBLCBCBMID, Rigidbody DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8C8A50", Offset = "0x8C7850", VA = "0x1808C8A50", Slot = "75")]
		public void AEGFGJILNJB(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8CAB60", Offset = "0x8C9960", VA = "0x1808CAB60", Slot = "76")]
		public void LECDONJGLLI(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8C95B0", Offset = "0x8C83B0", VA = "0x1808C95B0", Slot = "77")]
		public bool EAFDOCMANAD(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3C0", Offset = "0x8C91C0", VA = "0x1808CA3C0", Slot = "66")]
		public object IEECMJBGCNA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8C9790", Offset = "0x8C8590", VA = "0x1808C9790", Slot = "67")]
		public void EBIMHBHOHBK(LEDHMIGLCGN NFBLCBCBMID, object DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8CAAD0", Offset = "0x8C98D0", VA = "0x1808CAAD0", Slot = "68")]
		public object KPFHAEGFEOA(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8C9380", Offset = "0x8C8180", VA = "0x1808C9380", Slot = "69")]
		public void DCLPPPMCDLN(LEDHMIGLCGN NFBLCBCBMID, object DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8CADD0", Offset = "0x8C9BD0", VA = "0x1808CADD0", Slot = "70")]
		public float LJHAOHLMBCN(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9D40", Offset = "0x8C8B40", VA = "0x1808C9D40", Slot = "71")]
		public void GBJDIADKPAF(LEDHMIGLCGN NFBLCBCBMID, float DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F30", Offset = "0x8C8D30", VA = "0x1808C9F30", Slot = "78")]
		public void GPNJEDEKDHG(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8F30", Offset = "0x8C7D30", VA = "0x1808C8F30", Slot = "79")]
		public void CIKPGFHPJPB(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA5D0", Offset = "0x8C93D0", VA = "0x1808CA5D0", Slot = "80")]
		public bool JAKLMMKKCEL(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8C9FC0", Offset = "0x8C8DC0", VA = "0x1808C9FC0", Slot = "24")]
		public void HADOCFMJNNF(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8C98F0", Offset = "0x8C86F0", VA = "0x1808C98F0", Slot = "25")]
		public void EHFFDGHNHED(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x41F7230", Offset = "0x41F6030", VA = "0x1841F7230")]
		private void FBMAEHNPLDJ<T>(LEDHMIGLCGN NFBLCBCBMID, bool DPJGMDFEIDL) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x41F7280", Offset = "0x41F6080", VA = "0x1841F7280")]
		private bool GKOJECGAMJJ<T>(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x41F7FD0", Offset = "0x41F6DD0", VA = "0x1841F7FD0")]
		private void PPEAGPDBOCM<T>(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x41F7E50", Offset = "0x41F6C50", VA = "0x1841F7E50")]
		private bool LCHDIPBJCEP<TC, TV>(LEDHMIGLCGN NFBLCBCBMID, Func<TC, TV> LHLDMHIEOEA, out TV DPJGMDFEIDL) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x41F71B0", Offset = "0x41F5FB0", VA = "0x1841F71B0")]
		private bool LCHDIPBJCEP<T>(LEDHMIGLCGN NFBLCBCBMID, out T DPJGMDFEIDL) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x41F7830", Offset = "0x41F6630", VA = "0x1841F7830")]
		private T ILINNKDDIBH<T>(LEDHMIGLCGN NFBLCBCBMID) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x41F72E0", Offset = "0x41F60E0", VA = "0x1841F72E0")]
		private void HIMPEMJOMFD<T>(LEDHMIGLCGN NFBLCBCBMID, T DPJGMDFEIDL) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x41F6B50", Offset = "0x41F5950", VA = "0x1841F6B50")]
		private void BOJKPMJGIHK<T>(LEDHMIGLCGN NFBLCBCBMID, T DPJGMDFEIDL) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x41F71B0", Offset = "0x41F5FB0", VA = "0x1841F71B0")]
		private bool HPDLLJEMFNB<T>(LEDHMIGLCGN NFBLCBCBMID, out T DPJGMDFEIDL) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x41F7D30", Offset = "0x41F6B30", VA = "0x1841F7D30")]
		private T KFFJBCANLAF<T>(LEDHMIGLCGN NFBLCBCBMID) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x41F71B0", Offset = "0x41F5FB0", VA = "0x1841F71B0")]
		private void DKFCMJCCPAP<T>(LEDHMIGLCGN NFBLCBCBMID, T DPJGMDFEIDL) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x41F7C80", Offset = "0x41F6A80", VA = "0x1841F7C80")]
		private void JPGEPBDFFFG<T>(LEDHMIGLCGN NFBLCBCBMID, T DPJGMDFEIDL) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DA0", Offset = "0x8C7BA0", VA = "0x1808C8DA0")]
		private LEDHMIGLCGN BMCIMAHBFJA(Entity DNMNICOEECM)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA990", Offset = "0x8C9790", VA = "0x1808CA990")]
		private DynamicBuffer<Entity> KLMJHECCIJB(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x41F7D90", Offset = "0x41F6B90", VA = "0x1841F7D90")]
		private void KKKIACJIBMP<T>(LEDHMIGLCGN NFBLCBCBMID, object DPJGMDFEIDL, Func<object, T> LHLDMHIEOEA) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void NEOFEBEOAIM<T>(ref global::JGINJLKIIMG<T> MDAGBLFAAKK) where T : struct, KMKIHICBCMB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void NEOFEBEOAIM<TC, TV>(ref global::INNNKMFPNPD<TC, TV> MDAGBLFAAKK) where TC : struct, KMKIHICBCMB
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	[HLJOGLEHOLC(typeof(KinematicSleepChangeService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class KinematicSleepChangeService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class ACCEIJPIDGO : IEnumerable<BNKCFHLNIJK>, IEnumerable, IEnumerator<BNKCFHLNIJK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private BNKCFHLNIJK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			private BNKCFHLNIJK System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
			[DebuggerHidden]
			public ACCEIJPIDGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x11A9060", Offset = "0x11A7E60", VA = "0x1811A9060", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x11A8D20", Offset = "0x11A7B20", VA = "0x1811A8D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x11A90E0", Offset = "0x11A7EE0", VA = "0x1811A90E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x11A9020", Offset = "0x11A7E20", VA = "0x1811A9020", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x11A8F70", Offset = "0x11A7D70", VA = "0x1811A8F70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BNKCFHLNIJK> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x11A8F70", Offset = "0x11A7D70", VA = "0x1811A8F70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> LNNBHBDPEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xA35FC0", Offset = "0xA34DC0", VA = "0x180A35FC0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xA367D0", Offset = "0xA355D0", VA = "0x180A367D0")]
		public void DOGMOICPFLK(NativeArray<Entity> JFFJECJPHEB, bool MBDKEJGIAGI, bool LAANONPMILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA35DB0", Offset = "0xA34BB0", VA = "0x180A35DB0")]
		public void AHFLBLDKDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA36010", Offset = "0xA34E10", VA = "0x180A36010")]
		private void DCMHMFNDCFF(NativeArray<Entity> JFFJECJPHEB, bool MBDKEJGIAGI, bool LAANONPMILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA36A40", Offset = "0xA35840", VA = "0x180A36A40")]
		[IteratorStateMachine(typeof(ACCEIJPIDGO))]
		private IEnumerable<BNKCFHLNIJK> IFGMBHBHBMK(NativeArray<Entity> JFFJECJPHEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA368F0", Offset = "0xA356F0", VA = "0x180A368F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA36B20", Offset = "0xA35920", VA = "0x180A36B20")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[HLJOGLEHOLC(typeof(GNIJOOFEPBL), new string[] { })]
public class AGPHHBECKEE : GNIJOOFEPBL, IEnumerable<KOFEPFEJINF>, IEnumerable, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[AGIJCBMCMGO]
	private AKPDAFPFFKM DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> LDAMLMHHKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private IGLMCNHENLN CFBKBPIALOC;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F26B0", Offset = "0x8F14B0", VA = "0x1808F26B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KOFEPFEJINF BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AC0", Offset = "0x8F18C0", VA = "0x1808F2AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public KOFEPFEJINF BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AC0", Offset = "0x8F18C0", VA = "0x1808F2AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x8F27B0", Offset = "0x8F15B0", VA = "0x1808F27B0", Slot = "11")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x8F2630", Offset = "0x8F1430", VA = "0x1808F2630", Slot = "12")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x8F2820", Offset = "0x8F1620", VA = "0x1808F2820")]
	private void LAAPEMLAPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x8F2AE0", Offset = "0x8F18E0", VA = "0x1808F2AE0")]
	private string PBGKGEJOJEO(string CCEKFDNIAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x8F26D0", Offset = "0x8F14D0", VA = "0x1808F26D0", Slot = "7")]
	public KOFEPFEJINF DCDPLHLGGLJ(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x8F2C10", Offset = "0x8F1A10", VA = "0x1808F2C10")]
	private bool PNCGEFCEJHC(Type AFAIENJNNPO, string CCEKFDNIAPD, out KOFEPFEJINF KDFMDMEBMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x8F2B00", Offset = "0x8F1900", VA = "0x1808F2B00", Slot = "8")]
	public INOPGIMBOKC PHICJJCIGIG(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return default(INOPGIMBOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x8F2800", Offset = "0x8F1600", VA = "0x1808F2800", Slot = "9")]
	public IEnumerator<KOFEPFEJINF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8F2800", Offset = "0x8F1600", VA = "0x1808F2800", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x8F2EC0", Offset = "0x8F1CC0", VA = "0x1808F2EC0")]
	public AGPHHBECKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[DefaultMember("Item")]
public interface NANPEJGFFMP
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHOPCKCNNMK(INOPGIMBOKC FCIFBDBBENJ, out int LCJMNMLOPCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[HLJOGLEHOLC(typeof(NANPEJGFFMP), new string[] { })]
public class MHKLIBDDIAH : KPALCLLIODG, DOKJEHLBPKM, NANPEJGFFMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[AGIJCBMCMGO]
	private LLLCOEENCOL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<INOPGIMBOKC, int> NDFFLAJOMMP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA3A190", Offset = "0xA38F90", VA = "0x180A3A190", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA3A120", Offset = "0xA38F20", VA = "0x180A3A120", Slot = "6")]
	public bool NHOPCKCNNMK(INOPGIMBOKC FCIFBDBBENJ, out int LCJMNMLOPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0xA39E40", Offset = "0xA38C40", VA = "0x180A39E40", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xA3A110", Offset = "0xA38F10", VA = "0x180A3A110", Slot = "5")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA39EA0", Offset = "0xA38CA0", VA = "0x180A39EA0")]
	private void FOOCFHDGKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xA3A1F0", Offset = "0xA38FF0", VA = "0x180A3A1F0")]
	public MHKLIBDDIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[HLJOGLEHOLC(typeof(LLLCOEENCOL), new string[] { })]
[DefaultMember("Item")]
public class FMGHMDOLACC : LLLCOEENCOL, IEnumerable<ENGJLAFCBJI>, IEnumerable, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, AEKODNEMCEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[AGIJCBMCMGO]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[AGIJCBMCMGO]
	private GNIJOOFEPBL EHJHPJFNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private ENGJLAFCBJI[] EHANGNHJAOC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA216A0", Offset = "0xA204A0", VA = "0x180A216A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ENGJLAFCBJI BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA21920", Offset = "0xA20720", VA = "0x180A21920", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ENGJLAFCBJI BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA21920", Offset = "0xA20720", VA = "0x180A21920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "10")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA21400", Offset = "0xA20200", VA = "0x180A21400", Slot = "11")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "12")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xA216B0", Offset = "0xA204B0", VA = "0x180A216B0", Slot = "6")]
	public ENGJLAFCBJI DCDPLHLGGLJ(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xA21A40", Offset = "0xA20840", VA = "0x180A21A40", Slot = "7")]
	public INOPGIMBOKC PHICJJCIGIG(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return default(INOPGIMBOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0xA21960", Offset = "0xA20760", VA = "0x180A21960", Slot = "8")]
	public IEnumerator<ENGJLAFCBJI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0xA21B10", Offset = "0xA20910", VA = "0x180A21B10", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A59700", Offset = "0x3A58500", VA = "0x183A59700", Slot = "13")]
	public void ACKGONCECJP<TKey, T>(global::CHKLHNJIEBJ<TKey, T> JHGILNGJHFB, [Optional] object IEGGGFEMEIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA205E0", VA = "0x180A217E0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public FMGHMDOLACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xA21920", Offset = "0xA20720", VA = "0x180A21920")]
	[CompilerGenerated]
	private ENGJLAFCBJI FIMJKKFIPJD(int LFDIJNFJPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[HLJOGLEHOLC(typeof(EJBFOOGDBBL), new string[] { })]
[DefaultMember("Item")]
public class KGBHILFNPEA : EJBFOOGDBBL, IEnumerable<ABFMHNDOCPA>, IEnumerable, KPALCLLIODG, DOKJEHLBPKM, AEKODNEMCEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[AGIJCBMCMGO]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[AGIJCBMCMGO]
	private GNIJOOFEPBL EHJHPJFNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private ABFMHNDOCPA[] EHANGNHJAOC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA346D0", Offset = "0xA334D0", VA = "0x180A346D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ABFMHNDOCPA BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA348E0", Offset = "0xA336E0", VA = "0x180A348E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ABFMHNDOCPA BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xA348E0", Offset = "0xA336E0", VA = "0x180A348E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA34660", Offset = "0xA33460", VA = "0x180A34660", Slot = "9")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xA34AE0", Offset = "0xA338E0", VA = "0x180A34AE0", Slot = "10")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xA34A00", Offset = "0xA33800", VA = "0x180A34A00")]
	private ABFMHNDOCPA IGBICCDECKD(int DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0xA34720", Offset = "0xA33520", VA = "0x180A34720", Slot = "6")]
	public ABFMHNDOCPA DCDPLHLGGLJ(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0xA34D40", Offset = "0xA33B40", VA = "0x180A34D40", Slot = "14")]
	public INOPGIMBOKC PHICJJCIGIG(AMGMGHLEMLF MEBPKBJLLDI)
	{
		return default(INOPGIMBOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xA348F0", Offset = "0xA336F0", VA = "0x180A348F0", Slot = "7")]
	public IEnumerator<ABFMHNDOCPA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xA348F0", Offset = "0xA336F0", VA = "0x180A348F0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x322ED00", Offset = "0x322DB00", VA = "0x18322ED00", Slot = "11")]
	public void ACKGONCECJP<TKey, T>(global::CHKLHNJIEBJ<TKey, T> JHGILNGJHFB, [Optional] object IEGGGFEMEIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xA34840", Offset = "0xA33640", VA = "0x180A34840", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KGBHILFNPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xA348E0", Offset = "0xA336E0", VA = "0x180A348E0")]
	[CompilerGenerated]
	private ABFMHNDOCPA FIMJKKFIPJD(int LFDIJNFJPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(AKPDAFPFFKM), new string[] { })]
internal class AKPDAFPFFKM : KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private GNIJOOFEPBL EHJHPJFNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private EJBFOOGDBBL NMGFEILLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private LLLCOEENCOL DGNEOCPMFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::JMMBMFDPPCF<LKKPMGMGFIA> LAANNECNDLG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IGLMCNHENLN LMGDIHJBELE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D4470", Offset = "0x6D3270", VA = "0x1806D4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x8F3520", Offset = "0x8F2320", VA = "0x1808F3520", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x8F3650", Offset = "0x8F2450", VA = "0x1808F3650")]
	private void DJEFHHNNAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x36597B0", Offset = "0x36585B0", VA = "0x1836597B0")]
	public T PIOKNDFKNGA<T>() where T : LKKPMGMGFIA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x8F38E0", Offset = "0x8F26E0", VA = "0x1808F38E0")]
	public KOFEPFEJINF NOOOLPBKHJP(AMGMGHLEMLF CCEKFDNIAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::AMBLIANEJIB<T> NOOOLPBKHJP<T>(AMGMGHLEMLF CCEKFDNIAPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x8F3740", Offset = "0x8F2540", VA = "0x1808F3740")]
	public ABFMHNDOCPA HADILKBDNCP(AMGMGHLEMLF CCEKFDNIAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x4317450", Offset = "0x4316250", VA = "0x184317450")]
	public global::GGJMPKJGDJM<T> HADILKBDNCP<T>(AMGMGHLEMLF CCEKFDNIAPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x8F3810", Offset = "0x8F2610", VA = "0x1808F3810")]
	public ENGJLAFCBJI NDGDMAPGFIH(AMGMGHLEMLF CCEKFDNIAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::PEDBMPAMMKB<T> NDGDMAPGFIH<T>(AMGMGHLEMLF CCEKFDNIAPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public AKPDAFPFFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class GHCGDCBMDFN
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A88CA0", Offset = "0x3A87AA0", VA = "0x183A88CA0")]
	public static global::AMBLIANEJIB<T> NOOOLPBKHJP<T>(this AKPDAFPFFKM KMJBGHCCPII, global::HACMJIPGPHI<T> CCEKFDNIAPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::GGJMPKJGDJM<T> HADILKBDNCP<T>(this AKPDAFPFFKM KMJBGHCCPII, global::HACMJIPGPHI<T> CCEKFDNIAPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::PEDBMPAMMKB<T> NDGDMAPGFIH<T>(this AKPDAFPFFKM KMJBGHCCPII, global::HACMJIPGPHI<T> CCEKFDNIAPD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
[HLJOGLEHOLC(typeof(DBMLHAGMKKO), new string[] { })]
public class DBMLHAGMKKO : KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private MGBEEKHCHKI JDKCPIMOLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private INOPGIMBOKC[] HGECGFBENKL;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x909FA0", Offset = "0x908DA0", VA = "0x180909FA0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x90A230", Offset = "0x909030", VA = "0x18090A230")]
	public void FCIGKGBOOFD(IJJNJPIJDOH OJMDJGIIFAA, bool NBFHLGOBGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public DBMLHAGMKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HLJOGLEHOLC(typeof(PBBGDDADAKL), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
public sealed class PBBGDDADAKL : KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BGGPBOPEDBA : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
		[DebuggerHidden]
		public BGGPBOPEDBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x11A9D50", Offset = "0x11A8B50", VA = "0x1811A9D50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x11A99A0", Offset = "0x11A87A0", VA = "0x1811A99A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x11A9DD0", Offset = "0x11A8BD0", VA = "0x1811A9DD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x11A9D10", Offset = "0x11A8B10", VA = "0x1811A9D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x11A9C80", Offset = "0x11A8A80", VA = "0x1811A9C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x11A9C80", Offset = "0x11A8A80", VA = "0x1811A9C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string POELABEDBBO = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, CPNMDNJEGCI> IFMCDPIPOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> OHMHODFCAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> ONDFKMMBLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private EJBFOOGDBBL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private JPBNEEDJLKP GABFGDHMPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private AHFPALIMFBF BINHKOFKAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::DNHLENHGBPH<CPNMDNJEGCI> CJDAMIHGPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject HKKOFOHMJGB;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9B0", Offset = "0x8BC7B0", VA = "0x1808BD9B0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x8BE380", Offset = "0x8BD180", VA = "0x1808BE380", Slot = "5")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x8BDF00", Offset = "0x8BCD00", VA = "0x1808BDF00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0D0", Offset = "0x8BDED0", VA = "0x1808BF0D0")]
	private void PHFDENPIIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAC0", Offset = "0x8BD8C0", VA = "0x1808BEAC0")]
	internal void PABDEJAPOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1A0", Offset = "0x8BCFA0", VA = "0x1808BE1A0")]
	private void HEDDFMFDLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BCEA0", VA = "0x1808BE0A0")]
	private void FOBIINMDBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x8BE930", Offset = "0x8BD730", VA = "0x1808BE930")]
	[IteratorStateMachine(typeof(BGGPBOPEDBA))]
	private IEnumerable<RRCustomPropTag> OBMDLEBALNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA80", Offset = "0x8BC880", VA = "0x1808BDA80")]
	private void DPAODGEAJPK(LEDHMIGLCGN NFBLCBCBMID, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE980", Offset = "0x8BD780", VA = "0x1808BE980")]
	private void OBNDPKOJMJJ(SerializableGuid KFIPLDEPOPC, GameObject NGIKODIIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE5A0", Offset = "0x8BD3A0", VA = "0x1808BE5A0")]
	private void LHGNHAGFJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEEF0", Offset = "0x8BDCF0", VA = "0x1808BEEF0")]
	private bool PDJMFMIFEBD(CPNMDNJEGCI BCOFPIEJNLC, Transform KICGHGEEADG, out GameObject BINMOAHIPCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE550", Offset = "0x8BD350", VA = "0x1808BE550")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x8BF0E0", Offset = "0x8BDEE0", VA = "0x1808BF0E0")]
	public PBBGDDADAKL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public SerializableGuid LGGHGADEICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8610", Offset = "0x8C7410", VA = "0x1808C8610")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HLJOGLEHOLC(typeof(HEOCNGLGBLN), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
public class HEOCNGLGBLN : KPALCLLIODG
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string JLNPDHPKHEF = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService BBLHCHIFBMC;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0xA24A40", Offset = "0xA23840", VA = "0x180A24A40", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public HEOCNGLGBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
[HLJOGLEHOLC(typeof(IBMKLBJHPHM), new string[] { })]
public class IBMKLBJHPHM : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[AGIJCBMCMGO]
	private EnableComponentSystemsInScope PNDKEFGNGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[AGIJCBMCMGO]
	private SceneService BBLHCHIFBMC;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0xA2DBB0", Offset = "0xA2C9B0", VA = "0x180A2DBB0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0xA2DC20", Offset = "0xA2CA20", VA = "0x180A2DC20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0xA2DC60", Offset = "0xA2CA60", VA = "0x180A2DC60")]
	private void MJLNAPCEDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0xA2DC80", Offset = "0xA2CA80", VA = "0x180A2DC80")]
	private void NMBLMOALDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IBMKLBJHPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HLJOGLEHOLC(typeof(EJHGJPDMMNM), new string[] { })]
public class ILFNAKFJBOA : KPALCLLIODG, DOKJEHLBPKM, EJHGJPDMMNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private OJCNMNJFNCK DELEODDAJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private LAKCIKLBBPE AOFLGPMAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService KOJBMKIIGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem FDEPONHBBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int PMFHCBPMFAF;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OAKAGHDKDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4F0", Offset = "0xA2E2F0", VA = "0x180A2F4F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LEDHMIGLCGN LHEDNLMACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xA2FC10", Offset = "0xA2EA10", VA = "0x180A2FC10", Slot = "9")]
		get
		{
			return default(LEDHMIGLCGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA2F900", Offset = "0xA2E700", VA = "0x180A2F900", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public HMIODAKHEJO CDHFGJEEAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA2F430", Offset = "0xA2E230", VA = "0x180A2F430", Slot = "11")]
		get
		{
			return default(HMIODAKHEJO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA2F900", Offset = "0xA2E700", VA = "0x180A2F900", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HMIODAKHEJO KFBIFDFONMG
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xA2F370", Offset = "0xA2E170", VA = "0x180A2F370", Slot = "13")]
		get
		{
			return default(HMIODAKHEJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint MJHLNLPONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xA2F850", Offset = "0xA2E650", VA = "0x180A2F850")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CGHEABPKOCO OEAHENINFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA2FAD0", Offset = "0xA2E8D0", VA = "0x180A2FAD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xA2FB70", Offset = "0xA2E970", VA = "0x180A2FB70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0xA2F590", Offset = "0xA2E390", VA = "0x180A2F590", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0xA2FDE0", Offset = "0xA2EBE0", VA = "0x180A2FDE0", Slot = "5")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0xA2F920", Offset = "0xA2E720", VA = "0x180A2F920", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0xA2FF80", Offset = "0xA2ED80", VA = "0x180A2FF80")]
	private void MBJPIPAGBMK(Entity DNMNICOEECM, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE EPJLLOJPHCA, LDOGLLBKONE ABCKFOPNDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0xA2FCD0", Offset = "0xA2EAD0", VA = "0x180A2FCD0", Slot = "14")]
	public LEDHMIGLCGN IEFPBIBEMHK(LEDHMIGLCGN MOKGIKPKEBG, LEDHMIGLCGN PABKONOGBKI)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0xA2F9D0", Offset = "0xA2E7D0", VA = "0x180A2F9D0", Slot = "15")]
	public bool ELMNJLIGOFH(LEDHMIGLCGN MOKGIKPKEBG, LEDHMIGLCGN PABKONOGBKI, out LEDHMIGLCGN BDKHOEDMNIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0xA2F070", Offset = "0xA2DE70", VA = "0x180A2F070", Slot = "16")]
	public void ABJKFNJCLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0xA2FCB0", Offset = "0xA2EAB0", VA = "0x180A2FCB0", Slot = "17")]
	public void HDFCJMGHGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0xA2F660", Offset = "0xA2E460", VA = "0x180A2F660", Slot = "18")]
	public bool CBMLCALBHPA(LEDHMIGLCGN KMOIJDECCNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2E000", VA = "0x180A2F200")]
	private void AHEOFGGLNPC(LEDHMIGLCGN FDLGEMGDGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public ILFNAKFJBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HLJOGLEHOLC(typeof(GFLFGIAIPAA), new string[] { })]
public class JCNIIIPKANN : KPALCLLIODG, GFLFGIAIPAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xA315B0", Offset = "0xA303B0", VA = "0x180A315B0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xA31630", Offset = "0xA30430", VA = "0x180A31630", Slot = "5")]
	public void LFMAJGJFJNA(LEDHMIGLCGN BHMKDBDFPKN, bool DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x32195B0", Offset = "0x32183B0", VA = "0x1832195B0")]
	private void LMMFIPJEJPN<T>(LEDHMIGLCGN BHMKDBDFPKN, bool DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public JCNIIIPKANN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[HLJOGLEHOLC(typeof(GHIGCKNPKNN), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.RenderEffects)]
	public class SelectionService : KPALCLLIODG, GHIGCKNPKNN
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager ECFOMHOIDDI;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x985530", Offset = "0x984330", VA = "0x180985530", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x985620", Offset = "0x984420", VA = "0x180985620", Slot = "5")]
		public void NKKJAGIEDGP(LEDHMIGLCGN BHMKDBDFPKN, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9855B0", Offset = "0x9843B0", VA = "0x1809855B0", Slot = "6")]
		public void LJPEBMJBBOC(LEDHMIGLCGN BHMKDBDFPKN, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x32195B0", Offset = "0x32183B0", VA = "0x1832195B0")]
		private void LMMFIPJEJPN<T>(LEDHMIGLCGN BHMKDBDFPKN, bool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
[HLJOGLEHOLC(typeof(EOHBECCAMAG), new string[] { })]
internal sealed class EOHBECCAMAG : KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[AGIJCBMCMGO]
	private ObjectEmbodimentService EAFONAFODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP BPCGIPNNAMM;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x90ED00", Offset = "0x90DB00", VA = "0x18090ED00", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public EOHBECCAMAG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	[HLJOGLEHOLC(typeof(WorldSerialization), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	internal sealed class WorldSerialization : KPALCLLIODG, BMCBJIJOKNO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly EKGLDANHPKF NCAKIFNFNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[AGIJCBMCMGO]
		private DDLBEFNOPIH MEELIDEONKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[AGIJCBMCMGO]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[AGIJCBMCMGO]
		private SerializationService GABFGDHMPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[AGIJCBMCMGO]
		private EMEFJJPEKKP PHBHDKPPOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[AGIJCBMCMGO]
		private DebugWorldsService PKPIKHCBPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[AGIJCBMCMGO]
		private BulkInstantiateSceneObjectService ADCLMOENENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private KEOFLKLFAOP OPNLEKFMABF;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private HAELDGHLPLD OOAHONOPJGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x9999F0", Offset = "0x9987F0", VA = "0x1809999F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x9998A0", Offset = "0x9986A0", VA = "0x1809998A0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP LAJGCLJCGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x999A10", Offset = "0x998810", VA = "0x180999A10", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x999740", Offset = "0x998540", VA = "0x180999740", Slot = "6")]
		public bool AONGPPDAPKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x99A3C0", Offset = "0x9991C0", VA = "0x18099A3C0", Slot = "7")]
		public bool NMGAJDOADCH(IEnumerable<KGIJKPANHFI> IDNOGKNDBCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x99A3E0", Offset = "0x9991E0", VA = "0x18099A3E0", Slot = "5")]
		public ByteString PLLBGNIGJPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x999720", Offset = "0x998520", VA = "0x180999720")]
		private void AINMFFFLFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x99A200", Offset = "0x999000", VA = "0x18099A200")]
		private void JEGKEEJEHCM(EMPIKNKKIIH PEPOBPKKBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x999D20", Offset = "0x998B20", VA = "0x180999D20")]
		private void GOIPDAKAIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x999A40", Offset = "0x998840", VA = "0x180999A40")]
		private void GIKPPIJIELE(KHBAIADNABO PEPOBPKKBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x99A2D0", Offset = "0x9990D0", VA = "0x18099A2D0", Slot = "8")]
		public void JLEDNMLPELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x99A320", Offset = "0x999120", VA = "0x18099A320")]
		private EMPIKNKKIIH KBEHCCJIKLO(EntityManager AEACOCEHFLB, EntityManager LACAMDOJOEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[HLJOGLEHOLC(typeof(LKIJHLBBCPD), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
public class LKIJHLBBCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<MKFEGIBJCLL, string> PGGIKKNEIMD;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xA38150", Offset = "0xA36F50", VA = "0x180A38150")]
	public GameObject JPNFHFELNIH(MKFEGIBJCLL KMCFNCIEGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xA38220", Offset = "0xA37020", VA = "0x180A38220")]
	public LKIJHLBBCPD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(TimeService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class TimeService : CCIFGMMGDFO, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[AGIJCBMCMGO]
		private SingletonComponentService MHNACBKOHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool DGONGDINMNG;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData KPBHKCILMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x98CF80", Offset = "0x98BD80", VA = "0x18098CF80")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x98CFF0", Offset = "0x98BDF0", VA = "0x18098CFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool LONFCEGLBFE
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x84C980", Offset = "0x84B780", VA = "0x18084C980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x98CF70", Offset = "0x98BD70", VA = "0x18098CF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x98CF60", Offset = "0x98BD60", VA = "0x18098CF60", Slot = "4")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x98CE50", Offset = "0x98BC50", VA = "0x18098CE50", Slot = "5")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x98CEA0", Offset = "0x98BCA0", VA = "0x18098CEA0")]
		public void FADHBCKCFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	[HLJOGLEHOLC(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : KPALCLLIODG, DOKJEHLBPKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private OIHJCGPPHNA PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::AMBLIANEJIB<Entity> KICGHGEEADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService CFFMBLMAMOD;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x988FD0", Offset = "0x987DD0", VA = "0x180988FD0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x9890E0", Offset = "0x987EE0", VA = "0x1809890E0", Slot = "5")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x989040", Offset = "0x987E40", VA = "0x180989040", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x989210", Offset = "0x988010", VA = "0x180989210")]
		private void NLFMMAHNOND(Entity DNMNICOEECM, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[KNPMBINOPIG(MLNJOBCAIAM.Services)]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	[HLJOGLEHOLC(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[AGIJCBMCMGO]
		private OOONNEPHJGJ BBEGNBBGFBF;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private MHLEOJABAKM CIKNGENANOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xA1D410", Offset = "0xA1C210", VA = "0x180A1D410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private KAPMPBPLDOG PKFJBMJPMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0xA1D460", Offset = "0xA1C260", VA = "0x180A1D460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xA1D370", Offset = "0xA1C170", VA = "0x180A1D370", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xA1D3F0", Offset = "0xA1C1F0", VA = "0x180A1D3F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
[HLJOGLEHOLC(typeof(IIIMJHMHLON), new string[] { })]
public class IIIMJHMHLON : GHBKMHMLIAD, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class NCKICAFBDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public KEOFLKLFAOP services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public NCKICAFBDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x11B16E0", Offset = "0x11B04E0", VA = "0x1811B16E0")]
		internal void <InitReferences>b__0(KPALCLLIODG svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class DIBJPEOHLLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public KEOFLKLFAOP services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public DIBJPEOHLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x11AB8E0", Offset = "0x11AA6E0", VA = "0x1811AB8E0")]
		internal void <InitExternal>b__0(DOKJEHLBPKM svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP BPCGIPNNAMM;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public EHKKFECMDED EHALDMHGANA
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED00", Offset = "0xA2DB00", VA = "0x180A2ED00", Slot = "4")]
		get
		{
			return default(EHKKFECMDED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private PLMMGPNIKJM CPBIHJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EDF0", Offset = "0xA2DBF0", VA = "0x180A2EDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xA2ECB0", Offset = "0xA2DAB0", VA = "0x180A2ECB0", Slot = "5")]
	public void HFIDPCJBPHP(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xA2EB80", Offset = "0xA2D980", VA = "0x180A2EB80", Slot = "6")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xA2E970", Offset = "0xA2D770", VA = "0x180A2E970", Slot = "7")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0xA2ED10", Offset = "0xA2DB10", VA = "0x180A2ED10", Slot = "8")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xA2EA50", Offset = "0xA2D850", VA = "0x180A2EA50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x3F77A90", Offset = "0x3F76890", VA = "0x183F77A90")]
	private void HIJJBMACJGI<T>(Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public IIIMJHMHLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class DDOJMPGIBHN<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> NOOMPALANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> NGFFBKNAABM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public DDOJMPGIBHN(Func<From, To> KPMPGMAPHFA, Func<To, From> NOOMPALANFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int DJIEOHJNDEK, To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class HIFNGDFJNBC<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> NOOMPALANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x39313A0", Offset = "0x39301A0", VA = "0x1839313A0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x3931400", Offset = "0x3930200", VA = "0x183931400", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x3931370", Offset = "0x3930170", VA = "0x183931370", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x701090", Offset = "0x6FFE90", VA = "0x180701090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x39312E0", Offset = "0x39300E0", VA = "0x1839312E0")]
	public HIFNGDFJNBC(Func<From, To> KPMPGMAPHFA, Func<To, From> NOOMPALANFJ, bool JEFIMODPPHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x3930F00", Offset = "0x392FD00", VA = "0x183930F00", Slot = "11")]
	public void Add(To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x3930F60", Offset = "0x392FD60", VA = "0x183930F60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x3930F90", Offset = "0x392FD90", VA = "0x183930F90", Slot = "13")]
	public bool Contains(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x3930FF0", Offset = "0x392FDF0", VA = "0x183930FF0", Slot = "14")]
	public void CopyTo(To[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x3931100", Offset = "0x392FF00", VA = "0x183931100", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x3931170", Offset = "0x392FF70", VA = "0x183931170", Slot = "6")]
	public int IndexOf(To BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x39311D0", Offset = "0x392FFD0", VA = "0x1839311D0", Slot = "7")]
	public void Insert(int DJIEOHJNDEK, To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x3931280", Offset = "0x3930080", VA = "0x183931280", Slot = "15")]
	public bool Remove(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x3931250", Offset = "0x3930050", VA = "0x183931250", Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x3764FB0", Offset = "0x3763DB0", VA = "0x183764FB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class PIEJBEGLGOB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> NOOMPALANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> HDCHHDPICKJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4210", Offset = "0x3FC3010", VA = "0x183FC4210", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4260", Offset = "0x3FC3060", VA = "0x183FC4260", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x3FC41D0", Offset = "0x3FC2FD0", VA = "0x183FC41D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x35C0940", Offset = "0x35BF740", VA = "0x1835C0940")]
	public PIEJBEGLGOB(Func<From, To> KPMPGMAPHFA, Func<To, From> NOOMPALANFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3D90", Offset = "0x3FC2B90", VA = "0x183FC3D90", Slot = "11")]
	public void Add(To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3DD0", Offset = "0x3FC2BD0", VA = "0x183FC3DD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3E10", Offset = "0x3FC2C10", VA = "0x183FC3E10", Slot = "13")]
	public bool Contains(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3ED0", Offset = "0x3FC2CD0", VA = "0x183FC3ED0", Slot = "14")]
	public void CopyTo(To[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3F90", Offset = "0x3FC2D90", VA = "0x183FC3F90", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3FC40A0", Offset = "0x3FC2EA0", VA = "0x183FC40A0", Slot = "6")]
	public int IndexOf(To BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4110", Offset = "0x3FC2F10", VA = "0x183FC4110", Slot = "7")]
	public void Insert(int DJIEOHJNDEK, To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4190", Offset = "0x3FC2F90", VA = "0x183FC4190", Slot = "15")]
	public bool Remove(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4150", Offset = "0x3FC2F50", VA = "0x183FC4150", Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x3126360", Offset = "0x3125160", VA = "0x183126360", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class DHJKOPBFGOD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> KPMPGMAPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> NOOMPALANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool BJGAENKKDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public DHJKOPBFGOD(Func<From, To> KPMPGMAPHFA, Func<To, From> NOOMPALANFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HDCHHDPICKJ, int HKFDIPJFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To BKCHCEAGIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int DJIEOHJNDEK, To BKCHCEAGIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BKCHCEAGIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class HIICCILACGK
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string OLAHGOELAAE = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string GHDMJHDANHI = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string CPFLJDFHHAD = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string OFNEENJNCLM = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string PNFCKIAIOJB = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string MLIABFGBKPF = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string IOCHBCCGAJF = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string BOAOJOHJCNK = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class LAFOFKEJAIN
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LDDPDMEGCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public KEOFLKLFAOP services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public LDDPDMEGCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x11AFA40", Offset = "0x11AE840", VA = "0x1811AFA40")]
		internal void <InitServices>b__1(KPALCLLIODG svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x11AFAA0", Offset = "0x11AE8A0", VA = "0x1811AFAA0")]
		internal void <InitServices>b__2(DOKJEHLBPKM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA35DE0", VA = "0x180A36FE0")]
	public static void MKLHFNLIONI(this PLMMGPNIKJM DJCIICEJFGH, KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C69100", Offset = "0x3C67F00", VA = "0x183C69100")]
	public static void HIJJBMACJGI<T>(this PLMMGPNIKJM DJCIICEJFGH, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C68C00", Offset = "0x3C67A00", VA = "0x183C68C00")]
	public static void EFDENGLKKJC<T>(this PLMMGPNIKJM DJCIICEJFGH, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C68F50", Offset = "0x3C67D50", VA = "0x183C68F50")]
	public static void HDEOJPPEGBL<T>(this PLMMGPNIKJM DJCIICEJFGH, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C69170", Offset = "0x3C67F70", VA = "0x183C69170")]
	public static void MFEBCDKLJNF<T>(this PLMMGPNIKJM DJCIICEJFGH, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3C68DA0", Offset = "0x3C67BA0", VA = "0x183C68DA0")]
	public static void EOACPPMJEML<T>(this PLMMGPNIKJM DJCIICEJFGH, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C68A90", Offset = "0x3C67890", VA = "0x183C68A90")]
	public static void EFDENGLKKJC<T>(IEnumerable<ComponentSystemBase> LHNNPMPCLEE, Action<T> POENMCKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3C69320", Offset = "0x3C68120", VA = "0x183C69320")]
	private static void MFEBIHBKJEB<T>(object PFKBGJMLAMC, Action<T> POENMCKCDAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class NBICLBDBACK
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class EHLBNPMAEEI
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x90DFE0", Offset = "0x90CDE0", VA = "0x18090DFE0")]
	public static void HILCBHGHHFH(ComponentSystemBase PFKBGJMLAMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class LPGKEOGCHJD
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool EJOAHFIKKEM<T>(ref T EFBCPNIKEHB, ref T BFLEMGIJKLG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class JLJJEKEPEPG
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class CPPJHPADDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public CPPJHPADDNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xA32EC0", Offset = "0xA31CC0", VA = "0x180A32EC0")]
	public static string LMPGBALINNL(Transform HAFNICDKMAH, Transform KMOIJDECCNO)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[KNPMBINOPIG(MLNJOBCAIAM.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x988050", Offset = "0x986E50", VA = "0x180988050")]
		public static void FJMKFOKGINK(this GMLDFADABOI OPNLEKFMABF, JFBGCEOLBKN POLNGKBPPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x988390", Offset = "0x987190", VA = "0x180988390")]
		public static void IGJBFHJBNAI(this GMLDFADABOI OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x988280", Offset = "0x987080", VA = "0x180988280")]
		public static void FJMKFOKGINK(this GMLDFADABOI OPNLEKFMABF, [Optional] string[] DOIGBDIMODG, [Optional] string[] HLHECEPDMMI, [Optional] string[] MNEMJKEDCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x988650", Offset = "0x987450", VA = "0x180988650")]
		public static void IPIKHKLDEEM(this GMLDFADABOI OPNLEKFMABF, params string[] PPGJPLDFFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x987DA0", Offset = "0x986BA0", VA = "0x180987DA0")]
		public static void AIGAJCICMGA(this GMLDFADABOI OPNLEKFMABF, params string[] PPGJPLDFFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x987E50", Offset = "0x986C50", VA = "0x180987E50")]
		private static string[] ELIJFPDHHBF(JFBGCEOLBKN POLNGKBPPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x988490", Offset = "0x987290", VA = "0x180988490")]
		private static bool IHCAKKHHDEB(JFBGCEOLBKN POLNGKBPPLK, out string[] JICJIAGIFCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0")]
		private static bool JLCADBPPDNH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class AEMBGJLLKLG : NBPLFNCIPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo NCCJIKDBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] NHMGHNFFDAC;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8F1520", Offset = "0x8F0320", VA = "0x1808F1520")]
	public AEMBGJLLKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action FIKAMBFKPDD();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x8F1330", Offset = "0x8F0130", VA = "0x1808F1330")]
	public MethodInfo IGNEKBLHEEO(Action CIAILAMJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8F1370", Offset = "0x8F0170", VA = "0x1808F1370", Slot = "4")]
	public void OBNDPKOJMJJ(Type LAKBKKJKBPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class MCOCGAHFEBI : AEMBGJLLKLG
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum CJFHNANLFGH
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xA39D20", Offset = "0xA38B20", VA = "0x180A39D20", Slot = "5")]
	public override Action FIKAMBFKPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void JPDIJKGJKOH<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0xA39DB0", Offset = "0xA38BB0", VA = "0x180A39DB0")]
	[Preserve]
	public void ICDDKPMPJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x8AF990", Offset = "0x8AE790", VA = "0x1808AF990")]
	protected MCOCGAHFEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class OJFLDKOENKN : AEMBGJLLKLG
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x8AF870", Offset = "0x8AE670", VA = "0x1808AF870", Slot = "5")]
	public override Action FIKAMBFKPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KPHJONDIHPO<T>() where T : JMHCOOOCIFG;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8AF900", Offset = "0x8AE700", VA = "0x1808AF900")]
	[Preserve]
	public void ICDDKPMPJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x8AF990", Offset = "0x8AE790", VA = "0x1808AF990")]
	protected OJFLDKOENKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class ECNNJDFDGIC : AEMBGJLLKLG
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x90D320", Offset = "0x90C120", VA = "0x18090D320", Slot = "5")]
	public override Action FIKAMBFKPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void FGHPMCNGHAL<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x90D3B0", Offset = "0x90C1B0", VA = "0x18090D3B0")]
	[Preserve]
	public void ICDDKPMPJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x8F1520", Offset = "0x8F0320", VA = "0x1808F1520")]
	protected ECNNJDFDGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class HJBLAILJBJH
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0xA26E50", Offset = "0xA25C50", VA = "0x180A26E50")]
	public static Entity HMHLKJFAMLJ(this EntityManager ECFOMHOIDDI)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class EEKEFPJMHGK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0x11ABE10", Offset = "0x11AAC10", VA = "0x1811ABE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x11ABE60", Offset = "0x11AAC60", VA = "0x1811ABE60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x11ABEB0", Offset = "0x11AACB0", VA = "0x1811ABEB0")]
			[DebuggerHidden]
			public EEKEFPJMHGK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x11ABC80", Offset = "0x11AAA80", VA = "0x1811ABC80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x11ABE20", Offset = "0x11AAC20", VA = "0x1811ABE20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x11ABD60", Offset = "0x11AAB60", VA = "0x1811ABD60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x11ABD60", Offset = "0x11AAB60", VA = "0x1811ABD60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class NDHFCLHCPBI : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000615")]
				[Cpp2IlInjected.Address(RVA = "0x11ABE10", Offset = "0x11AAC10", VA = "0x1811ABE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x11B1A20", Offset = "0x11B0820", VA = "0x1811B1A20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x11ABEB0", Offset = "0x11AACB0", VA = "0x1811ABEB0")]
			[DebuggerHidden]
			public NDHFCLHCPBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x11B1A70", Offset = "0x11B0870", VA = "0x1811B1A70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x11B1740", Offset = "0x11B0540", VA = "0x1811B1740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x11B1B00", Offset = "0x11B0900", VA = "0x1811B1B00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x11B19E0", Offset = "0x11B07E0", VA = "0x1811B19E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x11B1930", Offset = "0x11B0730", VA = "0x1811B1930", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x11B1930", Offset = "0x11B0730", VA = "0x1811B1930", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class KHIEMNPNPOH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x11ABE10", Offset = "0x11AAC10", VA = "0x1811ABE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x11AF420", Offset = "0x11AE220", VA = "0x1811AF420", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x11ABEB0", Offset = "0x11AACB0", VA = "0x1811ABEB0")]
			[DebuggerHidden]
			public KHIEMNPNPOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x11AF470", Offset = "0x11AE270", VA = "0x1811AF470", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x11AF010", Offset = "0x11ADE10", VA = "0x1811AF010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x11AF540", Offset = "0x11AE340", VA = "0x1811AF540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x11AF590", Offset = "0x11AE390", VA = "0x1811AF590")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x11AF3E0", Offset = "0x11AE1E0", VA = "0x1811AF3E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x11AF340", Offset = "0x11AE140", VA = "0x1811AF340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x11AF340", Offset = "0x11AE140", VA = "0x1811AF340", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xA1FE00", Offset = "0xA1EC00", VA = "0x180A1FE00")]
		public static Entity EGJOLOHBLGK(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xA20E00", Offset = "0xA1FC00", VA = "0x180A20E00")]
		public static DynamicBuffer<ChildrenData> OJFCLBKOHIJ(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xA1FC70", Offset = "0xA1EA70", VA = "0x180A1FC70")]
		public static DynamicBuffer<ChildrenData> DOMFAIEACMO(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA20220", Offset = "0xA1F020", VA = "0x180A20220")]
		public static NativeArray<Entity> HCBMNIOGKFD(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Allocator CMCENMLGNBG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xA20C70", Offset = "0xA1FA70", VA = "0x180A20C70")]
		public static bool NGKPHBDDCCN(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Allocator CMCENMLGNBG, out NativeArray<Entity> FIPMKJEHAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA203E0", Offset = "0xA1F1E0", VA = "0x180A203E0")]
		public static NativeArray<Entity> IAEDEOMIHHI(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xA20010", Offset = "0xA1EE10", VA = "0x180A20010")]
		public static Entity FPACLIHAMAM(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, int DJIEOHJNDEK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7D0", Offset = "0xA1E5D0", VA = "0x180A1F7D0")]
		public static int AFINJGDAMJP(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xA20540", Offset = "0xA1F340", VA = "0x180A20540")]
		public static void IFCCJBJNKJO(NativeArray<Entity> PADELIJHEBE, NativeArray<Entity> PDECCELFEPJ, EntityManager ECFOMHOIDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA20900", Offset = "0xA1F700", VA = "0x180A20900")]
		public static int KBIKMFOCAPB(this EntityManager ECFOMHOIDDI, Entity KICGHGEEADG, Entity JJJNIHBIILJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xA207A0", Offset = "0xA1F5A0", VA = "0x180A207A0")]
		public static bool JNLEIODLHDK(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Entity NKHKMPCFDCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA20A60", Offset = "0xA1F860", VA = "0x180A20A60")]
		public static IEnumerable<Entity> LIKIKMEKNMI(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA209B0", Offset = "0xA1F7B0", VA = "0x180A209B0")]
		public static bool LDGJJGLOIFM(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Entity JJJNIHBIILJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA20BF0", Offset = "0xA1F9F0", VA = "0x180A20BF0")]
		public static bool MIOBDMMEPAF(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Entity MOKGIKPKEBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA1FA60", Offset = "0xA1E860", VA = "0x180A1FA60")]
		public static NativeList<Entity> DJBKCJAPECG(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, bool EIKBGGPMPHI = false, Allocator CMCENMLGNBG = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xA20E90", Offset = "0xA1FC90", VA = "0x180A20E90")]
		public static IEnumerable<Entity> OLAHGGADNDF(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA1F960", Offset = "0xA1E760", VA = "0x180A1F960")]
		public static Entity CONDOMCIIBM(this EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xA1FE70", Offset = "0xA1EC70", VA = "0x180A1FE70")]
		public static bool ELMNJLIGOFH(this EntityManager ECFOMHOIDDI, Entity MOKGIKPKEBG, Entity PABKONOGBKI, out Entity BDKHOEDMNIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xA1F8E0", Offset = "0xA1E6E0", VA = "0x180A1F8E0")]
		internal static void BBONDFHKHLO(EntityManager ECFOMHOIDDI, Entity KICGHGEEADG, Entity JJJNIHBIILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD00", Offset = "0xA1EB00", VA = "0x180A1FD00")]
		internal static void DPENJLAMNHD(EntityManager ECFOMHOIDDI, Entity KICGHGEEADG, Entity JJJNIHBIILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xA20D70", Offset = "0xA1FB70", VA = "0x180A20D70")]
		[IteratorStateMachine(typeof(EEKEFPJMHGK))]
		private static IEnumerable<Entity> NKBGGLKKEOA(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xA20350", Offset = "0xA1F150", VA = "0x180A20350")]
		[IteratorStateMachine(typeof(NDHFCLHCPBI))]
		private static IEnumerable<Entity> HFFICCLLMIM(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xA20B70", Offset = "0xA1F970", VA = "0x180A20B70")]
		[IteratorStateMachine(typeof(KHIEMNPNPOH))]
		private static IEnumerable<Entity> LPHHMPHAAMK(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xA20140", Offset = "0xA1EF40", VA = "0x180A20140")]
		private static bool GOEEPJIOPIK(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Entity NKHKMPCFDCI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[HLJOGLEHOLC(typeof(EJJKOHOJBIP), new string[] { })]
public class GFAGPMEMOLB : EJJKOHOJBIP, GHBKMHMLIAD, JOFACKOFGKP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private KEOFLKLFAOP OPNLEKFMABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private DDLBEFNOPIH MEELIDEONKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private OELGFEKAJPK HDNILMEAKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private OJCNMNJFNCK DELEODDAJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private OIHJCGPPHNA PFGOIEFLOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private AKKBHFINLKC GABFGDHMPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private KFMLBIJDEEK DPIALMDBECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private EJBFOOGDBBL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private KEEODLAFLHB DGONCMDHNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private GENPLKLONFI PHALEJNCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private EJHGJPDMMNM BJBHFOGLCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private OHLEPJKHPFA KMJKOFEFKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private ONNDHBLELDO PFMJDPPKDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private GFLFGIAIPAA KOHKFLAONNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private GHIGCKNPKNN LKFJOAFKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private OKGNFHNECDL MCKAOHLPBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private JEIJICDMMNL IKPDHLCKJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private HKGBKCLENBH AKAFHJJKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public KEOFLKLFAOP NHHMGEAMLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public CCMKEKPGHLC PGMNHIJIBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NMDJLEODPOP CPBIHJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DDLBEFNOPIH EKHOEJPCLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public OELGFEKAJPK NNIAMACHFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public NLEJJFIEGLH MDMIPFGDGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public OJCNMNJFNCK BFOFAHABICK
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A70", Offset = "0x6C4870", VA = "0x1806C5A70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OIHJCGPPHNA GLICBEHNJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7A0", Offset = "0x6CA5A0", VA = "0x1806CB7A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public AKKBHFINLKC HKDDLEDHFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CC0", Offset = "0x6C4AC0", VA = "0x1806C5CC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public KFMLBIJDEEK BLHPOCHEALM
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C90", Offset = "0x6C4A90", VA = "0x1806C5C90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EJBFOOGDBBL ACKMLANOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CA0", Offset = "0x6C4AA0", VA = "0x1806C5CA0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KEEODLAFLHB JOMMAODAIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CB0", Offset = "0x6C4AB0", VA = "0x1806C5CB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public GENPLKLONFI MFFAHBOIOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB70", Offset = "0x6CC970", VA = "0x1806CDB70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public EJHGJPDMMNM HAMEEEFHFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB60", Offset = "0x6CC960", VA = "0x1806CDB60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public OHLEPJKHPFA DJAIIFDPHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7433D0", Offset = "0x7421D0", VA = "0x1807433D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public ONNDHBLELDO ODHKFDBCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x74A000", Offset = "0x748E00", VA = "0x18074A000", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public GFLFGIAIPAA LFECHKGNEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7FE810", Offset = "0x7FD610", VA = "0x1807FE810", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GHIGCKNPKNN HBNMIGBPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6D1AC0", Offset = "0x6D08C0", VA = "0x1806D1AC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public OKGNFHNECDL KIKBAOEGAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x81C780", Offset = "0x81B580", VA = "0x18081C780", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public JEIJICDMMNL CDJAMAKOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x74EE70", Offset = "0x74DC70", VA = "0x18074EE70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HKGBKCLENBH LEFMAFAIAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x82A0D0", Offset = "0x828ED0", VA = "0x18082A0D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public EHKKFECMDED EHALDMHGANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA80", Offset = "0x6CD880", VA = "0x1806CEA80", Slot = "21")]
		get
		{
			return default(EHKKFECMDED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xA22780", Offset = "0xA21580", VA = "0x180A22780", Slot = "22")]
	public void HFIDPCJBPHP(KEOFLKLFAOP LAJGCLJCGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0xA22770", Offset = "0xA21570", VA = "0x180A22770", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0xA22A70", Offset = "0xA21870", VA = "0x180A22A70", Slot = "23")]
	public void OEAHENINFEJ(KEOFLKLFAOP LAJGCLJCGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public GFAGPMEMOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class NNCPAGLOMLA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class IOAFHOIIOLB : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NNCPAGLOMLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D20", Offset = "0x8E0B20", VA = "0x1808E1D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x11AE7A0", Offset = "0x11AD5A0", VA = "0x1811AE7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public IOAFHOIIOLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x11AE5F0", Offset = "0x11AD3F0", VA = "0x1811AE5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x11AE760", Offset = "0x11AD560", VA = "0x1811AE760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong HMODBEJJILN = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong NBLGCMPCFEP = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int NPOOANBHHEK = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int DLBMFNOIOCJ = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int GBCBBHENLMP = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int IJPCGNBKJNO = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> DNGHGCALCHL;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x804EF0", Offset = "0x803CF0", VA = "0x180804EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int JAIMLHDLAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x770E20", Offset = "0x76FC20", VA = "0x180770E20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x882710", Offset = "0x881510", VA = "0x180882710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8AC350", Offset = "0x8AB150", VA = "0x1808AC350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB50", Offset = "0x8AA950", VA = "0x1808ABB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x8AC480", Offset = "0x8AB280", VA = "0x1808AC480")]
	public NNCPAGLOMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x8AC500", Offset = "0x8AB300", VA = "0x1808AC500")]
	public NNCPAGLOMLA(int AMENINMKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6F0", Offset = "0x8AA4F0", VA = "0x1808AB6F0")]
	public bool CLOPCIMFOBL(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDA0", Offset = "0x8AABA0", VA = "0x1808ABDA0")]
	public bool GOOOLOLAEMA(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8AB7D0", Offset = "0x8AA5D0", VA = "0x1808AB7D0")]
	public bool DCMNKKCAMCC(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8ABD90", Offset = "0x8AAB90", VA = "0x1808ABD90")]
	public bool GLKFOIMGEAG(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3F0", Offset = "0x8AB1F0", VA = "0x1808AC3F0")]
	public void PBBEDGHDFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF00", Offset = "0x8AAD00", VA = "0x1808ABF00")]
	public void HHPOEELKJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x8AC260", Offset = "0x8AB060", VA = "0x1808AC260")]
	public void LMMFIPJEJPN(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8AC160", Offset = "0x8AAF60", VA = "0x1808AC160")]
	public void KJHAHNAAJMI(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABD00", Offset = "0x8AAB00", VA = "0x1808ABD00")]
	public bool GINCKGANKKP(int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFF0", Offset = "0x8AADF0", VA = "0x1808ABFF0")]
	public void JKBNJDBAHIF(int OMMIHDFOJDN, int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x8AB850", Offset = "0x8AA650", VA = "0x1808AB850")]
	public void DHGBLLKIGPA(int KHIHAIKJNEA, int AEGHEDEPILJ, int KNPCAAMBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA10", Offset = "0x8AA810", VA = "0x1808ABA10")]
	public int EKGLGHAFJEH(int KNPCAAMBLKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x8ABAE0", Offset = "0x8AA8E0", VA = "0x1808ABAE0")]
	public int EKGLGHAFJEH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8AC110", Offset = "0x8AAF10", VA = "0x1808AC110")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE90", Offset = "0x8AAC90", VA = "0x1808ABE90", Slot = "4")]
	[IteratorStateMachine(typeof(IOAFHOIIOLB))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE90", Offset = "0x8AAC90", VA = "0x1808ABE90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class PMCLMPCEHGC<T> : global::NKFJMCEGPDG<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::NGCIFGFGBMN<T> AHOOCNFILJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::OKDAGFHIFMF<T> PKOBHHGAGPE;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x274F730", Offset = "0x274E530", VA = "0x18274F730")]
	public PMCLMPCEHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x35B6240", Offset = "0x35B5040", VA = "0x1835B6240")]
	public PMCLMPCEHGC(global::NGCIFGFGBMN<T> AHOOCNFILJM, global::OKDAGFHIFMF<T> PKOBHHGAGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x35B6060", Offset = "0x35B4E60", VA = "0x1835B6060", Slot = "11")]
	public override T IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x35B5BA0", Offset = "0x35B49A0", VA = "0x1835B5BA0", Slot = "12")]
	public override void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK, T DPJGMDFEIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class MBABENOOJAN
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x365ADE0", Offset = "0x3659BE0", VA = "0x18365ADE0")]
	public static INOPGIMBOKC OBNDPKOJMJJ<T>(this KMGMGDDJLLK DPFFDAKDAHJ, global::HACMJIPGPHI<T> CCEKFDNIAPD, global::NGCIFGFGBMN<T> AHOOCNFILJM, global::OKDAGFHIFMF<T> PKOBHHGAGPE) where T : struct
	{
		return default(INOPGIMBOKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class GGMMNMAOABK<T> : global::PMCLMPCEHGC<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x42160A0", Offset = "0x4214EA0", VA = "0x1842160A0")]
	public GGMMNMAOABK(T CDJGLGILJHJ, T KIDJEKPKJJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class CBAEIHGCMGD<T> : global::NKFJMCEGPDG<T> where T : struct, JMHCOOOCIFG
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x442B4C0", Offset = "0x442A2C0", VA = "0x18442B4C0", Slot = "11")]
	public override T IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x442B430", Offset = "0x442A230", VA = "0x18442B430", Slot = "12")]
	public override void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK, T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2C00350", Offset = "0x2BFF150", VA = "0x182C00350")]
	public CBAEIHGCMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class MEEDOFEAMGG : OCMDAIJBDBA
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type ACDKNBDAPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK, in CBPKPEEEACL DPJGMDFEIDL);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK, in LDOGLLBKONE DPJGMDFEIDL);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void JIGGKPCGAGJ(FNGPCDCOHDD MGAEFPBCPOK, FGANNBOHKFB IGBHFDGFHIO, [Optional] object IEGGGFEMEIG);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	protected MEEDOFEAMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class NKFJMCEGPDG<T> : MEEDOFEAMGG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type ACDKNBDAPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x395D790", Offset = "0x395C590", VA = "0x18395D790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK, T DPJGMDFEIDL);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x395C1E0", Offset = "0x395AFE0", VA = "0x18395C1E0", Slot = "8")]
	public override void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK, in CBPKPEEEACL KMOIJDECCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x395B6E0", Offset = "0x395A4E0", VA = "0x18395B6E0", Slot = "9")]
	public override void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK, in LDOGLLBKONE PHBCKPEIIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x395C6E0", Offset = "0x395B4E0", VA = "0x18395C6E0", Slot = "10")]
	public override void JIGGKPCGAGJ(FNGPCDCOHDD MGAEFPBCPOK, FGANNBOHKFB IGBHFDGFHIO, object IEGGGFEMEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390")]
	protected NKFJMCEGPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class OLBDOHHAKPG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class KKGJMBFDCFF
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class JMJPGCJHPFN<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
			public JMJPGCJHPFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x3700750", Offset = "0x36FF550", VA = "0x183700750")]
			internal void <RegisterFixedString>b__0(FNGPCDCOHDD p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x3700920", Offset = "0x36FF720", VA = "0x183700920")]
			internal T <RegisterFixedString>b__1(FNGPCDCOHDD p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x11AF5E0", Offset = "0x11AE3E0", VA = "0x1811AF5E0")]
		public static void DDFMFBMOPEM(HLFLBAHBAHA BMJINKLIJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x4C72340", Offset = "0x4C71140", VA = "0x184C72340")]
		private static void HHMCPMPFAFJ<T>(HLFLBAHBAHA BMJINKLIJOB, int KIDJEKPKJJM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x4C72AB0", Offset = "0x4C718B0", VA = "0x184C72AB0")]
		private static void HKPHAMHPFPK<T>(FNGPCDCOHDD KDPJHAGCGIJ, T FKCJFNALIGC, int KIDJEKPKJJM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x4C72460", Offset = "0x4C71260", VA = "0x184C72460")]
		private static T HKNPNGOMKGH<T>(FNGPCDCOHDD KDPJHAGCGIJ, int KIDJEKPKJJM) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public KKGJMBFDCFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class GJAPMOLFJHO : MCOCGAHFEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private HLFLBAHBAHA BMJINKLIJOB;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x4C6F560", Offset = "0x4C6E360", VA = "0x184C6F560", Slot = "6")]
		public override void JPDIJKGJKOH<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x11ADCA0", Offset = "0x11ACAA0", VA = "0x1811ADCA0")]
		public static void CDDOPAMDCPG(HLFLBAHBAHA BMJINKLIJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x11ADD50", Offset = "0x11ACB50", VA = "0x1811ADD50")]
		public GJAPMOLFJHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB80", Offset = "0x8AE980", VA = "0x1808AFB80")]
	public static void HBNEEIMPKCN(HLFLBAHBAHA BMJINKLIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x3688C00", Offset = "0x3687A00", VA = "0x183688C00")]
	public static void OJCLICDDAGO<T>(HLFLBAHBAHA BMJINKLIJOB, global::NGCIFGFGBMN<T> AHOOCNFILJM, global::OKDAGFHIFMF<T> PKOBHHGAGPE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x3688B90", Offset = "0x3687990", VA = "0x183688B90")]
	public static void GKJLDICDOFC<T>(HLFLBAHBAHA KKCANAGMCIH) where T : struct, JMHCOOOCIFG
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
public interface HLFLBAHBAHA : global::DMNMALFOODJ<HLFLBAHBAHA>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBNDPKOJMJJ(Type LAKBKKJKBPK, OCMDAIJBDBA KKCANAGMCIH);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBLHCMBLLEL(Type LAKBKKJKBPK, out OCMDAIJBDBA KKCANAGMCIH);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class LHJLKCAPOEC
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0xA37F00", Offset = "0xA36D00", VA = "0x180A37F00")]
	public static void OBNDPKOJMJJ(this HLFLBAHBAHA ILCANNFLEKH, OCMDAIJBDBA KKCANAGMCIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[HLJOGLEHOLC(typeof(KMGMGDDJLLK), new string[] { })]
public sealed class OEDIEAKJGCA : KMGMGDDJLLK, global::DMNMALFOODJ<KMGMGDDJLLK>, CCIFGMMGDFO, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<INOPGIMBOKC, OCMDAIJBDBA> BMJINKLIJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private HLFLBAHBAHA OELCAMPADPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private LLLCOEENCOL DPFFDAKDAHJ;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool DOBPGBHLILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x701090", Offset = "0x6FFE90", VA = "0x180701090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD810", Offset = "0x8AC610", VA = "0x1808AD810")]
	public OEDIEAKJGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8AC690", VA = "0x1808AD890")]
	public OEDIEAKJGCA(Dictionary<INOPGIMBOKC, OCMDAIJBDBA> BMJINKLIJOB, bool NCKKELNDHPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD440", Offset = "0x8AC240", VA = "0x1808AD440", Slot = "7")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD0D0", Offset = "0x8ABED0", VA = "0x1808AD0D0", Slot = "8")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4A0", Offset = "0x8AC2A0", VA = "0x1808AD4A0", Slot = "9")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD740", Offset = "0x8AC540", VA = "0x1808AD740", Slot = "4")]
	public INOPGIMBOKC PHICJJCIGIG(AMGMGHLEMLF CCEKFDNIAPD)
	{
		return default(INOPGIMBOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5D0", Offset = "0x8AC3D0", VA = "0x1808AD5D0", Slot = "5")]
	public void OBNDPKOJMJJ(INOPGIMBOKC FCIFBDBBENJ, OCMDAIJBDBA KKCANAGMCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD150", Offset = "0x8ABF50", VA = "0x1808AD150")]
	[Conditional("DEBUG_BUILD")]
	private void BONILLBPDPO(INOPGIMBOKC FCIFBDBBENJ, Type LAKBKKJKBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AD290", Offset = "0x8AC090", VA = "0x1808AD290", Slot = "6")]
	public bool GBLHCMBLLEL(INOPGIMBOKC FCIFBDBBENJ, out OCMDAIJBDBA KKCANAGMCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4F0", Offset = "0x8AC2F0", VA = "0x1808AD4F0", Slot = "10")]
	public KMGMGDDJLLK MICLOCMPGIE()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[HLJOGLEHOLC(typeof(HLFLBAHBAHA), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.TypeSerializer)]
	public sealed class TypeSerializerService : CCIFGMMGDFO, HLFLBAHBAHA, global::DMNMALFOODJ<HLFLBAHBAHA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, OCMDAIJBDBA> BMJINKLIJOB;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool DOBPGBHLILJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x84C980", Offset = "0x84B780", VA = "0x18084C980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x98CF70", Offset = "0x98BD70", VA = "0x18098CF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x992DB0", Offset = "0x991BB0", VA = "0x180992DB0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x992CF0", Offset = "0x991AF0", VA = "0x180992CF0")]
		public TypeSerializerService(Dictionary<Type, OCMDAIJBDBA> BMJINKLIJOB, bool NCKKELNDHPH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x992A40", Offset = "0x991840", VA = "0x180992A40", Slot = "4")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x992B80", Offset = "0x991980", VA = "0x180992B80", Slot = "5")]
		public void OBNDPKOJMJJ(Type LAKBKKJKBPK, OCMDAIJBDBA KKCANAGMCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x992960", Offset = "0x991760", VA = "0x180992960", Slot = "6")]
		public bool GBLHCMBLLEL(Type LAKBKKJKBPK, out OCMDAIJBDBA KKCANAGMCIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x992AA0", Offset = "0x9918A0", VA = "0x180992AA0", Slot = "7")]
		public HLFLBAHBAHA MICLOCMPGIE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[HLJOGLEHOLC(typeof(MMIJODCFOAG), new string[] { })]
internal sealed class KNNMPGANNIE : MMIJODCFOAG, CCIFGMMGDFO, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<INOPGIMBOKC, GNBADFBHCAL> HCIDODAEIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private LLLCOEENCOL DPFFDAKDAHJ;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xA358B0", Offset = "0xA346B0", VA = "0x180A358B0", Slot = "6")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0xA35850", Offset = "0xA34650", VA = "0x180A35850", Slot = "7")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0xA35A90", Offset = "0xA34890", VA = "0x180A35A90", Slot = "4")]
	public void OBNDPKOJMJJ(INOPGIMBOKC JFGKEENDEHE, Type ANCHLJBGAMM, GNBADFBHCAL IDHDIEACLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0xA357E0", Offset = "0xA345E0", VA = "0x180A357E0", Slot = "5")]
	public bool AONMMLEPGBE(INOPGIMBOKC JFGKEENDEHE, out GNBADFBHCAL IDHDIEACLFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0xA35900", Offset = "0xA34700", VA = "0x180A35900")]
	[Conditional("DEBUG_BUILD")]
	private void GFGNLFPDPPF(INOPGIMBOKC JFGKEENDEHE, Type ANCHLJBGAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0xA35B00", Offset = "0xA34900", VA = "0x180A35B00")]
	public KNNMPGANNIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[HLJOGLEHOLC(typeof(JMKNCNLLHKA), new string[] { })]
internal sealed class BFHIKFABKGM : JMKNCNLLHKA, MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly NNCPAGLOMLA NGMFHGDPEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<IJJNJPIJDOH, int> JPAEIELFKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> HFJPOABLBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[AGIJCBMCMGO]
	private LLLCOEENCOL DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[AGIJCBMCMGO]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int BMCEFLNKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x8F7900", Offset = "0x8F6700", VA = "0x1808F7900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool EEONKLFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BC0", Offset = "0x6CF9C0", VA = "0x1806D0BC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BF0", Offset = "0x6CF9F0", VA = "0x1806D0BF0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x8F7480", Offset = "0x8F6280", VA = "0x1808F7480", Slot = "6")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x8F7400", Offset = "0x8F6200", VA = "0x1808F7400", Slot = "7")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x8F7630", Offset = "0x8F6430", VA = "0x1808F7630", Slot = "8")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6390", VA = "0x1808F7590")]
	private void EAMJNLJJAJE(LEDHMIGLCGN NFBLCBCBMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x8F7950", Offset = "0x8F6750", VA = "0x1808F7950", Slot = "4")]
	public bool OPMOPLPFMCH(IJJNJPIJDOH OJMDJGIIFAA, INOPGIMBOKC JHGILNGJHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x8F76E0", Offset = "0x8F64E0", VA = "0x1808F76E0", Slot = "5")]
	public void KGLDBFFHBJG(IJJNJPIJDOH OJMDJGIIFAA, Span<INOPGIMBOKC> DPFFDAKDAHJ, bool LHNCOHGAFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x8F7480", Offset = "0x8F6280", VA = "0x1808F7480", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x8F7A10", Offset = "0x8F6810", VA = "0x1808F7A10")]
	public BFHIKFABKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class OAHDJLOLDLD
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x8ACC50", Offset = "0x8ABA50", VA = "0x1808ACC50")]
	public static void KDNMMJFJFNJ(this FNGPCDCOHDD MGAEFPBCPOK, ReadOnlyMemory<byte> FIJDJHELEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x3686C00", Offset = "0x3685A00", VA = "0x183686C00")]
	public static void DELGLDDNCCO<T>(this FNGPCDCOHDD MGAEFPBCPOK, in T DPJGMDFEIDL) where T : struct, JMHCOOOCIFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x3686D30", Offset = "0x3685B30", VA = "0x183686D30")]
	public static T MMBGIBLAGEC<T>(this FNGPCDCOHDD MGAEFPBCPOK) where T : struct, JMHCOOOCIFG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AC950", Offset = "0x8AB750", VA = "0x1808AC950")]
	public static void DELGLDDNCCO(this FNGPCDCOHDD MGAEFPBCPOK, JHMJHCGLGMO HELDONCPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8ACCD0", Offset = "0x8ABAD0", VA = "0x1808ACCD0")]
	public static JHMJHCGLGMO POLDGMGEDOI(this FNGPCDCOHDD MGAEFPBCPOK)
	{
		return default(JHMJHCGLGMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8AC980", Offset = "0x8AB780", VA = "0x1808AC980")]
	public static void IOFHLMNBLMP(this FNGPCDCOHDD LKPFOEGOGPJ, uint PEDGMOHJCKA, bool AIDPDJBPCNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8ACB30", Offset = "0x8AB930", VA = "0x1808ACB30")]
	public static uint JLIJDPPDJMJ(this FNGPCDCOHDD DFCMBLHIHLK, bool AIDPDJBPCNO = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class AKELLJAIJGN
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class OOCLAJKDBNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public OOCLAJKDBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x326C810", Offset = "0x326B610", VA = "0x18326C810")]
		internal void <GetByteEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x326C880", Offset = "0x326B680", VA = "0x18326C880")]
		internal T <GetByteEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class CDGJEIGGPAK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public CDGJEIGGPAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x38AC330", Offset = "0x38AB130", VA = "0x1838AC330")]
		internal void <GetSByteEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x38AC3A0", Offset = "0x38AB1A0", VA = "0x1838AC3A0")]
		internal T <GetSByteEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class OMOCPFHBGHL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public OMOCPFHBGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3266D20", Offset = "0x3265B20", VA = "0x183266D20")]
		internal void <GetShortEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3266D90", Offset = "0x3265B90", VA = "0x183266D90")]
		internal T <GetShortEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class JGBNOFEILCP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public JGBNOFEILCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA700", Offset = "0x3AF9500", VA = "0x183AFA700")]
		internal void <GetUShortEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA770", Offset = "0x3AF9570", VA = "0x183AFA770")]
		internal T <GetUShortEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class APHCCJEMOBN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public APHCCJEMOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x42DAE50", Offset = "0x42D9C50", VA = "0x1842DAE50")]
		internal void <GetIntEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x42DAEB0", Offset = "0x42D9CB0", VA = "0x1842DAEB0")]
		internal T <GetIntEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class JLIPPMMCFMJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public JLIPPMMCFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x36FFEB0", Offset = "0x36FECB0", VA = "0x1836FFEB0")]
		internal void <GetUIntEnumDelegates>b__0(FNGPCDCOHDD b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x36FFF10", Offset = "0x36FED10", VA = "0x1836FFF10")]
		internal T <GetUIntEnumDelegates>b__1(FNGPCDCOHDD b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F800", Offset = "0x2B9E600", VA = "0x182B9F800")]
	public static void FPNMPFOMKDK<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x43170E0", Offset = "0x4315EE0", VA = "0x1843170E0")]
	private static void GENMNBDBFIH<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x43170E0", Offset = "0x4315EE0", VA = "0x1843170E0")]
	private static void NCGOLEMGFEP<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F6B0", Offset = "0x2B9E4B0", VA = "0x182B9F6B0")]
	private static void NMMOFDAEKIC<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F6B0", Offset = "0x2B9E4B0", VA = "0x182B9F6B0")]
	private static void EBHFGMFKMGJ<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x4317230", Offset = "0x4316030", VA = "0x184317230")]
	private static void KOHNMFJNOHC<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x4317230", Offset = "0x4316030", VA = "0x184317230")]
	private static void LAHMBEIIGCA<T>(T CDJGLGILJHJ, T KIDJEKPKJJM, out global::NGCIFGFGBMN<T> HGJEAGOALJM, out global::OKDAGFHIFMF<T> ALKGFNBHOMJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class NFOMGOBFLHE : FPPGDBCGJNK, DOKJEHLBPKM
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x8AB420", Offset = "0x8AA220", VA = "0x1808AB420", Slot = "4")]
	private void FOGFDFHOLAE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OOPOGIBDBDL(KMGMGDDJLLK DPFFDAKDAHJ);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
	protected NFOMGOBFLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[IOADNKMGCAK(typeof(LocalPoseData))]
public sealed class HLEDBDNOLHA : NFOMGOBFLHE
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA27BB0", VA = "0x180A28DB0", Slot = "5")]
	protected override void OOPOGIBDBDL(KMGMGDDJLLK DPFFDAKDAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	public HLEDBDNOLHA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class CopyAuthorityToEntity : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery OMGOLDJPFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery MEIECDCGPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery LMPALGLEMAO;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x905DD0", Offset = "0x904BD0", VA = "0x180905DD0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x906900", Offset = "0x905700", VA = "0x180906900", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x906A80", Offset = "0x905880", VA = "0x180906A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x906A50", Offset = "0x905850", VA = "0x180906A50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x905F20", Offset = "0x904D20", VA = "0x180905F20")]
		private void FCNNOKECOJB(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x905C30", Offset = "0x904A30", VA = "0x180905C30")]
		private void ADELEEHFJDO(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x906620", Offset = "0x905420", VA = "0x180906620")]
		private void OLEHICLBEND(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x906470", Offset = "0x905270", VA = "0x180906470")]
		private void IKHDIGNFIOG(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x906260", Offset = "0x905060", VA = "0x180906260")]
		private void FHKOFGCIOCM(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x905E40", Offset = "0x904C40", VA = "0x180905E40")]
		private void EBGHDBMDHKM(LEDHMIGLCGN NFBLCBCBMID, int BBBGEOBCIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class OFOBAGFNACE : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AEBA0", Offset = "0x8AD9A0", VA = "0x1808AEBA0", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1D0", Offset = "0x8ADFD0", VA = "0x1808AF1D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8AF290", Offset = "0x8AE090", VA = "0x1808AF290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x8AEBF0", Offset = "0x8AD9F0", VA = "0x1808AEBF0")]
	private void JCANKFBAOBO(NativeArray<Entity> JFFJECJPHEB, NativeList<Entity> CBFHGBBDIIK, ComponentDataFromEntity<ILLOKJDLMAE> GALODGKMIKP, BufferFromEntity<ChildrenData> ELJCILIBOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public OFOBAGFNACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class BEKOPKBOGFC : ParentSystemBase<AuthoredParentData, APCABMHFOCF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x8F71C0", Offset = "0x8F5FC0", VA = "0x1808F71C0", Slot = "14")]
	protected override EntityQueryDesc NGMFHEEEJCL(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE30", Offset = "0x6E9C30", VA = "0x1806EAE30", Slot = "15")]
	protected override EntityQueryDesc MAKMOEOPAAL(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x8F7180", Offset = "0x8F5F80", VA = "0x1808F7180", Slot = "16")]
	protected override EntityQueryDesc CPIMKBICELG(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8F7200", Offset = "0x8F6000", VA = "0x1808F7200", Slot = "17")]
	protected override EntityQueryDesc NLBFGADAFCC(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8F7280", Offset = "0x8F6080", VA = "0x1808F7280")]
	public BEKOPKBOGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8F7240", Offset = "0x8F6040", VA = "0x1808F7240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class OOPLMIPAOPB : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object HLKKIPGLBHI;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8B1710", Offset = "0x8B0510", VA = "0x1808B1710", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x8B1790", Offset = "0x8B0590", VA = "0x1808B1790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1830", Offset = "0x8B0630", VA = "0x1808B1830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public OOPLMIPAOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class CKELCCGIIDJ : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object HLKKIPGLBHI;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC150", Offset = "0x8FAF50", VA = "0x1808FC150", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1D0", Offset = "0x8FAFD0", VA = "0x1808FC1D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8FC270", Offset = "0x8FB070", VA = "0x1808FC270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public CKELCCGIIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct GDNBLEGPHJF : ISystemStateBufferElementData, IBufferElementData, IEquatable<GDNBLEGPHJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public FKENHAIEPLC ODABKCNLMCP;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0xA210A0", Offset = "0xA1FEA0", VA = "0x180A210A0", Slot = "4")]
	public bool Equals(GDNBLEGPHJF BNIMMCIKNIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static GDNBLEGPHJF LJJFBFNEMCH(FKENHAIEPLC ODABKCNLMCP)
	{
		return default(GDNBLEGPHJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct MKCJPOLHIHE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public FKENHAIEPLC ODABKCNLMCP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static MKCJPOLHIHE LJJFBFNEMCH(FKENHAIEPLC ODABKCNLMCP)
	{
		return default(MKCJPOLHIHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class IKDLANIBALJ : AIIPFAKFGIB
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xA2EE40", Offset = "0xA2DC40", VA = "0x180A2EE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0xA2EFD0", Offset = "0xA2DDD0", VA = "0x180A2EFD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7E0", Offset = "0x8AB5E0", VA = "0x1808AC7E0")]
	protected IKDLANIBALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[JNIBKDHCHEO]
internal abstract class AIIPFAKFGIB : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected HKGBKCLENBH AKAFHJJKOBE;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x8F2F40", Offset = "0x8F1D40", VA = "0x1808F2F40", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8F32A0", Offset = "0x8F20A0", VA = "0x1808F32A0")]
	protected void MHMFDMMFLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8F2FB0", Offset = "0x8F1DB0", VA = "0x1808F2FB0")]
	protected void HFCHGDCOCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3230", Offset = "0x8F2030", VA = "0x1808F3230")]
	protected CNNILEPOHAI MGIFCDBFEED()
	{
		return default(CNNILEPOHAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	protected AIIPFAKFGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class AAOAINEHJFM : AIIPFAKFGIB
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8F1100", Offset = "0x8EFF00", VA = "0x1808F1100", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8F1290", Offset = "0x8F0090", VA = "0x1808F1290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	protected AAOAINEHJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class NOBPOBHMKGO : AIIPFAKFGIB
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x8AC640", Offset = "0x8AB440", VA = "0x1808AC640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8AC750", Offset = "0x8AB550", VA = "0x1808AC750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7E0", Offset = "0x8AB5E0", VA = "0x1808AC7E0")]
	protected NOBPOBHMKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class PMDMAFHFGPH : IKDLANIBALJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF50", Offset = "0x8BED50", VA = "0x1808BFF50", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6E0", Offset = "0x8AA4E0", VA = "0x1808AB6E0")]
	public PMDMAFHFGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class DCKCPFGLDOP : AAOAINEHJFM
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x90B220", Offset = "0x90A020", VA = "0x18090B220", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public DCKCPFGLDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class PHGAKMKMPGC : NOBPOBHMKGO
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x8BF260", Offset = "0x8BE060", VA = "0x1808BF260", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7E0", Offset = "0x8AB5E0", VA = "0x1808AC7E0")]
	public PHGAKMKMPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class NMGMNMBBBBJ : IKDLANIBALJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8AB670", Offset = "0x8AA470", VA = "0x1808AB670", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6E0", Offset = "0x8AA4E0", VA = "0x1808AB6E0")]
	public NMGMNMBBBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class CKCMDDLKLMN : AAOAINEHJFM
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8FC0E0", Offset = "0x8FAEE0", VA = "0x1808FC0E0", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public CKCMDDLKLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class DBNPFBEPFEH : NOBPOBHMKGO
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override MCHPJOCJOKO GJDEGOPBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x90A350", Offset = "0x909150", VA = "0x18090A350", Slot = "15")]
		get
		{
			return default(MCHPJOCJOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6E0", Offset = "0x8AA4E0", VA = "0x1808AB6E0")]
	public DBNPFBEPFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct HHCHJPCHGLF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct FIGPIKKACEJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct NIFFBPNOOGA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct MCHPJOCJOKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType GHJIGOBEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType ANJMFOLHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object DPODOOAHECI;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0xA39D00", Offset = "0xA38B00", VA = "0x180A39D00")]
	public MCHPJOCJOKO(ComponentType GHJIGOBEMGM, ComponentType ANJMFOLHICF, object DPODOOAHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x365B180", Offset = "0x3659F80", VA = "0x18365B180")]
	public static MCHPJOCJOKO EEILILFBJJA<TReq, TTag>(object DPODOOAHECI)
	{
		return default(MCHPJOCJOKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class IHKBBHPIPKI
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string OKJGICJCIMJ = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string PLFJJHIPFMM = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly MCHPJOCJOKO HBNMIGBPLJD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly MCHPJOCJOKO ECHCHBFICAI;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct FKENHAIEPLC : global::DPOFMDICJLA<FKENHAIEPLC>, GHFDCEBDMDI, IEquatable<FKENHAIEPLC>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int NCHPHHOHCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int NPFJJNLPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xA210F0", Offset = "0xA1FEF0", VA = "0x180A210F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0xA210A0", Offset = "0xA1FEA0", VA = "0x180A210A0", Slot = "8")]
	public bool Equals(FKENHAIEPLC BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0xA21130", Offset = "0xA1FF30", VA = "0x180A21130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[JNIBKDHCHEO]
	[KNPMBINOPIG(MLNJOBCAIAM.Connectables)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class UpdateConnectableVisuals : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct KLDHEOHEGJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public FKENHAIEPLC ODABKCNLMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 PGEIGNJBBKG;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x11AF6C0", Offset = "0x11AE4C0", VA = "0x1811AF6C0")]
			public KLDHEOHEGJJ(FKENHAIEPLC ODABKCNLMCP, float3 PGEIGNJBBKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x11AF6A0", Offset = "0x11AE4A0", VA = "0x1811AF6A0")]
			public void MAEJFMCOHNB(out FKENHAIEPLC ODABKCNLMCP, out float3 PGEIGNJBBKG)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct OADCBMHIAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<KLDHEOHEGJJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
			public OADCBMHIAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<MKCJPOLHIHE> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct CHBGCHBDNIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<KLDHEOHEGJJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
			public CHBGCHBDNIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<GDNBLEGPHJF> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct HIJOMKEJECP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<KLDHEOHEGJJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
			public HIJOMKEJECP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in ACJHHPPCKGJ com, in DynamicBuffer<GDNBLEGPHJF> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MEDKBKOPEGN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct MNBIFHJDAFG
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct IGEHJEMOIGE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JKOMLNJECNG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<MKCJPOLHIHE>.Runtime KCFJAINEHIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LEHFDCKCABM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HOPLPCMLEPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MKCJPOLHIHE> DKKBMAFCJID;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x11B10B0", Offset = "0x11AFEB0", VA = "0x1811B10B0")]
				public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x11B1130", Offset = "0x11AFF30", VA = "0x1811B1130")]
				public IGEHJEMOIGE MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(IGEHJEMOIGE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals KOGEEFEPFML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<KLDHEOHEGJJ> GHOABBJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private MNBIFHJDAFG MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe MNBIFHJDAFG.IGEHJEMOIGE* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x11B0850", Offset = "0x11AF650", VA = "0x1811B0850")]
			internal void CKCONFOJCMG(Entity DNMNICOEECM, WorldPoseData FEGCBJDNCDA, in DynamicBuffer<MKCJPOLHIHE> AJCEDEPGCCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x11B0D60", Offset = "0x11AFB60", VA = "0x1811B0D60", Slot = "5")]
			public void ReadFromDisplayClass(ref OADCBMHIAGP ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x11B0D90", Offset = "0x11AFB90", VA = "0x1811B0D90", Slot = "6")]
			public void WriteToDisplayClass(ref OADCBMHIAGP ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x11B0A90", Offset = "0x11AF890", VA = "0x1811B0A90", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x11B0B70", Offset = "0x11AF970", VA = "0x1811B0B70")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref MNBIFHJDAFG.IGEHJEMOIGE HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x11B0CB0", Offset = "0x11AFAB0", VA = "0x1811B0CB0")]
			public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG, ref OADCBMHIAGP ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x11B0CF0", Offset = "0x11AFAF0", VA = "0x1811B0CF0")]
			public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct FNKEPHEKHJA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct NGPKJBMDGKP
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct HBIIGCAAIJL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JKOMLNJECNG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<GDNBLEGPHJF>.Runtime KCFJAINEHIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HOPLPCMLEPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<GDNBLEGPHJF> DKKBMAFCJID;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x11B1C90", Offset = "0x11B0A90", VA = "0x1811B1C90")]
				public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x11B1D00", Offset = "0x11B0B00", VA = "0x1811B1D00")]
				public HBIIGCAAIJL MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(HBIIGCAAIJL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<KLDHEOHEGJJ> GHOABBJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private NGPKJBMDGKP MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NGPKJBMDGKP.HBIIGCAAIJL* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x11AD800", Offset = "0x11AC600", VA = "0x1811AD800")]
			internal void CKCONFOJCMG(in WorldPoseData FEGCBJDNCDA, in DynamicBuffer<GDNBLEGPHJF> AJCEDEPGCCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x980620", Offset = "0x97F420", VA = "0x180980620", Slot = "5")]
			public void ReadFromDisplayClass(ref CHBGCHBDNIP ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x11AD910", Offset = "0x11AC710", VA = "0x1811AD910", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x11AD9E0", Offset = "0x11AC7E0", VA = "0x1811AD9E0")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref NGPKJBMDGKP.HBIIGCAAIJL HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x11ADAB0", Offset = "0x11AC8B0", VA = "0x1811ADAB0")]
			public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG, ref CHBGCHBDNIP ALHINGPEGEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct JNOENOPIDAK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct PELDPBJIENH
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct AEEMHGKJEEG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JKOMLNJECNG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ACJHHPPCKGJ>.Runtime FMKHBELDCBD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<GDNBLEGPHJF>.Runtime KCFJAINEHIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HOPLPCMLEPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<ACJHHPPCKGJ> ALLBGBDPADP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<GDNBLEGPHJF> DKKBMAFCJID;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x11B2850", Offset = "0x11B1650", VA = "0x1811B2850")]
				public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x11B28E0", Offset = "0x11B16E0", VA = "0x1811B28E0")]
				public AEEMHGKJEEG MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(AEEMHGKJEEG);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<KLDHEOHEGJJ> GHOABBJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private PELDPBJIENH MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PELDPBJIENH.AEEMHGKJEEG* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x11AE900", Offset = "0x11AD700", VA = "0x1811AE900")]
			internal void CKCONFOJCMG(in WorldPoseData FEGCBJDNCDA, in ACJHHPPCKGJ ODHELJAHLLA, in DynamicBuffer<GDNBLEGPHJF> AJCEDEPGCCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x980620", Offset = "0x97F420", VA = "0x180980620", Slot = "5")]
			public void ReadFromDisplayClass(ref HIJOMKEJECP ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x11AEA60", Offset = "0x11AD860", VA = "0x1811AEA60", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x11AEAE0", Offset = "0x11AD8E0", VA = "0x1811AEAE0")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref PELDPBJIENH.AEEMHGKJEEG HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x11AEC00", Offset = "0x11ADA00", VA = "0x1811AEC00")]
			public void MMEBNFEOLLL(UpdateConnectableVisuals OBDAFEBCIMG, ref HIJOMKEJECP ALHINGPEGEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery FHDDMONJBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery JHJDCEMKNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery GDJHFKDCCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery DNKADEMOAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery NNDEPDIOIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery JJAPNOADLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery IANHGMKDACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery PKFBBJLNDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery BKJBANDGMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery FNLBDKJMBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::PNLCOEEFLCB<FKENHAIEPLC, OEGOLGMLKMD> DGICLFGDOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private JEIJICDMMNL IKPDHLCKJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private EJHGJPDMMNM BJBHFOGLCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private MPIPGJLANDB KCDGPGBEJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery NEPHMHLLDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker FNCOKMBOPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery PJHOOOAMIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery IJBBPDLLMJJ;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int EKAGFOMELON
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x993CA0", Offset = "0x992AA0", VA = "0x180993CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x996910", Offset = "0x995710", VA = "0x180996910")]
		internal OEGOLGMLKMD MHLOBKACEJP(FKENHAIEPLC ODABKCNLMCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x993A90", Offset = "0x992890", VA = "0x180993A90", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x997280", Offset = "0x996080", VA = "0x180997280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x997500", Offset = "0x996300", VA = "0x180997500", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x997690", Offset = "0x996490", VA = "0x180997690", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x9974C0", Offset = "0x9962C0", VA = "0x1809974C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x9940A0", Offset = "0x992EA0", VA = "0x1809940A0")]
		private void CGHGACIAFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x993B50", Offset = "0x992950", VA = "0x180993B50")]
		private void BLEOFFPHJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x995790", Offset = "0x994590", VA = "0x180995790")]
		private void HPGKFLDPGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x9976D0", Offset = "0x9964D0", VA = "0x1809976D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x996360", Offset = "0x995160", VA = "0x180996360")]
		private void KMEGEMCDFBL(EntityQuery OMGOLDJPFLM, EntityQuery JCMJBHPHNGA, EntityQuery MEIECDCGPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x997800", Offset = "0x996600", VA = "0x180997800")]
		private void PPEAGPDBOCM(EntityQuery MEIECDCGPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x995FF0", Offset = "0x994DF0", VA = "0x180995FF0")]
		private void JMNIPOLHAJM(NativeArrayAsync<Entity> KJFIOGNFILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x9941B0", Offset = "0x992FB0", VA = "0x1809941B0")]
		private void DCBGPBENDDD(NativeArrayAsync<Entity> DGEODAMHOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x996CF0", Offset = "0x995AF0", VA = "0x180996CF0")]
		private void OHPGPMFNCLL(NativeArrayAsync<Entity> ODKIEMAMFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x994A90", Offset = "0x993890", VA = "0x180994A90")]
		private void FFICCHCEBAH(NativeList<FKENHAIEPLC> KLICBBFIBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x994D40", Offset = "0x993B40", VA = "0x180994D40")]
		private NativeList<FKENHAIEPLC> HCBJJBBNCGO(NativeArray<Entity> JFFJECJPHEB)
		{
			return default(NativeList<FKENHAIEPLC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x993410", Offset = "0x992210", VA = "0x180993410")]
		private void AECEOKPIJEP(NativeArray<Entity> JFFJECJPHEB, NativeList<FKENHAIEPLC> KLICBBFIBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x995260", Offset = "0x994060", VA = "0x180995260")]
		private void HHLKMOFJDGB(NativeArray<Entity> GBEAOHLLCFK, NativeArray<Entity> PDOGICHKGCO, NativeList<FKENHAIEPLC> HFJPOABLBHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x995B40", Offset = "0x994940", VA = "0x180995B40")]
		private void JHOJOIOHBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x994C00", Offset = "0x993A00", VA = "0x180994C00")]
		private NativeListAsync<KLDHEOHEGJJ> GEKHNBIAPON(EntityQuery EFCFIFNMPEK, Func<NativeList<KLDHEOHEGJJ>, JobHandle> POMDLKMCHCJ)
		{
			return default(NativeListAsync<KLDHEOHEGJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x996960", Offset = "0x995760", VA = "0x180996960")]
		private JobHandle NBPNEPNMHJD(NativeList<KLDHEOHEGJJ> GHOABBJLFEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x994950", Offset = "0x993750", VA = "0x180994950")]
		private JobHandle FFCNPPLKKFC(NativeList<KLDHEOHEGJJ> GHOABBJLFEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x993CE0", Offset = "0x992AE0", VA = "0x180993CE0")]
		private JobHandle BPOKHAELLHI(NativeList<KLDHEOHEGJJ> GHOABBJLFEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995C90", VA = "0x180996E90")]
		private void OPPGPJPKECG(NativeListAsync<KLDHEOHEGJJ> GHOABBJLFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x993E10", Offset = "0x992C10", VA = "0x180993E10")]
		private void CAPKHMFIDHI(NativeListAsync<KLDHEOHEGJJ> GHOABBJLFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x993A30", Offset = "0x992830", VA = "0x180993A30")]
		private bool BEKIHCGDEAC(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x996840", Offset = "0x995640", VA = "0x180996840")]
		private NativeArray<Entity> LNIFPPMNJKJ(Entity DNMNICOEECM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x994520", Offset = "0x993320", VA = "0x180994520")]
		private FKENHAIEPLC DJIJINBPFPP(NativeList<FKENHAIEPLC> HFJPOABLBHM)
		{
			return default(FKENHAIEPLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x9962D0", Offset = "0x9950D0", VA = "0x1809962D0")]
		private void JNOKBPLDJCO(FKENHAIEPLC ODABKCNLMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x997120", Offset = "0x995F20", VA = "0x180997120", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x9958F0", VA = "0x180996AF0")]
		public static EntityQuery NIGNHIHNMHE(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x9942C0", Offset = "0x9930C0", VA = "0x1809942C0")]
		public static EntityQuery DGNCBAHPPDG(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x9946E0", Offset = "0x9934E0", VA = "0x1809946E0")]
		public static EntityQuery EGLGKBGGGFC(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[KNPMBINOPIG(MLNJOBCAIAM.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private OJCNMNJFNCK DELEODDAJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private FLAHBDFKAEI CHELNEDMJKC;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5370", Offset = "0x8C4170", VA = "0x1808C5370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x8C52E0", Offset = "0x8C40E0", VA = "0x1808C52E0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5470", Offset = "0x8C4270", VA = "0x1808C5470", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class OJPILKNNNPB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public EBIEHGPCOMI EAFONAFODFI;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OJPILKNNNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
	public OJPILKNNNPB(EBIEHGPCOMI EAFONAFODFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9A0", Offset = "0x8AE7A0", VA = "0x1808AF9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class KILPKLLNCBD : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService CFFMBLMAMOD;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0xA34E10", Offset = "0xA33C10", VA = "0x180A34E10", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0xA34E70", Offset = "0xA33C70", VA = "0x180A34E70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0xA34EA0", Offset = "0xA33CA0", VA = "0x180A34EA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	protected KILPKLLNCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class KNNCNELHKGA : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery HBFDFGOCANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery ABNDMIMBHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery LHOMMNLNJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery PNLGAPJCDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService HCGOEBONMMN;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int OPEPNFGMHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA353E0", Offset = "0xA341E0", VA = "0x180A353E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int FKOFPEADGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xA35050", Offset = "0xA33E50", VA = "0x180A35050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xA34F60", Offset = "0xA33D60", VA = "0x180A34F60", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0xA355C0", Offset = "0xA343C0", VA = "0x180A355C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0xA357C0", Offset = "0xA345C0", VA = "0x180A357C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0xA35300", Offset = "0xA34100", VA = "0x180A35300")]
	public int HGNMOBEIPIH(SceneTag LICHDNGOEKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0xA350C0", Offset = "0xA33EC0", VA = "0x180A350C0")]
	public int FOOJIFAAONM(SceneTag LICHDNGOEKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0xA350E0", Offset = "0xA33EE0", VA = "0x180A350E0")]
	protected void HFLJGGGAKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0xA353F0", Offset = "0xA341F0", VA = "0x180A353F0")]
	protected void OAOCNHFMOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0xA35320", Offset = "0xA34120", VA = "0x180A35320")]
	public NativeArrayAsync<Entity> HKDOMLEKLOP(SceneTag LICHDNGOEKH, Allocator CMCENMLGNBG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0xA35570", Offset = "0xA34370", VA = "0x180A35570")]
	public NativeArrayAsync<Entity> OOCFGNGEALC(SceneTag LICHDNGOEKH, Allocator CMCENMLGNBG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0xA34FC0", Offset = "0xA33DC0", VA = "0x180A34FC0")]
	public bool CPNHDBOGFLJ(SceneTag LICHDNGOEKH, out NativeArrayAsync<Entity> EAFONAFODFI, Allocator CMCENMLGNBG = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00")]
	public bool BEGPOELPKJE(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0xA35500", Offset = "0xA34300", VA = "0x180A35500")]
	public EBIEHGPCOMI OHEECAFKGDO(Entity DNMNICOEECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0xA35370", Offset = "0xA34170", VA = "0x180A35370")]
	public bool JOBPINEJIPE(Entity DNMNICOEECM, out OJPILKNNNPB EAFONAFODFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0xA34EC0", Offset = "0xA33CC0", VA = "0x180A34EC0")]
	public void AHAAFILLENI(Entity DNMNICOEECM, OJPILKNNNPB EAFONAFODFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33E60", VA = "0x180A35060")]
	public bool EGLNMOJFAKJ(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LJAEPMKNGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public KNNCNELHKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class JHDFJGFCANN : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery PKJCKHHIDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private CCMKEKPGHLC IDFDCEEBKGN;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0xA31700", Offset = "0xA30500", VA = "0x180A31700", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0xA317C0", Offset = "0xA305C0", VA = "0x180A317C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0xA31880", Offset = "0xA30680", VA = "0x180A31880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x321B090", Offset = "0x3219E90", VA = "0x18321B090")]
	private bool BCFBHLAHOKF<TComponentData>(EntityQuery EFCFIFNMPEK, out NativeArray<Entity> JFFJECJPHEB, out NativeArray<TComponentData> IJKOIMBOKCL) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0xA31750", Offset = "0xA30550", VA = "0x180A31750")]
	public EBIEHGPCOMI OHEECAFKGDO(Entity DNMNICOEECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public JHDFJGFCANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[KNPMBINOPIG(MLNJOBCAIAM.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery DFBDFCABDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery AIONELCLJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery BKCGLPOBKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery LMPALGLEMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x988790", Offset = "0x987590", VA = "0x180988790", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x988850", Offset = "0x987650", VA = "0x180988850", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x988A80", Offset = "0x987880", VA = "0x180988A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x9887E0", Offset = "0x9875E0", VA = "0x1809887E0")]
		private void EKGLGHAFJEH(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x988F10", Offset = "0x987D10", VA = "0x180988F10")]
		private void PPEAGPDBOCM(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x988A10", Offset = "0x987810", VA = "0x180988A10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x988BB0", Offset = "0x9879B0", VA = "0x180988BB0")]
		private void PKGAAPNFGHE(EntityQuery EFCFIFNMPEK, bool MLLDIDGDNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class HLAGGGFGMEO : KDFOLIPKNOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct DNICCOGPFND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public DNICCOGPFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct DCEINALGCAI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct PBNBPJIHPDM
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct MLEFNBNOJLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BCIPLAMGNMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime LJPMFGMBCGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime NJAEKAINFPM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity DMNFBMPFCKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> DOBFBEJPFMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> CMIODPPKOKG;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x11B2710", Offset = "0x11B1510", VA = "0x1811B2710")]
			public void MMEBNFEOLLL(HLAGGGFGMEO OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x11B2790", Offset = "0x11B1590", VA = "0x1811B2790")]
			public MLEFNBNOJLG MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(MLEFNBNOJLG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private PBNBPJIHPDM MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PBNBPJIHPDM.MLEFNBNOJLG* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x11AB2A0", Offset = "0x11AA0A0", VA = "0x1811AB2A0")]
		internal void CKCONFOJCMG(Entity ONOCKEOOJHG, SplineShapeData KNNMPBLOADI, DynamicBuffer<LinkedEntityGroup> NGFFBKNAABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x11AB300", Offset = "0x11AA100", VA = "0x1811AB300", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x11AB3D0", Offset = "0x11AA1D0", VA = "0x1811AB3D0")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref PBNBPJIHPDM.MLEFNBNOJLG HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x11AB4F0", Offset = "0x11AA2F0", VA = "0x1811AB4F0")]
		public void MMEBNFEOLLL(HLAGGGFGMEO OBDAFEBCIMG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PMDPECABFIK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct GNNJAACINDJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct GPJGKIPJBPB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CABBIPGLNIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime MAFLCNCMEAM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity JLLHMMFLJOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> FOPAOEMNIEC;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x11AE3E0", Offset = "0x11AD1E0", VA = "0x1811AE3E0")]
			public void MMEBNFEOLLL(HLAGGGFGMEO OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x11AE440", Offset = "0x11AD240", VA = "0x1811AE440")]
			public GPJGKIPJBPB MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(GPJGKIPJBPB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> BFHFHFDNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private GNNJAACINDJ MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GNNJAACINDJ.GPJGKIPJBPB* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x11B45B0", Offset = "0x11B33B0", VA = "0x1811B45B0")]
		internal void CKCONFOJCMG(Entity PMNFHCBNADA, SplinePointParentData HEONJBCPIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x11B4820", Offset = "0x11B3620", VA = "0x1811B4820", Slot = "5")]
		public void ReadFromDisplayClass(ref DNICCOGPFND ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x11B4640", Offset = "0x11B3440", VA = "0x1811B4640", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x11B46E0", Offset = "0x11B34E0", VA = "0x1811B46E0")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref GNNJAACINDJ.GPJGKIPJBPB HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x11B4790", Offset = "0x11B3590", VA = "0x1811B4790")]
		public void MMEBNFEOLLL(HLAGGGFGMEO OBDAFEBCIMG, ref DNICCOGPFND ALHINGPEGEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery DHDIEECHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery PGGHJJCINKO;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA278C0", VA = "0x180A28AC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0xA28B70", Offset = "0xA27970", VA = "0x180A28B70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public HLAGGGFGMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0xA28820", Offset = "0xA27620", VA = "0x180A28820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0xA28520", Offset = "0xA27320", VA = "0x180A28520")]
	public static EntityQuery ALHHHNPGPNB(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0xA286C0", Offset = "0xA274C0", VA = "0x180A286C0")]
	public static EntityQuery MLCLIDLKBMA(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public sealed class PDEALNCKMJC : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private CCKFACOPIOK DPGNKCLIGHG;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1E0", Offset = "0x8BDFE0", VA = "0x1808BF1E0", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x8BF240", Offset = "0x8BE040", VA = "0x1808BF240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public PDEALNCKMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class IMCFJAOPOLJ : KDFOLIPKNOC, DOKJEHLBPKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct LOCNBEHDLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<KFJMJFAJGPB> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<DHHOEPAHABD> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<KFJMJFAJGPB> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public LOCNBEHDLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, OIFDFEHPCHJ previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__2(Entity entity, OIFDFEHPCHJ previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct FDKOBLFAJEI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct MKEPKANPICB
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct PEPCOCLPLMF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JHOJEDFKHJB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> GEKGIHJFOMA;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x11B0DD0", Offset = "0x11AFBD0", VA = "0x1811B0DD0")]
			public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x11B0E30", Offset = "0x11AFC30", VA = "0x1811B0E30")]
			public PEPCOCLPLMF MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(PEPCOCLPLMF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<KFJMJFAJGPB> PKNFMDNGPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private MKEPKANPICB MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MKEPKANPICB.PEPCOCLPLMF* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x11AD530", Offset = "0x11AC330", VA = "0x1811AD530")]
		internal void CKCONFOJCMG(Entity DNMNICOEECM, ParentData HDIELKAGPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x980620", Offset = "0x97F420", VA = "0x180980620", Slot = "5")]
		public void ReadFromDisplayClass(ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x11AD5B0", Offset = "0x11AC3B0", VA = "0x1811AD5B0", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x11AD650", Offset = "0x11AC450", VA = "0x1811AD650")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref MKEPKANPICB.PEPCOCLPLMF HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x11AD700", Offset = "0x11AC500", VA = "0x1811AD700")]
		public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG, ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct PFJFEIMEHDJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct AFEJENEEAHC
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct MEIOBKHLFBO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JHOJEDFKHJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<OIFDFEHPCHJ>.Runtime KAGNLCMKAMC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> GEKGIHJFOMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<OIFDFEHPCHJ> MPMCEHFELCI;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x11A93C0", Offset = "0x11A81C0", VA = "0x1811A93C0")]
			public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x11A9440", Offset = "0x11A8240", VA = "0x1811A9440")]
			public MEIOBKHLFBO MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(MEIOBKHLFBO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<DHHOEPAHABD> DLGBIBLJAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private AFEJENEEAHC MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AFEJENEEAHC.MEIOBKHLFBO* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x11B29B0", Offset = "0x11B17B0", VA = "0x1811B29B0")]
		internal void CKCONFOJCMG(Entity DNMNICOEECM, ParentData HDIELKAGPFJ, OIFDFEHPCHJ BBBKBKKMKPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x11B2C60", Offset = "0x11B1A60", VA = "0x1811B2C60", Slot = "5")]
		public void ReadFromDisplayClass(ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x11B2A70", Offset = "0x11B1870", VA = "0x1811B2A70", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x11B2B40", Offset = "0x11B1940", VA = "0x1811B2B40")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref AFEJENEEAHC.MEIOBKHLFBO HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x11B2C20", Offset = "0x11B1A20", VA = "0x1811B2C20")]
		public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG, ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct EBFLACMDBCM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct ODGAFLLCMMK
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct KFMKGFDMHKF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<OIFDFEHPCHJ>.Runtime KAGNLCMKAMC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<OIFDFEHPCHJ> MPMCEHFELCI;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x11B23C0", Offset = "0x11B11C0", VA = "0x1811B23C0")]
			public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x11B2420", Offset = "0x11B1220", VA = "0x1811B2420")]
			public KFMKGFDMHKF MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(KFMKGFDMHKF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<KFJMJFAJGPB> PPIHKFKCCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private ODGAFLLCMMK MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ODGAFLLCMMK.KFMKGFDMHKF* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x11ABA10", Offset = "0x11AA810", VA = "0x1811ABA10")]
		internal void CKCONFOJCMG(Entity DNMNICOEECM, OIFDFEHPCHJ BBBKBKKMKPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x11ABC70", Offset = "0x11AAA70", VA = "0x1811ABC70", Slot = "5")]
		public void ReadFromDisplayClass(ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x11ABA90", Offset = "0x11AA890", VA = "0x1811ABA90", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x11ABB30", Offset = "0x11AA930", VA = "0x1811ABB30")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref ODGAFLLCMMK.KFMKGFDMHKF HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x11ABBE0", Offset = "0x11AA9E0", VA = "0x1811ABBE0")]
		public void MMEBNFEOLLL(IMCFJAOPOLJ OBDAFEBCIMG, ref LOCNBEHDLDA ALHINGPEGEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private DBEKECCGIHJ EEGFLDHEACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery IMNPKGAIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery PEFAFGEOIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery BECNOBAAJGG;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0xA303B0", Offset = "0xA2F1B0", VA = "0x180A303B0", Slot = "14")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0xA30950", Offset = "0xA2F750", VA = "0x180A30950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public IMCFJAOPOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0xA308F0", Offset = "0xA2F6F0", VA = "0x180A308F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0xA30490", Offset = "0xA2F290", VA = "0x180A30490")]
	public static EntityQuery MIBNOFDBFBM(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0xA30180", Offset = "0xA2EF80", VA = "0x180A30180")]
	public static EntityQuery DJKAKALJKNK(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0xA306F0", Offset = "0xA2F4F0", VA = "0x180A306F0")]
	public static EntityQuery OJDENIFGOBC(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[KNPMBINOPIG(MLNJOBCAIAM.Connectables)]
	public class InitializeRigidbodyExHierarchy : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private CKCILGDFGNK IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA30C80", Offset = "0xA2FA80", VA = "0x180A30C80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA30C10", Offset = "0xA2FA10", VA = "0x180A30C10", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA30D10", Offset = "0xA2FB10", VA = "0x180A30D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class HGMMNGFDBAD : ParentSystemBase<ParentData, OIFDFEHPCHJ, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0xA26D50", Offset = "0xA25B50", VA = "0x180A26D50", Slot = "14")]
	protected override EntityQueryDesc NGMFHEEEJCL(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE30", Offset = "0x6E9C30", VA = "0x1806EAE30", Slot = "15")]
	protected override EntityQueryDesc MAKMOEOPAAL(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0xA26D10", Offset = "0xA25B10", VA = "0x180A26D10", Slot = "16")]
	protected override EntityQueryDesc CPIMKBICELG(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0xA26D90", Offset = "0xA25B90", VA = "0x180A26D90", Slot = "17")]
	protected override EntityQueryDesc NLBFGADAFCC(EntityQueryDesc EFCFIFNMPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0xA26E10", Offset = "0xA25C10", VA = "0x180A26E10")]
	public HGMMNGFDBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0xA26DD0", Offset = "0xA25BD0", VA = "0x180A26DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : KDFOLIPKNOC where ParentData : struct, IComponentData, ADKCGMMLOFH where PreviousParentData : struct, IComponentData, ADKCGMMLOFH where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, ADKCGMMLOFH
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct CADHIHHHFIN : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter OIILGMMHOAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter EBOOMNNEIMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter GHBLICCCPND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> NJCAIPOBBAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> COGKMBDMBOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType LEEKFOOMKAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint LDJKNPJNGHD;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x442AC80", Offset = "0x4429A80", VA = "0x18442AC80", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct BNHHBAAIMKL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> GHBLICCCPND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EDOHODPNMKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> DOMJFLNIFDP;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x38CD200", Offset = "0x38CC000", VA = "0x1838CD200", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct ABCBHBKFIAG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> OIILGMMHOAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> EBOOMNNEIMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> GHBLICCCPND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> EDOHODPNMKK;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8830", Offset = "0x4CA7630", VA = "0x184CA8830")]
			private int COEDADLMDCI(DynamicBuffer<ChildrenData> PDECCELFEPJ, Entity DNMNICOEECM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8F70", Offset = "0x4CA7D70", VA = "0x184CA8F70")]
			private void GPCECBHGFKC(Entity KICGHGEEADG, DynamicBuffer<ChildrenData> PDECCELFEPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8E40", Offset = "0x4CA7C40", VA = "0x184CA8E40")]
			private void FDNMNLFJGPG(Entity KICGHGEEADG, DynamicBuffer<ChildrenData> PDECCELFEPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8BB0", Offset = "0x4CA79B0", VA = "0x184CA8BB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct BFELPAKKFOB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> DAPNJCOAPCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> ILLDNLANPEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> EDOHODPNMKK;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x43FAF70", Offset = "0x43F9D70", VA = "0x1843FAF70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery ONHCFBOHDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery KLEEIDHKFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery ACFAIFANFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery NAANOFCBJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker HNLLNOMOBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker ILNKJJFHNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker AKCHOCPGPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker HHMMAKDFIFE;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x35C7EC0", Offset = "0x35C6CC0", VA = "0x1835C7EC0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x35C6C40", Offset = "0x35C5A40", VA = "0x1835C6C40")]
		private int COEDADLMDCI(DynamicBuffer<ChildrenData> PDECCELFEPJ, Entity DNMNICOEECM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x35C5EA0", Offset = "0x35C4CA0", VA = "0x1835C5EA0")]
		private void ADGADPJPICE(Entity HMMJIHBOJKI, Entity MIECKMKOJLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE30", Offset = "0x6E9C30", VA = "0x1806EAE30", Slot = "14")]
		protected virtual EntityQueryDesc NGMFHEEEJCL(EntityQueryDesc EFCFIFNMPEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE30", Offset = "0x6E9C30", VA = "0x1806EAE30", Slot = "15")]
		protected virtual EntityQueryDesc MAKMOEOPAAL(EntityQueryDesc EFCFIFNMPEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE30", Offset = "0x6E9C30", VA = "0x1806EAE30", Slot = "16")]
		protected virtual EntityQueryDesc CPIMKBICELG(EntityQueryDesc EFCFIFNMPEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc NLBFGADAFCC(EntityQueryDesc EFCFIFNMPEK);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x35C7B20", Offset = "0x35C6920", VA = "0x1835C7B20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x35C6720", Offset = "0x35C5520", VA = "0x1835C6720")]
		private void AHHNKBPHJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x35C6A80", Offset = "0x35C5880", VA = "0x1835C6A80")]
		private void BNHIOGLNEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x35C7350", Offset = "0x35C6150", VA = "0x1835C7350")]
		private JobHandle HHABINJCIHB(JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x35C6440", Offset = "0x35C5240", VA = "0x1835C6440")]
		private void AHBIDOLKLPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x35C7DF0", Offset = "0x35C6BF0", VA = "0x1835C7DF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x35C7DC0", Offset = "0x35C6BC0", VA = "0x1835C7DC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public abstract class HFNNKIIOFEG : KDFOLIPKNOC, DOKJEHLBPKM
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct MKGIABAFJGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public NativeListAsync<Entity> MOALBJDHMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public NativeListAsync<Entity> HEEEFKODPMD;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x11B0FC0", Offset = "0x11AFDC0", VA = "0x1811B0FC0")]
		public MKGIABAFJGC(NativeList<Entity> MOALBJDHMOE, NativeList<Entity> HEEEFKODPMD, JobHandle HPPHIENCKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x11B0F40", Offset = "0x11AFD40", VA = "0x1811B0F40")]
		public JobHandle JFEGCEOOAIF(JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x11B0EB0", Offset = "0x11AFCB0", VA = "0x1811B0EB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct EKCCNACEDHD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum EBFFJLNNCLC
		{
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[WriteOnly]
		public NativeList<Entity> INGIJDMEEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> MCEEFJOKDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> GGBKFCNJEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> AENFMNHFFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public ComponentDataFromEntity LJHCLDDCEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public ComponentDataFromEntity NFDDAPLONKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> MNCEKIHCMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int HHJLCIEACJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int LMCEIAPNJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private EBFFJLNNCLC IGALBGAIHEG;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x11AC9B0", Offset = "0x11AB7B0", VA = "0x1811AC9B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x11AC920", Offset = "0x11AB720", VA = "0x1811AC920")]
		private void APEONBPMCDD(Entity DNMNICOEECM, bool NOLAAPMLFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x11ACD80", Offset = "0x11ABB80", VA = "0x1811ACD80")]
		private void NDLNOGFEMDP(Entity DNMNICOEECM, bool NOLAAPMLFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x11ACC20", Offset = "0x11ABA20", VA = "0x1811ACC20")]
		public MKGIABAFJGC JPAELEKGOGM(NativeArray<Entity> FAEPHALCHNN, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x11AD0F0", Offset = "0x11ABEF0", VA = "0x1811AD0F0")]
		public MKGIABAFJGC NPODFKKKCIL(NativeArray<Entity> FAEPHALCHNN, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x11AD170", Offset = "0x11ABF70", VA = "0x1811AD170")]
		public MKGIABAFJGC PCLCNBFLBCH(NativeList<KFJMJFAJGPB> GHOABBJLFEA, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x11ACB40", Offset = "0x11AB940", VA = "0x1811ACB40")]
		public MKGIABAFJGC FNPBHOFPMAG(NativeList<KFJMJFAJGPB> GHOABBJLFEA, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x11ACCA0", Offset = "0x11ABAA0", VA = "0x1811ACCA0")]
		public MKGIABAFJGC LEEINAEHNCO(NativeList<DHHOEPAHABD> GHOABBJLFEA, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x4C6E530", Offset = "0x4C6D330", VA = "0x184C6E530")]
		private MKGIABAFJGC NEMIKEMGLIK<T>(NativeList<T> GHOABBJLFEA, int HKHIFMIDLGI, int CHAENGDEIDD, EBFFJLNNCLC LBPMHDKPAGN, JobHandle DGCBHFBCIBP) where T : struct
		{
			return default(MKGIABAFJGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x11ACE90", Offset = "0x11ABC90", VA = "0x1811ACE90")]
		private MKGIABAFJGC NEMIKEMGLIK(NativeArray<Entity> JFFJECJPHEB, int HKHIFMIDLGI, int CHAENGDEIDD, EBFFJLNNCLC LBPMHDKPAGN, JobHandle DGCBHFBCIBP)
		{
			return default(MKGIABAFJGC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery IGHDLCHMLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery AKCPHPPIEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private DBEKECCGIHJ BJEOLPIBILG;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType JDIHNIPHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType NBCBNCJCEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType ILPDEFGBJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0xA26280", Offset = "0xA25080", VA = "0x180A26280")]
	protected HFNNKIIOFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0xA250E0", Offset = "0xA23EE0", VA = "0x180A250E0", Slot = "14")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0xA251C0", Offset = "0xA23FC0", VA = "0x180A251C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0xA25410", Offset = "0xA24210", VA = "0x180A25410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xA253F0", Offset = "0xA241F0", VA = "0x180A253F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0xA25080", Offset = "0xA23E80", VA = "0x180A25080")]
	private void IDPOIDAHCPK(NativeArray<Entity> GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0xA24B40", Offset = "0xA23940", VA = "0x180A24B40")]
	private void BIPOMEPGEJC(NativeArray<Entity> GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0xA24E30", Offset = "0xA23C30", VA = "0x180A24E30")]
	private void GPOMKMELCFE(MKGIABAFJGC OIGDEGAGPKO, string HNBNDOKAOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0xA24F70", Offset = "0xA23D70", VA = "0x180A24F70")]
	private void GPOMKMELCFE(NativeListAsync<Entity> OKDFEIALJDM, string HNBNDOKAOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0xA24BE0", Offset = "0xA239E0", VA = "0x180A24BE0")]
	private void DMBKBIKJCNC(MKGIABAFJGC OIGDEGAGPKO, string HNBNDOKAOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0xA24D20", Offset = "0xA23B20", VA = "0x180A24D20")]
	private void DMBKBIKJCNC(NativeListAsync<Entity> OKDFEIALJDM, string HNBNDOKAOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0xA24AD0", Offset = "0xA238D0", VA = "0x180A24AD0")]
	private bool AFCLNKNGFPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public class HDJPBLBEHKO : KDFOLIPKNOC, KPALCLLIODG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NEJHPBHFNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public HDJPBLBEHKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public NEJHPBHFNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MDNCMBBMNHP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct ICOBLOALCPK
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct LDOIFBNDHCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime JMMAAFMFGLA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MMGDBLPPPOA;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x11AE530", Offset = "0x11AD330", VA = "0x1811AE530")]
			public void MMEBNFEOLLL(HDJPBLBEHKO OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x11AE540", Offset = "0x11AD340", VA = "0x1811AE540")]
			public LDOIFBNDHCP MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(LDOIFBNDHCP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public HDJPBLBEHKO KOGEEFEPFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer BMJOEPBNNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private ICOBLOALCPK MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ICOBLOALCPK.LDOIFBNDHCP* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x11B0510", Offset = "0x11AF310", VA = "0x1811B0510")]
		internal void CKCONFOJCMG(Entity HOJKPDKANGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x11AA920", Offset = "0x11A9720", VA = "0x1811AA920", Slot = "5")]
		public void ReadFromDisplayClass(ref NEJHPBHFNEJ ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x11AA950", Offset = "0x11A9750", VA = "0x1811AA950", Slot = "6")]
		public void WriteToDisplayClass(ref NEJHPBHFNEJ ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x11B0620", Offset = "0x11AF420", VA = "0x1811B0620", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x11B0670", Offset = "0x11AF470", VA = "0x1811B0670")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref ICOBLOALCPK.LDOIFBNDHCP HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x11B06E0", Offset = "0x11AF4E0", VA = "0x1811B06E0")]
		public void MMEBNFEOLLL(HDJPBLBEHKO OBDAFEBCIMG, ref NEJHPBHFNEJ ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x11B0720", Offset = "0x11AF520", VA = "0x1811B0720")]
		public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private NKOGBMNJOAI FNKPAEENBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private IMIJPLGBEGF AAJELFDMDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery HEHODFHILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker ONJMEBBKGHO;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0xA24890", Offset = "0xA23690", VA = "0x180A24890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0xA24580", Offset = "0xA23380", VA = "0x180A24580", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0xA248F0", Offset = "0xA236F0", VA = "0x180A248F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public HDJPBLBEHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA235B0", VA = "0x180A247B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0xA245E0", Offset = "0xA233E0", VA = "0x180A245E0")]
	public static EntityQuery CKPOHELOFJI(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[JNIBKDHCHEO]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public class GIJMADEADEP : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private IMIJPLGBEGF AAJELFDMDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService HAOGFLCGAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0xA235D0", Offset = "0xA223D0", VA = "0x180A235D0", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0xA23640", Offset = "0xA22440", VA = "0x180A23640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0xA236E0", Offset = "0xA224E0", VA = "0x180A236E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public GIJMADEADEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct AKEIDKCGOPF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public GBCGPCOGJKJ ODABKCNLMCP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50")]
	public static AKEIDKCGOPF LJJFBFNEMCH(in GBCGPCOGJKJ BDGGGMDMLJO)
	{
		return default(AKEIDKCGOPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50")]
	public static GBCGPCOGJKJ LJJFBFNEMCH(in AKEIDKCGOPF LEOEAAEGAFG)
	{
		return default(GBCGPCOGJKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class NKOGBMNJOAI : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x8AB480", Offset = "0x8AA280", VA = "0x1808AB480", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	public NKOGBMNJOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public class GAKPGKIDMHO : KDFOLIPKNOC, KPALCLLIODG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct PHEGKBPNOCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public GAKPGKIDMHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public PHEGKBPNOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__0(Entity e, AKEIDKCGOPF ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CJOGKDCCMOL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct BAFHFLMNLLF
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct NJDKMJCOKNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime JMMAAFMFGLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<AKEIDKCGOPF>.Runtime DJGDNDFFHKL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MMGDBLPPPOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<AKEIDKCGOPF> ICIJBGFHEKB;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x11A9770", Offset = "0x11A8570", VA = "0x1811A9770")]
			public void MMEBNFEOLLL(GAKPGKIDMHO OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x11A97D0", Offset = "0x11A85D0", VA = "0x1811A97D0")]
			public NJDKMJCOKNC MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(NJDKMJCOKNC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public GAKPGKIDMHO KOGEEFEPFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer BMJOEPBNNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private BAFHFLMNLLF MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BAFHFLMNLLF.NJDKMJCOKNC* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x11AA5D0", Offset = "0x11A93D0", VA = "0x1811AA5D0")]
		internal void CKCONFOJCMG(Entity HOJKPDKANGJ, AKEIDKCGOPF KHDDPKBHGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x11AA920", Offset = "0x11A9720", VA = "0x1811AA920", Slot = "5")]
		public void ReadFromDisplayClass(ref PHEGKBPNOCH ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x11AA950", Offset = "0x11A9750", VA = "0x1811AA950", Slot = "6")]
		public void WriteToDisplayClass(ref PHEGKBPNOCH ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x11AA6D0", Offset = "0x11A94D0", VA = "0x1811AA6D0", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x11AA770", Offset = "0x11A9570", VA = "0x1811AA770")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref BAFHFLMNLLF.NJDKMJCOKNC HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x11AA820", Offset = "0x11A9620", VA = "0x1811AA820")]
		public void MMEBNFEOLLL(GAKPGKIDMHO OBDAFEBCIMG, ref PHEGKBPNOCH ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x11AA8B0", Offset = "0x11A96B0", VA = "0x1811AA8B0")]
		public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private NKOGBMNJOAI FNKPAEENBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private IMIJPLGBEGF AAJELFDMDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery GOAGPGEBIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker PANLJPINOCP;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0xA22550", Offset = "0xA21350", VA = "0x180A22550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xA22240", Offset = "0xA21040", VA = "0x180A22240", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0xA225B0", Offset = "0xA213B0", VA = "0x180A225B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public GAKPGKIDMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0xA22470", Offset = "0xA21270", VA = "0x180A22470", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0xA222A0", Offset = "0xA210A0", VA = "0x180A222A0")]
	public static EntityQuery HDEDMNJFJJB(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct NKMLKDOOBFP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public CLKHLCOEDFF PFGOIEFLOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, PDIIEEBMKOH> JFFJECJPHEB;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x11B22C0", Offset = "0x11B10C0", VA = "0x1811B22C0")]
			public NKMLKDOOBFP(int DOOAOHCDEFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x11B2240", Offset = "0x11B1040", VA = "0x1811B2240", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct PGEOAAEKBMK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> DLIOBKHNINC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> DHJPKODHFFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KONDOCLNBGP;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x11B2C70", Offset = "0x11B1A70", VA = "0x1811B2C70", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct BEKEFFEIDJG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> DLIOBKHNINC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KONDOCLNBGP;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x11A9850", Offset = "0x11A8650", VA = "0x1811A9850", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private IMIJPLGBEGF AAJELFDMDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery EGCDHCAAPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery BNPILNFLDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery DDNIOOIAKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery JFMDENJGCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery LBPIEGNNGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle MCEDMBCOBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private NKMLKDOOBFP AELFNEGAFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private NKMLKDOOBFP NBBOJPICEON;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x8C19F0", Offset = "0x8C07F0", VA = "0x1808C19F0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x8C23C0", Offset = "0x8C11C0", VA = "0x1808C23C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D40", Offset = "0x8C0B40", VA = "0x1808C1D40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2680", Offset = "0x8C1480", VA = "0x1808C2680", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D80", Offset = "0x8C0B80", VA = "0x1808C1D80")]
		private void HPKOJCNBAAE(EntityQuery EFCFIFNMPEK, out (NativeArrayAsync<AKEIDKCGOPF> handles, NativeArrayAsync<GKLPACFDNKH> bounds) CPLKBCGCHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x8C1EC0", Offset = "0x8C0CC0", VA = "0x1808C1EC0")]
		private void KLICNDLHBAF((NativeArrayAsync<AKEIDKCGOPF> handles, NativeArrayAsync<GKLPACFDNKH> bounds) CPLKBCGCHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D40", Offset = "0x8C0B40", VA = "0x1808C1D40")]
		private void HOCIKAEODMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2120", Offset = "0x8C0F20", VA = "0x1808C2120")]
		private void MCGPCBNLDKB(EntityQuery EFCFIFNMPEK, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<AKEIDKCGOPF> handles) CPLKBCGCHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1A50", Offset = "0x8C0850", VA = "0x1808C1A50")]
		private void FJGPLFCAGLK((NativeArrayAsync<Entity> entities, NativeArrayAsync<AKEIDKCGOPF> handles) CPLKBCGCHAN, NKMLKDOOBFP BNBKCANFBLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x8C2260", Offset = "0x8C1060", VA = "0x1808C2260")]
		private JobHandle OFGHOPMNGJE(NKMLKDOOBFP BNBKCANFBLO, ComponentDataFromEntity<WorldPoseData> DLIOBKHNINC, ComponentDataFromEntity<WorldUniformScaleData> KONDOCLNBGP, ComponentDataFromEntity<WorldDeformableScaleData> DHJPKODHFFI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x8C18C0", Offset = "0x8C06C0", VA = "0x1808C18C0")]
		private JobHandle BFIFMLMAEHF(NKMLKDOOBFP BNBKCANFBLO, ComponentDataFromEntity<WorldPoseData> DLIOBKHNINC, ComponentDataFromEntity<WorldUniformScaleData> KONDOCLNBGP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct DMBCJNENKIK : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[JNIBKDHCHEO]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class SplineLocalBoundsSystem : KDFOLIPKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct MEDEDFIJDBO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> IJIHDPBFEGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> HOBGDEHPMDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<GKLPACFDNKH> ACKFGJACEDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, PDIIEEBMKOH>.ParallelWriter MJHPMPJBKOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HPNANDKHFPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter GCKIAHGHPKD;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x11B0790", Offset = "0x11AF590", VA = "0x1811B0790", Slot = "4")]
			public void Execute(int DJIEOHJNDEK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct ACMLEOKGAKB : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> EHDKBNBIMMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> NGPLDAOGIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> OOPPPKJHMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> FPJFHNGIPHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<GKLPACFDNKH> LOKCCLBFKDJ;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x11A9130", Offset = "0x11A7F30", VA = "0x1811A9130", Slot = "4")]
			public void Execute(int DJIEOHJNDEK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery KIMDIMFHECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery LLJBCCIPMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery KPENIFNELGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery PPAHAOLPKOO;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x98B250", Offset = "0x98A050", VA = "0x18098B250", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x98B460", Offset = "0x98A260", VA = "0x18098B460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x98A980", Offset = "0x989780", VA = "0x18098A980")]
		private JobHandle HAHIFFJAIEC(NativeArrayAsync<Entity> HDCHHDPICKJ, int EOKNLPLGCDF, JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x98AA60", Offset = "0x989860", VA = "0x18098AA60")]
		private JobHandle HAHIFFJAIEC(NativeArray<Entity> LAOPDMFGJMM, int EOKNLPLGCDF, [Optional] JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x98A5D0", Offset = "0x9893D0", VA = "0x18098A5D0")]
		private NativeArrayAsync<Entity> BNIGHMPOMPA(EntityQuery EFCFIFNMPEK)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x98AE00", Offset = "0x989C00", VA = "0x18098AE00")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) JIMNPOAKAII(NativeArrayAsync<Entity> BBNJBJNPJON)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x98AC40", Offset = "0x989A40", VA = "0x18098AC40")]
		private void IAIMCCAGJCC(out NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x98A470", Offset = "0x989270", VA = "0x18098A470")]
		private void AGIHHOMMPHP(NativeList<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x98A500", Offset = "0x989300", VA = "0x18098A500")]
		private void AGIHHOMMPHP(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x98ACD0", Offset = "0x989AD0", VA = "0x18098ACD0")]
		private void IEFBHONIIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void DJCFLGLALBL(int PJPKIMFJDFN, int DKNCGIDPLPM, int KLKCMOCFGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x98A650", Offset = "0x989450", VA = "0x18098A650")]
		private static GKLPACFDNKH EPNGFGMDKHP(NativeArray<Entity> FLMLHEJJNPB, ComponentDataFromEntity<SplinePointPositionData> OOPPPKJHMCP, ComponentDataFromEntity<SplinePointScaleData> FPJFHNGIPHP)
		{
			return default(GKLPACFDNKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct EICKDKEADOI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[JNIBKDHCHEO]
	[KNPMBINOPIG(MLNJOBCAIAM.Lifecycle)]
	public class DestroyLocalObjects : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[AGIJCBMCMGO]
		private ObjectNetworkToLocalMapService JKFEKEAGDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[AGIJCBMCMGO]
		private ObjectLifecycleService EEIMFPOJEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery JENJPFAEFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery CAIOHAHJEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery LMPALGLEMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x90C690", Offset = "0x90B490", VA = "0x18090C690", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x90CB60", Offset = "0x90B960", VA = "0x18090CB60")]
		public bool NBGJBJFPDGG(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x90CC10", Offset = "0x90BA10", VA = "0x18090CC10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x90C960", Offset = "0x90B760", VA = "0x18090C960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x90CD50", Offset = "0x90BB50", VA = "0x18090CD50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x90CD40", Offset = "0x90BB40", VA = "0x18090CD40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x90C960", Offset = "0x90B760", VA = "0x18090C960")]
		private void ELKJAFFAHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x90CAB0", Offset = "0x90B8B0", VA = "0x18090CAB0")]
		private void IFNGOBFKOMK(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x90C820", Offset = "0x90B620", VA = "0x18090C820")]
		private void ECBADIIOHIO(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x90C9A0", Offset = "0x90B7A0", VA = "0x18090C9A0")]
		private void GDOFLAOBACF(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x90C700", Offset = "0x90B500", VA = "0x18090C700")]
		private void CEILNEAKEPA(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static KBNFBDJCELI[] HJKADAODFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private DCOAIDCIDJN PPOEGPFJCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private GNIJOOFEPBL JHCKIPJEKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService KAMEPNPKECB;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB50", Offset = "0xA1D950", VA = "0x180A1EB50", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA1F190", Offset = "0xA1DF90", VA = "0x180A1F190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC00", Offset = "0xA1DA00", VA = "0x180A1EC00")]
		private void HIPEPKHHIII(KBNFBDJCELI FNCGHDAFHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private void EJAABMFJENH(Entity DNMNICOEECM, IJJNJPIJDOH OJMDJGIIFAA, KOFEPFEJINF KDFMDMEBMML, OIALCHKPHOP DOCHMPAIOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[KNPMBINOPIG(MLNJOBCAIAM.Callbacks)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public sealed class PropertyEventCallbacks : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService GEOHFEDENKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService KAMEPNPKECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase FNCGHDAFHII;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C72B0", VA = "0x1808C84B0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C7340", VA = "0x1808C8540", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[KNPMBINOPIG(MLNJOBCAIAM.NetworkSend)]
	internal class TransmitNetworkDataSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private KFMLBIJDEEK DPIALMDBECN;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x9928C0", Offset = "0x9916C0", VA = "0x1809928C0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x992910", Offset = "0x991710", VA = "0x180992910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[JNIBKDHCHEO]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	public class CalculateCullingBandChanges : KDFOLIPKNOC, CCIFGMMGDFO, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct ILOLFKGHNOL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType GFIDEEDFAAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> FPLDOGOAGOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<GNNNKOIJOAL>.ParallelWriter LIKEAPGJPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<DHBDIIJBNKD> KHELCHEGMLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 KMOIJDECCNO;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 MDGOACBEIIP;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 EEKEPMILPJL;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 MBGEDKHFFOC;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x980740", Offset = "0x97F540", VA = "0x180980740", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int GIOMJGMFFMM = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double AJCALDGINDN = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery IBFHOIAPIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery BNLBACNPFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double KDCLMILIBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService EGOJBHOKLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService DNJNINLCKDL;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE720", Offset = "0x8FD520", VA = "0x1808FE720", Slot = "14")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE690", Offset = "0x8FD490", VA = "0x1808FE690", Slot = "15")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAE0", Offset = "0x8FD8E0", VA = "0x1808FEAE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC30", Offset = "0x8FDA30", VA = "0x1808FEC30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE730", Offset = "0x8FD530", VA = "0x1808FE730")]
		private bool GHKBAGPIGIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7A0", Offset = "0x8FD5A0", VA = "0x1808FE7A0")]
		private void MDBFFDJEBMA(EntityQuery EFCFIFNMPEK, float3 LHLAOOLFCFO, string CCEKFDNIAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct GNNNKOIJOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity DNMNICOEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public BEKBBDPNCLI EPJLLOJPHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public BEKBBDPNCLI ABCKFOPNDBL;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService EGOJBHOKLEG;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5200", Offset = "0x8C4000", VA = "0x1808C5200", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5250", Offset = "0x8C4050", VA = "0x1808C5250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[KNPMBINOPIG(MLNJOBCAIAM.Connectables)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class UpdateInertialProperties : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery BPLDGCHBBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private AFNJKGGLFJI EPPGDJHEAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x999380", Offset = "0x998180", VA = "0x180999380", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x9993F0", Offset = "0x9981F0", VA = "0x1809993F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x999480", Offset = "0x998280", VA = "0x180999480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[JNIBKDHCHEO]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DOMPDHDICEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BDNIDAACGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JMKDHPEDCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService KGOLHDEFKIL;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1D500", Offset = "0xA1C300", VA = "0x180A1D500", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2E0", Offset = "0xA1D0E0", VA = "0x180A1E2E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA1E070", Offset = "0xA1CE70", VA = "0x180A1E070")]
		private void MNAFCGNLFNB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GHOABBJLFEA, EntityQueryDesc FOCHBBJHIAB, bool EEJCJBEHHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF30", Offset = "0xA1CD30", VA = "0x180A1DF30")]
		private void MNAFCGNLFNB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GHOABBJLFEA, EntityQueryDesc FOCHBBJHIAB, bool EEJCJBEHHGD, bool CPLPOCHONDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1E540", Offset = "0xA1D340", VA = "0x180A1E540", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1D550", Offset = "0xA1C350", VA = "0x180A1D550")]
		private void CODJFDNLBGF(EntityQuery EFCFIFNMPEK, bool MFCBBJLJBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA1D940", Offset = "0xA1C740", VA = "0x180A1D940")]
		private void GOPEBMLBCCH(EntityQuery EFCFIFNMPEK, bool LAANONPMILJ, bool MFCBBJLJBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1E810", Offset = "0xA1D610", VA = "0x180A1E810")]
		private void PFJLKDJEIKF(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1DDC0", Offset = "0xA1CBC0", VA = "0x180A1DDC0")]
		private void JKGEMGNEDAI(NativeList<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA1E1C0", Offset = "0xA1CFC0", VA = "0x180A1E1C0")]
		private void OLPNLIAANMM(NativeArray<Entity> JFFJECJPHEB, bool LAANONPMILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA1D740", Offset = "0xA1C540", VA = "0x180A1D740")]
		private NativeList<Entity> FHCAANGIEKN(NativeArray<Entity> JFFJECJPHEB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CB80", VA = "0x180A1DD80")]
		private NativeList<Entity> JDEMPLJPBFG(NativeArray<Entity> JFFJECJPHEB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA1E180", Offset = "0xA1CF80", VA = "0x180A1E180")]
		private NativeList<Entity> MPIJCCLEEKI(NativeArray<Entity> JFFJECJPHEB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB50", Offset = "0xA1C950", VA = "0x180A1DB50")]
		private NativeList<Entity> IEANGEKCKPM(NativeArray<Entity> JFFJECJPHEB, bool CHGLBJKLGHC)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA1DCF0", Offset = "0xA1CAF0", VA = "0x180A1DCF0")]
		private FGGKOJBBDBE IFGMBHBHBMK(NativeArray<Entity> JFFJECJPHEB)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(FGGKOJBBDBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA1EA80", Offset = "0xA1D880", VA = "0x180A1EA80")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService KGOLHDEFKIL;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5270", Offset = "0x8C4070", VA = "0x1808C5270", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C52C0", Offset = "0x8C40C0", VA = "0x1808C52C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : CLIEFILLAJL
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery PHJKHAENFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery ALHJFAEHLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery GLJEDAOAMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery FMDHFCFFDMC;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x90C0C0", Offset = "0x90AEC0", VA = "0x18090C0C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x90C280", Offset = "0x90B080", VA = "0x18090C280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x90BE80", Offset = "0x90AC80", VA = "0x18090BE80")]
		private void OKOJCBAHDHB(EntityQuery EFCFIFNMPEK, bool NNCAPEKDMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x90C300", Offset = "0x90B100", VA = "0x18090C300")]
		private void PMCHOAJGDII(EntityQuery EFCFIFNMPEK, bool NNCAPEKDMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class AssignPlayerIdsSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery DGDJHDBDPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery ACOKFFDGGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService BBLHCHIFBMC;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F66C0", Offset = "0x8F54C0", VA = "0x1808F66C0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6C60", Offset = "0x8F5A60", VA = "0x1808F6C60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D70", Offset = "0x8F5B70", VA = "0x1808F6D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F6730", Offset = "0x8F5530", VA = "0x1808F6730")]
		private void CDCLODHKKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F69E0", Offset = "0x8F57E0", VA = "0x1808F69E0")]
		private void LLCGMKCNMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F63A0", Offset = "0x8F51A0", VA = "0x1808F63A0")]
		private void BCAHECMELAM(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F68A0", Offset = "0x8F56A0", VA = "0x1808F68A0")]
		private void KLFCOPJPOLB(NativeArray<Entity> JFFJECJPHEB, int JJMFFKHHNKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x8F6B50", Offset = "0x8F5950", VA = "0x1808F6B50")]
		private void NHOBHKFBGMJ(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F6840", Offset = "0x8F5640", VA = "0x1808F6840")]
		private void IABAJFIIFFB(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void IGHNBMNECMM(int BBBGEOBCIIP, Transform HAFNICDKMAH, Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class POMKKIGLFNO
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0020", Offset = "0x8BEE20", VA = "0x1808C0020")]
	public static bool GJKNHEKHAFM(this SystemBase PFKBGJMLAMC, out Entity DNMNICOEECM)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery APOJIILJAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EJHGJPDMMNM OEELHKGPJPO;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x9005A0", Offset = "0x8FF3A0", VA = "0x1809005A0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x9005F0", Offset = "0x8FF3F0", VA = "0x1809005F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x9006B0", Offset = "0x8FF4B0", VA = "0x1809006B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<BOCHNCFDMIK>, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string FIPKCKPJNHH = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private GFLFGIAIPAA KOHKFLAONNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery CIKBAGIFJGC;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity MCONNBFBNGO
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA39950", Offset = "0xA38750", VA = "0x180A39950")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA39480", Offset = "0xA38280", VA = "0x180A39480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity KBDDHABKHBO
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA398F0", Offset = "0xA386F0", VA = "0x180A398F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public LEDHMIGLCGN BGEFHBDMENE
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0xA39860", Offset = "0xA38660", VA = "0x180A39860")]
			get
			{
				return default(LEDHMIGLCGN);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA39B70", Offset = "0xA38970", VA = "0x180A39B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public LEDHMIGLCGN BNNDCFLADOI
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0xA39BE0", Offset = "0xA389E0", VA = "0x180A39BE0")]
			get
			{
				return default(LEDHMIGLCGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA39A50", Offset = "0xA38850", VA = "0x180A39A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA39290", Offset = "0xA38090", VA = "0x180A39290", Slot = "15")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA39AF0", Offset = "0xA388F0", VA = "0x180A39AF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA39300", Offset = "0xA38100", VA = "0x180A39300", Slot = "14")]
		protected override void CHBPBEDNKEM(NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> GBPPMFBDKIM, NativeArray<Entity> GBFIHJGNJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xA394E0", Offset = "0xA382E0", VA = "0x180A394E0")]
		private void GGNLICKPKLP(NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> GBFIHJGNJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xA395C0", Offset = "0xA383C0", VA = "0x180A395C0")]
		private void GLPCAKHDOAD(Entity DNMNICOEECM, Entity NFFOMLLHMLJ, Entity CDJHCNKOPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x3659660", Offset = "0x3658460", VA = "0x183659660")]
		private bool GBLHCMBLLEL<T>(out T DPJGMDFEIDL) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x36596F0", Offset = "0x36584F0", VA = "0x1836596F0")]
		private void NAKCIOJFCFJ<T>(T DPJGMDFEIDL) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA399B0", Offset = "0xA387B0", VA = "0x180A399B0")]
		public bool MEEOMCFJOLL(LEDHMIGLCGN PIONJNOAFIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA39450", Offset = "0xA38250", VA = "0x180A39450")]
		private static bool DODJENAOPMK(LEDHMIGLCGN IDGPEHBCLAG, LEDHMIGLCGN KJEPLNBIHOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA39CC0", Offset = "0xA38AC0", VA = "0x180A39CC0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA39A10", Offset = "0xA38810", VA = "0x180A39A10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x908980", Offset = "0x907780", VA = "0x180908980", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x908C30", Offset = "0x907A30", VA = "0x180908C30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x908CD0", Offset = "0x907AD0", VA = "0x180908CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x908AE0", Offset = "0x9078E0", VA = "0x180908AE0")]
		private NativeArray<Entity> NBOGNHGJIFB(int KNPCAAMBLKA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x9089D0", Offset = "0x9077D0", VA = "0x1809089D0")]
		private void EPBFCDFJOLE(NativeArray<Entity> DOFBNHGLGIB, NativeArray<Entity> CLJCMNJBJPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	internal class HideRemotePivotsNotInScope : KDFOLIPKNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery POCDCNGBPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery EPMOBOGCFAK;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0xA2AEC0", Offset = "0xA29CC0", VA = "0x180A2AEC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFB0", Offset = "0xA29DB0", VA = "0x180A2AFB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class BDLDGCNCIDE
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string PHHDNELHILK = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x332D6F0", Offset = "0x332C4F0", VA = "0x18332D6F0")]
	public static NativeArray<T> NEMIKEMGLIK<T>(NativeArray<Entity> JFFJECJPHEB, EntityManager ECFOMHOIDDI) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6DE0", Offset = "0x8F5BE0", VA = "0x1808F6DE0")]
	public static void AJEEKDJHBAK(EntityQuery EFCFIFNMPEK, EntityManager ECFOMHOIDDI, NLEJJFIEGLH OONGFKGINCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x8F6F20", Offset = "0x8F5D20", VA = "0x1808F6F20")]
	public static void EPECFJNADOI(NativeArray<Entity> DOFBNHGLGIB, NLEJJFIEGLH OONGFKGINCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x8F7050", Offset = "0x8F5E50", VA = "0x1808F7050")]
	public static void IKHLNAAPGCK(NativeArray<Entity> DOFBNHGLGIB, NLEJJFIEGLH OONGFKGINCK)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService EEIMFPOJEBA;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x998130", Offset = "0x996F30", VA = "0x180998130", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x999280", Offset = "0x998080", VA = "0x180999280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x999320", Offset = "0x998120", VA = "0x180999320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x997920", Offset = "0x996720", VA = "0x180997920")]
		private void AGHHNJFANEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x999170", Offset = "0x997F70", VA = "0x180999170")]
		private void KBKGEFPKEIJ(NativeArray<Entity> DOFBNHGLGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x998650", Offset = "0x997450", VA = "0x180998650")]
		private void INPCNMEMMBC(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x998F20", Offset = "0x997D20", VA = "0x180998F20")]
		private void JLEMBNCDJFE(NativeArray<Entity> CLJCMNJBJPP, NativeArray<RigidTransform> MBAKKPHAKPE, NativeArray<RigidTransform> LLBKEECEEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x9981C0", Offset = "0x996FC0", VA = "0x1809981C0")]
		private void CCFPJPPENND(NativeArray<RigidTransform> LLBKEECEEKA, NativeArray<Entity> CLJCMNJBJPP, NativeList<Entity> AAMOKNHHCLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class PostGameplayOnScopeChange : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery APOJIILJAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery MLDFDENIPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x8C37B0", Offset = "0x8C25B0", VA = "0x1808C37B0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3890", Offset = "0x8C2690", VA = "0x1808C3890", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x8C39E0", Offset = "0x8C27E0", VA = "0x1808C39E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3820", Offset = "0x8C2620", VA = "0x1808C3820")]
		private void OKGEIHHOMCP(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery DIFNIPBAHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents PADELIJHEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EJHGJPDMMNM OEELHKGPJPO;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C3CE0", VA = "0x1808C4EE0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x8C5100", Offset = "0x8C3F00", VA = "0x1808C5100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C3FA0", VA = "0x1808C51A0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F70", Offset = "0x8C3D70", VA = "0x1808C4F70")]
		private void IDNGIEJDOED(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<FOFFCLGGJFM>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x983600", Offset = "0x982400", VA = "0x180983600", Slot = "14")]
		protected override void CHBPBEDNKEM(NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> GBPPMFBDKIM, NativeArray<Entity> GBFIHJGNJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x983750", Offset = "0x982550", VA = "0x180983750")]
		[BurstCompile]
		private static void CHBPBEDNKEM(NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> GBFIHJGNJDC, ComponentDataFromEntity<global::DMDFIALAIKC> IDBIJALOIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x983860", Offset = "0x982660", VA = "0x180983860")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x983820", Offset = "0x982620", VA = "0x180983820", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[KNPMBINOPIG(MLNJOBCAIAM.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : KDFOLIPKNOC where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery INGBDCJMBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery DFGAJJFPDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery GHEAFNJNHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery LODHJGNPCFD;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FF50", Offset = "0x3C7ED50", VA = "0x183C7FF50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3C80150", Offset = "0x3C7EF50", VA = "0x183C80150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3C80120", Offset = "0x3C7EF20", VA = "0x183C80120", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E480", Offset = "0x3C7D280", VA = "0x183C7E480")]
		private void BAJEMOPOLPC(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F0F0", Offset = "0x3C7DEF0", VA = "0x183C7F0F0")]
		private void FFJEHOEAAME(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F930", Offset = "0x3C7E730", VA = "0x183C7F930")]
		private void OCDPPGJIMHC(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void CHBPBEDNKEM(NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> GBPPMFBDKIM, NativeArray<Entity> GBFIHJGNJDC);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3C801E0", Offset = "0x3C7EFE0", VA = "0x183C801E0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x22EA390", Offset = "0x22E9190", VA = "0x1822EA390", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class OBONFEGJEEO : KDFOLIPKNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> LCJHLEPBNED;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD00", Offset = "0x8ABB00", VA = "0x1808ACD00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8ABD00", VA = "0x1808ACF00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x8AD050", Offset = "0x8ABE50", VA = "0x1808AD050")]
	public OBONFEGJEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct IDDALLBJAKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int NCHPHHOHCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int NPFJJNLPIKO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCB0", Offset = "0xA2CAB0", VA = "0x180A2DCB0")]
	public static Entity LJJFBFNEMCH(IDDALLBJAKP CPLKBCGCHAN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCB0", Offset = "0xA2CAB0", VA = "0x180A2DCB0")]
	public static IDDALLBJAKP LJJFBFNEMCH(Entity DNMNICOEECM)
	{
		return default(IDDALLBJAKP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct PJHJFLOBCOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct DJAGFOOLNGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType GOCNKJILLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> BCPNDHEOJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> AFEMIAFNLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> JFFJECJPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> HJDICCEFABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> BBBKBKKMKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> HDIELKAGPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int FHMCNKHLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int OLEGAMLBDHD;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool HNEFOBBBEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x90B9B0", Offset = "0x90A7B0", VA = "0x18090B9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x90BA30", Offset = "0x90A830", VA = "0x18090BA30")]
	public DJAGFOOLNGB(ComponentType GOCNKJILLJC, NativeList<int> BCPNDHEOJLP, NativeList<int> AFEMIAFNLOO, NativeArray<Entity> JFFJECJPHEB, NativeArray<Entity> HJDICCEFABF, NativeArray<byte> BBBKBKKMKPN, NativeArray<byte> HDIELKAGPFJ, int FHMCNKHLCCL, int OLEGAMLBDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x90B880", Offset = "0x90A680", VA = "0x18090B880")]
	private LDOGLLBKONE GJPOBMFENAN(NativeArray<byte> HDCHHDPICKJ, int DJIEOHJNDEK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T GJPOBMFENAN<T>(NativeArray<byte> HDCHHDPICKJ, int DJIEOHJNDEK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x90B7E0", Offset = "0x90A5E0", VA = "0x18090B7E0")]
	public LDOGLLBKONE EOOIBEAJNPL(int DJIEOHJNDEK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T EOOIBEAJNPL<T>(int DJIEOHJNDEK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x90B830", Offset = "0x90A630", VA = "0x18090B830")]
	public LDOGLLBKONE GIKCNPOIHIL(int DJIEOHJNDEK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T GIKCNPOIHIL<T>(int DJIEOHJNDEK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x90B700", Offset = "0x90A500", VA = "0x18090B700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct COACELIHDJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<NAOFCNIOKFK> DPFFDAKDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType GOCNKJILLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int FHMCNKHLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int OLEGAMLBDHD;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x8FE090", Offset = "0x8FCE90", VA = "0x1808FE090")]
	public COACELIHDJO(ComponentType GOCNKJILLJC, int FHMCNKHLCCL, int OLEGAMLBDHD, EntityQuery EFCFIFNMPEK, NativeArray<NAOFCNIOKFK> DPFFDAKDAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x8FE040", Offset = "0x8FCE40", VA = "0x1808FE040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct FNLLEOANANC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int DJIEOHJNDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int DJICDBBDJDC;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
	public FNLLEOANANC(int DJIEOHJNDEK, int DJICDBBDJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct NAOFCNIOKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int OMMIHDFOJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int LCJMNMLOPCJ;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
	public NAOFCNIOKFK(int OMMIHDFOJDN, int LCJMNMLOPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct OIALCHKPHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly INOPGIMBOKC FCIFBDBBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int FHMCNKHLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* BBBKBKKMKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* HDIELKAGPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool GLKFOIMGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE550", VA = "0x1808AF750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public INOPGIMBOKC CEGBKALJAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0")]
		get
		{
			return default(INOPGIMBOKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF760", Offset = "0x8AE560", VA = "0x1808AF760")]
	public LDOGLLBKONE PEFPMHIKCHL(Type LAKBKKJKBPK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF660", Offset = "0x8AE460", VA = "0x1808AF660")]
	public LDOGLLBKONE LLAGCCMLHFG(Type LAKBKKJKBPK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x36880F0", Offset = "0x3686EF0", VA = "0x1836880F0")]
	public T PEFPMHIKCHL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x36880D0", Offset = "0x3686ED0", VA = "0x1836880D0")]
	public T LLAGCCMLHFG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x8AF850", Offset = "0x8AE650", VA = "0x1808AF850")]
	public unsafe OIALCHKPHOP(INOPGIMBOKC FCIFBDBBENJ, int LCJMNMLOPCJ, byte* BBBKBKKMKPN, byte* HDIELKAGPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class AFKOEBAJGGC : MMMECBJBGPP, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService KAMEPNPKECB;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract KBNFBDJCELI BNPBCMJKABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x8F15D0", Offset = "0x8F03D0", VA = "0x1808F15D0", Slot = "17")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x8F1860", Offset = "0x8F0660", VA = "0x1808F1860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x8F1620", Offset = "0x8F0420", VA = "0x1808F1620", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	protected AFKOEBAJGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class MOFNHGBHOCG
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] COKPLHOHEDC;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class LNELFGKFMLI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, COACELIHDJO> DKMIOEBLIPE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public COACELIHDJO BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xA390F0", Offset = "0xA37EF0", VA = "0x180A390F0")]
		get
		{
			return default(COACELIHDJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0xA38650", Offset = "0xA37450", VA = "0x180A38650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0xA39180", Offset = "0xA37F80", VA = "0x180A39180")]
	public LNELFGKFMLI(NMDJLEODPOP BPCGIPNNAMM, EKGLDANHPKF CGFIKJKJOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0xA388E0", Offset = "0xA376E0", VA = "0x180A388E0")]
	public bool ICLIDKMCOMO(ComponentType GOCNKJILLJC, out COACELIHDJO LIMMJLMICDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0xA38DB0", Offset = "0xA37BB0", VA = "0x180A38DB0")]
	public Dictionary<ComponentType, COACELIHDJO>.Enumerator LEIFMBFFFGJ()
	{
		return default(Dictionary<ComponentType, COACELIHDJO>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0xA386A0", Offset = "0xA374A0", VA = "0x180A386A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0xA38950", Offset = "0xA37750", VA = "0x180A38950")]
	private void KFOPHJGJLEO(IEnumerable<LKKPMGMGFIA> EBDNLFDMLID, EntityManager ECFOMHOIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0xA38830", Offset = "0xA37630", VA = "0x180A38830")]
	private static int FBBHPINOIFF(LKKPMGMGFIA LAANNECNDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0xA38E40", Offset = "0xA37C40", VA = "0x180A38E40")]
	private static NativeArray<NAOFCNIOKFK> OFHLDCCLCEP(LKKPMGMGFIA LAANNECNDLG, Allocator CMCENMLGNBG = Allocator.Persistent)
	{
		return default(NativeArray<NAOFCNIOKFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface NHAPMCCEHGH
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool HNEFOBBBEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World KAFKEKECCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDEACOEHIFF(out NativeArray<int> NEMJDICMKED, Allocator CMCENMLGNBG);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKHDHOAJFAD(ComponentType GOCNKJILLJC, out DJAGFOOLNGB JONKLKJEMLO, out COACELIHDJO BBOKJAJJLIM);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKHDHOAJFAD(ComponentType GOCNKJILLJC, out DJAGFOOLNGB JONKLKJEMLO);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DJAGFOOLNGB PEJIDDEKFHA(ComponentType GOCNKJILLJC);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CONINBAKPNI BDGBBKDHKKH();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMEJCKBDPGP(JobHandle HPPHIENCKNF);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
internal interface ALEJKGLGAIK
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World KAFKEKECCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	LNELFGKFMLI PPCPNGCPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	GMKCLMHIBEH LMHEFJKNDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, OIALCHKPHOP> NANJOALJDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle ICNNDNPCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NEOFEBEOAIM();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJHAHNAAJMI();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BLHCGAFDOON(ComponentType GOCNKJILLJC, in DJAGFOOLNGB ICFEJHGBNIB);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HIHBDNKGEOH(FIMAOKHBMMB JPILKLCBOKG, out Entity MDFMPPCALJP);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct CONINBAKPNI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct ACDFICEPLED : IEnumerator<OIALCHKPHOP>, IEnumerator, IDisposable, IEnumerable<OIALCHKPHOP>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, OIALCHKPHOP> EJIPNPFMBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity DNMNICOEECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> CDEEMAKLBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private OIALCHKPHOP HDIELKAGPFJ;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public OIALCHKPHOP NFPBMNAHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x97D550", Offset = "0x97C350", VA = "0x18097D550", Slot = "4")]
			get
			{
				return default(OIALCHKPHOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x97D4E0", Offset = "0x97C2E0", VA = "0x18097D4E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x97D530", Offset = "0x97C330", VA = "0x18097D530")]
		internal ACDFICEPLED(NativeMultiHashMap<Entity, OIALCHKPHOP> EJIPNPFMBNA, Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x97D2D0", Offset = "0x97C0D0", VA = "0x18097D2D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x97D2A0", Offset = "0x97C0A0", VA = "0x18097D2A0")]
		public ACDFICEPLED LEIFMBFFFGJ()
		{
			return default(ACDFICEPLED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x97D3A0", Offset = "0x97C1A0", VA = "0x18097D3A0", Slot = "9")]
		private IEnumerator<OIALCHKPHOP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x97D440", Offset = "0x97C240", VA = "0x18097D440", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly ALEJKGLGAIK AJCEDEPGCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle KIPNEFHAEOE;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int LODJMNGJMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x8FE0C0", Offset = "0x8FCEC0", VA = "0x1808FE0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x8FE460", Offset = "0x8FD260", VA = "0x1808FE460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x8FE660", Offset = "0x8FD460", VA = "0x1808FE660")]
	public CONINBAKPNI(ALEJKGLGAIK AJCEDEPGCCG, JobHandle KIPNEFHAEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x8FE320", Offset = "0x8FD120", VA = "0x1808FE320")]
	public bool GJIEPKPFNFL(Allocator CMCENMLGNBG, out NativeKeyValueArrays<Entity, OIALCHKPHOP> LILKGIPDCFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1B0", Offset = "0x8FCFB0", VA = "0x1808FE1B0")]
	public bool EDLCLMCFOIK(Allocator CMCENMLGNBG, out (NativeArray<Entity> entities, int uniqueCount) LILKGIPDCFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x8FE540", Offset = "0x8FD340", VA = "0x1808FE540")]
	public ACDFICEPLED NOMFPLHAFAN(Entity DNMNICOEECM)
	{
		return default(ACDFICEPLED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class GMKCLMHIBEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<COACELIHDJO> GHOABBJLFEA;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public COACELIHDJO BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA24090", Offset = "0xA22E90", VA = "0x180A24090")]
		get
		{
			return default(COACELIHDJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA23B20", Offset = "0xA22920", VA = "0x180A23B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0xA24120", Offset = "0xA22F20", VA = "0x180A24120")]
	public GMKCLMHIBEH(LNELFGKFMLI DKMIOEBLIPE, NMDJLEODPOP BPCGIPNNAMM, EKGLDANHPKF CGFIKJKJOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0xA24010", Offset = "0xA22E10", VA = "0x180A24010")]
	public List<COACELIHDJO>.Enumerator LEIFMBFFFGJ()
	{
		return default(List<COACELIHDJO>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0xA23B60", Offset = "0xA22960", VA = "0x180A23B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0xA23CE0", Offset = "0xA22AE0", VA = "0x180A23CE0")]
	private void KFOPHJGJLEO(LNELFGKFMLI DKMIOEBLIPE, EntityManager ECFOMHOIDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class HNBENBGBLKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService ONDFKMMBLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::JMMBMFDPPCF<LKKPMGMGFIA> CFBKBPIALOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World OGAHLDGOMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> BNHJAECBKNL;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0xA2A870", Offset = "0xA29670", VA = "0x180A2A870")]
	public HNBENBGBLKD(ObjectInstantiationService ONDFKMMBLDC, NMDJLEODPOP BPCGIPNNAMM, EKGLDANHPKF CGFIKJKJOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0xA29AD0", Offset = "0xA288D0", VA = "0x180A29AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0xA29F20", Offset = "0xA28D20", VA = "0x180A29F20")]
	public bool GBHDEDGBMGL(FIMAOKHBMMB JPILKLCBOKG, out Entity MDFMPPCALJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0xA2A210", Offset = "0xA29010", VA = "0x180A2A210")]
	private void PICJEDKELGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0xA29000", Offset = "0xA27E00", VA = "0x180A29000")]
	private EntityArchetype AFKAJBKINAE(EntityArchetype OGAANLHKNAA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0xA29530", Offset = "0xA28330", VA = "0x180A29530")]
	public static void AKJHPEFCJGP(EntityManager AEACOCEHFLB, EntityManager LACAMDOJOEA, NativeArray<Entity> DNGMAKGMFCK, NativeArray<EntityArchetype> IOEFNFNDAIG, [Optional] NativeArray<Entity> JBAHJACCBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0xA29960", Offset = "0xA28760", VA = "0x180A29960")]
	[Conditional("DEBUG_BUILD")]
	private static void DNCPGEGFPGK(NativeArray<EntityArchetype> PFONNMBPBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0xA29BA0", Offset = "0xA289A0", VA = "0x180A29BA0")]
	private static string ENMJHLPNDLG(EntityArchetype ICNAFELCIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0xA29DE0", Offset = "0xA28BE0", VA = "0x180A29DE0")]
	[CompilerGenerated]
	internal static void FKNBFGGFJHH(ref Span<ComponentType> ONFPCALKHCC, ComponentType DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0xA29F80", Offset = "0xA28D80", VA = "0x180A29F80")]
	[CompilerGenerated]
	internal static void KJNEJBBENOD(Span<ComponentType> HDCHHDPICKJ, ref Span<ComponentType> ONFPCALKHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xA2A130", Offset = "0xA28F30", VA = "0x180A2A130")]
	[CompilerGenerated]
	internal static void ONNIDKCFHHP(Span<ComponentType> HDCHHDPICKJ, ref Span<ComponentType> ONFPCALKHCC, ComponentType GHJIGOBEMGM)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld IONOMDGCBNH;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x8F6230", Offset = "0x8F5030", VA = "0x1808F6230", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x8F62F0", Offset = "0x8F50F0", VA = "0x1808F62F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[KNPMBINOPIG(MLNJOBCAIAM.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : KDFOLIPKNOC, KPALCLLIODG, DOKJEHLBPKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct CAIOANEIGEH : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> JLJOIKNEPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> CDHFGLCNBPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<NAOFCNIOKFK> ACKMLANOHAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<FNLLEOANANC>.ParallelWriter NHMDFDLHDAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int HGEDHMLDENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int KPPDEOKLBCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker AMAJNGOGLKG;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x97E1C0", Offset = "0x97CFC0", VA = "0x18097E1C0", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x97E300", Offset = "0x97D100", VA = "0x18097E300")]
			private unsafe int HMJEMNDMJFO(byte* PMEJHNPJGNH, byte* BFKBHAILEEA)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct OBMKCGHJJED : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> BCPNDHEOJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> EDGCJOEFGGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<FNLLEOANANC> CBFHGBBDIIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker AMAJNGOGLKG;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x981260", Offset = "0x980060", VA = "0x180981260", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct DOOBIHCNJOI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> DHFAOOIKPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public ComponentDataFromEntity EIINMCHNDLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int FHMCNKHLCCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker AMAJNGOGLKG;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x97F0B0", Offset = "0x97DEB0", VA = "0x18097F0B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct COBIKGLMEPG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, OIALCHKPHOP> EBCHMJCDHFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> BBBKBKKMKPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> HDIELKAGPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<NAOFCNIOKFK> JMONBBCNFGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> AFEMIAFNLOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> BCPNDHEOJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int AIEHLONNDGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int OLEGAMLBDHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker AMAJNGOGLKG;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x97E850", Offset = "0x97D650", VA = "0x18097E850", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker OGJFEOANDBC;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker MIGIICKCFDA;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker EFGFHCHCGGB;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker DHJIKKMJIPG;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker ICKJFBFMAPN;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker ALGJBKLMPJE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker EAHAECPGGOI;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker OIAKHHNANFC;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker NHNNNGGFBKG;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker MPDICMEBLMA;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker GJHOLLLIELL;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker EBBGNBOLKJO;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker PPLJKMMAMGC;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker KMJNBEPPEEC;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker LCHODOEGKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService KAMEPNPKECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery OMGOLDJPFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery MEIECDCGPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery LMPALGLEMAO;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World KAFKEKECCDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x901670", Offset = "0x900470", VA = "0x180901670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private ALEJKGLGAIK EFFJPHMPJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x903520", Offset = "0x902320", VA = "0x180903520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x9012A0", Offset = "0x9000A0", VA = "0x1809012A0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "15")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x903220", Offset = "0x902020", VA = "0x180903220", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x9033E0", Offset = "0x9021E0", VA = "0x1809033E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x903370", Offset = "0x902170", VA = "0x180903370", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x9007F0", Offset = "0x8FF5F0", VA = "0x1809007F0")]
		private void BGPMEJIDLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x900AB0", Offset = "0x8FF8B0", VA = "0x180900AB0")]
		internal void BJCCKJLDBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x900AD0", Offset = "0x8FF8D0", VA = "0x180900AD0")]
		private void BJCCKJLDBPA(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x902220", Offset = "0x901020", VA = "0x180902220")]
		private void HLDJJEAKOBA(NativeArray<Entity> DNGMAKGMFCK, NativeArray<RRObjectPrefabData> KDIEMMHDIGF, ref NativeArray<Entity> FBKGHCGJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x903940", Offset = "0x902740", VA = "0x180903940")]
		internal void PIIEEAGJGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x903540", Offset = "0x902340", VA = "0x180903540")]
		private void PIIEEAGJGIN(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x901A10", Offset = "0x900810", VA = "0x180901A10")]
		internal void HHAFACJBLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x901730", Offset = "0x900530", VA = "0x180901730")]
		private void GIHJHEGHKJH(ALEJKGLGAIK AJCEDEPGCCG, COACELIHDJO BBOKJAJJLIM, bool DALNDAOHBJA, ref JobHandle KAJMHLDCLBN, ref JobHandle IPIPOJGOBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x9031F0", Offset = "0x901FF0", VA = "0x1809031F0")]
		internal bool NDGEBOPFPEK(in COACELIHDJO BFKBHAILEEA, out JobHandle ODABKCNLMCP, out DJAGFOOLNGB NCBOCADDALA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x9028C0", Offset = "0x9016C0", VA = "0x1809028C0")]
		private bool NDGEBOPFPEK(in COACELIHDJO BFKBHAILEEA, bool DALNDAOHBJA, out JobHandle ODABKCNLMCP, out DJAGFOOLNGB NCBOCADDALA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x902460", Offset = "0x901260", VA = "0x180902460")]
		internal (NativeList<int>, NativeList<int>) IKJLIFIEGBE(NativeList<FNLLEOANANC> CBFHGBBDIIK, int DOOAOHCDEFK, JobHandle DGCBHFBCIBP, out JobHandle HPPHIENCKNF, Allocator CMCENMLGNBG = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x902170", Offset = "0x900F70", VA = "0x180902170")]
		internal static NativeArray<Entity> HIHANONADAM(EntityQuery EFCFIFNMPEK, out JobHandle DJJFGJKLJAB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x900770", Offset = "0x8FF570", VA = "0x180900770")]
		internal static NativeArray<byte> ADFGOBFNDOG(int GACPBGKAIDC, out JobHandle HHPAGGDHDLE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x902620", Offset = "0x901420", VA = "0x180902620")]
		internal static NativeArray<byte> JOPJFILPODL(EntityQuery EFCFIFNMPEK, int EDBPGCEKEHE, out JobHandle HHPAGGDHDLE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x9012F0", Offset = "0x9000F0", VA = "0x1809012F0")]
		internal static NativeArray<Entity> BNIGHMPOMPA(EntityQuery EFCFIFNMPEK, out JobHandle KKAKHMNAOFL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x900200", VA = "0x180901400")]
		internal NativeArray<byte> EMGEKCNGAIH(NativeArray<Entity> JFFJECJPHEB, COACELIHDJO BBOKJAJJLIM, JobHandle DGCBHFBCIBP, out JobHandle HPPHIENCKNF, Allocator CMCENMLGNBG = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x902730", Offset = "0x901530", VA = "0x180902730")]
		internal JobHandle LKEHMLAAIJA(in DJAGFOOLNGB CPLKBCGCHAN, in COACELIHDJO BBOKJAJJLIM, NativeMultiHashMap<Entity, OIALCHKPHOP> EBCHMJCDHFO, JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x9013F0", Offset = "0x9001F0", VA = "0x1809013F0")]
		private JobHandle ELMGHDFGDDK(JobHandle OPCEMOAHIAO, JobHandle FKCBGIIENJE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x9013F0", Offset = "0x9001F0", VA = "0x1809013F0")]
		private JobHandle ELMGHDFGDDK(JobHandle OPCEMOAHIAO, JobHandle FKCBGIIENJE, JobHandle DCNGKNMPDHF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[KNPMBINOPIG(MLNJOBCAIAM.RenderEffects)]
	internal class PropagateHoverRootTag : HFNNKIIOFEG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct MHCBDFHHKHN : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType JDIHNIPHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AE0", Offset = "0x8C48E0", VA = "0x1808C5AE0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType NBCBNCJCEKD
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x8C5AB0", Offset = "0x8C48B0", VA = "0x1808C5AB0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType ILPDEFGBJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A80", Offset = "0x8C4880", VA = "0x1808C5A80", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B10", Offset = "0x8C4910", VA = "0x1808C5B10")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[KNPMBINOPIG(MLNJOBCAIAM.RenderEffects)]
	internal class PropagateSelectionRootTag : HFNNKIIOFEG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct ILAABCNDJHN : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType JDIHNIPHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4980", VA = "0x1808C5B80", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType NBCBNCJCEKD
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B50", Offset = "0x8C4950", VA = "0x1808C5B50", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType ILPDEFGBJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B20", Offset = "0x8C4920", VA = "0x1808C5B20", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B10", Offset = "0x8C4910", VA = "0x1808C5B10")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[JNIBKDHCHEO]
public class ALLGKECICLH : CLIEFILLAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x8F4700", Offset = "0x8F3500", VA = "0x1808F4700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x8F4790", Offset = "0x8F3590", VA = "0x1808F4790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public ALLGKECICLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[JNIBKDHCHEO]
public class PKMJBICBFFF : CLIEFILLAJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct EFLLNMNDAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public EFLLNMNDAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct FACNKILNOPB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct CHOCIMFNOGB
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct JDGMLMEMJOP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime OBNMOKHOKEA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> JOMKLCHIKBL;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x11AA270", Offset = "0x11A9070", VA = "0x1811AA270")]
			public void MMEBNFEOLLL(PKMJBICBFFF OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x11AA2D0", Offset = "0x11A90D0", VA = "0x1811AA2D0")]
			public JDGMLMEMJOP MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(JDGMLMEMJOP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager ECFOMHOIDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> HHPCNONCEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private CHOCIMFNOGB MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CHOCIMFNOGB.JDGMLMEMJOP* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IEENALOFKJO;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x11AD250", Offset = "0x11AC050", VA = "0x1811AD250")]
		internal void CKCONFOJCMG(Entity DNMNICOEECM, SplinePointParentData IODDJAKNMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x11AD510", Offset = "0x11AC310", VA = "0x1811AD510", Slot = "5")]
		public void ReadFromDisplayClass(ref EFLLNMNDAFK ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x11AD520", Offset = "0x11AC320", VA = "0x1811AD520", Slot = "6")]
		public void WriteToDisplayClass(ref EFLLNMNDAFK ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x11AD2C0", Offset = "0x11AC0C0", VA = "0x1811AD2C0", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x11AD360", Offset = "0x11AC160", VA = "0x1811AD360")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref CHOCIMFNOGB.JDGMLMEMJOP HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x11AD410", Offset = "0x11AC210", VA = "0x1811AD410")]
		public void MMEBNFEOLLL(PKMJBICBFFF OBDAFEBCIMG, ref EFLLNMNDAFK ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x11AD4A0", Offset = "0x11AC2A0", VA = "0x1811AD4A0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery DHDIEECHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker DINFJJJMMHB;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x8BF660", Offset = "0x8BE460", VA = "0x1808BF660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public PKMJBICBFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BF430", Offset = "0x8BE230", VA = "0x1808BF430", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2D0", Offset = "0x8BE0D0", VA = "0x1808BF2D0")]
	public static EntityQuery ALHHHNPGPNB(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[JNIBKDHCHEO]
public class LICAFKCDDMC : CLIEFILLAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery FCHLLMGILFE;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0xA38000", Offset = "0xA36E00", VA = "0x180A38000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0xA38090", Offset = "0xA36E90", VA = "0x180A38090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public LICAFKCDDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(ALLGKECICLH))]
public class ONDMHBLPHDN : KDFOLIPKNOC
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x8B15E0", Offset = "0x8B03E0", VA = "0x1808B15E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public ONDMHBLPHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class EOJFGGNPDBK : CLIEFILLAJL, KPALCLLIODG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct GGNOLFJMOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<IJJNJPIJDOH, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public GGNOLFJMOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IGAMGAJJDMG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct DCBFFPBNEGG
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct JHFLJMPAKIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LPJNGNMKLJP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FAOGDFJGLEG;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x11AB1C0", Offset = "0x11A9FC0", VA = "0x1811AB1C0")]
			public void MMEBNFEOLLL(EOJFGGNPDBK OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x11AB220", Offset = "0x11AA020", VA = "0x1811AB220")]
			public JHFLJMPAKIL MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(JHFLJMPAKIL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<IJJNJPIJDOH, Entity> EJIPNPFMBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DCBFFPBNEGG MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DCBFFPBNEGG.JHFLJMPAKIL* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x9803D0", Offset = "0x97F1D0", VA = "0x1809803D0")]
		internal void CKCONFOJCMG(Entity DNMNICOEECM, ObjectNetworkIdComponentData BKMGLPAKKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x980620", Offset = "0x97F420", VA = "0x180980620", Slot = "5")]
		public void ReadFromDisplayClass(ref GGNOLFJMOCN ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x980630", Offset = "0x97F430", VA = "0x180980630", Slot = "6")]
		public void WriteToDisplayClass(ref GGNOLFJMOCN ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x980450", Offset = "0x97F250", VA = "0x180980450", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x9804C0", Offset = "0x97F2C0", VA = "0x1809804C0")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref DCBFFPBNEGG.JHFLJMPAKIL HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x980570", Offset = "0x97F370", VA = "0x180980570")]
		public void MMEBNFEOLLL(EOJFGGNPDBK OBDAFEBCIMG, ref GGNOLFJMOCN ALHINGPEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x9805B0", Offset = "0x97F3B0", VA = "0x1809805B0")]
		public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService JKFEKEAGDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery DHDIEECHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker DINFJJJMMHB;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x90EF20", Offset = "0x90DD20", VA = "0x18090EF20", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x90F180", Offset = "0x90DF80", VA = "0x18090F180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public EOJFGGNPDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x90EF80", Offset = "0x90DD80", VA = "0x18090EF80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x90EDC0", Offset = "0x90DBC0", VA = "0x18090EDC0")]
	public static EntityQuery ALHHHNPGPNB(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class MHMJBJKPPOB : CLIEFILLAJL, KPALCLLIODG
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DDNIOBMBHFP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct JPPFNOAENAH
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct PKNEALFEKNJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime GNOMIGOGOPE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LEHFDCKCABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> DMBBKIDAHDM;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x11AEC40", Offset = "0x11ADA40", VA = "0x1811AEC40")]
			public void MMEBNFEOLLL(MHMJBJKPPOB OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x11AECA0", Offset = "0x11ADAA0", VA = "0x1811AECA0")]
			public PKNEALFEKNJ MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
			{
				return default(PKNEALFEKNJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public MHMJBJKPPOB AEDFJONMOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private JPPFNOAENAH MJFGHCPBCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JPPFNOAENAH.PKNEALFEKNJ* GHNMODMGKDO;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x11AB500", Offset = "0x11AA300", VA = "0x1811AB500")]
		public void CKCONFOJCMG(Entity DNMNICOEECM, ParentData IMMIIBELFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x11AB520", Offset = "0x11AA320", VA = "0x1811AB520", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x11AB5C0", Offset = "0x11AA3C0", VA = "0x1811AB5C0")]
		public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref JPPFNOAENAH.PKNEALFEKNJ HEFEALCGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x11AB670", Offset = "0x11AA470", VA = "0x1811AB670")]
		public void MMEBNFEOLLL(MHMJBJKPPOB OBDAFEBCIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x11AB6F0", Offset = "0x11AA4F0", VA = "0x1811AB6F0")]
		public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery DHDIEECHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker DINFJJJMMHB;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0xA3A6C0", Offset = "0xA394C0", VA = "0x180A3A6C0", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0xA3A920", Offset = "0xA39720", VA = "0x180A3A920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public MHMJBJKPPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0xA3A4D0", Offset = "0xA392D0", VA = "0x180A3A4D0")]
	[CompilerGenerated]
	private void BHJNDMGCJDE(Entity DNMNICOEECM, ParentData IMMIIBELFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xA3A720", Offset = "0xA39520", VA = "0x180A3A720", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0xA3A370", Offset = "0xA39170", VA = "0x180A3A370")]
	public static EntityQuery ALHHHNPGPNB(ComponentSystemBase OBDAFEBCIMG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class JCFOMCMFBGH : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int JOJAODNPKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery EFCFIFNMPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs ONDFKMMBLDC;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0xA30F50", Offset = "0xA2FD50", VA = "0x180A30F50", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0xA312F0", Offset = "0xA300F0", VA = "0x180A312F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0xA313D0", Offset = "0xA301D0", VA = "0x180A313D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0xA30FA0", Offset = "0xA2FDA0", VA = "0x180A30FA0")]
	private void GGEACICGHHF(Entity DNMNICOEECM, FIMAOKHBMMB JPILKLCBOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public JCFOMCMFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(JCFOMCMFBGH))]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	public class PostLoadAddSceneTagEntity : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService BBLHCHIFBMC;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x8C3AF0", Offset = "0x8C28F0", VA = "0x1808C3AF0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B40", Offset = "0x8C2940", VA = "0x1808C3B40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	[LDMGGBBOHCI(MNIFKKPEEPE.OMRoom)]
	public class PostLoadInitializeNetworkId : KDFOLIPKNOC, KPALCLLIODG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct GMPEEAJIFGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<IJJNJPIJDOH, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
			public GMPEEAJIFGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KPENFFHNDBE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct GBDNPJMFMPG
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct OCBHNFIGHHE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime BNKHHMEMNMN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LPJNGNMKLJP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LEHFDCKCABM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex EDBIEIIFOAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FAOGDFJGLEG;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x11ADB50", Offset = "0x11AC950", VA = "0x1811ADB50")]
				public void MMEBNFEOLLL(PostLoadInitializeNetworkId OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x11ADBC0", Offset = "0x11AC9C0", VA = "0x1811ADBC0")]
				public OCBHNFIGHHE MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(OCBHNFIGHHE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<IJJNJPIJDOH, Entity> EJIPNPFMBNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private GBDNPJMFMPG MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GBDNPJMFMPG.OCBHNFIGHHE* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IEENALOFKJO;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x11AF6E0", Offset = "0x11AE4E0", VA = "0x1811AF6E0")]
			internal void CKCONFOJCMG(Entity DNMNICOEECM, int FAMAGOOBNAN, ref ObjectNetworkIdComponentData BKMGLPAKKEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x980620", Offset = "0x97F420", VA = "0x180980620", Slot = "5")]
			public void ReadFromDisplayClass(ref GMPEEAJIFGO ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x980630", Offset = "0x97F430", VA = "0x180980630", Slot = "6")]
			public void WriteToDisplayClass(ref GMPEEAJIFGO ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x11AF770", Offset = "0x11AE570", VA = "0x1811AF770", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x11AF860", Offset = "0x11AE660", VA = "0x1811AF860")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref GBDNPJMFMPG.OCBHNFIGHHE HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x11AF930", Offset = "0x11AE730", VA = "0x1811AF930")]
			public void MMEBNFEOLLL(PostLoadInitializeNetworkId OBDAFEBCIMG, ref GMPEEAJIFGO ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x11AF9D0", Offset = "0x11AE7D0", VA = "0x1811AF9D0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[AGIJCBMCMGO]
		private ObjectNetworkToLocalMapService JKFEKEAGDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[AGIJCBMCMGO]
		private SceneService HAOGFLCGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery EFCFIFNMPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery GLBABMJGHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker PBICCNGHNBF;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x8C3D50", Offset = "0x8C2B50", VA = "0x1808C3D50", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A70", Offset = "0x8C3870", VA = "0x1808C4A70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x8C44B0", Offset = "0x8C32B0", VA = "0x1808C44B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x8C44B0", Offset = "0x8C32B0", VA = "0x1808C44B0")]
		public void HILAHGHKMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DC0", Offset = "0x8C2BC0", VA = "0x1808C3DC0")]
		private void CGLIBDCEGIF(NativeHashMap<IJJNJPIJDOH, Entity> EJIPNPFMBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4580", Offset = "0x8C3380", VA = "0x1808C4580")]
		private void KJKAHDBPLFL(NativeHashMap<IJJNJPIJDOH, Entity> EJIPNPFMBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x8C47E0", Offset = "0x8C35E0", VA = "0x1808C47E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4310", Offset = "0x8C3110", VA = "0x1808C4310")]
		public static EntityQuery HHMNFEBKECK(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class BGOEMIIKDJO : KDFOLIPKNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery HBFDFGOCANC;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x8F7BA0", Offset = "0x8F69A0", VA = "0x1808F7BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public BGOEMIIKDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class AGNKCHCCAJM : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::JMMBMFDPPCF<CCKGGMKEPJM> EFPIDPDKAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x8F18F0", Offset = "0x8F06F0", VA = "0x1808F18F0", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F0FA0", VA = "0x1808F21A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x8F24A0", Offset = "0x8F12A0", VA = "0x1808F24A0")]
	private void PLBJAFMKBBH(NativeList<EntityArchetype> PFONNMBPBHL, NativeHashMap<int, PDIIEEBMKOH> JFEJNHNLCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x8F2060", Offset = "0x8F0E60", VA = "0x1808F2060")]
	private Span<int> OEOHHNFHLFM(EntityArchetype ICNAFELCIGB)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x8F1990", Offset = "0x8F0790", VA = "0x1808F1990")]
	private bool DLGDCEEJBLD(int EDBPGCEKEHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x8F1A60", Offset = "0x8F0860", VA = "0x1808F1A60")]
	private void HPBEFOJIHJF(NativeHashMap<int, PDIIEEBMKOH> JFEJNHNLCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public AGNKCHCCAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[KNPMBINOPIG(MLNJOBCAIAM.Serialization)]
	public class PreSerializeRemoveEntities : KDFOLIPKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery GHPPNNICABG;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B60", Offset = "0x8C3960", VA = "0x1808C4B60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DE0", Offset = "0x8C3BE0", VA = "0x1808C4DE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[KNPMBINOPIG(MLNJOBCAIAM.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : KDFOLIPKNOC, KPALCLLIODG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct IMCANPDDNEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public ComponentDataFromEntity dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
			public IMCANPDDNEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x9803C0", Offset = "0x97F1C0", VA = "0x1809803C0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LIMNMPODCCD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> BCPNDHEOJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> HJDICCEFABF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public ComponentDataFromEntity JPPKDNEECHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> HDIELKAGPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int FHMCNKHLCCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType GOCNKJILLJC;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x11B0220", Offset = "0x11AF020", VA = "0x1811B0220")]
			internal void CKCONFOJCMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x11B0410", Offset = "0x11AF210", VA = "0x1811B0410", Slot = "5")]
			public void ReadFromDisplayClass(ref IMCANPDDNEJ ALHINGPEGEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x11B03E0", Offset = "0x11AF1E0", VA = "0x1811B03E0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x11B03F0", Offset = "0x11AF1F0", VA = "0x1811B03F0")]
			public void MMEBNFEOLLL(ShadowWorldApplyPropertyDifferencesToShadowWorld OBDAFEBCIMG, ref IMCANPDDNEJ ALHINGPEGEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService KAMEPNPKECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle DHJPADDNKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle NDKDNFJAPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private NHAPMCCEHGH AJCEDEPGCCG;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x9893A0", Offset = "0x9881A0", VA = "0x1809893A0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x989710", Offset = "0x988510", VA = "0x180989710")]
		public JobHandle HJIIGOKNPHB(JobHandle DGCBHFBCIBP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x989750", Offset = "0x988550", VA = "0x180989750", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x989400", Offset = "0x988200", VA = "0x180989400")]
		private bool GPCNBINGIFM(JobHandle DGCBHFBCIBP, int EDBPGCEKEHE, out JobHandle NCBAJHJOHAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[LFNIFJENOAD]
[UpdateInGroup(typeof(MACPOLEHCPP))]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal sealed class HGBBHANDKNI : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0xA262C0", Offset = "0xA250C0", VA = "0x180A262C0", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public HGBBHANDKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[LFNIFJENOAD]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
[UpdateInGroup(typeof(IJJLGABGBKA))]
internal sealed class HCCGCBHCHKP : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0xA24430", Offset = "0xA23230", VA = "0x180A24430", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public HCCGCBHCHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[LFNIFJENOAD]
[ExecuteAlways]
[UpdateInGroup(typeof(NNCCMFOGMLL))]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal sealed class EEJKKFKMEEI : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x90D440", Offset = "0x90C240", VA = "0x18090D440", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public EEJKKFKMEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[LFNIFJENOAD]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
[UpdateInGroup(typeof(DEFCEKJCCGG))]
internal sealed class MHLEOJABAKM : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0xA3A270", Offset = "0xA39070", VA = "0x180A3A270", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public MHLEOJABAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class IDEDAJDKHDA : AFKOEBAJGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override KBNFBDJCELI BNPBCMJKABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA80", Offset = "0x6CD880", VA = "0x1806CEA80", Slot = "18")]
		get
		{
			return default(KBNFBDJCELI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCD0", Offset = "0xA2CAD0", VA = "0x180A2DCD0")]
	public IDEDAJDKHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[LFNIFJENOAD]
[UpdateInGroup(typeof(BOELAJBNPJB))]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal sealed class IHALOKPPOOO : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0xA2DE30", Offset = "0xA2CC30", VA = "0x180A2DE30", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public IHALOKPPOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class MDEAICOMEAK : LNHODKLBMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public MDEAICOMEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class LAJPJDEEIIA : AFKOEBAJGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override KBNFBDJCELI BNPBCMJKABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "18")]
		get
		{
			return default(KBNFBDJCELI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCD0", Offset = "0xA2CAD0", VA = "0x180A2DCD0")]
	public LAJPJDEEIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[LFNIFJENOAD]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
[UpdateInGroup(typeof(DCGCALAGIBB))]
internal sealed class JJOAOIOEBNG : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0xA31ED0", Offset = "0xA30CD0", VA = "0x180A31ED0", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public JJOAOIOEBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class PAKOHLDNDHB : LNHODKLBMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public PAKOHLDNDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class MHKBMCCKDNL : LNHODKLBMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public MHKBMCCKDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class GELIBKMEDGP : KDFOLIPKNOC
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public GELIBKMEDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[JNIBKDHCHEO]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
public class GKFIHOHHJMN : KDFOLIPKNOC, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService DNJNINLCKDL;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0xA23A30", Offset = "0xA22830", VA = "0x180A23A30", Slot = "14")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0xA23A80", Offset = "0xA22880", VA = "0x180A23A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public GKFIHOHHJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class CopyTransformDataFromGameObjects : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct NHLDHFDDFIA : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float LEFLCNDNPAM = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> OPBCMHLCMCF;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x981060", Offset = "0x97FE60", VA = "0x180981060", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x981220", Offset = "0x980020", VA = "0x180981220")]
			private bool IFOAIFHDNCG(float3 ABCKFOPNDBL, float3 EPJLLOJPHCA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x980FF0", Offset = "0x97FDF0", VA = "0x180980FF0")]
			private bool AHOHEBLBIOG(quaternion ABCKFOPNDBL, quaternion EPJLLOJPHCA)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct ECLLDLCAOFO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> DBHNLPMDNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> HDNJAHICCMI;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x97F6C0", Offset = "0x97E4C0", VA = "0x18097F6C0", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly EKGLDANHPKF EIAPKDAKCFP;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly EKGLDANHPKF FMMGKNIPLIH;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly EKGLDANHPKF LDAKKCCMKBP;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker DPHJLMDBBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private GKMIKEJGNKB KFGFEHOEMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x906B10", Offset = "0x905910", VA = "0x180906B10", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x906B80", Offset = "0x905980", VA = "0x180906B80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x906BB0", Offset = "0x9059B0", VA = "0x180906BB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	public class RegisterTransforms : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LDIAAAKCEGM : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct NDKIDJDIDMJ
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct GLPHDAOONHM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<MCGBBJFAABK>.Runtime NGIEHIMDBDP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime AECLDNLDJKG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LEHFDCKCABM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<MCGBBJFAABK> DECCBOKBHDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> HLKBDIFNMPO;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x11B1B50", Offset = "0x11B0950", VA = "0x1811B1B50")]
				public void MMEBNFEOLLL(RegisterTransforms OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x11B1BD0", Offset = "0x11B09D0", VA = "0x1811B1BD0")]
				public GLPHDAOONHM MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(GLPHDAOONHM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private NDKIDJDIDMJ MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NDKIDJDIDMJ.GLPHDAOONHM* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate AKFDFCDKLIE;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x11AFB00", Offset = "0x11AE900", VA = "0x1811AFB00")]
			internal void CKCONFOJCMG(Entity DNMNICOEECM, MCGBBJFAABK HKFDIPJFPLD, Transform HAFNICDKMAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x11AFC00", Offset = "0x11AEA00", VA = "0x1811AFC00", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x11AFCF0", Offset = "0x11AEAF0", VA = "0x1811AFCF0")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, ref NDKIDJDIDMJ.GLPHDAOONHM HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x11AFDD0", Offset = "0x11AEBD0", VA = "0x1811AFDD0")]
			public void MMEBNFEOLLL(RegisterTransforms OBDAFEBCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x11AFDE0", Offset = "0x11AEBE0", VA = "0x1811AFDE0")]
			public unsafe static void PPKCIFLKJME(ArchetypeChunkIterator* DBIACMAHFEI, void* HJGAGHPDBHB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct CIJJNMENELC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct PGIBJIBIABE
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct PJJAHNHMFGB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime MBAPAOENBLD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<MCGBBJFAABK>.Runtime NGIEHIMDBDP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity LEHFDCKCABM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<MCGBBJFAABK> DECCBOKBHDD;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x11AA570", Offset = "0x11A9370", VA = "0x1811AA570")]
				public void MMEBNFEOLLL(RegisterTransforms OBDAFEBCIMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x11B2E10", Offset = "0x11B1C10", VA = "0x1811B2E10")]
				public PJJAHNHMFGB MPNFKLJGFMA(ref ArchetypeChunk KKKJEEDDCPH, int KABMAGJIOGM, int ILOKBNCBNPO)
				{
					return default(PJJAHNHMFGB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private PGIBJIBIABE MJFGHCPBCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PGIBJIBIABE.PJJAHNHMFGB* GHNMODMGKDO;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x11AA350", Offset = "0x11A9150", VA = "0x1811AA350")]
			internal void CKCONFOJCMG(Entity DNMNICOEECM, MCGBBJFAABK HKFDIPJFPLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x11AA430", Offset = "0x11A9230", VA = "0x1811AA430", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int HIOACLBEGPK, int BMLHGMBAEBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x11AA4C0", Offset = "0x11A92C0", VA = "0x1811AA4C0")]
			public void IDEIFNAELLH(ref ArchetypeChunk LJKLLDMPOPK, [NoAlias] ref PGIBJIBIABE.PJJAHNHMFGB HEFEALCGMNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x11AA570", Offset = "0x11A9370", VA = "0x1811AA570")]
			public void MMEBNFEOLLL(RegisterTransforms OBDAFEBCIMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private GKMIKEJGNKB KFGFEHOEMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery CDEEBANFCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery PEPLKEEIBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery FIGNCLKHKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery PLOOHDBILNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery IGCOIBLHGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker APLFAIHBBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery IMLLBHHJLJC;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x9823A0", Offset = "0x9811A0", VA = "0x1809823A0", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x983060", Offset = "0x981E60", VA = "0x180983060", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x983270", Offset = "0x982070", VA = "0x180983270", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x9825C0", Offset = "0x9813C0", VA = "0x1809825C0")]
		private void DGJOIOJGMHB(EntityQuery EFCFIFNMPEK, CLKHLCOEDFF EGLHJICLPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x983340", Offset = "0x982140", VA = "0x180983340")]
		private void PGEEGMLGFHD(EntityQuery EFCFIFNMPEK, CLKHLCOEDFF EGLHJICLPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x983210", Offset = "0x982010", VA = "0x180983210", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x982800", Offset = "0x981600", VA = "0x180982800")]
		private void FCFJALAADNE(NativeArray<Entity> JFFJECJPHEB, CLKHLCOEDFF EGLHJICLPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x982940", Offset = "0x981740", VA = "0x180982940")]
		[BurstCompile]
		internal static void GPMDNHGBHMM(NativeArray<MCGBBJFAABK> NJIOPNKDPHI, ComponentDataFromEntity<MCGBBJFAABK> PGMOMKNDPFK, CLKHLCOEDFF EGLHJICLPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void JKJAELEGMLA(Transform HAFNICDKMAH, Entity DNMNICOEECM, int DJIEOHJNDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void HEHEBFOFILL(Entity DNMNICOEECM, int DJIEOHJNDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void KFBDAFAGPDE(int DJIEOHJNDEK, CLKHLCOEDFF EGLHJICLPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x9821C0", Offset = "0x980FC0", VA = "0x1809821C0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void BHOOEMDBAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x982DF0", Offset = "0x981BF0", VA = "0x180982DF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x982C50", Offset = "0x981A50", VA = "0x180982C50")]
		public static EntityQuery MLAOAOJELDA(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x9823F0", Offset = "0x9811F0", VA = "0x1809823F0")]
		public static EntityQuery BOMMAGIOKAJ(ComponentSystemBase OBDAFEBCIMG)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	public class CopyTransformDataToGameObjects : KDFOLIPKNOC, KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct EBIPGHEKAEN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> OPBCMHLCMCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x97F5E0", Offset = "0x97E3E0", VA = "0x18097F5E0", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct CIGIDAFJNJN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DBHNLPMDNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x97E390", Offset = "0x97D190", VA = "0x18097E390", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct ILCAGJIAIGH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DBHNLPMDNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> HDNJAHICCMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> JFFJECJPHEB;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x980640", Offset = "0x97F440", VA = "0x180980640", Slot = "4")]
			public void Execute(int DJIEOHJNDEK, TransformAccess HAFNICDKMAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly EKGLDANHPKF EIAPKDAKCFP;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly EKGLDANHPKF FMMGKNIPLIH;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly EKGLDANHPKF LDAKKCCMKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private GKMIKEJGNKB KFGFEHOEMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery JGGDHMOPIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery OPGPFHJPOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery GHOLNKCBOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray FAGKLDBIKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray CGFHHJJMFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray EGIPOFOGPDE;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x907060", Offset = "0x905E60", VA = "0x180907060", Slot = "14")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x907230", Offset = "0x906030", VA = "0x180907230", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x907420", Offset = "0x906220", VA = "0x180907420", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x9074B0", Offset = "0x9062B0", VA = "0x1809074B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x9074E0", Offset = "0x9062E0", VA = "0x1809074E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x9070B0", Offset = "0x905EB0", VA = "0x1809070B0")]
		private NativeArray<Entity> HFDKELMFLLC(NativeArray<MCGBBJFAABK> BCPNDHEOJLP, NativeList<Entity> DNGMAKGMFCK, TransformAccessArray FGNOHBDMNAF, TransformAccessArray CFGFKLGDPCO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : KDFOLIPKNOC, DOKJEHLBPKM
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private CCKFACOPIOK DPGNKCLIGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private DBEKECCGIHJ OGKLNJLJJHC;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C3FA0", VA = "0x1808C51A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x907F90", Offset = "0x906D90", VA = "0x180907F90", Slot = "14")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x908160", Offset = "0x906F60", VA = "0x180908160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x907E10", Offset = "0x906C10", VA = "0x180907E10")]
		private static void CJMEPLNKCFF(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, Entity KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x908890", Offset = "0x907690", VA = "0x180908890")]
		private static bool PBBNBKDNKEE(EntityManager ECFOMHOIDDI, Entity DNMNICOEECM, out Transform HAFNICDKMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[KNPMBINOPIG(MLNJOBCAIAM.TransformSyncing)]
	public class L2PToL2WHierarchy : KDFOLIPKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct CKPOOBAFPPC : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> GDAOLJGBJCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> GLNCEHDKKDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> AENFMNHFFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> ONDJMHLMMKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> JENCPDDIKAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> IAEBJAHGCDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint LDJKNPJNGHD;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x11AB080", Offset = "0x11A9E80", VA = "0x1811AB080")]
			[Conditional("DEBUG_BUILD")]
			private void PPAGCDEAKIC(Entity DNMNICOEECM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x11AAD90", Offset = "0x11A9B90", VA = "0x1811AAD90", Slot = "4")]
			public void Execute(ArchetypeChunk LJKLLDMPOPK, int DJIEOHJNDEK, int CAFFBLJEDIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x11AA990", Offset = "0x11A9790", VA = "0x1811AA990")]
			private void EBMAJKCAJBO(float4x4 NCPEHHPDJCL, Entity DNMNICOEECM, bool BJLBLPMOEOL, int BEGFELCMNHC = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery EHJOFDIAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery PFABNANFAMO;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA36BA0", Offset = "0xA359A0", VA = "0x180A36BA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA36CC0", Offset = "0xA35AC0", VA = "0x180A36CC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class KPINDLKILLH : JDAMMLFCKGM
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct DELPEDJGCGO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> GDAOLJGBJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> JENCPDDIKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint LDJKNPJNGHD;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x11AB7E0", Offset = "0x11AA5E0", VA = "0x1811AB7E0", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int DJIEOHJNDEK, int CAFFBLJEDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x11AB760", Offset = "0x11AA560", VA = "0x1811AB760")]
		public bool EJOAHFIKKEM(ArchetypeChunk LJKLLDMPOPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery EHJOFDIAFHI;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0xA35B80", Offset = "0xA34980", VA = "0x180A35B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0xA35CB0", Offset = "0xA34AB0", VA = "0x180A35CB0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AGDFEFMINOL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public KPINDLKILLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class FLHNNEDBILI : JDAMMLFCKGM
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct EJLJJDFGOOH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> FBDCEJNMOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> OBBLMNACMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> EPPAHFMMKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> ICCFLOAEIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint LDJKNPJNGHD;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x11AC570", Offset = "0x11AB370", VA = "0x1811AC570", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int DJIEOHJNDEK, int CAFFBLJEDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x11AC4F0", Offset = "0x11AB2F0", VA = "0x1811AC4F0")]
		public bool EJOAHFIKKEM(ArchetypeChunk LJKLLDMPOPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery PFGOIEFLOBG;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0xA21180", Offset = "0xA1FF80", VA = "0x180A21180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0xA21290", Offset = "0xA20090", VA = "0x180A21290", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AGDFEFMINOL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public FLHNNEDBILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class DKFPBHNPFBA : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct AIAMMADDPDE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> LKMFCNEOFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BEICDEIAANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> KFHPJHCIFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> KNCNDPGJHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint LDJKNPJNGHD;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x97D650", Offset = "0x97C450", VA = "0x18097D650", Slot = "4")]
		public void Execute(ArchetypeChunk LJKLLDMPOPK, int DJIEOHJNDEK, int CAFFBLJEDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x97D570", Offset = "0x97C370", VA = "0x18097D570")]
		public bool EJOAHFIKKEM(ArchetypeChunk LJKLLDMPOPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery PFGOIEFLOBG;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x90BBE0", Offset = "0x90A9E0", VA = "0x18090BBE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x90BD10", Offset = "0x90AB10", VA = "0x18090BD10", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AGDFEFMINOL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	public DKFPBHNPFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[KNPMBINOPIG(MLNJOBCAIAM.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : HFNNKIIOFEG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct CIIHALHIALG : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType JDIHNIPHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C10", Offset = "0x8C4A10", VA = "0x1808C5C10", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType NBCBNCJCEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BE0", Offset = "0x8C49E0", VA = "0x1808C5BE0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType ILPDEFGBJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BB0", Offset = "0x8C49B0", VA = "0x1808C5BB0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B10", Offset = "0x8C4910", VA = "0x1808C5B10")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[OJPFBMJMNJL(JGAMAFNCPCL.Game)]
public class EGIDHJGALCH : HDMPPCBKAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type KHAHPENEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x90DC00", Offset = "0x90CA00", VA = "0x18090DC00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] GBCNPFICNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x90D590", Offset = "0x90C390", VA = "0x18090D590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public EGIDHJGALCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[OJPFBMJMNJL(JGAMAFNCPCL.Loading)]
public class NDPFJGGJJLF : HDMPPCBKAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type KHAHPENEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] GBCNPFICNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2C0", Offset = "0x8A90C0", VA = "0x1808AA2C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NDPFJGGJJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class GGGHHCDJACM : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0xA22D70", Offset = "0xA21B70", VA = "0x180A22D70", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public GGGHHCDJACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[OJPFBMJMNJL(JGAMAFNCPCL.Saving)]
public class JPCHDNJEJGN : HDMPPCBKAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type KHAHPENEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] GBCNPFICNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA33B20", Offset = "0xA32920", VA = "0x180A33B20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public JPCHDNJEJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class IAPGKLFELFD : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0xA2D970", Offset = "0xA2C770", VA = "0x180A2D970", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public IAPGKLFELFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[OJPFBMJMNJL(JGAMAFNCPCL.Simulation)]
public class CNCMKIBEJKF : HDMPPCBKAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type KHAHPENEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x8FDFB0", Offset = "0x8FCDB0", VA = "0x1808FDFB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] GBCNPFICNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC00", Offset = "0x8FCA00", VA = "0x1808FDC00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CNCMKIBEJKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[HLJOGLEHOLC(typeof(OPJJHCEGBKP), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal class OPJJHCEGBKP : DOKJEHLBPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::CMCHMAGOMCA<AuthoredParentData, APCABMHFOCF, CFLEFLGBCIN, AuthoredChildrenData> BFJFMIKELLP;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AB0", Offset = "0x8B08B0", VA = "0x1808B1AB0", Slot = "4")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OPJJHCEGBKP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	[HLJOGLEHOLC(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : KPALCLLIODG, DOKJEHLBPKM
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[AGIJCBMCMGO]
		private OIHJCGPPHNA PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[AGIJCBMCMGO]
		private PropertyChangeNetworkRouter PJBPHNEKLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::AMBLIANEJIB<Entity> JHGILNGJHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::CMCHMAGOMCA<ParentData, OIFDFEHPCHJ, HJOGCCLLHPA, ChildrenData> BFJFMIKELLP;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0xA1F340", Offset = "0xA1E140", VA = "0x180A1F340", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA1F400", Offset = "0xA1E200", VA = "0x180A1F400", Slot = "5")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA1F3B0", Offset = "0xA1E1B0", VA = "0x180A1F3B0")]
		public Entity GCHFIHMHOPE(Entity DNMNICOEECM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA1F2E0", Offset = "0xA1E0E0", VA = "0x180A1F2E0")]
		public bool BBFMINOPBKF(Entity DNMNICOEECM, Entity DDNBMNPALIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA1F6E0", Offset = "0xA1E4E0", VA = "0x180A1F6E0")]
		public bool OLGACPEMICJ(Entity DNMNICOEECM, Entity DDNBMNPALIB, bool JMPINMPLJAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA1F500", Offset = "0xA1E300", VA = "0x180A1F500")]
		private bool NGPKDIGLIHO(Entity DNMNICOEECM, Entity DDNBMNPALIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[HLJOGLEHOLC(typeof(LEBPMDNKHBB), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal sealed class LEBPMDNKHBB : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery HADGFDINLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0xA37A30", Offset = "0xA36830", VA = "0x180A37A30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0xA37230", Offset = "0xA36030", VA = "0x180A37230", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0xA374C0", Offset = "0xA362C0", VA = "0x180A374C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0xA37840", Offset = "0xA36640", VA = "0x180A37840")]
	public bool JNLEIODLHDK(Entity DNMNICOEECM, Entity NKHKMPCFDCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0xA37A80", Offset = "0xA36880", VA = "0x180A37A80")]
	public IEnumerable<Entity> LIKIKMEKNMI(Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0xA37900", Offset = "0xA36700", VA = "0x180A37900")]
	public bool LDGJJGLOIFM(Entity DNMNICOEECM, Entity JJJNIHBIILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0xA37C00", Offset = "0xA36A00", VA = "0x180A37C00")]
	public bool MIOBDMMEPAF(Entity DNMNICOEECM, Entity MOKGIKPKEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0xA373E0", Offset = "0xA361E0", VA = "0x180A373E0")]
	public NativeList<Entity> DJBKCJAPECG(Entity DNMNICOEECM, bool EIKBGGPMPHI = false, Allocator CMCENMLGNBG = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0xA37D00", Offset = "0xA36B00", VA = "0x180A37D00")]
	public IEnumerable<Entity> OLAHGGADNDF(Entity DNMNICOEECM, bool EIKBGGPMPHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0xA37330", Offset = "0xA36130", VA = "0x180A37330")]
	public Entity CONDOMCIIBM(Entity DNMNICOEECM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0xA377F0", Offset = "0xA365F0", VA = "0x180A377F0")]
	public NativeArray<Entity> IJFGJNIGJLA()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0xA375D0", Offset = "0xA363D0", VA = "0x180A375D0")]
	public bool ELMNJLIGOFH(Entity MOKGIKPKEBG, Entity PABKONOGBKI, out Entity BDKHOEDMNIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0xA374E0", Offset = "0xA362E0", VA = "0x180A374E0")]
	private Entity EGJOLOHBLGK(Entity DNMNICOEECM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public LEBPMDNKHBB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x33F4DD0", Offset = "0x33F3BD0", VA = "0x1833F4DD0")]
		public static void NEOFEBEOAIM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(KEOFLKLFAOP OPNLEKFMABF, global::HACMJIPGPHI<Entity> MEBPKBJLLDI, out global::CMCHMAGOMCA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> IMIFCLNIODP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, ADKCGMMLOFH where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, ADKCGMMLOFH, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x8C04C0", Offset = "0x8BF2C0", VA = "0x1808C04C0")]
		public static bool GADBDNFKECJ(HMIODAKHEJO IPAJFMPKCLK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class CMCHMAGOMCA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, ADKCGMMLOFH where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, ADKCGMMLOFH, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly EKGLDANHPKF CGFIKJKJOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::AMBLIANEJIB<Entity> JHGILNGJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly HGLBLJEIAMO DLKOEOAEKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly ENGJLAFCBJI KICGHGEEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly DBEKECCGIHJ OGKLNJLJJHC;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x443B2B0", Offset = "0x443A0B0", VA = "0x18443B2B0")]
	public CMCHMAGOMCA(KEOFLKLFAOP OPNLEKFMABF, global::HACMJIPGPHI<Entity> MEBPKBJLLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x443AB70", Offset = "0x4439970", VA = "0x18443AB70")]
	private bool HFGLDAMGMIA(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x443A3E0", Offset = "0x44391E0", VA = "0x18443A3E0")]
	private bool CLICNFDHELM(Entity DNMNICOEECM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x4439F40", Offset = "0x4438D40", VA = "0x184439F40")]
	public bool BBFMINOPBKF(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x4439F70", Offset = "0x4438D70", VA = "0x184439F70")]
	public bool BMJHPAABNDA(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x4439FA0", Offset = "0x4438DA0", VA = "0x184439FA0")]
	private bool BMJHPAABNDA(Entity DNMNICOEECM, in Entity DDNBMNPALIB, bool JMIKACOIJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void PHEFGNMCNNA(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void KIAJDCHCCNA(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void PGKDPFEELCM(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void OPCMEJANELP(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private static void IKIOIHALKIF(Entity DNMNICOEECM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x443AF60", Offset = "0x4439D60", VA = "0x18443AF60")]
	private bool JNLEIODLHDK(Entity DNMNICOEECM, Entity NKHKMPCFDCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x443B040", Offset = "0x4439E40", VA = "0x18443B040")]
	private void LPNIEANIFJM(Entity DNMNICOEECM, in Entity JEAPMLEICDM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x443A5D0", Offset = "0x44393D0", VA = "0x18443A5D0")]
	private void ECAFCKGALKA(Entity DNMNICOEECM, in Entity JEAPMLEICDM, in Entity DDNBMNPALIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x443A770", Offset = "0x4439570", VA = "0x18443A770")]
	private bool ECDMIBGFMOE(MBIIEBBCDMH OCABAAKKMMK, in IJJNJPIJDOH LOGFODHPPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x443AC30", Offset = "0x4439A30", VA = "0x18443AC30")]
	private void IBNDOHPBODA(Entity KICGHGEEADG, Entity JJJNIHBIILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x443AD60", Offset = "0x4439B60", VA = "0x18443AD60")]
	private void IEFILFBALKN(Entity KICGHGEEADG, Entity JJJNIHBIILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private void KFBDAFAGPDE(Entity DNMNICOEECM, Entity JEAPMLEICDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	private void JKJAELEGMLA(Entity DNMNICOEECM, Entity DDNBMNPALIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct IGNEIKCMOOH : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[HLJOGLEHOLC(typeof(ObjectEmbodimentService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Embodiment)]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	internal sealed class ObjectEmbodimentService : MADGGLIDCPC, CCIFGMMGDFO, KPALCLLIODG, DOKJEHLBPKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService EEIMFPOJEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[AGIJCBMCMGO]
		private OIHJCGPPHNA PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[AGIJCBMCMGO]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[AGIJCBMCMGO]
		private JPBNEEDJLKP GABFGDHMPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[AGIJCBMCMGO]
		private EHFLPEEKACO HDPCGLEKKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[AGIJCBMCMGO]
		private TransformOwnershipPhase FNCGHDAFHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<IJJNJPIJDOH, EBIEHGPCOMI> NLDMEGJNODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private KNNCNELHKGA AHFOHILAEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x8B4C50", Offset = "0x8B3A50", VA = "0x1808B4C50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int OPEPNFGMHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x8B4550", Offset = "0x8B3350", VA = "0x1808B4550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int FKOFPEADGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x8B2FC0", Offset = "0x8B1DC0", VA = "0x1808B2FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x8B3510", Offset = "0x8B2310", VA = "0x1808B3510", Slot = "4")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x8B2910", Offset = "0x8B1710", VA = "0x1808B2910", Slot = "5")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B50", Offset = "0x8B0950", VA = "0x1808B1B50")]
		public void ACLIBCIOFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x8B41C0", Offset = "0x8B2FC0", VA = "0x1808B41C0", Slot = "6")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x8B3370", Offset = "0x8B2170", VA = "0x1808B3370", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x8B3920", Offset = "0x8B2720", VA = "0x1808B3920")]
		public int HGNMOBEIPIH(SceneTag LICHDNGOEKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x8B34F0", Offset = "0x8B22F0", VA = "0x1808B34F0")]
		public int FOOJIFAAONM(SceneTag LICHDNGOEKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3520", Offset = "0x8B2320", VA = "0x1808B3520")]
		public bool GCKLDLBAPJA(Entity DNMNICOEECM, Allocator CMCENMLGNBG, out NativeList<Entity> NCEDEJCBDKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FE0", Offset = "0x8B1DE0", VA = "0x1808B2FE0")]
		public bool DLOKGEDKPOD(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x8B24B0", Offset = "0x8B12B0", VA = "0x1808B24B0")]
		public bool BEGPOELPKJE(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x8B40A0", Offset = "0x8B2EA0", VA = "0x1808B40A0")]
		public bool JOBPINEJIPE(Entity DNMNICOEECM, out EBIEHGPCOMI EAFONAFODFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4110", Offset = "0x8B2F10", VA = "0x1808B4110")]
		private bool JOBPINEJIPE(Transform HAFNICDKMAH, out EBIEHGPCOMI EAFONAFODFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B1130", VA = "0x1808B2330")]
		private void AHAAFILLENI(Entity DNMNICOEECM, EBIEHGPCOMI EAFONAFODFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x8B34A0", Offset = "0x8B22A0", VA = "0x1808B34A0")]
		private bool EGLNMOJFAKJ(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x8B5370", Offset = "0x8B4170", VA = "0x1808B5370")]
		public void OBNDPKOJMJJ(IJJNJPIJDOH OJMDJGIIFAA, EBIEHGPCOMI NINEKIGDNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x8B2570", Offset = "0x8B1370", VA = "0x1808B2570")]
		public bool BFNEHLOKEOJ(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BA0", Offset = "0x8B09A0", VA = "0x1808B1BA0")]
		public bool AGHGLADNMDE(LEDHMIGLCGN NFBLCBCBMID, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x8B22C0", Offset = "0x8B10C0", VA = "0x1808B22C0")]
		public bool AGHGLADNMDE(Entity DNMNICOEECM, [Optional] object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x8B2310", Offset = "0x8B1110", VA = "0x1808B2310")]
		public bool AGHGLADNMDE(EBIEHGPCOMI IPAJFMPKCLK, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x8B4850", Offset = "0x8B3650", VA = "0x1808B4850")]
		public bool LFGAABNLBMD(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C20", Offset = "0x8B3A20", VA = "0x1808B4C20")]
		public bool LFGAABNLBMD(EBIEHGPCOMI EAFONAFODFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F50", Offset = "0x8B0D50", VA = "0x1808B1F50")]
		public bool AGHGLADNMDE(EBIEHGPCOMI EAFONAFODFI, [Optional] object DPODOOAHECI, bool JBCHDAAKNKO = false, bool NFJGKJKNCPP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B70", Offset = "0x8B2970", VA = "0x1808B3B70")]
		public Transform HIJGCJPBNOE(Entity DNMNICOEECM, [Optional] object DPODOOAHECI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5570", Offset = "0x8B4370", VA = "0x1808B5570")]
		public bool PBBNBKDNKEE(Entity DNMNICOEECM, out Transform HAFNICDKMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
		public EBIEHGPCOMI GEKAIKIDDEH(Entity DNMNICOEECM, [Optional] object DPODOOAHECI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E70", Offset = "0x8B3C70", VA = "0x1808B4E70")]
		public void NGJHIIPHIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x8B3CE0", Offset = "0x8B2AE0", VA = "0x1808B3CE0")]
		public void HKDGGAHPPPL(SceneTag LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C00", Offset = "0x8B1A00", VA = "0x1808B2C00")]
		private void CPDEOEAGMCD(Entity DNMNICOEECM, bool LOIEKAGBODP, bool HACGAGBDLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x8B5640", Offset = "0x8B4440", VA = "0x1808B5640")]
		private void PBKKJPAAJKA(Entity DNMNICOEECM, EBIEHGPCOMI EAFONAFODFI, bool LOIEKAGBODP, bool HACGAGBDLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x8B4800", Offset = "0x8B3600", VA = "0x1808B4800")]
		public EBIEHGPCOMI LBAJABJBGOM(Entity DNMNICOEECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x8B52F0", Offset = "0x8B40F0", VA = "0x1808B52F0")]
		public bool OADOIGGJJMA(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B80", Offset = "0x8B1980", VA = "0x1808B2B80")]
		public bool CINGDJMBNFK(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x8B4570", Offset = "0x8B3370", VA = "0x1808B4570")]
		public bool KKDJDPJBDPA(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x8B3300", Offset = "0x8B2100", VA = "0x1808B3300")]
		public bool DMANKIDBMNB(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B2030", VA = "0x1808B3230")]
		public bool DMANKIDBMNB(IHMDJLDFGCF ODABKCNLMCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LJAEPMKNGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B3BB0", VA = "0x1808B4DB0")]
		private void LPLFLOMININ(bool NDCPLPKHLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x8B2AF0", Offset = "0x8B18F0", VA = "0x1808B2AF0")]
		private bool CAGJGEOMKHC(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x8B24D0", Offset = "0x8B12D0", VA = "0x1808B24D0")]
		private EBIEHGPCOMI BFLDAMHHAIC(Entity DNMNICOEECM, object DPODOOAHECI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5100", Offset = "0x8B3F00", VA = "0x1808B5100")]
		private EBIEHGPCOMI NPKOLIDNBEN(Entity DNMNICOEECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x8B45E0", Offset = "0x8B33E0", VA = "0x1808B45E0")]
		private (Vector3, Quaternion, Vector3) KPCFFPDHNLC(Entity DNMNICOEECM)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CA0", Offset = "0x8B3AA0", VA = "0x1808B4CA0")]
		private void LLHEAHPKAOI(Entity DNMNICOEECM, FIMAOKHBMMB JPILKLCBOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x8B3860", Offset = "0x8B2660", VA = "0x1808B3860")]
		private void HDAEFNPKOIB(LEDHMIGLCGN NFBLCBCBMID, EBIEHGPCOMI NINEKIGDNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A40", Offset = "0x8B1840", VA = "0x1808B2A40")]
		private void BNEJEOIPBPN(EBIEHGPCOMI NINEKIGDNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x8B3940", Offset = "0x8B2740", VA = "0x1808B3940")]
		private void HHPFPPIKBKP(EBIEHGPCOMI EAFONAFODFI, Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x8B4310", Offset = "0x8B3110", VA = "0x1808B4310")]
		private void JPBKILHOOFP(Entity DNMNICOEECM, EBIEHGPCOMI EAFONAFODFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x8B23D0", Offset = "0x8B11D0", VA = "0x1808B23D0")]
		private void BDLFGKFDHKC(Entity DNMNICOEECM, Transform HAFNICDKMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x8B34C0", Offset = "0x8B22C0", VA = "0x1808B34C0")]
		private LEDHMIGLCGN FOHAGAJHJFB(Entity DNMNICOEECM)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4600", VA = "0x1808B5800")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x8B56E0", Offset = "0x8B44E0", VA = "0x1808B56E0")]
		[CompilerGenerated]
		private void PCMPEALPOOF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class LMMPOFPDNNK
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0xA38550", Offset = "0xA37350", VA = "0x180A38550")]
	public static EBIEHGPCOMI GEKAIKIDDEH(this ObjectEmbodimentService CFFMBLMAMOD, LEDHMIGLCGN NFBLCBCBMID, [Optional] object DPODOOAHECI)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[KNPMBINOPIG(MLNJOBCAIAM.Lifecycle)]
	[HLJOGLEHOLC(typeof(ObjectLifecycleService), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	internal sealed class ObjectLifecycleService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService EAFONAFODFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private JMGAEOJCJBO LCFPMBEHBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects HJDGALPNFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5960", VA = "0x1808B6B60")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, FIMAOKHBMMB> MNADECFAHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4E10", VA = "0x1808B6010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x8B6190", Offset = "0x8B4F90", VA = "0x1808B6190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> APECANCAHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x8B6C10", Offset = "0x8B5A10", VA = "0x1808B6C10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AC0", Offset = "0x8B58C0", VA = "0x1808B6AC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x8B60B0", Offset = "0x8B4EB0", VA = "0x1808B60B0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5490", VA = "0x1808B6690", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A00", Offset = "0x8B5800", VA = "0x1808B6A00")]
		public bool GPGONAPLKOC(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BB0", Offset = "0x8B59B0", VA = "0x1808B6BB0")]
		internal void LLHNGFAHFLK(Entity DNMNICOEECM, FIMAOKHBMMB JPILKLCBOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A80", Offset = "0x8B5880", VA = "0x1808B6A80")]
		public void KJOGCPPIFAO(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F10", Offset = "0x8B5D10", VA = "0x1808B6F10")]
		public void PEFAKEAEGCJ(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x8B68F0", Offset = "0x8B56F0", VA = "0x1808B68F0")]
		private bool GAFLFEPKKFG(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x8B6490", Offset = "0x8B5290", VA = "0x1808B6490")]
		public void DMKMELLNHHE(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x8B66A0", Offset = "0x8B54A0", VA = "0x1808B66A0")]
		private bool EINBFIGDGNM(Entity DNMNICOEECM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x8B6860", Offset = "0x8B5660", VA = "0x1808B6860")]
		public void EJJEEPIOMOI(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x8B6CB0", Offset = "0x8B5AB0", VA = "0x1808B6CB0")]
		private void MOBDEICFFNA(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x8B6230", Offset = "0x8B5030", VA = "0x1808B6230")]
		private void DKEEHGEIFDH(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x8B69B0", Offset = "0x8B57B0", VA = "0x1808B69B0")]
		public void GDOFLAOBACF(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private void DPFKDDKOHHO(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D10", Offset = "0x8B5B10", VA = "0x1808B6D10")]
		private void OJAIHLIINJP(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[HLJOGLEHOLC(typeof(ObjectPrefabs), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Prefabs)]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	internal class ObjectPrefabs : GALPBDFCHLD, KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class PBJIICALKLK : IEnumerable<(MKFEGIBJCLL, FIMAOKHBMMB)>, IEnumerable, IEnumerator<(MKFEGIBJCLL, FIMAOKHBMMB)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (MKFEGIBJCLL primitiveType, FIMAOKHBMMB prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000137")]
			private (MKFEGIBJCLL, FIMAOKHBMMB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x11ABE10", Offset = "0x11AAC10", VA = "0x1811ABE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((MKFEGIBJCLL, FIMAOKHBMMB));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x11B26C0", Offset = "0x11B14C0", VA = "0x1811B26C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x11ABEB0", Offset = "0x11AACB0", VA = "0x1811ABEB0")]
			[DebuggerHidden]
			public PBJIICALKLK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x11B24E0", Offset = "0x11B12E0", VA = "0x1811B24E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x11B2680", Offset = "0x11B1480", VA = "0x1811B2680", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x11B25E0", Offset = "0x11B13E0", VA = "0x1811B25E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(MKFEGIBJCLL, FIMAOKHBMMB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x11B25E0", Offset = "0x11B13E0", VA = "0x1811B25E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<FIMAOKHBMMB, Entity> ONDFKMMBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<FIMAOKHBMMB, EntityArchetype> PFONNMBPBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<MKFEGIBJCLL, FIMAOKHBMMB> CICCOIGDIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<GGPGKEMMOBN, FIMAOKHBMMB> AKPDHDDPPLI;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int EKAGFOMELON
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x8B99B0", Offset = "0x8B87B0", VA = "0x1808B99B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x8BABF0", Offset = "0x8B99F0", VA = "0x1808BABF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x8B95D0", Offset = "0x8B83D0", VA = "0x1808B95D0", Slot = "5")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x8BA270", Offset = "0x8B9070", VA = "0x1808BA270", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC10", Offset = "0x8B9A10", VA = "0x1808BAC10")]
		internal IEnumerable<Type> MGIDEDABPDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x8BA710", Offset = "0x8B9510", VA = "0x1808BA710")]
		internal KLDHFAOGDPE EOHBHGDIDHO(Type LAKBKKJKBPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5A0", Offset = "0x8B93A0", VA = "0x1808BA5A0")]
		public EntityArchetype EABGDPFGKPK(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8C50", VA = "0x1808B9E50")]
		public NativeHashMap<int, EntityArchetype> COOILELKNNG(Allocator CMCENMLGNBG = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FD0", Offset = "0x8B8DD0", VA = "0x1808B9FD0")]
		public bool DCEOOMJMKPD(FIMAOKHBMMB JPILKLCBOKG, out EntityArchetype ICNAFELCIGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC70", Offset = "0x8B9A70", VA = "0x1808BAC70", Slot = "4")]
		[IteratorStateMachine(typeof(PBJIICALKLK))]
		public IEnumerable<(MKFEGIBJCLL, FIMAOKHBMMB)> PPOGLBJLLAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x8BA600", Offset = "0x8B9400", VA = "0x1808BA600")]
		public Entity ECIGONMMNAN(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x8BA040", Offset = "0x8B8E40", VA = "0x1808BA040")]
		public FIMAOKHBMMB DMBLIFKAIJH(GGPGKEMMOBN LAKBKKJKBPK)
		{
			return default(FIMAOKHBMMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0A0", Offset = "0x8B8EA0", VA = "0x1808BA0A0")]
		public FIMAOKHBMMB DMBLIFKAIJH(MKFEGIBJCLL LAKBKKJKBPK)
		{
			return default(FIMAOKHBMMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA100", Offset = "0x8B8F00", VA = "0x1808BA100")]
		public NativeHashMap<int, Entity> DOLKHAIMJCC(Allocator CMCENMLGNBG = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA80", Offset = "0x8B9880", VA = "0x1808BAA80")]
		public IEnumerable<FIMAOKHBMMB> HLDPLKDOLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA780", Offset = "0x8B9580", VA = "0x1808BA780")]
		public Entity FAMCPGLLPJB(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7E0", Offset = "0x8B95E0", VA = "0x1808BA7E0")]
		public bool GBHDEDGBMGL(FIMAOKHBMMB JPILKLCBOKG, out Entity MDFMPPCALJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A00", Offset = "0x8B8800", VA = "0x1808B9A00")]
		private void BPOCCOMENFC(KLDHFAOGDPE BLHMHPFFMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x8BA850", Offset = "0x8B9650", VA = "0x1808BA850")]
		internal void HFBPABGMPOA(FIMAOKHBMMB JPILKLCBOKG, ComponentTypeList MKPPOBDEBHF, LMBACJGJLJD JKINJFBBODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x8B9470", Offset = "0x8B8270", VA = "0x1808B9470")]
		private void AMDEDOILOKP(FIMAOKHBMMB JPILKLCBOKG, ComponentTypeList IJKOIMBOKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD0", Offset = "0x8B98D0", VA = "0x1808BAAD0")]
		internal Entity JBGDJPODEBM(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD30", Offset = "0x8B9B30", VA = "0x1808BAD30")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum KBNFBDJCELI
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface AGLHOLGBOEB
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World KAFKEKECCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	LNELFGKFMLI PPCPNGCPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class CMNDLGKJHLM : ALEJKGLGAIK, NHAPMCCEHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly CFCBLDNONOJ POAGLMBMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly KBNFBDJCELI FNCGHDAFHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<DJAGFOOLNGB> APKNCHKKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, OIALCHKPHOP> AODBCMGMCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> DLOABJGKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle COLCJFGGNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle NCAEJCHKGHA;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World BOOIKACDHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x8FD150", Offset = "0x8FBF50", VA = "0x1808FD150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private LNELFGKFMLI MKNEAANKFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x8FC970", Offset = "0x8FB770", VA = "0x1808FC970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private GMKCLMHIBEH MMDDCEOFABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x8FD120", Offset = "0x8FBF20", VA = "0x1808FD120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, OIALCHKPHOP> FBFPPGPLNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x6DBC60", Offset = "0x6DAA60", VA = "0x1806DBC60", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, OIALCHKPHOP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle LCALBDKCGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x8FD140", Offset = "0x8FBF40", VA = "0x1808FD140", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x8FD010", Offset = "0x8FBE10", VA = "0x1808FD010", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool GPFKLIACEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD020", Offset = "0x8FBE20", VA = "0x1808FD020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World NKEIJMENIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB70", Offset = "0x8FB970", VA = "0x1808FCB70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x8FD760", Offset = "0x8FC560", VA = "0x1808FD760")]
	public CMNDLGKJHLM(CFCBLDNONOJ POAGLMBMDHM, KBNFBDJCELI FNCGHDAFHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x8FD420", Offset = "0x8FC220", VA = "0x1808FD420", Slot = "11")]
	private void MGKJCOJNCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC990", Offset = "0x8FB790", VA = "0x1808FC990", Slot = "10")]
	private bool AKCMGHLGKCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA80", Offset = "0x8FB880", VA = "0x1808FCA80", Slot = "12")]
	private void BAFNOBEEEKN(ComponentType GOCNKJILLJC, in DJAGFOOLNGB ICFEJHGBNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x8FD690", Offset = "0x8FC490", VA = "0x1808FD690", Slot = "13")]
	private bool PECHEIEGEKL(FIMAOKHBMMB JPILKLCBOKG, out Entity MDFMPPCALJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6C0", Offset = "0x8FC4C0", VA = "0x1808FD6C0", Slot = "16")]
	private bool PGIIMADACLP(out NativeArray<int> NEMJDICMKED, Allocator CMCENMLGNBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x8FCD40", Offset = "0x8FBB40", VA = "0x1808FCD40", Slot = "17")]
	private bool GPDOHOKEMMO(ComponentType GOCNKJILLJC, out DJAGFOOLNGB JONKLKJEMLO, out COACELIHDJO BBOKJAJJLIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x8FCC10", Offset = "0x8FBA10", VA = "0x1808FCC10", Slot = "18")]
	private bool GPDOHOKEMMO(ComponentType GOCNKJILLJC, out DJAGFOOLNGB JONKLKJEMLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x8FD030", Offset = "0x8FBE30", VA = "0x1808FD030", Slot = "19")]
	private DJAGFOOLNGB IIJBEKLLDHK(ComponentType GOCNKJILLJC)
	{
		return default(DJAGFOOLNGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x8FCBD0", Offset = "0x8FB9D0", VA = "0x1808FCBD0", Slot = "20")]
	private CONINBAKPNI FDNKIJHFAIH()
	{
		return default(CONINBAKPNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x8FD430", Offset = "0x8FC230", VA = "0x1808FD430", Slot = "21")]
	private void NMPKDIEDKNO(JobHandle HPPHIENCKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1B0", Offset = "0x8FBFB0", VA = "0x1808FD1B0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x8FD470", Offset = "0x8FC270", VA = "0x1808FD470")]
	private bool NPMICICNEDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x8FCEC0", Offset = "0x8FBCC0", VA = "0x1808FCEC0")]
	private int HPIMBGCHDDC()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class CFCBLDNONOJ : AGLHOLGBOEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public NMDJLEODPOP BPCGIPNNAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService ONDFKMMBLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public LNELFGKFMLI DKMIOEBLIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public GMKCLMHIBEH PLNNIEHOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public HNBENBGBLKD BNHJAECBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool DNDEJBANJLE;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World KAFKEKECCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC20", Offset = "0x8FAA20", VA = "0x1808FBC20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public LNELFGKFMLI PPCPNGCPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CFCBLDNONOJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[KNPMBINOPIG(MLNJOBCAIAM.PropertyChanges)]
	[HLJOGLEHOLC(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : KPALCLLIODG, DOKJEHLBPKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct GOMCOAHDMMI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly KBNFBDJCELI LCGOGLJEIKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService ILCANNFLEKH;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x11AE4E0", Offset = "0x11AD2E0", VA = "0x1811AE4E0")]
			public GOMCOAHDMMI(PropertyDiffStateService ILCANNFLEKH, KBNFBDJCELI KCHHCAFOCBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x11AE4C0", Offset = "0x11AD2C0", VA = "0x1811AE4C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly CFCBLDNONOJ POAGLMBMDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly CMNDLGKJHLM[] OAPIEPIJAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private KBNFBDJCELI EPHFJCNPOIJ;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public AGLHOLGBOEB IBOPEAHAEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public NHAPMCCEHGH CBPELHNIKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5940", VA = "0x1808C6B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public ALEJKGLGAIK COJHLHPOHPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5940", VA = "0x1808C6B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D00", Offset = "0x8C5B00", VA = "0x1808C6D00")]
		public NHAPMCCEHGH FLEINPGIFCA(KBNFBDJCELI FNCGHDAFHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D00", Offset = "0x8C5B00", VA = "0x1808C6D00")]
		public ALEJKGLGAIK MPGHDMIBOOB(KBNFBDJCELI FNCGHDAFHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BA0", Offset = "0x8C59A0", VA = "0x1808C6BA0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5B40", VA = "0x1808C6D40", Slot = "5")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x8C6FD0", Offset = "0x8C5DD0", VA = "0x1808C6FD0")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C20", Offset = "0x8C5A20", VA = "0x1808C6C20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B80", Offset = "0x8C5980", VA = "0x1808C6B80")]
		public GOMCOAHDMMI BGLONHFFLKG(KBNFBDJCELI FNCGHDAFHII)
		{
			return default(GOMCOAHDMMI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x8C7080", Offset = "0x8C5E80", VA = "0x1808C7080")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(SceneService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	internal class SceneService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag IKMLCFCEKMP;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string CIGEIJHGAHF = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string LPCGHOJGLNG = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[AGIJCBMCMGO]
		private DDLBEFNOPIH MEELIDEONKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[AGIJCBMCMGO]
		private ObjectEmbodimentService EAFONAFODFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[AGIJCBMCMGO]
		private HGLBLJEIAMO LCJHLEPBNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[AGIJCBMCMGO]
		private SingletonComponentService HABLMONLMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery FMEJCGMGLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery NHOLFMKFMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery BKGKIKCEOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity ILBHLMJIGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool DEHBEHEKPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x9838A0", Offset = "0x9826A0", VA = "0x1809838A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> FNACMBCOEIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x73E910", Offset = "0x73D710", VA = "0x18073E910")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x983FF0", Offset = "0x982DF0", VA = "0x180983FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity IGDKOFCEMID
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x984200", Offset = "0x983000", VA = "0x180984200")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag IFKCGICHEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x984760", Offset = "0x983560", VA = "0x180984760")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity MMDGAALGPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x984760", Offset = "0x983560", VA = "0x180984760")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x983DD0", Offset = "0x982BD0", VA = "0x180983DD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x984560", Offset = "0x983360", VA = "0x180984560")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x983980", Offset = "0x982780", VA = "0x180983980", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x983BA0", Offset = "0x9829A0", VA = "0x180983BA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x983BE0", Offset = "0x9829E0", VA = "0x180983BE0")]
		public void EOGLCEEEGIO(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x983A60", Offset = "0x982860", VA = "0x180983A60")]
		public NativeArray<Entity> CKKNEONDPME(Allocator CMCENMLGNBG = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x983E40", Offset = "0x982C40", VA = "0x180983E40")]
		public void HCFCELFJALA(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x9838F0", Offset = "0x9826F0", VA = "0x1809838F0")]
		public Entity BFOIFPDNOAP(string CCEKFDNIAPD = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x984610", Offset = "0x983410", VA = "0x180984610")]
		public void MCNDGAHGCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x984740", Offset = "0x983540", VA = "0x180984740")]
		public void MJLNAPCEDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x9852D0", Offset = "0x9840D0", VA = "0x1809852D0")]
		public void PBPPPDJNGDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x983970", Offset = "0x982770", VA = "0x180983970")]
		public void BIDMCBACFKL(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x9840B0", Offset = "0x982EB0", VA = "0x1809840B0")]
		public bool IPBDMMAFFEH(Entity LICHDNGOEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x984350", Offset = "0x983150", VA = "0x180984350")]
		public void KBKJPFLEPBL(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x984630", Offset = "0x983430", VA = "0x180984630")]
		public string MHPGHBABIOM(Entity LICHDNGOEKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		public void HNHHIONMLKA(Entity LICHDNGOEKH, string CCEKFDNIAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x983C20", Offset = "0x982A20", VA = "0x180983C20")]
		public bool FFOHKJKBPLI(string CCEKFDNIAPD, out Entity LICHDNGOEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x983A90", Offset = "0x982890", VA = "0x180983A90")]
		public void CMDKFMDFEON(Entity LICHDNGOEKH, bool JOJEGLMMLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x984B60", Offset = "0x983960", VA = "0x180984B60")]
		public void OENNIBNLJAI(Entity DNMNICOEECM, bool KMKCLNPFHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x984CD0", Offset = "0x983AD0", VA = "0x180984CD0")]
		public void OENNIBNLJAI(NativeArray<Entity> JFFJECJPHEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x984BE0", Offset = "0x9839E0", VA = "0x180984BE0")]
		public void OENNIBNLJAI(EntityQuery EFCFIFNMPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x984D40", Offset = "0x983B40", VA = "0x180984D40")]
		public void OEOKNENEENH(Entity DNMNICOEECM, Entity LICHDNGOEKH, bool KMKCLNPFHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x984F70", Offset = "0x983D70", VA = "0x180984F70")]
		public void OEOKNENEENH(NativeArray<Entity> JFFJECJPHEB, Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x985150", Offset = "0x983F50", VA = "0x180985150")]
		public void OEOKNENEENH(EntityQuery EFCFIFNMPEK, Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x9843B0", Offset = "0x9831B0", VA = "0x1809843B0")]
		private void LFFHFOCOGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x984360", Offset = "0x983160", VA = "0x180984360")]
		private void KEHKLOAFHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x984200", Offset = "0x983000", VA = "0x180984200")]
		private Entity JKDNHMMHFKJ()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x984000", Offset = "0x982E00", VA = "0x180984000")]
		private void INOAAKNCEFE(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x984A90", Offset = "0x983890", VA = "0x180984A90")]
		private void OCNBKPFNDML(EntityQuery MLAIIEAJJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x9847B0", Offset = "0x9835B0", VA = "0x1809847B0")]
		private void OCNBKPFNDML(NativeArray<Entity> HAOGFLCGAPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x983F40", Offset = "0x982D40", VA = "0x180983F40")]
		private void HGGBJAKDOCE(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x983C40", Offset = "0x982A40", VA = "0x180983C40")]
		private void FNLKFLHEEFL(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x984160", Offset = "0x982F60", VA = "0x180984160")]
		private void JAOGKAJCHCF(SceneTag EOJLMFKFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x984390", Offset = "0x983190", VA = "0x180984390")]
		private void KKLCBGNCDKF(SceneTag EOJLMFKFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x985330", Offset = "0x984130", VA = "0x180985330")]
		private void PKHHHNBAIIB(SceneTag EOJLMFKFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x985200", Offset = "0x984000", VA = "0x180985200")]
		private void OPCAJBKLIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x523B6E0", Offset = "0x523A4E0", VA = "0x18523B6E0")]
		private void MNEEMIINPLF<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NHIDLANKBFI(SceneTag EOJLMFKFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x9845B0", Offset = "0x9833B0", VA = "0x1809845B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MBIJIOEHDGH(EntityQuery EFCFIFNMPEK, string CCEKFDNIAPD, SceneTag EOJLMFKFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x9852A0", Offset = "0x9840A0", VA = "0x1809852A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PBCNJNCHGBE(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void HKDPNDNACLH(Entity LICHDNGOEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[HLJOGLEHOLC(typeof(GKCAMNIKIBB), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	[ACKKCMMHKFG(MNIFKKPEEPE.PhotonRoom)]
	internal class UnitySceneService : KPALCLLIODG, GKCAMNIKIBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[AGIJCBMCMGO]
		private SceneService HAOGFLCGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> OENLPPNLJHJ;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x9932D0", Offset = "0x9920D0", VA = "0x1809932D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x9930D0", Offset = "0x991ED0", VA = "0x1809930D0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x993160", Offset = "0x991F60", VA = "0x180993160", Slot = "5")]
		public void EOGLCEEEGIO(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x992EE0", Offset = "0x991CE0", VA = "0x180992EE0", Slot = "6")]
		public bool BHKNNBGGCCK(LEDHMIGLCGN NFBLCBCBMID, Transform HAFNICDKMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x993320", Offset = "0x992120", VA = "0x180993320")]
		private bool NJENFCFBHMP(Scene LICHDNGOEKH, out Entity ACAANHONBGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992190", VA = "0x180993390")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[KNPMBINOPIG(MLNJOBCAIAM.ComponentSystemTypes)]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : KPALCLLIODG, DOKJEHLBPKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[AGIJCBMCMGO]
		private HGLBLJEIAMO LCJHLEPBNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity DNMNICOEECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private ComponentTypeList IJKOIMBOKCL;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int EKAGFOMELON
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x989D50", Offset = "0x988B50", VA = "0x180989D50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity LKLOOGFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager CKACCKOKEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x98A0D0", Offset = "0x988ED0", VA = "0x18098A0D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x523CFF0", Offset = "0x523BDF0", VA = "0x18523CFF0")]
		public T HEOCMNIHPLM<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x523D0B0", Offset = "0x523BEB0", VA = "0x18523D0B0")]
		public void LMMFIPJEJPN<T>(T DPJGMDFEIDL) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x989CE0", Offset = "0x988AE0", VA = "0x180989CE0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x989B40", Offset = "0x988940", VA = "0x180989B40", Slot = "5")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x989B40", Offset = "0x988940", VA = "0x180989B40")]
		private void ACOMOFBAMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x989E00", Offset = "0x988C00", VA = "0x180989E00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x98A120", Offset = "0x988F20", VA = "0x18098A120")]
		private ComponentTypeList OALLBPCHMAL()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void KCJNCCPODHL(int KNPCAAMBLKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
		private static void KLENIMCFLFJ(Type LAKBKKJKBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x989D60", Offset = "0x988B60", VA = "0x180989D60")]
		private static void CIGAGOCMPHL(Type LAKBKKJKBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct GMLAJELNCDI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[HLJOGLEHOLC(typeof(EHFLPEEKACO), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal sealed class EHFLPEEKACO : KPALCLLIODG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[AGIJCBMCMGO]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::INNNKMFPNPD<FAKMBACIFKP, Entity> AJMIPKHJBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::JGINJLKIIMG<PGGKNDBLPKI> KODPBPKDFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::JGINJLKIIMG<BKPDLKFCJIL> BKDOGHFNMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::JGINJLKIIMG<HIODNGJLJON> JHLKAHNECEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::JGINJLKIIMG<JFPIGCHENNN> EOOEMPACGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::JGINJLKIIMG<IGNEIKCMOOH> CFFMBLMAMOD;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::EHDBDBMNLKF<Entity> HFPNCBBMDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public HHDIDEJHIBI LGNOMDOCIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public HHDIDEJHIBI OBCCEIKJMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public HHDIDEJHIBI LANHIBIFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public HHDIDEJHIBI GGDAIMBEMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public HHDIDEJHIBI PHDHJMNGHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A70", Offset = "0x6C4870", VA = "0x1806C5A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x90DF90", Offset = "0x90CD90", VA = "0x18090DF90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x90DD90", Offset = "0x90CB90", VA = "0x18090DD90", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x90DEA0", Offset = "0x90CCA0", VA = "0x18090DEA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x3486DC0", Offset = "0x3485BC0", VA = "0x183486DC0")]
	private void NEOFEBEOAIM<T>(ref global::JGINJLKIIMG<T> MDAGBLFAAKK) where T : struct, KMKIHICBCMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x3486DC0", Offset = "0x3485BC0", VA = "0x183486DC0")]
	private void NEOFEBEOAIM<TC, TV>(ref global::INNNKMFPNPD<TC, TV> MDAGBLFAAKK) where TC : struct, KMKIHICBCMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public EHFLPEEKACO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[HLJOGLEHOLC(typeof(GKMIKEJGNKB), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
internal sealed class GKMIKEJGNKB : CCIFGMMGDFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private CLKHLCOEDFF NCNLGPFPDCO;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public CLKHLCOEDFF GBBLLGNPGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0xA23B00", Offset = "0xA22900", VA = "0x180A23B00")]
		get
		{
			return default(CLKHLCOEDFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0xA23AB0", Offset = "0xA228B0", VA = "0x180A23AB0", Slot = "4")]
	public void GCGEIOIGLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0xA23AA0", Offset = "0xA228A0", VA = "0x180A23AA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public GKMIKEJGNKB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(TransformOwnershipPhase), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum FBIOEPEAALM
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct FMCCCIHMGNE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private FBIOEPEAALM HFGDHPEOBEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase KICGHGEEADG;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x11AD7B0", Offset = "0x11AC5B0", VA = "0x1811AD7B0")]
			public FMCCCIHMGNE(TransformOwnershipPhase KICGHGEEADG, FBIOEPEAALM FNCGHDAFHII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x11AD790", Offset = "0x11AC590", VA = "0x1811AD790", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FBIOEPEAALM FNCGHDAFHII;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public FBIOEPEAALM BNCFLOFCEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
			get
			{
				return default(FBIOEPEAALM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x85DB50", Offset = "0x85C950", VA = "0x18085DB50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool INMPJMLMDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x98D790", Offset = "0x98C590", VA = "0x18098D790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool OGPJALMHMLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x98D750", Offset = "0x98C550", VA = "0x18098D750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x98D720", Offset = "0x98C520", VA = "0x18098D720")]
		public FMCCCIHMGNE FBIOEJIKLKG()
		{
			return default(FMCCCIHMGNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x98D760", Offset = "0x98C560", VA = "0x18098D760")]
		public FMCCCIHMGNE KJDAOEJGCBO()
		{
			return default(FMCCCIHMGNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[HLJOGLEHOLC(typeof(OKGNFHNECDL), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Circuits)]
	public class CircuitsService : KPALCLLIODG, OKGNFHNECDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[AGIJCBMCMGO]
		private DJOLAALEHNH IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager ECFOMHOIDDI;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x8FEEA0", Offset = "0x8FDCA0", VA = "0x1808FEEA0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x8FEF40", Offset = "0x8FDD40", VA = "0x1808FEF40", Slot = "5")]
		public bool DELNAOHBIKH(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5E0", Offset = "0x8FE3E0", VA = "0x1808FF5E0", Slot = "7")]
		public Guid GIMGPJHBLII(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x8FFC40", Offset = "0x8FEA40", VA = "0x1808FFC40", Slot = "8")]
		public void LKCONFMIEEN(LEDHMIGLCGN NFBLCBCBMID, Guid PKGNLGPDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x8FF510", Offset = "0x8FE310", VA = "0x1808FF510", Slot = "9")]
		public Guid GAOBMKCDGBG(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x8FF040", Offset = "0x8FDE40", VA = "0x1808FF040", Slot = "10")]
		public void EFFGBIPBIBO(LEDHMIGLCGN NFBLCBCBMID, Guid LHEEOHKMAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2A0", Offset = "0x8FE0A0", VA = "0x1808FF2A0", Slot = "11")]
		public bool EFGAPIDIDDO(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEA0", Offset = "0x8FECA0", VA = "0x1808FFEA0", Slot = "12")]
		public void MIOJPMNDEEG(LEDHMIGLCGN NFBLCBCBMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6B0", Offset = "0x8FE4B0", VA = "0x1808FF6B0", Slot = "13")]
		public void JNOCOKOHDCK(LEDHMIGLCGN KMOIJDECCNO, LEDHMIGLCGN KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2F0", Offset = "0x8FE0F0", VA = "0x1808FF2F0")]
		private void FBHJKLGIOFN(GOGLPNECKNO PJKKONINHJA, LEDHMIGLCGN KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF70", Offset = "0x8FED70", VA = "0x1808FFF70")]
		private void PIDMPGMMPKC(GOGLPNECKNO PJKKONINHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA70", Offset = "0x8FE870", VA = "0x1808FFA70")]
		private bool LDHDGABABIC(HMIODAKHEJO LOPIEGGIDMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x8FF460", Offset = "0x8FE260", VA = "0x1808FF460")]
		private bool FLELGBOOOFC(HMIODAKHEJO LOPIEGGIDMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF10", Offset = "0x8FED10", VA = "0x1808FFF10", Slot = "6")]
		public bool NNMJDCLHOLN(LEDHMIGLCGN BHMKDBDFPKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[KNPMBINOPIG(MLNJOBCAIAM.Connectables)]
	[HLJOGLEHOLC(typeof(JEIJICDMMNL), new string[] { })]
	internal class ConnectableService : JEIJICDMMNL, KPALCLLIODG, DOKJEHLBPKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class DECCDFNGKAI : IEnumerable<LEDHMIGLCGN>, IEnumerable, IEnumerator<LEDHMIGLCGN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private LEDHMIGLCGN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private LEDHMIGLCGN localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public LEDHMIGLCGN <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private LEDHMIGLCGN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(LEDHMIGLCGN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x97EEC0", Offset = "0x97DCC0", VA = "0x18097EEC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x97F080", Offset = "0x97DE80", VA = "0x18097F080")]
			[DebuggerHidden]
			public DECCDFNGKAI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x97EF10", Offset = "0x97DD10", VA = "0x18097EF10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x97EAD0", Offset = "0x97D8D0", VA = "0x18097EAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x97EFE0", Offset = "0x97DDE0", VA = "0x18097EFE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x97F030", Offset = "0x97DE30", VA = "0x18097F030")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x97EE80", Offset = "0x97DC80", VA = "0x18097EE80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x97EDD0", Offset = "0x97DBD0", VA = "0x18097EDD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LEDHMIGLCGN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x97EDD0", Offset = "0x97DBD0", VA = "0x18097EDD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly EKGLDANHPKF JIHLMGONGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int CMONADLBAOD = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int HIPFNMKPGBD = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private OIHJCGPPHNA PFGOIEFLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private CCMKEKPGHLC IDFDCEEBKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService KOJBMKIIGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::AMBLIANEJIB<Entity> LIDACGEGJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::AMBLIANEJIB<float3> BBDJNHEOALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::AMBLIANEJIB<quaternion> FAHENCMHLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::AMBLIANEJIB<Entity> KICGHGEEADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::AMBLIANEJIB<float3> OECGCOHJOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::AMBLIANEJIB<quaternion> JILDBBFONDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> LLAHKKJBJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> KJHELPOMNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery HADGFDINLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool DNDEJBANJLE;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<OEGOLGMLKMD> CLFPEFFIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x82A0D0", Offset = "0x828ED0", VA = "0x18082A0D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x82ED20", Offset = "0x82DB20", VA = "0x18082ED20", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<LEDHMIGLCGN, LEDHMIGLCGN> GLHNNABMEMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x9043E0", Offset = "0x9031E0", VA = "0x1809043E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x904B00", Offset = "0x903900", VA = "0x180904B00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<LEDHMIGLCGN, LEDHMIGLCGN> PAOAOIMKNEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x904480", Offset = "0x903280", VA = "0x180904480", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x9056C0", Offset = "0x9044C0", VA = "0x1809056C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<LEDHMIGLCGN, LEDHMIGLCGN, LEDHMIGLCGN> IIOKPEIMEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x9052D0", Offset = "0x9040D0", VA = "0x1809052D0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x903D10", Offset = "0x902B10", VA = "0x180903D10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<LEDHMIGLCGN> POPLHAEAPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x905590", Offset = "0x904390", VA = "0x180905590", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x9046D0", Offset = "0x9034D0", VA = "0x1809046D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x904090", Offset = "0x902E90", VA = "0x180904090", Slot = "25")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x904E30", Offset = "0x903C30", VA = "0x180904E30", Slot = "26")]
		public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x904520", Offset = "0x903320", VA = "0x180904520", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x905370", Offset = "0x904170", VA = "0x180905370")]
		private void LIJLFCGBIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x904990", Offset = "0x903790", VA = "0x180904990")]
		private void GCACPFOFAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x9053D0", Offset = "0x9041D0", VA = "0x1809053D0")]
		private void LJCBOKKLEBG(Entity DNMNICOEECM, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE EPJLLOJPHCA, LDOGLLBKONE ABCKFOPNDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x903DB0", Offset = "0x902BB0", VA = "0x180903DB0")]
		private void ACMKGHKEPDP(Entity DNMNICOEECM, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE EPJLLOJPHCA, LDOGLLBKONE ABCKFOPNDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x9013F0", Offset = "0x9001F0", VA = "0x1809013F0", Slot = "14")]
		public LEDHMIGLCGN BNKENCCBNJA(LEDHMIGLCGN NFBLCBCBMID, int ENMCODDNBNM)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5940", Offset = "0x7A4740", VA = "0x1807A5940", Slot = "15")]
		public Color ENCOJLMEDFJ(LEDHMIGLCGN NFBLCBCBMID, int ENMCODDNBNM)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x905810", Offset = "0x904610", VA = "0x180905810", Slot = "16")]
		public float3 PLKIIEMFGNH(LEDHMIGLCGN NFBLCBCBMID, int ENMCODDNBNM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x905760", Offset = "0x904560", VA = "0x180905760", Slot = "17")]
		public bool PFKDFNPJHGJ(LEDHMIGLCGN NFBLCBCBMID, LEDHMIGLCGN BLBGHDKPCFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x904D80", Offset = "0x903B80", VA = "0x180904D80", Slot = "18")]
		public LEDHMIGLCGN JJBBKGJKGEO(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x904BA0", Offset = "0x9039A0", VA = "0x180904BA0", Slot = "21")]
		public void HOIGOJPENBF(LEDHMIGLCGN NFBLCBCBMID, Vector3 PMHDGDIENPO, Quaternion PDOMJMCMHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x904770", Offset = "0x903570", VA = "0x180904770", Slot = "23")]
		public float3 FNIIEDKCBOI(JIKGBHEIAHO EAEEAMGKELJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x905630", Offset = "0x904430", VA = "0x180905630", Slot = "24")]
		public quaternion MDJNCMMEEOF(JIKGBHEIAHO EAEEAMGKELJ)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x9059F0", Offset = "0x9047F0", VA = "0x1809059F0", Slot = "28")]
		public RigidTransform PMEAOIGJAED(JIKGBHEIAHO EAEEAMGKELJ)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x904810", Offset = "0x903610", VA = "0x180904810", Slot = "22")]
		public bool FPBHHBDHPPL(LEDHMIGLCGN NFBLCBCBMID, out RigidTransform LODMKGEPCAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x904CF0", Offset = "0x903AF0", VA = "0x180904CF0", Slot = "19")]
		[IteratorStateMachine(typeof(DECCDFNGKAI))]
		public IEnumerable<LEDHMIGLCGN> IJDBJGLGPDB(LEDHMIGLCGN NFBLCBCBMID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x903F30", Offset = "0x902D30", VA = "0x180903F30", Slot = "20")]
		public LEDHMIGLCGN AMJLMHGIBEF(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x904210", Offset = "0x903010", VA = "0x180904210", Slot = "29")]
		public void CPFMEGLJPCL(ref List<LEDHMIGLCGN> FAEPHALCHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x903E10", Offset = "0x902C10", VA = "0x180903E10")]
		private Entity AMJLMHGIBEF(Entity DNMNICOEECM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x905B80", Offset = "0x904980", VA = "0x180905B80")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	[HLJOGLEHOLC(typeof(ObjectInstantiationService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Prefabs)]
	internal sealed class ObjectInstantiationService : KPALCLLIODG
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP DJCIICEJFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[AGIJCBMCMGO]
		private NOOFHADLCDP HMLBNAANBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[AGIJCBMCMGO]
		private DJLEFFBIDHF NFJGOJNDBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[AGIJCBMCMGO]
		private ObjectNetworkToLocalMapService JKFEKEAGDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[AGIJCBMCMGO]
		private ObjectLifecycleService EEIMFPOJEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[AGIJCBMCMGO]
		private ObjectPrefabs ONDFKMMBLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[AGIJCBMCMGO]
		private BKCKABBABHB HOAMJEOLDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private JMGAEOJCJBO LCFPMBEHBDN;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int JMMHIHALELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x8B5AC0", Offset = "0x8B48C0", VA = "0x1808B5AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x8B5880", Offset = "0x8B4680", VA = "0x1808B5880", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x8B5EB0", Offset = "0x8B4CB0", VA = "0x1808B5EB0")]
		public Entity KFPFEMMHDDG(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x8B5ED0", Offset = "0x8B4CD0", VA = "0x1808B5ED0")]
		public Entity NMBKONPBDBE(IJJNJPIJDOH OJMDJGIIFAA, FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D40", Offset = "0x8B4B40", VA = "0x1808B5D40")]
		public Entity HANFBOOMCII(FIMAOKHBMMB JPILKLCBOKG, bool LEELDADPDHC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DD0", Offset = "0x8B4BD0", VA = "0x1808B5DD0")]
		public Entity HANFBOOMCII(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5FB0", Offset = "0x8B4DB0", VA = "0x1808B5FB0")]
		public Entity PMJHHFAPJMP()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F30", Offset = "0x8B4D30", VA = "0x1808B5F30")]
		public Entity OAEDBDNFBBP(MKFEGIBJCLL LAKBKKJKBPK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E30", Offset = "0x8B4C30", VA = "0x1808B5E30")]
		public Entity KCCBGGDPNAH(GGPGKEMMOBN LAKBKKJKBPK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A10", Offset = "0x8B4810", VA = "0x1808B5A10")]
		public NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)> ECIGONMMNAN(NativeArray<LEDHMIGLCGN> KCACLEAMEOJ, Allocator CMCENMLGNBG)
		{
			return default(NativeArray<(LEDHMIGLCGN, LEDHMIGLCGN)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DE0", Offset = "0x8B4BE0", VA = "0x1808B5DE0")]
		public IEnumerable<FIMAOKHBMMB> HLDPLKDOLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x8B59B0", Offset = "0x8B47B0", VA = "0x1808B59B0")]
		public EntityArchetype EABGDPFGKPK(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A60", Offset = "0x8B4860", VA = "0x1808B5A60")]
		public Entity FAMCPGLLPJB(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x8B5CC0", Offset = "0x8B4AC0", VA = "0x1808B5CC0")]
		private Entity GEKHHFBPIFN(FIMAOKHBMMB JPILKLCBOKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B10", Offset = "0x8B4910", VA = "0x1808B5B10")]
		private Entity GEKHHFBPIFN(FIMAOKHBMMB JPILKLCBOKG, bool LEELDADPDHC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B49A0", VA = "0x1808B5BA0")]
		private Entity GEKHHFBPIFN(FIMAOKHBMMB JPILKLCBOKG, IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[KNPMBINOPIG(MLNJOBCAIAM.Physics)]
	[HLJOGLEHOLC(typeof(IMIJPLGBEGF), new string[] { })]
	public sealed class PhysicsSceneColliderService : IMIJPLGBEGF, GMBHOGJHLFH, CCIFGMMGDFO, KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string BOJEHIDHHAO = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int OLAGDFJFPGP = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int GFGJALFOAEP = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[AGIJCBMCMGO]
		private JPBNEEDJLKP GABFGDHMPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] BBNCKAMMFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] KAFINEDHDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::PNLCOEEFLCB<GBCGPCOGJKJ, BoxCollider> KFOMNAHBJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene LICHDNGOEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene EANJGPKMMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject MDFMPPCALJP;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int EGDKHGBMFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x8C1290", Offset = "0x8C0090", VA = "0x1808C1290", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x8C0E00", Offset = "0x8BFC00", VA = "0x1808C0E00", Slot = "9")]
		public void GCGEIOIGLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x8C0710", Offset = "0x8BF510", VA = "0x1808C0710", Slot = "10")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x8C0D00", Offset = "0x8BFB00", VA = "0x1808C0D00", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F70", Offset = "0x8BFD70", VA = "0x1808C0F70", Slot = "4")]
		public GBCGPCOGJKJ GLAAOFPAJPH(Entity DNMNICOEECM)
		{
			return default(GBCGPCOGJKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x8C0AE0", Offset = "0x8BF8E0", VA = "0x1808C0AE0", Slot = "5")]
		public void DGAOCNCAEPI(NativeArray<GBCGPCOGJKJ> NEJGCKJBOLM, NativeArray<GKLPACFDNKH> EIJJIFHMJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x8C10F0", Offset = "0x8BFEF0", VA = "0x1808C10F0", Slot = "6")]
		public void HNHFBBHPKPF(GBCGPCOGJKJ ODABKCNLMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1780", Offset = "0x8C0580", VA = "0x1808C1780", Slot = "7")]
		public bool NOFKFGLKKCP(GBCGPCOGJKJ ODABKCNLMCP, out Collider OGJBFFBMNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1470", Offset = "0x8C0270", VA = "0x1808C1470")]
		public bool NHJCBNIIGDP(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, Allocator CMCENMLGNBG, out NativeArray<Entity> JFFJECJPHEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x8C1820", Offset = "0x8C0620", VA = "0x1808C1820")]
		private void PHFNKCDCOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x7CA140", Offset = "0x7C8F40", VA = "0x1807CA140")]
		private void LELGFCNGJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x8C11C0", Offset = "0x8BFFC0", VA = "0x1808C11C0")]
		private void JGBDABBAIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x85D480", Offset = "0x85C280", VA = "0x18085D480")]
		private void AMHJDMIICEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x8C07D0", Offset = "0x8BF5D0", VA = "0x1808C07D0")]
		private BoxCollider CHPPDJNEMII(Entity DNMNICOEECM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x8C1210", Offset = "0x8C0010", VA = "0x1808C1210")]
		private void JNOLCAIFPBC(BoxCollider MCIIFODAPLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x8C1310", Offset = "0x8C0110", VA = "0x1808C1310")]
		[Conditional("UNITY_EDITOR")]
		private void LDEPLLHLPEI(GameObject NGIKODIIBGN, Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x8C08F0", Offset = "0x8BF6F0", VA = "0x1808C08F0")]
		private void CNLCJJDHLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x8C1360", Offset = "0x8C0160", VA = "0x1808C1360")]
		private void MPJLHABLLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x8C0500", Offset = "0x8BF300", VA = "0x1808C0500")]
		private void BBHJHFIMNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x8C10C0", Offset = "0x8BFEC0", VA = "0x1808C10C0")]
		private void HJDHGGNDKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x8C1350", Offset = "0x8C0150", VA = "0x1808C1350")]
		private void LEKOOCPEBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x8C12D0", Offset = "0x8C00D0", VA = "0x1808C12D0")]
		private void KFOMOHMGICO(Scene MDGCLGDDBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CF0", Offset = "0x8BFAF0", VA = "0x1808C0CF0", Slot = "8")]
		private bool DLMIHOJPJBK(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, Allocator CMCENMLGNBG, out NativeArray<Entity> JFFJECJPHEB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[HLJOGLEHOLC(typeof(GENPLKLONFI), new string[] { })]
public sealed class PLCJAGDLGOE : GENPLKLONFI, KPALCLLIODG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct KHICOIKDPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float OEOAFHEGLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint HHNFALMCDEE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private GMBHOGJHLFH PAHCHBPMCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private BDPOPDIKHDC CJHNKNNNJDP;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x8BF920", Offset = "0x8BE720", VA = "0x1808BF920", Slot = "5")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x8BFAD0", Offset = "0x8BE8D0", VA = "0x1808BFAD0")]
	public bool NHJCBNIIGDP(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, out IJOFMMLNBAM HFPKDFNHOAJ, out Entity FMDNGJGBJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9D0", Offset = "0x8BE7D0", VA = "0x1808BF9D0")]
	public static bool KGHCNBCDGDB(in Span<IJOFMMLNBAM> CKMDCJFLNGJ, float LEEANLGODCO, out int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x8BF990", Offset = "0x8BE790", VA = "0x1808BF990")]
	public static float FEACMOMFFHC(float OEOAFHEGLMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PLCJAGDLGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9C0", Offset = "0x8BE7C0", VA = "0x1808BF9C0", Slot = "4")]
	private bool FLKMBFHIMFD(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, out IJOFMMLNBAM HFPKDFNHOAJ, out Entity FMDNGJGBJNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[HLJOGLEHOLC(typeof(BDPOPDIKHDC), new string[] { })]
public sealed class MIOMNOPIFGF : BDPOPDIKHDC, KPALCLLIODG
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct PGOPBNNJOEK : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> JFFJECJPHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 BNBNMEJHJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 JJKICIBOOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> OBJKAMJLPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> NGAGCEEMEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NGPLDAOGIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> IEIFKPFFBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> FPJFHNGIPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<IJOFMMLNBAM> CILDDPOBAAH;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly IJOFMMLNBAM EMBHFDEGJML;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x11B3720", Offset = "0x11B2520", VA = "0x1811B3720", Slot = "4")]
		public void Execute(int DJIEOHJNDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x11B3B00", Offset = "0x11B2900", VA = "0x1811B3B00")]
		private static float3 HMHPMFLNGGF(in float4x4 OFKDBIKJMLI, in float3 KDPJHAGCGIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x11B3560", Offset = "0x11B2360", VA = "0x1811B3560")]
		private static float3 DOPAAKOAEJP(in float4x4 OFKDBIKJMLI, in float3 IDCGKPGHNKC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x11B3A00", Offset = "0x11B2800", VA = "0x1811B3A00")]
		private static float3 FIBLAIMFALB(in float4x4 OFKDBIKJMLI, in float3 KDPJHAGCGIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x11B3BD0", Offset = "0x11B29D0", VA = "0x1811B3BD0")]
		private static float3 KICCHNIJHGJ(in float4x4 OFKDBIKJMLI, in float3 IDCGKPGHNKC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x11B3DF0", Offset = "0x11B2BF0", VA = "0x1811B3DF0")]
		private bool ONJEJNKLCMC(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, in NativeArray<Entity> AMJGHBNGBMJ, out float3 HFPKDFNHOAJ, out float3 NEDOMCCPNJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x11B2E90", Offset = "0x11B1C90", VA = "0x1811B2E90")]
		public static bool CCANFKJDMIK(in float3 JKCDBBMOCBM, in float3 MKNOJCPAJIP, in float3 EFAGFLHMJOB, in float3 AKAGKDGKJOI, float KAACDLLENJD, float GMOCFACOONN, out float DKOBICODCGH, out float3 CEPNAELMOEI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager ECFOMHOIDDI;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x8A8F40", Offset = "0x8A7D40", VA = "0x1808A8F40", Slot = "5")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x8A8FD0", Offset = "0x8A7DD0", VA = "0x1808A8FD0")]
	public void NHJCBNIIGDP(in NativeArray<Entity> JFFJECJPHEB, in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, in NativeArray<IJOFMMLNBAM> PFEIENOFFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public MIOMNOPIFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x8A8FC0", Offset = "0x8A7DC0", VA = "0x1808A8FC0", Slot = "4")]
	private void MEJKMHGEGGF(in NativeArray<Entity> JFFJECJPHEB, in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, in NativeArray<IJOFMMLNBAM> PFEIENOFFBC)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[HLJOGLEHOLC(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[KNPMBINOPIG(MLNJOBCAIAM.Embodiment)]
	[ACKKCMMHKFG(MNIFKKPEEPE.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[AGIJCBMCMGO]
		private NMDJLEODPOP BPCGIPNNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[AGIJCBMCMGO]
		private NOOFHADLCDP JCCKEPEPFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[AGIJCBMCMGO]
		private DJLEFFBIDHF NMBAEAJDFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private NLEJJFIEGLH OONGFKGINCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<IJJNJPIJDOH, Entity> POKJIOGHBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager ECFOMHOIDDI;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<IJJNJPIJDOH, Entity> KAPPKFFMPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0x8B9410", Offset = "0x8B8210", VA = "0x1808B9410")]
			get
			{
				return default(NativeHashMap<IJJNJPIJDOH, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint JAAAKAFJIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x8B9280", Offset = "0x8B8080", VA = "0x1808B9280")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool MCKHJMONIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x79B540", Offset = "0x79A340", VA = "0x18079B540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x7A92E0", Offset = "0x7A80E0", VA = "0x1807A92E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C50", Offset = "0x8B7A50", VA = "0x1808B8C50", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E00", Offset = "0x8B7C00", VA = "0x1808B8E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x8B92B0", Offset = "0x8B80B0", VA = "0x1808B92B0")]
		public void KJHAHNAAJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x8B9000", Offset = "0x8B7E00", VA = "0x1808B9000")]
		public void ILCEIEAMEHO(IJJNJPIJDOH OJMDJGIIFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E70", Offset = "0x8B7C70", VA = "0x1808B8E70")]
		private LEDHMIGLCGN FOHAGAJHJFB(Entity DNMNICOEECM)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9330", Offset = "0x8B8130", VA = "0x1808B9330")]
		public LEDHMIGLCGN KOOGDODNOPA(IJJNJPIJDOH OJMDJGIIFAA)
		{
			return default(LEDHMIGLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D70", Offset = "0x8B7B70", VA = "0x1808B8D70")]
		public IJJNJPIJDOH DHOBLPLBCCE(LEDHMIGLCGN NFBLCBCBMID)
		{
			return default(IJJNJPIJDOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8F70", Offset = "0x8B7D70", VA = "0x1808B8F70")]
		public void IKJJBIEJENN(Entity DNMNICOEECM, IJJNJPIJDOH OJMDJGIIFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9220", Offset = "0x8B8020", VA = "0x1808B9220")]
		public void JJJOGBCGLJN(Entity DNMNICOEECM, IJJNJPIJDOH OJMDJGIIFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x8B91C0", Offset = "0x8B7FC0", VA = "0x1808B91C0")]
		public void IOGOBEPLNGO(Entity DNMNICOEECM, IJJNJPIJDOH OJMDJGIIFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EA0", Offset = "0x8B7CA0", VA = "0x1808B8EA0")]
		public void IFHMKMIECJG(Entity DNMNICOEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[HLJOGLEHOLC(typeof(PropertyEventCallbacksService), new string[] { })]
	[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
	[KNPMBINOPIG(MLNJOBCAIAM.Callbacks)]
	public class PropertyEventCallbacksService : KPALCLLIODG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct AFFCKMIBHPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public EFEGKCNPJCF JAKHBAJPHJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type LAKBKKJKBPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int LCJMNMLOPCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct INCMOBPCPIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public AFFCKMIBHPM[] DPFFDAKDAHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void EFEGKCNPJCF(Entity DNMNICOEECM, INOPGIMBOKC JFGKEENDEHE, LDOGLLBKONE EPJLLOJPHCA, LDOGLLBKONE ABCKFOPNDBL);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly EKGLDANHPKF CGFIKJKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<INOPGIMBOKC, EFEGKCNPJCF> JMBLKOGFINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, INCMOBPCPIG> NBCEAAMEAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private GNIJOOFEPBL DPFFDAKDAHJ;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action IKGHLNIFDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x8C7120", Offset = "0x8C5F20", VA = "0x1808C7120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D20", Offset = "0x8C6B20", VA = "0x1808C7D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action HIHDOBKMCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x8C7610", Offset = "0x8C6410", VA = "0x1808C7610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C6BC0", VA = "0x1808C7DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x8C71C0", Offset = "0x8C5FC0", VA = "0x1808C71C0", Slot = "4")]
		public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x8C7300", Offset = "0x8C6100", VA = "0x1808C7300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x8C7BB0", Offset = "0x8C69B0", VA = "0x1808C7BB0")]
		public void OBNDPKOJMJJ(INOPGIMBOKC JFGKEENDEHE, EFEGKCNPJCF JAKHBAJPHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7AC0", Offset = "0x8C68C0", VA = "0x1808C7AC0")]
		public void MIIFBDJOPDH(INOPGIMBOKC JFGKEENDEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x8C76B0", Offset = "0x8C64B0", VA = "0x1808C76B0")]
		internal void GOEEPBCGDOB(NHAPMCCEHGH AJCEDEPGCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7E60", Offset = "0x8C6C60", VA = "0x1808C7E60")]
		private void PJLHEOGOBNG(NHAPMCCEHGH AJCEDEPGCCG, int EDBPGCEKEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7390", Offset = "0x8C6190", VA = "0x1808C7390")]
		private void EEPBFBONAIE(KOFEPFEJINF KDFMDMEBMML, LNOFNLNFGAL ENAHMFALKMI, AFFCKMIBHPM GFDJDEMNBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7940", Offset = "0x8C6740", VA = "0x1808C7940")]
		private INCMOBPCPIG JGPCNAAHAGO(KOFEPFEJINF KDFMDMEBMML, LNOFNLNFGAL ENAHMFALKMI)
		{
			return default(INCMOBPCPIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7210", Offset = "0x8C6010", VA = "0x1808C7210")]
		private AFFCKMIBHPM DFJBKFPPGAO(INCMOBPCPIG BBOKJAJJLIM, KOFEPFEJINF KDFMDMEBMML, LNOFNLNFGAL ENAHMFALKMI)
		{
			return default(AFFCKMIBHPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x8C83F0", Offset = "0x8C71F0", VA = "0x1808C83F0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[HLJOGLEHOLC(typeof(KEEODLAFLHB), new string[] { })]
public class OEHBJLIANNI : KPALCLLIODG, DOKJEHLBPKM, KEEODLAFLHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class MOCBDJJHJNH : IEnumerable<LEDHMIGLCGN>, IEnumerable, IEnumerator<LEDHMIGLCGN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private LEDHMIGLCGN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public OEHBJLIANNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private LEDHMIGLCGN splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public LEDHMIGLCGN <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private LEDHMIGLCGN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LEDHMIGLCGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x11B13A0", Offset = "0x11B01A0", VA = "0x1811B13A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x97F080", Offset = "0x97DE80", VA = "0x18097F080")]
		[DebuggerHidden]
		public MOCBDJJHJNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x11B11F0", Offset = "0x11AFFF0", VA = "0x1811B11F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x11B1360", Offset = "0x11B0160", VA = "0x1811B1360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x11B12B0", Offset = "0x11B00B0", VA = "0x1811B12B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LEDHMIGLCGN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x11B12B0", Offset = "0x11B00B0", VA = "0x1811B12B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private NLEJJFIEGLH OONGFKGINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private FKPGBOIBNAE FLDLMCCAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService ONDFKMMBLDC;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager CKACCKOKEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x8AE650", Offset = "0x8AD450", VA = "0x1808AE650")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private AHFPALIMFBF PDMIOCKKDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC40", Offset = "0x8ACA40", VA = "0x1808ADC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB00", Offset = "0x8AC900", VA = "0x1808ADB00", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1A0", Offset = "0x8ACFA0", VA = "0x1808AE1A0", Slot = "5")]
	public void JPACDEMOODK(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB90", Offset = "0x8AC990", VA = "0x1808ADB90", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE390", Offset = "0x8AD190", VA = "0x1808AE390")]
	private void LBILKFIINDE(Entity AEDBGGHLONP, in LDOGLLBKONE MPADCHPLOPE, in LDOGLLBKONE IOMHKOCLPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB40", Offset = "0x8AD940", VA = "0x1808AEB40", Slot = "14")]
	public LEDHMIGLCGN PMJHHFAPJMP()
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2A0", Offset = "0x8AD0A0", VA = "0x1808AE2A0", Slot = "10")]
	public void KMPNJNJPLLD(LEDHMIGLCGN NFBLCBCBMID, JMNGIMIFOKO LNCKHCKJOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD30", Offset = "0x8ACB30", VA = "0x1808ADD30", Slot = "9")]
	public JMNGIMIFOKO GEPHPHMABHM(LEDHMIGLCGN NFBLCBCBMID)
	{
		return default(JMNGIMIFOKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6A0", Offset = "0x8AD4A0", VA = "0x1808AE6A0", Slot = "11")]
	public LEDHMIGLCGN MEDJFGEKGPD(LEDHMIGLCGN ONOCKEOOJHG, [Optional] Vector3? PGEIGNJBBKG, [Optional] Quaternion? BHCPPAMLLMB, [Optional] Vector3? FMNLLENGGHE)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x8AE610", Offset = "0x8AD410", VA = "0x1808AE610", Slot = "15")]
	public LEDHMIGLCGN LBOPCMFNHLD(LEDHMIGLCGN HJDGNEKLGLN, int DJIEOHJNDEK, [Optional] Vector3? PGEIGNJBBKG, [Optional] Quaternion? BHCPPAMLLMB, [Optional] Vector3? FMNLLENGGHE)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC750", VA = "0x1808AD950", Slot = "7")]
	public LEDHMIGLCGN ADPKNPCACEN(LEDHMIGLCGN HJDGNEKLGLN, int DJIEOHJNDEK)
	{
		return default(LEDHMIGLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0E0", Offset = "0x8ACEE0", VA = "0x1808AE0E0", Slot = "16")]
	public void JJDNDLELOGA(LEDHMIGLCGN HJDGNEKLGLN, LEDHMIGLCGN PMNFHCBNADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE20", Offset = "0x8ACC20", VA = "0x1808ADE20", Slot = "12")]
	public void IAHEGHDBBMJ(LEDHMIGLCGN HJDGNEKLGLN, int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x8AE9A0", Offset = "0x8AD7A0", VA = "0x1808AE9A0", Slot = "17")]
	public void MMBOLNMGOFB(LEDHMIGLCGN HJDGNEKLGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC90", Offset = "0x8ACA90", VA = "0x1808ADC90", Slot = "8")]
	public int GABACOICJLE(LEDHMIGLCGN HJDGNEKLGLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACDC0", VA = "0x1808ADFC0", Slot = "6")]
	[IteratorStateMachine(typeof(MOCBDJJHJNH))]
	public IEnumerable<LEDHMIGLCGN> IMCNEBPMKLB(LEDHMIGLCGN HJDGNEKLGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x8AE050", Offset = "0x8ACE50", VA = "0x1808AE050")]
	private bool JBHGHHBBPAD(LEDHMIGLCGN HJDGNEKLGLN, out NativeArray<Entity> PDECCELFEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA40", Offset = "0x8AC840", VA = "0x1808ADA40")]
	private NativeArray<Entity> AGPEBHOJFGK(LEDHMIGLCGN HJDGNEKLGLN)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OEHBJLIANNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[HLJOGLEHOLC(typeof(PPGCMHGINPA), new string[] { })]
[ACKKCMMHKFG(MNIFKKPEEPE.LoadInstance)]
internal sealed class PPGCMHGINPA : KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private NMDJLEODPOP DJCIICEJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase BOKGOPOBBFN;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PLMMGPNIKJM CPBIHJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x8C0340", Offset = "0x8BF140", VA = "0x1808C0340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x8C00B0", Offset = "0x8BEEB0", VA = "0x1808C00B0", Slot = "4")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x8C03F0", Offset = "0x8BF1F0", VA = "0x1808C03F0")]
	public void PDLHDBDDMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x8C0130", Offset = "0x8BEF30", VA = "0x1808C0130")]
	public void GMKHCECKFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PPGCMHGINPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct CIKDAMGJLFF : IEquatable<CIKDAMGJLFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int EDBPGCEKEHE;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type FCBCFKMJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC80", Offset = "0x8FAA80", VA = "0x1808FBC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x8FBE90", Offset = "0x8FAC90", VA = "0x1808FBE90")]
	public CIKDAMGJLFF(Type LAKBKKJKBPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x8FBDB0", Offset = "0x8FABB0", VA = "0x1808FBDB0")]
	public static CIKDAMGJLFF LJJFBFNEMCH(Type LAKBKKJKBPK)
	{
		return default(CIKDAMGJLFF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x8FBD60", Offset = "0x8FAB60", VA = "0x1808FBD60")]
	public static Type LJJFBFNEMCH(CIKDAMGJLFF ODABKCNLMCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA50", Offset = "0x6EE850", VA = "0x1806EFA50")]
	public static bool EKDLGPJCFAN(CIKDAMGJLFF EFBCPNIKEHB, CIKDAMGJLFF BFLEMGIJKLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA50", Offset = "0x6EE850", VA = "0x1806EFA50")]
	public static bool OBFGMGBJCFC(CIKDAMGJLFF EFBCPNIKEHB, CIKDAMGJLFF BFLEMGIJKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA10", Offset = "0x6EE810", VA = "0x1806EFA10", Slot = "4")]
	public bool Equals(CIKDAMGJLFF BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x8FBCE0", Offset = "0x8FAAE0", VA = "0x1808FBCE0", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x8FBE10", Offset = "0x8FAC10", VA = "0x1808FBE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class IALFFFMFDKD
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> NOJMMABBMDF;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> NOMNKLBKMNH;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0xA2D800", Offset = "0xA2C600", VA = "0x180A2D800")]
	static IALFFFMFDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F990", Offset = "0x3B4E790", VA = "0x183B4F990")]
	public static bool EKGLGHAFJEH<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0xA2D530", Offset = "0xA2C330", VA = "0x180A2D530")]
	public static bool EKGLGHAFJEH(Type LAKBKKJKBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0xA2D3C0", Offset = "0xA2C1C0", VA = "0x180A2D3C0")]
	private static bool EKGLGHAFJEH(Type LAKBKKJKBPK, out int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F900", Offset = "0x3B4E700", VA = "0x183B4F900")]
	public static int EGNOMCEFANN<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0xA2D350", Offset = "0xA2C150", VA = "0x180A2D350")]
	public static int EGNOMCEFANN(Type LAKBKKJKBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x3B4FA20", Offset = "0x3B4E820", VA = "0x183B4FA20")]
	public static bool GBLHCMBLLEL<T>(out int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0xA2D6C0", Offset = "0xA2C4C0", VA = "0x180A2D6C0")]
	public static bool GBLHCMBLLEL(Type LAKBKKJKBPK, out int DJIEOHJNDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0xA2D760", Offset = "0xA2C560", VA = "0x180A2D760")]
	public static Type HEOCMNIHPLM(int DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0xA2D5A0", Offset = "0xA2C3A0", VA = "0x180A2D5A0")]
	public static bool GBLHCMBLLEL(int DJIEOHJNDEK, out Type LAKBKKJKBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct IHOKIBELLJD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] CPLKBCGCHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int EOKNLPLGCDF;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x7CD800", Offset = "0x7CC600", VA = "0x1807CD800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x3221C90", Offset = "0x3220A90", VA = "0x183221C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> FHGODDBONKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x3736360", Offset = "0x3735160", VA = "0x183736360")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6010", VA = "0x180AB7210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x3736400", Offset = "0x3735200", VA = "0x183736400")]
	public IHOKIBELLJD(int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x37361F0", Offset = "0x3734FF0", VA = "0x1837361F0")]
	public int DMLIELKNFBC(T DPJGMDFEIDL, int CPMHNPIOINN, int KNPCAAMBLKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x37362A0", Offset = "0x37350A0", VA = "0x1837362A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct OHNLFIIJJKE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::IHOKIBELLJD<T> CPLKBCGCHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int EOKNLPLGCDF;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x325EA80", Offset = "0x325D880", VA = "0x18325EA80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int PAFNFOIPEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x325D1E0", Offset = "0x325BFE0", VA = "0x18325D1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int LOFJCNPKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x325DDD0", Offset = "0x325CBD0", VA = "0x18325DDD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x325DC40", Offset = "0x325CA40", VA = "0x18325DC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool AODFAOEBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x325E2E0", Offset = "0x325D0E0", VA = "0x18325E2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> FHGODDBONKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x325E190", Offset = "0x325CF90", VA = "0x18325E190")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x325EB80", Offset = "0x325D980", VA = "0x18325EB80")]
	public OHNLFIIJJKE(int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x325EA30", Offset = "0x325D830", VA = "0x18325EA30")]
	public T MJLCJNNHCCG(int DJIEOHJNDEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x325E530", Offset = "0x325D330", VA = "0x18325E530")]
	public void ILLJNEFMMPK(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x325DAD0", Offset = "0x325C8D0", VA = "0x18325DAD0")]
	public void CHNLCADILAL(Span<T> GHOABBJLFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x325DE00", Offset = "0x325CC00", VA = "0x18325DE00")]
	public void EKGLGHAFJEH(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x325D370", Offset = "0x325C170", VA = "0x18325D370")]
	private void AKNEOMBMOLE(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x325E7F0", Offset = "0x325D5F0", VA = "0x18325E7F0")]
	public void MHNPACKGLOM(Span<T> PDGNCDHKFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x325E790", Offset = "0x325D590", VA = "0x18325E790")]
	public void MALNPIHCJOA(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x325DF10", Offset = "0x325CD10", VA = "0x18325DF10")]
	public void FNEMHELDJIN(int NBNHMKEOAMD, int DAFMFEFJEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x325E130", Offset = "0x325CF30", VA = "0x18325E130")]
	public void FOJICMFLHIC(int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x325E320", Offset = "0x325D120", VA = "0x18325E320")]
	public void IKAJAOLCJMN(int NBNHMKEOAMD, int DAFMFEFJEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x325E660", Offset = "0x325D460", VA = "0x18325E660")]
	public void KKDBEJPOHBF(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x325E5A0", Offset = "0x325D3A0", VA = "0x18325E5A0")]
	public void JLCDPCJAECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x325DC90", Offset = "0x325CA90", VA = "0x18325DC90")]
	public int DMLIELKNFBC(T DPJGMDFEIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x325DD20", Offset = "0x325CB20", VA = "0x18325DD20")]
	public bool DOMBPGEJHPH(T DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x325DD80", Offset = "0x325CB80", VA = "0x18325DD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x325EB10", Offset = "0x325D910", VA = "0x18325EB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x325E720", Offset = "0x325D520", VA = "0x18325E720")]
	public static Span<T> LJJFBFNEMCH(global::OHNLFIIJJKE<T> GHOABBJLFEA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x325D830", Offset = "0x325C630", VA = "0x18325D830")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CBPIOMGPHEB(int DPJGMDFEIDL, int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CGLBGIJCHJF(int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x325D970", Offset = "0x325C770", VA = "0x18325D970")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void CGLBGIJCHJF(int EOKNLPLGCDF, int DJIEOHJNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x325D4F0", Offset = "0x325C2F0", VA = "0x18325D4F0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void AKPJOHMIEHA(int DPJGMDFEIDL, int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x325D630", Offset = "0x325C430", VA = "0x18325D630")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CAEEGFGDEEK(int NBNHMKEOAMD, int DAFMFEFJEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x325D230", Offset = "0x325C030", VA = "0x18325D230")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void AGKIIEJJPJM(int DPJGMDFEIDL, int EOKNLPLGCDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct CLKHLCOEDFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int DAIIBPOLLOL = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> JFFJECJPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray PFGOIEFLOBG;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int EKAGFOMELON
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x8FC640", Offset = "0x8FB440", VA = "0x1808FC640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> NCHBGDHAEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x8FC810", Offset = "0x8FB610", VA = "0x1808FC810")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray MGFIJOHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool MCKHJMONIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6A0", Offset = "0x8FB4A0", VA = "0x1808FC6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8F0", Offset = "0x8FB6F0", VA = "0x1808FC8F0")]
	public CLKHLCOEDFF(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x8FC5F0", Offset = "0x8FB3F0", VA = "0x1808FC5F0")]
	public Entity BDGAKPEMPCK(int DJIEOHJNDEK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8E0", Offset = "0x8FB6E0", VA = "0x1808FC8E0")]
	public Transform MKNIBCLKJEB(int DJIEOHJNDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x8FC650", Offset = "0x8FB450", VA = "0x1808FC650")]
	public void CAFEMNMHKCN(int DOOAOHCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x8FC740", Offset = "0x8FB540", VA = "0x1808FC740")]
	public int EKGLGHAFJEH(Transform HAFNICDKMAH, Entity DNMNICOEECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x8FC860", Offset = "0x8FB660", VA = "0x1808FC860")]
	public int MALNPIHCJOA(int DJIEOHJNDEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6C0", Offset = "0x8FB4C0", VA = "0x1808FC6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x8FC820", Offset = "0x8FB620", VA = "0x1808FC820")]
	private void KLIIDPAJCJN(int IGAILGMGBBN = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class BMKCACKDEKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<CIKDAMGJLFF, int2> GMLIBCKBKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> NGFFBKNAABM;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x8F91A0", Offset = "0x8F7FA0", VA = "0x1808F91A0")]
	public BMKCACKDEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x8F8EB0", Offset = "0x8F7CB0", VA = "0x1808F8EB0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void LMMFIPJEJPN<T>(T DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T HEOCMNIHPLM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x8F8F10", Offset = "0x8F7D10", VA = "0x1808F8F10")]
	public void LMMFIPJEJPN(Type LAKBKKJKBPK, LDOGLLBKONE DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x8F8A70", Offset = "0x8F7870", VA = "0x1808F8A70")]
	public LDOGLLBKONE HEOCMNIHPLM(Type LAKBKKJKBPK)
	{
		return default(LDOGLLBKONE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x8F8E10", Offset = "0x8F7C10", VA = "0x1808F8E10")]
	private NativeArray<byte> HMMPBDOACHI(int2 PANKGDDLAFN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x8F88B0", Offset = "0x8F76B0", VA = "0x1808F88B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x8F8950", Offset = "0x8F7750", VA = "0x1808F8950", Slot = "1")]
	~BMKCACKDEKA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct IEAOBFGNBHE<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::IEAOBFGNBHE<T> LJJFBFNEMCH(T DPJGMDFEIDL)
	{
		return default(global::IEAOBFGNBHE<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T LJJFBFNEMCH(global::IEAOBFGNBHE<T> HCMHCJOGKFN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class JJHKEJBCLDM
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly BMKCACKDEKA BOJDKPEEKOB;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0xA31D50", Offset = "0xA30B50", VA = "0x180A31D50")]
	internal static void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void LMMFIPJEJPN<T>(T DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0xA31DC0", Offset = "0xA30BC0", VA = "0x180A31DC0")]
	public static void LMMFIPJEJPN(Type LAKBKKJKBPK, LDOGLLBKONE DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T HEOCMNIHPLM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0xA31CB0", Offset = "0xA30AB0", VA = "0x180A31CB0")]
	public static LDOGLLBKONE HEOCMNIHPLM(Type LAKBKKJKBPK)
	{
		return default(LDOGLLBKONE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class CEGGJLNDLKK : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly CEGGJLNDLKK JLGGJMINNJN;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x8FBB20", Offset = "0x8FA920", VA = "0x1808FBB20", Slot = "4")]
	public bool Equals(LinkedEntityGroup IDDALCIIJOJ, LinkedEntityGroup GIJPFDNHKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x8FBB40", Offset = "0x8FA940", VA = "0x1808FBB40", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup LOPIEGGIDMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CEGGJLNDLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class CALBGIJNDGN
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void AEHBNDPIAMB(in Vector3 PGEIGNJBBKG, in Quaternion BHCPPAMLLMB, in Vector3 FMNLLENGGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void MMDOAFNIAGB(in Vector3 NCEBFPAHPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void BDCAJJADIPE(in Quaternion BHCPPAMLLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void HKALBJNEOEC(in Vector3 LHOEHBOIPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void EMOALDLOCAJ(in Vector3 LHOEHBOIPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void JOGBMPHGIKN(in float AKJKBINLMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x8FB170", Offset = "0x8F9F70", VA = "0x1808FB170")]
	[Conditional("DEBUG_BUILD")]
	public static void LIALJHPFCDC(in float3 DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	[Conditional("DEBUG_BUILD")]
	public static void LMCMKPNAKAO(in float DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x8FB250", Offset = "0x8FA050", VA = "0x1808FB250")]
	[Conditional("DEBUG_BUILD")]
	public static void LMCMKPNAKAO(in Vector3 DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x8FB220", Offset = "0x8FA020", VA = "0x1808FB220")]
	[Conditional("DEBUG_BUILD")]
	public static void LMCMKPNAKAO(in Quaternion DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x8FB310", Offset = "0x8FA110", VA = "0x1808FB310")]
	[Conditional("DEBUG_BUILD")]
	public static void PMKLCLEJFKH(in float DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x8FB2A0", Offset = "0x8FA0A0", VA = "0x1808FB2A0")]
	[Conditional("DEBUG_BUILD")]
	public static void PMKLCLEJFKH(in Vector3 DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x8FB2E0", Offset = "0x8FA0E0", VA = "0x1808FB2E0")]
	[Conditional("DEBUG_BUILD")]
	public static void PMKLCLEJFKH(in Quaternion DPJGMDFEIDL, string IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public CALBGIJNDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct DHHOEPAHABD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity DNMNICOEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity JEAPMLEICDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity DDNBMNPALIB;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x90B6F0", Offset = "0x90A4F0", VA = "0x18090B6F0")]
	public DHHOEPAHABD(Entity DNMNICOEECM, Entity JEAPMLEICDM, Entity DDNBMNPALIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x90B690", Offset = "0x90A490", VA = "0x18090B690")]
	public static DHHOEPAHABD LJJFBFNEMCH((Entity entity, Entity oldParent, Entity newParent) OAAGPGADKLN)
	{
		return default(DHHOEPAHABD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x90B6D0", Offset = "0x90A4D0", VA = "0x18090B6D0")]
	public void MAEJFMCOHNB(out Entity DNMNICOEECM, out Entity JEAPMLEICDM, out Entity DDNBMNPALIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct KFJMJFAJGPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity DNMNICOEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity KICGHGEEADG;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0xA33D30", Offset = "0xA32B30", VA = "0x180A33D30")]
	public KFJMJFAJGPB(Entity DNMNICOEECM, Entity KICGHGEEADG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0xA33CF0", Offset = "0xA32AF0", VA = "0x180A33CF0")]
	public static KFJMJFAJGPB LJJFBFNEMCH((Entity entity, Entity parent) OAAGPGADKLN)
	{
		return default(KFJMJFAJGPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0xA33D20", Offset = "0xA32B20", VA = "0x180A33D20")]
	public void MAEJFMCOHNB(out Entity DNMNICOEECM, out Entity KICGHGEEADG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct JCHBINCGMMD<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle ODABKCNLMCP;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool PINFPDGINOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA22C50", Offset = "0xA21A50", VA = "0x180A22C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x3AF24C0", Offset = "0x3AF12C0", VA = "0x183AF24C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2400", Offset = "0x3AF1200", VA = "0x183AF2400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2560", Offset = "0x3AF1360", VA = "0x183AF2560")]
	public JCHBINCGMMD(T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF23D0", Offset = "0x3AF11D0", VA = "0x183AF23D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum PIGMGOBOCOJ
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct JMPBHAINDLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public PIGMGOBOCOJ KHACDPLAFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int EPHAANJKGJD;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
	public JMPBHAINDLE(PIGMGOBOCOJ KHACDPLAFAB, int EPHAANJKGJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCB0", Offset = "0xA2CAB0", VA = "0x180A2DCB0")]
	public static JMPBHAINDLE LJJFBFNEMCH((PIGMGOBOCOJ eventType, int eventIndex) IDDALCIIJOJ)
	{
		return default(JMPBHAINDLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0xA33B10", Offset = "0xA32910", VA = "0x180A33B10")]
	public void MAEJFMCOHNB(out PIGMGOBOCOJ KHACDPLAFAB, out int EPHAANJKGJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[HLJOGLEHOLC(typeof(GMBHOGJHLFH), new string[] { })]
public sealed class BEOIJHOECJL : GMBHOGJHLFH, KPALCLLIODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private IMIJPLGBEGF AAJELFDMDLB;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x8F72C0", Offset = "0x8F60C0", VA = "0x1808F72C0", Slot = "5")]
	public void BKKGDHIMDBE(KEOFLKLFAOP OPNLEKFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x8F7310", Offset = "0x8F6110", VA = "0x1808F7310")]
	public bool NHJCBNIIGDP(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, Allocator CMCENMLGNBG, out NativeArray<Entity> JFFJECJPHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public BEOIJHOECJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x8F7310", Offset = "0x8F6110", VA = "0x1808F7310", Slot = "4")]
	private bool DLMIHOJPJBK(in float3 MEFJJPHNCLK, in float3 EDKNJDMPJNA, float LEEANLGODCO, Allocator CMCENMLGNBG, out NativeArray<Entity> JFFJECJPHEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[LFNIFJENOAD]
[UpdateInGroup(typeof(GNJLGPCGPID))]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal sealed class GHCLCIALLFI : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0xA230B0", Offset = "0xA21EB0", VA = "0x180A230B0", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public GHCLCIALLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[LFNIFJENOAD]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
[UpdateInGroup(typeof(NLAFGDLINMH))]
public sealed class LMOKIKAHBAF : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0xA38570", Offset = "0xA37370", VA = "0x180A38570", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public LMOKIKAHBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[LFNIFJENOAD]
[UpdateInGroup(typeof(KAPEMOBMPCL))]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
internal sealed class FPFLDLDFLIL : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0xA21B30", Offset = "0xA20930", VA = "0x180A21B30", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public FPFLDLDFLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class OAADPHBLCGP : LNHODKLBMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public OAADPHBLCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[LFNIFJENOAD]
[LDMGGBBOHCI(MNIFKKPEEPE.LoadInstance)]
[UpdateInGroup(typeof(NCCILOIGODH))]
internal sealed class KAPMPBPLDOG : MMMECBJBGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0xA33C10", Offset = "0xA32A10", VA = "0x180A33C10", Slot = "16")]
	protected override ComponentSystemBase IIKDJGDEJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7F0", Offset = "0x8AB5F0", VA = "0x1808AC7F0")]
	public KAPMPBPLDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[OOMLJFNMBNM(typeof(AuthoredLocalPoseData))]
public sealed class IEEJJLNLJGL : NJKOPLELIKH
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0xA2DDA0", Offset = "0xA2CBA0", VA = "0x180A2DDA0", Slot = "8")]
	protected override bool NFEBCKMEODN(ReadOnlySpan<AuthoredLocalPoseData> PDGNCDHKFCJ, IFAEDNBIFMG LAKAALEJDAJ, out ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0xA2DCE0", Offset = "0xA2CAE0", VA = "0x180A2DCE0", Slot = "9")]
	protected override bool HELPOIILIGH(int LLNMOPOJDNH, Span<AuthoredLocalPoseData> PDGNCDHKFCJ, in ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0xA2DE20", Offset = "0xA2CC20", VA = "0x180A2DE20")]
	public IEEJJLNLJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[OOMLJFNMBNM(typeof(LocalPoseData))]
public sealed class OAECIJBAPMM : DLEEJHDFLFI
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x8AC8C0", Offset = "0x8AB6C0", VA = "0x1808AC8C0", Slot = "8")]
	protected override bool NFEBCKMEODN(ReadOnlySpan<LocalPoseData> PDGNCDHKFCJ, IFAEDNBIFMG LAKAALEJDAJ, out ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x8AC800", Offset = "0x8AB600", VA = "0x1808AC800", Slot = "9")]
	protected override bool HELPOIILIGH(int LLNMOPOJDNH, Span<LocalPoseData> PDGNCDHKFCJ, in ReadOnlySpan<byte> KLGAKJLGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x8AC940", Offset = "0x8AB740", VA = "0x1808AC940")]
	public OAECIJBAPMM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : IFFEHGABMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x99B890", Offset = "0x99A690", VA = "0x18099B890", Slot = "6")]
		public sealed override void FJMKFOKGINK(JCOMJBEFBAO JAKHBAJPHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x99ADE0", Offset = "0x999BE0", VA = "0x18099ADE0", Slot = "4")]
		public sealed override void EAJHEFOPBGE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9FE0", Offset = "0x8A8DE0", VA = "0x1808A9FE0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C90", Offset = "0x8A8A90", VA = "0x1808A9C90")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001EA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
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
