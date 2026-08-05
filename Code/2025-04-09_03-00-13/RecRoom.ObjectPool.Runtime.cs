using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Pools;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C12FC0", Offset = "0x7C123C0", VA = "0x187C12FC0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles BKMONPLIHMM, float BJAGCMOOOMK, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C12C60", Offset = "0x7C12060", VA = "0x187C12C60")]
		public void SetDamageValue(float BJAGCMOOOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C13100", Offset = "0x7C12500", VA = "0x187C13100")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACBKFBMDPBH<T> : GOBMEFCJDOP<T>, DJNFHDJGNJD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FHBIOMPDFEE<T> : DJNFHDJGNJD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LMJOGCMBCGE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KGLMDBNIEIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MINOEGNIANM<T> : COOALICOFAM<T>, ACBKFBMDPBH<T>, GOBMEFCJDOP<T>, DJNFHDJGNJD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class POKAAIPGGJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MINOEGNIANM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public POKAAIPGGJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x535B010", Offset = "0x535A410", VA = "0x18535B010")]
			internal void NEKAPODGPIO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x38ED830", Offset = "0x38ECC30", VA = "0x1838ED830")]
			internal void KEOGAEDPOCM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HLFDOLJKNKL<T> LCNNLAPGKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool CGNLJHFMGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JJKLCHMKBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EKDCONIHOMM;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5060DC0", Offset = "0x50601C0", VA = "0x185060DC0")]
		public MINOEGNIANM(HLFDOLJKNKL<T> LCNNLAPGKNP, ObjectPool CGNLJHFMGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5060C50", Offset = "0x5060050", VA = "0x185060C50", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EGNADGDJLPC<T> : NOCDIBGNFAP, FHBIOMPDFEE<T>, DJNFHDJGNJD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LHBPCOMBKCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EGNADGDJLPC<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public LHBPCOMBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4E67400", Offset = "0x4E66800", VA = "0x184E67400")]
			internal void NEKAPODGPIO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x131C470", Offset = "0x131B870", VA = "0x18131C470")]
			internal void KEOGAEDPOCM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private HLFDOLJKNKL<T> LCNNLAPGKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool EKDCONIHOMM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42E0210", Offset = "0x42DF610", VA = "0x1842E0210")]
		public EGNADGDJLPC(HLFDOLJKNKL<T> LCNNLAPGKNP, ObjectPool CGNLJHFMGCC, int HMDDDIEEBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x42E01B0", Offset = "0x42DF5B0", VA = "0x1842E01B0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FMCLCOFLIKH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KGLMDBNIEIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public COOALICOFAM<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HLFDOLJKNKL<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FMCLCOFLIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x477EFB0", Offset = "0x477E3B0", VA = "0x18477EFB0")]
		internal void INIOBLPMDOM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x477EF00", Offset = "0x477E300", VA = "0x18477EF00")]
		internal void BEOLJDPENML(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x477EF60", Offset = "0x477E360", VA = "0x18477EF60")]
		internal void GKMHNGPGAAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<LMJOGCMBCGE> GILKFEJJEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IKLFDMFFGLH GKNPKPFKBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool CGNLJHFMGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C118D0", Offset = "0x7C10CD0", VA = "0x187C118D0")]
	private static void MEFLFFNCJKK(Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C11BA0", Offset = "0x7C10FA0", VA = "0x187C11BA0")]
	public KGLMDBNIEIL(string BBLPHGNPPDD, int HDJMHDOKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36BD910", Offset = "0x36BCD10", VA = "0x1836BD910")]
	public ACBKFBMDPBH<T> GKNBKKNIPGM<T>(AssetReference HDGHBBMBLLM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36BD9E0", Offset = "0x36BCDE0", VA = "0x1836BD9E0")]
	public FHBIOMPDFEE<T> HENHDECMNPA<T>(AssetReference HDGHBBMBLLM, int ECKHNAPCKGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36BD4D0", Offset = "0x36BC8D0", VA = "0x1836BD4D0")]
	public GOBMEFCJDOP<bool> BGMHGMOKIKN<T>(AssetReference HDGHBBMBLLM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C11510", Offset = "0x7C10910", VA = "0x187C11510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C11600", Offset = "0x7C10A00", VA = "0x187C11600")]
	private void GOICDPNOKDC(UnityEngine.Object NOEPGIHONDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C11740", Offset = "0x7C10B40", VA = "0x187C11740")]
	private ObjectPool LAFONKIINAB(string BBLPHGNPPDD)
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GlobalPool CIGDLNGNHMF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KEFCBDAPFGF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DNEPPKLGBFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C113C0", Offset = "0x7C107C0", VA = "0x187C113C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35FD430", Offset = "0x35FC830", VA = "0x1835FD430")]
		public static void SafeRelease<T>(T BLFGIKOAKOL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C112F0", Offset = "0x7C106F0", VA = "0x187C112F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C113B0", Offset = "0x7C107B0", VA = "0x187C113B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EFBOJPNLJNI> AHJLGGCCMLF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x381C120", Offset = "0x381B520", VA = "0x18381C120")]
		public T Acquire<T>(T BKMONPLIHMM, [Optional] Action<Component> HHLMOIAFANK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x381C4E0", Offset = "0x381B8E0", VA = "0x18381C4E0")]
		public bool Release<T>(T BLFGIKOAKOL) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x381C470", Offset = "0x381B870", VA = "0x18381C470")]
		public void Prefill<T>(T BKMONPLIHMM, int CDNBNIOMIGN, [Optional] Action<Component> LPCODOKAICG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x381C290", Offset = "0x381B690", VA = "0x18381C290")]
		public bool Exists<T>(T BKMONPLIHMM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x381C1E0", Offset = "0x381B5E0", VA = "0x18381C1E0")]
		public void Clear<T>(T BKMONPLIHMM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C12820", Offset = "0x7C11C20", VA = "0x187C12820")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x381C330", Offset = "0x381B730", VA = "0x18381C330")]
		private EFBOJPNLJNI ICIDKMKPGDO<T>(T BKMONPLIHMM) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		public void TrackInstantiation(string KKHCIDJCEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		public void EnableStats(bool CKEAHCPIIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C12990", Offset = "0x7C11D90", VA = "0x187C12990")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EFBOJPNLJNI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DNMEBJHPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BBLMJDIKHAC(bool HLCLADEIGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int ODEPGEJIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void HENHDECMNPA(int ECKHNAPCKGD, Action<Component> LPCODOKAICG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component GKNBKKNIPGM(Action<Component> HHLMOIAFANK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool FEMKONHLAGL(Component NAECADIONFH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CJEMNCEDADJ();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C11170", Offset = "0x7C10570", VA = "0x187C11170")]
	protected void NKLIFNGKHAF(Component BLFGIKOAKOL, bool HLCLADEIGNC, bool KONANLAGMNK, bool FJMIDKPJCAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C10EF0", Offset = "0x7C102F0", VA = "0x187C10EF0")]
	protected void IOHCKHAECCA(Transform EMFEDNCPHCF, bool HLCLADEIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected EFBOJPNLJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DIMGEDANLHO<T> : EFBOJPNLJNI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T BKMONPLIHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool BBLDBKBLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool KONANLAGMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JEIHJPCLGGE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66EF400", Offset = "0x66EE800", VA = "0x1866EF400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int ODEPGEJIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66EEA70", Offset = "0x66EDE70", VA = "0x1866EEA70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x66EF420", Offset = "0x66EE820", VA = "0x1866EF420")]
	public DIMGEDANLHO(T BKMONPLIHMM, ObjectPool BBLDBKBLNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66EF2D0", Offset = "0x66EE6D0", VA = "0x1866EF2D0", Slot = "6")]
	public override void HENHDECMNPA(int ECKHNAPCKGD, Action<Component> HHLMOIAFANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x66EF040", Offset = "0x66EE440", VA = "0x1866EF040", Slot = "7")]
	public override Component GKNBKKNIPGM(Action<Component> HHLMOIAFANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x66EECD0", Offset = "0x66EE0D0", VA = "0x1866EECD0", Slot = "8")]
	public override bool FEMKONHLAGL(Component NAECADIONFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x66EEAC0", Offset = "0x66EDEC0", VA = "0x1866EEAC0", Slot = "9")]
	public override void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66EEE80", Offset = "0x66EE280", VA = "0x1866EEE80")]
	private T GFOCLFFGPDM()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public interface NHMFCHPBJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject KDCGGLACGKA
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C124A0", Offset = "0x7C118A0", VA = "0x187C124A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C12790", Offset = "0x7C11B90", VA = "0x187C12790")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CIGDLNGNHMF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject KEFCBDAPFGF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool DNEPPKLGBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7C12AE0", Offset = "0x7C11EE0", VA = "0x187C12AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C12A20", Offset = "0x7C11E20", VA = "0x187C12A20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C113B0", Offset = "0x7C107B0", VA = "0x187C113B0")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EFBOJPNLJNI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GDAPDKIENOL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BCMPOCFIOFP(PooledParticle.LDMDENDEECP CMAMNCPNLFL);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum IDFBCJOFEBO
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum LDMDENDEECP
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface HAILMGNLFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool LNINEPCGNIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 EHKLHBBHPMN
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera CLBPCLIDLPB
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x691C910", Offset = "0x691BD10", VA = "0x18691C910")]
			public ColorConfiguration(ParticleSystem HFDOGJCDEIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C10D00", Offset = "0x7C10100", VA = "0x187C10D00")]
			public void DMFBDFFBKIN(Color ODFBFMBMBOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CCPFDLANCAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public CCPFDLANCAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C10C10", Offset = "0x7C10010", VA = "0x187C10C10")]
			internal void NOFDCLBNGGO(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MMBKOJPGOOB : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private HAILMGNLFEJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
			[DebuggerHidden]
			public MMBKOJPGOOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7C11E30", Offset = "0x7C11230", VA = "0x187C11E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C12450", Offset = "0x7C11850", VA = "0x187C12450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CGKGMNJFAMH : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
			[DebuggerHidden]
			public CGKGMNJFAMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7C10C40", Offset = "0x7C10040", VA = "0x187C10C40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7C10CB0", Offset = "0x7C100B0", VA = "0x187C10CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> BMPEBNGANJE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<GDAPDKIENOL> JELNMCIMDEB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> FLHLFKPIGEP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static LBKCJDEOHAA HABCMPGLCDB;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float KFGDJECDPEO = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool JLMGGHENHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int NNPNJPHCCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private LDMDENDEECP category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? FCAMGGGGNJH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] APOOBEOHCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CACEABGNKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float KGGKACMHCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float INMMBLKIONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform JCFPNAEBNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 OACNKFDCDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 PIIPJEBCJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IDFBCJOFEBO KPFLCNACPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LBKCJDEOHAA GAIPKLJPMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool HAJGPDJNIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform GCOMKJBPJFD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> NBOEHOBFJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C16D60", Offset = "0x7C16160", VA = "0x187C16D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LDMDENDEECP NHIKNPDDGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9D2A50", Offset = "0x9D1E50", VA = "0x1809D2A50")]
			get
			{
				return default(LDMDENDEECP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HOBAPCKPDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GDBJHGMFLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C16AB0", Offset = "0x7C15EB0", VA = "0x187C16AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int GBBOPBGENBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7C16C20", Offset = "0x7C16020", VA = "0x187C16C20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool GBKDAPKNKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C14710", Offset = "0x7C13B10", VA = "0x187C14710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem EDGJKHEFPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] FBPLEFFPPAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] EKHGHJCIOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IDFBCJOFEBO OHAHKODKDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AE440", Offset = "0x9AD840", VA = "0x1809AE440")]
			get
			{
				return default(IDFBCJOFEBO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C139A0", Offset = "0x7C12DA0", VA = "0x187C139A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform KHDOKFIGIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7C16DB0", Offset = "0x7C161B0", VA = "0x187C16DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CPAMMOLFMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C16A10", Offset = "0x7C15E10", VA = "0x187C16A10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7C16E00", Offset = "0x7C16200", VA = "0x187C16E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C16450", Offset = "0x7C15850", VA = "0x187C16450")]
		public static PooledParticle TryPlayPrefab(PooledParticle BKMONPLIHMM, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C16570", Offset = "0x7C15970", VA = "0x187C16570")]
		public static PooledParticle TryPlayPrefab(PooledParticle BKMONPLIHMM, Vector3 INHMOEHIHAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C15A40", Offset = "0x7C14E40", VA = "0x187C15A40")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C13770", Offset = "0x7C12B70", VA = "0x187C13770")]
		private void EHFIKMCAGNO(bool IBPGEKGMGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C14BE0", Offset = "0x7C13FE0", VA = "0x187C14BE0")]
		[IteratorStateMachine(typeof(MMBKOJPGOOB))]
		private static IEnumerator<CIKDDGFOAFI> ONKADJEFPIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C140F0", Offset = "0x7C134F0", VA = "0x187C140F0")]
		private static void KEKGJJAECEM(Stopwatch KINEPAABOFB, Vector3 IOCNIOMNBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C14B30", Offset = "0x7C13F30", VA = "0x187C14B30")]
		private static int MLPDIEBANPN(PooledParticle BICHNBDCKLH, PooledParticle CKCKMBIGMMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C134E0", Offset = "0x7C128E0", VA = "0x187C134E0")]
		private static int BCMPOCFIOFP(LDMDENDEECP CMAMNCPNLFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C14460", Offset = "0x7C13860", VA = "0x187C14460")]
		protected void LABLGBAFPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C13AF0", Offset = "0x7C12EF0", VA = "0x187C13AF0")]
		protected void JAMCDFKDIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C13270", Offset = "0x7C12670", VA = "0x187C13270", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C14790", Offset = "0x7C13B90", VA = "0x187C14790")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C14C40", Offset = "0x7C14040", VA = "0x187C14C40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C131E0", Offset = "0x7C125E0", VA = "0x187C131E0")]
		[IteratorStateMachine(typeof(CGKGMNJFAMH))]
		private IEnumerator<CIKDDGFOAFI> AGIABMNBFDK(float HLOBKBPABIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C13840", Offset = "0x7C12C40", VA = "0x187C13840")]
		private void FEMKONHLAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C16190", Offset = "0x7C15590", VA = "0x187C16190")]
		public void SetDuration(float HLOBKBPABIA, bool AOEAOHDBMHK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C14E10", Offset = "0x7C14210", VA = "0x187C14E10")]
		public void Play(Transform BOCCBDEGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C156B0", Offset = "0x7C14AB0", VA = "0x187C156B0")]
		public void Play(Transform BOCCBDEGDDP, bool MLFHGBNGCBI, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C14F60", Offset = "0x7C14360", VA = "0x187C14F60")]
		public void Play(Transform BOCCBDEGDDP, Vector3 PIIPJEBCJOI, bool MLFHGBNGCBI, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C150B0", Offset = "0x7C144B0", VA = "0x187C150B0")]
		public void Play(Transform HCPAADAPDAD, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C15820", Offset = "0x7C14C20", VA = "0x187C15820")]
		public void Play(Transform HCPAADAPDAD, Vector3 PIIPJEBCJOI, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C15350", Offset = "0x7C14750", VA = "0x187C15350")]
		public void Play(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, Vector3 GPBFPENHNGM, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C151F0", Offset = "0x7C145F0", VA = "0x187C151F0")]
		public void Play(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C154D0", Offset = "0x7C148D0", VA = "0x187C154D0")]
		public void Play(bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C163B0", Offset = "0x7C157B0", VA = "0x187C163B0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C16260", Offset = "0x7C15660", VA = "0x187C16260")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C135E0", Offset = "0x7C129E0", VA = "0x187C135E0")]
		private void DEDOJNOHHJE(float HLOBKBPABIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C14CD0", Offset = "0x7C140D0", VA = "0x187C14CD0")]
		private void PIILNHMNJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C15950", Offset = "0x7C14D50", VA = "0x187C15950")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C15BC0", Offset = "0x7C14FC0", VA = "0x187C15BC0")]
		public void SetColor(Color ODFBFMBMBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C14650", Offset = "0x7C13A50", VA = "0x187C14650")]
		private void LKOIJCJLFOH(float? GLBFMHKMALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C14AC0", Offset = "0x7C13EC0", VA = "0x187C14AC0")]
		private void MEIKILBEAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C139C0", Offset = "0x7C12DC0", VA = "0x187C139C0")]
		private void HDNAPLBNBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C16980", Offset = "0x7C15D80", VA = "0x187C16980")]
		public PooledParticle()
		{
		}
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
