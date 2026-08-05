using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CircuitsV2.CircuitNodes;
using CircuitsV2.Context;
using CircuitsV2.Graph;
using CircuitsV2.Graph.Nodes;
using CircuitsV2.Graph.Nodes.PureNodes.TypeConversions;
using CircuitsV2.Graph.Nodes.TypeConversions;
using CircuitsV2.Injection;
using CircuitsV2.Networking.Timing;
using CircuitsV2.Persistence;
using CircuitsV2.Protobuf;
using CircuitsV2.Types;
using CircuitsV2.Types.Checker;
using CircuitsV2.Types.Checker.Unification;
using CircuitsV2.Types.Checker.Unification.Reference;
using CircuitsV2.Types.Checker.Unification.Value;
using CircuitsV2.Utilities;
using CircuitsV2.Utilities.InternalTools;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Graph.Context;
using JetBrains.Annotations;
using RecRoom.Async;
using RecRoom.Networking.RPC;
using RecRoom.Networking.SynchronizedFields;
using UnityEngine;
using Utilities.DataStructures;
using Utilities.InternalTools;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ByteStringExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x14B5B50", Offset = "0x14B4F50", VA = "0x1814B5B50")]
	public static Guid ToGuid(this ByteString bytes)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x14B5990", Offset = "0x14B4D90", VA = "0x1814B5990")]
	public static ByteString ToByteString(this Guid guid)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x14B5CE0", Offset = "0x14B50E0", VA = "0x1814B5CE0")]
	public static Guid? ToGuid(this NullableBytes bytes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x14B5A80", Offset = "0x14B4E80", VA = "0x1814B5A80")]
	public static NullableBytes ToByteString(this Guid? guid)
	{
		return null;
	}
}
namespace Utilities.InternalTools
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class NodeTagAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly string[] tags;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2E28240", Offset = "0x2E27640", VA = "0x182E28240")]
		public NodeTagAttribute(string tag, params string[] tags)
		{
		}
	}
}
namespace Utilities.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RateLimitedSynchronizedField<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly SynchronizedField<T> internalField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly T InitialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly RateLimiter rateLimiter;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24AE4A0", Offset = "0x24AD8A0", VA = "0x1824AE4A0")]
		public RateLimitedSynchronizedField(SynchronizedField<T> internalField, T initialValue, RateLimiter rateLimiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE784D0", Offset = "0xE778D0", VA = "0x180E784D0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24AE260", Offset = "0x24AD660", VA = "0x1824AE260")]
		public bool Set(T newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24ADF90", Offset = "0x24AD390", VA = "0x1824ADF90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class RefCountMap<TKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Dictionary<TKey, int> _dictionary;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24AE930", Offset = "0x24ADD30", VA = "0x1824AE930")]
		public bool HasReferences(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24AEBA0", Offset = "0x24ADFA0", VA = "0x1824AEBA0")]
		public bool TryGetRefCount(TKey key, out int refCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x24AE9C0", Offset = "0x24ADDC0", VA = "0x1824AE9C0")]
		public void IncrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x24AE740", Offset = "0x24ADB40", VA = "0x1824AE740")]
		public void DecrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDFE9B0", Offset = "0xDFDDB0", VA = "0x180DFE9B0")]
		public RefCountMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ShortenedGuidMap
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public delegate void OnGuidsRemapped(IReadOnlyDictionary<Guid, GuidRemapping> remappedGuids);

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct GuidRemapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly string OldShortenedForm;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly string NewShortenedForm;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x141460", Offset = "0x140860", VA = "0x180141460")]
			public GuidRemapping(string oldShortenedForm, string newShortenedForm)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IGuidShortenerMethod guidShortenerMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<Guid, string> shortenedGuidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly HashSet<string> shortenedGuidValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly int startingRequiredCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int maxRequiredCharacters;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnGuidsRemapped OnExistingValuesRemapped
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x167F120", Offset = "0x167E520", VA = "0x18167F120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x167F1C0", Offset = "0x167E5C0", VA = "0x18167F1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x167EFE0", Offset = "0x167E3E0", VA = "0x18167EFE0")]
		private ShortenedGuidMap(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x167E6C0", Offset = "0x167DAC0", VA = "0x18167E6C0")]
		public static ShortenedGuidMap FromRequiredCharacters(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x167E820", Offset = "0x167DC20", VA = "0x18167E820")]
		public string GetShortened(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x167E900", Offset = "0x167DD00", VA = "0x18167E900")]
		private string GuidToShortenedString(Guid guid, int requiredCharacters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x167ECB0", Offset = "0x167E0B0", VA = "0x18167ECB0")]
		private string RemapGuid(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x167E9E0", Offset = "0x167DDE0", VA = "0x18167E9E0")]
		private void RemapExisting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x167EF40", Offset = "0x167E340", VA = "0x18167EF40")]
		public void Remove(Guid address)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IGuidShortenerMethod
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int MaxPossibleCharacters
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GuidToShortenedString(Guid guid, int numCharacters);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class Base64GuidShortenerMethod : IGuidShortenerMethod
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly IGuidShortenerMethod Instance;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MaxPossibleCharacters
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x166D1D0", Offset = "0x166C5D0", VA = "0x18166D1D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		private Base64GuidShortenerMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x166D0C0", Offset = "0x166C4C0", VA = "0x18166D0C0", Slot = "5")]
		public string GuidToShortenedString(Guid guid, int numCharacters)
		{
			return null;
		}
	}
}
namespace RecRoom.CircuitsV2.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ProtobufExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x167D800", Offset = "0x167CC00", VA = "0x18167D800")]
		public static bool IsEmpty(this CircuitContextData contextData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x11E4B50", Offset = "0x11E3F50", VA = "0x1811E4B50")]
		private static bool IsRepeatedFieldEmpty<T>(RepeatedField<T> repeatedField)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x167DB20", Offset = "0x167CF20", VA = "0x18167DB20")]
		internal static Vector3 ToVector3(this Vector3Data vector3Data)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x167DA70", Offset = "0x167CE70", VA = "0x18167DA70")]
		internal static Vector3Data ToVector3Data(this Vector3 vector3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x167D970", Offset = "0x167CD70", VA = "0x18167D970")]
		internal static Quaternion ToQuaternion(this QuaternionData quaternionData)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x167D8C0", Offset = "0x167CCC0", VA = "0x18167D8C0")]
		internal static QuaternionData ToQuaternionData(this Quaternion quaternion)
		{
			return null;
		}
	}
}
namespace Graph
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum DFSType
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		DirectedForward = 1,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		DirectedBackward = 2,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Undirected = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GraphTraversal
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class <DFS>d__1 : IEnumerable<Node>, IEnumerable, IEnumerator<Node>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Node <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Node root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Node <>3__root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DFSType dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public DFSType <>3__dfsType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private Stack<Node> <stack>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private HashSet<Node> <visited>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Node <current>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			Node IEnumerator<Node>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63A340", Offset = "0x639740", VA = "0x18063A340")]
			[DebuggerHidden]
			public <DFS>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1680230", Offset = "0x167F630", VA = "0x181680230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1680A00", Offset = "0x167FE00", VA = "0x181680A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1680960", Offset = "0x167FD60", VA = "0x181680960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1680960", Offset = "0x167FD60", VA = "0x181680960", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x167C2C0", Offset = "0x167B6C0", VA = "0x18167C2C0")]
		[IteratorStateMachine(typeof(<DFS>d__1))]
		public static IEnumerable<Node> DFS(Node root, DFSType dfsType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x167C340", Offset = "0x167B740", VA = "0x18167C340")]
		public static ExecutableNode ExecuteFromNode([NotNull] ExecutableNode executableNode, [CanBeNull] InputPort execPort, [NotNull] IExecutionScope executionScope)
		{
			return null;
		}
	}
}
namespace Graph.Context
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface INodeRestriction
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class NodeRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class NotRestriction : INodeRestriction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly Type[] notTypes;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB70", Offset = "0x3AAF70", VA = "0x1803ABB70")]
			public NotRestriction(params Type[] notTypes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x167D0A0", Offset = "0x167C4A0", VA = "0x18167D0A0")]
			protected bool Equals(NotRestriction other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x167D0E0", Offset = "0x167C4E0", VA = "0x18167D0E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x105A400", Offset = "0x1059800", VA = "0x18105A400", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1255F40", Offset = "0x1255340", VA = "0x181255F40")]
		public static INodeRestriction Not<T>()
		{
			return null;
		}
	}
}
namespace CircuitsV2
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ICircuitContextNetworking : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IRPCSender RpcSender
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IsAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class CircuitContext : IDisposable, ICircuitSerializable<CircuitContextData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly Memory ContextMemory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly Guid ContextId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly HashSet<INodeRestriction> nodeRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Guid templateId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly CircuitEventBus EventBus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<Guid, CircuitContext> directChildContexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly GlobalCircuitContext RootContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Dictionary<Guid, Node> circuitNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool disposed;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid TemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6871F0", Offset = "0x6865F0", VA = "0x1806871F0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x14B99E0", Offset = "0x14B8DE0", VA = "0x1814B99E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[NotNull]
		public Dependencies RecRoomDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x392EC0", Offset = "0x3922C0", VA = "0x180392EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IReadOnlyCollection<CircuitContext> ChildContexts
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x14B96C0", Offset = "0x14B8AC0", VA = "0x1814B96C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CircuitContext Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x392DE0", Offset = "0x3921E0", VA = "0x180392DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x391FA0", Offset = "0x3913A0", VA = "0x180391FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitContextNode ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3F4310", Offset = "0x3F3710", VA = "0x1803F4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x453D20", Offset = "0x453120", VA = "0x180453D20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		internal abstract SynchronizedCircuitContext SynchronizationContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyCollection<Node> CircuitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x14B9710", Offset = "0x14B8B10", VA = "0x1814B9710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75DFC0", Offset = "0x75D3C0", VA = "0x18075DFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CircuitContext, Node> OnCircuitNodeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x14B9440", Offset = "0x14B8840", VA = "0x1814B9440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x14B9760", Offset = "0x14B8B60", VA = "0x1814B9760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x14B94E0", Offset = "0x14B88E0", VA = "0x1814B94E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x14B9800", Offset = "0x14B8C00", VA = "0x1814B9800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<NodeConnection> OnNodesConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x14B9580", Offset = "0x14B8980", VA = "0x1814B9580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x14B98A0", Offset = "0x14B8CA0", VA = "0x1814B98A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NodeConnection> OnNodesDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x14B9620", Offset = "0x14B8A20", VA = "0x1814B9620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x14B9940", Offset = "0x14B8D40", VA = "0x1814B9940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x14B9250", Offset = "0x14B8650", VA = "0x1814B9250")]
		protected CircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x14B6F10", Offset = "0x14B6310", VA = "0x1814B6F10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x14B6020", Offset = "0x14B5420", VA = "0x1814B6020")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x14B7850", Offset = "0x14B6C50", VA = "0x1814B7850")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x14B5D90", Offset = "0x14B5190", VA = "0x1814B5D90")]
		protected void AddChildContext(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x14B82C0", Offset = "0x14B76C0", VA = "0x1814B82C0")]
		public bool SendEvent(CircuitEvent circuitEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x14B82F0", Offset = "0x14B76F0", VA = "0x1814B82F0")]
		public void SendSynchronizedEvent(CircuitEvent circuitEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x14B7C30", Offset = "0x14B7030", VA = "0x1814B7C30")]
		public void RequestCreateNewCircuitNode(Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x14B8000", Offset = "0x14B7400", VA = "0x1814B8000")]
		public void RequestDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x14B7E40", Offset = "0x14B7240", VA = "0x1814B7E40")]
		public void RequestCreateNewDynamicEvent(string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14B80F0", Offset = "0x14B74F0", VA = "0x1814B80F0")]
		public void RequestDestroyDynamicEvent(Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x14B76D0", Offset = "0x14B6AD0", VA = "0x1814B76D0")]
		public void LocalDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x14B76A0", Offset = "0x14B6AA0", VA = "0x1814B76A0")]
		public void LocalDestroyCircuitNode([NotNull] Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14B5E30", Offset = "0x14B5230", VA = "0x1814B5E30")]
		public void AddCircuitNode(Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A10", Offset = "0x14B7E10", VA = "0x1814B8A10")]
		protected bool TryFindNodeViaGloballyUniqueIdInternal(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x14B8360", Offset = "0x14B7760", VA = "0x1814B8360", Slot = "9")]
		public virtual CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x14B6850", Offset = "0x14B5C50", VA = "0x1814B6850")]
		internal void DeserializeTemplateData(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x14B7380", Offset = "0x14B6780", VA = "0x1814B7380")]
		internal void InferAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x14B6260", Offset = "0x14B5660", VA = "0x1814B6260", Slot = "10")]
		public virtual void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x11D9520", Offset = "0x11D8920", VA = "0x1811D9520")]
		public bool TryFindNode<TNode>(Guid nodeId, out TNode node) where TNode : Node
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x14B8DA0", Offset = "0x14B81A0", VA = "0x1814B8DA0")]
		public bool TryFindNode(Guid nodeId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x14B89A0", Offset = "0x14B7DA0", VA = "0x1814B89A0")]
		public bool TryFindChildContext(Guid childContextId, out CircuitContext childContext)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x14B7B10", Offset = "0x14B6F10", VA = "0x1814B7B10")]
		public void RaiseOnCircuitNodesConnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x14B7BA0", Offset = "0x14B6FA0", VA = "0x1814B7BA0")]
		public void RaiseOnCircuitNodesDisconnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x14B5FC0", Offset = "0x14B53C0", VA = "0x1814B5FC0")]
		public void AddNodeRestriction(INodeRestriction nodeRestriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x14B7670", Offset = "0x14B6A70", VA = "0x1814B7670")]
		public bool IsChildOf(CircuitContext parentContext)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ICircuitEventHandler
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleEvent(CircuitEvent circuitEvent);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CircuitEventBus : ICircuitSerializable<EventBusData>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class EventRegistration : ICircuitSerializable<EventRegistrationData>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public readonly CircuitContext RegisteredToContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public readonly CircuitEventDefinition EventDefinition;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x67DF40", Offset = "0x67D340", VA = "0x18067DF40")]
			public EventRegistration(CircuitContext registeredToContext, CircuitEventDefinition eventDefinition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x14C17F0", Offset = "0x14C0BF0", VA = "0x1814C17F0")]
			public void AddCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x14C1910", Offset = "0x14C0D10", VA = "0x1814C1910")]
			public void RemoveCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x14C1A50", Offset = "0x14C0E50", VA = "0x1814C1A50", Slot = "5")]
			public EventRegistrationData SerializeToProtobuf()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "4")]
			public void DeserializeFromProtobuf(EventRegistrationData protobufData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private abstract class LimitedEventQueueBase<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public const int DEFAULT_MAX_EVENTS_TO_PROCESS_PER_FRAME = 1024;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly int maxEventsToProcessPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			[CompilerGenerated]
			private Action OnTooManyEventsToProcess;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public abstract Queue<T> CurrentActiveQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			protected virtual Queue<T> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x1A70E80", Offset = "0x1A70280", VA = "0x181A70E80", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1019410", Offset = "0x1018810", VA = "0x181019410")]
			protected LimitedEventQueueBase(int maxEventsToProcessPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A70DC0", Offset = "0x1A701C0", VA = "0x181A70DC0")]
			public bool PushEvent(T queueEntry)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1A70C60", Offset = "0x1A70060", VA = "0x181A70C60", Slot = "6")]
			public virtual void ProcessQueue(Action<T> callback)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class SynchedCircuitEventQueue : LimitedEventQueueBase<Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets>>
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public override Queue<Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets>> CurrentActiveQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x14CBFC0", Offset = "0x14CB3C0", VA = "0x1814CBFC0")]
			public SynchedCircuitEventQueue(int maxEventsToProcessPerFrame = 1024)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LocalEventQueue : LimitedEventQueueBase<CircuitEvent>
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			private struct QueuedEvent
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public readonly float QueuedTime;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				public readonly float EventTime;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public readonly CircuitEvent CircuitEvent;

				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x1812A0", Offset = "0x1806A0", VA = "0x1801812A0")]
				public QueuedEvent(float queuedTime, float eventTime, CircuitEvent circuitEvent)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly ITimeProvider timeProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Queue<CircuitEvent> queue1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly Queue<CircuitEvent> queue2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private readonly SortedList<QueuedEvent> queuedEvents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private bool flipped;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public override Queue<CircuitEvent> CurrentActiveQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x14C9550", Offset = "0x14C8950", VA = "0x1814C9550", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			protected override Queue<CircuitEvent> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x14C9560", Offset = "0x14C8960", VA = "0x1814C9560", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x14C93E0", Offset = "0x14C87E0", VA = "0x1814C93E0")]
			public LocalEventQueue(ITimeProvider timeProvider, int maxEventsToProcessPerFrame = 1024)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x14C9250", Offset = "0x14C8650", VA = "0x1814C9250")]
			public bool PushEventDelayed(CircuitEvent circuitEvent, float delay)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x14C9080", Offset = "0x14C8480", VA = "0x1814C9080", Slot = "6")]
			public override void ProcessQueue(Action<CircuitEvent> callback)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class EventHandlerCollection
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private bool isEnumeratingHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private readonly SetDictionary<Guid, ICircuitEventHandler> eventHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private readonly List<Action> eventHandlerActions;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x14C1100", Offset = "0x14C0500", VA = "0x1814C1100")]
			public void AddCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x14C15E0", Offset = "0x14C09E0", VA = "0x1814C15E0")]
			public void RemoveCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x14C1700", Offset = "0x14C0B00", VA = "0x1814C1700")]
			private void RemoveHandlerInternal(Guid eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x14C1260", Offset = "0x14C0660", VA = "0x1814C1260")]
			public void HandleEvent(CircuitEvent circuitEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14C1200", Offset = "0x14C0600", VA = "0x1814C1200")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14C1770", Offset = "0x14C0B70", VA = "0x1814C1770")]
			public EventHandlerCollection()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LocalEventQueue localEventQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly SynchedCircuitEventQueue syncedEventQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly EventHandlerCollection eventHandlerCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<Guid, CircuitEventDefinition> registeredBuiltInCircuitEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<Guid, CircuitEventDefinition> registeredDynamicCircuitEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<Guid, CircuitEventObject> registeredDynamicCircuitEventObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool hasCachedListenableEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<EventRegistration> cachedListenableEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool hasCachedSendableEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<EventRegistration> cachedSendableEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly CircuitContext context;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IEnumerable<CircuitEventDefinition> RegisteredDynamicEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x14BC070", Offset = "0x14BB470", VA = "0x1814BC070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x14BBD10", Offset = "0x14BB110", VA = "0x1814BBD10")]
		public CircuitEventBus(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x14BB2A0", Offset = "0x14BA6A0", VA = "0x1814BB2A0")]
		public EventRegistration RegisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x14BB780", Offset = "0x14BAB80", VA = "0x1814BB780")]
		public EventRegistration RegisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x14BB380", Offset = "0x14BA780", VA = "0x1814BB380")]
		private EventRegistration RegisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x14BBC70", Offset = "0x14BB070", VA = "0x1814BBC70")]
		public void UnregisterDynamicCircuitEvent(Guid circuitEventDefinitionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x14BBD00", Offset = "0x14BB100", VA = "0x1814BBD00")]
		public void UnregisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x14BBA70", Offset = "0x14BAE70", VA = "0x1814BBA70")]
		public void UnregisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x14BBA80", Offset = "0x14BAE80", VA = "0x1814BBA80")]
		private void UnregisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x14BA9F0", Offset = "0x14B9DF0", VA = "0x1814BA9F0")]
		public IEnumerable<EventRegistration> GetListenableEvents(bool onlyPlayerListenable = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x14BA310", Offset = "0x14B9710", VA = "0x1814BA310")]
		private IReadOnlyList<EventRegistration> GetAllListenableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x14BA730", Offset = "0x14B9B30", VA = "0x1814BA730")]
		public EventRegistration GetListenableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x14BAAF0", Offset = "0x14B9EF0", VA = "0x1814BAAF0")]
		public EventRegistration GetSendableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x14BABC0", Offset = "0x14B9FC0", VA = "0x1814BABC0")]
		public IReadOnlyList<EventRegistration> GetSendableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x14BB270", Offset = "0x14BA670", VA = "0x1814BB270")]
		public bool Publish(CircuitEvent outgoingEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x14BB050", Offset = "0x14BA450", VA = "0x1814BB050")]
		public bool PublishDelayed(CircuitEvent outgoingEvent, float delay)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x14BB1F0", Offset = "0x14BA5F0", VA = "0x1814BB1F0")]
		public bool PublishSynced(CircuitEvent outgoingEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x14BAF70", Offset = "0x14BA370", VA = "0x1814BAF70")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x14BAE30", Offset = "0x14BA230", VA = "0x1814BAE30")]
		private void HandleLocalEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x14BB7D0", Offset = "0x14BABD0", VA = "0x1814BB7D0")]
		private void SendSyncedEvent(Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets> circuitEventAndTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x14BAE50", Offset = "0x14BA250", VA = "0x1814BAE50")]
		public void HandleReceivedSyncedEvent(SynchronizedEventData syncedEventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x14B9BE0", Offset = "0x14B8FE0", VA = "0x1814B9BE0")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x14BB890", Offset = "0x14BAC90", VA = "0x1814BB890", Slot = "6")]
		public EventBusData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x14BA070", Offset = "0x14B9470", VA = "0x1814BA070")]
		public void DeserializeFromTemplate(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x14B9E70", Offset = "0x14B9270", VA = "0x1814B9E70", Slot = "4")]
		public void DeserializeFromProtobuf(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x14BA240", Offset = "0x14B9640", VA = "0x1814BA240")]
		private void DestroyCircuitObjectFromProtoData(CircuitEventObject circuitEventObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x14B9C50", Offset = "0x14B9050", VA = "0x1814B9C50")]
		private CircuitEventObject CreateCircuitObjectFromProtoData(Guid eventId, CircuitEventObjectData protobufdata)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x14BA270", Offset = "0x14B9670", VA = "0x1814BA270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x14BBA00", Offset = "0x14BAE00", VA = "0x1814BBA00")]
		public bool TryGetDynamicEventObject(Guid eventDefEventDefinitionId, out CircuitEventObject circuitEventObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x14BAF10", Offset = "0x14BA310", VA = "0x1814BAF10")]
		public bool HasDynamicEvent(Guid eventId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class CircuitEvent
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly Guid CircuitEventTypeGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly CircuitEventDefinition EventDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly IReadOnlyDictionary<string, CircuitSignal> Signals;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x14BE5B0", Offset = "0x14BD9B0", VA = "0x1814BE5B0")]
		public CircuitEvent(Guid circuitEventTypeGuid, CircuitEventDefinition eventDefinition, IReadOnlyDictionary<string, CircuitSignal> signals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x14BDC60", Offset = "0x14BD060", VA = "0x1814BDC60")]
		public SynchronizedEventData Pack()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x14BE160", Offset = "0x14BD560", VA = "0x1814BE160")]
		public static CircuitEvent Unpack(CircuitEventDefinition eventDefinition, SynchronizedEventData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class CircuitEventDefinition : ICircuitSerializable<CircuitEventDefinitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class EventBuilder
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private readonly CircuitEventDefinition definition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private readonly List<string> remainingFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private readonly Dictionary<string, CircuitSignal> signals;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x14C1050", Offset = "0x14C0450", VA = "0x1814C1050")]
			public EventBuilder(CircuitEventDefinition definition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x14C0FB0", Offset = "0x14C03B0", VA = "0x1814C0FB0")]
			public EventBuilder WithSignal(string signalName, CircuitSignal signal)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x14C0EB0", Offset = "0x14C02B0", VA = "0x1814C0EB0")]
			public CircuitEvent Build()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Dictionary<string, CircuitType> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly Guid EventDefinitionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool IsPlayerListenable;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[EditableValue]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x14BCAF0", Offset = "0x14BBEF0", VA = "0x1814BCAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CircuitType> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnDefinitionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x14BC9B0", Offset = "0x14BBDB0", VA = "0x1814BC9B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x14BCA50", Offset = "0x14BBE50", VA = "0x1814BCA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x14BC8F0", Offset = "0x14BBCF0", VA = "0x1814BC8F0")]
		public CircuitEventDefinition(string name, Guid eventDefinitionId, bool isPlayerListenable = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x14BC480", Offset = "0x14BB880", VA = "0x1814BC480")]
		private bool Equals(CircuitEventDefinition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x14BC380", Offset = "0x14BB780", VA = "0x1814BC380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14BC4C0", Offset = "0x14BB8C0", VA = "0x1814BC4C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x90B190", Offset = "0x90A590", VA = "0x18090B190")]
		public static bool operator !=(CircuitEventDefinition left, CircuitEventDefinition right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x14BC0C0", Offset = "0x14BB4C0", VA = "0x1814BC0C0")]
		[EditableAddNamedPort(null)]
		public CircuitEventDefinition AddEventPropertyLocal(string name, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x14BC5B0", Offset = "0x14BB9B0", VA = "0x1814BC5B0")]
		public CircuitEventDefinition RemoveEventPropertyLocal(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x14BC650", Offset = "0x14BBA50", VA = "0x1814BC650", Slot = "5")]
		public CircuitEventDefinitionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x14BC160", Offset = "0x14BB560", VA = "0x1814BC160", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitEventDefinitionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x14BC4E0", Offset = "0x14BB8E0", VA = "0x1814BC4E0")]
		public EventBuilder NewEvent()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class CircuitEventObject : CircuitObject<CircuitEventObjectData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly CircuitEventDefinition EventDefinition;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x14BDB10", Offset = "0x14BCF10", VA = "0x1814BDB10")]
		public CircuitEventObject(CircuitContext context, CircuitEventDefinition definition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x14BD3C0", Offset = "0x14BC7C0", VA = "0x1814BD3C0")]
		private bool Equals(CircuitEventObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x14BD400", Offset = "0x14BC800", VA = "0x1814BD400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x14BD510", Offset = "0x14BC910", VA = "0x1814BD510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x14BD540", Offset = "0x14BC940", VA = "0x1814BD540")]
		public void RequestAddEventProperty(string name, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x14BD6B0", Offset = "0x14BCAB0", VA = "0x1814BD6B0")]
		public void RequestRemoveEventProperty(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x14BD7E0", Offset = "0x14BCBE0", VA = "0x1814BD7E0", Slot = "10")]
		public override CircuitEventObjectData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x14BCF90", Offset = "0x14BC390", VA = "0x1814BCF90", Slot = "11")]
		public override void DeserializeFromProtobuf(CircuitEventObjectData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x14BD320", Offset = "0x14BC720", VA = "0x1814BD320", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x14BDAC0", Offset = "0x14BCEC0", VA = "0x1814BDAC0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x14BCEA0", Offset = "0x14BC2A0", VA = "0x1814BCEA0", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Guid("BF6399A9-1CC0-4990-A182-0A1660B695F3")]
	public class CircuitEventObjectModificationHandler : EventModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x14BCE90", Offset = "0x14BC290", VA = "0x1814BCE90")]
		public CircuitEventObjectModificationHandler(CircuitEventObject modifiedEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x14BCB30", Offset = "0x14BBF30", VA = "0x1814BCB30")]
		public ICircuitObjectModification CreateAddPropertyModification(string propertyName, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x14BCC00", Offset = "0x14BC000", VA = "0x1814BCC00")]
		public ICircuitObjectModification CreateRemovePropertyModification(string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x14BCCA0", Offset = "0x14BC0A0", VA = "0x1814BCCA0", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class GlobalCircuitContext : SynchronizedCircuitContext
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public const int MAX_SYNCED_EVENTS_PER_SECOND = 15;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const int MAX_SYNCED_VARIABLE_UPDATES_PER_SECOND = 30;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public const int MAX_EXECUTIONS_PER_FRAME = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly Guid GlobalCircuitContextId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal int ExecutionsRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int deterministicGuidIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[CompilerGenerated]
		private Action<CircuitEventDefinition> OnCircuitEventDefinitionChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[CompilerGenerated]
		private Action OnReinitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Stack<CircuitContext> editStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly SetDictionary<Guid, CircuitContext> templatedContexts;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private const int MAX_BUFFERED_OPERATIONS = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private SynchronizedField<int> bufferedOperationsCount;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float GlobalHeat
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x14C5CA0", Offset = "0x14C50A0", VA = "0x1814C5CA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RateLimiter GlobalSyncedEventRateLimiter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x39F630", Offset = "0x39EA30", VA = "0x18039F630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CircuitContext CurrentEditContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x14C5C30", Offset = "0x14C5030", VA = "0x1814C5C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BufferedOperationsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x14C5BE0", Offset = "0x14C4FE0", VA = "0x1814C5BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x14C61C0", Offset = "0x14C55C0", VA = "0x1814C61C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ObjectCircuitContext> OnObjectCircuitContextCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x14C5B40", Offset = "0x14C4F40", VA = "0x1814C5B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x14C6120", Offset = "0x14C5520", VA = "0x1814C6120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CircuitContext, Node> OnCircuitNodeAddedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x14C5820", Offset = "0x14C4C20", VA = "0x1814C5820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x14C5E00", Offset = "0x14C5200", VA = "0x1814C5E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x14C58C0", Offset = "0x14C4CC0", VA = "0x1814C58C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x14C5EA0", Offset = "0x14C52A0", VA = "0x1814C5EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NodeConnection> OnNodesConnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x14C5A00", Offset = "0x14C4E00", VA = "0x1814C5A00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x14C5FE0", Offset = "0x14C53E0", VA = "0x1814C5FE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NodeConnection> OnNodesDisconnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x14C5AA0", Offset = "0x14C4EA0", VA = "0x1814C5AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x14C6080", Offset = "0x14C5480", VA = "0x1814C6080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CircuitContext, CircuitContext> OnContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x14C5960", Offset = "0x14C4D60", VA = "0x1814C5960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x14C5F40", Offset = "0x14C5340", VA = "0x1814C5F40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventRegisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x14C56E0", Offset = "0x14C4AE0", VA = "0x1814C56E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x14C5CC0", Offset = "0x14C50C0", VA = "0x1814C5CC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventUnregisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x14C5780", Offset = "0x14C4B80", VA = "0x1814C5780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x14C5D60", Offset = "0x14C5160", VA = "0x1814C5D60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x14C3410", Offset = "0x14C2810", VA = "0x1814C3410")]
		public Guid NextGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x14C5380", Offset = "0x14C4780", VA = "0x1814C5380")]
		public GlobalCircuitContext(ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x14C5420", Offset = "0x14C4820", VA = "0x1814C5420")]
		public GlobalCircuitContext(Guid contextId, ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D86D0", Offset = "0x7D7AD0", VA = "0x1807D86D0")]
		public void ResetMaxExecutions(int newRemaining = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x14C1E10", Offset = "0x14C1210", VA = "0x1814C1E10", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextId, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x14C5280", Offset = "0x14C4680", VA = "0x1814C5280")]
		public bool TryFindNodeViaGloballyUniqueId(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x14C5230", Offset = "0x14C4630", VA = "0x1814C5230", Slot = "9")]
		public sealed override CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x14C1F60", Offset = "0x14C1360", VA = "0x1814C1F60", Slot = "10")]
		public override void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x14C3630", Offset = "0x14C2A30", VA = "0x1814C3630")]
		public void PushEditContext(CircuitContext circuitContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x14C34C0", Offset = "0x14C28C0", VA = "0x1814C34C0")]
		public void PopEditContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x14C3920", Offset = "0x14C2D20", VA = "0x1814C3920")]
		public void RaiseRegisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x14C39A0", Offset = "0x14C2DA0", VA = "0x1814C39A0")]
		public void RaiseUnregisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x14C37F0", Offset = "0x14C2BF0", VA = "0x1814C37F0")]
		public void RaiseOnCircuitNodeDestroyedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x14C3780", Offset = "0x14C2B80", VA = "0x1814C3780")]
		public void RaiseOnCircuitNodeAddedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x14C3860", Offset = "0x14C2C60", VA = "0x1814C3860")]
		public void RaiseOnCircuitNodesConnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x14C38C0", Offset = "0x14C2CC0", VA = "0x1814C38C0")]
		public void RaiseOnCircuitNodesDisconnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x14C3A20", Offset = "0x14C2E20", VA = "0x1814C3A20")]
		public void RegisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x14C52A0", Offset = "0x14C46A0", VA = "0x1814C52A0")]
		public void UnregisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x14C3460", Offset = "0x14C2860", VA = "0x1814C3460")]
		private void OnBufferedOpCountChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x14C20A0", Offset = "0x14C14A0", VA = "0x1814C20A0")]
		public void MasterReinitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x14C4BF0", Offset = "0x14C3FF0", VA = "0x1814C4BF0")]
		[RPCMethod]
		protected void RpcReinitializeAll(CircuitContextData circuitContextData, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x14C3C80", Offset = "0x14C3080", VA = "0x1814C3C80")]
		internal void RequestCreateNewCircuitNode(Guid contextId, Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x14C22A0", Offset = "0x14C16A0", VA = "0x1814C22A0")]
		[RPCMethod]
		internal void MasterRpcCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x14C4420", Offset = "0x14C3820", VA = "0x1814C4420")]
		[RPCMethod]
		internal void RpcBufferedCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x14C4040", Offset = "0x14C3440", VA = "0x1814C4040")]
		internal void RequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x14C2E50", Offset = "0x14C2250", VA = "0x1814C2E50")]
		[RPCMethod]
		internal void MasterRpcRequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x14C46F0", Offset = "0x14C3AF0", VA = "0x1814C46F0")]
		[RPCMethod]
		internal void RpcBufferedDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x14C3E90", Offset = "0x14C3290", VA = "0x1814C3E90")]
		internal void RequestCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x14C2570", Offset = "0x14C1970", VA = "0x1814C2570")]
		[RPCMethod]
		internal void MasterRpcCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x14C45D0", Offset = "0x14C39D0", VA = "0x1814C45D0")]
		[RPCMethod]
		internal void RpcBufferedCreateNewDynamicEvent(Guid contextId, string eventName, Guid eventId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x14C4120", Offset = "0x14C3520", VA = "0x1814C4120")]
		internal void RequestDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x14C2860", Offset = "0x14C1C60", VA = "0x1814C2860")]
		[RPCMethod]
		internal void MasterRpcDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x14C4750", Offset = "0x14C3B50", VA = "0x1814C4750")]
		[RPCMethod]
		internal void RpcBufferedDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x14C3AA0", Offset = "0x14C2EA0", VA = "0x1814C3AA0")]
		internal void RequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x14C2BE0", Offset = "0x14C1FE0", VA = "0x1814C2BE0")]
		[RPCMethod]
		internal void MasterRpcRequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x14C4820", Offset = "0x14C3C20", VA = "0x1814C4820")]
		[RPCMethod]
		internal void RpcConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x14C4280", Offset = "0x14C3680", VA = "0x1814C4280")]
		internal void RequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x14C2FB0", Offset = "0x14C23B0", VA = "0x1814C2FB0")]
		[RPCMethod]
		internal void MasterRpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x14C4CA0", Offset = "0x14C40A0", VA = "0x1814C4CA0")]
		[RPCMethod]
		internal void RpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x14C4EC0", Offset = "0x14C42C0", VA = "0x1814C4EC0")]
		internal void SendObjectModification(ICircuitObjectModification nodeModificationBase)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x14C2A20", Offset = "0x14C1E20", VA = "0x1814C2A20")]
		[RPCMethod]
		internal void MasterRpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x14C49F0", Offset = "0x14C3DF0", VA = "0x1814C49F0")]
		[RPCMethod]
		internal void RpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x14C31C0", Offset = "0x14C25C0", VA = "0x1814C31C0")]
		public IEnumerable<CircuitObject> MasterSpawnTemplateOnAllClients(CircuitContext intoContext, CircuitContextData templateDataOriginal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x14C4E70", Offset = "0x14C4270", VA = "0x1814C4E70")]
		[RPCMethod]
		private void RpcSpawnTemplate(Guid intoContextId, CircuitContextData remappedTemplateData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class NestedCircuitContext : CircuitContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ObjectCircuitContext parentSynchronizationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly GlobalCircuitContext rootContext;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal override SynchronizedCircuitContext SynchronizationContext
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3F4220", Offset = "0x3F3620", VA = "0x1803F4220", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x19417D0", Offset = "0x1940BD0", VA = "0x1819417D0")]
		public NestedCircuitContext(Guid contextId, ObjectCircuitContext parentSynchronizationContext, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x19416E0", Offset = "0x1940AE0", VA = "0x1819416E0", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ObjectCircuitContext : SynchronizedCircuitContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly GlobalCircuitContext rootContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dependencies objectDependencies;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action OnDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1941A70", Offset = "0x1940E70", VA = "0x181941A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1941B10", Offset = "0x1940F10", VA = "0x181941B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1941A00", Offset = "0x1940E00", VA = "0x181941A00")]
		public ObjectCircuitContext(Guid contextId, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1941960", Offset = "0x1940D60", VA = "0x181941960")]
		public void SetSynchronizationBackend(ICircuitContextNetworking networkBackend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1941850", Offset = "0x1940C50", VA = "0x181941850", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1941930", Offset = "0x1940D30", VA = "0x181941930", Slot = "7")]
		protected override void DisposeInternal()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class SynchronizedCircuitContext : CircuitContext, IRPCHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum SyncedEventTargets
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			ALL,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			AUTHORITY,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			OTHERS
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[NotNull]
		private readonly Dictionary<Guid, CircuitContext> _childContextLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		protected ICircuitContextNetworking CircuitContextNetworking;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private ICircuitContextNetworking circuitContextNetworking;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[NotNull]
		public IReadOnlyDictionary<Guid, CircuitContext> ChildContextLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x3F4220", Offset = "0x3F3620", VA = "0x1803F4220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1DD89C0", Offset = "0x1DD7DC0", VA = "0x181DD89C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[NotNull]
		internal override SynchronizedCircuitContext SynchronizationContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4B3940", Offset = "0x4B2D40", VA = "0x1804B3940", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8970", Offset = "0x1DD7D70", VA = "0x181DD8970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1DD88A0", Offset = "0x1DD7CA0", VA = "0x181DD88A0")]
		public SynchronizedCircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8250", Offset = "0x1DD7650", VA = "0x181DD8250", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8160", Offset = "0x1DD7560", VA = "0x181DD8160")]
		public void AddChildContextToLookup(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD83F0", Offset = "0x1DD77F0", VA = "0x181DD83F0")]
		public void RemoveChildContextFromLookup(Guid childContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8650", Offset = "0x1DD7A50", VA = "0x181DD8650")]
		public void SendSynchronizedEvent(Guid fromContextId, CircuitEvent circuitEvent, SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD84D0", Offset = "0x1DD78D0", VA = "0x181DD84D0")]
		[RPCMethod]
		protected void RpcOnReceivedSynchronizedEvent(Guid contextId, SynchronizedEventData circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD82A0", Offset = "0x1DD76A0", VA = "0x181DD82A0")]
		protected static bool GetNetworkHandlerContext(Guid contextId, SynchronizedCircuitContext baseContext, out CircuitContext circuitContext)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 24)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct CircuitSignal
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int backingInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public bool backingBool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public float backingFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		internal const int MAX_STRING_LENGTH = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Impl impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private object backingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TypeKind circuitTypeKind;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x143450", Offset = "0x142850", VA = "0x180143450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FloatValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1554A0", Offset = "0x1548A0", VA = "0x1801554A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CircuitPlayer PlayerValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x180F60", Offset = "0x180360", VA = "0x180180F60")]
			get
			{
				return default(CircuitPlayer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[NotNull]
		public string StringValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x180F90", Offset = "0x180390", VA = "0x180180F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x13DEB0", Offset = "0x13D2B0", VA = "0x18013DEB0")]
		public object ObjectValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x15AE80", Offset = "0x15A280", VA = "0x18015AE80")]
		public T ObjectValue<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x180F40", Offset = "0x180340", VA = "0x180180F40")]
		private CircuitSignal(TypeKind circuitTypeKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1809C0", Offset = "0x17FDC0", VA = "0x1801809C0")]
		public bool Equals(CircuitSignal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x180A60", Offset = "0x17FE60", VA = "0x180180A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x180B80", Offset = "0x17FF80", VA = "0x180180B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x14C03E0", Offset = "0x14BF7E0", VA = "0x1814C03E0")]
		public static bool operator !=(CircuitSignal left, CircuitSignal right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x180D00", Offset = "0x180100", VA = "0x180180D00")]
		public string InternalToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x180E10", Offset = "0x180210", VA = "0x180180E10")]
		internal CircuitSignalData ToSerializedSignalData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x14BFCF0", Offset = "0x14BF0F0", VA = "0x1814BFCF0")]
		internal static CircuitSignal FromSerializedSignalData(CircuitSignalData signalData)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x14BF9D0", Offset = "0x14BEDD0", VA = "0x1814BF9D0")]
		public static CircuitSignal DefaultFor(TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x14BFBE0", Offset = "0x14BEFE0", VA = "0x1814BFBE0")]
		public static CircuitSignal FromBool(bool newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC70", Offset = "0x14BF070", VA = "0x1814BFC70")]
		public static CircuitSignal FromInt(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC30", Offset = "0x14BF030", VA = "0x1814BFC30")]
		public static CircuitSignal FromFloat(float newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x14BFE90", Offset = "0x14BF290", VA = "0x1814BFE90")]
		public static CircuitSignal FromString(string stringValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC70", Offset = "0x14BF070", VA = "0x1814BFC70")]
		public static CircuitSignal FromPlayerID(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC70", Offset = "0x14BF070", VA = "0x1814BFC70")]
		public static CircuitSignal FromPlayer(CircuitPlayer newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x14BFCB0", Offset = "0x14BF0B0", VA = "0x1814BFCB0")]
		public static CircuitSignal FromObject(object newValue, TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x14C01D0", Offset = "0x14BF5D0", VA = "0x1814C01D0")]
		public static CircuitSignal List(List<CircuitSignal> list)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x14BF730", Offset = "0x14BEB30", VA = "0x1814BF730")]
		public static CircuitSignal CreateListFromPorts(IExecutionScope executionScope, IReadOnlyCollection<InputPort> valuePorts, bool includeUnconnected)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x180C50", Offset = "0x180050", VA = "0x180180C50")]
		public List<CircuitSignal> GetListValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x14BFBE0", Offset = "0x14BEFE0", VA = "0x1814BFBE0")]
		public static explicit operator CircuitSignal(bool boolValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x14BFC30", Offset = "0x14BF030", VA = "0x1814BFC30")]
		public static explicit operator CircuitSignal(float floatValue)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct CircuitTypeOrString
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CircuitType circuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public string typeParameterReference;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public enum TypeOrStringKind
		{
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			CircuitType,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			TypeParameterReference
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private Impl impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TypeOrStringKind kind;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x14C08C0", Offset = "0x14BFCC0", VA = "0x1814C08C0")]
		public static implicit operator CircuitTypeOrString(string value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x14C0890", Offset = "0x14BFC90", VA = "0x1814C0890")]
		public static implicit operator CircuitTypeOrString(CircuitType value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x181170", Offset = "0x180570", VA = "0x180181170")]
		public CircuitType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x14C0720", Offset = "0x14BFB20", VA = "0x1814C0720")]
		public static CircuitType[] CircuitTypesFromArray(CircuitTypeOrString[] array)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct TypeParamConstrainedOrNot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TypeParameterType typeParam;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9DE0", Offset = "0x1DD91E0", VA = "0x181DD9DE0")]
		public static implicit operator TypeParamConstrainedOrNot(string name)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9E70", Offset = "0x1DD9270", VA = "0x181DD9E70")]
		public static implicit operator TypeParamConstrainedOrNot([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x62390", Offset = "0x61790")] (string, CircuitTypeOrString) fields)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x13BD80", Offset = "0x13B180", VA = "0x18013BD80")]
		public TypeParameterType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9CE0", Offset = "0x1DD90E0", VA = "0x181DD9CE0")]
		public static TypeParameterType[] TypeParameterTypesFromArray(TypeParamConstrainedOrNot[] array)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Guid? name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly IList<TypeParameterType> typeParameters;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x14C0DC0", Offset = "0x14C01C0", VA = "0x1814C0DC0")]
		public ClassFactoryTypeParams(Guid? name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x14C0AE0", Offset = "0x14BFEE0", VA = "0x1814C0AE0")]
		public ClassFactoryTypeParams CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x14C0C00", Offset = "0x14C0000", VA = "0x1814C0C00")]
		public ClassType End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly Guid? name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly IEnumerable<TypeParameterType> typeParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly IList<KeyValuePair<string, Property>> properties;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x14C0A10", Offset = "0x14BFE10", VA = "0x1814C0A10")]
		public ClassFactoryProps(Guid? name, string friendlyName, IList<TypeParameterType> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x14C0900", Offset = "0x14BFD00", VA = "0x1814C0900")]
		public ClassType End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class TypeTool
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class TypeToolRegistry
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1DDADE0", Offset = "0x1DDA1E0", VA = "0x181DDADE0")]
			public static void Enable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static Func<CircuitType> boolFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static Func<CircuitType> intFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Func<CircuitType> floatFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static Func<CircuitType> stringFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static Func<CircuitType> anyFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static Func<CircuitType> execFunc;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static Func<CircuitType> errFunc;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static CircuitType CBool
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBB30", Offset = "0x1DDAF30", VA = "0x181DDBB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static CircuitType CInt
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBCF0", Offset = "0x1DDB0F0", VA = "0x181DDBCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static CircuitType CFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBC80", Offset = "0x1DDB080", VA = "0x181DDBC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CircuitType CString
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBD60", Offset = "0x1DDB160", VA = "0x181DDBD60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static CircuitType CAny
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBAC0", Offset = "0x1DDAEC0", VA = "0x181DDBAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static CircuitType CExec
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBC10", Offset = "0x1DDB010", VA = "0x181DDBC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CircuitType CErr
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1DDBBA0", Offset = "0x1DDAFA0", VA = "0x181DDBBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB3A0", Offset = "0x1DDA7A0", VA = "0x181DDB3A0")]
		public static AppliedGenericType CArray(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB610", Offset = "0x1DDAA10", VA = "0x181DDB610")]
		public static AppliedGenericType CList(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB490", Offset = "0x1DDA890", VA = "0x181DDB490")]
		public static ClassFactoryTypeParams CClass()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB500", Offset = "0x1DDA900", VA = "0x181DDB500")]
		public static ClassFactoryTypeParams CClass(Guid name, string friendlyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB5A0", Offset = "0x1DDA9A0", VA = "0x181DDB5A0")]
		public static AppliedGenericType CIntersect(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB710", Offset = "0x1DDAB10", VA = "0x181DDB710")]
		public static AppliedGenericType CTuple(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB780", Offset = "0x1DDAB80", VA = "0x181DDB780")]
		public static TypeParameterType CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB850", Offset = "0x1DDAC50", VA = "0x181DDB850")]
		static TypeTool()
		{
		}
	}
}
namespace CircuitsV2.Types
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class AppliedGenericType : CircuitType, IEquatable<AppliedGenericType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public GenericType OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<CircuitType> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override bool ReferencesTypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7930", Offset = "0x1DC6D30", VA = "0x181DC7930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6F40", Offset = "0x1DC6340", VA = "0x181DC6F40", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7020", Offset = "0x1DC6420", VA = "0x181DC7020", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1DC78B0", Offset = "0x1DC6CB0", VA = "0x181DC78B0")]
		public AppliedGenericType(GenericType originalType, IEnumerable<CircuitType> typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7870", Offset = "0x1DC6C70", VA = "0x181DC7870", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7510", Offset = "0x1DC6910", VA = "0x181DC7510", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7480", Offset = "0x1DC6880", VA = "0x181DC7480", Slot = "10")]
		public bool Equals(AppliedGenericType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1DC75E0", Offset = "0x1DC69E0", VA = "0x181DC75E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7630", Offset = "0x1DC6A30", VA = "0x181DC7630", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC76B0", Offset = "0x1DC6AB0", VA = "0x181DC76B0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7270", Offset = "0x1DC6670", VA = "0x181DC7270")]
		public static AppliedGenericType DeserializeFromProtobuf(AppliedGenericTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ArrayType : GenericType, IEquatable<ArrayType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7C00", Offset = "0x1DC7000", VA = "0x181DC7C00")]
		public ArrayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7BA0", Offset = "0x1DC6FA0", VA = "0x181DC7BA0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7B10", Offset = "0x1DC6F10", VA = "0x181DC7B10", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7AD0", Offset = "0x1DC6ED0", VA = "0x181DC7AD0")]
		private static string ToStringImpl(string typeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7A70", Offset = "0x1DC6E70", VA = "0x181DC7A70", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E30", Offset = "0x3C2230", VA = "0x1803C2E30", Slot = "11")]
		public bool Equals(ArrayType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7A20", Offset = "0x1DC6E20", VA = "0x181DC7A20", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7AC0", Offset = "0x1DC6EC0", VA = "0x181DC7AC0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Field)]
	public class AutoTypeIdAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly string guidString;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x665350", Offset = "0x664750", VA = "0x180665350")]
		public AutoTypeIdAttribute(string guidString)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class CircuitType : IEquatable<CircuitType>
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public const int INITIAL_SERIALIZATION_VERSION = 0;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public const int CURRENT_SERIALIZATION_VERSION = 0;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TypeKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public virtual bool ReferencesTypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x384300", Offset = "0x383700", VA = "0x180384300")]
		public CircuitType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B3940", Offset = "0x4B2D40", VA = "0x1804B3940", Slot = "5")]
		public virtual CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1679AA0", Offset = "0x1678EA0", VA = "0x181679AA0", Slot = "7")]
		public virtual void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1679F90", Offset = "0x1679390", VA = "0x181679F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1679E30", Offset = "0x1679230", VA = "0x181679E30", Slot = "8")]
		public virtual bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1679DE0", Offset = "0x16791E0", VA = "0x181679DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x167A090", Offset = "0x1679490", VA = "0x18167A090")]
		public static bool operator ==(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x167A0B0", Offset = "0x16794B0", VA = "0x18167A0B0")]
		public static bool operator !=(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1679EF0", Offset = "0x16792F0", VA = "0x181679EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1679F10", Offset = "0x1679310", VA = "0x181679F10", Slot = "9")]
		public virtual CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1679B00", Offset = "0x1678F00", VA = "0x181679B00")]
		public static CircuitType DeserializeFromProtobuf(CircuitTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class ClassType : TypeParameterScopeType, IEquatable<ClassType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IReadOnlyDictionary<string, Property> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Guid? Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x167B2C0", Offset = "0x167A6C0", VA = "0x18167B2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x167B190", Offset = "0x167A590", VA = "0x18167B190")]
		public ClassType([Optional] IEnumerable<TypeParameterType> typeParameters, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] Guid? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x167AE60", Offset = "0x167A260", VA = "0x18167AE60", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x167A0F0", Offset = "0x16794F0", VA = "0x18167A0F0")]
		private string ClassNameToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x167B110", Offset = "0x167A510", VA = "0x18167B110")]
		private string TypeParametersToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x167AA40", Offset = "0x1679E40", VA = "0x18167AA40")]
		private string PropertiesToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x13CE580", Offset = "0x13CD980", VA = "0x1813CE580", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParamaterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x167A6C0", Offset = "0x1679AC0", VA = "0x18167A6C0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x167A510", Offset = "0x1679910", VA = "0x18167A510", Slot = "11")]
		public bool Equals(ClassType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x167A4C0", Offset = "0x16798C0", VA = "0x18167A4C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x167A8B0", Offset = "0x1679CB0", VA = "0x18167A8B0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x167ABB0", Offset = "0x1679FB0", VA = "0x18167ABB0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x167A1B0", Offset = "0x16795B0", VA = "0x18167A1B0")]
		public static ClassType DeserializeFromProtobuf(ClassTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FunctionType : TypeParameterScopeType, IEquatable<FunctionType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<KeyValuePair<string, Parameter>> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyList<KeyValuePair<string, Return>> Returns
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x167C120", Offset = "0x167B520", VA = "0x18167C120")]
		public FunctionType(IEnumerable<TypeParameterType> typeParameters, IEnumerable<KeyValuePair<string, Parameter>> parameters, IEnumerable<KeyValuePair<string, Return>> returns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x167C0F0", Offset = "0x167B4F0", VA = "0x18167C0F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x167C0C0", Offset = "0x167B4C0", VA = "0x18167C0C0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x167BB00", Offset = "0x167AF00", VA = "0x18167BB00", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x167BBF0", Offset = "0x167AFF0", VA = "0x18167BBF0", Slot = "11")]
		public bool Equals(FunctionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x167BAB0", Offset = "0x167AEB0", VA = "0x18167BAB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x167BCA0", Offset = "0x167B0A0", VA = "0x18167BCA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x167BD60", Offset = "0x167B160", VA = "0x18167BD60", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x167B780", Offset = "0x167AB80", VA = "0x18167B780")]
		public static FunctionType DeserializeFromProtobuf(FunctionTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GenericType : CircuitType
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x384300", Offset = "0x383700", VA = "0x180384300")]
		protected GenericType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract string ToString(IReadOnlyList<CircuitType> typeParameterAssignments);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x167C250", Offset = "0x167B650", VA = "0x18167C250")]
		public AppliedGenericType NewApplication(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x167C1E0", Offset = "0x167B5E0", VA = "0x18167C1E0")]
		public AppliedGenericType NewApplication(params CircuitType[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class IntersectionType : GenericType, IEquatable<IntersectionType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x167CEA0", Offset = "0x167C2A0", VA = "0x18167CEA0")]
		public IntersectionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x167CE70", Offset = "0x167C270", VA = "0x18167CE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x167CDD0", Offset = "0x167C1D0", VA = "0x18167CDD0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x167CD80", Offset = "0x167C180", VA = "0x18167CD80", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E30", Offset = "0x3C2230", VA = "0x1803C2E30", Slot = "11")]
		public bool Equals(IntersectionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x167CD30", Offset = "0x167C130", VA = "0x18167CD30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1679EF0", Offset = "0x16792F0", VA = "0x181679EF0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class Parameter : IEquatable<Parameter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CircuitType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB70", Offset = "0x3AAF70", VA = "0x1803ABB70")]
		public Parameter(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x167D290", Offset = "0x167C690", VA = "0x18167D290", Slot = "4")]
		public bool Equals(Parameter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x167D2D0", Offset = "0x167C6D0", VA = "0x18167D2D0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x105A400", Offset = "0x1059800", VA = "0x18105A400", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x167D320", Offset = "0x167C720", VA = "0x18167D320")]
		public ParameterData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x167D210", Offset = "0x167C610", VA = "0x18167D210")]
		public static Parameter DeserializeFromProtobuf(ParameterData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class Property : IEquatable<Property>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CircuitType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x489DF0", Offset = "0x4891F0", VA = "0x180489DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6667C0", Offset = "0x665BC0", VA = "0x1806667C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x167D7B0", Offset = "0x167CBB0", VA = "0x18167D7B0")]
		public Property(CircuitType type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x167D6F0", Offset = "0x167CAF0", VA = "0x18167D6F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x167D5C0", Offset = "0x167C9C0", VA = "0x18167D5C0")]
		private string GetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x167D6B0", Offset = "0x167CAB0", VA = "0x18167D6B0")]
		private string SetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x167D460", Offset = "0x167C860", VA = "0x18167D460", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x167D4F0", Offset = "0x167C8F0", VA = "0x18167D4F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x167D540", Offset = "0x167C940", VA = "0x18167D540", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x167D600", Offset = "0x167CA00", VA = "0x18167D600")]
		public PropertyData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x167D3B0", Offset = "0x167C7B0", VA = "0x18167D3B0")]
		public static Property DeserializeFromProtobuf(PropertyData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class Return : IEquatable<Return>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public CircuitType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB70", Offset = "0x3AAF70", VA = "0x1803ABB70")]
		public Return(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x167D290", Offset = "0x167C690", VA = "0x18167D290", Slot = "4")]
		public bool Equals(Return other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x167E5E0", Offset = "0x167D9E0", VA = "0x18167E5E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x105A400", Offset = "0x1059800", VA = "0x18105A400", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x167E630", Offset = "0x167DA30", VA = "0x18167E630")]
		public ReturnData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x167E560", Offset = "0x167D960", VA = "0x18167E560")]
		public static Return DeserializeFromProtobuf(ReturnData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class TupleType : GenericType, IEquatable<TupleType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x167F830", Offset = "0x167EC30", VA = "0x18167F830")]
		public TupleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x167F800", Offset = "0x167EC00", VA = "0x18167F800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x167F7A0", Offset = "0x167EBA0", VA = "0x18167F7A0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x167F750", Offset = "0x167EB50", VA = "0x18167F750", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E30", Offset = "0x3C2230", VA = "0x1803C2E30", Slot = "11")]
		public bool Equals(TupleType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x167F700", Offset = "0x167EB00", VA = "0x18167F700", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1679EF0", Offset = "0x16792F0", VA = "0x181679EF0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum TypeKind
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Boolean,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Int32,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Single,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		String,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Tuple,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Intersection,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Function,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		TypeParameter,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		TypeParameterReference,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		AppliedGeneric
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class TypeParameterReferenceType : CircuitType, IEquatable<TypeParameterReferenceType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public sealed override bool ReferencesTypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x38B250", Offset = "0x38A650", VA = "0x18038B250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x167F850", Offset = "0x167EC50", VA = "0x18167F850", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x167F940", Offset = "0x167ED40", VA = "0x18167F940", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x167FC20", Offset = "0x167F020", VA = "0x18167FC20")]
		public TypeParameterReferenceType(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x167FA70", Offset = "0x167EE70", VA = "0x18167FA70", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x167FAF0", Offset = "0x167EEF0", VA = "0x18167FAF0", Slot = "10")]
		public bool Equals(TypeParameterReferenceType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x167FA20", Offset = "0x167EE20", VA = "0x18167FA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x167FB20", Offset = "0x167EF20", VA = "0x18167FB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x167FB70", Offset = "0x167EF70", VA = "0x18167FB70", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x167F9A0", Offset = "0x167EDA0", VA = "0x18167F9A0")]
		public static TypeParameterReferenceType DeserializeFromProtobuf(TypeParameterReferenceTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class TypeParameterScopeType : GenericType
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public IEnumerable<TypeParameterType> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x167FD10", Offset = "0x167F110", VA = "0x18167FD10")]
		protected TypeParameterScopeType(IEnumerable<TypeParameterType> typeParameters, TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x167FC50", Offset = "0x167F050", VA = "0x18167FC50")]
		protected bool Equals(TypeParameterScopeType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x167FCB0", Offset = "0x167F0B0", VA = "0x18167FCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class TypeParameterType : CircuitType, IEquatable<TypeParameterType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public CircuitType Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x16801A0", Offset = "0x167F5A0", VA = "0x1816801A0")]
		public TypeParameterType(string name, [Optional] CircuitType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1680120", Offset = "0x167F520", VA = "0x181680120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x167FF20", Offset = "0x167F320", VA = "0x18167FF20", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x167FE60", Offset = "0x167F260", VA = "0x18167FE60", Slot = "10")]
		public bool Equals(TypeParameterType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x167FED0", Offset = "0x167F2D0", VA = "0x18167FED0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x167FFD0", Offset = "0x167F3D0", VA = "0x18167FFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1680050", Offset = "0x167F450", VA = "0x181680050", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x167FD80", Offset = "0x167F180", VA = "0x18167FD80")]
		public static TypeParameterType DeserializeFromProtobuf(TypeParameterTypeData protobufData)
		{
			return null;
		}
	}
}
namespace CircuitsV2.Types.Checker
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		TOutputPort SrcPort
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		TNode SrcNode
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TInputPort DstPort
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		TNode DstNode
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> : ICheckablePort where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		TCheckableConnection FirstConnection
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		IEnumerable<TInputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		IEnumerable<TOutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IEnumerable<(TypeParameterId<TNode>, TypeParameterId<TNode>)> GetAdditionalEquivalentTypeParameters();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> : ICheckablePort where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		IEnumerable<TCheckableConnection> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface ICheckablePort
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		CircuitType GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class TypeChecker
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1128420", Offset = "0x1127820", VA = "0x181128420")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(params TNode[] nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x11282D0", Offset = "0x11276D0", VA = "0x1811282D0")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TNode> nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1476FA0", Offset = "0x14763A0", VA = "0x181476FA0")]
		private static (Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>) GenerateConstraintsForNodes<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(IEnumerable<TNode> nodes, TUnificationArena unificationArena) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x14769F0", Offset = "0x1475DF0", VA = "0x1814769F0")]
		private static void GenerateConstraintsForNode<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToId, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToIdAll, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x66A90", Offset = "0x65E90")] List<(int, CircuitType)> idToType, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x66CA0", Offset = "0x660A0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1128170", Offset = "0x1127570", VA = "0x181128170")]
		private static Dictionary<string, int> IdentifyTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x66FF0", Offset = "0x663F0")] List<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1112B20", Offset = "0x1111F20", VA = "0x181112B20")]
		private static IEnumerable<(TPort, int)> GetGenericPorts<TPort, TUnificationArena, TTerm, TNode, TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TPort> ports, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToTypeId) where TPort : class, ICheckablePort where TUnificationArena : IUnificationArena<TTerm> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1478B30", Offset = "0x1477F30", VA = "0x181478B30")]
		private static (int, TTerm) GenerateOutputConstraintsAndId<TTerm, TOutputPort, TNode, TInputPort, TCheckableConnection, TUnificationArena>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x67270", Offset = "0x66670")] IEnumerable<(TOutputPort, int)> outputPorts, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x67770", Offset = "0x66B70")] List<(int, CircuitType)> idToType, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((int, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1477C00", Offset = "0x1477000", VA = "0x181477C00")]
		private static void GenerateInputConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x67C00", Offset = "0x67000")] IEnumerable<(TInputPort, int)> inputPorts, TUnificationArena unificationArena, int outputPortId, TTerm outputPortUnificationTerm, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x67E10", Offset = "0x67210")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x12D4950", Offset = "0x12D3D50", VA = "0x1812D4950")]
		private static int GenerateInputConnectionConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TInputPort inputPort, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68060", Offset = "0x67460")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xF57940", Offset = "0xF56D40", VA = "0x180F57940")]
		private static TTerm GetTypeUnificationTerm<TTerm, TUnificationArena>(CircuitType type, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68340", Offset = "0x67740")] List<(int, CircuitType)> idToType, IReadOnlyDictionary<string, int> typeParameterToId) where TUnificationArena : IUnificationArena<TTerm>
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1127A60", Offset = "0x1126E60", VA = "0x181127A60")]
		private static Dictionary<TNode, List<(string, CircuitType)>> GetTypeParameterAssignments<TNode, TInputPort, TOutputPort, TCheckableConnection>(ReferenceSubstitution[] substitutions, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68510", Offset = "0x67910")] IEnumerable<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1475C20", Offset = "0x1475020", VA = "0x181475C20")]
		private static void CacheAdditionalEquivalentTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection>(TNode node, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68910", Offset = "0x67D10")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1476350", Offset = "0x1475750", VA = "0x181476350")]
		private static void GenerateConstraintsForAdditionalEquivalentTypeParameters<TUnificationArena, TTerm, TNode>(TUnificationArena unificationArena, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68BF0", Offset = "0x67FF0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9410", Offset = "0x1DD8810", VA = "0x181DD9410")]
		private static Dictionary<int, CircuitType> ApplySubstitutions(Dictionary<int, ReferenceSubstitution> substitutions, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x68E90", Offset = "0x68290")] IEnumerable<(int, CircuitType)> idToType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9900", Offset = "0x1DD8D00", VA = "0x181DD9900")]
		private static CircuitType MonomorphizeItem(ITerm type, Dictionary<int, CircuitType> idToType, Dictionary<int, CircuitType> cache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1DD97B0", Offset = "0x1DD8BB0", VA = "0x181DD97B0")]
		private static ReferenceIdentifier GetArrowLast(ReferenceArrow arrow)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TNode Node
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x13BD80", Offset = "0x13B180", VA = "0x18013BD80")]
			[CompilerGenerated]
			get
			{
				return (TNode)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x13DEB0", Offset = "0x13D2B0", VA = "0x18013DEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x141460", Offset = "0x140860", VA = "0x180141460")]
		public TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x230320", Offset = "0x22F720", VA = "0x180230320", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2303F0", Offset = "0x22F7F0", VA = "0x1802303F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x230480", Offset = "0x22F880", VA = "0x180230480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x230510", Offset = "0x22F910", VA = "0x180230510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class TypeParameterId
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x125F0C0", Offset = "0x125E4C0", VA = "0x18125F0C0")]
		public static TypeParameterId<TNode> New<TNode>(TNode node, string name)
		{
			return default(TypeParameterId<TNode>);
		}
	}
}
namespace CircuitsV2.Types.Checker.Unification
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum ApplyConstraintResultKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Constraints,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		NoOp,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Substitution
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface IUnificationArena<TTerm>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NextId();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GetId<T>(Dictionary<T, int> itemToIndex, T item);

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TTerm Arrow(TTerm from, TTerm to);

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TTerm Identifier(int value);

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Constraint(TTerm lhs, TTerm rhs);
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum TermKind
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Identifier,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Arrow
	}
}
namespace CircuitsV2.Types.Checker.Unification.Value
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct ApplyConstraintResult
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x6B9F0", Offset = "0x6ADF0")]
			public readonly (Constraint, Constraint) constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Substitution substitution;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1E07C0", Offset = "0x1DFBC0", VA = "0x1801E07C0")]
			public Impl(in Constraint first, in Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1E07D0", Offset = "0x1DFBD0", VA = "0x1801E07D0")]
			public Impl(in Substitution substitution)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Impl impl;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public ApplyConstraintResultKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1362A0", Offset = "0x1356A0", VA = "0x1801362A0")]
			[CompilerGenerated]
			get
			{
				return default(ApplyConstraintResultKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Constraint FirstConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x13BD80", Offset = "0x13B180", VA = "0x18013BD80")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Constraint SecondConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x13DEB0", Offset = "0x13D2B0", VA = "0x18013DEB0")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Substitution Substitution
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x13BD80", Offset = "0x13B180", VA = "0x18013BD80")]
			get
			{
				return default(Substitution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1E06C0", Offset = "0x1DFAC0", VA = "0x1801E06C0")]
		private ApplyConstraintResult(in Constraint first, in Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x166CEE0", Offset = "0x166C2E0", VA = "0x18166CEE0")]
		public static ApplyConstraintResult NewConstraints(in Constraint first, in Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0690", Offset = "0x1DFA90", VA = "0x1801E0690")]
		private ApplyConstraintResult(in Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x166CF90", Offset = "0x166C390", VA = "0x18166CF90")]
		public static ApplyConstraintResult NewSubstitution(in Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1E06D0", Offset = "0x1DFAD0", VA = "0x1801E06D0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x166CF70", Offset = "0x166C370", VA = "0x18166CF70")]
		public static ApplyConstraintResult NewNoOp()
		{
			return default(ApplyConstraintResult);
		}
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct Arrow
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public TermIndex From
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public TermIndex To
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x138020", Offset = "0x137420", VA = "0x180138020")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x13BC30", Offset = "0x13B030", VA = "0x18013BC30")]
		public Arrow(TermIndex from, TermIndex to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1E0700", Offset = "0x1DFB00", VA = "0x1801E0700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct Constraint
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public TermIndex Lhs
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public TermIndex Rhs
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x138020", Offset = "0x137420", VA = "0x180138020")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1E0710", Offset = "0x1DFB10", VA = "0x1801E0710")]
		public ApplyConstraintResult Apply(Term[] terms)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x13BC30", Offset = "0x13B030", VA = "0x18013BC30")]
		public Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1E0740", Offset = "0x1DFB40", VA = "0x1801E0740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct Substitution
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TermIndex Value
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x138020", Offset = "0x137420", VA = "0x180138020")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x13BC30", Offset = "0x13B030", VA = "0x18013BC30")]
		public Substitution(int identifier, TermIndex value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0830", Offset = "0x1DFC30", VA = "0x1801E0830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 12)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct Term
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		private struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public readonly Arrow arrow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public readonly int identifier;

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x1E07F0", Offset = "0x1DFBF0", VA = "0x1801E07F0")]
			public Impl(in Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x1E0800", Offset = "0x1DFC00", VA = "0x1801E0800")]
			public Impl(int identifier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Impl impl;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public TermKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x13C880", Offset = "0x13BC80", VA = "0x18013C880")]
			[CompilerGenerated]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Arrow Arrow
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x13BD80", Offset = "0x13B180", VA = "0x18013BD80")]
			get
			{
				return default(Arrow);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A10", Offset = "0x1DFE10", VA = "0x1801E0A10")]
		private Term(in Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x167F6C0", Offset = "0x167EAC0", VA = "0x18167F6C0")]
		public static Term NewArrow(in Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A20", Offset = "0x1DFE20", VA = "0x1801E0A20")]
		private Term(int identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x167F6E0", Offset = "0x167EAE0", VA = "0x18167F6E0")]
		public static Term NewIdentifier(int identifier)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1E0920", Offset = "0x1DFD20", VA = "0x1801E0920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct TermIndex
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x13DF80", Offset = "0x13D380", VA = "0x18013DF80")]
		public TermIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1E08C0", Offset = "0x1DFCC0", VA = "0x1801E08C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1E08B0", Offset = "0x1DFCB0", VA = "0x1801E08B0")]
		public Term GetTerm(Term[] terms)
		{
			return default(Term);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class UnificationArena : IUnificationArena<TermIndex>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private List<Term> Terms
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB60", Offset = "0x3AAF60", VA = "0x1803ABB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Stack<Constraint> Constraints
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1683D90", Offset = "0x1683190", VA = "0x181683D90", Slot = "4")]
		public int NextId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C30", Offset = "0x12D4030", VA = "0x1812D4C30", Slot = "5")]
		public int GetId<T>(Dictionary<T, int> itemToIndex, T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1683BD0", Offset = "0x1682FD0", VA = "0x181683BD0", Slot = "6")]
		public TermIndex Arrow(TermIndex from, TermIndex to)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DF0", Offset = "0x3A71F0", VA = "0x1803A7DF0", Slot = "7")]
		public TermIndex Identifier(int value)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1683C80", Offset = "0x1683080", VA = "0x181683C80", Slot = "8")]
		public void Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1683E30", Offset = "0x1683230", VA = "0x181683E30", Slot = "9")]
		public ReferenceSubstitution[] Solve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1683CF0", Offset = "0x16830F0", VA = "0x181683CF0")]
		public static UnificationArena New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public UnificationArena()
		{
		}
	}
}
namespace CircuitsV2.Types.Checker.Unification.Reference
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface ITerm : IEquatable<ITerm>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		TermKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class ReferenceArrow : ITerm, IEquatable<ITerm>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public ITerm From
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ITerm To
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public TermKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x488E10", Offset = "0x488210", VA = "0x180488E10", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x167E080", Offset = "0x167D480", VA = "0x18167E080", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x67DF40", Offset = "0x67D340", VA = "0x18067DF40")]
		public ReferenceArrow(ITerm from, ITerm to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x167E1F0", Offset = "0x167D5F0", VA = "0x18167E1F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class ReferenceIdentifier : ITerm, IEquatable<ITerm>
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public TermKind Kind
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1F0", Offset = "0x3EA5F0", VA = "0x1803EB1F0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x167E280", Offset = "0x167D680", VA = "0x18167E280", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x384300", Offset = "0x383700", VA = "0x180384300")]
		public ReferenceIdentifier(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x167E390", Offset = "0x167D790", VA = "0x18167E390", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class ReferenceSubstitution
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public ITerm Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xAE3AD0", Offset = "0xAE2ED0", VA = "0x180AE3AD0")]
		public ReferenceSubstitution(int identifier, ITerm value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x167E510", Offset = "0x167D910", VA = "0x18167E510")]
		public ReferenceSubstitution(in Substitution substitution, Term[] terms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x167E3B0", Offset = "0x167D7B0", VA = "0x18167E3B0")]
		private static ITerm FromTermIndex(TermIndex termIndex, Term[] terms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x167E4B0", Offset = "0x167D8B0", VA = "0x18167E4B0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
}
namespace CircuitsV2.Synchronization
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class SignalSynchronization
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public struct IntBytesUnion
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public int IntVal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public byte b0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public byte b1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public byte b2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public byte b3;

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x13DF80", Offset = "0x13D380", VA = "0x18013DF80")]
			public IntBytesUnion(int intVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x24F210", Offset = "0x24E610", VA = "0x18024F210")]
			public IntBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x24F200", Offset = "0x24E600", VA = "0x18024F200")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7CB0", Offset = "0x1DC70B0", VA = "0x181DC7CB0")]
			public static IntBytesUnion ReadFromStream(Stream stream)
			{
				return default(IntBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly HashSet<ITypeSerializer> allTypeSerializers;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private static readonly Dictionary<CircuitType, ITypeSerializer> typeSerializers;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6BC0", Offset = "0x1DD5FC0", VA = "0x181DD6BC0")]
		internal static bool TryGetTypeSerializer(CircuitType signalType, out ITypeSerializer typeSerializer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6A50", Offset = "0x1DD5E50", VA = "0x181DD6A50")]
		public static void SerializeSignalForSync(Stream stream, CircuitType signalType, CircuitSignal signalValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DD68B0", Offset = "0x1DD5CB0", VA = "0x181DD68B0")]
		public static CircuitSignal DeserializeSyncedSignal(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6ED0", Offset = "0x1DD62D0", VA = "0x181DD6ED0")]
		public static void WriteInt(Stream stream, int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7CB0", Offset = "0x1DC70B0", VA = "0x181DC7CB0")]
		public static int ReadInt(Stream stream)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanSerialize(CircuitType circuitType);

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal);

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitSignal Deserialize(Stream stream, CircuitType signalType);
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal class BooleanSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xC1EC70", Offset = "0xC1E070", VA = "0x180C1EC70", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7C70", Offset = "0x1DC7070", VA = "0x181DC7C70", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7C10", Offset = "0x1DC7010", VA = "0x181DC7C10", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public BooleanSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class IntSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC1EB00", Offset = "0xC1DF00", VA = "0x180C1EB00", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7FF0", Offset = "0x1DC73F0", VA = "0x181DC7FF0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7F70", Offset = "0x1DC7370", VA = "0x181DC7F70", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public IntSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal class FloatSerializer : ITypeSerializer
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct FloatBytesUnion
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public float FloatVal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private byte b0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private byte b1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private byte b2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private byte b3;

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x164530", Offset = "0x163930", VA = "0x180164530")]
			public FloatBytesUnion(float floatVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x24F210", Offset = "0x24E610", VA = "0x18024F210")]
			public FloatBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x24F200", Offset = "0x24E600", VA = "0x18024F200")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7CB0", Offset = "0x1DC70B0", VA = "0x181DC7CB0")]
			public static FloatBytesUnion ReadFromStream(Stream stream)
			{
				return default(FloatBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7DE0", Offset = "0x1DC71E0", VA = "0x181DC7DE0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7EE0", Offset = "0x1DC72E0", VA = "0x181DC7EE0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7E10", Offset = "0x1DC7210", VA = "0x181DC7E10", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public FloatSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class StringSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7100", Offset = "0x1DD6500", VA = "0x181DD7100", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7280", Offset = "0x1DD6680", VA = "0x181DD7280", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7130", Offset = "0x1DD6530", VA = "0x181DD7130", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public StringSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class PlayerSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF550", Offset = "0x1DCE950", VA = "0x181DCF550", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF640", Offset = "0x1DCEA40", VA = "0x181DCF640", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF5C0", Offset = "0x1DCE9C0", VA = "0x181DCF5C0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public PlayerSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class ListSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8F80", Offset = "0x1DC8380", VA = "0x181DC8F80", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9230", Offset = "0x1DC8630", VA = "0x181DC9230", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC90A0", Offset = "0x1DC84A0", VA = "0x181DC90A0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public ListSerializer()
		{
		}
	}
}
namespace CircuitsV2.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class CircuitNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x1934620", Offset = "0x1933A20", VA = "0x181934620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x19332D0", Offset = "0x19326D0", VA = "0x1819332D0")]
		static CircuitNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class CircuitNodeData : IMessage<CircuitNodeData>, IMessage, IEquatable<CircuitNodeData>, IDeepCloneable<CircuitNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly MessageParser<CircuitNodeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public const int NodeIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private ByteString nodeId_;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public const int NodeTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private ByteString nodeType_;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public const int InputPortCollectionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private PortCollectionData inputPortCollection_;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public const int OutputPortCollectionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private PortCollectionData outputPortCollection_;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public const int NodeConnectionDatasFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static readonly FieldCodec<NodeConnectionData> _repeated_nodeConnectionDatas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private readonly RepeatedField<NodeConnectionData> nodeConnectionDatas_;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public const int NodeNameFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private string nodeName_;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public const int InventionDataFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private InventionPieceData inventionData_;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public const int TransformDataFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CircuitObjectTransformData transformData_;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public const int InnerContextIdFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ByteString innerContextId_;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public const int ListensToEventIdsFieldNumber = 100;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly FieldCodec<EventRegistrationData> _repeated_listensToEventIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private readonly RepeatedField<EventRegistrationData> listensToEventIds_;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public const int SendsToEventIdsFieldNumber = 101;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly FieldCodec<EventRegistrationData> _repeated_sendsToEventIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly RepeatedField<EventRegistrationData> sendsToEventIds_;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public const int SwitchNodeDataFieldNumber = 102;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private SwitchNodeData switchNodeData_;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public const int VariableNodeDataFieldNumber = 103;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private VariableNodeData variableNodeData_;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1935B70", Offset = "0x1934F70", VA = "0x181935B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x1935AA0", Offset = "0x1934EA0", VA = "0x181935AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x1935BD0", Offset = "0x1934FD0", VA = "0x181935BD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x1935D20", Offset = "0x1935120", VA = "0x181935D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1935DC0", Offset = "0x19351C0", VA = "0x181935DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public PortCollectionData InputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PortCollectionData OutputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x3AD160", Offset = "0x3AC560", VA = "0x1803AD160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public RepeatedField<NodeConnectionData> NodeConnectionDatas
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3B3350", Offset = "0x3B2750", VA = "0x1803B3350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[DebuggerNonUserCode]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x3890A0", Offset = "0x3884A0", VA = "0x1803890A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1935D70", Offset = "0x1935170", VA = "0x181935D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x392EC0", Offset = "0x3922C0", VA = "0x180392EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x391CE0", Offset = "0x3910E0", VA = "0x180391CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x3964F0", Offset = "0x3958F0", VA = "0x1803964F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x3936F0", Offset = "0x392AF0", VA = "0x1803936F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public ByteString InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x38A650", Offset = "0x389A50", VA = "0x18038A650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1935CD0", Offset = "0x19350D0", VA = "0x181935CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> ListensToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x3B75F0", Offset = "0x3B69F0", VA = "0x1803B75F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> SendsToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x392DE0", Offset = "0x3921E0", VA = "0x180392DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		public SwitchNodeData SwitchNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x3F4310", Offset = "0x3F3710", VA = "0x1803F4310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x453D20", Offset = "0x453120", VA = "0x180453D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public VariableNodeData VariableNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x3F4340", Offset = "0x3F3740", VA = "0x1803F4340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x47E080", Offset = "0x47D480", VA = "0x18047E080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1935850", Offset = "0x1934C50", VA = "0x181935850")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1935940", Offset = "0x1934D40", VA = "0x181935940")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1934A00", Offset = "0x1933E00", VA = "0x181934A00", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1934C80", Offset = "0x1934080", VA = "0x181934C80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1934A60", Offset = "0x1933E60", VA = "0x181934A60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1934CE0", Offset = "0x19340E0", VA = "0x181934CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x19352C0", Offset = "0x19346C0", VA = "0x1819352C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1935320", Offset = "0x1934720", VA = "0x181935320", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1934680", Offset = "0x1933A80", VA = "0x181934680", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1934EF0", Offset = "0x19342F0", VA = "0x181934EF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class CircuitObjectTransformDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1936920", Offset = "0x1935D20", VA = "0x181936920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1935E10", Offset = "0x1935210", VA = "0x181935E10")]
		static CircuitObjectTransformDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class Vector3Data : IMessage<Vector3Data>, IMessage, IEquatable<Vector3Data>, IDeepCloneable<Vector3Data>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly MessageParser<Vector3Data> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public const int XFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private float x_;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public const int YFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private float y_;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public const int ZFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[DebuggerNonUserCode]
		public static MessageParser<Vector3Data> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x1DE1410", Offset = "0x1DE0810", VA = "0x181DE1410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x1DE1390", Offset = "0x1DE0790", VA = "0x181DE1390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1DE1470", Offset = "0x1DE0870", VA = "0x181DE1470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x441970", Offset = "0x440D70", VA = "0x180441970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x48FEE0", Offset = "0x48F2E0", VA = "0x18048FEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x441980", Offset = "0x440D80", VA = "0x180441980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x48FEF0", Offset = "0x48F2F0", VA = "0x18048FEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x43EBF0", Offset = "0x43DFF0", VA = "0x18043EBF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x43E950", Offset = "0x43DD50", VA = "0x18043E950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x547250", Offset = "0x546650", VA = "0x180547250")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1170", Offset = "0x1DE0570", VA = "0x181DE1170", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE11E0", Offset = "0x1DE05E0", VA = "0x181DE11E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x546D60", Offset = "0x546160", VA = "0x180546D60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x546E90", Offset = "0x546290", VA = "0x180546E90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1270", Offset = "0x1DE0670", VA = "0x181DE1270", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x5470D0", Offset = "0x5464D0", VA = "0x1805470D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x546CB0", Offset = "0x5460B0", VA = "0x180546CB0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x546FF0", Offset = "0x5463F0", VA = "0x180546FF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class QuaternionData : IMessage<QuaternionData>, IMessage, IEquatable<QuaternionData>, IDeepCloneable<QuaternionData>
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly MessageParser<QuaternionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const int WFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private float w_;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const int XFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private float x_;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public const int YFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private float y_;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public const int ZFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private float z_;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[DebuggerNonUserCode]
		public static MessageParser<QuaternionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5900", Offset = "0x1DD4D00", VA = "0x181DD5900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5880", Offset = "0x1DD4C80", VA = "0x181DD5880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5960", Offset = "0x1DD4D60", VA = "0x181DD5960", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[DebuggerNonUserCode]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x441970", Offset = "0x440D70", VA = "0x180441970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x48FEE0", Offset = "0x48F2E0", VA = "0x18048FEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x441980", Offset = "0x440D80", VA = "0x180441980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x48FEF0", Offset = "0x48F2F0", VA = "0x18048FEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x43EBF0", Offset = "0x43DFF0", VA = "0x18043EBF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x43E950", Offset = "0x43DD50", VA = "0x18043E950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3B07C0", Offset = "0x3AFBC0", VA = "0x1803B07C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3B0860", Offset = "0x3AFC60", VA = "0x1803B0860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public QuaternionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x43EE00", Offset = "0x43E200", VA = "0x18043EE00")]
		[DebuggerNonUserCode]
		public QuaternionData(QuaternionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5640", Offset = "0x1DD4A40", VA = "0x181DD5640", Slot = "9")]
		[DebuggerNonUserCode]
		public QuaternionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1DD56C0", Offset = "0x1DD4AC0", VA = "0x181DD56C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xD84B90", Offset = "0xD83F90", VA = "0x180D84B90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(QuaternionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xD84CE0", Offset = "0xD840E0", VA = "0x180D84CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5760", Offset = "0x1DD4B60", VA = "0x181DD5760", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xD84F80", Offset = "0xD84380", VA = "0x180D84F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xD84AC0", Offset = "0xD83EC0", VA = "0x180D84AC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD84E70", Offset = "0xD84270", VA = "0x180D84E70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class CircuitObjectTransformData : IMessage<CircuitObjectTransformData>, IMessage, IEquatable<CircuitObjectTransformData>, IDeepCloneable<CircuitObjectTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly MessageParser<CircuitObjectTransformData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private ByteString id_;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public const int LocalPositionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Vector3Data localPosition_;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public const int LocalRotationFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private QuaternionData localRotation_;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitObjectTransformData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x19372C0", Offset = "0x19366C0", VA = "0x1819372C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x19371F0", Offset = "0x19365F0", VA = "0x1819371F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1937320", Offset = "0x1936720", VA = "0x181937320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[DebuggerNonUserCode]
		public ByteString Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x1937430", Offset = "0x1936830", VA = "0x181937430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public Vector3Data LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public QuaternionData LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1937190", Offset = "0x1936590", VA = "0x181937190")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x19370D0", Offset = "0x19364D0", VA = "0x1819370D0")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData(CircuitObjectTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1936A80", Offset = "0x1935E80", VA = "0x181936A80", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1936C40", Offset = "0x1936040", VA = "0x181936C40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1936B70", Offset = "0x1935F70", VA = "0x181936B70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitObjectTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1936D50", Offset = "0x1936150", VA = "0x181936D50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1936F00", Offset = "0x1936300", VA = "0x181936F00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1936F60", Offset = "0x1936360", VA = "0x181936F60", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1936980", Offset = "0x1935D80", VA = "0x181936980", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1936DE0", Offset = "0x19361E0", VA = "0x181936DE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class CircuitSignalDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x1937AD0", Offset = "0x1936ED0", VA = "0x181937AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1937480", Offset = "0x1936880", VA = "0x181937480")]
		static CircuitSignalDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class CircuitSignalData : IMessage<CircuitSignalData>, IMessage, IEquatable<CircuitSignalData>, IDeepCloneable<CircuitSignalData>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private static readonly MessageParser<CircuitSignalData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public const int TypeKindFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int typeKind_;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public const int BackingBoolFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private bool backingBool_;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public const int BackingIntFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int backingInt_;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public const int BackingFloatFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private float backingFloat_;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public const int BackingStringFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private string backingString_;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitSignalData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x1938380", Offset = "0x1937780", VA = "0x181938380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x19382B0", Offset = "0x19376B0", VA = "0x1819382B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x19383E0", Offset = "0x19377E0", VA = "0x1819383E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[DebuggerNonUserCode]
		public int TypeKind
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public bool BackingBool
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x90B900", Offset = "0x90AD00", VA = "0x18090B900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xBD9B00", Offset = "0xBD8F00", VA = "0x180BD9B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int BackingInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x3AD300", Offset = "0x3AC700", VA = "0x1803AD300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x3AD420", Offset = "0x3AC820", VA = "0x1803AD420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public float BackingFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3B07C0", Offset = "0x3AFBC0", VA = "0x1803B07C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3B0860", Offset = "0x3AFC60", VA = "0x1803B0860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public string BackingString
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x19384E0", Offset = "0x19378E0", VA = "0x1819384E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x19381F0", Offset = "0x19375F0", VA = "0x1819381F0")]
		[DebuggerNonUserCode]
		public CircuitSignalData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1938230", Offset = "0x1937630", VA = "0x181938230")]
		[DebuggerNonUserCode]
		public CircuitSignalData(CircuitSignalData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1937C40", Offset = "0x1937040", VA = "0x181937C40", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitSignalData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1937D50", Offset = "0x1937150", VA = "0x181937D50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1937CF0", Offset = "0x19370F0", VA = "0x181937CF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitSignalData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1937E00", Offset = "0x1937200", VA = "0x181937E00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1937FC0", Offset = "0x19373C0", VA = "0x181937FC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1938020", Offset = "0x1937420", VA = "0x181938020", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1937B30", Offset = "0x1936F30", VA = "0x181937B30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1937EF0", Offset = "0x19372F0", VA = "0x181937EF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class CircuitContextDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x192DE70", Offset = "0x192D270", VA = "0x18192DE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x192D2A0", Offset = "0x192C6A0", VA = "0x18192D2A0")]
		static CircuitContextDataReflection()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum CircuitSerializationVersion
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[OriginalName("InitialVersion")]
		InitialVersion
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class CircuitContextData : IMessage<CircuitContextData>, IMessage, IEquatable<CircuitContextData>, IDeepCloneable<CircuitContextData>
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly MessageParser<CircuitContextData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public const int ContextIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private ByteString contextId_;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public const int ContextTemplateIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private ByteString contextTemplateId_;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public const int SerializationVersionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private CircuitSerializationVersion serializationVersion_;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public const int EventBusDataFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private EventBusData eventBusData_;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public const int NodeDatasFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly FieldCodec<CircuitNodeData> _repeated_nodeDatas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly RepeatedField<CircuitNodeData> nodeDatas_;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public const int ChildContextsFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly FieldCodec<CircuitContextData> _repeated_childContexts_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly RepeatedField<CircuitContextData> childContexts_;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public const int DetermisticGuidIndexFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private int determisticGuidIndex_;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitContextData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x192EFD0", Offset = "0x192E3D0", VA = "0x18192EFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x192EF00", Offset = "0x192E300", VA = "0x18192EF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x192F030", Offset = "0x192E430", VA = "0x18192F030", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[DebuggerNonUserCode]
		public ByteString ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x192F130", Offset = "0x192E530", VA = "0x18192F130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public ByteString ContextTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x192F180", Offset = "0x192E580", VA = "0x18192F180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public CircuitSerializationVersion SerializationVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x3AD440", Offset = "0x3AC840", VA = "0x1803AD440")]
			get
			{
				return default(CircuitSerializationVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x3AD330", Offset = "0x3AC730", VA = "0x1803AD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public EventBusData EventBusData
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x3AD160", Offset = "0x3AC560", VA = "0x1803AD160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> NodeDatas
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3B3350", Offset = "0x3B2750", VA = "0x1803B3350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitContextData> ChildContexts
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x3890A0", Offset = "0x3884A0", VA = "0x1803890A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[DebuggerNonUserCode]
		public int DetermisticGuidIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x38BA00", Offset = "0x38AE00", VA = "0x18038BA00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x7D02C0", Offset = "0x7CF6C0", VA = "0x1807D02C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x192EE40", Offset = "0x192E240", VA = "0x18192EE40")]
		[DebuggerNonUserCode]
		public CircuitContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x192ECC0", Offset = "0x192E0C0", VA = "0x18192ECC0")]
		[DebuggerNonUserCode]
		public CircuitContextData(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x192E0C0", Offset = "0x192D4C0", VA = "0x18192E0C0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x192E260", Offset = "0x192D660", VA = "0x18192E260", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x192E120", Offset = "0x192D520", VA = "0x18192E120", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x192E3D0", Offset = "0x192D7D0", VA = "0x18192E3D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x192E8D0", Offset = "0x192DCD0", VA = "0x18192E8D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x192E930", Offset = "0x192DD30", VA = "0x18192E930", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x192DED0", Offset = "0x192D2D0", VA = "0x18192DED0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x192E710", Offset = "0x192DB10", VA = "0x18192E710", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x192E510", Offset = "0x192D910", VA = "0x18192E510", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class EventBusDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x193E9A0", Offset = "0x193DDA0", VA = "0x18193E9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x193CC60", Offset = "0x193C060", VA = "0x18193CC60")]
		static EventBusDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class EventBusData : IMessage<EventBusData>, IMessage, IEquatable<EventBusData>, IDeepCloneable<EventBusData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly MessageParser<EventBusData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public const int EventObjectDatasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly FieldCodec<CircuitEventObjectData> _repeated_eventObjectDatas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly RepeatedField<CircuitEventObjectData> eventObjectDatas_;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[DebuggerNonUserCode]
		public static MessageParser<EventBusData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x193F200", Offset = "0x193E600", VA = "0x18193F200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x193F130", Offset = "0x193E530", VA = "0x18193F130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x193F260", Offset = "0x193E660", VA = "0x18193F260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventObjectData> EventObjectDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x193F020", Offset = "0x193E420", VA = "0x18193F020")]
		[DebuggerNonUserCode]
		public EventBusData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x193F080", Offset = "0x193E480", VA = "0x18193F080")]
		[DebuggerNonUserCode]
		public EventBusData(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x193EA80", Offset = "0x193DE80", VA = "0x18193EA80", Slot = "9")]
		[DebuggerNonUserCode]
		public EventBusData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x193EB60", Offset = "0x193DF60", VA = "0x18193EB60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x193EC30", Offset = "0x193E030", VA = "0x18193EC30", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventBusData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0E0", Offset = "0x3CE4E0", VA = "0x1803CF0E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x193EDD0", Offset = "0x193E1D0", VA = "0x18193EDD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x193EE30", Offset = "0x193E230", VA = "0x18193EE30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x193EA00", Offset = "0x193DE00", VA = "0x18193EA00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x193ED70", Offset = "0x193E170", VA = "0x18193ED70", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x193ECB0", Offset = "0x193E0B0", VA = "0x18193ECB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class CircuitEventObjectData : IMessage<CircuitEventObjectData>, IMessage, IEquatable<CircuitEventObjectData>, IDeepCloneable<CircuitEventObjectData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private static readonly MessageParser<CircuitEventObjectData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public const int EventDefinitionDataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CircuitEventDefinitionData eventDefinitionData_;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public const int TransformDataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private CircuitObjectTransformData transformData_;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const int InventionDataFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private InventionPieceData inventionData_;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitEventObjectData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x19327C0", Offset = "0x1931BC0", VA = "0x1819327C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x19326F0", Offset = "0x1931AF0", VA = "0x1819326F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1932820", Offset = "0x1931C20", VA = "0x181932820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData EventDefinitionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB60", Offset = "0x3AAF60", VA = "0x1803ABB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x19325D0", Offset = "0x19319D0", VA = "0x1819325D0")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData(CircuitEventObjectData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1931FF0", Offset = "0x19313F0", VA = "0x181931FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1932130", Offset = "0x1931530", VA = "0x181932130", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x19321F0", Offset = "0x19315F0", VA = "0x1819321F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventObjectData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1932260", Offset = "0x1931660", VA = "0x181932260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1932410", Offset = "0x1931810", VA = "0x181932410", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1932470", Offset = "0x1931870", VA = "0x181932470", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1931F00", Offset = "0x1931300", VA = "0x181931F00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x19322E0", Offset = "0x19316E0", VA = "0x1819322E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class CircuitEventDefinitionData : IMessage<CircuitEventDefinitionData>, IMessage, IEquatable<CircuitEventDefinitionData>, IDeepCloneable<CircuitEventDefinitionData>
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly MessageParser<CircuitEventDefinitionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int EventIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private ByteString eventId_;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public const int EventNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private string eventName_;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public const int EventPropertiesFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly FieldCodec<CircuitEventProperty> _repeated_eventProperties_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly RepeatedField<CircuitEventProperty> eventProperties_;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitEventDefinitionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x19312E0", Offset = "0x19306E0", VA = "0x1819312E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x1931210", Offset = "0x1930610", VA = "0x181931210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x1931340", Offset = "0x1930740", VA = "0x181931340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		[DebuggerNonUserCode]
		public ByteString EventId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1931450", Offset = "0x1930850", VA = "0x181931450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x19314A0", Offset = "0x19308A0", VA = "0x1819314A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventProperty> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1931170", Offset = "0x1930570", VA = "0x181931170")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x19310F0", Offset = "0x19304F0", VA = "0x1819310F0")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData(CircuitEventDefinitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x19309B0", Offset = "0x192FDB0", VA = "0x1819309B0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1930A50", Offset = "0x192FE50", VA = "0x181930A50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1930B70", Offset = "0x192FF70", VA = "0x181930B70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventDefinitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1930C50", Offset = "0x1930050", VA = "0x181930C50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1930E20", Offset = "0x1930220", VA = "0x181930E20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1930E80", Offset = "0x1930280", VA = "0x181930E80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1930880", Offset = "0x192FC80", VA = "0x181930880", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1930D00", Offset = "0x1930100", VA = "0x181930D00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class CircuitEventProperty : IMessage<CircuitEventProperty>, IMessage, IEquatable<CircuitEventProperty>, IDeepCloneable<CircuitEventProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly MessageParser<CircuitEventProperty> _parser;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public const int PropertyNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private string propertyName_;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public const int PropertyTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private CircuitTypeData propertyType_;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitEventProperty> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x19330A0", Offset = "0x19324A0", VA = "0x1819330A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x1932FD0", Offset = "0x19323D0", VA = "0x181932FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1933100", Offset = "0x1932500", VA = "0x181933100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x1933210", Offset = "0x1932610", VA = "0x181933210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1932ED0", Offset = "0x19322D0", VA = "0x181932ED0")]
		[DebuggerNonUserCode]
		public CircuitEventProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1932F10", Offset = "0x1932310", VA = "0x181932F10")]
		[DebuggerNonUserCode]
		public CircuitEventProperty(CircuitEventProperty other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x19329F0", Offset = "0x1931DF0", VA = "0x1819329F0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventProperty Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1932B30", Offset = "0x1931F30", VA = "0x181932B30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1932AD0", Offset = "0x1931ED0", VA = "0x181932AD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1932BE0", Offset = "0x1931FE0", VA = "0x181932BE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1932D30", Offset = "0x1932130", VA = "0x181932D30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1932D90", Offset = "0x1932190", VA = "0x181932D90", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1932930", Offset = "0x1931D30", VA = "0x181932930", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1932C60", Offset = "0x1932060", VA = "0x181932C60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class EventRegistrationData : IMessage<EventRegistrationData>, IMessage, IEquatable<EventRegistrationData>, IDeepCloneable<EventRegistrationData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private static readonly MessageParser<EventRegistrationData> _parser;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const int RegistedToContextIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private ByteString registedToContextId_;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const int EventDefinitionIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private ByteString eventDefinitionId_;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		[DebuggerNonUserCode]
		public static MessageParser<EventRegistrationData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x1940570", Offset = "0x193F970", VA = "0x181940570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x19404A0", Offset = "0x193F8A0", VA = "0x1819404A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x19405D0", Offset = "0x193F9D0", VA = "0x1819405D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[DebuggerNonUserCode]
		public ByteString RegistedToContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x1940730", Offset = "0x193FB30", VA = "0x181940730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public ByteString EventDefinitionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x19406E0", Offset = "0x193FAE0", VA = "0x1819406E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1940430", Offset = "0x193F830", VA = "0x181940430")]
		[DebuggerNonUserCode]
		public EventRegistrationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1940390", Offset = "0x193F790", VA = "0x181940390")]
		[DebuggerNonUserCode]
		public EventRegistrationData(EventRegistrationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x193FE00", Offset = "0x193F200", VA = "0x18193FE00", Slot = "9")]
		[DebuggerNonUserCode]
		public EventRegistrationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x193FEC0", Offset = "0x193F2C0", VA = "0x18193FEC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x193FFF0", Offset = "0x193F3F0", VA = "0x18193FFF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventRegistrationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x19400D0", Offset = "0x193F4D0", VA = "0x1819400D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x19401E0", Offset = "0x193F5E0", VA = "0x1819401E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1940240", Offset = "0x193F640", VA = "0x181940240", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x193FD30", Offset = "0x193F130", VA = "0x18193FD30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1940160", Offset = "0x193F560", VA = "0x181940160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class SynchronizedEventData : IMessage<SynchronizedEventData>, IMessage, IEquatable<SynchronizedEventData>, IDeepCloneable<SynchronizedEventData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly MessageParser<SynchronizedEventData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private ByteString eventId_;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private static readonly FieldCodec<EventDataKeyValuePair> _repeated_datas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly RepeatedField<EventDataKeyValuePair> datas_;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		[DebuggerNonUserCode]
		public static MessageParser<SynchronizedEventData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DD92A0", Offset = "0x1DD86A0", VA = "0x181DD92A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9220", Offset = "0x1DD8620", VA = "0x181DD9220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9300", Offset = "0x1DD8700", VA = "0x181DD9300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[DebuggerNonUserCode]
		public ByteString EventId
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DD93C0", Offset = "0x1DD87C0", VA = "0x181DD93C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public RepeatedField<EventDataKeyValuePair> Datas
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9190", Offset = "0x1DD8590", VA = "0x181DD9190")]
		[DebuggerNonUserCode]
		public SynchronizedEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9120", Offset = "0x1DD8520", VA = "0x181DD9120")]
		[DebuggerNonUserCode]
		public SynchronizedEventData(SynchronizedEventData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8AF0", Offset = "0x1DD7EF0", VA = "0x181DD8AF0", Slot = "9")]
		[DebuggerNonUserCode]
		public SynchronizedEventData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8B90", Offset = "0x1DD7F90", VA = "0x181DD8B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8CA0", Offset = "0x1DD80A0", VA = "0x181DD8CA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SynchronizedEventData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8D60", Offset = "0x1DD8160", VA = "0x181DD8D60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8EE0", Offset = "0x1DD82E0", VA = "0x181DD8EE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8F40", Offset = "0x1DD8340", VA = "0x181DD8F40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8A10", Offset = "0x1DD7E10", VA = "0x181DD8A10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8DE0", Offset = "0x1DD81E0", VA = "0x181DD8DE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class EventDataKeyValuePair : IMessage<EventDataKeyValuePair>, IMessage, IEquatable<EventDataKeyValuePair>, IDeepCloneable<EventDataKeyValuePair>
	{
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly MessageParser<EventDataKeyValuePair> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private string key_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private ByteString value_;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[DebuggerNonUserCode]
		public static MessageParser<EventDataKeyValuePair> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x193FB20", Offset = "0x193EF20", VA = "0x18193FB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x193FA50", Offset = "0x193EE50", VA = "0x18193FA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x193FB80", Offset = "0x193EF80", VA = "0x18193FB80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x193FC90", Offset = "0x193F090", VA = "0x18193FC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x193FCE0", Offset = "0x193F0E0", VA = "0x18193FCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x193F9E0", Offset = "0x193EDE0", VA = "0x18193F9E0")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x193F940", Offset = "0x193ED40", VA = "0x18193F940")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair(EventDataKeyValuePair other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x193F430", Offset = "0x193E830", VA = "0x18193F430", Slot = "9")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x193F590", Offset = "0x193E990", VA = "0x18193F590", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x193F4F0", Offset = "0x193E8F0", VA = "0x18193F4F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventDataKeyValuePair other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x193F680", Offset = "0x193EA80", VA = "0x18193F680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x193F790", Offset = "0x193EB90", VA = "0x18193F790", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x193F7F0", Offset = "0x193EBF0", VA = "0x18193F7F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x193F360", Offset = "0x193E760", VA = "0x18193F360", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x193F710", Offset = "0x193EB10", VA = "0x18193F710", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class CircuitEventModificationData : IMessage<CircuitEventModificationData>, IMessage, IEquatable<CircuitEventModificationData>, IDeepCloneable<CircuitEventModificationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200009B")]
			public enum OperationTypes
			{
				[Cpp2IlInjected.Token(Token = "0x40001C0")]
				[OriginalName("Add")]
				Add,
				[Cpp2IlInjected.Token(Token = "0x40001C1")]
				[OriginalName("Remove")]
				Remove
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly MessageParser<CircuitEventModificationData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Types.OperationTypes operation_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private string propertyName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CircuitTypeData propertyType_;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitEventModificationData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x1931D40", Offset = "0x1931140", VA = "0x181931D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x1931C70", Offset = "0x1931070", VA = "0x181931C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x1931DA0", Offset = "0x19311A0", VA = "0x181931DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[DebuggerNonUserCode]
		public Types.OperationTypes Operation
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x1931EB0", Offset = "0x19312B0", VA = "0x181931EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1931C30", Offset = "0x1931030", VA = "0x181931C30")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1931B70", Offset = "0x1930F70", VA = "0x181931B70")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData(CircuitEventModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x19315F0", Offset = "0x19309F0", VA = "0x1819315F0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1931750", Offset = "0x1930B50", VA = "0x181931750", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x1930AE0", VA = "0x1819316E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1931810", Offset = "0x1930C10", VA = "0x181931810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x19319A0", Offset = "0x1930DA0", VA = "0x1819319A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1931A00", Offset = "0x1930E00", VA = "0x181931A00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x19314F0", Offset = "0x19308F0", VA = "0x1819314F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x19318B0", Offset = "0x1930CB0", VA = "0x1819318B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public static class InventionPieceDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8650", Offset = "0x1DC7A50", VA = "0x181DC8650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8060", Offset = "0x1DC7460", VA = "0x181DC8060")]
		static InventionPieceDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class InventionPieceData : IMessage<InventionPieceData>, IMessage, IEquatable<InventionPieceData>, IDeepCloneable<InventionPieceData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static readonly MessageParser<InventionPieceData> _parser;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int InstanceIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private ByteString instanceId_;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const int InventionIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private long inventionId_;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public const int VersionNumberFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private int versionNumber_;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public const int OriginallyFromOtherInventionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private bool originallyFromOtherInvention_;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[DebuggerNonUserCode]
		public static MessageParser<InventionPieceData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8DD0", Offset = "0x1DC81D0", VA = "0x181DC8DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8D00", Offset = "0x1DC8100", VA = "0x181DC8D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8E30", Offset = "0x1DC8230", VA = "0x181DC8E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		[DebuggerNonUserCode]
		public ByteString InstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8F30", Offset = "0x1DC8330", VA = "0x181DC8F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x3AD440", Offset = "0x3AC840", VA = "0x1803AD440")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x3AD330", Offset = "0x3AC730", VA = "0x1803AD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public bool OriginallyFromOtherInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x627880", Offset = "0x626C80", VA = "0x180627880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x627890", Offset = "0x626C90", VA = "0x180627890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8C00", Offset = "0x1DC8000", VA = "0x181DC8C00")]
		[DebuggerNonUserCode]
		public InventionPieceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8C60", Offset = "0x1DC8060", VA = "0x181DC8C60")]
		[DebuggerNonUserCode]
		public InventionPieceData(InventionPieceData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1DC87B0", Offset = "0x1DC7BB0", VA = "0x181DC87B0", Slot = "9")]
		[DebuggerNonUserCode]
		public InventionPieceData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8930", Offset = "0x1DC7D30", VA = "0x181DC8930", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8870", Offset = "0x1DC7C70", VA = "0x181DC8870", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InventionPieceData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xA71280", Offset = "0xA70680", VA = "0x180A71280", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8AE0", Offset = "0x1DC7EE0", VA = "0x181DC8AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA715D0", Offset = "0xA709D0", VA = "0x180A715D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1DC86B0", Offset = "0x1DC7AB0", VA = "0x181DC86B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8A30", Offset = "0x1DC7E30", VA = "0x181DC8A30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public static class CircuitContextNodeModificationsReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x192F970", Offset = "0x192ED70", VA = "0x18192F970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x192F1D0", Offset = "0x192E5D0", VA = "0x18192F1D0")]
		static CircuitContextNodeModificationsReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class CircuitContextNodeOperationData : IMessage<CircuitContextNodeOperationData>, IMessage, IEquatable<CircuitContextNodeOperationData>, IDeepCloneable<CircuitContextNodeOperationData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000A3")]
			public enum OperationTypes
			{
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				[OriginalName("Add")]
				Add,
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				[OriginalName("Remove")]
				Remove
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly MessageParser<CircuitContextNodeOperationData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Types.OperationTypes operationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool isInputGroup_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private string groupName_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private ByteString groupId_;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitContextNodeOperationData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x19302E0", Offset = "0x192F6E0", VA = "0x1819302E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x1930210", Offset = "0x192F610", VA = "0x181930210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x1930340", Offset = "0x192F740", VA = "0x181930340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		[DebuggerNonUserCode]
		public Types.OperationTypes OperationType
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x90B900", Offset = "0x90AD00", VA = "0x18090B900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xBD9B00", Offset = "0xBD8F00", VA = "0x180BD9B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1930490", Offset = "0x192F890", VA = "0x181930490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public ByteString GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1930440", Offset = "0x192F840", VA = "0x181930440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1930100", Offset = "0x192F500", VA = "0x181930100")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1930170", Offset = "0x192F570", VA = "0x181930170")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData(CircuitContextNodeOperationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x192FAE0", Offset = "0x192EEE0", VA = "0x18192FAE0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x192FC60", Offset = "0x192F060", VA = "0x18192FC60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x192FBB0", Offset = "0x192EFB0", VA = "0x18192FBB0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextNodeOperationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x192FD60", Offset = "0x192F160", VA = "0x18192FD60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x192FEF0", Offset = "0x192F2F0", VA = "0x18192FEF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x192FF50", Offset = "0x192F350", VA = "0x18192FF50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x192F9D0", Offset = "0x192EDD0", VA = "0x18192F9D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x192FE30", Offset = "0x192F230", VA = "0x18192FE30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public static class ModificationDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA960", Offset = "0x1DC9D60", VA = "0x181DCA960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9480", Offset = "0x1DC8880", VA = "0x181DC9480")]
		static ModificationDataReflection()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum CircuitObjectType
	{
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[OriginalName("NODE")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[OriginalName("EVENT")]
		Event
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class ModificationData : IMessage<ModificationData>, IMessage, IEquatable<ModificationData>, IDeepCloneable<ModificationData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly MessageParser<ModificationData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private ByteString contextId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private ByteString objectId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private CircuitObjectType modifiedObjectType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private ByteString modificationHandlerId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ByteString payload_;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[DebuggerNonUserCode]
		public static MessageParser<ModificationData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB520", Offset = "0x1DCA920", VA = "0x181DCB520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB450", Offset = "0x1DCA850", VA = "0x181DCB450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB580", Offset = "0x1DCA980", VA = "0x181DCB580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[DebuggerNonUserCode]
		public ByteString ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB680", Offset = "0x1DCAA80", VA = "0x181DCB680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public ByteString ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB720", Offset = "0x1DCAB20", VA = "0x181DCB720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CircuitObjectType ModifiedObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x3AD440", Offset = "0x3AC840", VA = "0x1803AD440")]
			get
			{
				return default(CircuitObjectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x3AD330", Offset = "0x3AC730", VA = "0x1803AD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public ByteString ModificationHandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB6D0", Offset = "0x1DCAAD0", VA = "0x181DCB6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x3B3350", Offset = "0x3B2750", VA = "0x1803B3350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB770", Offset = "0x1DCAB70", VA = "0x181DCB770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB3D0", Offset = "0x1DCA7D0", VA = "0x181DCB3D0")]
		[DebuggerNonUserCode]
		public ModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB370", Offset = "0x1DCA770", VA = "0x181DCB370")]
		[DebuggerNonUserCode]
		public ModificationData(ModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCAB60", Offset = "0x1DC9F60", VA = "0x181DCAB60", Slot = "9")]
		[DebuggerNonUserCode]
		public ModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCABF0", Offset = "0x1DC9FF0", VA = "0x181DCABF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCADA0", Offset = "0x1DCA1A0", VA = "0x181DCADA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1DCAEF0", Offset = "0x1DCA2F0", VA = "0x181DCAEF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB110", Offset = "0x1DCA510", VA = "0x181DCB110", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB170", Offset = "0x1DCA570", VA = "0x181DCB170", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA9C0", Offset = "0x1DC9DC0", VA = "0x181DCA9C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB010", Offset = "0x1DCA410", VA = "0x181DCB010", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class PortAddress : IMessage<PortAddress>, IMessage, IEquatable<PortAddress>, IDeepCloneable<PortAddress>
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly MessageParser<PortAddress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private ByteString contextId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private ByteString nodeId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool isInputPort_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private ByteString portId_;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[DebuggerNonUserCode]
		public static MessageParser<PortAddress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x1DD0060", Offset = "0x1DCF460", VA = "0x181DD0060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x1DCFF90", Offset = "0x1DCF390", VA = "0x181DCFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x1DD00C0", Offset = "0x1DCF4C0", VA = "0x181DD00C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		[DebuggerNonUserCode]
		public ByteString ContextId
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1DD01D0", Offset = "0x1DCF5D0", VA = "0x181DD01D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x1DD0220", Offset = "0x1DCF620", VA = "0x181DD0220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EB0", Offset = "0x3C82B0", VA = "0x1803C8EB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EC0", Offset = "0x3C82C0", VA = "0x1803C8EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x1DD0270", Offset = "0x1DCF670", VA = "0x181DD0270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFEC0", Offset = "0x1DCF2C0", VA = "0x181DCFEC0")]
		[DebuggerNonUserCode]
		public PortAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFF40", Offset = "0x1DCF340", VA = "0x181DCFF40")]
		[DebuggerNonUserCode]
		public PortAddress(PortAddress other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF7E0", Offset = "0x1DCEBE0", VA = "0x181DCF7E0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortAddress Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF860", Offset = "0x1DCEC60", VA = "0x181DCF860", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF9D0", Offset = "0x1DCEDD0", VA = "0x181DCF9D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortAddress other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFAF0", Offset = "0x1DCEEF0", VA = "0x181DCFAF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFCA0", Offset = "0x1DCF0A0", VA = "0x181DCFCA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFD00", Offset = "0x1DCF100", VA = "0x181DCFD00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF6B0", Offset = "0x1DCEAB0", VA = "0x181DCF6B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1DCFBD0", Offset = "0x1DCEFD0", VA = "0x181DCFBD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class PortModificationData : IMessage<PortModificationData>, IMessage, IEquatable<PortModificationData>, IDeepCloneable<PortModificationData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			public enum OperationTypes
			{
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				[OriginalName("Add")]
				Add,
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				[OriginalName("Remove")]
				Remove
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly MessageParser<PortModificationData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private Types.OperationTypes operationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private bool isInputPort_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private ByteString portGroupId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private NodePortData portData_;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[DebuggerNonUserCode]
		public static MessageParser<PortModificationData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4BD0", Offset = "0x1DD3FD0", VA = "0x181DD4BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4B00", Offset = "0x1DD3F00", VA = "0x181DD4B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4C30", Offset = "0x1DD4030", VA = "0x181DD4C30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[DebuggerNonUserCode]
		public Types.OperationTypes OperationType
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x90B900", Offset = "0x90AD00", VA = "0x18090B900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xBD9B00", Offset = "0xBD8F00", VA = "0x180BD9B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4D40", Offset = "0x1DD4140", VA = "0x181DD4D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerNonUserCode]
		public NodePortData PortData
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4940", Offset = "0x1DD3D40", VA = "0x181DD4940")]
		[DebuggerNonUserCode]
		public PortModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD49A0", Offset = "0x1DD3DA0", VA = "0x181DD49A0")]
		[DebuggerNonUserCode]
		public PortModificationData(PortModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4200", Offset = "0x1DD3600", VA = "0x181DD4200", Slot = "9")]
		[DebuggerNonUserCode]
		public PortModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4460", Offset = "0x1DD3860", VA = "0x181DD4460", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4390", Offset = "0x1DD3790", VA = "0x181DD4390", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4570", Offset = "0x1DD3970", VA = "0x181DD4570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4740", Offset = "0x1DD3B40", VA = "0x181DD4740", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD47A0", Offset = "0x1DD3BA0", VA = "0x181DD47A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4100", Offset = "0x1DD3500", VA = "0x181DD4100", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4630", Offset = "0x1DD3A30", VA = "0x181DD4630", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public sealed class PortDefaultValuePayloadData : IMessage<PortDefaultValuePayloadData>, IMessage, IEquatable<PortDefaultValuePayloadData>, IDeepCloneable<PortDefaultValuePayloadData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private static readonly MessageParser<PortDefaultValuePayloadData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private ByteString portId_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private CircuitSignalData defaultValueData_;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		[DebuggerNonUserCode]
		public static MessageParser<PortDefaultValuePayloadData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2110", Offset = "0x1DD1510", VA = "0x181DD2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2040", Offset = "0x1DD1440", VA = "0x181DD2040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2170", Offset = "0x1DD1570", VA = "0x181DD2170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2280", Offset = "0x1DD1680", VA = "0x181DD2280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1F30", Offset = "0x1DD1330", VA = "0x181DD1F30")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1F90", Offset = "0x1DD1390", VA = "0x181DD1F90")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData(PortDefaultValuePayloadData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1AC0", Offset = "0x1DD0EC0", VA = "0x181DD1AC0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1B90", Offset = "0x1DD0F90", VA = "0x181DD1B90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1C90", Offset = "0x1DD1090", VA = "0x181DD1C90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortDefaultValuePayloadData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x193C5A0", Offset = "0x193B9A0", VA = "0x18193C5A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1E10", Offset = "0x1DD1210", VA = "0x181DD1E10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x193C750", Offset = "0x193BB50", VA = "0x18193C750", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1A00", Offset = "0x1DD0E00", VA = "0x181DD1A00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1D40", Offset = "0x1DD1140", VA = "0x181DD1D40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public static class NodeConnectionDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x1DCBBD0", Offset = "0x1DCAFD0", VA = "0x181DCBBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB7C0", Offset = "0x1DCABC0", VA = "0x181DCB7C0")]
		static NodeConnectionDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class NodeConnectionData : IMessage<NodeConnectionData>, IMessage, IEquatable<NodeConnectionData>, IDeepCloneable<NodeConnectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static readonly MessageParser<NodeConnectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public const int SrcNodeIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private ByteString srcNodeId_;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public const int SrcPortIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private ByteString srcPortId_;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public const int DstNodeIdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private ByteString dstNodeId_;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public const int DstPortIdFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private ByteString dstPortId_;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		[DebuggerNonUserCode]
		public static MessageParser<NodeConnectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC6C0", Offset = "0x1DCBAC0", VA = "0x181DCC6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC5F0", Offset = "0x1DCB9F0", VA = "0x181DCC5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC720", Offset = "0x1DCBB20", VA = "0x181DCC720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		[DebuggerNonUserCode]
		public ByteString SrcNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC8C0", Offset = "0x1DCBCC0", VA = "0x181DCC8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public ByteString SrcPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC910", Offset = "0x1DCBD10", VA = "0x181DCC910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[DebuggerNonUserCode]
		public ByteString DstNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC820", Offset = "0x1DCBC20", VA = "0x181DCC820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		[DebuggerNonUserCode]
		public ByteString DstPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC870", Offset = "0x1DCBC70", VA = "0x181DCC870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC570", Offset = "0x1DCB970", VA = "0x181DCC570")]
		[DebuggerNonUserCode]
		public NodeConnectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC520", Offset = "0x1DCB920", VA = "0x181DCC520")]
		[DebuggerNonUserCode]
		public NodeConnectionData(NodeConnectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBDA0", Offset = "0x1DCB1A0", VA = "0x181DCBDA0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeConnectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBF70", Offset = "0x1DCB370", VA = "0x181DCBF70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBE20", Offset = "0x1DCB220", VA = "0x181DCBE20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeConnectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC110", Offset = "0x1DCB510", VA = "0x181DCC110", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC2F0", Offset = "0x1DCB6F0", VA = "0x181DCC2F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC350", Offset = "0x1DCB750", VA = "0x181DCC350", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBC30", Offset = "0x1DCB030", VA = "0x181DCBC30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC210", Offset = "0x1DCB610", VA = "0x181DCC210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public static class NodePortDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCFD0", Offset = "0x1DCC3D0", VA = "0x181DCCFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC960", Offset = "0x1DCBD60", VA = "0x181DCC960")]
		static NodePortDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class NodePortData : IMessage<NodePortData>, IMessage, IEquatable<NodePortData>, IDeepCloneable<NodePortData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private static readonly MessageParser<NodePortData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public const int PortIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private ByteString portId_;

		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public const int PortNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private string portName_;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public const int GenericPortTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private CircuitTypeData genericPortType_;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		[DebuggerNonUserCode]
		public static MessageParser<NodePortData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD9A0", Offset = "0x1DCCDA0", VA = "0x181DCD9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x1DCD8D0", Offset = "0x1DCCCD0", VA = "0x181DCD8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDA00", Offset = "0x1DCCE00", VA = "0x181DCDA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDB00", Offset = "0x1DCCF00", VA = "0x181DCDB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public string PortName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDB50", Offset = "0x1DCCF50", VA = "0x181DCDB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public CircuitTypeData GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD7A0", Offset = "0x1DCCBA0", VA = "0x181DCD7A0")]
		[DebuggerNonUserCode]
		public NodePortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD810", Offset = "0x1DCCC10", VA = "0x181DCD810")]
		[DebuggerNonUserCode]
		public NodePortData(NodePortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD140", Offset = "0x1DCC540", VA = "0x181DCD140", Slot = "9")]
		[DebuggerNonUserCode]
		public NodePortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD230", Offset = "0x1DCC630", VA = "0x181DCD230", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD340", Offset = "0x1DCC740", VA = "0x181DCD340", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodePortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD410", Offset = "0x1DCC810", VA = "0x181DCD410", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD5C0", Offset = "0x1DCC9C0", VA = "0x181DCD5C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD620", Offset = "0x1DCCA20", VA = "0x181DCD620", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD030", Offset = "0x1DCC430", VA = "0x181DCD030", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD4C0", Offset = "0x1DCC8C0", VA = "0x181DCD4C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public static class NullableBytesReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDE80", Offset = "0x1DCD280", VA = "0x181DCDE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDBA0", Offset = "0x1DCCFA0", VA = "0x181DCDBA0")]
		static NullableBytesReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class NullableBytes : IMessage<NullableBytes>, IMessage, IEquatable<NullableBytes>, IDeepCloneable<NullableBytes>
	{
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static readonly MessageParser<NullableBytes> _parser;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private ByteString value_;

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		[DebuggerNonUserCode]
		public static MessageParser<NullableBytes> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x1DCE4B0", Offset = "0x1DCD8B0", VA = "0x181DCE4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x1DCE3E0", Offset = "0x1DCD7E0", VA = "0x181DCE3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x1DCE510", Offset = "0x1DCD910", VA = "0x181DCE510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x1DCE610", Offset = "0x1DCDA10", VA = "0x181DCE610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE380", Offset = "0x1DCD780", VA = "0x181DCE380")]
		[DebuggerNonUserCode]
		public NullableBytes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE300", Offset = "0x1DCD700", VA = "0x181DCE300")]
		[DebuggerNonUserCode]
		public NullableBytes(NullableBytes other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDF60", Offset = "0x1DCD360", VA = "0x181DCDF60", Slot = "9")]
		[DebuggerNonUserCode]
		public NullableBytes Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE0A0", Offset = "0x1DCD4A0", VA = "0x181DCE0A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE010", Offset = "0x1DCD410", VA = "0x181DCE010", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NullableBytes other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C60", Offset = "0x8D7060", VA = "0x1808D7C60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE1E0", Offset = "0x1DCD5E0", VA = "0x181DCE1E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7ED0", Offset = "0x8D72D0", VA = "0x1808D7ED0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDEE0", Offset = "0x1DCD2E0", VA = "0x181DCDEE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE180", Offset = "0x1DCD580", VA = "0x181DCE180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class PortCollectionDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x1DD0D20", Offset = "0x1DD0120", VA = "0x181DD0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1DD02C0", Offset = "0x1DCF6C0", VA = "0x181DD02C0")]
		static PortCollectionDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class PortCollectionData : IMessage<PortCollectionData>, IMessage, IEquatable<PortCollectionData>, IDeepCloneable<PortCollectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly MessageParser<PortCollectionData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public const int BuiltInPortGroupsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private static readonly FieldCodec<PortGroupData> _repeated_builtInPortGroups_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private readonly RepeatedField<PortGroupData> builtInPortGroups_;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public const int DynamicPortGroupsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private static readonly FieldCodec<PortGroupData> _repeated_dynamicPortGroups_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly RepeatedField<PortGroupData> dynamicPortGroups_;

		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public const int DefaultPortValueDatasFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private static readonly FieldCodec<DefaultPortData> _repeated_defaultPortValueDatas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private readonly RepeatedField<DefaultPortData> defaultPortValueDatas_;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[DebuggerNonUserCode]
		public static MessageParser<PortCollectionData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x1DD18A0", Offset = "0x1DD0CA0", VA = "0x181DD18A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x1DD17D0", Offset = "0x1DD0BD0", VA = "0x181DD17D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x1DD1900", Offset = "0x1DD0D00", VA = "0x181DD1900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		[DebuggerNonUserCode]
		public RepeatedField<PortGroupData> BuiltInPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		[DebuggerNonUserCode]
		public RepeatedField<PortGroupData> DynamicPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		[DebuggerNonUserCode]
		public RepeatedField<DefaultPortData> DefaultPortValueDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1720", Offset = "0x1DD0B20", VA = "0x181DD1720")]
		[DebuggerNonUserCode]
		public PortCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1680", Offset = "0x1DD0A80", VA = "0x181DD1680")]
		[DebuggerNonUserCode]
		public PortCollectionData(PortCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0E70", Offset = "0x1DD0270", VA = "0x181DD0E70", Slot = "9")]
		[DebuggerNonUserCode]
		public PortCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0F40", Offset = "0x1DD0340", VA = "0x181DD0F40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1050", Offset = "0x1DD0450", VA = "0x181DD1050", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1100", Offset = "0x1DD0500", VA = "0x181DD1100", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1320", Offset = "0x1DD0720", VA = "0x181DD1320", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1380", Offset = "0x1DD0780", VA = "0x181DD1380", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0D80", Offset = "0x1DD0180", VA = "0x181DD0D80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1190", Offset = "0x1DD0590", VA = "0x181DD1190", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class DefaultPortData : IMessage<DefaultPortData>, IMessage, IEquatable<DefaultPortData>, IDeepCloneable<DefaultPortData>
	{
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private static readonly MessageParser<DefaultPortData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public const int PortIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private ByteString portId_;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public const int DefaultValueDataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private CircuitSignalData defaultValueData_;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultPortData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x193CA90", Offset = "0x193BE90", VA = "0x18193CA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x193CA10", Offset = "0x193BE10", VA = "0x18193CA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x193CAF0", Offset = "0x193BEF0", VA = "0x18193CAF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x193CBB0", Offset = "0x193BFB0", VA = "0x18193CBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x193C9B0", Offset = "0x193BDB0", VA = "0x18193C9B0")]
		[DebuggerNonUserCode]
		public DefaultPortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x193C890", Offset = "0x193BC90", VA = "0x18193C890")]
		[DebuggerNonUserCode]
		public DefaultPortData(DefaultPortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x193C2A0", Offset = "0x193B6A0", VA = "0x18193C2A0", Slot = "9")]
		[DebuggerNonUserCode]
		public DefaultPortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x193C4A0", Offset = "0x193B8A0", VA = "0x18193C4A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x193C3F0", Offset = "0x193B7F0", VA = "0x18193C3F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x193C5A0", Offset = "0x193B9A0", VA = "0x18193C5A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x193C6F0", Offset = "0x193BAF0", VA = "0x18193C6F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x193C750", Offset = "0x193BB50", VA = "0x18193C750", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x193C1E0", Offset = "0x193B5E0", VA = "0x18193C1E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x193C620", Offset = "0x193BA20", VA = "0x18193C620", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public static class PortGroupDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2EA0", Offset = "0x1DD22A0", VA = "0x181DD2EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1DD22D0", Offset = "0x1DD16D0", VA = "0x181DD22D0")]
		static PortGroupDataReflection()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public enum PortGroupType
	{
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[OriginalName("BasicGroup")]
		BasicGroup,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[OriginalName("IndexBased")]
		IndexBased,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[OriginalName("NameBased")]
		NameBased,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[OriginalName("ExecNameBased")]
		ExecNameBased
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class PortGroupData : IMessage<PortGroupData>, IMessage, IEquatable<PortGroupData>, IDeepCloneable<PortGroupData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static readonly MessageParser<PortGroupData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public const int PortGroupIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private ByteString portGroupId_;

		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public const int PortGroupTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private PortGroupType portGroupType_;

		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public const int NodePortDatasFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private static readonly FieldCodec<NodePortData> _repeated_nodePortDatas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly RepeatedField<NodePortData> nodePortDatas_;

		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public const int PortGroupNameFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string portGroupName_;

		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public const int ElementPortTypeFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private CircuitTypeData elementPortType_;

		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public const int NumberOfPortsFieldNumber = 101;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private uint numberOfPorts_;

		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public const int ElementNameFieldNumber = 102;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private string elementName_;

		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public const int ExecNameFieldNumber = 201;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private string execName_;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		[DebuggerNonUserCode]
		public static MessageParser<PortGroupData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3E60", Offset = "0x1DD3260", VA = "0x181DD3E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3D90", Offset = "0x1DD3190", VA = "0x181DD3D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3EC0", Offset = "0x1DD32C0", VA = "0x181DD3EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4060", Offset = "0x1DD3460", VA = "0x181DD4060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x3AD300", Offset = "0x3AC700", VA = "0x1803AD300")]
			get
			{
				return default(PortGroupType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x3AD420", Offset = "0x3AC820", VA = "0x1803AD420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public RepeatedField<NodePortData> NodePortDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		[DebuggerNonUserCode]
		public string PortGroupName
		{
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1DD40B0", Offset = "0x1DD34B0", VA = "0x181DD40B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public CircuitTypeData ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x3B3350", Offset = "0x3B2750", VA = "0x1803B3350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x3F44D0", Offset = "0x3F38D0", VA = "0x1803F44D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		public uint NumberOfPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x3F52A0", Offset = "0x3F46A0", VA = "0x1803F52A0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x3F4A30", Offset = "0x3F3E30", VA = "0x1803F4A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x392EC0", Offset = "0x3922C0", VA = "0x180392EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3FC0", Offset = "0x1DD33C0", VA = "0x181DD3FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public string ExecName
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x3964F0", Offset = "0x3958F0", VA = "0x1803964F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4010", Offset = "0x1DD3410", VA = "0x181DD4010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3CE0", Offset = "0x1DD30E0", VA = "0x181DD3CE0")]
		[DebuggerNonUserCode]
		public PortGroupData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3C30", Offset = "0x1DD3030", VA = "0x181DD3C30")]
		[DebuggerNonUserCode]
		public PortGroupData(PortGroupData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3160", Offset = "0x1DD2560", VA = "0x181DD3160", Slot = "9")]
		[DebuggerNonUserCode]
		public PortGroupData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3380", Offset = "0x1DD2780", VA = "0x181DD3380", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3240", Offset = "0x1DD2640", VA = "0x181DD3240", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortGroupData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3500", Offset = "0x1DD2900", VA = "0x181DD3500", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3860", Offset = "0x1DD2C60", VA = "0x181DD3860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD38C0", Offset = "0x1DD2CC0", VA = "0x181DD38C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2F00", Offset = "0x1DD2300", VA = "0x181DD2F00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3670", Offset = "0x1DD2A70", VA = "0x181DD3670", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public static class SwitchNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7700", Offset = "0x1DD6B00", VA = "0x181DD7700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1DD73B0", Offset = "0x1DD67B0", VA = "0x181DD73B0")]
		static SwitchNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class SwitchNodeData : IMessage<SwitchNodeData>, IMessage, IEquatable<SwitchNodeData>, IDeepCloneable<SwitchNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly MessageParser<SwitchNodeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public const int IntSwitchNodeCasesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly FieldCodec<int> _repeated_intSwitchNodeCases_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private readonly RepeatedField<int> intSwitchNodeCases_;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public const int StringSwitchNodeCasesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly FieldCodec<string> _repeated_stringSwitchNodeCases_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private readonly RepeatedField<string> stringSwitchNodeCases_;

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[DebuggerNonUserCode]
		public static MessageParser<SwitchNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8000", Offset = "0x1DD7400", VA = "0x181DD8000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7F30", Offset = "0x1DD7330", VA = "0x181DD7F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8060", Offset = "0x1DD7460", VA = "0x181DD8060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		[DebuggerNonUserCode]
		public RepeatedField<int> IntSwitchNodeCases
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[DebuggerNonUserCode]
		public RepeatedField<string> StringSwitchNodeCases
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7E30", Offset = "0x1DD7230", VA = "0x181DD7E30")]
		[DebuggerNonUserCode]
		public SwitchNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7EB0", Offset = "0x1DD72B0", VA = "0x181DD7EB0")]
		[DebuggerNonUserCode]
		public SwitchNodeData(SwitchNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7820", Offset = "0x1DD6C20", VA = "0x181DD7820", Slot = "9")]
		[DebuggerNonUserCode]
		public SwitchNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD78D0", Offset = "0x1DD6CD0", VA = "0x181DD78D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD79C0", Offset = "0x1DD6DC0", VA = "0x181DD79C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7A60", Offset = "0x1DD6E60", VA = "0x181DD7A60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7C00", Offset = "0x1DD7000", VA = "0x181DD7C00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7C60", Offset = "0x1DD7060", VA = "0x181DD7C60", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7760", Offset = "0x1DD6B60", VA = "0x181DD7760", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7AC0", Offset = "0x1DD6EC0", VA = "0x181DD7AC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public static class TypesReflection
	{
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x1DDE7E0", Offset = "0x1DDDBE0", VA = "0x181DDE7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBDD0", Offset = "0x1DDB1D0", VA = "0x181DDBDD0")]
		static TypesReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class AppliedGenericTypeData : IMessage<AppliedGenericTypeData>, IMessage, IEquatable<AppliedGenericTypeData>, IDeepCloneable<AppliedGenericTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly MessageParser<AppliedGenericTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public const int OriginalTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private CircuitTypeData originalType_;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public const int TypeParameterAssignmentsFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly FieldCodec<CircuitTypeData> _repeated_typeParameterAssignments_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly RepeatedField<CircuitTypeData> typeParameterAssignments_;

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[DebuggerNonUserCode]
		public static MessageParser<AppliedGenericTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x192CAF0", Offset = "0x192BEF0", VA = "0x18192CAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x192CA70", Offset = "0x192BE70", VA = "0x18192CA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x192CB50", Offset = "0x192BF50", VA = "0x18192CB50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public CircuitTypeData OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x192CA10", Offset = "0x192BE10", VA = "0x18192CA10")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x192C940", Offset = "0x192BD40", VA = "0x18192C940")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData(AppliedGenericTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x192C280", Offset = "0x192B680", VA = "0x18192C280", Slot = "9")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x192C380", Offset = "0x192B780", VA = "0x18192C380", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x192C460", Offset = "0x192B860", VA = "0x18192C460", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(AppliedGenericTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x192C4F0", Offset = "0x192B8F0", VA = "0x18192C4F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x192C6A0", Offset = "0x192BAA0", VA = "0x18192C6A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x192C700", Offset = "0x192BB00", VA = "0x18192C700", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x192C180", Offset = "0x192B580", VA = "0x18192C180", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x192C570", Offset = "0x192B970", VA = "0x18192C570", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class CircuitTypeData : IMessage<CircuitTypeData>, IMessage, IEquatable<CircuitTypeData>, IDeepCloneable<CircuitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly MessageParser<CircuitTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public const int KindFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int kind_;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public const int AppliedGenericTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private AppliedGenericTypeData appliedGenericType_;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public const int ClassTypeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private ClassTypeData classType_;

		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public const int FunctionTypeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private FunctionTypeData functionType_;

		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public const int TypeParameterReferenceTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private TypeParameterReferenceTypeData typeParameterReferenceType_;

		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public const int TypeParameterTypeFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TypeParameterTypeData typeParameterType_;

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[DebuggerNonUserCode]
		public static MessageParser<CircuitTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x193B480", Offset = "0x193A880", VA = "0x18193B480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x193B400", Offset = "0x193A800", VA = "0x18193B400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x193B4E0", Offset = "0x193A8E0", VA = "0x18193B4E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3AD320", Offset = "0x3AC720", VA = "0x1803AD320")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x3AD340", Offset = "0x3AC740", VA = "0x1803AD340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData AppliedGenericType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public ClassTypeData ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		public FunctionTypeData FunctionType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x3AD160", Offset = "0x3AC560", VA = "0x1803AD160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData TypeParameterReferenceType
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x3B3350", Offset = "0x3B2750", VA = "0x1803B3350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x3F44D0", Offset = "0x3F38D0", VA = "0x1803F44D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData TypeParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x3890A0", Offset = "0x3884A0", VA = "0x1803890A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x392ED0", Offset = "0x3922D0", VA = "0x180392ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public CircuitTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x193B110", Offset = "0x193A510", VA = "0x18193B110")]
		[DebuggerNonUserCode]
		public CircuitTypeData(CircuitTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x193A9A0", Offset = "0x1939DA0", VA = "0x18193A9A0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x193AAB0", Offset = "0x1939EB0", VA = "0x18193AAB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x193AA00", Offset = "0x1939E00", VA = "0x18193AA00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x193ABC0", Offset = "0x1939FC0", VA = "0x18193ABC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x193AEA0", Offset = "0x193A2A0", VA = "0x18193AEA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x193AF00", Offset = "0x193A300", VA = "0x18193AF00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x193A7E0", Offset = "0x1939BE0", VA = "0x18193A7E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x193ACB0", Offset = "0x193A0B0", VA = "0x18193ACB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class ClassTypeData : IMessage<ClassTypeData>, IMessage, IEquatable<ClassTypeData>, IDeepCloneable<ClassTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private static readonly MessageParser<ClassTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public const int TypeParametersFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private static readonly FieldCodec<CircuitTypeData> _repeated_typeParameters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private readonly RepeatedField<CircuitTypeData> typeParameters_;

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public const int PropertiesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private static readonly MapField<string, PropertyData>.Codec _map_properties_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private readonly MapField<string, PropertyData> properties_;

		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public const int NameFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private NullableBytes name_;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[DebuggerNonUserCode]
		public static MessageParser<ClassTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x193C0C0", Offset = "0x193B4C0", VA = "0x18193C0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x193C040", Offset = "0x193B440", VA = "0x18193C040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x193C120", Offset = "0x193B520", VA = "0x18193C120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[DebuggerNonUserCode]
		public MapField<string, PropertyData> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[DebuggerNonUserCode]
		public NullableBytes Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x3AD160", Offset = "0x3AC560", VA = "0x1803AD160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x193BF10", Offset = "0x193B310", VA = "0x18193BF10")]
		[DebuggerNonUserCode]
		public ClassTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x193BF90", Offset = "0x193B390", VA = "0x18193BF90")]
		[DebuggerNonUserCode]
		public ClassTypeData(ClassTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x193B6D0", Offset = "0x193AAD0", VA = "0x18193B6D0", Slot = "9")]
		[DebuggerNonUserCode]
		public ClassTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x193B7B0", Offset = "0x193ABB0", VA = "0x18193B7B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x193B8B0", Offset = "0x193ACB0", VA = "0x18193B8B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ClassTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x193B960", Offset = "0x193AD60", VA = "0x18193B960", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x193BBA0", Offset = "0x193AFA0", VA = "0x18193BBA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x193BC00", Offset = "0x193B000", VA = "0x18193BC00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x193B5A0", Offset = "0x193A9A0", VA = "0x18193B5A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x193BA10", Offset = "0x193AE10", VA = "0x18193BA10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class FunctionTypeData : IMessage<FunctionTypeData>, IMessage, IEquatable<FunctionTypeData>, IDeepCloneable<FunctionTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private static readonly MessageParser<FunctionTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public const int TypeParametersFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private static readonly FieldCodec<CircuitTypeData> _repeated_typeParameters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private readonly RepeatedField<CircuitTypeData> typeParameters_;

		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public const int ParametersFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private static readonly FieldCodec<ParameterWithKeyData> _repeated_parameters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private readonly RepeatedField<ParameterWithKeyData> parameters_;

		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public const int ReturnsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private static readonly FieldCodec<ReturnWithKeyData> _repeated_returns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private readonly RepeatedField<ReturnWithKeyData> returns_;

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[DebuggerNonUserCode]
		public static MessageParser<FunctionTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x19412E0", Offset = "0x19406E0", VA = "0x1819412E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x1941260", Offset = "0x1940660", VA = "0x181941260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x1941340", Offset = "0x1940740", VA = "0x181941340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		[DebuggerNonUserCode]
		public RepeatedField<ParameterWithKeyData> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		[DebuggerNonUserCode]
		public RepeatedField<ReturnWithKeyData> Returns
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x19411B0", Offset = "0x19405B0", VA = "0x1819411B0")]
		[DebuggerNonUserCode]
		public FunctionTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x1941110", Offset = "0x1940510", VA = "0x181941110")]
		[DebuggerNonUserCode]
		public FunctionTypeData(FunctionTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x19408A0", Offset = "0x193FCA0", VA = "0x1819408A0", Slot = "9")]
		[DebuggerNonUserCode]
		public FunctionTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1940970", Offset = "0x193FD70", VA = "0x181940970", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x1940A80", Offset = "0x193FE80", VA = "0x181940A80", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(FunctionTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1940B40", Offset = "0x193FF40", VA = "0x181940B40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x1940DA0", Offset = "0x19401A0", VA = "0x181940DA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x1940E00", Offset = "0x1940200", VA = "0x181940E00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x1940780", Offset = "0x193FB80", VA = "0x181940780", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x1940BF0", Offset = "0x193FFF0", VA = "0x181940BF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class ParameterData : IMessage<ParameterData>, IMessage, IEquatable<ParameterData>, IDeepCloneable<ParameterData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private static readonly MessageParser<ParameterData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private CircuitTypeData type_;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[DebuggerNonUserCode]
		public static MessageParser<ParameterData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DCEB50", Offset = "0x1DCDF50", VA = "0x181DCEB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x1DCEA80", Offset = "0x1DCDE80", VA = "0x181DCEA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x1DCEBB0", Offset = "0x1DCDFB0", VA = "0x181DCEBB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public ParameterData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEA20", Offset = "0x1DCDE20", VA = "0x181DCEA20")]
		[DebuggerNonUserCode]
		public ParameterData(ParameterData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE720", Offset = "0x1DCDB20", VA = "0x181DCE720", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE7B0", Offset = "0x1DCDBB0", VA = "0x181DCE7B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xF1DF70", Offset = "0xF1D370", VA = "0x180F1DF70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xF1E0A0", Offset = "0xF1D4A0", VA = "0x180F1E0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE900", Offset = "0x1DCDD00", VA = "0x181DCE900", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xF1E350", Offset = "0xF1D750", VA = "0x180F1E350", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE660", Offset = "0x1DCDA60", VA = "0x181DCE660", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE840", Offset = "0x1DCDC40", VA = "0x181DCE840", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class ParameterWithKeyData : IMessage<ParameterWithKeyData>, IMessage, IEquatable<ParameterWithKeyData>, IDeepCloneable<ParameterWithKeyData>
	{
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private static readonly MessageParser<ParameterWithKeyData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const int KeyFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private string key_;

		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public const int ValueFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private ParameterData value_;

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		[DebuggerNonUserCode]
		public static MessageParser<ParameterWithKeyData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DCF390", Offset = "0x1DCE790", VA = "0x181DCF390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x1DCF2C0", Offset = "0x1DCE6C0", VA = "0x181DCF2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DCF3F0", Offset = "0x1DCE7F0", VA = "0x181DCF3F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DCF500", Offset = "0x1DCE900", VA = "0x181DCF500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public ParameterData Value
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF1A0", Offset = "0x1DCE5A0", VA = "0x181DCF1A0")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF1E0", Offset = "0x1DCE5E0", VA = "0x181DCF1E0")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData(ParameterWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEDC0", Offset = "0x1DCE1C0", VA = "0x181DCEDC0", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEED0", Offset = "0x1DCE2D0", VA = "0x181DCEED0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x1930AE0", VA = "0x1819316E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x1931810", Offset = "0x1930C10", VA = "0x181931810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF080", Offset = "0x1DCE480", VA = "0x181DCF080", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x1931A00", Offset = "0x1930E00", VA = "0x181931A00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1DCECC0", Offset = "0x1DCE0C0", VA = "0x181DCECC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEF90", Offset = "0x1DCE390", VA = "0x181DCEF90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class PropertyData : IMessage<PropertyData>, IMessage, IEquatable<PropertyData>, IDeepCloneable<PropertyData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private static readonly MessageParser<PropertyData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private CircuitTypeData type_;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const int GetFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private bool get_;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const int SetFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private bool set_;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[DebuggerNonUserCode]
		public static MessageParser<PropertyData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x1DD54D0", Offset = "0x1DD48D0", VA = "0x181DD54D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5400", Offset = "0x1DD4800", VA = "0x181DD5400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5530", Offset = "0x1DD4930", VA = "0x181DD5530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DebuggerNonUserCode]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EB0", Offset = "0x3C82B0", VA = "0x1803C8EB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EC0", Offset = "0x3C82C0", VA = "0x1803C8EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[DebuggerNonUserCode]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x43C910", Offset = "0x43BD10", VA = "0x18043C910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x43C920", Offset = "0x43BD20", VA = "0x18043C920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public PropertyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD53A0", Offset = "0x1DD47A0", VA = "0x181DD53A0")]
		[DebuggerNonUserCode]
		public PropertyData(PropertyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4E50", Offset = "0x1DD4250", VA = "0x181DD4E50", Slot = "9")]
		[DebuggerNonUserCode]
		public PropertyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4EE0", Offset = "0x1DD42E0", VA = "0x181DD4EE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4FA0", Offset = "0x1DD43A0", VA = "0x181DD4FA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PropertyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5010", Offset = "0x1DD4410", VA = "0x181DD5010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1DD51B0", Offset = "0x1DD45B0", VA = "0x181DD51B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5210", Offset = "0x1DD4610", VA = "0x181DD5210", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4D90", Offset = "0x1DD4190", VA = "0x181DD4D90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD50B0", Offset = "0x1DD44B0", VA = "0x181DD50B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class ReturnData : IMessage<ReturnData>, IMessage, IEquatable<ReturnData>, IDeepCloneable<ReturnData>
	{
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private static readonly MessageParser<ReturnData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public const int TypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private CircuitTypeData type_;

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		[DebuggerNonUserCode]
		public static MessageParser<ReturnData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5EB0", Offset = "0x1DD52B0", VA = "0x181DD5EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5DE0", Offset = "0x1DD51E0", VA = "0x181DD5DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5F10", Offset = "0x1DD5310", VA = "0x181DD5F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2F0", Offset = "0x3AC6F0", VA = "0x1803AD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		[DebuggerNonUserCode]
		public ReturnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEA20", Offset = "0x1DCDE20", VA = "0x181DCEA20")]
		[DebuggerNonUserCode]
		public ReturnData(ReturnData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5AE0", Offset = "0x1DD4EE0", VA = "0x181DD5AE0", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5B70", Offset = "0x1DD4F70", VA = "0x181DD5B70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xF1DF70", Offset = "0xF1D370", VA = "0x180F1DF70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xF1E0A0", Offset = "0xF1D4A0", VA = "0x180F1E0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5CC0", Offset = "0x1DD50C0", VA = "0x181DD5CC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xF1E350", Offset = "0xF1D750", VA = "0x180F1E350", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5A20", Offset = "0x1DD4E20", VA = "0x181DD5A20", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5C00", Offset = "0x1DD5000", VA = "0x181DD5C00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class ReturnWithKeyData : IMessage<ReturnWithKeyData>, IMessage, IEquatable<ReturnWithKeyData>, IDeepCloneable<ReturnWithKeyData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private static readonly MessageParser<ReturnWithKeyData> _parser;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const int KeyFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private string key_;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const int ValueFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private ReturnData value_;

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[DebuggerNonUserCode]
		public static MessageParser<ReturnWithKeyData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x1DD66F0", Offset = "0x1DD5AF0", VA = "0x181DD66F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x1DD6620", Offset = "0x1DD5A20", VA = "0x181DD6620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x1DD6750", Offset = "0x1DD5B50", VA = "0x181DD6750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x1DD6860", Offset = "0x1DD5C60", VA = "0x181DD6860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public ReturnData Value
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6500", Offset = "0x1DD5900", VA = "0x181DD6500")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6540", Offset = "0x1DD5940", VA = "0x181DD6540")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData(ReturnWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6120", Offset = "0x1DD5520", VA = "0x181DD6120", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6230", Offset = "0x1DD5630", VA = "0x181DD6230", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x1930AE0", VA = "0x1819316E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x1931810", Offset = "0x1930C10", VA = "0x181931810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1DD63E0", Offset = "0x1DD57E0", VA = "0x181DD63E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1931A00", Offset = "0x1930E00", VA = "0x181931A00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6020", Offset = "0x1DD5420", VA = "0x181DD6020", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1DD62F0", Offset = "0x1DD56F0", VA = "0x181DD62F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class TypeParameterReferenceTypeData : IMessage<TypeParameterReferenceTypeData>, IMessage, IEquatable<TypeParameterReferenceTypeData>, IDeepCloneable<TypeParameterReferenceTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private static readonly MessageParser<TypeParameterReferenceTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[DebuggerNonUserCode]
		public static MessageParser<TypeParameterReferenceTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA430", Offset = "0x1DD9830", VA = "0x181DDA430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA360", Offset = "0x1DD9760", VA = "0x181DDA360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA490", Offset = "0x1DD9890", VA = "0x181DDA490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA5A0", Offset = "0x1DD99A0", VA = "0x181DDA5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA320", Offset = "0x1DD9720", VA = "0x181DDA320")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA2B0", Offset = "0x1DD96B0", VA = "0x181DDA2B0")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData(TypeParameterReferenceTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA000", Offset = "0x1DD9400", VA = "0x181DDA000", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA090", Offset = "0x1DD9490", VA = "0x181DDA090", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD60", Offset = "0x3AB160", VA = "0x1803ABD60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterReferenceTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE90", Offset = "0x3AB290", VA = "0x1803ABE90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA190", Offset = "0x1DD9590", VA = "0x181DDA190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x3AC130", Offset = "0x3AB530", VA = "0x1803AC130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9F40", Offset = "0x1DD9340", VA = "0x181DD9F40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA120", Offset = "0x1DD9520", VA = "0x181DDA120", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class TypeParameterTypeData : IMessage<TypeParameterTypeData>, IMessage, IEquatable<TypeParameterTypeData>, IDeepCloneable<TypeParameterTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private static readonly MessageParser<TypeParameterTypeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public const int ConstraintFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private CircuitTypeData constraint_;

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		[DebuggerNonUserCode]
		public static MessageParser<TypeParameterTypeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x1DDAC20", Offset = "0x1DDA020", VA = "0x181DDAC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x1DDAB50", Offset = "0x1DD9F50", VA = "0x181DDAB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x1DDAC80", Offset = "0x1DDA080", VA = "0x181DDAC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x3A8150", Offset = "0x3A7550", VA = "0x1803A8150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x3A8140", Offset = "0x3A7540", VA = "0x1803A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x1DDAD90", Offset = "0x1DDA190", VA = "0x181DDAD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public CircuitTypeData Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1DDAB10", Offset = "0x1DD9F10", VA = "0x181DDAB10")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1DDAA80", Offset = "0x1DD9E80", VA = "0x181DDAA80")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData(TypeParameterTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA6F0", Offset = "0x1DD9AF0", VA = "0x181DDA6F0", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA7B0", Offset = "0x1DD9BB0", VA = "0x181DDA7B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x1930AE0", VA = "0x1819316E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1931810", Offset = "0x1930C10", VA = "0x181931810", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA960", Offset = "0x1DD9D60", VA = "0x181DDA960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1931A00", Offset = "0x1930E00", VA = "0x181931A00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA5F0", Offset = "0x1DD99F0", VA = "0x181DDA5F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA870", Offset = "0x1DD9C70", VA = "0x181DDA870", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public static class VariableNodeDataReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0x1DE07A0", Offset = "0x1DDFBA0", VA = "0x181DE07A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0130", Offset = "0x1DDF530", VA = "0x181DE0130")]
		static VariableNodeDataReflection()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class VariableNodeData : IMessage<VariableNodeData>, IMessage, IEquatable<VariableNodeData>, IDeepCloneable<VariableNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private static readonly MessageParser<VariableNodeData> _parser;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const int IsSymbolicNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private bool isSymbolicName_;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public const int SymbolNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private string symbolName_;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public const int SymbolTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private CircuitTypeData symbolType_;

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		[DebuggerNonUserCode]
		public static MessageParser<VariableNodeData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x1DE0FC0", Offset = "0x1DE03C0", VA = "0x181DE0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x1DE0EF0", Offset = "0x1DE02F0", VA = "0x181DE0EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x1DE1020", Offset = "0x1DE0420", VA = "0x181DE1020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[DebuggerNonUserCode]
		public bool IsSymbolicName
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x3A8D50", Offset = "0x3A8150", VA = "0x1803A8D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x3A8D40", Offset = "0x3A8140", VA = "0x1803A8D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[DebuggerNonUserCode]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x1DE1120", Offset = "0x1DE0520", VA = "0x181DE1120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[DebuggerNonUserCode]
		public CircuitTypeData SymbolType
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x3AD2E0", Offset = "0x3AC6E0", VA = "0x1803AD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0E20", Offset = "0x1DE0220", VA = "0x181DE0E20")]
		[DebuggerNonUserCode]
		public VariableNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0E60", Offset = "0x1DE0260", VA = "0x181DE0E60")]
		[DebuggerNonUserCode]
		public VariableNodeData(VariableNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE08D0", Offset = "0x1DDFCD0", VA = "0x181DE08D0", Slot = "9")]
		[DebuggerNonUserCode]
		public VariableNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0990", Offset = "0x1DDFD90", VA = "0x181DE0990", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0A50", Offset = "0x1DDFE50", VA = "0x181DE0A50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(VariableNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0AC0", Offset = "0x1DDFEC0", VA = "0x181DE0AC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0C50", Offset = "0x1DE0050", VA = "0x181DE0C50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0CB0", Offset = "0x1DE00B0", VA = "0x181DE0CB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0800", Offset = "0x1DDFC00", VA = "0x181DE0800", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0B60", Offset = "0x1DDFF60", VA = "0x181DE0B60", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
namespace CircuitsV2.CircuitNodes
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public interface ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DeserializeFromProtobuf(TProto protobufData);
	}
}
namespace CircuitsV2.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class CircuitNodeUtil
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public enum TagSearchMethod
		{
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			ALL,
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			ANY
		}

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static Tuple<string, Guid>[] orderedOptions;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static List<string> orderedTags;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_ABSOLUTEVALUENODE;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_ADDNODE;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_ANDNODE;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_BOOLEXTERNALVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_BOOLINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_BRANCHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_BREAKTUPLE;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_CIRCUITBOARD;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_CIRCUITBOARD__INNERCONTEXTENTRYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_CIRCUITBOARD__INNERCONTEXTEXITNODE;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_DEBUGLOGNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_DELAYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_DEMONODES_EQUALSNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_DEMONODES_TOSTRINGNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_DIVIDENODE;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_EVENTRECEIVERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_EVENTSENDERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FLOATEXTERNALVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FLOATINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FOREACHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FOREACHNODE__BREAKEXITNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FOREACHNODE__INNERCONTEXTENTRYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FORNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FORNODE__BREAKEXITNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_FORNODE__INNERCONTEXTENTRYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_GETELEMENTNODE;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_GETLISTCOUNTNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_HASAUTHORITYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_IFEXPRESSIONNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_INTEXTERNALVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_INTINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_INTSWITCHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MAKEDICTIONARYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MAKELISTNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MAKETUPLE;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MAXNODE;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MINNODE;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MODULONODE;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_MULTIPLYNODE;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NANDNODE;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NORNODE;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NOTNODE;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NUMBERCOMPARISONS_GREATERTHANNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NUMBERCOMPARISONS_GREATERTHANOREQUALNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NUMBERCOMPARISONS_LESSTHANNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_NUMBERCOMPARISONS_LESSTHANOREQUALNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_ORNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_DAMAGEPLAYERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_GETALLPLAYERSNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_GETPLAYERHEALTHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_GETPLAYERISLOCALNODE;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_GETPLAYERNAMENODE;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_GETPLAYERSHIELDNODE;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_INVALIDPLAYERVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_LOCALPLAYERVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_PROMPTLOCALPLAYERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_PLAYERNODES_RESETPLAYERHEALTHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_POWERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_RANDOMFLOATGENERATORNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_RANDOMINTEGERGENERATORNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SETVALUENODE;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SHOWNOTIFICATIONNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_STRINGEXTERNALVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_STRINGFORMATNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_STRINGINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_STRINGSWITCHNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SUBTRACTNODE;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCEDINMEMORYBOOLVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCEDINMEMORYFLOATVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCEDINMEMORYINTVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCEDINMEMORYSTRINGVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCHEDEVENTSENDERNODE;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_SYNCHEDPLAYERINMEMORYVARIABLENODE;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_CEILTOINTNODE;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_FLOORTOINTNODE;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_INTTOFLOATNODE;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_PARSEBOOLNODE;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_PARSEFLOATNODE;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_PARSEINTNODE;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_TYPECONVERSIONS_ROUNDTOINTNODE;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private static readonly Guid CIRCUITSV2_GRAPH_NODES_VALUECHANGEDNODE;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly Dictionary<Guid, Type> guidToTypeLookup;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly Dictionary<Type, Guid> typeToGuidLookup;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly Dictionary<Guid, Func<CircuitContext, Guid, Node>> nodeConstructorLookup;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private static readonly Dictionary<Guid, Func<CircuitContext, Guid, Guid?, Node>> contextNodeConstructorLookup;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private static readonly Dictionary<Type, string> typeToFriendlyNameLookup;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private static readonly Dictionary<Type, HashSet<string>> typeToTagsLookup;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private static readonly Dictionary<string, int> tagsToCountLookup;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private static readonly List<Guid> playerCreatableNodes;

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public static IReadOnlyList<Guid> AllPlayerCreatableNodeTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x1679A40", Offset = "0x1678E40", VA = "0x181679A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xF40480", Offset = "0xF3F880", VA = "0x180F40480")]
		public static TNode CreateNode<TNode>(CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId) where TNode : Node
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x166D550", Offset = "0x166C950", VA = "0x18166D550")]
		internal static Node CreateNodeForDeserialize(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x166D610", Offset = "0x166CA10", VA = "0x18166D610")]
		public static Node CreateNode(Type nodeType, CircuitContext context, [Optional] Guid? nodeGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x166D8E0", Offset = "0x166CCE0", VA = "0x18166D8E0")]
		public static Node CreateNode(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId, [Optional] Vector3? localPosition, [Optional] Quaternion? localRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x166D1E0", Offset = "0x166C5E0", VA = "0x18166D1E0")]
		private static Node ConstructNodeInternal(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x166E4B0", Offset = "0x166D8B0", VA = "0x18166E4B0")]
		public static Guid GetTypeId(Type type)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x166DD60", Offset = "0x166D160", VA = "0x18166DD60")]
		public static Type GetNodeType(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x166DAA0", Offset = "0x166CEA0", VA = "0x18166DAA0")]
		public static Tuple<string, Guid>[] GetNodeTypeOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x166E5A0", Offset = "0x166D9A0", VA = "0x18166E5A0")]
		public static List<string> OrderedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x166DE70", Offset = "0x166D270", VA = "0x18166DE70")]
		public static void GetNodesWithTags(TagSearchMethod tagSearchMethod, IEnumerable<string> activeTags, out HashSet<Type> filteredTypes, out IList<string> filteredTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x166E7F0", Offset = "0x166DBF0", VA = "0x18166E7F0")]
		private static bool TypeHasTags(TagSearchMethod tagSearchMethod, Type t, IEnumerable<string> activeTags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class Box<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private T value;

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A69820", Offset = "0x1A68C20", VA = "0x181A69820")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB60", Offset = "0x3AAF60", VA = "0x1803ABB60")]
		public void Set(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A69830", Offset = "0x1A68C30", VA = "0x181A69830")]
		public Box(in T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x111C370", Offset = "0x111B770", VA = "0x18111C370")]
		public static Box<T> New<T>(in T value)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class SetDictionary<TKey, TVal>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private readonly Dictionary<TKey, HashSet<TVal>> dictionary;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2568510", Offset = "0x2567910", VA = "0x182568510")]
		public bool TryGetValue(TKey key, out HashSet<TVal> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2568230", Offset = "0x2567630", VA = "0x182568230")]
		public void Add(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2568340", Offset = "0x2567740", VA = "0x182568340")]
		public void Remove(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2568310", Offset = "0x2567710", VA = "0x182568310")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2568550", Offset = "0x2567950", VA = "0x182568550")]
		public SetDictionary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class SortedList<TVal> : IList<TVal>, ICollection<TVal>, IEnumerable<TVal>, IEnumerable, IReadOnlyList<TVal>, IReadOnlyCollection<TVal>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private readonly List<TVal> listImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly Func<TVal, TVal, int> valueComparer;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0xE784D0", Offset = "0xE778D0", VA = "0x180E784D0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public TVal this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2568BB0", Offset = "0x2567FB0", VA = "0x182568BB0", Slot = "18")]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2568C00", Offset = "0x2568000", VA = "0x182568C00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2568B20", Offset = "0x2567F20", VA = "0x182568B20")]
		public SortedList(Func<TVal, TVal, int> valueComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2568920", Offset = "0x2567D20", VA = "0x182568920", Slot = "16")]
		public IEnumerator<TVal> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2568A80", Offset = "0x2567E80", VA = "0x182568A80", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x25685D0", Offset = "0x25679D0", VA = "0x1825685D0", Slot = "11")]
		public void Add(TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2568310", Offset = "0x2567710", VA = "0x182568310", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2568830", Offset = "0x2567C30", VA = "0x182568830", Slot = "13")]
		public bool Contains(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2568870", Offset = "0x2567C70", VA = "0x182568870", Slot = "14")]
		public void CopyTo(TVal[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2568A40", Offset = "0x2567E40", VA = "0x182568A40", Slot = "15")]
		public bool Remove(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x1199CF0", Offset = "0x11990F0", VA = "0x181199CF0", Slot = "6")]
		public int IndexOf(TVal item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x25689F0", Offset = "0x2567DF0", VA = "0x1825689F0", Slot = "7")]
		public void Insert(int index, TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x101BB10", Offset = "0x101AF10", VA = "0x18101BB10", Slot = "8")]
		public void RemoveAt(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EditableValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3A85A0", Offset = "0x3A79A0", VA = "0x1803A85A0")]
		public EditableValueAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddNamedPort : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public readonly string FilterMethod;

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x665350", Offset = "0x664750", VA = "0x180665350")]
		public EditableAddNamedPort([Optional] string filterMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecOutput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x3A85A0", Offset = "0x3A79A0", VA = "0x1803A85A0")]
		public EditableAddExecOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecInput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x3A85A0", Offset = "0x3A79A0", VA = "0x1803A85A0")]
		public EditableAddExecInput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public static class Empties
	{
		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public static IReadOnlyDictionary<string, Property> EmptyPropertyTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x167B590", Offset = "0x167A990", VA = "0x18167B590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public static class DictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xF412C0", Offset = "0xF406C0", VA = "0x180F412C0")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, [Optional] TVal defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xF410C0", Offset = "0xF404C0", VA = "0x180F410C0")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, Func<TVal> defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1461970", Offset = "0x1460D70", VA = "0x181461970")]
		public static void AddToNestedList<K, V>(this IDictionary<K, List<V>> self, K key, V value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x14616B0", Offset = "0x1460AB0", VA = "0x1814616B0")]
		public static void AddOrUpdate<K, V>(this IDictionary<K, V> self, K key, V value, Func<V, V, V> updateOp)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class EnumerableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		private class FuncEqualityComparer<T> : IEqualityComparer<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private readonly Func<T, T, bool> equalsImpl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			private readonly Func<T, int> getHashCodeImpl;

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2558FE0", Offset = "0x25583E0", VA = "0x182558FE0", Slot = "4")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x198C190", Offset = "0x198B590", VA = "0x18198C190", Slot = "5")]
			public int GetHashCode(T obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x16DF7D0", Offset = "0x16DEBD0", VA = "0x1816DF7D0")]
			public FuncEqualityComparer(Func<T, T, bool> equalsImpl, Func<T, int> getHashCodeImpl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private sealed class <Extend>d__8<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			private IEnumerable<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public IEnumerable<T> <>3__self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			private IEnumerable<U> other;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public IEnumerable<U> <>3__other;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			private T with;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public T <>3__with;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private IEnumerator<T> <selfEnumerator>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private IEnumerator<U> <otherEnumerator>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700017A")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000743")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000745")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xE7BF60", Offset = "0xE7B360", VA = "0x180E7BF60")]
			[DebuggerHidden]
			public <Extend>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x1A78C90", Offset = "0x1A78090", VA = "0x181A78C90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x1A788E0", Offset = "0x1A77CE0", VA = "0x181A788E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x1A78D60", Offset = "0x1A78160", VA = "0x181A78D60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x1A78DB0", Offset = "0x1A781B0", VA = "0x181A78DB0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x1A78C40", Offset = "0x1A78040", VA = "0x181A78C40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1A78B80", Offset = "0x1A77F80", VA = "0x181A78B80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x102AA40", Offset = "0x1029E40", VA = "0x18102AA40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <MarkLast>d__18<T> : IEnumerable<(T, bool)>, IEnumerable, IEnumerator<(T, bool)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x292B0", Offset = "0x286B0")]
			private (T, bool) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private IEnumerable<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public IEnumerable<T> <>3__self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			private IEnumerator<T> <enumerator>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700017C")]
			private (T, bool) System.Collections.Generic.IEnumerator<(TValue,System.BooleanIsLast)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000755")]
				[Cpp2IlInjected.Address(RVA = "0x3F41E0", Offset = "0x3F35E0", VA = "0x1803F41E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((T, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000757")]
				[Cpp2IlInjected.Address(RVA = "0x2569520", Offset = "0x2568920", VA = "0x182569520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1ED99B0", Offset = "0x1ED8DB0", VA = "0x181ED99B0")]
			[DebuggerHidden]
			public <MarkLast>d__18(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2569A40", Offset = "0x2568E40", VA = "0x182569A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2569730", Offset = "0x2568B30", VA = "0x182569730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2569AD0", Offset = "0x2568ED0", VA = "0x182569AD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x25699F0", Offset = "0x2568DF0", VA = "0x1825699F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x2569380", Offset = "0x2568780", VA = "0x182569380", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, bool)> System.Collections.Generic.IEnumerable<(TValue,System.BooleanIsLast)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x129CA90", Offset = "0x129BE90", VA = "0x18129CA90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class <FormCurrentNextPairs>d__19<T> : IEnumerable<(T, T)>, IEnumerable, IEnumerator<(T, T)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x29F90", Offset = "0x29390")]
			private (T, T) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private IEnumerable<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public IEnumerable<T> <>3__self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private IEnumerator<T> <enumerator>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700017E")]
			private (T, T) System.Collections.Generic.IEnumerator<(TCurrent,TNext)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0x3F41E0", Offset = "0x3F35E0", VA = "0x1803F41E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((T, T));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0x2569520", Offset = "0x2568920", VA = "0x182569520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x1ED99B0", Offset = "0x1ED8DB0", VA = "0x181ED99B0")]
			[DebuggerHidden]
			public <FormCurrentNextPairs>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2569600", Offset = "0x2568A00", VA = "0x182569600", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x2568CA0", Offset = "0x25680A0", VA = "0x182568CA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x2569690", Offset = "0x2568A90", VA = "0x182569690")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2569480", Offset = "0x2568880", VA = "0x182569480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2569380", Offset = "0x2568780", VA = "0x182569380", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, T)> System.Collections.Generic.IEnumerable<(TCurrent,TNext)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x129CA90", Offset = "0x129BE90", VA = "0x18129CA90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		[CompilerGenerated]
		private sealed class <Unique>d__25<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			private IEnumerable<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public IEnumerable<T> <>3__self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private Func<T, U> uniqueSelector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public Func<T, U> <>3__uniqueSelector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private HashSet<U> <seen>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			private IEnumerator<T> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000180")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600076F")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000181")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000771")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xE7BF60", Offset = "0xE7B360", VA = "0x180E7BF60")]
			[DebuggerHidden]
			public <Unique>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x256B4D0", Offset = "0x256A8D0", VA = "0x18256B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x256AE20", Offset = "0x256A220", VA = "0x18256AE20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x256B690", Offset = "0x256AA90", VA = "0x18256B690")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x256B2B0", Offset = "0x256A6B0", VA = "0x18256B2B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x256B200", Offset = "0x256A600", VA = "0x18256B200", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x23573C0", Offset = "0x23567C0", VA = "0x1823573C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x13D1CA0", Offset = "0x13D10A0", VA = "0x1813D1CA0")]
		public static U AmountSwitch<U, T>(this IEnumerable<T> self, Func<U> zero, Func<T, U> one, Func<IEnumerable<T>, U> many)
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x167B5F0", Offset = "0x167A9F0", VA = "0x18167B5F0")]
		public static void CallAll(this IEnumerable<Action> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x11124D0", Offset = "0x11118D0", VA = "0x1811124D0")]
		public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] items)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x15C14A0", Offset = "0x15C08A0", VA = "0x1815C14A0")]
		public static string Delimit<T>(this IEnumerable<T> self, string delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11126D0", Offset = "0x1111AD0", VA = "0x1811126D0")]
		public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> self, Func<T, U> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xC03A20", Offset = "0xC02E20", VA = "0x180C03A20")]
		[IteratorStateMachine(typeof(<Extend>d__8<, >))]
		public static IEnumerable<T> Extend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x12D1720", Offset = "0x12D0B20", VA = "0x1812D1720")]
		public static int FirstIndexOf<T>(this IEnumerable<T> self, Func<T, bool> pred)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1095AC0", Offset = "0x1094EC0", VA = "0x181095AC0")]
		public static T FirstOr<T>(this IEnumerable<T> self, T optB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1462A60", Offset = "0x1461E60", VA = "0x181462A60")]
		public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x12D19F0", Offset = "0x12D0DF0", VA = "0x1812D19F0")]
		public static int SequenceGetHashCode<T>(this IEnumerable<T> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x11DB180", Offset = "0x11DA580", VA = "0x1811DB180")]
		public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x11DB030", Offset = "0x11DA430", VA = "0x1811DB030")]
		public static bool Multiple<T>(this IEnumerable<T> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x11124D0", Offset = "0x11118D0", VA = "0x1811124D0")]
		public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xBF07C0", Offset = "0xBEFBC0", VA = "0x180BF07C0")]
		[IteratorStateMachine(typeof(<MarkLast>d__18<>))]
		public static IEnumerable<(T, bool)> MarkLast<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xBF07C0", Offset = "0xBEFBC0", VA = "0x180BF07C0")]
		[IteratorStateMachine(typeof(<FormCurrentNextPairs>d__19<>))]
		public static IEnumerable<(T, T)> FormCurrentNextPairs<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x1112820", Offset = "0x1111C20", VA = "0x181112820")]
		public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x111C3D0", Offset = "0x111B7D0", VA = "0x18111C3D0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x111C3D0", Offset = "0x111B7D0", VA = "0x18111C3D0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x27380", Offset = "0x26780")] this IEnumerable<(TKey, TValue)> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x111C370", Offset = "0x111B770", VA = "0x18111C370")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xBEEFC0", Offset = "0xBEE3C0", VA = "0x180BEEFC0")]
		[IteratorStateMachine(typeof(<Unique>d__25<, >))]
		public static IEnumerable<T> Unique<T, U>(this IEnumerable<T> self, Func<T, U> uniqueSelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x11120D0", Offset = "0x11114D0", VA = "0x1811120D0")]
		public static IEnumerable<(T, U)> Zip<T, U>(this IEnumerable<T> self, IEnumerable<U> other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xBEF050", Offset = "0xBEE450", VA = "0x180BEF050")]
		public static IEnumerable<V> ZipExtend<V, T, U>(this IEnumerable<T> self, IEnumerable<U> other, Func<T, U, V> zipper, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x1112850", Offset = "0x1111C50", VA = "0x181112850")]
		public static IEnumerable<(T, U)> ZipExtend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class EquatableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x11DB310", Offset = "0x11DA710", VA = "0x1811DB310")]
		public static bool EquatableEquals<T>(this T self, object obj) where T : IEquatable<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public static class GenericExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class <ToEnumerable>d__0<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			private T self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public T <>3__self;

			[Cpp2IlInjected.Token(Token = "0x17000182")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000781")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000183")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000783")]
				[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xE7BF60", Offset = "0xE7B360", VA = "0x180E7BF60")]
			[DebuggerHidden]
			public <ToEnumerable>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x198C390", Offset = "0x198B790", VA = "0x18198C390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x256A550", Offset = "0x2569950", VA = "0x18256A550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x198C3C0", Offset = "0x198B7C0", VA = "0x18198C3C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x11A84E0", Offset = "0x11A78E0", VA = "0x1811A84E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class <ToEnumerableInf>d__1<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private T self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public T <>3__self;

			[Cpp2IlInjected.Token(Token = "0x17000184")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0x3AD320", Offset = "0x3AC720", VA = "0x1803AD320", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000185")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x11AF0E0", Offset = "0x11AE4E0", VA = "0x1811AF0E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x1EDABC0", Offset = "0x1ED9FC0", VA = "0x181EDABC0")]
			[DebuggerHidden]
			public <ToEnumerableInf>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x256A3A0", Offset = "0x25697A0", VA = "0x18256A3A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x256A480", Offset = "0x2569880", VA = "0x18256A480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x256A3E0", Offset = "0x25697E0", VA = "0x18256A3E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x11A84E0", Offset = "0x11A78E0", VA = "0x1811A84E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x1112AA0", Offset = "0x1111EA0", VA = "0x181112AA0")]
		[IteratorStateMachine(typeof(<ToEnumerable>d__0<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x1112A30", Offset = "0x1111E30", VA = "0x181112A30")]
		[IteratorStateMachine(typeof(<ToEnumerableInf>d__1<>))]
		public static IEnumerable<T> ToEnumerableInf<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xF4A290", Offset = "0xF49690", VA = "0x180F4A290")]
		public static T[] ToOneItemArray<T>(this T self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public static class IListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x10989F0", Offset = "0x1097DF0", VA = "0x1810989F0")]
		public static T Last<T>(this IList<T> self)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x1098C80", Offset = "0x1098080", VA = "0x181098C80")]
		public static T SetLast<T>(this IList<T> self, T value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x14685A0", Offset = "0x14679A0", VA = "0x1814685A0")]
		public static void RemoveFirstWhere<T>(this IList<T> self, Func<T, bool> pred)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x1468620", Offset = "0x1467A20", VA = "0x181468620")]
		public static void RemoveLast<T>(this IList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x1098E30", Offset = "0x1098230", VA = "0x181098E30")]
		public static T TakeLast<T>(this IList<T> self)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public static class IReadOnlyCollectionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x11DC9F0", Offset = "0x11DBDF0", VA = "0x1811DC9F0")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public static class IReadOnlyDictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x13D54A0", Offset = "0x13D48A0", VA = "0x1813D54A0")]
		public static V GetValueOrDefault<V, K>(this IReadOnlyDictionary<K, V> self, K key)
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x15C3A00", Offset = "0x15C2E00", VA = "0x1815C3A00")]
		public static V? GetValueOrNull<V, K>(this IReadOnlyDictionary<K, V> self, K key) where V : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class IReadOnlyListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x1098E80", Offset = "0x1098280", VA = "0x181098E80")]
		public static T GetValueOrDefault<T>(this IReadOnlyList<T> self, int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2F30", VA = "0x1815C3B30")]
		public static T? GetValueOrNull<T>(this IReadOnlyList<T> self, int index) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public static class KeyValuePairExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x1469970", Offset = "0x1468D70", VA = "0x181469970")]
		public static (TKey, TValue) Destructure<TKey, TValue>(this KeyValuePair<TKey, TValue> self)
		{
			return default((TKey, TValue));
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x11124D0", Offset = "0x11118D0", VA = "0x1811124D0")]
		public static IEnumerable<(TKey, TValue)> Destructure<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFF050", Offset = "0x1FFE450", VA = "0x181FFF050")]
		public static KeyValuePair<TKey, UValue> Revalue<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> self, UValue value)
		{
			return default(KeyValuePair<TKey, UValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public static class MapFieldExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x146CEA0", Offset = "0x146C2A0", VA = "0x18146CEA0")]
		public static void AddRange<K, V>(this MapField<K, V> self, IEnumerable<KeyValuePair<K, V>> values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x167CA00", Offset = "0x167BE00", VA = "0x18167CA00")]
		private static byte[] GetIntBytes(int intValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x167C3C0", Offset = "0x167B7C0", VA = "0x18167C3C0")]
		public static Guid Combine(params Guid[] guidsToCombine)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x167C930", Offset = "0x167BD30", VA = "0x18167C930")]
		public static Guid Create(Guid namespaceId, int index, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x167C530", Offset = "0x167B930", VA = "0x18167C530")]
		public static Guid Create(Guid namespaceId, Guid nameGuid, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x167C8A0", Offset = "0x167BCA0", VA = "0x18167C8A0")]
		public static Guid Create(Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x167C5A0", Offset = "0x167B9A0", VA = "0x18167C5A0")]
		private static Guid Create(Guid namespaceId, byte[] nameBytes, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x167CA80", Offset = "0x167BE80", VA = "0x18167CA80")]
		private static void SwapByteOrder(byte[] guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x167CC30", Offset = "0x167C030", VA = "0x18167CC30")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class InternalNodeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A85A0", Offset = "0x3A79A0", VA = "0x1803A85A0")]
		public InternalNodeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public static class NodeNameHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x167CEC0", Offset = "0x167C2C0", VA = "0x18167CEC0")]
		public static string GetFriendlyNodeName(Type nodeType)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public struct PerfScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x1358E0", Offset = "0x134CE0", VA = "0x1801358E0")]
		public PerfScope(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x1358E0", Offset = "0x134CE0", VA = "0x1801358E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public sealed class RateLimiter
	{
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private const float ONE_SECOND = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly ITimeProvider timeProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly int maxPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly Queue<float> timestampBuffer;

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public int CurrentPerSecond
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x167E030", Offset = "0x167D430", VA = "0x18167E030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x167DEE0", Offset = "0x167D2E0", VA = "0x18167DEE0")]
		public RateLimiter(ITimeProvider timeProvider, int maxPerSecond, int initialSize = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x167DC00", Offset = "0x167D000", VA = "0x18167DC00")]
		public bool CanExecute()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167D060", VA = "0x18167DC60")]
		public bool ExecuteIfPossible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x167DD30", Offset = "0x167D130", VA = "0x18167DD30")]
		public void MarkExecution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x167DDA0", Offset = "0x167D1A0", VA = "0x18167DDA0")]
		private void TrimExpiredValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B3940", Offset = "0x4B2D40", VA = "0x1804B3940")]
		public static T[] NewArray<T>(params T[] @params)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x20131E0", Offset = "0x20125E0", VA = "0x1820131E0")]
		public static KeyValuePair<TKey, TValue> NewKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x11E63A0", Offset = "0x11E57A0", VA = "0x1811E63A0")]
		public static bool IsNot<T>(this object self, out T result)
		{
			return default(bool);
		}
	}
}
namespace CircuitsV2.Utilities.StringUtils
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public static class StringNameConventions
	{
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static readonly Regex portNameRegex;

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x167F260", Offset = "0x167E660", VA = "0x18167F260")]
		public static bool IsValidPortName(string name)
		{
			return default(bool);
		}
	}
}
namespace CircuitsV2.Utilities.InternalTools
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class VisibleForTestingAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A85A0", Offset = "0x3A79A0", VA = "0x1803A85A0")]
		public VisibleForTestingAttribute()
		{
		}
	}
}
namespace CircuitsV2.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public class CircuitDataIdRemapper
	{
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly CircuitDataIdRemapper DoNotRemapRemapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private readonly Dictionary<ByteString, ByteString> idMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private readonly Guid remapId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private readonly bool remapIds;

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x19307B0", Offset = "0x192FBB0", VA = "0x1819307B0")]
		public CircuitDataIdRemapper(bool remapIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x1930720", Offset = "0x192FB20", VA = "0x181930720")]
		public CircuitDataIdRemapper(bool remapIds, Guid remapId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x19304E0", Offset = "0x192F8E0", VA = "0x1819304E0")]
		public ByteString RemapByteStringId(ByteString originalByteString, bool onlyIfAlreadyMapped = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class CircuitTemplateHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x193A050", Offset = "0x1939450", VA = "0x18193A050")]
		public static CircuitContextData RemapTemplate(CircuitContext intoContext, CircuitContextData originalTemplate, Guid remapId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x193A330", Offset = "0x1939730", VA = "0x18193A330")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x193A3D0", Offset = "0x19397D0", VA = "0x18193A3D0")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData, Matrix4x4 transformMatrix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x1938530", Offset = "0x1937930", VA = "0x181938530")]
		public static void AddInventionTracking(CircuitContextData templateData, ByteString instanceIdAsByteString, long inventionId, int versionNum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x19399F0", Offset = "0x1938DF0", VA = "0x1819399F0")]
		public static void RemapTemplateIds(CircuitContext intoContext, CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x19395D0", Offset = "0x19389D0", VA = "0x1819395D0")]
		private static void RemapNodeInnerContextIdsRecursive(CircuitDataIdRemapper remapper, CircuitContextData context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x1938A10", Offset = "0x1937E10", VA = "0x181938A10")]
		private static void RemapContextIdsRecursive(CircuitDataIdRemapper remapper, RepeatedField<CircuitContextData> contexts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x1938F90", Offset = "0x1938390", VA = "0x181938F90")]
		private static void RemapInventionInstanceIds(CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x1939410", Offset = "0x1938810", VA = "0x181939410")]
		private static void RemapNodeDataEventIds(IEnumerable<CircuitNodeData> nodeDatas, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x1938C90", Offset = "0x1938090", VA = "0x181938C90")]
		private static void RemapEventRegistrationList(IList<EventRegistrationData> registrationList, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x193A170", Offset = "0x1939570", VA = "0x18193A170")]
		private static void RemapUsesEventIds(CircuitContextData circuitContextData, CircuitDataIdRemapper remapper)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public static class SerializationHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		public delegate TCircuitObject Create<TCircuitObject, TProtoElement>(Guid objectId, TProtoElement protobufData) where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage;

		[Cpp2IlInjected.Token(Token = "0x2000118")]
		public delegate void Dispose<TCircuitObject, TProtoElement>(TCircuitObject objectId) where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage;

		[Cpp2IlInjected.Token(Token = "0x2000119")]
		public delegate void Initialize<TCircuitObject>(TCircuitObject obj);

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x125E4D0", Offset = "0x125D8D0", VA = "0x18125E4D0")]
		public static Create<TCircuitObject, TProtoElement> DoNotCreate<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x125E4D0", Offset = "0x125D8D0", VA = "0x18125E4D0")]
		public static Dispose<TCircuitObject, TProtoElement> IDisposableDispose<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x14739C0", Offset = "0x1472DC0", VA = "0x1814739C0")]
		public static void MergeDisposablesProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1473A40", Offset = "0x1472E40", VA = "0x181473A40")]
		public static void MergeProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, Dispose<TCircuitObject, TProtoElement> dispose, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x1473620", Offset = "0x1472A20", VA = "0x181473620")]
		public static void AppendProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}
	}
}
namespace CircuitsV2.Injection
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public sealed class Dependencies
	{
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		public class Binder<TInterface>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			private readonly Dependencies dependencies;

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x102AA00", Offset = "0x1029E00", VA = "0x18102AA00")]
			public Binder(Dependencies dependencies)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x124D770", Offset = "0x124CB70", VA = "0x18124D770")]
			public Dependencies To<TImpl>(TImpl implementation, [Optional] string name) where TImpl : TInterface
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct InjectionKey
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			private readonly Type injectedResourceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private readonly string injectedResourceName;

			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x141460", Offset = "0x140860", VA = "0x180141460")]
			public InjectionKey(Type injectedResourceType, string injectedResourceName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x22E240", Offset = "0x22D640", VA = "0x18022E240")]
			public bool Equals(InjectionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x22E180", Offset = "0x22D580", VA = "0x18022E180", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x22E2B0", Offset = "0x22D6B0", VA = "0x18022E2B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly Dictionary<InjectionKey, object> injectedInstancesDictionary;

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x111C370", Offset = "0x111B770", VA = "0x18111C370")]
		public Binder<TInterface> Bind<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xF40C30", Offset = "0xF40030", VA = "0x180F40C30")]
		public TInterface GetDependency<TInterface>([Optional] string name)
		{
			return (TInterface)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x193CC00", Offset = "0x193C000", VA = "0x18193CC00")]
		public Dependencies()
		{
		}
	}
}
namespace CircuitsV2.InjectedDependencies
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface ICircuitGameTeamManager
	{
	}
}
namespace CircuitsV2.Context
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public interface IMemory
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object GetReference(Guid id);

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SetReference(Guid id, object value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public interface IVariableChangeListener
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnVariableChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public static class MemoryDelegates
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		public delegate CircuitSignal ValueGetter(Memory memory, Guid memoryAddress);

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		public delegate bool ValueSetter(Memory memory, Guid memoryAddress, CircuitSignal newValue);

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static ValueGetter GetBoolean;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static ValueSetter SetBoolean;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static ValueGetter GetInt32;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static ValueSetter SetInt32;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static ValueGetter GetSingle;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static ValueSetter SetSingle;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static ValueGetter GetString;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static ValueSetter SetString;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static ValueGetter GetSyncedBoolean;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static ValueSetter SetSyncedBoolean;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static ValueGetter GetSyncedInt32;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static ValueSetter SetSyncedInt32;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static ValueGetter GetSyncedSingle;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static ValueSetter SetSyncedSingle;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static ValueGetter GetSyncedString;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static ValueSetter SetSyncedString;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static Func<IMemory, Guid, object> GetReference;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static Action<IMemory, Guid, object> SetReference;
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public interface ITypeSystem
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AllowsMultipleInputs(CircuitType from);

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AllowsMultipleOutputs(CircuitType from);

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsAssignableTo(CircuitType from, CircuitType to);

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CircuitType Narrow(CircuitType typeA, CircuitType typeB);
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public sealed class Memory
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		public interface IMemoryHandle : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x17000187")]
			Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000840")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		private abstract class MemoryHandle<TVal> : IMemoryHandle, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected readonly Memory Memory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			private readonly Dictionary<Guid, TVal> allocatedInDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private readonly Action<Guid, TVal> customDispose;

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private bool IsDisposed
			{
				[Cpp2IlInjected.Token(Token = "0x6000841")]
				[Cpp2IlInjected.Address(RVA = "0x3A8D50", Offset = "0x3A8150", VA = "0x1803A8D50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000842")]
				[Cpp2IlInjected.Address(RVA = "0x3A8D40", Offset = "0x3A8140", VA = "0x1803A8D40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000843")]
				[Cpp2IlInjected.Address(RVA = "0x6871F0", Offset = "0x6865F0", VA = "0x1806871F0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x1A71630", Offset = "0x1A70A30", VA = "0x181A71630")]
			protected MemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x1A715C0", Offset = "0x1A709C0", VA = "0x181A715C0", Slot = "6")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void DisposeInternal();

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x1A71400", Offset = "0x1A70800", VA = "0x181A71400")]
			protected void Deallocate()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private class SymbolMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private readonly string symbol;

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x1A783C0", Offset = "0x1A777C0", VA = "0x181A783C0")]
			public SymbolMemoryHandle(Memory memory, Guid address, string symbol, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x1A780C0", Offset = "0x1A774C0", VA = "0x181A780C0", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x1A782A0", Offset = "0x1A776A0", VA = "0x181A782A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private class UnnamedMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x1A7C3A0", Offset = "0x1A7B7A0", VA = "0x181A7C3A0")]
			public UnnamedMemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x1A7BF80", Offset = "0x1A7B380", VA = "0x181A7BF80", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x1A7C160", Offset = "0x1A7B560", VA = "0x181A7C160", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private const int MAX_SYNCED_STRING_LENGTH = 64;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		internal const int MAX_FIND_NEW_VARIABLE_NAME_BY_INDEX_ATTEMPTS = 25;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		internal const int MAX_FIND_NEW_VARIABLE_NAME_BY_RANDOM_ATTEMPTS = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private readonly CircuitContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private readonly ShortenedGuidMap shortenedGuidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private readonly Dictionary<Guid, bool> booleans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private readonly Dictionary<Guid, int> int32s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private readonly Dictionary<Guid, float> singles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private readonly Dictionary<Guid, string> strings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private readonly Dictionary<Guid, RateLimitedSynchronizedField<bool>> synchronizedBooleans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private readonly Dictionary<Guid, RateLimitedSynchronizedField<int>> synchronizedInt32s;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly Dictionary<Guid, RateLimitedSynchronizedField<float>> synchronizedSingles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private readonly Dictionary<Guid, RateLimitedSynchronizedField<string>> synchronizedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private readonly Dictionary<Guid, object> references;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private readonly Dictionary<string, Guid> addressMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private readonly Dictionary<Guid, string> symbolMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private readonly Dictionary<Guid, CircuitType> typeMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private readonly RefCountMap<Guid> handleRefTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private readonly SetDictionary<Guid, IVariableChangeListener> listenerMap;

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x14CB7D0", Offset = "0x14CABD0", VA = "0x1814CB7D0")]
		public Memory(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x14CA680", Offset = "0x14C9A80", VA = "0x1814CA680")]
		private void OnGuidsRemapped(IReadOnlyDictionary<Guid, ShortenedGuidMap.GuidRemapping> remappedguids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x146D6D0", Offset = "0x146CAD0", VA = "0x18146D6D0")]
		private void RemapDictionary<T>(Dictionary<Guid, RateLimitedSynchronizedField<T>> synchronizedFieldDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA60", Offset = "0x14C9E60", VA = "0x1814CAA60")]
		private void OnHandleReleased(IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x14CA730", Offset = "0x14C9B30", VA = "0x1814CA730")]
		private void OnHandleReleased(string symbol, IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x12547D0", Offset = "0x1253BD0", VA = "0x1812547D0")]
		public IMemoryHandle AllocateNamedVariable<T>(string symbol, Guid defaultAddress, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x1255AB0", Offset = "0x1254EB0", VA = "0x181255AB0")]
		public IMemoryHandle AllocateUnnamedVariable<T>(Guid address, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x12D3050", Offset = "0x12D2450", VA = "0x1812D3050")]
		private Guid InitializeLocal<T>(Guid address, Dictionary<Guid, T> dictionary, T value)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x12D31D0", Offset = "0x12D25D0", VA = "0x1812D31D0")]
		private Guid InitializeSynchronized<T>(Guid address, Dictionary<Guid, RateLimitedSynchronizedField<T>> dictionary, T initialValue)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x146D0E0", Offset = "0x146C4E0", VA = "0x18146D0E0")]
		private void DeallocateSynchronized<T>(Guid address, RateLimitedSynchronizedField<T> field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x11E0C40", Offset = "0x11E0040", VA = "0x1811E0C40")]
		private bool AllocateOrReference<T>(Guid defaultAddress, CircuitType valueType, Dictionary<Guid, T> typeMemory, out IMemoryHandle handle, [Optional] string variableName, [Optional] Action<Guid, T> customDispose)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x1254D90", Offset = "0x1254190", VA = "0x181254D90")]
		private IMemoryHandle AllocateOrReferenceLocal<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, T> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x12553A0", Offset = "0x12547A0", VA = "0x1812553A0")]
		private IMemoryHandle AllocateOrReferenceSynchronized<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, RateLimitedSynchronizedField<T>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x14C9AB0", Offset = "0x14C8EB0", VA = "0x1814C9AB0")]
		public IMemoryHandle AllocateBoolean(Guid defaultAddress, bool value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x14C9B60", Offset = "0x14C8F60", VA = "0x1814C9B60")]
		public IMemoryHandle AllocateInt32(Guid defaultAddress, int value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x14C9CC0", Offset = "0x14C90C0", VA = "0x1814C9CC0")]
		public IMemoryHandle AllocateSingle(Guid defaultAddress, float value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x14C9D70", Offset = "0x14C9170", VA = "0x1814C9D70")]
		public IMemoryHandle AllocateString(Guid defaultAddress, string value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C10", Offset = "0x14C9010", VA = "0x1814C9C10")]
		public IMemoryHandle AllocateOrReferenceSynchronizedBoolean(Guid defaultAddress, bool initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x14C9E20", Offset = "0x14C9220", VA = "0x1814C9E20")]
		public IMemoryHandle AllocateSynchronizedInt32(Guid defaultAddress, int initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x14C9ED0", Offset = "0x14C92D0", VA = "0x1814C9ED0")]
		public IMemoryHandle AllocateSynchronizedSingle(Guid defaultAddress, float initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x14C9F80", Offset = "0x14C9380", VA = "0x1814C9F80")]
		public IMemoryHandle AllocateSynchronizedString(Guid defaultAddress, string initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x14CA300", Offset = "0x14C9700", VA = "0x1814CA300")]
		public bool GetBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x14CA360", Offset = "0x14C9760", VA = "0x1814CA360")]
		public int GetInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x14CA3C0", Offset = "0x14C97C0", VA = "0x1814CA3C0")]
		public float GetSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x14CA420", Offset = "0x14C9820", VA = "0x1814CA420")]
		public string GetString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x14CA480", Offset = "0x14C9880", VA = "0x1814CA480")]
		public bool GetSynchronizedBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x14CA500", Offset = "0x14C9900", VA = "0x1814CA500")]
		public int GetSynchronizedInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x14CA580", Offset = "0x14C9980", VA = "0x1814CA580")]
		public float GetSynchronizedSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x14CA600", Offset = "0x14C9A00", VA = "0x1814CA600")]
		public string GetSynchronizedString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x11E1A80", Offset = "0x11E0E80", VA = "0x1811E1A80")]
		private bool SetValue<T>(Guid id, T value, Dictionary<Guid, T> values) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x14CB1C0", Offset = "0x14CA5C0", VA = "0x1814CB1C0")]
		public bool SetBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x14CB230", Offset = "0x14CA630", VA = "0x1814CB230")]
		public bool SetInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x14CB2A0", Offset = "0x14CA6A0", VA = "0x1814CB2A0")]
		public bool SetSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x14CB310", Offset = "0x14CA710", VA = "0x1814CB310")]
		public bool SetString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x14CB3C0", Offset = "0x14CA7C0", VA = "0x1814CB3C0")]
		public bool SetSynchronizedBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x14CB450", Offset = "0x14CA850", VA = "0x1814CB450")]
		public bool SetSynchronizedInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x14CB4E0", Offset = "0x14CA8E0", VA = "0x1814CB4E0")]
		public bool SetSynchronizedSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x14CB570", Offset = "0x14CA970", VA = "0x1814CB570")]
		public bool SetSynchronizedString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x14CADC0", Offset = "0x14CA1C0", VA = "0x1814CADC0")]
		public void RegisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x14CB750", Offset = "0x14CAB50", VA = "0x1814CB750")]
		public void UnregisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x14CAB80", Offset = "0x14C9F80", VA = "0x1814CAB80")]
		private void OnValueChanged(RateLimiter rateLimiter, Guid address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x14CB630", Offset = "0x14CAA30", VA = "0x1814CB630")]
		private static string Truncate(string originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x14CB680", Offset = "0x14CAA80", VA = "0x1814CB680")]
		public bool TryGetNamedVariable(string varName, out Guid variableAddress, out CircuitType variableType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x14CAE40", Offset = "0x14CA240", VA = "0x1814CAE40")]
		public void RemapNamedVariables(CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x14CA030", Offset = "0x14C9430", VA = "0x1814CA030")]
		internal string FindNewVariableName(string originalVarName)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	public static class TypeRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		public struct TypeConversionKey
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public readonly TypeKind FromKind;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public readonly TypeKind ToKind;

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0x13BC30", Offset = "0x13B030", VA = "0x18013BC30")]
			public TypeConversionKey(TypeKind fromKind, TypeKind toKind)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x1812D0", Offset = "0x1806D0", VA = "0x1801812D0")]
			public bool Equals(TypeConversionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x1812F0", Offset = "0x1806F0", VA = "0x1801812F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x181380", Offset = "0x180780", VA = "0x180181380", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private static readonly IDictionary<Guid, CircuitType> types;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private static readonly IDictionary<CircuitType, Guid> typeIds;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private static readonly IDictionary<CircuitType, Color> typeColors;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private static readonly IDictionary<Guid, string> nameToFriendlyName;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		[AutoTypeId("946EB83D-BC92-41F1-BDB7-B916D056AB62")]
		public static readonly CircuitType AnyType;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		[AutoTypeId("AE8A3772-2E0A-4986-B75F-E20D127590A8")]
		public static readonly CircuitType BooleanType;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		[AutoTypeId("E897DCC6-E979-4D95-99D6-E08E51EBDE84")]
		public static readonly CircuitType Int32Type;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[AutoTypeId("E7697C10-F347-430A-B225-E9F7940F48E1")]
		public static readonly CircuitType SingleType;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		[AutoTypeId("2715A114-7B0D-4334-A73F-794C6B536DFB")]
		public static readonly CircuitType StringType;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[AutoTypeId("47603B22-50B3-46EC-9181-2A7ED8D84710")]
		public static readonly CircuitType ExecType;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		[AutoTypeId("9131A9B9-7059-4F9E-9872-8746C5143D4A")]
		public static readonly CircuitType ErrorType;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		[AutoTypeId("2F7E7673-DFA7-4ADF-A3B7-DAC99BD15A22")]
		public static readonly ClassType GameObjectType;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		[AutoTypeId("4545CA57-BB4A-4505-9373-D5FB8D9045A8")]
		public static readonly ClassType PlayerType;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		[AutoTypeId("A2024DB1-50EE-40F7-A24E-3E50195DB3D9")]
		public static readonly ClassType ListType;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private static readonly HashSet<CircuitType> supportsDefaultValues;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private static readonly Dictionary<TypeConversionKey, Type> autoTypeConversions;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private static int colorIndex;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private static Color[] colors;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private static System.Random Random;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static bool isInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x14CC750", Offset = "0x14CBB50", VA = "0x1814CC750")]
		public static bool IsConvertableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x14CC4E0", Offset = "0x14CB8E0", VA = "0x1814CC4E0")]
		public static Func<Node, Node, (Node, ITypeConversionNode)> GetConverterConstructor(CircuitType from, CircuitType to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x14CCA50", Offset = "0x14CBE50", VA = "0x1814CCA50")]
		public static bool SupportsDefaultValue(CircuitType signalType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x14CC810", Offset = "0x14CBC10", VA = "0x1814CC810")]
		public static void RegisterFriendlyName(Guid name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x14CC600", Offset = "0x14CBA00", VA = "0x1814CC600")]
		public static string GetFriendlyName(Guid name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public sealed class TypeSystem : ITypeSystem
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly TypeKind[] PrimitiveTypes;

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public static ITypeSystem Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0x14CE940", Offset = "0x14CDD40", VA = "0x1814CE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x14CD230", Offset = "0x14CC630", VA = "0x1814CD230", Slot = "4")]
		public bool AllowsMultipleInputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x14CD260", Offset = "0x14CC660", VA = "0x1814CD260", Slot = "5")]
		public bool AllowsMultipleOutputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x14CDB60", Offset = "0x14CCF60", VA = "0x1814CDB60", Slot = "6")]
		public bool IsAssignableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x14CD430", Offset = "0x14CC830", VA = "0x1814CD430")]
		private bool IsAssignableToInternal(CircuitType from, CircuitType to, IReadOnlyList<CircuitType> fromTypeParameterAssignments, IReadOnlyList<CircuitType> toTypeParameterAssignments)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x14CDBF0", Offset = "0x14CCFF0", VA = "0x1814CDBF0", Slot = "7")]
		public CircuitType Narrow(CircuitType typeA, CircuitType typeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x14CD290", Offset = "0x14CC690", VA = "0x1814CD290")]
		private static (CircuitType, IReadOnlyList<CircuitType>, bool) ExtractTypeSpecifics(CircuitType type, IReadOnlyList<CircuitType> lastAssignments)
		{
			return default((CircuitType, IReadOnlyList<CircuitType>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public TypeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public interface IPlayerProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		CircuitPlayer LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GetPlayerName(CircuitPlayer player);

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GetPlayerHealth(CircuitPlayer player, out int health, out int shield);

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DamagePlayer(CircuitPlayer player, int damage, bool ignoreShield);

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ResetPlayerHealth(CircuitPlayer player);

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IsPlayerLocal(CircuitPlayer player);

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<PromptResponse> PromptForText(string promptTitle, string prompt);

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IReadOnlyList<CircuitPlayer> GetAllPlayers();
	}
	[StructLayout((LayoutKind)0, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public struct PromptResponse
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public bool PromptSuccess;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public string TextInput;
	}
}
namespace CircuitsV2.Graph
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	public interface ITransformable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public abstract class CircuitObject : ITransformable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		[Guid("3632DCA5-8DBA-4F6C-BF41-DD4609868843")]
		private class TransformModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x14CC3F0", Offset = "0x14CB7F0", VA = "0x1814CC3F0")]
			public TransformModificationHandler(CircuitObject modifiedObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x14CC040", Offset = "0x14CB440", VA = "0x1814CC040")]
			public ICircuitObjectModification CreateModification(Vector3? newLocalPosition, Quaternion? newLocalRotation)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x14CC170", Offset = "0x14CB570", VA = "0x1814CC170", Slot = "7")]
			public override void HandleModificationRequest(byte[] payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public readonly CircuitContext CircuitContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public readonly CircuitObjectId CircuitObjectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private readonly Dictionary<Guid, ICircuitObjectModificationHandler> modificationHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		internal readonly CircuitObjectType ObjectType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private readonly CircuitTokenFlag preventsDestroy;

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public CircuitObjectTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0x3890A0", Offset = "0x3884A0", VA = "0x1803890A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		protected internal bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0x4C2BB0", Offset = "0x4C1FB0", VA = "0x1804C2BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x556EA0", Offset = "0x5562A0", VA = "0x180556EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool CanSetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x14BF5A0", Offset = "0x14BE9A0", VA = "0x1814BF5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x14BF540", Offset = "0x14BE940", VA = "0x1814BF540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action OnDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x14BF400", Offset = "0x14BE800", VA = "0x1814BF400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0x14BF5F0", Offset = "0x14BE9F0", VA = "0x1814BF5F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x14BF4A0", Offset = "0x14BE8A0", VA = "0x1814BF4A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x14BF690", Offset = "0x14BEA90", VA = "0x1814BF690")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x14BF280", Offset = "0x14BE680", VA = "0x1814BF280")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x14BF080", Offset = "0x14BE480", VA = "0x1814BF080")]
		internal void SetCanDestroy(bool canDestroy, CircuitTokenFlag.CircuitToken token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x14BEEE0", Offset = "0x14BE2E0", VA = "0x1814BEEE0")]
		public void RequestTransformChange(Vector3? newPosition, Quaternion? newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x1461400", Offset = "0x1460800", VA = "0x181461400")]
		public void RegisterModificationHandler<T>(T handler) where T : ICircuitObjectModificationHandler
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x11D9910", Offset = "0x11D8D10", VA = "0x1811D9910")]
		public bool TryGetModificationHandler<T>(out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x11D99E0", Offset = "0x11D8DE0", VA = "0x1811D99E0")]
		public bool TryGetModificationHandler<T>(Guid handlerId, out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x14BF220", Offset = "0x14BE620", VA = "0x1814BF220")]
		public bool UnregisterModificationHandler(Guid guid)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x14BED10", Offset = "0x14BE110", VA = "0x1814BED10")]
		public void HandleModificationRequest(Guid modificationHandlerId, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x14BECC0", Offset = "0x14BE0C0", VA = "0x1814BECC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DisposeInternal();

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		internal abstract void SetNameLocal(string newName);

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x14BEE20", Offset = "0x14BE220", VA = "0x1814BEE20")]
		public bool RequestChangeName(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x4FE410", Offset = "0x4FD810", VA = "0x1804FE410", Slot = "8")]
		public virtual bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA0E710", Offset = "0xA0DB10", VA = "0x180A0E710")]
		protected void RaiseOnNameChangedEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public abstract class CircuitObject<TProto> : CircuitObject, ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1A6CB50", Offset = "0x1A6BF50", VA = "0x181A6CB50")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract TProto SerializeToProtobuf();

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void DeserializeFromProtobuf(TProto protobufData);
	}
	[StructLayout((LayoutKind)0, Size = 32)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public struct CircuitObjectId
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public readonly Guid ContextUniqueObjectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public readonly Guid GloballyUniqueObjectId;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x180970", Offset = "0x17FD70", VA = "0x180180970")]
		public CircuitObjectId(Guid contextId, Guid objectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x1808F0", Offset = "0x17FCF0", VA = "0x1801808F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[NodeTag("Control Flow", new string[] { })]
	public abstract class ExecutableNode : Node
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private float lastExecutionHeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private bool lastWasLimited;

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D30", Offset = "0x14C1130", VA = "0x1814C1D30")]
		protected ExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D00", Offset = "0x14C1100", VA = "0x1814C1D00")]
		protected ExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x14C1B10", Offset = "0x14C0F10", VA = "0x1814C1B10")]
		public NextExecutable ExecuteNode(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public interface IExecutionScope
	{
		[Cpp2IlInjected.Token(Token = "0x17000190")]
		int MaxExecutionsPerFrame
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MarkExecution();

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkValueRetrieve();
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public class ExecutionScope : IExecutionScope
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private bool wasLimited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private int myExecutions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private int valueRetrieves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public readonly CircuitContext ExecutionScopeContext;

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public int MaxExecutionsPerFrame
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x14C1E00", Offset = "0x14C1200", VA = "0x1814C1E00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x3AD320", Offset = "0x3AC720", VA = "0x1803AD320", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A8D50", Offset = "0x3A8150", VA = "0x1803A8D50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB4B0", Offset = "0xAAA8B0", VA = "0x180AAB4B0")]
		public ExecutionScope([NotNull] CircuitContext executionScopeContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D60", Offset = "0x14C1160", VA = "0x1814C1D60", Slot = "7")]
		public bool MarkExecution()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB8FE0", Offset = "0xAB83E0", VA = "0x180AB8FE0", Slot = "8")]
		public void MarkValueRetrieve()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public enum ConnectionResult
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		AlreadyConnected,
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		CanConvert,
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		ErrorCycleDetected,
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		ErrorInvalidType,
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		ErrorNull
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public enum DisconnectionResultKind
	{
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		ErrorNull,
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		ErrorNotConnected
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public struct DisconnectionResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public readonly DisconnectionResultKind Kind;

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public int IndexOfDstInSrc
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x138030", Offset = "0x137430", VA = "0x180138030")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x181230", Offset = "0x180630", VA = "0x180181230")]
		private DisconnectionResult(DisconnectionResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x181240", Offset = "0x180640", VA = "0x180181240")]
		private DisconnectionResult(int indexOfDstInSrc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x14C0E90", Offset = "0x14C0290", VA = "0x1814C0E90")]
		public static DisconnectionResult Ok(int indexOfDstInSrc)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x14C0E70", Offset = "0x14C0270", VA = "0x1814C0E70")]
		public static DisconnectionResult ErrorNull()
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x14C0E50", Offset = "0x14C0250", VA = "0x1814C0E50")]
		public static DisconnectionResult ErrorNotConnected()
		{
			return default(DisconnectionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public static class GraphOp
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x14C6220", Offset = "0x14C5620", VA = "0x1814C6220")]
		private static ConnectionResult CanConnect(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x14C6820", Offset = "0x14C5C20", VA = "0x1814C6820")]
		public static ConnectionResult ConnectByRequest(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x14C6D50", Offset = "0x14C6150", VA = "0x1814C6D50")]
		internal static ConnectionResult ConnectLocal(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x14C7270", Offset = "0x14C6670", VA = "0x1814C7270")]
		internal static void ConnectLocal(CircuitContext context, Guid srcNodeId, Guid srcPortId, Guid dstNodeId, Guid dstPortId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x14C6A70", Offset = "0x14C5E70", VA = "0x1814C6A70")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) ConnectCore(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x14C7430", Offset = "0x14C6830", VA = "0x1814C7430")]
		private static bool CreatesCycle(Node srcNode, Node dstNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x14C8EA0", Offset = "0x14C82A0", VA = "0x1814C8EA0")]
		private static bool IsConnected(Node srcNode, Node dstNode, OutputPort srcPort, InputPort dstPort)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x14C67B0", Offset = "0x14C5BB0", VA = "0x1814C67B0")]
		private static DisconnectionResult CanDisconnect(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x14C8570", Offset = "0x14C7970", VA = "0x1814C8570")]
		internal static DisconnectionResult DisconnectLocal(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x14C7EC0", Offset = "0x14C72C0", VA = "0x1814C7EC0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectCore(OutputPort srcPort, InputPort dstPort, int indexOfDstInSrc)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x14C8C40", Offset = "0x14C8040", VA = "0x1814C8C40")]
		private static int IndexOfDstInSrc(OutputPort srcPort, InputPort dstPort)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x14C81A0", Offset = "0x14C75A0", VA = "0x1814C81A0")]
		private static (IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>) DisconnectForConnect(OutputPort srcPort, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x14C6790", Offset = "0x14C5B90", VA = "0x1814C6790")]
		private static bool CanDisconnectPort(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x14C8630", Offset = "0x14C7A30", VA = "0x1814C8630")]
		public static bool DisconnectPortByRequest(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x14C8BD0", Offset = "0x14C7FD0", VA = "0x1814C8BD0")]
		internal static bool DisconnectPortLocal(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x14C8A40", Offset = "0x14C7E40", VA = "0x1814C8A40")]
		internal static void DisconnectPortLocal(CircuitContext context, Guid nodeId, Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x14C8860", Offset = "0x14C7C60", VA = "0x1814C8860")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectPortCore(PortBase port)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x14C7C00", Offset = "0x14C7000", VA = "0x1814C7C00")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyPortGroupCore(IPortGroup portGroup)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x14C6710", Offset = "0x14C5B10", VA = "0x1814C6710")]
		private static bool CanDestroyNode(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x14C7B40", Offset = "0x14C6F40", VA = "0x1814C7B40")]
		internal static bool DestroyNodeLocal(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x14C75D0", Offset = "0x14C69D0", VA = "0x1814C75D0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyNodeCore(Node node)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x14C8D00", Offset = "0x14C8100", VA = "0x1814C8D00")]
		public static void InferAndUpdateGraph(IEnumerable<Node> nodesToInfer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public interface IPort
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public abstract class Node : CircuitObject<CircuitNodeData>, ICheckableNode<Node, InputPort, OutputPort, NodeConnection>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected string DefaultNodeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected string UserSetNodeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		[VisibleForTesting]
		internal readonly InputPortCollection InputPortCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[VisibleForTesting]
		internal readonly OutputPortCollection OutputPortCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private FunctionType specificType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		[CompilerGenerated]
		private EventHandler SpecificTypeChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		private Guid NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x1727DF0", Offset = "0x17271F0", VA = "0x181727DF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		internal Dictionary<string, CircuitType> LastTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x3F4240", Offset = "0x3F3640", VA = "0x1803F4240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x560790", Offset = "0x55FB90", VA = "0x180560790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public IEnumerable<InputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x1727DA0", Offset = "0x17271A0", VA = "0x181727DA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public IEnumerable<InputPort> InputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0x1727C90", Offset = "0x1727090", VA = "0x181727C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public IEnumerable<OutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x1727FD0", Offset = "0x17273D0", VA = "0x181727FD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IEnumerable<OutputPort> OutputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x1727EC0", Offset = "0x17272C0", VA = "0x181727EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public IEnumerable<PortGroupBase<InputPort>> InputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x1727C40", Offset = "0x1727040", VA = "0x181727C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public IEnumerable<PortGroupBase<OutputPort>> OutputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x1727E70", Offset = "0x1727270", VA = "0x181727E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x3F4290", Offset = "0x3F3690", VA = "0x1803F4290", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		private FunctionType SpecificType
		{
			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0x17280C0", Offset = "0x17274C0", VA = "0x1817280C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action OnPortsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x1727BA0", Offset = "0x1726FA0", VA = "0x181727BA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x1728020", Offset = "0x1727420", VA = "0x181728020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x17273A0", Offset = "0x17267A0", VA = "0x1817273A0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x1726910", Offset = "0x1725D10", VA = "0x181726910")]
		public string GetNodeName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x17277D0", Offset = "0x1726BD0", VA = "0x1817277D0")]
		protected Node(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x1726A30", Offset = "0x1725E30", VA = "0x181726A30")]
		public bool RequestSetPortDefaultValue(PortBase port, CircuitSignal value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x1726920", Offset = "0x1725D20", VA = "0x181726920", Slot = "16")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x17273F0", Offset = "0x17267F0", VA = "0x1817273F0")]
		public void SetSpecificTypes(IEnumerable<(string, CircuitType)> genericTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x1727730", Offset = "0x1726B30", VA = "0x181727730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "17")]
		protected virtual void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x1726DA0", Offset = "0x17261A0", VA = "0x181726DA0", Slot = "10")]
		public sealed override CircuitNodeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x1726BA0", Offset = "0x1725FA0", VA = "0x181726BA0")]
		[CanBeNull]
		private InventionPieceData SerializeInventionPieceData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x1726460", Offset = "0x1725860", VA = "0x181726460", Slot = "11")]
		public sealed override void DeserializeFromProtobuf(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x1725D20", Offset = "0x1725120", VA = "0x181725D20")]
		public void DeserializeConnections(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "18")]
		protected virtual void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "19")]
		protected virtual void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x1726770", Offset = "0x1725B70", VA = "0x181726770", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x1726870", Offset = "0x1725C70", VA = "0x181726870", Slot = "20")]
		protected internal virtual (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x17269F0", Offset = "0x1725DF0", VA = "0x1817269F0")]
		internal void RaiseOnPortsUpdatedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x17268E0", Offset = "0x1725CE0", VA = "0x1817268E0", Slot = "21")]
		public virtual IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x1725C80", Offset = "0x1725080", VA = "0x181725C80")]
		protected static FunctionType CTypeParams(params TypeParamConstrainedOrNot[] typeParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x1725AA0", Offset = "0x1724EA0", VA = "0x181725AA0")]
		private static InputPort BuildInputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x1725B90", Offset = "0x1724F90", VA = "0x181725B90")]
		private static OutputPort BuildOutputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public class NodeConnection : ICheckableConnection<Node, InputPort, OutputPort, NodeConnection>, ICircuitSerializable<NodeConnectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		[NotNull]
		public Node SrcNode
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[NotNull]
		public OutputPort SrcPort
		{
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		[NotNull]
		public Node DstNode
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[NotNull]
		public InputPort DstPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x169ADD0", Offset = "0x169A1D0", VA = "0x18169ADD0")]
		public NodeConnection([NotNull] Node srcNode, [NotNull] OutputPort srcPort, [NotNull] Node dstNode, [NotNull] InputPort dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x1725760", Offset = "0x1724B60", VA = "0x181725760")]
		protected bool Equals(NodeConnection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x1725650", Offset = "0x1724A50", VA = "0x181725650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x17257A0", Offset = "0x1724BA0", VA = "0x1817257A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x90B190", Offset = "0x90A590", VA = "0x18090B190")]
		public static bool operator !=(NodeConnection left, NodeConnection right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x1725930", Offset = "0x1724D30", VA = "0x181725930", Slot = "9")]
		public NodeConnectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x1725600", Offset = "0x1724A00", VA = "0x181725600", Slot = "8")]
		public void DeserializeFromProtobuf(NodeConnectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x1725860", Offset = "0x1724C60", VA = "0x181725860")]
		public bool Matches(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public class BasicPortGroup<TPort> : PortGroupBase<TPort> where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1F0", Offset = "0x3EA5F0", VA = "0x1803EB1F0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x1A697A0", Offset = "0x1A68BA0", VA = "0x181A697A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x1A69740", Offset = "0x1A68B40", VA = "0x181A69740")]
		public BasicPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x1A69470", Offset = "0x1A68870", VA = "0x181A69470")]
		internal void AddPortLocal(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x1A694A0", Offset = "0x1A688A0", VA = "0x181A694A0", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x1A695C0", Offset = "0x1A689C0", VA = "0x181A695C0", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	internal class DynamicPortGroupModificationHandler<TPort> : NodeModificationHandlerBase where TPort : PortBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly PortGroupBase<TPort> portGroup;

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0x4EFD20", Offset = "0x4EF120", VA = "0x1804EFD20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D470", Offset = "0x1A6C870", VA = "0x181A6D470")]
		public DynamicPortGroupModificationHandler(Node node, PortGroupBase<TPort> portGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D000", Offset = "0x1A6C400", VA = "0x181A6D000")]
		public ICircuitObjectModification CreateAddModification(Guid portId, string portName, CircuitType portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D1D0", Offset = "0x1A6C5D0", VA = "0x181A6D1D0")]
		public ICircuitObjectModification CreateRemoveModification(Guid portId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D340", Offset = "0x1A6C740", VA = "0x181A6D340", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public class ExecNameBasedPortGroup<TPort> : NameBasedPortGroup<TPort> where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public TPort ExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x3F4270", Offset = "0x3F3670", VA = "0x1803F4270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0x40BE60", Offset = "0x40B260", VA = "0x18040BE60", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x1A6D8F0", Offset = "0x1A6CCF0", VA = "0x181A6D8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D680", Offset = "0x1A6CA80", VA = "0x181A6D680")]
		public ExecNameBasedPortGroup(string execPortName, PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D550", Offset = "0x1A6C950", VA = "0x181A6D550")]
		private void OnGroupPortRemoved(TPort obj)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public interface IIndexBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestAddPort();
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public class IndexBasedPortGroup<TPort> : PortGroupBase<TPort>, IReadOnlyIndexBasedPortGroup<TPort>, IReadOnlyPortGroup<TPort>, IIndexBasedPortGroup where TPort : PortBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private readonly string elementName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private readonly int minPortCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private readonly int maxPortCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private readonly CircuitType elementPortType;

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[VisibleForTesting]
		internal CircuitType ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x3F4240", Offset = "0x3F3640", VA = "0x1803F4240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x488E10", Offset = "0x488210", VA = "0x180488E10", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x1A6D8F0", Offset = "0x1A6CCF0", VA = "0x181A6D8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x1A70780", Offset = "0x1A6FB80", VA = "0x181A70780", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x1A705E0", Offset = "0x1A6F9E0", VA = "0x181A705E0")]
		public IndexBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory, string elementName, CircuitTypeOrString elementPortType, int minPortCount = 0, int maxPortCount = 64)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x1A6FEA0", Offset = "0x1A6F2A0", VA = "0x181A6FEA0", Slot = "16")]
		public override bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x1A6FCA0", Offset = "0x1A6F0A0", VA = "0x181A6FCA0")]
		public TPort AddPortLocal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1A70210", Offset = "0x1A6F610", VA = "0x181A70210")]
		private void RemoveLastPortLocal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x1A70440", Offset = "0x1A6F840", VA = "0x181A70440", Slot = "18")]
		protected override void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x1A6FF60", Offset = "0x1A6F360", VA = "0x181A6FF60", Slot = "19")]
		protected override void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x1A702F0", Offset = "0x1A6F6F0", VA = "0x181A702F0", Slot = "24")]
		public void RequestAddPort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x1A70170", Offset = "0x1A6F570", VA = "0x181A70170", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x1A701A0", Offset = "0x1A6F5A0", VA = "0x181A701A0", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public sealed class InputPort : PortBase, ICheckableInputPort<Node, InputPort, OutputPort, NodeConnection>, ICheckablePort
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private readonly bool canSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private CircuitSignal _defaultSignalValue;

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public NodeConnection FirstConnection
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0x1722550", Offset = "0x1721950", VA = "0x181722550", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private OutputPort FirstConnectedPort
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x17224F0", Offset = "0x17218F0", VA = "0x1817224F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x1722450", Offset = "0x1721850", VA = "0x181722450", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool SupportsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x1722670", Offset = "0x1721A70", VA = "0x181722670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool HasCustomDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x17225A0", Offset = "0x17219A0", VA = "0x1817225A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public CircuitSignal DefaultSignalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x17224D0", Offset = "0x17218D0", VA = "0x1817224D0")]
			get
			{
				return default(CircuitSignal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x1722790", Offset = "0x1721B90", VA = "0x181722790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action OnDefaultSignalValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x17223B0", Offset = "0x17217B0", VA = "0x1817223B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x17226F0", Offset = "0x1721AF0", VA = "0x1817226F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x1721F40", Offset = "0x1721340", VA = "0x181721F40", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x1722350", Offset = "0x1721750", VA = "0x181722350")]
		public InputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, bool canSet = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x1722080", Offset = "0x1721480", VA = "0x181722080", Slot = "12")]
		protected override void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x1721FD0", Offset = "0x17213D0", VA = "0x181721FD0", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x17222C0", Offset = "0x17216C0", VA = "0x1817222C0", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x1721F60", Offset = "0x1721360", VA = "0x181721F60", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x1721E10", Offset = "0x1721210", VA = "0x181721E10")]
		private CircuitSignal DefaultValue(TypeKind kind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x17221F0", Offset = "0x17215F0", VA = "0x1817221F0")]
		public DefaultPortData SerializeCustomDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x1721E80", Offset = "0x1721280", VA = "0x181721E80")]
		public void DeserializeCustomDefault(DefaultPortData portData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public interface IReadOnlyPortGroup<out TPort> where TPort : PortBase
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface IReadOnlyNameBasedPortGroup<out TPort> : IReadOnlyPortGroup<TPort> where TPort : PortBase
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface IReadOnlyIndexBasedPortGroup<out TPort> : IReadOnlyPortGroup<TPort> where TPort : PortBase
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface INameBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestAddPort(string portName, CircuitType circuitType);

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HasPort(string portName);
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	internal interface IEditableNameBasedPortGroup : INameBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ClearPorts();

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> eventDefinitionEventProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public class NameBasedPortGroup<TPort> : PortGroupBase<TPort>, IReadOnlyNameBasedPortGroup<TPort>, IReadOnlyPortGroup<TPort>, IEditableNameBasedPortGroup, INameBasedPortGroup where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0x3AA9E0", Offset = "0x3A9DE0", VA = "0x1803AA9E0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x1A6D8F0", Offset = "0x1A6CCF0", VA = "0x181A6D8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x1A72480", Offset = "0x1A71880", VA = "0x181A72480")]
		public NameBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x1A72210", Offset = "0x1A71610", VA = "0x181A72210", Slot = "26")]
		public void RequestAddPort(string portName, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B20", Offset = "0x1A70F20", VA = "0x181A71B20", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x1A71BD0", Offset = "0x1A70FD0", VA = "0x181A71BD0", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x1A71690", Offset = "0x1A70A90", VA = "0x181A71690")]
		internal TPort AddPortLocal(string portName, CircuitTypeOrString circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x1A71C80", Offset = "0x1A71080", VA = "0x181A71C80", Slot = "27")]
		public bool HasPort(string portName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x1A72350", Offset = "0x1A71750", VA = "0x181A72350")]
		public bool TryGetPort(string portName, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x1A71AA0", Offset = "0x1A70EA0", VA = "0x181A71AA0")]
		private Guid GeneratePortId(string portName)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x1A721E0", Offset = "0x1A715E0", VA = "0x181A721E0", Slot = "25")]
		public void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x1A71CC0", Offset = "0x1A710C0", VA = "0x181A71CC0")]
		internal void MergeNamedGroup(IEnumerable<KeyValuePair<string, CircuitType>> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x1A71830", Offset = "0x1A70C30", VA = "0x181A71830", Slot = "24")]
		public void ClearPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x146E3C0", Offset = "0x146D7C0", VA = "0x18146E3C0")]
		internal void OnBridgedPortRemoved<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x146E440", Offset = "0x146D840", VA = "0x18146E440")]
		internal (IEnumerable<Action>, IEnumerable<Node>) RemoveBridgedPortCore<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x146E390", Offset = "0x146D790", VA = "0x18146E390")]
		internal void OnBridgedPortAdded<TOtherPort>(TOtherPort otherAddedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x11E1CF0", Offset = "0x11E10F0", VA = "0x1811E1CF0")]
		internal bool CreateOrUpdateBridgedPort<TOtherPort>(TOtherPort otherAddedPort, out TPort myPort) where TOtherPort : PortBase
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public delegate CircuitSignal OutputPortGetDelegate(IExecutionScope executionScope);
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public delegate CircuitType OutputPortGetSignalTypeDelegate();
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public delegate void OutputPortSetDelegate(CircuitSignal value);
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public delegate Node OutputPortGetReferencedNodeDelegate();
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	public sealed class OutputPort : PortBase, ICheckableOutputPort<Node, InputPort, OutputPort, NodeConnection>, ICheckablePort
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private OutputPortGetDelegate outputPortGetDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private OutputPortGetSignalTypeDelegate outputPortGetSignalTypeDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private OutputPortSetDelegate outputPortSetDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate;

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		IEnumerable<NodeConnection> ICheckableOutputPort<Node, InputPort, OutputPort, NodeConnection>.Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x1942630", Offset = "0x1941A30", VA = "0x181942630", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A10", Offset = "0x3A1E10", VA = "0x1803A2A10", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x19424B0", Offset = "0x19418B0", VA = "0x1819424B0")]
		public OutputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, [Optional] OutputPortGetDelegate outputPortGetDelegate, [Optional] OutputPortSetDelegate outputPortSetDelegate, [Optional] OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x19423D0", Offset = "0x19417D0", VA = "0x1819423D0", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x1942470", Offset = "0x1941870", VA = "0x181942470", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x19423B0", Offset = "0x19417B0", VA = "0x1819423B0", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x1942250", Offset = "0x1941650", VA = "0x181942250")]
		public NextExecutable GetExec()
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x1942460", Offset = "0x1941860", VA = "0x181942460")]
		public void SetDelegates([Optional] OutputPortGetDelegate get, [Optional] OutputPortSetDelegate set)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public abstract class PortBase : IDisposable, IPort, ICircuitSerializable<NodePortData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private readonly List<NodeConnection> connections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public readonly Guid PortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public IPortGroup PortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public string PortName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private CircuitType specificPortType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		internal bool disposed;

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public IReadOnlyList<NodeConnection> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x19438A0", Offset = "0x1942CA0", VA = "0x1819438A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		internal bool IsDynamic
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x3EA050", Offset = "0x3E9450", VA = "0x1803EA050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x76A230", Offset = "0x769630", VA = "0x18076A230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public CircuitType GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0x38A650", Offset = "0x389A50", VA = "0x18038A650", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public CircuitType SpecificPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x3B75F0", Offset = "0x3B69F0", VA = "0x1803B75F0", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x1943A90", Offset = "0x1942E90", VA = "0x181943A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public abstract bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action OnSpecificPortTypeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096B")]
			[Cpp2IlInjected.Address(RVA = "0x1943800", Offset = "0x1942C00", VA = "0x181943800", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x19439F0", Offset = "0x1942DF0", VA = "0x1819439F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<bool> OnIsConnectedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x1943760", Offset = "0x1942B60", VA = "0x181943760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x1943950", Offset = "0x1942D50", VA = "0x181943950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Node GetNode(NodeConnection connection);

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x1943600", Offset = "0x1942A00", VA = "0x181943600")]
		protected PortBase(Guid portId, string portName, bool isInputPort, [Optional][CanBeNull] CircuitTypeOrString? circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x1943140", Offset = "0x1942540", VA = "0x181943140")]
		public void AddConnection(NodeConnection newConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x1943440", Offset = "0x1942840", VA = "0x181943440")]
		public bool RemoveConnection(NodeConnection connection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x1943380", Offset = "0x1942780", VA = "0x181943380")]
		public void RemoveConnectionAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x971AA0", Offset = "0x970EA0", VA = "0x180971AA0", Slot = "12")]
		protected virtual void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x1943320", Offset = "0x1942720", VA = "0x181943320")]
		private void RaiseOnIsConnectedChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract CircuitSignal Get(IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		public abstract void Set(CircuitSignal newSignal);

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract Node GetReferencedNode();

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x1943520", Offset = "0x1942920", VA = "0x181943520", Slot = "17")]
		public NodePortData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x1943200", Offset = "0x1942600", VA = "0x181943200", Slot = "5")]
		public void DeserializeFromProtobuf(NodePortData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x1943230", Offset = "0x1942630", VA = "0x181943230", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal static class PortBridge
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x1473470", Offset = "0x1472870", VA = "0x181473470")]
		internal static void BridgePortDelegates<TPortA, TPortB>(TPortA portA, TPortB portB) where TPortA : PortBase where TPortB : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x1943AE0", Offset = "0x1942EE0", VA = "0x181943AE0")]
		internal static void BridgePorts(NameBasedPortGroup<InputPort> source, NameBasedPortGroup<OutputPort> dest, bool skipExecs = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public delegate TPort PortCreationFactory<TPort>(Guid portId, string portName, CircuitTypeOrString portType) where TPort : PortBase;
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public interface IPortCollection : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	public abstract class PortCollection<TPort> : ICircuitSerializable<PortCollectionData>, IPortCollection, IDisposable where TPort : PortBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly Dictionary<Guid, PortGroupBase<TPort>> builtInPortGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private readonly Dictionary<Guid, PortGroupBase<TPort>> dynamicPortGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private readonly List<PortGroupBase<TPort>> orderedPortGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public readonly bool IsInputCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private readonly Node node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public readonly PortCreationFactory<TPort> portCreationFactory;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly Guid defaultBuiltInPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private readonly BasicPortGroup<TPort> defaultBuiltInPortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private bool disposed;

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public IReadOnlyList<PortGroupBase<TPort>> OrderedPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public IEnumerable<PortGroupBase<TPort>> AllPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x1A746F0", Offset = "0x1A73AF0", VA = "0x181A746F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public IEnumerable<TPort> AllPorts
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x1A74780", Offset = "0x1A73B80", VA = "0x181A74780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x1A744B0", Offset = "0x1A738B0", VA = "0x181A744B0")]
		public PortCollection(bool isInputCollection, Node node, PortCreationFactory<TPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x1A735C0", Offset = "0x1A729C0", VA = "0x181A735C0")]
		public IndexBasedPortGroup<TPort> RegisterIndexedPortGroup(Guid portGroupId, PortGroupSerialization serialization, CircuitTypeOrString elementType, string elementName = "Element", [Optional] string portGroupName, int minPortCount = 0, int maxPortCount = 64)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x1A736F0", Offset = "0x1A72AF0", VA = "0x181A736F0")]
		public NameBasedPortGroup<TPort> RegisterNameBasedPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x1A734B0", Offset = "0x1A728B0", VA = "0x181A734B0")]
		public ExecNameBasedPortGroup<TPort> RegisterExecNameBasedPortGroup(string execPortName, Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x1A733C0", Offset = "0x1A727C0", VA = "0x181A733C0")]
		public BasicPortGroup<TPort> RegisterBasicPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x1A733B0", Offset = "0x1A727B0", VA = "0x181A733B0")]
		private Dictionary<Guid, PortGroupBase<TPort>> GetPortGroupDictionary(PortGroupSerialization serialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x1A72510", Offset = "0x1A71910", VA = "0x181A72510")]
		private void AddPortGroup(PortGroupBase<TPort> newPortGroup, [Optional] string portGroupName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x1A73F00", Offset = "0x1A73300", VA = "0x181A73F00")]
		public bool TryGetPort(Guid portGuid, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x1A724E0", Offset = "0x1A718E0", VA = "0x181A724E0")]
		public void AddBuiltInPort(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x1A730D0", Offset = "0x1A724D0", VA = "0x181A730D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x1A73960", Offset = "0x1A72D60", VA = "0x181A73960", Slot = "6")]
		public PortCollectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "7")]
		protected virtual void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x1A72BA0", Offset = "0x1A71FA0", VA = "0x181A72BA0", Slot = "4")]
		public void DeserializeFromProtobuf([NotNull] PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "8")]
		protected virtual void DeserializeInternal(PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x1A727C0", Offset = "0x1A71BC0", VA = "0x181A727C0")]
		private PortGroupBase<TPort> CreatePortGroupOnDeserialization(Guid portGroupId, PortGroupData protobufData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x11E2020", Offset = "0x11E1420", VA = "0x1811E2020")]
		public bool TryGetPortGroup<T>(Guid portGroupId, out T portGroup) where T : PortGroupBase<TPort>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x1A737E0", Offset = "0x1A72BE0", VA = "0x181A737E0")]
		public void RemovePortGroup(Guid groupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public sealed class InputPortCollection : PortCollection<InputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x1721D90", Offset = "0x1721190", VA = "0x181721D90")]
		public InputPortCollection(Node node, PortCreationFactory<InputPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x1721AE0", Offset = "0x1720EE0", VA = "0x181721AE0", Slot = "7")]
		protected override void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x1721890", Offset = "0x1720C90", VA = "0x181721890", Slot = "8")]
		protected override void DeserializeInternal(PortCollectionData collectionData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public sealed class OutputPortCollection : PortCollection<OutputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x1941BB0", Offset = "0x1940FB0", VA = "0x181941BB0")]
		public OutputPortCollection(Node node, PortCreationFactory<OutputPort> portCreationFactory)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	public interface IPortGroup : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		IReadOnlyCollection<PortBase> Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RemovePort(Guid portId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	public abstract class PortGroupBase<TPort> : IPortGroup, IDisposable, ICircuitSerializable<PortGroupData>, IReadOnlyPortGroup<TPort> where TPort : PortBase, ICircuitSerializable<NodePortData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private readonly Dictionary<Guid, TPort> groupPorts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private readonly List<TPort> orderedGroupPorts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private readonly PortCollection<TPort> parentCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private readonly Node node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected readonly PortCreationFactory<TPort> PortFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private readonly DynamicPortGroupModificationHandler<TPort> portGroupModificationHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		internal bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[CompilerGenerated]
		private Action OnDisposed;

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x1A76560", Offset = "0x1A75960", VA = "0x181A76560", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public IReadOnlyList<TPort> OrderedPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x3B0A90", Offset = "0x3AFE90", VA = "0x1803B0A90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(PortGroupSerialization);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public abstract PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public abstract SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public IReadOnlyCollection<TPort> Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0xE784D0", Offset = "0xE778D0", VA = "0x180E784D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IReadOnlyCollection<PortBase> IPortGroup.Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x119BD10", Offset = "0x119B110", VA = "0x18119BD10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public Guid GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x6126A0", Offset = "0x611AA0", VA = "0x1806126A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public string PortGroupName
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0x3F4310", Offset = "0x3F3710", VA = "0x1803F4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x453D20", Offset = "0x453120", VA = "0x180453D20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public virtual bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x38B250", Offset = "0x38A650", VA = "0x18038B250", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<TPort> OnPortAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x1A763E0", Offset = "0x1A757E0", VA = "0x181A763E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x1A76580", Offset = "0x1A75980", VA = "0x181A76580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<TPort> OnPortRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1A764A0", Offset = "0x1A758A0", VA = "0x181A764A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x1A76640", Offset = "0x1A75A40", VA = "0x181A76640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A75260", Offset = "0x1A74660", VA = "0x181A75260", Slot = "16")]
		public virtual bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A76190", Offset = "0x1A75590", VA = "0x181A76190")]
		protected PortGroupBase(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A760F0", Offset = "0x1A754F0", VA = "0x181A760F0")]
		public bool TryGetRegisteredPort(Guid portId, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A74FF0", Offset = "0x1A743F0", VA = "0x181A74FF0")]
		protected void AddGroupPort(TPort port, [Optional] bool? isDynamicOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A758F0", Offset = "0x1A74CF0", VA = "0x181A758F0")]
		protected bool RemoveGroupPort(TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A759B0", Offset = "0x1A74DB0", VA = "0x181A759B0", Slot = "8")]
		public bool RemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A75F90", Offset = "0x1A75390", VA = "0x181A75F90", Slot = "17")]
		public PortGroupData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A75C90", Offset = "0x1A75090", VA = "0x181A75C90", Slot = "18")]
		protected virtual void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x1A752A0", Offset = "0x1A746A0", VA = "0x181A752A0", Slot = "10")]
		public void DeserializeFromProtobuf(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A75300", Offset = "0x1A74700", VA = "0x181A75300", Slot = "19")]
		protected virtual void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1A75590", Offset = "0x1A74990", VA = "0x181A75590", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A75A40", Offset = "0x1A74E40", VA = "0x181A75A40", Slot = "20")]
		public void RequestAddPort(Guid portId, [Optional] string portName, [Optional] CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x1A75B90", Offset = "0x1A74F90", VA = "0x181A75B90", Slot = "21")]
		public void RequestRemovePort(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void HandleAddPortRequest(NodePortData newPortRequest);

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void HandleRemovePortRequest(Guid portId);
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	public enum PortGroupSerialization
	{
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		BuiltInGroup_BuiltInPorts,
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		BuiltInGroup_DynamicPorts,
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		DynamicGroup_DynamicPorts
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[NodeTag("Value Modifiers", new string[] { })]
	public abstract class PureNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D00", Offset = "0x14C1100", VA = "0x1814C1D00")]
		protected PureNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x14C1D30", Offset = "0x14C1130", VA = "0x1814C1D30")]
		protected PureNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	public abstract class SingleExecutableNode : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private static Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private static Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public OutputPort OutputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x3F4020", Offset = "0x3F3420", VA = "0x1803F4020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		protected NextExecutable NextExecutable
		{
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x171AD50", Offset = "0x171A150", VA = "0x18171AD50")]
			get
			{
				return default(NextExecutable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x1944310", Offset = "0x1943710", VA = "0x181944310")]
		protected SingleExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x19445A0", Offset = "0x19439A0", VA = "0x1819445A0")]
		protected SingleExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x1944200", Offset = "0x1943600", VA = "0x181944200", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void ExecuteInternal(IExecutionScope executionScope);
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	public class CircuitObjectTransform : ICircuitSerializable<CircuitObjectTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		public delegate void OnLocalPositionChangedEvent(Vector3 newLocalPosition);

		[Cpp2IlInjected.Token(Token = "0x200016F")]
		public delegate void OnLocalRotationChangedEvent(Quaternion newLocalRotation);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private readonly Guid circuitObjectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private Quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public Vector3 LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x422ED0", Offset = "0x4222D0", VA = "0x180422ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Quaternion LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x14BEB70", Offset = "0x14BDF70", VA = "0x1814BEB70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event OnLocalPositionChangedEvent OnLocalPositionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x14BEA30", Offset = "0x14BDE30", VA = "0x1814BEA30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x14BEB80", Offset = "0x14BDF80", VA = "0x1814BEB80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event OnLocalRotationChangedEvent OnLocalRotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x14BEAD0", Offset = "0x14BDED0", VA = "0x1814BEAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x14BEC20", Offset = "0x14BE020", VA = "0x1814BEC20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x61B1B0", Offset = "0x61A5B0", VA = "0x18061B1B0")]
		public CircuitObjectTransform(Guid circuitObjectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x14BE880", Offset = "0x14BDC80", VA = "0x1814BE880")]
		public void SetLocalPosition(Vector3 newLocalPosition, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x14BE970", Offset = "0x14BDD70", VA = "0x1814BE970")]
		public void SetLocalRotation(Quaternion newLocalRotation, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x14BE7B0", Offset = "0x14BDBB0", VA = "0x1814BE7B0", Slot = "5")]
		public CircuitObjectTransformData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x14BE600", Offset = "0x14BDA00", VA = "0x1814BE600", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitObjectTransformData protobuf)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	public class CircuitTokenFlag
	{
		[Cpp2IlInjected.Token(Token = "0x2000171")]
		public class CircuitToken
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private readonly string tokenName;

			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB70", Offset = "0x3AAF70", VA = "0x1803ABB70")]
			public CircuitToken(string tokenName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x14C06D0", Offset = "0x14BFAD0", VA = "0x1814C06D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[CanBeNull]
		private HashSet<CircuitToken> _circuitTokens;

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0x14C0680", Offset = "0x14BFA80", VA = "0x1814C0680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x14C0490", Offset = "0x14BF890", VA = "0x1814C0490")]
		public bool AddToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x14C0560", Offset = "0x14BF960", VA = "0x1814C0560")]
		public bool RemoveToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x384140", Offset = "0x383540", VA = "0x180384140")]
		public CircuitTokenFlag()
		{
		}
	}
}
namespace CircuitsV2.Graph.Nodes
{
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	public struct CircuitPlayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public readonly int BackingPlayerId;

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x13DF80", Offset = "0x13D380", VA = "0x18013DF80")]
		public CircuitPlayer(int backingPlayerId)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	public struct CircuitTeam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public readonly int BackingTeamId;

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x13DF80", Offset = "0x13D380", VA = "0x18013DF80")]
		public CircuitTeam(int backingTeamId = -1)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Guid("21B7F027-68C6-4C8C-A5C3-81992622DE80")]
	public class ChangeCircuitObjectNameModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x1716140", Offset = "0x1715540", VA = "0x181716140")]
		public ChangeCircuitObjectNameModificationHandler(CircuitObject modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x1716080", Offset = "0x1715480", VA = "0x181716080")]
		public ICircuitObjectModification CreateModification(string newNodeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x17160D0", Offset = "0x17154D0", VA = "0x1817160D0", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public abstract class CircuitObjectModificationHandlerBase<T> : ICircuitObjectModificationHandler where T : CircuitObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected readonly T ModifiedObject;

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public virtual Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x1A6CB00", Offset = "0x1A6BF00", VA = "0x181A6CB00", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x102AA00", Offset = "0x1029E00", VA = "0x18102AA00")]
		protected CircuitObjectModificationHandlerBase(T modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HandleModificationRequest(byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x1A6CA30", Offset = "0x1A6BE30", VA = "0x181A6CA30")]
		protected ICircuitObjectModification WithPayload(string payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x1A6CAB0", Offset = "0x1A6BEB0", VA = "0x181A6CAB0")]
		protected ICircuitObjectModification WithPayload(IMessage payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C9B0", Offset = "0x1A6BDB0", VA = "0x181A6C9B0")]
		protected ICircuitObjectModification WithPayload(byte[] payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C970", Offset = "0x1A6BD70", VA = "0x181A6C970")]
		protected static string ParseStringPayload(byte[] payload)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public abstract class NodeModificationHandlerBase : CircuitObjectModificationHandlerBase<Node>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x1725A50", Offset = "0x1724E50", VA = "0x181725A50")]
		protected NodeModificationHandlerBase(Node modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public abstract class NodeModificationHandlerBase<T> : CircuitObjectModificationHandlerBase<T> where T : Node
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x101A6A0", Offset = "0x1019AA0", VA = "0x18101A6A0")]
		protected NodeModificationHandlerBase(T modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public abstract class EventModificationHandlerBase : CircuitObjectModificationHandlerBase<CircuitEventObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x171A570", Offset = "0x1719970", VA = "0x18171A570")]
		protected EventModificationHandlerBase(CircuitEventObject modifiedEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public interface ICircuitObjectModificationHandler
	{
		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A07")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HandleModificationRequest(byte[] payload);
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public interface ICircuitObjectModification
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		CircuitObject ModifiedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		byte[] GetPayload();

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Send();
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public class ModificationBase : ICircuitObjectModification
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private readonly byte[] payload;

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0x3F41E0", Offset = "0x3F35E0", VA = "0x1803F41E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public CircuitObject ModifiedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x38BA10", Offset = "0x38AE10", VA = "0x18038BA10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x17244B0", Offset = "0x17238B0", VA = "0x1817244B0")]
		public ModificationBase(ICircuitObjectModificationHandler handler, CircuitObject modifiedObject, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0", Slot = "6")]
		public byte[] GetPayload()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x1724470", Offset = "0x1723870", VA = "0x181724470", Slot = "7")]
		public void Send()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Guid("88EC6D1C-1F68-4A30-AD72-71A8AA1B933A")]
	public class PortDefaultValueModificationHandler : NodeModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x1725A50", Offset = "0x1724E50", VA = "0x181725A50")]
		public PortDefaultValueModificationHandler(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x1729B30", Offset = "0x1728F30", VA = "0x181729B30")]
		public ICircuitObjectModification CreateModification(Guid portId, CircuitSignal defaultSignal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x1729C00", Offset = "0x1729000", VA = "0x181729C00", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[InternalNode]
	[NodeTag("Debug", new string[] { })]
	[Guid("6C9E8939-6963-4803-9F22-90EE32382B0A")]
	public class DebugLogNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private static readonly Guid logStringPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private readonly InputPort logStringPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private readonly RateLimiter logRateLimiter;

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x1718920", Offset = "0x1717D20", VA = "0x181718920")]
		public DebugLogNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x17187E0", Offset = "0x1717BE0", VA = "0x1817187E0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[Guid("7ADC6AB1-FCAB-4746-AEC6-006352E29CDC")]
	public sealed class BranchNode : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly Guid executeId;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static readonly Guid ifId;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private static readonly Guid thenId;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private static readonly Guid elseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public readonly InputPort InputExecPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public readonly InputPort IfPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public readonly OutputPort ThenPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public readonly OutputPort ElsePort;

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x17151E0", Offset = "0x17145E0", VA = "0x1817151E0")]
		public BranchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x1715020", Offset = "0x1714420", VA = "0x181715020", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[InternalNode]
	[Guid("9478334A-451D-4802-BAB1-4B05F00D45E4")]
	public sealed class BreakTuple : Node
	{
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private static readonly Guid inputPortId;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly Guid outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly InputPort inputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private readonly NameBasedPortGroup<OutputPort> outputPortGroup;

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x1715BD0", Offset = "0x1714FD0", VA = "0x181715BD0")]
		public BreakTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x1715910", Offset = "0x1714D10", VA = "0x181715910")]
		private CircuitSignal GetReturn0(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x1715A20", Offset = "0x1714E20", VA = "0x181715A20")]
		private CircuitSignal GetReturn1(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[Guid("14EBDE7A-76C0-47DF-B0DD-01B1DAA50821")]
	public sealed class CircuitBoard : CircuitContextNode<CircuitBoard.InnerContextEntryNode, CircuitBoard.InnerContextExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000181")]
		[InternalNode]
		[Guid("F965D1E5-D418-4DA3-A777-4846979707E2")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x1720FA0", Offset = "0x17203A0", VA = "0x181720FA0")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000182")]
		[InternalNode]
		[Guid("50D4E4A0-EB29-428A-BF11-ED58B6686B2C")]
		public class InnerContextExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x17217B0", Offset = "0x1720BB0", VA = "0x1817217B0")]
			public InnerContextExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000183")]
		[Guid("9138579F-BB0F-4D9B-A052-BD28373625A4")]
		internal class CircuitBoardModificationHandler : NodeModificationHandlerBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private readonly CircuitBoard modifiedNode;

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x1716690", Offset = "0x1715A90", VA = "0x181716690")]
			public CircuitBoardModificationHandler(CircuitBoard modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x1716190", Offset = "0x1715590", VA = "0x181716190")]
			public ICircuitObjectModification CreateExecGroupModification(string newExecGroupName, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x1716240", Offset = "0x1715640", VA = "0x181716240")]
			public ICircuitObjectModification DeleteExecGroupModification(Guid execGroupId, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x1716310", Offset = "0x1715710", VA = "0x181716310", Slot = "7")]
			public override void HandleModificationRequest(byte[] payload)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private static readonly Guid executeOutputGroupBase;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private static readonly Guid executeInputGroupBase;

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public override bool CanAddInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0x38B250", Offset = "0x38A650", VA = "0x18038B250", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public override bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x38B250", Offset = "0x38A650", VA = "0x18038B250", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x1717760", Offset = "0x1716B60", VA = "0x181717760")]
		public CircuitBoard(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x17166E0", Offset = "0x1715AE0", VA = "0x1817166E0")]
		[EditableAddExecInput]
		internal ExecNameBasedPortGroup<InputPort> AddExecInput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x17168E0", Offset = "0x1715CE0", VA = "0x1817168E0")]
		[EditableAddExecOutput]
		internal ExecNameBasedPortGroup<OutputPort> AddExecOutput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x17171C0", Offset = "0x17165C0", VA = "0x1817171C0")]
		internal void RemoveExecInput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x17172F0", Offset = "0x17166F0", VA = "0x1817172F0")]
		internal void RemoveExecOutput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x1716AE0", Offset = "0x1715EE0", VA = "0x181716AE0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x1716ED0", Offset = "0x17162D0", VA = "0x181716ED0", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x1717420", Offset = "0x1716820", VA = "0x181717420", Slot = "24")]
		public override bool RequestAddInputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x17174C0", Offset = "0x17168C0", VA = "0x1817174C0", Slot = "26")]
		public override bool RequestAddOutputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x1717560", Offset = "0x1716960", VA = "0x181717560", Slot = "28")]
		public override bool RequestRemoveInputGroup(Guid groupId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x1717610", Offset = "0x1716A10", VA = "0x181717610", Slot = "30")]
		public override bool RequestRemoveOutputGroup(Guid groupId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public interface ICircuitContextNode
	{
		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		CircuitContext InnerContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public abstract class CircuitContextNode : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public Guid InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x952C90", Offset = "0x952090", VA = "0x180952C90")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public virtual bool CanAddInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public virtual bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public virtual bool CanRemoveInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public virtual bool CanRemoveOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x1717990", Offset = "0x1716D90", VA = "0x181717990")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x1717940", Offset = "0x1716D40", VA = "0x181717940", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "24")]
		public virtual bool RequestAddInputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "26")]
		public virtual bool RequestAddOutputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "28")]
		public virtual bool RequestRemoveInputGroup(Guid portGroup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x388F30", Offset = "0x388330", VA = "0x180388F30", Slot = "30")]
		public virtual bool RequestRemoveOutputGroup(Guid portGroup)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public abstract class CircuitContextNode<TEntryNode, TExitNode> : CircuitContextNode, ICircuitContextNode where TEntryNode : InnerContextEntryNodeBase, IEntryNode where TExitNode : InnerContextExitNodeBase, IExitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private readonly CircuitContext childContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private HashSet<TEntryNode> _cachedEntryNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private HashSet<TExitNode> _cachedExitNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private bool childContextNeedsInitialization;

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public CircuitContext InnerContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		protected HashSet<TEntryNode> CachedEntryNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x1A6C390", Offset = "0x1A6B790", VA = "0x181A6C390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		protected HashSet<TExitNode> CachedExitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x1A6C680", Offset = "0x1A6BA80", VA = "0x181A6C680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CircuitContext ChildContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C150", Offset = "0x1A6B550", VA = "0x181A6C150")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C0E0", Offset = "0x1A6B4E0", VA = "0x181A6C0E0")]
		private void OnNodeAddedOrRemoved(CircuitContext context, Node modifiedNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BFF0", Offset = "0x1A6B3F0", VA = "0x181A6BFF0")]
		private void DirtyCachedExitNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C090", Offset = "0x1A6B490", VA = "0x181A6C090", Slot = "16")]
		public sealed override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C000", Offset = "0x1A6B400", VA = "0x181A6C000", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "32")]
		protected virtual void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C040", Offset = "0x1A6B440", VA = "0x181A6C040", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		protected abstract NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x1A6B730", Offset = "0x1A6AB30", VA = "0x181A6B730", Slot = "34")]
		protected virtual bool AddInnerEntry(InputPort execInput, out TEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BB60", Offset = "0x1A6AF60", VA = "0x181A6BB60", Slot = "35")]
		internal virtual bool AddInnerExit(OutputPort execOutput, out TExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1A6BFB0", Offset = "0x1A6B3B0", VA = "0x181A6BFB0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public abstract class InnerNodeBase<TPort> : ExecutableNode where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private static readonly Guid executePortId;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private static readonly Guid valuePortGroupId;

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public TPort ExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public NameBasedPortGroup<TPort> ValuePortGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0x3F4020", Offset = "0x3F3420", VA = "0x1803F4020", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public ICircuitContextNode Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x400560", Offset = "0x3FF960", VA = "0x180400560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		protected abstract PortCollection<TPort> PortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x1A70940", Offset = "0x1A6FD40", VA = "0x181A70940")]
		protected InnerNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[InternalNode]
	public abstract class InnerContextEntryNodeBase : InnerNodeBase<OutputPort>, IEntryNode
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		protected sealed override PortCollection<OutputPort> PortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0x3F42A0", Offset = "0x3F36A0", VA = "0x1803F42A0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x1720D60", Offset = "0x1720160", VA = "0x181720D60")]
		protected InnerContextEntryNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x1720CE0", Offset = "0x17200E0", VA = "0x181720CE0", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[InternalNode]
	public abstract class InnerContextExitNodeBase : InnerNodeBase<InputPort>, IExitNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public OutputPort ParentOutputExecPort;

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		protected sealed override PortCollection<InputPort> PortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x3F4270", Offset = "0x3F3670", VA = "0x1803F4270", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x1721710", Offset = "0x1720B10", VA = "0x181721710")]
		protected InnerContextExitNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x1721670", Offset = "0x1720A70", VA = "0x181721670", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public interface IEntryNode
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public interface IExitNode
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[Guid("CEFEE2A5-D4A8-4DFF-8C4E-BAD684CA8D34")]
	public class DelayNode : ExecutableNode, ICircuitEventHandler
	{
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private readonly InputPort inputExecPort;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private static readonly Guid immediateExecuteOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private readonly OutputPort immediateOutputExecPort;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly Guid afterDelayExecuteOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private readonly OutputPort afterDelayOutputExecPort;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private static readonly Guid delayId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private readonly CircuitEventDefinition myEventDefinition;

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public InputPort DelayInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x1718F50", Offset = "0x1718350", VA = "0x181718F50")]
		public DelayNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x1718C80", Offset = "0x1718080", VA = "0x181718C80", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x1718B60", Offset = "0x1717F60", VA = "0x181718B60", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x1718D90", Offset = "0x1718190", VA = "0x181718D90", Slot = "23")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x1718C10", Offset = "0x1718010", VA = "0x181718C10")]
		private void ExecuteAfterDelay(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[NodeTag("Events", new string[] { })]
	public abstract class EventNodeBase : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[Guid("D2C5C13D-2AF9-4632-B80F-E434C96608FB")]
		private class EventRegistrationNodeModificationHandler : NodeModificationHandlerBase<EventNodeBase>
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0x171B630", Offset = "0x171AA30", VA = "0x18171B630")]
			public EventRegistrationNodeModificationHandler(EventNodeBase modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x171B540", Offset = "0x171A940", VA = "0x18171B540")]
			public ICircuitObjectModification CreateSetRegistrationModification(CircuitEventBus.EventRegistration eventRegistration)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x171B5A0", Offset = "0x171A9A0", VA = "0x18171B5A0", Slot = "7")]
			public override void HandleModificationRequest(byte[] payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private CircuitEventBus.EventRegistration eventRegistration;

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		internal abstract IEditableNameBasedPortGroup EventValuesGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public CircuitEventBus.EventRegistration EventRegistration
		{
			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x171A9E0", Offset = "0x1719DE0", VA = "0x18171A9E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices();

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x171A930", Offset = "0x1719D30", VA = "0x18171A930")]
		protected EventNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x171A5C0", Offset = "0x17199C0", VA = "0x18171A5C0", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x171A650", Offset = "0x1719A50", VA = "0x18171A650")]
		private void RefreshPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "25")]
		protected virtual void RegisterNewEventRegistration([NotNull] CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x3842F0", Offset = "0x3836F0", VA = "0x1803842F0", Slot = "26")]
		protected virtual void UnregisterOldEventRegistration([NotNull] CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x171A880", Offset = "0x1719C80", VA = "0x18171A880")]
		protected void SetEventRegistrationFromData(EventRegistrationData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId);

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x171A7C0", Offset = "0x1719BC0", VA = "0x18171A7C0")]
		public void RequestEventRegistrationChange(CircuitEventBus.EventRegistration setEventRegistration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[NodeTag("Events", new string[] { })]
	[Guid("8B533CCB-643A-491D-982C-94417CE99954")]
	public class EventReceiverNode : EventNodeBase, ICircuitEventHandler
	{
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public readonly OutputPort OutputExecPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private readonly Guid eventValuesGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private readonly NameBasedPortGroup<OutputPort> eventValuesGroup;

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		internal override IEditableNameBasedPortGroup EventValuesGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x1803F41A0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x171B2C0", Offset = "0x171A6C0", VA = "0x18171B2C0")]
		public EventReceiverNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x171AD50", Offset = "0x171A150", VA = "0x18171AD50", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x171B1A0", Offset = "0x171A5A0", VA = "0x18171B1A0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x171ACB0", Offset = "0x171A0B0", VA = "0x18171ACB0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x171B230", Offset = "0x171A630", VA = "0x18171B230", Slot = "26")]
		protected override void UnregisterOldEventRegistration(CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x171ADA0", Offset = "0x171A1A0", VA = "0x18171ADA0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x171ADF0", Offset = "0x171A1F0", VA = "0x18171ADF0", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x171B170", Offset = "0x171A570", VA = "0x18171B170", Slot = "25")]
		protected override void RegisterNewEventRegistration(CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x171AE20", Offset = "0x171A220", VA = "0x18171AE20", Slot = "28")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[NodeTag("Events", new string[] { })]
	[Guid("96A8FE50-BC37-458B-BAC9-582D45314779")]
	public class EventSenderNode : EventNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private readonly Guid eventValuesGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private readonly NameBasedPortGroup<InputPort> eventValuesGroup;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private static Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private static Guid executeOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private readonly RateLimiter myRateLimiter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public readonly bool SendSyncEvent;

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		internal override IEditableNameBasedPortGroup EventValuesGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x1803F41A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public OutputPort OutputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0x39F630", Offset = "0x39EA30", VA = "0x18039F630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x171BC30", Offset = "0x171B030", VA = "0x18171BC30")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId, bool sendSyncEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x171C000", Offset = "0x171B400", VA = "0x18171C000")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x171BAB0", Offset = "0x171AEB0", VA = "0x18171BAB0", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x171BA60", Offset = "0x171AE60", VA = "0x18171BA60", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x171BA00", Offset = "0x171AE00", VA = "0x18171BA00", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x171B720", Offset = "0x171AB20", VA = "0x18171B720")]
		protected void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x171BAE0", Offset = "0x171AEE0", VA = "0x18171BAE0", Slot = "28")]
		protected virtual void SendEventInternal(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x171BB00", Offset = "0x171AF00", VA = "0x18171BB00", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x171B680", Offset = "0x171AA80", VA = "0x18171B680", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[NodeTag("Networking", new string[] { })]
	[Guid("19572058-D738-4E6D-9C89-D5DEE7F5C903")]
	public class SynchedEventSenderNode : EventSenderNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[Guid("FF39CC84-7A64-4730-AEF8-A7746E6F5727")]
		public class SyncedEventSenderModificationHandler : NodeModificationHandlerBase<SynchedEventSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170001F7")]
			public SynchedEventSenderNode EventSenderNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000A93")]
				[Cpp2IlInjected.Address(RVA = "0x3A66D0", Offset = "0x3A5AD0", VA = "0x1803A66D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x172D090", Offset = "0x172C490", VA = "0x18172D090")]
			public SyncedEventSenderModificationHandler(SynchedEventSenderNode modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x172CFC0", Offset = "0x172C3C0", VA = "0x18172CFC0")]
			public ICircuitObjectModification CreateChangeTargetModification(SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x172D040", Offset = "0x172C440", VA = "0x18172D040", Slot = "7")]
			public override void HandleModificationRequest(byte[] payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private SynchronizedCircuitContext.SyncedEventTargets synchedEventTarget;

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public SynchronizedCircuitContext.SyncedEventTargets Target
		{
			[Cpp2IlInjected.Token(Token = "0x6000A90")]
			[Cpp2IlInjected.Address(RVA = "0x3FF860", Offset = "0x3FEC60", VA = "0x1803FF860")]
			get
			{
				return default(SynchronizedCircuitContext.SyncedEventTargets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x172D620", Offset = "0x172CA20", VA = "0x18172D620")]
		public SynchedEventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x172D5E0", Offset = "0x172C9E0", VA = "0x18172D5E0", Slot = "28")]
		protected override void SendEventInternal(CircuitEvent circuitEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[NodeTag("Loops", new string[] { })]
	[Guid("9A4AAEC1-019F-4912-8FF1-F703381D5832")]
	public class ForeachNode : CircuitContextNode<ForeachNode.InnerContextEntryNode, ForeachNode.BreakExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		[Guid("D377C07B-9628-46DE-BB53-0AE6B6069AD3")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public readonly OutputPort ArrayElementPort;

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x1721360", Offset = "0x1720760", VA = "0x181721360")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x1720E00", Offset = "0x1720200", VA = "0x181720E00", Slot = "21")]
			public override IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000199")]
		[InternalNode]
		[Guid("6FFDEC42-782E-4C79-A6C2-6393FB9275D0")]
		public class BreakExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x170001FB")]
			public bool Break
			{
				[Cpp2IlInjected.Token(Token = "0x6000AA7")]
				[Cpp2IlInjected.Address(RVA = "0xE3E040", Offset = "0xE3D440", VA = "0x180E3E040")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000AA8")]
				[Cpp2IlInjected.Address(RVA = "0xE3CB80", Offset = "0xE3BF80", VA = "0x180E3CB80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x1715820", Offset = "0x1714C20", VA = "0x181715820")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0x1715620", Offset = "0x1714A20", VA = "0x181715620", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x1715720", Offset = "0x1714B20", VA = "0x181715720")]
			public void ResetBreak()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private static readonly Guid arrayPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private readonly InputPort arrayInputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private readonly NameBasedPortGroup<InputPort> valueInputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private readonly NameBasedPortGroup<OutputPort> valueOutputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private BreakExitNode returnNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private InnerContextEntryNode entryNode;

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x3F40C0", Offset = "0x3F34C0", VA = "0x1803F40C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public OutputPort OutputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EB0", Offset = "0x3C62B0", VA = "0x1803C6EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public InnerContextEntryNode EntryNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x3F40F0", Offset = "0x3F34F0", VA = "0x1803F40F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x171DB50", Offset = "0x171CF50", VA = "0x18171DB50")]
		public ForeachNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x171DA00", Offset = "0x171CE00", VA = "0x18171DA00", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x171D550", Offset = "0x171C950", VA = "0x18171D550", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x171D5E0", Offset = "0x171C9E0", VA = "0x18171D5E0", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x171D420", Offset = "0x171C820", VA = "0x18171D420", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x171D4C0", Offset = "0x171C8C0", VA = "0x18171D4C0", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x171D920", Offset = "0x171CD20", VA = "0x18171D920", Slot = "21")]
		public override IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[NodeTag("Loops", new string[] { })]
	[Guid("495D52DC-EDF0-4498-92CA-6B80EC48A462")]
	public class ForNode : CircuitContextNode<ForNode.InnerContextEntryNode, ForNode.BreakExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[Guid("3B0E812B-30F8-41E4-B55B-AD54B393C1F3")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			private static readonly Guid indexId;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public readonly OutputPort IndexPort;

			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0x1721080", Offset = "0x1720480", VA = "0x181721080")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[Guid("CBB04F96-C285-4C6C-8F15-1B88B78FC0B0")]
		public class BreakExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x17000200")]
			public bool Break
			{
				[Cpp2IlInjected.Token(Token = "0x6000ABE")]
				[Cpp2IlInjected.Address(RVA = "0xE3E040", Offset = "0xE3D440", VA = "0x180E3E040")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000ABF")]
				[Cpp2IlInjected.Address(RVA = "0xE3CB80", Offset = "0xE3BF80", VA = "0x180E3CB80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x1715730", Offset = "0x1714B30", VA = "0x181715730")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x17156A0", Offset = "0x1714AA0", VA = "0x1817156A0", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x1715720", Offset = "0x1714B20", VA = "0x181715720")]
			public void ResetBreak()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly Guid fromId;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private static readonly Guid toId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private BreakExitNode returnNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private InnerContextEntryNode entryNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private readonly NameBasedPortGroup<InputPort> valueInputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private readonly NameBasedPortGroup<OutputPort> valueOutputGroup;

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x3F40C0", Offset = "0x3F34C0", VA = "0x1803F40C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public OutputPort OutputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EB0", Offset = "0x3C62B0", VA = "0x1803C6EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public InputPort FromInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x3F4150", Offset = "0x3F3550", VA = "0x1803F4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public InputPort ToInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB1")]
			[Cpp2IlInjected.Address(RVA = "0x3F40E0", Offset = "0x3F34E0", VA = "0x1803F40E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x171CE30", Offset = "0x171C230", VA = "0x18171CE30")]
		public ForNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x171CCB0", Offset = "0x171C0B0", VA = "0x18171CCB0", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x171C9D0", Offset = "0x171BDD0", VA = "0x18171C9D0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x171C8A0", Offset = "0x171BCA0", VA = "0x18171C8A0", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x171C940", Offset = "0x171BD40", VA = "0x18171C940", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x171CA60", Offset = "0x171BE60", VA = "0x18171CA60", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[Guid("E8C5082F-0A75-4025-9679-293BC8D72989")]
	[NodeTag("Lists", new string[] { })]
	public sealed class GetElementNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private static readonly Guid inputArrayPortId;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private static readonly Guid inputIndexPortId;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private readonly InputPort inputArrayPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private readonly InputPort inputIndexPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private readonly OutputPort outputPort;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x171E790", Offset = "0x171DB90", VA = "0x18171E790")]
		public GetElementNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x171E560", Offset = "0x171D960", VA = "0x18171E560")]
		private CircuitSignal Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[Guid("0493204D-9815-49A9-8C87-4DEDF5CCF7E8")]
	[NodeTag("Lists", new string[] { })]
	public class GetListCountNode : TypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x171EC60", Offset = "0x171E060", VA = "0x18171EC60")]
		public GetListCountNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x171EBE0", Offset = "0x171DFE0", VA = "0x18171EBE0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[NodeTag("Networking", new string[] { })]
	[Guid("B8B667B9-7B55-4B8D-B116-ABEF220777E2")]
	public class HasAuthorityNode : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private readonly InputPort executeInputPort;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private static readonly Guid executeHasAuthorityPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private readonly OutputPort executeHasAuthorityPort;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private static readonly Guid executeNotAuthorityPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private readonly OutputPort executeNotAuthorityPort;

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0x171FCC0", Offset = "0x171F0C0", VA = "0x18171FCC0")]
		public HasAuthorityNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x171FB60", Offset = "0x171EF60", VA = "0x18171FB60", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[NodeTag("Lists", new string[] { })]
	[Guid("542D3256-0D51-4C33-A2A1-FBC44B7E1F07")]
	public class MakeListNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private static readonly Guid valueInputPortGroupId;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private static readonly Guid arrayPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private readonly IndexBasedPortGroup<InputPort> valueInputPortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private readonly OutputPort returnPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private CircuitSignal returnValue;

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0x1723950", Offset = "0x1722D50", VA = "0x181723950")]
		public MakeListNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x1723820", Offset = "0x1722C20", VA = "0x181723820", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[InternalNode]
	[Guid("BEE72C1D-266B-4EA4-B185-7500618030C6")]
	public sealed class MakeTuple : Node
	{
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private static readonly Guid inputPortGroupId;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private readonly NameBasedPortGroup<InputPort> inputPortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private readonly OutputPort returnPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private readonly InputPort port0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private readonly InputPort port1;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x1723EF0", Offset = "0x17232F0", VA = "0x181723EF0")]
		public MakeTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x1723D00", Offset = "0x1723100", VA = "0x181723D00")]
		private CircuitSignal GetReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	public struct NextExecutable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[CanBeNull]
		public readonly ExecutableNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[CanBeNull]
		public readonly InputPort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public readonly bool HasValues;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly NextExecutable EMPTY;

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x201C60", Offset = "0x201060", VA = "0x180201C60")]
		public NextExecutable(ExecutableNode node, InputPort port)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[NodeTag("Random", new string[] { })]
	public abstract class RandomNumberGeneratorNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private static readonly Guid fromPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		protected readonly InputPort FromPort;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private static readonly Guid toPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		protected readonly InputPort ToPort;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private static readonly Guid returnPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public OutputPort ReturnPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private CircuitSignal randomSignal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected readonly System.Random Random;

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x172B4E0", Offset = "0x172A8E0", VA = "0x18172B4E0")]
		protected RandomNumberGeneratorNode(CircuitContext circuitContext, CircuitType numberType, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x172B2F0", Offset = "0x172A6F0", VA = "0x18172B2F0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal);

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x172B3F0", Offset = "0x172A7F0", VA = "0x18172B3F0")]
		private CircuitSignal ReturnRandom(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[Guid("FB2645F0-4042-4EF1-B988-AF2F80E651EC")]
	public class RandomIntegerGeneratorNode : RandomNumberGeneratorNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x172B0D0", Offset = "0x172A4D0", VA = "0x18172B0D0")]
		public RandomIntegerGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x172AFF0", Offset = "0x172A3F0", VA = "0x18172AFF0", Slot = "24")]
		protected override CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[Guid("4ECBF247-AB14-4F9E-8094-E40A45D283E6")]
	public class RandomFloatGeneratorNode : RandomNumberGeneratorNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0x172ADF0", Offset = "0x172A1F0", VA = "0x18172ADF0")]
		public RandomFloatGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0x172ACB0", Offset = "0x172A0B0", VA = "0x18172ACB0", Slot = "24")]
		protected override CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[Guid("76187060-C0B0-4EC6-B082-FF81754CFF25")]
	[NodeTag("Variable", new string[] { })]
	public class SetValueNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private static readonly Guid valuePortId;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private static readonly Guid variablePortId;

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public InputPort VariablePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public InputPort NewValuePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x172BD40", Offset = "0x172B140", VA = "0x18172BD40")]
		public SetValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x172BC30", Offset = "0x172B030", VA = "0x18172BC30", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[Guid("61BC2310-69F5-4DFA-B43C-12AE98DD05AB")]
	public class ShowNotificationNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private static readonly Guid valuePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private readonly InputPort valuePort;

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0x172C150", Offset = "0x172B550", VA = "0x18172C150")]
		public ShowNotificationNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x172C010", Offset = "0x172B410", VA = "0x18172C010", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	public abstract class SwitchNode<T> : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly Guid executeId;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private static readonly Guid switchId;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private static readonly Guid defaultId;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly Guid caseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private readonly InputPort executePort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private readonly InputPort switchPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly OutputPort defaultPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly IndexBasedPortGroup<OutputPort> casePortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly List<T> caseLabels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private Dictionary<T, OutputPort> caseMap;

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		protected abstract CircuitType SwitchPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE7")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract T GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x1A77880", Offset = "0x1A76C80", VA = "0x181A77880")]
		public SwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x1A76D10", Offset = "0x1A76110", VA = "0x181A76D10", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x1A76700", Offset = "0x1A75B00", VA = "0x181A76700")]
		protected Dictionary<T, OutputPort> BuildCaseMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x1A76DD0", Offset = "0x1A761D0", VA = "0x181A76DD0", Slot = "18")]
		protected sealed override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract SwitchNodeData SerializeCaseLables(IEnumerable<T> caseLables);

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x1A76B70", Offset = "0x1A75F70", VA = "0x181A76B70", Slot = "19")]
		protected sealed override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(Slot = "26")]
		protected abstract IEnumerable<T> DeserializeCaseLables(SwitchNodeData protobufData);
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[InternalNode]
	[Guid("543655EA-3A21-462B-9BD6-0460A45087E4")]
	public sealed class IntSwitchNode : SwitchNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		protected override CircuitType SwitchPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF6")]
			[Cpp2IlInjected.Address(RVA = "0x1722B30", Offset = "0x1721F30", VA = "0x181722B30", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x17229D0", Offset = "0x1721DD0", VA = "0x1817229D0", Slot = "24")]
		protected override int GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x1722AB0", Offset = "0x1721EB0", VA = "0x181722AB0")]
		public IntSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x1722A30", Offset = "0x1721E30", VA = "0x181722A30", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<int> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A10", Offset = "0x3A1E10", VA = "0x1803A2A10", Slot = "26")]
		protected override IEnumerable<int> DeserializeCaseLables(SwitchNodeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[InternalNode]
	[Guid("C273CBC2-0EE4-4CE2-B960-C16760B273F1")]
	public sealed class StringSwitchNode : SwitchNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000205")]
		protected override CircuitType SwitchPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFB")]
			[Cpp2IlInjected.Address(RVA = "0x172CDD0", Offset = "0x172C1D0", VA = "0x18172CDD0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x172CC70", Offset = "0x172C070", VA = "0x18172CC70", Slot = "24")]
		protected override string GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x172CD50", Offset = "0x172C150", VA = "0x18172CD50")]
		public StringSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x172CCD0", Offset = "0x172C0D0", VA = "0x18172CCD0", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<string> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x41F440", Offset = "0x41E840", VA = "0x18041F440", Slot = "26")]
		protected override IEnumerable<string> DeserializeCaseLables(SwitchNodeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	public interface IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		CircuitContext InnerContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[NodeTag("Boolean Logic", new string[] { })]
	public abstract class MultiInputBooleanLogicNode : PureNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private readonly int minPortCount;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private static readonly Guid valueInputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public readonly IndexBasedPortGroup<InputPort> ValueInputPortGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private readonly List<bool> inputs;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1724C30", Offset = "0x1724030", VA = "0x181724C30")]
		public MultiInputBooleanLogicNode(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x1724A30", Offset = "0x1723E30", VA = "0x181724A30")]
		private CircuitSignal GetBooleanReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool GetBooleanReturnInternal(List<bool> bools);
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[Guid("3FB9FD93-8D45-4395-B9A3-63A99A14442B")]
	public class AndNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x1714DC0", Offset = "0x17141C0", VA = "0x181714DC0")]
		public AndNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x1714CD0", Offset = "0x17140D0", VA = "0x181714CD0", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[Guid("B5DCDED0-EB2B-468D-A4B9-FFB1054F6214")]
	public class OrNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x17298D0", Offset = "0x1728CD0", VA = "0x1817298D0")]
		public OrNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x17297E0", Offset = "0x1728BE0", VA = "0x1817297E0", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[Guid("502E86D1-5B3A-4213-97E2-DF25836FFCC4")]
	public class NANDNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x17253C0", Offset = "0x17247C0", VA = "0x1817253C0")]
		public NANDNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x17252D0", Offset = "0x17246D0", VA = "0x1817252D0", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[Guid("2891BCB4-A6AB-4A2E-A08D-DD2A55F1CF66")]
	public class NORNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x1725550", Offset = "0x1724950", VA = "0x181725550")]
		public NORNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x1725460", Offset = "0x1724860", VA = "0x181725460", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[Guid("FF551243-BEB4-470E-AB48-9D616818D5E4")]
	[NodeTag("Boolean Logic", new string[] { })]
	public class NotNode : PureNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private static readonly Guid inputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public readonly InputPort InputPort;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1C")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x1728270", Offset = "0x1727670", VA = "0x181728270")]
		public NotNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x1728140", Offset = "0x1727540", VA = "0x181728140")]
		private CircuitSignal GetNotValue(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[Guid("A4F8A9A1-FD7B-4702-8345-93AE4D57F333")]
	public sealed class IfExpressionNode : PureNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private static readonly Guid ifId;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private static readonly Guid thenId;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private static readonly Guid elseId;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly Guid resultId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly InputPort ifPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private readonly InputPort thenPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private readonly InputPort elsePort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private readonly OutputPort resultPort;

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x1720200", Offset = "0x171F600", VA = "0x181720200")]
		public IfExpressionNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x1720030", Offset = "0x171F430", VA = "0x181720030")]
		private CircuitSignal GetResult(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[InternalNode]
	[Guid("A3576885-5DFC-46CF-9BCD-3C3ABED1DA55")]
	public class MakeDictionaryNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private static readonly Guid keyInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private static readonly Guid valueInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly Guid returnPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private readonly InputPort keyInputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private readonly InputPort valueInputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private readonly OutputPort outputPort;

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x1723280", Offset = "0x1722680", VA = "0x181723280")]
		public MakeDictionaryNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x1723130", Offset = "0x1722530", VA = "0x181723130")]
		private CircuitSignal Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[Guid("98B99011-9BE8-43B3-89CC-1E9D55BD8B51")]
	[NodeTag("Math", new string[] { })]
	public class AbsoluteValueNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly Guid inputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public readonly InputPort InputPort;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x1714550", Offset = "0x1713950", VA = "0x181714550")]
		public AbsoluteValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x1714370", Offset = "0x1713770", VA = "0x181714370", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x1714280", Offset = "0x1713680", VA = "0x181714280")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x1714180", Offset = "0x1713580", VA = "0x181714180")]
		private CircuitSignal GetFloatReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[Guid("0CCB153C-DD08-4F22-80FD-9D8C5940928C")]
	public class AddNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x1714C30", Offset = "0x1714030", VA = "0x181714C30")]
		public AddNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x1714A60", Offset = "0x1713E60", VA = "0x181714A60", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x1714A50", Offset = "0x1713E50", VA = "0x181714A50", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[Guid("F2EAFD78-5F23-44C9-A271-8FF2F0762E71")]
	public class DivideNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x1719850", Offset = "0x1718C50", VA = "0x181719850")]
		public DivideNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x1719620", Offset = "0x1718A20", VA = "0x181719620", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x1719820", Offset = "0x1718C20", VA = "0x181719820")]
		private static int SafeDivide(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x1719460", Offset = "0x1718860", VA = "0x181719460", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x1719800", Offset = "0x1718C00", VA = "0x181719800")]
		private static float SafeDivide(float numerator, float divisor)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[Guid("FE462E79-9E9F-4234-B594-7B6C0A69329B")]
	public class ModuloNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x1724990", Offset = "0x1723D90", VA = "0x181724990")]
		public ModuloNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x1724780", Offset = "0x1723B80", VA = "0x181724780", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x1724970", Offset = "0x1723D70", VA = "0x181724970")]
		private static int SafeModulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x17245A0", Offset = "0x17239A0", VA = "0x1817245A0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x1724950", Offset = "0x1723D50", VA = "0x181724950")]
		private static float SafeModulo(float numerator, float divisor)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[Guid("4738D696-D05A-42EE-A182-7641C429AE06")]
	public class MultiplyNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x1725230", Offset = "0x1724630", VA = "0x181725230")]
		public MultiplyNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x17250A0", Offset = "0x17244A0", VA = "0x1817250A0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x1724EF0", Offset = "0x17242F0", VA = "0x181724EF0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[Guid("288D4E89-EBED-41ED-A522-4C79BD48471A")]
	public class PowerNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x1729F20", Offset = "0x1729320", VA = "0x181729F20")]
		public PowerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x1729E70", Offset = "0x1729270", VA = "0x181729E70", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x1729DC0", Offset = "0x17291C0", VA = "0x181729DC0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[Guid("1FBB364C-1AF0-44BB-A82B-905CAEB6819A")]
	public class SubtractNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x172CF20", Offset = "0x172C320", VA = "0x18172CF20")]
		public SubtractNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x172CEA0", Offset = "0x172C2A0", VA = "0x18172CEA0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x172CE20", Offset = "0x172C220", VA = "0x18172CE20", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[Guid("1CB807B1-85E7-4C14-B3AE-5775B7873B7D")]
	public class MaxNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x1724310", Offset = "0x1723710", VA = "0x181724310")]
		public MaxNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x1724300", Offset = "0x1723700", VA = "0x181724300", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x17242F0", Offset = "0x17236F0", VA = "0x1817242F0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[Guid("BFB1AD17-5ADE-4BD8-9C31-6D4B1E47DAE3")]
	public class MinNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x17243D0", Offset = "0x17237D0", VA = "0x1817243D0")]
		public MinNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x17243C0", Offset = "0x17237C0", VA = "0x1817243C0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x17243B0", Offset = "0x17237B0", VA = "0x1817243B0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[NodeTag("Math", new string[] { })]
	public abstract class NumberNodeBase : PureNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private static readonly Guid valueInputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public readonly IndexBasedPortGroup<InputPort> ValueInputPortGroup;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private List<int> intInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private List<float> floatInputs;

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x17293A0", Offset = "0x17287A0", VA = "0x1817293A0")]
		public NumberNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount, int maxPortCount = int.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x17291C0", Offset = "0x17285C0", VA = "0x1817291C0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x1729010", Offset = "0x1728410", VA = "0x181729010")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x1728EB0", Offset = "0x17282B0", VA = "0x181728EB0")]
		private CircuitSignal GetFloatReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract int CalculateIntValue(IList<int> signals);

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract float CalculateFloatValue(IList<float> signals);
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[Guid("77AFC9DD-BAA9-4312-B8B8-7EF479C840E6")]
	[NodeTag("String", new string[] { })]
	public class StringFormatNode : PureNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private static readonly Guid formatPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[VisibleForTesting]
		internal readonly InputPort FormatPort;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private static readonly Guid valuesPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private NameBasedPortGroup<InputPort> valuesPortGroup;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private static readonly Guid outputStringPortId;

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0x3F4020", Offset = "0x3F3420", VA = "0x1803F4020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x172C7E0", Offset = "0x172BBE0", VA = "0x18172C7E0")]
		public StringFormatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x172C3C0", Offset = "0x172B7C0", VA = "0x18172C3C0")]
		private CircuitSignal GetOutputString(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	public abstract class ExternalVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		protected IExternalVariableNodeImplementation ExternalImplementation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x171C210", Offset = "0x171B610", VA = "0x18171C210")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x171C120", Offset = "0x171B520", VA = "0x18171C120", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x171C030", Offset = "0x171B430", VA = "0x18171C030", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	public abstract class ExternalVariableNode<TVal> : ExternalVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D970", Offset = "0x1A6CD70", VA = "0x181A6D970")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	public interface IExternalVariableNodeImplementation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitSignal GetValue();

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SetValue(CircuitSignal newValue);
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	public abstract class InMemoryVariableNode : VariableNodeBase, IVariableChangeListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private Memory.IMemoryHandle _memoryHandle;

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public bool IsSymbolicName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0x7D7410", Offset = "0x7D6810", VA = "0x1807D7410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x7D8310", Offset = "0x7D7710", VA = "0x1807D8310")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x8E4CB0", Offset = "0x8E40B0", VA = "0x1808E4CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected Memory.IMemoryHandle MemoryHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x1803F41A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x1720A30", Offset = "0x171FE30", VA = "0x181720A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		internal Guid MemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x1720930", Offset = "0x171FD30", VA = "0x181720930")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		protected Guid DefaultMemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x1720840", Offset = "0x171FC40", VA = "0x181720840")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x17207A0", Offset = "0x171FBA0", VA = "0x1817207A0")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x17206E0", Offset = "0x171FAE0", VA = "0x1817206E0", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	public abstract class InMemoryVariableNode<TVal> : InMemoryVariableNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly MemoryDelegates.ValueGetter getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly MemoryDelegates.ValueSetter setter;

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		private Guid AllocateVariableAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x1A6F800", Offset = "0x1A6EC00", VA = "0x181A6F800")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		private string AllocateVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x1A6FC60", Offset = "0x1A6F060", VA = "0x181A6FC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x1A6F640", Offset = "0x1A6EA40", VA = "0x181A6F640")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x1A6E7B0", Offset = "0x1A6DBB0", VA = "0x181A6E7B0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract Memory.IMemoryHandle Allocate(Guid defaultAddress, string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x1A6EE30", Offset = "0x1A6E230", VA = "0x181A6EE30", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x1A6E540", Offset = "0x1A6D940", VA = "0x181A6E540", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x1A6EB20", Offset = "0x1A6DF20", VA = "0x181A6EB20", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x1A6E610", Offset = "0x1A6DA10", VA = "0x181A6E610", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x1A6F2F0", Offset = "0x1A6E6F0", VA = "0x181A6F2F0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x1A6E720", Offset = "0x1A6DB20", VA = "0x181A6E720", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	public interface IVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterChangeListener(IVariableChangeListener changeListener);

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UnregisterChangeListener(IVariableChangeListener changeListener);
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[InternalNode]
	[Guid("D7224807-99D3-428A-B3F0-DF50CC96FE21")]
	public class BoolExternalVariableNode : ExternalVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x1714E60", Offset = "0x1714260", VA = "0x181714E60")]
		public BoolExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[InternalNode]
	[Guid("B8295B54-B9AD-4D99-A8BC-77BED41D1F54")]
	public class IntExternalVariableNode : ExternalVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x1722810", Offset = "0x1721C10", VA = "0x181722810")]
		public IntExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[InternalNode]
	[Guid("8B2531DC-2C87-4300-834F-6CA9AD19F62A")]
	public class FloatExternalVariableNode : ExternalVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x171C2B0", Offset = "0x171B6B0", VA = "0x18171C2B0")]
		public FloatExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[InternalNode]
	[Guid("04088018-9D4B-458E-9B5F-AA2DF1605D7C")]
	[NodeTag("String", new string[] { })]
	public class StringExternalVariableNode : ExternalVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x172C330", Offset = "0x172B730", VA = "0x18172C330")]
		public StringExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[NodeTag("Networking", new string[] { })]
	public abstract class SyncedInMemoryVariableNode<T> : InMemoryVariableNode<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x1A78610", Offset = "0x1A77A10", VA = "0x181A78610")]
		protected SyncedInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Guid("1A5331BC-5025-487E-898C-3C49EE715664")]
	public class IntInMemoryVariableNode : InMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x17228A0", Offset = "0x1721CA0", VA = "0x1817228A0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x17228F0", Offset = "0x1721CF0", VA = "0x1817228F0")]
		public IntInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[Guid("3EE1EDFE-5520-4714-862B-98AF90F6E3DA")]
	public class PlayerInMemoryVariableNode : InMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x17228A0", Offset = "0x1721CA0", VA = "0x1817228A0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x1729A20", Offset = "0x1728E20", VA = "0x181729A20")]
		public PlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x17299D0", Offset = "0x1728DD0", VA = "0x1817299D0")]
		private static bool SetPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x1729970", Offset = "0x1728D70", VA = "0x181729970")]
		private static CircuitSignal GetPlayer(Memory memory, Guid memoryAddress)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	[Guid("DDC89F58-D8F2-49DE-AF34-332382D8BB71")]
	public class SynchedPlayerInMemoryVariableNode : SyncedInMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x172D340", Offset = "0x172C740", VA = "0x18172D340", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x172D7B0", Offset = "0x172CBB0", VA = "0x18172D7B0")]
		public SynchedPlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x172D760", Offset = "0x172CB60", VA = "0x18172D760")]
		private static bool SetSynchedPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x172D700", Offset = "0x172CB00", VA = "0x18172D700")]
		private static CircuitSignal GetSyncedPlayer(Memory memory, Guid memoryAddress)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	[Guid("DD96FD78-C47B-4CCC-9D6B-23DA2F3F7987")]
	public class SyncedInMemoryIntVariableNode : SyncedInMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x172D340", Offset = "0x172C740", VA = "0x18172D340", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x172D390", Offset = "0x172C790", VA = "0x18172D390")]
		public SyncedInMemoryIntVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
	[Guid("DCE27FE2-ABC2-4A6A-9C4E-5D829A5B83A6")]
	public class FloatInMemoryVariableNode : InMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x171C340", Offset = "0x171B740", VA = "0x18171C340", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x171C390", Offset = "0x171B790", VA = "0x18171C390")]
		public FloatInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[Guid("56DCF860-9C74-4213-8859-45ABA0B96D43")]
	public class SyncedInMemoryFloatVariableNode : SyncedInMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x172D210", Offset = "0x172C610", VA = "0x18172D210", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x172D260", Offset = "0x172C660", VA = "0x18172D260")]
		public SyncedInMemoryFloatVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Guid("8065D557-B6CC-4DD1-8CFA-B7481FE7BCF1")]
	public class BoolInMemoryVariableNode : InMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x1714EF0", Offset = "0x17142F0", VA = "0x181714EF0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x1714F40", Offset = "0x1714340", VA = "0x181714F40")]
		public BoolInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Guid("1E2CA8E7-037F-4A1A-82A7-62B81928B6A4")]
	public class SyncedInMemoryBoolVariableNode : SyncedInMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x172D0E0", Offset = "0x172C4E0", VA = "0x18172D0E0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x172D130", Offset = "0x172C530", VA = "0x18172D130")]
		public SyncedInMemoryBoolVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Guid("797913DF-1BCF-4280-8666-F17D7782CEBB")]
	public class StringInMemoryVariableNode : InMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x172CB00", Offset = "0x172BF00", VA = "0x18172CB00", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x172CB90", Offset = "0x172BF90", VA = "0x18172CB90")]
		public StringInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Guid("62F1B8B1-F1D3-4CEB-B0E9-57C4915BF401")]
	public class SyncedInMemoryStringVariableNode : SyncedInMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x172D470", Offset = "0x172C870", VA = "0x18172D470", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x172D500", Offset = "0x172C900", VA = "0x18172D500")]
		public SyncedInMemoryStringVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E0")]
	[Guid("BC5E4A50-1D2C-43BB-A93F-29E53F5AF50A")]
	public class ValueChangedNode : ExecutableNode, IVariableChangeListener
	{
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Guid outputValuePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private readonly OutputPort outputExecPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private readonly OutputPort outputValuePort;

		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private static readonly Guid variablePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private IVariableNode listeningToNode;

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public InputPort VariablePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B96")]
			[Cpp2IlInjected.Address(RVA = "0x3F4160", Offset = "0x3F3560", VA = "0x1803F4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x1945D40", Offset = "0x1945140", VA = "0x181945D40")]
		public ValueChangedNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x1945870", Offset = "0x1944C70", VA = "0x181945870", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x19459F0", Offset = "0x1944DF0", VA = "0x1819459F0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1945B90", Offset = "0x1944F90", VA = "0x181945B90", Slot = "23")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x1945C00", Offset = "0x1945000", VA = "0x181945C00")]
		private void UnregisterListeningNode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x1945A40", Offset = "0x1944E40", VA = "0x181945A40")]
		private void OnIsConnectedChanged(bool isConnected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x1945A40", Offset = "0x1944E40", VA = "0x181945A40")]
		private void UpdateListener()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E1")]
	[NodeTag("Variable", new string[] { })]
	public abstract class VariableNodeBase : PureNode, IVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		protected static readonly Guid ValuePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private readonly HashSet<IVariableChangeListener> changeListeners;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		protected readonly CircuitType PortType;

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public OutputPort ValuePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x3F4020", Offset = "0x3F3420", VA = "0x1803F4020", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x1946470", Offset = "0x1945870", VA = "0x181946470")]
		protected VariableNodeBase(CircuitContext circuitContext, Guid nodeId, CircuitType portType, bool canSet = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract void Set(CircuitSignal value);

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		protected abstract CircuitSignal Get(IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x19461A0", Offset = "0x19455A0", VA = "0x1819461A0", Slot = "27")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x1946350", Offset = "0x1945750", VA = "0x181946350", Slot = "22")]
		public void RegisterChangeListener(IVariableChangeListener changeListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x19463B0", Offset = "0x19457B0", VA = "0x1819463B0", Slot = "23")]
		public void UnregisterChangeListener(IVariableChangeListener changeListener)
		{
		}
	}
}
namespace CircuitsV2.Graph.Nodes.TypeConversions
{
	[Cpp2IlInjected.Token(Token = "0x20001E2")]
	[NodeTag("Parsing", new string[] { })]
	public abstract class ParsingNode : TypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private static readonly Guid parseSuccessPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly OutputPort ParseSuccessPort;

		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private static readonly CircuitSignal TRUE_SIGNAL;

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private static readonly CircuitSignal FALSE_SIGNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private CircuitSignal successValue;

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x1942ED0", Offset = "0x19422D0", VA = "0x181942ED0")]
		protected ParsingNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x1942C60", Offset = "0x1942060", VA = "0x181942C60", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[Guid("00B49995-A322-47A3-A32B-5530F2BA7FED")]
	public class ParseIntNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x1942AF0", Offset = "0x1941EF0", VA = "0x181942AF0")]
		public ParseIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x1942A70", Offset = "0x1941E70", VA = "0x181942A70", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	[Guid("5E25F40A-2B8C-4327-A89C-7A749838DA7D")]
	public class ParseFloatNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x1942900", Offset = "0x1941D00", VA = "0x181942900")]
		public ParseFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x1942880", Offset = "0x1941C80", VA = "0x181942880", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[Guid("92C05EBC-1967-49A4-94B5-2D01FE1E6B85")]
	public class ParseBoolNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x1942710", Offset = "0x1941B10", VA = "0x181942710")]
		public ParseBoolNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x1942640", Offset = "0x1941A40", VA = "0x181942640", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	[NodeTag("Type Conversion", new string[] { })]
	public abstract class TypeConversionNode : PureNode, ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Guid valueInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private static readonly Guid valueOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public InputPort ValueInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x3F41D0", Offset = "0x3F35D0", VA = "0x1803F41D0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public OutputPort ValueOutputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x3F41B0", Offset = "0x3F35B0", VA = "0x1803F41B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x1944700", Offset = "0x1943B00", VA = "0x181944700")]
		protected TypeConversionNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x19445D0", Offset = "0x19439D0", VA = "0x1819445D0")]
		private CircuitSignal GetAndConvert(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal Convert(CircuitSignal inputSignal);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Guid("65CFBA8A-B5DC-4946-B824-E6EFC5719F3A")]
	public class IntToFloatNode : TypeConversionNode, ITypeConversionNode<int, float>, ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x1941570", Offset = "0x1940970", VA = "0x181941570")]
		public IntToFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x1941530", Offset = "0x1940930", VA = "0x181941530", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[NodeTag("Math", new string[] { })]
	public abstract class FloatToIntConversionNodeBase : TypeConversionNode, ITypeConversionNode<float, int>, ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x171C6D0", Offset = "0x171BAD0", VA = "0x18171C6D0")]
		protected FloatToIntConversionNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x171C540", Offset = "0x171B940", VA = "0x18171C540", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x171C470", Offset = "0x171B870", VA = "0x18171C470")]
		private float ClampToIntRange(float floatValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract int ConvertInternal(float clampedInput);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	[Guid("BC451CAB-2292-4E60-832D-31060EB82BD0")]
	public class FloorToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x1716060", Offset = "0x1715460", VA = "0x181716060")]
		public FloorToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x171C840", Offset = "0x171BC40", VA = "0x18171C840", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Guid("38B502DC-DD35-4083-A2B0-8A8E5F69A958")]
	public class CeilToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x1716060", Offset = "0x1715460", VA = "0x181716060")]
		public CeilToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x1716000", Offset = "0x1715400", VA = "0x181716000", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	[Guid("0D2A4771-0694-4B84-8E07-2080C26AAE22")]
	public class RoundToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x1716060", Offset = "0x1715460", VA = "0x181716060")]
		public RoundToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x19441A0", Offset = "0x19435A0", VA = "0x1819441A0", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.PureNodes.TypeConversions
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	public interface ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000218")]
		InputPort ValueInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		OutputPort ValueOutputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	public interface ITypeConversionNode<TFrom, TTo> : ITypeConversionNode
	{
	}
}
namespace CircuitsV2.Graph.Nodes.NumberComparisons
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[NodeTag("Comparison", new string[] { })]
	public abstract class NumberComparisonNodeBase : PureNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private static readonly Guid inputAPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public readonly InputPort InputAPort;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private static readonly Guid inputBPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public readonly InputPort InputBPort;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly Guid outputPortId;

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public OutputPort ReturnPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC7")]
			[Cpp2IlInjected.Address(RVA = "0x3F4020", Offset = "0x3F3420", VA = "0x1803F4020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x1728970", Offset = "0x1727D70", VA = "0x181728970")]
		public NumberComparisonNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x1728760", Offset = "0x1727B60", VA = "0x181728760", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x1728520", Offset = "0x1727920", VA = "0x181728520")]
		private CircuitSignal CalculateReturnValueFloat(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x1728640", Offset = "0x1727A40", VA = "0x181728640")]
		private CircuitSignal CalculateReturnValueInt(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool CalculateReturnValueInternal(float signalA, float signalB);

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract bool CalculateReturnValueInternal(int signalA, int signalB);
	}
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	[Guid("110C29B1-AC90-4A71-B3C0-53372AA134BC")]
	public class GreaterThanNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x171F9A0", Offset = "0x171EDA0", VA = "0x18171F9A0")]
		public GreaterThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x171F910", Offset = "0x171ED10", VA = "0x18171F910", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x171F900", Offset = "0x171ED00", VA = "0x18171F900", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F0")]
	[Guid("7E58B3F4-2694-4CED-B3A8-0FE23F48F60F")]
	public class LessThanNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x1722D70", Offset = "0x1722170", VA = "0x181722D70")]
		public LessThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x1722CE0", Offset = "0x17220E0", VA = "0x181722CE0", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x1722CD0", Offset = "0x17220D0", VA = "0x181722CD0", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F1")]
	[Guid("A10E7788-F016-4390-A68E-87D93B47EDB1")]
	public class GreaterThanOrEqualNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x171FAD0", Offset = "0x171EED0", VA = "0x18171FAD0")]
		public GreaterThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x171FA30", Offset = "0x171EE30", VA = "0x18171FA30", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x171FAC0", Offset = "0x171EEC0", VA = "0x18171FAC0", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F2")]
	[Guid("A027073F-9189-457F-A53D-8562E8829DAF")]
	public class LessThanOrEqualNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1722EA0", Offset = "0x17222A0", VA = "0x181722EA0")]
		public LessThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x1722E00", Offset = "0x1722200", VA = "0x181722E00", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1722E90", Offset = "0x1722290", VA = "0x181722E90", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.DemoNodes
{
	[Cpp2IlInjected.Token(Token = "0x20001F3")]
	[NodeTag("Comparison", new string[] { })]
	[Guid("3663225D-E18D-40E6-A234-EF10378528BE")]
	public class EqualsNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly Guid valueAPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private readonly InputPort valueAPort;

		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private static readonly Guid valueBPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly InputPort valueBPort;

		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private static readonly Guid equalsOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly OutputPort equalsOutputPort;

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x171A180", Offset = "0x1719580", VA = "0x18171A180")]
		public EqualsNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x171A000", Offset = "0x1719400", VA = "0x18171A000", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x171A030", Offset = "0x1719430", VA = "0x18171A030", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x17199F0", Offset = "0x1718DF0", VA = "0x1817199F0")]
		private OutputPortGetDelegate GetDelegateForType(CircuitType specificType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x1719DF0", Offset = "0x17191F0", VA = "0x181719DF0")]
		private CircuitSignal GetReferenceEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x1719EF0", Offset = "0x17192F0", VA = "0x181719EF0")]
		private CircuitSignal GetStringEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x1719B90", Offset = "0x1718F90", VA = "0x181719B90")]
		private CircuitSignal GetFloatEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x1719CF0", Offset = "0x17190F0", VA = "0x181719CF0")]
		private CircuitSignal GetIntEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x17198F0", Offset = "0x1718CF0", VA = "0x1817198F0")]
		private CircuitSignal GetBooleanEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1719B50", Offset = "0x1718F50", VA = "0x181719B50")]
		private CircuitSignal GetFalse(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	[NodeTag("String", new string[] { })]
	[Guid("74E81EDB-84BD-4E52-B2F3-A73A62A6B3AA")]
	public class ToStringNode : TypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x20001F5")]
		private delegate CircuitSignal ConvertFunc(CircuitContext context, CircuitSignal inputSignal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private ConvertFunc convertFunc;

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x172DF50", Offset = "0x172D350", VA = "0x18172DF50")]
		public ToStringNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x171A000", Offset = "0x1719400", VA = "0x18171A000", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x172DDA0", Offset = "0x172D1A0", VA = "0x18172DDA0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x172D990", Offset = "0x172CD90", VA = "0x18172D990")]
		private ConvertFunc GetDelegateForType(CircuitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x172DC10", Offset = "0x172D010", VA = "0x18172DC10")]
		private CircuitSignal GetPlayerToString(CircuitContext context, CircuitSignal inputsignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x172D8C0", Offset = "0x172CCC0", VA = "0x18172D8C0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x172DD20", Offset = "0x172D120", VA = "0x18172DD20")]
		private static CircuitSignal GetReferenceToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x172DD80", Offset = "0x172D180", VA = "0x18172DD80")]
		private static CircuitSignal GetStringToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x172DB50", Offset = "0x172CF50", VA = "0x18172DB50")]
		private static CircuitSignal GetFloatToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x172DBB0", Offset = "0x172CFB0", VA = "0x18172DBB0")]
		private static CircuitSignal GetIntToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x172D930", Offset = "0x172CD30", VA = "0x18172D930")]
		private static CircuitSignal GetBooleanToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x172DB10", Offset = "0x172CF10", VA = "0x18172DB10")]
		private static CircuitSignal GetEmpty(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.PlayerNodes
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[NodeTag("Player", new string[] { })]
	[Guid("EBF08E8A-9786-4368-AA64-FD0B480F593A")]
	public class InvalidPlayerVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private readonly CircuitSignal invalidPlayerSignal;

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x1722BD0", Offset = "0x1721FD0", VA = "0x181722BD0")]
		public InvalidPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x1722B80", Offset = "0x1721F80", VA = "0x181722B80", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x952D40", Offset = "0x952140", VA = "0x180952D40", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F7")]
	[NodeTag("Player", new string[] { })]
	[Guid("FDF733A8-BDD6-4800-B1D4-95B06B3D6F02")]
	public class LocalPlayerVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private readonly CircuitSignal localPlayerSignal;

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x1722F80", Offset = "0x1722380", VA = "0x181722F80")]
		public LocalPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x1722F30", Offset = "0x1722330", VA = "0x181722F30", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x952D40", Offset = "0x952140", VA = "0x180952D40", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	[NodeTag("Player", new string[] { })]
	[Guid("4646DBED-E616-470E-8E0C-EB446B91838B")]
	public class GetPlayerIsLocalNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x171F260", Offset = "0x171E660", VA = "0x18171F260")]
		public GetPlayerIsLocalNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x171F160", Offset = "0x171E560", VA = "0x18171F160", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	[Guid("949B77E7-1F65-4F5B-A46B-F4E7B81F7A08")]
	[NodeTag("Player", new string[] { })]
	public class GetPlayerNameNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x171F4A0", Offset = "0x171E8A0", VA = "0x18171F4A0")]
		public GetPlayerNameNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x171F400", Offset = "0x171E800", VA = "0x18171F400", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	[NodeTag("Player", new string[] { })]
	[Guid("09B0BF5B-95DF-474B-B81A-4E8E2C78ED0A")]
	public class GetAllPlayersNode : SingleExecutableNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private static readonly Guid allPlayersOutputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private readonly OutputPort allPlayersOutputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private CircuitSignal returnSignal;

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x171E270", Offset = "0x171D670", VA = "0x18171E270")]
		public GetAllPlayersNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x171E1F0", Offset = "0x171D5F0", VA = "0x18171E1F0")]
		private CircuitSignal GetPlayerList(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x171E110", Offset = "0x171D510", VA = "0x18171E110", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	[Guid("46E6B40E-2416-4078-B7DC-A0ECC2C2AA20")]
	[NodeTag("Player", new string[] { })]
	public class PromptLocalPlayerNode : SingleExecutableNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private static readonly Guid promptTitleInputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private readonly InputPort promptTitleInputPort;

		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private static readonly Guid promptInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private static readonly Guid promptCompletePortId;

		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private static readonly Guid promptFailedPortId;

		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private static readonly Guid promptResponsePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private IPromise<PromptResponse> promptPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private CircuitSignal promptResponse;

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public InputPort PromptInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x1803F41A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public OutputPort PromptCompletePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C05")]
			[Cpp2IlInjected.Address(RVA = "0x39F630", Offset = "0x39EA30", VA = "0x18039F630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		private OutputPort PromptFailedPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C06")]
			[Cpp2IlInjected.Address(RVA = "0x3F40C0", Offset = "0x3F34C0", VA = "0x1803F40C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public OutputPort ResponsePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C07")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EB0", Offset = "0x3C62B0", VA = "0x1803C6EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x172A600", Offset = "0x1729A00", VA = "0x18172A600")]
		public PromptLocalPlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x172A380", Offset = "0x1729780", VA = "0x18172A380")]
		private CircuitSignal GetPromptResponse(IExecutionScope executionscope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x172A080", Offset = "0x1729480", VA = "0x18172A080", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x1729FC0", Offset = "0x17293C0", VA = "0x181729FC0")]
		private void ExecuteAfterPrompt(OutputPort fromPort)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x56BD0", Offset = "0x55FD0")]
	[Guid("163C326E-6BB9-428A-8837-FF507D948E93")]
	public class GetPlayerHealthNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x171EFC0", Offset = "0x171E3C0", VA = "0x18171EFC0")]
		public GetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x171EEA0", Offset = "0x171E2A0", VA = "0x18171EEA0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[InternalNode]
	[Guid("6B962C79-6BE2-4E2C-A517-BE998B58F9D1")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x57040", Offset = "0x56440")]
	public class GetPlayerShieldNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x171F760", Offset = "0x171EB60", VA = "0x18171F760")]
		public GetPlayerShieldNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x171F640", Offset = "0x171EA40", VA = "0x18171F640", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	[InternalNode]
	[Guid("67ACA89C-F753-4F94-87DF-1CE1D4FCB8B0")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x57480", Offset = "0x56880")]
	public class DamagePlayerNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly Guid playerInputPortId;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private static readonly Guid damageInputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public InputPort PlayerInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public InputPort DamageInputPortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x1803F41A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x1718500", Offset = "0x1717900", VA = "0x181718500")]
		public DamagePlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x17182C0", Offset = "0x17176C0", VA = "0x1817182C0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x58CA0", Offset = "0x580A0")]
	[Guid("5CA7C15F-BFED-4103-B5D6-7AF5DA64A703")]
	public class ResetPlayerHealthNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private static readonly Guid playerInputPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public InputPort PlayerInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x3F4190", Offset = "0x3F3590", VA = "0x1803F4190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x172BA20", Offset = "0x172AE20", VA = "0x18172BA20")]
		public ResetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x172B8A0", Offset = "0x172ACA0", VA = "0x18172B8A0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
}
namespace CircuitsV2.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000200")]
	public abstract class CircuitNetworking : ICircuitContextNetworking, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private bool isDisposed;

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public IRPCSender RpcSender
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x384290", Offset = "0x383690", VA = "0x180384290", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0x38BA90", Offset = "0x38AE90", VA = "0x18038BA90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public abstract bool IsAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x1301A40", Offset = "0x1300E40", VA = "0x181301A40")]
		protected CircuitNetworking(IRPCSender rpcSender, IContextSynchronizedFieldFactory synchronizedFieldFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x1933260", Offset = "0x1932660", VA = "0x181933260", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace CircuitsV2.Networking.Timing
{
	[Cpp2IlInjected.Token(Token = "0x2000201")]
	public interface ITimeProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		float CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000C22")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
namespace CircuitsV2.Networking.Notifications
{
	[Cpp2IlInjected.Token(Token = "0x2000202")]
	public interface INotificationProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PlayNotification(string notification);
	}
}
namespace CircuitsV2.Networking.InventionTracking
{
	[Cpp2IlInjected.Token(Token = "0x2000203")]
	public interface IInventionTracking
	{
		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GetTrackedData(string key, out Guid instanceId, out long inventionId, out int versionNumber, out bool wasPartOfInvention);

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetTrackedData(string key, Guid instanceId, long inventionId, int versionNumber, bool wasPartOfInvention);

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EnsureTrackingRegistered(string key);

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ForgetTrackedKey(string key);
	}
}
namespace CircuitsV2.Networking.BuiltInEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000204")]
	public static class BuiltInEvents
	{
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public static readonly CircuitEventDefinition Initialize;

		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public static readonly CircuitEventDefinition UnityUpdateDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public static readonly CircuitEventDefinition GameStartDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public static readonly CircuitEventDefinition GameEndDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public static readonly CircuitEventDefinition LocalPlayerJoinedDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public static readonly CircuitEventDefinition OtherPlayerJoinedDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly CircuitEventDefinition PlayerLeftDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public static readonly CircuitEventDefinition PlayerCollisionEventDefinition;

		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public static readonly CircuitEventDefinition TestEventDefinition;

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x192CC10", Offset = "0x192C010", VA = "0x18192CC10")]
		public static void Register(GlobalCircuitContext globalCircuitContext)
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
