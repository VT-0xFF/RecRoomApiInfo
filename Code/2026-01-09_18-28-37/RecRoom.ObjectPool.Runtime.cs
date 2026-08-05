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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D2590", Offset = "0x85D1990", VA = "0x1885D2590")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles prefab, float damage, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85D2230", Offset = "0x85D1630", VA = "0x1885D2230")]
		public void SetDamageValue(float damage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85D26D0", Offset = "0x85D1AD0", VA = "0x1885D26D0")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SLRLHQJVAVW<a> : KOPZSJWAQQR<a>, SKSLBBUJUBM, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JFHBEGKNXVF<a> : SKSLBBUJUBM, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HAQDXWKSWFU
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnInstantiate();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OMUOHVHJLYA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class SYKFHOZIJOT<a> : YCZXWPFSJVC<a>, SLRLHQJVAVW<a>, KOPZSJWAQQR<a>, SKSLBBUJUBM, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class OMQYCOONSBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public SYKFHOZIJOT<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public ObjectPool SNHYSUNQIAP;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public OMQYCOONSBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x5985CE0", Offset = "0x59850E0", VA = "0x185985CE0")]
				internal void PUIMATHDQAY(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x5985DE0", Offset = "0x59851E0", VA = "0x185985DE0")]
				internal void PUNSYABAZMH(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DULTLWUWMRK<a> MJATHXDKPRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ObjectPool SNHYSUNQIAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private a FTFYLZHIWCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private bool ZZTRGFNCDMN;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5DBC380", Offset = "0x5DBB780", VA = "0x185DBC380")]
			public SYKFHOZIJOT(DULTLWUWMRK<a> a, ObjectPool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5DBC240", Offset = "0x5DBB640", VA = "0x185DBC240", Slot = "27")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class XYACPKAPIJE<a> : VVQOLOWDTTB, JFHBEGKNXVF<a>, SKSLBBUJUBM, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class VKMWSMJNIRA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ObjectPool SNHYSUNQIAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public int CTQGKRYIMEZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public XYACPKAPIJE<a> ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public VKMWSMJNIRA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x6250EE0", Offset = "0x62502E0", VA = "0x186250EE0")]
				internal void PUIMATHDQAY(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x145AA30", Offset = "0x1459E30", VA = "0x18145AA30")]
				internal void PUNSYABAZMH(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private DULTLWUWMRK<a> MJATHXDKPRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool ZZTRGFNCDMN;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3DB73C0", Offset = "0x3DB67C0", VA = "0x183DB73C0")]
			public XYACPKAPIJE(DULTLWUWMRK<a> a, ObjectPool b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3DB7360", Offset = "0x3DB6760", VA = "0x183DB7360", Slot = "19")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MMAKMVZZEMK<a> where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OMUOHVHJLYA ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public YCZXWPFSJVC<bool> KYWNSHPQLYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public DULTLWUWMRK<a> MJATHXDKPRO;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MMAKMVZZEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x57D0FE0", Offset = "0x57D03E0", VA = "0x1857D0FE0")]
			internal void XEZCNHFBTWY(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x57D1070", Offset = "0x57D0470", VA = "0x1857D1070")]
			internal void XFEJKNYZDIH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x57D10D0", Offset = "0x57D04D0", VA = "0x1857D10D0")]
			internal void XFJQHUSWMTQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<HAQDXWKSWFU> LOGNFQRMBXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JZNYKEMSFZS IAHVKLKBAWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ObjectPool SNHYSUNQIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool ZZTRGFNCDMN;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85D1570", Offset = "0x85D0970", VA = "0x1885D1570")]
		private static void LUIFTQRWPRS(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85D1830", Offset = "0x85D0C30", VA = "0x1885D1830")]
		public OMUOHVHJLYA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x38B1ED0", Offset = "0x38B12D0", VA = "0x1838B1ED0")]
		public SLRLHQJVAVW<T> Acquire<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x38B23B0", Offset = "0x38B17B0", VA = "0x1838B23B0")]
		public JFHBEGKNXVF<a> UNXLXDSSVEO<a>(AssetReference a, int b) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38B1F80", Offset = "0x38B1380", VA = "0x1838B1F80")]
		public KOPZSJWAQQR<bool> Exists<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85D1340", Offset = "0x85D0740", VA = "0x1885D1340", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85D1430", Offset = "0x85D0830", VA = "0x1885D1430")]
		private void LLRLOSPQTLO(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85D11C0", Offset = "0x85D05C0", VA = "0x1885D11C0")]
		private ObjectPool BYVMWETQLDW(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GlobalPool WKYSXCBTISI;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GameObject MMIABHNRHLK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x85D1070", Offset = "0x85D0470", VA = "0x1885D1070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x36CA1D0", Offset = "0x36C95D0", VA = "0x1836CA1D0")]
		public static void SafeRelease<T>(T obj) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85D0FA0", Offset = "0x85D03A0", VA = "0x1885D0FA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85D1060", Offset = "0x85D0460", VA = "0x1885D1060")]
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
			public T MHEWXLBFLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xBEF450", Offset = "0xBEE850", VA = "0x180BEF450")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			internal PooledObject(T value, ObjectPool pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5A86FC0", Offset = "0x5A863C0", VA = "0x185A86FC0", Slot = "4")]
			private void HQQAIWMTMBV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly Dictionary<Component, DXNZHMNYTPH> FEMYPRIKTIU;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38B7D30", Offset = "0x38B7130", VA = "0x1838B7D30")]
		public T Acquire<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38B7C30", Offset = "0x38B7030", VA = "0x1838B7C30")]
		public PooledObject<T> AcquirePooledObject<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return default(PooledObject<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38B8110", Offset = "0x38B7510", VA = "0x1838B8110")]
		public bool Release<T>(T obj) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38B8080", Offset = "0x38B7480", VA = "0x1838B8080")]
		public void Prefill<T>(T prefab, int numInstances, [Optional] Action<Component> invokePerNewInstance) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38B7EA0", Offset = "0x38B72A0", VA = "0x1838B7EA0")]
		public bool Exists<T>(T prefab) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x38B7DF0", Offset = "0x38B71F0", VA = "0x1838B7DF0")]
		public void Clear<T>(T prefab) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E00", Offset = "0x85D1200", VA = "0x1885D1E00")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38B7F40", Offset = "0x38B7340", VA = "0x1838B7F40")]
		private DXNZHMNYTPH MFXNHIZJSHI<a>(a a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public void TrackInstantiation(string objectName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public void EnableStats(bool shouldEnable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85D1F70", Offset = "0x85D1370", VA = "0x1885D1F70")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class DXNZHMNYTPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public interface OEQVECZUNWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LCSJQXZIXPS(bool a);
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract int EIAEFINBPXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void UNXLXDSSVEO(int a, Action<Component> b);

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
		[Cpp2IlInjected.Address(RVA = "0x85D0E20", Offset = "0x85D0220", VA = "0x1885D0E20")]
		protected void BSCWVEQUZDW(Component a, bool b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85D0BA0", Offset = "0x85CFFA0", VA = "0x1885D0BA0")]
		protected void BOKAJVZJTGY(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected DXNZHMNYTPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TZZKTLWTOOS<a> : DXNZHMNYTPH where a : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private a QESCFNWZJWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ObjectPool ZILASJBLQTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool PUVOGYBSGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Queue<a> JKYMPLPAELZ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5F08D80", Offset = "0x5F08180", VA = "0x185F08D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override int EIAEFINBPXC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5F089A0", Offset = "0x5F07DA0", VA = "0x185F089A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F08DA0", Offset = "0x5F081A0", VA = "0x185F08DA0")]
		public TZZKTLWTOOS(a a, ObjectPool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F08B40", Offset = "0x5F07F40", VA = "0x185F08B40", Slot = "6")]
		public override void UNXLXDSSVEO(int a, Action<Component> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F08410", Offset = "0x5F07810", VA = "0x185F08410", Slot = "7")]
		public override Component Acquire(Action<Component> invokeOnNewInstance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F089C0", Offset = "0x5F07DC0", VA = "0x185F089C0", Slot = "8")]
		public override bool Release(Component behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F08630", Offset = "0x5F07A30", VA = "0x185F08630", Slot = "9")]
		public override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F08800", Offset = "0x5F07C00", VA = "0x185F08800")]
		private a IGOODNRECYK()
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
		public interface DKFLAKKNODX
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject XHILHJVMXMJ
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
		[Cpp2IlInjected.Address(RVA = "0x85D1AA0", Offset = "0x85D0EA0", VA = "0x1885D1AA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85D1D80", Offset = "0x85D1180", VA = "0x1885D1D80")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static PersistentGlobalPool WKYSXCBTISI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static GameObject MMIABHNRHLK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85D20B0", Offset = "0x85D14B0", VA = "0x1885D20B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85D1FF0", Offset = "0x85D13F0", VA = "0x1885D1FF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85D1060", Offset = "0x85D0460", VA = "0x1885D1060")]
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
		public DXNZHMNYTPH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JPUJTGVNLYR
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
		public interface MNMDEWDSGSM
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool EPFMNLMLFZO
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 LCGTNPGEFOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera NPUJSEHVOBJ
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
			[Cpp2IlInjected.Address(RVA = "0x7221DF0", Offset = "0x72211F0", VA = "0x187221DF0")]
			public ColorConfiguration(ParticleSystem mainParticles)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85D09B0", Offset = "0x85CFDB0", VA = "0x1885D09B0")]
			public void AVXFHEUXSIF(Color a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class TMGCCYJELEL : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private MNMDEWDSGSM DCVSCFHLJBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch YWLKXECWJUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] RELJEPHCULC;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public TMGCCYJELEL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x85D6560", Offset = "0x85D5960", VA = "0x1885D6560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x85D6520", Offset = "0x85D5920", VA = "0x1885D6520", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> BIWJOJILMMN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<JPUJTGVNLYR> CQWPSFAGNUP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> ZSUOTOAMDWT;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static ARAECGCQSWT UHKSYRBFPSS;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float PBVBXQOGZHX = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool UFFTLWYPHWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int CODQHPAVARX;

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
		private float? BASRZGNPAVR;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] HFFVOFSNUFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] USTQPVXXRXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool LNLXJIEUSKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float ROANUYPIVJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float VOKPHGOVYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform OEYVQLQMHIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 SWKQNTCOLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 VCGVQXLBRLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FollowType NQQRRQMXRHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private ARAECGCQSWT UQMOMRKPPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool GIHFCOPAOQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform YZTYANYVEYA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> TPHKIOZRVPO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85D63E0", Offset = "0x85D57E0", VA = "0x1885D63E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ParticleCategory GNXLPVLRGRA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xACB2A0", Offset = "0xACA6A0", VA = "0x180ACB2A0")]
			get
			{
				return default(ParticleCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ACWRZBMKDOR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool XHGDOZFMMRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85D5950", Offset = "0x85D4D50", VA = "0x1885D5950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int DDDFOMKMMTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85D62A0", Offset = "0x85D56A0", VA = "0x1885D62A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool LXTCQPQKMYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x85D2FE0", Offset = "0x85D23E0", VA = "0x1885D2FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem QSJDXIZDVDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] PFSCZQRRZQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAF000", Offset = "0xAAE400", VA = "0x180AAF000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] JGPGNOIQNXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AB0", Offset = "0xAA8EB0", VA = "0x180AA9AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float MZNORTVGAHG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAD9760", Offset = "0xAD8B60", VA = "0x180AD9760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FollowType DAXGZZQOFAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAF560", VA = "0x180AB0160")]
			get
			{
				return default(FollowType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85D3610", Offset = "0x85D2A10", VA = "0x1885D3610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Transform FSOLSSJPOTM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x85D6430", Offset = "0x85D5830", VA = "0x1885D6430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BAZFMQIUQOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85D6200", Offset = "0x85D5600", VA = "0x1885D6200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85D6480", Offset = "0x85D5880", VA = "0x1885D6480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85D54D0", Offset = "0x85D48D0", VA = "0x1885D54D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85D55F0", Offset = "0x85D49F0", VA = "0x1885D55F0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85D4630", Offset = "0x85D3A30", VA = "0x1885D4630")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85D36C0", Offset = "0x85D2AC0", VA = "0x1885D36C0")]
		private void PYYJDQPATBR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85D5950", Offset = "0x85D4D50", VA = "0x1885D5950")]
		private bool XWNQVQFCQZQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85D47A0", Offset = "0x85D3BA0", VA = "0x1885D47A0")]
		private Bounds SIJQXQZRIPG()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85D2A70", Offset = "0x85D1E70", VA = "0x1885D2A70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void DOFUUOUMXCX(ParticleSystemRenderer a, int b, UnityEngine.Object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85D2A20", Offset = "0x85D1E20", VA = "0x1885D2A20")]
		[IteratorStateMachine(typeof(TMGCCYJELEL))]
		private static IEnumerator<QAEGIZFUAOU> CRCYHPWLASN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85D2B50", Offset = "0x85D1F50", VA = "0x1885D2B50")]
		private static void FQWJWRWESNG(Stopwatch a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85D3160", Offset = "0x85D2560", VA = "0x1885D3160")]
		private static int KXPLWVIUORA(PooledParticle a, PooledParticle b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85D3060", Offset = "0x85D2460", VA = "0x1885D3060")]
		private static int JFVZYDXTPZM(ParticleCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85D5770", Offset = "0x85D4B70", VA = "0x1885D5770")]
		protected void VVSLJQYBEXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85D5A30", Offset = "0x85D4E30", VA = "0x1885D5A30")]
		protected void YBYKFWSXBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85D27B0", Offset = "0x85D1BB0", VA = "0x1885D27B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85D32D0", Offset = "0x85D26D0", VA = "0x1885D32D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85D3630", Offset = "0x85D2A30", VA = "0x1885D3630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85D42A0", Offset = "0x85D36A0", VA = "0x1885D42A0")]
		private void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85D5050", Offset = "0x85D4450", VA = "0x1885D5050")]
		public void SetDuration(float duration, bool setStartLifetime = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85D3790", Offset = "0x85D2B90", VA = "0x1885D3790")]
		public void Play(Transform followTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85D4000", Offset = "0x85D3400", VA = "0x1885D4000")]
		public void Play(Transform followTransform, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85D38F0", Offset = "0x85D2CF0", VA = "0x1885D38F0")]
		public void Play(Transform followTransform, Vector3 followWorldSpaceOffset, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85D3A40", Offset = "0x85D2E40", VA = "0x1885D3A40")]
		public void Play(Transform followPosition, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85D4170", Offset = "0x85D3570", VA = "0x1885D4170")]
		public void Play(Transform followPosition, Vector3 followWorldSpaceOffset, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85D3CE0", Offset = "0x85D30E0", VA = "0x1885D3CE0")]
		public void Play(Vector3 position, Quaternion rotation, Vector3 velocity, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85D3B80", Offset = "0x85D2F80", VA = "0x1885D3B80")]
		public void Play(Vector3 position, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85D3E60", Offset = "0x85D3260", VA = "0x1885D3E60")]
		public void Play(bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85D5220", Offset = "0x85D4620", VA = "0x1885D5220")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85D5120", Offset = "0x85D4520", VA = "0x1885D5120")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85D52C0", Offset = "0x85D46C0", VA = "0x1885D52C0")]
		private void TOJZQUEDLEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85D44A0", Offset = "0x85D38A0", VA = "0x1885D44A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85D4BA0", Offset = "0x85D3FA0", VA = "0x1885D4BA0")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85D3210", Offset = "0x85D2610", VA = "0x1885D3210")]
		private void LOYRNJICGFB(float? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85D4B30", Offset = "0x85D3F30", VA = "0x1885D4B30")]
		private void SSEVYCPVYLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85D2EB0", Offset = "0x85D22B0", VA = "0x1885D2EB0")]
		private void IKLWWWLWKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85D6170", Offset = "0x85D5570", VA = "0x1885D6170")]
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
