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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x87F4AC0", Offset = "0x87F3CC0", VA = "0x1887F4AC0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles prefab, float damage, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87F4760", Offset = "0x87F3960", VA = "0x1887F4760")]
		public void SetDamageValue(float damage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C00", Offset = "0x87F3E00", VA = "0x1887F4C00")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ESSMKDELNQC<a> : YUBVFZQANJB<a>, AZBXLTTNREY, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface QPGKFWGNTDL<a> : AZBXLTTNREY, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BBDAQDYUKGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnInstantiate();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class YOSJCCFRYMK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class CCXBEXPUTIZ<a> : PSJCSVSCOIC<a>, ESSMKDELNQC<a>, YUBVFZQANJB<a>, AZBXLTTNREY, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class PLYECEGTBAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public CCXBEXPUTIZ<a> LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public ObjectPool CELBXRLZDQV;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PLYECEGTBAG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x5BD4240", Offset = "0x5BD3440", VA = "0x185BD4240")]
				internal void FQHMAMHPQLA(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x5BD4340", Offset = "0x5BD3540", VA = "0x185BD4340")]
				internal void FQMSXTBMZWJ(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private LMVHCOIRJIW<a> UAEMZQXTBKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ObjectPool CELBXRLZDQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private a ASMDMMWEUQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private bool WCTMPOAJLBF;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CD70", Offset = "0x3D9BF70", VA = "0x183D9CD70")]
			public CCXBEXPUTIZ(LMVHCOIRJIW<a> a, ObjectPool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CC30", Offset = "0x3D9BE30", VA = "0x183D9CC30", Slot = "27")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PKQEFKBJFVW<a> : JIQTMOOBEYN, QPGKFWGNTDL<a>, AZBXLTTNREY, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class PWPEITYPPDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ObjectPool CELBXRLZDQV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public int ULJJHBYNRZB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public PKQEFKBJFVW<a> LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				public PWPEITYPPDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x5C18930", Offset = "0x5C17B30", VA = "0x185C18930")]
				internal void FQHMAMHPQLA(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x14C82B0", Offset = "0x14C74B0", VA = "0x1814C82B0")]
				internal void FQMSXTBMZWJ(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private LMVHCOIRJIW<a> UAEMZQXTBKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool WCTMPOAJLBF;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5BD2100", Offset = "0x5BD1300", VA = "0x185BD2100")]
			public PKQEFKBJFVW(LMVHCOIRJIW<a> a, ObjectPool b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5BD2040", Offset = "0x5BD1240", VA = "0x185BD2040", Slot = "19")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LKDBRXWPCQY<a> where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public YOSJCCFRYMK LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PSJCSVSCOIC<bool> BQKBLCCBDWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LMVHCOIRJIW<a> UAEMZQXTBKG;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public LKDBRXWPCQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x537E260", Offset = "0x537D460", VA = "0x18537E260")]
			internal void HORIRGMEZVU(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x537E2F0", Offset = "0x537D4F0", VA = "0x18537E2F0")]
			internal void HOWPONGCJHD(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x537E210", Offset = "0x537D410", VA = "0x18537E210")]
			internal void HOGUWSYKGZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<BBDAQDYUKGQ> OFXOFNRFXOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IDOZODRBIUS IKPGNRGUKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ObjectPool CELBXRLZDQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool WCTMPOAJLBF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87F93C0", Offset = "0x87F85C0", VA = "0x1887F93C0")]
		private static void OTPHIYLEUOK(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87F9800", Offset = "0x87F8A00", VA = "0x1887F9800")]
		public YOSJCCFRYMK(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3C54410", Offset = "0x3C53610", VA = "0x183C54410")]
		public ESSMKDELNQC<T> Acquire<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C54880", Offset = "0x3C53A80", VA = "0x183C54880")]
		public QPGKFWGNTDL<a> XPQAMROKTTO<a>(AssetReference a, int b) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C544C0", Offset = "0x3C536C0", VA = "0x183C544C0")]
		public YUBVFZQANJB<bool> Exists<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87F9180", Offset = "0x87F8380", VA = "0x1887F9180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87F9270", Offset = "0x87F8470", VA = "0x1887F9270")]
		private void ENWBCIOKNNY(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87F9600", Offset = "0x87F8800", VA = "0x1887F9600")]
		private ObjectPool WDIRWKQQWTU(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GlobalPool EYVGSUSZKGK;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GameObject ZWSCHHPSCIO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x87F3A80", Offset = "0x87F2C80", VA = "0x1887F3A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x373C3E0", Offset = "0x373B5E0", VA = "0x18373C3E0")]
		public static void SafeRelease<T>(T obj) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87F39B0", Offset = "0x87F2BB0", VA = "0x1887F39B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87F3A70", Offset = "0x87F2C70", VA = "0x1887F3A70")]
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
			public T LRBPAVAYBMJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
			internal PooledObject(T value, ObjectPool pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5C455F0", Offset = "0x5C447F0", VA = "0x185C455F0", Slot = "4")]
			private void JZSTYLGWFSV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly Dictionary<Component, POTDNLEGHBR> WYKDWLHBLHQ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3950C20", Offset = "0x394FE20", VA = "0x183950C20")]
		public T Acquire<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3950B20", Offset = "0x394FD20", VA = "0x183950B20")]
		public PooledObject<T> AcquirePooledObject<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return default(PooledObject<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3951000", Offset = "0x3950200", VA = "0x183951000")]
		public bool Release<T>(T obj) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3950F70", Offset = "0x3950170", VA = "0x183950F70")]
		public void Prefill<T>(T prefab, int numInstances, [Optional] Action<Component> invokePerNewInstance) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3950D90", Offset = "0x394FF90", VA = "0x183950D90")]
		public bool Exists<T>(T prefab) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3950CE0", Offset = "0x394FEE0", VA = "0x183950CE0")]
		public void Clear<T>(T prefab) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87F3F30", Offset = "0x87F3130", VA = "0x1887F3F30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3950E30", Offset = "0x3950030", VA = "0x183950E30")]
		private POTDNLEGHBR GIJMULLZHUU<a>(a a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public void TrackInstantiation(string objectName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public void EnableStats(bool shouldEnable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87F40A0", Offset = "0x87F32A0", VA = "0x1887F40A0")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class POTDNLEGHBR
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public interface HSVWUIWRXYC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SSINFKIEAQG(bool a);
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract int HEMUPWEZDSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void XPQAMROKTTO(int a, Action<Component> b);

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
		[Cpp2IlInjected.Address(RVA = "0x87F43A0", Offset = "0x87F35A0", VA = "0x1887F43A0")]
		protected void XWBCAOUKLJE(Component a, bool b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87F4120", Offset = "0x87F3320", VA = "0x1887F4120")]
		protected void VNEVRSARKZY(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected POTDNLEGHBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class OVIWWZTUDRW<a> : POTDNLEGHBR where a : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private a YTHYDDRNOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ObjectPool VIOXSESABZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool TNDRNVCBGRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Queue<a> BXEODIDGTOV;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5B11B70", Offset = "0x5B10D70", VA = "0x185B11B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override int HEMUPWEZDSG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5B11D60", Offset = "0x5B10F60", VA = "0x185B11D60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B12300", Offset = "0x5B11500", VA = "0x185B12300")]
		public OVIWWZTUDRW(a a, ObjectPool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B120B0", Offset = "0x5B112B0", VA = "0x185B120B0", Slot = "6")]
		public override void XPQAMROKTTO(int a, Action<Component> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B11940", Offset = "0x5B10B40", VA = "0x185B11940", Slot = "7")]
		public override Component Acquire(Action<Component> invokeOnNewInstance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B11D80", Offset = "0x5B10F80", VA = "0x185B11D80", Slot = "8")]
		public override bool Release(Component behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B11B90", Offset = "0x5B10D90", VA = "0x185B11B90", Slot = "9")]
		public override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5B11F10", Offset = "0x5B11110", VA = "0x185B11F10")]
		private a VKPLTDUXICE()
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
		public interface UVFFPDUQLRB
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject SOSETADSAUT
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
		[Cpp2IlInjected.Address(RVA = "0x87F3BD0", Offset = "0x87F2DD0", VA = "0x1887F3BD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87F3EB0", Offset = "0x87F30B0", VA = "0x1887F3EB0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static PersistentGlobalPool EYVGSUSZKGK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static GameObject ZWSCHHPSCIO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x87F45E0", Offset = "0x87F37E0", VA = "0x1887F45E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x87F4520", Offset = "0x87F3720", VA = "0x1887F4520")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x87F3A70", Offset = "0x87F2C70", VA = "0x1887F3A70")]
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
		public POTDNLEGHBR PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface XSQHDLUPCWL
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
		public interface QXQEYKCOPCS
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool LJEOZCCDLHE
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 CULIBQUBGWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera ZOLTAGWAGEN
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
			[Cpp2IlInjected.Address(RVA = "0x7419A90", Offset = "0x7418C90", VA = "0x187419A90")]
			public ColorConfiguration(ParticleSystem mainParticles)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x87F37C0", Offset = "0x87F29C0", VA = "0x1887F37C0")]
			public void FGEAXVEASBJ(Color a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class QIYLCCDHKSF : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private QXQEYKCOPCS DGZJMFSYQEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch IADGAZFWRQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] OYLPSONNCTQ;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public QIYLCCDHKSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87F8A50", Offset = "0x87F7C50", VA = "0x1887F8A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87F8F80", Offset = "0x87F8180", VA = "0x1887F8F80", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> QYZHXTJIEEX;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<XSQHDLUPCWL> CIBQPGRBULT;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> OAPWYIBOOZX;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IFXEZINOVAZ RGIVKQJTUDW;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float KSEFVMZYLKP = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool GONBUHYSRSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int EZNBKRXODQH;

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
		private float? SNURGDACLNX;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] WZBRRRZGVYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] KTMZYLTWIWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool GDTUZQOLPCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float EZNBIXFLHUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float WSDEZAFRCKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform NMFFWAXKLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 CGACLAXZMAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 HDKEDSNABYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FollowType FZFVKRLMDVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IFXEZINOVAZ TDQPGQGBWAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool ASJREGBMHUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform YNCFVFIVAQW;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> IVSSIIKTPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87F8910", Offset = "0x87F7B10", VA = "0x1887F8910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ParticleCategory OVUFGEMGETW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xADEA60", Offset = "0xADDC60", VA = "0x180ADEA60")]
			get
			{
				return default(ParticleCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ZBVGYCKNLJV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UOPIMDBEPYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x87F5400", Offset = "0x87F4600", VA = "0x1887F5400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int MQXIYYYKCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x87F87D0", Offset = "0x87F79D0", VA = "0x1887F87D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool PVUTQFFSSRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x87F5890", Offset = "0x87F4A90", VA = "0x1887F5890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem NFOTVBWBTXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] ZQUTPSCVGBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xABEC10", Offset = "0xABDE10", VA = "0x180ABEC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] JWYCPETUWMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xABE640", Offset = "0xABD840", VA = "0x180ABE640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float PGMVVPXGNIS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAED580", Offset = "0xAEC780", VA = "0x180AED580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FollowType YAQEHOTFTNL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB9310", Offset = "0xAB8510", VA = "0x180AB9310")]
			get
			{
				return default(FollowType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x87F5910", Offset = "0x87F4B10", VA = "0x1887F5910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Transform GCCZVOFBKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x87F8960", Offset = "0x87F7B60", VA = "0x1887F8960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NQMGGUTJDVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x87F8730", Offset = "0x87F7930", VA = "0x1887F8730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x87F89B0", Offset = "0x87F7BB0", VA = "0x1887F89B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87F8090", Offset = "0x87F7290", VA = "0x1887F8090")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x87F81B0", Offset = "0x87F73B0", VA = "0x1887F81B0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x87F7290", Offset = "0x87F6490", VA = "0x1887F7290")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x87F8330", Offset = "0x87F7530", VA = "0x1887F8330")]
		private void UWEWYPQJWOJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x87F5400", Offset = "0x87F4600", VA = "0x1887F5400")]
		private bool JIHUCFWPIDW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x87F7530", Offset = "0x87F6730", VA = "0x1887F7530")]
		private Bounds SXSHXXNEPIK()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x87F5260", Offset = "0x87F4460", VA = "0x1887F5260")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void FFUXETTSENX(ParticleSystemRenderer a, int b, UnityEngine.Object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87F8400", Offset = "0x87F7600", VA = "0x1887F8400")]
		[IteratorStateMachine(typeof(QIYLCCDHKSF))]
		private static IEnumerator<GVXKGQILIBM> YOIWFRODWYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87F59C0", Offset = "0x87F4BC0", VA = "0x1887F59C0")]
		private static void PDNKRYIYIJE(Stopwatch a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87F78C0", Offset = "0x87F6AC0", VA = "0x1887F78C0")]
		private static int SZIZNFDVIGY(PooledParticle a, PooledParticle b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x87F5160", Offset = "0x87F4360", VA = "0x1887F5160")]
		private static int FDWDMQEISZW(ParticleCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87F6D20", Offset = "0x87F5F20", VA = "0x1887F6D20")]
		protected void RYTYIGXJGRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87F6830", Offset = "0x87F5A30", VA = "0x1887F6830")]
		protected void RTZCEMVVNRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87F4CE0", Offset = "0x87F3EE0", VA = "0x1887F4CE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87F5550", Offset = "0x87F4750", VA = "0x1887F5550")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87F5930", Offset = "0x87F4B30", VA = "0x1887F5930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x87F6F00", Offset = "0x87F6100", VA = "0x1887F6F00")]
		private void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x87F7E20", Offset = "0x87F7020", VA = "0x1887F7E20")]
		public void SetDuration(float duration, bool setStartLifetime = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x87F5D20", Offset = "0x87F4F20", VA = "0x1887F5D20")]
		public void Play(Transform followTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x87F6590", Offset = "0x87F5790", VA = "0x1887F6590")]
		public void Play(Transform followTransform, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x87F5E80", Offset = "0x87F5080", VA = "0x1887F5E80")]
		public void Play(Transform followTransform, Vector3 followWorldSpaceOffset, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x87F5FD0", Offset = "0x87F51D0", VA = "0x1887F5FD0")]
		public void Play(Transform followPosition, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87F6700", Offset = "0x87F5900", VA = "0x1887F6700")]
		public void Play(Transform followPosition, Vector3 followWorldSpaceOffset, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x87F6270", Offset = "0x87F5470", VA = "0x1887F6270")]
		public void Play(Vector3 position, Quaternion rotation, Vector3 velocity, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87F6110", Offset = "0x87F5310", VA = "0x1887F6110")]
		public void Play(Vector3 position, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87F63F0", Offset = "0x87F55F0", VA = "0x1887F63F0")]
		public void Play(bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x87F7FF0", Offset = "0x87F71F0", VA = "0x1887F7FF0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87F7EF0", Offset = "0x87F70F0", VA = "0x1887F7EF0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87F4F50", Offset = "0x87F4150", VA = "0x1887F4F50")]
		private void EALZSZTDTKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87F7100", Offset = "0x87F6300", VA = "0x1887F7100")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x87F7970", Offset = "0x87F6B70", VA = "0x1887F7970")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x87F5340", Offset = "0x87F4540", VA = "0x1887F5340")]
		private void GBZUETPTDXD(float? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x87F54E0", Offset = "0x87F46E0", VA = "0x1887F54E0")]
		private void LLATCBPPWWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x87F7400", Offset = "0x87F6600", VA = "0x1887F7400")]
		private void SEFLGTMZEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x87F86A0", Offset = "0x87F78A0", VA = "0x1887F86A0")]
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
