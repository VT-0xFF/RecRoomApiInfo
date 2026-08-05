using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetBundles;
using RecRoom.Async;
using RecRoom.Core.Pools;
using RecRoom.DataStructures.ResourceHandles;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x885F540", Offset = "0x885E540", VA = "0x18885F540")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles prefab, float damage, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x885F1E0", Offset = "0x885E1E0", VA = "0x18885F1E0")]
		public void SetDamageValue(float damage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x885F680", Offset = "0x885E680", VA = "0x18885F680")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface VHQBJNEVUZJ<a> : VKQMZHJZWXK<a>, YTAUUGIQSDF, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface AHNZWKQCAOS<a> : YTAUUGIQSDF, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DZXMOXWCJVZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnInstantiate();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QYBZXFVEWLN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class ZDCMLTEVFYK<a> : XSWSNEJLTGH<a>, VHQBJNEVUZJ<a>, VKQMZHJZWXK<a>, YTAUUGIQSDF, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class NMXMBBMJYRH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public ZDCMLTEVFYK<a> SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public ObjectPool CDTGLVMWDXY;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public NMXMBBMJYRH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x5B66980", Offset = "0x5B65980", VA = "0x185B66980")]
				internal void AVFLGHWIDEH(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x5B66950", Offset = "0x5B65950", VA = "0x185B66950")]
				internal void AVAEJBCKTSY(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TEHJZDMBIST<a> EPKZJUAXWYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ObjectPool CDTGLVMWDXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private a BHFGTEQSRMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private bool HORTZAXUTKY;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3F32220", Offset = "0x3F31220", VA = "0x183F32220")]
			public ZDCMLTEVFYK(TEHJZDMBIST<a> a, ObjectPool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3F320E0", Offset = "0x3F310E0", VA = "0x183F320E0", Slot = "27")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ZRANAVSOIWZ<a> : ZMNCXYLBFLK, AHNZWKQCAOS<a>, YTAUUGIQSDF, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class MJLEUFQBZLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ObjectPool CDTGLVMWDXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public int JSQQKHYNQCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public ZRANAVSOIWZ<a> SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public MJLEUFQBZLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x5A8ED30", Offset = "0x5A8DD30", VA = "0x185A8ED30")]
				internal void AVFLGHWIDEH(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x14D9450", Offset = "0x14D8450", VA = "0x1814D9450")]
				internal void AVAEJBCKTSY(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TEHJZDMBIST<a> EPKZJUAXWYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool HORTZAXUTKY;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3F4C880", Offset = "0x3F4B880", VA = "0x183F4C880")]
			public ZRANAVSOIWZ(TEHJZDMBIST<a> a, ObjectPool b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3F4C820", Offset = "0x3F4B820", VA = "0x183F4C820", Slot = "19")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PFCQVHTKEZL<a> where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public QYBZXFVEWLN SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public XSWSNEJLTGH<bool> ZXCFMDBOSGQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TEHJZDMBIST<a> EPKZJUAXWYF;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public PFCQVHTKEZL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDB00", Offset = "0x5DBCB00", VA = "0x185DBDB00")]
			internal void TESMEVPYOJX(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDAA0", Offset = "0x5DBCAA0", VA = "0x185DBDAA0")]
			internal void TENFHOWBEYO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDA50", Offset = "0x5DBCA50", VA = "0x185DBDA50")]
			internal void TEHYKICDVNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<DZXMOXWCJVZ> EWFSFSMDUDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private WPHDQYXELDN DSLUVHJMTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ObjectPool CDTGLVMWDXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool HORTZAXUTKY;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8863740", Offset = "0x8862740", VA = "0x188863740")]
		private static void WYKMRLBALZF(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8863B50", Offset = "0x8862B50", VA = "0x188863B50")]
		public QYBZXFVEWLN(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x39FDC40", Offset = "0x39FCC40", VA = "0x1839FDC40")]
		public VHQBJNEVUZJ<T> Acquire<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x39FE120", Offset = "0x39FD120", VA = "0x1839FE120")]
		public AHNZWKQCAOS<a> ITWVWGGBIWN<a>(AssetReference a, int b) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39FDCF0", Offset = "0x39FCCF0", VA = "0x1839FDCF0")]
		public VKQMZHJZWXK<bool> Exists<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88634D0", Offset = "0x88624D0", VA = "0x1888634D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8863980", Offset = "0x8862980", VA = "0x188863980")]
		private void ZRYPLPACUJX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88635C0", Offset = "0x88625C0", VA = "0x1888635C0")]
		private ObjectPool PWHXZWJKZGL(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GlobalPool BQYDEMZZJBN;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GameObject PNBZKNMIGYB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x885E380", Offset = "0x885D380", VA = "0x18885E380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x375D040", Offset = "0x375C040", VA = "0x18375D040")]
		public static void SafeRelease<T>(T obj) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x885E2B0", Offset = "0x885D2B0", VA = "0x18885E2B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x885E370", Offset = "0x885D370", VA = "0x18885E370")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct PooledObject<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly T toReturn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly ObjectPool pool;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T FNDQYUTZTLK
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			internal PooledObject(T value, ObjectPool pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DF2D40", Offset = "0x5DF1D40", VA = "0x185DF2D40", Slot = "4")]
			private void FQZHCUDIKGC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly Dictionary<Component, AWZOJRYMDLY> XWIWARHHIOH;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x396AF80", Offset = "0x3969F80", VA = "0x18396AF80")]
		public T Acquire<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x396AE80", Offset = "0x3969E80", VA = "0x18396AE80")]
		public PooledObject<T> AcquirePooledObject<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return default(PooledObject<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x396B220", Offset = "0x396A220", VA = "0x18396B220")]
		public bool Release<T>(T obj) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x396B190", Offset = "0x396A190", VA = "0x18396B190")]
		public void Prefill<T>(T prefab, int numInstances, [Optional] Action<Component> invokePerNewInstance) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x396B0F0", Offset = "0x396A0F0", VA = "0x18396B0F0")]
		public bool Exists<T>(T prefab) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x396B040", Offset = "0x396A040", VA = "0x18396B040")]
		public void Clear<T>(T prefab) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x885EDB0", Offset = "0x885DDB0", VA = "0x18885EDB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x396B3E0", Offset = "0x396A3E0", VA = "0x18396B3E0")]
		private AWZOJRYMDLY UYOBMHNIKXJ<a>(a a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void TrackInstantiation(string objectName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void EnableStats(bool shouldEnable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x885EF20", Offset = "0x885DF20", VA = "0x18885EF20")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AWZOJRYMDLY
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public interface AHIKBSBWGGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OBGHKORUKXZ(bool a);
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract int LVFQKJALOUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ITWVWGGBIWN(int a, Action<Component> b);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Component Acquire(Action<Component> invokeOnNewInstance);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Release(Component behaviour);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x885DF40", Offset = "0x885CF40", VA = "0x18885DF40")]
		protected void WXJZKZBIZEH(Component a, bool b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x885DCC0", Offset = "0x885CCC0", VA = "0x18885DCC0")]
		protected void USPDKYCMQSF(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected AWZOJRYMDLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class OJGZKRKQLAJ<a> : AWZOJRYMDLY where a : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private a LOZSGZHOAEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ObjectPool QATAGREIEXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool VVMAOMZCUBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Queue<a> AUZQFMWBFIK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5CA34C0", Offset = "0x5CA24C0", VA = "0x185CA34C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override int LVFQKJALOUD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5CA34A0", Offset = "0x5CA24A0", VA = "0x185CA34A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA34E0", Offset = "0x5CA24E0", VA = "0x185CA34E0")]
		public OJGZKRKQLAJ(a a, ObjectPool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA30C0", Offset = "0x5CA20C0", VA = "0x185CA30C0", Slot = "6")]
		public override void ITWVWGGBIWN(int a, Action<Component> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2B30", Offset = "0x5CA1B30", VA = "0x185CA2B30", Slot = "7")]
		public override Component Acquire(Action<Component> invokeOnNewInstance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3310", Offset = "0x5CA2310", VA = "0x185CA3310", Slot = "8")]
		public override bool Release(Component behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2EF0", Offset = "0x5CA1EF0", VA = "0x185CA2EF0", Slot = "9")]
		public override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2D50", Offset = "0x5CA1D50", VA = "0x185CA2D50")]
		private a BLNCJENQKFN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public interface EGAHIFJSPOU
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject FNLUAHDEJPY
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x885EA50", Offset = "0x885DA50", VA = "0x18885EA50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x885ED30", Offset = "0x885DD30", VA = "0x18885ED30")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static PersistentGlobalPool BQYDEMZZJBN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static GameObject PNBZKNMIGYB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x885F060", Offset = "0x885E060", VA = "0x18885F060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x885EFA0", Offset = "0x885DFA0", VA = "0x18885EFA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x885E370", Offset = "0x885D370", VA = "0x18885E370")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AWZOJRYMDLY PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface QZKCAPINKAW
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetCategoryPriority(PooledParticle.ParticleCategory category);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private enum FollowType
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ParticleCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public interface UKVVLLSJQJV
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool XBXZBYTHZLV
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 TQLLBUHPDKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera UQMSPZAXNCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x747EA10", Offset = "0x747DA10", VA = "0x18747EA10")]
			public ColorConfiguration(ParticleSystem mainParticles)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x885E0C0", Offset = "0x885D0C0", VA = "0x18885E0C0")]
			public void PQCCCFHXZQU(Color a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KDYGSRFJMTU : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private UKVVLLSJQJV ZKGHJUEFTFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch ERUSJBDIKNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] NCTNKLWZDXZ;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public KDYGSRFJMTU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x885E4D0", Offset = "0x885D4D0", VA = "0x18885E4D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x885EA10", Offset = "0x885DA10", VA = "0x18885EA10", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JXBKMHWZLEO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<QZKCAPINKAW> AJTEFKKEVKK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> OXWICEZERHY;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static ALZORZCQSFK TOELQARJLAZ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float WEDRTZENWSU = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool AXKUMPAUBYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int IHHXBZHCKYA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private ParticleCategory category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? VNSMUENIELI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] NMNSNWMXNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] NCOTOYHFNVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool NAZVHDJUPXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float YTOGQVTHRCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float QUNTQMDORVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform VGNFZNKHJPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 TVOLOMENUWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 LHNLNRNPDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FollowType PZEWWVDKXST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private ALZORZCQSFK IXIIOIFTFUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool KVMIBRHVNFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform BBRVWKAXTWT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> PCBNICZGLQT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8863390", Offset = "0x8862390", VA = "0x188863390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ParticleCategory GTABTDOAPHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00")]
			get
			{
				return default(ParticleCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int TYFOWUPNLNC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool SDYQODCXKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8862D20", Offset = "0x8861D20", VA = "0x188862D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int ROXBESVCRIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8863250", Offset = "0x8862250", VA = "0x188863250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool DZZBGQCNFMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8862E50", Offset = "0x8861E50", VA = "0x188862E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem KEFQAWMBAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] KUFDWQXGPSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAD3540", Offset = "0xAD2540", VA = "0x180AD3540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] BBAMUXZYUQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F10", Offset = "0xAD1F10", VA = "0x180AD2F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float OBFLPBKNQZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB026E0", Offset = "0xB016E0", VA = "0x180B026E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FollowType RHAVIYFPPEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAD82D0", Offset = "0xAD72D0", VA = "0x180AD82D0")]
			get
			{
				return default(FollowType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x885FC20", Offset = "0x885EC20", VA = "0x18885FC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Transform PBSPRLEJMHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x88633E0", Offset = "0x88623E0", VA = "0x1888633E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HURKJANBMDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88631B0", Offset = "0x88621B0", VA = "0x1888631B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8863430", Offset = "0x8862430", VA = "0x188863430")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88629D0", Offset = "0x88619D0", VA = "0x1888629D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8862AF0", Offset = "0x8861AF0", VA = "0x188862AF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8861F80", Offset = "0x8860F80", VA = "0x188861F80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88601B0", Offset = "0x885F1B0", VA = "0x1888601B0")]
		private void FJHQJVXNIPC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8862D20", Offset = "0x8861D20", VA = "0x188862D20")]
		private bool VXLKYTIPVMX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8860850", Offset = "0x885F850", VA = "0x188860850")]
		private Bounds KRLMFROTINN()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8860770", Offset = "0x885F770", VA = "0x188860770")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void HLNQBONMWAE(ParticleSystemRenderer a, int b, UnityEngine.Object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8862E00", Offset = "0x8861E00", VA = "0x188862E00")]
		[IteratorStateMachine(typeof(KDYGSRFJMTU))]
		private static IEnumerator<ADJUPIXYSVF> VZLEZRKTUNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x885FE50", Offset = "0x885EE50", VA = "0x18885FE50")]
		private static void ETQMPDPPDID(Stopwatch a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8862C70", Offset = "0x8861C70", VA = "0x188862C70")]
		private static int UBAEFUXVMCL(PooledParticle a, PooledParticle b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88620F0", Offset = "0x88610F0", VA = "0x1888620F0")]
		private static int SSGFUMUHBXP(ParticleCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x885FA40", Offset = "0x885EA40", VA = "0x18885FA40")]
		protected void CRXEIRMCLQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8860280", Offset = "0x885F280", VA = "0x188860280")]
		protected void GQRCHQTHYKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x885F760", Offset = "0x885E760", VA = "0x18885F760", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8860BE0", Offset = "0x885FBE0", VA = "0x188860BE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8860F20", Offset = "0x885FF20", VA = "0x188860F20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8861BF0", Offset = "0x8860BF0", VA = "0x188861BF0")]
		private void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88626A0", Offset = "0x88616A0", VA = "0x1888626A0")]
		public void SetDuration(float duration, bool setStartLifetime = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8860FB0", Offset = "0x885FFB0", VA = "0x188860FB0")]
		public void Play(Transform followTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8861820", Offset = "0x8860820", VA = "0x188861820")]
		public void Play(Transform followTransform, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8861110", Offset = "0x8860110", VA = "0x188861110")]
		public void Play(Transform followTransform, Vector3 followWorldSpaceOffset, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8861260", Offset = "0x8860260", VA = "0x188861260")]
		public void Play(Transform followPosition, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8861990", Offset = "0x8860990", VA = "0x188861990")]
		public void Play(Transform followPosition, Vector3 followWorldSpaceOffset, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8861500", Offset = "0x8860500", VA = "0x188861500")]
		public void Play(Vector3 position, Quaternion rotation, Vector3 velocity, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88613A0", Offset = "0x88603A0", VA = "0x1888613A0")]
		public void Play(Vector3 position, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8861680", Offset = "0x8860680", VA = "0x188861680")]
		public void Play(bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8862870", Offset = "0x8861870", VA = "0x188862870")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8862770", Offset = "0x8861770", VA = "0x188862770")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x885FC40", Offset = "0x885EC40", VA = "0x18885FC40")]
		private void EPIVPHBDWRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8861DF0", Offset = "0x8860DF0", VA = "0x188861DF0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88621F0", Offset = "0x88611F0", VA = "0x1888621F0")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8862910", Offset = "0x8861910", VA = "0x188862910")]
		private void TXXYESYVLZO(float? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x885F9D0", Offset = "0x885E9D0", VA = "0x18885F9D0")]
		private void CRJHEJSOHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8861AC0", Offset = "0x8860AC0", VA = "0x188861AC0")]
		private void RTKUFGHYJVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8863120", Offset = "0x8862120", VA = "0x188863120")]
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
