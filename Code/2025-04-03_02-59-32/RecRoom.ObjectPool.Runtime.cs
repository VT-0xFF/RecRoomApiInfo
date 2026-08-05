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
		[Cpp2IlInjected.Address(RVA = "0x7BBE9A0", Offset = "0x7BBDDA0", VA = "0x187BBE9A0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles BKMONPLIHMM, float BJAGCMOOOMK, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE640", Offset = "0x7BBDA40", VA = "0x187BBE640")]
		public void SetDamageValue(float BJAGCMOOOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEAE0", Offset = "0x7BBDEE0", VA = "0x187BBEAE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public POKAAIPGGJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5327CD0", Offset = "0x53270D0", VA = "0x185327CD0")]
			internal void NEKAPODGPIO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x38F38E0", Offset = "0x38F2CE0", VA = "0x1838F38E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50414D0", Offset = "0x50408D0", VA = "0x1850414D0")]
		public MINOEGNIANM(HLFDOLJKNKL<T> LCNNLAPGKNP, ObjectPool CGNLJHFMGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5041360", Offset = "0x5040760", VA = "0x185041360", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public LHBPCOMBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4E40800", Offset = "0x4E3FC00", VA = "0x184E40800")]
			internal void NEKAPODGPIO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x12F6590", Offset = "0x12F5990", VA = "0x1812F6590")]
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
		[Cpp2IlInjected.Address(RVA = "0x42C14F0", Offset = "0x42C08F0", VA = "0x1842C14F0")]
		public EGNADGDJLPC(HLFDOLJKNKL<T> LCNNLAPGKNP, ObjectPool CGNLJHFMGCC, int HMDDDIEEBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x42C1490", Offset = "0x42C0890", VA = "0x1842C1490", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FMCLCOFLIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x47527F0", Offset = "0x4751BF0", VA = "0x1847527F0")]
		internal void INIOBLPMDOM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4752740", Offset = "0x4751B40", VA = "0x184752740")]
		internal void BEOLJDPENML(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x47527A0", Offset = "0x4751BA0", VA = "0x1847527A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBD270", Offset = "0x7BBC670", VA = "0x187BBD270")]
	private static void MEFLFFNCJKK(Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD550", Offset = "0x7BBC950", VA = "0x187BBD550")]
	public KGLMDBNIEIL(string BBLPHGNPPDD, int HDJMHDOKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36AA8D0", Offset = "0x36A9CD0", VA = "0x1836AA8D0")]
	public ACBKFBMDPBH<T> GKNBKKNIPGM<T>(AssetReference HDGHBBMBLLM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36AA9A0", Offset = "0x36A9DA0", VA = "0x1836AA9A0")]
	public FHBIOMPDFEE<T> HENHDECMNPA<T>(AssetReference HDGHBBMBLLM, int ECKHNAPCKGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36AA4A0", Offset = "0x36A98A0", VA = "0x1836AA4A0")]
	public GOBMEFCJDOP<bool> BGMHGMOKIKN<T>(AssetReference HDGHBBMBLLM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCEA0", Offset = "0x7BBC2A0", VA = "0x187BBCEA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCF90", Offset = "0x7BBC390", VA = "0x187BBCF90")]
	private void GOICDPNOKDC(UnityEngine.Object NOEPGIHONDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD0E0", Offset = "0x7BBC4E0", VA = "0x187BBD0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBCD30", Offset = "0x7BBC130", VA = "0x187BBCD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35E7280", Offset = "0x35E6680", VA = "0x1835E7280")]
		public static void SafeRelease<T>(T BLFGIKOAKOL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCC60", Offset = "0x7BBC060", VA = "0x187BBCC60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCD20", Offset = "0x7BBC120", VA = "0x187BBCD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x38093F0", Offset = "0x38087F0", VA = "0x1838093F0")]
		public T Acquire<T>(T BKMONPLIHMM, [Optional] Action<Component> HHLMOIAFANK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38097B0", Offset = "0x3808BB0", VA = "0x1838097B0")]
		public bool Release<T>(T BLFGIKOAKOL) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3809740", Offset = "0x3808B40", VA = "0x183809740")]
		public void Prefill<T>(T BKMONPLIHMM, int CDNBNIOMIGN, [Optional] Action<Component> LPCODOKAICG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3809560", Offset = "0x3808960", VA = "0x183809560")]
		public bool Exists<T>(T BKMONPLIHMM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38094B0", Offset = "0x38088B0", VA = "0x1838094B0")]
		public void Clear<T>(T BKMONPLIHMM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE1E0", Offset = "0x7BBD5E0", VA = "0x187BBE1E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3809600", Offset = "0x3808A00", VA = "0x183809600")]
		private EFBOJPNLJNI ICIDKMKPGDO<T>(T BKMONPLIHMM) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		public void TrackInstantiation(string KKHCIDJCEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		public void EnableStats(bool CKEAHCPIIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE350", Offset = "0x7BBD750", VA = "0x187BBE350")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBCAE0", Offset = "0x7BBBEE0", VA = "0x187BBCAE0")]
	protected void NKLIFNGKHAF(Component BLFGIKOAKOL, bool HLCLADEIGNC, bool KONANLAGMNK, bool FJMIDKPJCAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC860", Offset = "0x7BBBC60", VA = "0x187BBC860")]
	protected void IOHCKHAECCA(Transform EMFEDNCPHCF, bool HLCLADEIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x6687600", Offset = "0x6686A00", VA = "0x186687600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int ODEPGEJIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6686C70", Offset = "0x6686070", VA = "0x186686C70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6687620", Offset = "0x6686A20", VA = "0x186687620")]
	public DIMGEDANLHO(T BKMONPLIHMM, ObjectPool BBLDBKBLNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x66874D0", Offset = "0x66868D0", VA = "0x1866874D0", Slot = "6")]
	public override void HENHDECMNPA(int ECKHNAPCKGD, Action<Component> HHLMOIAFANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6687240", Offset = "0x6686640", VA = "0x186687240", Slot = "7")]
	public override Component GKNBKKNIPGM(Action<Component> HHLMOIAFANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6686ED0", Offset = "0x66862D0", VA = "0x186686ED0", Slot = "8")]
	public override bool FEMKONHLAGL(Component NAECADIONFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6686CC0", Offset = "0x66860C0", VA = "0x186686CC0", Slot = "9")]
	public override void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6687080", Offset = "0x6686480", VA = "0x186687080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BBDE60", Offset = "0x7BBD260", VA = "0x187BBDE60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE150", Offset = "0x7BBD550", VA = "0x187BBE150")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBE4A0", Offset = "0x7BBD8A0", VA = "0x187BBE4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE3E0", Offset = "0x7BBD7E0", VA = "0x187BBE3E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCD20", Offset = "0x7BBC120", VA = "0x187BBCD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x68BF410", Offset = "0x68BE810", VA = "0x1868BF410")]
			public ColorConfiguration(ParticleSystem HFDOGJCDEIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC670", Offset = "0x7BBBA70", VA = "0x187BBC670")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public CCPFDLANCAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC580", Offset = "0x7BBB980", VA = "0x187BBC580")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public MMBKOJPGOOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7BBD7E0", Offset = "0x7BBCBE0", VA = "0x187BBD7E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7BBDE10", Offset = "0x7BBD210", VA = "0x187BBDE10", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public CGKGMNJFAMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC5B0", Offset = "0x7BBB9B0", VA = "0x187BBC5B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC620", Offset = "0x7BBBA20", VA = "0x187BBC620", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC2800", Offset = "0x7BC1C00", VA = "0x187BC2800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LDMDENDEECP NHIKNPDDGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA60", Offset = "0x9BBE60", VA = "0x1809BCA60")]
			get
			{
				return default(LDMDENDEECP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HOBAPCKPDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GDBJHGMFLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2530", Offset = "0x7BC1930", VA = "0x187BC2530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int GBBOPBGENBK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC26B0", Offset = "0x7BC1AB0", VA = "0x187BC26B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool GBKDAPKNKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0150", Offset = "0x7BBF550", VA = "0x187BC0150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem EDGJKHEFPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] FBPLEFFPPAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] EKHGHJCIOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x994400", Offset = "0x993800", VA = "0x180994400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IDFBCJOFEBO OHAHKODKDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9984D0", Offset = "0x9978D0", VA = "0x1809984D0")]
			get
			{
				return default(IDFBCJOFEBO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF3B0", Offset = "0x7BBE7B0", VA = "0x187BBF3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform KHDOKFIGIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2850", Offset = "0x7BC1C50", VA = "0x187BC2850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CPAMMOLFMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2490", Offset = "0x7BC1890", VA = "0x187BC2490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7BC28A0", Offset = "0x7BC1CA0", VA = "0x187BC28A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1EA0", Offset = "0x7BC12A0", VA = "0x187BC1EA0")]
		public static PooledParticle TryPlayPrefab(PooledParticle BKMONPLIHMM, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1FC0", Offset = "0x7BC13C0", VA = "0x187BC1FC0")]
		public static PooledParticle TryPlayPrefab(PooledParticle BKMONPLIHMM, Vector3 INHMOEHIHAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1490", Offset = "0x7BC0890", VA = "0x187BC1490")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF180", Offset = "0x7BBE580", VA = "0x187BBF180")]
		private void EHFIKMCAGNO(bool IBPGEKGMGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0620", Offset = "0x7BBFA20", VA = "0x187BC0620")]
		[IteratorStateMachine(typeof(MMBKOJPGOOB))]
		private static IEnumerator<CIKDDGFOAFI> ONKADJEFPIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFB30", Offset = "0x7BBEF30", VA = "0x187BBFB30")]
		private static void KEKGJJAECEM(Stopwatch KINEPAABOFB, Vector3 IOCNIOMNBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0570", Offset = "0x7BBF970", VA = "0x187BC0570")]
		private static int MLPDIEBANPN(PooledParticle BICHNBDCKLH, PooledParticle CKCKMBIGMMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEED0", Offset = "0x7BBE2D0", VA = "0x187BBEED0")]
		private static int BCMPOCFIOFP(LDMDENDEECP CMAMNCPNLFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFEA0", Offset = "0x7BBF2A0", VA = "0x187BBFEA0")]
		protected void LABLGBAFPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF500", Offset = "0x7BBE900", VA = "0x187BBF500")]
		protected void JAMCDFKDIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEC50", Offset = "0x7BBE050", VA = "0x187BBEC50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BC01D0", Offset = "0x7BBF5D0", VA = "0x187BC01D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0680", Offset = "0x7BBFA80", VA = "0x187BC0680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEBC0", Offset = "0x7BBDFC0", VA = "0x187BBEBC0")]
		[IteratorStateMachine(typeof(CGKGMNJFAMH))]
		private IEnumerator<CIKDDGFOAFI> AGIABMNBFDK(float HLOBKBPABIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF250", Offset = "0x7BBE650", VA = "0x187BBF250")]
		private void FEMKONHLAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1BE0", Offset = "0x7BC0FE0", VA = "0x187BC1BE0")]
		public void SetDuration(float HLOBKBPABIA, bool AOEAOHDBMHK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0850", Offset = "0x7BBFC50", VA = "0x187BC0850")]
		public void Play(Transform BOCCBDEGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1100", Offset = "0x7BC0500", VA = "0x187BC1100")]
		public void Play(Transform BOCCBDEGDDP, bool MLFHGBNGCBI, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7BC09B0", Offset = "0x7BBFDB0", VA = "0x187BC09B0")]
		public void Play(Transform BOCCBDEGDDP, Vector3 PIIPJEBCJOI, bool MLFHGBNGCBI, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0B00", Offset = "0x7BBFF00", VA = "0x187BC0B00")]
		public void Play(Transform HCPAADAPDAD, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1270", Offset = "0x7BC0670", VA = "0x187BC1270")]
		public void Play(Transform HCPAADAPDAD, Vector3 PIIPJEBCJOI, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0DA0", Offset = "0x7BC01A0", VA = "0x187BC0DA0")]
		public void Play(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, Vector3 GPBFPENHNGM, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0C40", Offset = "0x7BC0040", VA = "0x187BC0C40")]
		public void Play(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F20", Offset = "0x7BC0320", VA = "0x187BC0F20")]
		public void Play(bool MLFHGBNGCBI = false, float ABJKDOKGMBJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E00", Offset = "0x7BC1200", VA = "0x187BC1E00")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1CB0", Offset = "0x7BC10B0", VA = "0x187BC1CB0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEFE0", Offset = "0x7BBE3E0", VA = "0x187BBEFE0")]
		private void DEDOJNOHHJE(float HLOBKBPABIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0710", Offset = "0x7BBFB10", VA = "0x187BC0710")]
		private void PIILNHMNJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BC13A0", Offset = "0x7BC07A0", VA = "0x187BC13A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1610", Offset = "0x7BC0A10", VA = "0x187BC1610")]
		public void SetColor(Color ODFBFMBMBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0090", Offset = "0x7BBF490", VA = "0x187BC0090")]
		private void LKOIJCJLFOH(float? GLBFMHKMALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0500", Offset = "0x7BBF900", VA = "0x187BC0500")]
		private void MEIKILBEAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF3D0", Offset = "0x7BBE7D0", VA = "0x187BBF3D0")]
		private void HDNAPLBNBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BC23F0", Offset = "0x7BC17F0", VA = "0x187BC23F0")]
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
