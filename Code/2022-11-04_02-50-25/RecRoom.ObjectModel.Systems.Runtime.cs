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
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class CFCCMCFNBNI<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class GLCHPLOGCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::CFCCMCFNBNI<T> EJOHAMAIHHN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] JMMBOCMMDCH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public GLCHPLOGCKA(global::CFCCMCFNBNI<T> EJOHAMAIHHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LIIGDCMEIFP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::CFCCMCFNBNI<T> <>4__this;

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
		public LIIGDCMEIFP(int <>1__state)
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
	private const int PAJNDMEBFNM = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> JGKOBIEBEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int FAOPDFHNGMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T BJGDNLMGIHJ
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
	private bool CAOBGEHCFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HBDPFFKNCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool CAMENFJGICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BOODKFKIDEE
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
	public int MHDOGPFGFFD
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
	public CFCCMCFNBNI(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public CFCCMCFNBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void CJEBMIMAJJA(int PGFOAHEHPOH, T MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void GOBFDDIOGIM(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] MFPKPKDLKNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void FKODGEMMKMC(NativeArray<T> CCKHAOABLMF, int EFDMFNHPCPL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::CFCCMCFNBNI<>.LIIGDCMEIFP))]
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
	public int LPHHEGFFIAL(T MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool GMLJNDAKNDK(T MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void PCLJKBMNBJO(int IMHCJLNDAON, int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void BEHIIBPBPCD(int IMHCJLNDAON, int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void CMOFOEFEAHO(int IMHCJLNDAON, int MJMHIELCMAL, int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int MENEDILBPJH(int PGFOAHEHPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T CGGMAIAOLMK(int PGFOAHEHPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void COPPNIENJMC(int PGFOAHEHPOH, T MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void AMBOAEKFJJE(int PGFOAHEHPOH, T MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void BGAOCPCKIIA(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int HNEMEMHFAFC(int PKODKJLGOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int DLBIGLAOOPJ(int PKODKJLGOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void AFHMGIKFONI(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void NPEELNLAKDA(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T HKMHENADECB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T LDIPJAHPIOO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void JLJFMJCMILD(int PGFOAHEHPOH, IReadOnlyCollection<T> DOFLDOMHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void PCMIAHOCMAA(int PGFOAHEHPOH, int KEFCLBAPBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void NFPFNJLEJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void LBFPJGDPAJK(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void GAIFCCLPDBD(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void GKNACMGGJKK(int MJMHIELCMAL, int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T EKJJKCBEOJA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T AEBCKEEKBOK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DKFCABINONO]
public static class DNHOJLPFCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D16E70", Offset = "0x2D16270", VA = "0x182D16E70")]
	static DNHOJLPFCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x23CD4F0", Offset = "0x23CC8F0", VA = "0x1823CD4F0")]
	public static void OPHMDAMJPLF<T>(T NOBDDMHFHPJ, ref T PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D16C20", Offset = "0x2D16020", VA = "0x182D16C20")]
	public static void OPHMDAMJPLF(FixedString32 NOBDDMHFHPJ, ref string PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D10", Offset = "0x2D16110", VA = "0x182D16D10")]
	public static void OPHMDAMJPLF(string NOBDDMHFHPJ, ref FixedString32 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D50", Offset = "0x2D16150", VA = "0x182D16D50")]
	public static void OPHMDAMJPLF(FixedString64 NOBDDMHFHPJ, ref string PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D16C50", Offset = "0x2D16050", VA = "0x182D16C50")]
	public static void OPHMDAMJPLF(string NOBDDMHFHPJ, ref FixedString64 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B00", Offset = "0x2D15F00", VA = "0x182D16B00")]
	public static void OPHMDAMJPLF(BCALMFNOPDJ NOBDDMHFHPJ, ref Vector3 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D16CB0", Offset = "0x2D160B0", VA = "0x182D16CB0")]
	public static void OPHMDAMJPLF(Vector3 NOBDDMHFHPJ, ref BCALMFNOPDJ PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D80", Offset = "0x2D16180", VA = "0x182D16D80")]
	public static void OPHMDAMJPLF(PAHIJDIENOL NOBDDMHFHPJ, ref Vector4 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B70", Offset = "0x2D15F70", VA = "0x182D16B70")]
	public static void OPHMDAMJPLF(Vector4 NOBDDMHFHPJ, ref PAHIJDIENOL PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D16D80", Offset = "0x2D16180", VA = "0x182D16D80")]
	public static void OPHMDAMJPLF(PAHIJDIENOL NOBDDMHFHPJ, ref Quaternion PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B70", Offset = "0x2D15F70", VA = "0x182D16B70")]
	public static void OPHMDAMJPLF(Quaternion NOBDDMHFHPJ, ref PAHIJDIENOL PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D16E40", Offset = "0x2D16240", VA = "0x182D16E40")]
	public static void OPHMDAMJPLF(BCALMFNOPDJ NOBDDMHFHPJ, ref float3 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D16CB0", Offset = "0x2D160B0", VA = "0x182D16CB0")]
	public static void OPHMDAMJPLF(float3 NOBDDMHFHPJ, ref BCALMFNOPDJ PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B30", Offset = "0x2D15F30", VA = "0x182D16B30")]
	public static void OPHMDAMJPLF(PAHIJDIENOL NOBDDMHFHPJ, ref float4 PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B70", Offset = "0x2D15F70", VA = "0x182D16B70")]
	public static void OPHMDAMJPLF(float4 NOBDDMHFHPJ, ref PAHIJDIENOL PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B30", Offset = "0x2D15F30", VA = "0x182D16B30")]
	public static void OPHMDAMJPLF(PAHIJDIENOL NOBDDMHFHPJ, ref quaternion PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D16DD0", Offset = "0x2D161D0", VA = "0x182D16DD0")]
	public static void OPHMDAMJPLF(quaternion NOBDDMHFHPJ, ref PAHIJDIENOL PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D16BE0", Offset = "0x2D15FE0", VA = "0x182D16BE0")]
	public static void OPHMDAMJPLF(Entity NOBDDMHFHPJ, ref ECAHGLJIEAD PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D16DB0", Offset = "0x2D161B0", VA = "0x182D16DB0")]
	public static void OPHMDAMJPLF(ECAHGLJIEAD NOBDDMHFHPJ, ref Entity PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NEKKAFLHHJJ]
public class EBHDPAAFAGF : ComponentSystem, OIOAOEDFDMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EJMKHPELEHA ECMNFNGHGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KKKCPPGBJHO GEFAJMMEOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D18E50", Offset = "0x2D18250", VA = "0x182D18E50", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
	public EBHDPAAFAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(LPGEBAOCHLN))]
internal class EGBJBMLADGF : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D18F50", Offset = "0x2D18350", VA = "0x182D18F50", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D19190", Offset = "0x2D18590", VA = "0x182D19190")]
	[Preserve]
	private void LOIIBDGHMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public EGBJBMLADGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(LPGEBAOCHLN))]
internal class GDEOPLKFIMC : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C74B00", Offset = "0x2C73F00", VA = "0x182C74B00", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public GDEOPLKFIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A420A0", Offset = "0x2A414A0", VA = "0x182A420A0")]
		public static ObjectModelConfigAsset OHHGONMLELI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01C80", VA = "0x180F02880")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AFAPMPFKDID(JCDEPCAPNFC.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int KCHJKIMPEDI = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly EHNHFGEGKKP PDHCNHGCAHC;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x45C7BF0", Offset = "0x45C6FF0", VA = "0x1845C7BF0")]
			public static DLABIEOOCHD BOMPBOFJFNC(int LLOBDECBKLM)
			{
				return default(DLABIEOOCHD);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x45C8230", Offset = "0x45C7630", VA = "0x1845C8230")]
			private static void MJMCAHAHPEI(HOGBEFGIKOI LJAKBOIJGKN, HOGBEFGIKOI CGEMAEJKGIC, DLABIEOOCHD BBEIPJALHJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x45C8060", Offset = "0x45C7460", VA = "0x1845C8060")]
			public static int LGNDLHKLCFC(GameObject MGDBDEJKIMA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x45C7FE0", Offset = "0x45C73E0", VA = "0x1845C7FE0")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			private static void IIMBLHMIAIK(HOGBEFGIKOI DCJOMJHHEFE, int LLOBDECBKLM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static KADOJAOKIOP PKBPIIAEHNA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static FJONBJHEIFH HNBJGDKCNEA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static KADOJAOKIOP PODKGNKAKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2A439A0", Offset = "0x2A42DA0", VA = "0x182A439A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2A43780", Offset = "0x2A42B80", VA = "0x182A43780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static FJONBJHEIFH GGNLEHPEPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2A43130", Offset = "0x2A42530", VA = "0x182A43130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2A42BC0", Offset = "0x2A41FC0", VA = "0x182A42BC0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool BHGKKHLGKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2A42740", Offset = "0x2A41B40", VA = "0x182A42740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EJMKHPELEHA ECMNFNGHGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A43520", Offset = "0x2A42920", VA = "0x182A43520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static KKKCPPGBJHO GEFAJMMEOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2A42DE0", Offset = "0x2A421E0", VA = "0x182A42DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static GGGMMDNLNGG OGJNIKMIANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2A43920", Offset = "0x2A42D20", VA = "0x182A43920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static AGECAABBCAI BMLCNMKOKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2A424D0", Offset = "0x2A418D0", VA = "0x182A424D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static IANFCDGCLMD PPANCHCHJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2A43370", Offset = "0x2A42770", VA = "0x182A43370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static AKIKBDADLPE OJNIAOBKCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2A42140", Offset = "0x2A41540", VA = "0x182A42140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool DLDBKIAKDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2A43A00", Offset = "0x2A42E00", VA = "0x182A43A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool NGGBAODBEFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2A42550", Offset = "0x2A41950", VA = "0x182A42550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool BKEJHICBPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2A43860", Offset = "0x2A42C60", VA = "0x182A43860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2A42F50", Offset = "0x2A42350", VA = "0x182A42F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool DPOFDNNJFMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2A421C0", Offset = "0x2A415C0", VA = "0x182A421C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2A438C0", Offset = "0x2A42CC0", VA = "0x182A438C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action BAOFIHNMMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2A428A0", Offset = "0x2A41CA0", VA = "0x182A428A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2A43AE0", Offset = "0x2A42EE0", VA = "0x182A43AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A42E60", Offset = "0x2A42260", VA = "0x182A42E60")]
		public static HOGBEFGIKOI HAOPAHLBONF(GameObject MGDBDEJKIMA)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A42470", Offset = "0x2A41870", VA = "0x182A42470")]
		public static bool DDDDDFILMGA(ByteString NBOKDDEOMCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A43250", Offset = "0x2A42650", VA = "0x182A43250")]
		public static MPFJCJEABON IOOAIFHAAEN(DLABIEOOCHD BBEIPJALHJO)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A42220", Offset = "0x2A41620", VA = "0x182A42220")]
		public static (ByteString, IDisposable) CAOILNKOGOI()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A429A0", Offset = "0x2A41DA0", VA = "0x182A429A0")]
		public static (ByteString, IDisposable) FGAGHPHIOEP(IEnumerable<HOGBEFGIKOI> EMDHJBJJOCG)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A433F0", Offset = "0x2A427F0", VA = "0x182A433F0")]
		public static bool JLMEHNKIBIA(GameObject MGDBDEJKIMA, out DLABIEOOCHD BBEIPJALHJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A42AD0", Offset = "0x2A41ED0", VA = "0x182A42AD0")]
		public static bool FGCDMJBLHGH(IEnumerable<FJGCKAIOICJ> JLPIOMCIPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A436A0", Offset = "0x2A42AA0", VA = "0x182A436A0")]
		public static void KOEBCBOPMEC(bool DILCHIHLBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A42FB0", Offset = "0x2A423B0", VA = "0x182A42FB0")]
		public static Task HPKFAJGPFBJ(bool DILCHIHLBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A435C0", Offset = "0x2A429C0", VA = "0x182A435C0")]
		private static FJONBJHEIFH KIGDFHDEOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A42350", Offset = "0x2A41750", VA = "0x182A42350")]
		private static bool CGIMFKCOJIB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AFAPMPFKDID(JCDEPCAPNFC.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2A48350", Offset = "0x2A47750", VA = "0x182A48350")]
		public static bool MDEFGNAPJIA(NODKLFFDFHA KNCGEPDNJIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A483F0", Offset = "0x2A477F0", VA = "0x182A483F0")]
		public static NODKLFFDFHA MGGHGLFMIKB(GameObject MGDBDEJKIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A48620", Offset = "0x2A47A20", VA = "0x182A48620")]
		public static NODKLFFDFHA MGGHGLFMIKB(GameObject MGDBDEJKIMA, DLABIEOOCHD BBEIPJALHJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A48250", Offset = "0x2A47650", VA = "0x182A48250")]
		public static bool BNGDCMMGBBJ(GameObject LJDNPPGJLHN, string HABMBBKOFME, bool PCEPKEJFJHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A48820", Offset = "0x2A47C20", VA = "0x182A48820")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void PNFNINOOGLM(GameObject LJDNPPGJLHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2A48160", Offset = "0x2A47560", VA = "0x182A48160")]
		[CompilerGenerated]
		internal static string APCLDMNIJDC((GameObject go, string prefabName) LBFFDNKPEBE)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, KKBJAIBOEFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public HOGBEFGIKOI EPIGHCONBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(HOGBEFGIKOI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2CAB3B0", Offset = "0x2CAA7B0", VA = "0x182CAB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[AFAPMPFKDID(JCDEPCAPNFC.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, NODKLFFDFHA, KKBJAIBOEFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string BFAPJPEOOKP = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EALAGMHCKDJ AGOKAPGFDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HOGBEFGIKOI ODKPHBBMMPO;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public HOGBEFGIKOI EPIGHCONBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1303BE0", Offset = "0x1302FE0", VA = "0x181303BE0", Slot = "15")]
			get
			{
				return default(HOGBEFGIKOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public MPFJCJEABON KBCLEKIMDJF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BCE0", Offset = "0x2C6B0E0", VA = "0x182C6BCE0", Slot = "6")]
			get
			{
				return default(MPFJCJEABON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool JKEKAKBCKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BCD0", Offset = "0x2C6B0D0", VA = "0x182C6BCD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EALAGMHCKDJ KKGLFKPHOCD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9DD8C0", Offset = "0x9DCCC0", VA = "0x1809DD8C0", Slot = "7")]
			get
			{
				return default(EALAGMHCKDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KKKCPPGBJHO GEFAJMMEOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2C6B190", Offset = "0x2C6A590", VA = "0x182C6B190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private GGDOJMIIODJ LMLDPKHOICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2C6B1E0", Offset = "0x2C6A5E0", VA = "0x182C6B1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BEHJJHABHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x726570", VA = "0x180727170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> ALCJIKJCLEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BB90", Offset = "0x2C6AF90", VA = "0x182C6BB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BD10", Offset = "0x2C6B110", VA = "0x182C6BD10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<NODKLFFDFHA> FPDNJBJMKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BC30", Offset = "0x2C6B030", VA = "0x182C6BC30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BDB0", Offset = "0x2C6B1B0", VA = "0x182C6BDB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2C6AFA0", Offset = "0x2C6A3A0", VA = "0x182C6AFA0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BA20", Offset = "0x2C6AE20", VA = "0x182C6BA20", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B6C0", Offset = "0x2C6AAC0", VA = "0x182C6B6C0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B990", Offset = "0x2C6AD90", VA = "0x182C6B990", Slot = "11")]
		public void OnEmbody(FGEHAOHAFDI ICDEHOIBFMN, HOGBEFGIKOI ODKPHBBMMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BA10", Offset = "0x2C6AE10", VA = "0x182C6BA10", Slot = "12")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B760", Offset = "0x2C6AB60", VA = "0x182C6B760", Slot = "13")]
		public void OnDisembody(bool OEMLEMIPCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B330", Offset = "0x2C6A730", VA = "0x182C6B330")]
		private void KJNDNGOMBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B270", Offset = "0x2C6A670", VA = "0x182C6B270")]
		private void IHDBDIOJJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B490", Offset = "0x2C6A890", VA = "0x182C6B490")]
		private void OFDBPHEIMHD(bool MKDJEEGDHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B430", Offset = "0x2C6A830", VA = "0x182C6B430", Slot = "14")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xF99350", Offset = "0xF98750", VA = "0x180F99350", Slot = "10")]
		private GameObject DDGJDLFDGNG()
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

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[AFAPMPFKDID(JCDEPCAPNFC.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override FFIHEMJDJJI PNAKMMNBDEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A55180", Offset = "0x2A54580", VA = "0x182A55180", Slot = "5")]
			get
			{
				return default(FFIHEMJDJJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A55120", Offset = "0x2A54520", VA = "0x182A55120")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[AFAPMPFKDID(JCDEPCAPNFC.Registration)]
	public class TransformEntity : MonoBehaviour, KKBJAIBOEFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private FFIHEMJDJJI prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HOGBEFGIKOI DCJOMJHHEFE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual FFIHEMJDJJI PNAKMMNBDEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "5")]
			get
			{
				return default(FFIHEMJDJJI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x711410", Offset = "0x710810", VA = "0x180711410", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public HOGBEFGIKOI EPIGHCONBEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCC7120", Offset = "0xCC6520", VA = "0x180CC7120", Slot = "4")]
			get
			{
				return default(HOGBEFGIKOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal Entity BADKAKDHHFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal IANFCDGCLMD PPANCHCHJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal GGDOJMIIODJ EFLPOHGKJLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2BDB440", Offset = "0x2BDA840", VA = "0x182BDB440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB430", Offset = "0x2BDA830", VA = "0x182BDB430")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB340", Offset = "0x2BDA740", VA = "0x182BDB340")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB610", Offset = "0x2BDAA10", VA = "0x182BDB610")]
		internal void PAICICMJOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB4E0", Offset = "0x2BDA8E0", VA = "0x182BDB4E0")]
		private bool MKOKLKACMCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB4B0", Offset = "0x2BDA8B0", VA = "0x182BDB4B0")]
		private void IMIAJHNIELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB340", Offset = "0x2BDA740", VA = "0x182BDB340")]
		internal void AEPKJBPFIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB580", Offset = "0x2BDA980", VA = "0x182BDB580")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB960", Offset = "0x2BDAD60", VA = "0x182BDB960")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BGGFAGPLFND(typeof(FJONBJHEIFH), new string[] { })]
[FONHBDMNEGL(typeof(HIMFGGFNFGH))]
public class FAEFJKMAPAH : NAIFOFGODGF, FJONBJHEIFH, JFMMJOKBFKE, HIMFGGFNFGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MNCBLPIJNJN KMGLINHGLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KKKCPPGBJHO BAKIKEOBNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private PHOJMNPNNFN CNKEEMPEKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OPFADMNHCLD DENFIAEEJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4C0", Offset = "0x8BD8C0", VA = "0x1808BE4C0", Slot = "18")]
		get
		{
			return default(OPFADMNHCLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MNCBLPIJNJN ECMNFNGHGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EFLFKJPCKHG LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KKKCPPGBJHO GEFAJMMEOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ADCMEHCEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C70DB0", Offset = "0x2C701B0", VA = "0x182C70DB0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C71020", Offset = "0x2C70420", VA = "0x182C71020", Slot = "19")]
	public void DHLKGJANJLO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF810", Offset = "0x7BEC10", VA = "0x1807BF810")]
	private void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C714E0", Offset = "0x2C708E0", VA = "0x182C714E0")]
	private void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C711A0", Offset = "0x2C705A0", VA = "0x182C711A0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C70E10", Offset = "0x2C70210", VA = "0x182C70E10", Slot = "4")]
	public ByteString CAOILNKOGOI(out IDisposable LAHPHJFAOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C71590", Offset = "0x2C70990", VA = "0x182C71590", Slot = "12")]
	public void PHCGINGHJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C70EF0", Offset = "0x2C702F0", VA = "0x182C70EF0", Slot = "5")]
	public void DBBEJMFMHKH(ByteString HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
	public void LBCLHFBEDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C71130", Offset = "0x2C70530", VA = "0x182C71130", Slot = "7")]
	public void DNDMLAHIKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C70DC0", Offset = "0x2C701C0", VA = "0x182C70DC0", Slot = "8")]
	public void BJKIBDECBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C71400", Offset = "0x2C70800", VA = "0x182C71400", Slot = "9")]
	public void MCNJKCMJNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C71200", Offset = "0x2C70600", VA = "0x182C71200", Slot = "10")]
	public bool FGCDMJBLHGH(IEnumerable<FJGCKAIOICJ> JLPIOMCIPGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C71470", Offset = "0x2C70870", VA = "0x182C71470", Slot = "11")]
	public void MKPKANBDNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C70D40", Offset = "0x2C70140", VA = "0x182C70D40", Slot = "13")]
	public void ANKOHIIKKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C713D0", Offset = "0x2C707D0", VA = "0x182C713D0")]
	private void KACIFHPOMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C712E0", Offset = "0x2C706E0", VA = "0x182C712E0")]
	public static FAEFJKMAPAH GEGOECOOINK(MNCBLPIJNJN KMGLINHGLGG, ONAFOAMBPDO GHPHIAMLFNM = ONAFOAMBPDO.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void MIAAGBOPGBM(MNCBLPIJNJN KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void CMCHIIJBNKB(MNCBLPIJNJN KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FAEFJKMAPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GLLFDLNPIBC
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C79640", Offset = "0x2C78A40", VA = "0x182C79640")]
	public static MPFJCJEABON IADDBEFBPMO(this FJONBJHEIFH HNBJGDKCNEA, DLABIEOOCHD BBEIPJALHJO, FFIHEMJDJJI CNEFMCCDIIL)
	{
		return default(MPFJCJEABON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C79780", Offset = "0x2C78B80", VA = "0x182C79780")]
	public static NPCIIIEMMEN NOOMHEOPAIM(this FJONBJHEIFH HNBJGDKCNEA)
	{
		return default(NPCIIIEMMEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C79340", Offset = "0x2C78740", VA = "0x182C79340")]
	public static HOGBEFGIKOI HAOPAHLBONF(this FJONBJHEIFH HNBJGDKCNEA, Entity KCGBIDJFHLF)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C793F0", Offset = "0x2C787F0", VA = "0x182C793F0")]
	public static HOGBEFGIKOI HAOPAHLBONF(this FJONBJHEIFH HNBJGDKCNEA, DLABIEOOCHD BBEIPJALHJO)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C79520", Offset = "0x2C78920", VA = "0x182C79520")]
	public static DLABIEOOCHD HGPHDEFJFGN(this FJONBJHEIFH HNBJGDKCNEA, HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(DLABIEOOCHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum ONAFOAMBPDO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class FNMDIAKAJPN<T> : global::LLCPJAENECK<T>, global::DFOJKPKKLBC<DLABIEOOCHD, T>, global::DNDLEPOOMMO<DLABIEOOCHD>, NMADPBMEMAM, IDisposable, AJFNKNMFLJF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly global::DNDLEPOOMMO<Entity> GIOGLFNEEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Delegate EFJANDLGFFM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3785C30", Offset = "0x3785030", VA = "0x183785C30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Type JAKOAABNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3797670", Offset = "0x3796A70", VA = "0x183797670", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MDNFODCBPDK APKPACOCEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x37828C0", Offset = "0x3781CC0", VA = "0x1837828C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int BIJJFGKIFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3797560", Offset = "0x3796960", VA = "0x183797560", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MEHGLGCDNDI CEIEOIKNIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x37859B0", Offset = "0x3784DB0", VA = "0x1837859B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3785100", Offset = "0x3784500", VA = "0x183785100", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3305790", Offset = "0x3304B90", VA = "0x183305790", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::DDBAOMOJKJK<DLABIEOOCHD> BAOFIHNMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3789170", Offset = "0x3788570", VA = "0x183789170", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3798740", Offset = "0x3797B40", VA = "0x183798740", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3305CA0", Offset = "0x33050A0", VA = "0x183305CA0")]
	public FNMDIAKAJPN(global::DNDLEPOOMMO<Entity> GIOGLFNEEJE, IANFCDGCLMD OMBDCMFHFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3782F70", Offset = "0x3782370", VA = "0x183782F70")]
	private Entity BEIKDICPIGL(DLABIEOOCHD BBEIPJALHJO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x33020D0", Offset = "0x33014D0", VA = "0x1833020D0")]
	private DLABIEOOCHD BEIKDICPIGL(Entity KCGBIDJFHLF)
	{
		return default(DLABIEOOCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3787010", Offset = "0x3786410", VA = "0x183787010", Slot = "4")]
	public T DPALGOGEJPD(DLABIEOOCHD BBEIPJALHJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x37969E0", Offset = "0x3795DE0", VA = "0x1837969E0")]
	public bool JKDFMHKJMMK(DLABIEOOCHD BBEIPJALHJO, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x378B620", Offset = "0x378AA20", VA = "0x18378B620")]
	public bool GEFNNNFAFEO(DLABIEOOCHD BBEIPJALHJO, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3797BD0", Offset = "0x3796FD0", VA = "0x183797BD0", Slot = "9")]
	public bool NNJMHAAKOAN(DLABIEOOCHD BBEIPJALHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3798DC0", Offset = "0x37981C0", VA = "0x183798DC0", Slot = "26")]
	public object PPGDMHEFIEG(DLABIEOOCHD BBEIPJALHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3784CD0", Offset = "0x37840D0", VA = "0x183784CD0")]
	public bool BFFIMPJJIHI(DLABIEOOCHD BBEIPJALHJO, in object NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3786C20", Offset = "0x3786020", VA = "0x183786C20")]
	public void DPALGOGEJPD(DLABIEOOCHD BBEIPJALHJO, in GANDDJBCJLO PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x37956A0", Offset = "0x3794AA0", VA = "0x1837956A0")]
	public bool JKDFMHKJMMK(DLABIEOOCHD BBEIPJALHJO, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x378C740", Offset = "0x378BB40", VA = "0x18378C740")]
	public bool GEFNNNFAFEO(DLABIEOOCHD BBEIPJALHJO, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3301DB0", Offset = "0x33011B0", VA = "0x183301DB0", Slot = "22")]
	public void AJIBBCJIBFD(DGPMAHPPOKF KKGADOGDKJF, [Optional] object IDEIPFIOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3781AF0", Offset = "0x3780EF0", VA = "0x183781AF0", Slot = "15")]
	public void AJIBBCJIBFD(DLABIEOOCHD MPIADBGKNBD, PLHAONFOPHE KKGADOGDKJF, object IDEIPFIOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x378EE70", Offset = "0x378E270", VA = "0x18378EE70", Slot = "14")]
	public bool IHGJCBOPEIC(DLABIEOOCHD PLMCOCLAMMK, DLABIEOOCHD NOBDDMHFHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x142DD10", Offset = "0x142D110", VA = "0x18142DD10", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x37994B0", Offset = "0x37988B0", VA = "0x1837994B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3785200", Offset = "0x3784600", VA = "0x183785200")]
	public string CFGCCFPHEJG(in DMCBBFPDIBM CPDKILJDHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x378A040", Offset = "0x3789440", VA = "0x18378A040")]
	private void GBOBHLAIMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x378E470", Offset = "0x378D870", VA = "0x18378E470")]
	private void GPOGCEGOOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3792790", Offset = "0x3791B90", VA = "0x183792790")]
	private void IOGFEEFLFIN(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3788940", Offset = "0x3787D40", VA = "0x183788940")]
	private void EJMDHFEFLKK(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3790A90", Offset = "0x378FE90", VA = "0x183790A90")]
	[Conditional("DEBUG_BUILD")]
	private static void IJGHDAAPFFM(Entity KCGBIDJFHLF, DLABIEOOCHD BBEIPJALHJO, string KDNIDDIGOFK, string FNABAEOLHAC, [CallerMemberName] string EDMKMICDLNB = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x231CBA0", Offset = "0x231BFA0", VA = "0x18231CBA0", Slot = "5")]
	private bool PDFCEGGDFNP(DLABIEOOCHD MPIADBGKNBD, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33028E0", Offset = "0x3301CE0", VA = "0x1833028E0", Slot = "6")]
	private bool DDNIKJMEDFJ(DLABIEOOCHD MPIADBGKNBD, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCAA0", Offset = "0x2CBBEA0", VA = "0x182CBCAA0", Slot = "10")]
	private bool GOBDMEMIKBJ(DLABIEOOCHD MPIADBGKNBD, in object NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3305600", Offset = "0x3304A00", VA = "0x183305600", Slot = "11")]
	private void JKKEKKCMMDN(DLABIEOOCHD MPIADBGKNBD, in GANDDJBCJLO PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3305A40", Offset = "0x3304E40", VA = "0x183305A40", Slot = "12")]
	private bool PAEDAFFNGGM(DLABIEOOCHD MPIADBGKNBD, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3301C00", Offset = "0x3301000", VA = "0x183301C00", Slot = "13")]
	private bool ADIPOAIGEME(DLABIEOOCHD MPIADBGKNBD, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3304000", Offset = "0x3303400", VA = "0x183304000", Slot = "16")]
	private string HBOBGJKBDFO(in DMCBBFPDIBM PKODKJLGOIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class PAKLIDDKMKP<T> : global::OFBAKEDDMOM<T>, global::DFOJKPKKLBC<HOGBEFGIKOI, T>, global::DNDLEPOOMMO<HOGBEFGIKOI>, NMADPBMEMAM, IDisposable, GMLMCMNEFMA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly global::DNDLEPOOMMO<Entity> GIOGLFNEEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Delegate EFJANDLGFFM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3910B40", Offset = "0x390FF40", VA = "0x183910B40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Type JAKOAABNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x39144D0", Offset = "0x39138D0", VA = "0x1839144D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MDNFODCBPDK APKPACOCEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x39102C0", Offset = "0x390F6C0", VA = "0x1839102C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BIJJFGKIFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3914380", Offset = "0x3913780", VA = "0x183914380", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public MEHGLGCDNDI CEIEOIKNIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x39109B0", Offset = "0x390FDB0", VA = "0x1839109B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3910950", Offset = "0x390FD50", VA = "0x183910950", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34EBE50", Offset = "0x34EB250", VA = "0x1834EBE50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::DDBAOMOJKJK<HOGBEFGIKOI> BAOFIHNMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3911810", Offset = "0x3910C10", VA = "0x183911810", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3914910", Offset = "0x3913D10", VA = "0x183914910", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3305CA0", Offset = "0x33050A0", VA = "0x183305CA0")]
	public PAKLIDDKMKP(global::DNDLEPOOMMO<Entity> GIOGLFNEEJE, IANFCDGCLMD OMBDCMFHFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1297900", Offset = "0x1296D00", VA = "0x181297900")]
	private Entity BEIKDICPIGL(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x34EA1C0", Offset = "0x34E95C0", VA = "0x1834EA1C0")]
	private HOGBEFGIKOI BEIKDICPIGL(Entity KCGBIDJFHLF)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3910B90", Offset = "0x390FF90", VA = "0x183910B90", Slot = "4")]
	public T DPALGOGEJPD(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x39140E0", Offset = "0x39134E0", VA = "0x1839140E0")]
	public bool JKDFMHKJMMK(HOGBEFGIKOI DCJOMJHHEFE, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3912560", Offset = "0x3911960", VA = "0x183912560")]
	public bool GEFNNNFAFEO(HOGBEFGIKOI DCJOMJHHEFE, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x39145D0", Offset = "0x39139D0", VA = "0x1839145D0", Slot = "9")]
	public bool NNJMHAAKOAN(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3914A30", Offset = "0x3913E30", VA = "0x183914A30", Slot = "26")]
	public object PPGDMHEFIEG(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3910730", Offset = "0x390FB30", VA = "0x183910730")]
	public bool BFFIMPJJIHI(HOGBEFGIKOI DCJOMJHHEFE, in object NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3911560", Offset = "0x3910960", VA = "0x183911560")]
	public void DPALGOGEJPD(HOGBEFGIKOI DCJOMJHHEFE, in GANDDJBCJLO PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3913CC0", Offset = "0x39130C0", VA = "0x183913CC0")]
	public bool JKDFMHKJMMK(HOGBEFGIKOI DCJOMJHHEFE, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39124A0", Offset = "0x39118A0", VA = "0x1839124A0")]
	public bool GEFNNNFAFEO(HOGBEFGIKOI DCJOMJHHEFE, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3301DB0", Offset = "0x33011B0", VA = "0x183301DB0", Slot = "22")]
	public void AJIBBCJIBFD(DGPMAHPPOKF KKGADOGDKJF, [Optional] object IDEIPFIOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3910070", Offset = "0x390F470", VA = "0x183910070", Slot = "15")]
	public void AJIBBCJIBFD(HOGBEFGIKOI MPIADBGKNBD, PLHAONFOPHE KKGADOGDKJF, object IDEIPFIOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3912EC0", Offset = "0x39122C0", VA = "0x183912EC0", Slot = "14")]
	public bool IHGJCBOPEIC(HOGBEFGIKOI PLMCOCLAMMK, HOGBEFGIKOI NOBDDMHFHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3911A20", Offset = "0x3910E20", VA = "0x183911A20")]
	private void GBOBHLAIMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3912770", Offset = "0x3911B70", VA = "0x183912770")]
	private void GPOGCEGOOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3913410", Offset = "0x3912810", VA = "0x183913410")]
	private void IOGFEEFLFIN(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3911600", Offset = "0x3910A00", VA = "0x183911600")]
	private void EJMDHFEFLKK(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34EDD40", Offset = "0x34ED140", VA = "0x1834EDD40", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3914C00", Offset = "0x3914000", VA = "0x183914C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3785200", Offset = "0x3784600", VA = "0x183785200")]
	public string CFGCCFPHEJG(in DMCBBFPDIBM CPDKILJDHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x34EBE50", Offset = "0x34EB250", VA = "0x1834EBE50", Slot = "5")]
	private bool DJHPJAOCKJJ(HOGBEFGIKOI MPIADBGKNBD, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x34EBE90", Offset = "0x34EB290", VA = "0x1834EBE90", Slot = "6")]
	private bool DLCDLIOGDEN(HOGBEFGIKOI MPIADBGKNBD, in T NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCAD0", Offset = "0x2CBBED0", VA = "0x182CBCAD0", Slot = "10")]
	private bool GDOAMKHMILG(HOGBEFGIKOI MPIADBGKNBD, in object NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x34EBB40", Offset = "0x34EAF40", VA = "0x1834EBB40", Slot = "11")]
	private void COGOGOAIACP(HOGBEFGIKOI MPIADBGKNBD, in GANDDJBCJLO PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x34F2370", Offset = "0x34F1770", VA = "0x1834F2370", Slot = "12")]
	private bool IAPNOENMBPD(HOGBEFGIKOI MPIADBGKNBD, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34F6E20", Offset = "0x34F6220", VA = "0x1834F6E20", Slot = "13")]
	private bool OKEDPCEKDIG(HOGBEFGIKOI MPIADBGKNBD, in DMCBBFPDIBM NKLJAHJEFHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3304000", Offset = "0x3303400", VA = "0x183304000", Slot = "16")]
	private string GDFAPANMHGJ(in DMCBBFPDIBM PKODKJLGOIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KMJPLEOALAH : IDisposable, PBOGGOLBDDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> COKEDGLCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public KMJPLEOALAH(NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2C83D20", Offset = "0x2C83120", VA = "0x182C83D20", Slot = "6")]
	public HOGBEFGIKOI OBDEJAMELKM(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2C83D10", Offset = "0x2C83110", VA = "0x182C83D10", Slot = "7")]
	public Entity OBDEJAMELKM(Entity KCGBIDJFHLF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2C83D70", Offset = "0x2C83170", VA = "0x182C83D70", Slot = "8")]
	public IEnumerable<HOGBEFGIKOI> OBDEJAMELKM(IEnumerable<HOGBEFGIKOI> EMDHJBJJOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2C83CB0", Offset = "0x2C830B0", VA = "0x182C83CB0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string MEHEGALKLNF = "Remap";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly EHNHFGEGKKP EOGGAEDIAHH;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int LDOIDCOGPJE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static PBOGGOLBDDL DNDKNEHOPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool PBGNJJNILIK;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> COKEDGLCPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3960", Offset = "0x2BD2D60", VA = "0x182BD3960")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static bool IGFDOADKIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2BD38D0", Offset = "0x2BD2CD0", VA = "0x182BD38D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3A70", Offset = "0x2BD2E70", VA = "0x182BD3A70")]
		public static SerializationRemapScope KNOLLLACCGO()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3DF0", Offset = "0x2BD31F0", VA = "0x182BD3DF0")]
		public SerializationRemapScope(PBOGGOLBDDL NGDEMDMJJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BD37C0", Offset = "0x2BD2BC0", VA = "0x182BD37C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3C00", Offset = "0x2BD3000", VA = "0x182BD3C00")]
		public static HOGBEFGIKOI OBDEJAMELKM(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3AD0", Offset = "0x2BD2ED0", VA = "0x182BD3AD0")]
		public static Entity OBDEJAMELKM(Entity KCGBIDJFHLF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BGGFAGPLFND(typeof(PDNCIJEEHCM), new string[] { })]
public class IDHPJCKJHPO : PDNCIJEEHCM
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EC70", Offset = "0x2C7E070", VA = "0x182C7EC70", Slot = "5")]
	public void LJLDLAKDIBF(object HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EB90", Offset = "0x2C7DF90", VA = "0x182C7EB90", Slot = "6")]
	public void DNGBHIPFDPO(object HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EAB0", Offset = "0x2C7DEB0", VA = "0x182C7EAB0", Slot = "7")]
	public void BHLPAFMPCIN(object HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ED50", Offset = "0x2C7E150", VA = "0x182C7ED50", Slot = "4")]
	public IDisposable NCFBAEEHLOC(object HKDHNKHPGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public IDHPJCKJHPO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[BGGFAGPLFND(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
	internal class BulkInstantiateSceneObjectService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string CHKIOPGNAGP = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[GPKJCAPOIDC]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[GPKJCAPOIDC]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[GPKJCAPOIDC]
		private GGDOJMIIODJ KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EntityQuery KMOOOPLLDHH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x2D07D90", Offset = "0x2D07190", VA = "0x182D07D90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2D08E20", Offset = "0x2D08220", VA = "0x182D08E20", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2D07540", Offset = "0x2D06940", VA = "0x182D07540", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2D07B00", Offset = "0x2D06F00", VA = "0x182D07B00")]
		public bool FGCDMJBLHGH(IEnumerable<FJGCKAIOICJ> KPLAIHGPDKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2D07C80", Offset = "0x2D07080", VA = "0x182D07C80")]
		public static bool FIGHDIAKOEP(FJGCKAIOICJ DKKNMPCNGDF, out DLABIEOOCHD BBEIPJALHJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2D07550", Offset = "0x2D06950", VA = "0x182D07550")]
		private void EAJGKAFPFAN(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA, IEnumerable<FJGCKAIOICJ> KPLAIHGPDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2D078D0", Offset = "0x2D06CD0", VA = "0x182D078D0")]
		private void EHOCCBMGGAJ(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2D07060", Offset = "0x2D06460", VA = "0x182D07060")]
		private void AKFBKFAPOKB(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA, DLABIEOOCHD BBEIPJALHJO, string JODEBEIHAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2D07FB0", Offset = "0x2D073B0", VA = "0x182D07FB0")]
		private void JNNCIFDCGGO(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2D08580", Offset = "0x2D07980", VA = "0x182D08580")]
		private void OCDBELFPLAO(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA, List<FJGCKAIOICJ> HABIDIOALBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2D07DE0", Offset = "0x2D071E0", VA = "0x182D07DE0")]
		private NativeList<DLABIEOOCHD> JKKJOEHLOON(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA)
		{
			return default(NativeList<DLABIEOOCHD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2D08310", Offset = "0x2D07710", VA = "0x182D08310")]
		private NativeArray<Entity> JPAFGIAKNPK(NativeList<DLABIEOOCHD> MIMKCFDGCHO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2D084E0", Offset = "0x2D078E0", VA = "0x182D084E0")]
		private static void NJFIHFAPNAG(Dictionary<DLABIEOOCHD, FJGCKAIOICJ> NACECODOGPA, DLABIEOOCHD BBEIPJALHJO, FJGCKAIOICJ DKKNMPCNGDF, string JODEBEIHAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
	[BGGFAGPLFND(typeof(DebugWorldsService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.Application)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		internal static bool ADCMEHCEMMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2D180F0", Offset = "0x2D174F0", VA = "0x182D180F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x2D181B0", Offset = "0x2D175B0", VA = "0x182D181B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal static bool DDNCCLLIPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2D18170", Offset = "0x2D17570", VA = "0x182D18170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x2D18130", Offset = "0x2D17530", VA = "0x182D18130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public void FNJDAIIAIOA(string JODEBEIHAPC, EntityManager KLFKJJDHNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public static void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BGGFAGPLFND(typeof(PHOJMNPNNFN), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.Application)]
internal class PHOJMNPNNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ADCMEHCEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x671270", Offset = "0x670670", VA = "0x180671270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PHOJMNPNNFN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization, new string[] { "Timing" })]
	[FONHBDMNEGL(typeof(SerializationService))]
	[BGGFAGPLFND(typeof(NGFGMFMKNCI), new string[] { })]
	internal class SerializationService : NGFGMFMKNCI, IDisposable, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const string HGIGCGKHEJF = "Timing";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly EHNHFGEGKKP GFAOMHEGENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[GPKJCAPOIDC]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[GPKJCAPOIDC]
		private AEOIKCPGKNG KJICPDPGIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[GPKJCAPOIDC]
		private PHOJMNPNNFN CNKEEMPEKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private KJGNEIJECBP CMMBHAHFNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private ENEKONIDOGK PMJBBMLDMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private SerializationRemapScope LAHPHJFAOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? JGANKBONNHL;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool BKEKHEIIINM
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD50A0", Offset = "0x2BD44A0", VA = "0x182BD50A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3E80", Offset = "0x2BD3280", VA = "0x182BD3E80", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool DEBNPMBDLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x710CE0", Offset = "0x7100E0", VA = "0x180710CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x711490", Offset = "0x710890", VA = "0x180711490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public ENEKONIDOGK ILIAFLLGFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5D50", Offset = "0x2BD5150", VA = "0x182BD5D50", Slot = "15")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4550", Offset = "0x2BD3950", VA = "0x182BD4550", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4420", Offset = "0x2BD3820", VA = "0x182BD4420")]
		public static bool DDDDDFILMGA(ByteString NBOKDDEOMCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0")]
		public void HGKDPOFOHOL(KJGNEIJECBP EDOLNFCKPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD50B0", Offset = "0x2BD44B0", VA = "0x182BD50B0", Slot = "5")]
		public void JPBAINCAIPL(bool DILCHIHLBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4730", Offset = "0x2BD3B30", VA = "0x182BD4730", Slot = "6")]
		public Task FCPDOFJHGOJ(bool DILCHIHLBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4100", Offset = "0x2BD3500", VA = "0x182BD4100", Slot = "7")]
		public ByteString CAOILNKOGOI(out IDisposable LAHPHJFAOLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD41E0", Offset = "0x2BD35E0", VA = "0x182BD41E0", Slot = "18")]
		public ByteString CAOILNKOGOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BD43C0", Offset = "0x2BD37C0", VA = "0x182BD43C0", Slot = "9")]
		public bool DBBEJMFMHKH(ByteString MOBAMMAGENB, GFLFCFIKNND GHPHIAMLFNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD54B0", Offset = "0x2BD48B0", VA = "0x182BD54B0")]
		private bool LIIBBJHMMJP(ByteString MOBAMMAGENB, GFLFCFIKNND GHPHIAMLFNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4560", Offset = "0x2BD3960", VA = "0x182BD4560", Slot = "8")]
		public void EGGLNHKBMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD57D0", Offset = "0x2BD4BD0", VA = "0x182BD57D0", Slot = "10")]
		public bool MCNJKCMJNDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4820", Offset = "0x2BD3C20", VA = "0x182BD4820", Slot = "11")]
		public bool FGCDMJBLHGH(IEnumerable<FJGCKAIOICJ> JLPIOMCIPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C70", Offset = "0x2BD5070", VA = "0x182BD5C70")]
		public bool OAKKBJNOHJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5A40", Offset = "0x2BD4E40", VA = "0x182BD5A40", Slot = "12")]
		public bool MKPKANBDNAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4C00", Offset = "0x2BD4000", VA = "0x182BD4C00")]
		public void HHPLHFHCFAM(ENEKONIDOGK.MONGMMMLFNL.HOPICMCEDOD APKCPEDKOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5220", Offset = "0x2BD4620", VA = "0x182BD5220")]
		private bool LADGMCENBLP(ByteString MOBAMMAGENB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4E80", Offset = "0x2BD4280", VA = "0x182BD4E80")]
		private void HLHFCPDCBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4BA0", Offset = "0x2BD3FA0", VA = "0x182BD4BA0")]
		private ByteString GKBJINJGPNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4A90", Offset = "0x2BD3E90", VA = "0x182BD4A90")]
		private ByteString FKLMAMKIJJJ(ByteString NBOKDDEOMCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4060", Offset = "0x2BD3460", VA = "0x182BD4060")]
		private ENEKONIDOGK.MONGMMMLFNL.HOPICMCEDOD APGNILNEDKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BD51F0", Offset = "0x2BD45F0", VA = "0x182BD51F0")]
		private void KLBFFPFKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3E90", Offset = "0x2BD3290", VA = "0x182BD3E90", Slot = "13")]
		public bool ANKOHIIKKDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4ED0", Offset = "0x2BD42D0", VA = "0x182BD4ED0")]
		private void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BGGFAGPLFND(typeof(LBMLBONIJAH), new string[] { })]
[FONHBDMNEGL(typeof(AEOIKCPGKNG))]
internal class AEOIKCPGKNG : LBMLBONIJAH
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DNDMLAHIKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFE80", Offset = "0x2CFF280", VA = "0x182CFFE80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFD90", Offset = "0x2CFF190", VA = "0x182CFFD90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<PBOGGOLBDDL> KNDONEFNHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFF20", Offset = "0x2CFF320", VA = "0x182CFFF20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFBB0", Offset = "0x2CFEFB0", VA = "0x182CFFBB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BEBLKNEBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFC50", Offset = "0x2CFF050", VA = "0x182CFFC50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFCF0", Offset = "0x2CFF0F0", VA = "0x182CFFCF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action OPOHNLILLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2D000B0", Offset = "0x2CFF4B0", VA = "0x182D000B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFB10", Offset = "0x2CFEF10", VA = "0x182CFFB10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<PBOGGOLBDDL> NFPGJFKJHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2D00150", Offset = "0x2CFF550", VA = "0x182D00150", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFFC0", Offset = "0x2CFF3C0", VA = "0x182CFFFC0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x11D3CD0", Offset = "0x11D30D0", VA = "0x1811D3CD0")]
	public void EGGLNHKBMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x11D3380", Offset = "0x11D2780", VA = "0x1811D3380")]
	public void DEBJPFPAGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x148E5C0", Offset = "0x148D9C0", VA = "0x18148E5C0")]
	public void LMPAPNHJCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2D00060", Offset = "0x2CFF460", VA = "0x182D00060")]
	public void NCFBGJKBJPC(PBOGGOLBDDL DNDKNEHOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFE30", Offset = "0x2CFF230", VA = "0x182CFFE30")]
	public void KABAGODIEIF(PBOGGOLBDDL DNDKNEHOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public AEOIKCPGKNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BGGFAGPLFND(typeof(AKIKBDADLPE), new string[] { })]
public class AEHMKDEALAM : AKIKBDADLPE, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityHierarchyParents IKPELHJLNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HEAFAACMDJP BGHKBCNEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private ObjectEmbodimentService ECKHIFIOGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public global::OFBAKEDDMOM<HOGBEFGIKOI> MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x674580", Offset = "0x673980", VA = "0x180674580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6745A0", Offset = "0x6739A0", VA = "0x1806745A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF6D0", Offset = "0x2CFEAD0", VA = "0x182CFF6D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x12F0890", Offset = "0x12EFC90", VA = "0x1812F0890", Slot = "14")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF840", Offset = "0x2CFEC40", VA = "0x182CFF840", Slot = "15")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF310", Offset = "0x2CFE710", VA = "0x182CFF310", Slot = "16")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8229E0", Offset = "0x821DE0", VA = "0x1808229E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2A40180", Offset = "0x2A3F580", VA = "0x182A40180")]
	private HOGBEFGIKOI CAOGICAAIIL(Entity KCGBIDJFHLF)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF130", Offset = "0x2CFE530", VA = "0x182CFF130", Slot = "4")]
	public HOGBEFGIKOI DLEPMOHONDC(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFEE20", Offset = "0x2CFE220", VA = "0x182CFEE20", Slot = "19")]
	public void AJEDEJEJBCN(ref List<HOGBEFGIKOI> CNIGGNPJLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF910", Offset = "0x2CFED10", VA = "0x182CFF910", Slot = "20")]
	public IEnumerable<HOGBEFGIKOI> PLNMIAOCGMN(HOGBEFGIKOI DCJOMJHHEFE, bool FOKIDIOGDBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF430", Offset = "0x2CFE830", VA = "0x182CFF430", Slot = "21")]
	public HOGBEFGIKOI GFFMDBOMJCE(HOGBEFGIKOI DCJOMJHHEFE, int PGFOAHEHPOH)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2CFED00", Offset = "0x2CFE100", VA = "0x182CFED00", Slot = "22")]
	public int AGLCELNNLEN(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF260", Offset = "0x2CFE660", VA = "0x182CFF260", Slot = "8")]
	public int EBLMMENAALN(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF040", Offset = "0x2CFE440", VA = "0x182CFF040", Slot = "9")]
	public KEIDHOKKPCI BDLNEMCOBJO(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(KEIDHOKKPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2CFEB30", Offset = "0x2CFDF30", VA = "0x182CFEB30", Slot = "23")]
	public bool ABHNDDLBDAH(HOGBEFGIKOI DCJOMJHHEFE, out KEIDHOKKPCI JCEKJAMHHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF190", Offset = "0x2CFE590", VA = "0x182CFF190", Slot = "24")]
	public IEnumerable<HOGBEFGIKOI> EBJAFNDLFGI(HOGBEFGIKOI DCJOMJHHEFE, bool FOKIDIOGDBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF530", Offset = "0x2CFE930", VA = "0x182CFF530", Slot = "12")]
	public HOGBEFGIKOI GJDFNDJNALK(HOGBEFGIKOI LAAEFADHFKD, HOGBEFGIKOI NAHHHHBNGEI)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF600", Offset = "0x2CFEA00", VA = "0x182CFF600", Slot = "13")]
	public bool HBHDIMLPOJD(HOGBEFGIKOI LAAEFADHFKD, HOGBEFGIKOI NAHHHHBNGEI, out HOGBEFGIKOI NABADPABDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF780", Offset = "0x2CFEB80", VA = "0x182CFF780", Slot = "5")]
	public HOGBEFGIKOI LKJHOOBEPGJ(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF810", Offset = "0x2CFEC10", VA = "0x182CFF810", Slot = "11")]
	public bool MODCFHPGPKN(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI IJPMBDNEJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF750", Offset = "0x2CFEB50", VA = "0x182CFF750", Slot = "25")]
	public bool JOKNPFIDODI(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI MIJGFFHMOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF720", Offset = "0x2CFEB20", VA = "0x182CFF720", Slot = "10")]
	public bool IPJALMMAMBB(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI LAAEFADHFKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF400", Offset = "0x2CFE800", VA = "0x182CFF400", Slot = "6")]
	public bool FFPPMEKEJBA(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI BLENCGKHIJI, bool EMMHLADBAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF7E0", Offset = "0x2CFEBE0", VA = "0x182CFF7E0", Slot = "7")]
	public bool MCIAKNOLHHF(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI BLENCGKHIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public AEHMKDEALAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(PKKNALEKOHF), new string[] { })]
internal class PKKNALEKOHF : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[GPKJCAPOIDC]
	private JFAKMNMKBKN CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, AFANFAEGBHI> MONHDNKMPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BF50", Offset = "0x2A4B350", VA = "0x182A4BF50", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BCE0", Offset = "0x2A4B0E0", VA = "0x182A4BCE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BAD0", Offset = "0x2A4AED0", VA = "0x182A4BAD0")]
	public AFANFAEGBHI BDMJNHJPOIA(DLDEFENJDPN KDNIDDIGOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B980", Offset = "0x2A4AD80", VA = "0x182A4B980")]
	public AFANFAEGBHI BDMJNHJPOIA(EKCDKOGIIEF FHKHLDOKDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BE30", Offset = "0x2A4B230", VA = "0x182A4BE30")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BFA0", Offset = "0x2A4B3A0", VA = "0x182A4BFA0")]
	public PKKNALEKOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class AFANFAEGBHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeList<MGDPNDCFNMK> ODPLAHBBEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<BAGOHMBBHPA> GAPIEKACOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<AJGCMCOKHHP> GPFPLHDLLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<BAGOHMBBHPA> OPPKKNMEFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NativeList<MGDPNDCFNMK> EILAEGKIHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
		get
		{
			return default(NativeList<MGDPNDCFNMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NativeList<BAGOHMBBHPA> DDGIKANJKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xCC7120", Offset = "0xCC6520", VA = "0x180CC7120")]
		get
		{
			return default(NativeList<BAGOHMBBHPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NativeList<AJGCMCOKHHP> HOEHOCGDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1303BE0", Offset = "0x1302FE0", VA = "0x181303BE0")]
		get
		{
			return default(NativeList<AJGCMCOKHHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<BAGOHMBBHPA> OALMLHKMJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x12D08C0", Offset = "0x12CFCC0", VA = "0x1812D08C0")]
		get
		{
			return default(NativeList<BAGOHMBBHPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JobHandle LCPHJAOHDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x135CF80", Offset = "0x135C380", VA = "0x18135CF80")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x135CEE0", Offset = "0x135C2E0", VA = "0x18135CEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool IDMFHAGNMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D001F0", Offset = "0x2CFF5F0", VA = "0x182D001F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D00730", Offset = "0x2CFFB30", VA = "0x182D00730")]
	public AFANFAEGBHI(Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D006A0", Offset = "0x2CFFAA0", VA = "0x182D006A0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D002A0", Offset = "0x2CFF6A0", VA = "0x182D002A0")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D003D0", Offset = "0x2CFF7D0", VA = "0x182D003D0")]
	public void EIPAABBBFMM(Entity KCGBIDJFHLF, Entity JMCOICNPJLH, Entity GIJFJALMMOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(EPCPPJMHEPH), new string[] { })]
public class EPCPPJMHEPH : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[GPKJCAPOIDC]
	private SceneService NBPMHEMDGJK;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AF50", Offset = "0x2C6A350", VA = "0x182C6AF50", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AF30", Offset = "0x2C6A330", VA = "0x182C6AF30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public EPCPPJMHEPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal abstract class GAILKEAHAGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private uint IPKCAHMCCKL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract uint MCMHIHCLBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x9DB5F0", Offset = "0x9DA9F0", VA = "0x1809DB5F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C742F0", Offset = "0x2C736F0", VA = "0x182C742F0")]
	public DLABIEOOCHD FLHEIIBAFGL()
	{
		return default(DLABIEOOCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C74240", Offset = "0x2C73640", VA = "0x182C74240")]
	public void EDLBOPKPCOL(DLABIEOOCHD BBEIPJALHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x174B630", Offset = "0x174AA30", VA = "0x18174B630", Slot = "6")]
	public virtual void ACEKBINJHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected GAILKEAHAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(HJFFEOBFAMB), new string[] { })]
internal sealed class HJFFEOBFAMB : GAILKEAHAGK, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[GPKJCAPOIDC]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private uint CFFPFDDOHIM;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override uint MCMHIHCLBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B4D0", Offset = "0x2C7A8D0", VA = "0x182C7B4D0", Slot = "7")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B480", Offset = "0x2C7A880", VA = "0x182C7B480")]
	private void LECMLIIFLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B420", Offset = "0x2C7A820", VA = "0x182C7B420", Slot = "6")]
	public override void ACEKBINJHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public HJFFEOBFAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(LDEDNDJNIPK), new string[] { })]
internal sealed class LDEDNDJNIPK : GAILKEAHAGK
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override uint MCMHIHCLBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LDEDNDJNIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BGGFAGPLFND(typeof(HMKEHOIOCDA), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
internal sealed class HMKEHOIOCDA : FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private EntityQuery MHHJBEFPBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private EntityQuery JHMPMHKFKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private EntityQuery OBALKMMAMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private EntityQuery DOCHKIDCANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityQuery CAPPEHFOKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private EntityQuery MFADHNFEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BC60", Offset = "0x2C7B060", VA = "0x182C7BC60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public EntityQuery PGABNAGEACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public EntityQuery IKJACHBKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68E030", Offset = "0x68D430", VA = "0x18068E030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public EntityQuery ADAMGGEAIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x12092F0", Offset = "0x12086F0", VA = "0x1812092F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery OBOANFBFKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x135CF80", Offset = "0x135C380", VA = "0x18135CF80")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery EOHHNGJINEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x13046D0", Offset = "0x1303AD0", VA = "0x1813046D0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery GHDKCHGALDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BE10", Offset = "0x2C7B210", VA = "0x182C7BE10")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int DNPBCJGIMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BE90", Offset = "0x2C7B290", VA = "0x182C7BE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int FOFCNFMGCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B630", Offset = "0x2C7AA30", VA = "0x182C7B630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int BPAJAMMNKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BED0", Offset = "0x2C7B2D0", VA = "0x182C7BED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int JKOKCBLKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BEB0", Offset = "0x2C7B2B0", VA = "0x182C7BEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int CPEJHEELHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B6B0", Offset = "0x2C7AAB0", VA = "0x182C7B6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KKFAIJNDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B610", Offset = "0x2C7AA10", VA = "0x182C7B610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BEF0", Offset = "0x2C7B2F0", VA = "0x182C7BEF0", Slot = "5")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B7E0", Offset = "0x2C7ABE0", VA = "0x182C7B7E0", Slot = "6")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B650", Offset = "0x2C7AA50", VA = "0x182C7B650")]
	private EntityQueryDesc BOHJCPNBGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B780", Offset = "0x2C7AB80", VA = "0x182C7B780", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BD60", Offset = "0x2C7B160", VA = "0x182C7BD60")]
	public DEGKDCDCKLH IBJMLEAPICC(HOGBEFGIKOI ODKPHBBMMPO)
	{
		return default(DEGKDCDCKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BCB0", Offset = "0x2C7B0B0", VA = "0x182C7BCB0")]
	public DEGKDCDCKLH IBJMLEAPICC(Entity KCGBIDJFHLF)
	{
		return default(DEGKDCDCKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B6D0", Offset = "0x2C7AAD0", VA = "0x182C7B6D0")]
	public FFIHEMJDJJI DIIICNFKKLC(Entity KCGBIDJFHLF)
	{
		return default(FFIHEMJDJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BF40", Offset = "0x2C7B340", VA = "0x182C7BF40")]
	public HMKEHOIOCDA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AFAPMPFKDID(JCDEPCAPNFC.All)]
	[BGGFAGPLFND(typeof(IANFCDGCLMD), new string[] { })]
	public class ObjectService : OIOAOEDFDMG, IANFCDGCLMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly EHNHFGEGKKP PGKBANCJEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[GPKJCAPOIDC]
		private KKKCPPGBJHO BAKIKEOBNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[GPKJCAPOIDC]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[GPKJCAPOIDC]
		private ObjectLifecycleService CLKGBFAJPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[GPKJCAPOIDC]
		private ObjectEmbodimentService ECKHIFIOGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[GPKJCAPOIDC]
		private ObjectInstantiationService EELIHJHFEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[GPKJCAPOIDC]
		private HMKEHOIOCDA BGHKBCNEBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private ObjectNetworkToLocalMapService NDPGNEGOBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public KKKCPPGBJHO GEFAJMMEOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int DNPBCJGIMKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A47820", Offset = "0x2A46C20", VA = "0x182A47820", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int FOFCNFMGCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2A461C0", Offset = "0x2A455C0", VA = "0x182A461C0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int BPAJAMMNKFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A47E30", Offset = "0x2A47230", VA = "0x182A47E30", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int JKOKCBLKLPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A47E10", Offset = "0x2A47210", VA = "0x182A47E10", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int CPEJHEELHIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2A46670", Offset = "0x2A45A70", VA = "0x182A46670", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int KKFAIJNDLMF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2A46150", Offset = "0x2A45550", VA = "0x182A46150", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<HOGBEFGIKOI, FFIHEMJDJJI> LDMBPIGAPOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A46D30", Offset = "0x2A46130", VA = "0x182A46D30", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2A46550", Offset = "0x2A45950", VA = "0x182A46550", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<HOGBEFGIKOI> GMBPCJOOEEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2A47440", Offset = "0x2A46840", VA = "0x182A47440", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2A47AA0", Offset = "0x2A46EA0", VA = "0x182A47AA0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A47E50", Offset = "0x2A47250", VA = "0x182A47E50", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A467E0", Offset = "0x2A45BE0", VA = "0x182A467E0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A47780", Offset = "0x2A46B80", VA = "0x182A47780")]
		private void LMNFIBIHPEA(Entity KCGBIDJFHLF, FFIHEMJDJJI CNEFMCCDIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A47860", Offset = "0x2A46C60", VA = "0x182A47860")]
		private void NEFHIKEDNBE(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A46650", Offset = "0x2A45A50", VA = "0x182A46650")]
		internal HOGBEFGIKOI CAOGICAAIIL(Entity KCGBIDJFHLF)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A47350", Offset = "0x2A46750", VA = "0x182A47350", Slot = "41")]
		public KEIDHOKKPCI KEGGPLBJCLJ()
		{
			return default(KEIDHOKKPCI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A472A0", Offset = "0x2A466A0", VA = "0x182A472A0", Slot = "42")]
		public KEIDHOKKPCI JPJIEHLCKAF()
		{
			return default(KEIDHOKKPCI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A46C30", Offset = "0x2A46030", VA = "0x182A46C30", Slot = "43")]
		public KEIDHOKKPCI FFBJKIGNPAG()
		{
			return default(KEIDHOKKPCI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A471B0", Offset = "0x2A465B0", VA = "0x182A471B0", Slot = "10")]
		public DEGKDCDCKLH IBJMLEAPICC(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(DEGKDCDCKLH);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A466D0", Offset = "0x2A45AD0", VA = "0x182A466D0", Slot = "11")]
		public FFIHEMJDJJI DIIICNFKKLC(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(FFIHEMJDJJI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A474E0", Offset = "0x2A468E0", VA = "0x182A474E0")]
		private KEIDHOKKPCI KILCHEENMHJ(EntityQuery KFGMFPAGHMA)
		{
			return default(KEIDHOKKPCI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A47B40", Offset = "0x2A46F40", VA = "0x182A47B40", Slot = "33")]
		public bool NNJMHAAKOAN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A46170", Offset = "0x2A45570", VA = "0x182A46170", Slot = "29")]
		public void AFFPDBIGLLL(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A46710", Offset = "0x2A45B10", VA = "0x182A46710", Slot = "30")]
		public void DJKBALEHOOL(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A47D70", Offset = "0x2A47170", VA = "0x182A47D70", Slot = "31")]
		public void OABAAEPLPCK(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A46B70", Offset = "0x2A45F70", VA = "0x182A46B70", Slot = "22")]
		public MPFJCJEABON FDPPJMGMAAM(FFIHEMJDJJI CNEFMCCDIIL, bool PKCONJJIEKP)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A46AC0", Offset = "0x2A45EC0", VA = "0x182A46AC0", Slot = "23")]
		public MPFJCJEABON FDPPJMGMAAM(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A47590", Offset = "0x2A46990", VA = "0x182A47590", Slot = "24")]
		public MPFJCJEABON LFJKLNGGDME(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A46FE0", Offset = "0x2A463E0", VA = "0x182A46FE0", Slot = "25")]
		public MPFJCJEABON IADDBEFBPMO(DLABIEOOCHD BBEIPJALHJO, FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A46770", Offset = "0x2A45B70", VA = "0x182A46770", Slot = "44")]
		public MPFJCJEABON DLEAHELKPND(int OCDPNHKNPIH, FFIHEMJDJJI CNEFMCCDIIL, GameObject MGDBDEJKIMA)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A47CB0", Offset = "0x2A470B0", VA = "0x182A47CB0", Slot = "26")]
		public NPCIIIEMMEN NOOMHEOPAIM()
		{
			return default(NPCIIIEMMEN);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A47620", Offset = "0x2A46A20", VA = "0x182A47620", Slot = "45")]
		public EGDCPOMNDBK LJEGHAHIGBK(NNNACFBOHIB NLAFPPIOFPG)
		{
			return default(EGDCPOMNDBK);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A47BD0", Offset = "0x2A46FD0", VA = "0x182A47BD0", Slot = "27")]
		public PDJNOHEHFGC NOOAPLLHHLE()
		{
			return default(PDJNOHEHFGC);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A46390", Offset = "0x2A45790", VA = "0x182A46390", Slot = "28")]
		public KHKFNJDDEKL BJMENJJIMOG(CDPNPEPOMEC NLAFPPIOFPG)
		{
			return default(KHKFNJDDEKL);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A47840", Offset = "0x2A46C40", VA = "0x182A47840", Slot = "12")]
		public void MGGHGLFMIKB(DLABIEOOCHD BBEIPJALHJO, NODKLFFDFHA PIOLONINMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A461E0", Offset = "0x2A455E0", VA = "0x182A461E0", Slot = "13")]
		public MPFJCJEABON AJOCPKACCNK(HOGBEFGIKOI DCJOMJHHEFE, [Optional] object PFJMMABJIDH)
		{
			return default(MPFJCJEABON);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A469D0", Offset = "0x2A45DD0", VA = "0x182A469D0", Slot = "14")]
		public bool ELFGIBIBFMP(HOGBEFGIKOI DCJOMJHHEFE, out NODKLFFDFHA HNCBGLIPCEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A473F0", Offset = "0x2A467F0", VA = "0x182A473F0", Slot = "46")]
		public Transform KEMEDAPIKJK(HOGBEFGIKOI DCJOMJHHEFE, [Optional] object PFJMMABJIDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A471E0", Offset = "0x2A465E0", VA = "0x182A471E0", Slot = "16")]
		public bool IICHANKDDLE(HOGBEFGIKOI DCJOMJHHEFE, out Transform ENMFIMJMMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A46A70", Offset = "0x2A45E70", VA = "0x182A46A70", Slot = "17")]
		public bool FDEINLLBLDO(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2A465F0", Offset = "0x2A459F0", VA = "0x182A465F0")]
		public bool BPHNCBFOIEL(NODKLFFDFHA PKODKJLGOIN, [Optional] object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2A46620", Offset = "0x2A45A20", VA = "0x182A46620", Slot = "47")]
		public bool BPHNCBFOIEL(HOGBEFGIKOI DCJOMJHHEFE, [Optional] object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2A480C0", Offset = "0x2A474C0", VA = "0x182A480C0", Slot = "48")]
		public void PMKCPINDBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2A478F0", Offset = "0x2A46CF0", VA = "0x182A478F0", Slot = "15")]
		public void NJCPIIKIJLL(NODKLFFDFHA HKFNIHLBEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2A46690", Offset = "0x2A45A90", VA = "0x182A46690", Slot = "49")]
		public void DBIDIBIGODI(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2A464D0", Offset = "0x2A458D0", VA = "0x182A464D0", Slot = "18")]
		public bool BLCDGAOPOOD(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2A46EC0", Offset = "0x2A462C0", VA = "0x182A46EC0", Slot = "19")]
		public bool HFKDBKCEAGB(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2A47230", Offset = "0x2A46630", VA = "0x182A47230", Slot = "50")]
		public bool ILJINODCPBL(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2A46960", Offset = "0x2A45D60", VA = "0x182A46960", Slot = "51")]
		public bool EDILFGKDEMM(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2A46CD0", Offset = "0x2A460D0", VA = "0x182A46CD0", Slot = "32")]
		public NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)> GBLBPOEDLKO(NativeArray<HOGBEFGIKOI> OAAMCCOBBKO, Allocator NHNCCHNPCJI)
		{
			return default(NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2A46F40", Offset = "0x2A46340", VA = "0x182A46F40", Slot = "21")]
		public DLABIEOOCHD HGPHDEFJFGN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(DLABIEOOCHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2A46DD0", Offset = "0x2A461D0", VA = "0x182A46DD0", Slot = "20")]
		public HOGBEFGIKOI HAOPAHLBONF(DLABIEOOCHD BBEIPJALHJO)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2A47740", Offset = "0x2A46B40", VA = "0x182A47740")]
		private void LJEGJPOBLAA(FFIHEMJDJJI CNEFMCCDIIL, HOGBEFGIKOI DCJOMJHHEFE, DLABIEOOCHD BBEIPJALHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(PBJPFABNNDA), new string[] { })]
internal sealed class PBJPFABNNDA : OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private ObjectInstantiationService EELIHJHFEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[GPKJCAPOIDC]
	private HMKEHOIOCDA BGHKBCNEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A060", Offset = "0x2A49460", VA = "0x182A4A060", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2A49BF0", Offset = "0x2A48FF0", VA = "0x182A49BF0")]
	public NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)> GBLBPOEDLKO(NativeArray<HOGBEFGIKOI> OAAMCCOBBKO, Allocator NHNCCHNPCJI)
	{
		return default(NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2A49CF0", Offset = "0x2A490F0", VA = "0x182A49CF0")]
	private void MGJNFCLCIIH(NativeMultiHashMap<int, (HOGBEFGIKOI src, HOGBEFGIKOI dst)> NBIBNOHAOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2A49430", Offset = "0x2A48830", VA = "0x182A49430")]
	private void AAIILFDCMLI(NativeMultiHashMap<int, (HOGBEFGIKOI src, HOGBEFGIKOI dst)> NBIBNOHAOMM, int CNEFMCCDIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2A49ED0", Offset = "0x2A492D0", VA = "0x182A49ED0")]
	private void NLGJAPNLCNN(NativeMultiHashMap<int, (HOGBEFGIKOI src, HOGBEFGIKOI dst)> NBIBNOHAOMM, int CNEFMCCDIIL, CHDKGPPIPOE CKCKOLCCJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2A498F0", Offset = "0x2A48CF0", VA = "0x182A498F0")]
	private NativeMultiHashMap<int, (HOGBEFGIKOI, HOGBEFGIKOI)> FPPBNGNACML(Allocator NHNCCHNPCJI, NativeArray<HOGBEFGIKOI> OAAMCCOBBKO, out NativeArray<(HOGBEFGIKOI src, HOGBEFGIKOI dst)> NABGAKOOOPH)
	{
		return default(NativeMultiHashMap<int, (HOGBEFGIKOI, HOGBEFGIKOI)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PBJPFABNNDA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BGGFAGPLFND(typeof(GGDOJMIIODJ), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing, new string[] { "NotifyTransformParentChanged", "OnParentChanged" })]
	[FONHBDMNEGL(typeof(TransformService))]
	public class TransformService : GGDOJMIIODJ, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private const string PKDJDECACHO = "NotifyTransformParentChanged";

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private const string PKOICPDBEEC = "OnParentChanged";

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly EHNHFGEGKKP FNNHHOCAMJB;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly EHNHFGEGKKP FNNNKMBNFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private AKIKBDADLPE NDBEPEANOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TransformOwnershipPhase GPHEICNAKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private ObjectEmbodimentService OFIMLDPADIP;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2BDD7C0", Offset = "0x2BDCBC0", VA = "0x182BDD7C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private NPLLDKEDKFD KBCPAMGBEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2BDDC90", Offset = "0x2BDD090", VA = "0x182BDDC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2BE00C0", Offset = "0x2BDF4C0", VA = "0x182BE00C0", Slot = "32")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDD0", Offset = "0x2BDC1D0", VA = "0x182BDCDD0", Slot = "33")]
		public bool FCJFOOJGGJD(Transform ENMFIMJMMCO, out HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFC60", Offset = "0x2BDF060", VA = "0x182BDFC60", Slot = "34")]
		public Transform OBIOFHAKCKC(Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDF40", Offset = "0x2BDD340", VA = "0x182BDDF40", Slot = "30")]
		public bool IICHANKDDLE(Entity KCGBIDJFHLF, out Transform ENMFIMJMMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE08F0", Offset = "0x2BDFCF0", VA = "0x182BE08F0")]
		private void PMIENADDBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBD70", Offset = "0x2BDB170", VA = "0x182BDBD70", Slot = "29")]
		public void BJCNHMLOPBE(Entity KCGBIDJFHLF, out Matrix4x4 NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDD50", Offset = "0x2BDD150", VA = "0x182BDDD50", Slot = "4")]
		public void IHDBDIOJJEF(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCF80", Offset = "0x2BDC380", VA = "0x182BDCF80")]
		public void FOIFOLOJAHO(Entity KCGBIDJFHLF, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI, Vector3 MPHDINIDBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE030", Offset = "0x2BDD430", VA = "0x182BDE030")]
		public void IIKDLJAJGKJ(Entity KCGBIDJFHLF, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF630", Offset = "0x2BDEA30", VA = "0x182BDF630", Slot = "27")]
		public void MJMECBPGPEK(Entity KCGBIDJFHLF, out Matrix4x4 OABODAFCNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBEC0", Offset = "0x2BDB2C0", VA = "0x182BDBEC0")]
		public void BJJLOCHJFBA(Entity KCGBIDJFHLF, in Matrix4x4 NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF070", Offset = "0x2BDE470", VA = "0x182BDF070")]
		public void LHAPHHDFAKN(Entity KCGBIDJFHLF, in Matrix4x4 NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE140", Offset = "0x2BDD540", VA = "0x182BDE140")]
		public void IKLFAMDABMK(Entity KCGBIDJFHLF, in Matrix4x4 AAKBNKMOPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2BE07D0", Offset = "0x2BDFBD0", VA = "0x182BE07D0", Slot = "5")]
		public void PIEDEHDCNOB(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCCC0", Offset = "0x2BDC0C0", VA = "0x182BDCCC0", Slot = "6")]
		public Vector3 FAPPDPDPICD(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCAD0", Offset = "0x2BDBED0", VA = "0x182BDCAD0", Slot = "7")]
		public void EMFNCPMJHLI(Entity KCGBIDJFHLF, Quaternion PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCBD0", Offset = "0x2BDBFD0", VA = "0x182BDCBD0", Slot = "8")]
		public Quaternion EPLDJALDAHE(Entity KCGBIDJFHLF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD6C0", Offset = "0x2BDCAC0", VA = "0x182BDD6C0", Slot = "12")]
		public void HFJCHPONMLN(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC8F0", Offset = "0x2BDBCF0", VA = "0x182BDC8F0", Slot = "11")]
		public Vector3 DJAABEFKDFC(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF1A0", Offset = "0x2BDE5A0", VA = "0x182BDF1A0")]
		public void LJKGKMGIMKC(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD430", Offset = "0x2BDC830", VA = "0x182BDD430")]
		private Vector3 GJAMNPIKKLN(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBA20", Offset = "0x2BDAE20", VA = "0x182BDBA20", Slot = "14")]
		public float AAFAMFBEKMB(Entity KCGBIDJFHLF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFD20", Offset = "0x2BDF120", VA = "0x182BDFD20", Slot = "13")]
		public void OCEJJPFPKAK(Entity KCGBIDJFHLF, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBC80", Offset = "0x2BDB080", VA = "0x182BDBC80")]
		private float BELNIMHIKGH(Entity KCGBIDJFHLF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC860", Offset = "0x2BDBC60", VA = "0x182BDC860")]
		public void DBICAMDLLJC(Entity KCGBIDJFHLF, float BFGAIIECOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFB80", Offset = "0x2BDEF80", VA = "0x182BDFB80", Slot = "16")]
		public Vector3 NNOAGPJBIFG(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF240", Offset = "0x2BDE640", VA = "0x182BDF240", Slot = "15")]
		public void MCELCGMFMCN(Entity KCGBIDJFHLF, Vector3 JODCMFIABKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2BE06A0", Offset = "0x2BDFAA0", VA = "0x182BE06A0")]
		private Vector3 PHDFBJJBPGJ(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCA00", Offset = "0x2BDBE00", VA = "0x182BDCA00")]
		public void DKJJJNOKNLB(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFE30", Offset = "0x2BDF230", VA = "0x182BDFE30")]
		[Conditional("DEBUG_BUILD")]
		private void OIKIJKCIEOK(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE850", Offset = "0x2BDDC50", VA = "0x182BDE850", Slot = "35")]
		public void KAKDOCDCDAK(Entity KCGBIDJFHLF, Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE440", Offset = "0x2BDD840", VA = "0x182BDE440", Slot = "9")]
		public void JLMOAEFFFCC(Entity KCGBIDJFHLF, out Vector3 IAMBOGDEHMB, out Quaternion BOMBFPIEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE9B0", Offset = "0x2BDDDB0", VA = "0x182BDE9B0", Slot = "10")]
		public void KCPPNNNIIJO(Entity KCGBIDJFHLF, out Vector3 IAMBOGDEHMB, out Quaternion BOMBFPIEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF870", Offset = "0x2BDEC70", VA = "0x182BDF870", Slot = "36")]
		public void NINIOPAJDNL(Entity KCGBIDJFHLF, Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBAC0", Offset = "0x2BDAEC0", VA = "0x182BDBAC0")]
		public void AJAOBJGKFNG(Entity KCGBIDJFHLF, Vector3 IAMBOGDEHMB, Quaternion BOMBFPIEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF640", Offset = "0x2BDEA40", VA = "0x182BDF640", Slot = "17")]
		public void NDLKJANCLFH(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDBB0", Offset = "0x2BDCFB0", VA = "0x182BDDBB0", Slot = "18")]
		public Vector3 IBPEGGMNKJE(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE610", Offset = "0x2BDDA10", VA = "0x182BDE610", Slot = "19")]
		public void JPKOCBFJGLJ(Entity KCGBIDJFHLF, Quaternion PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC280", Offset = "0x2BDB680", VA = "0x182BDC280", Slot = "20")]
		public Quaternion BJKFKNFMJDO(Entity KCGBIDJFHLF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEAE0", Offset = "0x2BDDEE0", VA = "0x182BDEAE0", Slot = "22")]
		public void KLLAEHGNKIL(Entity KCGBIDJFHLF, Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFA90", Offset = "0x2BDEE90", VA = "0x182BDFA90", Slot = "21")]
		public Vector3 NNGHMPPDMDC(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF370", Offset = "0x2BDE770", VA = "0x182BDF370", Slot = "23")]
		public void MCHEBFNILDN(Entity KCGBIDJFHLF, float APENOONFKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEF50", Offset = "0x2BDE350", VA = "0x182BDEF50", Slot = "24")]
		public float LGGBLNLEABF(Entity KCGBIDJFHLF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2BE01B0", Offset = "0x2BDF5B0", VA = "0x182BE01B0", Slot = "25")]
		public void PFMHOHCMOON(Entity KCGBIDJFHLF, Vector3 PPLIDOOGJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE300", Offset = "0x2BDD700", VA = "0x182BDE300", Slot = "26")]
		public Vector3 JDIMIIKIENB(Entity KCGBIDJFHLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC370", Offset = "0x2BDB770", VA = "0x182BDC370", Slot = "31")]
		public void BNABFCFDENB(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF4E0", Offset = "0x2BDE8E0", VA = "0x182BDF4E0")]
		private HOGBEFGIKOI MJLGAIKAJJE(Transform ENMFIMJMMCO)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD050", Offset = "0x2BDC450", VA = "0x182BDD050")]
		private static TransformEntity GBPNPKPDCLI(FFIHEMJDJJI NLAFPPIOFPG, GameObject LJDNPPGJLHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD4D0", Offset = "0x2BDC8D0", VA = "0x182BDD4D0")]
		private void HBLPNKADJDD(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD590", Offset = "0x2BDC990", VA = "0x182BDD590")]
		private void HBLPNKADJDD(Entity KCGBIDJFHLF, in Entity JMCOICNPJLH, in Entity GIJFJALMMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE590", Offset = "0x2BDD990", VA = "0x182BDE590")]
		private KDMLPDKICJM JLMOAEFFFCC(Entity KCGBIDJFHLF)
		{
			return default(KDMLPDKICJM);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFFE0", Offset = "0x2BDF3E0", VA = "0x182BDFFE0")]
		private bool OMNMAFDEGEK(Entity KCGBIDJFHLF, out Entity BLENCGKHIJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD280", Offset = "0x2BDC680", VA = "0x182BDD280")]
		private void GCEFHEIBJEN(Entity KCGBIDJFHLF, out Matrix4x4 NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD810", Offset = "0x2BDCC10", VA = "0x182BDD810")]
		private void IAACNCEAPMG(Entity KCGBIDJFHLF, out Matrix4x4 AAKBNKMOPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEF40", Offset = "0x2BDE340", VA = "0x182BDEF40", Slot = "28")]
		private void LCCEFFAECHG(Entity KCGBIDJFHLF, in Matrix4x4 OABODAFCNNG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(NJOOFEFJLPJ), new string[] { })]
internal sealed class NJOOFEFJLPJ : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[GPKJCAPOIDC]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B8C0", Offset = "0x2A3ACC0", VA = "0x182A3B8C0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B850", Offset = "0x2A3AC50", VA = "0x182A3B850", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public NJOOFEFJLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BGGFAGPLFND(typeof(DOOMDJDMHCG), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
public class DOOMDJDMHCG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct HFOHPGNMGGG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly DOOMDJDMHCG BLENCGKHIJI;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD06C0", Offset = "0x2BCFAC0", VA = "0x182BD06C0")]
		public HFOHPGNMGGG(DOOMDJDMHCG BLENCGKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD06A0", Offset = "0x2BCFAA0", VA = "0x182BD06A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int FOCIGGLCICP;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool BBEOGMLMBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x118C270", Offset = "0x118B670", VA = "0x18118C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action DFIKOGBAIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2D17850", Offset = "0x2D16C50", VA = "0x182D17850")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2D17920", Offset = "0x2D16D20", VA = "0x182D17920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2D178F0", Offset = "0x2D16CF0", VA = "0x182D178F0")]
	public HFOHPGNMGGG DEJNGPMHEOB()
	{
		return default(HFOHPGNMGGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x15085B0", Offset = "0x15079B0", VA = "0x1815085B0")]
	public void JIILAAKEFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2D179C0", Offset = "0x2D16DC0", VA = "0x182D179C0")]
	public void GNGIFJMGMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public DOOMDJDMHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(JIFCIAHIKLP), new string[] { })]
public class JIFCIAHIKLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int FOCIGGLCICP;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool ADCMEHCEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE95A10", Offset = "0xE94E10", VA = "0x180E95A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x87BE20", Offset = "0x87B220", VA = "0x18087BE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JIFCIAHIKLP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[BGGFAGPLFND(typeof(EnableComponentSystemsInScope), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes, new string[] { "Verbose" })]
	public class EnableComponentSystemsInScope : OIOAOEDFDMG, BBNIJBDDGNH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private struct BJIBMBOOANK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private NativeArray<int> OGFDNPKHLBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private NativeArray<int> LBCJAENOALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private Dictionary<ComponentSystemBase, int> CBAIOCMCOAE;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDA50", Offset = "0x2BCCE50", VA = "0x182BCDA50")]
			public BJIBMBOOANK(NativeArray<int> OGFDNPKHLBH, NativeArray<int> LBCJAENOALC, Dictionary<ComponentSystemBase, int> CBAIOCMCOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD7D0", Offset = "0x2BCCBD0", VA = "0x182BCD7D0")]
			public void GFGPNCOJPNL(IEnumerable<ComponentSystemBase> BAKIKEOBNEJ, BADKLKEFGCO CEOPAPKPMJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class JOLLFCFDPNN : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public JOLLFCFDPNN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0C20", Offset = "0x2BD0020", VA = "0x182BD0C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0DF0", Offset = "0x2BD01F0", VA = "0x182BD0DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0D40", Offset = "0x2BD0140", VA = "0x182BD0D40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0D40", Offset = "0x2BD0140", VA = "0x182BD0D40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public const BADKLKEFGCO LKJFBDNEDOC = BADKLKEFGCO.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public const string AINCAKBFJCK = "Verbose";

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly EHNHFGEGKKP EFKMDFELGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private World ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private EJMKHPELEHA KMGLINHGLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NativeArray<int> ABGAGAEOFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NativeArray<int> ENCNKOILBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int CELCPLLAAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private BADKLKEFGCO LNJGKEKKEKI;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CEA0", Offset = "0x2C6C2A0", VA = "0x182C6CEA0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C140", Offset = "0x2C6B540", VA = "0x182C6C140", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C1D0", Offset = "0x2C6B5D0", VA = "0x182C6C1D0")]
		[IteratorStateMachine(typeof(JOLLFCFDPNN))]
		private IEnumerable<ComponentSystemBase> EDKCKBMAOGD(int BOIMPMGFDJM, int NBODAMBMIAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BF10", Offset = "0x2C6B310", VA = "0x182C6BF10", Slot = "5")]
		public void CEBNKNPICKG(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BF10", Offset = "0x2C6B310", VA = "0x182C6BF10")]
		private void NAOPFPDCCLA(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CDA0", Offset = "0x2C6C1A0", VA = "0x182C6CDA0")]
		public void NAOPFPDCCLA(BADKLKEFGCO NAFOACFEDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C260", Offset = "0x2C6B660", VA = "0x182C6C260")]
		private void FDFONNADEOG(BADKLKEFGCO NAFOACFEDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C5B0", Offset = "0x2C6B9B0", VA = "0x182C6C5B0")]
		private void FLPAMDKHOKG(BADKLKEFGCO NAFOACFEDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BE50", Offset = "0x2C6B250", VA = "0x182C6BE50")]
		private void AEEBONKPMKJ(BADKLKEFGCO NAFOACFEDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C4F0", Offset = "0x2C6B8F0", VA = "0x182C6C4F0")]
		private void FLMKGJIJICI(int BOIMPMGFDJM, int NBODAMBMIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C6F0", Offset = "0x2C6BAF0", VA = "0x182C6C6F0")]
		private void KOEBCBOPMEC(int BOIMPMGFDJM, int NBODAMBMIAE, bool DILCHIHLBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BEB0", Offset = "0x2C6B2B0", VA = "0x182C6BEB0")]
		private int AIIEHFHDCKF(BADKLKEFGCO NAFOACFEDAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C7B0", Offset = "0x2C6BBB0", VA = "0x182C6C7B0")]
		private bool LFHLIBCBGPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BF90", Offset = "0x2C6B390", VA = "0x182C6BF90")]
		private Dictionary<ComponentSystemBase, int> CIAJBCNONNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BED0", Offset = "0x2C6B2D0", VA = "0x182C6BED0")]
		private void AKMJICHBNLK(NativeArray<int> OGFDNPKHLBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C640", Offset = "0x2C6BA40", VA = "0x182C6C640")]
		private void HAIOAGLICIA(NativeArray<int> LBCJAENOALC, NativeArray<int> OGFDNPKHLBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C080", Offset = "0x2C6B480", VA = "0x182C6C080")]
		private static BADKLKEFGCO DCPPJMAHJBM(Type NLAFPPIOFPG, BADKLKEFGCO NANCDEAMBKG)
		{
			return default(BADKLKEFGCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D000", Offset = "0x2C6C400", VA = "0x182C6D000")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CD40", Offset = "0x2C6C140", VA = "0x182C6CD40")]
		[CompilerGenerated]
		private void NADNDAOCBPB(OIOAOEDFDMG OHLIKKPGLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C0E0", Offset = "0x2C6B4E0", VA = "0x182C6C0E0")]
		[CompilerGenerated]
		private void DHPBOPPHPGJ(BIJJPFLHCDJ OHLIKKPGLOF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[AFAPMPFKDID(JCDEPCAPNFC.WorldService)]
	[BGGFAGPLFND(typeof(EJFLHFELKLA), new string[] { })]
	public class TickService : OIOAOEDFDMG, EJFLHFELKLA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static readonly ProfilerMarker HKPNCKENNBF;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly ProfilerMarker EIKFFAMAAJK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly ProfilerMarker BPILJDMOHEM;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly ProfilerMarker FBDHAFEHBHE;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly ProfilerMarker BIOAMFECDNG;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly ProfilerMarker OGIFAOIKMMI;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly ProfilerMarker DGPJFGPDDKF;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static readonly ProfilerMarker OMBLPLIEGND;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly ProfilerMarker EBNEPABPIIJ;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker KHMAKGOMOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[GPKJCAPOIDC]
		private NGFGMFMKNCI NLNFAPHGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[GPKJCAPOIDC]
		private PHOJMNPNNFN KEJAKMEBEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[GPKJCAPOIDC]
		private TransformOwnershipPhase POHJJICNBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[GPKJCAPOIDC]
		private TimeService KKACNFNCHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private DOGKLJKKAGC ICDEHOIBFMN;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private bool PGBPNABCHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9D10", Offset = "0x2BD9110", VA = "0x182BD9D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private bool ALPGGEHPOEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9C70", Offset = "0x2BD9070", VA = "0x182BD9C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private bool BOGHLGNHHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9D10", Offset = "0x2BD9110", VA = "0x182BD9D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool IMLGCFNMDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9D10", Offset = "0x2BD9110", VA = "0x182BD9D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAB70", Offset = "0x2BD9F70", VA = "0x182BDAB70", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA7B0", Offset = "0x2BD9BB0", VA = "0x182BDA7B0", Slot = "14")]
		public void LAGOBGAADHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA8D0", Offset = "0x2BD9CD0", VA = "0x182BDA8D0", Slot = "15")]
		public void MNLLIJLLNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA410", Offset = "0x2BD9810", VA = "0x182BDA410", Slot = "5")]
		public void FOAFKLPBJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9F0", Offset = "0x2BD9DF0", VA = "0x182BDA9F0", Slot = "6")]
		public void OJADFBOHKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9D80", Offset = "0x2BD9180", VA = "0x182BD9D80", Slot = "7")]
		public void DCCIDDEMAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDACE0", Offset = "0x2BDA0E0", VA = "0x182BDACE0", Slot = "8")]
		public void PJHFLKJOMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA630", Offset = "0x2BD9A30", VA = "0x182BDA630", Slot = "9")]
		public void GHKECNMOFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9FD0", Offset = "0x2BD93D0", VA = "0x182BD9FD0", Slot = "10")]
		public void ELAKGBNBIPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F00", Offset = "0x2BD9300", VA = "0x182BD9F00", Slot = "11")]
		public void DKIDMAHHMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
		public void EIAMFFJBCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA4E0", Offset = "0x2BD98E0", VA = "0x182BDA4E0", Slot = "12")]
		public void GAAPHFOBLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[AFAPMPFKDID(JCDEPCAPNFC.WorldService)]
	[BGGFAGPLFND(typeof(FGEHAOHAFDI), new string[] { })]
	public class WorldService : FGEHAOHAFDI, IDisposable, EHPEJLPKBCA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DOGKLJKKAGC ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public DOGKLJKKAGC KHGEGLGEBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public NPLLDKEDKFD KBCPAMGBEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8B00", Offset = "0x2BE7F00", VA = "0x182BE8B00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x2BE8AE0", Offset = "0x2BE7EE0", VA = "0x182BE8AE0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool EMADIPGMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8B20", Offset = "0x2BE7F20", VA = "0x182BE8B20", Slot = "10")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2BE89D0", Offset = "0x2BE7DD0", VA = "0x182BE89D0")]
		private void GEGOECOOINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE87A0", Offset = "0x2BE7BA0", VA = "0x182BE87A0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8780", Offset = "0x2BE7B80", VA = "0x182BE8780", Slot = "8")]
		public ComponentSystemBase AEICJCCBMMN(Type NLAFPPIOFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BGGFAGPLFND(typeof(KAONIDNDOFG), new string[] { })]
public sealed class FMFKNBIIPEI : KAONIDNDOFG, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class IFGOPPDIOFD : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0A00", Offset = "0x2BCFE00", VA = "0x182BD0A00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAAD540", VA = "0x180AAE140")]
		[DebuggerHidden]
		public IFGOPPDIOFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD06F0", Offset = "0x2BCFAF0", VA = "0x182BD06F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD09C0", Offset = "0x2BCFDC0", VA = "0x182BD09C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0920", Offset = "0x2BCFD20", VA = "0x182BD0920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0920", Offset = "0x2BCFD20", VA = "0x182BD0920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[GPKJCAPOIDC]
	private DBALNFAKKBN CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly MJJLCIOLOIA IKPGPCBDMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<string, GKKFMIBFDNH> LPMPFJBJFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Dictionary<int, NKMFEBAPHJN> KLAMFEPBNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly List<GMLMCMNEFMA> LNANOCBCFDG;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NKMFEBAPHJN DJOBMHMMLND
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C73070", Offset = "0x2C72470", VA = "0x182C73070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public List<GMLMCMNEFMA> ENEDPEJIGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C73E80", Offset = "0x2C73280", VA = "0x182C73E80", Slot = "8")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C73700", Offset = "0x2C72B00", VA = "0x182C73700", Slot = "9")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C73670", Offset = "0x2C72A70", VA = "0x182C73670", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C737B0", Offset = "0x2C72BB0", VA = "0x182C737B0", Slot = "6")]
	public bool EHFNLAMFMGD(GMLMCMNEFMA GIOGLFNEEJE, out NKMFEBAPHJN JALFPKPFAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C732E0", Offset = "0x2C726E0", VA = "0x182C732E0")]
	private void DGHAMKCNJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C73140", Offset = "0x2C72540", VA = "0x182C73140")]
	private void CHBHBBNIAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C73D40", Offset = "0x2C73140", VA = "0x182C73D40")]
	private GKKFMIBFDNH NCCHKBCCIPC(string CNFHEMAKJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C73070", Offset = "0x2C72470", VA = "0x182C73070")]
	private GKKFMIBFDNH NGHAGKJPKKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C73A10", Offset = "0x2C72E10", VA = "0x182C73A10")]
	private GKKFMIBFDNH JFPCGPDLPLN(string CNFHEMAKJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C73840", Offset = "0x2C72C40", VA = "0x182C73840")]
	private GKKFMIBFDNH HMCOELJBLEH(string BABJIPJIPPC, string PFJMMABJIDH, [Optional] GKKFMIBFDNH IGDJFDIIBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C73CD0", Offset = "0x2C730D0", VA = "0x182C73CD0")]
	[IteratorStateMachine(typeof(IFGOPPDIOFD))]
	private IEnumerable<(string, string)> MNDFEEKHEMB(string CNFHEMAKJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C73C80", Offset = "0x2C73080", VA = "0x182C73C80")]
	private bool KBEBJJHGNPI(GMLMCMNEFMA GIOGLFNEEJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C72F90", Offset = "0x2C72390", VA = "0x182C72F90")]
	private MJJLCIOLOIA BIDLINPHFKH(GMLMCMNEFMA GIOGLFNEEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C73E30", Offset = "0x2C73230", VA = "0x182C73E30")]
	private MJJLCIOLOIA NMNECCGJKGE(GMLMCMNEFMA GIOGLFNEEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C73720", Offset = "0x2C72B20", VA = "0x182C73720")]
	private MJJLCIOLOIA EEFIPBPEIKG(GMLMCMNEFMA GIOGLFNEEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x27D1760", Offset = "0x27D0B60", VA = "0x1827D1760")]
	private T ODCIAONAEOC<T>(GMLMCMNEFMA GIOGLFNEEJE) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C730D0", Offset = "0x2C724D0", VA = "0x182C730D0")]
	private FieldInfo CGFAMFIAOBE(GMLMCMNEFMA GIOGLFNEEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C73EE0", Offset = "0x2C732E0", VA = "0x182C73EE0")]
	public FMFKNBIIPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C73DA0", Offset = "0x2C731A0", VA = "0x182C73DA0")]
	[CompilerGenerated]
	private int NJLOJBAKNBF(GMLMCMNEFMA ANJGLCCJFPO, GMLMCMNEFMA ABBMKKCGFBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class GKKFMIBFDNH : NKMFEBAPHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public readonly string EHMMJODJOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly GKKFMIBFDNH IGDJFDIIBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly List<GKKFMIBFDNH> PFKCALOAJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly List<GMLMCMNEFMA> CKCKOLCCJBK;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string DHDBFHECACA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public NKMFEBAPHJN CPNLEBEOMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public IEnumerable<NKMFEBAPHJN> HFHJPKIFKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public IEnumerable<GMLMCMNEFMA> ONGMFGHDJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C78640", Offset = "0x2C77A40", VA = "0x182C78640")]
	public GKKFMIBFDNH(string JODEBEIHAPC, GKKFMIBFDNH BLENCGKHIJI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[BGGFAGPLFND(typeof(AGECAABBCAI), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.History)]
	[FONHBDMNEGL(typeof(HistoryService))]
	public class HistoryService : OIOAOEDFDMG, IDisposable, AGECAABBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private enum NLKNCHOGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private readonly struct GHMLKLEPOEO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly NLKNCHOGCHH LBDINLBOJHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly HistoryService BHMPCEPJFGF;

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x45C0AB0", Offset = "0x45BFEB0", VA = "0x1845C0AB0")]
			public GHMLKLEPOEO(HistoryService BHMPCEPJFGF, bool BENGCIKOALN, uint CELCPLLAAGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x45C0A80", Offset = "0x45BFE80", VA = "0x1845C0A80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public class GFIDNNNNDHF
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			public struct CBLGFJFMOFO : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				private readonly GFIDNNNNDHF BIGIMFNMPLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				private readonly bool ELLJAMIMCNJ;

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x45BE800", Offset = "0x45BDC00", VA = "0x1845BE800")]
				public CBLGFJFMOFO(GFIDNNNNDHF BIGIMFNMPLJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x45BE7D0", Offset = "0x45BDBD0", VA = "0x1845BE7D0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003E")]
			public struct HNEPHONCCHH : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private readonly GFIDNNNNDHF BIGIMFNMPLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				private readonly bool ELLJAMIMCNJ;

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x45C16A0", Offset = "0x45C0AA0", VA = "0x1845C16A0")]
				public HNEPHONCCHH(GFIDNNNNDHF BIGIMFNMPLJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x45BE7D0", Offset = "0x45BDBD0", VA = "0x1845BE7D0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly HistoryService GBAPOEABIEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private bool AIKNFDDLMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private int AIBMJGKHEBE;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x45C0A40", Offset = "0x45BFE40", VA = "0x1845C0A40")]
			public GFIDNNNNDHF(HistoryService GBAPOEABIEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x45C0A10", Offset = "0x45BFE10", VA = "0x1845C0A10")]
			public bool NDFAKLCGNNF(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x45C0970", Offset = "0x45BFD70", VA = "0x1845C0970")]
			public HNEPHONCCHH CIOLDAEEPHF()
			{
				return default(HNEPHONCCHH);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x45C09C0", Offset = "0x45BFDC0", VA = "0x1845C09C0")]
			public CBLGFJFMOFO FNIOEMEIDIG()
			{
				return default(CBLGFJFMOFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class HFCJLHIFGFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public HFCJLHIFGFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x45C1180", Offset = "0x45C0580", VA = "0x1845C1180")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class ENLNCOMLAGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public ENLNCOMLAGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x45C02B0", Offset = "0x45BF6B0", VA = "0x1845C02B0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class PKDCDNIJOJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public PKDCDNIJOJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x45C7BC0", Offset = "0x45C6FC0", VA = "0x1845C7BC0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly UndoAction IABNCNBKPLF;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly RedoAction ABMLLLAAOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private PBPAAJMLMCL AIBIAGFHEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private ActionBuffer NPGOIMBBHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private ActionBuffer CJFGEKIFIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private MLGKMOEOAJD KGKHMIAKHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private TransformOwnershipPhase POHJJICNBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private PropertyChangeRouterService JJPHOOBJDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private JBIMGIHPKMP CIPOOAKLDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private NLKNCHOGCHH JHKBFCIIDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private GFIDNNNNDHF BIGIMFNMPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AECJABNNLMC NILIJGCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private JFAKMNMKBKN PGFIIEBCPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private EKCDKOGIIEF FOLHBACKCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly GatherPropertiesForUndelete JEINODMCIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private uint KGLFPANKNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private uint OBELHJADIMJ;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private GFIDNNNNDHF FCHJODDFDLM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool ANIKKAOCMON
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2C7C330", Offset = "0x2C7B730", VA = "0x182C7C330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool LOHCDHFALAF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D210", Offset = "0x2C7C610", VA = "0x182C7D210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool PPBEGPAJOME
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D020", Offset = "0x2C7C420", VA = "0x182C7D020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int NJIEBNFNJEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D5C0", Offset = "0x2C7C9C0", VA = "0x182C7D5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int LKEHLJCOONE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2C7C3A0", Offset = "0x2C7B7A0", VA = "0x182C7C3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private bool EPPKHGMNFPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D550", Offset = "0x2C7C950", VA = "0x182C7D550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private bool GBAABPDGOJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x2C7C0E0", Offset = "0x2C7B4E0", VA = "0x182C7C0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool DJJKCOIGAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x93F6F0", Offset = "0x93EAF0", VA = "0x18093F6F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x16F2D40", Offset = "0x16F2140", VA = "0x1816F2D40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private ActionBuffer ACKPKDMNOMI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x2C7C420", Offset = "0x2C7B820", VA = "0x182C7C420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action KNOHLDLEDGP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2C7C430", Offset = "0x2C7B830", VA = "0x182C7C430", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2C7CEB0", Offset = "0x2C7C2B0", VA = "0x182C7CEB0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action HGKPOKOHHDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x2C7E1E0", Offset = "0x2C7D5E0", VA = "0x182C7E1E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C7D310", Offset = "0x2C7C710", VA = "0x182C7D310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7DCF0", Offset = "0x2C7D0F0", VA = "0x182C7DCF0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C790", Offset = "0x2C7BB90", VA = "0x182C7C790", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D070", Offset = "0x2C7C470", VA = "0x182C7D070")]
		private void IGGBADNMEAI(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D3B0", Offset = "0x2C7C7B0", VA = "0x182C7D3B0")]
		private void KKDANGPKBEE(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ELEHMCHKFPL, DMCBBFPDIBM NKLJAHJEFHB, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C7DA60", Offset = "0x2C7CE60", VA = "0x182C7DA60")]
		private void NPICIINGILI(DLABIEOOCHD ODKPHBBMMPO, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D890", Offset = "0x2C7CC90", VA = "0x182C7D890", Slot = "14")]
		public IDisposable NFOPDLFOMCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D560", Offset = "0x2C7C960", VA = "0x182C7D560", Slot = "9")]
		public IDisposable MGAAPAFKPLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C270", Offset = "0x2C7B670", VA = "0x182C7C270", Slot = "6")]
		public UndoAction BFHCOKJLHNM()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C4D0", Offset = "0x2C7B8D0", VA = "0x182C7C4D0", Slot = "15")]
		public RedoAction DMKCMLHOOLB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D660", Offset = "0x2C7CA60", VA = "0x182C7D660", Slot = "16")]
		public UndoAction MMPDHDGAAPN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C590", Offset = "0x2C7B990", VA = "0x182C7C590", Slot = "7")]
		public RedoAction DMKCMLHOOLB(UndoAction ENDGJBMJNDE)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D720", Offset = "0x2C7CB20", VA = "0x182C7D720", Slot = "8")]
		public UndoAction MMPDHDGAAPN(RedoAction ENDGJBMJNDE)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E1A0", Offset = "0x2C7D5A0", VA = "0x182C7E1A0")]
		public bool PGKBDLCHJMO(ODAEONFNEPL BCMIFBEGGGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CFD0", Offset = "0x2C7C3D0", VA = "0x182C7CFD0", Slot = "17")]
		public void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CDF0", Offset = "0x2C7C1F0", VA = "0x182C7CDF0")]
		public void FDPPJMGMAAM(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D130", Offset = "0x2C7C530", VA = "0x182C7D130")]
		public void JAFGFGNMGBJ(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, in DMCBBFPDIBM NKLJAHJEFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C7DC40", Offset = "0x2C7D040", VA = "0x182C7DC40")]
		public void NPMHDFIHKNN(DLABIEOOCHD ODKPHBBMMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CF50", Offset = "0x2C7C350", VA = "0x182C7CF50")]
		private void FJGGLJDHFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CF90", Offset = "0x2C7C390", VA = "0x182C7CF90")]
		private void GKJAPLPDIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D050", Offset = "0x2C7C450", VA = "0x182C7D050")]
		private void IECHMBICALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CA30", Offset = "0x2C7BE30", VA = "0x182C7CA30")]
		private BJHHMFNLFAP EGCMDBILDDA()
		{
			return default(BJHHMFNLFAP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D870", Offset = "0x2C7CC70", VA = "0x182C7D870")]
		private uint NEGDBCIKICN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7DA40", Offset = "0x2C7CE40", VA = "0x182C7DA40")]
		private bool NPDDCMDALFB(out BJHHMFNLFAP PADKGNIPPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C250", Offset = "0x2C7B650", VA = "0x182C7C250")]
		private bool AOOBAMKJDEB(out BJHHMFNLFAP PADKGNIPPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D2B0", Offset = "0x2C7C6B0", VA = "0x182C7D2B0")]
		private RedoAction KFNPLHFDEEF(BJHHMFNLFAP PADKGNIPPLI)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C3C0", Offset = "0x2C7B7C0", VA = "0x182C7C3C0")]
		private UndoAction DBLAKIJPLLI(BJHHMFNLFAP PADKGNIPPLI)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CB30", Offset = "0x2C7BF30", VA = "0x182C7CB30")]
		private BJHHMFNLFAP EKKGIMMGIKP(BJHHMFNLFAP PADKGNIPPLI, ActionBuffer GODAAHFJFFO, bool BENGCIKOALN)
		{
			return default(BJHHMFNLFAP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C6B0", Offset = "0x2C7BAB0", VA = "0x182C7C6B0")]
		private void DOMKDOCOOLF(Action PADKGNIPPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x21EAE60", Offset = "0x21EA260", VA = "0x1821EAE60")]
		private T DOMKDOCOOLF<T>(Func<T> DIPDMFLCIBB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D840", Offset = "0x2C7CC40", VA = "0x182C7D840")]
		private GHMLKLEPOEO NBLFNMHNBGI(bool BENGCIKOALN, uint CELCPLLAAGH)
		{
			return default(GHMLKLEPOEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E360", Offset = "0x2C7D760", VA = "0x182C7E360")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D8F0", Offset = "0x2C7CCF0", VA = "0x182C7D8F0")]
		[CompilerGenerated]
		private UndoAction NNFBLJJPNLK()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C7D3D0", Offset = "0x2C7C7D0", VA = "0x182C7D3D0")]
		[CompilerGenerated]
		private RedoAction LMFGAMFPPGC()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C0F0", Offset = "0x2C7B4F0", VA = "0x182C7C0F0")]
		[CompilerGenerated]
		private UndoAction AGIHIKOFJDE()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MMMPICCOLCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeArray<byte> CCKHAOABLMF;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public MMMPICCOLCC(NativeArray<byte> CCKHAOABLMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A36C00", Offset = "0x2A36000", VA = "0x182A36C00")]
	public static MMMPICCOLCC IGKGMCHPHKB(NativeArray<byte> CCKHAOABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	public T CJIEGGPIGDI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public NativeArray<T> FMCCEPDKPAN<T>(int EBMDFJGMEAO, Allocator NHNCCHNPCJI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	public NativeArray<T> ENHDBJJMHGH<T>(Allocator NHNCCHNPCJI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EJIDPKAFHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private NativeArray<byte> CCKHAOABLMF;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public EJIDPKAFHHH(NativeArray<byte> CCKHAOABLMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A430", Offset = "0x2D19830", VA = "0x182D1A430")]
	public static EJIDPKAFHHH IGKGMCHPHKB(NativeArray<byte> CCKHAOABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2032600", Offset = "0x2031A00", VA = "0x182032600")]
	public T CJIEGGPIGDI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	public NativeArray<T> FMCCEPDKPAN<T>(int EBMDFJGMEAO, Allocator NHNCCHNPCJI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class CCNDDHAAEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<byte> CCKHAOABLMF;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public CCNDDHAAEHB(NativeArray<byte> CCKHAOABLMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2D09170", Offset = "0x2D08570", VA = "0x182D09170")]
	public static CCNDDHAAEHB IGKGMCHPHKB(NativeArray<byte> CCKHAOABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DE10", Offset = "0x2E7D210", VA = "0x182E7DE10")]
	public void BKABDMKJGAC<T>(in T PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DE70", Offset = "0x2E7D270", VA = "0x182E7DE70")]
	public void KEDEJOKPEIC<T>(NativeArray<T> NOBDDMHFHPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	public void KKKLGGKHGIB<T>(NativeArray<T> PKODKJLGOIN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BFACLNCDCND
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2D05A10", Offset = "0x2D04E10", VA = "0x182D05A10")]
	public static Span<byte> ELAGJCJFLKC(this NativeArray<byte> CCKHAOABLMF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2D05810", Offset = "0x2D04C10", VA = "0x182D05810")]
	public static ReadOnlySpan<byte> BEFOGBCAPKA(this NativeArray<byte> CCKHAOABLMF)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2D05B10", Offset = "0x2D04F10", VA = "0x182D05B10")]
	public static NativeArray<byte> HNICMPNFACI(this NativeArray<byte> CCKHAOABLMF, int BOIMPMGFDJM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2D05790", Offset = "0x2D04B90", VA = "0x182D05790")]
	public static NativeArray<byte> ANJBIPJJLLA(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2A28050", Offset = "0x2A27450", VA = "0x182A28050")]
	public static NativeArray<byte> ANJBIPJJLLA<T>(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2D05AA0", Offset = "0x2D04EA0", VA = "0x182D05AA0")]
	public static NativeArray<byte> HDLBJHAPAFC(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A295F0", Offset = "0x2A289F0", VA = "0x182A295F0")]
	public static NativeArray<byte> HDLBJHAPAFC<T>(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2D05990", Offset = "0x2D04D90", VA = "0x182D05990")]
	public static NativeArray<byte> CCOPBGEIPBJ(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A280B0", Offset = "0x2A274B0", VA = "0x182A280B0")]
	public static NativeArray<byte> CCOPBGEIPBJ<T>(this NativeArray<byte> CCKHAOABLMF, int EFJDLDLIAEL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MHGGFHLPBFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeList<byte> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public MHGGFHLPBFB(NativeList<byte> BEOMDPHLMGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2C88320", Offset = "0x2C87720", VA = "0x182C88320")]
	public static MHGGFHLPBFB IGKGMCHPHKB(NativeList<byte> CCKHAOABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	public void BKABDMKJGAC<T>(in T PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	public void KEDEJOKPEIC<T>(NativeArray<T> PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	public void KKKLGGKHGIB<T>(NativeArray<T> PKODKJLGOIN) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[BGGFAGPLFND(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.PropertyChanges)]
	public class PropertyChangeNetworkRouter : EHPEJLPKBCA, OIOAOEDFDMG, DGPMAHPPOKF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[GPKJCAPOIDC]
		private LFDHBCPGFAN HAPALLCNNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[GPKJCAPOIDC]
		private FEILDLCAMGM CKCKOLCCJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[GPKJCAPOIDC]
		private DOOMDJDMHCG LLKHHJDGPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[GPKJCAPOIDC]
		private PropertyChangeRouterService JJPHOOBJDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PBPAAJMLMCL FOPIKDEMFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ACFOGPILAFJ PNOAFPCBLOI;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public PBPAAJMLMCL HGACLGDNFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2A52750", Offset = "0x2A51B50", VA = "0x182A52750")]
		public PBPAAJMLMCL.IACCEHDACFM DEJNGPMHEOB()
		{
			return default(PBPAAJMLMCL.IACCEHDACFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2A52E70", Offset = "0x2A52270", VA = "0x182A52E70", Slot = "4")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2A53110", Offset = "0x2A52510", VA = "0x182A53110", Slot = "5")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2A52A70", Offset = "0x2A51E70", VA = "0x182A52A70", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2A52540", Offset = "0x2A51940", VA = "0x182A52540")]
		public void BFHCOKJLHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2A52D70", Offset = "0x2A52170", VA = "0x182A52D70")]
		public void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2A53000", Offset = "0x2A52400", VA = "0x182A53000")]
		private void NGOMGAECAOP(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2A52DA0", Offset = "0x2A521A0", VA = "0x182A52DA0")]
		private void IJEOOHPFOIA(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ELEHMCHKFPL, DMCBBFPDIBM NKLJAHJEFHB, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2A52650", Offset = "0x2A51A50", VA = "0x182A52650")]
		private void DDCMKFIJMIH(DLABIEOOCHD ODKPHBBMMPO, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2A52790", Offset = "0x2A51B90", VA = "0x182A52790")]
		private void DPMIFACLKFP(ACFOGPILAFJ EKGMIOGLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2A53390", Offset = "0x2A52790", VA = "0x182A53390")]
		private void PNGHGPPDPEP(ACFOGPILAFJ EKGMIOGLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2A52CB0", Offset = "0x2A520B0", VA = "0x182A52CB0")]
		private void HGJIOFKMAFI(ACFOGPILAFJ EKGMIOGLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2A52E50", Offset = "0x2A52250", VA = "0x182A52E50")]
		private void JIILAAKEFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2A52C90", Offset = "0x2A52090", VA = "0x182A52C90")]
		private void GNGIFJMGMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2A52F60", Offset = "0x2A52360", VA = "0x182A52F60")]
		private void LMBMHLPLBLA(ACFOGPILAFJ EKGMIOGLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x39836B0", Offset = "0x3982AB0", VA = "0x1839836B0", Slot = "6")]
		private void NNGADAMHFBN<TKey, T>(global::DFOJKPKKLBC<TKey, T> GIOGLFNEEJE, object IDEIPFIOJKJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[AFAPMPFKDID(JCDEPCAPNFC.History)]
	[BGGFAGPLFND(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate void JHMAFEIBEPL(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD, bool JFLMLABFBOH);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public delegate void ALBHDPLOLMD(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ELEHMCHKFPL, DMCBBFPDIBM NKLJAHJEFHB, bool JFLMLABFBOH);

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public delegate void KMFFHGPFHHG(DLABIEOOCHD ODKPHBBMMPO, bool JFLMLABFBOH);

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public JHMAFEIBEPL GEGOECOOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ALBHDPLOLMD GCGKGDBLFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KMFFHGPFHHG AFFPDBIGLLL;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2A53510", Offset = "0x2A52910", VA = "0x182A53510")]
		public void FDPPJMGMAAM(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2A53530", Offset = "0x2A52930", VA = "0x182A53530")]
		public void JAFGFGNMGBJ(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, in DMCBBFPDIBM ELEHMCHKFPL, in DMCBBFPDIBM NKLJAHJEFHB, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2A535A0", Offset = "0x2A529A0", VA = "0x182A535A0")]
		public void NPMHDFIHKNN(DLABIEOOCHD ODKPHBBMMPO, bool JFLMLABFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[DebuggerTypeProxy(typeof(PAGFJFKJIDH))]
	[AFAPMPFKDID(JCDEPCAPNFC.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		internal class PAGFJFKJIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly ActionBuffer BPMIJGKONLK;

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public int MHDOGPFGFFD
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1800", Offset = "0x2BD0C00", VA = "0x182BD1800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public BOBPHBNJINA[] DCCABFBHLAE
			{
				[Cpp2IlInjected.Token(Token = "0x600035B")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1850", Offset = "0x2BD0C50", VA = "0x182BD1850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
			public PAGFJFKJIDH(ActionBuffer MOBGIBJMKEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1710", Offset = "0x2BD0B10", VA = "0x182BD1710")]
			[CompilerGenerated]
			private BOBPHBNJINA AKICADLBHGK(BJHHMFNLFAP PADKGNIPPLI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		internal class BOBPHBNJINA : DGPMAHPPOKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly ActionBuffer BPMIJGKONLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly BJHHMFNLFAP PADKGNIPPLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private List<(ACFOGPILAFJ, string, object)> KJICPDPGIDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private EJIDPKAFHHH IGGKMMMGNJJ;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public int MHDOGPFGFFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2BCDCD0", Offset = "0x2BCD0D0", VA = "0x182BCDCD0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public List<(ACFOGPILAFJ, string, object)> JGHPJNIOBBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE160", Offset = "0x2BCD560", VA = "0x182BCE160")]
			public BOBPHBNJINA(ActionBuffer MOBGIBJMKEF, BJHHMFNLFAP PADKGNIPPLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDD20", Offset = "0x2BCD120", VA = "0x182BCDD20")]
			private string LLEHCHBNIDH(ACFOGPILAFJ PNOAFPCBLOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDE20", Offset = "0x2BCD220", VA = "0x182BCDE20")]
			private void NGKBIODLKGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x25EA8B0", Offset = "0x25E9CB0", VA = "0x1825EA8B0", Slot = "4")]
			public void BPDLDKHKAOA<TKey, T>(global::DFOJKPKKLBC<TKey, T> GIOGLFNEEJE, [Optional] object IDEIPFIOJKJ) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private NativeList<byte> LGAMCIMMCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly Stack<BJHHMFNLFAP> FFBJDBBPAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly KABGGPLCJGE HDMNEJBCKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly AECJABNNLMC NILIJGCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly FEILDLCAMGM CKCKOLCCJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly bool HAMCAFDIJNP;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public MOABPAKNKCE GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2D02E80", Offset = "0x2D02280", VA = "0x182D02E80")]
			get
			{
				return default(MOABPAKNKCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int MHDOGPFGFFD
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x2D03250", Offset = "0x2D02650", VA = "0x182D03250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2D03BD0", Offset = "0x2D02FD0", VA = "0x182D03BD0")]
		public ActionBuffer(AECJABNNLMC NILIJGCOFNN, FEILDLCAMGM CKCKOLCCJBK, bool HAMCAFDIJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2D037C0", Offset = "0x2D02BC0", VA = "0x182D037C0")]
		public bool MBNCIDBFAFK(out BJHHMFNLFAP PADKGNIPPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2D03500", Offset = "0x2D02900", VA = "0x182D03500")]
		public void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2D02EC0", Offset = "0x2D022C0", VA = "0x182D02EC0")]
		public BJHHMFNLFAP BFHCOKJLHNM(GFLOILOIGLL KJICPDPGIDE, JBIMGIHPKMP CIPOOAKLDAN, uint AIHBGCJGGAL)
		{
			return default(BJHHMFNLFAP);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2D03000", Offset = "0x2D02400", VA = "0x182D03000")]
		public bool BHLABMKBAPF(uint AIHBGCJGGAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2D03990", Offset = "0x2D02D90", VA = "0x182D03990")]
		public bool ONAHKEOOEIO(uint AIHBGCJGGAL, out BJHHMFNLFAP ENDGJBMJNDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2D03570", Offset = "0x2D02970", VA = "0x182D03570")]
		public void IOJEBLJBPBB(BJHHMFNLFAP ENDGJBMJNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2D03850", Offset = "0x2D02C50", VA = "0x182D03850")]
		[Conditional("DEBUG_BUILD")]
		private void OHNMPPPJJOF(BJHHMFNLFAP ENDGJBMJNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2D030A0", Offset = "0x2D024A0", VA = "0x182D030A0")]
		private void EKKGIMMGIKP(BJHHMFNLFAP KJLNEKPMEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2D03290", Offset = "0x2D02690", VA = "0x182D03290")]
		private void GKHJCIKHGNE(EJIDPKAFHHH FLDKEOIMAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2D031F0", Offset = "0x2D025F0", VA = "0x182D031F0")]
		private void FLNCIIOEOMG(BJHHMFNLFAP PADKGNIPPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2D036E0", Offset = "0x2D02AE0", VA = "0x182D036E0")]
		private EJIDPKAFHHH LBCJDHEOFPN(BJHHMFNLFAP PADKGNIPPLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2D03030", Offset = "0x2D02430", VA = "0x182D03030", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class KABGGPLCJGE : DGPMAHPPOKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly AECJABNNLMC NILIJGCOFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FEILDLCAMGM CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private DLABIEOOCHD ODKPHBBMMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EJIDPKAFHHH DDCHMCOLHMI;

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x66D6E0", Offset = "0x66CAE0", VA = "0x18066D6E0")]
	public KABGGPLCJGE(AECJABNNLMC NILIJGCOFNN, FEILDLCAMGM CKCKOLCCJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x26278A0", Offset = "0x2626CA0", VA = "0x1826278A0", Slot = "4")]
	public void BPDLDKHKAOA<TKey, T>(global::DFOJKPKKLBC<TKey, T> KMGAAAKIJHE, [Optional] object IDEIPFIOJKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2C83330", Offset = "0x2C82730", VA = "0x182C83330")]
	public void AJIBBCJIBFD(ACFOGPILAFJ PNOAFPCBLOI, ref EJIDPKAFHHH FLDKEOIMAFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PBPAAJMLMCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IACCEHDACFM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly PBPAAJMLMCL BLENCGKHIJI;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x45C1700", Offset = "0x45C0B00", VA = "0x1845C1700")]
		public IACCEHDACFM(PBPAAJMLMCL BLENCGKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x45C16E0", Offset = "0x45C0AE0", VA = "0x1845C16E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	protected GFLOILOIGLL KJICPDPGIDE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GFLOILOIGLL JGHPJNIOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A0F0", Offset = "0x2A494F0", VA = "0x182A4A0F0")]
		get
		{
			return default(GFLOILOIGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool JMEGGAJPGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A5E0", Offset = "0x2A499E0", VA = "0x182A4A5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A5F0", Offset = "0x2A499F0", VA = "0x182A4A5F0")]
	public PBPAAJMLMCL(GFLOILOIGLL.NJGLNFDCNHM JPLNKIHFDEF = GFLOILOIGLL.NJGLNFDCNHM.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A360", Offset = "0x2A49760", VA = "0x182A4A360")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A170", Offset = "0x2A49570", VA = "0x182A4A170")]
	public void FDPPJMGMAAM(DLABIEOOCHD ODKPHBBMMPO, KLNEOHHKOFO HIDIJDEBIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A370", Offset = "0x2A49770", VA = "0x182A4A370")]
	public void JAFGFGNMGBJ(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A500", Offset = "0x2A49900", VA = "0x182A4A500")]
	public void NPMHDFIHKNN(DLABIEOOCHD ODKPHBBMMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A400", Offset = "0x2A49800", VA = "0x182A4A400")]
	public void JIILAAKEFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A260", Offset = "0x2A49660", VA = "0x182A4A260")]
	public void GNGIFJMGMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A160", Offset = "0x2A49560", VA = "0x182A4A160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A130", Offset = "0x2A49530", VA = "0x182A4A130")]
	public IACCEHDACFM DEJNGPMHEOB()
	{
		return default(IACCEHDACFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct ACFOGPILAFJ : IComparable<ACFOGPILAFJ>, IEquatable<ACFOGPILAFJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static readonly ACFOGPILAFJ KCHJKIMPEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public DLABIEOOCHD ODKPHBBMMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public EKCDKOGIIEF FHKHLDOKDFM;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC870", Offset = "0x2CFBC70", VA = "0x182CFC870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
	public ACFOGPILAFJ(DLABIEOOCHD ODKPHBBMMPO, EKCDKOGIIEF FHKHLDOKDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC880", Offset = "0x2CFBC80", VA = "0x182CFC880")]
	public void KBJIHOMMPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC670", Offset = "0x2CFBA70", VA = "0x182CFC670", Slot = "4")]
	public int CompareTo(ACFOGPILAFJ BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC890", Offset = "0x2CFBC90", VA = "0x182CFC890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC6B0", Offset = "0x2CFBAB0", VA = "0x182CFC6B0", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC750", Offset = "0x2CFBB50", VA = "0x182CFC750", Slot = "5")]
	public bool Equals(ACFOGPILAFJ BKBGGIICJOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC830", Offset = "0x2CFBC30", VA = "0x182CFC830")]
	public static bool HOHCOENENOO(ACFOGPILAFJ EIPBHONBEOF, ACFOGPILAFJ KHDOHMLGMCL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC7A0", Offset = "0x2CFBBA0", VA = "0x182CFC7A0")]
	public static bool GJGNKFAGFPG(ACFOGPILAFJ EIPBHONBEOF, ACFOGPILAFJ KHDOHMLGMCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC7F0", Offset = "0x2CFBBF0", VA = "0x182CFC7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AFAPMPFKDID(JCDEPCAPNFC.History)]
	public class GatherPropertiesForUndelete : PLHAONFOPHE
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private AECJABNNLMC NILIJGCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private DLABIEOOCHD ODKPHBBMMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private HistoryService GBAPOEABIEL;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A0A0", Offset = "0x2C794A0", VA = "0x182C7A0A0")]
		public void OCDFAGNDEKO(DLABIEOOCHD ODKPHBBMMPO, AECJABNNLMC NILIJGCOFNN, HistoryService GBAPOEABIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2C79FD0", Offset = "0x2C793D0", VA = "0x182C79FD0", Slot = "4")]
		private void ELCFECNECLE(NMADPBMEMAM GIOGLFNEEJE, in DMCBBFPDIBM PKODKJLGOIN, object IDEIPFIOJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ANLCPKNINON
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2D02370", Offset = "0x2D01770", VA = "0x182D02370")]
	public static void PNGHGPPDPEP(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI, KLNEOHHKOFO HIDIJDEBIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2D02110", Offset = "0x2D01510", VA = "0x182D02110")]
	public static void CJNCKBIFHHP(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2D02270", Offset = "0x2D01670", VA = "0x182D02270")]
	public static void HGJIOFKMAFI(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2D022C0", Offset = "0x2D016C0", VA = "0x182D022C0")]
	public static void LMJEHKGBOEI(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2D021D0", Offset = "0x2D015D0", VA = "0x182D021D0")]
	public static KLNEOHHKOFO HEPIADJMOHE(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI)
	{
		return default(KLNEOHHKOFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x282A160", Offset = "0x2829560", VA = "0x18282A160")]
	public static T NBFDDNNELLE<T>(GFLOILOIGLL KJICPDPGIDE, ACFOGPILAFJ PNOAFPCBLOI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x282A1A0", Offset = "0x28295A0", VA = "0x18282A1A0")]
	public static T NBFDDNNELLE<T>(ref EJIDPKAFHHH HANEMGLFJMM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2D02220", Offset = "0x2D01620", VA = "0x182D02220")]
	public static KLNEOHHKOFO HEPIADJMOHE(ref EJIDPKAFHHH HANEMGLFJMM)
	{
		return default(KLNEOHHKOFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct GFLOILOIGLL : IEnumerable<ACFOGPILAFJ>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum NJGLNFDCNHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private struct LOAOJGGJCCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly GFLOILOIGLL BEOMDPHLMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly JBIMGIHPKMP CIPOOAKLDAN;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x45C4950", Offset = "0x45C3D50", VA = "0x1845C4950")]
		public LOAOJGGJCCE(GFLOILOIGLL BEOMDPHLMGK, JBIMGIHPKMP CIPOOAKLDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x45C4410", Offset = "0x45C3810", VA = "0x1845C4410")]
		public void JBJECBOLMMM(NativeList<byte> GHBMNGPKFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x45C42D0", Offset = "0x45C36D0", VA = "0x1845C42D0")]
		private void DHKAECIPJHE(ACFOGPILAFJ PNOAFPCBLOI, ref CCNDDHAAEHB NCOBOLMBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x45C4690", Offset = "0x45C3A90", VA = "0x1845C4690")]
		private void KAFLLLFOHEK(ACFOGPILAFJ PNOAFPCBLOI, ref CCNDDHAAEHB NCOBOLMBNNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x45C4080", Offset = "0x45C3480", VA = "0x1845C4080")]
		private NativeArray<byte> AJDOJNIOAMI(NativeList<byte> GHBMNGPKFNO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x45C4320", Offset = "0x45C3720", VA = "0x1845C4320")]
		private NativeArray<byte> IDPKEOFMLFG(NativeList<byte> GHBMNGPKFNO, int EBMDFJGMEAO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x45C4720", Offset = "0x45C3B20", VA = "0x1845C4720")]
		private int LPNKNMPILGC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x45C4170", Offset = "0x45C3570", VA = "0x1845C4170")]
		private bool CLGNHEDPFBD(ACFOGPILAFJ PNOAFPCBLOI, out NativeArray<byte> CABLEGNAMLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct BPNIOMNOFAD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private NativeList<byte> HANEMGLFJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private GFLOILOIGLL BEOMDPHLMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private readonly ACFOGPILAFJ EKGMIOGLPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private readonly int BOIMPMGFDJM;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE4A0", Offset = "0x2BCD8A0", VA = "0x182BCE4A0")]
		internal BPNIOMNOFAD(GFLOILOIGLL BEOMDPHLMGK, ACFOGPILAFJ EKGMIOGLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE280", Offset = "0x2BCD680", VA = "0x182BCE280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE440", Offset = "0x2BCD840", VA = "0x182BCE440")]
		public void PHLDKHLKBCM(NativeArray<byte> PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE220", Offset = "0x2BCD620", VA = "0x182BCE220")]
		public void DIFBPKJJFAD(NativeArray<byte> PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE2B0", Offset = "0x2BCD6B0", VA = "0x182BCE2B0")]
		public void KAFLLLFOHEK(in DMCBBFPDIBM PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x25F31A0", Offset = "0x25F25A0", VA = "0x1825F31A0")]
		public void KAFLLLFOHEK<T>(T PKODKJLGOIN) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE2C0", Offset = "0x2BCD6C0", VA = "0x182BCE2C0")]
		private void MLLJDCFFLNG(int PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE330", Offset = "0x2BCD730", VA = "0x182BCE330")]
		private void MLLJDCFFLNG(in DMCBBFPDIBM PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE3E0", Offset = "0x2BCD7E0", VA = "0x182BCE3E0")]
		private unsafe void MLLJDCFFLNG(void* GJOMIADCNOK, int EBMDFJGMEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE440", Offset = "0x2BCD840", VA = "0x182BCE440")]
		private void MLLJDCFFLNG(NativeArray<byte> NOBDDMHFHPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OKIOICPJEGE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private GFLOILOIGLL BEOMDPHLMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private NativeArray<byte> HANEMGLFJMM;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x45C7820", Offset = "0x45C6C20", VA = "0x1845C7820")]
		internal OKIOICPJEGE(GFLOILOIGLL BEOMDPHLMGK, NativeArray<byte> HANEMGLFJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x45C7660", Offset = "0x45C6A60", VA = "0x1845C7660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x45C7760", Offset = "0x45C6B60", VA = "0x1845C7760")]
		public NativeArray<byte> FMCCEPDKPAN(int EBMDFJGMEAO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x45C7670", Offset = "0x45C6A70", VA = "0x1845C7670")]
		public NativeArray<byte> ENHDBJJMHGH()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x25F8BC0", Offset = "0x25F7FC0", VA = "0x1825F8BC0")]
		public T CJIEGGPIGDI<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x45C7560", Offset = "0x45C6960", VA = "0x1845C7560")]
		public void CJIEGGPIGDI(in GANDDJBCJLO PKODKJLGOIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GKOPFMAHALK : IEnumerator<ACFOGPILAFJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly NativeList<ACFOGPILAFJ> CCKHAOABLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private int PGFOAHEHPOH;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public ACFOGPILAFJ GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0080", Offset = "0x2BCF480", VA = "0x182BD0080", Slot = "4")]
			get
			{
				return default(ACFOGPILAFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0030", Offset = "0x2BCF430", VA = "0x182BD0030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0070", Offset = "0x2BCF470", VA = "0x182BD0070")]
		internal GKOPFMAHALK(NativeList<ACFOGPILAFJ> NOBDDMHFHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFEF0", Offset = "0x2BCF2F0", VA = "0x182BCFEF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFFF0", Offset = "0x2BCF3F0", VA = "0x182BCFFF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct AABMOFMELOO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private const int BFHNFPGJIPG = 0;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private const int JIKGDGHFIMC = 1;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private const int JILLNMOLFNF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NativeArray<int> HANEMGLFJMM;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool EIEEJMIIAKB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCAC0", Offset = "0x2BCBEC0", VA = "0x182BCCAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public int HLKNFFMBMGK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCBE0", Offset = "0x2BCBFE0", VA = "0x182BCCBE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCB90", Offset = "0x2BCBF90", VA = "0x182BCCB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public NJGLNFDCNHM LGPBHGBBGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCBF0", Offset = "0x2BCBFF0", VA = "0x182BCCBF0")]
			get
			{
				return default(NJGLNFDCNHM);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCC00", Offset = "0x2BCC000", VA = "0x182BCCC00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool JMEGGAJPGKL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCC40", Offset = "0x2BCC040", VA = "0x182BCCC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCB70", Offset = "0x2BCBF70", VA = "0x182BCCB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool AFOBDDDONNO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCC30", Offset = "0x2BCC030", VA = "0x182BCCC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCC10", Offset = "0x2BCC010", VA = "0x182BCCC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCC50", Offset = "0x2BCC050", VA = "0x182BCCC50")]
		public AABMOFMELOO(NJGLNFDCNHM JPLNKIHFDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCB00", Offset = "0x2BCBF00", VA = "0x182BCCB00")]
		private int DPALGOGEJPD(int MJMHIELCMAL, int MNADLPNMEOB = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCBA0", Offset = "0x2BCBFA0", VA = "0x182BCCBA0")]
		private void JKDFMHKJMMK(int MJMHIELCMAL, int PKODKJLGOIN, int MNADLPNMEOB = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCB30", Offset = "0x2BCBF30", VA = "0x182BCCB30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private const int CKLHOBBNBIP = -1;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private const int PHHEFMCAKKB = 0;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly ACFOGPILAFJ LIHGCHOMNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeHashMap<ACFOGPILAFJ, int> HFJPAOEGHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeList<ACFOGPILAFJ> KJICPDPGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeList<int> ENCNKOILBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private NativeList<byte> CAOJNDHMLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private NativeList<byte> HANEMGLFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private AABMOFMELOO DALCKALNCCE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool JMEGGAJPGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2C75FD0", Offset = "0x2C753D0", VA = "0x182C75FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IDMFHAGNMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2C754C0", Offset = "0x2C748C0", VA = "0x182C754C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int HLKNFFMBMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2C75B00", Offset = "0x2C74F00", VA = "0x182C75B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int APMAHMKEOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2C75A80", Offset = "0x2C74E80", VA = "0x182C75A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2C75760", Offset = "0x2C74B60", VA = "0x182C75760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2C75960", Offset = "0x2C74D60", VA = "0x182C75960")]
	public static GFLOILOIGLL GEGOECOOINK(NJGLNFDCNHM JPLNKIHFDEF = NJGLNFDCNHM.Last, int ELFIDGOEDGI = 16, int NEJDPBNNEJG = 256)
	{
		return default(GFLOILOIGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2C761B0", Offset = "0x2C755B0", VA = "0x182C761B0")]
	private GFLOILOIGLL(NJGLNFDCNHM JPLNKIHFDEF, int ELFIDGOEDGI, int NEJDPBNNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2C75830", Offset = "0x2C74C30", VA = "0x182C75830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2C757A0", Offset = "0x2C74BA0", VA = "0x182C757A0")]
	public BPNIOMNOFAD DPMIFACLKFP(ACFOGPILAFJ EKGMIOGLPIC)
	{
		return default(BPNIOMNOFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2C756D0", Offset = "0x2C74AD0", VA = "0x182C756D0")]
	public OKIOICPJEGE DGIEBOIMJFH(ACFOGPILAFJ EKGMIOGLPIC)
	{
		return default(OKIOICPJEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2C75CF0", Offset = "0x2C750F0", VA = "0x182C75CF0")]
	public bool MLKBEBKOKLI(ACFOGPILAFJ EKGMIOGLPIC, out OKIOICPJEGE LCPDGKLFBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2C75910", Offset = "0x2C74D10", VA = "0x182C75910")]
	public bool EJNOFOLKBNG(ACFOGPILAFJ EKGMIOGLPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2C75FE0", Offset = "0x2C753E0", VA = "0x182C75FE0")]
	public bool OMFEDDKCGOI(ACFOGPILAFJ EKGMIOGLPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2C75EE0", Offset = "0x2C752E0", VA = "0x182C75EE0")]
	public void OJHNMBPJGJC(NativeList<byte> GHBMNGPKFNO, JBIMGIHPKMP CIPOOAKLDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x27DBE70", Offset = "0x27DB270", VA = "0x1827DBE70")]
	public T DKOCCOGEFLF<T>(ACFOGPILAFJ EKGMIOGLPIC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2C759A0", Offset = "0x2C74DA0", VA = "0x182C759A0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2C75AC0", Offset = "0x2C74EC0", VA = "0x182C75AC0")]
	public GKOPFMAHALK IEHFBKOKLDF()
	{
		return default(GKOPFMAHALK);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2C754E0", Offset = "0x2C748E0", VA = "0x182C754E0")]
	private void COKGHKKLIDD(ACFOGPILAFJ EKGMIOGLPIC, int BOIMPMGFDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2C75B10", Offset = "0x2C74F10", VA = "0x182C75B10")]
	private void KBJIHOMMPEE(int EAAHGFKJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2C75C00", Offset = "0x2C75000", VA = "0x182C75C00")]
	private void LDAIADKPMNO(ACFOGPILAFJ EKGMIOGLPIC, int BOIMPMGFDJM, int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3914CA0", Offset = "0x39140A0", VA = "0x183914CA0")]
	private static T DKOCCOGEFLF<T>(NativeArray<byte> CCKHAOABLMF, int MJMHIELCMAL = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2C760F0", Offset = "0x2C754F0", VA = "0x182C760F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C760B0", Offset = "0x2C754B0", VA = "0x182C760B0", Slot = "4")]
	private IEnumerator<ACFOGPILAFJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Preserve]
internal sealed class CAICNKFEDGH<T> : HPFCFNHKHFD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x41BF100", Offset = "0x41BE500", VA = "0x1841BF100", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x41BF220", Offset = "0x41BE620", VA = "0x1841BF220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3454300", Offset = "0x3453700", VA = "0x183454300")]
	public CAICNKFEDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x27707D0", Offset = "0x276FBD0", VA = "0x1827707D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	internal class CleanupRigidbodyExImpl : HPFCFNHKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BE70", Offset = "0x2D0B270", VA = "0x182D0BE70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BF10", Offset = "0x2D0B310", VA = "0x182D0BF10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[Preserve]
internal class OMFFLKFFJDM : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private EntityQuery BECIJGIPDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CCE0", Offset = "0x2A3C0E0", VA = "0x182A3CCE0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CC10", Offset = "0x2A3C010", VA = "0x182A3CC10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CCA0", Offset = "0x2A3C0A0", VA = "0x182A3CCA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public OMFFLKFFJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal class OLEKGCJAAJM : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private PropertyDiffStateService KHKIFOPGAAH;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CBC0", Offset = "0x2A3BFC0", VA = "0x182A3CBC0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CB50", Offset = "0x2A3BF50", VA = "0x182A3CB50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public OLEKGCJAAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private SceneService KGBHFHAMEAH;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D18DB0", Offset = "0x2D181B0", VA = "0x182D18DB0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D18910", Offset = "0x2D17D10", VA = "0x182D18910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D189A0", Offset = "0x2D17DA0", VA = "0x182D189A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[BGGFAGPLFND(typeof(CullingBandService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	public class CullingBandService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly List<global::CBNGKCNANOL<IIHOLKKFLMB>> ONIGEBBMCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D15200", Offset = "0x2D14600", VA = "0x182D15200", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D15190", Offset = "0x2D14590", VA = "0x182D15190")]
		public void OJGMGKONCPC(global::CBNGKCNANOL<IIHOLKKFLMB> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D14D20", Offset = "0x2D14120", VA = "0x182D14D20")]
		public void KOBLCICIJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D14BB0", Offset = "0x2D13FB0", VA = "0x182D14BB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D152A0", Offset = "0x2D146A0", VA = "0x182D152A0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics, new string[] { "Callbacks" })]
	[BGGFAGPLFND(typeof(LMOKMGNLDFK), new string[] { })]
	public class PhysicsService : OIOAOEDFDMG, BIJJPFLHCDJ, LMOKMGNLDFK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private const string BPIIKEMFHGO = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static readonly EHNHFGEGKKP OGOOJPHNCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private HEKPAFKDBLD HJAECBDFNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private PropertyEventCallbacksService EGECADFEGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private global::KIABHJONBDN<ABMFFIFNGAO> MKHJJKEKEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<HOGBEFGIKOI, ABMFFIFNGAO> AAMBILKPOHF
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2A4FE70", Offset = "0x2A4F270", VA = "0x182A4FE70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2A4FC40", Offset = "0x2A4F040", VA = "0x182A4FC40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF10", Offset = "0x2A4F310", VA = "0x182A4FF10", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F9A0", Offset = "0x2A4EDA0", VA = "0x182A4F9A0", Slot = "5")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F840", Offset = "0x2A4EC40", VA = "0x182A4F840", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FCE0", Offset = "0x2A4F0E0", VA = "0x182A4FCE0", Slot = "8")]
		public bool HNCLCNOIDHD(HOGBEFGIKOI DCJOMJHHEFE, out Collider HNEJPHOBPOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F780", Offset = "0x2A4EB80", VA = "0x182A4F780")]
		private void CEBFHJJMDNM(Entity KCGBIDJFHLF, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ICBMMLPPJIN, DMCBBFPDIBM LPLBPOMCKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FDB0", Offset = "0x2A4F1B0", VA = "0x182A4FDB0", Slot = "9")]
		public void IGFFCJNDLPG(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BGGFAGPLFND(typeof(DLFLMEPDEKJ), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class RbexService : OIOAOEDFDMG, DLFLMEPDEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private World ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private DMEJOPMIOFD AFEEJKEGNNH;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x2A56970", Offset = "0x2A55D70", VA = "0x182A56970")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A58430", Offset = "0x2A57830", VA = "0x182A58430", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A55B60", Offset = "0x2A54F60", VA = "0x182A55B60", Slot = "6")]
		public KFMMEAOIBIL DMAOEHADNDM(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A56760", Offset = "0x2A55B60", VA = "0x182A56760", Slot = "5")]
		public void GLMFHMJCMFI(HOGBEFGIKOI DCJOMJHHEFE, KFMMEAOIBIL PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A56C60", Offset = "0x2A56060", VA = "0x182A56C60", Slot = "34")]
		public CollisionDetectionMode ICIAEBDNDNG(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A58030", Offset = "0x2A57430", VA = "0x182A58030", Slot = "35")]
		public void OHBDGDBOION(HOGBEFGIKOI DCJOMJHHEFE, CollisionDetectionMode PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A57C30", Offset = "0x2A57030", VA = "0x182A57C30", Slot = "36")]
		public CKFADKHCOCO NGIMBHBIING(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(CKFADKHCOCO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A55790", Offset = "0x2A54B90", VA = "0x182A55790", Slot = "37")]
		public void CIEOGHDEMGI(HOGBEFGIKOI DCJOMJHHEFE, CKFADKHCOCO PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A58270", Offset = "0x2A57670", VA = "0x182A58270", Slot = "38")]
		public bool PAKOJCNKNML(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A56900", Offset = "0x2A55D00", VA = "0x182A56900", Slot = "39")]
		public void HHHELECKCMH(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A55AE0", Offset = "0x2A54EE0", VA = "0x182A55AE0", Slot = "40")]
		public HOGBEFGIKOI DLEPMOHONDC(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2A58540", Offset = "0x2A57940", VA = "0x182A58540", Slot = "41")]
		public void PHCCHDHOMEM(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2A57790", Offset = "0x2A56B90", VA = "0x182A57790", Slot = "42")]
		public HOGBEFGIKOI LKJHOOBEPGJ(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2A564D0", Offset = "0x2A558D0", VA = "0x182A564D0", Slot = "43")]
		public void FFPPMEKEJBA(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2A57AB0", Offset = "0x2A56EB0", VA = "0x182A57AB0", Slot = "7")]
		public void MNJLDMDAPLM(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2A57140", Offset = "0x2A56540", VA = "0x182A57140", Slot = "8")]
		public void KKMHFJFCFJD(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2A55C70", Offset = "0x2A55070", VA = "0x182A55C70", Slot = "9")]
		public int EBLMMENAALN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2A565B0", Offset = "0x2A559B0", VA = "0x182A565B0", Slot = "10")]
		public HOGBEFGIKOI GFFMDBOMJCE(HOGBEFGIKOI DCJOMJHHEFE, int PGFOAHEHPOH)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2A57950", Offset = "0x2A56D50", VA = "0x182A57950", Slot = "11")]
		public void MKNAOJIAMDN(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2A57250", Offset = "0x2A56650", VA = "0x182A57250", Slot = "12")]
		public void LAIIIEBCPEI(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH, HOGBEFGIKOI PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2A556A0", Offset = "0x2A54AA0", VA = "0x182A556A0", Slot = "13")]
		public void CFKMOEPKPMK(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2A55980", Offset = "0x2A54D80", VA = "0x182A55980", Slot = "14")]
		public bool COCGNCJDCBB(HOGBEFGIKOI DCJOMJHHEFE, out HOGBEFGIKOI PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2A55BF0", Offset = "0x2A54FF0", VA = "0x182A55BF0", Slot = "15")]
		public void DPLHCOOJCCM(HOGBEFGIKOI DCJOMJHHEFE, float3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2A56210", Offset = "0x2A55610", VA = "0x182A56210", Slot = "16")]
		public bool EPMNFHJPIMG(HOGBEFGIKOI DCJOMJHHEFE, out float3 PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2A573E0", Offset = "0x2A567E0", VA = "0x182A573E0", Slot = "17")]
		public void LCADCNDEJBI(HOGBEFGIKOI DCJOMJHHEFE, float3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2A57460", Offset = "0x2A56860", VA = "0x182A57460", Slot = "18")]
		public bool LCANELDMBDC(HOGBEFGIKOI DCJOMJHHEFE, out float3 PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2A57CD0", Offset = "0x2A570D0", VA = "0x182A57CD0", Slot = "26")]
		public float3 NHAOLPJAAPK(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2A57620", Offset = "0x2A56A20", VA = "0x182A57620", Slot = "27")]
		public void LELPCIDOPDP(HOGBEFGIKOI DCJOMJHHEFE, float3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2A56C00", Offset = "0x2A56000", VA = "0x182A56C00", Slot = "28")]
		public float IBBNJEIGEPO(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2A57A40", Offset = "0x2A56E40", VA = "0x182A57A40", Slot = "29")]
		public void MKOFPBFHJHL(HOGBEFGIKOI DCJOMJHHEFE, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2A57FD0", Offset = "0x2A573D0", VA = "0x182A57FD0", Slot = "30")]
		public float ODKFLDFEHCL(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2A56130", Offset = "0x2A55530", VA = "0x182A56130", Slot = "31")]
		public void EMIKIENNOPO(HOGBEFGIKOI DCJOMJHHEFE, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2A55D60", Offset = "0x2A55160", VA = "0x182A55D60", Slot = "32")]
		public bool EECJLKACMBM(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2A56E80", Offset = "0x2A56280", VA = "0x182A56E80", Slot = "33")]
		public void IPIEFPKOOFJ(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2A551C0", Offset = "0x2A545C0", VA = "0x182A551C0", Slot = "19")]
		public void AKJJFHPLLOE(HOGBEFGIKOI DCJOMJHHEFE, float3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2A56D20", Offset = "0x2A56120", VA = "0x182A56D20", Slot = "20")]
		public bool ILLPBOMIODB(HOGBEFGIKOI DCJOMJHHEFE, out float3 PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2A560C0", Offset = "0x2A554C0", VA = "0x182A560C0", Slot = "21")]
		public void ELAJHAJHDLA(HOGBEFGIKOI DCJOMJHHEFE, quaternion PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2A580A0", Offset = "0x2A574A0", VA = "0x182A580A0", Slot = "22")]
		public bool OJHPLLGIMIK(HOGBEFGIKOI DCJOMJHHEFE, out quaternion PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2A55E50", Offset = "0x2A55250", VA = "0x182A55E50", Slot = "23")]
		public bool EIJFPPECCMN(HOGBEFGIKOI DCJOMJHHEFE, out float3 JDCDFFHCHBF, out quaternion KGMIHLJJHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2A575C0", Offset = "0x2A569C0", VA = "0x182A575C0", Slot = "44")]
		public OBMNDCKAAPN LEABEJEENJE(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(OBMNDCKAAPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2A561A0", Offset = "0x2A555A0", VA = "0x182A561A0", Slot = "45")]
		public void ENFCIDENDEC(HOGBEFGIKOI DCJOMJHHEFE, OBMNDCKAAPN PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2A555B0", Offset = "0x2A549B0", VA = "0x182A555B0", Slot = "72")]
		public void CCPKNFLBEBD(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2A56AF0", Offset = "0x2A55EF0", VA = "0x182A56AF0", Slot = "73")]
		public void HNMFBNCADJE(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2A56B80", Offset = "0x2A55F80", VA = "0x182A56B80", Slot = "74")]
		public bool IABLEOKBFIE(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2A56F50", Offset = "0x2A56350", VA = "0x182A56F50", Slot = "81")]
		public void KDFEBEAGAJG(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2A56870", Offset = "0x2A55C70", VA = "0x182A56870", Slot = "82")]
		public void GMGHOIMJKKD(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2A57E80", Offset = "0x2A57280", VA = "0x182A57E80", Slot = "83")]
		public bool NLDMCANEFJH(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2A554B0", Offset = "0x2A548B0", VA = "0x182A554B0", Slot = "84")]
		public IEnumerable<object> CAMDHBMAFLL(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2A55640", Offset = "0x2A54A40", VA = "0x182A55640", Slot = "46")]
		public bool CDBGBGMCGPK(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2A576A0", Offset = "0x2A56AA0", VA = "0x182A576A0", Slot = "47")]
		public void LHDNIDFJJGA(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2A584E0", Offset = "0x2A578E0", VA = "0x182A584E0", Slot = "48")]
		public bool PEOLGCGMONN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2A57E10", Offset = "0x2A57210", VA = "0x182A57E10", Slot = "49")]
		public void NLDGMHLMPOO(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2A57DB0", Offset = "0x2A571B0", VA = "0x182A57DB0", Slot = "50")]
		public bool NJNDCAJBIAP(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2A55340", Offset = "0x2A54740", VA = "0x182A55340", Slot = "51")]
		public void BIHJEDPOHBC(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2A55920", Offset = "0x2A54D20", VA = "0x182A55920", Slot = "52")]
		public RigidbodyConstraints CMKNMGKPHEC(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2A553B0", Offset = "0x2A547B0", VA = "0x182A553B0", Slot = "53")]
		public void BIIKKEIFHJD(HOGBEFGIKOI DCJOMJHHEFE, RigidbodyConstraints PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2A57380", Offset = "0x2A56780", VA = "0x182A57380", Slot = "54")]
		public float LAKJJMDNLFC(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A55240", Offset = "0x2A54640", VA = "0x182A55240", Slot = "55")]
		public void ALLBGFECNPN(HOGBEFGIKOI DCJOMJHHEFE, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A56EF0", Offset = "0x2A562F0", VA = "0x182A56EF0", Slot = "56")]
		public float JNIAOLOPGII(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A56990", Offset = "0x2A55D90", VA = "0x182A56990", Slot = "57")]
		public void HJIGDPKNDEM(HOGBEFGIKOI DCJOMJHHEFE, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A558C0", Offset = "0x2A54CC0", VA = "0x182A558C0", Slot = "58")]
		public bool CKPGLPBCHFA(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2A585C0", Offset = "0x2A579C0", VA = "0x182A585C0", Slot = "59")]
		public void PHGLOGNBOOP(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2A56CC0", Offset = "0x2A560C0", VA = "0x182A56CC0", Slot = "60")]
		public bool IKIKEAEGOON(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2A56A00", Offset = "0x2A55E00", VA = "0x182A56A00", Slot = "61")]
		public void HKNHAFHLDHK(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2A56550", Offset = "0x2A55950", VA = "0x182A56550", Slot = "62")]
		public int FPBEPFPHFNI(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2A57BC0", Offset = "0x2A56FC0", VA = "0x182A57BC0", Slot = "63")]
		public void MPKAPBIMMBF(HOGBEFGIKOI DCJOMJHHEFE, int PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A55420", Offset = "0x2A54820", VA = "0x182A55420", Slot = "64")]
		public Rigidbody BKDNJPDGDCH(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2A582D0", Offset = "0x2A576D0", VA = "0x182A582D0", Slot = "65")]
		public void PBLKMKCBEHL(HOGBEFGIKOI DCJOMJHHEFE, Rigidbody PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2A552B0", Offset = "0x2A546B0", VA = "0x182A552B0", Slot = "75")]
		public void BCCDCGOAMIP(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2A55DC0", Offset = "0x2A551C0", VA = "0x182A55DC0", Slot = "76")]
		public void EHEJJHJACLF(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2A57840", Offset = "0x2A56C40", VA = "0x182A57840", Slot = "77")]
		public bool MCBGLDLKBEA(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2A55830", Offset = "0x2A54C30", VA = "0x182A55830", Slot = "66")]
		public object CIMOGBCKAKL(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2A56370", Offset = "0x2A55770", VA = "0x182A56370", Slot = "67")]
		public void FFAGKLCADGP(HOGBEFGIKOI DCJOMJHHEFE, object PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2A566D0", Offset = "0x2A55AD0", VA = "0x182A566D0", Slot = "68")]
		public object GJMCHJKKNIE(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2A56FE0", Offset = "0x2A563E0", VA = "0x182A56FE0", Slot = "69")]
		public void KGGNKNEGIEF(HOGBEFGIKOI DCJOMJHHEFE, object PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2A56810", Offset = "0x2A55C10", VA = "0x182A56810", Slot = "70")]
		public float GMAJDHNPFME(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2A58200", Offset = "0x2A57600", VA = "0x182A58200", Slot = "71")]
		public void OOLKGMCIGOA(HOGBEFGIKOI DCJOMJHHEFE, float PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2A578C0", Offset = "0x2A56CC0", VA = "0x182A578C0", Slot = "78")]
		public void MFFLELNKFAP(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2A57700", Offset = "0x2A56B00", VA = "0x182A57700", Slot = "79")]
		public void LIBKAMLPNEG(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2A56A70", Offset = "0x2A55E70", VA = "0x182A56A70", Slot = "80")]
		public bool HMGIFNLGILA(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2A57D50", Offset = "0x2A57150", VA = "0x182A57D50", Slot = "24")]
		public void NHKBBEMMAFE(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2A55730", Offset = "0x2A54B30", VA = "0x182A55730", Slot = "25")]
		public void CGKFMENFPHO(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x4204720", Offset = "0x4203B20", VA = "0x184204720")]
		private void FAJCBBNOOKA<T>(HOGBEFGIKOI DCJOMJHHEFE, bool PKODKJLGOIN) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x4204770", Offset = "0x4203B70", VA = "0x184204770")]
		private bool FJBPNNFHJLM<T>(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x4204E90", Offset = "0x4204290", VA = "0x184204E90")]
		private void GMLJNDAKNDK<T>(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x4204F70", Offset = "0x4204370", VA = "0x184204F70")]
		private bool JNNNOMKLHAK<TC, TV>(HOGBEFGIKOI DCJOMJHHEFE, Func<TC, TV> DIPDMFLCIBB, out TV PKODKJLGOIN) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4204EF0", Offset = "0x42042F0", VA = "0x184204EF0")]
		private bool JNNNOMKLHAK<T>(HOGBEFGIKOI DCJOMJHHEFE, out T PKODKJLGOIN) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x42051A0", Offset = "0x42045A0", VA = "0x1842051A0")]
		private T NBOGJGKBMIF<T>(HOGBEFGIKOI DCJOMJHHEFE) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x42041D0", Offset = "0x42035D0", VA = "0x1842041D0")]
		private void DOJKHICLJIE<T>(HOGBEFGIKOI DCJOMJHHEFE, T PKODKJLGOIN) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x42047D0", Offset = "0x4203BD0", VA = "0x1842047D0")]
		private void GFOGNFAPPPL<T>(HOGBEFGIKOI DCJOMJHHEFE, T PKODKJLGOIN) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x4204EF0", Offset = "0x42042F0", VA = "0x184204EF0")]
		private bool PCOIJPLFFDP<T>(HOGBEFGIKOI DCJOMJHHEFE, out T PKODKJLGOIN) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x4204E30", Offset = "0x4204230", VA = "0x184204E30")]
		private T GHBPGCGNBEM<T>(HOGBEFGIKOI DCJOMJHHEFE) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x4204EF0", Offset = "0x42042F0", VA = "0x184204EF0")]
		private void IABMDBHCNOJ<T>(HOGBEFGIKOI DCJOMJHHEFE, T PKODKJLGOIN) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x42050F0", Offset = "0x42044F0", VA = "0x1842050F0")]
		private void LKAGCMFEKLK<T>(HOGBEFGIKOI DCJOMJHHEFE, T PKODKJLGOIN) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A55190", Offset = "0x2A54590", VA = "0x182A55190")]
		private HOGBEFGIKOI ABFIOCPPLOI(Entity KCGBIDJFHLF)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2A57F00", Offset = "0x2A57300", VA = "0x182A57F00")]
		private DynamicBuffer<Entity> OBDHEDMCECF(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x4204110", Offset = "0x4203510", VA = "0x184204110")]
		private void DNFJFMEPPNA<T>(HOGBEFGIKOI DCJOMJHHEFE, object PKODKJLGOIN, Func<object, T> DIPDMFLCIBB) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		private void NGKBIODLKGD<T>(ref global::PNLCFHKCGAO<T> BDPOLJDOFBF) where T : struct, JOFONMFINJP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		private void NGKBIODLKGD<TC, TV>(ref global::IIDCNIPBHBO<TC, TV> BDPOLJDOFBF) where TC : struct, JOFONMFINJP
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BGGFAGPLFND(typeof(KinematicSleepChangeService), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	public class KinematicSleepChangeService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class DFJABGAMJJL : IEnumerable<KFMMEAOIBIL>, IEnumerable, IEnumerator<KFMMEAOIBIL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			private KFMMEAOIBIL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private KFMMEAOIBIL System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public DFJABGAMJJL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x45BEFD0", Offset = "0x45BE3D0", VA = "0x1845BEFD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x45BEC90", Offset = "0x45BE090", VA = "0x1845BEC90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x45BF050", Offset = "0x45BE450", VA = "0x1845BF050")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x45BEF90", Offset = "0x45BE390", VA = "0x1845BEF90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x45BEEE0", Offset = "0x45BE2E0", VA = "0x1845BEEE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KFMMEAOIBIL> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x45BEEE0", Offset = "0x45BE2E0", VA = "0x1845BEEE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> PAFMLENLHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2C85A90", Offset = "0x2C84E90", VA = "0x182C85A90", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2C85970", Offset = "0x2C84D70", VA = "0x182C85970")]
		public void OJGMGKONCPC(NativeArray<Entity> IHPLCMEEOEJ, bool KLEMFCMCLBA, bool BNGAAEAOMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2C85760", Offset = "0x2C84B60", VA = "0x182C85760")]
		public void KOBLCICIJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2C84FA0", Offset = "0x2C843A0", VA = "0x182C84FA0")]
		private void EEKOAOLIBFB(NativeArray<Entity> IHPLCMEEOEJ, bool KLEMFCMCLBA, bool BNGAAEAOMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2C84DC0", Offset = "0x2C841C0", VA = "0x182C84DC0")]
		[IteratorStateMachine(typeof(DFJABGAMJJL))]
		private IEnumerable<KFMMEAOIBIL> BEJNKLDHMGF(NativeArray<Entity> IHPLCMEEOEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2C84E50", Offset = "0x2C84250", VA = "0x182C84E50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2C85B30", Offset = "0x2C84F30", VA = "0x182C85B30")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BGGFAGPLFND(typeof(JFAKMNMKBKN), new string[] { })]
[DefaultMember("Item")]
public class KONIMEFDAMH : JFAKMNMKBKN, IEnumerable<HAKAHGDBIOD>, IEnumerable, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[GPKJCAPOIDC]
	private MOGNBJLFDMA CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Dictionary<(Type, string), int> ELHEDBKCEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private HAOLEKOPLCI ODDKNHMLCMJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2C84930", Offset = "0x2C83D30", VA = "0x182C84930", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HAKAHGDBIOD BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2C84470", Offset = "0x2C83870", VA = "0x182C84470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HAKAHGDBIOD BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2C84470", Offset = "0x2C83870", VA = "0x182C84470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2C84970", Offset = "0x2C83D70", VA = "0x182C84970", Slot = "11")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2C849C0", Offset = "0x2C83DC0", VA = "0x182C849C0", Slot = "12")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2C84A40", Offset = "0x2C83E40", VA = "0x182C84A40")]
	private void PDIHCGBAENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1630360", Offset = "0x162F760", VA = "0x181630360")]
	private string PFDPDNADHAK(string JODEBEIHAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2C845A0", Offset = "0x2C839A0", VA = "0x182C845A0", Slot = "7")]
	public HAKAHGDBIOD FAHCFADNBLA(DLDEFENJDPN KDNIDDIGOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2C84680", Offset = "0x2C83A80", VA = "0x182C84680")]
	private bool FNGCDOLJEEA(Type GKBALKCFPMJ, string JODEBEIHAPC, out HAKAHGDBIOD GPGIOJFGNNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2C84490", Offset = "0x2C83890", VA = "0x182C84490", Slot = "8")]
	public EKCDKOGIIEF ENKBCEOLBMN(DLDEFENJDPN KDNIDDIGOFK)
	{
		return default(EKCDKOGIIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2C84950", Offset = "0x2C83D50", VA = "0x182C84950", Slot = "9")]
	public IEnumerator<HAKAHGDBIOD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2C84950", Offset = "0x2C83D50", VA = "0x182C84950", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2C84D40", Offset = "0x2C84140", VA = "0x182C84D40")]
	public KONIMEFDAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[DefaultMember("Item")]
public interface JBIMGIHPKMP
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	int BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJLHHPGNJNP(EKCDKOGIIEF FBDAFGPAOAL, out int FOADGJOOFID);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DefaultMember("Item")]
[BGGFAGPLFND(typeof(JBIMGIHPKMP), new string[] { })]
public class FCJEHHIPLEP : OIOAOEDFDMG, BIJJPFLHCDJ, JBIMGIHPKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[GPKJCAPOIDC]
	private FEILDLCAMGM CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Dictionary<EKCDKOGIIEF, int> AMCCBKDALGK;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2C715D0", Offset = "0x2C709D0", VA = "0x182C715D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2C718B0", Offset = "0x2C70CB0", VA = "0x182C718B0", Slot = "6")]
	public bool MJLHHPGNJNP(EKCDKOGIIEF FBDAFGPAOAL, out int FOADGJOOFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2C71920", Offset = "0x2C70D20", VA = "0x182C71920", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2C718A0", Offset = "0x2C70CA0", VA = "0x182C718A0", Slot = "5")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2C71630", Offset = "0x2C70A30", VA = "0x182C71630")]
	private void DHBKKDAPAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2C71980", Offset = "0x2C70D80", VA = "0x182C71980")]
	public FCJEHHIPLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DefaultMember("Item")]
[BGGFAGPLFND(typeof(FEILDLCAMGM), new string[] { })]
public class PAFNBDFFBFB : FEILDLCAMGM, IEnumerable<AJFNKNMFLJF>, IEnumerable, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, DGPMAHPPOKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[GPKJCAPOIDC]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[GPKJCAPOIDC]
	private JFAKMNMKBKN PGFIIEBCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private AJFNKNMFLJF[] LICDPJJOAFO;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2A48E30", Offset = "0x2A48230", VA = "0x182A48E30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public AJFNKNMFLJF BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2A48AB0", Offset = "0x2A47EB0", VA = "0x182A48AB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AJFNKNMFLJF BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2A48AB0", Offset = "0x2A47EB0", VA = "0x182A48AB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "10")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2A48F20", Offset = "0x2A48320", VA = "0x182A48F20", Slot = "11")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "12")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2A48D00", Offset = "0x2A48100", VA = "0x182A48D00", Slot = "6")]
	public AJFNKNMFLJF FAHCFADNBLA(DLDEFENJDPN KDNIDDIGOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2A48C30", Offset = "0x2A48030", VA = "0x182A48C30", Slot = "7")]
	public EKCDKOGIIEF ENKBCEOLBMN(DLDEFENJDPN KDNIDDIGOFK)
	{
		return default(EKCDKOGIIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2A48E40", Offset = "0x2A48240", VA = "0x182A48E40", Slot = "8")]
	public IEnumerator<AJFNKNMFLJF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2A491C0", Offset = "0x2A485C0", VA = "0x182A491C0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x27E98D0", Offset = "0x27E8CD0", VA = "0x1827E98D0", Slot = "13")]
	public void BPDLDKHKAOA<TKey, T>(global::DFOJKPKKLBC<TKey, T> GIOGLFNEEJE, [Optional] object IDEIPFIOJKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2A48AF0", Offset = "0x2A47EF0", VA = "0x182A48AF0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PAFNBDFFBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2A48AB0", Offset = "0x2A47EB0", VA = "0x182A48AB0")]
	[CompilerGenerated]
	private AJFNKNMFLJF IHFKGCBLMJH(int BBOINFMIBOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DefaultMember("Item")]
[BGGFAGPLFND(typeof(DBALNFAKKBN), new string[] { })]
public class BNDDAKAENKG : DBALNFAKKBN, IEnumerable<GMLMCMNEFMA>, IEnumerable, OIOAOEDFDMG, BIJJPFLHCDJ, DGPMAHPPOKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[GPKJCAPOIDC]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[GPKJCAPOIDC]
	private JFAKMNMKBKN PGFIIEBCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private GMLMCMNEFMA[] LICDPJJOAFO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2D06CE0", Offset = "0x2D060E0", VA = "0x182D06CE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GMLMCMNEFMA BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2D06700", Offset = "0x2D05B00", VA = "0x182D06700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public GMLMCMNEFMA BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2D06700", Offset = "0x2D05B00", VA = "0x182D06700", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2D06E40", Offset = "0x2D06240", VA = "0x182D06E40", Slot = "9")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2D067B0", Offset = "0x2D05BB0", VA = "0x182D067B0", Slot = "10")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2D06A10", Offset = "0x2D05E10", VA = "0x182D06A10")]
	private GMLMCMNEFMA EIBKANNJCFE(int PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2D06BC0", Offset = "0x2D05FC0", VA = "0x182D06BC0", Slot = "6")]
	public GMLMCMNEFMA FAHCFADNBLA(DLDEFENJDPN KDNIDDIGOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D06AF0", Offset = "0x2D05EF0", VA = "0x182D06AF0", Slot = "14")]
	public EKCDKOGIIEF ENKBCEOLBMN(DLDEFENJDPN KDNIDDIGOFK)
	{
		return default(EKCDKOGIIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D06D30", Offset = "0x2D06130", VA = "0x182D06D30", Slot = "7")]
	public IEnumerator<GMLMCMNEFMA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D06D30", Offset = "0x2D06130", VA = "0x182D06D30", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A2DD40", Offset = "0x2A2D140", VA = "0x182A2DD40", Slot = "11")]
	public void BPDLDKHKAOA<TKey, T>(global::DFOJKPKKLBC<TKey, T> GIOGLFNEEJE, [Optional] object IDEIPFIOJKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D06710", Offset = "0x2D05B10", VA = "0x182D06710", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BNDDAKAENKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D06700", Offset = "0x2D05B00", VA = "0x182D06700")]
	[CompilerGenerated]
	private GMLMCMNEFMA IHFKGCBLMJH(int BBOINFMIBOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(MOGNBJLFDMA), new string[] { })]
internal class MOGNBJLFDMA : OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private JFAKMNMKBKN PGFIIEBCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private DBALNFAKKBN CJHGAOHDCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private FEILDLCAMGM AELNFHLIJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private global::OLKIDMOIAPH<CHDKGPPIPOE> LONDBJKEPFJ;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HAOLEKOPLCI FGOJLNMBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A36FC0", Offset = "0x2A363C0", VA = "0x182A36FC0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A36E00", Offset = "0x2A36200", VA = "0x182A36E00")]
	private void KLDGNNBOJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x294B9D0", Offset = "0x294ADD0", VA = "0x18294B9D0")]
	public T DKOOOOHLODA<T>() where T : CHDKGPPIPOE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A36C60", Offset = "0x2A36060", VA = "0x182A36C60")]
	public HAKAHGDBIOD BDGELLFBIAD(DLDEFENJDPN JODEBEIHAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	public global::KIABHJONBDN<T> BDGELLFBIAD<T>(DLDEFENJDPN JODEBEIHAPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A36D30", Offset = "0x2A36130", VA = "0x182A36D30")]
	public GMLMCMNEFMA CBPOAMOFLKN(DLDEFENJDPN JODEBEIHAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x294B950", Offset = "0x294AD50", VA = "0x18294B950")]
	public global::PAKLIDDKMKP<T> CBPOAMOFLKN<T>(DLDEFENJDPN JODEBEIHAPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A36EF0", Offset = "0x2A362F0", VA = "0x182A36EF0")]
	public AJFNKNMFLJF LLCNEHNDCKI(DLDEFENJDPN JODEBEIHAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	public global::FNMDIAKAJPN<T> LLCNEHNDCKI<T>(DLDEFENJDPN JODEBEIHAPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MOGNBJLFDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal static class NOMGCGOABPG
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x29FE480", Offset = "0x29FD880", VA = "0x1829FE480")]
	public static global::KIABHJONBDN<T> BDGELLFBIAD<T>(this MOGNBJLFDMA CDECOLIGOKO, global::CPENGNEJPCM<T> JODEBEIHAPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	public static global::PAKLIDDKMKP<T> CBPOAMOFLKN<T>(this MOGNBJLFDMA CDECOLIGOKO, global::CPENGNEJPCM<T> JODEBEIHAPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	public static global::FNMDIAKAJPN<T> LLCNEHNDCKI<T>(this MOGNBJLFDMA CDECOLIGOKO, global::CPENGNEJPCM<T> JODEBEIHAPC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BGGFAGPLFND(typeof(GDGKEDJKJBO), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
public class GDGKEDJKJBO : OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private AECJABNNLMC NILIJGCOFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private EKCDKOGIIEF[] NOIPOBJJKMC;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C74D70", Offset = "0x2C74170", VA = "0x182C74D70", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C74C50", Offset = "0x2C74050", VA = "0x182C74C50")]
	public void OFDBPHEIMHD(DLABIEOOCHD BBEIPJALHJO, bool MKDJEEGDHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public GDGKEDJKJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(GGGHDBODPID), new string[] { })]
public sealed class GGGHDBODPID : OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class MJFCOMFPAED : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public MJFCOMFPAED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x45C6460", Offset = "0x45C5860", VA = "0x1845C6460", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x45C60B0", Offset = "0x45C54B0", VA = "0x1845C60B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x45C64E0", Offset = "0x45C58E0", VA = "0x1845C64E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x45C6420", Offset = "0x45C5820", VA = "0x1845C6420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x45C6390", Offset = "0x45C5790", VA = "0x1845C6390", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x45C6390", Offset = "0x45C5790", VA = "0x1845C6390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private const string AIJHDEJDADN = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Dictionary<SerializableGuid, GPMMCAIIICI> ELMFKCBJIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<SerializableGuid> PNMBCNKOKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<SerializableGuid, GameObject> EELIHJHFEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private DBALNFAKKBN CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private LBMLBONIJAH NLNFAPHGJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private NPLLDKEDKFD GLGOPOLOJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private global::OFBAKEDDMOM<GPMMCAIIICI> NLDFKBDPMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private GameObject FHFMIKJHPBG;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C779E0", Offset = "0x2C76DE0", VA = "0x182C779E0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C76E60", Offset = "0x2C76260", VA = "0x182C76E60", Slot = "5")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C76930", Offset = "0x2C75D30", VA = "0x182C76930", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C779D0", Offset = "0x2C76DD0", VA = "0x182C779D0")]
	private void NJLIDNLGJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C76320", Offset = "0x2C75720", VA = "0x182C76320")]
	internal void BMONBNNLDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C771E0", Offset = "0x2C765E0", VA = "0x182C771E0")]
	private void HDAIGKJFFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C770E0", Offset = "0x2C764E0", VA = "0x182C770E0")]
	private void FKOPDELFFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C77090", Offset = "0x2C76490", VA = "0x182C77090")]
	[IteratorStateMachine(typeof(MJFCOMFPAED))]
	private IEnumerable<RRCustomPropTag> EGFFFIPBNGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C77410", Offset = "0x2C76810", VA = "0x182C77410")]
	private void JENDEHKFBIA(HOGBEFGIKOI DCJOMJHHEFE, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C77890", Offset = "0x2C76C90", VA = "0x182C77890")]
	private void MGGHGLFMIKB(SerializableGuid KIDLKIGCBDG, GameObject MGDBDEJKIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C76AD0", Offset = "0x2C75ED0", VA = "0x182C76AD0")]
	private void EBNANOMAOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C76750", Offset = "0x2C75B50", VA = "0x182C76750")]
	private bool DFBEDFBKPKO(GPMMCAIIICI BBNHDDIFGIH, Transform BLENCGKHIJI, out GameObject AEBBMADEDFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C773C0", Offset = "0x2C767C0", VA = "0x182C773C0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C77AB0", Offset = "0x2C76EB0", VA = "0x182C77AB0")]
	public GGGHDBODPID()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public SerializableGuid LCPKIELKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A550A0", Offset = "0x2A544A0", VA = "0x182A550A0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(MAPLLABMGCJ), new string[] { })]
public class MAPLLABMGCJ : OIOAOEDFDMG
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private const string OKLIOPOGNHG = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private SceneService NBPMHEMDGJK;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C872A0", Offset = "0x2C866A0", VA = "0x182C872A0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MAPLLABMGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(FHMDNBBBOHM), new string[] { })]
public class FHMDNBBBOHM : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	[GPKJCAPOIDC]
	private EnableComponentSystemsInScope PEDOBMCOJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[GPKJCAPOIDC]
	private SceneService NBPMHEMDGJK;

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C71E30", Offset = "0x2C71230", VA = "0x182C71E30", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C71DD0", Offset = "0x2C711D0", VA = "0x182C71DD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C71E10", Offset = "0x2C71210", VA = "0x182C71E10")]
	private void HBFPNPBNGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C71DA0", Offset = "0x2C711A0", VA = "0x182C71DA0")]
	private void DIJDBDLPPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FHMDNBBBOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BGGFAGPLFND(typeof(GGGMMDNLNGG), new string[] { })]
public class EGJLHHCFCOA : OIOAOEDFDMG, BIJJPFLHCDJ, GGGMMDNLNGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private AKIKBDADLPE NDBEPEANOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private JCNMFMHMJFG EPOIOCEBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private PropertyEventCallbacksService EGECADFEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private LocalPlayerScopeSystem BDPBIEPDENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private int PIELNFLECAA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DLDBKIAKDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A2E0", Offset = "0x2D196E0", VA = "0x182D1A2E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HOGBEFGIKOI EOHPLOJIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A3F0", Offset = "0x2D197F0", VA = "0x182D1A3F0", Slot = "9")]
		get
		{
			return default(HOGBEFGIKOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A0B0", Offset = "0x2D194B0", VA = "0x182D1A0B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MPFJCJEABON AGMKACDGABC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D195C0", Offset = "0x2D189C0", VA = "0x182D195C0", Slot = "11")]
		get
		{
			return default(MPFJCJEABON);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A0B0", Offset = "0x2D194B0", VA = "0x182D1A0B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public MPFJCJEABON HIEDEDONCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A1F0", Offset = "0x2D195F0", VA = "0x182D1A1F0", Slot = "13")]
		get
		{
			return default(MPFJCJEABON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private uint JBGOLBLGGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D19610", Offset = "0x2D18A10", VA = "0x182D19610")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event FHAIPKOPGHO CEBNKNPICKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A240", Offset = "0x2D19640", VA = "0x182D1A240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A010", Offset = "0x2D19410", VA = "0x182D1A010", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A320", Offset = "0x2D19720", VA = "0x182D1A320", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D19900", Offset = "0x2D18D00", VA = "0x182D19900", Slot = "5")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D19850", Offset = "0x2D18C50", VA = "0x182D19850", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D19BB0", Offset = "0x2D18FB0", VA = "0x182D19BB0")]
	private void GNHPGKPBGDL(Entity KCGBIDJFHLF, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ICBMMLPPJIN, DMCBBFPDIBM LPLBPOMCKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D19AA0", Offset = "0x2D18EA0", VA = "0x182D19AA0", Slot = "14")]
	public HOGBEFGIKOI GJDFNDJNALK(HOGBEFGIKOI LAAEFADHFKD, HOGBEFGIKOI NAHHHHBNGEI)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D19DB0", Offset = "0x2D191B0", VA = "0x182D19DB0", Slot = "15")]
	public bool HBHDIMLPOJD(HOGBEFGIKOI LAAEFADHFKD, HOGBEFGIKOI NAHHHHBNGEI, out HOGBEFGIKOI NABADPABDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D196C0", Offset = "0x2D18AC0", VA = "0x182D196C0", Slot = "16")]
	public void BPJLJNDLJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A150", Offset = "0x2D19550", VA = "0x182D1A150", Slot = "17")]
	public void LJOBPHIOKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D19EB0", Offset = "0x2D192B0", VA = "0x182D19EB0", Slot = "18")]
	public bool IBKPHFBKPGN(HOGBEFGIKOI ENDGJBMJNDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A0B0", Offset = "0x2D194B0", VA = "0x182D1A0B0")]
	private void MHOFGANIDMC(HOGBEFGIKOI PDENIBPHFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public EGJLHHCFCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BGGFAGPLFND(typeof(LNBCOHDPELB), new string[] { })]
public class JGLHKAHHAKK : OIOAOEDFDMG, LNBCOHDPELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C82890", Offset = "0x2C81C90", VA = "0x182C82890", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C82820", Offset = "0x2C81C20", VA = "0x182C82820", Slot = "5")]
	public void GJJPPDOCLJE(HOGBEFGIKOI ODKPHBBMMPO, bool PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2616900", Offset = "0x2615D00", VA = "0x182616900")]
	private void JKDFMHKJMMK<T>(HOGBEFGIKOI ODKPHBBMMPO, bool PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JGLHKAHHAKK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[BGGFAGPLFND(typeof(HGDBOJAFNMK), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.RenderEffects)]
	public class SelectionService : OIOAOEDFDMG, HGDBOJAFNMK
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD36F0", Offset = "0x2BD2AF0", VA = "0x182BD36F0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3680", Offset = "0x2BD2A80", VA = "0x182BD3680", Slot = "5")]
		public void IMGMHBAGOAD(HOGBEFGIKOI ODKPHBBMMPO, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3610", Offset = "0x2BD2A10", VA = "0x182BD3610", Slot = "6")]
		public void EFDPBFFCNAM(HOGBEFGIKOI ODKPHBBMMPO, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2616900", Offset = "0x2615D00", VA = "0x182616900")]
		private void JKDFMHKJMMK<T>(HOGBEFGIKOI ODKPHBBMMPO, bool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[BGGFAGPLFND(typeof(LLAABKFPNLD), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
internal sealed class LLAABKFPNLD : OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[GPKJCAPOIDC]
	private ObjectEmbodimentService ECKHIFIOGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI LIDPFPMMNIM;

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C86540", Offset = "0x2C85940", VA = "0x182C86540", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LLAABKFPNLD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[BGGFAGPLFND(typeof(WorldSerialization), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization, new string[] { "Timing" })]
	internal sealed class WorldSerialization : OIOAOEDFDMG, KJGNEIJECBP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private const string HGIGCGKHEJF = "Timing";

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static readonly EHNHFGEGKKP GFAOMHEGENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[GPKJCAPOIDC]
		private EJFLHFELKLA BDDIOBKHCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[GPKJCAPOIDC]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[GPKJCAPOIDC]
		private SerializationService NLNFAPHGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[GPKJCAPOIDC]
		private AEOIKCPGKNG KJICPDPGIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[GPKJCAPOIDC]
		private DebugWorldsService MLFHCBBOOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[GPKJCAPOIDC]
		private BulkInstantiateSceneObjectService BJCBJGFCNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private EJMKHPELEHA KMGLINHGLGG;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private ENEKONIDOGK ILIAFLLGFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xCEC300", Offset = "0xCEB700", VA = "0x180CEC300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BE85A0", Offset = "0x2BE79A0", VA = "0x182BE85A0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA OMEOKNGBDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7AA0", Offset = "0x2BE6EA0", VA = "0x182BE7AA0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7AD0", Offset = "0x2BE6ED0", VA = "0x182BE7AD0", Slot = "6")]
		public bool HGGHNDPHJPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7DC0", Offset = "0x2BE71C0", VA = "0x182BE7DC0", Slot = "7")]
		public bool KGAMDMBBKLC(IEnumerable<FJGCKAIOICJ> JLPIOMCIPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7DE0", Offset = "0x2BE71E0", VA = "0x182BE7DE0", Slot = "5")]
		public ByteString KKPPFGFCFDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7D00", Offset = "0x2BE7100", VA = "0x182BE7D00")]
		private void KAEBEOHGNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7C30", Offset = "0x2BE7030", VA = "0x182BE7C30")]
		private void IANCLDCANBB(KMJPLEOALAH DNDKNEHOPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x2BE75C0", Offset = "0x2BE69C0", VA = "0x182BE75C0")]
		private void CLPAEFFIMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2BE82C0", Offset = "0x2BE76C0", VA = "0x182BE82C0")]
		private void NBLNNBOGJJF(PBOGGOLBDDL DNDKNEHOPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8270", Offset = "0x2BE7670", VA = "0x182BE8270", Slot = "8")]
		public void MKPKANBDNAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7D20", Offset = "0x2BE7120", VA = "0x182BE7D20")]
		private KMJPLEOALAH KEPHFMBBPLM(EntityManager ODHEKJGHFGE, EntityManager GENELGNIMGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(BJMOAEFIIIA), new string[] { })]
public class BJMOAEFIIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly Dictionary<CDPNPEPOMEC, string> JLENKJLMMDN;

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2D05CB0", Offset = "0x2D050B0", VA = "0x182D05CB0")]
	public GameObject MPBHNMKIOBL(CDPNPEPOMEC JLLGFEHPFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2D05D80", Offset = "0x2D05180", VA = "0x182D05D80")]
	public BJMOAEFIIIA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[BGGFAGPLFND(typeof(TimeService), new string[] { })]
	public class TimeService : EHPEJLPKBCA, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[GPKJCAPOIDC]
		private SingletonComponentService FFNFJFNCLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private bool CLGKKJBBBDI;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public TimeData IKFGFGKLPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2BDB170", Offset = "0x2BDA570", VA = "0x182BDB170")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x2BDB0F0", Offset = "0x2BDA4F0", VA = "0x182BDB0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool HHKELMLMPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x6A9000", Offset = "0x6A8400", VA = "0x1806A9000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x16F2260", Offset = "0x16F1660", VA = "0x1816F2260", Slot = "4")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB1E0", Offset = "0x2BDA5E0", VA = "0x182BDB1E0", Slot = "5")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB230", Offset = "0x2BDA630", VA = "0x182BDB230")]
		public void PKINDBOBHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing)]
	[BGGFAGPLFND(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private GGDOJMIIODJ KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private global::KIABHJONBDN<Entity> BLENCGKHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private ObjectEmbodimentService OFIMLDPADIP;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7580", Offset = "0x2BD6980", VA = "0x182BD7580", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7150", Offset = "0x2BD6550", VA = "0x182BD7150", Slot = "5")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD70B0", Offset = "0x2BD64B0", VA = "0x182BD70B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7280", Offset = "0x2BD6680", VA = "0x182BD7280")]
		private void HBLPNKADJDD(Entity KCGBIDJFHLF, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7340", Offset = "0x2BD6740", VA = "0x182BD7340")]
		private void HBLPNKADJDD(Entity KCGBIDJFHLF, in Entity JMCOICNPJLH, in Entity GIJFJALMMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[BGGFAGPLFND(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Services)]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[GPKJCAPOIDC]
		private JIFCIAHIKLP DILCHIHLBPH;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private FPLMJBEGKKH JFBIKHDNJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D080", Offset = "0x2C6C480", VA = "0x182C6D080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private GBBIMEMIDOB ABHEIHELHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x2C6D010", Offset = "0x2C6C410", VA = "0x182C6D010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D0D0", Offset = "0x2C6C4D0", VA = "0x182C6D0D0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D060", Offset = "0x2C6C460", VA = "0x182C6D060", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[BGGFAGPLFND(typeof(GFCJCAIMAKN), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
public class GFCJCAIMAKN : JFMMJOKBFKE, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class OHJNJFPDHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public EJMKHPELEHA services;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OHJNJFPDHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1560", Offset = "0x2BD0960", VA = "0x182BD1560")]
		internal void <InitReferences>b__0(OIOAOEDFDMG svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class DLMIJDDEMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public EJMKHPELEHA services;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DLMIJDDEMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEDE0", Offset = "0x2BCE1E0", VA = "0x182BCEDE0")]
		internal void <InitExternal>b__0(BIJJPFLHCDJ svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI LIDPFPMMNIM;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public OPFADMNHCLD DENFIAEEJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x8BE4C0", Offset = "0x8BD8C0", VA = "0x1808BE4C0", Slot = "4")]
		get
		{
			return default(OPFADMNHCLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private DOGKLJKKAGC KHGEGLGEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2C75260", Offset = "0x2C74660", VA = "0x182C75260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2C75000", Offset = "0x2C74400", VA = "0x182C75000", Slot = "5")]
	public void DHLKGJANJLO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2C752B0", Offset = "0x2C746B0", VA = "0x182C752B0", Slot = "6")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x2C753E0", Offset = "0x2C747E0", VA = "0x182C753E0", Slot = "7")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x2C75180", Offset = "0x2C74580", VA = "0x182C75180", Slot = "8")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x2C75050", Offset = "0x2C74450", VA = "0x182C75050", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x27DBDE0", Offset = "0x27DB1E0", VA = "0x1827DBDE0")]
	private void MKAFDDACJMN<T>(Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public GFCJCAIMAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
public class PONIGIFFJHK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly Func<From, To> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly Func<To, From> EJKEAFJJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public DynamicBuffer<From> BPMIJGKONLK;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public To BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	public PONIGIFFJHK(Func<From, To> OGMBHJLBFEE, Func<To, From> EJKEAFJJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int PGFOAHEHPOH, To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public class EMHLEIHFNAD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly Func<From, To> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly Func<To, From> EJKEAFJJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public List<From> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x40AFBA0", Offset = "0x40AEFA0", VA = "0x1840AFBA0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x40AFC00", Offset = "0x40AF000", VA = "0x1840AFC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x40AFB70", Offset = "0x40AEF70", VA = "0x1840AFB70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x726570", VA = "0x180727170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x38E19B0", Offset = "0x38E0DB0", VA = "0x1838E19B0")]
	public EMHLEIHFNAD(Func<From, To> OGMBHJLBFEE, Func<To, From> EJKEAFJJOCB, bool CNDIMEFFGEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x40AF760", Offset = "0x40AEB60", VA = "0x1840AF760", Slot = "11")]
	public void Add(To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x23E2820", Offset = "0x23E1C20", VA = "0x1823E2820", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x40AF7C0", Offset = "0x40AEBC0", VA = "0x1840AF7C0", Slot = "13")]
	public bool Contains(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x40AF820", Offset = "0x40AEC20", VA = "0x1840AF820", Slot = "14")]
	public void CopyTo(To[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x40AF930", Offset = "0x40AED30", VA = "0x1840AF930", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x40AFA00", Offset = "0x40AEE00", VA = "0x1840AFA00", Slot = "6")]
	public int IndexOf(To MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x40AFA60", Offset = "0x40AEE60", VA = "0x1840AFA60", Slot = "7")]
	public void Insert(int PGFOAHEHPOH, To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x40AFB10", Offset = "0x40AEF10", VA = "0x1840AFB10", Slot = "15")]
	public bool Remove(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x40AFAE0", Offset = "0x40AEEE0", VA = "0x1840AFAE0", Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2766460", Offset = "0x2765860", VA = "0x182766460", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DefaultMember("Item")]
public class PIEIBGBJPMJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> EJKEAFJJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<From> CCKHAOABLMF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x350D000", Offset = "0x350C400", VA = "0x18350D000", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x350D050", Offset = "0x350C450", VA = "0x18350D050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x350CFC0", Offset = "0x350C3C0", VA = "0x18350CFC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x1429760", Offset = "0x1428B60", VA = "0x181429760")]
	public PIEIBGBJPMJ(Func<From, To> OGMBHJLBFEE, Func<To, From> EJKEAFJJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x350CBD0", Offset = "0x350BFD0", VA = "0x18350CBD0", Slot = "11")]
	public void Add(To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x350CC10", Offset = "0x350C010", VA = "0x18350CC10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x350CC50", Offset = "0x350C050", VA = "0x18350CC50", Slot = "13")]
	public bool Contains(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x350CD10", Offset = "0x350C110", VA = "0x18350CD10", Slot = "14")]
	public void CopyTo(To[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x350CDD0", Offset = "0x350C1D0", VA = "0x18350CDD0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x350CE90", Offset = "0x350C290", VA = "0x18350CE90", Slot = "6")]
	public int IndexOf(To MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x350CF00", Offset = "0x350C300", VA = "0x18350CF00", Slot = "7")]
	public void Insert(int PGFOAHEHPOH, To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x350CF80", Offset = "0x350C380", VA = "0x18350CF80", Slot = "15")]
	public bool Remove(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x350CF40", Offset = "0x350C340", VA = "0x18350CF40", Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x28C3650", Offset = "0x28C2A50", VA = "0x1828C3650", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DefaultMember("Item")]
public class CFCFPHCMACA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> EJKEAFJJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeList<From> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	public CFCFPHCMACA(Func<From, To> OGMBHJLBFEE, Func<To, From> EJKEAFJJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int PGFOAHEHPOH, To MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class OKAGKBDMFGF
{
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public const string CAFFCJMACNC = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public const string HMOPGBEGPKA = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public const string OBBJINDPDIG = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public const string EEIMOGGONNI = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public const string BPEOPAIANKA = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public const string MFLBDPAFFFI = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public const string FIDEIFAOIHE = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string HABADGOLKMC = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class PBDJEIGOICB
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class FEJDKFNCLIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public EJMKHPELEHA services;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FEJDKFNCLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x45C0330", Offset = "0x45BF730", VA = "0x1845C0330")]
		internal void <InitServices>b__1(OIOAOEDFDMG svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x45C0390", Offset = "0x45BF790", VA = "0x1845C0390")]
		internal void <InitServices>b__2(BIJJPFLHCDJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2A491E0", Offset = "0x2A485E0", VA = "0x182A491E0")]
	public static void AIILJEJMNMI(this DOGKLJKKAGC ICDEHOIBFMN, EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x27F68A0", Offset = "0x27F5CA0", VA = "0x1827F68A0")]
	public static void MKAFDDACJMN<T>(this DOGKLJKKAGC ICDEHOIBFMN, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x27F6590", Offset = "0x27F5990", VA = "0x1827F6590")]
	public static void KKOGHJHHNNL<T>(this DOGKLJKKAGC ICDEHOIBFMN, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x27F5FC0", Offset = "0x27F53C0", VA = "0x1827F5FC0")]
	public static void DCFOHIOMAAF<T>(this DOGKLJKKAGC ICDEHOIBFMN, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x27F6170", Offset = "0x27F5570", VA = "0x1827F6170")]
	public static void GPKNJGJEJDB<T>(this DOGKLJKKAGC ICDEHOIBFMN, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x27F6320", Offset = "0x27F5720", VA = "0x1827F6320")]
	public static void HFOMDFIKKCC<T>(this DOGKLJKKAGC ICDEHOIBFMN, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x27F6730", Offset = "0x27F5B30", VA = "0x1827F6730")]
	public static void KKOGHJHHNNL<T>(IEnumerable<ComponentSystemBase> BAKIKEOBNEJ, Action<T> FOMGCAAGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x27F64D0", Offset = "0x27F58D0", VA = "0x1827F64D0")]
	private static void IBHNOEENMDA<T>(object PEOBFOOAMDB, Action<T> FOMGCAAGCCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class KDNBMPEBNEI
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class HAFCEKLFNED
{
	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A200", Offset = "0x2C79600", VA = "0x182C7A200")]
	public static void DPAJNGBIPMD(ComponentSystemBase PEOBFOOAMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class FCKKGCBFCAK
{
	[Cpp2IlInjected.Token(Token = "0x6000582")]
	public static bool GIHPAKJHIHP<T>(ref T ANJGLCCJFPO, ref T ABBMKKCGFBG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MACPMNNGKBO
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class OJDIMPBDDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OJDIMPBDDGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2C871D0", Offset = "0x2C865D0", VA = "0x182C871D0")]
	public static string LOFLLHANBIN(Transform ENMFIMJMMCO, Transform ENDGJBMJNDE)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[AFAPMPFKDID(JCDEPCAPNFC.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD63B0", Offset = "0x2BD57B0", VA = "0x182BD63B0")]
		public static void HGCIEPNFBCH(this MNCBLPIJNJN KMGLINHGLGG, ONAFOAMBPDO GHPHIAMLFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD60F0", Offset = "0x2BD54F0", VA = "0x182BD60F0")]
		public static void ELKIACABLJF(this MNCBLPIJNJN KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2BD62A0", Offset = "0x2BD56A0", VA = "0x182BD62A0")]
		public static void HGCIEPNFBCH(this MNCBLPIJNJN KMGLINHGLGG, [Optional] string[] LMGDEIDKMGP, [Optional] string[] ENLJPIPNNIC, [Optional] string[] MABLFFAAMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6040", Offset = "0x2BD5440", VA = "0x182BD6040")]
		public static void DFBJOHMKCCP(this MNCBLPIJNJN KMGLINHGLGG, params string[] IDCHCBCNNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2BD61F0", Offset = "0x2BD55F0", VA = "0x182BD61F0")]
		public static void FLLKNPKPMBL(this MNCBLPIJNJN KMGLINHGLGG, params string[] IDCHCBCNNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x2BD65E0", Offset = "0x2BD59E0", VA = "0x182BD65E0")]
		private static string[] PNFFCKEEJBB(ONAFOAMBPDO GHPHIAMLFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5E80", Offset = "0x2BD5280", VA = "0x182BD5E80")]
		private static bool AEMIJEKANJA(ONAFOAMBPDO GHPHIAMLFNM, out string[] FPLKOFHCPEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00")]
		private static bool PMOHNDEMJPP()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class NGLLFJBHDCO : CHOEKCDLPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly MethodInfo NBEAOPOKDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly Type[] LBFFDNKPEBE;

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B660", Offset = "0x2A3AA60", VA = "0x182A3B660")]
	public NGLLFJBHDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action INNIJOMHLDH();

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B470", Offset = "0x2A3A870", VA = "0x182A3B470")]
	public MethodInfo HGCEEMIKHKG(Action PADKGNIPPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B4B0", Offset = "0x2A3A8B0", VA = "0x182A3B4B0", Slot = "4")]
	public void MGGHGLFMIKB(Type NLAFPPIOFPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class BIACBJBPGAI : NGLLFJBHDCO
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private enum JJJKDLHLBMB
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2D05C20", Offset = "0x2D05020", VA = "0x182D05C20", Slot = "5")]
	public override Action INNIJOMHLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DAOACOOGBGA<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2D05B90", Offset = "0x2D04F90", VA = "0x182D05B90")]
	[Preserve]
	public void EJJOIGEJPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFB00", Offset = "0x2CFEF00", VA = "0x182CFFB00")]
	protected BIACBJBPGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public abstract class AEMDLCGDOCJ : NGLLFJBHDCO
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFA70", Offset = "0x2CFEE70", VA = "0x182CFFA70", Slot = "5")]
	public override Action INNIJOMHLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GJGBMIKIMHB<T>() where T : JEHFEHAOHED;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF9E0", Offset = "0x2CFEDE0", VA = "0x182CFF9E0")]
	[Preserve]
	public void EJJOIGEJPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFB00", Offset = "0x2CFEF00", VA = "0x182CFFB00")]
	protected AEMDLCGDOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class CEFOGGJLIGI : NGLLFJBHDCO
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D09600", Offset = "0x2D08A00", VA = "0x182D09600", Slot = "5")]
	public override Action INNIJOMHLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NOBCDMPHKGE<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D09570", Offset = "0x2D08970", VA = "0x182D09570")]
	[Preserve]
	public void EJJOIGEJPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFB00", Offset = "0x2CFEF00", VA = "0x182CFFB00")]
	protected CEFOGGJLIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class FMDPELKEBGG
{
	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C72E90", Offset = "0x2C72290", VA = "0x182C72E90")]
	public static Entity GGCBJKJCGBK(this EntityManager KLFKJJDHNIL)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[AFAPMPFKDID(JCDEPCAPNFC.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class DIKMFDCPKNL : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000C9")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB350", Offset = "0x1DCA750", VA = "0x181DCB350", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C6")]
				[Cpp2IlInjected.Address(RVA = "0x2BCE800", Offset = "0x2BCDC00", VA = "0x182BCE800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE850", Offset = "0x2BCDC50", VA = "0x182BCE850")]
			[DebuggerHidden]
			public DIKMFDCPKNL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE630", Offset = "0x2BCDA30", VA = "0x182BCE630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE7C0", Offset = "0x2BCDBC0", VA = "0x182BCE7C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE710", Offset = "0x2BCDB10", VA = "0x182BCE710", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE710", Offset = "0x2BCDB10", VA = "0x182BCE710", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class LMHFHEILIIA : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000CB")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB350", Offset = "0x1DCA750", VA = "0x181DCB350", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x2BD1430", Offset = "0x2BD0830", VA = "0x182BD1430", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE850", Offset = "0x2BCDC50", VA = "0x182BCE850")]
			[DebuggerHidden]
			public LMHFHEILIIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1480", Offset = "0x2BD0880", VA = "0x182BD1480", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1150", Offset = "0x2BD0550", VA = "0x182BD1150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1510", Offset = "0x2BD0910", VA = "0x182BD1510")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2BD13F0", Offset = "0x2BD07F0", VA = "0x182BD13F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1340", Offset = "0x2BD0740", VA = "0x182BD1340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2BD1340", Offset = "0x2BD0740", VA = "0x182BD1340", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class GPDOGFNDGPO : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005D7")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB350", Offset = "0x1DCA750", VA = "0x181DCB350", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005D9")]
				[Cpp2IlInjected.Address(RVA = "0x2BD04E0", Offset = "0x2BCF8E0", VA = "0x182BD04E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE850", Offset = "0x2BCDC50", VA = "0x182BCE850")]
			[DebuggerHidden]
			public GPDOGFNDGPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0530", Offset = "0x2BCF930", VA = "0x182BD0530", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x2BD00D0", Offset = "0x2BCF4D0", VA = "0x182BD00D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0600", Offset = "0x2BCFA00", VA = "0x182BD0600")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0650", Offset = "0x2BCFA50", VA = "0x182BD0650")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x2BD04A0", Offset = "0x2BCF8A0", VA = "0x182BD04A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0400", Offset = "0x2BCF800", VA = "0x182BD0400", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0400", Offset = "0x2BCF800", VA = "0x182BD0400", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C70C40", Offset = "0x2C70040", VA = "0x182C70C40")]
		public static Entity POGOENBECCM(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F880", Offset = "0x2C6EC80", VA = "0x182C6F880")]
		public static DynamicBuffer<ChildrenData> EMLLABOBLOE(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FF60", Offset = "0x2C6F360", VA = "0x182C6FF60")]
		public static DynamicBuffer<ChildrenData> KJDIMHIHPFI(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FD00", Offset = "0x2C6F100", VA = "0x182C6FD00")]
		public static NativeArray<Entity> HKOJAAEEEDL(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Allocator NHNCCHNPCJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C70070", Offset = "0x2C6F470", VA = "0x182C70070")]
		public static bool LEKPCHOJMMK(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Allocator NHNCCHNPCJI, out NativeArray<Entity> ABCOOLKBJPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C708D0", Offset = "0x2C6FCD0", VA = "0x182C708D0")]
		public static NativeArray<Entity> OONDBKGPMAD(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FA30", Offset = "0x2C6EE30", VA = "0x182C6FA30")]
		public static Entity GFFMDBOMJCE(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, int PGFOAHEHPOH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F770", Offset = "0x2C6EB70", VA = "0x182C6F770")]
		public static int EBLMMENAALN(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C70170", Offset = "0x2C6F570", VA = "0x182C70170")]
		public static void LMKIAICAOHI(NativeArray<Entity> IKPELHJLNPD, NativeArray<Entity> CJDMCMNNBID, EntityManager KLFKJJDHNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C70820", Offset = "0x2C6FC20", VA = "0x182C70820")]
		public static int OFGGBHPEHGD(this EntityManager KLFKJJDHNIL, Entity BLENCGKHIJI, Entity MIJGFFHMOFJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C703D0", Offset = "0x2C6F7D0", VA = "0x182C703D0")]
		public static bool MODCFHPGPKN(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Entity IJPMBDNEJAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C70B30", Offset = "0x2C6FF30", VA = "0x182C70B30")]
		public static IEnumerable<Entity> PLNMIAOCGMN(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FEB0", Offset = "0x2C6F2B0", VA = "0x182C6FEB0")]
		public static bool JOKNPFIDODI(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Entity MIJGFFHMOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FE30", Offset = "0x2C6F230", VA = "0x182C6FE30")]
		public static bool IPJALMMAMBB(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Entity LAAEFADHFKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C70530", Offset = "0x2C6F930", VA = "0x182C70530")]
		public static NativeList<Entity> NGEIPGINFEP(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false, Allocator NHNCCHNPCJI = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F5F0", Offset = "0x2C6E9F0", VA = "0x182C6F5F0")]
		public static IEnumerable<Entity> EBJAFNDLFGI(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F4F0", Offset = "0x2C6E8F0", VA = "0x182C6F4F0")]
		public static Entity DLEPMOHONDC(this EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FB60", Offset = "0x2C6EF60", VA = "0x182C6FB60")]
		public static bool HBHDIMLPOJD(this EntityManager KLFKJJDHNIL, Entity LAAEFADHFKD, Entity NAHHHHBNGEI, out Entity NABADPABDEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F470", Offset = "0x2C6E870", VA = "0x182C6F470")]
		internal static void AHFMNOEOJML(EntityManager KLFKJJDHNIL, Entity BLENCGKHIJI, Entity MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C70A30", Offset = "0x2C6FE30", VA = "0x182C70A30")]
		internal static void OPJDENBLDNE(EntityManager KLFKJJDHNIL, Entity BLENCGKHIJI, Entity MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F910", Offset = "0x2C6ED10", VA = "0x182C6F910")]
		[IteratorStateMachine(typeof(DIKMFDCPKNL))]
		private static IEnumerable<Entity> ENJFJGIIJLI(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F9A0", Offset = "0x2C6EDA0", VA = "0x182C6F9A0")]
		[IteratorStateMachine(typeof(LMHFHEILIIA))]
		private static IEnumerable<Entity> FBPLPBCLLCO(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FFF0", Offset = "0x2C6F3F0", VA = "0x182C6FFF0")]
		[IteratorStateMachine(typeof(GPDOGFNDGPO))]
		private static IEnumerable<Entity> LBGLGLPIECD(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C70740", Offset = "0x2C6FB40", VA = "0x182C70740")]
		private static bool NLGIGGICEMM(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Entity IJPMBDNEJAG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BGGFAGPLFND(typeof(KKKCPPGBJHO), new string[] { })]
public class MEFDKDDPJDP : KKKCPPGBJHO, JFMMJOKBFKE, BBNIJBDDGNH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private EJMKHPELEHA KMGLINHGLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private EJFLHFELKLA BDDIOBKHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private FJONBJHEIFH HNBJGDKCNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private AKIKBDADLPE NDBEPEANOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private GGDOJMIIODJ KPJDOIFOFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private NGFGMFMKNCI NLNFAPHGJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private OOOBPOCGNJM IJCALMDFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private DBALNFAKKBN CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private GNOAFGFBGKD CLCNKMNFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private AOKOBIPCECP BPDKNGHHMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private GGGMMDNLNGG LCPDGKLFBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private AGECAABBCAI GBAPOEABIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private LMOKMGNLDFK OMFGPOLJDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private LNBCOHDPELB JJBACBOALNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private HGDBOJAFNMK PNJKCFDPAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private GCIJLHJDMDE MPGGBHGCIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private DLFLMEPDEKJ EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public EJMKHPELEHA ECMNFNGHGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public EFLFKJPCKHG LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public FGEHAOHAFDI KHGEGLGEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public EJFLHFELKLA FEOIIIFFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FJONBJHEIFH GGNLEHPEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public IANFCDGCLMD PPANCHCHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AKIKBDADLPE OJNIAOBKCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x674580", Offset = "0x673980", VA = "0x180674580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public GGDOJMIIODJ EFLPOHGKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public NGFGMFMKNCI IAPFOKFJHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x683760", Offset = "0x682B60", VA = "0x180683760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public OOOBPOCGNJM JDCBIKOAGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x66D0B0", Offset = "0x66C4B0", VA = "0x18066D0B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DBALNFAKKBN ONGMFGHDJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GNOAFGFBGKD NHPKGMIOLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x683780", Offset = "0x682B80", VA = "0x180683780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public AOKOBIPCECP NNHMAFHMKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x683700", Offset = "0x682B00", VA = "0x180683700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GGGMMDNLNGG OGJNIKMIANO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x683710", Offset = "0x682B10", VA = "0x180683710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public AGECAABBCAI BMLCNMKOKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A96D0", Offset = "0x6A8AD0", VA = "0x1806A96D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LMOKMGNLDFK KGCPIMEHFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x673D80", Offset = "0x673180", VA = "0x180673D80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public LNBCOHDPELB GNDIPEOPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x673E20", Offset = "0x673220", VA = "0x180673E20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HGDBOJAFNMK CLEDONBKDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A96A0", Offset = "0x6A8AA0", VA = "0x1806A96A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public GCIJLHJDMDE EFNCAPEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x683720", Offset = "0x682B20", VA = "0x180683720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DLFLMEPDEKJ PIJKCPOODDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x683730", Offset = "0x682B30", VA = "0x180683730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OPFADMNHCLD DENFIAEEJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x693AA0", Offset = "0x692EA0", VA = "0x180693AA0", Slot = "20")]
		get
		{
			return default(OPFADMNHCLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C87350", Offset = "0x2C86750", VA = "0x182C87350", Slot = "21")]
	public void DHLKGJANJLO(EJMKHPELEHA OMEOKNGBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C87620", Offset = "0x2C86A20", VA = "0x182C87620", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C87330", Offset = "0x2C86730", VA = "0x182C87330", Slot = "22")]
	public void CEBNKNPICKG(EJMKHPELEHA OMEOKNGBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MEFDKDDPJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DefaultMember("Item")]
public class IJBGPGPJKDC : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class BHPEBBCLPGI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public IJBGPGPJKDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x683790", Offset = "0x682B90", VA = "0x180683790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x45BE780", Offset = "0x45BDB80", VA = "0x1845BE780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
		[DebuggerHidden]
		public BHPEBBCLPGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x45BE5D0", Offset = "0x45BD9D0", VA = "0x1845BE5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x45BE740", Offset = "0x45BDB40", VA = "0x1845BE740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000226")]
	protected const ulong INAFAGIKOPC = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000227")]
	protected const ulong GEBGMKLNHAA = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000228")]
	protected const int OMCPOJFKHNJ = 8;

	[Cpp2IlInjected.Token(Token = "0x4000229")]
	protected const int BIHEJGEOBIC = 6;

	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public const int KLLMJOIAJIJ = 64;

	[Cpp2IlInjected.Token(Token = "0x400022B")]
	protected const int JFIBNAMGCAJ = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly List<ulong> CDCHOOHICDK;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x711410", Offset = "0x710810", VA = "0x180711410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public int PBAJKAMGFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x688C90", Offset = "0x688090", VA = "0x180688C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x711320", Offset = "0x710720", VA = "0x180711320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7F2E0", Offset = "0x2C7E6E0", VA = "0x182C7F2E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7FAC0", Offset = "0x2C7EEC0", VA = "0x182C7FAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FF90", Offset = "0x2C7F390", VA = "0x182C7FF90")]
	public IJBGPGPJKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C80010", Offset = "0x2C7F410", VA = "0x182C80010")]
	public IJBGPGPJKDC(int IPGLLLPIFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F200", Offset = "0x2C7E600", VA = "0x182C7F200")]
	public bool BDBHKBDIFME(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F790", Offset = "0x2C7EB90", VA = "0x182C7F790")]
	public bool HHEDDKFGPOE(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FF10", Offset = "0x2C7F310", VA = "0x182C7FF10")]
	public bool PBODFMHGJDA(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F380", Offset = "0x2C7E780", VA = "0x182C7F380")]
	public bool COOCIDMCJJO(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FE80", Offset = "0x2C7F280", VA = "0x182C7FE80")]
	public void OBHNEMPLJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FC70", Offset = "0x2C7F070", VA = "0x182C7FC70")]
	public void MEPJMLBBELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F9D0", Offset = "0x2C7EDD0", VA = "0x182C7F9D0")]
	public void JKDFMHKJMMK(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F8D0", Offset = "0x2C7ECD0", VA = "0x182C7F8D0")]
	public void HLOEIBCGJID(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F390", Offset = "0x2C7E790", VA = "0x182C7F390")]
	public bool EADGBDOIODD(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FD60", Offset = "0x2C7F160", VA = "0x182C7FD60")]
	public void MHKHAAJHHNC(int MJMHIELCMAL, int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F560", Offset = "0x2C7E960", VA = "0x182C7F560")]
	public void GOJKPJFEAIA(int ENOOKOIJALA, int ENJGHFPMKCI, int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F420", Offset = "0x2C7E820", VA = "0x182C7F420")]
	public int EIPAABBBFMM(int EFJDLDLIAEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F4F0", Offset = "0x2C7E8F0", VA = "0x182C7F4F0")]
	public int EIPAABBBFMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F880", Offset = "0x2C7EC80", VA = "0x182C7F880")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F720", Offset = "0x2C7EB20", VA = "0x182C7F720", Slot = "4")]
	[IteratorStateMachine(typeof(BHPEBBCLPGI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F720", Offset = "0x2C7EB20", VA = "0x182C7F720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class MOJBGPFMBAP<T> : global::FMKNNMGECIN<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	protected global::LAOIBAEOBNB<T> NNDIKIMAICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	protected global::GPOFGOIMPEA<T> CCACBEMOIOL;

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x1125B70", Offset = "0x1124F70", VA = "0x181125B70")]
	public MOJBGPFMBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x2321500", Offset = "0x2320900", VA = "0x182321500")]
	public MOJBGPFMBAP(global::LAOIBAEOBNB<T> NNDIKIMAICF, global::GPOFGOIMPEA<T> CCACBEMOIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x2321220", Offset = "0x2320620", VA = "0x182321220", Slot = "11")]
	public override T DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x2320ED0", Offset = "0x23202D0", VA = "0x182320ED0", Slot = "12")]
	public override void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF, T PKODKJLGOIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class ODBLANDABEL
{
	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x27DF620", Offset = "0x27DEA20", VA = "0x1827DF620")]
	public static EKCDKOGIIEF MGGHGLFMIKB<T>(this MKPMKBJEFCI CKCKOLCCJBK, global::CPENGNEJPCM<T> JODEBEIHAPC, global::LAOIBAEOBNB<T> NNDIKIMAICF, global::GPOFGOIMPEA<T> CCACBEMOIOL) where T : struct
	{
		return default(EKCDKOGIIEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class IBIIMHCJJBK<T> : global::MOJBGPFMBAP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x51714C0", Offset = "0x51708C0", VA = "0x1851714C0")]
	public IBIIMHCJJBK(T KCAMANKDPPD, T PCCFFNKLAEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class ECNPFMLKLLO<T> : global::FMKNNMGECIN<T> where T : struct, JEHFEHAOHED
{
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x28B8F60", Offset = "0x28B8360", VA = "0x1828B8F60", Slot = "11")]
	public override T DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x28B8E30", Offset = "0x28B8230", VA = "0x1828B8E30", Slot = "12")]
	public override void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF, T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x1712A10", Offset = "0x1711E10", VA = "0x181712A10")]
	public ECNPFMLKLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class AFGDHPEGFMG : LEEJOLAJEEA
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public abstract Type CIMNBDDIBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF, in GANDDJBCJLO PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF, in DMCBBFPDIBM PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AJIBBCJIBFD(IIPOGCFKCHF FNLJNGKNKAF, JAEKDBPNICM KKGADOGDKJF, [Optional] object IDEIPFIOJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected AFGDHPEGFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class FMKNNMGECIN<T> : AFGDHPEGFMG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public override Type CIMNBDDIBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x3780C30", Offset = "0x3780030", VA = "0x183780C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF, T PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3780110", Offset = "0x377F510", VA = "0x183780110", Slot = "8")]
	public override void DBBEJMFMHKH(IIPOGCFKCHF FNLJNGKNKAF, in GANDDJBCJLO ENDGJBMJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x377FF20", Offset = "0x377F320", VA = "0x18377FF20", Slot = "9")]
	public override void CAOILNKOGOI(IIPOGCFKCHF FNLJNGKNKAF, in DMCBBFPDIBM EKGMIOGLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x377EDA0", Offset = "0x377E1A0", VA = "0x18377EDA0", Slot = "10")]
	public override void AJIBBCJIBFD(IIPOGCFKCHF FNLJNGKNKAF, JAEKDBPNICM KKGADOGDKJF, object IDEIPFIOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x11290E0", Offset = "0x11284E0", VA = "0x1811290E0")]
	protected FMKNNMGECIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MPKANDEBGEB
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class KGLKBKPEFFB
	{
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class BPPFNIHBPEL<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
			public BPPFNIHBPEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x2178E70", Offset = "0x2178270", VA = "0x182178E70")]
			internal void <RegisterFixedString>b__0(IIPOGCFKCHF p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x2179140", Offset = "0x2178540", VA = "0x182179140")]
			internal T <RegisterFixedString>b__1(IIPOGCFKCHF p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x45C2BF0", Offset = "0x45C1FF0", VA = "0x1845C2BF0")]
		public static void NPEEFCNPDFF(GHBHCKJAKHL PDNGJNGOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x25F63B0", Offset = "0x25F57B0", VA = "0x1825F63B0")]
		private static void MFJKALCHHDE<T>(GHBHCKJAKHL PDNGJNGOJPF, int PCCFFNKLAEE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x25F64D0", Offset = "0x25F58D0", VA = "0x1825F64D0")]
		private static void MGCBJBCHCCN<T>(IIPOGCFKCHF PMLBPCJAADD, T CJJLCOOAFHD, int PCCFFNKLAEE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x25F5D60", Offset = "0x25F5160", VA = "0x1825F5D60")]
		private static T JPGCELDOGLM<T>(IIPOGCFKCHF PMLBPCJAADD, int PCCFFNKLAEE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KGLKBKPEFFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class IJMDNGGNIAD : BIACBJBPGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private GHBHCKJAKHL PDNGJNGOJPF;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x25F5960", Offset = "0x25F4D60", VA = "0x1825F5960", Slot = "6")]
		public override void DAOACOOGBGA<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x45C1850", Offset = "0x45C0C50", VA = "0x1845C1850")]
		public static void HKHIBJCOJFO(GHBHCKJAKHL PDNGJNGOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x45C1900", Offset = "0x45C0D00", VA = "0x1845C1900")]
		public IJMDNGGNIAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x2A370F0", Offset = "0x2A364F0", VA = "0x182A370F0")]
	public static void HNBJKIFEJFE(GHBHCKJAKHL PDNGJNGOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x294C1E0", Offset = "0x294B5E0", VA = "0x18294C1E0")]
	public static void FLBIOKAFBAC<T>(GHBHCKJAKHL PDNGJNGOJPF, global::LAOIBAEOBNB<T> NNDIKIMAICF, global::GPOFGOIMPEA<T> CCACBEMOIOL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x294C270", Offset = "0x294B670", VA = "0x18294C270")]
	public static void NKPBGECCNBJ<T>(GHBHCKJAKHL MEDLODAPPOO) where T : struct, JEHFEHAOHED
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
public interface GHBHCKJAKHL : global::LNAMNMIPAMA<GHBHCKJAKHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGGHGLFMIKB(Type NLAFPPIOFPG, LEEJOLAJEEA MEDLODAPPOO);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPPKACEDDDN(Type NLAFPPIOFPG, out LEEJOLAJEEA MEDLODAPPOO);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class OGFDLPGAIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C6C0", Offset = "0x2A3BAC0", VA = "0x182A3C6C0")]
	public static void MGGHGLFMIKB(this GHBHCKJAKHL BHMPCEPJFGF, LEEJOLAJEEA MEDLODAPPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[BGGFAGPLFND(typeof(MKPMKBJEFCI), new string[] { })]
public sealed class ADGGLCJHLDP : MKPMKBJEFCI, global::LNAMNMIPAMA<MKPMKBJEFCI>, EHPEJLPKBCA, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private readonly Dictionary<EKCDKOGIIEF, LEEJOLAJEEA> PDNGJNGOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private GHBHCKJAKHL KPKBJGEJCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private FEILDLCAMGM CKCKOLCCJBK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool LJMGAIPFPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x726570", VA = "0x180727170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD090", Offset = "0x2CFC490", VA = "0x182CFD090")]
	public ADGGLCJHLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD110", Offset = "0x2CFC510", VA = "0x182CFD110")]
	public ADGGLCJHLDP(Dictionary<EKCDKOGIIEF, LEEJOLAJEEA> PDNGJNGOJPF, bool PILNLEICMEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCD00", Offset = "0x2CFC100", VA = "0x182CFCD00", Slot = "7")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD010", Offset = "0x2CFC410", VA = "0x182CFD010", Slot = "8")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCCB0", Offset = "0x2CFC0B0", VA = "0x182CFCCB0", Slot = "9")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCBE0", Offset = "0x2CFBFE0", VA = "0x182CFCBE0", Slot = "4")]
	public EKCDKOGIIEF ENKBCEOLBMN(DLDEFENJDPN JODEBEIHAPC)
	{
		return default(EKCDKOGIIEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCEA0", Offset = "0x2CFC2A0", VA = "0x182CFCEA0", Slot = "5")]
	public void MGGHGLFMIKB(EKCDKOGIIEF FBDAFGPAOAL, LEEJOLAJEEA MEDLODAPPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCD60", Offset = "0x2CFC160", VA = "0x182CFCD60")]
	[Conditional("DEBUG_BUILD")]
	private void KONKHIJDACI(EKCDKOGIIEF FBDAFGPAOAL, Type NLAFPPIOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2CFCA30", Offset = "0x2CFBE30", VA = "0x182CFCA30", Slot = "6")]
	public bool DPPKACEDDDN(EKCDKOGIIEF FBDAFGPAOAL, out LEEJOLAJEEA MEDLODAPPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2CFC950", Offset = "0x2CFBD50", VA = "0x182CFC950", Slot = "10")]
	public MKPMKBJEFCI APNGCNFCFAB()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[AFAPMPFKDID(JCDEPCAPNFC.TypeSerializer)]
	[BGGFAGPLFND(typeof(GHBHCKJAKHL), new string[] { })]
	public sealed class TypeSerializerService : EHPEJLPKBCA, GHBHCKJAKHL, global::LNAMNMIPAMA<GHBHCKJAKHL>
	{
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly Dictionary<Type, LEEJOLAJEEA> PDNGJNGOJPF;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool LJMGAIPFPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x6A9000", Offset = "0x6A8400", VA = "0x1806A9000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0E10", Offset = "0x2BE0210", VA = "0x182BE0E10")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0E90", Offset = "0x2BE0290", VA = "0x182BE0E90")]
		public TypeSerializerService(Dictionary<Type, LEEJOLAJEEA> PDNGJNGOJPF, bool PILNLEICMEC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0C40", Offset = "0x2BE0040", VA = "0x182BE0C40", Slot = "4")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0CA0", Offset = "0x2BE00A0", VA = "0x182BE0CA0", Slot = "5")]
		public void MGGHGLFMIKB(Type NLAFPPIOFPG, LEEJOLAJEEA MEDLODAPPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0B60", Offset = "0x2BDFF60", VA = "0x182BE0B60", Slot = "6")]
		public bool DPPKACEDDDN(Type NLAFPPIOFPG, out LEEJOLAJEEA MEDLODAPPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0A80", Offset = "0x2BDFE80", VA = "0x182BE0A80", Slot = "7")]
		public GHBHCKJAKHL APNGCNFCFAB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BGGFAGPLFND(typeof(AGFKJNAKCML), new string[] { })]
internal sealed class NLPKKACCNED : AGFKJNAKCML, EHPEJLPKBCA, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private readonly Dictionary<EKCDKOGIIEF, BMKMMMHPLHA> HIPKABIAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private FEILDLCAMGM CKCKOLCCJBK;

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BB90", Offset = "0x2A3AF90", VA = "0x182A3BB90", Slot = "6")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BC50", Offset = "0x2A3B050", VA = "0x182A3BC50", Slot = "7")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BBE0", Offset = "0x2A3AFE0", VA = "0x182A3BBE0", Slot = "4")]
	public void MGGHGLFMIKB(EKCDKOGIIEF FHKHLDOKDFM, Type OKMDDKHFMHB, BMKMMMHPLHA IDAFEEPPHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BB20", Offset = "0x2A3AF20", VA = "0x182A3BB20", Slot = "5")]
	public bool IMPHKAJBJNE(EKCDKOGIIEF FHKHLDOKDFM, out BMKMMMHPLHA IDAFEEPPHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B990", Offset = "0x2A3AD90", VA = "0x182A3B990")]
	[Conditional("DEBUG_BUILD")]
	private void DCGNKILBHLL(EKCDKOGIIEF FHKHLDOKDFM, Type OKMDDKHFMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BCB0", Offset = "0x2A3B0B0", VA = "0x182A3BCB0")]
	public NLPKKACCNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[BGGFAGPLFND(typeof(DGFLBBKAMEK), new string[] { })]
internal sealed class MEKKIOANIGH : DGFLBBKAMEK, FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private readonly IJBGPGPJKDC NOBBDKFIHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private readonly Dictionary<DLABIEOOCHD, int> JKAJEDPAKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private readonly Stack<int> CCJADMFACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[GPKJCAPOIDC]
	private FEILDLCAMGM CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	[GPKJCAPOIDC]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private int PMFBLFOPOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x2C87D50", Offset = "0x2C87150", VA = "0x182C87D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool ADCMEHCEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x738540", Offset = "0x737940", VA = "0x180738540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x960C90", Offset = "0x960090", VA = "0x180960C90", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2C876D0", Offset = "0x2C86AD0", VA = "0x182C876D0", Slot = "6")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2C87DA0", Offset = "0x2C871A0", VA = "0x182C87DA0", Slot = "7")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x2C87810", Offset = "0x2C86C10", VA = "0x182C87810", Slot = "8")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2C87630", Offset = "0x2C86A30", VA = "0x182C87630")]
	private void DHEJOMDOFJG(HOGBEFGIKOI DCJOMJHHEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2C87C10", Offset = "0x2C87010", VA = "0x182C87C10", Slot = "4")]
	public bool ICKGEMGPGLJ(DLABIEOOCHD BBEIPJALHJO, EKCDKOGIIEF GIOGLFNEEJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2C878C0", Offset = "0x2C86CC0", VA = "0x182C878C0", Slot = "5")]
	public void FMDEAHCAODA(DLABIEOOCHD BBEIPJALHJO, Span<EKCDKOGIIEF> CKCKOLCCJBK, bool BKJMHDJFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x2C876D0", Offset = "0x2C86AD0", VA = "0x182C876D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x2C87E20", Offset = "0x2C87220", VA = "0x182C87E20")]
	public MEKKIOANIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class EGIJAAEIIKG
{
	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x2D193C0", Offset = "0x2D187C0", VA = "0x182D193C0")]
	public static void FGJIOMFOEEJ(this IIPOGCFKCHF FNLJNGKNKAF, ReadOnlyMemory<byte> NMDCMHPDGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x202B650", Offset = "0x202AA50", VA = "0x18202B650")]
	public static void KNJHNBOLLLG<T>(this IIPOGCFKCHF FNLJNGKNKAF, in T PKODKJLGOIN) where T : struct, JEHFEHAOHED
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x202B780", Offset = "0x202AB80", VA = "0x18202B780")]
	public static T LCAJGCJDGFO<T>(this IIPOGCFKCHF FNLJNGKNKAF) where T : struct, JEHFEHAOHED
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x2D19590", Offset = "0x2D18990", VA = "0x182D19590")]
	public static void KNJHNBOLLLG(this IIPOGCFKCHF FNLJNGKNKAF, DJDLJOKCJFN AIIJDIFFBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x2D19440", Offset = "0x2D18840", VA = "0x182D19440")]
	public static DJDLJOKCJFN FNHHAOCOMBO(this IIPOGCFKCHF FNLJNGKNKAF)
	{
		return default(DJDLJOKCJFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2D19210", Offset = "0x2D18610", VA = "0x182D19210")]
	public static void EGBBAFCOKAA(this IIPOGCFKCHF HAPALLCNNCH, uint LKFMBBIHNMK, bool HEONGBNAHMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x2D19470", Offset = "0x2D18870", VA = "0x182D19470")]
	public static uint JCCKJEJCKLC(this IIPOGCFKCHF IGGKMMMGNJJ, bool HEONGBNAHMA = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class GMEOGOLMBID
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class BMAMAIDEKFN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public BMAMAIDEKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x216C030", Offset = "0x216B430", VA = "0x18216C030")]
		internal void <GetByteEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x216C0A0", Offset = "0x216B4A0", VA = "0x18216C0A0")]
		internal T <GetByteEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class FKOAFGEOGML<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public FKOAFGEOGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD4C0", Offset = "0x2DAC8C0", VA = "0x182DAD4C0")]
		internal void <GetSByteEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD530", Offset = "0x2DAC930", VA = "0x182DAD530")]
		internal T <GetSByteEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class KLPJDINICHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public KLPJDINICHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x373BC20", Offset = "0x373B020", VA = "0x18373BC20")]
		internal void <GetShortEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x373BC90", Offset = "0x373B090", VA = "0x18373BC90")]
		internal T <GetShortEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class GPPNGICMFBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public GPPNGICMFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C9D0", Offset = "0x3C0BDD0", VA = "0x183C0C9D0")]
		internal void <GetUShortEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CA40", Offset = "0x3C0BE40", VA = "0x183C0CA40")]
		internal T <GetUShortEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class EOMIHDLEOLJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public EOMIHDLEOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x111E950", Offset = "0x111DD50", VA = "0x18111E950")]
		internal void <GetIntEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x111E9B0", Offset = "0x111DDB0", VA = "0x18111E9B0")]
		internal T <GetIntEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class DENNIPGBDJK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public DENNIPGBDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x2F52F30", Offset = "0x2F52330", VA = "0x182F52F30")]
		internal void <GetUIntEnumDelegates>b__0(IIPOGCFKCHF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x2F52F90", Offset = "0x2F52390", VA = "0x182F52F90")]
		internal T <GetUIntEnumDelegates>b__1(IIPOGCFKCHF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x3918FB0", Offset = "0x39183B0", VA = "0x183918FB0")]
	public static void BNAEOIGOOPH<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x3919470", Offset = "0x3918870", VA = "0x183919470")]
	private static void MLDDKLBINNB<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x3919470", Offset = "0x3918870", VA = "0x183919470")]
	private static void KMMAGLKDMNA<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x3919320", Offset = "0x3918720", VA = "0x183919320")]
	private static void DJIAOOPKAKK<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x3919320", Offset = "0x3918720", VA = "0x183919320")]
	private static void CNKEBBNHGBO<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x39191D0", Offset = "0x39185D0", VA = "0x1839191D0")]
	private static void BNHDOBCDOMH<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x39191D0", Offset = "0x39185D0", VA = "0x1839191D0")]
	private static void KDOFMOMNDKJ<T>(T KCAMANKDPPD, T PCCFFNKLAEE, out global::LAOIBAEOBNB<T> PFIDLIDKEJO, out global::GPOFGOIMPEA<T> NMICOGGIEFG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public abstract class LFIDNFJOFIN : DEMAFNKHPIE, BIJJPFLHCDJ
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x2C860A0", Offset = "0x2C854A0", VA = "0x182C860A0", Slot = "4")]
	private void DPBALGFNKLH(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FEKMACJDONH(MKPMKBJEFCI CKCKOLCCJBK);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
	protected LFIDNFJOFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DKKDIDPNENE(typeof(LocalPoseData))]
public sealed class DADKJALANLC : LFIDNFJOFIN
{
	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D15320", Offset = "0x2D14720", VA = "0x182D15320", Slot = "5")]
	protected override void FEKMACJDONH(MKPMKBJEFCI CKCKOLCCJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	public DADKJALANLC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class CopyAuthorityToEntity : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private EntityQuery CGCJGCFFJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private EntityQuery LMIAMINPIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EntityQuery PMIKDNJLJDD;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D122D0", Offset = "0x2D116D0", VA = "0x182D122D0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D12110", Offset = "0x2D11510", VA = "0x182D12110", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D12290", Offset = "0x2D11690", VA = "0x182D12290", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D12260", Offset = "0x2D11660", VA = "0x182D12260", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D12340", Offset = "0x2D11740", VA = "0x182D12340")]
		private void PDFBAGNJLAE(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D11CE0", Offset = "0x2D110E0", VA = "0x182D11CE0")]
		private void FHMMJDGNBDB(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D11A00", Offset = "0x2D10E00", VA = "0x182D11A00")]
		private void BLGCPCFKCBH(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D11F60", Offset = "0x2D11360", VA = "0x182D11F60")]
		private void JPMNAPGFMJJ(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D117F0", Offset = "0x2D10BF0", VA = "0x182D117F0")]
		private void AGOMNHEILKC(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D11E80", Offset = "0x2D11280", VA = "0x182D11E80")]
		private void HKPIADJJAAB(HOGBEFGIKOI DCJOMJHHEFE, int CFFPFDDOHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class ALBAJHKBFKI : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D01EB0", Offset = "0x2D012B0", VA = "0x182D01EB0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D01A20", Offset = "0x2D00E20", VA = "0x182D01A20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D01AE0", Offset = "0x2D00EE0", VA = "0x182D01AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D01440", Offset = "0x2D00840", VA = "0x182D01440")]
	private void KOBHBIGODAJ(NativeArray<Entity> IHPLCMEEOEJ, NativeList<Entity> ONIGEBBMCKC, ComponentDataFromEntity<PDNNBBMMODJ> BELECFLFNGJ, BufferFromEntity<ChildrenData> CIANEDCGFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public ALBAJHKBFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class NEIDABLFLFL : ParentSystemBase<AuthoredParentData, NEJHAMPOPML, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B330", Offset = "0x2A3A730", VA = "0x182A3B330", Slot = "14")]
	protected override EntityQueryDesc EOOGDHPMMHF(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x717AB0", VA = "0x1807186B0", Slot = "15")]
	protected override EntityQueryDesc CACNGMHKNPD(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B3B0", Offset = "0x2A3A7B0", VA = "0x182A3B3B0", Slot = "16")]
	protected override EntityQueryDesc GDFJNGFMCMK(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B370", Offset = "0x2A3A770", VA = "0x182A3B370", Slot = "17")]
	protected override EntityQueryDesc FAJHACBOBLD(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B430", Offset = "0x2A3A830", VA = "0x182A3B430")]
	public NEIDABLFLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B3F0", Offset = "0x2A3A7F0", VA = "0x182A3B3F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CEBBHIJFPIE : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private object BLFKIOCGHHN;

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D094F0", Offset = "0x2D088F0", VA = "0x182D094F0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D091D0", Offset = "0x2D085D0", VA = "0x182D091D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D09270", Offset = "0x2D08670", VA = "0x182D09270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public CEBBHIJFPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class IGCFGFNCOCN : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private object BLFKIOCGHHN;

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F180", Offset = "0x2C7E580", VA = "0x182C7F180", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EE60", Offset = "0x2C7E260", VA = "0x182C7EE60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EF00", Offset = "0x2C7E300", VA = "0x182C7EF00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public IGCFGFNCOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[InternalBufferCapacity(1)]
internal struct DBBBKFDFCOK : ISystemStateBufferElementData, IBufferElementData, IEquatable<DBBBKFDFCOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public EFOIAHNDAKE IICPGPKAIEH;

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D15570", Offset = "0x2D14970", VA = "0x182D15570", Slot = "4")]
	public bool Equals(DBBBKFDFCOK BKBGGIICJOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static DBBBKFDFCOK IGKGMCHPHKB(EFOIAHNDAKE IICPGPKAIEH)
	{
		return default(DBBBKFDFCOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[InternalBufferCapacity(4)]
internal struct PEODDHKFIDA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public EFOIAHNDAKE IICPGPKAIEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	public static PEODDHKFIDA IGKGMCHPHKB(EFOIAHNDAKE IICPGPKAIEH)
	{
		return default(PEODDHKFIDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal abstract class AGKDEENNCIP : GMHDCDDOMEN
{
	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D01140", Offset = "0x2D00540", VA = "0x182D01140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D012D0", Offset = "0x2D006D0", VA = "0x182D012D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980")]
	protected AGKDEENNCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[OIHCMNACLNL]
internal abstract class GMHDCDDOMEN : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	protected EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	protected IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	protected DLFLMEPDEKJ EIOOACKMMIN;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	protected abstract LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C79E10", Offset = "0x2C79210", VA = "0x182C79E10", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C79B20", Offset = "0x2C78F20", VA = "0x182C79B20")]
	protected void DFPOIKFLCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C798A0", Offset = "0x2C78CA0", VA = "0x182C798A0")]
	protected void CKJMBLCJKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C79DA0", Offset = "0x2C791A0", VA = "0x182C79DA0")]
	protected KEIDHOKKPCI KILCHEENMHJ()
	{
		return default(KEIDHOKKPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	protected GMHDCDDOMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal abstract class DDFGAJCLILA : GMHDCDDOMEN
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D15860", Offset = "0x2D14C60", VA = "0x182D15860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D159F0", Offset = "0x2D14DF0", VA = "0x182D159F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980")]
	protected DDFGAJCLILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal abstract class IMDNNDGDNIM : GMHDCDDOMEN
{
	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C81240", Offset = "0x2C80640", VA = "0x182C81240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C81350", Offset = "0x2C80750", VA = "0x182C81350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	protected IMDNNDGDNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class APCBDFNGLFD : AGKDEENNCIP
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D02B70", Offset = "0x2D01F70", VA = "0x182D02B70", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980")]
	public APCBDFNGLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal class MJBLACFDJBO : DDFGAJCLILA
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C88380", Offset = "0x2C87780", VA = "0x182C88380", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C82990", Offset = "0x2C81D90", VA = "0x182C82990")]
	public MJBLACFDJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class APIIPHLJLPO : IMDNNDGDNIM
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D02BE0", Offset = "0x2D01FE0", VA = "0x182D02BE0", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980")]
	public APIIPHLJLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class CBEAEIGMLKP : AGKDEENNCIP
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D08FF0", Offset = "0x2D083F0", VA = "0x182D08FF0", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980")]
	public CBEAEIGMLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class JGMPPJOOEKH : DDFGAJCLILA
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C82910", Offset = "0x2C81D10", VA = "0x182C82910", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C82990", Offset = "0x2C81D90", VA = "0x182C82990")]
	public JGMPPJOOEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C82980", Offset = "0x2C81D80", VA = "0x182C82980", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class GKMOLEMBBIH : IMDNNDGDNIM
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override LIEDKFIKHCP NCPENIDCLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C78740", Offset = "0x2C77B40", VA = "0x182C78740", Slot = "15")]
		get
		{
			return default(LIEDKFIKHCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public GKMOLEMBBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct NIACGIINLAG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct IOBMKIGHCKD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal struct LLFCJFGDJGF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public readonly struct LIEDKFIKHCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly ComponentType JNHKIIDIEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public readonly ComponentType LMFEBLFMKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public readonly object PFJMMABJIDH;

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C86520", Offset = "0x2C85920", VA = "0x182C86520")]
	public LIEDKFIKHCP(ComponentType JNHKIIDIEEF, ComponentType LMFEBLFMKNE, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF460", Offset = "0x2BBE860", VA = "0x182BBF460")]
	public static LIEDKFIKHCP BEIKDICPIGL<TReq, TTag>(object PFJMMABJIDH)
	{
		return default(LIEDKFIKHCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class ANOPEHJDJMH
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public const string AGFADCLADEH = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public const string FMPIAGNDKLG = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly LIEDKFIKHCP CLEDONBKDFM;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly LIEDKFIKHCP HFIFIBHCBOM;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal struct EFOIAHNDAKE : global::EFNHAFHOKBP<EFOIAHNDAKE>, JHCFGCJIHGF, IEquatable<EFOIAHNDAKE>
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D18EC0", Offset = "0x2D182C0", VA = "0x182D18EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D15570", Offset = "0x2D14970", VA = "0x182D15570", Slot = "8")]
	public bool Equals(EFOIAHNDAKE BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D18F00", Offset = "0x2D18300", VA = "0x182D18F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[OIHCMNACLNL]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Connectables)]
	public class UpdateConnectableVisuals : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private struct ANFNPPLIBAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public EFOIAHNDAKE IICPGPKAIEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public float3 IAMBOGDEHMB;

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x45BE280", Offset = "0x45BD680", VA = "0x1845BE280")]
			public ANFNPPLIBAB(EFOIAHNDAKE IICPGPKAIEH, float3 IAMBOGDEHMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x45BE260", Offset = "0x45BD660", VA = "0x1845BE260")]
			public void LEBFDCFJPJP(out EFOIAHNDAKE IICPGPKAIEH, out float3 IAMBOGDEHMB)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private struct JKFBBEMFNKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public NativeList<ANFNPPLIBAB> list;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
			public JKFBBEMFNKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<PEODDHKFIDA> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private struct NECKANPKBBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public NativeList<ANFNPPLIBAB> list;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
			public NECKANPKBBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<DBBBKFDFCOK> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private struct KFJDCEMDMHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public NativeList<ANFNPPLIBAB> list;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
			public KFJDCEMDMHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in FHKNLIGMGNK com, in DynamicBuffer<DBBBKFDFCOK> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HEEGJLEOIOA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			private struct CNFOCELHALN
			{
				[Cpp2IlInjected.Token(Token = "0x20000D9")]
				public struct EMLHNHFMPIJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002B6")]
					public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002B7")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JEDBADFJMIJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002B8")]
					public LambdaParameterValueProvider_DynamicBuffer<PEODDHKFIDA>.Runtime PGNECGOCFFN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B3")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HAJELPEHHBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> CDMDOCIEDNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<PEODDHKFIDA> MFODBKGKOLH;

				[Cpp2IlInjected.Token(Token = "0x6000734")]
				[Cpp2IlInjected.Address(RVA = "0x45BEC10", Offset = "0x45BE010", VA = "0x1845BEC10")]
				public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000735")]
				[Cpp2IlInjected.Address(RVA = "0x45BEB50", Offset = "0x45BDF50", VA = "0x1845BEB50")]
				public EMLHNHFMPIJ LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(EMLHNHFMPIJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public UpdateConnectableVisuals PKKGNCPEECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public NativeList<ANFNPPLIBAB> BEOMDPHLMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private CNFOCELHALN HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CNFOCELHALN.EMLHNHFMPIJ* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x45C0C70", Offset = "0x45C0070", VA = "0x1845C0C70")]
			internal void EMAOGODENHP(Entity KCGBIDJFHLF, WorldPoseData GOPJMLLJBJK, in DynamicBuffer<PEODDHKFIDA> AGOKAPGFDDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x45C1110", Offset = "0x45C0510", VA = "0x1845C1110", Slot = "5")]
			public void ReadFromDisplayClass(ref JKFBBEMFNKL GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x45C1140", Offset = "0x45C0540", VA = "0x1845C1140", Slot = "6")]
			public void WriteToDisplayClass(ref JKFBBEMFNKL GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x45C0EB0", Offset = "0x45C02B0", VA = "0x1845C0EB0", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x45C0F90", Offset = "0x45C0390", VA = "0x1845C0F90")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref CNFOCELHALN.EMLHNHFMPIJ NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x45C10D0", Offset = "0x45C04D0", VA = "0x1845C10D0")]
			public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE, ref JKFBBEMFNKL GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x45C0C00", Offset = "0x45C0000", VA = "0x1845C0C00")]
			public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct DJINHHMOLIC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000DB")]
			private struct BCJIOMFKJIK
			{
				[Cpp2IlInjected.Token(Token = "0x20000DC")]
				[NoAlias]
				public struct FHMMMOILIHC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JEDBADFJMIJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<DBBBKFDFCOK>.Runtime PGNECGOCFFN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> CDMDOCIEDNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<DBBBKFDFCOK> MFODBKGKOLH;

				[Cpp2IlInjected.Token(Token = "0x600073B")]
				[Cpp2IlInjected.Address(RVA = "0x45BE560", Offset = "0x45BD960", VA = "0x1845BE560")]
				public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600073C")]
				[Cpp2IlInjected.Address(RVA = "0x45BE4C0", Offset = "0x45BD8C0", VA = "0x1845BE4C0")]
				public FHMMMOILIHC LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(FHMMMOILIHC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public NativeList<ANFNPPLIBAB> BEOMDPHLMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private BCJIOMFKJIK HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BCJIOMFKJIK.FHMMMOILIHC* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x45BF0A0", Offset = "0x45BE4A0", VA = "0x1845BF0A0")]
			internal void EMAOGODENHP(in WorldPoseData GOPJMLLJBJK, in DynamicBuffer<DBBBKFDFCOK> AGOKAPGFDDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x3ADE380", Offset = "0x3ADD780", VA = "0x183ADE380", Slot = "5")]
			public void ReadFromDisplayClass(ref NECKANPKBBC GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x45BF1B0", Offset = "0x45BE5B0", VA = "0x1845BF1B0", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x45BF280", Offset = "0x45BE680", VA = "0x1845BF280")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref BCJIOMFKJIK.FHMMMOILIHC NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x45BF350", Offset = "0x45BE750", VA = "0x1845BF350")]
			public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE, ref NECKANPKBBC GGIPLLJMCBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EMBHMMPJCLN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000DE")]
			private struct NGKLECGKIBP
			{
				[Cpp2IlInjected.Token(Token = "0x20000DF")]
				[NoAlias]
				public struct NLGLAFOCFMI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JEDBADFJMIJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<FHKNLIGMGNK>.Runtime BOAGLDAJDFN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C8")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<DBBBKFDFCOK>.Runtime PGNECGOCFFN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C3")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> CDMDOCIEDNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<FHKNLIGMGNK> KFGIOPNEAJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DBBBKFDFCOK> MFODBKGKOLH;

				[Cpp2IlInjected.Token(Token = "0x6000742")]
				[Cpp2IlInjected.Address(RVA = "0x45C7340", Offset = "0x45C6740", VA = "0x1845C7340")]
				public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000743")]
				[Cpp2IlInjected.Address(RVA = "0x45C7270", Offset = "0x45C6670", VA = "0x1845C7270")]
				public NLGLAFOCFMI LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(NLGLAFOCFMI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			public NativeList<ANFNPPLIBAB> BEOMDPHLMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			private NGKLECGKIBP HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NGKLECGKIBP.NLGLAFOCFMI* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x45BFF70", Offset = "0x45BF370", VA = "0x1845BFF70")]
			internal void EMAOGODENHP(in WorldPoseData GOPJMLLJBJK, in FHKNLIGMGNK KHCAPAHHIAE, in DynamicBuffer<DBBBKFDFCOK> AGOKAPGFDDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x3ADE380", Offset = "0x3ADD780", VA = "0x183ADE380", Slot = "5")]
			public void ReadFromDisplayClass(ref KFJDCEMDMHG GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x45C00D0", Offset = "0x45BF4D0", VA = "0x1845C00D0", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x45C0150", Offset = "0x45BF550", VA = "0x1845C0150")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref NGKLECGKIBP.NLGLAFOCFMI NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x45C0270", Offset = "0x45BF670", VA = "0x1845C0270")]
			public void MNDCOKLGGKE(UpdateConnectableVisuals MJGELGPDDDE, ref KFJDCEMDMHG GGIPLLJMCBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private EntityQuery LILDONIFOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private EntityQuery KJAPOOHLPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private EntityQuery LKAMNMNKEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery CBLDPCMIBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery OBOBHNLCFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery HKIFCKLFEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery KCPGACHICFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery MIODPDJKEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery PMFHMPLGGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery OBLOMKGCLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private global::PHGCLLNIMJB<EFOIAHNDAKE, OCFAONBDMGG> JGKDGHHKONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private JGEBPOEEGMC KJFOJHNOMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private GGGMMDNLNGG LCPDGKLFBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private JIHFIOAGDDL OJPKHKHENFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery EBGHKPFKBFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private ProfilerMarker JLKIAGJNLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery BFBGKFOLAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private EntityQuery OPBOKNBJEKP;

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public int MHDOGPFGFFD
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2BE2D80", Offset = "0x2BE2180", VA = "0x182BE2D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3030", Offset = "0x2BE2430", VA = "0x182BE3030")]
		internal OCFAONBDMGG HBECBBHBPMO(EFOIAHNDAKE IICPGPKAIEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4ED0", Offset = "0x2BE42D0", VA = "0x182BE4ED0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4950", Offset = "0x2BE3D50", VA = "0x182BE4950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4BD0", Offset = "0x2BE3FD0", VA = "0x182BE4BD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4D60", Offset = "0x2BE4160", VA = "0x182BE4D60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4B90", Offset = "0x2BE3F90", VA = "0x182BE4B90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1EA0", Offset = "0x2BE12A0", VA = "0x182BE1EA0")]
		private void EAIEFJPIKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2BE29D0", Offset = "0x2BE1DD0", VA = "0x182BE29D0")]
		private void FFPJFMCGJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1AF0", Offset = "0x2BE0EF0", VA = "0x182BE1AF0")]
		private void EAICNIKJKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4DA0", Offset = "0x2BE41A0", VA = "0x182BE4DA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2BE12B0", Offset = "0x2BE06B0", VA = "0x182BE12B0")]
		private void ADDBGNGPEPF(EntityQuery CGCJGCFFJOA, EntityQuery BLHGJJNFHDC, EntityQuery LMIAMINPIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2F60", Offset = "0x2BE2360", VA = "0x182BE2F60")]
		private void GMLJNDAKNDK(EntityQuery LMIAMINPIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE26F0", Offset = "0x2BE1AF0", VA = "0x182BE26F0")]
		private void FFKBPLCHLPO(global::LJNKEFMLNCC<Entity> EBAKAIEOGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE37B0", Offset = "0x2BE2BB0", VA = "0x182BE37B0")]
		private void IMMMOPNFJIC(global::LJNKEFMLNCC<Entity> IJDNNAKIJCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2DC0", Offset = "0x2BE21C0", VA = "0x182BE2DC0")]
		private void GCIDMLPEOIP(global::LJNKEFMLNCC<Entity> HFCNIDMGNDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4190", Offset = "0x2BE3590", VA = "0x182BE4190")]
		private void LEFKEODMNPC(NativeList<EFOIAHNDAKE> LLDMNFAGMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE38C0", Offset = "0x2BE2CC0", VA = "0x182BE38C0")]
		private NativeList<EFOIAHNDAKE> JEHMNFICNPP(NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(NativeList<EFOIAHNDAKE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5150", Offset = "0x2BE4550", VA = "0x182BE5150")]
		private void PHNLKBOFGAJ(NativeArray<Entity> IHPLCMEEOEJ, NativeList<EFOIAHNDAKE> LLDMNFAGMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3080", Offset = "0x2BE2480", VA = "0x182BE3080")]
		private void HOBKKFGJFHK(NativeArray<Entity> OHJACAKMBEK, NativeArray<Entity> NGAGGKIFKIM, NativeList<EFOIAHNDAKE> CCJADMFACJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1FB0", Offset = "0x2BE13B0", VA = "0x182BE1FB0")]
		private void ECFPFPAMFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1820", Offset = "0x2BE0C20", VA = "0x182BE1820")]
		private global::CBNGKCNANOL<ANFNPPLIBAB> CNEBCFPFFAK(EntityQuery KFGMFPAGHMA, Func<NativeList<ANFNPPLIBAB>, JobHandle> JNDKINCNCOB)
		{
			return default(global::CBNGKCNANOL<ANFNPPLIBAB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1960", Offset = "0x2BE0D60", VA = "0x182BE1960")]
		private JobHandle DFJPJONCCBE(NativeList<ANFNPPLIBAB> BEOMDPHLMGK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4050", Offset = "0x2BE3450", VA = "0x182BE4050")]
		private JobHandle KBHGHDHPBKA(NativeList<ANFNPPLIBAB> BEOMDPHLMGK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x2BE46C0", Offset = "0x2BE3AC0", VA = "0x182BE46C0")]
		private JobHandle OPDDIDFEDBO(NativeList<ANFNPPLIBAB> BEOMDPHLMGK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x2BE43D0", Offset = "0x2BE37D0", VA = "0x182BE43D0")]
		private void NAIKAJKFOJO(global::CBNGKCNANOL<ANFNPPLIBAB> BEOMDPHLMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2460", Offset = "0x2BE1860", VA = "0x182BE2460")]
		private void ENNBJJIEMIG(global::CBNGKCNANOL<ANFNPPLIBAB> BEOMDPHLMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4660", Offset = "0x2BE3A60", VA = "0x182BE4660")]
		private bool ODMPMLMDKPE(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4300", Offset = "0x2BE3700", VA = "0x182BE4300")]
		private NativeArray<Entity> MAOLFGPNDEO(Entity KCGBIDJFHLF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE4F90", Offset = "0x2BE4390", VA = "0x182BE4F90")]
		private EFOIAHNDAKE PDEDFDLOPAO(NativeList<EFOIAHNDAKE> CCJADMFACJD)
		{
			return default(EFOIAHNDAKE);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1790", Offset = "0x2BE0B90", VA = "0x182BE1790")]
		private void CFKNIFCMHJG(EFOIAHNDAKE IICPGPKAIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE47F0", Offset = "0x2BE3BF0", VA = "0x182BE47F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE35B0", Offset = "0x2BE29B0", VA = "0x182BE35B0")]
		public static EntityQuery IGDHGIMHCED(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2B20", Offset = "0x2BE1F20", VA = "0x182BE2B20")]
		public static EntityQuery FGHNJJKLLLC(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x2BE3DE0", Offset = "0x2BE31E0", VA = "0x182BE3DE0")]
		public static EntityQuery JFAICMKOPEO(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[AFAPMPFKDID(JCDEPCAPNFC.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private AKIKBDADLPE NDBEPEANOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private EDIGLAHOEKM JPOKCHDFDJE;

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x2A51BF0", Offset = "0x2A50FF0", VA = "0x182A51BF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2A522B0", Offset = "0x2A516B0", VA = "0x182A522B0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2A51CF0", Offset = "0x2A510F0", VA = "0x182A51CF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class LPEEPCDALOA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public NODKLFFDFHA ECKHIFIOGEF;

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LPEEPCDALOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	public LPEEPCDALOA(NODKLFFDFHA ECKHIFIOGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x2C86600", Offset = "0x2C85A00", VA = "0x182C86600", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public abstract class LCBJGEFGFJA : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private ObjectEmbodimentService OFIMLDPADIP;

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2C86040", Offset = "0x2C85440", VA = "0x182C86040", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x2C85FF0", Offset = "0x2C853F0", VA = "0x182C85FF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x2C86020", Offset = "0x2C85420", VA = "0x182C86020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	protected LCBJGEFGFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class AGJGAEEIMIA : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private EntityQuery LNKAHLADFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private EntityQuery GPKHLPIFGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private EntityQuery GBFGAHLBBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private EntityQuery EONDFMLNHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private ObjectEmbodimentService BPJFMKONMIF;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int MNHMEJLDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D00C40", Offset = "0x2D00040", VA = "0x182D00C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int FPFDKAAIJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2D01130", Offset = "0x2D00530", VA = "0x182D01130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x2D00EB0", Offset = "0x2D002B0", VA = "0x182D00EB0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2D00C90", Offset = "0x2D00090", VA = "0x182D00C90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x2D00E90", Offset = "0x2D00290", VA = "0x182D00E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x2D00820", Offset = "0x2CFFC20", VA = "0x182D00820")]
	public int ALOJHDPLKID(SceneTag ENNCIIPAJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x2D008B0", Offset = "0x2CFFCB0", VA = "0x182D008B0")]
	public int COBBFMJJAON(SceneTag ENNCIIPAJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x2D00F10", Offset = "0x2D00310", VA = "0x182D00F10")]
	protected void PGMHMFFHDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x2D00B30", Offset = "0x2CFFF30", VA = "0x182D00B30")]
	protected void KBMELMMOOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x2D008D0", Offset = "0x2CFFCD0", VA = "0x182D008D0")]
	public global::LJNKEFMLNCC<Entity> DAKJCMBOPAJ(SceneTag ENNCIIPAJMI, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(global::LJNKEFMLNCC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x2D009B0", Offset = "0x2CFFDB0", VA = "0x182D009B0")]
	public global::LJNKEFMLNCC<Entity> DLGGJFFEAAC(SceneTag ENNCIIPAJMI, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(global::LJNKEFMLNCC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x2D00920", Offset = "0x2CFFD20", VA = "0x182D00920")]
	public bool DKDLKIANPOM(SceneTag ENNCIIPAJMI, out global::LJNKEFMLNCC<Entity> ECKHIFIOGEF, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x2D00AD0", Offset = "0x2CFFED0", VA = "0x182D00AD0")]
	public bool FDEINLLBLDO(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x2D00840", Offset = "0x2CFFC40", VA = "0x182D00840")]
	public NODKLFFDFHA CKFHMDJOFEM(Entity KCGBIDJFHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x2D00A60", Offset = "0x2CFFE60", VA = "0x182D00A60")]
	public bool ELFGIBIBFMP(Entity KCGBIDJFHLF, out LPEEPCDALOA ECKHIFIOGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0x2D00C50", Offset = "0x2D00050", VA = "0x182D00C50")]
	public void MHGDBICOJJL(Entity KCGBIDJFHLF, LPEEPCDALOA ECKHIFIOGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x2D00A00", Offset = "0x2CFFE00", VA = "0x182D00A00")]
	public bool EHEILLAFCLI(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void PBKBBJHEGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public AGJGAEEIMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class JDECJDHJDOG : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private EntityQuery OHANBLFNHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x2C82490", Offset = "0x2C81890", VA = "0x182C82490", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x2C820F0", Offset = "0x2C814F0", VA = "0x182C820F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x2C821B0", Offset = "0x2C815B0", VA = "0x182C821B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x26167F0", Offset = "0x2615BF0", VA = "0x1826167F0")]
	private bool APHHJNPBLAD<TComponentData>(EntityQuery KFGMFPAGHMA, out NativeArray<Entity> IHPLCMEEOEJ, out NativeArray<TComponentData> ICJBAHODFKP) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x2C82080", Offset = "0x2C81480", VA = "0x182C82080")]
	public NODKLFFDFHA CKFHMDJOFEM(Entity KCGBIDJFHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public JDECJDHJDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[AFAPMPFKDID(JCDEPCAPNFC.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private EntityQuery EKEFJAPPKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private EntityQuery FHCFNPOOAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private EntityQuery ELKCONFJLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private EntityQuery PMIKDNJLJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7010", Offset = "0x2BD6410", VA = "0x182BD7010", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6CB0", Offset = "0x2BD60B0", VA = "0x182BD6CB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6EE0", Offset = "0x2BD62E0", VA = "0x182BD6EE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BD0", Offset = "0x2BD5FD0", VA = "0x182BD6BD0")]
		private void EIPAABBBFMM(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6C40", Offset = "0x2BD6040", VA = "0x182BD6C40")]
		private void GMLJNDAKNDK(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6E70", Offset = "0x2BD6270", VA = "0x182BD6E70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6870", Offset = "0x2BD5C70", VA = "0x182BD6870")]
		private void BKDEBOFKKDA(EntityQuery KFGMFPAGHMA, bool LBKIMMBOFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal sealed class PLNFIKCPJBK : HPFCFNHKHFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct GKPOHCPDFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public GKPOHCPDFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct LLJOLNGHOHN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		private struct JJPDMGLBLIB
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			[NoAlias]
			public struct LLDDJIOMNEN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002E8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DIHIOBOJBFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002E9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime BNKNOCAEPHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002EA")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime KMIEKENOFDB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BBOIFHCKAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> PCFLANBLEHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> IPPNLOACABA;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x45C22C0", Offset = "0x45C16C0", VA = "0x1845C22C0")]
			public void MNDCOKLGGKE(PLNFIKCPJBK MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x45C2200", Offset = "0x45C1600", VA = "0x1845C2200")]
			public LLDDJIOMNEN LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(LLDDJIOMNEN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private JJPDMGLBLIB HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JJPDMGLBLIB.LLDDJIOMNEN* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x45C3E20", Offset = "0x45C3220", VA = "0x1845C3E20")]
		internal void EMAOGODENHP(Entity MBBKGMLAEGI, SplineShapeData HOEKGJHOPIH, DynamicBuffer<LinkedEntityGroup> BPMIJGKONLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x45C3E80", Offset = "0x45C3280", VA = "0x1845C3E80", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x45C3F50", Offset = "0x45C3350", VA = "0x1845C3F50")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref JJPDMGLBLIB.LLDDJIOMNEN NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x45C4070", Offset = "0x45C3470", VA = "0x1845C4070")]
		public void MNDCOKLGGKE(PLNFIKCPJBK MJGELGPDDDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IOMFPFMJEAE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		private struct CGBNABNDCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000EE")]
			[NoAlias]
			public struct DGBMOEPKBFO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LNOHNNLAKGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime OBGCBKNLMJD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GACMNEIHBND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> GLEBEANLNIA;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x45BE8C0", Offset = "0x45BDCC0", VA = "0x1845BE8C0")]
			public void MNDCOKLGGKE(PLNFIKCPJBK MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x45BE840", Offset = "0x45BDC40", VA = "0x1845BE840")]
			public DGBMOEPKBFO LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(DGBMOEPKBFO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public BufferFromEntity<LinkedEntityGroup> KAPCDOPPNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private CGBNABNDCPJ HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CGBNABNDCPJ.DGBMOEPKBFO* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x45C1910", Offset = "0x45C0D10", VA = "0x1845C1910")]
		internal void EMAOGODENHP(Entity COOOOOEEJOG, SplinePointParentData JKBIAFABLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x45C1B80", Offset = "0x45C0F80", VA = "0x1845C1B80", Slot = "5")]
		public void ReadFromDisplayClass(ref GKPOHCPDFJG GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x45C19A0", Offset = "0x45C0DA0", VA = "0x1845C19A0", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x45C1A40", Offset = "0x45C0E40", VA = "0x1845C1A40")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref CGBNABNDCPJ.DGBMOEPKBFO NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x45C1AF0", Offset = "0x45C0EF0", VA = "0x1845C1AF0")]
		public void MNDCOKLGGKE(PLNFIKCPJBK MJGELGPDDDE, ref GKPOHCPDFJG GGIPLLJMCBK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private EntityQuery ILOOLOIIOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private EntityQuery FKFLGEMDDIH;

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C5C0", Offset = "0x2A4B9C0", VA = "0x182A4C5C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C670", Offset = "0x2A4BA70", VA = "0x182A4C670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public PLNFIKCPJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C320", Offset = "0x2A4B720", VA = "0x182A4C320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C180", Offset = "0x2A4B580", VA = "0x182A4C180")]
	public static EntityQuery LBGGGMJMAAB(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C020", Offset = "0x2A4B420", VA = "0x182A4C020")]
	public static EntityQuery CMOGPHGGDEJ(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public sealed class MKNNNKALCIP : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private PKKNALEKOHF MKMDDACMGAO;

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x2C885E0", Offset = "0x2C879E0", VA = "0x182C885E0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x2C885C0", Offset = "0x2C879C0", VA = "0x182C885C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public MKNNNKALCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class GHDHEJKHCPL : HPFCFNHKHFD, BIJJPFLHCDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct FHBBPIPCGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public NativeList<BAGOHMBBHPA> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public NativeList<AJGCMCOKHHP> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public NativeList<BAGOHMBBHPA> oldParents;

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public FHBBPIPCGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, LGMDCDJDGBF previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__2(Entity entity, LGMDCDJDGBF previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct KDMHMMNINAG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		private struct LCHDNDAGFDC
		{
			[Cpp2IlInjected.Token(Token = "0x20000F4")]
			[NoAlias]
			public struct BNFOBOKKIAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FF")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000300")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime BDOEACPFAFJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> DMALNBNHKGC;

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x45C3520", Offset = "0x45C2920", VA = "0x1845C3520")]
			public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x45C34A0", Offset = "0x45C28A0", VA = "0x1845C34A0")]
			public BNFOBOKKIAL LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(BNFOBOKKIAL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NativeList<BAGOHMBBHPA> GAPIEKACOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private LCHDNDAGFDC HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LCHDNDAGFDC.BNFOBOKKIAL* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x45C2620", Offset = "0x45C1A20", VA = "0x1845C2620")]
		internal void EMAOGODENHP(Entity KCGBIDJFHLF, ParentData FOPIKDEMFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE380", Offset = "0x3ADD780", VA = "0x183ADE380", Slot = "5")]
		public void ReadFromDisplayClass(ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x45C26A0", Offset = "0x45C1AA0", VA = "0x1845C26A0", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x45C2740", Offset = "0x45C1B40", VA = "0x1845C2740")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref LCHDNDAGFDC.BNFOBOKKIAL NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x45C27F0", Offset = "0x45C1BF0", VA = "0x1845C27F0")]
		public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE, ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct HLCACLBKLMA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		private struct OHDBLEBFLOP
		{
			[Cpp2IlInjected.Token(Token = "0x20000F7")]
			[NoAlias]
			public struct CKGJKLHJPCF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime BDOEACPFAFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000309")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<LGMDCDJDGBF>.Runtime HDHJFAJKEMB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> DMALNBNHKGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<LGMDCDJDGBF> JLFCNJFFDLA;

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x45C7470", Offset = "0x45C6870", VA = "0x1845C7470")]
			public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x45C73D0", Offset = "0x45C67D0", VA = "0x1845C73D0")]
			public CKGJKLHJPCF LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(CKGJKLHJPCF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<AJGCMCOKHHP> GPFPLHDLLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private OHDBLEBFLOP HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OHDBLEBFLOP.CKGJKLHJPCF* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x45C13E0", Offset = "0x45C07E0", VA = "0x1845C13E0")]
		internal void EMAOGODENHP(Entity KCGBIDJFHLF, ParentData FOPIKDEMFDA, LGMDCDJDGBF CKINCBHFECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x45C1690", Offset = "0x45C0A90", VA = "0x1845C1690", Slot = "5")]
		public void ReadFromDisplayClass(ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x45C14A0", Offset = "0x45C08A0", VA = "0x1845C14A0", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x45C1570", Offset = "0x45C0970", VA = "0x1845C1570")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref OHDBLEBFLOP.CKGJKLHJPCF NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x45C1650", Offset = "0x45C0A50", VA = "0x1845C1650")]
		public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE, ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct JOENNLMLMEB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		private struct GNDEGMFAMME
		{
			[Cpp2IlInjected.Token(Token = "0x20000FA")]
			[NoAlias]
			public struct FCKJFOKPKIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<LGMDCDJDGBF>.Runtime HDHJFAJKEMB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<LGMDCDJDGBF> JLFCNJFFDLA;

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x45C0BA0", Offset = "0x45BFFA0", VA = "0x1845C0BA0")]
			public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x45C0B20", Offset = "0x45BFF20", VA = "0x1845C0B20")]
			public FCKJFOKPKIE LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(FCKJFOKPKIE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public NativeList<BAGOHMBBHPA> OPPKKNMEFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private GNDEGMFAMME HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GNDEGMFAMME.FCKJFOKPKIE* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x45C23B0", Offset = "0x45C17B0", VA = "0x1845C23B0")]
		internal void EMAOGODENHP(Entity KCGBIDJFHLF, LGMDCDJDGBF CKINCBHFECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x45C2610", Offset = "0x45C1A10", VA = "0x1845C2610", Slot = "5")]
		public void ReadFromDisplayClass(ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x45C2430", Offset = "0x45C1830", VA = "0x1845C2430", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x45C24D0", Offset = "0x45C18D0", VA = "0x1845C24D0")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref GNDEGMFAMME.FCKJFOKPKIE NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x45C2580", Offset = "0x45C1980", VA = "0x1845C2580")]
		public void MNDCOKLGGKE(GHDHEJKHCPL MJGELGPDDDE, ref FHBBPIPCGMK GGIPLLJMCBK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private AFANFAEGBHI PLNBOLJMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private EntityQuery HEIKPJHBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private EntityQuery HEOFFBBIPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private EntityQuery NPNFBKEMEPL;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x2C77E10", Offset = "0x2C77210", VA = "0x182C77E10", Slot = "14")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x2C78380", Offset = "0x2C77780", VA = "0x182C78380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public GHDHEJKHCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x2C78320", Offset = "0x2C77720", VA = "0x182C78320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x2C77BB0", Offset = "0x2C76FB0", VA = "0x182C77BB0")]
	public static EntityQuery CHGPCILLDJM(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2C77EF0", Offset = "0x2C772F0", VA = "0x182C77EF0")]
	public static EntityQuery HLPFLHMFEJI(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x2C78120", Offset = "0x2C77520", VA = "0x182C78120")]
	public static EntityQuery MDGGJGDPHAG(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[AFAPMPFKDID(JCDEPCAPNFC.Connectables)]
	public class InitializeRigidbodyExHierarchy : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private OMFDKPDAEMN OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C81BF0", Offset = "0x2C80FF0", VA = "0x182C81BF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C81E70", Offset = "0x2C81270", VA = "0x182C81E70", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C81C80", Offset = "0x2C81080", VA = "0x182C81C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public class GCBGLBKMLGF : ParentSystemBase<ParentData, LGMDCDJDGBF, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C74420", Offset = "0x2C73820", VA = "0x182C74420", Slot = "14")]
	protected override EntityQueryDesc EOOGDHPMMHF(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x717AB0", VA = "0x1807186B0", Slot = "15")]
	protected override EntityQueryDesc CACNGMHKNPD(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C744A0", Offset = "0x2C738A0", VA = "0x182C744A0", Slot = "16")]
	protected override EntityQueryDesc GDFJNGFMCMK(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C74460", Offset = "0x2C73860", VA = "0x182C74460", Slot = "17")]
	protected override EntityQueryDesc FAJHACBOBLD(EntityQueryDesc KFGMFPAGHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C74520", Offset = "0x2C73920", VA = "0x182C74520")]
	public GCBGLBKMLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C744E0", Offset = "0x2C738E0", VA = "0x182C744E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : HPFCFNHKHFD where ParentData : struct, IComponentData, DCIIGNCABLO where PreviousParentData : struct, IComponentData, DCIIGNCABLO where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, DCIIGNCABLO
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[BurstCompile]
		private struct PFBFCNPHEGJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter AJFGDECLKOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MICNCKNJCPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public NativeHashMap<Entity, int>.ParallelWriter OMHHOPPACEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public ArchetypeChunkComponentType<PreviousParentData> HKCMBKNMBMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> KFPHKEODAAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			[ReadOnly]
			public ArchetypeChunkEntityType BCCIKGEDOFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public uint IIKLADPIEOI;

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x3500F60", Offset = "0x3500360", VA = "0x183500F60", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[BurstCompile]
		private struct OIDKKAFPJMO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OMHHOPPACEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> MGKBPINJPNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeList<Entity> FLFHJLBJMAE;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x28D70C0", Offset = "0x28D64C0", VA = "0x1828D70C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[BurstCompile]
		private struct LLJFDKFCLNC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> AJFGDECLKOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MICNCKNJCPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OMHHOPPACEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public BufferFromEntity<ChildrenData> MGKBPINJPNE;

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x23E77F0", Offset = "0x23E6BF0", VA = "0x1823E77F0")]
			private int ACDABHCEKHI(DynamicBuffer<ChildrenData> CJDMCMNNBID, Entity KCGBIDJFHLF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x23E7900", Offset = "0x23E6D00", VA = "0x1823E7900")]
			private void CBCDENKMAGF(Entity BLENCGKHIJI, DynamicBuffer<ChildrenData> CJDMCMNNBID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x23E7E80", Offset = "0x23E7280", VA = "0x1823E7E80")]
			private void GDNKCCOIEBO(Entity BLENCGKHIJI, DynamicBuffer<ChildrenData> CJDMCMNNBID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x23E7BC0", Offset = "0x23E6FC0", VA = "0x1823E7BC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[BurstCompile]
		private struct DLGFGEFBDLP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public NativeArray<Entity> IOFNGKDPMOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public NativeList<Entity> MMKJCMJHBBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public BufferFromEntity<ChildrenData> MGKBPINJPNE;

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x2FD7280", Offset = "0x2FD6680", VA = "0x182FD7280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected EntityQuery IHPDOLOKGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected EntityQuery HFBAFPGNLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected EntityQuery HNDBPMFDEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected EntityQuery AFLDJJNKNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected ProfilerMarker GHCPLNKNMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected ProfilerMarker IHMGJECHIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected ProfilerMarker CCPFEHCHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected ProfilerMarker KLACGLNDOCA;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C32270", Offset = "0x2C31670", VA = "0x182C32270")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C30210", Offset = "0x2C2F610", VA = "0x182C30210")]
		private int ACDABHCEKHI(DynamicBuffer<ChildrenData> CJDMCMNNBID, Entity KCGBIDJFHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C30F00", Offset = "0x2C30300", VA = "0x182C30F00")]
		private void ILAOFCGGNNJ(Entity FLBPEPNFBOA, Entity NMHBGKPCHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x717AB0", VA = "0x1807186B0", Slot = "14")]
		protected virtual EntityQueryDesc EOOGDHPMMHF(EntityQueryDesc KFGMFPAGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x717AB0", VA = "0x1807186B0", Slot = "15")]
		protected virtual EntityQueryDesc CACNGMHKNPD(EntityQueryDesc KFGMFPAGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x7186B0", Offset = "0x717AB0", VA = "0x1807186B0", Slot = "16")]
		protected virtual EntityQueryDesc GDFJNGFMCMK(EntityQueryDesc KFGMFPAGHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FAJHACBOBLD(EntityQueryDesc KFGMFPAGHMA);

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C31B00", Offset = "0x2C30F00", VA = "0x182C31B00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C30300", Offset = "0x2C2F700", VA = "0x182C30300")]
		private void BMNBFJGHHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C311C0", Offset = "0x2C305C0", VA = "0x182C311C0")]
		private void IPNCINIEBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C304A0", Offset = "0x2C2F8A0", VA = "0x182C304A0")]
		private JobHandle FEANLKHPCGH(JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C31820", Offset = "0x2C30C20", VA = "0x182C31820")]
		private void OMLKALHINNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C32040", Offset = "0x2C31440", VA = "0x182C32040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x2737B30", Offset = "0x2736F30", VA = "0x182737B30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x27707D0", Offset = "0x276FBD0", VA = "0x1827707D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[AlwaysUpdateSystem]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public abstract class NBALLIBJMND : HPFCFNHKHFD, BIJJPFLHCDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private struct MCBKEECPHDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public global::CBNGKCNANOL<Entity> NEIFDEHMEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public global::CBNGKCNANOL<Entity> LAAPIIICFJM;

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x45C4AA0", Offset = "0x45C3EA0", VA = "0x1845C4AA0")]
		public MCBKEECPHDD(NativeList<Entity> NEIFDEHMEMC, NativeList<Entity> LAAPIIICFJM, JobHandle KNAKGAMMCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x45C4990", Offset = "0x45C3D90", VA = "0x1845C4990")]
		public JobHandle BCAHKFOBCCB(JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x45C4A10", Offset = "0x45C3E10", VA = "0x1845C4A10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[BurstCompile]
	private struct NFNLICCMOGD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[Flags]
		public enum PLMNMPMMFKK
		{
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[WriteOnly]
		public NativeList<Entity> IBELCHEMANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[WriteOnly]
		public NativeList<Entity> DFCFGCPIEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[ReadOnly]
		public NativeArray<Entity> FGDFMOBENIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FOEDGHHJFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[ReadOnly]
		public EEFBLJMPCLJ JBEEOEMIGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		[ReadOnly]
		public EEFBLJMPCLJ CEPDDODACIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> MGLNMIFFOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public int HLHAJEAANAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public int LKHIEDIOCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private PLMNMPMMFKK ALNHKIHJPEP;

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x45C69D0", Offset = "0x45C5DD0", VA = "0x1845C69D0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x45C6940", Offset = "0x45C5D40", VA = "0x1845C6940")]
		private void EEJCKFFPDIF(Entity KCGBIDJFHLF, bool EGIIAHAKDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x45C7160", Offset = "0x45C6560", VA = "0x1845C7160")]
		private void PMANFMNBLNP(Entity KCGBIDJFHLF, bool EGIIAHAKDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x45C6C40", Offset = "0x45C6040", VA = "0x1845C6C40")]
		public MCBKEECPHDD FNMCDKAAFLI(NativeArray<Entity> CNIGGNPJLOO, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x45C70E0", Offset = "0x45C64E0", VA = "0x1845C70E0")]
		public MCBKEECPHDD ONHKNJACNCB(NativeArray<Entity> CNIGGNPJLOO, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x45C6CC0", Offset = "0x45C60C0", VA = "0x1845C6CC0")]
		public MCBKEECPHDD IMDODHFIMCH(NativeList<BAGOHMBBHPA> BEOMDPHLMGK, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x45C6B60", Offset = "0x45C5F60", VA = "0x1845C6B60")]
		public MCBKEECPHDD FFGBKODJJOL(NativeList<BAGOHMBBHPA> BEOMDPHLMGK, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x45C7000", Offset = "0x45C6400", VA = "0x1845C7000")]
		public MCBKEECPHDD LEJGALAHNGL(NativeList<AJGCMCOKHHP> BEOMDPHLMGK, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x25F8A80", Offset = "0x25F7E80", VA = "0x1825F8A80")]
		private MCBKEECPHDD IPOINCNDEII<T>(NativeList<T> BEOMDPHLMGK, int DGJANLKNPBG, int NABNAKDECMI, PLMNMPMMFKK PNIPPNPIENM, JobHandle KOKJOGPCFAB) where T : struct
		{
			return default(MCBKEECPHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x45C6DA0", Offset = "0x45C61A0", VA = "0x1845C6DA0")]
		private MCBKEECPHDD IPOINCNDEII(NativeArray<Entity> IHPLCMEEOEJ, int DGJANLKNPBG, int NABNAKDECMI, PLMNMPMMFKK PNIPPNPIENM, JobHandle KOKJOGPCFAB)
		{
			return default(MCBKEECPHDD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private EntityQuery MIDPDGKGHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private EntityQuery MBFHGCAMCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private AFANFAEGBHI OJDMMPMLLDG;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected abstract ComponentType BEALFJLDEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	protected abstract ComponentType ABPJDEPDJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	protected abstract ComponentType HGGELJLCKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AA10", Offset = "0x2A39E10", VA = "0x182A3AA10")]
	protected NBALLIBJMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A39360", Offset = "0x2A38760", VA = "0x182A39360", Slot = "14")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A399B0", Offset = "0x2A38DB0", VA = "0x182A399B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A39BE0", Offset = "0x2A38FE0", VA = "0x182A39BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x776510", Offset = "0x775910", VA = "0x180776510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A39300", Offset = "0x2A38700", VA = "0x182A39300")]
	private void DEANKMFHPKO(NativeArray<Entity> BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A39690", Offset = "0x2A38A90", VA = "0x182A39690")]
	private void KABAHAMAEBD(NativeArray<Entity> BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A39550", Offset = "0x2A38950", VA = "0x182A39550")]
	private void GKAHCHLLKNC(MCBKEECPHDD JKGHFIMDABP, string KDKDCPDPKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A39440", Offset = "0x2A38840", VA = "0x182A39440")]
	private void GKAHCHLLKNC(global::CBNGKCNANOL<Entity> INGJNOPOAKM, string KDKDCPDPKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A39760", Offset = "0x2A38B60", VA = "0x182A39760")]
	private void NFBFMHLLGJP(MCBKEECPHDD JKGHFIMDABP, string KDKDCPDPKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A398A0", Offset = "0x2A38CA0", VA = "0x182A398A0")]
	private void NFBFMHLLGJP(global::CBNGKCNANOL<Entity> INGJNOPOAKM, string KDKDCPDPKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A396F0", Offset = "0x2A38AF0", VA = "0x182A396F0")]
	private bool LLOCJIOKODJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public class JNPDNDAOAIA : HPFCFNHKHFD, OIOAOEDFDMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct KFLEKBODMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public JNPDNDAOAIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public KFLEKBODMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KJMOKFCMJKO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct EPGNHKIIAJC
		{
			[Cpp2IlInjected.Token(Token = "0x200010A")]
			public struct ODIFHAEPJCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000350")]
				public LambdaParameterValueProvider_Entity.Runtime PDGDMEEIKEF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PDPJMLJPHLA;

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x45C0320", Offset = "0x45BF720", VA = "0x1845C0320")]
			public void MNDCOKLGGKE(JNPDNDAOAIA MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x45C0310", Offset = "0x45BF710", VA = "0x1845C0310")]
			public ODIFHAEPJCB LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(ODIFHAEPJCB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public JNPDNDAOAIA PKKGNCPEECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public EntityCommandBuffer NJOPHMDMEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private EPGNHKIIAJC HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EPGNHKIIAJC.ODIFHAEPJCB* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x45C2E70", Offset = "0x45C2270", VA = "0x1845C2E70")]
		internal void EMAOGODENHP(Entity CLHMIOKIOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x45C3080", Offset = "0x45C2480", VA = "0x1845C3080", Slot = "5")]
		public void ReadFromDisplayClass(ref KFLEKBODMHO GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x45C30B0", Offset = "0x45C24B0", VA = "0x1845C30B0", Slot = "6")]
		public void WriteToDisplayClass(ref KFLEKBODMHO GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x45C2F80", Offset = "0x45C2380", VA = "0x1845C2F80", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x45C2FD0", Offset = "0x45C23D0", VA = "0x1845C2FD0")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref EPGNHKIIAJC.ODIFHAEPJCB NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x45C3040", Offset = "0x45C2440", VA = "0x1845C3040")]
		public void MNDCOKLGGKE(JNPDNDAOAIA MJGELGPDDDE, ref KFLEKBODMHO GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x45C2E00", Offset = "0x45C2200", VA = "0x1845C2E00")]
		public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private PCBPLKKAMJP DEODCLABBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private HEKPAFKDBLD PDBFBDMLDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private EntityQuery JFOFCHPIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private ProfilerMarker CHKKGDECMEH;

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C83120", Offset = "0x2C82520", VA = "0x182C83120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C832D0", Offset = "0x2C826D0", VA = "0x182C832D0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C83180", Offset = "0x2C82580", VA = "0x182C83180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public JNPDNDAOAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C83040", Offset = "0x2C82440", VA = "0x182C83040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C82E70", Offset = "0x2C82270", VA = "0x182C82E70")]
	public static EntityQuery GKGPCLPEBME(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[OIHCMNACLNL]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public class IJHIPIPOJCF : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private HEKPAFKDBLD PDBFBDMLDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private SceneService KGBHFHAMEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x2C809B0", Offset = "0x2C7FDB0", VA = "0x182C809B0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2C805C0", Offset = "0x2C7F9C0", VA = "0x182C805C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2C80660", Offset = "0x2C7FA60", VA = "0x182C80660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public IJHIPIPOJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public struct LPLLHGHODNK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public HHCCENAFAHO IICPGPKAIEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000")]
	public static LPLLHGHODNK IGKGMCHPHKB(in HHCCENAFAHO BJFNHLCPHPH)
	{
		return default(LPLLHGHODNK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000")]
	public static HHCCENAFAHO IGKGMCHPHKB(in LPLLHGHODNK EJCDNALNFEF)
	{
		return default(HHCCENAFAHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[AlwaysUpdateSystem]
public class PCBPLKKAMJP : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A6B0", Offset = "0x2A49AB0", VA = "0x182A4A6B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	public PCBPLKKAMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[AlwaysUpdateSystem]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public class JMNJPFCKJHA : HPFCFNHKHFD, OIOAOEDFDMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct EHFGNFPPMJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public JMNJPFCKJHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public EHFGNFPPMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__0(Entity e, LPLLHGHODNK ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PEKJIIMPLGA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private struct LCOILKCPGJE
		{
			[Cpp2IlInjected.Token(Token = "0x2000112")]
			public struct GLCFHBGHANP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public LambdaParameterValueProvider_Entity.Runtime PDGDMEEIKEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public LambdaParameterValueProvider_IComponentData<LPLLHGHODNK>.Runtime OMANOIENNAF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PDPJMLJPHLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<LPLLHGHODNK> LJKDBAOGKOG;

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x45C3DC0", Offset = "0x45C31C0", VA = "0x1845C3DC0")]
			public void MNDCOKLGGKE(JMNJPFCKJHA MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x45C3D40", Offset = "0x45C3140", VA = "0x1845C3D40")]
			public GLCFHBGHANP LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(GLCFHBGHANP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public JMNJPFCKJHA PKKGNCPEECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public EntityCommandBuffer NJOPHMDMEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private LCOILKCPGJE HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LCOILKCPGJE.GLCFHBGHANP* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x45C78E0", Offset = "0x45C6CE0", VA = "0x1845C78E0")]
		internal void EMAOGODENHP(Entity CLHMIOKIOGP, LPLLHGHODNK OEHKHCOEAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x45C3080", Offset = "0x45C2480", VA = "0x1845C3080", Slot = "5")]
		public void ReadFromDisplayClass(ref EHFGNFPPMJP GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x45C30B0", Offset = "0x45C24B0", VA = "0x1845C30B0", Slot = "6")]
		public void WriteToDisplayClass(ref EHFGNFPPMJP GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x45C79E0", Offset = "0x45C6DE0", VA = "0x1845C79E0", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x45C7A80", Offset = "0x45C6E80", VA = "0x1845C7A80")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref LCOILKCPGJE.GLCFHBGHANP NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x45C7B30", Offset = "0x45C6F30", VA = "0x1845C7B30")]
		public void MNDCOKLGGKE(JMNJPFCKJHA MJGELGPDDDE, ref EHFGNFPPMJP GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x45C7870", Offset = "0x45C6C70", VA = "0x1845C7870")]
		public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private PCBPLKKAMJP DEODCLABBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private HEKPAFKDBLD PDBFBDMLDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private EntityQuery IGHBBFDCIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private ProfilerMarker GJEJLNFJBDO;

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x2C82C50", Offset = "0x2C82050", VA = "0x182C82C50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x2C82E10", Offset = "0x2C82210", VA = "0x182C82E10", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x2C82CB0", Offset = "0x2C820B0", VA = "0x182C82CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public JMNJPFCKJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x2C82B70", Offset = "0x2C81F70", VA = "0x182C82B70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x2C829A0", Offset = "0x2C81DA0", VA = "0x182C829A0")]
	public static EntityQuery DLMOBJIGDDA(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct IIMKHLCCJDA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public MELNNNHAMLB KPJDOIFOFHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public NativeHashMap<Entity, KMBCDIKKHFF> IHPLCMEEOEJ;

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x45C17B0", Offset = "0x45C0BB0", VA = "0x1845C17B0")]
			public IIMKHLCCJDA(int OIKPPNLJGJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x45C1730", Offset = "0x45C0B30", VA = "0x1845C1730", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[BurstCompile]
		private struct DLGIFOMAGGO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EKNGNPFKKAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> IGOENOLNMBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> OAIBCIFEAIH;

			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0x45BF750", Offset = "0x45BEB50", VA = "0x1845BF750", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[BurstCompile]
		private struct KIJBPNLGFBO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EKNGNPFKKAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> OAIBCIFEAIH;

			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x45C2CB0", Offset = "0x45C20B0", VA = "0x1845C2CB0", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private HEKPAFKDBLD PDBFBDMLDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private EntityQuery EFFDBEGDJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private EntityQuery DEKDKLFBDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private EntityQuery EDKFMGGDKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private EntityQuery IDNJEEIAMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private EntityQuery MCEBDAOBGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private JobHandle LPFBCIHBGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private IIMKHLCCJDA OIHAFPNMNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private IIMKHLCCJDA NCDHNNFGLBP;

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F6D0", Offset = "0x2A4EAD0", VA = "0x182A4F6D0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EC70", Offset = "0x2A4E070", VA = "0x182A4EC70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EC30", Offset = "0x2A4E030", VA = "0x182A4EC30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EF30", Offset = "0x2A4E330", VA = "0x182A4EF30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E1D0", Offset = "0x2A4D5D0", VA = "0x182A4E1D0")]
		private void ADJODFCAKFF(EntityQuery KFGMFPAGHMA, out (global::LJNKEFMLNCC<LPLLHGHODNK> handles, global::LJNKEFMLNCC<GGMEFOFAIEF> bounds) HANEMGLFJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E9D0", Offset = "0x2A4DDD0", VA = "0x182A4E9D0")]
		private void MCMFEOCFKJF((global::LJNKEFMLNCC<LPLLHGHODNK> handles, global::LJNKEFMLNCC<GGMEFOFAIEF> bounds) HANEMGLFJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EC30", Offset = "0x2A4E030", VA = "0x182A4EC30")]
		private void MNKPEIMPPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E760", Offset = "0x2A4DB60", VA = "0x182A4E760")]
		private void JFHAEEINKNI(EntityQuery KFGMFPAGHMA, out (global::LJNKEFMLNCC<Entity> entities, global::LJNKEFMLNCC<LPLLHGHODNK> handles) HANEMGLFJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E310", Offset = "0x2A4D710", VA = "0x182A4E310")]
		private void BBLHGGIAFNM((global::LJNKEFMLNCC<Entity> entities, global::LJNKEFMLNCC<LPLLHGHODNK> handles) HANEMGLFJMM, IIMKHLCCJDA FIIMOOOHHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E600", Offset = "0x2A4DA00", VA = "0x182A4E600")]
		private JobHandle GOOHANKABII(IIMKHLCCJDA FIIMOOOHHPE, ComponentDataFromEntity<WorldPoseData> EKNGNPFKKAB, ComponentDataFromEntity<WorldUniformScaleData> OAIBCIFEAIH, ComponentDataFromEntity<WorldDeformableScaleData> IGOENOLNMBE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E8A0", Offset = "0x2A4DCA0", VA = "0x182A4E8A0")]
		private JobHandle KCFEPBDJLKN(IIMKHLCCJDA FIIMOOOHHPE, ComponentDataFromEntity<WorldPoseData> EKNGNPFKKAB, ComponentDataFromEntity<WorldUniformScaleData> OAIBCIFEAIH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
public struct IEPLLMEOFDO : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[OIHCMNACLNL]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class SplineLocalBoundsSystem : HPFCFNHKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		[BurstCompile]
		private struct KGKJCLDHABB : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> CMPMDKNOKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> NIHOPOOHGBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<GGMEFOFAIEF> KFICDCMOJGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			[WriteOnly]
			public NativeHashMap<Entity, KMBCDIKKHFF>.ParallelWriter HNJKPJOOJKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter BDNCICKDKME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter JAOFKNJOCMN;

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x45C2B30", Offset = "0x45C1F30", VA = "0x1845C2B30", Slot = "4")]
			public void Execute(int PGFOAHEHPOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011A")]
		[BurstCompile]
		private struct JFFHELIOKDA : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			[ReadOnly]
			public NativeArray<Entity> CCDLMIGICFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> KOKFAHMIFOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> FJCBPBDKGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> EPEIHFMHFHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<GGMEFOFAIEF> ELCIGOBOKBM;

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x45C1B90", Offset = "0x45C0F90", VA = "0x1845C1B90", Slot = "4")]
			public void Execute(int PGFOAHEHPOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private EntityQuery BOENLKJMLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private EntityQuery MAJEJKGLOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private EntityQuery EHBOIDFFBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private EntityQuery NJPHMHBEEHL;

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x2BD94F0", Offset = "0x2BD88F0", VA = "0x182BD94F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9700", Offset = "0x2BD8B00", VA = "0x182BD9700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9050", Offset = "0x2BD8450", VA = "0x182BD9050")]
		private JobHandle KFPANNGHDLC(global::LJNKEFMLNCC<Entity> CCKHAOABLMF, int EBMDFJGMEAO, JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9130", Offset = "0x2BD8530", VA = "0x182BD9130")]
		private JobHandle KFPANNGHDLC(NativeArray<Entity> FPDFPCHGOAL, int EBMDFJGMEAO, [Optional] JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9310", Offset = "0x2BD8710", VA = "0x182BD9310")]
		private global::LJNKEFMLNCC<Entity> KKAGAJEMDGO(EntityQuery KFGMFPAGHMA)
		{
			return default(global::LJNKEFMLNCC<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8710", Offset = "0x2BD7B10", VA = "0x182BD8710")]
		private (global::CBNGKCNANOL<Entity>, global::CBNGKCNANOL<Entity>) AOHAOJPPKMM(global::LJNKEFMLNCC<Entity> BFJJDHEGHJP)
		{
			return default((global::CBNGKCNANOL<Entity>, global::CBNGKCNANOL<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8E90", Offset = "0x2BD8290", VA = "0x182BD8E90")]
		private void GMALHDJJJBB(out NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9460", Offset = "0x2BD8860", VA = "0x182BD9460")]
		private void LANPPBJMCLI(NativeList<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9390", Offset = "0x2BD8790", VA = "0x182BD9390")]
		private void LANPPBJMCLI(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8F20", Offset = "0x2BD8320", VA = "0x182BD8F20")]
		private void JABMJGLHLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void FHKKEOFKFJB(int FLJJBKOOJBO, int FDGKKCDJCEB, int GBBGPJOGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B60", Offset = "0x2BD7F60", VA = "0x182BD8B60")]
		private static GGMEFOFAIEF ECIDFLNNMEO(NativeArray<Entity> CLODEMIOBOI, ComponentDataFromEntity<SplinePointPositionData> FJCBPBDKGKE, ComponentDataFromEntity<SplinePointScaleData> EPEIHFMHFHN)
		{
			return default(GGMEFOFAIEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct CAADDMFLFGA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[OIHCMNACLNL]
	[AFAPMPFKDID(JCDEPCAPNFC.Lifecycle)]
	public class DestroyLocalObjects : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private ObjectNetworkToLocalMapService NDPGNEGOBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private ObjectLifecycleService CLKGBFAJPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private EntityQuery COCABHJDGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private EntityQuery BBGIIMOHPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private EntityQuery PMIKDNJLJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x2D18850", Offset = "0x2D17C50", VA = "0x182D18850", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x2D18650", Offset = "0x2D17A50", VA = "0x182D18650")]
		public bool OODLBMBKPMI(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x2D18700", Offset = "0x2D17B00", VA = "0x182D18700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x2D183E0", Offset = "0x2D177E0", VA = "0x182D183E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x2D18830", Offset = "0x2D17C30", VA = "0x182D18830", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x109EBA0", Offset = "0x109DFA0", VA = "0x18109EBA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x2D183E0", Offset = "0x2D177E0", VA = "0x182D183E0")]
		private void DKAEHEIKBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x2D181F0", Offset = "0x2D175F0", VA = "0x182D181F0")]
		private void ABKGEDPJLGF(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x2D182A0", Offset = "0x2D176A0", VA = "0x182D182A0")]
		private void BFMBDDCPEMJ(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x2D18540", Offset = "0x2D17940", VA = "0x182D18540")]
		private void EKCHPFJIDML(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x2D18420", Offset = "0x2D17820", VA = "0x182D18420")]
		private void EDGNJKOKGOJ(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static ADKBFPANNLM[] CIJNJLLMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private HDDOLPGOPCO FOHCMKDEKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private JFAKMNMKBKN CGILIOAKMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private PropertyDiffStateService EKBFNLBECOJ;

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x2C6EE40", Offset = "0x2C6E240", VA = "0x182C6EE40", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x2C6ED80", Offset = "0x2C6E180", VA = "0x182C6ED80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E7F0", Offset = "0x2C6DBF0", VA = "0x182C6E7F0")]
		private void KANOCOOMBAF(ADKBFPANNLM KADCGNDDIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private void DNFGEIKBLMA(Entity KCGBIDJFHLF, DLABIEOOCHD BBEIPJALHJO, HAKAHGDBIOD GPGIOJFGNNC, AMBIFMNOMBI OJLNGGLLGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[AFAPMPFKDID(JCDEPCAPNFC.Callbacks)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public sealed class PropertyEventCallbacks : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private PropertyEventCallbacksService INFFNKABNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private PropertyDiffStateService EKBFNLBECOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TransformOwnershipPhase KADCGNDDIGB;

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x2A55010", Offset = "0x2A54410", VA = "0x182A55010", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x2A54F40", Offset = "0x2A54340", VA = "0x182A54F40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.NetworkSend)]
	internal class TransmitNetworkDataSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private OOOBPOCGNJM IJCALMDFCEN;

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2BE0A30", Offset = "0x2BDFE30", VA = "0x182BE0A30", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE09E0", Offset = "0x2BDFDE0", VA = "0x182BE09E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[OIHCMNACLNL]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public class CalculateCullingBandChanges : HPFCFNHKHFD, EHPEJLPKBCA, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[BurstCompile]
		private struct DKGMBKJEOGL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[ReadOnly]
			public ArchetypeChunkEntityType DKALGDLIFCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> PKEGAPKGICE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			[WriteOnly]
			public NativeList<IIHOLKKFLMB>.ParallelWriter PFIELKAHPLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public ArchetypeChunkComponentType<DDJDCKIFIPM> FMKEJIHIEMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public float3 ENDGJBMJNDE;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private static readonly float4x2 CMEAKBHCPKK;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private static readonly float4x2 JBLKBJKKAJH;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			private static readonly int4x2 PKOKDDKBFLA;

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE880", Offset = "0x2BCDC80", VA = "0x182BCE880", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private static EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private const int CPMEFLJOJEB = 10;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private const double KLBNIHACOAA = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private EntityQuery ICMNEJNCPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private EntityQuery DCFOCDLMELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private double EAHDHFDPLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private CullingBandService NCPEBPJMCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TimeService KKACNFNCHOF;

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A7E0", Offset = "0x2D09BE0", VA = "0x182D0A7E0", Slot = "14")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AB60", Offset = "0x2D09F60", VA = "0x182D0AB60", Slot = "15")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A7F0", Offset = "0x2D09BF0", VA = "0x182D0A7F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A940", Offset = "0x2D09D40", VA = "0x182D0A940", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A770", Offset = "0x2D09B70", VA = "0x182D0A770")]
		private bool GBNKGJNLBPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A430", Offset = "0x2D09830", VA = "0x182D0A430")]
		private void AMFNPNEPAHA(EntityQuery KFGMFPAGHMA, float3 CPGENOICBJI, string JODEBEIHAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public struct IIHOLKKFLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public Entity KCGBIDJFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public KACHEPBJCJB ICBMMLPPJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public KACHEPBJCJB LPLBPOMCKIG;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class ProcessCullingBandChangeCallbacks : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private CullingBandService NCPEBPJMCAJ;

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x2A51B30", Offset = "0x2A50F30", VA = "0x182A51B30", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x2A51B10", Offset = "0x2A50F10", VA = "0x182A51B10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[AFAPMPFKDID(JCDEPCAPNFC.Connectables)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public class UpdateInertialProperties : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery KPCCFGDMCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private OCMKMDCPLBN BBMELFMFHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7550", Offset = "0x2BE6950", VA = "0x182BE7550", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7220", Offset = "0x2BE6620", VA = "0x182BE7220", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2BE72B0", Offset = "0x2BE66B0", VA = "0x182BE72B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[OIHCMNACLNL]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KAPFNNGNICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FFKKBKCAFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NKGIGPAKCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private KinematicSleepChangeService GIBONBBIDGN;

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E680", Offset = "0x2C6DA80", VA = "0x182C6E680", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E150", Offset = "0x2C6D550", VA = "0x182C6E150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D810", Offset = "0x2C6CC10", VA = "0x182C6D810")]
		private void IJLMKMFNJDB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BEOMDPHLMGK, EntityQueryDesc MAFGMLOJJCJ, bool MCFBEICDKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D920", Offset = "0x2C6CD20", VA = "0x182C6D920")]
		private void IJLMKMFNJDB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BEOMDPHLMGK, EntityQueryDesc MAFGMLOJJCJ, bool MCFBEICDKMP, bool CNBICOEGBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E3B0", Offset = "0x2C6D7B0", VA = "0x182C6E3B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DD80", Offset = "0x2C6D180", VA = "0x182C6DD80")]
		private void LBEKAGHMMIN(EntityQuery KFGMFPAGHMA, bool KJBPNOGLMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D600", Offset = "0x2C6CA00", VA = "0x182C6D600")]
		private void GLPBENDAPPJ(EntityQuery KFGMFPAGHMA, bool BNGAAEAOMAB, bool KJBPNOGLMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D230", Offset = "0x2C6C630", VA = "0x182C6D230")]
		private void CGGLMOGJBOD(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D490", Offset = "0x2C6C890", VA = "0x182C6D490")]
		private void DKGNGOAEFCL(NativeList<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DC60", Offset = "0x2C6D060", VA = "0x182C6DC60")]
		private void JNNENMOKIJD(NativeArray<Entity> IHPLCMEEOEJ, bool BNGAAEAOMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DA60", Offset = "0x2C6CE60", VA = "0x182C6DA60")]
		private NativeList<Entity> JNDBPDJHIJP(NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D450", Offset = "0x2C6C850", VA = "0x182C6D450")]
		private NativeList<Entity> DAEOBHANADM(NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E110", Offset = "0x2C6D510", VA = "0x182C6E110")]
		private NativeList<Entity> OIDCNMABGGD(NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DF70", Offset = "0x2C6D370", VA = "0x182C6DF70")]
		private NativeList<Entity> LLAHMHFPPNJ(NativeArray<Entity> IHPLCMEEOEJ, bool DLDJAFOIHFD)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D1A0", Offset = "0x2C6C5A0", VA = "0x182C6D1A0")]
		private HGNFKFGIIDH BEJNKLDHMGF(NativeArray<Entity> IHPLCMEEOEJ)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(HGNFKFGIIDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E720", Offset = "0x2C6DB20", VA = "0x182C6E720")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class ProcessKinematicSleepChangeCallbacks : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private KinematicSleepChangeService GIBONBBIDGN;

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2A51BA0", Offset = "0x2A50FA0", VA = "0x182A51BA0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2A51B80", Offset = "0x2A50F80", VA = "0x182A51B80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public class DebugSyncPropertiesFromUnityRigidbody : OPEENOIKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private static EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery DJAMOPBJJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private EntityQuery BJJHICHKBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private EntityQuery KJHNEADFBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private EntityQuery MEEBMOGBHLN;

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2D17E60", Offset = "0x2D17260", VA = "0x182D17E60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2D18020", Offset = "0x2D17420", VA = "0x182D18020", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2D17C20", Offset = "0x2D17020", VA = "0x182D17C20")]
		private void DIMENBIHELM(EntityQuery KFGMFPAGHMA, bool ANAIACKALCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2D179E0", Offset = "0x2D16DE0", VA = "0x182D179E0")]
		private void ADHGHHKMKKC(EntityQuery KFGMFPAGHMA, bool ANAIACKALCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	internal class AssignPlayerIdsSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public const string IICIIPEBIKA = "LocalPlayerScene";

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery NNHDHAIJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery HDOIJGOPKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private SceneService NBPMHEMDGJK;

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2D04780", Offset = "0x2D03B80", VA = "0x182D04780", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2D04650", Offset = "0x2D03A50", VA = "0x182D04650", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2D04760", Offset = "0x2D03B60", VA = "0x182D04760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2D041B0", Offset = "0x2D035B0", VA = "0x182D041B0")]
		private void NINIIPFAGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2D03E80", Offset = "0x2D03280", VA = "0x182D03E80")]
		private void EBGGOBOFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2D042C0", Offset = "0x2D036C0", VA = "0x182D042C0")]
		private void OMOJJFKONPD(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2D047F0", Offset = "0x2D03BF0", VA = "0x182D047F0")]
		private void PCJKPKADIKA(NativeArray<Entity> IHPLCMEEOEJ, int MAFDFKDMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2D03FF0", Offset = "0x2D033F0", VA = "0x182D03FF0")]
		private void ELCECFDMODK(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2D040F0", Offset = "0x2D034F0", VA = "0x182D040F0")]
		private void KOLMOEFHCKB(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void HLHNEDAPCDB(int CFFPFDDOHIM, Transform ENMFIMJMMCO, Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class MPKHKPDOFAN
{
	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x2A38B50", Offset = "0x2A37F50", VA = "0x182A38B50")]
	public static bool BNPDEHIGBJC(this SystemBase PEOBFOOAMDB, out Entity KCGBIDJFHLF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery GALNKCDJNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private GGGMMDNLNGG PHLMBCMNDPE;

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C3F0", Offset = "0x2D0B7F0", VA = "0x182D0C3F0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C2C0", Offset = "0x2D0B6C0", VA = "0x182D0C2C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C380", Offset = "0x2D0B780", VA = "0x182D0C380", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<LGAIJMKKHPE>, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private const string JEDOFAFMMPN = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private LNBCOHDPELB JJBACBOALNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery JDMGICAIOMN;

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private Entity MCOJJNJPJLI
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x2C86760", Offset = "0x2C85B60", VA = "0x182C86760")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C868B0", Offset = "0x2C85CB0", VA = "0x182C868B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		private Entity NMDAFJPEOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C86B90", Offset = "0x2C85F90", VA = "0x182C86B90")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public HOGBEFGIKOI KGFEIJPPOIA
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C86A90", Offset = "0x2C85E90", VA = "0x182C86A90")]
			get
			{
				return default(HOGBEFGIKOI);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C86B20", Offset = "0x2C85F20", VA = "0x182C86B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public HOGBEFGIKOI JNAOPOLNLCN
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0x2C86820", Offset = "0x2C85C20", VA = "0x182C86820")]
			get
			{
				return default(HOGBEFGIKOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C86FB0", Offset = "0x2C863B0", VA = "0x182C86FB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C870D0", Offset = "0x2C864D0", VA = "0x182C870D0", Slot = "15")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C87050", Offset = "0x2C86450", VA = "0x182C87050", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C86940", Offset = "0x2C85D40", VA = "0x182C86940", Slot = "14")]
		protected override void HFCGHGIECBJ(NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> ACJFOJBAJOC, NativeArray<Entity> BJLGEPGPKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C86E90", Offset = "0x2C86290", VA = "0x182C86E90")]
		private void OACGIHCNNNN(NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> BJLGEPGPKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C86BF0", Offset = "0x2C85FF0", VA = "0x182C86BF0")]
		private void MDILPIJPOIP(Entity KCGBIDJFHLF, Entity KJMHKGNOOPL, Entity FAEIACLNLCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BDF0", Offset = "0x2E4B1F0", VA = "0x182E4BDF0")]
		private bool DPPKACEDDDN<T>(out T PKODKJLGOIN) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BE80", Offset = "0x2E4B280", VA = "0x182E4BE80")]
		private void FCLBPALBBFJ<T>(T PKODKJLGOIN) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C867C0", Offset = "0x2C85BC0", VA = "0x182C867C0")]
		public bool AFPBHNGKAFC(HOGBEFGIKOI HDJBMDHODLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C86910", Offset = "0x2C85D10", VA = "0x182C86910")]
		private static bool HEENPBPGMNI(HOGBEFGIKOI ALACHPLLEKB, HOGBEFGIKOI MIFICLOCMHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C87190", Offset = "0x2C86590", VA = "0x182C87190")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C86F70", Offset = "0x2C86370", VA = "0x182C86F70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D14B10", Offset = "0x2D13F10", VA = "0x182D14B10", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D14620", Offset = "0x2D13A20", VA = "0x182D14620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D146C0", Offset = "0x2D13AC0", VA = "0x182D146C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D143C0", Offset = "0x2D137C0", VA = "0x182D143C0")]
		private NativeArray<Entity> BNJLPPDFLDL(int EFJDLDLIAEL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D14510", Offset = "0x2D13910", VA = "0x182D14510")]
		private void IFHJOAENKAE(NativeArray<Entity> HICCLEHNAME, NativeArray<Entity> MCGOOALJLNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class HideRemotePivotsNotInScope : HPFCFNHKHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private EntityQuery GOIMLPGFGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private EntityQuery LHNJIFNGECB;

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BF50", Offset = "0x2C7B350", VA = "0x182C7BF50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C040", Offset = "0x2C7B440", VA = "0x182C7C040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal static class FCPCBKOOGCI
{
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public const string BGBKPDJBHKO = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x27CAA10", Offset = "0x27C9E10", VA = "0x1827CAA10")]
	public static NativeArray<T> IPOINCNDEII<T>(NativeArray<Entity> IHPLCMEEOEJ, EntityManager KLFKJJDHNIL) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C71A00", Offset = "0x2C70E00", VA = "0x182C71A00")]
	public static void BJOKCADIAFD(EntityQuery KFGMFPAGHMA, EntityManager KLFKJJDHNIL, IANFCDGCLMD OMBDCMFHFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C71C70", Offset = "0x2C71070", VA = "0x182C71C70")]
	public static void OLMLBAIMGJK(NativeArray<Entity> HICCLEHNAME, IANFCDGCLMD OMBDCMFHFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C71B40", Offset = "0x2C70F40", VA = "0x182C71B40")]
	public static void EOJJOPDEMNM(NativeArray<Entity> HICCLEHNAME, IANFCDGCLMD OMBDCMFHFFN)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TransformService KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private ObjectLifecycleService CLKGBFAJPNJ;

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7140", Offset = "0x2BE6540", VA = "0x182BE7140", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7090", Offset = "0x2BE6490", VA = "0x182BE7090", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7130", Offset = "0x2BE6530", VA = "0x182BE7130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6770", Offset = "0x2BE5B70", VA = "0x182BE6770")]
		private void NKABDADFKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6F80", Offset = "0x2BE6380", VA = "0x182BE6F80")]
		private void NPCLHKOKMEB(NativeArray<Entity> HICCLEHNAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5EA0", Offset = "0x2BE52A0", VA = "0x182BE5EA0")]
		private void JPOLALPHANA(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BE57C0", Offset = "0x2BE4BC0", VA = "0x182BE57C0")]
		private void GDPBKACPOHK(NativeArray<Entity> MCGOOALJLNP, NativeArray<RigidTransform> EELLJNEBMNJ, NativeArray<RigidTransform> IBDHJNFKKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5A10", Offset = "0x2BE4E10", VA = "0x182BE5A10")]
		private void HAMPCPPHAON(NativeArray<RigidTransform> IBDHJNFKKNP, NativeArray<Entity> MCGOOALJLNP, NativeList<Entity> IBHAFKMLNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	internal class PostGameplayOnScopeChange : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery GALNKCDJNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private EntityQuery CELIEHJMNCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50340", Offset = "0x2A4F740", VA = "0x182A50340", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A50130", Offset = "0x2A4F530", VA = "0x182A50130", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A50280", Offset = "0x2A4F680", VA = "0x182A50280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A500C0", Offset = "0x2A4F4C0", VA = "0x182A500C0")]
		private void FBLJBHAFJEG(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	internal class PreventDisembodiedScopesSystem : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private EntityQuery MBKHCBHGEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private EntityHierarchyParents IKPELHJLNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private GGGMMDNLNGG PHLMBCMNDPE;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A51A30", Offset = "0x2A50E30", VA = "0x182A51A30", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A51980", Offset = "0x2A50D80", VA = "0x182A51980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A51A20", Offset = "0x2A50E20", VA = "0x182A51A20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A517F0", Offset = "0x2A50BF0", VA = "0x182A517F0")]
		private void MMGIMJGCACF(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<CIFDNFDBHAC>
	{
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD19F0", Offset = "0x2BD0DF0", VA = "0x182BD19F0", Slot = "14")]
		protected override void HFCGHGIECBJ(NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> ACJFOJBAJOC, NativeArray<Entity> BJLGEPGPKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1920", Offset = "0x2BD0D20", VA = "0x182BD1920")]
		[BurstCompile]
		private static void HFCGHGIECBJ(NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> BJLGEPGPKOK, ComponentDataFromEntity<global::HMOIPFDDKOA> KOOJJOGJKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1B80", Offset = "0x2BD0F80", VA = "0x182BD1B80")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1B40", Offset = "0x2BD0F40", VA = "0x182BD1B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[AFAPMPFKDID(JCDEPCAPNFC.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : HPFCFNHKHFD where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private EntityQuery OEHNHHBBMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private EntityQuery NADBDJJCOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private EntityQuery MJHPLABCPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery BMCEDAPPDFE;

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x3453EA0", Offset = "0x34532A0", VA = "0x183453EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x3454270", Offset = "0x3453670", VA = "0x183454270", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x3454240", Offset = "0x3453640", VA = "0x183454240", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x34525A0", Offset = "0x34519A0", VA = "0x1834525A0")]
		private void DPEJHCPBPPN(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x34536C0", Offset = "0x3452AC0", VA = "0x1834536C0")]
		private void LENLCCDHALG(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x3452E20", Offset = "0x3452220", VA = "0x183452E20")]
		private void JDPJNANIOBH(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void HFCGHGIECBJ(NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> ACJFOJBAJOC, NativeArray<Entity> BJLGEPGPKOK);

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x3454300", Offset = "0x3453700", VA = "0x183454300")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x27707D0", Offset = "0x276FBD0", VA = "0x1827707D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public sealed class PPPEJKALACD : HPFCFNHKHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private List<(EntityQuery, ComponentType)> BGHKBCNEBME;

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CA00", Offset = "0x2A4BE00", VA = "0x182A4CA00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CC00", Offset = "0x2A4C000", VA = "0x182A4CC00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CD50", Offset = "0x2A4C150", VA = "0x182A4CD50")]
	public PPPEJKALACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct MHJBJHOGLJI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public int JPEBDLEMFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public int JHIGGPANBBG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C882F0", Offset = "0x2C876F0", VA = "0x182C882F0")]
	public static Entity IGKGMCHPHKB(MHJBJHOGLJI HANEMGLFJMM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C882F0", Offset = "0x2C876F0", VA = "0x182C882F0")]
	public static MHJBJHOGLJI IGKGMCHPHKB(Entity KCGBIDJFHLF)
	{
		return default(MHJBJHOGLJI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct EOFMHHFCICE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public struct OHKGEEOIGMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public readonly ComponentType DHGPLCEACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public readonly NativeList<int> LBCJAENOALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public readonly NativeList<int> PHPFFLJAGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public readonly NativeArray<Entity> IHPLCMEEOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly NativeArray<Entity> BMDEPDLDBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public readonly NativeArray<byte> CKINCBHFECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public readonly NativeArray<byte> FOPIKDEMFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly int OAOCNAELCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly int FHEKGKCDDAF;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public bool ACOADPAOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C810", Offset = "0x2A3BC10", VA = "0x182A3C810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CAF0", Offset = "0x2A3BEF0", VA = "0x182A3CAF0")]
	public OHKGEEOIGMA(ComponentType DHGPLCEACKF, NativeList<int> LBCJAENOALC, NativeList<int> PHPFFLJAGAM, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> BMDEPDLDBHF, NativeArray<byte> CKINCBHFECF, NativeArray<byte> FOPIKDEMFDA, int OAOCNAELCIL, int FHEKGKCDDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C9C0", Offset = "0x2A3BDC0", VA = "0x182A3C9C0")]
	private DMCBBFPDIBM JJEGBFOPPMO(NativeArray<byte> CCKHAOABLMF, int PGFOAHEHPOH)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	private T JJEGBFOPPMO<T>(NativeArray<byte> CCKHAOABLMF, int PGFOAHEHPOH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C970", Offset = "0x2A3BD70", VA = "0x182A3C970")]
	public DMCBBFPDIBM HDAIGALHMOL(int PGFOAHEHPOH)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	public T HDAIGALHMOL<T>(int PGFOAHEHPOH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C7C0", Offset = "0x2A3BBC0", VA = "0x182A3C7C0")]
	public DMCBBFPDIBM ADHAHIACPHF(int PGFOAHEHPOH)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	public T ADHAHIACPHF<T>(int PGFOAHEHPOH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C890", Offset = "0x2A3BC90", VA = "0x182A3C890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public readonly struct IKABOPAFLEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<EAGGOJMLLPB> CKCKOLCCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly ComponentType DHGPLCEACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly int OAOCNAELCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly int FHEKGKCDDAF;

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C80BE0", Offset = "0x2C7FFE0", VA = "0x182C80BE0")]
	public IKABOPAFLEH(ComponentType DHGPLCEACKF, int OAOCNAELCIL, int FHEKGKCDDAF, EntityQuery KFGMFPAGHMA, NativeArray<EAGGOJMLLPB> CKCKOLCCJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C80B90", Offset = "0x2C7FF90", VA = "0x182C80B90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct AEJPEBLBNPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public int PGFOAHEHPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public int HEHGAIHDODB;

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
	public AEJPEBLBNPH(int PGFOAHEHPOH, int HEHGAIHDODB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public struct EAGGOJMLLPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly int MJMHIELCMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly int FOADGJOOFID;

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
	public EAGGOJMLLPB(int MJMHIELCMAL, int FOADGJOOFID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public struct AMBIFMNOMBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private readonly EKCDKOGIIEF FBDAFGPAOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private readonly int OAOCNAELCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private unsafe readonly byte* CKINCBHFECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private unsafe readonly byte* FOPIKDEMFDA;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2D01FF0", Offset = "0x2D013F0", VA = "0x182D01FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public EKCDKOGIIEF GDGOIHPFNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20")]
		get
		{
			return default(EKCDKOGIIEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x2D01F00", Offset = "0x2D01300", VA = "0x182D01F00")]
	public DMCBBFPDIBM DJKLHDJMOLL(Type NLAFPPIOFPG)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x2D02000", Offset = "0x2D01400", VA = "0x182D02000")]
	public DMCBBFPDIBM LGGLMAIBCDA(Type NLAFPPIOFPG)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x2829990", Offset = "0x2828D90", VA = "0x182829990")]
	public T DJKLHDJMOLL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x28299B0", Offset = "0x2828DB0", VA = "0x1828299B0")]
	public T LGGLMAIBCDA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x2D020F0", Offset = "0x2D014F0", VA = "0x182D020F0")]
	public unsafe AMBIFMNOMBI(EKCDKOGIIEF FBDAFGPAOAL, int FOADGJOOFID, byte* CKINCBHFECF, byte* FOPIKDEMFDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal abstract class GDEBFBMMJMA : KDNDLNICKKO, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private PropertyDiffStateService EKBFNLBECOJ;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected abstract ADKBFPANNLM GJIBMIOIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x2C74AB0", Offset = "0x2C73EB0", VA = "0x182C74AB0", Slot = "17")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x2C74A20", Offset = "0x2C73E20", VA = "0x182C74A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x2C747E0", Offset = "0x2C73BE0", VA = "0x182C747E0", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	protected GDEBFBMMJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public static class IJKCNKNEMAC
{
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] BNLFPCHOPNI;
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[DefaultMember("Item")]
internal class GLAOBBNBINF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly Dictionary<ComponentType, IKABOPAFLEH> EFLMONEFIII;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public IKABOPAFLEH BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2C787B0", Offset = "0x2C77BB0", VA = "0x182C787B0")]
		get
		{
			return default(IKABOPAFLEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2C78E90", Offset = "0x2C78290", VA = "0x182C78E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x2C79230", Offset = "0x2C78630", VA = "0x182C79230")]
	public GLAOBBNBINF(FGEHAOHAFDI LIDPFPMMNIM, EHNHFGEGKKP PDHCNHGCAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0x2C78F70", Offset = "0x2C78370", VA = "0x182C78F70")]
	public bool MLNCJCFKCNK(ComponentType DHGPLCEACKF, out IKABOPAFLEH APKCPEDKOCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0x2C78EE0", Offset = "0x2C782E0", VA = "0x182C78EE0")]
	public Dictionary<ComponentType, IKABOPAFLEH>.Enumerator IEHFBKOKLDF()
	{
		return default(Dictionary<ComponentType, IKABOPAFLEH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x2C788F0", Offset = "0x2C77CF0", VA = "0x182C788F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0x2C78A90", Offset = "0x2C77E90", VA = "0x182C78A90")]
	private void FHADLGPCFFO(IEnumerable<CHDKGPPIPOE> NMLEBLHLCBM, EntityManager KLFKJJDHNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0x2C78840", Offset = "0x2C77C40", VA = "0x182C78840")]
	private static int CHGFHGNAPFM(CHDKGPPIPOE LONDBJKEPFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x2C78FE0", Offset = "0x2C783E0", VA = "0x182C78FE0")]
	private static NativeArray<EAGGOJMLLPB> NCMNJOPKOEG(CHDKGPPIPOE LONDBJKEPFJ, Allocator NHNCCHNPCJI = Allocator.Persistent)
	{
		return default(NativeArray<EAGGOJMLLPB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal interface LIMLHMBKDHE
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	bool ACOADPAOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	World JAFDKOADMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJKEHBDLPKI(out NativeArray<int> LHKLNDCEBLM, Allocator NHNCCHNPCJI);

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LHKIELHLIPG(ComponentType DHGPLCEACKF, out OHKGEEOIGMA NEJINOAAOHF, out IKABOPAFLEH GLIPIAPKOKG);

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LHKIELHLIPG(ComponentType DHGPLCEACKF, out OHKGEEOIGMA NEJINOAAOHF);

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OHKGEEOIGMA FJCIHIIMLCK(ComponentType DHGPLCEACKF);

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OEEKGDMLMHL GDJPOLKAOEM();

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDFCMGEHACC(JobHandle KNAKGAMMCOC);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
internal interface MPOIHBOLOFN
{
	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	World JAFDKOADMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	GLAOBBNBINF LHJKPNCGOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	ICOKJDJNJLD KJKAAMAFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	NativeMultiHashMap<Entity, AMBIFMNOMBI> FNHBFIENGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	JobHandle KONDAJEHBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGKBIODLKGD();

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLOEIBCGJID();

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCPONLDLNBO(ComponentType DHGPLCEACKF, in OHKGEEOIGMA KJOLOKLIGGC);

	[Cpp2IlInjected.Token(Token = "0x600092A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HJKOABBLGEO(FFIHEMJDJJI CNEFMCCDIIL, out Entity LPLLOMCCPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct OEEKGDMLMHL
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public struct KGGHFCKPBGA : IEnumerator<AMBIFMNOMBI>, IEnumerator, IDisposable, IEnumerable<AMBIFMNOMBI>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private readonly NativeMultiHashMap<Entity, AMBIFMNOMBI> NACECODOGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private readonly Entity KCGBIDJFHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private NativeMultiHashMapIterator<Entity> DFNPGBIEIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private AMBIFMNOMBI FOPIKDEMFDA;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public AMBIFMNOMBI GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xD8CBD0", Offset = "0xD8BFD0", VA = "0x180D8CBD0", Slot = "4")]
			get
			{
				return default(AMBIFMNOMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x45C2AC0", Offset = "0x45C1EC0", VA = "0x1845C2AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x45C2B10", Offset = "0x45C1F10", VA = "0x1845C2B10")]
		internal KGGHFCKPBGA(NativeMultiHashMap<Entity, AMBIFMNOMBI> NACECODOGPA, Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x45C28B0", Offset = "0x45C1CB0", VA = "0x1845C28B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x45C2880", Offset = "0x45C1C80", VA = "0x1845C2880")]
		public KGGHFCKPBGA IEHFBKOKLDF()
		{
			return default(KGGHFCKPBGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x45C2980", Offset = "0x45C1D80", VA = "0x1845C2980", Slot = "9")]
		private IEnumerator<AMBIFMNOMBI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x45C2A20", Offset = "0x45C1E20", VA = "0x1845C2A20", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly MPOIHBOLOFN AGOKAPGFDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private readonly JobHandle MMKLHKMCDHL;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public int CCKONMNNCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C320", Offset = "0x2A3B720", VA = "0x182A3C320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C240", Offset = "0x2A3B640", VA = "0x182A3C240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4CB0", Offset = "0x1EC40B0", VA = "0x181EC4CB0")]
	public OEEKGDMLMHL(MPOIHBOLOFN AGOKAPGFDDL, JobHandle MMKLHKMCDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C410", Offset = "0x2A3B810", VA = "0x182A3C410")]
	public bool IAEJDENFAFO(Allocator NHNCCHNPCJI, out NativeKeyValueArrays<Entity, AMBIFMNOMBI> HNCBGLIPCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C550", Offset = "0x2A3B950", VA = "0x182A3C550")]
	public bool LFPJMFJAHGO(Allocator NHNCCHNPCJI, out (NativeArray<Entity> entities, int uniqueCount) HNCBGLIPCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C120", Offset = "0x2A3B520", VA = "0x182A3C120")]
	public KGGHFCKPBGA APLHLJMBDLB(Entity KCGBIDJFHLF)
	{
		return default(KGGHFCKPBGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[DefaultMember("Item")]
internal class ICOKJDJNJLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly List<IKABOPAFLEH> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public IKABOPAFLEH BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E400", Offset = "0x2C7D800", VA = "0x182C7E400")]
		get
		{
			return default(IKABOPAFLEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E910", Offset = "0x2C7DD10", VA = "0x182C7E910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E9D0", Offset = "0x2C7DDD0", VA = "0x182C7E9D0")]
	public ICOKJDJNJLD(GLAOBBNBINF EFLMONEFIII, FGEHAOHAFDI LIDPFPMMNIM, EHNHFGEGKKP PDHCNHGCAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E950", Offset = "0x2C7DD50", VA = "0x182C7E950")]
	public List<IKABOPAFLEH>.Enumerator IEHFBKOKLDF()
	{
		return default(List<IKABOPAFLEH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E490", Offset = "0x2C7D890", VA = "0x182C7E490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E600", Offset = "0x2C7DA00", VA = "0x182C7E600")]
	private void FHADLGPCFFO(GLAOBBNBINF EFLMONEFIII, EntityManager KLFKJJDHNIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal class ADLIBBBJLJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly ObjectInstantiationService EELIHJHFEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly global::OLKIDMOIAPH<CHDKGPPIPOE> ODDKNHMLCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly World HNOPBAGIJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private NativeHashMap<int, Entity> LADDLHIGNIF;

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x2CFEA40", Offset = "0x2CFDE40", VA = "0x182CFEA40")]
	public ADLIBBBJLJE(ObjectInstantiationService EELIHJHFEMH, FGEHAOHAFDI LIDPFPMMNIM, EHNHFGEGKKP PDHCNHGCAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD410", Offset = "0x2CFC810", VA = "0x182CFD410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD4E0", Offset = "0x2CFC8E0", VA = "0x182CFD4E0")]
	public bool HGHEDFHKJBL(FFIHEMJDJJI CNEFMCCDIIL, out Entity LPLLOMCCPLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2CFE3E0", Offset = "0x2CFD7E0", VA = "0x182CFE3E0")]
	private void PHLLKNNCMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2CFDEB0", Offset = "0x2CFD2B0", VA = "0x182CFDEB0")]
	private EntityArchetype OMFBJGDDNLK(EntityArchetype PLPGMOICCFP)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD9A0", Offset = "0x2CFCDA0", VA = "0x182CFD9A0")]
	public static void NAFCNDAAJHP(EntityManager ODHEKJGHFGE, EntityManager GENELGNIMGN, NativeArray<Entity> CMKPAMKPOPL, NativeArray<EntityArchetype> GMHGBBLHBNL, [Optional] NativeArray<Entity> OEGFJDGFPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD680", Offset = "0x2CFCA80", VA = "0x182CFD680")]
	[Conditional("DEBUG_BUILD")]
	private static void IAFJFLMOJGP(NativeArray<EntityArchetype> PHNLLMECBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD1D0", Offset = "0x2CFC5D0", VA = "0x182CFD1D0")]
	private static string CFGCCFPHEJG(EntityArchetype LKHIPKFNEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD540", Offset = "0x2CFC940", VA = "0x182CFD540")]
	[CompilerGenerated]
	internal static void HIIFAKMGBGJ(ref Span<ComponentType> NKDIEDNLMDL, ComponentType PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD7F0", Offset = "0x2CFCBF0", VA = "0x182CFD7F0")]
	[CompilerGenerated]
	internal static void MMLMJPMMKJF(Span<ComponentType> CCKHAOABLMF, ref Span<ComponentType> NKDIEDNLMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFDDD0", Offset = "0x2CFD1D0", VA = "0x182CFDDD0")]
	[CompilerGenerated]
	internal static void OBPIJLOBMKC(Span<ComponentType> CCKHAOABLMF, ref Span<ComponentType> NKDIEDNLMDL, ComponentType JNHKIIDIEEF)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[AFAPMPFKDID(JCDEPCAPNFC.PropertyChanges)]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld KLNEBEJPJPN;

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x2D03DC0", Offset = "0x2D031C0", VA = "0x182D03DC0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2D03D10", Offset = "0x2D03110", VA = "0x182D03D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[AlwaysUpdateSystem]
	[AFAPMPFKDID(JCDEPCAPNFC.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : HPFCFNHKHFD, OIOAOEDFDMG, BIJJPFLHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000147")]
		[BurstCompile]
		internal struct JLKONHNLPIJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			[ReadOnly]
			public NativeArray<byte> APNNGHBGJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			[ReadOnly]
			public NativeArray<byte> IPLPPAINIDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			[ReadOnly]
			public NativeArray<EAGGOJMLLPB> ONGMFGHDJHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			[WriteOnly]
			public NativeList<AEJPEBLBNPH>.ParallelWriter ANMJLDFFDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public int FOGONFFOPKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public int FLDJJIPMPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public ProfilerMarker AAHCMLFPEGI;

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0AE0", Offset = "0x2BCFEE0", VA = "0x182BD0AE0", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0A50", Offset = "0x2BCFE50", VA = "0x182BD0A50")]
			private unsafe int DFMOMKMFNOO(byte* NCOPNCOLEJN, byte* NDJEINDKPBB)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000148")]
		[BurstCompile]
		internal struct BFDOIMKJKJG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[WriteOnly]
			public NativeList<int> LBCJAENOALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[WriteOnly]
			public NativeList<int> CCEJKHIFMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeList<AEJPEBLBNPH> ONIGEBBMCKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public ProfilerMarker AAHCMLFPEGI;

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD6F0", Offset = "0x2BCCAF0", VA = "0x182BCD6F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000149")]
		[BurstCompile]
		internal struct PADINCLLCJN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			[WriteOnly]
			public NativeArray<byte> DCMMCJKGFBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			[ReadOnly]
			public EEFBLJMPCLJ OMJJFGNAHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public int OAOCNAELCIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public ProfilerMarker AAHCMLFPEGI;

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD15C0", Offset = "0x2BD09C0", VA = "0x182BD15C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200014A")]
		[BurstCompile]
		internal struct AIGKPDMNGPC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, AMBIFMNOMBI> OCHFABANPCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			[ReadOnly]
			public NativeArray<byte> CKINCBHFECF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[ReadOnly]
			public NativeArray<byte> FOPIKDEMFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public NativeArray<EAGGOJMLLPB> IGKHKKCIDEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			[ReadOnly]
			public NativeList<int> PHPFFLJAGAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			[ReadOnly]
			public NativeList<int> LBCJAENOALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int PADHFAMEIFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int FHEKGKCDDAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public ProfilerMarker AAHCMLFPEGI;

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD280", Offset = "0x2BCC680", VA = "0x182BCD280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private static readonly ProfilerMarker BCMIFLLLJNI;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker IGKDKOIGGKB;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private static readonly ProfilerMarker GBHFNKDEBLC;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private static readonly ProfilerMarker HOCPDMCIMHF;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private static readonly ProfilerMarker HJOEIFPDOPD;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private static readonly ProfilerMarker CJKDMKHFGHN;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly ProfilerMarker GMMEEKNNECA;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker LDDADKLPKJL;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker BHOBAPKAHHI;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker MPNDNAHPHLD;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker JHNAIOIAMGB;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker EAKNBDBLMKI;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker MFBNHGLEHJH;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker POCANCFKHFO;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker DAENCAFAHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private PropertyDiffStateService EKBFNLBECOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private EntityQuery CGCJGCFFJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private EntityQuery LMIAMINPIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private EntityQuery PMIKDNJLJDD;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		internal World JAFDKOADMMD
		{
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x2D0EB20", Offset = "0x2D0DF20", VA = "0x182D0EB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		private MPOIHBOLOFN KKGLFKPHOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x2D0DB30", Offset = "0x2D0CF30", VA = "0x182D0DB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F6F0", Offset = "0x2D0EAF0", VA = "0x182D0F6F0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "15")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F3F0", Offset = "0x2D0E7F0", VA = "0x182D0F3F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F5B0", Offset = "0x2D0E9B0", VA = "0x182D0F5B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F540", Offset = "0x2D0E940", VA = "0x182D0F540", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D450", Offset = "0x2D0C850", VA = "0x182D0D450")]
		private void DJCAKJCGODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E230", Offset = "0x2D0D630", VA = "0x182D0E230")]
		internal void JKEOIEDCFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E250", Offset = "0x2D0D650", VA = "0x182D0E250")]
		private void JKEOIEDCFEG(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DFF0", Offset = "0x2D0D3F0", VA = "0x182D0DFF0")]
		private void JFBEIKAEGKL(NativeArray<Entity> CMKPAMKPOPL, NativeArray<RRObjectPrefabData> KBFNLBOELEH, ref NativeArray<Entity> AGAHJNBMMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DB10", Offset = "0x2D0CF10", VA = "0x182D0DB10")]
		internal void DLKIEJKBEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D710", Offset = "0x2D0CB10", VA = "0x182D0D710")]
		private void DLKIEJKBEBM(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EC90", Offset = "0x2D0E090", VA = "0x182D0EC90")]
		internal void OJEAGEBAHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DB50", Offset = "0x2D0CF50", VA = "0x182D0DB50")]
		private void GKLECHEJGJD(MPOIHBOLOFN AGOKAPGFDDL, IKABOPAFLEH GLIPIAPKOKG, bool HGGIEBKEPOB, ref JobHandle IAAKFOGIOBB, ref JobHandle JDHFIPCOGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C620", Offset = "0x2D0BA20", VA = "0x182D0C620")]
		internal bool CGHLKMJJAIN(in IKABOPAFLEH NDJEINDKPBB, out JobHandle IICPGPKAIEH, out OHKGEEOIGMA LMEKCGFAFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C650", Offset = "0x2D0BA50", VA = "0x182D0C650")]
		private bool CGHLKMJJAIN(in IKABOPAFLEH NDJEINDKPBB, bool HGGIEBKEPOB, out JobHandle IICPGPKAIEH, out OHKGEEOIGMA LMEKCGFAFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DE30", Offset = "0x2D0D230", VA = "0x182D0DE30")]
		internal (NativeList<int>, NativeList<int>) HFLGPLBAGFG(NativeList<AEJPEBLBNPH> ONIGEBBMCKC, int OIKPPNLJGJL, JobHandle KOKJOGPCFAB, out JobHandle KNAKGAMMCOC, Allocator NHNCCHNPCJI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EBE0", Offset = "0x2D0DFE0", VA = "0x182D0EBE0")]
		internal static NativeArray<Entity> NDDKIPOLJOD(EntityQuery KFGMFPAGHMA, out JobHandle BIMILNBGGDA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C490", Offset = "0x2D0B890", VA = "0x182D0C490")]
		internal static NativeArray<byte> BDPCPBOJHMP(int OGILIIFBKAD, out JobHandle DKAPKAODBEL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C510", Offset = "0x2D0B910", VA = "0x182D0C510")]
		internal static NativeArray<byte> CGHJOHDJOFP(EntityQuery KFGMFPAGHMA, int IJKBMAIIDGK, out JobHandle DKAPKAODBEL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EA20", Offset = "0x2D0DE20", VA = "0x182D0EA20")]
		internal static NativeArray<Entity> KKAGAJEMDGO(EntityQuery KFGMFPAGHMA, out JobHandle NAKOAOBAEMO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D1E0", Offset = "0x2D0C5E0", VA = "0x182D0D1E0")]
		internal NativeArray<byte> DGAFEDELKNP(NativeArray<Entity> IHPLCMEEOEJ, IKABOPAFLEH GLIPIAPKOKG, JobHandle KOKJOGPCFAB, out JobHandle KNAKGAMMCOC, Allocator NHNCCHNPCJI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D050", Offset = "0x2D0C450", VA = "0x182D0D050")]
		internal JobHandle DFNANCJBPBC(in OHKGEEOIGMA HANEMGLFJMM, in IKABOPAFLEH GLIPIAPKOKG, NativeMultiHashMap<Entity, AMBIFMNOMBI> OCHFABANPCD, JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x2019490", Offset = "0x2018890", VA = "0x182019490")]
		private JobHandle MIICEBPBFOK(JobHandle MFJIBLMLBIC, JobHandle NPDCKLPICKP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x2019490", Offset = "0x2018890", VA = "0x182019490")]
		private JobHandle MIICEBPBFOK(JobHandle MFJIBLMLBIC, JobHandle NPDCKLPICKP, JobHandle GOJKLGHAFID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[AFAPMPFKDID(JCDEPCAPNFC.RenderEffects)]
	internal class PropagateHoverRootTag : NBALLIBJMND
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		public struct MLIOHBFNFBD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		protected override ComponentType BEALFJLDEJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0x2A523F0", Offset = "0x2A517F0", VA = "0x182A523F0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		protected override ComponentType ABPJDEPDJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x2A52390", Offset = "0x2A51790", VA = "0x182A52390", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		protected override ComponentType HGGELJLCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x2A523C0", Offset = "0x2A517C0", VA = "0x182A523C0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AA10", Offset = "0x2A39E10", VA = "0x182A3AA10")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[AFAPMPFKDID(JCDEPCAPNFC.RenderEffects)]
	internal class PropagateSelectionRootTag : NBALLIBJMND
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		public struct FPEIKDPIJNB : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		protected override ComponentType BEALFJLDEJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x2A52480", Offset = "0x2A51880", VA = "0x182A52480", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType ABPJDEPDJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0x2A52420", Offset = "0x2A51820", VA = "0x182A52420", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType HGGELJLCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0x2A52450", Offset = "0x2A51850", VA = "0x182A52450", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AA10", Offset = "0x2A39E10", VA = "0x182A3AA10")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[OIHCMNACLNL]
public class MPNAGFDKPNN : OPEENOIKAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x2A38BE0", Offset = "0x2A37FE0", VA = "0x182A38BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x2A38C70", Offset = "0x2A38070", VA = "0x182A38C70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public MPNAGFDKPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[OIHCMNACLNL]
public class BKNLPLNDDAN : OPEENOIKAJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct DIJECOAMNEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public DIJECOAMNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct BNMOABECHIH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		private struct HGGNNJAMLDF
		{
			[Cpp2IlInjected.Token(Token = "0x2000154")]
			[NoAlias]
			public struct OIMJKCBBHPF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000449")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400044A")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime FKJHGGDBLBG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> OFIKIBDBOOE;

			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0x45C1260", Offset = "0x45C0660", VA = "0x1845C1260")]
			public void MNDCOKLGGKE(BKNLPLNDDAN MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x45C11E0", Offset = "0x45C05E0", VA = "0x1845C11E0")]
			public OIMJKCBBHPF LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(OIMJKCBBHPF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public NativeList<Entity> FMJNBBOCACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private HGGNNJAMLDF HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HGGNNJAMLDF.OIMJKCBBHPF* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JJHLNKHGPKA;

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDAE0", Offset = "0x2BCCEE0", VA = "0x182BCDAE0")]
		internal void EMAOGODENHP(Entity KCGBIDJFHLF, SplinePointParentData EKDILHNEMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCB0", Offset = "0x2BCD0B0", VA = "0x182BCDCB0", Slot = "5")]
		public void ReadFromDisplayClass(ref DIJECOAMNEH GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCC0", Offset = "0x2BCD0C0", VA = "0x182BCDCC0", Slot = "6")]
		public void WriteToDisplayClass(ref DIJECOAMNEH GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDB50", Offset = "0x2BCCF50", VA = "0x182BCDB50", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDBC0", Offset = "0x2BCCFC0", VA = "0x182BCDBC0")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref HGGNNJAMLDF.OIMJKCBBHPF NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDC70", Offset = "0x2BCD070", VA = "0x182BCDC70")]
		public void MNDCOKLGGKE(BKNLPLNDDAN MJGELGPDDDE, ref DIJECOAMNEH GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDA70", Offset = "0x2BCCE70", VA = "0x182BCDA70")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private EntityQuery ILOOLOIIOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerMarker LFBELFDJONJ;

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x2D06440", Offset = "0x2D05840", VA = "0x182D06440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public BKNLPLNDDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x2D06210", Offset = "0x2D05610", VA = "0x182D06210", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x2D060B0", Offset = "0x2D054B0", VA = "0x182D060B0")]
	public static EntityQuery LBGGGMJMAAB(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[OIHCMNACLNL]
public class PLOAMKIMMPC : OPEENOIKAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery PNGBMEDCHHG;

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C8B0", Offset = "0x2A4BCB0", VA = "0x182A4C8B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C940", Offset = "0x2A4BD40", VA = "0x182A4C940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public PLOAMKIMMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[UpdateAfter(typeof(MPNAGFDKPNN))]
public class CBOAEOLFCHJ : HPFCFNHKHFD
{
	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2D09060", Offset = "0x2D08460", VA = "0x182D09060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public CBOAEOLFCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class HGODPMBCKMH : OPEENOIKAJM, OIOAOEDFDMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct PEPBHOBGEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public NativeHashMap<DLABIEOOCHD, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public PEPBHOBGEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MJIJEFMNCHN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015A")]
		private struct AABPAKGHMMB
		{
			[Cpp2IlInjected.Token(Token = "0x200015B")]
			public struct DJLMPCOLGGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000456")]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000457")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MOLGHIJFDND;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CNFANNPOKKK;

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0x45BD9C0", Offset = "0x45BCDC0", VA = "0x1845BD9C0")]
			public void MNDCOKLGGKE(HGODPMBCKMH MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0x45BD940", Offset = "0x45BCD40", VA = "0x1845BD940")]
			public DJLMPCOLGGP LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(DJLMPCOLGGP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public NativeHashMap<DLABIEOOCHD, Entity> NACECODOGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private AABPAKGHMMB HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AABPAKGHMMB.DJLMPCOLGGP* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x45C65A0", Offset = "0x45C59A0", VA = "0x1845C65A0")]
		internal void EMAOGODENHP(Entity KCGBIDJFHLF, ObjectNetworkIdComponentData KHDJIMPGCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADE380", Offset = "0x3ADD780", VA = "0x183ADE380", Slot = "5")]
		public void ReadFromDisplayClass(ref PEPBHOBGEND GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x23D4FC0", Offset = "0x23D43C0", VA = "0x1823D4FC0", Slot = "6")]
		public void WriteToDisplayClass(ref PEPBHOBGEND GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x45C6620", Offset = "0x45C5A20", VA = "0x1845C6620", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x45C66C0", Offset = "0x45C5AC0", VA = "0x1845C66C0")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref AABPAKGHMMB.DJLMPCOLGGP NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x45C6770", Offset = "0x45C5B70", VA = "0x1845C6770")]
		public void MNDCOKLGGKE(HGODPMBCKMH MJGELGPDDDE, ref PEPBHOBGEND GGIPLLJMCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x45C6530", Offset = "0x45C5930", VA = "0x1845C6530")]
		public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private ObjectNetworkToLocalMapService NDPGNEGOBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private EntityQuery ILOOLOIIOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private ProfilerMarker LFBELFDJONJ;

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B3C0", Offset = "0x2C7A7C0", VA = "0x182C7B3C0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B280", Offset = "0x2C7A680", VA = "0x182C7B280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public HGODPMBCKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B080", Offset = "0x2C7A480", VA = "0x182C7B080", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AF20", Offset = "0x2C7A320", VA = "0x182C7AF20")]
	public static EntityQuery LBGGGMJMAAB(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
public class CPCOFLFDBBD : OPEENOIKAJM, OIOAOEDFDMG
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AOOLKLGGKOM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct AGMAGLDBHDD
		{
			[Cpp2IlInjected.Token(Token = "0x200015F")]
			public struct LHLIPCFMDCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000461")]
				public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000462")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime FFJLLILBNNG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HAJELPEHHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> ENMEGNLJFEK;

			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0x45BDB80", Offset = "0x45BCF80", VA = "0x1845BDB80")]
			public void MNDCOKLGGKE(CPCOFLFDBBD MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x45BDB00", Offset = "0x45BCF00", VA = "0x1845BDB00")]
			public LHLIPCFMDCB LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
			{
				return default(LHLIPCFMDCB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CPCOFLFDBBD IANLPCJMBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private AGMAGLDBHDD HDANEGKBBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AGMAGLDBHDD.LHLIPCFMDCB* HODJFDOOGIO;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD570", Offset = "0x2BCC970", VA = "0x182BCD570")]
		public void EMAOGODENHP(Entity KCGBIDJFHLF, ParentData DCJFPKKADEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD590", Offset = "0x2BCC990", VA = "0x182BCD590", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD600", Offset = "0x2BCCA00", VA = "0x182BCD600")]
		public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref AGMAGLDBHDD.LHLIPCFMDCB NAEMAGOOGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD6B0", Offset = "0x2BCCAB0", VA = "0x182BCD6B0")]
		public void MNDCOKLGGKE(CPCOFLFDBBD MJGELGPDDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD500", Offset = "0x2BCC900", VA = "0x182BCD500")]
		public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private EntityQuery ILOOLOIIOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private ProfilerMarker LFBELFDJONJ;

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A3D0", Offset = "0x2D097D0", VA = "0x182D0A3D0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A2C0", Offset = "0x2D096C0", VA = "0x182D0A2C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public CPCOFLFDBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2D09ED0", Offset = "0x2D092D0", VA = "0x182D09ED0")]
	[CompilerGenerated]
	private void OPLKDJDMHDH(Entity KCGBIDJFHLF, ParentData DCJFPKKADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A0C0", Offset = "0x2D094C0", VA = "0x182D0A0C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2D09D70", Offset = "0x2D09170", VA = "0x182D09D70")]
	public static EntityQuery LBGGGMJMAAB(ComponentSystemBase MJGELGPDDDE)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
public class KOKBNOAAFDK : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private int LHDLBLKNMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private EntityQuery KFGMFPAGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private ObjectPrefabs EELIHJHFEMH;

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C84420", Offset = "0x2C83820", VA = "0x182C84420", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C84160", Offset = "0x2C83560", VA = "0x182C84160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C84240", Offset = "0x2C83640", VA = "0x182C84240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C83E10", Offset = "0x2C83210", VA = "0x182C83E10")]
	private void NBFFEHCBENC(Entity KCGBIDJFHLF, FFIHEMJDJJI CNEFMCCDIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public KOKBNOAAFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
	[UpdateBefore(typeof(KOKBNOAAFDK))]
	public class PostLoadAddSceneTagEntity : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private SceneService NBPMHEMDGJK;

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A505C0", Offset = "0x2A4F9C0", VA = "0x182A505C0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A50400", Offset = "0x2A4F800", VA = "0x182A50400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
	[KJKMMMHBKLF(BADKLKEFGCO.OMRoom)]
	public class PostLoadInitializeNetworkId : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		[CompilerGenerated]
		private struct CMJLEJPLLOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public NativeHashMap<DLABIEOOCHD, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
			public CMJLEJPLLOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000164")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct DKPFCPAOMGK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			private struct HHLGEBLGKKB
			{
				[Cpp2IlInjected.Token(Token = "0x2000166")]
				[NoAlias]
				public struct FIPAHLIICFE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000477")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000478")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime BNKLDBFEGLF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000479")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MOLGHIJFDND;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000474")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity HAJELPEHHBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000475")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex KAJFIJPPKMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000476")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CNFANNPOKKK;

				[Cpp2IlInjected.Token(Token = "0x60009D0")]
				[Cpp2IlInjected.Address(RVA = "0x45C1370", Offset = "0x45C0770", VA = "0x1845C1370")]
				public void MNDCOKLGGKE(PostLoadInitializeNetworkId MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009D1")]
				[Cpp2IlInjected.Address(RVA = "0x45C12C0", Offset = "0x45C06C0", VA = "0x1845C12C0")]
				public FIPAHLIICFE LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(FIPAHLIICFE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public NativeHashMap<DLABIEOOCHD, Entity> NACECODOGPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private HHLGEBLGKKB HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HHLGEBLGKKB.FIPAHLIICFE* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

			[Cpp2IlInjected.Token(Token = "0x4000473")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JJHLNKHGPKA;

			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x45BF460", Offset = "0x45BE860", VA = "0x1845BF460")]
			internal void EMAOGODENHP(Entity KCGBIDJFHLF, int BGGENBEAMFM, ref ObjectNetworkIdComponentData KHDJIMPGCBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0x3ADE380", Offset = "0x3ADD780", VA = "0x183ADE380", Slot = "5")]
			public void ReadFromDisplayClass(ref CMJLEJPLLOI GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0x23D4FC0", Offset = "0x23D43C0", VA = "0x1823D4FC0", Slot = "6")]
			public void WriteToDisplayClass(ref CMJLEJPLLOI GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0x45BF4F0", Offset = "0x45BE8F0", VA = "0x1845BF4F0", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0x45BF5E0", Offset = "0x45BE9E0", VA = "0x1845BF5E0")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref HHLGEBLGKKB.FIPAHLIICFE NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x45BF6B0", Offset = "0x45BEAB0", VA = "0x1845BF6B0")]
			public void MNDCOKLGGKE(PostLoadInitializeNetworkId MJGELGPDDDE, ref CMJLEJPLLOI GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x45BF3F0", Offset = "0x45BE7F0", VA = "0x1845BF3F0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		[GPKJCAPOIDC]
		private ObjectNetworkToLocalMapService NDPGNEGOBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[GPKJCAPOIDC]
		private SceneService KGBHFHAMEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private EntityQuery KFGMFPAGHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private EntityQuery MJEIKBAOFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private ProfilerMarker PAFDGKGLHHH;

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A513B0", Offset = "0x2A507B0", VA = "0x182A513B0", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A51310", Offset = "0x2A50710", VA = "0x182A51310", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A508C0", Offset = "0x2A4FCC0", VA = "0x182A508C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A508C0", Offset = "0x2A4FCC0", VA = "0x182A508C0")]
		public void DCDENAGNDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A50990", Offset = "0x2A4FD90", VA = "0x182A50990")]
		private void JDMGFKJKJMB(NativeHashMap<DLABIEOOCHD, Entity> NACECODOGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50660", Offset = "0x2A4FA60", VA = "0x182A50660")]
		private void AALMFBDBPMP(NativeHashMap<DLABIEOOCHD, Entity> NACECODOGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A51080", Offset = "0x2A50480", VA = "0x182A51080", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A50EE0", Offset = "0x2A502E0", VA = "0x182A50EE0")]
		public static EntityQuery OKLCDIHMHJF(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class KLPAIMFABCK : HPFCFNHKHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private EntityQuery LNKAHLADFBN;

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C83B80", Offset = "0x2C82F80", VA = "0x182C83B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C83C10", Offset = "0x2C83010", VA = "0x182C83C10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public KLPAIMFABCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public class BAHJDIDPNFF : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private global::OLKIDMOIAPH<BLKKLCOOGHJ> CDIFMHGGMEA;

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D056F0", Offset = "0x2D04AF0", VA = "0x182D056F0", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D053F0", Offset = "0x2D047F0", VA = "0x182D053F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D05260", Offset = "0x2D04660", VA = "0x182D05260")]
	private void OKBEMPDJBAJ(NativeList<EntityArchetype> PHNLLMECBAK, NativeHashMap<int, KMBCDIKKHFF> PBAEGNJPPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D05120", Offset = "0x2D04520", VA = "0x182D05120")]
	private Span<int> NLCJAICPBJA(EntityArchetype LKHIPKFNEGI)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D05050", Offset = "0x2D04450", VA = "0x182D05050")]
	private bool FNFALAJHGGP(int IJKBMAIIDGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D04A50", Offset = "0x2D03E50", VA = "0x182D04A50")]
	private void BILPLDHPOPD(NativeHashMap<int, KMBCDIKKHFF> PBAEGNJPPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public BAHJDIDPNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization)]
	public class PreSerializeRemoveEntities : HPFCFNHKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private static EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private EntityQuery MHEKLOHNCIN;

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A51470", Offset = "0x2A50870", VA = "0x182A51470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A516F0", Offset = "0x2A50AF0", VA = "0x182A516F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[AFAPMPFKDID(JCDEPCAPNFC.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[CompilerGenerated]
		private struct BCLENGKJGBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public EEFBLJMPCLJ dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
			public BCLENGKJGBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE620", Offset = "0x2BCDA20", VA = "0x182BCE620")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct FFMBOPGADHF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			[ReadOnly]
			public NativeList<int> LBCJAENOALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[ReadOnly]
			public NativeArray<Entity> BMDEPDLDBHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public EEFBLJMPCLJ FGMICBEFEKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			[ReadOnly]
			public NativeArray<byte> FOPIKDEMFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int OAOCNAELCIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public ComponentType DHGPLCEACKF;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x45C0740", Offset = "0x45BFB40", VA = "0x1845C0740")]
			internal void EMAOGODENHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x45C0930", Offset = "0x45BFD30", VA = "0x1845C0930", Slot = "5")]
			public void ReadFromDisplayClass(ref BCLENGKJGBG GGIPLLJMCBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x45C0900", Offset = "0x45BFD00", VA = "0x1845C0900", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x45C0910", Offset = "0x45BFD10", VA = "0x1845C0910")]
			public void MNDCOKLGGKE(ShadowWorldApplyPropertyDifferencesToShadowWorld MJGELGPDDDE, ref BCLENGKJGBG GGIPLLJMCBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private PropertyDiffStateService EKBFNLBECOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private JobHandle APAGEAHMFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private JobHandle LMPNOELEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private LIMLHMBKDHE AGOKAPGFDDL;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7D30", Offset = "0x2BD7130", VA = "0x182BD7D30", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7950", Offset = "0x2BD6D50", VA = "0x182BD7950")]
		public JobHandle MBKBGOKPNNM(JobHandle KOKJOGPCFAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7990", Offset = "0x2BD6D90", VA = "0x182BD7990", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7640", Offset = "0x2BD6A40", VA = "0x182BD7640")]
		private bool AADAEHNIBMH(JobHandle KOKJOGPCFAB, int IJKBMAIIDGK, out JobHandle PCLAACGDLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[ExecuteAlways]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(MCCDCLBDPKF))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal sealed class NIIHMMNGLOL : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B710", Offset = "0x2A3AB10", VA = "0x182A3B710", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public NIIHMMNGLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[ExecuteAlways]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(EEOOCNPEGJD))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal sealed class DLILNFMMGKG : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D16760", Offset = "0x2D15B60", VA = "0x182D16760", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public DLILNFMMGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[NEKKAFLHHJJ]
[ExecuteAlways]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
[UpdateInGroup(typeof(KIJJKOCHGBB))]
internal sealed class NBDCKMCKANM : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AA50", Offset = "0x2A39E50", VA = "0x182A3AA50", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public NBDCKMCKANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[NEKKAFLHHJJ]
[ExecuteAlways]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
[UpdateInGroup(typeof(KGOCGONGAKM))]
internal sealed class FPLMJBEGKKH : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C74140", Offset = "0x2C73540", VA = "0x182C74140", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public FPLMJBEGKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal class GMKDHGGKMOF : GDEBFBMMJMA
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected override ADKBFPANNLM GJIBMIOIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x693AA0", Offset = "0x692EA0", VA = "0x180693AA0", Slot = "18")]
		get
		{
			return default(ADKBFPANNLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public GMKDHGGKMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[NEKKAFLHHJJ]
[ExecuteAlways]
[UpdateInGroup(typeof(KFJMOJFBOLO))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal sealed class IOLICAPBNJH : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C81450", Offset = "0x2C80850", VA = "0x182C81450", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public IOLICAPBNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal class ENIDEFBOEEE : HIEMLNGKCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public ENIDEFBOEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal class IBBDLICCFAF : GDEBFBMMJMA
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	protected override ADKBFPANNLM GJIBMIOIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "18")]
		get
		{
			return default(ADKBFPANNLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public IBBDLICCFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[ExecuteAlways]
[NEKKAFLHHJJ]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
[UpdateInGroup(typeof(MEGNHAFEFAA))]
internal sealed class FIJAGKBFCPI : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2C71EA0", Offset = "0x2C712A0", VA = "0x182C71EA0", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public FIJAGKBFCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal class GMNFPAGFDGD : HIEMLNGKCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public GMNFPAGFDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class KNCJFFHLGFB : HIEMLNGKCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public KNCJFFHLGFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public class LCMOLHEBKDF : HPFCFNHKHFD
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public LCMOLHEBKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[OIHCMNACLNL]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public class IMIHBOLKJDG : HPFCFNHKHFD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private TimeService KKACNFNCHOF;

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x2C81400", Offset = "0x2C80800", VA = "0x182C81400", Slot = "14")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2C813E0", Offset = "0x2C807E0", VA = "0x182C813E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public IMIHBOLKJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	public class CopyTransformDataFromGameObjects : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x200017B")]
		[BurstCompile]
		private struct FGHILFMKPLN : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private const float PHPPAKCGMNA = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> AOAMJCFGHFD;

			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCF060", Offset = "0x2BCE460", VA = "0x182BCF060", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCF290", Offset = "0x2BCE690", VA = "0x182BCF290")]
			private bool LDLLEAEKLHK(float3 LPLBPOMCKIG, float3 ICBMMLPPJIN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0x2BCF220", Offset = "0x2BCE620", VA = "0x182BCF220")]
			private bool GNGGCEKGAHC(quaternion LPLBPOMCKIG, quaternion ICBMMLPPJIN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[BurstCompile]
		private struct KDDLAJBMFBI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> BLHFFOFBGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> PLHMCCHMDOJ;

			[Cpp2IlInjected.Token(Token = "0x6000A20")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0F30", Offset = "0x2BD0330", VA = "0x182BD0F30", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private const string MIGEDKMGNPC = "Pose";

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private const string EJMBAKEEFPA = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private const string GAGIKAMLIBI = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private static readonly EHNHFGEGKKP GCCNHBBFBBO;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private static readonly EHNHFGEGKKP HCICJPEFJME;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static readonly EHNHFGEGKKP IKCKJJCGHLK;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly ProfilerMarker BKLHIEFOAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private NJEAPIHJKLF OAGBGJOEMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x2D12A70", Offset = "0x2D11E70", VA = "0x182D12A70", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x2D126D0", Offset = "0x2D11AD0", VA = "0x182D126D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x2D12700", Offset = "0x2D11B00", VA = "0x182D12700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing)]
	public class RegisterTransforms : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x200017F")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct FFAOGIIJMDP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000180")]
			private struct NDHDNOEMBGI
			{
				[Cpp2IlInjected.Token(Token = "0x2000181")]
				public struct MNECLGDAFPD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B3")]
					public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B4")]
					public LambdaParameterValueProvider_IComponentData<EGEDBOODONB>.Runtime DHEDBALEJCB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B5")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime GCBJFEFKFLK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B0")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HAJELPEHHBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B1")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<EGEDBOODONB> OCJHKNHMFAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> LMOECPJAAGK;

				[Cpp2IlInjected.Token(Token = "0x6000A3B")]
				[Cpp2IlInjected.Address(RVA = "0x45C68C0", Offset = "0x45C5CC0", VA = "0x1845C68C0")]
				public void MNDCOKLGGKE(RegisterTransforms MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A3C")]
				[Cpp2IlInjected.Address(RVA = "0x45C6800", Offset = "0x45C5C00", VA = "0x1845C6800")]
				public MNECLGDAFPD LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(MNECLGDAFPD);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private NDHDNOEMBGI HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NDHDNOEMBGI.MNECLGDAFPD* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate NOELODDBADO;

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x45C0460", Offset = "0x45BF860", VA = "0x1845C0460")]
			internal void EMAOGODENHP(Entity KCGBIDJFHLF, EGEDBOODONB EFDMFNHPCPL, Transform ENMFIMJMMCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x45C0560", Offset = "0x45BF960", VA = "0x1845C0560", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x45C0650", Offset = "0x45BFA50", VA = "0x1845C0650")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, ref NDHDNOEMBGI.MNECLGDAFPD NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x45C0730", Offset = "0x45BFB30", VA = "0x1845C0730")]
			public void MNDCOKLGGKE(RegisterTransforms MJGELGPDDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0x45C03F0", Offset = "0x45BF7F0", VA = "0x1845C03F0")]
			public unsafe static void EGDPKLLPODG(ArchetypeChunkIterator* IHFAICIBBKI, void* IJJLHLHPAFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000182")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct BCFECKNMLHH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000183")]
			private struct ACCOBLHFJBA
			{
				[Cpp2IlInjected.Token(Token = "0x2000184")]
				[NoAlias]
				public struct PJJICLPCCDP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BA")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ACMCEFAPNGA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BB")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<EGEDBOODONB>.Runtime DHEDBALEJCB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity HAJELPEHHBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B9")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<EGEDBOODONB> OCJHKNHMFAE;

				[Cpp2IlInjected.Token(Token = "0x6000A41")]
				[Cpp2IlInjected.Address(RVA = "0x45BDAA0", Offset = "0x45BCEA0", VA = "0x1845BDAA0")]
				public void MNDCOKLGGKE(RegisterTransforms MJGELGPDDDE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A42")]
				[Cpp2IlInjected.Address(RVA = "0x45BDA20", Offset = "0x45BCE20", VA = "0x1845BDA20")]
				public PJJICLPCCDP LJMADNOCPHP(ref ArchetypeChunk LAFAIEJDGAB, int LFJDENJIFKD, int BDKFJFNAGOA)
				{
					return default(PJJICLPCCDP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			private ACCOBLHFJBA HDANEGKBBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ACCOBLHFJBA.PJJICLPCCDP* HODJFDOOGIO;

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x45BE2A0", Offset = "0x45BD6A0", VA = "0x1845BE2A0")]
			internal void EMAOGODENHP(Entity KCGBIDJFHLF, EGEDBOODONB EFDMFNHPCPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0x45BE380", Offset = "0x45BD780", VA = "0x1845BE380", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x45BE410", Offset = "0x45BD810", VA = "0x1845BE410")]
			public void HGCIIMFHKCN(ref ArchetypeChunk LDKMHEJBNPK, [NoAlias] ref ACCOBLHFJBA.PJJICLPCCDP NAEMAGOOGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x45BDAA0", Offset = "0x45BCEA0", VA = "0x1845BDAA0")]
			public void MNDCOKLGGKE(RegisterTransforms MJGELGPDDDE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private NJEAPIHJKLF OAGBGJOEMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private EntityQuery KBPAMFPAGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private EntityQuery OHCJHADDPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private EntityQuery NGMAFGKOBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private EntityQuery LOCCPPEEMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery MAGIGGCGIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private ProfilerMarker FGKMEFBEPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery LPDAFOADPDK;

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2A59760", Offset = "0x2A58B60", VA = "0x182A59760", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2A59480", Offset = "0x2A58880", VA = "0x182A59480", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2A59690", Offset = "0x2A58A90", VA = "0x182A59690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2A58630", Offset = "0x2A57A30", VA = "0x182A58630")]
		private void FIEPHECDCBK(EntityQuery KFGMFPAGHMA, MELNNNHAMLB LEEPDBNBCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x2A597B0", Offset = "0x2A58BB0", VA = "0x182A597B0")]
		private void PDFCEFHHLIG(EntityQuery KFGMFPAGHMA, MELNNNHAMLB LEEPDBNBCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x2A59630", Offset = "0x2A58A30", VA = "0x182A59630", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2A58B80", Offset = "0x2A57F80", VA = "0x182A58B80")]
		private void GMBACGLDOLC(NativeArray<Entity> IHPLCMEEOEJ, MELNNNHAMLB LEEPDBNBCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2A58870", Offset = "0x2A57C70", VA = "0x182A58870")]
		[BurstCompile]
		internal static void GIJJHMLFCMD(NativeArray<EGEDBOODONB> DKCPGNMBDPH, ComponentDataFromEntity<EGEDBOODONB> IBHAJKCBAOK, MELNNNHAMLB LEEPDBNBCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void LOCFLNMICLD(Transform ENMFIMJMMCO, Entity KCGBIDJFHLF, int PGFOAHEHPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void JBGALJBPEDL(Entity KCGBIDJFHLF, int PGFOAHEHPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void ACMCKKKPAAD(int PGFOAHEHPOH, MELNNNHAMLB LEEPDBNBCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x2A59030", Offset = "0x2A58430", VA = "0x182A59030")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void KIJLJGHJIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2A59210", Offset = "0x2A58610", VA = "0x182A59210", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x2A58E90", Offset = "0x2A58290", VA = "0x182A58E90")]
		public static EntityQuery INPGCIHIADP(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x2A58CC0", Offset = "0x2A580C0", VA = "0x182A58CC0")]
		public static EntityQuery GNHHLFBBKBP(ComponentSystemBase MJGELGPDDDE)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : HPFCFNHKHFD, OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct CDHGFNPDOHD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> AOAMJCFGHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE540", Offset = "0x2BCD940", VA = "0x182BCE540", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[BurstCompile]
		private struct FAFCDKLAMGI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BLHFFOFBGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2BCEFC0", Offset = "0x2BCE3C0", VA = "0x182BCEFC0", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct KAJDNPFICOJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BLHFFOFBGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> PLHMCCHMDOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public NativeArray<Entity> IHPLCMEEOEJ;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0E30", Offset = "0x2BD0230", VA = "0x182BD0E30", Slot = "4")]
			public void Execute(int PGFOAHEHPOH, TransformAccess ENMFIMJMMCO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private const string MIGEDKMGNPC = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private const string EJMBAKEEFPA = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private const string GAGIKAMLIBI = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly EHNHFGEGKKP GCCNHBBFBBO;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly EHNHFGEGKKP HCICJPEFJME;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly EHNHFGEGKKP IKCKJJCGHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private NJEAPIHJKLF OAGBGJOEMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private EntityQuery PLFOGKBOFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery KCKKNOLDHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery LAMNANELKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private TransformAccessArray ALAPHAOEHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray BKHBDGJPIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray PHJLAOBNMMA;

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x2D13870", Offset = "0x2D12C70", VA = "0x182D13870", Slot = "14")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x2D12DA0", Offset = "0x2D121A0", VA = "0x182D12DA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2D12F90", Offset = "0x2D12390", VA = "0x182D12F90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2D13020", Offset = "0x2D12420", VA = "0x182D13020", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2D13050", Offset = "0x2D12450", VA = "0x182D13050", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2D12C20", Offset = "0x2D12020", VA = "0x182D12C20")]
		private NativeArray<Entity> OMHJEINGHJN(NativeArray<EGEDBOODONB> LBCJAENOALC, NativeList<Entity> CMKPAMKPOPL, TransformAccessArray OMPHLGCKILB, TransformAccessArray ILJPIKOMLPB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : HPFCFNHKHFD, BIJJPFLHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private PKKNALEKOHF MKMDDACMGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private AFANFAEGBHI JGOACJAEEPK;

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x2A51A20", Offset = "0x2A50E20", VA = "0x182A51A20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x2D13AE0", Offset = "0x2D12EE0", VA = "0x182D13AE0", Slot = "14")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x2D13C90", Offset = "0x2D13090", VA = "0x182D13C90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x2D139D0", Offset = "0x2D12DD0", VA = "0x182D139D0")]
		private static void CGMCGOOEMOH(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF, Entity BLENCGKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x2D13BF0", Offset = "0x2D12FF0", VA = "0x182D13BF0")]
		private static Transform OBIOFHAKCKC(EntityManager KLFKJJDHNIL, Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[AFAPMPFKDID(JCDEPCAPNFC.TransformSyncing)]
	public class L2PToL2WHierarchy : HPFCFNHKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		[BurstCompile]
		private struct LCLCEAGDDOI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> FGCJPCDEPKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> LKILKEOJBOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> FOEDGHHJFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> LBNJBDKJMJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			public ArchetypeChunkComponentType<LocalToWorldData> IMHDOPDMCEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> DPOIHJPKPLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			public uint IIKLADPIEOI;

			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x45C3580", Offset = "0x45C2980", VA = "0x1845C3580")]
			[Conditional("DEBUG_BUILD")]
			private void BIEKIMPAKLM(Entity KCGBIDJFHLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x45C3650", Offset = "0x45C2A50", VA = "0x1845C3650", Slot = "4")]
			public void Execute(ArchetypeChunk LDKMHEJBNPK, int PGFOAHEHPOH, int KPOOHJBBLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x45C3940", Offset = "0x45C2D40", VA = "0x1845C3940")]
			private void JHGJPJMIFII(float4x4 GAEAGIKANJA, Entity KCGBIDJFHLF, bool CPJBIJDBDIK, int KJKHPEKCAGF = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private EntityQuery KJMHLJJBJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery OPGPDMDNHEF;

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x2C85BB0", Offset = "0x2C84FB0", VA = "0x182C85BB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x2C85CD0", Offset = "0x2C850D0", VA = "0x182C85CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class APPCEHAHNHI : DJAAOLBJGHI
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[BurstCompile]
	private struct EBBHAHFHOFP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> FGCJPCDEPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public ArchetypeChunkComponentType<LocalToWorldData> IMHDOPDMCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public uint IIKLADPIEOI;

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEE40", Offset = "0x2BCE240", VA = "0x182BCEE40", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int PGFOAHEHPOH, int KPOOHJBBLEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEF40", Offset = "0x2BCE340", VA = "0x182BCEF40")]
		public bool GIHPAKJHIHP(ArchetypeChunk LDKMHEJBNPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private EntityQuery KJMHLJJBJPF;

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2D02C50", Offset = "0x2D02050", VA = "0x182D02C50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x2D02D80", Offset = "0x2D02180", VA = "0x182D02D80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AAGBILOJELN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public APPCEHAHNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public class GCLGMOFFEKM : DJAAOLBJGHI
{
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[BurstCompile]
	private struct FLKFLMNHNDI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> CAICCJDDEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public ArchetypeChunkComponentType<WorldPoseData> MAEONHAGGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> AGKGHANNPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> CGDAGJBNOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public uint IIKLADPIEOI;

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF2D0", Offset = "0x2BCE6D0", VA = "0x182BCF2D0", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int PGFOAHEHPOH, int KPOOHJBBLEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF680", Offset = "0x2BCEA80", VA = "0x182BCF680")]
		public bool GIHPAKJHIHP(ArchetypeChunk LDKMHEJBNPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private EntityQuery KPJDOIFOFHA;

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2C74560", Offset = "0x2C73960", VA = "0x182C74560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x2C74670", Offset = "0x2C73A70", VA = "0x182C74670", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AAGBILOJELN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public GCLGMOFFEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class DFOJJMKJMKE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[BurstCompile]
	private struct FMGAIKECDNH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> OBFBFNEANNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> KDIKEHLAHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> OEOLHGENJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public ArchetypeChunkComponentType<LocalToParentData> JDHIFHLJPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public uint IIKLADPIEOI;

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF700", Offset = "0x2BCEB00", VA = "0x182BCF700", Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int PGFOAHEHPOH, int KPOOHJBBLEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFE10", Offset = "0x2BCF210", VA = "0x182BCFE10")]
		public bool GIHPAKJHIHP(ArchetypeChunk LDKMHEJBNPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private EntityQuery KPJDOIFOFHA;

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2D161A0", Offset = "0x2D155A0", VA = "0x182D161A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2D162D0", Offset = "0x2D156D0", VA = "0x182D162D0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AAGBILOJELN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	public DFOJJMKJMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[AFAPMPFKDID(JCDEPCAPNFC.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : NBALLIBJMND
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		public struct IFLIBMGGNCH : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType BEALFJLDEJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0x2A52510", Offset = "0x2A51910", VA = "0x182A52510", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType ABPJDEPDJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0x2A524B0", Offset = "0x2A518B0", VA = "0x182A524B0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType HGGELJLCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x2A524E0", Offset = "0x2A518E0", VA = "0x182A524E0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AA10", Offset = "0x2A39E10", VA = "0x182A3AA10")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[FICPFKAKBGH(OFJLJDAKPIJ.Game)]
public class CHAGCDCLPBJ : IHDBFJONIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Type KHHNIJJCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x2D09690", Offset = "0x2D08A90", VA = "0x182D09690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Type[] ANGNAOEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x2D09700", Offset = "0x2D08B00", VA = "0x182D09700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public CHAGCDCLPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[FICPFKAKBGH(OFJLJDAKPIJ.Loading)]
public class LPJNLAAJIAD : IHDBFJONIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Type KHHNIJJCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Type[] ANGNAOEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2C86670", Offset = "0x2C85A70", VA = "0x182C86670", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LPJNLAAJIAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public sealed class JGHMKHADJEJ : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x2C824E0", Offset = "0x2C818E0", VA = "0x182C824E0", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public JGHMKHADJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[FICPFKAKBGH(OFJLJDAKPIJ.Saving)]
public class KGJLHBLLCLK : IHDBFJONIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type KHHNIJJCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] ANGNAOEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x2C83A90", Offset = "0x2C82E90", VA = "0x182C83A90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public KGJLHBLLCLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public sealed class MJNKPIPBNFH : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x2C883F0", Offset = "0x2C877F0", VA = "0x182C883F0", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public MJNKPIPBNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[FICPFKAKBGH(OFJLJDAKPIJ.Simulation)]
public class LHBLLIOEAPO : IHDBFJONIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type KHHNIJJCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2C86100", Offset = "0x2C85500", VA = "0x182C86100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] ANGNAOEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2C86170", Offset = "0x2C85570", VA = "0x182C86170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LHBLLIOEAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[BGGFAGPLFND(typeof(HLDNGDJOHDJ), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
internal class HLDNGDJOHDJ : BIJJPFLHCDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private global::CAJGNEAMAMB<AuthoredParentData, NEJHAMPOPML, BKLOPJPPHED, AuthoredChildrenData> PKNHBIAMMNG;

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B570", Offset = "0x2C7A970", VA = "0x182C7B570", Slot = "4")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public HLDNGDJOHDJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BGGFAGPLFND(typeof(EntityHierarchyParents), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.HierarchySystems)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class EntityHierarchyParents : OIOAOEDFDMG, BIJJPFLHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		[GPKJCAPOIDC]
		private GGDOJMIIODJ KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[GPKJCAPOIDC]
		private PropertyChangeNetworkRouter PDOEMANMJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private global::KIABHJONBDN<Entity> GIOGLFNEEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::CAJGNEAMAMB<ParentData, LGMDCDJDGBF, BHBCICILJNI, ChildrenData> PKNHBIAMMNG;

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F3B0", Offset = "0x2C6E7B0", VA = "0x182C6F3B0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6EF80", Offset = "0x2C6E380", VA = "0x182C6EF80", Slot = "5")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F300", Offset = "0x2C6E700", VA = "0x182C6F300")]
		public Entity LKJHOOBEPGJ(Entity KCGBIDJFHLF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F350", Offset = "0x2C6E750", VA = "0x182C6F350")]
		public bool MCIAKNOLHHF(Entity KCGBIDJFHLF, Entity GIJFJALMMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F080", Offset = "0x2C6E480", VA = "0x182C6F080")]
		public bool FFPPMEKEJBA(Entity KCGBIDJFHLF, Entity GIJFJALMMOL, bool EMMHLADBAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F120", Offset = "0x2C6E520", VA = "0x182C6F120")]
		private bool JKHMBDIFCCJ(Entity KCGBIDJFHLF, Entity GIJFJALMMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[BGGFAGPLFND(typeof(HEAFAACMDJP), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
internal sealed class HEAFAACMDJP : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private EntityQuery OBGNIKGMCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A790", Offset = "0x2C79B90", VA = "0x182C7A790")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ABB0", Offset = "0x2C79FB0", VA = "0x182C7ABB0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A350", Offset = "0x2C79750", VA = "0x182C7A350", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AA10", Offset = "0x2C79E10", VA = "0x182C7AA10")]
	public bool MODCFHPGPKN(Entity KCGBIDJFHLF, Entity IJPMBDNEJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ACB0", Offset = "0x2C7A0B0", VA = "0x182C7ACB0")]
	public IEnumerable<Entity> PLNMIAOCGMN(Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A8E0", Offset = "0x2C79CE0", VA = "0x182C7A8E0")]
	public bool JOKNPFIDODI(Entity KCGBIDJFHLF, Entity MIJGFFHMOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A7E0", Offset = "0x2C79BE0", VA = "0x182C7A7E0")]
	public bool IPJALMMAMBB(Entity KCGBIDJFHLF, Entity LAAEFADHFKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AAD0", Offset = "0x2C79ED0", VA = "0x182C7AAD0")]
	public NativeList<Entity> NGEIPGINFEP(Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false, Allocator NHNCCHNPCJI = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A370", Offset = "0x2C79770", VA = "0x182C7A370")]
	public IEnumerable<Entity> EBJAFNDLFGI(Entity KCGBIDJFHLF, bool FOKIDIOGDBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A2A0", Offset = "0x2C796A0", VA = "0x182C7A2A0")]
	public Entity DLEPMOHONDC(Entity KCGBIDJFHLF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A250", Offset = "0x2C79650", VA = "0x182C7A250")]
	public NativeArray<Entity> AJEDEJEJBCN()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A570", Offset = "0x2C79970", VA = "0x182C7A570")]
	public bool HBHDIMLPOJD(Entity LAAEFADHFKD, Entity NAHHHHBNGEI, out Entity NABADPABDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AE30", Offset = "0x2C7A230", VA = "0x182C7AE30")]
	private Entity POGOENBECCM(Entity KCGBIDJFHLF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public HEAFAACMDJP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[AFAPMPFKDID(JCDEPCAPNFC.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x3D60340", Offset = "0x3D5F740", VA = "0x183D60340")]
		public static void NGKBIODLKGD<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(EJMKHPELEHA KMGLINHGLGG, global::CPENGNEJPCM<Entity> KDNIDDIGOFK, out global::CAJGNEAMAMB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> EIFIFCILEIO) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, DCIIGNCABLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, DCIIGNCABLO, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CDD0", Offset = "0x2A4C1D0", VA = "0x182A4CDD0")]
		public static bool KIAIPHLFFJA(MPFJCJEABON ODDIKGOJDNI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class CAJGNEAMAMB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, DCIIGNCABLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, DCIIGNCABLO, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private static readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private readonly FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly global::KIABHJONBDN<Entity> GIOGLFNEEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly HMKEHOIOCDA CAKNODKBOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly AJFNKNMFLJF BLENCGKHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly AFANFAEGBHI JGOACJAEEPK;

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x41C0AD0", Offset = "0x41BFED0", VA = "0x1841C0AD0")]
	public CAJGNEAMAMB(EJMKHPELEHA KMGLINHGLGG, global::CPENGNEJPCM<Entity> KDNIDDIGOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x41C03C0", Offset = "0x41BF7C0", VA = "0x1841C03C0")]
	private bool OPIOALLBAPO(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x41BF290", Offset = "0x41BE690", VA = "0x1841BF290")]
	private bool CDKNNDBNEMC(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x41BFD70", Offset = "0x41BF170", VA = "0x1841BFD70")]
	public bool MCIAKNOLHHF(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x41BF7D0", Offset = "0x41BEBD0", VA = "0x1841BF7D0")]
	public bool JBOJIDDMHFG(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x41BF800", Offset = "0x41BEC00", VA = "0x1841BF800")]
	private bool JBOJIDDMHFG(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL, bool CAAKCLFBFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void INDMDDGDPDN(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void CCLADEGCKDE(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void IGAKPPBNIHJ(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void LIPGOGEMGOM(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void MKMGGPOFOLC(Entity KCGBIDJFHLF, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x41BFEC0", Offset = "0x41BF2C0", VA = "0x1841BFEC0")]
	private bool MODCFHPGPKN(Entity KCGBIDJFHLF, Entity IJPMBDNEJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x41BF6E0", Offset = "0x41BEAE0", VA = "0x1841BF6E0")]
	private void FKHEKFACBPE(Entity KCGBIDJFHLF, in Entity JMCOICNPJLH, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x41C0220", Offset = "0x41BF620", VA = "0x1841C0220")]
	private void OLNOCDKFLCO(Entity KCGBIDJFHLF, in Entity JMCOICNPJLH, in Entity GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x41BF2E0", Offset = "0x41BE6E0", VA = "0x1841BF2E0")]
	private bool DNNMEAHALCC(NKPFECECGDG EAPOMGONGIE, in DLABIEOOCHD ILMJDMECFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x41BFC40", Offset = "0x41BF040", VA = "0x1841BFC40")]
	private void KKMHFJFCFJD(Entity BLENCGKHIJI, Entity MIJGFFHMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x41BFE30", Offset = "0x41BF230", VA = "0x1841BFE30")]
	private void MNJLDMDAPLM(Entity BLENCGKHIJI, Entity MIJGFFHMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private void ACMCKKKPAAD(Entity KCGBIDJFHLF, Entity JMCOICNPJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private void LOCFLNMICLD(Entity KCGBIDJFHLF, Entity GIJFJALMMOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public struct DBNKDNBIEFI : JOFONMFINJP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x66D000", Offset = "0x66C400", VA = "0x18066D000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PJOKDCEKIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E0", Offset = "0x6D18E0", VA = "0x1806D24E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[AFAPMPFKDID(JCDEPCAPNFC.Embodiment)]
	[BGGFAGPLFND(typeof(ObjectEmbodimentService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class ObjectEmbodimentService : FNBOKKBLOMJ, EHPEJLPKBCA, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private ObjectLifecycleService CLKGBFAJPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[GPKJCAPOIDC]
		private GGDOJMIIODJ KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[GPKJCAPOIDC]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[GPKJCAPOIDC]
		private LBMLBONIJAH NLNFAPHGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[GPKJCAPOIDC]
		private DMEJOPMIOFD FEIDGHOMMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[GPKJCAPOIDC]
		private TransformOwnershipPhase KADCGNDDIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private readonly Dictionary<DLABIEOOCHD, NODKLFFDFHA> OHPECILNJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private AGJGAEEIMIA CHCPJKGHBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB8")]
			[Cpp2IlInjected.Address(RVA = "0x2A3EFC0", Offset = "0x2A3E3C0", VA = "0x182A3EFC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public int MNHMEJLDIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x2A3F950", Offset = "0x2A3ED50", VA = "0x182A3F950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public int FPFDKAAIJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x2A409C0", Offset = "0x2A3FDC0", VA = "0x182A409C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x10912E0", Offset = "0x10906E0", VA = "0x1810912E0", Slot = "4")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2A403E0", Offset = "0x2A3F7E0", VA = "0x182A403E0", Slot = "5")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D090", Offset = "0x2A3C490", VA = "0x182A3D090")]
		public void BIOAKAMKIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DFC0", Offset = "0x2A3D3C0", VA = "0x182A3DFC0", Slot = "6")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DE20", Offset = "0x2A3D220", VA = "0x182A3DE20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D070", Offset = "0x2A3C470", VA = "0x182A3D070")]
		public int ALOJHDPLKID(SceneTag ENNCIIPAJMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D9B0", Offset = "0x2A3CDB0", VA = "0x182A3D9B0")]
		public int COBBFMJJAON(SceneTag ENNCIIPAJMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CD30", Offset = "0x2A3C130", VA = "0x182A3CD30")]
		public bool AGGAOONDGHE(Entity KCGBIDJFHLF, Allocator NHNCCHNPCJI, out NativeList<Entity> JLJHEBPAALG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EC50", Offset = "0x2A3E050", VA = "0x182A3EC50")]
		public bool HEEDMOAAPAG(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E850", Offset = "0x2A3DC50", VA = "0x182A3E850")]
		public bool FDEINLLBLDO(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E370", Offset = "0x2A3D770", VA = "0x182A3E370")]
		public bool ELFGIBIBFMP(Entity KCGBIDJFHLF, out NODKLFFDFHA ECKHIFIOGEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E3E0", Offset = "0x2A3D7E0", VA = "0x182A3E3E0")]
		private bool ELFGIBIBFMP(Transform ENMFIMJMMCO, out NODKLFFDFHA ECKHIFIOGEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FB70", Offset = "0x2A3EF70", VA = "0x182A3FB70")]
		private void MHGDBICOJJL(Entity KCGBIDJFHLF, NODKLFFDFHA ECKHIFIOGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E350", Offset = "0x2A3D750", VA = "0x182A3E350")]
		private bool EHEILLAFCLI(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F970", Offset = "0x2A3ED70", VA = "0x182A3F970")]
		public void MGGHGLFMIKB(DLABIEOOCHD BBEIPJALHJO, NODKLFFDFHA PIOLONINMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FC00", Offset = "0x2A3F000", VA = "0x182A3FC00")]
		public bool NEAHKIGKEFD(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D4F0", Offset = "0x2A3C8F0", VA = "0x182A3D4F0")]
		public bool BPHNCBFOIEL(HOGBEFGIKOI DCJOMJHHEFE, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D8A0", Offset = "0x2A3CCA0", VA = "0x182A3D8A0")]
		public bool BPHNCBFOIEL(Entity KCGBIDJFHLF, [Optional] object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D160", Offset = "0x2A3C560", VA = "0x182A3D160")]
		public bool BPHNCBFOIEL(NODKLFFDFHA ODDIKGOJDNI, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D9D0", Offset = "0x2A3CDD0", VA = "0x182A3D9D0")]
		public bool DBIDIBIGODI(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DDA0", Offset = "0x2A3D1A0", VA = "0x182A3DDA0")]
		public bool DBIDIBIGODI(NODKLFFDFHA ECKHIFIOGEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D180", Offset = "0x2A3C580", VA = "0x182A3D180")]
		public bool BPHNCBFOIEL(NODKLFFDFHA ECKHIFIOGEF, [Optional] object PFJMMABJIDH, bool LGPEEBCPBMM = false, bool KMCLAMOJHKF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F380", Offset = "0x2A3E780", VA = "0x182A3F380")]
		public Transform KEMEDAPIKJK(Entity KCGBIDJFHLF, [Optional] object PFJMMABJIDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F0E0", Offset = "0x2A3E4E0", VA = "0x182A3F0E0")]
		public bool IICHANKDDLE(Entity KCGBIDJFHLF, out Transform ENMFIMJMMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CF80", Offset = "0x2A3C380", VA = "0x182A3CF80")]
		public NODKLFFDFHA AJOCPKACCNK(Entity KCGBIDJFHLF, [Optional] object PFJMMABJIDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2A40730", Offset = "0x2A3FB30", VA = "0x182A40730")]
		public void PMKCPINDBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E490", Offset = "0x2A3D890", VA = "0x182A3E490")]
		public void EPCHDIBPNII(SceneTag ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F4F0", Offset = "0x2A3E8F0", VA = "0x182A3F4F0")]
		private void KMGJMFKFPFJ(Entity KCGBIDJFHLF, bool LCCHKMLHGFM, bool HDFBEJLAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F8B0", Offset = "0x2A3ECB0", VA = "0x182A3F8B0")]
		private void KOBGDPADDJF(Entity KCGBIDJFHLF, NODKLFFDFHA ECKHIFIOGEF, bool LCCHKMLHGFM, bool HDFBEJLAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DDD0", Offset = "0x2A3D1D0", VA = "0x182A3DDD0")]
		public NODKLFFDFHA DHEKCDECPCP(Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D0E0", Offset = "0x2A3C4E0", VA = "0x182A3D0E0")]
		public bool BLCDGAOPOOD(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EEA0", Offset = "0x2A3E2A0", VA = "0x182A3EEA0")]
		public bool HFKDBKCEAGB(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DF50", Offset = "0x2A3D350", VA = "0x182A3DF50")]
		public bool EDILFGKDEMM(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F280", Offset = "0x2A3E680", VA = "0x182A3F280")]
		public bool ILJINODCPBL(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F1B0", Offset = "0x2A3E5B0", VA = "0x182A3F1B0")]
		public bool ILJINODCPBL(PJOKDCEKIIH IICPGPKAIEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void PBKBBJHEGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADF")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D8F0", Offset = "0x2A3CCF0", VA = "0x182A3D8F0")]
		private void CCIFIAJJMOE(bool ONBPAADBCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F2F0", Offset = "0x2A3E6F0", VA = "0x182A3F2F0")]
		private bool IMOGFOJODCL(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EF20", Offset = "0x2A3E320", VA = "0x182A3EF20")]
		private NODKLFFDFHA HGHCFMBJNIE(Entity KCGBIDJFHLF, object PFJMMABJIDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E870", Offset = "0x2A3DC70", VA = "0x182A3E870")]
		private NODKLFFDFHA FFKGICDCKJE(Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0x2A40510", Offset = "0x2A3F910", VA = "0x182A40510")]
		private (Vector3, Quaternion, Vector3) PKDONBHPFJL(Entity KCGBIDJFHLF)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EB40", Offset = "0x2A3DF40", VA = "0x182A3EB40")]
		private void GGJACINJHAN(Entity KCGBIDJFHLF, FFIHEMJDJJI CNEFMCCDIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FFA0", Offset = "0x2A3F3A0", VA = "0x182A3FFA0")]
		private void NHBOLGLKFGK(HOGBEFGIKOI DCJOMJHHEFE, NODKLFFDFHA PIOLONINMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0x2A40060", Offset = "0x2A3F460", VA = "0x182A40060")]
		private void NILLBPDFHJG(NODKLFFDFHA PIOLONINMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2A401B0", Offset = "0x2A3F5B0", VA = "0x182A401B0")]
		private void OOFBOJCCPPM(NODKLFFDFHA ECKHIFIOGEF, Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E110", Offset = "0x2A3D510", VA = "0x182A3E110")]
		private void EFJEIJEFFPO(Entity KCGBIDJFHLF, NODKLFFDFHA ECKHIFIOGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EA60", Offset = "0x2A3DE60", VA = "0x182A3EA60")]
		private void FIMFDDFFIHN(Entity KCGBIDJFHLF, Transform ENMFIMJMMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x2A40180", Offset = "0x2A3F580", VA = "0x182A40180")]
		private HOGBEFGIKOI NPCPKDAOGEH(Entity KCGBIDJFHLF)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x2A40A30", Offset = "0x2A3FE30", VA = "0x182A40A30")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F010", Offset = "0x2A3E410", VA = "0x182A3F010")]
		[CompilerGenerated]
		private void HMDFFCHHPJA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal static class IAHKCNDLNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E3E0", Offset = "0x2C7D7E0", VA = "0x182C7E3E0")]
	public static NODKLFFDFHA AJOCPKACCNK(this ObjectEmbodimentService OFIMLDPADIP, HOGBEFGIKOI DCJOMJHHEFE, [Optional] object PFJMMABJIDH)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[BGGFAGPLFND(typeof(ObjectLifecycleService), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Lifecycle)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class ObjectLifecycleService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private ObjectEmbodimentService ECKHIFIOGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private DestroyLocalObjects GCLJLEIHGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0x2A41720", Offset = "0x2A40B20", VA = "0x182A41720")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Entity, FFIHEMJDJJI> LDMBPIGAPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEF")]
			[Cpp2IlInjected.Address(RVA = "0x2A415E0", Offset = "0x2A409E0", VA = "0x182A415E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF0")]
			[Cpp2IlInjected.Address(RVA = "0x2A41350", Offset = "0x2A40750", VA = "0x182A41350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Entity> MNDEHHMFPIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF1")]
			[Cpp2IlInjected.Address(RVA = "0x2A41770", Offset = "0x2A40B70", VA = "0x182A41770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF2")]
			[Cpp2IlInjected.Address(RVA = "0x2A41680", Offset = "0x2A40A80", VA = "0x182A41680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x2A41FA0", Offset = "0x2A413A0", VA = "0x182A41FA0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF5")]
		[Cpp2IlInjected.Address(RVA = "0x2A41490", Offset = "0x2A40890", VA = "0x182A41490", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x2A41C30", Offset = "0x2A41030", VA = "0x182A41C30")]
		public bool NNJMHAAKOAN(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x2A41810", Offset = "0x2A40C10", VA = "0x182A41810")]
		internal void LEIICPIABKN(Entity KCGBIDJFHLF, FFIHEMJDJJI CNEFMCCDIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2A41450", Offset = "0x2A40850", VA = "0x182A41450")]
		public void DJKBALEHOOL(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x2A41590", Offset = "0x2A40990", VA = "0x182A41590")]
		public void FNNDIILPGLE(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x2A414A0", Offset = "0x2A408A0", VA = "0x182A414A0")]
		private bool EBMENCENNFC(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x2A41150", Offset = "0x2A40550", VA = "0x182A41150")]
		public void AFFPDBIGLLL(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x2A41870", Offset = "0x2A40C70", VA = "0x182A41870")]
		private bool NCLNICGLCHP(Entity KCGBIDJFHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x2A41CB0", Offset = "0x2A410B0", VA = "0x182A41CB0")]
		public void OABAAEPLPCK(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x2A413F0", Offset = "0x2A407F0", VA = "0x182A413F0")]
		private void CJHJCBPJKNM(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x2A41D40", Offset = "0x2A41140", VA = "0x182A41D40")]
		private void ONMNCPEDDPB(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x2A41540", Offset = "0x2A40940", VA = "0x182A41540")]
		public void EKCHPFJIDML(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private void BNCBIPFNKFH(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x2A41A30", Offset = "0x2A40E30", VA = "0x182A41A30")]
		private void NFKCFOBMIKD(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[AFAPMPFKDID(JCDEPCAPNFC.Prefabs)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[BGGFAGPLFND(typeof(ObjectPrefabs), new string[] { })]
	internal class ObjectPrefabs : PDOMJEMLCGH, OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class CHHNGFPPCFD : IEnumerable<(CDPNPEPOMEC, FFIHEMJDJJI)>, IEnumerable, IEnumerator<(CDPNPEPOMEC, FFIHEMJDJJI)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private (CDPNPEPOMEC primitiveType, FFIHEMJDJJI prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000133")]
			private (CDPNPEPOMEC, FFIHEMJDJJI) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB350", Offset = "0x1DCA750", VA = "0x181DCB350", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((CDPNPEPOMEC, FFIHEMJDJJI));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000134")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0x45BEB00", Offset = "0x45BDF00", VA = "0x1845BEB00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2BCE850", Offset = "0x2BCDC50", VA = "0x182BCE850")]
			[DebuggerHidden]
			public CHHNGFPPCFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0x45BE920", Offset = "0x45BDD20", VA = "0x1845BE920", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0x45BEAC0", Offset = "0x45BDEC0", VA = "0x1845BEAC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0x45BEA20", Offset = "0x45BDE20", VA = "0x1845BEA20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(CDPNPEPOMEC, FFIHEMJDJJI)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B27")]
			[Cpp2IlInjected.Address(RVA = "0x45BEA20", Offset = "0x45BDE20", VA = "0x1845BEA20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private World ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private readonly Dictionary<FFIHEMJDJJI, Entity> EELIHJHFEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private readonly Dictionary<FFIHEMJDJJI, EntityArchetype> PHNLLMECBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private readonly Dictionary<CDPNPEPOMEC, FFIHEMJDJJI> ADJCLNKIIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<NNNACFBOHIB, FFIHEMJDJJI> JEDMMELJJHP;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public int MHDOGPFGFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B05")]
			[Cpp2IlInjected.Address(RVA = "0x2A44CA0", Offset = "0x2A440A0", VA = "0x182A44CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B06")]
			[Cpp2IlInjected.Address(RVA = "0x2A44FD0", Offset = "0x2A443D0", VA = "0x182A44FD0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0x2A45860", Offset = "0x2A44C60", VA = "0x182A45860", Slot = "5")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x2A44910", Offset = "0x2A43D10", VA = "0x182A44910", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x2A45050", Offset = "0x2A44450", VA = "0x182A45050")]
		internal IEnumerable<Type> IDGGFPELIIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x2A44770", Offset = "0x2A43B70", VA = "0x182A44770")]
		internal LILHBOLDDBP DFMLCGAHOAK(Type NLAFPPIOFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x2A44FF0", Offset = "0x2A443F0", VA = "0x182A44FF0")]
		public EntityArchetype HIMLDABCCHB(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x2A45570", Offset = "0x2A44970", VA = "0x182A45570")]
		public NativeHashMap<int, EntityArchetype> NIGFALGKPLM(Allocator NHNCCHNPCJI = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x2A45500", Offset = "0x2A44900", VA = "0x182A45500")]
		public bool KPHDIIDEPDK(FFIHEMJDJJI CNEFMCCDIIL, out EntityArchetype LKHIPKFNEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x2A448A0", Offset = "0x2A43CA0", VA = "0x182A448A0", Slot = "4")]
		[IteratorStateMachine(typeof(CHHNGFPPCFD))]
		public IEnumerable<(CDPNPEPOMEC, FFIHEMJDJJI)> DOFOPDAFJLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x2A44E50", Offset = "0x2A44250", VA = "0x182A44E50")]
		public Entity GBLBPOEDLKO(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x2A44840", Offset = "0x2A43C40", VA = "0x182A44840")]
		public FFIHEMJDJJI DIIICNFKKLC(NNNACFBOHIB NLAFPPIOFPG)
		{
			return default(FFIHEMJDJJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2A447E0", Offset = "0x2A43BE0", VA = "0x182A447E0")]
		public FFIHEMJDJJI DIIICNFKKLC(CDPNPEPOMEC NLAFPPIOFPG)
		{
			return default(FFIHEMJDJJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2A456F0", Offset = "0x2A44AF0", VA = "0x182A456F0")]
		public NativeHashMap<int, Entity> OMGFLFIHJAP(Allocator NHNCCHNPCJI = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x2A44720", Offset = "0x2A43B20", VA = "0x182A44720")]
		public IEnumerable<FFIHEMJDJJI> DBHLMNBJLNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x2A44C40", Offset = "0x2A44040", VA = "0x182A44C40")]
		public Entity FKCALAJIOHB(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x2A44F60", Offset = "0x2A44360", VA = "0x182A44F60")]
		public bool HGHEDFHKJBL(FFIHEMJDJJI CNEFMCCDIIL, out Entity LPLLOMCCPLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x2A450B0", Offset = "0x2A444B0", VA = "0x182A450B0")]
		private void JFLKHOGMEFH(LILHBOLDDBP AIGMCEEMIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x2A444F0", Offset = "0x2A438F0", VA = "0x182A444F0")]
		internal void AEAMFHKMGKF(FFIHEMJDJJI CNEFMCCDIIL, APDBBCPJHNI CGKMJOIBMPH, CFHDEDJFOHN EMCAFFKHMOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x2A44CF0", Offset = "0x2A440F0", VA = "0x182A44CF0")]
		private void GAGKPJPCDAM(FFIHEMJDJJI CNEFMCCDIIL, APDBBCPJHNI ICJBAHODFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C40", Offset = "0x2A45040", VA = "0x182A45C40")]
		internal Entity POEDOFAKDLC(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x2A45DB0", Offset = "0x2A451B0", VA = "0x182A45DB0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
public enum ADKBFPANNLM
{
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal interface EDGJMKDKOBC
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World JAFDKOADMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	GLAOBBNBINF LHJKPNCGOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class MLCMLAJFKIH : MPOIHBOLOFN, LIMLHMBKDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private readonly AIOLEJENMFN AHMLJOKDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private readonly ADKBFPANNLM KADCGNDDIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private readonly List<OHKGEEOIGMA> OLEDOOEEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private NativeMultiHashMap<Entity, AMBIFMNOMBI> JNHCILNEBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private NativeHashMap<int, int> AHNCAPDGLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private JobHandle PMOCGGMEGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private JobHandle EECAONPMCBL;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private World FMDALHKHINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2C886C0", Offset = "0x2C87AC0", VA = "0x182C886C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private GLAOBBNBINF BLACDENCJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8B00", Offset = "0x2BE7F00", VA = "0x182BE8B00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private ICOKJDJNJLD DMNFMKIIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x681D40", Offset = "0x681140", VA = "0x180681D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private NativeMultiHashMap<Entity, AMBIFMNOMBI> ODHHKNIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x68E030", Offset = "0x68D430", VA = "0x18068E030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, AMBIFMNOMBI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private JobHandle KFDEJJMBPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x113CA40", Offset = "0x113BE40", VA = "0x18113CA40", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x113C850", Offset = "0x113BC50", VA = "0x18113C850", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private bool GANBHBDEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2C88FF0", Offset = "0x2C883F0", VA = "0x182C88FF0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private World AKFFLAIPPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2C88720", Offset = "0x2C87B20", VA = "0x182C88720", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2A")]
	[Cpp2IlInjected.Address(RVA = "0x2C894C0", Offset = "0x2C888C0", VA = "0x182C894C0")]
	public MLCMLAJFKIH(AIOLEJENMFN AHMLJOKDEKH, ADKBFPANNLM KADCGNDDIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x2C88680", Offset = "0x2C87A80", VA = "0x182C88680", Slot = "11")]
	private void DDIHMKCGJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x2C88A00", Offset = "0x2C87E00", VA = "0x182C88A00", Slot = "10")]
	private bool HEAFCGPDGBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x2C88910", Offset = "0x2C87D10", VA = "0x182C88910", Slot = "12")]
	private void EMKMMHBIOLI(ComponentType DHGPLCEACKF, in OHKGEEOIGMA KJOLOKLIGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x2C88690", Offset = "0x2C87A90", VA = "0x182C88690", Slot = "13")]
	private bool DHOLNGDPLID(FFIHEMJDJJI CNEFMCCDIIL, out Entity LPLLOMCCPLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x2C88870", Offset = "0x2C87C70", VA = "0x182C88870", Slot = "16")]
	private bool EJPJHLOMCDI(out NativeArray<int> LHKLNDCEBLM, Allocator NHNCCHNPCJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x2C891D0", Offset = "0x2C885D0", VA = "0x182C891D0", Slot = "17")]
	private bool PKPGNAEEMEP(ComponentType DHGPLCEACKF, out OHKGEEOIGMA NEJINOAAOHF, out IKABOPAFLEH GLIPIAPKOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x2C89390", Offset = "0x2C88790", VA = "0x182C89390", Slot = "18")]
	private bool PKPGNAEEMEP(ComponentType DHGPLCEACKF, out OHKGEEOIGMA NEJINOAAOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x2C88780", Offset = "0x2C87B80", VA = "0x182C88780", Slot = "19")]
	private OHKGEEOIGMA EFPKHFDHPEE(ComponentType DHGPLCEACKF)
	{
		return default(OHKGEEOIGMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x2C88640", Offset = "0x2C87A40", VA = "0x182C88640", Slot = "20")]
	private OEEKGDMLMHL BAPGOLDMAIE()
	{
		return default(OEEKGDMLMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x2C89000", Offset = "0x2C88400", VA = "0x182C89000", Slot = "21")]
	private void MIHHKBHHEJJ(JobHandle KNAKGAMMCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x2C88B20", Offset = "0x2C87F20", VA = "0x182C88B20")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x2C88DD0", Offset = "0x2C881D0", VA = "0x182C88DD0")]
	private bool IJIHNIEHLDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x2C89040", Offset = "0x2C88440", VA = "0x182C89040")]
	private int OAJKIGIACHP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal class AIOLEJENMFN : EDGJMKDKOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public FGEHAOHAFDI LIDPFPMMNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public ObjectInstantiationService EELIHJHFEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public GLAOBBNBINF EFLMONEFIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public ICOKJDJNJLD AEGCMFKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ADLIBBBJLJE LADDLHIGNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public World JAFDKOADMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x2D01370", Offset = "0x2D00770", VA = "0x182D01370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public GLAOBBNBINF LHJKPNCGOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public AIOLEJENMFN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[AFAPMPFKDID(JCDEPCAPNFC.PropertyChanges)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[BGGFAGPLFND(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AB")]
		internal readonly struct JOALEGIDFDL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private readonly ADKBFPANNLM AFAKGGOJGPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private readonly PropertyDiffStateService BHMPCEPJFGF;

			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x45C2360", Offset = "0x45C1760", VA = "0x1845C2360")]
			public JOALEGIDFDL(PropertyDiffStateService BHMPCEPJFGF, ADKBFPANNLM OJAKDMOLJFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0x45C2340", Offset = "0x45C1740", VA = "0x1845C2340", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private readonly AIOLEJENMFN AHMLJOKDEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private readonly MLCMLAJFKIH[] PGKNLENPHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private ADKBFPANNLM MPFDKCFONHK;

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public EDGJMKDKOBC DJJKAOMILLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public LIMLHMBKDHE OOODMJEGDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B46")]
			[Cpp2IlInjected.Address(RVA = "0x2A53610", Offset = "0x2A52A10", VA = "0x182A53610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public MPOIHBOLOFN ACIPLEJGEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0x2A53610", Offset = "0x2A52A10", VA = "0x182A53610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x8CD880", Offset = "0x8CCC80", VA = "0x1808CD880")]
		public LIMLHMBKDHE KODEOLHHIKG(ADKBFPANNLM KADCGNDDIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x8CD880", Offset = "0x8CCC80", VA = "0x1808CD880")]
		public MPOIHBOLOFN CFLBCFGHJHG(ADKBFPANNLM KADCGNDDIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2A53A40", Offset = "0x2A52E40", VA = "0x182A53A40", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2A53730", Offset = "0x2A52B30", VA = "0x182A53730", Slot = "5")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2A539E0", Offset = "0x2A52DE0", VA = "0x182A539E0")]
		public void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2A53650", Offset = "0x2A52A50", VA = "0x182A53650", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2A539C0", Offset = "0x2A52DC0", VA = "0x182A539C0")]
		public JOALEGIDFDL FOFAIMBBKBN(ADKBFPANNLM KADCGNDDIGB)
		{
			return default(JOALEGIDFDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2A53B10", Offset = "0x2A52F10", VA = "0x182A53B10")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[BGGFAGPLFND(typeof(SceneService), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.HierarchySystems)]
	internal class SceneService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public static readonly SceneTag OPBIEPPPDNG;

		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private const string JJHHFIPKFCO = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[GPKJCAPOIDC]
		private EJFLHFELKLA BDDIOBKHCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[GPKJCAPOIDC]
		private ObjectEmbodimentService ECKHIFIOGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[GPKJCAPOIDC]
		private HMKEHOIOCDA BGHKBCNEBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[GPKJCAPOIDC]
		private SingletonComponentService DKCKDEAGPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private EntityQuery JJBOHKCFOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private EntityQuery EOINIEHNNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private EntityQuery NNENCDCBCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public bool GDKLHMOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3550", Offset = "0x2BD2950", VA = "0x182BD3550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public NativeArray<Entity> FNEHCLPCKJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x20E57A0", Offset = "0x20E4BA0", VA = "0x1820E57A0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2BD33E0", Offset = "0x2BD27E0", VA = "0x182BD33E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public SceneTag GLJBOOBOJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2A90", Offset = "0x2BD1E90", VA = "0x182BD2A90")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public Entity MHAKELPBOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2A90", Offset = "0x2BD1E90", VA = "0x182BD2A90")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2250", Offset = "0x2BD1650", VA = "0x182BD2250")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2B50", Offset = "0x2BD1F50", VA = "0x182BD2B50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3470", Offset = "0x2BD2870", VA = "0x182BD3470", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2480", Offset = "0x2BD1880", VA = "0x182BD2480", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1F40", Offset = "0x2BD1340", VA = "0x182BD1F40")]
		public NativeArray<Entity> BKKLAJFDJLM(Allocator NHNCCHNPCJI = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1F70", Offset = "0x2BD1370", VA = "0x182BD1F70")]
		public void BLFNIJENKEH(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD33F0", Offset = "0x2BD27F0", VA = "0x182BD33F0")]
		public Entity OKAJCMEJHJK(string JODEBEIHAPC = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD33C0", Offset = "0x2BD27C0", VA = "0x182BD33C0")]
		public void NFFIFILFKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2B30", Offset = "0x2BD1F30", VA = "0x182BD2B30")]
		public void HBFPNPBNGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3300", Offset = "0x2BD2700", VA = "0x182BD3300")]
		public void LDDLKNNEMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1F30", Offset = "0x2BD1330", VA = "0x182BD1F30")]
		public void AKJALBHOOBC(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3250", Offset = "0x2BD2650", VA = "0x182BD3250")]
		public void IPKDAOLGJPF(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1BC0", Offset = "0x2BD0FC0", VA = "0x182BD1BC0")]
		public string ABNGCAAMJLG(Entity ENNCIIPAJMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		public void IOCOENNLCAL(Entity ENNCIIPAJMI, string JODEBEIHAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2B10", Offset = "0x2BD1F10", VA = "0x182BD2B10")]
		public bool GJADDLBFFKP(string JODEBEIHAPC, out Entity ENNCIIPAJMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2980", Offset = "0x2BD1D80", VA = "0x182BD2980")]
		public void EMEBGAOOELI(Entity ENNCIIPAJMI, bool LJPOHPEAICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2070", Offset = "0x2BD1470", VA = "0x182BD2070")]
		public void BPFOLNFJBPL(Entity KCGBIDJFHLF, bool IEKLBFGKDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x2BD21E0", Offset = "0x2BD15E0", VA = "0x182BD21E0")]
		public void BPFOLNFJBPL(NativeArray<Entity> IHPLCMEEOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x2BD20F0", Offset = "0x2BD14F0", VA = "0x182BD20F0")]
		public void BPFOLNFJBPL(EntityQuery KFGMFPAGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2BD24C0", Offset = "0x2BD18C0", VA = "0x182BD24C0")]
		public void EMBCIIHOMJG(Entity KCGBIDJFHLF, Entity ENNCIIPAJMI, bool IEKLBFGKDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD26F0", Offset = "0x2BD1AF0", VA = "0x182BD26F0")]
		public void EMBCIIHOMJG(NativeArray<Entity> IHPLCMEEOEJ, Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD28D0", Offset = "0x2BD1CD0", VA = "0x182BD28D0")]
		public void EMBCIIHOMJG(EntityQuery KFGMFPAGHMA, Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1CD0", Offset = "0x2BD10D0", VA = "0x182BD1CD0")]
		private void AFPJFNJDOOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2450", Offset = "0x2BD1850", VA = "0x182BD2450")]
		private void DKMFGJCKOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1E80", Offset = "0x2BD1280", VA = "0x182BD1E80")]
		private void AIPCIKKCEGH(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2C40", Offset = "0x2BD2040", VA = "0x182BD2C40")]
		private void IAHDDEFAMMI(EntityQuery CIEELFJMCHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2D10", Offset = "0x2BD2110", VA = "0x182BD2D10")]
		private void IAHDDEFAMMI(NativeArray<Entity> KGBHFHAMEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2FF0", Offset = "0x2BD23F0", VA = "0x182BD2FF0")]
		private void IBJDLFNBMMF(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2BD22C0", Offset = "0x2BD16C0", VA = "0x182BD22C0")]
		private void DHCKBJOBHHH(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2BA0", Offset = "0x2BD1FA0", VA = "0x182BD2BA0")]
		private void HNGIDBLIKPG(SceneTag OOJHKFALEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2BD30A0", Offset = "0x2BD24A0", VA = "0x182BD30A0")]
		private void IDLPKAFDAPE(SceneTag OOJHKFALEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2BD30C0", Offset = "0x2BD24C0", VA = "0x182BD30C0")]
		private void IFNGIAAAFLN(SceneTag OOJHKFALEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3260", Offset = "0x2BD2660", VA = "0x182BD3260")]
		private void JIOHFCCLDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2530", Offset = "0x3BE1930", VA = "0x183BE2530")]
		private void ECIDNJILEOJ<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CGOFOFJJEPG(SceneTag OOJHKFALEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3360", Offset = "0x2BD2760", VA = "0x182BD3360")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LGBGBNFGMGD(EntityQuery KFGMFPAGHMA, string JODEBEIHAPC, SceneTag OOJHKFALEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2AE0", Offset = "0x2BD1EE0", VA = "0x182BD2AE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FGKOLADKLLO(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void JNMIONAOBLM(Entity ENNCIIPAJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[BGGFAGPLFND(typeof(SingletonComponentService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes)]
	internal sealed class SingletonComponentService : OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		[GPKJCAPOIDC]
		private HMKEHOIOCDA BGHKBCNEBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private Entity KCGBIDJFHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private APDBBCPJHNI ICJBAHODFKP;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public int MHDOGPFGFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD82F0", Offset = "0x2BD76F0", VA = "0x182BD82F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity BADKAKDHHFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		private EntityManager CPBCICNIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8300", Offset = "0x2BD7700", VA = "0x182BD8300")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3E60", Offset = "0x3BE3260", VA = "0x183BE3E60")]
		public T DPALGOGEJPD<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3F20", Offset = "0x3BE3320", VA = "0x183BE3F20")]
		public void JKDFMHKJMMK<T>(T PKODKJLGOIN) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8350", Offset = "0x2BD7750", VA = "0x182BD8350", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7E80", Offset = "0x2BD7280", VA = "0x182BD7E80", Slot = "5")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7E80", Offset = "0x2BD7280", VA = "0x182BD7E80")]
		private void DNBOAINBPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8020", Offset = "0x2BD7420", VA = "0x182BD8020", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x2BD83C0", Offset = "0x2BD77C0", VA = "0x182BD83C0")]
		private APDBBCPJHNI PMOAGBKLPJF()
		{
			return default(APDBBCPJHNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void MHDCEMOEIEC(int EFJDLDLIAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		private static void MJGPGCDIEFL(Type NLAFPPIOFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7DE0", Offset = "0x2BD71E0", VA = "0x182BD7DE0")]
		private static void DENDEENGNOC(Type NLAFPPIOFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal struct LOEEOLFJOKM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[BGGFAGPLFND(typeof(DMEJOPMIOFD), new string[] { })]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
internal sealed class DMEJOPMIOFD : OIOAOEDFDMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	[GPKJCAPOIDC]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private global::IIDCNIPBHBO<KNFINANKODG, Entity> PAFHBICFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private global::PNLCFHKCGAO<BIFPCOHOIBP> DEIONOGMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private global::PNLCFHKCGAO<CLALFINCOBK> AENEOPANDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private global::PNLCFHKCGAO<KLKLJDBPIGE> NGHPLGONAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private global::PNLCFHKCGAO<EGJNONMMACL> FKOBCAIODGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private global::PNLCFHKCGAO<DBNKDNBIEFI> OFIMLDPADIP;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public global::EBKMKJBCAGK<Entity> MKMLLLPGLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public PGDKJDMJHPC OELHILGBHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public PGDKJDMJHPC ENPIDOFBLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public PGDKJDMJHPC LFCHFPHFBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public PGDKJDMJHPC FKOEBGALBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PGDKJDMJHPC NFOCGJKCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x674580", Offset = "0x673980", VA = "0x180674580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2D169A0", Offset = "0x2D15DA0", VA = "0x182D169A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2D169F0", Offset = "0x2D15DF0", VA = "0x182D169F0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2D168B0", Offset = "0x2D15CB0", VA = "0x182D168B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x23CD460", Offset = "0x23CC860", VA = "0x1823CD460")]
	private void NGKBIODLKGD<T>(ref global::PNLCFHKCGAO<T> BDPOLJDOFBF) where T : struct, JOFONMFINJP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x23CD460", Offset = "0x23CC860", VA = "0x1823CD460")]
	private void NGKBIODLKGD<TC, TV>(ref global::IIDCNIPBHBO<TC, TV> BDPOLJDOFBF) where TC : struct, JOFONMFINJP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public DMEJOPMIOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
[BGGFAGPLFND(typeof(NJEAPIHJKLF), new string[] { })]
internal sealed class NJEAPIHJKLF : EHPEJLPKBCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private MELNNNHAMLB PHCGMEFEKKL;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MELNNNHAMLB BEHBJKNLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x1EC5CB0", Offset = "0x1EC50B0", VA = "0x181EC5CB0")]
		get
		{
			return default(MELNNNHAMLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B800", Offset = "0x2A3AC00", VA = "0x182A3B800", Slot = "4")]
	public void KHPEEABHNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B7F0", Offset = "0x2A3ABF0", VA = "0x182A3B7F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public NJEAPIHJKLF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[AFAPMPFKDID(JCDEPCAPNFC.HierarchySystems)]
	[BGGFAGPLFND(typeof(TransformOwnershipPhase), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		public enum BANAEDFCOHI
		{
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		public struct EMAIPNBGAPP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			private BANAEDFCOHI FNCIGHDIGPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private readonly TransformOwnershipPhase BLENCGKHIJI;

			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x45BFF20", Offset = "0x45BF320", VA = "0x1845BFF20")]
			public EMAIPNBGAPP(TransformOwnershipPhase BLENCGKHIJI, BANAEDFCOHI KADCGNDDIGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BA6")]
			[Cpp2IlInjected.Address(RVA = "0x45BFF00", Offset = "0x45BF300", VA = "0x1845BFF00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public BANAEDFCOHI KADCGNDDIGB;

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public BANAEDFCOHI PKHCNOMMKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
			get
			{
				return default(BANAEDFCOHI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x68DF30", Offset = "0x68D330", VA = "0x18068DF30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public bool NKNGJNAJELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0xC0F9E0", Offset = "0xC0EDE0", VA = "0x180C0F9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public bool IBOFNLJFLND
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x16F34E0", Offset = "0x16F28E0", VA = "0x1816F34E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB970", Offset = "0x2BDAD70", VA = "0x182BDB970")]
		public EMAIPNBGAPP CGKKKHLPOHE()
		{
			return default(EMAIPNBGAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB9A0", Offset = "0x2BDADA0", VA = "0x182BDB9A0")]
		public EMAIPNBGAPP FJLBPMALBCO()
		{
			return default(EMAIPNBGAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[BGGFAGPLFND(typeof(GCIJLHJDMDE), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Circuits)]
	public class CircuitsService : OIOAOEDFDMG, GCIJLHJDMDE
	{
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		[GPKJCAPOIDC]
		private MLAEKAFPOJD OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BD80", Offset = "0x2D0B180", VA = "0x182D0BD80", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0ADB0", Offset = "0x2D0A1B0", VA = "0x182D0ADB0", Slot = "5")]
		public bool FOPAEKFPILN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B360", Offset = "0x2D0A760", VA = "0x182D0B360", Slot = "7")]
		public Guid JBILPHPLPHM(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BA50", Offset = "0x2D0AE50", VA = "0x182D0BA50", Slot = "8")]
		public void OPJHOLONKJA(HOGBEFGIKOI DCJOMJHHEFE, Guid MCCPAGKJMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BCB0", Offset = "0x2D0B0B0", VA = "0x182D0BCB0", Slot = "9")]
		public Guid OPPAPLELJIB(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B100", Offset = "0x2D0A500", VA = "0x182D0B100", Slot = "10")]
		public void JBBPEGMPNOK(HOGBEFGIKOI DCJOMJHHEFE, Guid EMCLDAHHNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AEB0", Offset = "0x2D0A2B0", VA = "0x182D0AEB0", Slot = "11")]
		public bool GBDCOBJMECP(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B090", Offset = "0x2D0A490", VA = "0x182D0B090", Slot = "12")]
		public void JBAMOAFLCCL(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B430", Offset = "0x2D0A830", VA = "0x182D0B430", Slot = "13")]
		public void JCJLFBBKDDG(HOGBEFGIKOI ENDGJBMJNDE, HOGBEFGIKOI BLENCGKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AC40", Offset = "0x2D0A040", VA = "0x182D0AC40")]
		private void CFHMFDCPPLK(GDNPLCPGBNO MEHJFOINNPI, HOGBEFGIKOI BLENCGKHIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AF00", Offset = "0x2D0A300", VA = "0x182D0AF00")]
		private void GHPAHLDKIJI(GDNPLCPGBNO MEHJFOINNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B7F0", Offset = "0x2D0ABF0", VA = "0x182D0B7F0")]
		private bool KFFHDDGPBNL(MPFJCJEABON HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B9A0", Offset = "0x2D0ADA0", VA = "0x182D0B9A0")]
		private bool NLEBBLIKOGM(MPFJCJEABON HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B940", Offset = "0x2D0AD40", VA = "0x182D0B940", Slot = "6")]
		public bool MHOFBKGICJP(HOGBEFGIKOI ODKPHBBMMPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[BGGFAGPLFND(typeof(JGEBPOEEGMC), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Connectables, new string[] { "Callbacks" })]
	internal class ConnectableService : JGEBPOEEGMC, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		[CompilerGenerated]
		private sealed class ACLGMKGBGBH : IEnumerable<HOGBEFGIKOI>, IEnumerable, IEnumerator<HOGBEFGIKOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			private HOGBEFGIKOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			private HOGBEFGIKOI localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public HOGBEFGIKOI <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000157")]
			private HOGBEFGIKOI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BDA")]
				[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(HOGBEFGIKOI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000158")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BDC")]
				[Cpp2IlInjected.Address(RVA = "0x2BCD0C0", Offset = "0x2BCC4C0", VA = "0x182BCD0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAAD540", VA = "0x180AAE140")]
			[DebuggerHidden]
			public ACLGMKGBGBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD6")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD110", Offset = "0x2BCC510", VA = "0x182BCD110", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD7")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCCD0", Offset = "0x2BCC0D0", VA = "0x182BCCCD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD8")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD1E0", Offset = "0x2BCC5E0", VA = "0x182BCD1E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD9")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD230", Offset = "0x2BCC630", VA = "0x182BCD230")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDB")]
			[Cpp2IlInjected.Address(RVA = "0x2BCD080", Offset = "0x2BCC480", VA = "0x182BCD080", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDD")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCFD0", Offset = "0x2BCC3D0", VA = "0x182BCCFD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HOGBEFGIKOI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDE")]
			[Cpp2IlInjected.Address(RVA = "0x2BCCFD0", Offset = "0x2BCC3D0", VA = "0x182BCCFD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private const string BPIIKEMFHGO = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private static readonly EHNHFGEGKKP OGOOJPHNCDM;

		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public const int DMBAMPJKKHH = 0;

		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public const int GPJPBBAHPOC = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private GGDOJMIIODJ KPJDOIFOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private EFLFKJPCKHG OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private PropertyEventCallbacksService EGECADFEGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private global::KIABHJONBDN<Entity> CFDMPDHCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private global::KIABHJONBDN<float3> AHBILMPDONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private global::KIABHJONBDN<quaternion> OOGMBCAOMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private global::KIABHJONBDN<Entity> BLENCGKHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private global::KIABHJONBDN<float3> CFOIIIPLIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private global::KIABHJONBDN<quaternion> HKBDKOEBLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private HashSet<Entity> GKECKCPLBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private HashSet<Entity> EJIAGLGGOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private EntityQuery OBGNIKGMCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Func<OCFAONBDMGG> DLAKCDEKCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(RVA = "0x683750", Offset = "0x682B50", VA = "0x180683750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0x7A04E0", Offset = "0x79F8E0", VA = "0x1807A04E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<HOGBEFGIKOI, HOGBEFGIKOI> GIBKPEBKICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2D10E80", Offset = "0x2D10280", VA = "0x182D10E80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2D0FAF0", Offset = "0x2D0EEF0", VA = "0x182D0FAF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<HOGBEFGIKOI, HOGBEFGIKOI> LFHAKPEJMMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2D0FC20", Offset = "0x2D0F020", VA = "0x182D0FC20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2D10500", Offset = "0x2D0F900", VA = "0x182D10500", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<HOGBEFGIKOI, HOGBEFGIKOI, HOGBEFGIKOI> IILPOGCDLBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBB")]
			[Cpp2IlInjected.Address(RVA = "0x2D10880", Offset = "0x2D0FC80", VA = "0x182D10880", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(RVA = "0x2D0FE10", Offset = "0x2D0F210", VA = "0x182D0FE10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<HOGBEFGIKOI> JFGDPKHNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBD")]
			[Cpp2IlInjected.Address(RVA = "0x2D11610", Offset = "0x2D10A10", VA = "0x182D11610", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBE")]
			[Cpp2IlInjected.Address(RVA = "0x2D10920", Offset = "0x2D0FD20", VA = "0x182D10920", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2D11490", Offset = "0x2D10890", VA = "0x182D11490", Slot = "23")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2D10060", Offset = "0x2D0F460", VA = "0x182D10060", Slot = "24")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FEB0", Offset = "0x2D0F2B0", VA = "0x182D0FEB0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2D10820", Offset = "0x2D0FC20", VA = "0x182D10820")]
		private void GOOELFIBDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2D11320", Offset = "0x2D10720", VA = "0x182D11320")]
		private void OPAMKKLNKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2D11160", Offset = "0x2D10560", VA = "0x182D11160")]
		private void NJICMCEIEOJ(Entity KCGBIDJFHLF, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ICBMMLPPJIN, DMCBBFPDIBM LPLBPOMCKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D10F20", Offset = "0x2D10320", VA = "0x182D10F20")]
		private void MCLAMANGEPF(Entity KCGBIDJFHLF, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ICBMMLPPJIN, DMCBBFPDIBM LPLBPOMCKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x2019490", Offset = "0x2018890", VA = "0x182019490", Slot = "14")]
		public HOGBEFGIKOI ACNOHAGNJGK(HOGBEFGIKOI DCJOMJHHEFE, int EPBNOPALECM)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x151D1B0", Offset = "0x151C5B0", VA = "0x18151D1B0", Slot = "15")]
		public Color HKEIKADJNBE(HOGBEFGIKOI DCJOMJHHEFE, int EPBNOPALECM)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2D10F80", Offset = "0x2D10380", VA = "0x182D10F80", Slot = "16")]
		public float3 MPPCAOGEKOI(HOGBEFGIKOI DCJOMJHHEFE, int EPBNOPALECM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2D109C0", Offset = "0x2D0FDC0", VA = "0x182D109C0", Slot = "17")]
		public bool HLJDMLPBBFB(HOGBEFGIKOI DCJOMJHHEFE, HOGBEFGIKOI LJEAPAONGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D105A0", Offset = "0x2D0F9A0", VA = "0x182D105A0", Slot = "18")]
		public HOGBEFGIKOI FAHJOPOJKEI(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FCC0", Offset = "0x2D0F0C0", VA = "0x182D0FCC0", Slot = "21")]
		public void CFPNCNGBLLJ(HOGBEFGIKOI DCJOMJHHEFE, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2D10CF0", Offset = "0x2D100F0", VA = "0x182D10CF0", Slot = "22")]
		public bool LAAJICAOKLI(HOGBEFGIKOI DCJOMJHHEFE, out RigidTransform LCICOIKFECE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FB90", Offset = "0x2D0EF90", VA = "0x182D0FB90", Slot = "19")]
		[IteratorStateMachine(typeof(ACLGMKGBGBH))]
		public IEnumerable<HOGBEFGIKOI> ANKPICNLCKN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2D10A70", Offset = "0x2D0FE70", VA = "0x182D10A70", Slot = "20")]
		public HOGBEFGIKOI HMHCOKIEOOG(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2D10650", Offset = "0x2D0FA50", VA = "0x182D10650", Slot = "26")]
		public void FAMECNDEKEN(ref List<HOGBEFGIKOI> CNIGGNPJLOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2D10BD0", Offset = "0x2D0FFD0", VA = "0x182D10BD0")]
		private Entity HMHCOKIEOOG(Entity KCGBIDJFHLF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2D11740", Offset = "0x2D10B40", VA = "0x182D11740")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[BGGFAGPLFND(typeof(ObjectInstantiationService), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Prefabs)]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class ObjectInstantiationService : OIOAOEDFDMG
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI ICDEHOIBFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		[GPKJCAPOIDC]
		private LDEDNDJNIPK OBEJEPJHJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[GPKJCAPOIDC]
		private HJFFEOBFAMB IIGAFOKJCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		[GPKJCAPOIDC]
		private ObjectNetworkToLocalMapService NDPGNEGOBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		[GPKJCAPOIDC]
		private ObjectLifecycleService CLKGBFAJPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		[GPKJCAPOIDC]
		private ObjectPrefabs EELIHJHFEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		[GPKJCAPOIDC]
		private PBJPFABNNDA DJHBFGODLJN;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public int FOFCNFMGCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2A40AB0", Offset = "0x2A3FEB0", VA = "0x182A40AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2A40FF0", Offset = "0x2A403F0", VA = "0x182A40FF0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2A40C30", Offset = "0x2A40030", VA = "0x182A40C30")]
		public Entity GBLBPOEDLKO(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x2A40F00", Offset = "0x2A40300", VA = "0x182A40F00")]
		public Entity LFJKLNGGDME(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x2A40D80", Offset = "0x2A40180", VA = "0x182A40D80")]
		public Entity IADDBEFBPMO(DLABIEOOCHD BBEIPJALHJO, FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x2A40BE0", Offset = "0x2A3FFE0", VA = "0x182A40BE0")]
		public Entity FDPPJMGMAAM(FFIHEMJDJJI CNEFMCCDIIL, bool PKCONJJIEKP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x2A40C30", Offset = "0x2A40030", VA = "0x182A40C30")]
		public Entity FDPPJMGMAAM(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2A40FB0", Offset = "0x2A403B0", VA = "0x182A40FB0")]
		public Entity NOOAPLLHHLE()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2A40B00", Offset = "0x2A3FF00", VA = "0x182A40B00")]
		public Entity BJMENJJIMOG(CDPNPEPOMEC NLAFPPIOFPG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2A40F20", Offset = "0x2A40320", VA = "0x182A40F20")]
		public Entity LJEGHAHIGBK(NNNACFBOHIB NLAFPPIOFPG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2A40CD0", Offset = "0x2A400D0", VA = "0x182A40CD0")]
		public NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)> GBLBPOEDLKO(NativeArray<HOGBEFGIKOI> OAAMCCOBBKO, Allocator NHNCCHNPCJI)
		{
			return default(NativeArray<(HOGBEFGIKOI, HOGBEFGIKOI)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2A40B90", Offset = "0x2A3FF90", VA = "0x182A40B90")]
		public IEnumerable<FFIHEMJDJJI> DBHLMNBJLNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x2A40D20", Offset = "0x2A40120", VA = "0x182A40D20")]
		public EntityArchetype HIMLDABCCHB(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x2A40C70", Offset = "0x2A40070", VA = "0x182A40C70")]
		public Entity FKCALAJIOHB(FFIHEMJDJJI CNEFMCCDIIL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x2A40DE0", Offset = "0x2A401E0", VA = "0x182A40DE0")]
		private Entity KNFNBPCPPAJ(FFIHEMJDJJI CNEFMCCDIIL, DLABIEOOCHD BBEIPJALHJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[BGGFAGPLFND(typeof(HEKPAFKDBLD), new string[] { })]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public sealed class PhysicsSceneColliderService : HEKPAFKDBLD, MPACAJOFKDD, EHPEJLPKBCA, OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private const string DCOJGLPHGKM = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private const int JHFNPDHMGKK = -1;

		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private const int FDIGPAPGNNC = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[GPKJCAPOIDC]
		private LBMLBONIJAH NLNFAPHGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private Collider[] JJBEKMKEIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private RaycastHit[] HOOFCMDHCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private global::PHGCLLNIMJB<HHCCENAFAHO, BoxCollider> CCOBLPJPBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Scene ENNCIIPAJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private PhysicsScene HFOBJFCODOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private GameObject LPLLOMCCPLH;

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public int BLJINHEHPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x2A4E080", Offset = "0x2A4D480", VA = "0x182A4E080", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DD00", Offset = "0x2A4D100", VA = "0x182A4DD00", Slot = "9")]
		public void KHPEEABHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E0C0", Offset = "0x2A4D4C0", VA = "0x182A4E0C0", Slot = "10")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D190", Offset = "0x2A4C590", VA = "0x182A4D190", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DF00", Offset = "0x2A4D300", VA = "0x182A4DF00", Slot = "4")]
		public HHCCENAFAHO LIBHNDIJOCE(Entity KCGBIDJFHLF)
		{
			return default(HHCCENAFAHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CE10", Offset = "0x2A4C210", VA = "0x182A4CE10", Slot = "5")]
		public void BANPELHDDNA(NativeArray<HHCCENAFAHO> DPAEBOCAIMO, NativeArray<GGMEFOFAIEF> JJOGFAELGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DC20", Offset = "0x2A4D020", VA = "0x182A4DC20", Slot = "6")]
		public void IOPNFKGMJGL(HHCCENAFAHO IICPGPKAIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D520", Offset = "0x2A4C920", VA = "0x182A4D520", Slot = "7")]
		public bool GBEDLHMECHL(HHCCENAFAHO IICPGPKAIEH, out Collider HNEJPHOBPOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D610", Offset = "0x2A4CA10", VA = "0x182A4D610")]
		public bool GGDKAPPFLLE(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, Allocator NHNCCHNPCJI, out NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DEB0", Offset = "0x2A4D2B0", VA = "0x182A4DEB0")]
		private void LDGPFJINBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0xCCFAE0", Offset = "0xCCEEE0", VA = "0x180CCFAE0")]
		private void JAEDLDGJGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D5C0", Offset = "0x2A4C9C0", VA = "0x182A4D5C0")]
		private void GFCOLEIJLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x204F800", Offset = "0x204EC00", VA = "0x18204F800")]
		private void GJFEMPHPPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D020", Offset = "0x2A4C420", VA = "0x182A4D020")]
		private BoxCollider CNNECDLOPNL(Entity KCGBIDJFHLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D290", Offset = "0x2A4C690", VA = "0x182A4D290")]
		private void FGKJBGPNEPF(BoxCollider BKANEINDLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DE70", Offset = "0x2A4D270", VA = "0x182A4DE70")]
		[Conditional("UNITY_EDITOR")]
		private void KIMAJHJCEEC(GameObject MGDBDEJKIMA, Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D920", Offset = "0x2A4CD20", VA = "0x182A4D920")]
		private void GMGOJJJECII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DB10", Offset = "0x2A4CF10", VA = "0x182A4DB10")]
		private void HLDECMEGPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D310", Offset = "0x2A4C710", VA = "0x182A4D310")]
		private void FPCGCNBEKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E050", Offset = "0x2A4D450", VA = "0x182A4E050")]
		private void OJPAILBJIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DCF0", Offset = "0x2A4D0F0", VA = "0x182A4DCF0")]
		private void KEMAHGDJGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D140", Offset = "0x2A4C540", VA = "0x182A4D140")]
		private void COCLEPAELAL(Scene IFOHLANJPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D180", Offset = "0x2A4C580", VA = "0x182A4D180", Slot = "8")]
		private bool DHEJPNOLEFM(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, Allocator NHNCCHNPCJI, out NativeArray<Entity> IHPLCMEEOEJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
[BGGFAGPLFND(typeof(AOKOBIPCECP), new string[] { })]
public sealed class KBPPKHPODID : AOKOBIPCECP, OIOAOEDFDMG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	private struct KGMAKALKCDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public float KBBAFLEKIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public uint BFFKJIHCFNC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private MPACAJOFKDD PCABHJOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private LHGPFCJOOOP OFIFLJCJBCE;

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x2C83A20", Offset = "0x2C82E20", VA = "0x182C83A20", Slot = "5")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x2C834A0", Offset = "0x2C828A0", VA = "0x182C834A0")]
	public bool GGDKAPPFLLE(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, out IDGCCMDOIEN JLLOLEMHKHB, out Entity FEFLJODMCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x2C83920", Offset = "0x2C82D20", VA = "0x182C83920")]
	public static bool JPGJLEDPIJI(in Span<IDGCCMDOIEN> NHPABFIJNJC, float PAKNAMCBNFF, out int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x2C83460", Offset = "0x2C82860", VA = "0x182C83460")]
	public static float DJOHEJOOFLA(float KBBAFLEKIJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public KBPPKHPODID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x2C83490", Offset = "0x2C82890", VA = "0x182C83490", Slot = "4")]
	private bool FNDGPHPNJHC(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, out IDGCCMDOIEN JLLOLEMHKHB, out Entity FEFLJODMCEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[BGGFAGPLFND(typeof(LHGPFCJOOOP), new string[] { })]
public sealed class NNAKJADFBOA : LHGPFCJOOOP, OIOAOEDFDMG
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[BurstCompile]
	private struct MFBHKHCJGMH : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		[ReadOnly]
		public NativeArray<Entity> IHPLCMEEOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		[ReadOnly]
		public float3 PDGMDOGIEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		[ReadOnly]
		public float3 LLKHDCGFDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> PCMHNNIHDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> GKKDBEPABPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> KOKFAHMIFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> NICPOAELMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> EPEIHFMHFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[WriteOnly]
		public NativeArray<IDGCCMDOIEN> KIGMKCCIIJH;

		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private static readonly IDGCCMDOIEN IBDFJNNFJOD;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x45C4FB0", Offset = "0x45C43B0", VA = "0x1845C4FB0", Slot = "4")]
		public void Execute(int PGFOAHEHPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x45C55E0", Offset = "0x45C49E0", VA = "0x1845C55E0")]
		private static float3 HMFNALNHEDO(in float4x4 PHKMPFENAIO, in float3 PMLBPCJAADD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x45C5E80", Offset = "0x45C5280", VA = "0x1845C5E80")]
		private static float3 PLCLIIHJBCN(in float4x4 PHKMPFENAIO, in float3 PFEJCBNJLGA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x45C56B0", Offset = "0x45C4AB0", VA = "0x1845C56B0")]
		private static float3 OPBKMFJJDJG(in float4x4 PHKMPFENAIO, in float3 PMLBPCJAADD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x45C4D90", Offset = "0x45C4190", VA = "0x1845C4D90")]
		private static float3 DIBBJGHCCNM(in float4x4 PHKMPFENAIO, in float3 PFEJCBNJLGA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x45C5290", Offset = "0x45C4690", VA = "0x1845C5290")]
		private bool HJIGBHADHMO(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, in NativeArray<Entity> NDOGEEBALBP, out float3 JLLOLEMHKHB, out float3 EMLKPCFFBLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x45C57B0", Offset = "0x45C4BB0", VA = "0x1845C57B0")]
		public static bool PJFJGMLHIEJ(in float3 MDGGEDAHJMC, in float3 CAELJIIDKGK, in float3 KBIFJHPJBLG, in float3 CNEBGCHPJCP, float DFFHGFODDIL, float ECNANCDNFBD, out float PMFPAMNENCI, out float3 PIJNGNJGCHN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BFC0", Offset = "0x2A3B3C0", VA = "0x182A3BFC0", Slot = "5")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD30", Offset = "0x2A3B130", VA = "0x182A3BD30")]
	public void GGDKAPPFLLE(in NativeArray<Entity> IHPLCMEEOEJ, in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, in NativeArray<IDGCCMDOIEN> NLAMHPDBMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public NNAKJADFBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x2A3BD30", Offset = "0x2A3B130", VA = "0x182A3BD30", Slot = "4")]
	private void KBMPEELMIKC(in NativeArray<Entity> IHPLCMEEOEJ, in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, in NativeArray<IDGCCMDOIEN> NLAMHPDBMJJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[AFAPMPFKDID(JCDEPCAPNFC.Embodiment)]
	[BGGFAGPLFND(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[GPKJCAPOIDC]
		private FGEHAOHAFDI LIDPFPMMNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[GPKJCAPOIDC]
		private LDEDNDJNIPK POFGCNJGDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[GPKJCAPOIDC]
		private HJFFEOBFAMB FHDNLNILLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private IANFCDGCLMD OMBDCMFHFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private NativeHashMap<DLABIEOOCHD, Entity> DCGGKGIKGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private EntityManager KLFKJJDHNIL;

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal NativeHashMap<DLABIEOOCHD, Entity> ENOGBLCCHCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0x1303BE0", Offset = "0x1302FE0", VA = "0x181303BE0")]
			get
			{
				return default(NativeHashMap<DLABIEOOCHD, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal uint LOMENBNHFGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x2A44320", Offset = "0x2A43720", VA = "0x182A44320")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool EMADIPGMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0x81CCE0", Offset = "0x81C0E0", VA = "0x18081CCE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xDDCB70", Offset = "0xDDBF70", VA = "0x180DDCB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2A44380", Offset = "0x2A43780", VA = "0x182A44380", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2A43F90", Offset = "0x2A43390", VA = "0x182A43F90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2A44170", Offset = "0x2A43570", VA = "0x182A44170")]
		public void HLOEIBCGJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2A43CE0", Offset = "0x2A430E0", VA = "0x182A43CE0")]
		public void CFINLOKEOPD(DLABIEOOCHD BBEIPJALHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x2A44350", Offset = "0x2A43750", VA = "0x182A44350")]
		private HOGBEFGIKOI NPCPKDAOGEH(Entity KCGBIDJFHLF)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x2A44000", Offset = "0x2A43400", VA = "0x182A44000")]
		public HOGBEFGIKOI HAOPAHLBONF(DLABIEOOCHD BBEIPJALHJO)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x2A440E0", Offset = "0x2A434E0", VA = "0x182A440E0")]
		public DLABIEOOCHD HGPHDEFJFGN(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(DLABIEOOCHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2A43EA0", Offset = "0x2A432A0", VA = "0x182A43EA0")]
		public void DEGHGENDIEK(Entity KCGBIDJFHLF, DLABIEOOCHD BBEIPJALHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2A442C0", Offset = "0x2A436C0", VA = "0x182A442C0")]
		public void MCPOMLLBGGI(Entity KCGBIDJFHLF, DLABIEOOCHD BBEIPJALHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2A43F30", Offset = "0x2A43330", VA = "0x182A43F30")]
		public void DLOGDBHAKFI(Entity KCGBIDJFHLF, DLABIEOOCHD BBEIPJALHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2A441F0", Offset = "0x2A435F0", VA = "0x182A441F0")]
		public void LEPDPFKBKCF(Entity KCGBIDJFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
	[AFAPMPFKDID(JCDEPCAPNFC.Callbacks)]
	[BGGFAGPLFND(typeof(PropertyEventCallbacksService), new string[] { })]
	public class PropertyEventCallbacksService : OIOAOEDFDMG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001BF")]
		private struct HDAOKKDPCCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			public EBGGGHLMLAJ EGLKIOCIBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public Type NLAFPPIOFPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			public int FOADGJOOFID;
		}

		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		private struct HKFHMFMKKEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public HDAOKKDPCCM[] CKCKOLCCJBK;
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public delegate void EBGGGHLMLAJ(Entity KCGBIDJFHLF, EKCDKOGIIEF FHKHLDOKDFM, DMCBBFPDIBM ICBMMLPPJIN, DMCBBFPDIBM LPLBPOMCKIG);

		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private readonly Dictionary<EKCDKOGIIEF, EBGGGHLMLAJ> OIJPMOCPAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private readonly Dictionary<int, HKFHMFMKKEJ> NNOMNDFKFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private JFAKMNMKBKN CKCKOLCCJBK;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action NDLBOIKMDPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2A548A0", Offset = "0x2A53CA0", VA = "0x182A548A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x2A54940", Offset = "0x2A53D40", VA = "0x182A54940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action COALBNNKCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x2A54710", Offset = "0x2A53B10", VA = "0x182A54710")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x2A541E0", Offset = "0x2A535E0", VA = "0x182A541E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2A54DE0", Offset = "0x2A541E0", VA = "0x182A54DE0", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2A54400", Offset = "0x2A53800", VA = "0x182A54400", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2A549E0", Offset = "0x2A53DE0", VA = "0x182A549E0")]
		public void MGGHGLFMIKB(EKCDKOGIIEF FHKHLDOKDFM, EBGGGHLMLAJ EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2A547B0", Offset = "0x2A53BB0", VA = "0x182A547B0")]
		public void IMEDOJDENFA(EKCDKOGIIEF FHKHLDOKDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2A54B50", Offset = "0x2A53F50", VA = "0x182A54B50")]
		internal void MNNBOIJILCA(LIMLHMBKDHE AGOKAPGFDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2A53CA0", Offset = "0x2A530A0", VA = "0x182A53CA0")]
		private void BCGCNKHOMPD(LIMLHMBKDHE AGOKAPGFDDL, int IJKBMAIIDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x2A54490", Offset = "0x2A53890", VA = "0x182A54490")]
		private void FOCGBICEPEI(HAKAHGDBIOD GPGIOJFGNNC, MDNFODCBPDK MOKKDKPBGJI, HDAOKKDPCCM AFDACEMPBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x2A54280", Offset = "0x2A53680", VA = "0x182A54280")]
		private HKFHMFMKKEJ CCGBBPDJNED(HAKAHGDBIOD GPGIOJFGNNC, MDNFODCBPDK MOKKDKPBGJI)
		{
			return default(HKFHMFMKKEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2A53BB0", Offset = "0x2A52FB0", VA = "0x182A53BB0")]
		private HDAOKKDPCCM AJFIEPNONCJ(HKFHMFMKKEJ GLIPIAPKOKG, HAKAHGDBIOD GPGIOJFGNNC, MDNFODCBPDK MOKKDKPBGJI)
		{
			return default(HDAOKKDPCCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2A54E80", Offset = "0x2A54280", VA = "0x182A54E80")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
[BGGFAGPLFND(typeof(GNOAFGFBGKD), new string[] { })]
public class PJIBJPLLCII : OIOAOEDFDMG, BIJJPFLHCDJ, GNOAFGFBGKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class MDCLJCNGDGJ : IEnumerable<HOGBEFGIKOI>, IEnumerable, IEnumerator<HOGBEFGIKOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private HOGBEFGIKOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public PJIBJPLLCII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private HOGBEFGIKOI splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public HOGBEFGIKOI <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		private HOGBEFGIKOI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C56")]
			[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HOGBEFGIKOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C58")]
			[Cpp2IlInjected.Address(RVA = "0x45C4D40", Offset = "0x45C4140", VA = "0x1845C4D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAAD540", VA = "0x180AAE140")]
		[DebuggerHidden]
		public MDCLJCNGDGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x45C4B90", Offset = "0x45C3F90", VA = "0x1845C4B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x45C4D00", Offset = "0x45C4100", VA = "0x1845C4D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x45C4C50", Offset = "0x45C4050", VA = "0x1845C4C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HOGBEFGIKOI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x45C4C50", Offset = "0x45C4050", VA = "0x1845C4C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private IANFCDGCLMD OMBDCMFHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private COFBLKKABHP DKMOLIAHNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	private ObjectInstantiationService EELIHJHFEMH;

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B280", Offset = "0x2A4A680", VA = "0x182A4B280")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private NPLLDKEDKFD KBCPAMGBEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B390", Offset = "0x2A4A790", VA = "0x182A4B390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B8F0", Offset = "0x2A4ACF0", VA = "0x182A4B8F0", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AD80", Offset = "0x2A4A180", VA = "0x182A4AD80", Slot = "5")]
	public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x2A4ACD0", Offset = "0x2A4A0D0", VA = "0x182A4ACD0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AE80", Offset = "0x2A4A280", VA = "0x182A4AE80")]
	private void EENFCGCFIEL(Entity DDNMGEIBIAC, in DMCBBFPDIBM KFCDAKJGAEM, in DMCBBFPDIBM NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B870", Offset = "0x2A4AC70", VA = "0x182A4B870", Slot = "14")]
	public HOGBEFGIKOI NOOAPLLHHLE()
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B520", Offset = "0x2A4A920", VA = "0x182A4B520", Slot = "10")]
	public void KGEIHPEAPAB(HOGBEFGIKOI DCJOMJHHEFE, DNOIBALCHPH DALCKALNCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B2D0", Offset = "0x2A4A6D0", VA = "0x182A4B2D0", Slot = "9")]
	public DNOIBALCHPH IADDLEAIKKN(HOGBEFGIKOI DCJOMJHHEFE)
	{
		return default(DNOIBALCHPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A9B0", Offset = "0x2A49DB0", VA = "0x182A4A9B0", Slot = "11")]
	public HOGBEFGIKOI DKAJLFLGHFL(HOGBEFGIKOI MBBKGMLAEGI, [Optional] Vector3? IAMBOGDEHMB, [Optional] Quaternion? BOMBFPIEJKJ, [Optional] Vector3? PDDMGAHIAAG)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B4E0", Offset = "0x2A4A8E0", VA = "0x182A4B4E0", Slot = "15")]
	public HOGBEFGIKOI JKHGMBKLGFM(HOGBEFGIKOI ALMCMCFJIAP, int PGFOAHEHPOH, [Optional] Vector3? IAMBOGDEHMB, [Optional] Quaternion? BOMBFPIEJKJ, [Optional] Vector3? PDDMGAHIAAG)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B5E0", Offset = "0x2A4A9E0", VA = "0x182A4B5E0", Slot = "7")]
	public HOGBEFGIKOI KKHKIDEHOEN(HOGBEFGIKOI ALMCMCFJIAP, int PGFOAHEHPOH)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B1C0", Offset = "0x2A4A5C0", VA = "0x182A4B1C0", Slot = "16")]
	public void FKBMPNJODNO(HOGBEFGIKOI ALMCMCFJIAP, HOGBEFGIKOI COOOOOEEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B6D0", Offset = "0x2A4AAD0", VA = "0x182A4B6D0", Slot = "12")]
	public void LIFNPNBFHIL(HOGBEFGIKOI ALMCMCFJIAP, int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A810", Offset = "0x2A49C10", VA = "0x182A4A810", Slot = "17")]
	public void CMFPEPAFBOF(HOGBEFGIKOI ALMCMCFJIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A770", Offset = "0x2A49B70", VA = "0x182A4A770", Slot = "8")]
	public int BNNPAFMBCOA(HOGBEFGIKOI ALMCMCFJIAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B450", Offset = "0x2A4A850", VA = "0x182A4B450", Slot = "6")]
	[IteratorStateMachine(typeof(MDCLJCNGDGJ))]
	public IEnumerable<HOGBEFGIKOI> JFDDKMDJJLP(HOGBEFGIKOI ALMCMCFJIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A6E0", Offset = "0x2A49AE0", VA = "0x182A4A6E0")]
	private bool AMNOHCJKLCC(HOGBEFGIKOI ALMCMCFJIAP, out NativeArray<Entity> CJDMCMNNBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B100", Offset = "0x2A4A500", VA = "0x182A4B100")]
	private NativeArray<Entity> EIKHPLKJIOF(HOGBEFGIKOI ALMCMCFJIAP)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PJIBJPLLCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[CIKFNDBCLGD(BADKLKEFGCO.LoadInstance)]
[BGGFAGPLFND(typeof(MLGKMOEOAJD), new string[] { })]
internal sealed class MLGKMOEOAJD : OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private FGEHAOHAFDI ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private TransformOwnershipPhase POHJJICNBLO;

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private DOGKLJKKAGC KHGEGLGEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2A36770", Offset = "0x2A35B70", VA = "0x182A36770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A36B80", Offset = "0x2A35F80", VA = "0x182A36B80", Slot = "4")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x2A367C0", Offset = "0x2A35BC0", VA = "0x182A367C0")]
	public void MCBFDPIAKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x2A368B0", Offset = "0x2A35CB0", VA = "0x182A368B0")]
	public void NKKELJHPHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MLGKMOEOAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
public readonly struct DBNOMNPPMPN : IEquatable<DBNOMNPPMPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private readonly int IJKBMAIIDGK;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Type JAKOAABNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0x2D15690", Offset = "0x2D14A90", VA = "0x182D15690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2D157A0", Offset = "0x2D14BA0", VA = "0x182D157A0")]
	public DBNOMNPPMPN(Type NLAFPPIOFPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2D15640", Offset = "0x2D14A40", VA = "0x182D15640")]
	public static DBNOMNPPMPN IGKGMCHPHKB(Type NLAFPPIOFPG)
	{
		return default(DBNOMNPPMPN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2D15670", Offset = "0x2D14A70", VA = "0x182D15670")]
	public static Type IGKGMCHPHKB(DBNOMNPPMPN IICPGPKAIEH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0xBA3660", Offset = "0xBA2A60", VA = "0x180BA3660")]
	public static bool HOHCOENENOO(DBNOMNPPMPN ANJGLCCJFPO, DBNOMNPPMPN ABBMKKCGFBG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0xBA3660", Offset = "0xBA2A60", VA = "0x180BA3660")]
	public static bool GJGNKFAGFPG(DBNOMNPPMPN ANJGLCCJFPO, DBNOMNPPMPN ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x84E6A0", Offset = "0x84DAA0", VA = "0x18084E6A0", Slot = "4")]
	public bool Equals(DBNOMNPPMPN BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x2D155C0", Offset = "0x2D149C0", VA = "0x182D155C0", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x2D15770", Offset = "0x2D14B70", VA = "0x182D15770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
public static class AOMIMGMICPO
{
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private static Dictionary<Type, int> AHMEDEFMBMJ;

	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private static List<Type> PGOGMLANOKM;

	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x2D02A00", Offset = "0x2D01E00", VA = "0x182D02A00")]
	static AOMIMGMICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x282A8E0", Offset = "0x2829CE0", VA = "0x18282A8E0")]
	public static bool EIPAABBBFMM<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x2D02990", Offset = "0x2D01D90", VA = "0x182D02990")]
	public static bool EIPAABBBFMM(Type NLAFPPIOFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x2D02820", Offset = "0x2D01C20", VA = "0x182D02820")]
	private static bool EIPAABBBFMM(Type NLAFPPIOFPG, out int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x282A850", Offset = "0x2829C50", VA = "0x18282A850")]
	public static int EAJBBMPDAHB<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x2D027B0", Offset = "0x2D01BB0", VA = "0x182D027B0")]
	public static int EAJBBMPDAHB(Type NLAFPPIOFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x282A7B0", Offset = "0x2829BB0", VA = "0x18282A7B0")]
	public static bool DPPKACEDDDN<T>(out int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x2D02710", Offset = "0x2D01B10", VA = "0x182D02710")]
	public static bool DPPKACEDDDN(Type NLAFPPIOFPG, out int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x2D02550", Offset = "0x2D01950", VA = "0x182D02550")]
	public static Type DPALGOGEJPD(int PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x2D025F0", Offset = "0x2D019F0", VA = "0x182D025F0")]
	public static bool DPPKACEDDDN(int PGFOAHEHPOH, out Type NLAFPPIOFPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[DefaultMember("Item")]
public struct KFBDPDDPGMJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private T[] HANEMGLFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private int EBMDFJGMEAO;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x76C5E0", Offset = "0x76B9E0", VA = "0x18076C5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2321B30", Offset = "0x2320F30", VA = "0x182321B30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Span<T> JDLPGDEBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x35101A0", Offset = "0x350F5A0", VA = "0x1835101A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x924FA0", Offset = "0x9243A0", VA = "0x180924FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C78")]
	[Cpp2IlInjected.Address(RVA = "0x35102F0", Offset = "0x350F6F0", VA = "0x1835102F0")]
	public KFBDPDDPGMJ(int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C79")]
	[Cpp2IlInjected.Address(RVA = "0x3510240", Offset = "0x350F640", VA = "0x183510240")]
	public int LPHHEGFFIAL(T PKODKJLGOIN, int BOIMPMGFDJM, int EFJDLDLIAEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7A")]
	[Cpp2IlInjected.Address(RVA = "0x35100E0", Offset = "0x350F4E0", VA = "0x1835100E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
[DefaultMember("Item")]
public struct KHBLDMOGIFC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private global::KFBDPDDPGMJ<T> HANEMGLFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private int EBMDFJGMEAO;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3510720", Offset = "0x350FB20", VA = "0x183510720")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x35111B0", Offset = "0x35105B0", VA = "0x1835111B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int BOODKFKIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x3511E90", Offset = "0x3511290", VA = "0x183511E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x3511DE0", Offset = "0x35111E0", VA = "0x183511DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x3510D70", Offset = "0x3510170", VA = "0x183510D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> JDLPGDEBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x3511690", Offset = "0x3510A90", VA = "0x183511690")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x3512130", Offset = "0x3511530", VA = "0x183512130")]
	public KHBLDMOGIFC(int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x35107C0", Offset = "0x350FBC0", VA = "0x1835107C0")]
	public T CDLCOALMIJB(int PGFOAHEHPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x3510810", Offset = "0x350FC10", VA = "0x183510810")]
	public void CFMNLPLFMMA(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0x35114F0", Offset = "0x35108F0", VA = "0x1835114F0")]
	public void GPAKKAGHFJH(Span<T> BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x3510DF0", Offset = "0x35101F0", VA = "0x183510DF0")]
	public void EIPAABBBFMM(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x3510890", Offset = "0x350FC90", VA = "0x183510890")]
	private void CIPOPCBDLDB(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x3511B50", Offset = "0x3510F50", VA = "0x183511B50")]
	public void MNIBHCAMCCO(Span<T> FAFJGGGCDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x3510BD0", Offset = "0x350FFD0", VA = "0x183510BD0")]
	public void DBLOPOMEFMO(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x3510F10", Offset = "0x3510310", VA = "0x183510F10")]
	public void EJJPKDGHPFI(int JDJJEHDGFDE, int NBODAMBMIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8B")]
	[Cpp2IlInjected.Address(RVA = "0x3511490", Offset = "0x3510890", VA = "0x183511490")]
	public void GOBFDDIOGIM(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0x3511200", Offset = "0x3510600", VA = "0x183511200")]
	public void GKNACMGGJKK(int JDJJEHDGFDE, int NBODAMBMIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0x3510520", Offset = "0x350F920", VA = "0x183510520")]
	public void ADHKJJDCDMN(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0x3511A00", Offset = "0x3510E00", VA = "0x183511A00")]
	public void JGJLLDHCCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0x3511AC0", Offset = "0x3510EC0", VA = "0x183511AC0")]
	public int LPHHEGFFIAL(T PKODKJLGOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0x3511E30", Offset = "0x3511230", VA = "0x183511E30")]
	public bool OOGLABKJNAC(T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x3510DA0", Offset = "0x35101A0", VA = "0x183510DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x35120C0", Offset = "0x35114C0", VA = "0x1835120C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x3511990", Offset = "0x3510D90", VA = "0x183511990")]
	public static Span<T> IGKGMCHPHKB(global::KHBLDMOGIFC<T> BEOMDPHLMGK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x3510C30", Offset = "0x3510030", VA = "0x183510C30")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DGIIDFMDIKG(int PKODKJLGOIN, int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void HIGCHHMPCCN(int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x3511830", Offset = "0x3510C30", VA = "0x183511830")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void HIGCHHMPCCN(int EBMDFJGMEAO, int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0x35105E0", Offset = "0x350F9E0", VA = "0x1835105E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void BLCOIBCNDBH(int PKODKJLGOIN, int EBMDFJGMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x3511EC0", Offset = "0x35112C0", VA = "0x183511EC0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void POIDJLNBGBK(int JDJJEHDGFDE, int NBODAMBMIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x3510A90", Offset = "0x350FE90", VA = "0x183510A90")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CJGGBLEIAKI(int PKODKJLGOIN, int EBMDFJGMEAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
public struct MELNNNHAMLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private const int JCGLLPOHBJD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private NativeList<Entity> IHPLCMEEOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private TransformAccessArray KPJDOIFOFHA;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2C88170", Offset = "0x2C87570", VA = "0x182C88170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public NativeList<Entity> OJIGDFFECEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0xCFDD60", Offset = "0xCFD160", VA = "0x180CFDD60")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public TransformAccessArray IMILONIIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9D")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9E")]
		[Cpp2IlInjected.Address(RVA = "0x2C88150", Offset = "0x2C87550", VA = "0x182C88150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2C88270", Offset = "0x2C87670", VA = "0x182C88270")]
	public MELNNNHAMLB(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x2C881C0", Offset = "0x2C875C0", VA = "0x182C881C0")]
	public Entity JLCDGLCPHNE(int PGFOAHEHPOH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2C88260", Offset = "0x2C87660", VA = "0x182C88260")]
	public Transform OBIOFHAKCKC(int PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2C88210", Offset = "0x2C87610", VA = "0x182C88210")]
	public void JPLDDEAHAHF(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2C88080", Offset = "0x2C87480", VA = "0x182C88080")]
	public int EIPAABBBFMM(Transform ENMFIMJMMCO, Entity KCGBIDJFHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2C87F80", Offset = "0x2C87380", VA = "0x182C87F80")]
	public int DBLOPOMEFMO(int PGFOAHEHPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2C88000", Offset = "0x2C87400", VA = "0x182C88000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2C88180", Offset = "0x2C87580", VA = "0x182C88180")]
	private void GLKJPEOCKHE(int DKLCIPBCDOP = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class NECLPPGBKAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private NativeHashMap<DBNOMNPPMPN, int2> GFLONMFMLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private NativeList<byte> BPMIJGKONLK;

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B290", Offset = "0x2A3A690", VA = "0x182A3B290")]
	public NECLPPGBKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B020", Offset = "0x2A3A420", VA = "0x182A3B020")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	public void JKDFMHKJMMK<T>(T PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	public T DPALGOGEJPD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAA")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B080", Offset = "0x2A3A480", VA = "0x182A3B080")]
	public void JKDFMHKJMMK(Type NLAFPPIOFPG, DMCBBFPDIBM PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AC50", Offset = "0x2A3A050", VA = "0x182A3AC50")]
	public DMCBBFPDIBM DPALGOGEJPD(Type NLAFPPIOFPG)
	{
		return default(DMCBBFPDIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABB0", Offset = "0x2A39FB0", VA = "0x182A3ABB0")]
	private NativeArray<byte> BJNCKINLMDJ(int2 ICFHJGNHLJB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AE60", Offset = "0x2A3A260", VA = "0x182A3AE60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAE")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AF00", Offset = "0x2A3A300", VA = "0x182A3AF00", Slot = "1")]
	~NECLPPGBKAP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001CB")]
public struct HBIDHMNHNME<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000171")]
	internal static T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB0")]
	public static global::HBIDHMNHNME<T> IGKGMCHPHKB(T PKODKJLGOIN)
	{
		return default(global::HBIDHMNHNME<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB1")]
	public static T IGKGMCHPHKB(global::HBIDHMNHNME<T> NANCDEAMBKG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public static class DKBEJLFLDHK
{
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private static readonly NECLPPGBKAP JBJMKLKPAJN;

	[Cpp2IlInjected.Token(Token = "0x6000CB2")]
	[Cpp2IlInjected.Address(RVA = "0x2D164E0", Offset = "0x2D158E0", VA = "0x182D164E0")]
	internal static void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	public static void JKDFMHKJMMK<T>(T PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2D16550", Offset = "0x2D15950", VA = "0x182D16550")]
	public static void JKDFMHKJMMK(Type NLAFPPIOFPG, DMCBBFPDIBM PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	public static T DPALGOGEJPD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2D16440", Offset = "0x2D15840", VA = "0x182D16440")]
	public static DMCBBFPDIBM DPALGOGEJPD(Type NLAFPPIOFPG)
	{
		return default(DMCBBFPDIBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public class DLEOJFPLFIG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	public static readonly DLEOJFPLFIG MGJBOLMPFNF;

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2D16660", Offset = "0x2D15A60", VA = "0x182D16660", Slot = "4")]
	public bool Equals(LinkedEntityGroup HHAEMEGNPGJ, LinkedEntityGroup ACCHMFPFGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2D16680", Offset = "0x2D15A80", VA = "0x182D16680", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup HKFNIHLBEHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public DLEOJFPLFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class BOMCGDEDPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GPCHEHNKBMA(in Vector3 IAMBOGDEHMB, in Quaternion BOMBFPIEJKJ, in Vector3 PDDMGAHIAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void LNINKMEPCHA(in Vector3 JOMKICEAGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GMCCCMGOEAB(in Quaternion BOMBFPIEJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void LDNMFAHHPNJ(in Vector3 CKMIGMECKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void PBJCMMHPEAH(in Vector3 CKMIGMECKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void KOCIICHKLBE(in float BNNOKKELMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2D06EB0", Offset = "0x2D062B0", VA = "0x182D06EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BOHIIOIGGKI(in float3 PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EADNOFPDHBB(in float PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2D06FE0", Offset = "0x2D063E0", VA = "0x182D06FE0")]
	[Conditional("DEBUG_BUILD")]
	public static void EADNOFPDHBB(in Vector3 PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x2D07030", Offset = "0x2D06430", VA = "0x182D07030")]
	[Conditional("DEBUG_BUILD")]
	public static void EADNOFPDHBB(in Quaternion PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x2D06F60", Offset = "0x2D06360", VA = "0x182D06F60")]
	[Conditional("DEBUG_BUILD")]
	public static void DFLACLOGPCB(in float PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x2D06FA0", Offset = "0x2D063A0", VA = "0x182D06FA0")]
	[Conditional("DEBUG_BUILD")]
	public static void DFLACLOGPCB(in Vector3 PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2D06F70", Offset = "0x2D06370", VA = "0x182D06F70")]
	[Conditional("DEBUG_BUILD")]
	public static void DFLACLOGPCB(in Quaternion PKODKJLGOIN, string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BOMCGDEDPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
public struct AJGCMCOKHHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	public Entity KCGBIDJFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	public Entity JMCOICNPJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	public Entity GIJFJALMMOL;

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2D01430", Offset = "0x2D00830", VA = "0x182D01430")]
	public AJGCMCOKHHP(Entity KCGBIDJFHLF, Entity JMCOICNPJLH, Entity GIJFJALMMOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CCB")]
	[Cpp2IlInjected.Address(RVA = "0x2D013D0", Offset = "0x2D007D0", VA = "0x182D013D0")]
	public static AJGCMCOKHHP IGKGMCHPHKB((Entity entity, Entity oldParent, Entity newParent) GJLLOHMFDJE)
	{
		return default(AJGCMCOKHHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCC")]
	[Cpp2IlInjected.Address(RVA = "0x2D01410", Offset = "0x2D00810", VA = "0x182D01410")]
	public void LEBFDCFJPJP(out Entity KCGBIDJFHLF, out Entity JMCOICNPJLH, out Entity GIJFJALMMOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public struct BAGOHMBBHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	public Entity KCGBIDJFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	public Entity BLENCGKHIJI;

	[Cpp2IlInjected.Token(Token = "0x6000CCD")]
	[Cpp2IlInjected.Address(RVA = "0xF6AF50", Offset = "0xF6A350", VA = "0x180F6AF50")]
	public BAGOHMBBHPA(Entity KCGBIDJFHLF, Entity BLENCGKHIJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2D04A10", Offset = "0x2D03E10", VA = "0x182D04A10")]
	public static BAGOHMBBHPA IGKGMCHPHKB((Entity entity, Entity parent) GJLLOHMFDJE)
	{
		return default(BAGOHMBBHPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2D04A40", Offset = "0x2D03E40", VA = "0x182D04A40")]
	public void LEBFDCFJPJP(out Entity KCGBIDJFHLF, out Entity BLENCGKHIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public struct FNBBGIBCFGA<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private GCHandle IICPGPKAIEH;

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool COODBDDJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC870", Offset = "0x2CFBC70", VA = "0x182CFC870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x3781290", Offset = "0x3780690", VA = "0x183781290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x3781360", Offset = "0x3780760", VA = "0x183781360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x3781420", Offset = "0x3780820", VA = "0x183781420")]
	public FNBBGIBCFGA(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x3781330", Offset = "0x3780730", VA = "0x183781330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public enum IODLKGKFLPA
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public struct MGDPNDCFNMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public IODLKGKFLPA HDBCIBLIGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public int EAAHGFKJLJA;

	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
	public MGDPNDCFNMK(IODLKGKFLPA HDBCIBLIGPO, int EAAHGFKJLJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x2C882F0", Offset = "0x2C876F0", VA = "0x182C882F0")]
	public static MGDPNDCFNMK IGKGMCHPHKB((IODLKGKFLPA eventType, int eventIndex) HHAEMEGNPGJ)
	{
		return default(MGDPNDCFNMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x2C88310", Offset = "0x2C87710", VA = "0x182C88310")]
	public void LEBFDCFJPJP(out IODLKGKFLPA HDBCIBLIGPO, out int EAAHGFKJLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
[BGGFAGPLFND(typeof(MPACAJOFKDD), new string[] { })]
public sealed class FNBCJJGEIKB : MPACAJOFKDD, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private HEKPAFKDBLD PDBFBDMLDPB;

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x2C740F0", Offset = "0x2C734F0", VA = "0x182C740F0", Slot = "5")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2C74050", Offset = "0x2C73450", VA = "0x182C74050")]
	public bool GGDKAPPFLLE(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, Allocator NHNCCHNPCJI, out NativeArray<Entity> IHPLCMEEOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FNBCJJGEIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2C74050", Offset = "0x2C73450", VA = "0x182C74050", Slot = "4")]
	private bool DHEJPNOLEFM(in float3 NMEEAGEKJAF, in float3 IJOKHPEAHHL, float PAKNAMCBNFF, Allocator NHNCCHNPCJI, out NativeArray<Entity> IHPLCMEEOEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(AEGIDOOLGBC))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal sealed class IJDHIEEIHEE : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2C800A0", Offset = "0x2C7F4A0", VA = "0x182C800A0", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public IJDHIEEIHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(DNHCEONGJON))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
public sealed class OCOJCGCHIJB : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C040", Offset = "0x2A3B440", VA = "0x182A3C040", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public OCOJCGCHIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[NEKKAFLHHJJ]
[UpdateInGroup(typeof(FGGFGHNNJIF))]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
internal sealed class DELMCDODDFL : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2D15A90", Offset = "0x2D14E90", VA = "0x182D15A90", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public DELMCDODDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class PFKDAEDANMO : HIEMLNGKCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public PFKDAEDANMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[NEKKAFLHHJJ]
[ExecuteAlways]
[KJKMMMHBKLF(BADKLKEFGCO.LoadInstance)]
[UpdateInGroup(typeof(IMAGNLAEPGD))]
internal sealed class GBBIMEMIDOB : KDNDLNICKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x2C74340", Offset = "0x2C73740", VA = "0x182C74340", Slot = "16")]
	protected override ComponentSystemBase LNDALPBDGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x2A3ABA0", Offset = "0x2A39FA0", VA = "0x182A3ABA0")]
	public GBBIMEMIDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
[BLFPDGNAKFF(typeof(AuthoredLocalPoseData))]
public sealed class GMKANFOPLIG : IEPDEOJFPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2C79F40", Offset = "0x2C79340", VA = "0x182C79F40", Slot = "8")]
	protected override bool EIOANJMFCHN(ReadOnlySpan<AuthoredLocalPoseData> FAFJGGGCDPH, DDAIMAPAILI ANOCPAKAOKI, out ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2C79E80", Offset = "0x2C79280", VA = "0x182C79E80", Slot = "9")]
	protected override bool CAJOMCEOAEA(int CELCPLLAAGH, Span<AuthoredLocalPoseData> FAFJGGGCDPH, in ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x2C79FC0", Offset = "0x2C793C0", VA = "0x182C79FC0")]
	public GMKANFOPLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[BLFPDGNAKFF(typeof(LocalPoseData))]
public sealed class JCPEPGAKKMO : DHAONIDBCCD
{
	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x2C81FF0", Offset = "0x2C813F0", VA = "0x182C81FF0", Slot = "8")]
	protected override bool EIOANJMFCHN(ReadOnlySpan<LocalPoseData> FAFJGGGCDPH, DDAIMAPAILI ANOCPAKAOKI, out ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x2C81F30", Offset = "0x2C81330", VA = "0x182C81F30", Slot = "9")]
	protected override bool CAJOMCEOAEA(int CELCPLLAAGH, Span<LocalPoseData> FAFJGGGCDPH, in ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x2C82070", Offset = "0x2C81470", VA = "0x182C82070")]
	public JCPEPGAKKMO()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9720", Offset = "0x2BE8B20", VA = "0x182BE9720", Slot = "6")]
		public sealed override void HGCIEPNFBCH(LDNEHEGKOKK EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8C80", Offset = "0x2BE8080", VA = "0x182BE8C80", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000CF3")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x2C80F60", Offset = "0x2C80360", VA = "0x182C80F60")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2C80C10", Offset = "0x2C80010", VA = "0x182C80C10")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001DF")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001E0")]
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
