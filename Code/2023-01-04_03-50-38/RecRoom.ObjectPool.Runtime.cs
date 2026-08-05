using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Header("Impact Particle System")]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Header("Impact Particle Start Lifetime")]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[Header("Spray Particle System")]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Header("Spray Particle Burst Count")]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60122E0", Offset = "0x60116E0", VA = "0x1860122E0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles JLHMEAKALNB, float GPGIMGLCEMN, Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60120E0", Offset = "0x60114E0", VA = "0x1860120E0")]
		public void SetDamageValue(float GPGIMGLCEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x60124A0", Offset = "0x60118A0", VA = "0x1860124A0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DMKBGPLMOLP<T> : global::JENPMPFICOP<T>, JLFOFKFALKJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KPGEBBLNLNJ<T> : JLFOFKFALKJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PDNFEGDPJFD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ELJCEGBKEJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OAOJAFHMOHE<T> : global::AHANDFLOFLD<T>, global::DMKBGPLMOLP<T>, global::JENPMPFICOP<T>, JLFOFKFALKJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AHEMDJIKAKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OAOJAFHMOHE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public AHEMDJIKAKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x38C1BF0", Offset = "0x38C0FF0", VA = "0x1838C1BF0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1D52950", Offset = "0x1D51D50", VA = "0x181D52950")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::HDJHLDKFKIP<T> HPLKBMJJGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool DAFGKHGBAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AGBKKGEFEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28965B0", Offset = "0x28959B0", VA = "0x1828965B0")]
		public OAOJAFHMOHE(global::HDJHLDKFKIP<T> HPLKBMJJGAP, ObjectPool DAFGKHGBAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2896470", Offset = "0x2895870", VA = "0x182896470", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PJELIIIEBKB<T> : HADFCENGJKO, global::KPGEBBLNLNJ<T>, JLFOFKFALKJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GJNMDBGNKOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PJELIIIEBKB<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public GJNMDBGNKOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x279C2D0", Offset = "0x279B6D0", VA = "0x18279C2D0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1166E40", Offset = "0x1166240", VA = "0x181166E40")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::HDJHLDKFKIP<T> HPLKBMJJGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4360", Offset = "0x2DB3760", VA = "0x182DB4360")]
		public PJELIIIEBKB(global::HDJHLDKFKIP<T> HPLKBMJJGAP, ObjectPool DAFGKHGBAIJ, int DGKELLDGEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4310", Offset = "0x2DB3710", VA = "0x182DB4310", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LIJPILNFFPC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ELJCEGBKEJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::AHANDFLOFLD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::HDJHLDKFKIP<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LIJPILNFFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3899A30", Offset = "0x3898E30", VA = "0x183899A30")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3899AD0", Offset = "0x3898ED0", VA = "0x183899AD0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3899B30", Offset = "0x3898F30", VA = "0x183899B30")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<PDNFEGDPJFD> JMHBGNNHFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MGBFCNCMNCD PLBAKONDOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool DAFGKHGBAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool HDGGGIKCCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x600FE10", Offset = "0x600F210", VA = "0x18600FE10")]
	private static void ADDELDCDFKM(Component HEKOHKDELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60104C0", Offset = "0x600F8C0", VA = "0x1860104C0")]
	public ELJCEGBKEJH(string AGEOBIJKNAA, int NNMICLAJEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2072FD0", Offset = "0x20723D0", VA = "0x182072FD0")]
	public global::DMKBGPLMOLP<T> GJGNFIMMHOA<T>(AssetReference NDPKOIKKMGM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2073420", Offset = "0x2072820", VA = "0x182073420")]
	public global::KPGEBBLNLNJ<T> IKMEJOIGCKE<T>(AssetReference NDPKOIKKMGM, int LKJCGNNPEOE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2073060", Offset = "0x2072460", VA = "0x182073060")]
	public global::JENPMPFICOP<bool> HGNKBEMEDCJ<T>(AssetReference NDPKOIKKMGM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6010060", Offset = "0x600F460", VA = "0x186010060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6010170", Offset = "0x600F570", VA = "0x186010170")]
	private void GHBGFDCLPGD(UnityEngine.Object BPMBKGDLDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60102B0", Offset = "0x600F6B0", VA = "0x1860102B0")]
	private ObjectPool KMOFNLGHAGL(string AGEOBIJKNAA)
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
		private static GlobalPool EPGBMCBLEPE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CCFJPGOFPFD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6010860", Offset = "0x600FC60", VA = "0x186010860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F72A70", Offset = "0x1F71E70", VA = "0x181F72A70")]
		public static void SafeRelease<T>(T JLBINKLPHKJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6010760", Offset = "0x600FB60", VA = "0x186010760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6010850", Offset = "0x600FC50", VA = "0x186010850")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, BFAFIPAAEMC> FCFHLKNHNIO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0DB0", Offset = "0x1FC01B0", VA = "0x181FC0DB0")]
		public T Acquire<T>(T JLHMEAKALNB, [Optional] Action<Component> ENKNGAGEHHL) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1140", Offset = "0x1FC0540", VA = "0x181FC1140")]
		public bool Release<T>(T JLBINKLPHKJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FC10E0", Offset = "0x1FC04E0", VA = "0x181FC10E0")]
		public void Prefill<T>(T JLHMEAKALNB, int MIBHGLMGEMB, [Optional] Action<Component> ACLIGKMFAFP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0EF0", Offset = "0x1FC02F0", VA = "0x181FC0EF0")]
		public bool Exists<T>(T JLHMEAKALNB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0E40", Offset = "0x1FC0240", VA = "0x181FC0E40")]
		public void Clear<T>(T JLHMEAKALNB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6011C30", Offset = "0x6011030", VA = "0x186011C30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0FA0", Offset = "0x1FC03A0", VA = "0x181FC0FA0")]
		private BFAFIPAAEMC HFAOKIBLPLD<T>(T JLHMEAKALNB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public void TrackInstantiation(string EGGCHMDIBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public void EnableStats(bool NNOHLPELMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6011D80", Offset = "0x6011180", VA = "0x186011D80")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class BFAFIPAAEMC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EDNMBMDDFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BNBDPGMNFMF(bool BNMAEDNLOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component DCLPEGKICGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int CPGDDKLIKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void IKMEJOIGCKE(int LKJCGNNPEOE, Action<Component> ACLIGKMFAFP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component GJGNFIMMHOA(Action<Component> ENKNGAGEHHL);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool FLGFHANBACE(Component PJKDAPHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void BNMOGLEIOOC();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x600F8A0", Offset = "0x600ECA0", VA = "0x18600F8A0")]
	protected void CNNPONIFMAN(Component JLBINKLPHKJ, bool BNMAEDNLOCE, bool PMJJEMDIMAP, bool CLCJJIPEPIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x600FA20", Offset = "0x600EE20", VA = "0x18600FA20")]
	protected void FLDLNHJGGEH(Transform CLBLMIOJIDG, bool BNMAEDNLOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected BFAFIPAAEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LKDCGPOIDFG<T> : BFAFIPAAEMC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T JLHMEAKALNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool KCONPCAOCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool PMJJEMDIMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> GOKIFDMGBLJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component DCLPEGKICGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3097110", Offset = "0x3096510", VA = "0x183097110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int CPGDDKLIKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3096FD0", Offset = "0x30963D0", VA = "0x183096FD0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3097130", Offset = "0x3096530", VA = "0x183097130")]
	public LKDCGPOIDFG(T JLHMEAKALNB, ObjectPool KCONPCAOCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3097000", Offset = "0x3096400", VA = "0x183097000", Slot = "7")]
	public override void IKMEJOIGCKE(int LKJCGNNPEOE, Action<Component> ENKNGAGEHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3096D60", Offset = "0x3096160", VA = "0x183096D60", Slot = "8")]
	public override Component GJGNFIMMHOA(Action<Component> ENKNGAGEHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3096BD0", Offset = "0x3095FD0", VA = "0x183096BD0", Slot = "9")]
	public override bool FLGFHANBACE(Component PJKDAPHKFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30969E0", Offset = "0x3095DE0", VA = "0x1830969E0", Slot = "10")]
	public override void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3096880", Offset = "0x3095C80", VA = "0x183096880")]
	private T AAAJCHIJOBJ()
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
		public interface CINHLIOGDJF
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject AGPIEKKCNDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6011860", Offset = "0x6010C60", VA = "0x186011860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6011BB0", Offset = "0x6010FB0", VA = "0x186011BB0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool EPGBMCBLEPE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject CCFJPGOFPFD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6011EF0", Offset = "0x60112F0", VA = "0x186011EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6011E00", Offset = "0x6011200", VA = "0x186011E00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6010850", Offset = "0x600FC50", VA = "0x186010850")]
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
		public BFAFIPAAEMC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HLBMJMAJONN
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NNOFLHAMIAD(PooledParticle.CIDEODEGHBO ALKAPHEGPHI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum LBDCJKIECPM
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum CIDEODEGHBO
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface IDPCHMNHLMB
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool HCFICECJFFC
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 IDKDOLHFDFF
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera NEOFDGCIPMI
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD7D6D0", Offset = "0xD7CAD0", VA = "0x180D7D6D0")]
			public ColorConfiguration(ParticleSystem CNAKNNADMDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x600FC20", Offset = "0x600F020", VA = "0x18600FC20")]
			public void LBECBOPABKM(Color CNDGCCPDGDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OMBFPMIFDDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public OMBFPMIFDDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6011830", Offset = "0x6010C30", VA = "0x186011830")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HJECJNJPDBP : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private NCBIOOCDIOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IDPCHMNHLMB <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
			[DebuggerHidden]
			public HJECJNJPDBP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6010A20", Offset = "0x600FE20", VA = "0x186010A20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x60110C0", Offset = "0x60104C0", VA = "0x1860110C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IMEKJJCACAH : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private NCBIOOCDIOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
			[DebuggerHidden]
			public IMEKJJCACAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6011100", Offset = "0x6010500", VA = "0x186011100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x60111C0", Offset = "0x60105C0", VA = "0x1860111C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> PKGMNHMMBAJ;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<HLBMJMAJONN> NBOIEEPKMEB;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> FJPINDPBHNN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static OFJDMAJBJNN IPBEBBLKPBN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float HAKGLNOKPMJ = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool PONIBMHCHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int ADPIJIDALAE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private CIDEODEGHBO category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ParticleSystem.MinMaxGradient[] CFNCMLHANDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool LCOPIMFGEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float NPHHFMFGNBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float HBNHOKNPKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform LCIAEGHANFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 JKIPNIHKBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 FNDGMMHLPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LBDCJKIECPM JLEBEEOKJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private OFJDMAJBJNN LKBJHNGFJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool ODMGIFHHMFA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> ELABJFHFKND
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6015D90", Offset = "0x6015190", VA = "0x186015D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CIDEODEGHBO NDPLHCLLOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x693C90", Offset = "0x693090", VA = "0x180693C90")]
			get
			{
				return default(CIDEODEGHBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NFFFMKNKNFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DGHOOJGKDDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6015A80", Offset = "0x6014E80", VA = "0x186015A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int HGABKIADEIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6015C10", Offset = "0x6015010", VA = "0x186015C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool CPDJPCHALKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6012990", Offset = "0x6011D90", VA = "0x186012990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem MIHIGCILBLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] MPEFIGDICCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] ALBKNNOLCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private LBDCJKIECPM DLFBFKGJGCK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x81E3F0", Offset = "0x81D7F0", VA = "0x18081E3F0")]
			get
			{
				return default(LBDCJKIECPM);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6012970", Offset = "0x6011D70", VA = "0x186012970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BKNCECAIFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x60159E0", Offset = "0x6014DE0", VA = "0x1860159E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6015DF0", Offset = "0x60151F0", VA = "0x186015DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6015580", Offset = "0x6014980", VA = "0x186015580")]
		public static PooledParticle TryPlayPrefab(PooledParticle JLHMEAKALNB, Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6015390", Offset = "0x6014790", VA = "0x186015390")]
		public static PooledParticle TryPlayPrefab(PooledParticle JLHMEAKALNB, Vector3 EFKMIDDCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6014A00", Offset = "0x6013E00", VA = "0x186014A00")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6013550", Offset = "0x6012950", VA = "0x186013550")]
		private void KDDCKOHNDNG(bool JNPACPCGCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6013500", Offset = "0x6012900", VA = "0x186013500")]
		[IteratorStateMachine(typeof(HJECJNJPDBP))]
		private static IEnumerator<NCBIOOCDIOA> JEFPLHGDKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6013BE0", Offset = "0x6012FE0", VA = "0x186013BE0")]
		private static void OPLDCOPHGNA(Stopwatch ANOJNPAHJKB, Vector3 HEDFGKKIJLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6012D10", Offset = "0x6012110", VA = "0x186012D10")]
		private static int FNLACKAEIIM(PooledParticle LBABLKMFGKM, PooledParticle MGCAIGBBIIM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60138D0", Offset = "0x6012CD0", VA = "0x1860138D0")]
		private static int NNOFLHAMIAD(CIDEODEGHBO ALKAPHEGPHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60139E0", Offset = "0x6012DE0", VA = "0x1860139E0")]
		protected void ONLPLDGFDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6012DC0", Offset = "0x60121C0", VA = "0x186012DC0")]
		protected void IJKFMHFNCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60126B0", Offset = "0x6011AB0", VA = "0x1860126B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6013630", Offset = "0x6012A30", VA = "0x186013630")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6013F70", Offset = "0x6013370", VA = "0x186013F70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60128F0", Offset = "0x6011CF0", VA = "0x1860128F0")]
		[IteratorStateMachine(typeof(IMEKJJCACAH))]
		private IEnumerator<NCBIOOCDIOA> BNMOALKLHJN(float IFDELLDHIPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6012B60", Offset = "0x6011F60", VA = "0x186012B60")]
		private void FLGFHANBACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60151A0", Offset = "0x60145A0", VA = "0x1860151A0")]
		public void SetDuration(float IFDELLDHIPH, bool ODFOFHJMJII = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60146E0", Offset = "0x6013AE0", VA = "0x1860146E0")]
		public void Play(Transform MJIBNOEKEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60140C0", Offset = "0x60134C0", VA = "0x1860140C0")]
		public void Play(Transform MJIBNOEKEPD, bool EMDHALPFGIL, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6014210", Offset = "0x6013610", VA = "0x186014210")]
		public void Play(Transform MJIBNOEKEPD, Vector3 FNDGMMHLPLN, bool EMDHALPFGIL, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6014490", Offset = "0x6013890", VA = "0x186014490")]
		public void Play(Transform BBLPHFBBBEI, Quaternion IAPKIBMDFEP, bool EMDHALPFGIL = false, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6014360", Offset = "0x6013760", VA = "0x186014360")]
		public void Play(Transform BBLPHFBBBEI, Vector3 FNDGMMHLPLN, Quaternion IAPKIBMDFEP, bool EMDHALPFGIL = false, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x60133F0", VA = "0x186013FF0")]
		public void Play(Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP, Vector3 EAMJDCGEMLP, bool EMDHALPFGIL = false, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6014820", Offset = "0x6013C20", VA = "0x186014820")]
		public void Play(Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP, bool EMDHALPFGIL = false, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60145D0", Offset = "0x60139D0", VA = "0x1860145D0")]
		public void Play(bool EMDHALPFGIL = false, float ECIHJKBAPKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6015300", Offset = "0x6014700", VA = "0x186015300")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6015270", Offset = "0x6014670", VA = "0x186015270")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6013370", Offset = "0x6012770", VA = "0x186013370")]
		private void IPOHIBBIPFN(float IFDELLDHIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6012540", Offset = "0x6011940", VA = "0x186012540")]
		private void ALHCAAAGJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60148E0", Offset = "0x6013CE0", VA = "0x1860148E0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6014BA0", Offset = "0x6013FA0", VA = "0x186014BA0")]
		public void SetColor(Color CNDGCCPDGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6012A20", Offset = "0x6011E20", VA = "0x186012A20")]
		private void EAKIJDLNLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6015980", Offset = "0x6014D80", VA = "0x186015980")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6011200", Offset = "0x6010600", VA = "0x186011200")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6011310", Offset = "0x6010710", VA = "0x186011310")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
