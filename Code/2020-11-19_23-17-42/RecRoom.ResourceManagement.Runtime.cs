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
		[Cpp2IlInjected.Address(RVA = "0x3122E20", Offset = "0x3121C20", VA = "0x183122E20")]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3122B10", Offset = "0x3121910", VA = "0x183122B10", Slot = "1")]
		~PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3122DB0", Offset = "0x3121BB0", VA = "0x183122DB0")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3122C40", Offset = "0x3121A40", VA = "0x183122C40")]
		public GameObject GetOrCachePrefab(string prefabName, bool isPermanent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3122C20", Offset = "0x3121A20", VA = "0x183122C20")]
		public IPromise<GameObject> GetOrCachePrefabAsync(string prefabName, bool isPermanent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3122C80", Offset = "0x3121A80", VA = "0x183122C80")]
		private GameObject GetPrefab(string prefabName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x31226D0", Offset = "0x31214D0", VA = "0x1831226D0")]
		public void CachePrefab(string prefabName, GameObject prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3122790", Offset = "0x3121590", VA = "0x183122790")]
		public IPromise<GameObject> CachePrefab(string prefabName, bool isPermanent, bool cacheAsync)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3122D30", Offset = "0x3121B30", VA = "0x183122D30")]
		public bool InEitherCache(string prefabName)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ResourcesHelper
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x150B720", Offset = "0x150A520", VA = "0x18150B720")]
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
			[Cpp2IlInjected.Address(RVA = "0x3122EE0", Offset = "0x3121CE0", VA = "0x183122EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B6630", Offset = "0x3B5430", VA = "0x1803B6630")]
			public <>c__DisplayClass6_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3123570", Offset = "0x3122370", VA = "0x183123570")]
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
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x408100", Offset = "0x406F00", VA = "0x180408100")]
			[DebuggerHidden]
			public <ProcessQueue>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3123220", Offset = "0x3122020", VA = "0x183123220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3123520", Offset = "0x3122320", VA = "0x183123520", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3123090", Offset = "0x3121E90", VA = "0x183123090")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E007F0", Offset = "0x1DFF5F0", VA = "0x181E007F0")]
		public IPromise<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3122F50", Offset = "0x3121D50", VA = "0x183122F50")]
		public IPromise<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3123030", Offset = "0x3121E30", VA = "0x183123030")]
		[IteratorStateMachine(typeof(<ProcessQueue>d__6))]
		private IEnumerator<ISchedule> ProcessQueue(Queue<QueuedLoad> queue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x31231C0", Offset = "0x3121FC0", VA = "0x1831231C0")]
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
