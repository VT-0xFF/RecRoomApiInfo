using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PrefabCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private Dictionary<string, GameObject> temporaryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> permanentCache;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3560BA0", Offset = "0x355F9A0", VA = "0x183560BA0")]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3560880", Offset = "0x355F680", VA = "0x183560880", Slot = "1")]
		~PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3560B30", Offset = "0x355F930", VA = "0x183560B30")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x35609C0", Offset = "0x355F7C0", VA = "0x1835609C0")]
		public GameObject GetOrCachePrefab(string prefabName, bool isPermanent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35609A0", Offset = "0x355F7A0", VA = "0x1835609A0")]
		public IPromise<GameObject> GetOrCachePrefabAsync(string prefabName, bool isPermanent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3560A00", Offset = "0x355F800", VA = "0x183560A00")]
		private GameObject GetPrefab(string prefabName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3560440", Offset = "0x355F240", VA = "0x183560440")]
		public void CachePrefab(string prefabName, GameObject prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3560500", Offset = "0x355F300", VA = "0x183560500")]
		public IPromise<GameObject> CachePrefab(string prefabName, bool isPermanent, bool cacheAsync)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3560AB0", Offset = "0x355F8B0", VA = "0x183560AB0")]
		public bool InEitherCache(string prefabName)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ResourcesHelper
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13BD910", Offset = "0x13BC710", VA = "0x1813BD910")]
		public static T SafeLoad<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class QueuedLoad
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public string assetName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Promise<GameObject> Promise;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3560C70", Offset = "0x355FA70", VA = "0x183560C70")]
			public QueuedLoad(string assetName)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<QueuedLoad> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3D9000", Offset = "0x3D7E00", VA = "0x1803D9000")]
			public <>c__DisplayClass6_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3561300", Offset = "0x3560100", VA = "0x183561300")]
			internal bool <ProcessQueue>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class <ProcessQueue>d__6 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Queue<QueuedLoad> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private <>c__DisplayClass6_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private QueuedLoad <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3D93C0", Offset = "0x3D81C0", VA = "0x1803D93C0")]
			[DebuggerHidden]
			public <ProcessQueue>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3D93B0", Offset = "0x3D81B0", VA = "0x1803D93B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3560FB0", Offset = "0x355FDB0", VA = "0x183560FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x35612B0", Offset = "0x35600B0", VA = "0x1835612B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int PARALLEL_WORKER_THREAD_COUNT = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static Queue<QueuedLoad> loadQueue;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3560E20", Offset = "0x355FC20", VA = "0x183560E20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1ACD680", Offset = "0x1ACC480", VA = "0x181ACD680")]
		public IPromise<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3560CE0", Offset = "0x355FAE0", VA = "0x183560CE0")]
		public IPromise<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3560DC0", Offset = "0x355FBC0", VA = "0x183560DC0")]
		[IteratorStateMachine(typeof(<ProcessQueue>d__6))]
		private IEnumerator<ISchedule> ProcessQueue(Queue<QueuedLoad> queue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3560F50", Offset = "0x355FD50", VA = "0x183560F50")]
		public ResourcesManager()
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
