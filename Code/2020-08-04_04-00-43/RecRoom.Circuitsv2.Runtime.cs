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
	[Cpp2IlInjected.Address(RVA = "0x12B80F0", Offset = "0x12B70F0", VA = "0x1812B80F0")]
	public static Guid ToGuid(this ByteString bytes)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x12B7F20", Offset = "0x12B6F20", VA = "0x1812B7F20")]
	public static ByteString ToByteString(this Guid guid)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x12B8270", Offset = "0x12B7270", VA = "0x1812B8270")]
	public static Guid? ToGuid(this NullableBytes bytes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x12B8060", Offset = "0x12B7060", VA = "0x1812B8060")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB3F00", Offset = "0x2CB2F00", VA = "0x182CB3F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F241F0", Offset = "0x1F231F0", VA = "0x181F241F0")]
		public RateLimitedSynchronizedField(SynchronizedField<T> internalField, T initialValue, RateLimiter rateLimiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEA5AE0", Offset = "0xEA4AE0", VA = "0x180EA5AE0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F23FB0", Offset = "0x1F22FB0", VA = "0x181F23FB0")]
		public bool Set(T newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F23CE0", Offset = "0x1F22CE0", VA = "0x181F23CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F24680", Offset = "0x1F23680", VA = "0x181F24680")]
		public bool HasReferences(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F248F0", Offset = "0x1F238F0", VA = "0x181F248F0")]
		public bool TryGetRefCount(TKey key, out int refCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F24710", Offset = "0x1F23710", VA = "0x181F24710")]
		public void IncrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1F24490", Offset = "0x1F23490", VA = "0x181F24490")]
		public void DecrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD63E40", Offset = "0xD62E40", VA = "0x180D63E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x152230", Offset = "0x151630", VA = "0x180152230")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CB52E0", Offset = "0x2CB42E0", VA = "0x182CB52E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5380", Offset = "0x2CB4380", VA = "0x182CB5380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2CB51B0", Offset = "0x2CB41B0", VA = "0x182CB51B0")]
		private ShortenedGuidMap(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2CB48D0", Offset = "0x2CB38D0", VA = "0x182CB48D0")]
		public static ShortenedGuidMap FromRequiredCharacters(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A30", Offset = "0x2CB3A30", VA = "0x182CB4A30")]
		public string GetShortened(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4B10", Offset = "0x2CB3B10", VA = "0x182CB4B10")]
		private string GuidToShortenedString(Guid guid, int requiredCharacters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4E80", Offset = "0x2CB3E80", VA = "0x182CB4E80")]
		private string RemapGuid(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4BE0", Offset = "0x2CB3BE0", VA = "0x182CB4BE0")]
		private void RemapExisting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5110", Offset = "0x2CB4110", VA = "0x182CB5110")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CB30E0", Offset = "0x2CB20E0", VA = "0x182CB30E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		private Base64GuidShortenerMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2FD0", Offset = "0x2CB1FD0", VA = "0x182CB2FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB4150", Offset = "0x2CB3150", VA = "0x182CB4150")]
		public static bool IsEmpty(this CircuitContextData contextData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14BB360", Offset = "0x14BA360", VA = "0x1814BB360")]
		private static bool IsRepeatedFieldEmpty<T>(RepeatedField<T> repeatedField)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CB43C0", Offset = "0x2CB33C0", VA = "0x182CB43C0")]
		internal static Vector3 ToVector3(this Vector3Data vector3Data)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4320", Offset = "0x2CB3320", VA = "0x182CB4320")]
		internal static Vector3Data ToVector3Data(this Vector3 vector3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4260", Offset = "0x2CB3260", VA = "0x182CB4260")]
		internal static Quaternion ToQuaternion(this QuaternionData quaternionData)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2CB41D0", Offset = "0x2CB31D0", VA = "0x182CB41D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA11CB0", Offset = "0xA10CB0", VA = "0x180A11CB0")]
			[DebuggerHidden]
			public <DFS>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5500", Offset = "0x2CB4500", VA = "0x182CB5500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5C70", Offset = "0x2CB4C70", VA = "0x182CB5C70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5BD0", Offset = "0x2CB4BD0", VA = "0x182CB5BD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5BD0", Offset = "0x2CB4BD0", VA = "0x182CB5BD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3370", Offset = "0x2CB2370", VA = "0x182CB3370")]
		[IteratorStateMachine(typeof(<DFS>d__1))]
		public static IEnumerable<Node> DFS(Node root, DFSType dfsType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB33F0", Offset = "0x2CB23F0", VA = "0x182CB33F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A5520", Offset = "0x3A4520", VA = "0x1803A5520")]
			public NotRestriction(params Type[] notTypes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB3FE0", Offset = "0x2CB2FE0", VA = "0x182CB3FE0")]
			protected bool Equals(NotRestriction other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4020", Offset = "0x2CB3020", VA = "0x182CB4020", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1262130", Offset = "0x1261130", VA = "0x181262130", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x13DEDA0", Offset = "0x13DDDA0", VA = "0x1813DEDA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x77CDA0", Offset = "0x77BDA0", VA = "0x18077CDA0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x12BBCB0", Offset = "0x12BACB0", VA = "0x1812BBCB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[NotNull]
		public Dependencies RecRoomDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF30", Offset = "0x3E9F30", VA = "0x1803EAF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BB990", Offset = "0x12BA990", VA = "0x1812BB990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CircuitContext Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3C5850", Offset = "0x3C4850", VA = "0x1803C5850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3FF360", Offset = "0x3FE360", VA = "0x1803FF360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitContextNode ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x38B5A0", Offset = "0x38A5A0", VA = "0x18038B5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4E95A0", Offset = "0x4E85A0", VA = "0x1804E95A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BB9E0", Offset = "0x12BA9E0", VA = "0x1812BB9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x45DAC0", Offset = "0x45CAC0", VA = "0x18045DAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CircuitContext, Node> OnCircuitNodeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x12BB710", Offset = "0x12BA710", VA = "0x1812BB710")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x12BBA30", Offset = "0x12BAA30", VA = "0x1812BBA30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x12BB7B0", Offset = "0x12BA7B0", VA = "0x1812BB7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x12BBAD0", Offset = "0x12BAAD0", VA = "0x1812BBAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<NodeConnection> OnNodesConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12BB850", Offset = "0x12BA850", VA = "0x1812BB850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x12BBB70", Offset = "0x12BAB70", VA = "0x1812BBB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NodeConnection> OnNodesDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x12BB8F0", Offset = "0x12BA8F0", VA = "0x1812BB8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x12BBC10", Offset = "0x12BAC10", VA = "0x1812BBC10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12BB570", Offset = "0x12BA570", VA = "0x1812BB570")]
		protected CircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x12B93D0", Offset = "0x12B83D0", VA = "0x1812B93D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x12B85A0", Offset = "0x12B75A0", VA = "0x1812B85A0")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x12B9C60", Offset = "0x12B8C60", VA = "0x1812B9C60")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x12B8310", Offset = "0x12B7310", VA = "0x1812B8310")]
		protected void AddChildContext(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x12BA6A0", Offset = "0x12B96A0", VA = "0x1812BA6A0")]
		public bool SendEvent(CircuitEvent circuitEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x12BA6D0", Offset = "0x12B96D0", VA = "0x1812BA6D0")]
		public void SendSynchronizedEvent(CircuitEvent circuitEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x12BA020", Offset = "0x12B9020", VA = "0x1812BA020")]
		public void RequestCreateNewCircuitNode(Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12BA3E0", Offset = "0x12B93E0", VA = "0x1812BA3E0")]
		public void RequestDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12BA230", Offset = "0x12B9230", VA = "0x1812BA230")]
		public void RequestCreateNewDynamicEvent(string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x12BA4D0", Offset = "0x12B94D0", VA = "0x1812BA4D0")]
		public void RequestDestroyDynamicEvent(Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x12B9AE0", Offset = "0x12B8AE0", VA = "0x1812B9AE0")]
		public void LocalDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x12B9AB0", Offset = "0x12B8AB0", VA = "0x1812B9AB0")]
		public void LocalDestroyCircuitNode([NotNull] Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12B83B0", Offset = "0x12B73B0", VA = "0x1812B83B0")]
		public void AddCircuitNode(Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x12BAD70", Offset = "0x12B9D70", VA = "0x1812BAD70")]
		protected bool TryFindNodeViaGloballyUniqueIdInternal(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x12BA740", Offset = "0x12B9740", VA = "0x1812BA740", Slot = "9")]
		public virtual CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x12B8D70", Offset = "0x12B7D70", VA = "0x1812B8D70")]
		internal void DeserializeTemplateData(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12B9810", Offset = "0x12B8810", VA = "0x1812B9810")]
		internal void InferAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x12B87D0", Offset = "0x12B77D0", VA = "0x1812B87D0", Slot = "10")]
		public virtual void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A9C0", Offset = "0x1A999C0", VA = "0x181A9A9C0")]
		public bool TryFindNode<TNode>(Guid nodeId, out TNode node) where TNode : Node
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x12BB0F0", Offset = "0x12BA0F0", VA = "0x1812BB0F0")]
		public bool TryFindNode(Guid nodeId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x12BAD00", Offset = "0x12B9D00", VA = "0x1812BAD00")]
		public bool TryFindChildContext(Guid childContextId, out CircuitContext childContext)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x12B9F00", Offset = "0x12B8F00", VA = "0x1812B9F00")]
		public void RaiseOnCircuitNodesConnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x12B9F90", Offset = "0x12B8F90", VA = "0x1812B9F90")]
		public void RaiseOnCircuitNodesDisconnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x12B8540", Offset = "0x12B7540", VA = "0x1812B8540")]
		public void AddNodeRestriction(INodeRestriction nodeRestriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x12B9A80", Offset = "0x12B8A80", VA = "0x1812B9A80")]
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
			[Cpp2IlInjected.Address(RVA = "0xADD740", Offset = "0xADC740", VA = "0x180ADD740")]
			public EventRegistration(CircuitContext registeredToContext, CircuitEventDefinition eventDefinition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x12C3550", Offset = "0x12C2550", VA = "0x1812C3550")]
			public void AddCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x12C3670", Offset = "0x12C2670", VA = "0x1812C3670")]
			public void RemoveCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x12C37B0", Offset = "0x12C27B0", VA = "0x1812C37B0", Slot = "5")]
			public EventRegistrationData SerializeToProtobuf()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x1AD0650", Offset = "0x1ACF650", VA = "0x181AD0650", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x10FB940", Offset = "0x10FA940", VA = "0x1810FB940")]
			protected LimitedEventQueueBase(int maxEventsToProcessPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AD05A0", Offset = "0x1ACF5A0", VA = "0x181AD05A0")]
			public bool PushEvent(T queueEntry)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1AD0440", Offset = "0x1ACF440", VA = "0x181AD0440", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x12CD840", Offset = "0x12CC840", VA = "0x1812CD840")]
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
				[Cpp2IlInjected.Address(RVA = "0x180050", Offset = "0x17F450", VA = "0x180180050")]
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
				[Cpp2IlInjected.Address(RVA = "0x12CAF40", Offset = "0x12C9F40", VA = "0x1812CAF40", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			protected override Queue<CircuitEvent> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x12CAF50", Offset = "0x12C9F50", VA = "0x1812CAF50", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x12CADD0", Offset = "0x12C9DD0", VA = "0x1812CADD0")]
			public LocalEventQueue(ITimeProvider timeProvider, int maxEventsToProcessPerFrame = 1024)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x12CAC40", Offset = "0x12C9C40", VA = "0x1812CAC40")]
			public bool PushEventDelayed(CircuitEvent circuitEvent, float delay)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x12CAA70", Offset = "0x12C9A70", VA = "0x1812CAA70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C2EA0", Offset = "0x12C1EA0", VA = "0x1812C2EA0")]
			public void AddCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x12C3340", Offset = "0x12C2340", VA = "0x1812C3340")]
			public void RemoveCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x12C3460", Offset = "0x12C2460", VA = "0x1812C3460")]
			private void RemoveHandlerInternal(Guid eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x12C3000", Offset = "0x12C2000", VA = "0x1812C3000")]
			public void HandleEvent(CircuitEvent circuitEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x12C2FA0", Offset = "0x12C1FA0", VA = "0x1812C2FA0")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x12C34D0", Offset = "0x12C24D0", VA = "0x1812C34D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BE1D0", Offset = "0x12BD1D0", VA = "0x1812BE1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12BDE70", Offset = "0x12BCE70", VA = "0x1812BDE70")]
		public CircuitEventBus(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x12BD410", Offset = "0x12BC410", VA = "0x1812BD410")]
		public EventRegistration RegisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x12BD8F0", Offset = "0x12BC8F0", VA = "0x1812BD8F0")]
		public EventRegistration RegisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x12BD4F0", Offset = "0x12BC4F0", VA = "0x1812BD4F0")]
		private EventRegistration RegisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12BDDD0", Offset = "0x12BCDD0", VA = "0x1812BDDD0")]
		public void UnregisterDynamicCircuitEvent(Guid circuitEventDefinitionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12BDE60", Offset = "0x12BCE60", VA = "0x1812BDE60")]
		public void UnregisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x12BDBD0", Offset = "0x12BCBD0", VA = "0x1812BDBD0")]
		public void UnregisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x12BDBE0", Offset = "0x12BCBE0", VA = "0x1812BDBE0")]
		private void UnregisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x12BCBB0", Offset = "0x12BBBB0", VA = "0x1812BCBB0")]
		public IEnumerable<EventRegistration> GetListenableEvents(bool onlyPlayerListenable = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x12BC590", Offset = "0x12BB590", VA = "0x1812BC590")]
		private IReadOnlyList<EventRegistration> GetAllListenableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x12BC900", Offset = "0x12BB900", VA = "0x1812BC900")]
		public EventRegistration GetListenableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x12BCCB0", Offset = "0x12BBCB0", VA = "0x1812BCCB0")]
		public EventRegistration GetSendableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x12BCD80", Offset = "0x12BBD80", VA = "0x1812BCD80")]
		public IReadOnlyList<EventRegistration> GetSendableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x12BD3E0", Offset = "0x12BC3E0", VA = "0x1812BD3E0")]
		public bool Publish(CircuitEvent outgoingEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x12BD1C0", Offset = "0x12BC1C0", VA = "0x1812BD1C0")]
		public bool PublishDelayed(CircuitEvent outgoingEvent, float delay)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x12BD360", Offset = "0x12BC360", VA = "0x1812BD360")]
		public bool PublishSynced(CircuitEvent outgoingEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x12BD0E0", Offset = "0x12BC0E0", VA = "0x1812BD0E0")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x12BCFA0", Offset = "0x12BBFA0", VA = "0x1812BCFA0")]
		private void HandleLocalEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x12BD940", Offset = "0x12BC940", VA = "0x1812BD940")]
		private void SendSyncedEvent(Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets> circuitEventAndTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x12BCFC0", Offset = "0x12BBFC0", VA = "0x1812BCFC0")]
		public void HandleReceivedSyncedEvent(SynchronizedEventData syncedEventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12BBEB0", Offset = "0x12BAEB0", VA = "0x1812BBEB0")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x12BD9F0", Offset = "0x12BC9F0", VA = "0x1812BD9F0", Slot = "6")]
		public EventBusData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x12BC300", Offset = "0x12BB300", VA = "0x1812BC300")]
		public void DeserializeFromTemplate(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x12BC110", Offset = "0x12BB110", VA = "0x1812BC110", Slot = "4")]
		public void DeserializeFromProtobuf(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x12BC4C0", Offset = "0x12BB4C0", VA = "0x1812BC4C0")]
		private void DestroyCircuitObjectFromProtoData(CircuitEventObject circuitEventObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x12BBF20", Offset = "0x12BAF20", VA = "0x1812BBF20")]
		private CircuitEventObject CreateCircuitObjectFromProtoData(Guid eventId, CircuitEventObjectData protobufdata)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x12BC4F0", Offset = "0x12BB4F0", VA = "0x1812BC4F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x12BDB60", Offset = "0x12BCB60", VA = "0x1812BDB60")]
		public bool TryGetDynamicEventObject(Guid eventDefEventDefinitionId, out CircuitEventObject circuitEventObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x12BD080", Offset = "0x12BC080", VA = "0x1812BD080")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C04D0", Offset = "0x12BF4D0", VA = "0x1812C04D0")]
		public CircuitEvent(Guid circuitEventTypeGuid, CircuitEventDefinition eventDefinition, IReadOnlyDictionary<string, CircuitSignal> signals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		public SynchronizedEventData Pack()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x12C00E0", Offset = "0x12BF0E0", VA = "0x1812C00E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C2DF0", Offset = "0x12C1DF0", VA = "0x1812C2DF0")]
			public EventBuilder(CircuitEventDefinition definition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x12C2D50", Offset = "0x12C1D50", VA = "0x1812C2D50")]
			public EventBuilder WithSignal(string signalName, CircuitSignal signal)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x12C2C50", Offset = "0x12C1C50", VA = "0x1812C2C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x12BEBD0", Offset = "0x12BDBD0", VA = "0x1812BEBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CircuitType> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnDefinitionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x12BEA90", Offset = "0x12BDA90", VA = "0x1812BEA90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x12BEB30", Offset = "0x12BDB30", VA = "0x1812BEB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x12BE9D0", Offset = "0x12BD9D0", VA = "0x1812BE9D0")]
		public CircuitEventDefinition(string name, Guid eventDefinitionId, bool isPlayerListenable = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x12BE5B0", Offset = "0x12BD5B0", VA = "0x1812BE5B0")]
		private bool Equals(CircuitEventDefinition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x12BE4B0", Offset = "0x12BD4B0", VA = "0x1812BE4B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x12BE5F0", Offset = "0x12BD5F0", VA = "0x1812BE5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xDA3540", Offset = "0xDA2540", VA = "0x180DA3540")]
		public static bool operator !=(CircuitEventDefinition left, CircuitEventDefinition right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x12BE220", Offset = "0x12BD220", VA = "0x1812BE220")]
		[EditableAddNamedPort(null)]
		public CircuitEventDefinition AddEventPropertyLocal(string name, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x12BE6E0", Offset = "0x12BD6E0", VA = "0x1812BE6E0")]
		public CircuitEventDefinition RemoveEventPropertyLocal(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x12BE780", Offset = "0x12BD780", VA = "0x1812BE780", Slot = "5")]
		public CircuitEventDefinitionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x12BE2C0", Offset = "0x12BD2C0", VA = "0x1812BE2C0", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitEventDefinitionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x12BE610", Offset = "0x12BD610", VA = "0x1812BE610")]
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
		[Cpp2IlInjected.Address(RVA = "0x12BFB10", Offset = "0x12BEB10", VA = "0x1812BFB10")]
		public CircuitEventObject(CircuitContext context, CircuitEventDefinition definition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x12BF430", Offset = "0x12BE430", VA = "0x1812BF430")]
		private bool Equals(CircuitEventObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12BF470", Offset = "0x12BE470", VA = "0x1812BF470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x12BF580", Offset = "0x12BE580", VA = "0x1812BF580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12BF5B0", Offset = "0x12BE5B0", VA = "0x1812BF5B0")]
		public void RequestAddEventProperty(string name, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x12BF700", Offset = "0x12BE700", VA = "0x1812BF700")]
		public void RequestRemoveEventProperty(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12BF830", Offset = "0x12BE830", VA = "0x1812BF830", Slot = "10")]
		public override CircuitEventObjectData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12BF070", Offset = "0x12BE070", VA = "0x1812BF070", Slot = "11")]
		public override void DeserializeFromProtobuf(CircuitEventObjectData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12BF390", Offset = "0x12BE390", VA = "0x1812BF390", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12BFAC0", Offset = "0x12BEAC0", VA = "0x1812BFAC0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x12BEF80", Offset = "0x12BDF80", VA = "0x1812BEF80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x12BEF70", Offset = "0x12BDF70", VA = "0x1812BEF70")]
		public CircuitEventObjectModificationHandler(CircuitEventObject modifiedEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12BEC10", Offset = "0x12BDC10", VA = "0x1812BEC10")]
		public ICircuitObjectModification CreateAddPropertyModification(string propertyName, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x12BECD0", Offset = "0x12BDCD0", VA = "0x1812BECD0")]
		public ICircuitObjectModification CreateRemovePropertyModification(string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12BED60", Offset = "0x12BDD60", VA = "0x1812BED60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C78B0", Offset = "0x12C68B0", VA = "0x1812C78B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RateLimiter GlobalSyncedEventRateLimiter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x431C90", Offset = "0x430C90", VA = "0x180431C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C7850", Offset = "0x12C6850", VA = "0x1812C7850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BufferedOperationsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x12C7800", Offset = "0x12C6800", VA = "0x1812C7800")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x12C7DD0", Offset = "0x12C6DD0", VA = "0x1812C7DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ObjectCircuitContext> OnObjectCircuitContextCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x12C7760", Offset = "0x12C6760", VA = "0x1812C7760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x12C7D30", Offset = "0x12C6D30", VA = "0x1812C7D30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CircuitContext, Node> OnCircuitNodeAddedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x12C7440", Offset = "0x12C6440", VA = "0x1812C7440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x12C7A10", Offset = "0x12C6A10", VA = "0x1812C7A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x12C74E0", Offset = "0x12C64E0", VA = "0x1812C74E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x12C7AB0", Offset = "0x12C6AB0", VA = "0x1812C7AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NodeConnection> OnNodesConnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x12C7620", Offset = "0x12C6620", VA = "0x1812C7620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x12C7BF0", Offset = "0x12C6BF0", VA = "0x1812C7BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NodeConnection> OnNodesDisconnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x12C76C0", Offset = "0x12C66C0", VA = "0x1812C76C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x12C7C90", Offset = "0x12C6C90", VA = "0x1812C7C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CircuitContext, CircuitContext> OnContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x12C7580", Offset = "0x12C6580", VA = "0x1812C7580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x12C7B50", Offset = "0x12C6B50", VA = "0x1812C7B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventRegisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x12C7300", Offset = "0x12C6300", VA = "0x1812C7300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x12C78D0", Offset = "0x12C68D0", VA = "0x1812C78D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventUnregisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x12C73A0", Offset = "0x12C63A0", VA = "0x1812C73A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x12C7970", Offset = "0x12C6970", VA = "0x1812C7970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x12C5100", Offset = "0x12C4100", VA = "0x1812C5100")]
		public Guid NextGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12C6FA0", Offset = "0x12C5FA0", VA = "0x1812C6FA0")]
		public GlobalCircuitContext(ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x12C7040", Offset = "0x12C6040", VA = "0x1812C7040")]
		public GlobalCircuitContext(Guid contextId, ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x629A60", Offset = "0x628A60", VA = "0x180629A60")]
		public void ResetMaxExecutions(int newRemaining = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x12C3B40", Offset = "0x12C2B40", VA = "0x1812C3B40", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextId, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12C6EA0", Offset = "0x12C5EA0", VA = "0x1812C6EA0")]
		public bool TryFindNodeViaGloballyUniqueId(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x12C6E70", Offset = "0x12C5E70", VA = "0x1812C6E70", Slot = "9")]
		public sealed override CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x12C3C90", Offset = "0x12C2C90", VA = "0x1812C3C90", Slot = "10")]
		public override void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12C52E0", Offset = "0x12C42E0", VA = "0x1812C52E0")]
		public void PushEditContext(CircuitContext circuitContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12C51B0", Offset = "0x12C41B0", VA = "0x1812C51B0")]
		public void PopEditContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x12C55B0", Offset = "0x12C45B0", VA = "0x1812C55B0")]
		public void RaiseRegisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12C5630", Offset = "0x12C4630", VA = "0x1812C5630")]
		public void RaiseUnregisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12C5480", Offset = "0x12C4480", VA = "0x1812C5480")]
		public void RaiseOnCircuitNodeDestroyedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12C5410", Offset = "0x12C4410", VA = "0x1812C5410")]
		public void RaiseOnCircuitNodeAddedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12C54F0", Offset = "0x12C44F0", VA = "0x1812C54F0")]
		public void RaiseOnCircuitNodesConnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x12C5550", Offset = "0x12C4550", VA = "0x1812C5550")]
		public void RaiseOnCircuitNodesDisconnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x12C56B0", Offset = "0x12C46B0", VA = "0x1812C56B0")]
		public void RegisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x12C6EC0", Offset = "0x12C5EC0", VA = "0x1812C6EC0")]
		public void UnregisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x12C5150", Offset = "0x12C4150", VA = "0x1812C5150")]
		private void OnBufferedOpCountChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x12C3D90", Offset = "0x12C2D90", VA = "0x1812C3D90")]
		public void MasterReinitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x12C6830", Offset = "0x12C5830", VA = "0x1812C6830")]
		[RPCMethod]
		protected void RpcReinitializeAll(CircuitContextData circuitContextData, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12C5900", Offset = "0x12C4900", VA = "0x1812C5900")]
		internal void RequestCreateNewCircuitNode(Guid contextId, Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12C3F90", Offset = "0x12C2F90", VA = "0x1812C3F90")]
		[RPCMethod]
		internal void MasterRpcCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x12C60A0", Offset = "0x12C50A0", VA = "0x1812C60A0")]
		[RPCMethod]
		internal void RpcBufferedCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12C5CC0", Offset = "0x12C4CC0", VA = "0x1812C5CC0")]
		internal void RequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x12C4B40", Offset = "0x12C3B40", VA = "0x1812C4B40")]
		[RPCMethod]
		internal void MasterRpcRequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x12C6370", Offset = "0x12C5370", VA = "0x1812C6370")]
		[RPCMethod]
		internal void RpcBufferedDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x12C5B10", Offset = "0x12C4B10", VA = "0x1812C5B10")]
		internal void RequestCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x12C4260", Offset = "0x12C3260", VA = "0x1812C4260")]
		[RPCMethod]
		internal void MasterRpcCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x12C6250", Offset = "0x12C5250", VA = "0x1812C6250")]
		[RPCMethod]
		internal void RpcBufferedCreateNewDynamicEvent(Guid contextId, string eventName, Guid eventId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x12C5DA0", Offset = "0x12C4DA0", VA = "0x1812C5DA0")]
		internal void RequestDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x12C4550", Offset = "0x12C3550", VA = "0x1812C4550")]
		[RPCMethod]
		internal void MasterRpcDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x12C63D0", Offset = "0x12C53D0", VA = "0x1812C63D0")]
		[RPCMethod]
		internal void RpcBufferedDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x12C5730", Offset = "0x12C4730", VA = "0x1812C5730")]
		internal void RequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x12C48D0", Offset = "0x12C38D0", VA = "0x1812C48D0")]
		[RPCMethod]
		internal void MasterRpcRequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x12C64A0", Offset = "0x12C54A0", VA = "0x1812C64A0")]
		[RPCMethod]
		internal void RpcConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x12C5F00", Offset = "0x12C4F00", VA = "0x1812C5F00")]
		internal void RequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x12C4CA0", Offset = "0x12C3CA0", VA = "0x1812C4CA0")]
		[RPCMethod]
		internal void MasterRpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x12C68E0", Offset = "0x12C58E0", VA = "0x1812C68E0")]
		[RPCMethod]
		internal void RpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x12C6B00", Offset = "0x12C5B00", VA = "0x1812C6B00")]
		internal void SendObjectModification(ICircuitObjectModification nodeModificationBase)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x12C4710", Offset = "0x12C3710", VA = "0x1812C4710")]
		[RPCMethod]
		internal void MasterRpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x12C6670", Offset = "0x12C5670", VA = "0x1812C6670")]
		[RPCMethod]
		internal void RpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x12C4EB0", Offset = "0x12C3EB0", VA = "0x1812C4EB0")]
		public IEnumerable<CircuitObject> MasterSpawnTemplateOnAllClients(CircuitContext intoContext, CircuitContextData templateDataOriginal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x12C6AB0", Offset = "0x12C5AB0", VA = "0x1812C6AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E30D0", Offset = "0x3E20D0", VA = "0x1803E30D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x16514F0", Offset = "0x16504F0", VA = "0x1816514F0")]
		public NestedCircuitContext(Guid contextId, ObjectCircuitContext parentSynchronizationContext, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1651400", Offset = "0x1650400", VA = "0x181651400", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x1651780", Offset = "0x1650780", VA = "0x181651780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1651820", Offset = "0x1650820", VA = "0x181651820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1651710", Offset = "0x1650710", VA = "0x181651710")]
		public ObjectCircuitContext(Guid contextId, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1651670", Offset = "0x1650670", VA = "0x181651670")]
		public void SetSynchronizationBackend(ICircuitContextNetworking networkBackend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1651570", Offset = "0x1650570", VA = "0x181651570", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1651640", Offset = "0x1650640", VA = "0x181651640", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E30D0", Offset = "0x3E20D0", VA = "0x1803E30D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1554DC0", Offset = "0x1553DC0", VA = "0x181554DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x42D6D0", Offset = "0x42C6D0", VA = "0x18042D6D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1554D70", Offset = "0x1553D70", VA = "0x181554D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1554CA0", Offset = "0x1553CA0", VA = "0x181554CA0")]
		public SynchronizedCircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1554670", Offset = "0x1553670", VA = "0x181554670", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1554580", Offset = "0x1553580", VA = "0x181554580")]
		public void AddChildContextToLookup(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1554810", Offset = "0x1553810", VA = "0x181554810")]
		public void RemoveChildContextFromLookup(Guid childContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1554A60", Offset = "0x1553A60", VA = "0x181554A60")]
		public void SendSynchronizedEvent(Guid fromContextId, CircuitEvent circuitEvent, SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x15548F0", Offset = "0x15538F0", VA = "0x1815548F0")]
		[RPCMethod]
		protected void RpcOnReceivedSynchronizedEvent(Guid contextId, SynchronizedEventData circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x15546C0", Offset = "0x15536C0", VA = "0x1815546C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x158AF0", Offset = "0x157EF0", VA = "0x180158AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FloatValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x15BD60", Offset = "0x15B160", VA = "0x18015BD60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CircuitPlayer PlayerValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x17FD50", Offset = "0x17F150", VA = "0x18017FD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1569A0", Offset = "0x155DA0", VA = "0x1801569A0")]
		public object ObjectValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x16F660", Offset = "0x16EA60", VA = "0x18016F660")]
		public T ObjectValue<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x17FD30", Offset = "0x17F130", VA = "0x18017FD30")]
		private CircuitSignal(TypeKind circuitTypeKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x17F7F0", Offset = "0x17EBF0", VA = "0x18017F7F0")]
		public bool Equals(CircuitSignal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x17F890", Offset = "0x17EC90", VA = "0x18017F890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x17F9B0", Offset = "0x17EDB0", VA = "0x18017F9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x12C21F0", Offset = "0x12C11F0", VA = "0x1812C21F0")]
		public static bool operator !=(CircuitSignal left, CircuitSignal right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x17FB20", Offset = "0x17EF20", VA = "0x18017FB20")]
		public string InternalToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x17FC30", Offset = "0x17F030", VA = "0x18017FC30")]
		internal CircuitSignalData ToSerializedSignalData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12C1B40", Offset = "0x12C0B40", VA = "0x1812C1B40")]
		internal static CircuitSignal FromSerializedSignalData(CircuitSignalData signalData)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12C1830", Offset = "0x12C0830", VA = "0x1812C1830")]
		public static CircuitSignal DefaultFor(TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x12C1A30", Offset = "0x12C0A30", VA = "0x1812C1A30")]
		public static CircuitSignal FromBool(bool newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x12C1AC0", Offset = "0x12C0AC0", VA = "0x1812C1AC0")]
		public static CircuitSignal FromInt(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x12C1A80", Offset = "0x12C0A80", VA = "0x1812C1A80")]
		public static CircuitSignal FromFloat(float newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x12C1CE0", Offset = "0x12C0CE0", VA = "0x1812C1CE0")]
		public static CircuitSignal FromString(string stringValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x12C1AC0", Offset = "0x12C0AC0", VA = "0x1812C1AC0")]
		public static CircuitSignal FromPlayerID(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x12C1AC0", Offset = "0x12C0AC0", VA = "0x1812C1AC0")]
		public static CircuitSignal FromPlayer(CircuitPlayer newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x12C1B00", Offset = "0x12C0B00", VA = "0x1812C1B00")]
		public static CircuitSignal FromObject(object newValue, TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x12C2010", Offset = "0x12C1010", VA = "0x1812C2010")]
		public static CircuitSignal List(List<CircuitSignal> list)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12C15A0", Offset = "0x12C05A0", VA = "0x1812C15A0")]
		public static CircuitSignal CreateListFromPorts(IExecutionScope executionScope, IReadOnlyCollection<InputPort> valuePorts, bool includeUnconnected)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x17FA70", Offset = "0x17EE70", VA = "0x18017FA70")]
		public List<CircuitSignal> GetListValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x12C1A30", Offset = "0x12C0A30", VA = "0x1812C1A30")]
		public static explicit operator CircuitSignal(bool boolValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x12C1A80", Offset = "0x12C0A80", VA = "0x1812C1A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C2670", Offset = "0x12C1670", VA = "0x1812C2670")]
		public static implicit operator CircuitTypeOrString(string value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x12C2640", Offset = "0x12C1640", VA = "0x1812C2640")]
		public static implicit operator CircuitTypeOrString(CircuitType value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x17FF20", Offset = "0x17F320", VA = "0x18017FF20")]
		public CircuitType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x12C24D0", Offset = "0x12C14D0", VA = "0x1812C24D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1555C40", Offset = "0x1554C40", VA = "0x181555C40")]
		public static implicit operator TypeParamConstrainedOrNot(string name)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1555CE0", Offset = "0x1554CE0", VA = "0x181555CE0")]
		public static implicit operator TypeParamConstrainedOrNot([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x26510", Offset = "0x25910")] (string, CircuitTypeOrString) fields)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x148820", Offset = "0x147C20", VA = "0x180148820")]
		public TypeParameterType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1555B40", Offset = "0x1554B40", VA = "0x181555B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C2B60", Offset = "0x12C1B60", VA = "0x1812C2B60")]
		public ClassFactoryTypeParams(Guid? name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x12C2880", Offset = "0x12C1880", VA = "0x1812C2880")]
		public ClassFactoryTypeParams CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x12C29A0", Offset = "0x12C19A0", VA = "0x1812C29A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C27B0", Offset = "0x12C17B0", VA = "0x1812C27B0")]
		public ClassFactoryProps(Guid? name, string friendlyName, IList<TypeParameterType> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x12C26B0", Offset = "0x12C16B0", VA = "0x1812C26B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15567F0", Offset = "0x15557F0", VA = "0x1815567F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1557540", Offset = "0x1556540", VA = "0x181557540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static CircuitType CInt
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1557700", Offset = "0x1556700", VA = "0x181557700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static CircuitType CFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1557690", Offset = "0x1556690", VA = "0x181557690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CircuitType CString
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1557770", Offset = "0x1556770", VA = "0x181557770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static CircuitType CAny
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x15574D0", Offset = "0x15564D0", VA = "0x1815574D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static CircuitType CExec
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1557620", Offset = "0x1556620", VA = "0x181557620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CircuitType CErr
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x15575B0", Offset = "0x15565B0", VA = "0x1815575B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1556DB0", Offset = "0x1555DB0", VA = "0x181556DB0")]
		public static AppliedGenericType CArray(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1557030", Offset = "0x1556030", VA = "0x181557030")]
		public static AppliedGenericType CList(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1556EC0", Offset = "0x1555EC0", VA = "0x181556EC0")]
		public static ClassFactoryTypeParams CClass()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1556F30", Offset = "0x1555F30", VA = "0x181556F30")]
		public static ClassFactoryTypeParams CClass(Guid name, string friendlyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1556FD0", Offset = "0x1555FD0", VA = "0x181556FD0")]
		public static AppliedGenericType CIntersect(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1557160", Offset = "0x1556160", VA = "0x181557160")]
		public static AppliedGenericType CTuple(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x15571C0", Offset = "0x15561C0", VA = "0x1815571C0")]
		public static TypeParameterType CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1557260", Offset = "0x1556260", VA = "0x181557260")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15436E0", Offset = "0x15426E0", VA = "0x1815436E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1542C90", Offset = "0x1541C90", VA = "0x181542C90", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1542D70", Offset = "0x1541D70", VA = "0x181542D70", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x15435E0", Offset = "0x15425E0", VA = "0x1815435E0")]
		public AppliedGenericType(GenericType originalType, IEnumerable<CircuitType> typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x15435B0", Offset = "0x15425B0", VA = "0x1815435B0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1543240", Offset = "0x1542240", VA = "0x181543240", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x15431B0", Offset = "0x15421B0", VA = "0x1815431B0", Slot = "10")]
		public bool Equals(AppliedGenericType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1543310", Offset = "0x1542310", VA = "0x181543310", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1543360", Offset = "0x1542360", VA = "0x181543360", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x15433F0", Offset = "0x15423F0", VA = "0x1815433F0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1542FB0", Offset = "0x1541FB0", VA = "0x181542FB0")]
		public static AppliedGenericType DeserializeFromProtobuf(AppliedGenericTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ArrayType : GenericType, IEquatable<ArrayType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1543B20", Offset = "0x1542B20", VA = "0x181543B20")]
		public ArrayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1543AC0", Offset = "0x1542AC0", VA = "0x181543AC0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1543A30", Offset = "0x1542A30", VA = "0x181543A30", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x15439F0", Offset = "0x15429F0", VA = "0x1815439F0")]
		private static string ToStringImpl(string typeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1543980", Offset = "0x1542980", VA = "0x181543980", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x671D30", Offset = "0x670D30", VA = "0x180671D30", Slot = "11")]
		public bool Equals(ArrayType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1543930", Offset = "0x1542930", VA = "0x181543930", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x15439D0", Offset = "0x15429D0", VA = "0x1815439D0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x6083E0", Offset = "0x6073E0", VA = "0x1806083E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
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
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x37F200", Offset = "0x37E200", VA = "0x18037F200")]
		public CircuitType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x42D6D0", Offset = "0x42C6D0", VA = "0x18042D6D0", Slot = "5")]
		public virtual CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1550130", Offset = "0x154F130", VA = "0x181550130", Slot = "7")]
		public virtual void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1550510", Offset = "0x154F510", VA = "0x181550510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1550420", Offset = "0x154F420", VA = "0x181550420", Slot = "8")]
		public virtual bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x15503D0", Offset = "0x154F3D0", VA = "0x1815503D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1550610", Offset = "0x154F610", VA = "0x181550610")]
		public static bool operator ==(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1550630", Offset = "0x154F630", VA = "0x181550630")]
		public static bool operator !=(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x15439D0", Offset = "0x15429D0", VA = "0x1815439D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x15504A0", Offset = "0x154F4A0", VA = "0x1815504A0", Slot = "9")]
		public virtual CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1550190", Offset = "0x154F190", VA = "0x181550190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1551640", Offset = "0x1550640", VA = "0x181551640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1551510", Offset = "0x1550510", VA = "0x181551510")]
		public ClassType([Optional] IEnumerable<TypeParameterType> typeParameters, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] Guid? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1551210", Offset = "0x1550210", VA = "0x181551210", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1550670", Offset = "0x154F670", VA = "0x181550670")]
		private string ClassNameToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1551490", Offset = "0x1550490", VA = "0x181551490")]
		private string TypeParametersToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1550E30", Offset = "0x154FE30", VA = "0x181550E30")]
		private string PropertiesToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x140A7C0", Offset = "0x14097C0", VA = "0x18140A7C0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParamaterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1550B90", Offset = "0x154FB90", VA = "0x181550B90", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1550A60", Offset = "0x154FA60", VA = "0x181550A60", Slot = "11")]
		public bool Equals(ClassType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1550A10", Offset = "0x154FA10", VA = "0x181550A10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1550D00", Offset = "0x154FD00", VA = "0x181550D00", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1550F80", Offset = "0x154FF80", VA = "0x181550F80", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1550720", Offset = "0x154F720", VA = "0x181550720")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1552490", Offset = "0x1551490", VA = "0x181552490")]
		public FunctionType(IEnumerable<TypeParameterType> typeParameters, IEnumerable<KeyValuePair<string, Parameter>> parameters, IEnumerable<KeyValuePair<string, Return>> returns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1552460", Offset = "0x1551460", VA = "0x181552460", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1552430", Offset = "0x1551430", VA = "0x181552430", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1551E80", Offset = "0x1550E80", VA = "0x181551E80", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1551F70", Offset = "0x1550F70", VA = "0x181551F70", Slot = "11")]
		public bool Equals(FunctionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1551E30", Offset = "0x1550E30", VA = "0x181551E30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1552020", Offset = "0x1551020", VA = "0x181552020", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x15520E0", Offset = "0x15510E0", VA = "0x1815520E0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1551B30", Offset = "0x1550B30", VA = "0x181551B30")]
		public static FunctionType DeserializeFromProtobuf(FunctionTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GenericType : CircuitType
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x37F200", Offset = "0x37E200", VA = "0x18037F200")]
		protected GenericType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract string ToString(IReadOnlyList<CircuitType> typeParameterAssignments);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x15525C0", Offset = "0x15515C0", VA = "0x1815525C0")]
		public AppliedGenericType NewApplication(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1552550", Offset = "0x1551550", VA = "0x181552550")]
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
		[Cpp2IlInjected.Address(RVA = "0x1552910", Offset = "0x1551910", VA = "0x181552910")]
		public IntersectionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x15528E0", Offset = "0x15518E0", VA = "0x1815528E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1552840", Offset = "0x1551840", VA = "0x181552840", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x15527F0", Offset = "0x15517F0", VA = "0x1815527F0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x671D30", Offset = "0x670D30", VA = "0x180671D30", Slot = "11")]
		public bool Equals(IntersectionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x15527A0", Offset = "0x15517A0", VA = "0x1815527A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x15439D0", Offset = "0x15429D0", VA = "0x1815439D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5520", Offset = "0x3A4520", VA = "0x1803A5520")]
		public Parameter(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1552E70", Offset = "0x1551E70", VA = "0x181552E70", Slot = "4")]
		public bool Equals(Parameter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1552EB0", Offset = "0x1551EB0", VA = "0x181552EB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1262130", Offset = "0x1261130", VA = "0x181262130", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1552F00", Offset = "0x1551F00", VA = "0x181552F00")]
		public ParameterData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1552E00", Offset = "0x1551E00", VA = "0x181552E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x49D520", Offset = "0x49C520", VA = "0x18049D520")]
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
			[Cpp2IlInjected.Address(RVA = "0x569620", Offset = "0x568620", VA = "0x180569620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1521490", Offset = "0x1520490", VA = "0x181521490")]
		public Property(CircuitType type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1553410", Offset = "0x1552410", VA = "0x181553410", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1553300", Offset = "0x1552300", VA = "0x181553300")]
		private string GetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x15533D0", Offset = "0x15523D0", VA = "0x1815533D0")]
		private string SetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x15531A0", Offset = "0x15521A0", VA = "0x1815531A0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1553230", Offset = "0x1552230", VA = "0x181553230", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1553280", Offset = "0x1552280", VA = "0x181553280", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1553340", Offset = "0x1552340", VA = "0x181553340")]
		public PropertyData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1553100", Offset = "0x1552100", VA = "0x181553100")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3A5520", Offset = "0x3A4520", VA = "0x1803A5520")]
		public Return(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1552E70", Offset = "0x1551E70", VA = "0x181552E70", Slot = "4")]
		public bool Equals(Return other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1553A10", Offset = "0x1552A10", VA = "0x181553A10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1262130", Offset = "0x1261130", VA = "0x181262130", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1553A60", Offset = "0x1552A60", VA = "0x181553A60")]
		public ReturnData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x15539A0", Offset = "0x15529A0", VA = "0x1815539A0")]
		public static Return DeserializeFromProtobuf(ReturnData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class TupleType : GenericType, IEquatable<TupleType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x15552D0", Offset = "0x15542D0", VA = "0x1815552D0")]
		public TupleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x15552A0", Offset = "0x15542A0", VA = "0x1815552A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1555240", Offset = "0x1554240", VA = "0x181555240", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x15551F0", Offset = "0x15541F0", VA = "0x1815551F0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x671D30", Offset = "0x670D30", VA = "0x180671D30", Slot = "11")]
		public bool Equals(TupleType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15551A0", Offset = "0x15541A0", VA = "0x1815551A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x15439D0", Offset = "0x15429D0", VA = "0x1815439D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x39EB10", Offset = "0x39DB10", VA = "0x18039EB10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1555E40", Offset = "0x1554E40", VA = "0x181555E40", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1555F30", Offset = "0x1554F30", VA = "0x181555F30", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1556220", Offset = "0x1555220", VA = "0x181556220")]
		public TypeParameterReferenceType(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1556050", Offset = "0x1555050", VA = "0x181556050", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x15560D0", Offset = "0x15550D0", VA = "0x1815560D0", Slot = "10")]
		public bool Equals(TypeParameterReferenceType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1556000", Offset = "0x1555000", VA = "0x181556000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1556100", Offset = "0x1555100", VA = "0x181556100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1556150", Offset = "0x1555150", VA = "0x181556150", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1555F90", Offset = "0x1554F90", VA = "0x181555F90")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1556310", Offset = "0x1555310", VA = "0x181556310")]
		protected TypeParameterScopeType(IEnumerable<TypeParameterType> typeParameters, TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1556250", Offset = "0x1555250", VA = "0x181556250")]
		protected bool Equals(TypeParameterScopeType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x15562B0", Offset = "0x15552B0", VA = "0x1815562B0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1556760", Offset = "0x1555760", VA = "0x181556760")]
		public TypeParameterType(string name, [Optional] CircuitType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x15566E0", Offset = "0x15556E0", VA = "0x1815566E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x15564C0", Offset = "0x15554C0", VA = "0x1815564C0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1556400", Offset = "0x1555400", VA = "0x181556400", Slot = "10")]
		public bool Equals(TypeParameterType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1556470", Offset = "0x1555470", VA = "0x181556470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1556570", Offset = "0x1555570", VA = "0x181556570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x15565F0", Offset = "0x15555F0", VA = "0x1815565F0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1556380", Offset = "0x1555380", VA = "0x181556380")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F3D60", Offset = "0x11F2D60", VA = "0x1811F3D60")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(params TNode[] nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x11F3C20", Offset = "0x11F2C20", VA = "0x1811F3C20")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TNode> nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1374D60", Offset = "0x1373D60", VA = "0x181374D60")]
		private static (Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>) GenerateConstraintsForNodes<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(IEnumerable<TNode> nodes, TUnificationArena unificationArena) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1D34EF0", Offset = "0x1D33EF0", VA = "0x181D34EF0")]
		private static void GenerateConstraintsForNode<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToId, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToIdAll, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2DDA0", Offset = "0x2D1A0")] List<(int, CircuitType)> idToType, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2E070", Offset = "0x2D470")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x11F3AD0", Offset = "0x11F2AD0", VA = "0x1811F3AD0")]
		private static Dictionary<string, int> IdentifyTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2E390", Offset = "0x2D790")] List<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x11F31B0", Offset = "0x11F21B0", VA = "0x1811F31B0")]
		private static IEnumerable<(TPort, int)> GetGenericPorts<TPort, TUnificationArena, TTerm, TNode, TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TPort> ports, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToTypeId) where TPort : class, ICheckablePort where TUnificationArena : IUnificationArena<TTerm> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1375750", Offset = "0x1374750", VA = "0x181375750")]
		private static (int, TTerm) GenerateOutputConstraintsAndId<TTerm, TOutputPort, TNode, TInputPort, TCheckableConnection, TUnificationArena>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2E660", Offset = "0x2DA60")] IEnumerable<(TOutputPort, int)> outputPorts, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2E8B0", Offset = "0x2DCB0")] List<(int, CircuitType)> idToType, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((int, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1D359E0", Offset = "0x1D349E0", VA = "0x181D359E0")]
		private static void GenerateInputConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2EB40", Offset = "0x2DF40")] IEnumerable<(TInputPort, int)> inputPorts, TUnificationArena unificationArena, int outputPortId, TTerm outputPortUnificationTerm, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30090", Offset = "0x2F490")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1316110", Offset = "0x1315110", VA = "0x181316110")]
		private static int GenerateInputConnectionConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TInputPort inputPort, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x302F0", Offset = "0x2F6F0")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x150AAB0", Offset = "0x1509AB0", VA = "0x18150AAB0")]
		private static TTerm GetTypeUnificationTerm<TTerm, TUnificationArena>(CircuitType type, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30610", Offset = "0x2FA10")] List<(int, CircuitType)> idToType, IReadOnlyDictionary<string, int> typeParameterToId) where TUnificationArena : IUnificationArena<TTerm>
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x11F3420", Offset = "0x11F2420", VA = "0x1811F3420")]
		private static Dictionary<TNode, List<(string, CircuitType)>> GetTypeParameterAssignments<TNode, TInputPort, TOutputPort, TCheckableConnection>(ReferenceSubstitution[] substitutions, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30880", Offset = "0x2FC80")] IEnumerable<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1374760", Offset = "0x1373760", VA = "0x181374760")]
		private static void CacheAdditionalEquivalentTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection>(TNode node, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30A60", Offset = "0x2FE60")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1D34880", Offset = "0x1D33880", VA = "0x181D34880")]
		private static void GenerateConstraintsForAdditionalEquivalentTypeParameters<TUnificationArena, TTerm, TNode>(TUnificationArena unificationArena, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30D20", Offset = "0x30120")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x15552F0", Offset = "0x15542F0", VA = "0x1815552F0")]
		private static Dictionary<int, CircuitType> ApplySubstitutions(Dictionary<int, ReferenceSubstitution> substitutions, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x30F00", Offset = "0x30300")] IEnumerable<(int, CircuitType)> idToType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1555780", Offset = "0x1554780", VA = "0x181555780")]
		private static CircuitType MonomorphizeItem(ITerm type, Dictionary<int, CircuitType> idToType, Dictionary<int, CircuitType> cache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1555660", Offset = "0x1554660", VA = "0x181555660")]
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
			[Cpp2IlInjected.Address(RVA = "0x148820", Offset = "0x147C20", VA = "0x180148820")]
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
			[Cpp2IlInjected.Address(RVA = "0x1569A0", Offset = "0x155DA0", VA = "0x1801569A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x152230", Offset = "0x151630", VA = "0x180152230")]
		public TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x294040", Offset = "0x293440", VA = "0x180294040", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x294110", Offset = "0x293510", VA = "0x180294110", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2941A0", Offset = "0x2935A0", VA = "0x1802941A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x294230", Offset = "0x293630", VA = "0x180294230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class TypeParameterId
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x13BC4F0", Offset = "0x13BB4F0", VA = "0x1813BC4F0")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x33FE0", Offset = "0x333E0")]
			public readonly (Constraint, Constraint) constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Substitution substitution;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1BC240", Offset = "0x1BB640", VA = "0x1801BC240")]
			public Impl(in Constraint first, in Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1BC250", Offset = "0x1BB650", VA = "0x1801BC250")]
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
			[Cpp2IlInjected.Address(RVA = "0x1588E0", Offset = "0x157CE0", VA = "0x1801588E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x148820", Offset = "0x147C20", VA = "0x180148820")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Constraint SecondConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1569A0", Offset = "0x155DA0", VA = "0x1801569A0")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Substitution Substitution
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x148820", Offset = "0x147C20", VA = "0x180148820")]
			get
			{
				return default(Substitution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1BC110", Offset = "0x1BB510", VA = "0x1801BC110")]
		private ApplyConstraintResult(in Constraint first, in Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x15437D0", Offset = "0x15427D0", VA = "0x1815437D0")]
		public static ApplyConstraintResult NewConstraints(in Constraint first, in Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC0E0", Offset = "0x1BB4E0", VA = "0x1801BC0E0")]
		private ApplyConstraintResult(in Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1543880", Offset = "0x1542880", VA = "0x181543880")]
		public static ApplyConstraintResult NewSubstitution(in Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1BC120", Offset = "0x1BB520", VA = "0x1801BC120")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1543860", Offset = "0x1542860", VA = "0x181543860")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F50", Offset = "0x147350", VA = "0x180147F50")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x149630", Offset = "0x148A30", VA = "0x180149630")]
		public Arrow(TermIndex from, TermIndex to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1BC150", Offset = "0x1BB550", VA = "0x1801BC150", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F50", Offset = "0x147350", VA = "0x180147F50")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1BC160", Offset = "0x1BB560", VA = "0x1801BC160")]
		public ApplyConstraintResult Apply(Term[] terms)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x149630", Offset = "0x148A30", VA = "0x180149630")]
		public Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1BC190", Offset = "0x1BB590", VA = "0x1801BC190", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F50", Offset = "0x147350", VA = "0x180147F50")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x149630", Offset = "0x148A30", VA = "0x180149630")]
		public Substitution(int identifier, TermIndex value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2B0", Offset = "0x1BB6B0", VA = "0x1801BC2B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1BC270", Offset = "0x1BB670", VA = "0x1801BC270")]
			public Impl(in Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x1BC280", Offset = "0x1BB680", VA = "0x1801BC280")]
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
			[Cpp2IlInjected.Address(RVA = "0x149610", Offset = "0x148A10", VA = "0x180149610")]
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
			[Cpp2IlInjected.Address(RVA = "0x148820", Offset = "0x147C20", VA = "0x180148820")]
			get
			{
				return default(Arrow);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1BC490", Offset = "0x1BB890", VA = "0x1801BC490")]
		private Term(in Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1555160", Offset = "0x1554160", VA = "0x181555160")]
		public static Term NewArrow(in Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1BC4A0", Offset = "0x1BB8A0", VA = "0x1801BC4A0")]
		private Term(int identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1555180", Offset = "0x1554180", VA = "0x181555180")]
		public static Term NewIdentifier(int identifier)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3A0", Offset = "0x1BB7A0", VA = "0x1801BC3A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1533A0", Offset = "0x1527A0", VA = "0x1801533A0")]
		public TermIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1BC340", Offset = "0x1BB740", VA = "0x1801BC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC330", Offset = "0x1BB730", VA = "0x1801BC330")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x37F230", Offset = "0x37E230", VA = "0x18037F230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Stack<Constraint> Constraints
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1558A00", Offset = "0x1557A00", VA = "0x181558A00", Slot = "4")]
		public int NextId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x13163E0", Offset = "0x13153E0", VA = "0x1813163E0", Slot = "5")]
		public int GetId<T>(Dictionary<T, int> itemToIndex, T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1558860", Offset = "0x1557860", VA = "0x181558860", Slot = "6")]
		public TermIndex Arrow(TermIndex from, TermIndex to)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5E7260", Offset = "0x5E6260", VA = "0x1805E7260", Slot = "7")]
		public TermIndex Identifier(int value)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x15588F0", Offset = "0x15578F0", VA = "0x1815588F0", Slot = "8")]
		public void Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1558A80", Offset = "0x1557A80", VA = "0x181558A80", Slot = "9")]
		public ReferenceSubstitution[] Solve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1558960", Offset = "0x1557960", VA = "0x181558960")]
		public static UnificationArena New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EFB60", Offset = "0x3EEB60", VA = "0x1803EFB60", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x15534D0", Offset = "0x15524D0", VA = "0x1815534D0", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xADD740", Offset = "0xADC740", VA = "0x180ADD740")]
		public ReferenceArrow(ITerm from, ITerm to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1553630", Offset = "0x1552630", VA = "0x181553630", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C2EE0", Offset = "0x3C1EE0", VA = "0x1803C2EE0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15536C0", Offset = "0x15526C0", VA = "0x1815536C0", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x37F200", Offset = "0x37E200", VA = "0x18037F200")]
		public ReferenceIdentifier(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x15537D0", Offset = "0x15527D0", VA = "0x1815537D0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xEE3E30", Offset = "0xEE2E30", VA = "0x180EE3E30")]
		public ReferenceSubstitution(int identifier, ITerm value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1553950", Offset = "0x1552950", VA = "0x181553950")]
		public ReferenceSubstitution(in Substitution substitution, Term[] terms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x15537F0", Offset = "0x15527F0", VA = "0x1815537F0")]
		private static ITerm FromTermIndex(TermIndex termIndex, Term[] terms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x15538F0", Offset = "0x15528F0", VA = "0x1815538F0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1533A0", Offset = "0x1527A0", VA = "0x1801533A0")]
			public IntBytesUnion(int intVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1BC220", Offset = "0x1BB620", VA = "0x1801BC220")]
			public IntBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1BC210", Offset = "0x1BB610", VA = "0x1801BC210")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1551880", Offset = "0x1550880", VA = "0x181551880")]
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
		[Cpp2IlInjected.Address(RVA = "0x1553DE0", Offset = "0x1552DE0", VA = "0x181553DE0")]
		internal static bool TryGetTypeSerializer(CircuitType signalType, out ITypeSerializer typeSerializer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1553C70", Offset = "0x1552C70", VA = "0x181553C70")]
		public static void SerializeSignalForSync(Stream stream, CircuitType signalType, CircuitSignal signalValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1553AE0", Offset = "0x1552AE0", VA = "0x181553AE0")]
		public static CircuitSignal DeserializeSyncedSignal(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x15540D0", Offset = "0x15530D0", VA = "0x1815540D0")]
		public static void WriteInt(Stream stream, int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1551880", Offset = "0x1550880", VA = "0x181551880")]
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
		[Cpp2IlInjected.Address(RVA = "0x822860", Offset = "0x821860", VA = "0x180822860", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1543C20", Offset = "0x1542C20", VA = "0x181543C20", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1543BC0", Offset = "0x1542BC0", VA = "0x181543BC0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		public BooleanSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class IntSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8225F0", Offset = "0x8215F0", VA = "0x1808225F0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1552730", Offset = "0x1551730", VA = "0x181552730", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x15526B0", Offset = "0x15516B0", VA = "0x1815526B0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
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
			[Cpp2IlInjected.Address(RVA = "0x15D2C0", Offset = "0x15C6C0", VA = "0x18015D2C0")]
			public FloatBytesUnion(float floatVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x1BC220", Offset = "0x1BB620", VA = "0x1801BC220")]
			public FloatBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x1BC210", Offset = "0x1BB610", VA = "0x1801BC210")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1551880", Offset = "0x1550880", VA = "0x181551880")]
			public static FloatBytesUnion ReadFromStream(Stream stream)
			{
				return default(FloatBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x15519B0", Offset = "0x15509B0", VA = "0x1815519B0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1551AA0", Offset = "0x1550AA0", VA = "0x181551AA0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x15519D0", Offset = "0x15509D0", VA = "0x1815519D0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		public FloatSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class StringSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x15542F0", Offset = "0x15532F0", VA = "0x1815542F0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1554450", Offset = "0x1553450", VA = "0x181554450", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1554310", Offset = "0x1553310", VA = "0x181554310", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		public StringSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class PlayerSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1552F80", Offset = "0x1551F80", VA = "0x181552F80", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1553090", Offset = "0x1552090", VA = "0x181553090", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1553010", Offset = "0x1552010", VA = "0x181553010", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		public PlayerSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class ListSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1552930", Offset = "0x1551930", VA = "0x181552930", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1552BE0", Offset = "0x1551BE0", VA = "0x181552BE0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1552A50", Offset = "0x1551A50", VA = "0x181552A50", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
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
			[Cpp2IlInjected.Address(RVA = "0x1649150", Offset = "0x1648150", VA = "0x181649150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1647D80", Offset = "0x1646D80", VA = "0x181647D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x164A7B0", Offset = "0x16497B0", VA = "0x18164A7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x164A6F0", Offset = "0x16496F0", VA = "0x18164A6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x164A810", Offset = "0x1649810", VA = "0x18164A810", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x164A960", Offset = "0x1649960", VA = "0x18164A960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x164AA00", Offset = "0x1649A00", VA = "0x18164AA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public PortCollectionData InputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PortCollectionData OutputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x43BD90", Offset = "0x43AD90", VA = "0x18043BD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public RepeatedField<NodeConnectionData> NodeConnectionDatas
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3A4110", Offset = "0x3A3110", VA = "0x1803A4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x38D8B0", Offset = "0x38C8B0", VA = "0x18038D8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x164A9B0", Offset = "0x16499B0", VA = "0x18164A9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF30", Offset = "0x3E9F30", VA = "0x1803EAF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x47CB10", Offset = "0x47BB10", VA = "0x18047CB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x39C320", Offset = "0x39B320", VA = "0x18039C320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x47E400", Offset = "0x47D400", VA = "0x18047E400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public ByteString InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x38F140", Offset = "0x38E140", VA = "0x18038F140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x164A910", Offset = "0x1649910", VA = "0x18164A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> ListensToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x391BC0", Offset = "0x390BC0", VA = "0x180391BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5850", Offset = "0x3C4850", VA = "0x1803C5850")]
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
			[Cpp2IlInjected.Address(RVA = "0x38B5A0", Offset = "0x38A5A0", VA = "0x18038B5A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x4E95A0", Offset = "0x4E85A0", VA = "0x1804E95A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public VariableNodeData VariableNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x45DA90", Offset = "0x45CA90", VA = "0x18045DA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x456820", Offset = "0x455820", VA = "0x180456820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x164A3C0", Offset = "0x16493C0", VA = "0x18164A3C0")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x164A590", Offset = "0x1649590", VA = "0x18164A590")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1649520", Offset = "0x1648520", VA = "0x181649520", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x16497A0", Offset = "0x16487A0", VA = "0x1816497A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1649580", Offset = "0x1648580", VA = "0x181649580", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1649800", Offset = "0x1648800", VA = "0x181649800", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1649DE0", Offset = "0x1648DE0", VA = "0x181649DE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1649E40", Offset = "0x1648E40", VA = "0x181649E40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x16491B0", Offset = "0x16481B0", VA = "0x1816491B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1649A10", Offset = "0x1648A10", VA = "0x181649A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x164B580", Offset = "0x164A580", VA = "0x18164B580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x164AA50", Offset = "0x1649A50", VA = "0x18164AA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x155A030", Offset = "0x1559030", VA = "0x18155A030")]
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
			[Cpp2IlInjected.Address(RVA = "0x1559F70", Offset = "0x1558F70", VA = "0x181559F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x155A090", Offset = "0x1559090", VA = "0x18155A090", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x570BF0", Offset = "0x56FBF0", VA = "0x180570BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x570350", Offset = "0x56F350", VA = "0x180570350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x569C80", Offset = "0x568C80", VA = "0x180569C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x56A030", Offset = "0x569030", VA = "0x18056A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x4F5100", Offset = "0x4F4100", VA = "0x1804F5100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x5A2D90", Offset = "0x5A1D90", VA = "0x1805A2D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x5A32D0", Offset = "0x5A22D0", VA = "0x1805A32D0")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1559D50", Offset = "0x1558D50", VA = "0x181559D50", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1559DC0", Offset = "0x1558DC0", VA = "0x181559DC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x665940", Offset = "0x664940", VA = "0x180665940", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x665A70", Offset = "0x664A70", VA = "0x180665A70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1559E50", Offset = "0x1558E50", VA = "0x181559E50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x665CF0", Offset = "0x664CF0", VA = "0x180665CF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x665890", Offset = "0x664890", VA = "0x180665890", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x665C10", Offset = "0x664C10", VA = "0x180665C10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEBD80", Offset = "0x1FEAD80", VA = "0x181FEBD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEBCC0", Offset = "0x1FEACC0", VA = "0x181FEBCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEBDE0", Offset = "0x1FEADE0", VA = "0x181FEBDE0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x570BF0", Offset = "0x56FBF0", VA = "0x180570BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x570350", Offset = "0x56F350", VA = "0x180570350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x569C80", Offset = "0x568C80", VA = "0x180569C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x56A030", Offset = "0x569030", VA = "0x18056A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4F5100", Offset = "0x4F4100", VA = "0x1804F5100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x5A2D90", Offset = "0x5A1D90", VA = "0x1805A2D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4F4660", Offset = "0x4F3660", VA = "0x1804F4660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x4F4670", Offset = "0x4F3670", VA = "0x1804F4670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public QuaternionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x660F10", Offset = "0x65FF10", VA = "0x180660F10")]
		[DebuggerNonUserCode]
		public QuaternionData(QuaternionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBA80", Offset = "0x1FEAA80", VA = "0x181FEBA80", Slot = "9")]
		[DebuggerNonUserCode]
		public QuaternionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBB00", Offset = "0x1FEAB00", VA = "0x181FEBB00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xB89B50", Offset = "0xB88B50", VA = "0x180B89B50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(QuaternionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xB89CA0", Offset = "0xB88CA0", VA = "0x180B89CA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBBA0", Offset = "0x1FEABA0", VA = "0x181FEBBA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xB89F80", Offset = "0xB88F80", VA = "0x180B89F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xB89A80", Offset = "0xB88A80", VA = "0x180B89A80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xB89E70", Offset = "0xB88E70", VA = "0x180B89E70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x164BEC0", Offset = "0x164AEC0", VA = "0x18164BEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x164BE00", Offset = "0x164AE00", VA = "0x18164BE00")]
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
			[Cpp2IlInjected.Address(RVA = "0x164BF20", Offset = "0x164AF20", VA = "0x18164BF20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x164C020", Offset = "0x164B020", VA = "0x18164C020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public Vector3Data LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public QuaternionData LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x164BD50", Offset = "0x164AD50", VA = "0x18164BD50")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x164BCD0", Offset = "0x164ACD0", VA = "0x18164BCD0")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData(CircuitObjectTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x164B6E0", Offset = "0x164A6E0", VA = "0x18164B6E0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x164B850", Offset = "0x164A850", VA = "0x18164B850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x164B780", Offset = "0x164A780", VA = "0x18164B780", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitObjectTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x164B960", Offset = "0x164A960", VA = "0x18164B960", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x164BB00", Offset = "0x164AB00", VA = "0x18164BB00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x164BB60", Offset = "0x164AB60", VA = "0x18164BB60", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x164B5E0", Offset = "0x164A5E0", VA = "0x18164B5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x164B9F0", Offset = "0x164A9F0", VA = "0x18164B9F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x164C680", Offset = "0x164B680", VA = "0x18164C680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x164C070", Offset = "0x164B070", VA = "0x18164C070")]
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
			[Cpp2IlInjected.Address(RVA = "0x164CF00", Offset = "0x164BF00", VA = "0x18164CF00")]
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
			[Cpp2IlInjected.Address(RVA = "0x164CE40", Offset = "0x164BE40", VA = "0x18164CE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x164CF60", Offset = "0x164BF60", VA = "0x18164CF60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public bool BackingBool
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x409620", Offset = "0x408620", VA = "0x180409620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x409CF0", Offset = "0x408CF0", VA = "0x180409CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int BackingInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x403E00", Offset = "0x402E00", VA = "0x180403E00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x403F40", Offset = "0x402F40", VA = "0x180403F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public float BackingFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4F4660", Offset = "0x4F3660", VA = "0x1804F4660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4F4670", Offset = "0x4F3670", VA = "0x1804F4670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public string BackingString
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x164D060", Offset = "0x164C060", VA = "0x18164D060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x164CD80", Offset = "0x164BD80", VA = "0x18164CD80")]
		[DebuggerNonUserCode]
		public CircuitSignalData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x164CDC0", Offset = "0x164BDC0", VA = "0x18164CDC0")]
		[DebuggerNonUserCode]
		public CircuitSignalData(CircuitSignalData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x164C7E0", Offset = "0x164B7E0", VA = "0x18164C7E0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitSignalData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x164C8F0", Offset = "0x164B8F0", VA = "0x18164C8F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x164C890", Offset = "0x164B890", VA = "0x18164C890", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitSignalData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x164C9A0", Offset = "0x164B9A0", VA = "0x18164C9A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x164CB50", Offset = "0x164BB50", VA = "0x18164CB50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x164CBB0", Offset = "0x164BBB0", VA = "0x18164CBB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x164C6E0", Offset = "0x164B6E0", VA = "0x18164C6E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x164CA80", Offset = "0x164BA80", VA = "0x18164CA80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1642B30", Offset = "0x1641B30", VA = "0x181642B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1641FE0", Offset = "0x1640FE0", VA = "0x181641FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1643C00", Offset = "0x1642C00", VA = "0x181643C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1643B40", Offset = "0x1642B40", VA = "0x181643B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1643C60", Offset = "0x1642C60", VA = "0x181643C60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x1643D60", Offset = "0x1642D60", VA = "0x181643D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public ByteString ContextTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x1643DB0", Offset = "0x1642DB0", VA = "0x181643DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public CircuitSerializationVersion SerializationVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x49D700", Offset = "0x49C700", VA = "0x18049D700")]
			get
			{
				return default(CircuitSerializationVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x49D590", Offset = "0x49C590", VA = "0x18049D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public EventBusData EventBusData
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x43BD90", Offset = "0x43AD90", VA = "0x18043BD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> NodeDatas
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3A4110", Offset = "0x3A3110", VA = "0x1803A4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x38D8B0", Offset = "0x38C8B0", VA = "0x18038D8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CD60", Offset = "0x39BD60", VA = "0x18039CD60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x55CB70", Offset = "0x55BB70", VA = "0x18055CB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x16439F0", Offset = "0x16429F0", VA = "0x1816439F0")]
		[DebuggerNonUserCode]
		public CircuitContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1643930", Offset = "0x1642930", VA = "0x181643930")]
		[DebuggerNonUserCode]
		public CircuitContextData(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1642D80", Offset = "0x1641D80", VA = "0x181642D80", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1642F20", Offset = "0x1641F20", VA = "0x181642F20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1642DE0", Offset = "0x1641DE0", VA = "0x181642DE0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1643090", Offset = "0x1642090", VA = "0x181643090", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1643540", Offset = "0x1642540", VA = "0x181643540", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x16435A0", Offset = "0x16425A0", VA = "0x1816435A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1642B90", Offset = "0x1641B90", VA = "0x181642B90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x16433C0", Offset = "0x16423C0", VA = "0x1816433C0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x16431C0", Offset = "0x16421C0", VA = "0x1816431C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDC210", Offset = "0x1FDB210", VA = "0x181FDC210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA530", Offset = "0x1FD9530", VA = "0x181FDA530")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDCA60", Offset = "0x1FDBA60", VA = "0x181FDCA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDC9A0", Offset = "0x1FDB9A0", VA = "0x181FDC9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDCAC0", Offset = "0x1FDBAC0", VA = "0x181FDCAC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC890", Offset = "0x1FDB890", VA = "0x181FDC890")]
		[DebuggerNonUserCode]
		public EventBusData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC8F0", Offset = "0x1FDB8F0", VA = "0x181FDC8F0")]
		[DebuggerNonUserCode]
		public EventBusData(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC2F0", Offset = "0x1FDB2F0", VA = "0x181FDC2F0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventBusData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC3D0", Offset = "0x1FDB3D0", VA = "0x181FDC3D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC4A0", Offset = "0x1FDB4A0", VA = "0x181FDC4A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventBusData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3A9510", Offset = "0x3A8510", VA = "0x1803A9510", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC640", Offset = "0x1FDB640", VA = "0x181FDC640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC6A0", Offset = "0x1FDB6A0", VA = "0x181FDC6A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC270", Offset = "0x1FDB270", VA = "0x181FDC270", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC5E0", Offset = "0x1FDB5E0", VA = "0x181FDC5E0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC520", Offset = "0x1FDB520", VA = "0x181FDC520", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x16472B0", Offset = "0x16462B0", VA = "0x1816472B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16471F0", Offset = "0x16461F0", VA = "0x1816471F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1647310", Offset = "0x1646310", VA = "0x181647310", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x37F230", Offset = "0x37E230", VA = "0x18037F230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x16470D0", Offset = "0x16460D0", VA = "0x1816470D0")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData(CircuitEventObjectData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1646AF0", Offset = "0x1645AF0", VA = "0x181646AF0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x1646C30", Offset = "0x1645C30", VA = "0x181646C30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x1646CF0", Offset = "0x1645CF0", VA = "0x181646CF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventObjectData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1646D60", Offset = "0x1645D60", VA = "0x181646D60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1646F10", Offset = "0x1645F10", VA = "0x181646F10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1646F70", Offset = "0x1645F70", VA = "0x181646F70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x1646A00", Offset = "0x1645A00", VA = "0x181646A00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1646DE0", Offset = "0x1645DE0", VA = "0x181646DE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1645E40", Offset = "0x1644E40", VA = "0x181645E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1645D80", Offset = "0x1644D80", VA = "0x181645D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1645EA0", Offset = "0x1644EA0", VA = "0x181645EA0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1645FA0", Offset = "0x1644FA0", VA = "0x181645FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1645FF0", Offset = "0x1644FF0", VA = "0x181645FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventProperty> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1645C90", Offset = "0x1644C90", VA = "0x181645C90")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1645C10", Offset = "0x1644C10", VA = "0x181645C10")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData(CircuitEventDefinitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1645500", Offset = "0x1644500", VA = "0x181645500", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x16455A0", Offset = "0x16445A0", VA = "0x1816455A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x16456C0", Offset = "0x16446C0", VA = "0x1816456C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventDefinitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x16457A0", Offset = "0x16447A0", VA = "0x1816457A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1645950", Offset = "0x1644950", VA = "0x181645950", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x16459B0", Offset = "0x16449B0", VA = "0x1816459B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x16453E0", Offset = "0x16443E0", VA = "0x1816453E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1645840", Offset = "0x1644840", VA = "0x181645840", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1647B60", Offset = "0x1646B60", VA = "0x181647B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x1647AA0", Offset = "0x1646AA0", VA = "0x181647AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1647BC0", Offset = "0x1646BC0", VA = "0x181647BC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x1647CC0", Offset = "0x1646CC0", VA = "0x181647CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x16479A0", Offset = "0x16469A0", VA = "0x1816479A0")]
		[DebuggerNonUserCode]
		public CircuitEventProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x16479E0", Offset = "0x16469E0", VA = "0x1816479E0")]
		[DebuggerNonUserCode]
		public CircuitEventProperty(CircuitEventProperty other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x16474D0", Offset = "0x16464D0", VA = "0x1816474D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventProperty Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1647610", Offset = "0x1646610", VA = "0x181647610", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x16475B0", Offset = "0x16465B0", VA = "0x1816475B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x16476C0", Offset = "0x16466C0", VA = "0x1816476C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1647800", Offset = "0x1646800", VA = "0x181647800", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1647860", Offset = "0x1646860", VA = "0x181647860", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1647410", Offset = "0x1646410", VA = "0x181647410", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1647730", Offset = "0x1646730", VA = "0x181647730", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDDD10", Offset = "0x1FDCD10", VA = "0x181FDDD10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDDC50", Offset = "0x1FDCC50", VA = "0x181FDDC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDDD70", Offset = "0x1FDCD70", VA = "0x181FDDD70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDEC0", Offset = "0x1FDCEC0", VA = "0x181FDDEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public ByteString EventDefinitionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDE70", Offset = "0x1FDCE70", VA = "0x181FDDE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDB50", Offset = "0x1FDCB50", VA = "0x181FDDB50")]
		[DebuggerNonUserCode]
		public EventRegistrationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDB10", Offset = "0x1FDCB10", VA = "0x181FDDB10")]
		[DebuggerNonUserCode]
		public EventRegistrationData(EventRegistrationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD5D0", Offset = "0x1FDC5D0", VA = "0x181FDD5D0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventRegistrationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD640", Offset = "0x1FDC640", VA = "0x181FDD640", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD770", Offset = "0x1FDC770", VA = "0x181FDD770", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventRegistrationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD850", Offset = "0x1FDC850", VA = "0x181FDD850", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD960", Offset = "0x1FDC960", VA = "0x181FDD960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD9C0", Offset = "0x1FDC9C0", VA = "0x181FDD9C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD500", Offset = "0x1FDC500", VA = "0x181FDD500", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD8E0", Offset = "0x1FDC8E0", VA = "0x181FDD8E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEE3C0", Offset = "0x1FED3C0", VA = "0x181FEE3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEE300", Offset = "0x1FED300", VA = "0x181FEE300")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEE420", Offset = "0x1FED420", VA = "0x181FEE420", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x1FEE520", Offset = "0x1FED520", VA = "0x181FEE520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public RepeatedField<EventDataKeyValuePair> Datas
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE220", Offset = "0x1FED220", VA = "0x181FEE220")]
		[DebuggerNonUserCode]
		public SynchronizedEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE1B0", Offset = "0x1FED1B0", VA = "0x181FEE1B0")]
		[DebuggerNonUserCode]
		public SynchronizedEventData(SynchronizedEventData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDB40", Offset = "0x1FECB40", VA = "0x181FEDB40", Slot = "9")]
		[DebuggerNonUserCode]
		public SynchronizedEventData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDBE0", Offset = "0x1FECBE0", VA = "0x181FEDBE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDCF0", Offset = "0x1FECCF0", VA = "0x181FEDCF0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SynchronizedEventData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDDB0", Offset = "0x1FECDB0", VA = "0x181FEDDB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDF20", Offset = "0x1FECF20", VA = "0x181FEDF20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDF80", Offset = "0x1FECF80", VA = "0x181FEDF80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDA70", Offset = "0x1FECA70", VA = "0x181FEDA70", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDE30", Offset = "0x1FECE30", VA = "0x181FEDE30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDD300", Offset = "0x1FDC300", VA = "0x181FDD300")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDD240", Offset = "0x1FDC240", VA = "0x181FDD240")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDD360", Offset = "0x1FDC360", VA = "0x181FDD360", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD460", Offset = "0x1FDC460", VA = "0x181FDD460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD4B0", Offset = "0x1FDC4B0", VA = "0x181FDD4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD180", Offset = "0x1FDC180", VA = "0x181FDD180")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD140", Offset = "0x1FDC140", VA = "0x181FDD140")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair(EventDataKeyValuePair other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCC90", Offset = "0x1FDBC90", VA = "0x181FDCC90", Slot = "9")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCDA0", Offset = "0x1FDBDA0", VA = "0x181FDCDA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCD00", Offset = "0x1FDBD00", VA = "0x181FDCD00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventDataKeyValuePair other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCE90", Offset = "0x1FDBE90", VA = "0x181FDCE90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCF90", Offset = "0x1FDBF90", VA = "0x181FDCF90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCFF0", Offset = "0x1FDBFF0", VA = "0x181FDCFF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCBC0", Offset = "0x1FDBBC0", VA = "0x181FDCBC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCF10", Offset = "0x1FDBF10", VA = "0x181FDCF10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1646850", Offset = "0x1645850", VA = "0x181646850")]
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
			[Cpp2IlInjected.Address(RVA = "0x1646790", Offset = "0x1645790", VA = "0x181646790")]
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
			[Cpp2IlInjected.Address(RVA = "0x16468B0", Offset = "0x16458B0", VA = "0x1816468B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x16469B0", Offset = "0x16459B0", VA = "0x1816469B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1646750", Offset = "0x1645750", VA = "0x181646750")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1646690", Offset = "0x1645690", VA = "0x181646690")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData(CircuitEventModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1646130", Offset = "0x1645130", VA = "0x181646130", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1646290", Offset = "0x1645290", VA = "0x181646290", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1646220", Offset = "0x1645220", VA = "0x181646220", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1646350", Offset = "0x1645350", VA = "0x181646350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x16464D0", Offset = "0x16454D0", VA = "0x1816464D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1646530", Offset = "0x1645530", VA = "0x181646530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1646040", Offset = "0x1645040", VA = "0x181646040", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x16463E0", Offset = "0x16453E0", VA = "0x1816463E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDF270", Offset = "0x1FDE270", VA = "0x181FDF270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FDECB0", Offset = "0x1FDDCB0", VA = "0x181FDECB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDF9A0", Offset = "0x1FDE9A0", VA = "0x181FDF9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDF8E0", Offset = "0x1FDE8E0", VA = "0x181FDF8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDFA00", Offset = "0x1FDEA00", VA = "0x181FDFA00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x1FDFB00", Offset = "0x1FDEB00", VA = "0x181FDFB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x49D700", Offset = "0x49C700", VA = "0x18049D700")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x49D590", Offset = "0x49C590", VA = "0x18049D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public bool OriginallyFromOtherInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x6E9050", Offset = "0x6E8050", VA = "0x1806E9050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x6E9060", Offset = "0x6E8060", VA = "0x1806E9060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF7E0", Offset = "0x1FDE7E0", VA = "0x181FDF7E0")]
		[DebuggerNonUserCode]
		public InventionPieceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF890", Offset = "0x1FDE890", VA = "0x181FDF890")]
		[DebuggerNonUserCode]
		public InventionPieceData(InventionPieceData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF3D0", Offset = "0x1FDE3D0", VA = "0x181FDF3D0", Slot = "9")]
		[DebuggerNonUserCode]
		public InventionPieceData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF510", Offset = "0x1FDE510", VA = "0x181FDF510", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF450", Offset = "0x1FDE450", VA = "0x181FDF450", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InventionPieceData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xAD17F0", Offset = "0xAD07F0", VA = "0x180AD17F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF6C0", Offset = "0x1FDE6C0", VA = "0x181FDF6C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xAD1B80", Offset = "0xAD0B80", VA = "0x180AD1B80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF2D0", Offset = "0x1FDE2D0", VA = "0x181FDF2D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF610", Offset = "0x1FDE610", VA = "0x181FDF610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644550", Offset = "0x1643550", VA = "0x181644550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x1643E00", Offset = "0x1642E00", VA = "0x181643E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644E40", Offset = "0x1643E40", VA = "0x181644E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644D80", Offset = "0x1643D80", VA = "0x181644D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1644EA0", Offset = "0x1643EA0", VA = "0x181644EA0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x409620", Offset = "0x408620", VA = "0x180409620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x409CF0", Offset = "0x408CF0", VA = "0x180409CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1644FF0", Offset = "0x1643FF0", VA = "0x181644FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public ByteString GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1644FA0", Offset = "0x1643FA0", VA = "0x181644FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1644C70", Offset = "0x1643C70", VA = "0x181644C70")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1644D30", Offset = "0x1643D30", VA = "0x181644D30")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData(CircuitContextNodeOperationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x16446C0", Offset = "0x16436C0", VA = "0x1816446C0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x16447F0", Offset = "0x16437F0", VA = "0x1816447F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1644740", Offset = "0x1643740", VA = "0x181644740", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextNodeOperationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x16448F0", Offset = "0x16438F0", VA = "0x1816448F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1644A70", Offset = "0x1643A70", VA = "0x181644A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1644AD0", Offset = "0x1643AD0", VA = "0x181644AD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x16445B0", Offset = "0x16435B0", VA = "0x1816445B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x16449B0", Offset = "0x16439B0", VA = "0x1816449B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE0F80", Offset = "0x1FDFF80", VA = "0x181FE0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFB50", Offset = "0x1FDEB50", VA = "0x181FDFB50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE1C30", Offset = "0x1FE0C30", VA = "0x181FE1C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE1B70", Offset = "0x1FE0B70", VA = "0x181FE1B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE1C90", Offset = "0x1FE0C90", VA = "0x181FE1C90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1D90", Offset = "0x1FE0D90", VA = "0x181FE1D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public ByteString ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1E30", Offset = "0x1FE0E30", VA = "0x181FE1E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CircuitObjectType ModifiedObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x49D700", Offset = "0x49C700", VA = "0x18049D700")]
			get
			{
				return default(CircuitObjectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x49D590", Offset = "0x49C590", VA = "0x18049D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public ByteString ModificationHandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1DE0", Offset = "0x1FE0DE0", VA = "0x181FE1DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x3A4110", Offset = "0x3A3110", VA = "0x1803A4110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1E80", Offset = "0x1FE0E80", VA = "0x181FE1E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE19D0", Offset = "0x1FE09D0", VA = "0x181FE19D0")]
		[DebuggerNonUserCode]
		public ModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1970", Offset = "0x1FE0970", VA = "0x181FE1970")]
		[DebuggerNonUserCode]
		public ModificationData(ModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1180", Offset = "0x1FE0180", VA = "0x181FE1180", Slot = "9")]
		[DebuggerNonUserCode]
		public ModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1200", Offset = "0x1FE0200", VA = "0x181FE1200", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE13B0", Offset = "0x1FE03B0", VA = "0x181FE13B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1500", Offset = "0x1FE0500", VA = "0x181FE1500", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1710", Offset = "0x1FE0710", VA = "0x181FE1710", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1770", Offset = "0x1FE0770", VA = "0x181FE1770", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0FE0", Offset = "0x1FDFFE0", VA = "0x181FE0FE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1620", Offset = "0x1FE0620", VA = "0x181FE1620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE6670", Offset = "0x1FE5670", VA = "0x181FE6670")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE65B0", Offset = "0x1FE55B0", VA = "0x181FE65B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE66D0", Offset = "0x1FE56D0", VA = "0x181FE66D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1FE67D0", Offset = "0x1FE57D0", VA = "0x181FE67D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6820", Offset = "0x1FE5820", VA = "0x181FE6820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x3A31E0", Offset = "0x3A21E0", VA = "0x1803A31E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x3A31F0", Offset = "0x3A21F0", VA = "0x1803A31F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6870", Offset = "0x1FE5870", VA = "0x181FE6870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6410", Offset = "0x1FE5410", VA = "0x181FE6410")]
		[DebuggerNonUserCode]
		public PortAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6560", Offset = "0x1FE5560", VA = "0x181FE6560")]
		[DebuggerNonUserCode]
		public PortAddress(PortAddress other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5D30", Offset = "0x1FE4D30", VA = "0x181FE5D30", Slot = "9")]
		[DebuggerNonUserCode]
		public PortAddress Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5DB0", Offset = "0x1FE4DB0", VA = "0x181FE5DB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5F20", Offset = "0x1FE4F20", VA = "0x181FE5F20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortAddress other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6040", Offset = "0x1FE5040", VA = "0x181FE6040", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1FE61F0", Offset = "0x1FE51F0", VA = "0x181FE61F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6250", Offset = "0x1FE5250", VA = "0x181FE6250", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5C00", Offset = "0x1FE4C00", VA = "0x181FE5C00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6120", Offset = "0x1FE5120", VA = "0x181FE6120", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEB040", Offset = "0x1FEA040", VA = "0x181FEB040")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEAF80", Offset = "0x1FE9F80", VA = "0x181FEAF80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEB0A0", Offset = "0x1FEA0A0", VA = "0x181FEB0A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x409620", Offset = "0x408620", VA = "0x180409620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x409CF0", Offset = "0x408CF0", VA = "0x180409CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1FEB1A0", Offset = "0x1FEA1A0", VA = "0x181FEB1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerNonUserCode]
		public NodePortData PortData
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAE00", Offset = "0x1FE9E00", VA = "0x181FEAE00")]
		[DebuggerNonUserCode]
		public PortModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAEB0", Offset = "0x1FE9EB0", VA = "0x181FEAEB0")]
		[DebuggerNonUserCode]
		public PortModificationData(PortModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA760", Offset = "0x1FE9760", VA = "0x181FEA760", Slot = "9")]
		[DebuggerNonUserCode]
		public PortModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA920", Offset = "0x1FE9920", VA = "0x181FEA920", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA850", Offset = "0x1FE9850", VA = "0x181FEA850", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAA30", Offset = "0x1FE9A30", VA = "0x181FEAA30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAC00", Offset = "0x1FE9C00", VA = "0x181FEAC00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAC60", Offset = "0x1FE9C60", VA = "0x181FEAC60", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA660", Offset = "0x1FE9660", VA = "0x181FEA660", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAAF0", Offset = "0x1FE9AF0", VA = "0x181FEAAF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE8710", Offset = "0x1FE7710", VA = "0x181FE8710")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE8650", Offset = "0x1FE7650", VA = "0x181FE8650")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE8770", Offset = "0x1FE7770", VA = "0x181FE8770", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1FE8870", Offset = "0x1FE7870", VA = "0x181FE8870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8540", Offset = "0x1FE7540", VA = "0x181FE8540")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE85F0", Offset = "0x1FE75F0", VA = "0x181FE85F0")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData(PortDefaultValuePayloadData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8110", Offset = "0x1FE7110", VA = "0x181FE8110", Slot = "9")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE81A0", Offset = "0x1FE71A0", VA = "0x181FE81A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE82A0", Offset = "0x1FE72A0", VA = "0x181FE82A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortDefaultValuePayloadData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9EC0", Offset = "0x1FD8EC0", VA = "0x181FD9EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8420", Offset = "0x1FE7420", VA = "0x181FE8420", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA070", Offset = "0x1FD9070", VA = "0x181FDA070", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8050", Offset = "0x1FE7050", VA = "0x181FE8050", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8350", Offset = "0x1FE7350", VA = "0x181FE8350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE22C0", Offset = "0x1FE12C0", VA = "0x181FE22C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1ED0", Offset = "0x1FE0ED0", VA = "0x181FE1ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE2EC0", Offset = "0x1FE1EC0", VA = "0x181FE2EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE2E00", Offset = "0x1FE1E00", VA = "0x181FE2E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE2F20", Offset = "0x1FE1F20", VA = "0x181FE2F20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FE30C0", Offset = "0x1FE20C0", VA = "0x181FE30C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public ByteString SrcPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FE3110", Offset = "0x1FE2110", VA = "0x181FE3110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[DebuggerNonUserCode]
		public ByteString DstNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x1FE3020", Offset = "0x1FE2020", VA = "0x181FE3020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		[DebuggerNonUserCode]
		public ByteString DstPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FE3070", Offset = "0x1FE2070", VA = "0x181FE3070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2C60", Offset = "0x1FE1C60", VA = "0x181FE2C60")]
		[DebuggerNonUserCode]
		public NodeConnectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2C10", Offset = "0x1FE1C10", VA = "0x181FE2C10")]
		[DebuggerNonUserCode]
		public NodeConnectionData(NodeConnectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2490", Offset = "0x1FE1490", VA = "0x181FE2490", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeConnectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2660", Offset = "0x1FE1660", VA = "0x181FE2660", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2510", Offset = "0x1FE1510", VA = "0x181FE2510", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeConnectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2800", Offset = "0x1FE1800", VA = "0x181FE2800", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE29E0", Offset = "0x1FE19E0", VA = "0x181FE29E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2A40", Offset = "0x1FE1A40", VA = "0x181FE2A40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2320", Offset = "0x1FE1320", VA = "0x181FE2320", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2900", Offset = "0x1FE1900", VA = "0x181FE2900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE3790", Offset = "0x1FE2790", VA = "0x181FE3790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3160", Offset = "0x1FE2160", VA = "0x181FE3160")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE40E0", Offset = "0x1FE30E0", VA = "0x181FE40E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE4020", Offset = "0x1FE3020", VA = "0x181FE4020")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE4140", Offset = "0x1FE3140", VA = "0x181FE4140", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FE4240", Offset = "0x1FE3240", VA = "0x181FE4240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public string PortName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FE4290", Offset = "0x1FE3290", VA = "0x181FE4290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public CircuitTypeData GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3EF0", Offset = "0x1FE2EF0", VA = "0x181FE3EF0")]
		[DebuggerNonUserCode]
		public NodePortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3FB0", Offset = "0x1FE2FB0", VA = "0x181FE3FB0")]
		[DebuggerNonUserCode]
		public NodePortData(NodePortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FE38F0", Offset = "0x1FE28F0", VA = "0x181FE38F0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodePortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3990", Offset = "0x1FE2990", VA = "0x181FE3990", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3AA0", Offset = "0x1FE2AA0", VA = "0x181FE3AA0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodePortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3B70", Offset = "0x1FE2B70", VA = "0x181FE3B70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3D10", Offset = "0x1FE2D10", VA = "0x181FE3D10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3D70", Offset = "0x1FE2D70", VA = "0x181FE3D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE37F0", Offset = "0x1FE27F0", VA = "0x181FE37F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3C10", Offset = "0x1FE2C10", VA = "0x181FE3C10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE45C0", Offset = "0x1FE35C0", VA = "0x181FE45C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1FE42E0", Offset = "0x1FE32E0", VA = "0x181FE42E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE4BB0", Offset = "0x1FE3BB0", VA = "0x181FE4BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE4AF0", Offset = "0x1FE3AF0", VA = "0x181FE4AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE4C10", Offset = "0x1FE3C10", VA = "0x181FE4C10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x1FE4D10", Offset = "0x1FE3D10", VA = "0x181FE4D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4A40", Offset = "0x1FE3A40", VA = "0x181FE4A40")]
		[DebuggerNonUserCode]
		public NullableBytes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4A00", Offset = "0x1FE3A00", VA = "0x181FE4A00")]
		[DebuggerNonUserCode]
		public NullableBytes(NullableBytes other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1FE46A0", Offset = "0x1FE36A0", VA = "0x181FE46A0", Slot = "9")]
		[DebuggerNonUserCode]
		public NullableBytes Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE47A0", Offset = "0x1FE37A0", VA = "0x181FE47A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4710", Offset = "0x1FE3710", VA = "0x181FE4710", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NullableBytes other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7268E0", Offset = "0x7258E0", VA = "0x1807268E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE48E0", Offset = "0x1FE38E0", VA = "0x181FE48E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xAB88A0", Offset = "0xAB78A0", VA = "0x180AB88A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4620", Offset = "0x1FE3620", VA = "0x181FE4620", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4880", Offset = "0x1FE3880", VA = "0x181FE4880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE7350", Offset = "0x1FE6350", VA = "0x181FE7350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1FE68C0", Offset = "0x1FE58C0", VA = "0x181FE68C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE7EF0", Offset = "0x1FE6EF0", VA = "0x181FE7EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE7E30", Offset = "0x1FE6E30", VA = "0x181FE7E30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE7F50", Offset = "0x1FE6F50", VA = "0x181FE7F50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7D80", Offset = "0x1FE6D80", VA = "0x181FE7D80")]
		[DebuggerNonUserCode]
		public PortCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7CE0", Offset = "0x1FE6CE0", VA = "0x181FE7CE0")]
		[DebuggerNonUserCode]
		public PortCollectionData(PortCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74A0", Offset = "0x1FE64A0", VA = "0x181FE74A0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7560", Offset = "0x1FE6560", VA = "0x181FE7560", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7670", Offset = "0x1FE6670", VA = "0x181FE7670", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7720", Offset = "0x1FE6720", VA = "0x181FE7720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6930", VA = "0x181FE7930", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7990", Offset = "0x1FE6990", VA = "0x181FE7990", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1FE73B0", Offset = "0x1FE63B0", VA = "0x181FE73B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1FE77A0", Offset = "0x1FE67A0", VA = "0x181FE77A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDA380", Offset = "0x1FD9380", VA = "0x181FDA380")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDA2C0", Offset = "0x1FD92C0", VA = "0x181FDA2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDA3E0", Offset = "0x1FD93E0", VA = "0x181FDA3E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x1FDA4E0", Offset = "0x1FD94E0", VA = "0x181FDA4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA210", Offset = "0x1FD9210", VA = "0x181FDA210")]
		[DebuggerNonUserCode]
		public DefaultPortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA1B0", Offset = "0x1FD91B0", VA = "0x181FDA1B0")]
		[DebuggerNonUserCode]
		public DefaultPortData(DefaultPortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9C80", Offset = "0x1FD8C80", VA = "0x181FD9C80", Slot = "9")]
		[DebuggerNonUserCode]
		public DefaultPortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9DC0", Offset = "0x1FD8DC0", VA = "0x181FD9DC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9D10", Offset = "0x1FD8D10", VA = "0x181FD9D10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9EC0", Offset = "0x1FD8EC0", VA = "0x181FD9EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA010", Offset = "0x1FD9010", VA = "0x181FDA010", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA070", Offset = "0x1FD9070", VA = "0x181FDA070", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9BC0", Offset = "0x1FD8BC0", VA = "0x181FD9BC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9F40", Offset = "0x1FD8F40", VA = "0x181FD9F40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE9410", Offset = "0x1FE8410", VA = "0x181FE9410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1FE88C0", Offset = "0x1FE78C0", VA = "0x181FE88C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEA3C0", Offset = "0x1FE93C0", VA = "0x181FEA3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEA300", Offset = "0x1FE9300", VA = "0x181FEA300")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEA420", Offset = "0x1FE9420", VA = "0x181FEA420", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x1FEA5C0", Offset = "0x1FE95C0", VA = "0x181FEA5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x403E00", Offset = "0x402E00", VA = "0x180403E00")]
			get
			{
				return default(PortGroupType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x403F40", Offset = "0x402F40", VA = "0x180403F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public RepeatedField<NodePortData> NodePortDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1FEA610", Offset = "0x1FE9610", VA = "0x181FEA610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public CircuitTypeData ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x3A4110", Offset = "0x3A3110", VA = "0x1803A4110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x408110", Offset = "0x407110", VA = "0x180408110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		public uint NumberOfPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x6E6C90", Offset = "0x6E5C90", VA = "0x1806E6C90")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x7F0A60", Offset = "0x7EFA60", VA = "0x1807F0A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF30", Offset = "0x3E9F30", VA = "0x1803EAF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x1FEA520", Offset = "0x1FE9520", VA = "0x181FEA520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public string ExecName
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x39C320", Offset = "0x39B320", VA = "0x18039C320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1FEA570", Offset = "0x1FE9570", VA = "0x181FEA570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA200", Offset = "0x1FE9200", VA = "0x181FEA200")]
		[DebuggerNonUserCode]
		public PortGroupData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA150", Offset = "0x1FE9150", VA = "0x181FEA150")]
		[DebuggerNonUserCode]
		public PortGroupData(PortGroupData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1FE96B0", Offset = "0x1FE86B0", VA = "0x181FE96B0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortGroupData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1FE98D0", Offset = "0x1FE88D0", VA = "0x181FE98D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9790", Offset = "0x1FE8790", VA = "0x181FE9790", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortGroupData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9A50", Offset = "0x1FE8A50", VA = "0x181FE9A50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9D90", Offset = "0x1FE8D90", VA = "0x181FE9D90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9DF0", Offset = "0x1FE8DF0", VA = "0x181FE9DF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9470", Offset = "0x1FE8470", VA = "0x181FE9470", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9BA0", Offset = "0x1FE8BA0", VA = "0x181FE9BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FED060", Offset = "0x1FEC060", VA = "0x181FED060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1FECD20", Offset = "0x1FEBD20", VA = "0x181FECD20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FED910", Offset = "0x1FEC910", VA = "0x181FED910")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FED850", Offset = "0x1FEC850", VA = "0x181FED850")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FED970", Offset = "0x1FEC970", VA = "0x181FED970", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1FED750", Offset = "0x1FEC750", VA = "0x181FED750")]
		[DebuggerNonUserCode]
		public SwitchNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1FED7D0", Offset = "0x1FEC7D0", VA = "0x181FED7D0")]
		[DebuggerNonUserCode]
		public SwitchNodeData(SwitchNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1FED170", Offset = "0x1FEC170", VA = "0x181FED170", Slot = "9")]
		[DebuggerNonUserCode]
		public SwitchNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1FED220", Offset = "0x1FEC220", VA = "0x181FED220", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1FED300", Offset = "0x1FEC300", VA = "0x181FED300", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1FED390", Offset = "0x1FEC390", VA = "0x181FED390", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1FED530", Offset = "0x1FEC530", VA = "0x181FED530", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1FED590", Offset = "0x1FEC590", VA = "0x181FED590", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1FED0C0", Offset = "0x1FEC0C0", VA = "0x181FED0C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1FED3F0", Offset = "0x1FEC3F0", VA = "0x181FED3F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FF1D00", Offset = "0x1FF0D00", VA = "0x181FF1D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF3C0", Offset = "0x1FEE3C0", VA = "0x181FEF3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1641770", Offset = "0x1640770", VA = "0x181641770")]
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
			[Cpp2IlInjected.Address(RVA = "0x16416B0", Offset = "0x16406B0", VA = "0x1816416B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16417D0", Offset = "0x16407D0", VA = "0x1816417D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public CircuitTypeData OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x1641650", Offset = "0x1640650", VA = "0x181641650")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x1641540", Offset = "0x1640540", VA = "0x181641540")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData(AppliedGenericTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x1640E50", Offset = "0x163FE50", VA = "0x181640E50", Slot = "9")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x1640F90", Offset = "0x163FF90", VA = "0x181640F90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1641070", Offset = "0x1640070", VA = "0x181641070", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(AppliedGenericTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x1641100", Offset = "0x1640100", VA = "0x181641100", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x16412A0", Offset = "0x16402A0", VA = "0x1816412A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1641300", Offset = "0x1640300", VA = "0x181641300", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x1640D50", Offset = "0x163FD50", VA = "0x181640D50", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x1641180", Offset = "0x1640180", VA = "0x181641180", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x164FE20", Offset = "0x164EE20", VA = "0x18164FE20")]
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
			[Cpp2IlInjected.Address(RVA = "0x164FD60", Offset = "0x164ED60", VA = "0x18164FD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x164FE80", Offset = "0x164EE80", VA = "0x18164FE80", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3CD390", Offset = "0x3CC390", VA = "0x1803CD390")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x56A680", Offset = "0x569680", VA = "0x18056A680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData AppliedGenericType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public ClassTypeData ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		public FunctionTypeData FunctionType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x43BD90", Offset = "0x43AD90", VA = "0x18043BD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData TypeParameterReferenceType
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x3A4110", Offset = "0x3A3110", VA = "0x1803A4110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x408110", Offset = "0x407110", VA = "0x180408110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData TypeParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x38D8B0", Offset = "0x38C8B0", VA = "0x18038D8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x4003E0", Offset = "0x3FF3E0", VA = "0x1804003E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public CircuitTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x164FB10", Offset = "0x164EB10", VA = "0x18164FB10")]
		[DebuggerNonUserCode]
		public CircuitTypeData(CircuitTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x164F3A0", Offset = "0x164E3A0", VA = "0x18164F3A0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x164F4B0", Offset = "0x164E4B0", VA = "0x18164F4B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x164F400", Offset = "0x164E400", VA = "0x18164F400", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x164F5C0", Offset = "0x164E5C0", VA = "0x18164F5C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x164F8A0", Offset = "0x164E8A0", VA = "0x18164F8A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x164F900", Offset = "0x164E900", VA = "0x18164F900", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x164F1E0", Offset = "0x164E1E0", VA = "0x18164F1E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x164F6B0", Offset = "0x164E6B0", VA = "0x18164F6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1650B30", Offset = "0x164FB30", VA = "0x181650B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1650A70", Offset = "0x164FA70", VA = "0x181650A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1650B90", Offset = "0x164FB90", VA = "0x181650B90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x43BD90", Offset = "0x43AD90", VA = "0x18043BD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x1650940", Offset = "0x164F940", VA = "0x181650940")]
		[DebuggerNonUserCode]
		public ClassTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x16509C0", Offset = "0x164F9C0", VA = "0x1816509C0")]
		[DebuggerNonUserCode]
		public ClassTypeData(ClassTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x16500B0", Offset = "0x164F0B0", VA = "0x1816500B0", Slot = "9")]
		[DebuggerNonUserCode]
		public ClassTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x1650190", Offset = "0x164F190", VA = "0x181650190", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x1650290", Offset = "0x164F290", VA = "0x181650290", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ClassTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x1650340", Offset = "0x164F340", VA = "0x181650340", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x1650580", Offset = "0x164F580", VA = "0x181650580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x16505E0", Offset = "0x164F5E0", VA = "0x1816505E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x164FF80", Offset = "0x164EF80", VA = "0x18164FF80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x16503F0", Offset = "0x164F3F0", VA = "0x1816503F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDEB50", Offset = "0x1FDDB50", VA = "0x181FDEB50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDEA90", Offset = "0x1FDDA90", VA = "0x181FDEA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FDEBB0", Offset = "0x1FDDBB0", VA = "0x181FDEBB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE9E0", Offset = "0x1FDD9E0", VA = "0x181FDE9E0")]
		[DebuggerNonUserCode]
		public FunctionTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE940", Offset = "0x1FDD940", VA = "0x181FDE940")]
		[DebuggerNonUserCode]
		public FunctionTypeData(FunctionTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE030", Offset = "0x1FDD030", VA = "0x181FDE030", Slot = "9")]
		[DebuggerNonUserCode]
		public FunctionTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE100", Offset = "0x1FDD100", VA = "0x181FDE100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE210", Offset = "0x1FDD210", VA = "0x181FDE210", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(FunctionTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE2D0", Offset = "0x1FDD2D0", VA = "0x181FDE2D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE530", Offset = "0x1FDD530", VA = "0x181FDE530", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE590", Offset = "0x1FDD590", VA = "0x181FDE590", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDF10", Offset = "0x1FDCF10", VA = "0x181FDDF10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE380", Offset = "0x1FDD380", VA = "0x181FDE380", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE5240", Offset = "0x1FE4240", VA = "0x181FE5240")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE5180", Offset = "0x1FE4180", VA = "0x181FE5180")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE52A0", Offset = "0x1FE42A0", VA = "0x181FE52A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public ParameterData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5120", Offset = "0x1FE4120", VA = "0x181FE5120")]
		[DebuggerNonUserCode]
		public ParameterData(ParameterData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4E20", Offset = "0x1FE3E20", VA = "0x181FE4E20", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4EB0", Offset = "0x1FE3EB0", VA = "0x181FE4EB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x74CE60", Offset = "0x74BE60", VA = "0x18074CE60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x74CF90", Offset = "0x74BF90", VA = "0x18074CF90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5000", Offset = "0x1FE4000", VA = "0x181FE5000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x74D280", Offset = "0x74C280", VA = "0x18074D280", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4D60", Offset = "0x1FE3D60", VA = "0x181FE4D60", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4F40", Offset = "0x1FE3F40", VA = "0x181FE4F40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE5A50", Offset = "0x1FE4A50", VA = "0x181FE5A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE5990", Offset = "0x1FE4990", VA = "0x181FE5990")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FE5AB0", Offset = "0x1FE4AB0", VA = "0x181FE5AB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x1FE5BB0", Offset = "0x1FE4BB0", VA = "0x181FE5BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public ParameterData Value
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5870", Offset = "0x1FE4870", VA = "0x181FE5870")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE58B0", Offset = "0x1FE48B0", VA = "0x181FE58B0")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData(ParameterWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5490", Offset = "0x1FE4490", VA = "0x181FE5490", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE55A0", Offset = "0x1FE45A0", VA = "0x181FE55A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x1646220", Offset = "0x1645220", VA = "0x181646220", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x1646350", Offset = "0x1645350", VA = "0x181646350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5750", Offset = "0x1FE4750", VA = "0x181FE5750", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x1646530", Offset = "0x1645530", VA = "0x181646530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1FE53A0", Offset = "0x1FE43A0", VA = "0x181FE53A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5660", Offset = "0x1FE4660", VA = "0x181FE5660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEB920", Offset = "0x1FEA920", VA = "0x181FEB920")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEB860", Offset = "0x1FEA860", VA = "0x181FEB860")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEB980", Offset = "0x1FEA980", VA = "0x181FEB980", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DebuggerNonUserCode]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3A31E0", Offset = "0x3A21E0", VA = "0x1803A31E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3A31F0", Offset = "0x3A21F0", VA = "0x1803A31F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[DebuggerNonUserCode]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x5307D0", Offset = "0x52F7D0", VA = "0x1805307D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x531CC0", Offset = "0x530CC0", VA = "0x180531CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public PropertyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB800", Offset = "0x1FEA800", VA = "0x181FEB800")]
		[DebuggerNonUserCode]
		public PropertyData(PropertyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB2B0", Offset = "0x1FEA2B0", VA = "0x181FEB2B0", Slot = "9")]
		[DebuggerNonUserCode]
		public PropertyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB340", Offset = "0x1FEA340", VA = "0x181FEB340", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB400", Offset = "0x1FEA400", VA = "0x181FEB400", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PropertyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB470", Offset = "0x1FEA470", VA = "0x181FEB470", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB610", Offset = "0x1FEA610", VA = "0x181FEB610", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB670", Offset = "0x1FEA670", VA = "0x181FEB670", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB1F0", Offset = "0x1FEA1F0", VA = "0x181FEB1F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB510", Offset = "0x1FEA510", VA = "0x181FEB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEC360", Offset = "0x1FEB360", VA = "0x181FEC360")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEC2A0", Offset = "0x1FEB2A0", VA = "0x181FEC2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEC3C0", Offset = "0x1FEB3C0", VA = "0x181FEC3C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x390B20", Offset = "0x38FB20", VA = "0x180390B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		[DebuggerNonUserCode]
		public ReturnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5120", Offset = "0x1FE4120", VA = "0x181FE5120")]
		[DebuggerNonUserCode]
		public ReturnData(ReturnData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBFA0", Offset = "0x1FEAFA0", VA = "0x181FEBFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC030", Offset = "0x1FEB030", VA = "0x181FEC030", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x74CE60", Offset = "0x74BE60", VA = "0x18074CE60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x74CF90", Offset = "0x74BF90", VA = "0x18074CF90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC180", Offset = "0x1FEB180", VA = "0x181FEC180", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x74D280", Offset = "0x74C280", VA = "0x18074D280", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBEE0", Offset = "0x1FEAEE0", VA = "0x181FEBEE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC0C0", Offset = "0x1FEB0C0", VA = "0x181FEC0C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FECB70", Offset = "0x1FEBB70", VA = "0x181FECB70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FECAB0", Offset = "0x1FEBAB0", VA = "0x181FECAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FECBD0", Offset = "0x1FEBBD0", VA = "0x181FECBD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x1FECCD0", Offset = "0x1FEBCD0", VA = "0x181FECCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public ReturnData Value
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC990", Offset = "0x1FEB990", VA = "0x181FEC990")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC9D0", Offset = "0x1FEB9D0", VA = "0x181FEC9D0")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData(ReturnWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC5B0", Offset = "0x1FEB5B0", VA = "0x181FEC5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC6C0", Offset = "0x1FEB6C0", VA = "0x181FEC6C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x1646220", Offset = "0x1645220", VA = "0x181646220", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x1646350", Offset = "0x1645350", VA = "0x181646350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC870", Offset = "0x1FEB870", VA = "0x181FEC870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x1646530", Offset = "0x1645530", VA = "0x181646530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC4C0", Offset = "0x1FEB4C0", VA = "0x181FEC4C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC780", Offset = "0x1FEB780", VA = "0x181FEC780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEEA50", Offset = "0x1FEDA50", VA = "0x181FEEA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEE990", Offset = "0x1FED990", VA = "0x181FEE990")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEEAB0", Offset = "0x1FEDAB0", VA = "0x181FEEAB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x1FEEBB0", Offset = "0x1FEDBB0", VA = "0x181FEEBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE950", Offset = "0x1FED950", VA = "0x181FEE950")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE8E0", Offset = "0x1FED8E0", VA = "0x181FEE8E0")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData(TypeParameterReferenceTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE630", Offset = "0x1FED630", VA = "0x181FEE630", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE6C0", Offset = "0x1FED6C0", VA = "0x181FEE6C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC40", Offset = "0x9B9C40", VA = "0x1809BAC40", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterReferenceTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD70", Offset = "0x9B9D70", VA = "0x1809BAD70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE7C0", Offset = "0x1FED7C0", VA = "0x181FEE7C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB040", Offset = "0x9BA040", VA = "0x1809BB040", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE570", Offset = "0x1FED570", VA = "0x181FEE570", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE750", Offset = "0x1FED750", VA = "0x181FEE750", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEF210", Offset = "0x1FEE210", VA = "0x181FEF210")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEF150", Offset = "0x1FEE150", VA = "0x181FEF150")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FEF270", Offset = "0x1FEE270", VA = "0x181FEF270", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39D560", Offset = "0x39C560", VA = "0x18039D560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x40B2F0", Offset = "0x40A2F0", VA = "0x18040B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x1FEF370", Offset = "0x1FEE370", VA = "0x181FEF370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public CircuitTypeData Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF110", Offset = "0x1FEE110", VA = "0x181FEF110")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF080", Offset = "0x1FEE080", VA = "0x181FEF080")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData(TypeParameterTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1FEECF0", Offset = "0x1FEDCF0", VA = "0x181FEECF0", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEDB0", Offset = "0x1FEDDB0", VA = "0x181FEEDB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x1646220", Offset = "0x1645220", VA = "0x181646220", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1646350", Offset = "0x1645350", VA = "0x181646350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEF60", Offset = "0x1FEDF60", VA = "0x181FEEF60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1646530", Offset = "0x1645530", VA = "0x181646530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEC00", Offset = "0x1FEDC00", VA = "0x181FEEC00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEE70", Offset = "0x1FEDE70", VA = "0x181FEEE70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x15593C0", Offset = "0x15583C0", VA = "0x1815593C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1558D90", Offset = "0x1557D90", VA = "0x181558D90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1559BA0", Offset = "0x1558BA0", VA = "0x181559BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1559AE0", Offset = "0x1558AE0", VA = "0x181559AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1559C00", Offset = "0x1558C00", VA = "0x181559C00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C1FE0", Offset = "0x3C0FE0", VA = "0x1803C1FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x3C2310", Offset = "0x3C1310", VA = "0x1803C2310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[DebuggerNonUserCode]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x1559D00", Offset = "0x1558D00", VA = "0x181559D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[DebuggerNonUserCode]
		public CircuitTypeData SymbolType
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x4084C0", Offset = "0x4074C0", VA = "0x1804084C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1559A10", Offset = "0x1558A10", VA = "0x181559A10")]
		[DebuggerNonUserCode]
		public VariableNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1559A50", Offset = "0x1558A50", VA = "0x181559A50")]
		[DebuggerNonUserCode]
		public VariableNodeData(VariableNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x15594E0", Offset = "0x15584E0", VA = "0x1815594E0", Slot = "9")]
		[DebuggerNonUserCode]
		public VariableNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x15595A0", Offset = "0x15585A0", VA = "0x1815595A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1559660", Offset = "0x1558660", VA = "0x181559660", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(VariableNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x15596D0", Offset = "0x15586D0", VA = "0x1815596D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1559850", Offset = "0x1558850", VA = "0x181559850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x15598B0", Offset = "0x15588B0", VA = "0x1815598B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1559420", Offset = "0x1558420", VA = "0x181559420", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1559760", Offset = "0x1558760", VA = "0x181559760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x15500D0", Offset = "0x154F0D0", VA = "0x1815500D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xCABAB0", Offset = "0xCAAAB0", VA = "0x180CABAB0")]
		public static TNode CreateNode<TNode>(CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId) where TNode : Node
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x1543F40", Offset = "0x1542F40", VA = "0x181543F40")]
		internal static Node CreateNodeForDeserialize(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x1544000", Offset = "0x1543000", VA = "0x181544000")]
		public static Node CreateNode(Type nodeType, CircuitContext context, [Optional] Guid? nodeGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x15442C0", Offset = "0x15432C0", VA = "0x1815442C0")]
		public static Node CreateNode(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId, [Optional] Vector3? localPosition, [Optional] Quaternion? localRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x1543C60", Offset = "0x1542C60", VA = "0x181543C60")]
		private static Node ConstructNodeInternal(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x1544DF0", Offset = "0x1543DF0", VA = "0x181544DF0")]
		public static Guid GetTypeId(Type type)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x1544710", Offset = "0x1543710", VA = "0x181544710")]
		public static Type GetNodeType(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x1544450", Offset = "0x1543450", VA = "0x181544450")]
		public static Tuple<string, Guid>[] GetNodeTypeOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x1544EE0", Offset = "0x1543EE0", VA = "0x181544EE0")]
		public static List<string> OrderedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x1544810", Offset = "0x1543810", VA = "0x181544810")]
		public static void GetNodesWithTags(TagSearchMethod tagSearchMethod, IEnumerable<string> activeTags, out HashSet<Type> filteredTypes, out IList<string> filteredTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x1545130", Offset = "0x1544130", VA = "0x181545130")]
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
		[Cpp2IlInjected.Address(RVA = "0x23AE1D0", Offset = "0x23AD1D0", VA = "0x1823AE1D0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x37F230", Offset = "0x37E230", VA = "0x18037F230")]
		public void Set(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x23AE1E0", Offset = "0x23AD1E0", VA = "0x1823AE1E0")]
		public Box(in T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x11E7430", Offset = "0x11E6430", VA = "0x1811E7430")]
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
		[Cpp2IlInjected.Address(RVA = "0x23BA6B0", Offset = "0x23B96B0", VA = "0x1823BA6B0")]
		public bool TryGetValue(TKey key, out HashSet<TVal> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x23BA3D0", Offset = "0x23B93D0", VA = "0x1823BA3D0")]
		public void Add(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x23BA4E0", Offset = "0x23B94E0", VA = "0x1823BA4E0")]
		public void Remove(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x23BA4B0", Offset = "0x23B94B0", VA = "0x1823BA4B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x23BA6F0", Offset = "0x23B96F0", VA = "0x1823BA6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA5AE0", Offset = "0xEA4AE0", VA = "0x180EA5AE0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public TVal this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x23BAD50", Offset = "0x23B9D50", VA = "0x1823BAD50", Slot = "18")]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x23BAD90", Offset = "0x23B9D90", VA = "0x1823BAD90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x23BACC0", Offset = "0x23B9CC0", VA = "0x1823BACC0")]
		public SortedList(Func<TVal, TVal, int> valueComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x23BAAC0", Offset = "0x23B9AC0", VA = "0x1823BAAC0", Slot = "16")]
		public IEnumerator<TVal> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x23BAC20", Offset = "0x23B9C20", VA = "0x1823BAC20", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x23BA770", Offset = "0x23B9770", VA = "0x1823BA770", Slot = "11")]
		public void Add(TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x23BA4B0", Offset = "0x23B94B0", VA = "0x1823BA4B0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x23BA9D0", Offset = "0x23B99D0", VA = "0x1823BA9D0", Slot = "13")]
		public bool Contains(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x23BAA10", Offset = "0x23B9A10", VA = "0x1823BAA10", Slot = "14")]
		public void CopyTo(TVal[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x23BABE0", Offset = "0x23B9BE0", VA = "0x1823BABE0", Slot = "15")]
		public bool Remove(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x11C3540", Offset = "0x11C2540", VA = "0x1811C3540", Slot = "6")]
		public int IndexOf(TVal item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x23BAB90", Offset = "0x23B9B90", VA = "0x1823BAB90", Slot = "7")]
		public void Insert(int index, TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x1102D60", Offset = "0x1101D60", VA = "0x181102D60", Slot = "8")]
		public void RemoveAt(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EditableValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x49C440", Offset = "0x49B440", VA = "0x18049C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x6083E0", Offset = "0x6073E0", VA = "0x1806083E0")]
		public EditableAddNamedPort([Optional] string filterMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecOutput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x49C440", Offset = "0x49B440", VA = "0x18049C440")]
		public EditableAddExecOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecInput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x49C440", Offset = "0x49B440", VA = "0x18049C440")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CB3180", Offset = "0x2CB2180", VA = "0x182CB3180")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F7A60", Offset = "0x14F6A60", VA = "0x1814F7A60")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, [Optional] TVal defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x14F7870", Offset = "0x14F6870", VA = "0x1814F7870")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, Func<TVal> defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C810", Offset = "0x1D1B810", VA = "0x181D1C810")]
		public static void AddToNestedList<K, V>(this IDictionary<K, List<V>> self, K key, V value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C550", Offset = "0x1D1B550", VA = "0x181D1C550")]
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
			[Cpp2IlInjected.Address(RVA = "0x23AE220", Offset = "0x23AD220", VA = "0x1823AE220", Slot = "4")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2212AE0", Offset = "0x2211AE0", VA = "0x182212AE0", Slot = "5")]
			public int GetHashCode(T obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x11C09E0", Offset = "0x11BF9E0", VA = "0x1811C09E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xEA9590", Offset = "0xEA8590", VA = "0x180EA9590")]
			[DebuggerHidden]
			public <Extend>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x23BB1C0", Offset = "0x23BA1C0", VA = "0x1823BB1C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x23BAE30", Offset = "0x23B9E30", VA = "0x1823BAE30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x23BB290", Offset = "0x23BA290", VA = "0x1823BB290")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x23BB2E0", Offset = "0x23BA2E0", VA = "0x1823BB2E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x23BB170", Offset = "0x23BA170", VA = "0x1823BB170", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x23BB0C0", Offset = "0x23BA0C0", VA = "0x1823BB0C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x1A7E7B0", Offset = "0x1A7D7B0", VA = "0x181A7E7B0", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x7F3F0", Offset = "0x7E7F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4A4A90", Offset = "0x4A3A90", VA = "0x1804A4A90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x23BBB70", Offset = "0x23BAB70", VA = "0x1823BBB70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x236C2F0", Offset = "0x236B2F0", VA = "0x18236C2F0")]
			[DebuggerHidden]
			public <MarkLast>d__18(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x23BC0D0", Offset = "0x23BB0D0", VA = "0x1823BC0D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x23BBDC0", Offset = "0x23BADC0", VA = "0x1823BBDC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x23BC160", Offset = "0x23BB160", VA = "0x1823BC160")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x23BC080", Offset = "0x23BB080", VA = "0x1823BC080", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x23BB9E0", Offset = "0x23BA9E0", VA = "0x1823BB9E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, bool)> System.Collections.Generic.IEnumerable<(TValue,System.BooleanIsLast)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x1150B90", Offset = "0x114FB90", VA = "0x181150B90", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x80250", Offset = "0x7F650")]
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
				[Cpp2IlInjected.Address(RVA = "0x4A4A90", Offset = "0x4A3A90", VA = "0x1804A4A90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x23BBB70", Offset = "0x23BAB70", VA = "0x1823BBB70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x236C2F0", Offset = "0x236B2F0", VA = "0x18236C2F0")]
			[DebuggerHidden]
			public <FormCurrentNextPairs>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x23BBC50", Offset = "0x23BAC50", VA = "0x1823BBC50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x23BB330", Offset = "0x23BA330", VA = "0x1823BB330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x23BBCE0", Offset = "0x23BACE0", VA = "0x1823BBCE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x23BBAD0", Offset = "0x23BAAD0", VA = "0x1823BBAD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x23BB9E0", Offset = "0x23BA9E0", VA = "0x1823BB9E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, T)> System.Collections.Generic.IEnumerable<(TCurrent,TNext)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x1150B90", Offset = "0x114FB90", VA = "0x181150B90", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xEA9590", Offset = "0xEA8590", VA = "0x180EA9590")]
			[DebuggerHidden]
			public <Unique>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x23BEC20", Offset = "0x23BDC20", VA = "0x1823BEC20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x23BE560", Offset = "0x23BD560", VA = "0x1823BE560", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x23BEDE0", Offset = "0x23BDDE0", VA = "0x1823BEDE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x23BEA00", Offset = "0x23BDA00", VA = "0x1823BEA00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x23BE940", Offset = "0x23BD940", VA = "0x1823BE940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2330290", Offset = "0x232F290", VA = "0x182330290", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x14F8780", Offset = "0x14F7780", VA = "0x1814F8780")]
		public static U AmountSwitch<U, T>(this IEnumerable<T> self, Func<U> zero, Func<T, U> one, Func<IEnumerable<T>, U> many)
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB31E0", Offset = "0x2CB21E0", VA = "0x182CB31E0")]
		public static void CallAll(this IEnumerable<Action> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x11E7230", Offset = "0x11E6230", VA = "0x1811E7230")]
		public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] items)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1367FB0", Offset = "0x1366FB0", VA = "0x181367FB0")]
		public static string Delimit<T>(this IEnumerable<T> self, string delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11E7490", Offset = "0x11E6490", VA = "0x1811E7490")]
		public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> self, Func<T, U> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE818B0", Offset = "0xE808B0", VA = "0x180E818B0")]
		[IteratorStateMachine(typeof(<Extend>d__8<, >))]
		public static IEnumerable<T> Extend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x1312E50", Offset = "0x1311E50", VA = "0x181312E50")]
		public static int FirstIndexOf<T>(this IEnumerable<T> self, Func<T, bool> pred)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x116F570", Offset = "0x116E570", VA = "0x18116F570")]
		public static T FirstOr<T>(this IEnumerable<T> self, T optB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D400", Offset = "0x1D1C400", VA = "0x181D1D400")]
		public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x1313100", Offset = "0x1312100", VA = "0x181313100")]
		public static int SequenceGetHashCode<T>(this IEnumerable<T> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1A9C860", Offset = "0x1A9B860", VA = "0x181A9C860")]
		public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x1A9C710", Offset = "0x1A9B710", VA = "0x181A9C710")]
		public static bool Multiple<T>(this IEnumerable<T> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x11E7230", Offset = "0x11E6230", VA = "0x1811E7230")]
		public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE6C190", Offset = "0xE6B190", VA = "0x180E6C190")]
		[IteratorStateMachine(typeof(<MarkLast>d__18<>))]
		public static IEnumerable<(T, bool)> MarkLast<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE6C190", Offset = "0xE6B190", VA = "0x180E6C190")]
		[IteratorStateMachine(typeof(<FormCurrentNextPairs>d__19<>))]
		public static IEnumerable<(T, T)> FormCurrentNextPairs<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x11E75E0", Offset = "0x11E65E0", VA = "0x1811E75E0")]
		public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x11E7610", Offset = "0x11E6610", VA = "0x1811E7610")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x11E7610", Offset = "0x11E6610", VA = "0x1811E7610")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x7B1D0", Offset = "0x7A5D0")] this IEnumerable<(TKey, TValue)> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x11E7430", Offset = "0x11E6430", VA = "0x1811E7430")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA41470", Offset = "0xA40470", VA = "0x180A41470")]
		[IteratorStateMachine(typeof(<Unique>d__25<, >))]
		public static IEnumerable<T> Unique<T, U>(this IEnumerable<T> self, Func<T, U> uniqueSelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x11E07F0", Offset = "0x11DF7F0", VA = "0x1811E07F0")]
		public static IEnumerable<(T, U)> Zip<T, U>(this IEnumerable<T> self, IEnumerable<U> other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA41620", Offset = "0xA40620", VA = "0x180A41620")]
		public static IEnumerable<V> ZipExtend<V, T, U>(this IEnumerable<T> self, IEnumerable<U> other, Func<T, U, V> zipper, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x11E7950", Offset = "0x11E6950", VA = "0x1811E7950")]
		public static IEnumerable<(T, U)> ZipExtend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class EquatableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x1A9C9E0", Offset = "0x1A9B9E0", VA = "0x181A9C9E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xEA9590", Offset = "0xEA8590", VA = "0x180EA9590")]
			[DebuggerHidden]
			public <ToEnumerable>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x11CF7E0", Offset = "0x11CE7E0", VA = "0x1811CF7E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x23BCC10", Offset = "0x23BBC10", VA = "0x1823BCC10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x11CF810", Offset = "0x11CE810", VA = "0x1811CF810", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x1152080", Offset = "0x1151080", VA = "0x181152080", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CD390", Offset = "0x3CC390", VA = "0x1803CD390", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x23BCBA0", Offset = "0x23BBBA0", VA = "0x1823BCBA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x236C330", Offset = "0x236B330", VA = "0x18236C330")]
			[DebuggerHidden]
			public <ToEnumerableInf>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x23BCA20", Offset = "0x23BBA20", VA = "0x1823BCA20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x23BCB00", Offset = "0x23BBB00", VA = "0x1823BCB00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x23BCA60", Offset = "0x23BBA60", VA = "0x1823BCA60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x1152080", Offset = "0x1151080", VA = "0x181152080", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x11EF830", Offset = "0x11EE830", VA = "0x1811EF830")]
		[IteratorStateMachine(typeof(<ToEnumerable>d__0<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x11EF7C0", Offset = "0x11EE7C0", VA = "0x1811EF7C0")]
		[IteratorStateMachine(typeof(<ToEnumerableInf>d__1<>))]
		public static IEnumerable<T> ToEnumerableInf<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x1502520", Offset = "0x1501520", VA = "0x181502520")]
		public static T[] ToOneItemArray<T>(this T self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public static class IListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x1172A90", Offset = "0x1171A90", VA = "0x181172A90")]
		public static T Last<T>(this IList<T> self)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x1172D20", Offset = "0x1171D20", VA = "0x181172D20")]
		public static T SetLast<T>(this IList<T> self, T value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x1D21D60", Offset = "0x1D20D60", VA = "0x181D21D60")]
		public static void RemoveFirstWhere<T>(this IList<T> self, Func<T, bool> pred)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x1D21DD0", Offset = "0x1D20DD0", VA = "0x181D21DD0")]
		public static void RemoveLast<T>(this IList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x1172ED0", Offset = "0x1171ED0", VA = "0x181172ED0")]
		public static T TakeLast<T>(this IList<T> self)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public static class IReadOnlyCollectionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x1A9D910", Offset = "0x1A9C910", VA = "0x181A9D910")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public static class IReadOnlyDictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7960", Offset = "0x2CE6960", VA = "0x182CE7960")]
		public static V GetValueOrDefault<V, K>(this IReadOnlyDictionary<K, V> self, K key)
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x136B5B0", Offset = "0x136A5B0", VA = "0x18136B5B0")]
		public static V? GetValueOrNull<V, K>(this IReadOnlyDictionary<K, V> self, K key) where V : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class IReadOnlyListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x1172F20", Offset = "0x1171F20", VA = "0x181172F20")]
		public static T GetValueOrDefault<T>(this IReadOnlyList<T> self, int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x136B6D0", Offset = "0x136A6D0", VA = "0x18136B6D0")]
		public static T? GetValueOrNull<T>(this IReadOnlyList<T> self, int index) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public static class KeyValuePairExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x136B820", Offset = "0x136A820", VA = "0x18136B820")]
		public static (TKey, TValue) Destructure<TKey, TValue>(this KeyValuePair<TKey, TValue> self)
		{
			return default((TKey, TValue));
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x11E7230", Offset = "0x11E6230", VA = "0x1811E7230")]
		public static IEnumerable<(TKey, TValue)> Destructure<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x13AF760", Offset = "0x13AE760", VA = "0x1813AF760")]
		public static KeyValuePair<TKey, UValue> Revalue<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> self, UValue value)
		{
			return default(KeyValuePair<TKey, UValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public static class MapFieldExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x1D256F0", Offset = "0x1D246F0", VA = "0x181D256F0")]
		public static void AddRange<K, V>(this MapField<K, V> self, IEnumerable<KeyValuePair<K, V>> values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3AA0", Offset = "0x2CB2AA0", VA = "0x182CB3AA0")]
		private static byte[] GetIntBytes(int intValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3470", Offset = "0x2CB2470", VA = "0x182CB3470")]
		public static Guid Combine(params Guid[] guidsToCombine)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CB39D0", Offset = "0x2CB29D0", VA = "0x182CB39D0")]
		public static Guid Create(Guid namespaceId, int index, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CB35E0", Offset = "0x2CB25E0", VA = "0x182CB35E0")]
		public static Guid Create(Guid namespaceId, Guid nameGuid, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3940", Offset = "0x2CB2940", VA = "0x182CB3940")]
		public static Guid Create(Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3650", Offset = "0x2CB2650", VA = "0x182CB3650")]
		private static Guid Create(Guid namespaceId, byte[] nameBytes, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3B20", Offset = "0x2CB2B20", VA = "0x182CB3B20")]
		private static void SwapByteOrder(byte[] guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3CB0", Offset = "0x2CB2CB0", VA = "0x182CB3CB0")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[AttributeUsage(AttributeTargets.Class)]
	public class InternalNodeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x49C440", Offset = "0x49B440", VA = "0x18049C440")]
		public InternalNodeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public static class NodeNameHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3D30", Offset = "0x2CB2D30", VA = "0x182CB3D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x145BC0", Offset = "0x144FC0", VA = "0x180145BC0")]
		public PerfScope(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x145BC0", Offset = "0x144FC0", VA = "0x180145BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CB4880", Offset = "0x2CB3880", VA = "0x182CB4880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4740", Offset = "0x2CB3740", VA = "0x182CB4740")]
		public RateLimiter(ITimeProvider timeProvider, int maxPerSecond, int initialSize = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4470", Offset = "0x2CB3470", VA = "0x182CB4470")]
		public bool CanExecute()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CB44D0", Offset = "0x2CB34D0", VA = "0x182CB44D0")]
		public bool ExecuteIfPossible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CB45A0", Offset = "0x2CB35A0", VA = "0x182CB45A0")]
		public void MarkExecution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4610", Offset = "0x2CB3610", VA = "0x182CB4610")]
		private void TrimExpiredValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x42D6D0", Offset = "0x42C6D0", VA = "0x18042D6D0")]
		public static T[] NewArray<T>(params T[] @params)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x13BC4B0", Offset = "0x13BB4B0", VA = "0x1813BC4B0")]
		public static KeyValuePair<TKey, TValue> NewKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x1AA8B00", Offset = "0x1AA7B00", VA = "0x181AA8B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB5420", Offset = "0x2CB4420", VA = "0x182CB5420")]
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
		[Cpp2IlInjected.Address(RVA = "0x49C440", Offset = "0x49B440", VA = "0x18049C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x1645310", Offset = "0x1644310", VA = "0x181645310")]
		public CircuitDataIdRemapper(bool remapIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x1645280", Offset = "0x1644280", VA = "0x181645280")]
		public CircuitDataIdRemapper(bool remapIds, Guid remapId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x1645040", Offset = "0x1644040", VA = "0x181645040")]
		public ByteString RemapByteStringId(ByteString originalByteString, bool onlyIfAlreadyMapped = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class CircuitTemplateHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x164EA60", Offset = "0x164DA60", VA = "0x18164EA60")]
		public static CircuitContextData RemapTemplate(CircuitContext intoContext, CircuitContextData originalTemplate, Guid remapId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x164ED30", Offset = "0x164DD30", VA = "0x18164ED30")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x164EDD0", Offset = "0x164DDD0", VA = "0x18164EDD0")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData, Matrix4x4 transformMatrix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x164D0B0", Offset = "0x164C0B0", VA = "0x18164D0B0")]
		public static void AddInventionTracking(CircuitContextData templateData, ByteString instanceIdAsByteString, long inventionId, int versionNum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x164E450", Offset = "0x164D450", VA = "0x18164E450")]
		public static void RemapTemplateIds(CircuitContext intoContext, CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x164E050", Offset = "0x164D050", VA = "0x18164E050")]
		private static void RemapNodeInnerContextIdsRecursive(CircuitDataIdRemapper remapper, CircuitContextData context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x164D540", Offset = "0x164C540", VA = "0x18164D540")]
		private static void RemapContextIdsRecursive(CircuitDataIdRemapper remapper, RepeatedField<CircuitContextData> contexts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x164DA40", Offset = "0x164CA40", VA = "0x18164DA40")]
		private static void RemapInventionInstanceIds(CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x164DE90", Offset = "0x164CE90", VA = "0x18164DE90")]
		private static void RemapNodeDataEventIds(IEnumerable<CircuitNodeData> nodeDatas, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x164D7B0", Offset = "0x164C7B0", VA = "0x18164D7B0")]
		private static void RemapEventRegistrationList(IList<EventRegistrationData> registrationList, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x164EB80", Offset = "0x164DB80", VA = "0x18164EB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x13E2330", Offset = "0x13E1330", VA = "0x1813E2330")]
		public static Create<TCircuitObject, TProtoElement> DoNotCreate<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x13E2330", Offset = "0x13E1330", VA = "0x1813E2330")]
		public static Dispose<TCircuitObject, TProtoElement> IDisposableDispose<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x1370920", Offset = "0x136F920", VA = "0x181370920")]
		public static void MergeDisposablesProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x13709A0", Offset = "0x136F9A0", VA = "0x1813709A0")]
		public static void MergeProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, Dispose<TCircuitObject, TProtoElement> dispose, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x1370590", Offset = "0x136F590", VA = "0x181370590")]
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
			[Cpp2IlInjected.Address(RVA = "0x11C0240", Offset = "0x11BF240", VA = "0x1811C0240")]
			public Binder(Dependencies dependencies)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x13D67F0", Offset = "0x13D57F0", VA = "0x1813D67F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x152230", Offset = "0x151630", VA = "0x180152230")]
			public InjectionKey(Type injectedResourceType, string injectedResourceName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x1ECB00", Offset = "0x1EBF00", VA = "0x1801ECB00")]
			public bool Equals(InjectionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x1ECA40", Offset = "0x1EBE40", VA = "0x1801ECA40", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x1ECB70", Offset = "0x1EBF70", VA = "0x1801ECB70", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly Dictionary<InjectionKey, object> injectedInstancesDictionary;

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x11E7430", Offset = "0x11E6430", VA = "0x1811E7430")]
		public Binder<TInterface> Bind<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xCAC3B0", Offset = "0xCAB3B0", VA = "0x180CAC3B0")]
		public TInterface GetDependency<TInterface>([Optional] string name)
		{
			return (TInterface)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x1650C90", Offset = "0x164FC90", VA = "0x181650C90")]
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
				[Cpp2IlInjected.Address(RVA = "0x3C1FE0", Offset = "0x3C0FE0", VA = "0x1803C1FE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000842")]
				[Cpp2IlInjected.Address(RVA = "0x3C2310", Offset = "0x3C1310", VA = "0x1803C2310")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000843")]
				[Cpp2IlInjected.Address(RVA = "0x77CDA0", Offset = "0x77BDA0", VA = "0x18077CDA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x1AD0DF0", Offset = "0x1ACFDF0", VA = "0x181AD0DF0")]
			protected MemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x1AD0D80", Offset = "0x1ACFD80", VA = "0x181AD0D80", Slot = "6")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void DisposeInternal();

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x1AD0BC0", Offset = "0x1ACFBC0", VA = "0x181AD0BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AD7A30", Offset = "0x1AD6A30", VA = "0x181AD7A30")]
			public SymbolMemoryHandle(Memory memory, Guid address, string symbol, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x1AD7740", Offset = "0x1AD6740", VA = "0x181AD7740", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x1AD7910", Offset = "0x1AD6910", VA = "0x181AD7910", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private class UnnamedMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB1F0", Offset = "0x1ADA1F0", VA = "0x181ADB1F0")]
			public UnnamedMemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x1ADADD0", Offset = "0x1AD9DD0", VA = "0x181ADADD0", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x1ADAFB0", Offset = "0x1AD9FB0", VA = "0x181ADAFB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x12CD0E0", Offset = "0x12CC0E0", VA = "0x1812CD0E0")]
		public Memory(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x12CC070", Offset = "0x12CB070", VA = "0x1812CC070")]
		private void OnGuidsRemapped(IReadOnlyDictionary<Guid, ShortenedGuidMap.GuidRemapping> remappedguids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x136E6B0", Offset = "0x136D6B0", VA = "0x18136E6B0")]
		private void RemapDictionary<T>(Dictionary<Guid, RateLimitedSynchronizedField<T>> synchronizedFieldDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x12CC440", Offset = "0x12CB440", VA = "0x1812CC440")]
		private void OnHandleReleased(IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x12CC120", Offset = "0x12CB120", VA = "0x1812CC120")]
		private void OnHandleReleased(string symbol, IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x13DD640", Offset = "0x13DC640", VA = "0x1813DD640")]
		public IMemoryHandle AllocateNamedVariable<T>(string symbol, Guid defaultAddress, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x13DE920", Offset = "0x13DD920", VA = "0x1813DE920")]
		public IMemoryHandle AllocateUnnamedVariable<T>(Guid address, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x1314870", Offset = "0x1313870", VA = "0x181314870")]
		private Guid InitializeLocal<T>(Guid address, Dictionary<Guid, T> dictionary, T value)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x13149F0", Offset = "0x13139F0", VA = "0x1813149F0")]
		private Guid InitializeSynchronized<T>(Guid address, Dictionary<Guid, RateLimitedSynchronizedField<T>> dictionary, T initialValue)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x136E650", Offset = "0x136D650", VA = "0x18136E650")]
		private void DeallocateSynchronized<T>(Guid address, RateLimitedSynchronizedField<T> field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x1A9E1B0", Offset = "0x1A9D1B0", VA = "0x181A9E1B0")]
		private bool AllocateOrReference<T>(Guid defaultAddress, CircuitType valueType, Dictionary<Guid, T> typeMemory, out IMemoryHandle handle, [Optional] string variableName, [Optional] Action<Guid, T> customDispose)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x13DDC00", Offset = "0x13DCC00", VA = "0x1813DDC00")]
		private IMemoryHandle AllocateOrReferenceLocal<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, T> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x13DE210", Offset = "0x13DD210", VA = "0x1813DE210")]
		private IMemoryHandle AllocateOrReferenceSynchronized<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, RateLimitedSynchronizedField<T>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4A0", Offset = "0x12CA4A0", VA = "0x1812CB4A0")]
		public IMemoryHandle AllocateBoolean(Guid defaultAddress, bool value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x12CB550", Offset = "0x12CA550", VA = "0x1812CB550")]
		public IMemoryHandle AllocateInt32(Guid defaultAddress, int value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x12CB6B0", Offset = "0x12CA6B0", VA = "0x1812CB6B0")]
		public IMemoryHandle AllocateSingle(Guid defaultAddress, float value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x12CB760", Offset = "0x12CA760", VA = "0x1812CB760")]
		public IMemoryHandle AllocateString(Guid defaultAddress, string value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x12CB600", Offset = "0x12CA600", VA = "0x1812CB600")]
		public IMemoryHandle AllocateOrReferenceSynchronizedBoolean(Guid defaultAddress, bool initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x12CB810", Offset = "0x12CA810", VA = "0x1812CB810")]
		public IMemoryHandle AllocateSynchronizedInt32(Guid defaultAddress, int initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x12CB8C0", Offset = "0x12CA8C0", VA = "0x1812CB8C0")]
		public IMemoryHandle AllocateSynchronizedSingle(Guid defaultAddress, float initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x12CB970", Offset = "0x12CA970", VA = "0x1812CB970")]
		public IMemoryHandle AllocateSynchronizedString(Guid defaultAddress, string initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x12CBCF0", Offset = "0x12CACF0", VA = "0x1812CBCF0")]
		public bool GetBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x12CBD50", Offset = "0x12CAD50", VA = "0x1812CBD50")]
		public int GetInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x12CBDB0", Offset = "0x12CADB0", VA = "0x1812CBDB0")]
		public float GetSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x12CBE10", Offset = "0x12CAE10", VA = "0x1812CBE10")]
		public string GetString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x12CBE70", Offset = "0x12CAE70", VA = "0x1812CBE70")]
		public bool GetSynchronizedBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x12CBEF0", Offset = "0x12CAEF0", VA = "0x1812CBEF0")]
		public int GetSynchronizedInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x12CBF70", Offset = "0x12CAF70", VA = "0x1812CBF70")]
		public float GetSynchronizedSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x12CBFF0", Offset = "0x12CAFF0", VA = "0x1812CBFF0")]
		public string GetSynchronizedString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x1A9EFB0", Offset = "0x1A9DFB0", VA = "0x181A9EFB0")]
		private bool SetValue<T>(Guid id, T value, Dictionary<Guid, T> values) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x12CCAE0", Offset = "0x12CBAE0", VA = "0x1812CCAE0")]
		public bool SetBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x12CCB50", Offset = "0x12CBB50", VA = "0x1812CCB50")]
		public bool SetInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x12CCBC0", Offset = "0x12CBBC0", VA = "0x1812CCBC0")]
		public bool SetSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x12CCC30", Offset = "0x12CBC30", VA = "0x1812CCC30")]
		public bool SetString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x12CCCE0", Offset = "0x12CBCE0", VA = "0x1812CCCE0")]
		public bool SetSynchronizedBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x12CCD70", Offset = "0x12CBD70", VA = "0x1812CCD70")]
		public bool SetSynchronizedInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x12CCDF0", Offset = "0x12CBDF0", VA = "0x1812CCDF0")]
		public bool SetSynchronizedSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x12CCE80", Offset = "0x12CBE80", VA = "0x1812CCE80")]
		public bool SetSynchronizedString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x12CC770", Offset = "0x12CB770", VA = "0x1812CC770")]
		public void RegisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x12CD060", Offset = "0x12CC060", VA = "0x1812CD060")]
		public void UnregisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x12CC550", Offset = "0x12CB550", VA = "0x1812CC550")]
		private void OnValueChanged(RateLimiter rateLimiter, Guid address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x12CCF40", Offset = "0x12CBF40", VA = "0x1812CCF40")]
		private static string Truncate(string originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x12CCF90", Offset = "0x12CBF90", VA = "0x1812CCF90")]
		public bool TryGetNamedVariable(string varName, out Guid variableAddress, out CircuitType variableType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x12CC7F0", Offset = "0x12CB7F0", VA = "0x1812CC7F0")]
		public void RemapNamedVariables(CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x12CBA20", Offset = "0x12CAA20", VA = "0x1812CBA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x149630", Offset = "0x148A30", VA = "0x180149630")]
			public TypeConversionKey(TypeKind fromKind, TypeKind toKind)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x180080", Offset = "0x17F480", VA = "0x180180080")]
			public bool Equals(TypeConversionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x1800A0", Offset = "0x17F4A0", VA = "0x1801800A0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x180130", Offset = "0x17F530", VA = "0x180180130", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x12CDFA0", Offset = "0x12CCFA0", VA = "0x1812CDFA0")]
		public static bool IsConvertableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x12CDD50", Offset = "0x12CCD50", VA = "0x1812CDD50")]
		public static Func<Node, Node, (Node, ITypeConversionNode)> GetConverterConstructor(CircuitType from, CircuitType to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x12CE280", Offset = "0x12CD280", VA = "0x1812CE280")]
		public static bool SupportsDefaultValue(CircuitType signalType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x12CE040", Offset = "0x12CD040", VA = "0x1812CE040")]
		public static void RegisterFriendlyName(Guid name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x12CDE50", Offset = "0x12CCE50", VA = "0x1812CDE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x12CFDD0", Offset = "0x12CEDD0", VA = "0x1812CFDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x12CEA40", Offset = "0x12CDA40", VA = "0x1812CEA40", Slot = "4")]
		public bool AllowsMultipleInputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x12CEA60", Offset = "0x12CDA60", VA = "0x1812CEA60", Slot = "5")]
		public bool AllowsMultipleOutputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x12CF180", Offset = "0x12CE180", VA = "0x1812CF180", Slot = "6")]
		public bool IsAssignableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x12CEBE0", Offset = "0x12CDBE0", VA = "0x1812CEBE0")]
		private bool IsAssignableToInternal(CircuitType from, CircuitType to, IReadOnlyList<CircuitType> fromTypeParameterAssignments, IReadOnlyList<CircuitType> toTypeParameterAssignments)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x12CF210", Offset = "0x12CE210", VA = "0x1812CF210", Slot = "7")]
		public CircuitType Narrow(CircuitType typeA, CircuitType typeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x12CEA80", Offset = "0x12CDA80", VA = "0x1812CEA80")]
		private static (CircuitType, IReadOnlyList<CircuitType>, bool) ExtractTypeSpecifics(CircuitType type, IReadOnlyList<CircuitType> lastAssignments)
		{
			return default((CircuitType, IReadOnlyList<CircuitType>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
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
	public abstract class CircuitObject : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[Guid("3632DCA5-8DBA-4F6C-BF41-DD4609868843")]
		private class TransformModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x12CDC60", Offset = "0x12CCC60", VA = "0x1812CDC60")]
			public TransformModificationHandler(CircuitObject modifiedObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x12CD8C0", Offset = "0x12CC8C0", VA = "0x1812CD8C0")]
			public ICircuitObjectModification CreateModification(Vector3? newLocalPosition, Quaternion? newLocalRotation)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x12CD9C0", Offset = "0x12CC9C0", VA = "0x1812CD9C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38D8B0", Offset = "0x38C8B0", VA = "0x18038D8B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E18F0", Offset = "0x3E08F0", VA = "0x1803E18F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x52D1E0", Offset = "0x52C1E0", VA = "0x18052D1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool CanSetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x12C1410", Offset = "0x12C0410", VA = "0x1812C1410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x12C13C0", Offset = "0x12C03C0", VA = "0x1812C13C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action OnDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x12C1280", Offset = "0x12C0280", VA = "0x1812C1280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0x12C1460", Offset = "0x12C0460", VA = "0x1812C1460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x12C1320", Offset = "0x12C0320", VA = "0x1812C1320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x12C1500", Offset = "0x12C0500", VA = "0x1812C1500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x12C1100", Offset = "0x12C0100", VA = "0x1812C1100")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x12C0F50", Offset = "0x12BFF50", VA = "0x1812C0F50")]
		internal void SetCanDestroy(bool canDestroy, CircuitTokenFlag.CircuitToken token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x12C0DE0", Offset = "0x12BFDE0", VA = "0x1812C0DE0")]
		public void RequestTransformChange(Vector3? newPosition, Quaternion? newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x13658A0", Offset = "0x13648A0", VA = "0x1813658A0")]
		public void RegisterModificationHandler<T>(T handler) where T : ICircuitObjectModificationHandler
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x1A9ADB0", Offset = "0x1A99DB0", VA = "0x181A9ADB0")]
		public bool TryGetModificationHandler<T>(out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x1A9AE80", Offset = "0x1A99E80", VA = "0x181A9AE80")]
		public bool TryGetModificationHandler<T>(Guid handlerId, out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x12C10A0", Offset = "0x12C00A0", VA = "0x1812C10A0")]
		public bool UnregisterModificationHandler(Guid guid)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x12C0C10", Offset = "0x12BFC10", VA = "0x1812C0C10")]
		public void HandleModificationRequest(Guid modificationHandlerId, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x12C0BC0", Offset = "0x12BFBC0", VA = "0x1812C0BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C0D20", Offset = "0x12BFD20", VA = "0x1812C0D20")]
		public bool RequestChangeName(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x557510", Offset = "0x556510", VA = "0x180557510", Slot = "8")]
		public virtual bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x905B40", Offset = "0x904B40", VA = "0x180905B40")]
		protected void RaiseOnNameChangedEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	public abstract class CircuitObject<TProto> : CircuitObject, ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC6A0", Offset = "0x1ACB6A0", VA = "0x181ACC6A0")]
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
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public struct CircuitObjectId
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public readonly Guid ContextUniqueObjectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public readonly Guid GloballyUniqueObjectId;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x17F7A0", Offset = "0x17EBA0", VA = "0x18017F7A0")]
		public CircuitObjectId(Guid contextId, Guid objectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x17F720", Offset = "0x17EB20", VA = "0x18017F720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C3A60", Offset = "0x12C2A60", VA = "0x1812C3A60")]
		protected ExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x12C3A30", Offset = "0x12C2A30", VA = "0x1812C3A30")]
		protected ExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x12C3870", Offset = "0x12C2870", VA = "0x1812C3870")]
		public NextExecutable ExecuteNode(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
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
	[Cpp2IlInjected.Token(Token = "0x200013C")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C3B30", Offset = "0x12C2B30", VA = "0x1812C3B30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x3CD390", Offset = "0x3CC390", VA = "0x1803CD390", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x3C1FE0", Offset = "0x3C0FE0", VA = "0x1803C1FE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xF5BBB0", Offset = "0xF5ABB0", VA = "0x180F5BBB0")]
		public ExecutionScope([NotNull] CircuitContext executionScopeContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x12C3A90", Offset = "0x12C2A90", VA = "0x1812C3A90", Slot = "7")]
		public bool MarkExecution()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xCC3850", Offset = "0xCC2850", VA = "0x180CC3850", Slot = "8")]
		public void MarkValueRetrieve()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
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
	[Cpp2IlInjected.Token(Token = "0x200013E")]
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
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public struct DisconnectionResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public readonly DisconnectionResultKind Kind;

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public int IndexOfDstInSrc
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x147F60", Offset = "0x147360", VA = "0x180147F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x17FFE0", Offset = "0x17F3E0", VA = "0x18017FFE0")]
		private DisconnectionResult(DisconnectionResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x17FFF0", Offset = "0x17F3F0", VA = "0x18017FFF0")]
		private DisconnectionResult(int indexOfDstInSrc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x12C2C30", Offset = "0x12C1C30", VA = "0x1812C2C30")]
		public static DisconnectionResult Ok(int indexOfDstInSrc)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x12C2C10", Offset = "0x12C1C10", VA = "0x1812C2C10")]
		public static DisconnectionResult ErrorNull()
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x12C2BF0", Offset = "0x12C1BF0", VA = "0x1812C2BF0")]
		public static DisconnectionResult ErrorNotConnected()
		{
			return default(DisconnectionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public static class GraphOp
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x12C7E30", Offset = "0x12C6E30", VA = "0x1812C7E30")]
		private static ConnectionResult CanConnect(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x12C83F0", Offset = "0x12C73F0", VA = "0x1812C83F0")]
		public static ConnectionResult ConnectByRequest(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x12C8910", Offset = "0x12C7910", VA = "0x1812C8910")]
		internal static ConnectionResult ConnectLocal(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x12C8DF0", Offset = "0x12C7DF0", VA = "0x1812C8DF0")]
		internal static void ConnectLocal(CircuitContext context, Guid srcNodeId, Guid srcPortId, Guid dstNodeId, Guid dstPortId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x12C8640", Offset = "0x12C7640", VA = "0x1812C8640")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) ConnectCore(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x12C8FB0", Offset = "0x12C7FB0", VA = "0x1812C8FB0")]
		private static bool CreatesCycle(Node srcNode, Node dstNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x12CA890", Offset = "0x12C9890", VA = "0x1812CA890")]
		private static bool IsConnected(Node srcNode, Node dstNode, OutputPort srcPort, InputPort dstPort)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x12C8380", Offset = "0x12C7380", VA = "0x1812C8380")]
		private static DisconnectionResult CanDisconnect(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x12C9FF0", Offset = "0x12C8FF0", VA = "0x1812C9FF0")]
		internal static DisconnectionResult DisconnectLocal(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x12C9A10", Offset = "0x12C8A10", VA = "0x1812C9A10")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectCore(OutputPort srcPort, InputPort dstPort, int indexOfDstInSrc)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x12CA680", Offset = "0x12C9680", VA = "0x1812CA680")]
		private static int IndexOfDstInSrc(OutputPort srcPort, InputPort dstPort)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x12C9CC0", Offset = "0x12C8CC0", VA = "0x1812C9CC0")]
		private static (IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>) DisconnectForConnect(OutputPort srcPort, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x12C8360", Offset = "0x12C7360", VA = "0x1812C8360")]
		private static bool CanDisconnectPort(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x12CA0B0", Offset = "0x12C90B0", VA = "0x1812CA0B0")]
		public static bool DisconnectPortByRequest(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x12CA610", Offset = "0x12C9610", VA = "0x1812CA610")]
		internal static bool DisconnectPortLocal(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x12CA480", Offset = "0x12C9480", VA = "0x1812CA480")]
		internal static void DisconnectPortLocal(CircuitContext context, Guid nodeId, Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x12CA2E0", Offset = "0x12C92E0", VA = "0x1812CA2E0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectPortCore(PortBase port)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x12C9760", Offset = "0x12C8760", VA = "0x1812C9760")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyPortGroupCore(IPortGroup portGroup)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x12C82E0", Offset = "0x12C72E0", VA = "0x1812C82E0")]
		private static bool CanDestroyNode(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x12C96A0", Offset = "0x12C86A0", VA = "0x1812C96A0")]
		internal static bool DestroyNodeLocal(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x12C9140", Offset = "0x12C8140", VA = "0x1812C9140")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyNodeCore(Node node)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x12CA730", Offset = "0x12C9730", VA = "0x1812CA730")]
		public static void InferAndUpdateGraph(IEnumerable<Node> nodesToInfer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
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
			[Cpp2IlInjected.Address(RVA = "0x15F4540", Offset = "0x15F3540", VA = "0x1815F4540")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		internal Dictionary<string, CircuitType> LastTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x4CC900", Offset = "0x4CB900", VA = "0x1804CC900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x4CB690", Offset = "0x4CA690", VA = "0x1804CB690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public IEnumerable<InputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x15F44F0", Offset = "0x15F34F0", VA = "0x1815F44F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public IEnumerable<InputPort> InputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0x15F43F0", Offset = "0x15F33F0", VA = "0x1815F43F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public IEnumerable<OutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x15F4710", Offset = "0x15F3710", VA = "0x1815F4710", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IEnumerable<OutputPort> OutputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x15F4610", Offset = "0x15F3610", VA = "0x1815F4610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public IEnumerable<PortGroupBase<InputPort>> InputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x15F43A0", Offset = "0x15F33A0", VA = "0x1815F43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public IEnumerable<PortGroupBase<OutputPort>> OutputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x15F45C0", Offset = "0x15F35C0", VA = "0x1815F45C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x46F690", Offset = "0x46E690", VA = "0x18046F690", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x15F4800", Offset = "0x15F3800", VA = "0x1815F4800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action OnPortsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x15F4300", Offset = "0x15F3300", VA = "0x1815F4300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x15F4760", Offset = "0x15F3760", VA = "0x1815F4760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x15F3B40", Offset = "0x15F2B40", VA = "0x1815F3B40", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x15F3180", Offset = "0x15F2180", VA = "0x1815F3180")]
		public string GetNodeName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x15F3F50", Offset = "0x15F2F50", VA = "0x1815F3F50")]
		protected Node(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x15F3270", Offset = "0x15F2270", VA = "0x1815F3270")]
		public bool RequestSetPortDefaultValue(PortBase port, CircuitSignal value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x15F3190", Offset = "0x15F2190", VA = "0x1815F3190", Slot = "16")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x15F3B90", Offset = "0x15F2B90", VA = "0x1815F3B90")]
		public void SetSpecificTypes(IEnumerable<(string, CircuitType)> genericTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x15F3EB0", Offset = "0x15F2EB0", VA = "0x1815F3EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "17")]
		protected virtual void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x15F35A0", Offset = "0x15F25A0", VA = "0x1815F35A0", Slot = "10")]
		public sealed override CircuitNodeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x15F33D0", Offset = "0x15F23D0", VA = "0x1815F33D0")]
		[CanBeNull]
		private InventionPieceData SerializeInventionPieceData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x15F2CF0", Offset = "0x15F1CF0", VA = "0x1815F2CF0", Slot = "11")]
		public sealed override void DeserializeFromProtobuf(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x15F2620", Offset = "0x15F1620", VA = "0x1815F2620")]
		public void DeserializeConnections(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "18")]
		protected virtual void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "19")]
		protected virtual void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x15F2F60", Offset = "0x15F1F60", VA = "0x1815F2F60", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x15F3050", Offset = "0x15F2050", VA = "0x1815F3050", Slot = "20")]
		protected internal virtual (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x15F3250", Offset = "0x15F2250", VA = "0x1815F3250")]
		internal void RaiseOnPortsUpdatedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x15F30C0", Offset = "0x15F20C0", VA = "0x1815F30C0", Slot = "21")]
		public virtual IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x15F2580", Offset = "0x15F1580", VA = "0x1815F2580")]
		protected static FunctionType CTypeParams(params TypeParamConstrainedOrNot[] typeParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x15F23A0", Offset = "0x15F13A0", VA = "0x1815F23A0")]
		private static InputPort BuildInputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x15F2490", Offset = "0x15F1490", VA = "0x1815F2490")]
		private static OutputPort BuildOutputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public class NodeConnection : ICheckableConnection<Node, InputPort, OutputPort, NodeConnection>, ICircuitSerializable<NodeConnectionData>
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		[NotNull]
		public Node SrcNode
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x14BE030", Offset = "0x14BD030", VA = "0x1814BE030")]
		public NodeConnection([NotNull] Node srcNode, [NotNull] OutputPort srcPort, [NotNull] Node dstNode, [NotNull] InputPort dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x15F2070", Offset = "0x15F1070", VA = "0x1815F2070")]
		protected bool Equals(NodeConnection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x15F1F70", Offset = "0x15F0F70", VA = "0x1815F1F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x15F20B0", Offset = "0x15F10B0", VA = "0x1815F20B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xDA3540", Offset = "0xDA2540", VA = "0x180DA3540")]
		public static bool operator !=(NodeConnection left, NodeConnection right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x15F2230", Offset = "0x15F1230", VA = "0x1815F2230", Slot = "9")]
		public NodeConnectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x15F1F20", Offset = "0x15F0F20", VA = "0x1815F1F20", Slot = "8")]
		public void DeserializeFromProtobuf(NodeConnectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x15F2170", Offset = "0x15F1170", VA = "0x1815F2170")]
		public bool Matches(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	public class BasicPortGroup<TPort> : PortGroupBase<TPort> where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x3C2EE0", Offset = "0x3C1EE0", VA = "0x1803C2EE0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x1AC93E0", Offset = "0x1AC83E0", VA = "0x181AC93E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC9380", Offset = "0x1AC8380", VA = "0x181AC9380")]
		public BasicPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC90E0", Offset = "0x1AC80E0", VA = "0x181AC90E0")]
		internal void AddPortLocal(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC9110", Offset = "0x1AC8110", VA = "0x181AC9110", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC9210", Offset = "0x1AC8210", VA = "0x181AC9210", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal class DynamicPortGroupModificationHandler<TPort> : NodeModificationHandlerBase where TPort : PortBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private readonly PortGroupBase<TPort> portGroup;

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0x54A550", Offset = "0x549550", VA = "0x18054A550", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCED0", Offset = "0x1ACBED0", VA = "0x181ACCED0")]
		public DynamicPortGroupModificationHandler(Node node, PortGroupBase<TPort> portGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCA90", Offset = "0x1ACBA90", VA = "0x181ACCA90")]
		public ICircuitObjectModification CreateAddModification(Guid portId, string portName, CircuitType portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCC30", Offset = "0x1ACBC30", VA = "0x181ACCC30")]
		public ICircuitObjectModification CreateRemoveModification(Guid portId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCD80", Offset = "0x1ACBD80", VA = "0x181ACCD80", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public class ExecNameBasedPortGroup<TPort> : NameBasedPortGroup<TPort> where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public TPort ExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x470990", Offset = "0x46F990", VA = "0x180470990")]
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
			[Cpp2IlInjected.Address(RVA = "0x402610", Offset = "0x401610", VA = "0x180402610", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x1ACD320", Offset = "0x1ACC320", VA = "0x181ACD320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x1ACD0B0", Offset = "0x1ACC0B0", VA = "0x181ACD0B0")]
		public ExecNameBasedPortGroup(string execPortName, PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCFB0", Offset = "0x1ACBFB0", VA = "0x181ACCFB0")]
		private void OnGroupPortRemoved(TPort obj)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public interface IIndexBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestAddPort();
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public class IndexBasedPortGroup<TPort> : PortGroupBase<TPort>, IIndexBasedPortGroup where TPort : PortBase
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
			[Cpp2IlInjected.Address(RVA = "0x4CC900", Offset = "0x4CB900", VA = "0x1804CC900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x3EFB60", Offset = "0x3EEB60", VA = "0x1803EFB60", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x1ACD320", Offset = "0x1ACC320", VA = "0x181ACD320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x1ACFF60", Offset = "0x1ACEF60", VA = "0x181ACFF60", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x1ACFDC0", Offset = "0x1ACEDC0", VA = "0x181ACFDC0")]
		public IndexBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory, string elementName, CircuitTypeOrString elementPortType, int minPortCount = 0, int maxPortCount = 64)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF6A0", Offset = "0x1ACE6A0", VA = "0x181ACF6A0", Slot = "16")]
		public override bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF4A0", Offset = "0x1ACE4A0", VA = "0x181ACF4A0")]
		public TPort AddPortLocal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1ACFA00", Offset = "0x1ACEA00", VA = "0x181ACFA00")]
		private void RemoveLastPortLocal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x1ACFC30", Offset = "0x1ACEC30", VA = "0x181ACFC30", Slot = "18")]
		protected override void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF760", Offset = "0x1ACE760", VA = "0x181ACF760", Slot = "19")]
		protected override void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x1ACFAE0", Offset = "0x1ACEAE0", VA = "0x181ACFAE0", Slot = "24")]
		public void RequestAddPort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF960", Offset = "0x1ACE960", VA = "0x181ACF960", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF990", Offset = "0x1ACE990", VA = "0x181ACF990", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014F")]
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
			[Cpp2IlInjected.Address(RVA = "0x15EEF20", Offset = "0x15EDF20", VA = "0x1815EEF20", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private OutputPort FirstConnectedPort
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x15EEED0", Offset = "0x15EDED0", VA = "0x1815EEED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x15EEE40", Offset = "0x15EDE40", VA = "0x1815EEE40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool SupportsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x15EEFF0", Offset = "0x15EDFF0", VA = "0x1815EEFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool HasCustomDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x15EEF60", Offset = "0x15EDF60", VA = "0x1815EEF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public CircuitSignal DefaultSignalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x15EEEB0", Offset = "0x15EDEB0", VA = "0x1815EEEB0")]
			get
			{
				return default(CircuitSignal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x15EF100", Offset = "0x15EE100", VA = "0x1815EF100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action OnDefaultSignalValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x15EEDA0", Offset = "0x15EDDA0", VA = "0x1815EEDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x15EF060", Offset = "0x15EE060", VA = "0x1815EF060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x557FA0", Offset = "0x556FA0", VA = "0x180557FA0", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x15EED40", Offset = "0x15EDD40", VA = "0x1815EED40")]
		public InputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, bool canSet = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x15EEAF0", Offset = "0x15EDAF0", VA = "0x1815EEAF0", Slot = "12")]
		protected override void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x15EEA50", Offset = "0x15EDA50", VA = "0x1815EEA50", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x15EECC0", Offset = "0x15EDCC0", VA = "0x1815EECC0", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x15EE9F0", Offset = "0x15ED9F0", VA = "0x1815EE9F0", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x15EE860", Offset = "0x15ED860", VA = "0x1815EE860")]
		private CircuitSignal DefaultValue(TypeKind kind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x15EEC00", Offset = "0x15EDC00", VA = "0x1815EEC00")]
		public DefaultPortData SerializeCustomDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x15EE930", Offset = "0x15ED930", VA = "0x1815EE930")]
		public void DeserializeCustomDefault(DefaultPortData portData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public interface INameBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestAddPort(string portName, CircuitType circuitType);

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HasPort(string portName);
	}
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	internal interface IEditableNameBasedPortGroup : INameBasedPortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ClearPorts();

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> eventDefinitionEventProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class NameBasedPortGroup<TPort> : PortGroupBase<TPort>, IEditableNameBasedPortGroup, INameBasedPortGroup where TPort : PortBase
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0x3E0FA0", Offset = "0x3DFFA0", VA = "0x1803E0FA0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x1ACD320", Offset = "0x1ACC320", VA = "0x181ACD320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1B70", Offset = "0x1AD0B70", VA = "0x181AD1B70")]
		public NameBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1920", Offset = "0x1AD0920", VA = "0x181AD1920", Slot = "26")]
		public void RequestAddPort(string portName, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x1AD12C0", Offset = "0x1AD02C0", VA = "0x181AD12C0", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1350", Offset = "0x1AD0350", VA = "0x181AD1350", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0E50", Offset = "0x1ACFE50", VA = "0x181AD0E50")]
		internal TPort AddPortLocal(string portName, CircuitTypeOrString circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1400", Offset = "0x1AD0400", VA = "0x181AD1400", Slot = "27")]
		public bool HasPort(string portName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1A60", Offset = "0x1AD0A60", VA = "0x181AD1A60")]
		public bool TryGetPort(string portName, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1240", Offset = "0x1AD0240", VA = "0x181AD1240")]
		private Guid GeneratePortId(string portName)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x1AD18F0", Offset = "0x1AD08F0", VA = "0x181AD18F0", Slot = "25")]
		public void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1440", Offset = "0x1AD0440", VA = "0x181AD1440")]
		internal void MergeNamedGroup(IEnumerable<KeyValuePair<string, CircuitType>> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0FF0", Offset = "0x1ACFFF0", VA = "0x181AD0FF0", Slot = "24")]
		public void ClearPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x136F500", Offset = "0x136E500", VA = "0x18136F500")]
		internal void OnBridgedPortRemoved<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x136F580", Offset = "0x136E580", VA = "0x18136F580")]
		internal (IEnumerable<Action>, IEnumerable<Node>) RemoveBridgedPortCore<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x136F4D0", Offset = "0x136E4D0", VA = "0x18136F4D0")]
		internal void OnBridgedPortAdded<TOtherPort>(TOtherPort otherAddedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x1A9F220", Offset = "0x1A9E220", VA = "0x181A9F220")]
		internal bool CreateOrUpdateBridgedPort<TOtherPort>(TOtherPort otherAddedPort, out TPort myPort) where TOtherPort : PortBase
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public delegate CircuitSignal OutputPortGetDelegate(IExecutionScope executionScope);
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public delegate CircuitType OutputPortGetSignalTypeDelegate();
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public delegate void OutputPortSetDelegate(CircuitSignal value);
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public delegate Node OutputPortGetReferencedNodeDelegate();
	[Cpp2IlInjected.Token(Token = "0x2000157")]
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x16525C0", Offset = "0x16515C0", VA = "0x1816525C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3DBAE0", Offset = "0x3DAAE0", VA = "0x1803DBAE0", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x1652460", Offset = "0x1651460", VA = "0x181652460")]
		public OutputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, [Optional] OutputPortGetDelegate outputPortGetDelegate, [Optional] OutputPortSetDelegate outputPortSetDelegate, [Optional] OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x1652380", Offset = "0x1651380", VA = "0x181652380", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x1652420", Offset = "0x1651420", VA = "0x181652420", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x1652360", Offset = "0x1651360", VA = "0x181652360", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x1652230", Offset = "0x1651230", VA = "0x181652230")]
		public NextExecutable GetExec()
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x1652410", Offset = "0x1651410", VA = "0x181652410")]
		public void SetDelegates([Optional] OutputPortGetDelegate get, [Optional] OutputPortSetDelegate set)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public abstract class PortBase : IDisposable, ICircuitSerializable<NodePortData>
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x16537E0", Offset = "0x16527E0", VA = "0x1816537E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		internal bool IsDynamic
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x3C1E10", Offset = "0x3C0E10", VA = "0x1803C1E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x835A30", Offset = "0x834A30", VA = "0x180835A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x38F140", Offset = "0x38E140", VA = "0x18038F140", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x391BC0", Offset = "0x390BC0", VA = "0x180391BC0", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x16539D0", Offset = "0x16529D0", VA = "0x1816539D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1653740", Offset = "0x1652740", VA = "0x181653740", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x1653930", Offset = "0x1652930", VA = "0x181653930", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<bool> OnIsConnectedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x16536A0", Offset = "0x16526A0", VA = "0x1816536A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x1653890", Offset = "0x1652890", VA = "0x181653890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Node GetNode(NodeConnection connection);

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x1653570", Offset = "0x1652570", VA = "0x181653570")]
		protected PortBase(Guid portId, string portName, bool isInputPort, [Optional][CanBeNull] CircuitTypeOrString? circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x16530D0", Offset = "0x16520D0", VA = "0x1816530D0")]
		public void AddConnection(NodeConnection newConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x16533C0", Offset = "0x16523C0", VA = "0x1816533C0")]
		public bool RemoveConnection(NodeConnection connection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x1653300", Offset = "0x1652300", VA = "0x181653300")]
		public void RemoveConnectionAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xE2A6B0", Offset = "0xE296B0", VA = "0x180E2A6B0", Slot = "12")]
		protected virtual void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x16532A0", Offset = "0x16522A0", VA = "0x1816532A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16534A0", Offset = "0x16524A0", VA = "0x1816534A0", Slot = "17")]
		public NodePortData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x1653190", Offset = "0x1652190", VA = "0x181653190", Slot = "5")]
		public void DeserializeFromProtobuf(NodePortData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x16531B0", Offset = "0x16521B0", VA = "0x1816531B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	internal static class PortBridge
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x136FEB0", Offset = "0x136EEB0", VA = "0x18136FEB0")]
		internal static void BridgePortDelegates<TPortA, TPortB>(TPortA portA, TPortB portB) where TPortA : PortBase where TPortB : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x1653A20", Offset = "0x1652A20", VA = "0x181653A20")]
		internal static void BridgePorts(NameBasedPortGroup<InputPort> source, NameBasedPortGroup<OutputPort> dest, bool skipExecs = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public delegate TPort PortCreationFactory<TPort>(Guid portId, string portName, CircuitTypeOrString portType) where TPort : PortBase;
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	public abstract class PortCollection<TPort> : ICircuitSerializable<PortCollectionData>, IDisposable where TPort : PortBase
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
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public IEnumerable<PortGroupBase<TPort>> AllPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x1AD3CC0", Offset = "0x1AD2CC0", VA = "0x181AD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public IEnumerable<TPort> AllPorts
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD3D50", Offset = "0x1AD2D50", VA = "0x181AD3D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3A80", Offset = "0x1AD2A80", VA = "0x181AD3A80")]
		public PortCollection(bool isInputCollection, Node node, PortCreationFactory<TPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2C50", Offset = "0x1AD1C50", VA = "0x181AD2C50")]
		public IndexBasedPortGroup<TPort> RegisterIndexedPortGroup(Guid portGroupId, PortGroupSerialization serialization, CircuitTypeOrString elementType, string elementName = "Element", [Optional] string portGroupName, int minPortCount = 0, int maxPortCount = 64)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2D80", Offset = "0x1AD1D80", VA = "0x181AD2D80")]
		public NameBasedPortGroup<TPort> RegisterNameBasedPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2B40", Offset = "0x1AD1B40", VA = "0x181AD2B40")]
		public ExecNameBasedPortGroup<TPort> RegisterExecNameBasedPortGroup(string execPortName, Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2A50", Offset = "0x1AD1A50", VA = "0x181AD2A50")]
		public BasicPortGroup<TPort> RegisterBasicPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2A40", Offset = "0x1AD1A40", VA = "0x181AD2A40")]
		private Dictionary<Guid, PortGroupBase<TPort>> GetPortGroupDictionary(PortGroupSerialization serialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1C00", Offset = "0x1AD0C00", VA = "0x181AD1C00")]
		private void AddPortGroup(PortGroupBase<TPort> newPortGroup, [Optional] string portGroupName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3510", Offset = "0x1AD2510", VA = "0x181AD3510")]
		public bool TryGetPort(Guid portGuid, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1BD0", Offset = "0x1AD0BD0", VA = "0x181AD1BD0")]
		public void AddBuiltInPort(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2770", Offset = "0x1AD1770", VA = "0x181AD2770", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2FF0", Offset = "0x1AD1FF0", VA = "0x181AD2FF0", Slot = "6")]
		public PortCollectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "7")]
		protected virtual void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2250", Offset = "0x1AD1250", VA = "0x181AD2250", Slot = "4")]
		public void DeserializeFromProtobuf([NotNull] PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "8")]
		protected virtual void DeserializeInternal(PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1EA0", Offset = "0x1AD0EA0", VA = "0x181AD1EA0")]
		private PortGroupBase<TPort> CreatePortGroupOnDeserialization(Guid portGroupId, PortGroupData protobufData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x1A9F300", Offset = "0x1A9E300", VA = "0x181A9F300")]
		public bool TryGetPortGroup<T>(Guid portGroupId, out T portGroup) where T : PortGroupBase<TPort>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2E70", Offset = "0x1AD1E70", VA = "0x181AD2E70")]
		public void RemovePortGroup(Guid groupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public sealed class InputPortCollection : PortCollection<InputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x15EE7E0", Offset = "0x15ED7E0", VA = "0x1815EE7E0")]
		public InputPortCollection(Node node, PortCreationFactory<InputPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x15EE560", Offset = "0x15ED560", VA = "0x1815EE560", Slot = "7")]
		protected override void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x15EE330", Offset = "0x15ED330", VA = "0x1815EE330", Slot = "8")]
		protected override void DeserializeInternal(PortCollectionData collectionData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public sealed class OutputPortCollection : PortCollection<OutputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x16518C0", Offset = "0x16508C0", VA = "0x1816518C0")]
		public OutputPortCollection(Node node, PortCreationFactory<OutputPort> portCreationFactory)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public enum PortGroupSerialization
	{
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		BuiltInGroup_BuiltInPorts,
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		BuiltInGroup_DynamicPorts,
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		DynamicGroup_DynamicPorts
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
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
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	public abstract class PortGroupBase<TPort> : IPortGroup, IDisposable, ICircuitSerializable<PortGroupData> where TPort : PortBase, ICircuitSerializable<NodePortData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private readonly Dictionary<Guid, TPort> groupPorts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly List<TPort> orderedGroupPorts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private readonly PortCollection<TPort> parentCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private readonly Node node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected readonly PortCreationFactory<TPort> PortFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private readonly DynamicPortGroupModificationHandler<TPort> portGroupModificationHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		internal bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		[CompilerGenerated]
		private Action OnDisposed;

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x1AD5970", Offset = "0x1AD4970", VA = "0x181AD5970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public IReadOnlyList<TPort> OrderedPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x38D8A0", Offset = "0x38C8A0", VA = "0x18038D8A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA5AE0", Offset = "0xEA4AE0", VA = "0x180EA5AE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IReadOnlyCollection<PortBase> IPortGroup.Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x11C55C0", Offset = "0x11C45C0", VA = "0x1811C55C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public Guid GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AB0", Offset = "0x4A3AB0", VA = "0x1804A4AB0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x38B5A0", Offset = "0x38A5A0", VA = "0x18038B5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x4E95A0", Offset = "0x4E85A0", VA = "0x1804E95A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public virtual bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x39EB10", Offset = "0x39DB10", VA = "0x18039EB10", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<TPort> OnPortAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x1AD57F0", Offset = "0x1AD47F0", VA = "0x181AD57F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AD5990", Offset = "0x1AD4990", VA = "0x181AD5990")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<TPort> OnPortRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1AD58B0", Offset = "0x1AD48B0", VA = "0x181AD58B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AD5A50", Offset = "0x1AD4A50", VA = "0x181AD5A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x1AD46D0", Offset = "0x1AD36D0", VA = "0x181AD46D0", Slot = "16")]
		public virtual bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x1AD55A0", Offset = "0x1AD45A0", VA = "0x181AD55A0")]
		protected PortGroupBase(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AD5500", Offset = "0x1AD4500", VA = "0x181AD5500")]
		public bool TryGetRegisteredPort(Guid portId, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x1AD44A0", Offset = "0x1AD34A0", VA = "0x181AD44A0")]
		protected void AddGroupPort(TPort port, [Optional] bool? isDynamicOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4D30", Offset = "0x1AD3D30", VA = "0x181AD4D30")]
		protected bool RemoveGroupPort(TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4DF0", Offset = "0x1AD3DF0", VA = "0x181AD4DF0", Slot = "8")]
		public bool RemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x1AD53B0", Offset = "0x1AD43B0", VA = "0x181AD53B0", Slot = "17")]
		public PortGroupData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x1AD50D0", Offset = "0x1AD40D0", VA = "0x181AD50D0", Slot = "18")]
		protected virtual void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4710", Offset = "0x1AD3710", VA = "0x181AD4710", Slot = "10")]
		public void DeserializeFromProtobuf(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4770", Offset = "0x1AD3770", VA = "0x181AD4770", Slot = "19")]
		protected virtual void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD49F0", Offset = "0x1AD39F0", VA = "0x181AD49F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4E80", Offset = "0x1AD3E80", VA = "0x181AD4E80", Slot = "20")]
		public void RequestAddPort(Guid portId, [Optional] string portName, [Optional] CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4FD0", Offset = "0x1AD3FD0", VA = "0x181AD4FD0", Slot = "21")]
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
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[NodeTag("Value Modifiers", new string[] { })]
	public abstract class PureNode : Node
	{
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x12C3A30", Offset = "0x12C2A30", VA = "0x1812C3A30")]
		protected PureNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x12C3A60", Offset = "0x12C2A60", VA = "0x1812C3A60")]
		protected PureNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE10", Offset = "0x39BE10", VA = "0x18039CE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x15E7E90", Offset = "0x15E6E90", VA = "0x1815E7E90")]
			get
			{
				return default(NextExecutable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x1654960", Offset = "0x1653960", VA = "0x181654960")]
		protected SingleExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x1654BF0", Offset = "0x1653BF0", VA = "0x181654BF0")]
		protected SingleExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x1654850", Offset = "0x1653850", VA = "0x181654850", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract void ExecuteInternal(IExecutionScope executionScope);
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	public class CircuitObjectTransform : ICircuitSerializable<CircuitObjectTransformData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		public delegate void OnLocalPositionChangedEvent(Vector3 newLocalPosition);

		[Cpp2IlInjected.Token(Token = "0x2000169")]
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
			[Cpp2IlInjected.Address(RVA = "0x5758B0", Offset = "0x5748B0", VA = "0x1805758B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Quaternion LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x12C0A70", Offset = "0x12BFA70", VA = "0x1812C0A70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event OnLocalPositionChangedEvent OnLocalPositionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x12C0930", Offset = "0x12BF930", VA = "0x1812C0930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x12C0A80", Offset = "0x12BFA80", VA = "0x1812C0A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event OnLocalRotationChangedEvent OnLocalRotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x12C09D0", Offset = "0x12BF9D0", VA = "0x1812C09D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x12C0B20", Offset = "0x12BFB20", VA = "0x1812C0B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D50", Offset = "0x6D5D50", VA = "0x1806D6D50")]
		public CircuitObjectTransform(Guid circuitObjectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x12C0780", Offset = "0x12BF780", VA = "0x1812C0780")]
		public void SetLocalPosition(Vector3 newLocalPosition, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x12C0870", Offset = "0x12BF870", VA = "0x1812C0870")]
		public void SetLocalRotation(Quaternion newLocalRotation, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF6C0", VA = "0x1812C06C0", Slot = "5")]
		public CircuitObjectTransformData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x12C0520", Offset = "0x12BF520", VA = "0x1812C0520", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitObjectTransformData protobuf)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	public class CircuitTokenFlag
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		public class CircuitToken
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private readonly string tokenName;

			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x3A5520", Offset = "0x3A4520", VA = "0x1803A5520")]
			public CircuitToken(string tokenName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x12C2480", Offset = "0x12C1480", VA = "0x1812C2480", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C2440", Offset = "0x12C1440", VA = "0x1812C2440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x12C22A0", Offset = "0x12C12A0", VA = "0x1812C22A0")]
		public bool AddToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x12C2360", Offset = "0x12C1360", VA = "0x1812C2360")]
		public bool RemoveToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x37F240", Offset = "0x37E240", VA = "0x18037F240")]
		public CircuitTokenFlag()
		{
		}
	}
}
namespace CircuitsV2.Graph.Nodes
{
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	public struct CircuitPlayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public readonly int BackingPlayerId;

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x1533A0", Offset = "0x1527A0", VA = "0x1801533A0")]
		public CircuitPlayer(int backingPlayerId)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	public struct CircuitTeam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public readonly int BackingTeamId;

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x1533A0", Offset = "0x1527A0", VA = "0x1801533A0")]
		public CircuitTeam(int backingTeamId = -1)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[Guid("21B7F027-68C6-4C8C-A5C3-81992622DE80")]
	public class ChangeCircuitObjectNameModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x15E3130", Offset = "0x15E2130", VA = "0x1815E3130")]
		public ChangeCircuitObjectNameModificationHandler(CircuitObject modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x15E3070", Offset = "0x15E2070", VA = "0x1815E3070")]
		public ICircuitObjectModification CreateModification(string newNodeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x15E30C0", Offset = "0x15E20C0", VA = "0x1815E30C0", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	public abstract class CircuitObjectModificationHandlerBase<T> : ICircuitObjectModificationHandler where T : CircuitObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected readonly T ModifiedObject;

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public virtual Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x1ACC650", Offset = "0x1ACB650", VA = "0x181ACC650", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x11C0240", Offset = "0x11BF240", VA = "0x1811C0240")]
		protected CircuitObjectModificationHandlerBase(T modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HandleModificationRequest(byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC590", Offset = "0x1ACB590", VA = "0x181ACC590")]
		protected ICircuitObjectModification WithPayload(string payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC600", Offset = "0x1ACB600", VA = "0x181ACC600")]
		protected ICircuitObjectModification WithPayload(IMessage payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC510", Offset = "0x1ACB510", VA = "0x181ACC510")]
		protected ICircuitObjectModification WithPayload(byte[] payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC4D0", Offset = "0x1ACB4D0", VA = "0x181ACC4D0")]
		protected static string ParseStringPayload(byte[] payload)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	public abstract class NodeModificationHandlerBase : CircuitObjectModificationHandlerBase<Node>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x15F2350", Offset = "0x15F1350", VA = "0x1815F2350")]
		protected NodeModificationHandlerBase(Node modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	public abstract class NodeModificationHandlerBase<T> : CircuitObjectModificationHandlerBase<T> where T : Node
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x1101900", Offset = "0x1100900", VA = "0x181101900")]
		protected NodeModificationHandlerBase(T modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	public abstract class EventModificationHandlerBase : CircuitObjectModificationHandlerBase<CircuitEventObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x15E7730", Offset = "0x15E6730", VA = "0x1815E7730")]
		protected EventModificationHandlerBase(CircuitEventObject modifiedEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
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
	[Cpp2IlInjected.Token(Token = "0x2000174")]
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
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public class ModificationBase : ICircuitObjectModification
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private readonly byte[] payload;

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public Guid HandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0x4A4A90", Offset = "0x4A3A90", VA = "0x1804A4A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4120", Offset = "0x3A3120", VA = "0x1803A4120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x15F0DF0", Offset = "0x15EFDF0", VA = "0x1815F0DF0")]
		public ModificationBase(ICircuitObjectModificationHandler handler, CircuitObject modifiedObject, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0", Slot = "6")]
		public byte[] GetPayload()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x15F0DB0", Offset = "0x15EFDB0", VA = "0x1815F0DB0", Slot = "7")]
		public void Send()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[Guid("88EC6D1C-1F68-4A30-AD72-71A8AA1B933A")]
	public class PortDefaultValueModificationHandler : NodeModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x15F2350", Offset = "0x15F1350", VA = "0x1815F2350")]
		public PortDefaultValueModificationHandler(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x15F61B0", Offset = "0x15F51B0", VA = "0x1815F61B0")]
		public ICircuitObjectModification CreateModification(Guid portId, CircuitSignal defaultSignal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x15F6270", Offset = "0x15F5270", VA = "0x1815F6270", Slot = "7")]
		public override void HandleModificationRequest(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[InternalNode]
	[Guid("6C9E8939-6963-4803-9F22-90EE32382B0A")]
	[NodeTag("Debug", new string[] { })]
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
		[Cpp2IlInjected.Address(RVA = "0x15E5A00", Offset = "0x15E4A00", VA = "0x1815E5A00")]
		public DebugLogNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x15E58C0", Offset = "0x15E48C0", VA = "0x1815E58C0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
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
		[Cpp2IlInjected.Address(RVA = "0x15E22C0", Offset = "0x15E12C0", VA = "0x1815E22C0")]
		public BranchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x15E2100", Offset = "0x15E1100", VA = "0x1815E2100", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
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
		[Cpp2IlInjected.Address(RVA = "0x15E2C50", Offset = "0x15E1C50", VA = "0x1815E2C50")]
		public BreakTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x15E29B0", Offset = "0x15E19B0", VA = "0x1815E29B0")]
		private CircuitSignal GetReturn0(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x15E2AB0", Offset = "0x15E1AB0", VA = "0x1815E2AB0")]
		private CircuitSignal GetReturn1(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[Guid("14EBDE7A-76C0-47DF-B0DD-01B1DAA50821")]
	public sealed class CircuitBoard : CircuitContextNode<CircuitBoard.InnerContextEntryNode, CircuitBoard.InnerContextExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x200017B")]
		[InternalNode]
		[Guid("F965D1E5-D418-4DA3-A777-4846979707E2")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x15EDA60", Offset = "0x15ECA60", VA = "0x1815EDA60")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[InternalNode]
		[Guid("50D4E4A0-EB29-428A-BF11-ED58B6686B2C")]
		public class InnerContextExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x15EE250", Offset = "0x15ED250", VA = "0x1815EE250")]
			public InnerContextExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200017D")]
		[Guid("9138579F-BB0F-4D9B-A052-BD28373625A4")]
		internal class CircuitBoardModificationHandler : NodeModificationHandlerBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private readonly CircuitBoard modifiedNode;

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x15E3940", Offset = "0x15E2940", VA = "0x1815E3940")]
			public CircuitBoardModificationHandler(CircuitBoard modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x15E3180", Offset = "0x15E2180", VA = "0x1815E3180")]
			public ICircuitObjectModification CreateExecGroupModification(string newExecGroupName, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x15E3220", Offset = "0x15E2220", VA = "0x1815E3220")]
			public ICircuitObjectModification DeleteExecGroupModification(Guid execGroupId, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x15E32D0", Offset = "0x15E22D0", VA = "0x1815E32D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39EB10", Offset = "0x39DB10", VA = "0x18039EB10", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public override bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x39EB10", Offset = "0x39DB10", VA = "0x18039EB10", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x15E49E0", Offset = "0x15E39E0", VA = "0x1815E49E0")]
		public CircuitBoard(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x15E3990", Offset = "0x15E2990", VA = "0x1815E3990")]
		[EditableAddExecInput]
		internal ExecNameBasedPortGroup<InputPort> AddExecInput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x15E3B60", Offset = "0x15E2B60", VA = "0x1815E3B60")]
		[EditableAddExecOutput]
		internal ExecNameBasedPortGroup<OutputPort> AddExecOutput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x15E4380", Offset = "0x15E3380", VA = "0x1815E4380")]
		internal void RemoveExecInput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x15E44A0", Offset = "0x15E34A0", VA = "0x1815E44A0")]
		internal void RemoveExecOutput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x15E3D30", Offset = "0x15E2D30", VA = "0x1815E3D30", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x15E40C0", Offset = "0x15E30C0", VA = "0x1815E40C0", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x15E45C0", Offset = "0x15E35C0", VA = "0x1815E45C0", Slot = "24")]
		public override bool RequestAddInputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x15E4660", Offset = "0x15E3660", VA = "0x1815E4660", Slot = "26")]
		public override bool RequestAddOutputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x15E4700", Offset = "0x15E3700", VA = "0x1815E4700", Slot = "28")]
		public override bool RequestRemoveInputGroup(Guid groupId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x15E4820", Offset = "0x15E3820", VA = "0x1815E4820", Slot = "30")]
		public override bool RequestRemoveOutputGroup(Guid groupId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017E")]
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
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public abstract class CircuitContextNode : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public Guid InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x700E10", Offset = "0x6FFE10", VA = "0x180700E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public virtual bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public virtual bool CanRemoveInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public virtual bool CanRemoveOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x15E4BC0", Offset = "0x15E3BC0", VA = "0x1815E4BC0")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x15E4B80", Offset = "0x15E3B80", VA = "0x1815E4B80", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "24")]
		public virtual bool RequestAddInputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "26")]
		public virtual bool RequestAddOutputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "28")]
		public virtual bool RequestRemoveInputGroup(Guid portGroup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x391BB0", Offset = "0x390BB0", VA = "0x180391BB0", Slot = "30")]
		public virtual bool RequestRemoveOutputGroup(Guid portGroup)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		protected HashSet<TEntryNode> CachedEntryNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x1ACBF10", Offset = "0x1ACAF10", VA = "0x181ACBF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		protected HashSet<TExitNode> CachedExitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x1ACC1F0", Offset = "0x1ACB1F0", VA = "0x181ACC1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CircuitContext ChildContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBD00", Offset = "0x1ACAD00", VA = "0x181ACBD00")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBC90", Offset = "0x1ACAC90", VA = "0x181ACBC90")]
		private void OnNodeAddedOrRemoved(CircuitContext context, Node modifiedNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBBA0", Offset = "0x1ACABA0", VA = "0x181ACBBA0")]
		private void DirtyCachedExitNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBC40", Offset = "0x1ACAC40", VA = "0x181ACBC40", Slot = "16")]
		public sealed override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBBB0", Offset = "0x1ACABB0", VA = "0x181ACBBB0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "32")]
		protected virtual void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBBF0", Offset = "0x1ACABF0", VA = "0x181ACBBF0", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		protected abstract NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB2F0", Offset = "0x1ACA2F0", VA = "0x181ACB2F0", Slot = "34")]
		protected virtual bool AddInnerEntry(InputPort execInput, out TEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB720", Offset = "0x1ACA720", VA = "0x181ACB720", Slot = "35")]
		internal virtual bool AddInnerExit(OutputPort execOutput, out TExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBB60", Offset = "0x1ACAB60", VA = "0x181ACBB60", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE10", Offset = "0x39BE10", VA = "0x18039CE10", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x3F7F50", Offset = "0x3F6F50", VA = "0x1803F7F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AD0120", Offset = "0x1ACF120", VA = "0x181AD0120")]
		protected InnerNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[InternalNode]
	public abstract class InnerContextEntryNodeBase : InnerNodeBase<OutputPort>, IEntryNode
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		protected sealed override PortCollection<OutputPort> PortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0x39C8E0", Offset = "0x39B8E0", VA = "0x18039C8E0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x15ED820", Offset = "0x15EC820", VA = "0x1815ED820")]
		protected InnerContextEntryNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x15ED7B0", Offset = "0x15EC7B0", VA = "0x1815ED7B0", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
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
			[Cpp2IlInjected.Address(RVA = "0x470990", Offset = "0x46F990", VA = "0x180470990", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x15EE1B0", Offset = "0x15ED1B0", VA = "0x1815EE1B0")]
		protected InnerContextExitNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x15EE130", Offset = "0x15ED130", VA = "0x1815EE130", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public interface IEntryNode
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public interface IExitNode
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x15E6020", Offset = "0x15E5020", VA = "0x1815E6020")]
		public DelayNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x15E5D50", Offset = "0x15E4D50", VA = "0x1815E5D50", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x15E5C30", Offset = "0x15E4C30", VA = "0x1815E5C30", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x15E5E60", Offset = "0x15E4E60", VA = "0x1815E5E60", Slot = "23")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x15E5CE0", Offset = "0x15E4CE0", VA = "0x1815E5CE0")]
		private void ExecuteAfterDelay(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[NodeTag("Events", new string[] { })]
	public abstract class EventNodeBase : ExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Guid("D2C5C13D-2AF9-4632-B80F-E434C96608FB")]
		private class EventRegistrationNodeModificationHandler : NodeModificationHandlerBase<EventNodeBase>
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0x15E8790", Offset = "0x15E7790", VA = "0x1815E8790")]
			public EventRegistrationNodeModificationHandler(EventNodeBase modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x15E8650", Offset = "0x15E7650", VA = "0x1815E8650")]
			public ICircuitObjectModification CreateSetRegistrationModification(CircuitEventBus.EventRegistration eventRegistration)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x15E86B0", Offset = "0x15E76B0", VA = "0x1815E86B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x15E7B60", Offset = "0x15E6B60", VA = "0x1815E7B60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices();

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x15E7AB0", Offset = "0x15E6AB0", VA = "0x1815E7AB0")]
		protected EventNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x15E7780", Offset = "0x15E6780", VA = "0x1815E7780", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x15E7810", Offset = "0x15E6810", VA = "0x1815E7810")]
		private void RefreshPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "25")]
		protected virtual void RegisterNewEventRegistration([NotNull] CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F0", Offset = "0x37E1F0", VA = "0x18037F1F0", Slot = "26")]
		protected virtual void UnregisterOldEventRegistration([NotNull] CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x15E7A20", Offset = "0x15E6A20", VA = "0x1815E7A20")]
		protected void SetEventRegistrationFromData(EventRegistrationData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId);

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x15E7960", Offset = "0x15E6960", VA = "0x1815E7960")]
		public void RequestEventRegistrationChange(CircuitEventBus.EventRegistration setEventRegistration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[Guid("8B533CCB-643A-491D-982C-94417CE99954")]
	[NodeTag("Events", new string[] { })]
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
			[Cpp2IlInjected.Address(RVA = "0x46F0C0", Offset = "0x46E0C0", VA = "0x18046F0C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x15E83D0", Offset = "0x15E73D0", VA = "0x1815E83D0")]
		public EventReceiverNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x15E7E90", Offset = "0x15E6E90", VA = "0x1815E7E90", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x15E82D0", Offset = "0x15E72D0", VA = "0x1815E82D0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x15E7E10", Offset = "0x15E6E10", VA = "0x1815E7E10", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x15E8340", Offset = "0x15E7340", VA = "0x1815E8340", Slot = "26")]
		protected override void UnregisterOldEventRegistration(CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x15E7EE0", Offset = "0x15E6EE0", VA = "0x1815E7EE0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x15E7F30", Offset = "0x15E6F30", VA = "0x1815E7F30", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x15E82A0", Offset = "0x15E72A0", VA = "0x1815E82A0", Slot = "25")]
		protected override void RegisterNewEventRegistration(CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x15E7F60", Offset = "0x15E6F60", VA = "0x1815E7F60", Slot = "28")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[Guid("96A8FE50-BC37-458B-BAC9-582D45314779")]
	[NodeTag("Events", new string[] { })]
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
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x46F0C0", Offset = "0x46E0C0", VA = "0x18046F0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x431C90", Offset = "0x430C90", VA = "0x180431C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x15E8D40", Offset = "0x15E7D40", VA = "0x1815E8D40")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId, bool sendSyncEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x15E9100", Offset = "0x15E8100", VA = "0x1815E9100")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x15E8BE0", Offset = "0x15E7BE0", VA = "0x1815E8BE0", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x15E8B90", Offset = "0x15E7B90", VA = "0x1815E8B90", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x15E8B30", Offset = "0x15E7B30", VA = "0x1815E8B30", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x15E8860", Offset = "0x15E7860", VA = "0x1815E8860")]
		protected void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x15E8C10", Offset = "0x15E7C10", VA = "0x1815E8C10", Slot = "28")]
		protected virtual void SendEventInternal(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x15E8C30", Offset = "0x15E7C30", VA = "0x1815E8C30", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x15E87E0", Offset = "0x15E77E0", VA = "0x1815E87E0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[Guid("19572058-D738-4E6D-9C89-D5DEE7F5C903")]
	[NodeTag("Networking", new string[] { })]
	public class SynchedEventSenderNode : EventSenderNode
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[Guid("FF39CC84-7A64-4730-AEF8-A7746E6F5727")]
		public class SyncedEventSenderModificationHandler : NodeModificationHandlerBase<SynchedEventSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170001F7")]
			public SynchedEventSenderNode EventSenderNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000A93")]
				[Cpp2IlInjected.Address(RVA = "0x39DCC0", Offset = "0x39CCC0", VA = "0x18039DCC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x1655A00", Offset = "0x1654A00", VA = "0x181655A00")]
			public SyncedEventSenderModificationHandler(SynchedEventSenderNode modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x1655940", Offset = "0x1654940", VA = "0x181655940")]
			public ICircuitObjectModification CreateChangeTargetModification(SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x16559C0", Offset = "0x16549C0", VA = "0x1816559C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E9FF0", Offset = "0x3E8FF0", VA = "0x1803E9FF0")]
			get
			{
				return default(SynchronizedCircuitContext.SyncedEventTargets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x1655F80", Offset = "0x1654F80", VA = "0x181655F80")]
		public SynchedEventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x1655F40", Offset = "0x1654F40", VA = "0x181655F40", Slot = "28")]
		protected override void SendEventInternal(CircuitEvent circuitEvent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[Guid("495D52DC-EDF0-4498-92CA-6B80EC48A462")]
	[NodeTag("Loops", new string[] { })]
	public class ForNode : CircuitContextNode<ForNode.InnerContextEntryNode, ForNode.BreakExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[Guid("3B0E812B-30F8-41E4-B55B-AD54B393C1F3")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			private static readonly Guid indexId;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public readonly OutputPort IndexPort;

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x15EDB40", Offset = "0x15ECB40", VA = "0x1815EDB40")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[Guid("CBB04F96-C285-4C6C-8F15-1B88B78FC0B0")]
		public class BreakExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x170001FC")]
			public bool Break
			{
				[Cpp2IlInjected.Token(Token = "0x6000AA7")]
				[Cpp2IlInjected.Address(RVA = "0x836F80", Offset = "0x835F80", VA = "0x180836F80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000AA8")]
				[Cpp2IlInjected.Address(RVA = "0x835AD0", Offset = "0x834AD0", VA = "0x180835AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x15E27D0", Offset = "0x15E17D0", VA = "0x1815E27D0")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0x15E2760", Offset = "0x15E1760", VA = "0x1815E2760", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x15E27C0", Offset = "0x15E17C0", VA = "0x1815E27C0")]
			public void ResetBreak()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private static readonly Guid fromId;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private static readonly Guid toId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private BreakExitNode returnNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private InnerContextEntryNode entryNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private readonly NameBasedPortGroup<InputPort> valueInputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private readonly NameBasedPortGroup<OutputPort> valueOutputGroup;

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x4703F0", Offset = "0x46F3F0", VA = "0x1804703F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A1220", Offset = "0x3A0220", VA = "0x1803A1220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public InputPort FromInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x470560", Offset = "0x46F560", VA = "0x180470560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public InputPort ToInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x39CCC0", Offset = "0x39BCC0", VA = "0x18039CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x15E9AF0", Offset = "0x15E8AF0", VA = "0x1815E9AF0")]
		public ForNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x15E9970", Offset = "0x15E8970", VA = "0x1815E9970", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x15E9690", Offset = "0x15E8690", VA = "0x1815E9690", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x15E9570", Offset = "0x15E8570", VA = "0x1815E9570", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x15E9600", Offset = "0x15E8600", VA = "0x1815E9600", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x15E9720", Offset = "0x15E8720", VA = "0x1815E9720", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[NodeTag("Loops", new string[] { })]
	[Guid("9A4AAEC1-019F-4912-8FF1-F703381D5832")]
	public class ForeachNode : CircuitContextNode<ForeachNode.InnerContextEntryNode, ForeachNode.BreakExitNode>, IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		[Guid("D377C07B-9628-46DE-BB53-0AE6B6069AD3")]
		public class InnerContextEntryNode : InnerContextEntryNodeBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public readonly OutputPort ArrayElementPort;

			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0x15EDE20", Offset = "0x15ECE20", VA = "0x1815EDE20")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8C0", Offset = "0x15EC8C0", VA = "0x1815ED8C0", Slot = "21")]
			public override IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[InternalNode]
		[Guid("6FFDEC42-782E-4C79-A6C2-6393FB9275D0")]
		public class BreakExitNode : InnerContextExitNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x17000200")]
			public bool Break
			{
				[Cpp2IlInjected.Token(Token = "0x6000ABE")]
				[Cpp2IlInjected.Address(RVA = "0x836F80", Offset = "0x835F80", VA = "0x180836F80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000ABF")]
				[Cpp2IlInjected.Address(RVA = "0x835AD0", Offset = "0x834AD0", VA = "0x180835AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x15E28C0", Offset = "0x15E18C0", VA = "0x1815E28C0")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x15E2700", Offset = "0x15E1700", VA = "0x1815E2700", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x15E27C0", Offset = "0x15E17C0", VA = "0x1815E27C0")]
			public void ResetBreak()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly Guid executeInputPortId;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly Guid executeOutputPortId;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private static readonly Guid arrayPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private readonly InputPort arrayInputPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private readonly NameBasedPortGroup<InputPort> valueInputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private readonly NameBasedPortGroup<OutputPort> valueOutputGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private BreakExitNode returnNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private InnerContextEntryNode entryNode;

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x4703F0", Offset = "0x46F3F0", VA = "0x1804703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public OutputPort OutputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x3A1220", Offset = "0x3A0220", VA = "0x1803A1220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public InnerContextEntryNode EntryNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x39CA80", Offset = "0x39BA80", VA = "0x18039CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x15EA770", Offset = "0x15E9770", VA = "0x1815EA770")]
		public ForeachNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x15EA620", Offset = "0x15E9620", VA = "0x1815EA620", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x15EA1A0", Offset = "0x15E91A0", VA = "0x1815EA1A0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x15EA230", Offset = "0x15E9230", VA = "0x1815EA230", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x15EA080", Offset = "0x15E9080", VA = "0x1815EA080", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x15EA110", Offset = "0x15E9110", VA = "0x1815EA110", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x15EA540", Offset = "0x15E9540", VA = "0x1815EA540", Slot = "21")]
		public override IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[NodeTag("Lists", new string[] { })]
	[Guid("E8C5082F-0A75-4025-9679-293BC8D72989")]
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
		[Cpp2IlInjected.Address(RVA = "0x15EB330", Offset = "0x15EA330", VA = "0x1815EB330")]
		public GetElementNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x15EB110", Offset = "0x15EA110", VA = "0x1815EB110")]
		private CircuitSignal Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[Guid("0493204D-9815-49A9-8C87-4DEDF5CCF7E8")]
	[NodeTag("Lists", new string[] { })]
	public class GetListCountNode : TypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x15EB7E0", Offset = "0x15EA7E0", VA = "0x1815EB7E0")]
		public GetListCountNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x15EB770", Offset = "0x15EA770", VA = "0x1815EB770", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019C")]
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
		[Cpp2IlInjected.Address(RVA = "0x15EC800", Offset = "0x15EB800", VA = "0x1815EC800")]
		public HasAuthorityNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x15EC6A0", Offset = "0x15EB6A0", VA = "0x1815EC6A0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019D")]
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
		[Cpp2IlInjected.Address(RVA = "0x15F0290", Offset = "0x15EF290", VA = "0x1815F0290")]
		public MakeListNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x15F0160", Offset = "0x15EF160", VA = "0x1815F0160", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019E")]
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
		[Cpp2IlInjected.Address(RVA = "0x15F0830", Offset = "0x15EF830", VA = "0x1815F0830")]
		public MakeTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x15F0640", Offset = "0x15EF640", VA = "0x1815F0640")]
		private CircuitSignal GetReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019F")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EC6E0", Offset = "0x1EBAE0", VA = "0x1801EC6E0")]
		public NextExecutable(ExecutableNode node, InputPort port)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x15F7B70", Offset = "0x15F6B70", VA = "0x1815F7B70")]
		protected RandomNumberGeneratorNode(CircuitContext circuitContext, CircuitType numberType, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x15F7980", Offset = "0x15F6980", VA = "0x1815F7980", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal);

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x15F7A80", Offset = "0x15F6A80", VA = "0x1815F7A80")]
		private CircuitSignal ReturnRandom(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[Guid("FB2645F0-4042-4EF1-B988-AF2F80E651EC")]
	public class RandomIntegerGeneratorNode : RandomNumberGeneratorNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0x15F7760", Offset = "0x15F6760", VA = "0x1815F7760")]
		public RandomIntegerGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x15F7680", Offset = "0x15F6680", VA = "0x1815F7680", Slot = "24")]
		protected override CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[Guid("4ECBF247-AB14-4F9E-8094-E40A45D283E6")]
	public class RandomFloatGeneratorNode : RandomNumberGeneratorNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x15F7490", Offset = "0x15F6490", VA = "0x1815F7490")]
		public RandomFloatGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0x15F7350", Offset = "0x15F6350", VA = "0x1815F7350", Slot = "24")]
		protected override CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
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
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public InputPort NewValuePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0x1654220", Offset = "0x1653220", VA = "0x181654220")]
		public SetValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x1654110", Offset = "0x1653110", VA = "0x181654110", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[Guid("61BC2310-69F5-4DFA-B43C-12AE98DD05AB")]
	public class ShowNotificationNode : SingleExecutableNode
	{
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private static readonly Guid valuePortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private readonly InputPort valuePort;

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0x1654680", Offset = "0x1653680", VA = "0x181654680")]
		public ShowNotificationNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0x16544E0", Offset = "0x16534E0", VA = "0x1816544E0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
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
			[Cpp2IlInjected.Token(Token = "0x6000AE6")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract T GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6F30", Offset = "0x1AD5F30", VA = "0x181AD6F30")]
		public SwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x1AD63D0", Offset = "0x1AD53D0", VA = "0x181AD63D0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD5DD0", Offset = "0x1AD4DD0", VA = "0x181AD5DD0")]
		protected Dictionary<T, OutputPort> BuildCaseMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6490", Offset = "0x1AD5490", VA = "0x181AD6490", Slot = "18")]
		protected sealed override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract SwitchNodeData SerializeCaseLables(IEnumerable<T> caseLables);

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6240", Offset = "0x1AD5240", VA = "0x181AD6240", Slot = "19")]
		protected sealed override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(Slot = "26")]
		protected abstract IEnumerable<T> DeserializeCaseLables(SwitchNodeData protobufData);
	}
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[InternalNode]
	[Guid("543655EA-3A21-462B-9BD6-0460A45087E4")]
	public sealed class IntSwitchNode : SwitchNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		protected override CircuitType SwitchPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0x15EF4A0", Offset = "0x15EE4A0", VA = "0x1815EF4A0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x15EF340", Offset = "0x15EE340", VA = "0x1815EF340", Slot = "24")]
		protected override int GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x15EF420", Offset = "0x15EE420", VA = "0x1815EF420")]
		public IntSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x15EF3A0", Offset = "0x15EE3A0", VA = "0x1815EF3A0", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<int> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x3DBAE0", Offset = "0x3DAAE0", VA = "0x1803DBAE0", Slot = "26")]
		protected override IEnumerable<int> DeserializeCaseLables(SwitchNodeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[InternalNode]
	[Guid("C273CBC2-0EE4-4CE2-B960-C16760B273F1")]
	public sealed class StringSwitchNode : SwitchNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000205")]
		protected override CircuitType SwitchPortType
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFA")]
			[Cpp2IlInjected.Address(RVA = "0x1655690", Offset = "0x1654690", VA = "0x181655690", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x1655530", Offset = "0x1654530", VA = "0x181655530", Slot = "24")]
		protected override string GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x1655610", Offset = "0x1654610", VA = "0x181655610")]
		public StringSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x1655590", Offset = "0x1654590", VA = "0x181655590", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<string> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x3DB970", Offset = "0x3DA970", VA = "0x1803DB970", Slot = "26")]
		protected override IEnumerable<string> DeserializeCaseLables(SwitchNodeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	public interface IEditableNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		CircuitContext InnerContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0x15F1560", Offset = "0x15F0560", VA = "0x1815F1560")]
		public MultiInputBooleanLogicNode(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x15F1360", Offset = "0x15F0360", VA = "0x1815F1360")]
		private CircuitSignal GetBooleanReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool GetBooleanReturnInternal(List<bool> bools);
	}
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[Guid("3FB9FD93-8D45-4395-B9A3-63A99A14442B")]
	public class AndNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0x15E1EA0", Offset = "0x15E0EA0", VA = "0x1815E1EA0")]
		public AndNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x15E1DB0", Offset = "0x15E0DB0", VA = "0x1815E1DB0", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[Guid("B5DCDED0-EB2B-468D-A4B9-FFB1054F6214")]
	public class OrNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x15F5F50", Offset = "0x15F4F50", VA = "0x1815F5F50")]
		public OrNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x15F5E60", Offset = "0x15F4E60", VA = "0x1815F5E60", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[Guid("502E86D1-5B3A-4213-97E2-DF25836FFCC4")]
	public class NANDNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x15F1CE0", Offset = "0x15F0CE0", VA = "0x1815F1CE0")]
		public NANDNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x15F1BF0", Offset = "0x15F0BF0", VA = "0x1815F1BF0", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[Guid("2891BCB4-A6AB-4A2E-A08D-DD2A55F1CF66")]
	public class NORNode : MultiInputBooleanLogicNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x15F1E70", Offset = "0x15F0E70", VA = "0x1815F1E70")]
		public NORNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x15F1D80", Offset = "0x15F0D80", VA = "0x1815F1D80", Slot = "22")]
		protected override bool GetBooleanReturnInternal(List<bool> bools)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[NodeTag("Boolean Logic", new string[] { })]
	[Guid("FF551243-BEB4-470E-AB48-9D616818D5E4")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B1B")]
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x15F49B0", Offset = "0x15F39B0", VA = "0x1815F49B0")]
		public NotNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x15F4880", Offset = "0x15F3880", VA = "0x1815F4880")]
		private CircuitSignal GetNotValue(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
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

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x15ECD40", Offset = "0x15EBD40", VA = "0x1815ECD40")]
		public IfExpressionNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x15ECB70", Offset = "0x15EBB70", VA = "0x1815ECB70")]
		private CircuitSignal GetResult(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
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

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x15EFBD0", Offset = "0x15EEBD0", VA = "0x1815EFBD0")]
		public MakeDictionaryNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x15EFA80", Offset = "0x15EEA80", VA = "0x1815EFA80")]
		private CircuitSignal Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x15E1650", Offset = "0x15E0650", VA = "0x1815E1650")]
		public AbsoluteValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x15E14B0", Offset = "0x15E04B0", VA = "0x1815E14B0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x15E13C0", Offset = "0x15E03C0", VA = "0x1815E13C0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x15E12C0", Offset = "0x15E02C0", VA = "0x1815E12C0")]
		private CircuitSignal GetFloatReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[Guid("0CCB153C-DD08-4F22-80FD-9D8C5940928C")]
	public class AddNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x15E1D10", Offset = "0x15E0D10", VA = "0x1815E1D10")]
		public AddNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x15E1B50", Offset = "0x15E0B50", VA = "0x1815E1B50", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x15E1B40", Offset = "0x15E0B40", VA = "0x1815E1B40", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[Guid("F2EAFD78-5F23-44C9-A271-8FF2F0762E71")]
	public class DivideNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x15E6920", Offset = "0x15E5920", VA = "0x1815E6920")]
		public DivideNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x15E66F0", Offset = "0x15E56F0", VA = "0x1815E66F0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x15E68F0", Offset = "0x15E58F0", VA = "0x1815E68F0")]
		private static int SafeDivide(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x15E6530", Offset = "0x15E5530", VA = "0x1815E6530", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x15E68D0", Offset = "0x15E58D0", VA = "0x1815E68D0")]
		private static float SafeDivide(float numerator, float divisor)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[Guid("FE462E79-9E9F-4234-B594-7B6C0A69329B")]
	public class ModuloNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x15F12C0", Offset = "0x15F02C0", VA = "0x1815F12C0")]
		public ModuloNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x15F10B0", Offset = "0x15F00B0", VA = "0x1815F10B0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x15F12A0", Offset = "0x15F02A0", VA = "0x1815F12A0")]
		private static int SafeModulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x15F0EE0", Offset = "0x15EFEE0", VA = "0x1815F0EE0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x15F1280", Offset = "0x15F0280", VA = "0x1815F1280")]
		private static float SafeModulo(float numerator, float divisor)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[Guid("4738D696-D05A-42EE-A182-7641C429AE06")]
	public class MultiplyNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x15F1B50", Offset = "0x15F0B50", VA = "0x1815F1B50")]
		public MultiplyNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x15F19C0", Offset = "0x15F09C0", VA = "0x1815F19C0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x15F1820", Offset = "0x15F0820", VA = "0x1815F1820", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[Guid("288D4E89-EBED-41ED-A522-4C79BD48471A")]
	public class PowerNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x15F65D0", Offset = "0x15F55D0", VA = "0x1815F65D0")]
		public PowerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x15F6520", Offset = "0x15F5520", VA = "0x1815F6520", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x15F6470", Offset = "0x15F5470", VA = "0x1815F6470", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[Guid("1FBB364C-1AF0-44BB-A82B-905CAEB6819A")]
	public class SubtractNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x16558A0", Offset = "0x16548A0", VA = "0x1816558A0")]
		public SubtractNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x16557C0", Offset = "0x16547C0", VA = "0x1816557C0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x16556E0", Offset = "0x16546E0", VA = "0x1816556E0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[Guid("1CB807B1-85E7-4C14-B3AE-5775B7873B7D")]
	public class MaxNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x15F0C50", Offset = "0x15EFC50", VA = "0x1815F0C50")]
		public MaxNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x15F0C40", Offset = "0x15EFC40", VA = "0x1815F0C40", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x15F0C30", Offset = "0x15EFC30", VA = "0x1815F0C30", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[Guid("BFB1AD17-5ADE-4BD8-9C31-6D4B1E47DAE3")]
	public class MinNode : NumberNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x15F0D10", Offset = "0x15EFD10", VA = "0x1815F0D10")]
		public MinNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x15F0D00", Offset = "0x15EFD00", VA = "0x1815F0D00", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x15F0CF0", Offset = "0x15EFCF0", VA = "0x1815F0CF0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x15F5A30", Offset = "0x15F4A30", VA = "0x1815F5A30")]
		public NumberNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount, int maxPortCount = int.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x15F5890", Offset = "0x15F4890", VA = "0x1815F5890", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x15F56F0", Offset = "0x15F46F0", VA = "0x1815F56F0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x15F55A0", Offset = "0x15F45A0", VA = "0x1815F55A0")]
		private CircuitSignal GetFloatReturn(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract int CalculateIntValue(IList<int> signals);

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract float CalculateFloatValue(IList<float> signals);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0x39CE10", Offset = "0x39BE10", VA = "0x18039CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x16550C0", Offset = "0x16540C0", VA = "0x1816550C0")]
		public StringFormatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x1654CB0", Offset = "0x1653CB0", VA = "0x181654CB0")]
		private CircuitSignal GetOutputString(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	public abstract class ExternalVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		protected IExternalVariableNodeImplementation ExternalImplementation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x15E9310", Offset = "0x15E8310", VA = "0x1815E9310")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x15E9220", Offset = "0x15E8220", VA = "0x1815E9220", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x15E9130", Offset = "0x15E8130", VA = "0x1815E9130", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	public abstract class ExternalVariableNode<TVal> : ExternalVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x1ACD3A0", Offset = "0x1ACC3A0", VA = "0x181ACD3A0")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	public interface IExternalVariableNodeImplementation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitSignal GetValue();

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SetValue(CircuitSignal newValue);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	public interface IVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterChangeListener(IVariableChangeListener changeListener);

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UnregisterChangeListener(IVariableChangeListener changeListener);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	public abstract class InMemoryVariableNode : VariableNodeBase, IVariableChangeListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private Memory.IMemoryHandle _memoryHandle;

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public bool IsSymbolicName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x5DEBB0", Offset = "0x5DDBB0", VA = "0x1805DEBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x7C9460", Offset = "0x7C8460", VA = "0x1807C9460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x8ABEA0", Offset = "0x8AAEA0", VA = "0x1808ABEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected Memory.IMemoryHandle MemoryHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x46F0C0", Offset = "0x46E0C0", VA = "0x18046F0C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x15ED570", Offset = "0x15EC570", VA = "0x1815ED570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		internal Guid MemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x15ED470", Offset = "0x15EC470", VA = "0x1815ED470")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		protected Guid DefaultMemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x15ED380", Offset = "0x15EC380", VA = "0x1815ED380")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x15ED2E0", Offset = "0x15EC2E0", VA = "0x1815ED2E0")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x15ED220", Offset = "0x15EC220", VA = "0x1815ED220", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF010", Offset = "0x1ACE010", VA = "0x181ACF010")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		private string AllocateVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF470", Offset = "0x1ACE470", VA = "0x181ACF470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x1ACEE70", Offset = "0x1ACDE70", VA = "0x181ACEE70")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE150", Offset = "0x1ACD150", VA = "0x181ACE150", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract Memory.IMemoryHandle Allocate(Guid defaultAddress, string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE6D0", Offset = "0x1ACD6D0", VA = "0x181ACE6D0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDF10", Offset = "0x1ACCF10", VA = "0x181ACDF10", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE430", Offset = "0x1ACD430", VA = "0x181ACE430", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDFE0", Offset = "0x1ACCFE0", VA = "0x181ACDFE0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x1ACEB50", Offset = "0x1ACDB50", VA = "0x181ACEB50", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE0C0", Offset = "0x1ACD0C0", VA = "0x181ACE0C0", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[InternalNode]
	[Guid("D7224807-99D3-428A-B3F0-DF50CC96FE21")]
	public class BoolExternalVariableNode : ExternalVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x15E1F40", Offset = "0x15E0F40", VA = "0x1815E1F40")]
		public BoolExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[InternalNode]
	[Guid("B8295B54-B9AD-4D99-A8BC-77BED41D1F54")]
	public class IntExternalVariableNode : ExternalVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x15EF180", Offset = "0x15EE180", VA = "0x1815EF180")]
		public IntExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[InternalNode]
	[Guid("8B2531DC-2C87-4300-834F-6CA9AD19F62A")]
	public class FloatExternalVariableNode : ExternalVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x15E93B0", Offset = "0x15E83B0", VA = "0x1815E93B0")]
		public FloatExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[InternalNode]
	[Guid("04088018-9D4B-458E-9B5F-AA2DF1605D7C")]
	[NodeTag("String", new string[] { })]
	public class StringExternalVariableNode : ExternalVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x1654C20", Offset = "0x1653C20", VA = "0x181654C20")]
		public StringExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[NodeTag("Networking", new string[] { })]
	public abstract class SyncedInMemoryVariableNode<T> : InMemoryVariableNode<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7C80", Offset = "0x1AD6C80", VA = "0x181AD7C80")]
		protected SyncedInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[Guid("1A5331BC-5025-487E-898C-3C49EE715664")]
	public class IntInMemoryVariableNode : InMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x15EF210", Offset = "0x15EE210", VA = "0x1815EF210", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x15EF260", Offset = "0x15EE260", VA = "0x1815EF260")]
		public IntInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[Guid("3EE1EDFE-5520-4714-862B-98AF90F6E3DA")]
	public class PlayerInMemoryVariableNode : InMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x15EF210", Offset = "0x15EE210", VA = "0x1815EF210", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x15F60A0", Offset = "0x15F50A0", VA = "0x1815F60A0")]
		public PlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x15F6050", Offset = "0x15F5050", VA = "0x1815F6050")]
		private static bool SetPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x15F5FF0", Offset = "0x15F4FF0", VA = "0x1815F5FF0")]
		private static CircuitSignal GetPlayer(Memory memory, Guid memoryAddress)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[Guid("DDC89F58-D8F2-49DE-AF34-332382D8BB71")]
	public class SynchedPlayerInMemoryVariableNode : SyncedInMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x1655CB0", Offset = "0x1654CB0", VA = "0x181655CB0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x1656110", Offset = "0x1655110", VA = "0x181656110")]
		public SynchedPlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x16560C0", Offset = "0x16550C0", VA = "0x1816560C0")]
		private static bool SetSynchedPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x1656060", Offset = "0x1655060", VA = "0x181656060")]
		private static CircuitSignal GetSyncedPlayer(Memory memory, Guid memoryAddress)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[Guid("DD96FD78-C47B-4CCC-9D6B-23DA2F3F7987")]
	public class SyncedInMemoryIntVariableNode : SyncedInMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x1655CB0", Offset = "0x1654CB0", VA = "0x181655CB0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x1655D00", Offset = "0x1654D00", VA = "0x181655D00")]
		public SyncedInMemoryIntVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[Guid("DCE27FE2-ABC2-4A6A-9C4E-5D829A5B83A6")]
	public class FloatInMemoryVariableNode : InMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x15E9440", Offset = "0x15E8440", VA = "0x1815E9440", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x15E9490", Offset = "0x15E8490", VA = "0x1815E9490")]
		public FloatInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[Guid("56DCF860-9C74-4213-8859-45ABA0B96D43")]
	public class SyncedInMemoryFloatVariableNode : SyncedInMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x1655B80", Offset = "0x1654B80", VA = "0x181655B80", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x1655BD0", Offset = "0x1654BD0", VA = "0x181655BD0")]
		public SyncedInMemoryFloatVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Guid("8065D557-B6CC-4DD1-8CFA-B7481FE7BCF1")]
	public class BoolInMemoryVariableNode : InMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x15E1FD0", Offset = "0x15E0FD0", VA = "0x1815E1FD0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x15E2020", Offset = "0x15E1020", VA = "0x1815E2020")]
		public BoolInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[Guid("1E2CA8E7-037F-4A1A-82A7-62B81928B6A4")]
	public class SyncedInMemoryBoolVariableNode : SyncedInMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x1655A50", Offset = "0x1654A50", VA = "0x181655A50", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x1655AA0", Offset = "0x1654AA0", VA = "0x181655AA0")]
		public SyncedInMemoryBoolVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	[Guid("797913DF-1BCF-4280-8666-F17D7782CEBB")]
	public class StringInMemoryVariableNode : InMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x16553D0", Offset = "0x16543D0", VA = "0x1816553D0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1655450", Offset = "0x1654450", VA = "0x181655450")]
		public StringInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	[Guid("62F1B8B1-F1D3-4CEB-B0E9-57C4915BF401")]
	public class SyncedInMemoryStringVariableNode : SyncedInMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x1655DE0", Offset = "0x1654DE0", VA = "0x181655DE0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x1655E60", Offset = "0x1654E60", VA = "0x181655E60")]
		public SyncedInMemoryStringVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B95")]
			[Cpp2IlInjected.Address(RVA = "0x39CE20", Offset = "0x39BE20", VA = "0x18039CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x16573E0", Offset = "0x16563E0", VA = "0x1816573E0")]
		public ValueChangedNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x1656F20", Offset = "0x1655F20", VA = "0x181656F20", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x1657090", Offset = "0x1656090", VA = "0x181657090", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x1657230", Offset = "0x1656230", VA = "0x181657230", Slot = "23")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x16572A0", Offset = "0x16562A0", VA = "0x1816572A0")]
		private void UnregisterListeningNode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x16570E0", Offset = "0x16560E0", VA = "0x1816570E0")]
		private void OnIsConnectedChanged(bool isConnected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x16570E0", Offset = "0x16560E0", VA = "0x1816570E0")]
		private void UpdateListener()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x39CE10", Offset = "0x39BE10", VA = "0x18039CE10", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x1657B00", Offset = "0x1656B00", VA = "0x181657B00")]
		protected VariableNodeBase(CircuitContext circuitContext, Guid nodeId, CircuitType portType, bool canSet = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract void Set(CircuitSignal value);

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		protected abstract CircuitSignal Get(IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x1657840", Offset = "0x1656840", VA = "0x181657840", Slot = "27")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x16579E0", Offset = "0x16569E0", VA = "0x1816579E0", Slot = "22")]
		public void RegisterChangeListener(IVariableChangeListener changeListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x1657A40", Offset = "0x1656A40", VA = "0x181657A40", Slot = "23")]
		public void UnregisterChangeListener(IVariableChangeListener changeListener)
		{
		}
	}
}
namespace CircuitsV2.Graph.Nodes.TypeConversions
{
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
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

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x1652E60", Offset = "0x1651E60", VA = "0x181652E60")]
		protected ParsingNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x1652BF0", Offset = "0x1651BF0", VA = "0x181652BF0", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal);
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Guid("00B49995-A322-47A3-A32B-5530F2BA7FED")]
	public class ParseIntNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x1652A80", Offset = "0x1651A80", VA = "0x181652A80")]
		public ParseIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x1652A00", Offset = "0x1651A00", VA = "0x181652A00", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Guid("5E25F40A-2B8C-4327-A89C-7A749838DA7D")]
	public class ParseFloatNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x1652890", Offset = "0x1651890", VA = "0x181652890")]
		public ParseFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x1652810", Offset = "0x1651810", VA = "0x181652810", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Guid("92C05EBC-1967-49A4-94B5-2D01FE1E6B85")]
	public class ParseBoolNode : ParsingNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x16526A0", Offset = "0x16516A0", VA = "0x1816526A0")]
		public ParseBoolNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x16525D0", Offset = "0x16515D0", VA = "0x1816525D0", Slot = "25")]
		protected override bool ConvertInternal(CircuitSignal inputSignal, out CircuitSignal convertedSignal)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x3E1470", Offset = "0x3E0470", VA = "0x1803E1470", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public OutputPort ValueOutputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x39CE30", Offset = "0x39BE30", VA = "0x18039CE30", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x1656350", Offset = "0x1655350", VA = "0x181656350")]
		protected TypeConversionNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x1656220", Offset = "0x1655220", VA = "0x181656220")]
		private CircuitSignal GetAndConvert(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal Convert(CircuitSignal inputSignal);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E1")]
	[Guid("65CFBA8A-B5DC-4946-B824-E6EFC5719F3A")]
	public class IntToFloatNode : TypeConversionNode, ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x1651290", Offset = "0x1650290", VA = "0x181651290")]
		public IntToFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x1651250", Offset = "0x1650250", VA = "0x181651250", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E2")]
	[NodeTag("Math", new string[] { })]
	public abstract class FloatToIntConversionNodeBase : TypeConversionNode, ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x1650F50", Offset = "0x164FF50", VA = "0x181650F50")]
		protected FloatToIntConversionNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x1650DC0", Offset = "0x164FDC0", VA = "0x181650DC0", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x1650CF0", Offset = "0x164FCF0", VA = "0x181650CF0")]
		private float ClampToIntRange(float floatValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract int ConvertInternal(float clampedInput);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[Guid("BC451CAB-2292-4E60-832D-31060EB82BD0")]
	public class FloorToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x1641FC0", Offset = "0x1640FC0", VA = "0x181641FC0")]
		public FloorToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x16510C0", Offset = "0x16500C0", VA = "0x1816510C0", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	[Guid("38B502DC-DD35-4083-A2B0-8A8E5F69A958")]
	public class CeilToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x1641FC0", Offset = "0x1640FC0", VA = "0x181641FC0")]
		public CeilToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x1641F60", Offset = "0x1640F60", VA = "0x181641F60", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[Guid("0D2A4771-0694-4B84-8E07-2080C26AAE22")]
	public class RoundToIntNode : FloatToIntConversionNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x1641FC0", Offset = "0x1640FC0", VA = "0x181641FC0")]
		public RoundToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x16540B0", Offset = "0x16530B0", VA = "0x1816540B0", Slot = "25")]
		protected override int ConvertInternal(float input)
		{
			return default(int);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.PureNodes.TypeConversions
{
	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	public interface ITypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000218")]
		InputPort ValueInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		OutputPort ValueOutputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
namespace CircuitsV2.Graph.Nodes.NumberComparisons
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
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
			[Cpp2IlInjected.Token(Token = "0x6000BC6")]
			[Cpp2IlInjected.Address(RVA = "0x39CE10", Offset = "0x39BE10", VA = "0x18039CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x15F5060", Offset = "0x15F4060", VA = "0x1815F5060")]
		public NumberComparisonNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x15F4E90", Offset = "0x15F3E90", VA = "0x1815F4E90", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x15F4C60", Offset = "0x15F3C60", VA = "0x1815F4C60")]
		private CircuitSignal CalculateReturnValueFloat(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x15F4D80", Offset = "0x15F3D80", VA = "0x1815F4D80")]
		private CircuitSignal CalculateReturnValueInt(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool CalculateReturnValueInternal(float signalA, float signalB);

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract bool CalculateReturnValueInternal(int signalA, int signalB);
	}
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[Guid("110C29B1-AC90-4A71-B3C0-53372AA134BC")]
	public class GreaterThanNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x15EC4E0", Offset = "0x15EB4E0", VA = "0x1815EC4E0")]
		public GreaterThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x15EC450", Offset = "0x15EB450", VA = "0x1815EC450", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x15EC440", Offset = "0x15EB440", VA = "0x1815EC440", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	[Guid("7E58B3F4-2694-4CED-B3A8-0FE23F48F60F")]
	public class LessThanNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x15EF6E0", Offset = "0x15EE6E0", VA = "0x1815EF6E0")]
		public LessThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x15EF650", Offset = "0x15EE650", VA = "0x1815EF650", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x15EF640", Offset = "0x15EE640", VA = "0x1815EF640", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Guid("A10E7788-F016-4390-A68E-87D93B47EDB1")]
	public class GreaterThanOrEqualNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x15EC610", Offset = "0x15EB610", VA = "0x1815EC610")]
		public GreaterThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x15EC570", Offset = "0x15EB570", VA = "0x1815EC570", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x15EC600", Offset = "0x15EB600", VA = "0x1815EC600", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	[Guid("A027073F-9189-457F-A53D-8562E8829DAF")]
	public class LessThanOrEqualNode : NumberComparisonNodeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x15EF810", Offset = "0x15EE810", VA = "0x1815EF810")]
		public LessThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x15EF770", Offset = "0x15EE770", VA = "0x1815EF770", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x15EF800", Offset = "0x15EE800", VA = "0x1815EF800", Slot = "23")]
		protected override bool CalculateReturnValueInternal(int signalA, int signalB)
		{
			return default(bool);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.DemoNodes
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[Guid("3663225D-E18D-40E6-A234-EF10378528BE")]
	[NodeTag("Comparison", new string[] { })]
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

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x15E7340", Offset = "0x15E6340", VA = "0x1815E7340")]
		public EqualsNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x15E70A0", Offset = "0x15E60A0", VA = "0x1815E70A0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x15E70D0", Offset = "0x15E60D0", VA = "0x1815E70D0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x15E6AC0", Offset = "0x15E5AC0", VA = "0x1815E6AC0")]
		private OutputPortGetDelegate GetDelegateForType(CircuitType specificType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x15E6EB0", Offset = "0x15E5EB0", VA = "0x1815E6EB0")]
		private CircuitSignal GetReferenceEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x15E6F90", Offset = "0x15E5F90", VA = "0x1815E6F90")]
		private CircuitSignal GetStringEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x15E6C50", Offset = "0x15E5C50", VA = "0x1815E6C50")]
		private CircuitSignal GetFloatEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x15E6DB0", Offset = "0x15E5DB0", VA = "0x1815E6DB0")]
		private CircuitSignal GetIntEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x15E69C0", Offset = "0x15E59C0", VA = "0x1815E69C0")]
		private CircuitSignal GetBooleanEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x15E6C10", Offset = "0x15E5C10", VA = "0x1815E6C10")]
		private CircuitSignal GetFalse(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	[Guid("74E81EDB-84BD-4E52-B2F3-A73A62A6B3AA")]
	[NodeTag("String", new string[] { })]
	public class ToStringNode : TypeConversionNode
	{
		[Cpp2IlInjected.Token(Token = "0x20001EE")]
		private delegate CircuitSignal ConvertFunc(CircuitContext context, CircuitSignal inputSignal);

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private ConvertFunc convertFunc;

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x15F88E0", Offset = "0x15F78E0", VA = "0x1815F88E0")]
		public ToStringNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x15E70A0", Offset = "0x15E60A0", VA = "0x1815E70A0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x15F8740", Offset = "0x15F7740", VA = "0x1815F8740", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x15F8360", Offset = "0x15F7360", VA = "0x1815F8360")]
		private ConvertFunc GetDelegateForType(CircuitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x15F85D0", Offset = "0x15F75D0", VA = "0x1815F85D0")]
		private CircuitSignal GetPlayerToString(CircuitContext context, CircuitSignal inputsignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x15F8290", Offset = "0x15F7290", VA = "0x1815F8290", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x15F86D0", Offset = "0x15F76D0", VA = "0x1815F86D0")]
		private static CircuitSignal GetReferenceToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x15F8720", Offset = "0x15F7720", VA = "0x1815F8720")]
		private static CircuitSignal GetStringToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x15F8510", Offset = "0x15F7510", VA = "0x1815F8510")]
		private static CircuitSignal GetFloatToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x15F8570", Offset = "0x15F7570", VA = "0x1815F8570")]
		private static CircuitSignal GetIntToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x15F8300", Offset = "0x15F7300", VA = "0x1815F8300")]
		private static CircuitSignal GetBooleanToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x15F84D0", Offset = "0x15F74D0", VA = "0x1815F84D0")]
		private static CircuitSignal GetEmpty(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
}
namespace CircuitsV2.Graph.Nodes.PlayerNodes
{
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	[NodeTag("Player", new string[] { })]
	[Guid("EBF08E8A-9786-4368-AA64-FD0B480F593A")]
	public class InvalidPlayerVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private readonly CircuitSignal invalidPlayerSignal;

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x15EF540", Offset = "0x15EE540", VA = "0x1815EF540")]
		public InvalidPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x15EF4F0", Offset = "0x15EE4F0", VA = "0x1815EF4F0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xC5BF10", Offset = "0xC5AF10", VA = "0x180C5BF10", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F0")]
	[Guid("FDF733A8-BDD6-4800-B1D4-95B06B3D6F02")]
	[NodeTag("Player", new string[] { })]
	public class LocalPlayerVariableNode : VariableNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private readonly CircuitSignal localPlayerSignal;

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x15EF8F0", Offset = "0x15EE8F0", VA = "0x1815EF8F0")]
		public LocalPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x15EF8A0", Offset = "0x15EE8A0", VA = "0x1815EF8A0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0xC5BF10", Offset = "0xC5AF10", VA = "0x180C5BF10", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F1")]
	[Guid("4646DBED-E616-470E-8E0C-EB446B91838B")]
	[NodeTag("Player", new string[] { })]
	public class GetPlayerIsLocalNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x15EBDD0", Offset = "0x15EADD0", VA = "0x1815EBDD0")]
		public GetPlayerIsLocalNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x15EBCD0", Offset = "0x15EACD0", VA = "0x1815EBCD0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F2")]
	[Guid("949B77E7-1F65-4F5B-A46B-F4E7B81F7A08")]
	[NodeTag("Player", new string[] { })]
	public class GetPlayerNameNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x15EC000", Offset = "0x15EB000", VA = "0x1815EC000")]
		public GetPlayerNameNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x15EBF60", Offset = "0x15EAF60", VA = "0x1815EBF60", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F3")]
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

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x15EAE30", Offset = "0x15E9E30", VA = "0x1815EAE30")]
		public GetAllPlayersNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x15EADB0", Offset = "0x15E9DB0", VA = "0x1815EADB0")]
		private CircuitSignal GetPlayerList(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x15EACD0", Offset = "0x15E9CD0", VA = "0x1815EACD0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	[NodeTag("Player", new string[] { })]
	[Guid("46E6B40E-2416-4078-B7DC-A0ECC2C2AA20")]
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
			[Cpp2IlInjected.Token(Token = "0x6000C03")]
			[Cpp2IlInjected.Address(RVA = "0x46F0C0", Offset = "0x46E0C0", VA = "0x18046F0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public OutputPort PromptCompletePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x431C90", Offset = "0x430C90", VA = "0x180431C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		private OutputPort PromptFailedPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C05")]
			[Cpp2IlInjected.Address(RVA = "0x4703F0", Offset = "0x46F3F0", VA = "0x1804703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public OutputPort ResponsePort
		{
			[Cpp2IlInjected.Token(Token = "0x6000C06")]
			[Cpp2IlInjected.Address(RVA = "0x3A1220", Offset = "0x3A0220", VA = "0x1803A1220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x15F6CA0", Offset = "0x15F5CA0", VA = "0x1815F6CA0")]
		public PromptLocalPlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x15F6A20", Offset = "0x15F5A20", VA = "0x1815F6A20")]
		private CircuitSignal GetPromptResponse(IExecutionScope executionscope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x15F6730", Offset = "0x15F5730", VA = "0x1815F6730", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x15F6670", Offset = "0x15F5670", VA = "0x1815F6670")]
		private void ExecuteAfterPrompt(OutputPort fromPort)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[InternalNode]
	[Guid("163C326E-6BB9-428A-8837-FF507D948E93")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x16BA0", Offset = "0x15FA0")]
	public class GetPlayerHealthNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x15EBB40", Offset = "0x15EAB40", VA = "0x1815EBB40")]
		public GetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x15EBA20", Offset = "0x15EAA20", VA = "0x1815EBA20", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[InternalNode]
	[Guid("6B962C79-6BE2-4E2C-A517-BE998B58F9D1")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x16F90", Offset = "0x16390")]
	public class GetPlayerShieldNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x15EC2B0", Offset = "0x15EB2B0", VA = "0x1815EC2B0")]
		public GetPlayerShieldNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x15EC190", Offset = "0x15EB190", VA = "0x1815EC190", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F7")]
	[InternalNode]
	[Guid("67ACA89C-F753-4F94-87DF-1CE1D4FCB8B0")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x17520", Offset = "0x16920")]
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
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public InputPort DamageInputPortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x46F0C0", Offset = "0x46E0C0", VA = "0x18046F0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x15E55F0", Offset = "0x15E45F0", VA = "0x1815E55F0")]
		public DamagePlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x15E53B0", Offset = "0x15E43B0", VA = "0x1815E53B0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x17E20", Offset = "0x17220")]
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
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0x39CBF0", Offset = "0x39BBF0", VA = "0x18039CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x15F8090", Offset = "0x15F7090", VA = "0x1815F8090")]
		public ResetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x15F7F20", Offset = "0x15F6F20", VA = "0x1815F7F20", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
}
namespace CircuitsV2.Networking
{
	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	public abstract class CircuitNetworking : ICircuitContextNetworking, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private bool isDisposed;

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public IRPCSender RpcSender
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0x37F190", Offset = "0x37E190", VA = "0x18037F190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x3935A0", Offset = "0x3925A0", VA = "0x1803935A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public abstract bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public abstract bool IsAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x11A0E60", Offset = "0x119FE60", VA = "0x1811A0E60")]
		protected CircuitNetworking(IRPCSender rpcSender, IContextSynchronizedFieldFactory synchronizedFieldFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x1647D10", Offset = "0x1646D10", VA = "0x181647D10", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace CircuitsV2.Networking.Timing
{
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	public interface ITimeProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		float CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000C21")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
namespace CircuitsV2.Networking.Notifications
{
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	public interface INotificationProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PlayNotification(string notification);
	}
}
namespace CircuitsV2.Networking.InventionTracking
{
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	public interface IInventionTracking
	{
		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool GetTrackedData(string key, out Guid instanceId, out long inventionId, out int versionNumber, out bool wasPartOfInvention);

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetTrackedData(string key, Guid instanceId, long inventionId, int versionNumber, bool wasPartOfInvention);

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EnsureTrackingRegistered(string key);

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ForgetTrackedKey(string key);
	}
}
namespace CircuitsV2.Networking.BuiltInEvents
{
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x16418D0", Offset = "0x16408D0", VA = "0x1816418D0")]
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
