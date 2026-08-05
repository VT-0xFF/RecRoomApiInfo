using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ResourceManagement_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8CE0", Offset = "0x8AD74E0", VA = "0x188AD8CE0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class PrefabCache
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct LoadedPrefab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public GameObject Prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncOperationHandle<GameObject> AddressablesHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JHXZLDGKHPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public GameObject GWRPWLBRXQO;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JHXZLDGKHPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			internal void AJABYHRRRNP(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ELCYXXBCTYR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Dictionary<string, LoadedPrefab> OXRBYWVLJYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public string TOQSCXJTSPQ;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public ELCYXXBCTYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8410", Offset = "0x8AD6C10", VA = "0x188AD8410")]
			internal GameObject RHLFVHUMIFT((GameObject prefab, AsyncOperationHandle<GameObject> handle) tuple)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly PrefabCache ZJHLYMBJODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Dictionary<string, LoadedPrefab> DHKNZLNXJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Dictionary<string, LoadedPrefab> BMLZMEEMOME;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA1F0", Offset = "0x8AD89F0", VA = "0x188ADA1F0")]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9350", Offset = "0x8AD7B50", VA = "0x188AD9350", Slot = "1")]
		~PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8DF0", Offset = "0x8AD75F0", VA = "0x188AD8DF0")]
		private void AHNFQMPXHBE(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8EC0", Offset = "0x8AD76C0", VA = "0x188AD8EC0")]
		private void CLLLECQMLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9430", Offset = "0x8AD7C30", VA = "0x188AD9430")]
		private void LBGTCUPBOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9660", Offset = "0x8AD7E60", VA = "0x188AD9660")]
		public GameObject LVEYJETLXED(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA030", Offset = "0x8AD8830", VA = "0x188ADA030")]
		public JIREGIBPOUE<GameObject> YPBEDOPWNWA(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9AE0", Offset = "0x8AD82E0", VA = "0x188AD9AE0")]
		private GameObject OUKCNFMDIGP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD90F0", Offset = "0x8AD78F0", VA = "0x188AD90F0")]
		private LoadedPrefab ETUGUBOOCFN(string a)
		{
			return default(LoadedPrefab);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8E50", Offset = "0x8AD7650", VA = "0x188AD8E50")]
		public void AKCVEGHKUKG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9F20", Offset = "0x8AD8720", VA = "0x188AD9F20")]
		public void SVLJHMGPQPS(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9BA0", Offset = "0x8AD83A0", VA = "0x188AD9BA0")]
		public JIREGIBPOUE<GameObject> QCBFMZPXQJX(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9820", Offset = "0x8AD8020", VA = "0x188AD9820")]
		private static JIREGIBPOUE<GameObject> NNUHYOLTDWD(string a, Dictionary<string, LoadedPrefab> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9EA0", Offset = "0x8AD86A0", VA = "0x188AD9EA0")]
		public bool RGQRJDRYEGV(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class AMIGARTAIQE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x308C670", Offset = "0x308AE70", VA = "0x18308C670")]
		public static a HDZKJGOXUVM<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class TSYZUIPPWUK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public string BGQAFWLBNFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public SMIRXNPXRKL<(GameObject loadedAsset, AsyncOperationHandle<GameObject> handle)> PVTOZSTIILK;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA700", Offset = "0x8AD8F00", VA = "0x188ADA700")]
			public TSYZUIPPWUK(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OZNGAHXEFXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Queue<TSYZUIPPWUK> VISNCQIVPOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Func<bool> HHJKLVTYFOK;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OZNGAHXEFXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8DA0", Offset = "0x8AD75A0", VA = "0x188AD8DA0")]
			internal bool ZMJBFBGGTGF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JJKJLRGEASF : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Queue<TSYZUIPPWUK> VISNCQIVPOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private OZNGAHXEFXB UBGREOIDSYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TSYZUIPPWUK WGQYZVLPIUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private AsyncOperationHandle<IList<IResourceLocation>> LIIFCJATDZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private ResourceRequest DHORRFODYQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private AsyncOperationHandle<GameObject> GTFEJLFKUTG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public JJKJLRGEASF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8570", Offset = "0x8AD6D70", VA = "0x188AD8570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8530", Offset = "0x8AD6D30", VA = "0x188AD8530", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int XVYDYLOXIDC = 2;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static Queue<TSYZUIPPWUK> FEQVAZMHLKS;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA480", Offset = "0x8AD8C80", VA = "0x188ADA480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA370", Offset = "0x8AD8B70", VA = "0x188ADA370")]
		public JIREGIBPOUE<(GameObject, AsyncOperationHandle<GameObject>)> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA300", Offset = "0x8AD8B00", VA = "0x188ADA300")]
		[IteratorStateMachine(typeof(JJKJLRGEASF))]
		private IEnumerator<ZCECIALXIMT> GOOSWNOHUYX(Queue<TSYZUIPPWUK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA6C0", Offset = "0x8AD8EC0", VA = "0x188ADA6C0")]
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
