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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8467C90", Offset = "0x8466A90", VA = "0x188467C90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FLFNPLAKMCE, float JGOLMHOAPJL, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8467930", Offset = "0x8466730", VA = "0x188467930")]
		public void SetDamageValue(float JGOLMHOAPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8467DD0", Offset = "0x8466BD0", VA = "0x188467DD0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MDBBCDOEFDG<T> : CEBCBDBEPBJ<T>, IDGEJBLICGP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GHELEIBAKAJ<T> : IDGEJBLICGP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BJCOGPPGLKP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HJBKBNEOIFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MEDHNOGLOMH<T> : PJHMOOOINAI<T>, MDBBCDOEFDG<T>, CEBCBDBEPBJ<T>, IDGEJBLICGP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PFGMNFECHBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MEDHNOGLOMH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public PFGMNFECHBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x597F420", Offset = "0x597E220", VA = "0x18597F420")]
			internal void CABKDCOCKPB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3F3BE00", Offset = "0x3F3AC00", VA = "0x183F3BE00")]
			internal void HGLEAMJBNCO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NONKHMPPJIB<T> FGPEPFIIEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool PHGDIPJAEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T GBACACMKFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HDGGIMAAJCJ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5658100", Offset = "0x5656F00", VA = "0x185658100")]
		public MEDHNOGLOMH(NONKHMPPJIB<T> FGPEPFIIEMA, ObjectPool PHGDIPJAEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5657FC0", Offset = "0x5656DC0", VA = "0x185657FC0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DIBDGFIDNAF<T> : OEFHFMHBIFE, GHELEIBAKAJ<T>, IDGEJBLICGP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AICBOKFKPAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DIBDGFIDNAF<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public AICBOKFKPAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4FE0710", Offset = "0x4FDF510", VA = "0x184FE0710")]
			internal void CABKDCOCKPB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1620EA0", Offset = "0x161FCA0", VA = "0x181620EA0")]
			internal void HGLEAMJBNCO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NONKHMPPJIB<T> FGPEPFIIEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HDGGIMAAJCJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DE78B0", Offset = "0x6DE66B0", VA = "0x186DE78B0")]
		public DIBDGFIDNAF(NONKHMPPJIB<T> FGPEPFIIEMA, ObjectPool PHGDIPJAEDL, int DOJEDHBHELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7850", Offset = "0x6DE6650", VA = "0x186DE7850", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BJIFMJCNHPD<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HJBKBNEOIFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PJHMOOOINAI<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NONKHMPPJIB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BJIFMJCNHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62578A0", Offset = "0x62566A0", VA = "0x1862578A0")]
		internal void KPBOCKPEFHK(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6257840", Offset = "0x6256640", VA = "0x186257840")]
		internal void HJJDOPPLDOP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62577F0", Offset = "0x62565F0", VA = "0x1862577F0")]
		internal void DPBHAEPAOGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<BJCOGPPGLKP> BINAEBPFADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OMDOIIGBCDI BPHCKKBHNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool PHGDIPJAEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8466960", Offset = "0x8465760", VA = "0x188466960")]
	private static void ELLFJAAJPMK(Component LPAADBJGJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8466DD0", Offset = "0x8465BD0", VA = "0x188466DD0")]
	public HJBKBNEOIFJ(string DLNGPIGGLBL, int ALHHLLEBPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3BA06A0", Offset = "0x3B9F4A0", VA = "0x183BA06A0")]
	public MDBBCDOEFDG<T> AOBILGBCGBI<T>(AssetReference JEOFBIODEBI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0A00", Offset = "0x3B9F800", VA = "0x183BA0A00")]
	public GHELEIBAKAJ<T> HEKPHNOOBGC<T>(AssetReference JEOFBIODEBI, int LJEIHABMGGI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0740", Offset = "0x3B9F540", VA = "0x183BA0740")]
	public CEBCBDBEPBJ<bool> FGHKILHPKEI<T>(AssetReference JEOFBIODEBI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8466870", Offset = "0x8465670", VA = "0x188466870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8466730", Offset = "0x8465530", VA = "0x188466730")]
	private void CPNBJDOAHDM(UnityEngine.Object HEJMIEGPBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8466BB0", Offset = "0x84659B0", VA = "0x188466BB0")]
	private ObjectPool GOANNAPGICI(string DLNGPIGGLBL)
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
		private static GlobalPool DIPJLOIABCD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GEFLEENOMPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool ODAOEPEFKDK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84665C0", Offset = "0x84653C0", VA = "0x1884665C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B982D0", Offset = "0x3B970D0", VA = "0x183B982D0")]
		public static void SafeRelease<T>(T MKPNGAKJFMP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84664F0", Offset = "0x84652F0", VA = "0x1884664F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84665B0", Offset = "0x84653B0", VA = "0x1884665B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, DFOPLFIIJFL> AJAIOEFNMFD;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A3A0", Offset = "0x3D491A0", VA = "0x183D4A3A0")]
		public T Acquire<T>(T FLFNPLAKMCE, [Optional] Action<Component> DANDOCBEMLF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A710", Offset = "0x3D49510", VA = "0x183D4A710")]
		public bool Release<T>(T MKPNGAKJFMP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A6C0", Offset = "0x3D494C0", VA = "0x183D4A6C0")]
		public void Prefill<T>(T FLFNPLAKMCE, int APLKFJJIDFM, [Optional] Action<Component> MGOMFMPHEMK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A620", Offset = "0x3D49420", VA = "0x183D4A620")]
		public bool Exists<T>(T FLFNPLAKMCE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A430", Offset = "0x3D49230", VA = "0x183D4A430")]
		public void Clear<T>(T FLFNPLAKMCE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84674D0", Offset = "0x84662D0", VA = "0x1884674D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A4E0", Offset = "0x3D492E0", VA = "0x183D4A4E0")]
		private DFOPLFIIJFL EBLKCIJFEDE<T>(T FLFNPLAKMCE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public void TrackInstantiation(string BGCKIOAJGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public void EnableStats(bool EOFDPPEEMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8467640", Offset = "0x8466440", VA = "0x188467640")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DFOPLFIIJFL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PHJLFABIJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FBEACKMBBNB(bool BAMJEJIELLP);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int CILIHLFMOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void HEKPHNOOBGC(int LJEIHABMGGI, Action<Component> MGOMFMPHEMK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component AOBILGBCGBI(Action<Component> DANDOCBEMLF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NIADOCPAAKN(Component DALMNDLIGME);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void MKDKKBLDFOH();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8465D00", Offset = "0x8464B00", VA = "0x188465D00")]
	protected void OIMDJBHIJDI(Component MKPNGAKJFMP, bool BAMJEJIELLP, bool JAADPICIPOB, bool DAKMPKMHONI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8465A80", Offset = "0x8464880", VA = "0x188465A80")]
	protected void DHHLFAHECEG(Transform NJIADOCAKGG, bool BAMJEJIELLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected DFOPLFIIJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MFGOAOLPJGN<T> : DFOPLFIIJFL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FLFNPLAKMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool JDNGGKBOLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JAADPICIPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> ILEKHGCAAHC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x565EC40", Offset = "0x565DA40", VA = "0x18565EC40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int CILIHLFMOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x565EC00", Offset = "0x565DA00", VA = "0x18565EC00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x565F1A0", Offset = "0x565DFA0", VA = "0x18565F1A0")]
	public MFGOAOLPJGN(T FLFNPLAKMCE, ObjectPool JDNGGKBOLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x565EAF0", Offset = "0x565D8F0", VA = "0x18565EAF0", Slot = "6")]
	public override void HEKPHNOOBGC(int LJEIHABMGGI, Action<Component> DANDOCBEMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x565E880", Offset = "0x565D680", VA = "0x18565E880", Slot = "7")]
	public override Component AOBILGBCGBI(Action<Component> DANDOCBEMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x565EE50", Offset = "0x565DC50", VA = "0x18565EE50", Slot = "8")]
	public override bool NIADOCPAAKN(Component DALMNDLIGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x565EC60", Offset = "0x565DA60", VA = "0x18565EC60", Slot = "9")]
	public override void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x565EFF0", Offset = "0x565DDF0", VA = "0x18565EFF0")]
	private T OKPBFJKJEHP()
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
		public interface DKJLHPKCNGC
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject KNCEGBICJJD
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
		[Cpp2IlInjected.Address(RVA = "0x8467150", Offset = "0x8465F50", VA = "0x188467150")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8467440", Offset = "0x8466240", VA = "0x188467440")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool DIPJLOIABCD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GEFLEENOMPN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool ODAOEPEFKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8467790", Offset = "0x8466590", VA = "0x188467790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84676D0", Offset = "0x84664D0", VA = "0x1884676D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84665B0", Offset = "0x84653B0", VA = "0x1884665B0")]
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
		public DFOPLFIIJFL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HHKEAHFPPBB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int INEDCHPNPOL(PooledParticle.PAHHIODCCPD INDDHEPFNIF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JJIBOPCGDAH
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum PAHHIODCCPD
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface BKKHFOOOECM
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool MDJJPHJAMJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 KIIIOFFNPMA
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera PGMILJHCGON
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
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7054250", Offset = "0x7053050", VA = "0x187054250")]
			public ColorConfiguration(ParticleSystem KONBMFNBPMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8465890", Offset = "0x8464690", VA = "0x188465890")]
			public void CHBNBLJKGLE(Color PFKMCINIKNC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MMPGMMFMABO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public MMPGMMFMABO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8467120", Offset = "0x8465F20", VA = "0x188467120")]
			internal void INIKOBMFHII(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GKENPDKGCCL : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private BKKHFOOOECM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public GKENPDKGCCL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8465E80", Offset = "0x8464C80", VA = "0x188465E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84664A0", Offset = "0x84652A0", VA = "0x1884664A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class JMJHNMCLIAA : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public JMJHNMCLIAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8467060", Offset = "0x8465E60", VA = "0x188467060", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x84670D0", Offset = "0x8465ED0", VA = "0x1884670D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JPCOBHJPDGN;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<HHKEAHFPPBB> OECAIIDEFKL;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> LLEHMBKOCIP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IHBKINGAIAD OAMOCJHHIFI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float APLBEOBPCME = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool CNBNHDBEBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int OMNEIFLEFAM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private PAHHIODCCPD category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? JPNJGAMEAMH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] PNEMMCENBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] LOIHKNEBHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool MAGBHIAENHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float HLBMGGEJEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float PJOOPMMJGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform FPMKGDFCGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 CNJNPFMEFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 JOKNABKKHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private JJIBOPCGDAH DIBPKGMPKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IHBKINGAIAD LFFMPLEJJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool HNAMEFHEIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Transform KHPPIFGNOJD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> OLIDEEMMGMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x846BBB0", Offset = "0x846A9B0", VA = "0x18846BBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PAHHIODCCPD FFFOFBKHOKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA80B80", Offset = "0xA7F980", VA = "0x180A80B80")]
			get
			{
				return default(PAHHIODCCPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int OAOLAGJJCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CBELIOGKNIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x846B8E0", Offset = "0x846A6E0", VA = "0x18846B8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int KBLNBLFMAKL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x846BA60", Offset = "0x846A860", VA = "0x18846BA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OJMBPCPFBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8468E30", Offset = "0x8467C30", VA = "0x188468E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem FDILAHPNDDG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] CMKEEIJGLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] LEEFOBBOENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JJIBOPCGDAH GENOOGLFHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xEC65C0", Offset = "0xEC53C0", VA = "0x180EC65C0")]
			get
			{
				return default(JJIBOPCGDAH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84687A0", Offset = "0x84675A0", VA = "0x1884687A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform OLPMPAIMKPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x846BC00", Offset = "0x846AA00", VA = "0x18846BC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LHFKEHIOMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x846B840", Offset = "0x846A640", VA = "0x18846B840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x846BC50", Offset = "0x846AA50", VA = "0x18846BC50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x846B250", Offset = "0x846A050", VA = "0x18846B250")]
		public static PooledParticle TryPlayPrefab(PooledParticle FLFNPLAKMCE, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x846B370", Offset = "0x846A170", VA = "0x18846B370")]
		public static PooledParticle TryPlayPrefab(PooledParticle FLFNPLAKMCE, Vector3 EMECBHNHILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x846A960", Offset = "0x8469760", VA = "0x18846A960")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84694A0", Offset = "0x84682A0", VA = "0x1884694A0")]
		private void NINCGPGHBKK(bool GPJMDAINDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8468500", Offset = "0x8467300", VA = "0x188468500")]
		[IteratorStateMachine(typeof(GKENPDKGCCL))]
		private static IEnumerator<DMCHEKCEBGH> EDGCBKFFGCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84688D0", Offset = "0x84676D0", VA = "0x1884688D0")]
		private static void JHLGECBMCIM(Stopwatch INANPMNJHBH, Vector3 DOGMKDBMAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8468560", Offset = "0x8467360", VA = "0x188468560")]
		private static int FKCGMDPOHGP(PooledParticle PHLJLBDJNIE, PooledParticle GEOHFJAPCHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84687C0", Offset = "0x84675C0", VA = "0x1884687C0")]
		private static int INEDCHPNPOL(PAHHIODCCPD INDDHEPFNIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8468C40", Offset = "0x8467A40", VA = "0x188468C40")]
		protected void KHGIJLOBBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8469570", Offset = "0x8468370", VA = "0x188469570")]
		protected void NLBBKAKMECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8468150", Offset = "0x8466F50", VA = "0x188468150", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8468F70", Offset = "0x8467D70", VA = "0x188468F70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8469B80", Offset = "0x8468980", VA = "0x188469B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8467EB0", Offset = "0x8466CB0", VA = "0x188467EB0")]
		[IteratorStateMachine(typeof(JMJHNMCLIAA))]
		private IEnumerator<DMCHEKCEBGH> AFFNCDEANBJ(float CFEOPLEMNPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84692A0", Offset = "0x84680A0", VA = "0x1884692A0")]
		private void NIADOCPAAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x846AF90", Offset = "0x8469D90", VA = "0x18846AF90")]
		public void SetDuration(float CFEOPLEMNPG, bool HKOHBEELLFI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8469C80", Offset = "0x8468A80", VA = "0x188469C80")]
		public void Play(Transform NABAKKNHLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x846A530", Offset = "0x8469330", VA = "0x18846A530")]
		public void Play(Transform NABAKKNHLCD, bool FGOILMKGPNA, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8469DE0", Offset = "0x8468BE0", VA = "0x188469DE0")]
		public void Play(Transform NABAKKNHLCD, Vector3 JOKNABKKHAJ, bool FGOILMKGPNA, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8469F30", Offset = "0x8468D30", VA = "0x188469F30")]
		public void Play(Transform IFFLCPOAEEK, Quaternion NOLDGDLLBBL, bool FGOILMKGPNA = false, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x846A6A0", Offset = "0x84694A0", VA = "0x18846A6A0")]
		public void Play(Transform IFFLCPOAEEK, Vector3 JOKNABKKHAJ, Quaternion NOLDGDLLBBL, bool FGOILMKGPNA = false, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x846A1D0", Offset = "0x8468FD0", VA = "0x18846A1D0")]
		public void Play(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, Vector3 LNGDDNPHJHH, bool FGOILMKGPNA = false, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x846A070", Offset = "0x8468E70", VA = "0x18846A070")]
		public void Play(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, bool FGOILMKGPNA = false, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x846A350", Offset = "0x8469150", VA = "0x18846A350")]
		public void Play(bool FGOILMKGPNA = false, float AODHLEPPFKI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x846B1B0", Offset = "0x8469FB0", VA = "0x18846B1B0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x846B060", Offset = "0x8469E60", VA = "0x18846B060")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8468610", Offset = "0x8467410", VA = "0x188468610")]
		private void GEGCALEMHPG(float CFEOPLEMNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8467F40", Offset = "0x8466D40", VA = "0x188467F40")]
		private void AOHINPEBLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x846A7D0", Offset = "0x84695D0", VA = "0x18846A7D0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x846AAE0", Offset = "0x84698E0", VA = "0x18846AAE0")]
		public void SetColor(Color PFKMCINIKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8468EB0", Offset = "0x8467CB0", VA = "0x188468EB0")]
		private void KMGPHOMEKFC(float? GJEILCNCAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8469C10", Offset = "0x8468A10", VA = "0x188469C10")]
		private void PJCGBGEEFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84683D0", Offset = "0x84671D0", VA = "0x1884683D0")]
		private void CDKKKPEMHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x846B7A0", Offset = "0x846A5A0", VA = "0x18846B7A0")]
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
