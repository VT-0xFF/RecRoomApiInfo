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
	[Cpp2IlInjected.Address(RVA = "0x2C88DE0", Offset = "0x2C873E0", VA = "0x182C88DE0")]
	public static Guid ToGuid(this ByteString bytes)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C88C20", Offset = "0x2C87220", VA = "0x182C88C20")]
	public static ByteString ToByteString(this Guid guid)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C88F70", Offset = "0x2C87570", VA = "0x182C88F70")]
	public static Guid? ToGuid(this NullableBytes bytes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C88D10", Offset = "0x2C87310", VA = "0x182C88D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EBAEC0", Offset = "0x1EB94C0", VA = "0x181EBAEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x151AA60", Offset = "0x1519060", VA = "0x18151AA60")]
		public RateLimitedSynchronizedField(SynchronizedField<T> internalField, T initialValue, RateLimiter rateLimiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x10AA4B0", Offset = "0x10A8AB0", VA = "0x1810AA4B0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x151A820", Offset = "0x1518E20", VA = "0x18151A820")]
		public bool Set(T newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x151A550", Offset = "0x1518B50", VA = "0x18151A550", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x151AEF0", Offset = "0x15194F0", VA = "0x18151AEF0")]
		public bool HasReferences(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x151B160", Offset = "0x1519760", VA = "0x18151B160")]
		public bool TryGetRefCount(TKey key, out int refCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x151AF80", Offset = "0x1519580", VA = "0x18151AF80")]
		public void IncrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x151AD00", Offset = "0x1519300", VA = "0x18151AD00")]
		public void DecrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x744FD0", Offset = "0x7435D0", VA = "0x180744FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C430", Offset = "0x1B830", VA = "0x18001C430")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C7A10", Offset = "0x7C6010", VA = "0x1807C7A10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7C7AB0", Offset = "0x7C60B0", VA = "0x1807C7AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C78D0", Offset = "0x7C5ED0", VA = "0x1807C78D0")]
		private ShortenedGuidMap(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FB0", Offset = "0x7C55B0", VA = "0x1807C6FB0")]
		public static ShortenedGuidMap FromRequiredCharacters(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C7110", Offset = "0x7C5710", VA = "0x1807C7110")]
		public string GetShortened(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C71F0", Offset = "0x7C57F0", VA = "0x1807C71F0")]
		private string GuidToShortenedString(Guid guid, int requiredCharacters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C75A0", Offset = "0x7C5BA0", VA = "0x1807C75A0")]
		private string RemapGuid(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C72D0", Offset = "0x7C58D0", VA = "0x1807C72D0")]
		private void RemapExisting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C7830", Offset = "0x7C5E30", VA = "0x1807C7830")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B5AA0", Offset = "0x7B40A0", VA = "0x1807B5AA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		private Base64GuidShortenerMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B5990", Offset = "0x7B3F90", VA = "0x1807B5990", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C60F0", Offset = "0x7C46F0", VA = "0x1807C60F0")]
		public static bool IsEmpty(this CircuitContextData contextData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AF10", Offset = "0x2C29510", VA = "0x182C2AF10")]
		private static bool IsRepeatedFieldEmpty<T>(RepeatedField<T> repeatedField)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C6410", Offset = "0x7C4A10", VA = "0x1807C6410")]
		internal static Vector3 ToVector3(this Vector3Data vector3Data)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C6360", Offset = "0x7C4960", VA = "0x1807C6360")]
		internal static Vector3Data ToVector3Data(this Vector3 vector3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C6260", Offset = "0x7C4860", VA = "0x1807C6260")]
		internal static Quaternion ToQuaternion(this QuaternionData quaternionData)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C61B0", Offset = "0x7C47B0", VA = "0x1807C61B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB30", Offset = "0x5FA130", VA = "0x1805FBB30")]
			[DebuggerHidden]
			public <DFS>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B20", Offset = "0x7C7120", VA = "0x1807C8B20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7C92F0", Offset = "0x7C78F0", VA = "0x1807C92F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7C9250", Offset = "0x7C7850", VA = "0x1807C9250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C9250", Offset = "0x7C7850", VA = "0x1807C9250", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B90", Offset = "0x7C3190", VA = "0x1807C4B90")]
		[IteratorStateMachine(typeof(<DFS>d__1))]
		public static IEnumerable<Node> DFS(Node root, DFSType dfsType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C10", Offset = "0x7C3210", VA = "0x1807C4C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0330", Offset = "0x3EE930", VA = "0x1803F0330")]
			public NotRestriction(params Type[] notTypes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5980", Offset = "0x7C3F80", VA = "0x1807C5980")]
			protected bool Equals(NotRestriction other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C59C0", Offset = "0x7C3FC0", VA = "0x1807C59C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3D6AA0", Offset = "0x3D50A0", VA = "0x1803D6AA0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2C35CC0", Offset = "0x2C342C0", VA = "0x182C35CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18E38A0", Offset = "0x18E1EA0", VA = "0x1818E38A0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2C8CC70", Offset = "0x2C8B270", VA = "0x182C8CC70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[NotNull]
		public Dependencies RecRoomDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3DEFB0", Offset = "0x3DD5B0", VA = "0x1803DEFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8C950", Offset = "0x2C8AF50", VA = "0x182C8C950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CircuitContext Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3DF050", Offset = "0x3DD650", VA = "0x1803DF050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3DF350", Offset = "0x3DD950", VA = "0x1803DF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitContextNode ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3DF100", Offset = "0x3DD700", VA = "0x1803DF100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3F0", Offset = "0x3DD9F0", VA = "0x1803DF3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8C9A0", Offset = "0x2C8AFA0", VA = "0x182C8C9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB04C80", Offset = "0xB03280", VA = "0x180B04C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CircuitContext, Node> OnCircuitNodeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C6D0", Offset = "0x2C8ACD0", VA = "0x182C8C6D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C9F0", Offset = "0x2C8AFF0", VA = "0x182C8C9F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C770", Offset = "0x2C8AD70", VA = "0x182C8C770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2C8CA90", Offset = "0x2C8B090", VA = "0x182C8CA90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<NodeConnection> OnNodesConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C810", Offset = "0x2C8AE10", VA = "0x182C8C810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2C8CB30", Offset = "0x2C8B130", VA = "0x182C8CB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NodeConnection> OnNodesDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C8B0", Offset = "0x2C8AEB0", VA = "0x182C8C8B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2C8CBD0", Offset = "0x2C8B1D0", VA = "0x182C8CBD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C4E0", Offset = "0x2C8AAE0", VA = "0x182C8C4E0")]
		protected CircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A1A0", Offset = "0x2C887A0", VA = "0x182C8A1A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2C892B0", Offset = "0x2C878B0", VA = "0x182C892B0")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AAE0", Offset = "0x2C890E0", VA = "0x182C8AAE0")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2C89020", Offset = "0x2C87620", VA = "0x182C89020")]
		protected void AddChildContext(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B550", Offset = "0x2C89B50", VA = "0x182C8B550")]
		public bool SendEvent(CircuitEvent circuitEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B580", Offset = "0x2C89B80", VA = "0x182C8B580")]
		public void SendSynchronizedEvent(CircuitEvent circuitEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AEC0", Offset = "0x2C894C0", VA = "0x182C8AEC0")]
		public void RequestCreateNewCircuitNode(Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B290", Offset = "0x2C89890", VA = "0x182C8B290")]
		public void RequestDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B0D0", Offset = "0x2C896D0", VA = "0x182C8B0D0")]
		public void RequestCreateNewDynamicEvent(string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B380", Offset = "0x2C89980", VA = "0x182C8B380")]
		public void RequestDestroyDynamicEvent(Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A960", Offset = "0x2C88F60", VA = "0x182C8A960")]
		public void LocalDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A930", Offset = "0x2C88F30", VA = "0x182C8A930")]
		public void LocalDestroyCircuitNode([NotNull] Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2C890C0", Offset = "0x2C876C0", VA = "0x182C890C0")]
		public void AddCircuitNode(Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BCA0", Offset = "0x2C8A2A0", VA = "0x182C8BCA0")]
		protected bool TryFindNodeViaGloballyUniqueIdInternal(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B5F0", Offset = "0x2C89BF0", VA = "0x182C8B5F0", Slot = "9")]
		public virtual CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2C89AE0", Offset = "0x2C880E0", VA = "0x182C89AE0")]
		internal void DeserializeTemplateData(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A610", Offset = "0x2C88C10", VA = "0x182C8A610")]
		internal void InferAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2C894F0", Offset = "0x2C87AF0", VA = "0x182C894F0", Slot = "10")]
		public virtual void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2C1ECB0", Offset = "0x2C1D2B0", VA = "0x182C1ECB0")]
		public bool TryFindNode<TNode>(Guid nodeId, out TNode node) where TNode : Node
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C030", Offset = "0x2C8A630", VA = "0x182C8C030")]
		public bool TryFindNode(Guid nodeId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BC30", Offset = "0x2C8A230", VA = "0x182C8BC30")]
		public bool TryFindChildContext(Guid childContextId, out CircuitContext childContext)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ADA0", Offset = "0x2C893A0", VA = "0x182C8ADA0")]
		public void RaiseOnCircuitNodesConnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AE30", Offset = "0x2C89430", VA = "0x182C8AE30")]
		public void RaiseOnCircuitNodesDisconnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2C89250", Offset = "0x2C87850", VA = "0x182C89250")]
		public void AddNodeRestriction(INodeRestriction nodeRestriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A900", Offset = "0x2C88F00", VA = "0x182C8A900")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF700", Offset = "0x3DDD00", VA = "0x1803DF700")]
			public EventRegistration(CircuitContext registeredToContext, CircuitEventDefinition eventDefinition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2C94A80", Offset = "0x2C93080", VA = "0x182C94A80")]
			public void AddCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2C94BA0", Offset = "0x2C931A0", VA = "0x182C94BA0")]
			public void RemoveCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2C94CE0", Offset = "0x2C932E0", VA = "0x182C94CE0", Slot = "5")]
			public EventRegistrationData SerializeToProtobuf()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xEB03F0", Offset = "0xEAE9F0", VA = "0x180EB03F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCB0D70", Offset = "0xCAF370", VA = "0x180CB0D70")]
			protected LimitedEventQueueBase(int maxEventsToProcessPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2D61540", Offset = "0x2D5FB40", VA = "0x182D61540")]
			public bool PushEvent(T queueEntry)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2D613E0", Offset = "0x2D5F9E0", VA = "0x182D613E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EDE0", Offset = "0x2C9D3E0", VA = "0x182C9EDE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x350D80", Offset = "0x350180", VA = "0x180350D80")]
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
				[Cpp2IlInjected.Address(RVA = "0x2C9C780", Offset = "0x2C9AD80", VA = "0x182C9C780", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			protected override Queue<CircuitEvent> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x2C9C790", Offset = "0x2C9AD90", VA = "0x182C9C790", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2C9C610", Offset = "0x2C9AC10", VA = "0x182C9C610")]
			public LocalEventQueue(ITimeProvider timeProvider, int maxEventsToProcessPerFrame = 1024)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C9C480", Offset = "0x2C9AA80", VA = "0x182C9C480")]
			public bool PushEventDelayed(CircuitEvent circuitEvent, float delay)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C9C2B0", Offset = "0x2C9A8B0", VA = "0x182C9C2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C94390", Offset = "0x2C92990", VA = "0x182C94390")]
			public void AddCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C94870", Offset = "0x2C92E70", VA = "0x182C94870")]
			public void RemoveCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2C94990", Offset = "0x2C92F90", VA = "0x182C94990")]
			private void RemoveHandlerInternal(Guid eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x2C944F0", Offset = "0x2C92AF0", VA = "0x182C944F0")]
			public void HandleEvent(CircuitEvent circuitEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x2C94490", Offset = "0x2C92A90", VA = "0x182C94490")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2C94A00", Offset = "0x2C93000", VA = "0x182C94A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8F300", Offset = "0x2C8D900", VA = "0x182C8F300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EFA0", Offset = "0x2C8D5A0", VA = "0x182C8EFA0")]
		public CircuitEventBus(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E530", Offset = "0x2C8CB30", VA = "0x182C8E530")]
		public EventRegistration RegisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EA10", Offset = "0x2C8D010", VA = "0x182C8EA10")]
		public EventRegistration RegisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E610", Offset = "0x2C8CC10", VA = "0x182C8E610")]
		private EventRegistration RegisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EF00", Offset = "0x2C8D500", VA = "0x182C8EF00")]
		public void UnregisterDynamicCircuitEvent(Guid circuitEventDefinitionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EF90", Offset = "0x2C8D590", VA = "0x182C8EF90")]
		public void UnregisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ED00", Offset = "0x2C8D300", VA = "0x182C8ED00")]
		public void UnregisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ED10", Offset = "0x2C8D310", VA = "0x182C8ED10")]
		private void UnregisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DC80", Offset = "0x2C8C280", VA = "0x182C8DC80")]
		public IEnumerable<EventRegistration> GetListenableEvents(bool onlyPlayerListenable = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D5A0", Offset = "0x2C8BBA0", VA = "0x182C8D5A0")]
		private IReadOnlyList<EventRegistration> GetAllListenableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D9C0", Offset = "0x2C8BFC0", VA = "0x182C8D9C0")]
		public EventRegistration GetListenableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DD80", Offset = "0x2C8C380", VA = "0x182C8DD80")]
		public EventRegistration GetSendableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DE50", Offset = "0x2C8C450", VA = "0x182C8DE50")]
		public IReadOnlyList<EventRegistration> GetSendableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E500", Offset = "0x2C8CB00", VA = "0x182C8E500")]
		public bool Publish(CircuitEvent outgoingEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E2E0", Offset = "0x2C8C8E0", VA = "0x182C8E2E0")]
		public bool PublishDelayed(CircuitEvent outgoingEvent, float delay)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E480", Offset = "0x2C8CA80", VA = "0x182C8E480")]
		public bool PublishSynced(CircuitEvent outgoingEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E200", Offset = "0x2C8C800", VA = "0x182C8E200")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E0C0", Offset = "0x2C8C6C0", VA = "0x182C8E0C0")]
		private void HandleLocalEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EA60", Offset = "0x2C8D060", VA = "0x182C8EA60")]
		private void SendSyncedEvent(Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets> circuitEventAndTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E0E0", Offset = "0x2C8C6E0", VA = "0x182C8E0E0")]
		public void HandleReceivedSyncedEvent(SynchronizedEventData syncedEventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CE70", Offset = "0x2C8B470", VA = "0x182C8CE70")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EB20", Offset = "0x2C8D120", VA = "0x182C8EB20", Slot = "6")]
		public EventBusData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D300", Offset = "0x2C8B900", VA = "0x182C8D300")]
		public void DeserializeFromTemplate(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D100", Offset = "0x2C8B700", VA = "0x182C8D100", Slot = "4")]
		public void DeserializeFromProtobuf(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D4D0", Offset = "0x2C8BAD0", VA = "0x182C8D4D0")]
		private void DestroyCircuitObjectFromProtoData(CircuitEventObject circuitEventObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CEE0", Offset = "0x2C8B4E0", VA = "0x182C8CEE0")]
		private CircuitEventObject CreateCircuitObjectFromProtoData(Guid eventId, CircuitEventObjectData protobufdata)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D500", Offset = "0x2C8BB00", VA = "0x182C8D500", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EC90", Offset = "0x2C8D290", VA = "0x182C8EC90")]
		public bool TryGetDynamicEventObject(Guid eventDefEventDefinitionId, out CircuitEventObject circuitEventObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E1A0", Offset = "0x2C8C7A0", VA = "0x182C8E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C91840", Offset = "0x2C8FE40", VA = "0x182C91840")]
		public CircuitEvent(Guid circuitEventTypeGuid, CircuitEventDefinition eventDefinition, IReadOnlyDictionary<string, CircuitSignal> signals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C90EF0", Offset = "0x2C8F4F0", VA = "0x182C90EF0")]
		public SynchronizedEventData Pack()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C913F0", Offset = "0x2C8F9F0", VA = "0x182C913F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C942E0", Offset = "0x2C928E0", VA = "0x182C942E0")]
			public EventBuilder(CircuitEventDefinition definition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2C94240", Offset = "0x2C92840", VA = "0x182C94240")]
			public EventBuilder WithSignal(string signalName, CircuitSignal signal)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2C94140", Offset = "0x2C92740", VA = "0x182C94140")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C8FD80", Offset = "0x2C8E380", VA = "0x182C8FD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CircuitType> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnDefinitionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2C8FC40", Offset = "0x2C8E240", VA = "0x182C8FC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2C8FCE0", Offset = "0x2C8E2E0", VA = "0x182C8FCE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FB80", Offset = "0x2C8E180", VA = "0x182C8FB80")]
		public CircuitEventDefinition(string name, Guid eventDefinitionId, bool isPlayerListenable = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F710", Offset = "0x2C8DD10", VA = "0x182C8F710")]
		private bool Equals(CircuitEventDefinition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F610", Offset = "0x2C8DC10", VA = "0x182C8F610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F750", Offset = "0x2C8DD50", VA = "0x182C8F750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xCABB30", Offset = "0xCAA130", VA = "0x180CABB30")]
		public static bool operator !=(CircuitEventDefinition left, CircuitEventDefinition right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F350", Offset = "0x2C8D950", VA = "0x182C8F350")]
		[EditableAddNamedPort(null)]
		public CircuitEventDefinition AddEventPropertyLocal(string name, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F840", Offset = "0x2C8DE40", VA = "0x182C8F840")]
		public CircuitEventDefinition RemoveEventPropertyLocal(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F8E0", Offset = "0x2C8DEE0", VA = "0x182C8F8E0", Slot = "5")]
		public CircuitEventDefinitionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F3F0", Offset = "0x2C8D9F0", VA = "0x182C8F3F0", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitEventDefinitionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F770", Offset = "0x2C8DD70", VA = "0x182C8F770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C90DA0", Offset = "0x2C8F3A0", VA = "0x182C90DA0")]
		public CircuitEventObject(CircuitContext context, CircuitEventDefinition definition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C90650", Offset = "0x2C8EC50", VA = "0x182C90650")]
		private bool Equals(CircuitEventObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C90690", Offset = "0x2C8EC90", VA = "0x182C90690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C907A0", Offset = "0x2C8EDA0", VA = "0x182C907A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C907D0", Offset = "0x2C8EDD0", VA = "0x182C907D0")]
		public void RequestAddEventProperty(string name, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C90940", Offset = "0x2C8EF40", VA = "0x182C90940")]
		public void RequestRemoveEventProperty(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C90A70", Offset = "0x2C8F070", VA = "0x182C90A70", Slot = "10")]
		public override CircuitEventObjectData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C90220", Offset = "0x2C8E820", VA = "0x182C90220", Slot = "11")]
		public override void DeserializeFromProtobuf(CircuitEventObjectData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C905B0", Offset = "0x2C8EBB0", VA = "0x182C905B0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C90D50", Offset = "0x2C8F350", VA = "0x182C90D50", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C90130", Offset = "0x2C8E730", VA = "0x182C90130", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C90120", Offset = "0x2C8E720", VA = "0x182C90120")]
		public CircuitEventObjectModificationHandler(CircuitEventObject modifiedEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FDC0", Offset = "0x2C8E3C0", VA = "0x182C8FDC0")]
		public ICircuitObjectModification CreateAddPropertyModification(string propertyName, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FE90", Offset = "0x2C8E490", VA = "0x182C8FE90")]
		public ICircuitObjectModification CreateRemovePropertyModification(string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FF30", Offset = "0x2C8E530", VA = "0x182C8FF30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C98ED0", Offset = "0x2C974D0", VA = "0x182C98ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RateLimiter GlobalSyncedEventRateLimiter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x461E70", Offset = "0x460470", VA = "0x180461E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C98E60", Offset = "0x2C97460", VA = "0x182C98E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BufferedOperationsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2C98E10", Offset = "0x2C97410", VA = "0x182C98E10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2C993F0", Offset = "0x2C979F0", VA = "0x182C993F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ObjectCircuitContext> OnObjectCircuitContextCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2C98D70", Offset = "0x2C97370", VA = "0x182C98D70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2C99350", Offset = "0x2C97950", VA = "0x182C99350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CircuitContext, Node> OnCircuitNodeAddedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2C98A50", Offset = "0x2C97050", VA = "0x182C98A50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2C99030", Offset = "0x2C97630", VA = "0x182C99030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2C98AF0", Offset = "0x2C970F0", VA = "0x182C98AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2C990D0", Offset = "0x2C976D0", VA = "0x182C990D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NodeConnection> OnNodesConnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2C98C30", Offset = "0x2C97230", VA = "0x182C98C30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2C99210", Offset = "0x2C97810", VA = "0x182C99210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NodeConnection> OnNodesDisconnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2C98CD0", Offset = "0x2C972D0", VA = "0x182C98CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2C992B0", Offset = "0x2C978B0", VA = "0x182C992B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CircuitContext, CircuitContext> OnContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2C98B90", Offset = "0x2C97190", VA = "0x182C98B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2C99170", Offset = "0x2C97770", VA = "0x182C99170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventRegisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x2C98910", Offset = "0x2C96F10", VA = "0x182C98910")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2C98EF0", Offset = "0x2C974F0", VA = "0x182C98EF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventUnregisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2C989B0", Offset = "0x2C96FB0", VA = "0x182C989B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2C98F90", Offset = "0x2C97590", VA = "0x182C98F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C96640", Offset = "0x2C94C40", VA = "0x182C96640")]
		public Guid NextGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C985B0", Offset = "0x2C96BB0", VA = "0x182C985B0")]
		public GlobalCircuitContext(ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C98650", Offset = "0x2C96C50", VA = "0x182C98650")]
		public GlobalCircuitContext(Guid contextId, ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x949A70", Offset = "0x948070", VA = "0x180949A70")]
		public void ResetMaxExecutions(int newRemaining = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C95040", Offset = "0x2C93640", VA = "0x182C95040", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextId, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C984B0", Offset = "0x2C96AB0", VA = "0x182C984B0")]
		public bool TryFindNodeViaGloballyUniqueId(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2C98460", Offset = "0x2C96A60", VA = "0x182C98460", Slot = "9")]
		public sealed override CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2C95190", Offset = "0x2C93790", VA = "0x182C95190", Slot = "10")]
		public override void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2C96860", Offset = "0x2C94E60", VA = "0x182C96860")]
		public void PushEditContext(CircuitContext circuitContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2C966F0", Offset = "0x2C94CF0", VA = "0x182C966F0")]
		public void PopEditContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2C96B50", Offset = "0x2C95150", VA = "0x182C96B50")]
		public void RaiseRegisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2C96BD0", Offset = "0x2C951D0", VA = "0x182C96BD0")]
		public void RaiseUnregisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2C96A20", Offset = "0x2C95020", VA = "0x182C96A20")]
		public void RaiseOnCircuitNodeDestroyedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2C969B0", Offset = "0x2C94FB0", VA = "0x182C969B0")]
		public void RaiseOnCircuitNodeAddedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2C96A90", Offset = "0x2C95090", VA = "0x182C96A90")]
		public void RaiseOnCircuitNodesConnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2C96AF0", Offset = "0x2C950F0", VA = "0x182C96AF0")]
		public void RaiseOnCircuitNodesDisconnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2C96C50", Offset = "0x2C95250", VA = "0x182C96C50")]
		public void RegisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2C984D0", Offset = "0x2C96AD0", VA = "0x182C984D0")]
		public void UnregisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2C96690", Offset = "0x2C94C90", VA = "0x182C96690")]
		private void OnBufferedOpCountChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2C952D0", Offset = "0x2C938D0", VA = "0x182C952D0")]
		public void MasterReinitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2C97E20", Offset = "0x2C96420", VA = "0x182C97E20")]
		[RPCMethod]
		protected void RpcReinitializeAll(CircuitContextData circuitContextData, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2C96EB0", Offset = "0x2C954B0", VA = "0x182C96EB0")]
		internal void RequestCreateNewCircuitNode(Guid contextId, Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2C954D0", Offset = "0x2C93AD0", VA = "0x182C954D0")]
		[RPCMethod]
		internal void MasterRpcCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2C97650", Offset = "0x2C95C50", VA = "0x182C97650")]
		[RPCMethod]
		internal void RpcBufferedCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2C97270", Offset = "0x2C95870", VA = "0x182C97270")]
		internal void RequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2C96080", Offset = "0x2C94680", VA = "0x182C96080")]
		[RPCMethod]
		internal void MasterRpcRequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2C97920", Offset = "0x2C95F20", VA = "0x182C97920")]
		[RPCMethod]
		internal void RpcBufferedDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2C970C0", Offset = "0x2C956C0", VA = "0x182C970C0")]
		internal void RequestCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2C957A0", Offset = "0x2C93DA0", VA = "0x182C957A0")]
		[RPCMethod]
		internal void MasterRpcCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2C97800", Offset = "0x2C95E00", VA = "0x182C97800")]
		[RPCMethod]
		internal void RpcBufferedCreateNewDynamicEvent(Guid contextId, string eventName, Guid eventId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2C97350", Offset = "0x2C95950", VA = "0x182C97350")]
		internal void RequestDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2C95A90", Offset = "0x2C94090", VA = "0x182C95A90")]
		[RPCMethod]
		internal void MasterRpcDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2C97980", Offset = "0x2C95F80", VA = "0x182C97980")]
		[RPCMethod]
		internal void RpcBufferedDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2C96CD0", Offset = "0x2C952D0", VA = "0x182C96CD0")]
		internal void RequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2C95E10", Offset = "0x2C94410", VA = "0x182C95E10")]
		[RPCMethod]
		internal void MasterRpcRequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2C97A50", Offset = "0x2C96050", VA = "0x182C97A50")]
		[RPCMethod]
		internal void RpcConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2C974B0", Offset = "0x2C95AB0", VA = "0x182C974B0")]
		internal void RequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2C961E0", Offset = "0x2C947E0", VA = "0x182C961E0")]
		[RPCMethod]
		internal void MasterRpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2C97ED0", Offset = "0x2C964D0", VA = "0x182C97ED0")]
		[RPCMethod]
		internal void RpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2C980F0", Offset = "0x2C966F0", VA = "0x182C980F0")]
		internal void SendObjectModification(ICircuitObjectModification nodeModificationBase)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2C95C50", Offset = "0x2C94250", VA = "0x182C95C50")]
		[RPCMethod]
		internal void MasterRpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2C97C20", Offset = "0x2C96220", VA = "0x182C97C20")]
		[RPCMethod]
		internal void RpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2C963F0", Offset = "0x2C949F0", VA = "0x182C963F0")]
		public IEnumerable<CircuitObject> MasterSpawnTemplateOnAllClients(CircuitContext intoContext, CircuitContextData templateDataOriginal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2C980A0", Offset = "0x2C966A0", VA = "0x182C980A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2AED0", Offset = "0xA294D0", VA = "0x180A2AED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE50", Offset = "0xA29450", VA = "0x180A2AE50")]
		public NestedCircuitContext(Guid contextId, ObjectCircuitContext parentSynchronizationContext, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD60", Offset = "0xA29360", VA = "0x180A2AD60", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B100", Offset = "0xA29700", VA = "0x180A2B100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B1A0", Offset = "0xA297A0", VA = "0x180A2B1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA2B090", Offset = "0xA29690", VA = "0x180A2B090")]
		public ObjectCircuitContext(Guid contextId, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFF0", Offset = "0xA295F0", VA = "0x180A2AFF0")]
		public void SetSynchronizationBackend(ICircuitContextNetworking networkBackend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA2AEE0", Offset = "0xA294E0", VA = "0x180A2AEE0", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA2AFC0", Offset = "0xA295C0", VA = "0x180A2AFC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2AED0", Offset = "0xA294D0", VA = "0x180A2AED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xE4F3E0", Offset = "0xE4D9E0", VA = "0x180E4F3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C07B0", Offset = "0x3BEDB0", VA = "0x1803C07B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xE4F390", Offset = "0xE4D990", VA = "0x180E4F390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xE4F2C0", Offset = "0xE4D8C0", VA = "0x180E4F2C0")]
		public SynchronizedCircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xE4EC70", Offset = "0xE4D270", VA = "0x180E4EC70", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xE4EB80", Offset = "0xE4D180", VA = "0x180E4EB80")]
		public void AddChildContextToLookup(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xE4EE10", Offset = "0xE4D410", VA = "0x180E4EE10")]
		public void RemoveChildContextFromLookup(Guid childContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xE4F070", Offset = "0xE4D670", VA = "0x180E4F070")]
		public void SendSynchronizedEvent(Guid fromContextId, CircuitEvent circuitEvent, SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xE4EEF0", Offset = "0xE4D4F0", VA = "0x180E4EEF0")]
		[RPCMethod]
		protected void RpcOnReceivedSynchronizedEvent(Guid contextId, SynchronizedEventData circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xE4ECC0", Offset = "0xE4D2C0", VA = "0x180E4ECC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD07A0", Offset = "0xCFBA0", VA = "0x1800D07A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FloatValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x13FF0", Offset = "0x133F0", VA = "0x180013FF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CircuitPlayer PlayerValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x350A80", Offset = "0x34FE80", VA = "0x180350A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x350AB0", Offset = "0x34FEB0", VA = "0x180350AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x14440", Offset = "0x13840", VA = "0x180014440")]
		public object ObjectValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x28D0", Offset = "0x1CD0", VA = "0x1800028D0")]
		public T ObjectValue<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x350A60", Offset = "0x34FE60", VA = "0x180350A60")]
		private CircuitSignal(TypeKind circuitTypeKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3504E0", Offset = "0x34F8E0", VA = "0x1803504E0")]
		public bool Equals(CircuitSignal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x350580", Offset = "0x34F980", VA = "0x180350580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3506A0", Offset = "0x34FAA0", VA = "0x1803506A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2C93670", Offset = "0x2C91C70", VA = "0x182C93670")]
		public static bool operator !=(CircuitSignal left, CircuitSignal right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x350820", Offset = "0x34FC20", VA = "0x180350820")]
		public string InternalToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x350930", Offset = "0x34FD30", VA = "0x180350930")]
		internal CircuitSignalData ToSerializedSignalData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F80", Offset = "0x2C91580", VA = "0x182C92F80")]
		internal static CircuitSignal FromSerializedSignalData(CircuitSignalData signalData)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2C92C60", Offset = "0x2C91260", VA = "0x182C92C60")]
		public static CircuitSignal DefaultFor(TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2C92E70", Offset = "0x2C91470", VA = "0x182C92E70")]
		public static CircuitSignal FromBool(bool newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F00", Offset = "0x2C91500", VA = "0x182C92F00")]
		public static CircuitSignal FromInt(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2C92EC0", Offset = "0x2C914C0", VA = "0x182C92EC0")]
		public static CircuitSignal FromFloat(float newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2C93120", Offset = "0x2C91720", VA = "0x182C93120")]
		public static CircuitSignal FromString(string stringValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F00", Offset = "0x2C91500", VA = "0x182C92F00")]
		public static CircuitSignal FromPlayerID(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F00", Offset = "0x2C91500", VA = "0x182C92F00")]
		public static CircuitSignal FromPlayer(CircuitPlayer newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F40", Offset = "0x2C91540", VA = "0x182C92F40")]
		public static CircuitSignal FromObject(object newValue, TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2C93460", Offset = "0x2C91A60", VA = "0x182C93460")]
		public static CircuitSignal List(List<CircuitSignal> list)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2C929C0", Offset = "0x2C90FC0", VA = "0x182C929C0")]
		public static CircuitSignal CreateListFromPorts(IExecutionScope executionScope, IReadOnlyCollection<InputPort> valuePorts, bool includeUnconnected)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x350770", Offset = "0x34FB70", VA = "0x180350770")]
		public List<CircuitSignal> GetListValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2C92E70", Offset = "0x2C91470", VA = "0x182C92E70")]
		public static explicit operator CircuitSignal(bool boolValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2C92EC0", Offset = "0x2C914C0", VA = "0x182C92EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C93B50", Offset = "0x2C92150", VA = "0x182C93B50")]
		public static implicit operator CircuitTypeOrString(string value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2C93B20", Offset = "0x2C92120", VA = "0x182C93B20")]
		public static implicit operator CircuitTypeOrString(CircuitType value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x350C60", Offset = "0x350060", VA = "0x180350C60")]
		public CircuitType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2C939B0", Offset = "0x2C91FB0", VA = "0x182C939B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE50800", Offset = "0xE4EE00", VA = "0x180E50800")]
		public static implicit operator TypeParamConstrainedOrNot(string name)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xE50890", Offset = "0xE4EE90", VA = "0x180E50890")]
		public static implicit operator TypeParamConstrainedOrNot([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x253B30", Offset = "0x252F30")] (string, CircuitTypeOrString) fields)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2ED0", Offset = "0x22D0", VA = "0x180002ED0")]
		public TypeParameterType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE50700", Offset = "0xE4ED00", VA = "0x180E50700")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C94050", Offset = "0x2C92650", VA = "0x182C94050")]
		public ClassFactoryTypeParams(Guid? name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2C93D70", Offset = "0x2C92370", VA = "0x182C93D70")]
		public ClassFactoryTypeParams CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C93E90", Offset = "0x2C92490", VA = "0x182C93E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C93CA0", Offset = "0x2C922A0", VA = "0x182C93CA0")]
		public ClassFactoryProps(Guid? name, string friendlyName, IList<TypeParameterType> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2C93B90", Offset = "0x2C92190", VA = "0x182C93B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xE51940", Offset = "0xE4FF40", VA = "0x180E51940")]
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
			[Cpp2IlInjected.Address(RVA = "0xE52690", Offset = "0xE50C90", VA = "0x180E52690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static CircuitType CInt
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xE52850", Offset = "0xE50E50", VA = "0x180E52850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static CircuitType CFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xE527E0", Offset = "0xE50DE0", VA = "0x180E527E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CircuitType CString
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xE528C0", Offset = "0xE50EC0", VA = "0x180E528C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static CircuitType CAny
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xE52620", Offset = "0xE50C20", VA = "0x180E52620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static CircuitType CExec
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE52770", Offset = "0xE50D70", VA = "0x180E52770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CircuitType CErr
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xE52700", Offset = "0xE50D00", VA = "0x180E52700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xE51F00", Offset = "0xE50500", VA = "0x180E51F00")]
		public static AppliedGenericType CArray(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xE52170", Offset = "0xE50770", VA = "0x180E52170")]
		public static AppliedGenericType CList(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xE51FF0", Offset = "0xE505F0", VA = "0x180E51FF0")]
		public static ClassFactoryTypeParams CClass()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xE52060", Offset = "0xE50660", VA = "0x180E52060")]
		public static ClassFactoryTypeParams CClass(Guid name, string friendlyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xE52100", Offset = "0xE50700", VA = "0x180E52100")]
		public static AppliedGenericType CIntersect(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xE52270", Offset = "0xE50870", VA = "0x180E52270")]
		public static AppliedGenericType CTuple(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xE522E0", Offset = "0xE508E0", VA = "0x180E522E0")]
		public static TypeParameterType CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xE523B0", Offset = "0xE509B0", VA = "0x180E523B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE3DC10", Offset = "0xE3C210", VA = "0x180E3DC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xE3D220", Offset = "0xE3B820", VA = "0x180E3D220", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xE3D300", Offset = "0xE3B900", VA = "0x180E3D300", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xE3DB90", Offset = "0xE3C190", VA = "0x180E3DB90")]
		public AppliedGenericType(GenericType originalType, IEnumerable<CircuitType> typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xE3DB50", Offset = "0xE3C150", VA = "0x180E3DB50", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xE3D7F0", Offset = "0xE3BDF0", VA = "0x180E3D7F0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xE3D760", Offset = "0xE3BD60", VA = "0x180E3D760", Slot = "10")]
		public bool Equals(AppliedGenericType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xE3D8C0", Offset = "0xE3BEC0", VA = "0x180E3D8C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xE3D910", Offset = "0xE3BF10", VA = "0x180E3D910", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xE3D990", Offset = "0xE3BF90", VA = "0x180E3D990", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xE3D550", Offset = "0xE3BB50", VA = "0x180E3D550")]
		public static AppliedGenericType DeserializeFromProtobuf(AppliedGenericTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ArrayType : GenericType, IEquatable<ArrayType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xE3DEE0", Offset = "0xE3C4E0", VA = "0x180E3DEE0")]
		public ArrayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xE3DE80", Offset = "0xE3C480", VA = "0x180E3DE80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDF0", Offset = "0xE3C3F0", VA = "0x180E3DDF0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDB0", Offset = "0xE3C3B0", VA = "0x180E3DDB0")]
		private static string ToStringImpl(string typeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xE3DD50", Offset = "0xE3C350", VA = "0x180E3DD50", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5600", Offset = "0x7C3C00", VA = "0x1807C5600", Slot = "11")]
		public bool Equals(ArrayType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xE3DD00", Offset = "0xE3C300", VA = "0x180E3DD00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xE3DDA0", Offset = "0xE3C3A0", VA = "0x180E3DDA0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x405350", Offset = "0x403950", VA = "0x180405350")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x456540", Offset = "0x454B40", VA = "0x180456540")]
		public CircuitType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C07B0", Offset = "0x3BEDB0", VA = "0x1803C07B0", Slot = "5")]
		public virtual CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2370", Offset = "0x7C0970", VA = "0x1807C2370", Slot = "7")]
		public virtual void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2860", Offset = "0x7C0E60", VA = "0x1807C2860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2700", Offset = "0x7C0D00", VA = "0x1807C2700", Slot = "8")]
		public virtual bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C26B0", Offset = "0x7C0CB0", VA = "0x1807C26B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2960", Offset = "0x7C0F60", VA = "0x1807C2960")]
		public static bool operator ==(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C2980", Offset = "0x7C0F80", VA = "0x1807C2980")]
		public static bool operator !=(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C27C0", Offset = "0x7C0DC0", VA = "0x1807C27C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C27E0", Offset = "0x7C0DE0", VA = "0x1807C27E0", Slot = "9")]
		public virtual CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C23D0", Offset = "0x7C09D0", VA = "0x1807C23D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C3B90", Offset = "0x7C2190", VA = "0x1807C3B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A60", Offset = "0x7C2060", VA = "0x1807C3A60")]
		public ClassType([Optional] IEnumerable<TypeParameterType> typeParameters, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] Guid? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C3730", Offset = "0x7C1D30", VA = "0x1807C3730", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C0FC0", VA = "0x1807C29C0")]
		private string ClassNameToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C39E0", Offset = "0x7C1FE0", VA = "0x1807C39E0")]
		private string TypeParametersToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
		private string PropertiesToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FB230", Offset = "0x5F9830", VA = "0x1805FB230", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParamaterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F90", Offset = "0x7C1590", VA = "0x1807C2F90", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DE0", Offset = "0x7C13E0", VA = "0x1807C2DE0", Slot = "11")]
		public bool Equals(ClassType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D90", Offset = "0x7C1390", VA = "0x1807C2D90", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3180", Offset = "0x7C1780", VA = "0x1807C3180", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3480", Offset = "0x7C1A80", VA = "0x1807C3480", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A80", Offset = "0x7C1080", VA = "0x1807C2A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C49F0", Offset = "0x7C2FF0", VA = "0x1807C49F0")]
		public FunctionType(IEnumerable<TypeParameterType> typeParameters, IEnumerable<KeyValuePair<string, Parameter>> parameters, IEnumerable<KeyValuePair<string, Return>> returns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C49C0", Offset = "0x7C2FC0", VA = "0x1807C49C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C4990", Offset = "0x7C2F90", VA = "0x1807C4990", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C43D0", Offset = "0x7C29D0", VA = "0x1807C43D0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C44C0", Offset = "0x7C2AC0", VA = "0x1807C44C0", Slot = "11")]
		public bool Equals(FunctionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C4380", Offset = "0x7C2980", VA = "0x1807C4380", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4570", Offset = "0x7C2B70", VA = "0x1807C4570", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C4630", Offset = "0x7C2C30", VA = "0x1807C4630", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050")]
		public static FunctionType DeserializeFromProtobuf(FunctionTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GenericType : CircuitType
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x456540", Offset = "0x454B40", VA = "0x180456540")]
		protected GenericType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract string ToString(IReadOnlyList<CircuitType> typeParameterAssignments);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B20", Offset = "0x7C3120", VA = "0x1807C4B20")]
		public AppliedGenericType NewApplication(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C30B0", VA = "0x1807C4AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C5780", Offset = "0x7C3D80", VA = "0x1807C5780")]
		public IntersectionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5750", Offset = "0x7C3D50", VA = "0x1807C5750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C56B0", Offset = "0x7C3CB0", VA = "0x1807C56B0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5660", Offset = "0x7C3C60", VA = "0x1807C5660", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5600", Offset = "0x7C3C00", VA = "0x1807C5600", Slot = "11")]
		public bool Equals(IntersectionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C5610", Offset = "0x7C3C10", VA = "0x1807C5610", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C27C0", Offset = "0x7C0DC0", VA = "0x1807C27C0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F0330", Offset = "0x3EE930", VA = "0x1803F0330")]
		public Parameter(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B70", Offset = "0x7C4170", VA = "0x1807C5B70", Slot = "4")]
		public bool Equals(Parameter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BB0", Offset = "0x7C41B0", VA = "0x1807C5BB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D6AA0", Offset = "0x3D50A0", VA = "0x1803D6AA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C00", Offset = "0x7C4200", VA = "0x1807C5C00")]
		public ParameterData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AF0", Offset = "0x7C40F0", VA = "0x1807C5AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A0EF0", Offset = "0x49F4F0", VA = "0x1804A0EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C60E0", Offset = "0x7C46E0", VA = "0x1807C60E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C6090", Offset = "0x7C4690", VA = "0x1807C6090")]
		public Property(CircuitType type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FD0", Offset = "0x7C45D0", VA = "0x1807C5FD0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EA0", Offset = "0x7C44A0", VA = "0x1807C5EA0")]
		private string GetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F90", Offset = "0x7C4590", VA = "0x1807C5F90")]
		private string SetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D40", Offset = "0x7C4340", VA = "0x1807C5D40", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DD0", Offset = "0x7C43D0", VA = "0x1807C5DD0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E20", Offset = "0x7C4420", VA = "0x1807C5E20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EE0", Offset = "0x7C44E0", VA = "0x1807C5EE0")]
		public PropertyData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C90", Offset = "0x7C4290", VA = "0x1807C5C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3F0330", Offset = "0x3EE930", VA = "0x1803F0330")]
		public Return(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B70", Offset = "0x7C4170", VA = "0x1807C5B70", Slot = "4")]
		public bool Equals(Return other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7C6ED0", Offset = "0x7C54D0", VA = "0x1807C6ED0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3D6AA0", Offset = "0x3D50A0", VA = "0x1803D6AA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F20", Offset = "0x7C5520", VA = "0x1807C6F20")]
		public ReturnData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E50", Offset = "0x7C5450", VA = "0x1807C6E50")]
		public static Return DeserializeFromProtobuf(ReturnData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class TupleType : GenericType, IEquatable<TupleType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7C8120", Offset = "0x7C6720", VA = "0x1807C8120")]
		public TupleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7C80F0", Offset = "0x7C66F0", VA = "0x1807C80F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8090", Offset = "0x7C6690", VA = "0x1807C8090", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8040", Offset = "0x7C6640", VA = "0x1807C8040", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5600", Offset = "0x7C3C00", VA = "0x1807C5600", Slot = "11")]
		public bool Equals(TupleType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FF0", Offset = "0x7C65F0", VA = "0x1807C7FF0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7C27C0", Offset = "0x7C0DC0", VA = "0x1807C27C0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC7E0", Offset = "0x3EADE0", VA = "0x1803EC7E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7C8140", Offset = "0x7C6740", VA = "0x1807C8140", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7C8230", Offset = "0x7C6830", VA = "0x1807C8230", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7C8510", Offset = "0x7C6B10", VA = "0x1807C8510")]
		public TypeParameterReferenceType(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7C8360", Offset = "0x7C6960", VA = "0x1807C8360", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7C83E0", Offset = "0x7C69E0", VA = "0x1807C83E0", Slot = "10")]
		public bool Equals(TypeParameterReferenceType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7C8310", Offset = "0x7C6910", VA = "0x1807C8310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7C8410", Offset = "0x7C6A10", VA = "0x1807C8410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7C8460", Offset = "0x7C6A60", VA = "0x1807C8460", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8290", Offset = "0x7C6890", VA = "0x1807C8290")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8600", Offset = "0x7C6C00", VA = "0x1807C8600")]
		protected TypeParameterScopeType(IEnumerable<TypeParameterType> typeParameters, TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8540", Offset = "0x7C6B40", VA = "0x1807C8540")]
		protected bool Equals(TypeParameterScopeType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C6BA0", VA = "0x1807C85A0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A90", Offset = "0x7C7090", VA = "0x1807C8A90")]
		public TypeParameterType(string name, [Optional] CircuitType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A10", Offset = "0x7C7010", VA = "0x1807C8A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7C8810", Offset = "0x7C6E10", VA = "0x1807C8810", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7C8750", Offset = "0x7C6D50", VA = "0x1807C8750", Slot = "10")]
		public bool Equals(TypeParameterType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7C87C0", Offset = "0x7C6DC0", VA = "0x1807C87C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7C88C0", Offset = "0x7C6EC0", VA = "0x1807C88C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7C8940", Offset = "0x7C6F40", VA = "0x1807C8940", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7C8670", Offset = "0x7C6C70", VA = "0x1807C8670")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC1C70", Offset = "0x2BC0270", VA = "0x182BC1C70")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(params TNode[] nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1B20", Offset = "0x2BC0120", VA = "0x182BC1B20")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TNode> nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x49F380", Offset = "0x49D980", VA = "0x18049F380")]
		private static (Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>) GenerateConstraintsForNodes<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(IEnumerable<TNode> nodes, TUnificationArena unificationArena) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B500", Offset = "0x2D99B00", VA = "0x182D9B500")]
		private static void GenerateConstraintsForNode<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToId, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToIdAll, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x255B30", Offset = "0x254F30")] List<(int, CircuitType)> idToType, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x256FB0", Offset = "0x2563B0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2BC19C0", Offset = "0x2BBFFC0", VA = "0x182BC19C0")]
		private static Dictionary<string, int> IdentifyTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257300", Offset = "0x256700")] List<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC2F0", Offset = "0x2BAA8F0", VA = "0x182BAC2F0")]
		private static IEnumerable<(TPort, int)> GetGenericPorts<TPort, TUnificationArena, TTerm, TNode, TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TPort> ports, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToTypeId) where TPort : class, ICheckablePort where TUnificationArena : IUnificationArena<TTerm> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x49FDA0", Offset = "0x49E3A0", VA = "0x18049FDA0")]
		private static (int, TTerm) GenerateOutputConstraintsAndId<TTerm, TOutputPort, TNode, TInputPort, TCheckableConnection, TUnificationArena>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257510", Offset = "0x256910")] IEnumerable<(TOutputPort, int)> outputPorts, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2576F0", Offset = "0x256AF0")] List<(int, CircuitType)> idToType, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((int, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C010", Offset = "0x2D9A610", VA = "0x182D9C010")]
		private static void GenerateInputConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257B20", Offset = "0x256F20")] IEnumerable<(TInputPort, int)> inputPorts, TUnificationArena unificationArena, int outputPortId, TTerm outputPortUnificationTerm, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257CD0", Offset = "0x2570D0")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x58E850", Offset = "0x58CE50", VA = "0x18058E850")]
		private static int GenerateInputConnectionConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TInputPort inputPort, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257D90", Offset = "0x257190")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8257C0", Offset = "0x823DC0", VA = "0x1808257C0")]
		private static TTerm GetTypeUnificationTerm<TTerm, TUnificationArena>(CircuitType type, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x257F40", Offset = "0x257340")] List<(int, CircuitType)> idToType, IReadOnlyDictionary<string, int> typeParameterToId) where TUnificationArena : IUnificationArena<TTerm>
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC12B0", Offset = "0x2BBF8B0", VA = "0x182BC12B0")]
		private static Dictionary<TNode, List<(string, CircuitType)>> GetTypeParameterAssignments<TNode, TInputPort, TOutputPort, TCheckableConnection>(ReferenceSubstitution[] substitutions, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2580E0", Offset = "0x2574E0")] IEnumerable<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A730", Offset = "0x2D98D30", VA = "0x182D9A730")]
		private static void CacheAdditionalEquivalentTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection>(TNode node, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x258310", Offset = "0x257710")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2D9AE60", Offset = "0x2D99460", VA = "0x182D9AE60")]
		private static void GenerateConstraintsForAdditionalEquivalentTypeParameters<TUnificationArena, TTerm, TNode>(TUnificationArena unificationArena, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2584C0", Offset = "0x2578C0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE4FE30", Offset = "0xE4E430", VA = "0x180E4FE30")]
		private static Dictionary<int, CircuitType> ApplySubstitutions(Dictionary<int, ReferenceSubstitution> substitutions, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x258640", Offset = "0x257A40")] IEnumerable<(int, CircuitType)> idToType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE50320", Offset = "0xE4E920", VA = "0x180E50320")]
		private static CircuitType MonomorphizeItem(ITerm type, Dictionary<int, CircuitType> idToType, Dictionary<int, CircuitType> cache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE501D0", Offset = "0xE4E7D0", VA = "0x180E501D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2ED0", Offset = "0x22D0", VA = "0x180002ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14440", Offset = "0x13840", VA = "0x180014440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1C430", Offset = "0x1B830", VA = "0x18001C430")]
		public TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x356B40", Offset = "0x355F40", VA = "0x180356B40", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x356C10", Offset = "0x356010", VA = "0x180356C10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x356CA0", Offset = "0x3560A0", VA = "0x180356CA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x356D30", Offset = "0x356130", VA = "0x180356D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class TypeParameterId
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x245AD90", Offset = "0x2459390", VA = "0x18245AD90")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x25AD90", Offset = "0x25A190")]
			public readonly (Constraint, Constraint) constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Substitution substitution;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x4A430", Offset = "0x49830", VA = "0x18004A430")]
			public Impl(in Constraint first, in Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x4A440", Offset = "0x49840", VA = "0x18004A440")]
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
			[Cpp2IlInjected.Address(RVA = "0x2640", Offset = "0x1A40", VA = "0x180002640")]
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
			[Cpp2IlInjected.Address(RVA = "0x2ED0", Offset = "0x22D0", VA = "0x180002ED0")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Constraint SecondConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x14440", Offset = "0x13840", VA = "0x180014440")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Substitution Substitution
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2ED0", Offset = "0x22D0", VA = "0x180002ED0")]
			get
			{
				return default(Substitution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4A330", Offset = "0x49730", VA = "0x18004A330")]
		private ApplyConstraintResult(in Constraint first, in Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7B57B0", Offset = "0x7B3DB0", VA = "0x1807B57B0")]
		public static ApplyConstraintResult NewConstraints(in Constraint first, in Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4A300", Offset = "0x49700", VA = "0x18004A300")]
		private ApplyConstraintResult(in Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5860", Offset = "0x7B3E60", VA = "0x1807B5860")]
		public static ApplyConstraintResult NewSubstitution(in Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4A340", Offset = "0x49740", VA = "0x18004A340")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5840", Offset = "0x7B3E40", VA = "0x1807B5840")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x192F0", Offset = "0x186F0", VA = "0x1800192F0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x13370", Offset = "0x12770", VA = "0x180013370")]
		public Arrow(TermIndex from, TermIndex to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4A370", Offset = "0x49770", VA = "0x18004A370", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x192F0", Offset = "0x186F0", VA = "0x1800192F0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x4A380", Offset = "0x49780", VA = "0x18004A380")]
		public ApplyConstraintResult Apply(Term[] terms)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x13370", Offset = "0x12770", VA = "0x180013370")]
		public Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x4A3B0", Offset = "0x497B0", VA = "0x18004A3B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x192F0", Offset = "0x186F0", VA = "0x1800192F0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x13370", Offset = "0x12770", VA = "0x180013370")]
		public Substitution(int identifier, TermIndex value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A0", Offset = "0x498A0", VA = "0x18004A4A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A460", Offset = "0x49860", VA = "0x18004A460")]
			public Impl(in Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x4A470", Offset = "0x49870", VA = "0x18004A470")]
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
			[Cpp2IlInjected.Address(RVA = "0x14510", Offset = "0x13910", VA = "0x180014510")]
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
			[Cpp2IlInjected.Address(RVA = "0x2ED0", Offset = "0x22D0", VA = "0x180002ED0")]
			get
			{
				return default(Arrow);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4A680", Offset = "0x49A80", VA = "0x18004A680")]
		private Term(in Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FB0", Offset = "0x7C65B0", VA = "0x1807C7FB0")]
		public static Term NewArrow(in Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4A690", Offset = "0x49A90", VA = "0x18004A690")]
		private Term(int identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7C7FD0", Offset = "0x7C65D0", VA = "0x1807C7FD0")]
		public static Term NewIdentifier(int identifier)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x4A590", Offset = "0x49990", VA = "0x18004A590", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x13F80", Offset = "0x13380", VA = "0x180013F80")]
		public TermIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x4A530", Offset = "0x49930", VA = "0x18004A530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x4A520", Offset = "0x49920", VA = "0x18004A520")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD300", Offset = "0x3DB900", VA = "0x1803DD300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Stack<Constraint> Constraints
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6B0", Offset = "0x7CACB0", VA = "0x1807CC6B0", Slot = "4")]
		public int NextId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x58EB30", Offset = "0x58D130", VA = "0x18058EB30", Slot = "5")]
		public int GetId<T>(Dictionary<T, int> itemToIndex, T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4F0", Offset = "0x7CAAF0", VA = "0x1807CC4F0", Slot = "6")]
		public TermIndex Arrow(TermIndex from, TermIndex to)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x4AB0F0", Offset = "0x4A96F0", VA = "0x1804AB0F0", Slot = "7")]
		public TermIndex Identifier(int value)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7CC5A0", Offset = "0x7CABA0", VA = "0x1807CC5A0", Slot = "8")]
		public void Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7CC750", Offset = "0x7CAD50", VA = "0x1807CC750", Slot = "9")]
		public ReferenceSubstitution[] Solve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7CC610", Offset = "0x7CAC10", VA = "0x1807CC610")]
		public static UnificationArena New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x478230", Offset = "0x476830", VA = "0x180478230", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6970", Offset = "0x7C4F70", VA = "0x1807C6970", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF700", Offset = "0x3DDD00", VA = "0x1803DF700")]
		public ReferenceArrow(ITerm from, ITerm to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C6AE0", Offset = "0x7C50E0", VA = "0x1807C6AE0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC400", Offset = "0x3EAA00", VA = "0x1803EC400", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B70", Offset = "0x7C5170", VA = "0x1807C6B70", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x456540", Offset = "0x454B40", VA = "0x180456540")]
		public ReferenceIdentifier(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C80", Offset = "0x7C5280", VA = "0x1807C6C80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x456C80", Offset = "0x455280", VA = "0x180456C80")]
		public ReferenceSubstitution(int identifier, ITerm value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E00", Offset = "0x7C5400", VA = "0x1807C6E00")]
		public ReferenceSubstitution(in Substitution substitution, Term[] terms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CA0", Offset = "0x7C52A0", VA = "0x1807C6CA0")]
		private static ITerm FromTermIndex(TermIndex termIndex, Term[] terms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DA0", Offset = "0x7C53A0", VA = "0x1807C6DA0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F80", Offset = "0x13380", VA = "0x180013F80")]
			public IntBytesUnion(int intVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xE4550", Offset = "0xE3950", VA = "0x1800E4550")]
			public IntBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xE4540", Offset = "0xE3940", VA = "0x1800E4540")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xE3DFC0", Offset = "0xE3C5C0", VA = "0x180E3DFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE4D5E0", Offset = "0xE4BBE0", VA = "0x180E4D5E0")]
		internal static bool TryGetTypeSerializer(CircuitType signalType, out ITypeSerializer typeSerializer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE4D470", Offset = "0xE4BA70", VA = "0x180E4D470")]
		public static void SerializeSignalForSync(Stream stream, CircuitType signalType, CircuitSignal signalValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE4D2D0", Offset = "0xE4B8D0", VA = "0x180E4D2D0")]
		public static CircuitSignal DeserializeSyncedSignal(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE4D8F0", Offset = "0xE4BEF0", VA = "0x180E4D8F0")]
		public static void WriteInt(Stream stream, int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE3DFC0", Offset = "0xE3C5C0", VA = "0x180E3DFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE3DEF0", Offset = "0xE3C4F0", VA = "0x180E3DEF0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE3DF80", Offset = "0xE3C580", VA = "0x180E3DF80", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE3DF20", Offset = "0xE3C520", VA = "0x180E3DF20", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		public BooleanSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class IntSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE3E280", Offset = "0xE3C880", VA = "0x180E3E280", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE3E330", Offset = "0xE3C930", VA = "0x180E3E330", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE3E2B0", Offset = "0xE3C8B0", VA = "0x180E3E2B0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x14010", Offset = "0x13410", VA = "0x180014010")]
			public FloatBytesUnion(float floatVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xE4550", Offset = "0xE3950", VA = "0x1800E4550")]
			public FloatBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xE4540", Offset = "0xE3940", VA = "0x1800E4540")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xE3DFC0", Offset = "0xE3C5C0", VA = "0x180E3DFC0")]
			public static FloatBytesUnion ReadFromStream(Stream stream)
			{
				return default(FloatBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE3E0F0", Offset = "0xE3C6F0", VA = "0x180E3E0F0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE3E1F0", Offset = "0xE3C7F0", VA = "0x180E3E1F0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE3E120", Offset = "0xE3C720", VA = "0x180E3E120", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		public FloatSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class StringSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE4DB20", Offset = "0xE4C120", VA = "0x180E4DB20", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE4DCA0", Offset = "0xE4C2A0", VA = "0x180E4DCA0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE4DB50", Offset = "0xE4C150", VA = "0x180E4DB50", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		public StringSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class PlayerSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE45C20", Offset = "0xE44220", VA = "0x180E45C20", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE45D10", Offset = "0xE44310", VA = "0x180E45D10", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE45C90", Offset = "0xE44290", VA = "0x180E45C90", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		public PlayerSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class ListSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE3F460", Offset = "0xE3DA60", VA = "0x180E3F460", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE3F710", Offset = "0xE3DD10", VA = "0x180E3F710", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE3F580", Offset = "0xE3DB80", VA = "0x180E3F580", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1DC70", Offset = "0xA1C270", VA = "0x180A1DC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA1C920", Offset = "0xA1AF20", VA = "0x180A1C920")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1F1C0", Offset = "0xA1D7C0", VA = "0x180A1F1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1F0F0", Offset = "0xA1D6F0", VA = "0x180A1F0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1F220", Offset = "0xA1D820", VA = "0x180A1F220", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA1F370", Offset = "0xA1D970", VA = "0x180A1F370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xA1F410", Offset = "0xA1DA10", VA = "0x180A1F410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public PortCollectionData InputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PortCollectionData OutputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD320", Offset = "0x3DB920", VA = "0x1803DD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public RepeatedField<NodeConnectionData> NodeConnectionDatas
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2E0", Offset = "0x3DB8E0", VA = "0x1803DD2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B70", Offset = "0x3E3170", VA = "0x1803E4B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA1F3C0", Offset = "0xA1D9C0", VA = "0x180A1F3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x3DEFB0", Offset = "0x3DD5B0", VA = "0x1803DEFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x3DF290", Offset = "0x3DD890", VA = "0x1803DF290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x4B47C0", Offset = "0x4B2DC0", VA = "0x1804B47C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x4C2380", Offset = "0x4C0980", VA = "0x1804C2380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public ByteString InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x4B47D0", Offset = "0x4B2DD0", VA = "0x1804B47D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1F320", Offset = "0xA1D920", VA = "0x180A1F320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> ListensToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x3DF040", Offset = "0x3DD640", VA = "0x1803DF040")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF050", Offset = "0x3DD650", VA = "0x1803DF050")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF100", Offset = "0x3DD700", VA = "0x1803DF100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3F0", Offset = "0x3DD9F0", VA = "0x1803DF3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public VariableNodeData VariableNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4D0", Offset = "0x5FCAD0", VA = "0x1805FE4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x949A80", Offset = "0x948080", VA = "0x180949A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA1EEA0", Offset = "0xA1D4A0", VA = "0x180A1EEA0")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA1EF90", Offset = "0xA1D590", VA = "0x180A1EF90")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1C650", VA = "0x180A1E050", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1C8D0", VA = "0x180A1E2D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA1E0B0", Offset = "0xA1C6B0", VA = "0x180A1E0B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA1E330", Offset = "0xA1C930", VA = "0x180A1E330", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA1E910", Offset = "0xA1CF10", VA = "0x180A1E910", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA1E970", Offset = "0xA1CF70", VA = "0x180A1E970", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA1DCD0", Offset = "0xA1C2D0", VA = "0x180A1DCD0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA1E540", Offset = "0xA1CB40", VA = "0x180A1E540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FF70", Offset = "0xA1E570", VA = "0x180A1FF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA1F460", Offset = "0xA1DA60", VA = "0x180A1F460")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57F70", Offset = "0xE56570", VA = "0x180E57F70")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57EF0", Offset = "0xE564F0", VA = "0x180E57EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57FD0", Offset = "0xE565D0", VA = "0x180E57FD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x457660", Offset = "0x455C60", VA = "0x180457660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xB98010", Offset = "0xB96610", VA = "0x180B98010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9D0", Offset = "0xA4BFD0", VA = "0x180A4D9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xB98020", Offset = "0xB96620", VA = "0x180B98020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE350", Offset = "0x9AC950", VA = "0x1809AE350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xB98030", Offset = "0xB96630", VA = "0x180B98030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xB97D90", Offset = "0xB96390", VA = "0x180B97D90")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE57CD0", Offset = "0xE562D0", VA = "0x180E57CD0", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE57D40", Offset = "0xE56340", VA = "0x180E57D40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB97A50", Offset = "0xB96050", VA = "0x180B97A50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xB97A90", Offset = "0xB96090", VA = "0x180B97A90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE57DD0", Offset = "0xE563D0", VA = "0x180E57DD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xB97C10", Offset = "0xB96210", VA = "0x180B97C10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xB97910", Offset = "0xB95F10", VA = "0x180B97910", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xB97B30", Offset = "0xB96130", VA = "0x180B97B30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C320", Offset = "0xE4A920", VA = "0x180E4C320")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C2A0", Offset = "0xE4A8A0", VA = "0x180E4C2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C380", Offset = "0xE4A980", VA = "0x180E4C380", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x457660", Offset = "0x455C60", VA = "0x180457660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xB98010", Offset = "0xB96610", VA = "0x180B98010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9D0", Offset = "0xA4BFD0", VA = "0x180A4D9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB98020", Offset = "0xB96620", VA = "0x180B98020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9AE350", Offset = "0x9AC950", VA = "0x1809AE350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xB98030", Offset = "0xB96630", VA = "0x180B98030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9AE340", Offset = "0x9AC940", VA = "0x1809AE340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9BE620", Offset = "0x9BCC20", VA = "0x1809BE620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public QuaternionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE4C250", Offset = "0xE4A850", VA = "0x180E4C250")]
		[DebuggerNonUserCode]
		public QuaternionData(QuaternionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE4BD60", Offset = "0xE4A360", VA = "0x180E4BD60", Slot = "9")]
		[DebuggerNonUserCode]
		public QuaternionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDE0", Offset = "0xE4A3E0", VA = "0x180E4BDE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE4BE80", Offset = "0xE4A480", VA = "0x180E4BE80", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(QuaternionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE4BED0", Offset = "0xE4A4D0", VA = "0x180E4BED0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE4C040", Offset = "0xE4A640", VA = "0x180E4C040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE4C0A0", Offset = "0xE4A6A0", VA = "0x180E4C0A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE4BD10", Offset = "0xE4A310", VA = "0x180E4BD10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE4BF90", Offset = "0xE4A590", VA = "0x180E4BF90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA20910", Offset = "0xA1EF10", VA = "0x180A20910")]
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
			[Cpp2IlInjected.Address(RVA = "0xA20840", Offset = "0xA1EE40", VA = "0x180A20840")]
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
			[Cpp2IlInjected.Address(RVA = "0xA20970", Offset = "0xA1EF70", VA = "0x180A20970", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xA20A80", Offset = "0xA1F080", VA = "0x180A20A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public Vector3Data LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public QuaternionData LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EDE0", VA = "0x180A207E0")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA20720", Offset = "0xA1ED20", VA = "0x180A20720")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData(CircuitObjectTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA200D0", Offset = "0xA1E6D0", VA = "0x180A200D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA20290", Offset = "0xA1E890", VA = "0x180A20290", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA201C0", Offset = "0xA1E7C0", VA = "0x180A201C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitObjectTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA203A0", Offset = "0xA1E9A0", VA = "0x180A203A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA20550", Offset = "0xA1EB50", VA = "0x180A20550", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA205B0", Offset = "0xA1EBB0", VA = "0x180A205B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA1FFD0", Offset = "0xA1E5D0", VA = "0x180A1FFD0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA20430", Offset = "0xA1EA30", VA = "0x180A20430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA21120", Offset = "0xA1F720", VA = "0x180A21120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA20AD0", Offset = "0xA1F0D0", VA = "0x180A20AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA219D0", Offset = "0xA1FFD0", VA = "0x180A219D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA21900", Offset = "0xA1FF00", VA = "0x180A21900")]
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
			[Cpp2IlInjected.Address(RVA = "0xA21A30", Offset = "0xA20030", VA = "0x180A21A30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public bool BackingBool
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x457670", Offset = "0x455C70", VA = "0x180457670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7D00A0", Offset = "0x7CE6A0", VA = "0x1807D00A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int BackingInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF00", Offset = "0x3DD500", VA = "0x1803DEF00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x4F4190", Offset = "0x4F2790", VA = "0x1804F4190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public float BackingFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9AE340", Offset = "0x9AC940", VA = "0x1809AE340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9BE620", Offset = "0x9BCC20", VA = "0x1809BE620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public string BackingString
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA21B30", Offset = "0xA20130", VA = "0x180A21B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA21840", Offset = "0xA1FE40", VA = "0x180A21840")]
		[DebuggerNonUserCode]
		public CircuitSignalData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA21880", Offset = "0xA1FE80", VA = "0x180A21880")]
		[DebuggerNonUserCode]
		public CircuitSignalData(CircuitSignalData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA21290", Offset = "0xA1F890", VA = "0x180A21290", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitSignalData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA213A0", Offset = "0xA1F9A0", VA = "0x180A213A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xA21340", Offset = "0xA1F940", VA = "0x180A21340", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitSignalData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xA21450", Offset = "0xA1FA50", VA = "0x180A21450", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA21610", Offset = "0xA1FC10", VA = "0x180A21610", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA21670", Offset = "0xA1FC70", VA = "0x180A21670", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xA21180", Offset = "0xA1F780", VA = "0x180A21180", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA21540", Offset = "0xA1FB40", VA = "0x180A21540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA174C0", Offset = "0xA15AC0", VA = "0x180A174C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA168F0", Offset = "0xA14EF0", VA = "0x180A168F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA18620", Offset = "0xA16C20", VA = "0x180A18620")]
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
			[Cpp2IlInjected.Address(RVA = "0xA18550", Offset = "0xA16B50", VA = "0x180A18550")]
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
			[Cpp2IlInjected.Address(RVA = "0xA18680", Offset = "0xA16C80", VA = "0x180A18680", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA18780", Offset = "0xA16D80", VA = "0x180A18780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public ByteString ContextTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA187D0", Offset = "0xA16DD0", VA = "0x180A187D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public CircuitSerializationVersion SerializationVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x3FAB40", Offset = "0x3F9140", VA = "0x1803FAB40")]
			get
			{
				return default(CircuitSerializationVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DC0", Offset = "0x5E63C0", VA = "0x1805E7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public EventBusData EventBusData
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x3DD320", Offset = "0x3DB920", VA = "0x1803DD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> NodeDatas
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2E0", Offset = "0x3DB8E0", VA = "0x1803DD2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B70", Offset = "0x3E3170", VA = "0x1803E4B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x949460", Offset = "0x947A60", VA = "0x180949460")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x560420", Offset = "0x55EA20", VA = "0x180560420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA18490", Offset = "0xA16A90", VA = "0x180A18490")]
		[DebuggerNonUserCode]
		public CircuitContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xA18310", Offset = "0xA16910", VA = "0x180A18310")]
		[DebuggerNonUserCode]
		public CircuitContextData(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xA17710", Offset = "0xA15D10", VA = "0x180A17710", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA178B0", Offset = "0xA15EB0", VA = "0x180A178B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA17770", Offset = "0xA15D70", VA = "0x180A17770", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xA17A20", Offset = "0xA16020", VA = "0x180A17A20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA17F20", Offset = "0xA16520", VA = "0x180A17F20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA17F80", Offset = "0xA16580", VA = "0x180A17F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA17520", Offset = "0xA15B20", VA = "0x180A17520", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA17D60", Offset = "0xA16360", VA = "0x180A17D60", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA17B60", Offset = "0xA16160", VA = "0x180A17B60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA27FF0", Offset = "0xA265F0", VA = "0x180A27FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA262B0", Offset = "0xA248B0", VA = "0x180A262B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA28880", Offset = "0xA26E80", VA = "0x180A28880")]
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
			[Cpp2IlInjected.Address(RVA = "0xA287B0", Offset = "0xA26DB0", VA = "0x180A287B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA288E0", Offset = "0xA26EE0", VA = "0x180A288E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA286A0", Offset = "0xA26CA0", VA = "0x180A286A0")]
		[DebuggerNonUserCode]
		public EventBusData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA28700", Offset = "0xA26D00", VA = "0x180A28700")]
		[DebuggerNonUserCode]
		public EventBusData(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA280D0", Offset = "0xA266D0", VA = "0x180A280D0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventBusData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA281B0", Offset = "0xA267B0", VA = "0x180A281B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA28280", Offset = "0xA26880", VA = "0x180A28280", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventBusData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA28300", Offset = "0xA26900", VA = "0x180A28300", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA28450", Offset = "0xA26A50", VA = "0x180A28450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA284B0", Offset = "0xA26AB0", VA = "0x180A284B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA28050", Offset = "0xA26650", VA = "0x180A28050", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA283F0", Offset = "0xA269F0", VA = "0x180A283F0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA28330", Offset = "0xA26930", VA = "0x180A28330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1BE10", Offset = "0xA1A410", VA = "0x180A1BE10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1BD40", Offset = "0xA1A340", VA = "0x180A1BD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1BE70", Offset = "0xA1A470", VA = "0x180A1BE70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD300", Offset = "0x3DB900", VA = "0x1803DD300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC20", Offset = "0xA1A220", VA = "0x180A1BC20")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData(CircuitEventObjectData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1B640", Offset = "0xA19C40", VA = "0x180A1B640", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1B780", Offset = "0xA19D80", VA = "0x180A1B780", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA1B840", Offset = "0xA19E40", VA = "0x180A1B840", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventObjectData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1B8B0", Offset = "0xA19EB0", VA = "0x180A1B8B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA1BA60", Offset = "0xA1A060", VA = "0x180A1BA60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA1BAC0", Offset = "0xA1A0C0", VA = "0x180A1BAC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA1B550", Offset = "0xA19B50", VA = "0x180A1B550", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1B930", Offset = "0xA19F30", VA = "0x180A1B930", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1A930", Offset = "0xA18F30", VA = "0x180A1A930")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1A860", Offset = "0xA18E60", VA = "0x180A1A860")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1A990", Offset = "0xA18F90", VA = "0x180A1A990", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA1AAA0", Offset = "0xA190A0", VA = "0x180A1AAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xA1AAF0", Offset = "0xA190F0", VA = "0x180A1AAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventProperty> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7C0", Offset = "0xA18DC0", VA = "0x180A1A7C0")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1A740", Offset = "0xA18D40", VA = "0x180A1A740")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData(CircuitEventDefinitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1A000", Offset = "0xA18600", VA = "0x180A1A000", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1A0A0", Offset = "0xA186A0", VA = "0x180A1A0A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA1A1C0", Offset = "0xA187C0", VA = "0x180A1A1C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventDefinitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA1A2A0", Offset = "0xA188A0", VA = "0x180A1A2A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1A470", Offset = "0xA18A70", VA = "0x180A1A470", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1A4D0", Offset = "0xA18AD0", VA = "0x180A1A4D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA19ED0", Offset = "0xA184D0", VA = "0x180A19ED0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1A350", Offset = "0xA18950", VA = "0x180A1A350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1C6F0", Offset = "0xA1ACF0", VA = "0x180A1C6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1C620", Offset = "0xA1AC20", VA = "0x180A1C620")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1C750", Offset = "0xA1AD50", VA = "0x180A1C750", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xA1C860", Offset = "0xA1AE60", VA = "0x180A1C860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA1C520", Offset = "0xA1AB20", VA = "0x180A1C520")]
		[DebuggerNonUserCode]
		public CircuitEventProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA1C560", Offset = "0xA1AB60", VA = "0x180A1C560")]
		[DebuggerNonUserCode]
		public CircuitEventProperty(CircuitEventProperty other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA1C040", Offset = "0xA1A640", VA = "0x180A1C040", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventProperty Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA1C180", Offset = "0xA1A780", VA = "0x180A1C180", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA1C120", Offset = "0xA1A720", VA = "0x180A1C120", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA1C230", Offset = "0xA1A830", VA = "0x180A1C230", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA1C380", Offset = "0xA1A980", VA = "0x180A1C380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3E0", Offset = "0xA1A9E0", VA = "0x180A1C3E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF80", Offset = "0xA1A580", VA = "0x180A1BF80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2B0", Offset = "0xA1A8B0", VA = "0x180A1C2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29BF0", Offset = "0xA281F0", VA = "0x180A29BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29B20", Offset = "0xA28120", VA = "0x180A29B20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29C50", Offset = "0xA28250", VA = "0x180A29C50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA29DB0", Offset = "0xA283B0", VA = "0x180A29DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public ByteString EventDefinitionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xA29D60", Offset = "0xA28360", VA = "0x180A29D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA29AB0", Offset = "0xA280B0", VA = "0x180A29AB0")]
		[DebuggerNonUserCode]
		public EventRegistrationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA29A10", Offset = "0xA28010", VA = "0x180A29A10")]
		[DebuggerNonUserCode]
		public EventRegistrationData(EventRegistrationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA29480", Offset = "0xA27A80", VA = "0x180A29480", Slot = "9")]
		[DebuggerNonUserCode]
		public EventRegistrationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA29540", Offset = "0xA27B40", VA = "0x180A29540", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA29670", Offset = "0xA27C70", VA = "0x180A29670", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventRegistrationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA29750", Offset = "0xA27D50", VA = "0x180A29750", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA29860", Offset = "0xA27E60", VA = "0x180A29860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA298C0", Offset = "0xA27EC0", VA = "0x180A298C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA293B0", Offset = "0xA279B0", VA = "0x180A293B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA297E0", Offset = "0xA27DE0", VA = "0x180A297E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4FCC0", Offset = "0xE4E2C0", VA = "0x180E4FCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4FC40", Offset = "0xE4E240", VA = "0x180E4FC40")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4FD20", Offset = "0xE4E320", VA = "0x180E4FD20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xE4FDE0", Offset = "0xE4E3E0", VA = "0x180E4FDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public RepeatedField<EventDataKeyValuePair> Datas
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE4FBB0", Offset = "0xE4E1B0", VA = "0x180E4FBB0")]
		[DebuggerNonUserCode]
		public SynchronizedEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE4FB40", Offset = "0xE4E140", VA = "0x180E4FB40")]
		[DebuggerNonUserCode]
		public SynchronizedEventData(SynchronizedEventData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xE4F510", Offset = "0xE4DB10", VA = "0x180E4F510", Slot = "9")]
		[DebuggerNonUserCode]
		public SynchronizedEventData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE4F5B0", Offset = "0xE4DBB0", VA = "0x180E4F5B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE4F6C0", Offset = "0xE4DCC0", VA = "0x180E4F6C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SynchronizedEventData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE4F780", Offset = "0xE4DD80", VA = "0x180E4F780", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE4F900", Offset = "0xE4DF00", VA = "0x180E4F900", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE4F960", Offset = "0xE4DF60", VA = "0x180E4F960", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE4F430", Offset = "0xE4DA30", VA = "0x180E4F430", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE4F800", Offset = "0xE4DE00", VA = "0x180E4F800", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA291A0", Offset = "0xA277A0", VA = "0x180A291A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA290D0", Offset = "0xA276D0", VA = "0x180A290D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29200", Offset = "0xA27800", VA = "0x180A29200", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA29310", Offset = "0xA27910", VA = "0x180A29310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xA29360", Offset = "0xA27960", VA = "0x180A29360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xA29060", Offset = "0xA27660", VA = "0x180A29060")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA28FC0", Offset = "0xA275C0", VA = "0x180A28FC0")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair(EventDataKeyValuePair other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA28AB0", Offset = "0xA270B0", VA = "0x180A28AB0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA28C10", Offset = "0xA27210", VA = "0x180A28C10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xA28B70", Offset = "0xA27170", VA = "0x180A28B70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventDataKeyValuePair other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xA28D00", Offset = "0xA27300", VA = "0x180A28D00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA28E10", Offset = "0xA27410", VA = "0x180A28E10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xA28E70", Offset = "0xA27470", VA = "0x180A28E70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xA289E0", Offset = "0xA26FE0", VA = "0x180A289E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xA28D90", Offset = "0xA27390", VA = "0x180A28D90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1B390", Offset = "0xA19990", VA = "0x180A1B390")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1B2C0", Offset = "0xA198C0", VA = "0x180A1B2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1B3F0", Offset = "0xA199F0", VA = "0x180A1B3F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA1B500", Offset = "0xA19B00", VA = "0x180A1B500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B280", Offset = "0xA19880", VA = "0x180A1B280")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B1C0", Offset = "0xA197C0", VA = "0x180A1B1C0")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData(CircuitEventModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC40", Offset = "0xA19240", VA = "0x180A1AC40", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xA1ADA0", Offset = "0xA193A0", VA = "0x180A1ADA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD30", Offset = "0xA19330", VA = "0x180A1AD30", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE60", Offset = "0xA19460", VA = "0x180A1AE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFF0", Offset = "0xA195F0", VA = "0x180A1AFF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B050", Offset = "0xA19650", VA = "0x180A1B050", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB40", Offset = "0xA19140", VA = "0x180A1AB40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF00", Offset = "0xA19500", VA = "0x180A1AF00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE3E990", Offset = "0xE3CF90", VA = "0x180E3E990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE3E3A0", Offset = "0xE3C9A0", VA = "0x180E3E3A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE3F2B0", Offset = "0xE3D8B0", VA = "0x180E3F2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE3F1E0", Offset = "0xE3D7E0", VA = "0x180E3F1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE3F310", Offset = "0xE3D910", VA = "0x180E3F310", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xE3F410", Offset = "0xE3DA10", VA = "0x180E3F410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x3FAB40", Offset = "0x3F9140", VA = "0x1803FAB40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DC0", Offset = "0x5E63C0", VA = "0x1805E7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public bool OriginallyFromOtherInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D90", Offset = "0x5E6390", VA = "0x1805E7D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xC19B70", Offset = "0xC18170", VA = "0x180C19B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE3F0E0", Offset = "0xE3D6E0", VA = "0x180E3F0E0")]
		[DebuggerNonUserCode]
		public InventionPieceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE3F140", Offset = "0xE3D740", VA = "0x180E3F140")]
		[DebuggerNonUserCode]
		public InventionPieceData(InventionPieceData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE3EAF0", Offset = "0xE3D0F0", VA = "0x180E3EAF0", Slot = "9")]
		[DebuggerNonUserCode]
		public InventionPieceData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE3EC70", Offset = "0xE3D270", VA = "0x180E3EC70", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE3EBB0", Offset = "0xE3D1B0", VA = "0x180E3EBB0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InventionPieceData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE3ED70", Offset = "0xE3D370", VA = "0x180E3ED70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE3EEE0", Offset = "0xE3D4E0", VA = "0x180E3EEE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF40", Offset = "0xE3D540", VA = "0x180E3EF40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE3E9F0", Offset = "0xE3CFF0", VA = "0x180E3E9F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE3EE30", Offset = "0xE3D430", VA = "0x180E3EE30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA18FC0", Offset = "0xA175C0", VA = "0x180A18FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA18820", Offset = "0xA16E20", VA = "0x180A18820")]
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
			[Cpp2IlInjected.Address(RVA = "0xA19930", Offset = "0xA17F30", VA = "0x180A19930")]
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
			[Cpp2IlInjected.Address(RVA = "0xA19860", Offset = "0xA17E60", VA = "0x180A19860")]
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
			[Cpp2IlInjected.Address(RVA = "0xA19990", Offset = "0xA17F90", VA = "0x180A19990", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x457670", Offset = "0x455C70", VA = "0x180457670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x7D00A0", Offset = "0x7CE6A0", VA = "0x1807D00A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA19AE0", Offset = "0xA180E0", VA = "0x180A19AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public ByteString GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA19A90", Offset = "0xA18090", VA = "0x180A19A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA19750", Offset = "0xA17D50", VA = "0x180A19750")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA197C0", Offset = "0xA17DC0", VA = "0x180A197C0")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData(CircuitContextNodeOperationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA19130", Offset = "0xA17730", VA = "0x180A19130", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xA192B0", Offset = "0xA178B0", VA = "0x180A192B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xA19200", Offset = "0xA17800", VA = "0x180A19200", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextNodeOperationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xA193B0", Offset = "0xA179B0", VA = "0x180A193B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xA19540", Offset = "0xA17B40", VA = "0x180A19540", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xA195A0", Offset = "0xA17BA0", VA = "0x180A195A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xA19020", Offset = "0xA17620", VA = "0x180A19020", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA19480", Offset = "0xA17A80", VA = "0x180A19480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE40E40", Offset = "0xE3F440", VA = "0x180E40E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE3F960", Offset = "0xE3DF60", VA = "0x180E3F960")]
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
			[Cpp2IlInjected.Address(RVA = "0xE41A00", Offset = "0xE40000", VA = "0x180E41A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xE41930", Offset = "0xE3FF30", VA = "0x180E41930")]
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
			[Cpp2IlInjected.Address(RVA = "0xE41A60", Offset = "0xE40060", VA = "0x180E41A60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xE41B60", Offset = "0xE40160", VA = "0x180E41B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public ByteString ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xE41C00", Offset = "0xE40200", VA = "0x180E41C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CircuitObjectType ModifiedObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x3FAB40", Offset = "0x3F9140", VA = "0x1803FAB40")]
			get
			{
				return default(CircuitObjectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DC0", Offset = "0x5E63C0", VA = "0x1805E7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public ByteString ModificationHandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xE41BB0", Offset = "0xE401B0", VA = "0x180E41BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2E0", Offset = "0x3DB8E0", VA = "0x1803DD2E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xE41C50", Offset = "0xE40250", VA = "0x180E41C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE418B0", Offset = "0xE3FEB0", VA = "0x180E418B0")]
		[DebuggerNonUserCode]
		public ModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE41850", Offset = "0xE3FE50", VA = "0x180E41850")]
		[DebuggerNonUserCode]
		public ModificationData(ModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE41040", Offset = "0xE3F640", VA = "0x180E41040", Slot = "9")]
		[DebuggerNonUserCode]
		public ModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE410D0", Offset = "0xE3F6D0", VA = "0x180E410D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE41280", Offset = "0xE3F880", VA = "0x180E41280", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE413D0", Offset = "0xE3F9D0", VA = "0x180E413D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE415F0", Offset = "0xE3FBF0", VA = "0x180E415F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE41650", Offset = "0xE3FC50", VA = "0x180E41650", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE40EA0", Offset = "0xE3F4A0", VA = "0x180E40EA0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE414F0", Offset = "0xE3FAF0", VA = "0x180E414F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE46730", Offset = "0xE44D30", VA = "0x180E46730")]
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
			[Cpp2IlInjected.Address(RVA = "0xE46660", Offset = "0xE44C60", VA = "0x180E46660")]
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
			[Cpp2IlInjected.Address(RVA = "0xE46790", Offset = "0xE44D90", VA = "0x180E46790", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xE468A0", Offset = "0xE44EA0", VA = "0x180E468A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xE468F0", Offset = "0xE44EF0", VA = "0x180E468F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x6C9CE0", Offset = "0x6C82E0", VA = "0x1806C9CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x83C7A0", Offset = "0x83ADA0", VA = "0x18083C7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xE46940", Offset = "0xE44F40", VA = "0x180E46940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE46590", Offset = "0xE44B90", VA = "0x180E46590")]
		[DebuggerNonUserCode]
		public PortAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE46610", Offset = "0xE44C10", VA = "0x180E46610")]
		[DebuggerNonUserCode]
		public PortAddress(PortAddress other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE45EB0", Offset = "0xE444B0", VA = "0x180E45EB0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortAddress Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE45F30", Offset = "0xE44530", VA = "0x180E45F30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE460A0", Offset = "0xE446A0", VA = "0x180E460A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortAddress other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE461C0", Offset = "0xE447C0", VA = "0x180E461C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE46370", Offset = "0xE44970", VA = "0x180E46370", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE463D0", Offset = "0xE449D0", VA = "0x180E463D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE45D80", Offset = "0xE44380", VA = "0x180E45D80", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE462A0", Offset = "0xE448A0", VA = "0x180E462A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4B2A0", Offset = "0xE498A0", VA = "0x180E4B2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4B1D0", Offset = "0xE497D0", VA = "0x180E4B1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4B300", Offset = "0xE49900", VA = "0x180E4B300", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x457670", Offset = "0x455C70", VA = "0x180457670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x7D00A0", Offset = "0x7CE6A0", VA = "0x1807D00A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xE4B410", Offset = "0xE49A10", VA = "0x180E4B410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerNonUserCode]
		public NodePortData PortData
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE4B010", Offset = "0xE49610", VA = "0x180E4B010")]
		[DebuggerNonUserCode]
		public PortModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE4B070", Offset = "0xE49670", VA = "0x180E4B070")]
		[DebuggerNonUserCode]
		public PortModificationData(PortModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE4A8D0", Offset = "0xE48ED0", VA = "0x180E4A8D0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE4AB30", Offset = "0xE49130", VA = "0x180E4AB30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE4AA60", Offset = "0xE49060", VA = "0x180E4AA60", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE4AC40", Offset = "0xE49240", VA = "0x180E4AC40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE4AE10", Offset = "0xE49410", VA = "0x180E4AE10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE4AE70", Offset = "0xE49470", VA = "0x180E4AE70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE4A7D0", Offset = "0xE48DD0", VA = "0x180E4A7D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE4AD00", Offset = "0xE49300", VA = "0x180E4AD00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE487E0", Offset = "0xE46DE0", VA = "0x180E487E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE48710", Offset = "0xE46D10", VA = "0x180E48710")]
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
			[Cpp2IlInjected.Address(RVA = "0xE48840", Offset = "0xE46E40", VA = "0x180E48840", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xE48950", Offset = "0xE46F50", VA = "0x180E48950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE48600", Offset = "0xE46C00", VA = "0x180E48600")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE48660", Offset = "0xE46C60", VA = "0x180E48660")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData(PortDefaultValuePayloadData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE48190", Offset = "0xE46790", VA = "0x180E48190", Slot = "9")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE48260", Offset = "0xE46860", VA = "0x180E48260", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE48360", Offset = "0xE46960", VA = "0x180E48360", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortDefaultValuePayloadData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA25BF0", Offset = "0xA241F0", VA = "0x180A25BF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE484E0", Offset = "0xE46AE0", VA = "0x180E484E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA25DA0", Offset = "0xA243A0", VA = "0x180A25DA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE480D0", Offset = "0xE466D0", VA = "0x180E480D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE48410", Offset = "0xE46A10", VA = "0x180E48410", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE420B0", Offset = "0xE406B0", VA = "0x180E420B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE41CA0", Offset = "0xE402A0", VA = "0x180E41CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE42BA0", Offset = "0xE411A0", VA = "0x180E42BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE42AD0", Offset = "0xE410D0", VA = "0x180E42AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE42C00", Offset = "0xE41200", VA = "0x180E42C00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xE42DA0", Offset = "0xE413A0", VA = "0x180E42DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public ByteString SrcPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0xE42DF0", Offset = "0xE413F0", VA = "0x180E42DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[DebuggerNonUserCode]
		public ByteString DstNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xE42D00", Offset = "0xE41300", VA = "0x180E42D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		[DebuggerNonUserCode]
		public ByteString DstPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xE42D50", Offset = "0xE41350", VA = "0x180E42D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE42A50", Offset = "0xE41050", VA = "0x180E42A50")]
		[DebuggerNonUserCode]
		public NodeConnectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE42A00", Offset = "0xE41000", VA = "0x180E42A00")]
		[DebuggerNonUserCode]
		public NodeConnectionData(NodeConnectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE42280", Offset = "0xE40880", VA = "0x180E42280", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeConnectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE42450", Offset = "0xE40A50", VA = "0x180E42450", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE42300", Offset = "0xE40900", VA = "0x180E42300", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeConnectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE425F0", Offset = "0xE40BF0", VA = "0x180E425F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE427D0", Offset = "0xE40DD0", VA = "0x180E427D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE42830", Offset = "0xE40E30", VA = "0x180E42830", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE42110", Offset = "0xE40710", VA = "0x180E42110", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE426F0", Offset = "0xE40CF0", VA = "0x180E426F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE434B0", Offset = "0xE41AB0", VA = "0x180E434B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE42E40", Offset = "0xE41440", VA = "0x180E42E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xE43E80", Offset = "0xE42480", VA = "0x180E43E80")]
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
			[Cpp2IlInjected.Address(RVA = "0xE43DB0", Offset = "0xE423B0", VA = "0x180E43DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE43EE0", Offset = "0xE424E0", VA = "0x180E43EE0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xE43FE0", Offset = "0xE425E0", VA = "0x180E43FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public string PortName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xE44030", Offset = "0xE42630", VA = "0x180E44030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public CircuitTypeData GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE43C80", Offset = "0xE42280", VA = "0x180E43C80")]
		[DebuggerNonUserCode]
		public NodePortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE43CF0", Offset = "0xE422F0", VA = "0x180E43CF0")]
		[DebuggerNonUserCode]
		public NodePortData(NodePortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE43620", Offset = "0xE41C20", VA = "0x180E43620", Slot = "9")]
		[DebuggerNonUserCode]
		public NodePortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE43710", Offset = "0xE41D10", VA = "0x180E43710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE43820", Offset = "0xE41E20", VA = "0x180E43820", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodePortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE438F0", Offset = "0xE41EF0", VA = "0x180E438F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE43AA0", Offset = "0xE420A0", VA = "0x180E43AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE43B00", Offset = "0xE42100", VA = "0x180E43B00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE43510", Offset = "0xE41B10", VA = "0x180E43510", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE439A0", Offset = "0xE41FA0", VA = "0x180E439A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE44360", Offset = "0xE42960", VA = "0x180E44360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE44080", Offset = "0xE42680", VA = "0x180E44080")]
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
			[Cpp2IlInjected.Address(RVA = "0xE44A50", Offset = "0xE43050", VA = "0x180E44A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xE44980", Offset = "0xE42F80", VA = "0x180E44980")]
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
			[Cpp2IlInjected.Address(RVA = "0xE44AB0", Offset = "0xE430B0", VA = "0x180E44AB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xE44BB0", Offset = "0xE431B0", VA = "0x180E44BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE44920", Offset = "0xE42F20", VA = "0x180E44920")]
		[DebuggerNonUserCode]
		public NullableBytes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE448A0", Offset = "0xE42EA0", VA = "0x180E448A0")]
		[DebuggerNonUserCode]
		public NullableBytes(NullableBytes other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE44440", Offset = "0xE42A40", VA = "0x180E44440", Slot = "9")]
		[DebuggerNonUserCode]
		public NullableBytes Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE44580", Offset = "0xE42B80", VA = "0x180E44580", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE444F0", Offset = "0xE42AF0", VA = "0x180E444F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NullableBytes other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE44660", Offset = "0xE42C60", VA = "0x180E44660", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE44720", Offset = "0xE42D20", VA = "0x180E44720", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE44780", Offset = "0xE42D80", VA = "0x180E44780", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE443C0", Offset = "0xE429C0", VA = "0x180E443C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE446C0", Offset = "0xE42CC0", VA = "0x180E446C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE473F0", Offset = "0xE459F0", VA = "0x180E473F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE46990", Offset = "0xE44F90", VA = "0x180E46990")]
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
			[Cpp2IlInjected.Address(RVA = "0xE47F70", Offset = "0xE46570", VA = "0x180E47F70")]
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
			[Cpp2IlInjected.Address(RVA = "0xE47EA0", Offset = "0xE464A0", VA = "0x180E47EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE47FD0", Offset = "0xE465D0", VA = "0x180E47FD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE47DF0", Offset = "0xE463F0", VA = "0x180E47DF0")]
		[DebuggerNonUserCode]
		public PortCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE47D50", Offset = "0xE46350", VA = "0x180E47D50")]
		[DebuggerNonUserCode]
		public PortCollectionData(PortCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE47540", Offset = "0xE45B40", VA = "0x180E47540", Slot = "9")]
		[DebuggerNonUserCode]
		public PortCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE47610", Offset = "0xE45C10", VA = "0x180E47610", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE47720", Offset = "0xE45D20", VA = "0x180E47720", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE477D0", Offset = "0xE45DD0", VA = "0x180E477D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE479F0", Offset = "0xE45FF0", VA = "0x180E479F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE47A50", Offset = "0xE46050", VA = "0x180E47A50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE47450", Offset = "0xE45A50", VA = "0x180E47450", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE47860", Offset = "0xE45E60", VA = "0x180E47860", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA260E0", Offset = "0xA246E0", VA = "0x180A260E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA26060", Offset = "0xA24660", VA = "0x180A26060")]
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
			[Cpp2IlInjected.Address(RVA = "0xA26140", Offset = "0xA24740", VA = "0x180A26140", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xA26200", Offset = "0xA24800", VA = "0x180A26200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xA26000", Offset = "0xA24600", VA = "0x180A26000")]
		[DebuggerNonUserCode]
		public DefaultPortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA25EE0", Offset = "0xA244E0", VA = "0x180A25EE0")]
		[DebuggerNonUserCode]
		public DefaultPortData(DefaultPortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA258F0", Offset = "0xA23EF0", VA = "0x180A258F0", Slot = "9")]
		[DebuggerNonUserCode]
		public DefaultPortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA25AF0", Offset = "0xA240F0", VA = "0x180A25AF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA25A40", Offset = "0xA24040", VA = "0x180A25A40", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xA25BF0", Offset = "0xA241F0", VA = "0x180A25BF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xA25D40", Offset = "0xA24340", VA = "0x180A25D40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA25DA0", Offset = "0xA243A0", VA = "0x180A25DA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA25830", Offset = "0xA23E30", VA = "0x180A25830", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xA25C70", Offset = "0xA24270", VA = "0x180A25C70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE49570", Offset = "0xE47B70", VA = "0x180E49570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE489A0", Offset = "0xE46FA0", VA = "0x180E489A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4A530", Offset = "0xE48B30", VA = "0x180E4A530")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4A460", Offset = "0xE48A60", VA = "0x180E4A460")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4A590", Offset = "0xE48B90", VA = "0x180E4A590", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xE4A730", Offset = "0xE48D30", VA = "0x180E4A730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF00", Offset = "0x3DD500", VA = "0x1803DEF00")]
			get
			{
				return default(PortGroupType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x4F4190", Offset = "0x4F2790", VA = "0x1804F4190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public RepeatedField<NodePortData> NodePortDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0xE4A780", Offset = "0xE48D80", VA = "0x180E4A780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public CircuitTypeData ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2E0", Offset = "0x3DB8E0", VA = "0x1803DD2E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x3DD330", Offset = "0x3DB930", VA = "0x1803DD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		public uint NumberOfPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x46A230", Offset = "0x468830", VA = "0x18046A230")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x3F8070", Offset = "0x3F6670", VA = "0x1803F8070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x3DEFB0", Offset = "0x3DD5B0", VA = "0x1803DEFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0xE4A690", Offset = "0xE48C90", VA = "0x180E4A690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public string ExecName
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x4B47C0", Offset = "0x4B2DC0", VA = "0x1804B47C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xE4A6E0", Offset = "0xE48CE0", VA = "0x180E4A6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE4A3B0", Offset = "0xE489B0", VA = "0x180E4A3B0")]
		[DebuggerNonUserCode]
		public PortGroupData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE4A300", Offset = "0xE48900", VA = "0x180E4A300")]
		[DebuggerNonUserCode]
		public PortGroupData(PortGroupData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE49830", Offset = "0xE47E30", VA = "0x180E49830", Slot = "9")]
		[DebuggerNonUserCode]
		public PortGroupData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE49A50", Offset = "0xE48050", VA = "0x180E49A50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE49910", Offset = "0xE47F10", VA = "0x180E49910", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortGroupData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE49BD0", Offset = "0xE481D0", VA = "0x180E49BD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE49F30", Offset = "0xE48530", VA = "0x180E49F30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE49F90", Offset = "0xE48590", VA = "0x180E49F90", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE495D0", Offset = "0xE47BD0", VA = "0x180E495D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE49D40", Offset = "0xE48340", VA = "0x180E49D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4E120", Offset = "0xE4C720", VA = "0x180E4E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE4DDD0", Offset = "0xE4C3D0", VA = "0x180E4DDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4EA20", Offset = "0xE4D020", VA = "0x180E4EA20")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4E950", Offset = "0xE4CF50", VA = "0x180E4E950")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D080", VA = "0x180E4EA80", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE4E850", Offset = "0xE4CE50", VA = "0x180E4E850")]
		[DebuggerNonUserCode]
		public SwitchNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE4E8D0", Offset = "0xE4CED0", VA = "0x180E4E8D0")]
		[DebuggerNonUserCode]
		public SwitchNodeData(SwitchNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE4E240", Offset = "0xE4C840", VA = "0x180E4E240", Slot = "9")]
		[DebuggerNonUserCode]
		public SwitchNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE4E2F0", Offset = "0xE4C8F0", VA = "0x180E4E2F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE4E3E0", Offset = "0xE4C9E0", VA = "0x180E4E3E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE4E480", Offset = "0xE4CA80", VA = "0x180E4E480", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE4E620", Offset = "0xE4CC20", VA = "0x180E4E620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE4E680", Offset = "0xE4CC80", VA = "0x180E4E680", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE4E180", Offset = "0xE4C780", VA = "0x180E4E180", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE4E4E0", Offset = "0xE4CAE0", VA = "0x180E4E4E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE55340", Offset = "0xE53940", VA = "0x180E55340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE52930", Offset = "0xE50F30", VA = "0x180E52930")]
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
			[Cpp2IlInjected.Address(RVA = "0xA16140", Offset = "0xA14740", VA = "0x180A16140")]
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
			[Cpp2IlInjected.Address(RVA = "0xA160C0", Offset = "0xA146C0", VA = "0x180A160C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA161A0", Offset = "0xA147A0", VA = "0x180A161A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public CircuitTypeData OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA16060", Offset = "0xA14660", VA = "0x180A16060")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA15F90", Offset = "0xA14590", VA = "0x180A15F90")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData(AppliedGenericTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA158D0", Offset = "0xA13ED0", VA = "0x180A158D0", Slot = "9")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xA159D0", Offset = "0xA13FD0", VA = "0x180A159D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xA15AB0", Offset = "0xA140B0", VA = "0x180A15AB0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(AppliedGenericTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xA15B40", Offset = "0xA14140", VA = "0x180A15B40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xA15CF0", Offset = "0xA142F0", VA = "0x180A15CF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xA15D50", Offset = "0xA14350", VA = "0x180A15D50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xA157D0", Offset = "0xA13DD0", VA = "0x180A157D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xA15BC0", Offset = "0xA141C0", VA = "0x180A15BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA24AD0", Offset = "0xA230D0", VA = "0x180A24AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA24A50", Offset = "0xA23050", VA = "0x180A24A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA24B30", Offset = "0xA23130", VA = "0x180A24B30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AA0", Offset = "0x4A30A0", VA = "0x1804A4AA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x4F41A0", Offset = "0x4F27A0", VA = "0x1804F41A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData AppliedGenericType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public ClassTypeData ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		public FunctionTypeData FunctionType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD320", Offset = "0x3DB920", VA = "0x1803DD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData TypeParameterReferenceType
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2E0", Offset = "0x3DB8E0", VA = "0x1803DD2E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD330", Offset = "0x3DB930", VA = "0x1803DD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData TypeParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x3E4B70", Offset = "0x3E3170", VA = "0x1803E4B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x3E4C70", Offset = "0x3E3270", VA = "0x1803E4C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public CircuitTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA24760", Offset = "0xA22D60", VA = "0x180A24760")]
		[DebuggerNonUserCode]
		public CircuitTypeData(CircuitTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA23FF0", Offset = "0xA225F0", VA = "0x180A23FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xA24100", Offset = "0xA22700", VA = "0x180A24100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xA24050", Offset = "0xA22650", VA = "0x180A24050", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA24210", Offset = "0xA22810", VA = "0x180A24210", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA244F0", Offset = "0xA22AF0", VA = "0x180A244F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA24550", Offset = "0xA22B50", VA = "0x180A24550", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xA23E30", Offset = "0xA22430", VA = "0x180A23E30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xA24300", Offset = "0xA22900", VA = "0x180A24300", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA25710", Offset = "0xA23D10", VA = "0x180A25710")]
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
			[Cpp2IlInjected.Address(RVA = "0xA25690", Offset = "0xA23C90", VA = "0x180A25690")]
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
			[Cpp2IlInjected.Address(RVA = "0xA25770", Offset = "0xA23D70", VA = "0x180A25770", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD320", Offset = "0x3DB920", VA = "0x1803DD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA25560", Offset = "0xA23B60", VA = "0x180A25560")]
		[DebuggerNonUserCode]
		public ClassTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA255E0", Offset = "0xA23BE0", VA = "0x180A255E0")]
		[DebuggerNonUserCode]
		public ClassTypeData(ClassTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA24D20", Offset = "0xA23320", VA = "0x180A24D20", Slot = "9")]
		[DebuggerNonUserCode]
		public ClassTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA24E00", Offset = "0xA23400", VA = "0x180A24E00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA24F00", Offset = "0xA23500", VA = "0x180A24F00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ClassTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xA24FB0", Offset = "0xA235B0", VA = "0x180A24FB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA251F0", Offset = "0xA237F0", VA = "0x180A251F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA25250", Offset = "0xA23850", VA = "0x180A25250", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA24BF0", Offset = "0xA231F0", VA = "0x180A24BF0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA25060", Offset = "0xA23660", VA = "0x180A25060", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA28F60", VA = "0x180A2A960")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2A8E0", Offset = "0xA28EE0", VA = "0x180A2A8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2A9C0", Offset = "0xA28FC0", VA = "0x180A2A9C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2A830", Offset = "0xA28E30", VA = "0x180A2A830")]
		[DebuggerNonUserCode]
		public FunctionTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2A790", Offset = "0xA28D90", VA = "0x180A2A790")]
		[DebuggerNonUserCode]
		public FunctionTypeData(FunctionTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA29F20", Offset = "0xA28520", VA = "0x180A29F20", Slot = "9")]
		[DebuggerNonUserCode]
		public FunctionTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA29FF0", Offset = "0xA285F0", VA = "0x180A29FF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2A100", Offset = "0xA28700", VA = "0x180A2A100", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(FunctionTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2A1C0", Offset = "0xA287C0", VA = "0x180A2A1C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2A420", Offset = "0xA28A20", VA = "0x180A2A420", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A480", Offset = "0xA28A80", VA = "0x180A2A480", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA29E00", Offset = "0xA28400", VA = "0x180A29E00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2A270", Offset = "0xA28870", VA = "0x180A2A270", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45220", Offset = "0xE43820", VA = "0x180E45220")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45150", Offset = "0xE43750", VA = "0x180E45150")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45280", Offset = "0xE43880", VA = "0x180E45280", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public ParameterData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE450F0", Offset = "0xE436F0", VA = "0x180E450F0")]
		[DebuggerNonUserCode]
		public ParameterData(ParameterData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE44CC0", Offset = "0xE432C0", VA = "0x180E44CC0", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE44D90", Offset = "0xE43390", VA = "0x180E44D90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE44D50", Offset = "0xE43350", VA = "0x180E44D50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE44E20", Offset = "0xE43420", VA = "0x180E44E20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE44F50", Offset = "0xE43550", VA = "0x180E44F50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE44FB0", Offset = "0xE435B0", VA = "0x180E44FB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE44C00", Offset = "0xE43200", VA = "0x180E44C00", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE44E90", Offset = "0xE43490", VA = "0x180E44E90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45A60", Offset = "0xE44060", VA = "0x180E45A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45990", Offset = "0xE43F90", VA = "0x180E45990")]
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
			[Cpp2IlInjected.Address(RVA = "0xE45AC0", Offset = "0xE440C0", VA = "0x180E45AC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xE45BD0", Offset = "0xE441D0", VA = "0x180E45BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public ParameterData Value
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE45870", Offset = "0xE43E70", VA = "0x180E45870")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE458B0", Offset = "0xE43EB0", VA = "0x180E458B0")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData(ParameterWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE45490", Offset = "0xE43A90", VA = "0x180E45490", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE455A0", Offset = "0xE43BA0", VA = "0x180E455A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD30", Offset = "0xA19330", VA = "0x180A1AD30", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE60", Offset = "0xA19460", VA = "0x180A1AE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE45750", Offset = "0xE43D50", VA = "0x180E45750", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA1B050", Offset = "0xA19650", VA = "0x180A1B050", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE45390", Offset = "0xE43990", VA = "0x180E45390", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE45660", Offset = "0xE43C60", VA = "0x180E45660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4BBA0", Offset = "0xE4A1A0", VA = "0x180E4BBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4BAD0", Offset = "0xE4A0D0", VA = "0x180E4BAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4BC00", Offset = "0xE4A200", VA = "0x180E4BC00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DebuggerNonUserCode]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x6C9CE0", Offset = "0x6C82E0", VA = "0x1806C9CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x83C7A0", Offset = "0x83ADA0", VA = "0x18083C7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[DebuggerNonUserCode]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x83C6A0", Offset = "0x83ACA0", VA = "0x18083C6A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x9449C0", Offset = "0x942FC0", VA = "0x1809449C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public PropertyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE4BA70", Offset = "0xE4A070", VA = "0x180E4BA70")]
		[DebuggerNonUserCode]
		public PropertyData(PropertyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE4B520", Offset = "0xE49B20", VA = "0x180E4B520", Slot = "9")]
		[DebuggerNonUserCode]
		public PropertyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE4B5B0", Offset = "0xE49BB0", VA = "0x180E4B5B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE4B670", Offset = "0xE49C70", VA = "0x180E4B670", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PropertyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE4B6E0", Offset = "0xE49CE0", VA = "0x180E4B6E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE4B880", Offset = "0xE49E80", VA = "0x180E4B880", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE4B8E0", Offset = "0xE49EE0", VA = "0x180E4B8E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE4B460", Offset = "0xE49A60", VA = "0x180E4B460", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE4B780", Offset = "0xE49D80", VA = "0x180E4B780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C8D0", Offset = "0xE4AED0", VA = "0x180E4C8D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C800", Offset = "0xE4AE00", VA = "0x180E4C800")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4C930", Offset = "0xE4AF30", VA = "0x180E4C930", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2F0", Offset = "0x3DB8F0", VA = "0x1803DD2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
		[DebuggerNonUserCode]
		public ReturnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE450F0", Offset = "0xE436F0", VA = "0x180E450F0")]
		[DebuggerNonUserCode]
		public ReturnData(ReturnData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE4C500", Offset = "0xE4AB00", VA = "0x180E4C500", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xE4C590", Offset = "0xE4AB90", VA = "0x180E4C590", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE44D50", Offset = "0xE43350", VA = "0x180E44D50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE44E20", Offset = "0xE43420", VA = "0x180E44E20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE4C6E0", Offset = "0xE4ACE0", VA = "0x180E4C6E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE44FB0", Offset = "0xE435B0", VA = "0x180E44FB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE4C440", Offset = "0xE4AA40", VA = "0x180E4C440", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE4C620", Offset = "0xE4AC20", VA = "0x180E4C620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4D110", Offset = "0xE4B710", VA = "0x180E4D110")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4D040", Offset = "0xE4B640", VA = "0x180E4D040")]
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
			[Cpp2IlInjected.Address(RVA = "0xE4D170", Offset = "0xE4B770", VA = "0x180E4D170", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xE4D280", Offset = "0xE4B880", VA = "0x180E4D280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public ReturnData Value
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE4CF20", Offset = "0xE4B520", VA = "0x180E4CF20")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE4CF60", Offset = "0xE4B560", VA = "0x180E4CF60")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData(ReturnWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE4CB40", Offset = "0xE4B140", VA = "0x180E4CB40", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE4CC50", Offset = "0xE4B250", VA = "0x180E4CC50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD30", Offset = "0xA19330", VA = "0x180A1AD30", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE60", Offset = "0xA19460", VA = "0x180A1AE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE4CE00", Offset = "0xE4B400", VA = "0x180E4CE00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA1B050", Offset = "0xA19650", VA = "0x180A1B050", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE4CA40", Offset = "0xE4B040", VA = "0x180E4CA40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE4CD10", Offset = "0xE4B310", VA = "0x180E4CD10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE50F90", Offset = "0xE4F590", VA = "0x180E50F90")]
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
			[Cpp2IlInjected.Address(RVA = "0xE50EC0", Offset = "0xE4F4C0", VA = "0x180E50EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE50FF0", Offset = "0xE4F5F0", VA = "0x180E50FF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xE51100", Offset = "0xE4F700", VA = "0x180E51100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE50E80", Offset = "0xE4F480", VA = "0x180E50E80")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE50E10", Offset = "0xE4F410", VA = "0x180E50E10")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData(TypeParameterReferenceTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE50A20", Offset = "0xE4F020", VA = "0x180E50A20", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE50AB0", Offset = "0xE4F0B0", VA = "0x180E50AB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE50B40", Offset = "0xE4F140", VA = "0x180E50B40", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterReferenceTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE50B80", Offset = "0xE4F180", VA = "0x180E50B80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE50C70", Offset = "0xE4F270", VA = "0x180E50C70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE50CD0", Offset = "0xE4F2D0", VA = "0x180E50CD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4EF60", VA = "0x180E50960", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE50C00", Offset = "0xE4F200", VA = "0x180E50C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE51780", Offset = "0xE4FD80", VA = "0x180E51780")]
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
			[Cpp2IlInjected.Address(RVA = "0xE516B0", Offset = "0xE4FCB0", VA = "0x180E516B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE517E0", Offset = "0xE4FDE0", VA = "0x180E517E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x410250", Offset = "0x40E850", VA = "0x180410250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x3F59B0", Offset = "0x3F3FB0", VA = "0x1803F59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xE518F0", Offset = "0xE4FEF0", VA = "0x180E518F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public CircuitTypeData Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE51670", Offset = "0xE4FC70", VA = "0x180E51670")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE515E0", Offset = "0xE4FBE0", VA = "0x180E515E0")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData(TypeParameterTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE51250", Offset = "0xE4F850", VA = "0x180E51250", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE51310", Offset = "0xE4F910", VA = "0x180E51310", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD30", Offset = "0xA19330", VA = "0x180A1AD30", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE60", Offset = "0xA19460", VA = "0x180A1AE60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE514C0", Offset = "0xE4FAC0", VA = "0x180E514C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA1B050", Offset = "0xA19650", VA = "0x180A1B050", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE51150", Offset = "0xE4F750", VA = "0x180E51150", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE513D0", Offset = "0xE4F9D0", VA = "0x180E513D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57300", Offset = "0xE55900", VA = "0x180E57300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE56C90", Offset = "0xE55290", VA = "0x180E56C90")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57B20", Offset = "0xE56120", VA = "0x180E57B20")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57A50", Offset = "0xE56050", VA = "0x180E57A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xE57B80", Offset = "0xE56180", VA = "0x180E57B80", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B49C0", Offset = "0x4B2FC0", VA = "0x1804B49C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x4EF3D0", Offset = "0x4ED9D0", VA = "0x1804EF3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[DebuggerNonUserCode]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xE57C80", Offset = "0xE56280", VA = "0x180E57C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[DebuggerNonUserCode]
		public CircuitTypeData SymbolType
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x3DD310", Offset = "0x3DB910", VA = "0x1803DD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE57980", Offset = "0xE55F80", VA = "0x180E57980")]
		[DebuggerNonUserCode]
		public VariableNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE579C0", Offset = "0xE55FC0", VA = "0x180E579C0")]
		[DebuggerNonUserCode]
		public VariableNodeData(VariableNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE57430", Offset = "0xE55A30", VA = "0x180E57430", Slot = "9")]
		[DebuggerNonUserCode]
		public VariableNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE574F0", Offset = "0xE55AF0", VA = "0x180E574F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE575B0", Offset = "0xE55BB0", VA = "0x180E575B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(VariableNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE57620", Offset = "0xE55C20", VA = "0x180E57620", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE577B0", Offset = "0xE55DB0", VA = "0x180E577B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE57810", Offset = "0xE55E10", VA = "0x180E57810", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE57360", Offset = "0xE55960", VA = "0x180E57360", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE576C0", Offset = "0xE55CC0", VA = "0x180E576C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2310", Offset = "0x7C0910", VA = "0x1807C2310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x80C2A0", Offset = "0x80A8A0", VA = "0x18080C2A0")]
		public static TNode CreateNode<TNode>(CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId) where TNode : Node
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E20", Offset = "0x7B4420", VA = "0x1807B5E20")]
		internal static Node CreateNodeForDeserialize(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EE0", Offset = "0x7B44E0", VA = "0x1807B5EE0")]
		public static Node CreateNode(Type nodeType, CircuitContext context, [Optional] Guid? nodeGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x7B61B0", Offset = "0x7B47B0", VA = "0x1807B61B0")]
		public static Node CreateNode(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId, [Optional] Vector3? localPosition, [Optional] Quaternion? localRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AB0", Offset = "0x7B40B0", VA = "0x1807B5AB0")]
		private static Node ConstructNodeInternal(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D80", Offset = "0x7B5380", VA = "0x1807B6D80")]
		public static Guid GetTypeId(Type type)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7B6630", Offset = "0x7B4C30", VA = "0x1807B6630")]
		public static Type GetNodeType(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6370", Offset = "0x7B4970", VA = "0x1807B6370")]
		public static Tuple<string, Guid>[] GetNodeTypeOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E70", Offset = "0x7B5470", VA = "0x1807B6E70")]
		public static List<string> OrderedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6740", Offset = "0x7B4D40", VA = "0x1807B6740")]
		public static void GetNodesWithTags(TagSearchMethod tagSearchMethod, IEnumerable<string> activeTags, out HashSet<Type> filteredTypes, out IList<string> filteredTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x7B70C0", Offset = "0x7B56C0", VA = "0x1807B70C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D59B80", Offset = "0x2D58180", VA = "0x182D59B80")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD300", Offset = "0x3DB900", VA = "0x1803DD300")]
		public void Set(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D59B90", Offset = "0x2D58190", VA = "0x182D59B90")]
		public Box(in T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x49E930", Offset = "0x49CF30", VA = "0x18049E930")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF6140", Offset = "0x2DF4740", VA = "0x182DF6140")]
		public bool TryGetValue(TKey key, out HashSet<TVal> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5E60", Offset = "0x2DF4460", VA = "0x182DF5E60")]
		public void Add(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5F70", Offset = "0x2DF4570", VA = "0x182DF5F70")]
		public void Remove(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5F40", Offset = "0x2DF4540", VA = "0x182DF5F40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6180", Offset = "0x2DF4780", VA = "0x182DF6180")]
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
			[Cpp2IlInjected.Address(RVA = "0x10AA4B0", Offset = "0x10A8AB0", VA = "0x1810AA4B0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public TVal this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2DF67E0", Offset = "0x2DF4DE0", VA = "0x182DF67E0", Slot = "18")]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6830", Offset = "0x2DF4E30", VA = "0x182DF6830", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6750", Offset = "0x2DF4D50", VA = "0x182DF6750")]
		public SortedList(Func<TVal, TVal, int> valueComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6550", Offset = "0x2DF4B50", VA = "0x182DF6550", Slot = "16")]
		public IEnumerator<TVal> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2DF66B0", Offset = "0x2DF4CB0", VA = "0x182DF66B0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6200", Offset = "0x2DF4800", VA = "0x182DF6200", Slot = "11")]
		public void Add(TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5F40", Offset = "0x2DF4540", VA = "0x182DF5F40", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6460", Offset = "0x2DF4A60", VA = "0x182DF6460", Slot = "13")]
		public bool Contains(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF64A0", Offset = "0x2DF4AA0", VA = "0x182DF64A0", Slot = "14")]
		public void CopyTo(TVal[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6670", Offset = "0x2DF4C70", VA = "0x182DF6670", Slot = "15")]
		public bool Remove(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2980", Offset = "0x2BE0F80", VA = "0x182BE2980", Slot = "6")]
		public int IndexOf(TVal item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6620", Offset = "0x2DF4C20", VA = "0x182DF6620", Slot = "7")]
		public void Insert(int index, TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2B03D30", Offset = "0x2B02330", VA = "0x182B03D30", Slot = "8")]
		public void RemoveAt(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EditableValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x422CC0", Offset = "0x4212C0", VA = "0x180422CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x405350", Offset = "0x403950", VA = "0x180405350")]
		public EditableAddNamedPort([Optional] string filterMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecOutput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x422CC0", Offset = "0x4212C0", VA = "0x180422CC0")]
		public EditableAddExecOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecInput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x422CC0", Offset = "0x4212C0", VA = "0x180422CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C3E60", Offset = "0x7C2460", VA = "0x1807C3E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x80CDC0", Offset = "0x80B3C0", VA = "0x18080CDC0")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, [Optional] TVal defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x80CBC0", Offset = "0x80B1C0", VA = "0x18080CBC0")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, Func<TVal> defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F350", Offset = "0x2D7D950", VA = "0x182D7F350")]
		public static void AddToNestedList<K, V>(this IDictionary<K, List<V>> self, K key, V value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F090", Offset = "0x2D7D690", VA = "0x182D7F090")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DE7100", Offset = "0x2DE5700", VA = "0x182DE7100", Slot = "4")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2D32520", Offset = "0x2D30B20", VA = "0x182D32520", Slot = "5")]
			public int GetHashCode(T obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xCAFFF0", Offset = "0xCAE5F0", VA = "0x180CAFFF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x1308400", Offset = "0x1306A00", VA = "0x181308400")]
			[DebuggerHidden]
			public <Extend>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6C80", Offset = "0x2DF5280", VA = "0x182DF6C80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x2DF68D0", Offset = "0x2DF4ED0", VA = "0x182DF68D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6D50", Offset = "0x2DF5350", VA = "0x182DF6D50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6DA0", Offset = "0x2DF53A0", VA = "0x182DF6DA0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6C30", Offset = "0x2DF5230", VA = "0x182DF6C30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6B70", Offset = "0x2DF5170", VA = "0x182DF6B70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xDB25B0", Offset = "0xDB0BB0", VA = "0x180DB25B0", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2175A0", Offset = "0x2169A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FB870", Offset = "0x5F9E70", VA = "0x1805FB870", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2DF7670", Offset = "0x2DF5C70", VA = "0x182DF7670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1400600", Offset = "0x13FEC00", VA = "0x181400600")]
			[DebuggerHidden]
			public <MarkLast>d__18(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7B90", Offset = "0x2DF6190", VA = "0x182DF7B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7880", Offset = "0x2DF5E80", VA = "0x182DF7880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7C20", Offset = "0x2DF6220", VA = "0x182DF7C20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7B40", Offset = "0x2DF6140", VA = "0x182DF7B40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x2DF74D0", Offset = "0x2DF5AD0", VA = "0x182DF74D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, bool)> System.Collections.Generic.IEnumerable<(TValue,System.BooleanIsLast)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x157E220", Offset = "0x157C820", VA = "0x18157E220", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x218340", Offset = "0x217740")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FB870", Offset = "0x5F9E70", VA = "0x1805FB870", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2DF7670", Offset = "0x2DF5C70", VA = "0x182DF7670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x1400600", Offset = "0x13FEC00", VA = "0x181400600")]
			[DebuggerHidden]
			public <FormCurrentNextPairs>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7750", Offset = "0x2DF5D50", VA = "0x182DF7750", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x2DF6DF0", Offset = "0x2DF53F0", VA = "0x182DF6DF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x2DF77E0", Offset = "0x2DF5DE0", VA = "0x182DF77E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2DF75D0", Offset = "0x2DF5BD0", VA = "0x182DF75D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2DF74D0", Offset = "0x2DF5AD0", VA = "0x182DF74D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, T)> System.Collections.Generic.IEnumerable<(TCurrent,TNext)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x157E220", Offset = "0x157C820", VA = "0x18157E220", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x1308400", Offset = "0x1306A00", VA = "0x181308400")]
			[DebuggerHidden]
			public <Unique>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9960", Offset = "0x2DF7F60", VA = "0x182DF9960", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x2DF92B0", Offset = "0x2DF78B0", VA = "0x182DF92B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9B20", Offset = "0x2DF8120", VA = "0x182DF9B20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9740", Offset = "0x2DF7D40", VA = "0x182DF9740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9690", Offset = "0x2DF7C90", VA = "0x182DF9690", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x131C550", Offset = "0x131AB50", VA = "0x18131C550", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xBF4580", Offset = "0xBF2B80", VA = "0x180BF4580")]
		public static U AmountSwitch<U, T>(this IEnumerable<T> self, Func<U> zero, Func<T, U> one, Func<IEnumerable<T>, U> many)
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EC0", Offset = "0x7C24C0", VA = "0x1807C3EC0")]
		public static void CallAll(this IEnumerable<Action> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB9D0", Offset = "0x2BA9FD0", VA = "0x182BAB9D0")]
		public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] items)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x493660", Offset = "0x491C60", VA = "0x180493660")]
		public static string Delimit<T>(this IEnumerable<T> self, string delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x2BABB90", Offset = "0x2BAA190", VA = "0x182BABB90")]
		public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> self, Func<T, U> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x26A4CC0", Offset = "0x26A32C0", VA = "0x1826A4CC0")]
		[IteratorStateMachine(typeof(<Extend>d__8<, >))]
		public static IEnumerable<T> Extend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x58BB60", Offset = "0x58A160", VA = "0x18058BB60")]
		public static int FirstIndexOf<T>(this IEnumerable<T> self, Func<T, bool> pred)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x3BB900", Offset = "0x3B9F00", VA = "0x1803BB900")]
		public static T FirstOr<T>(this IEnumerable<T> self, T optB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FE00", Offset = "0x2D7E400", VA = "0x182D7FE00")]
		public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x58BE30", Offset = "0x58A430", VA = "0x18058BE30")]
		public static int SequenceGetHashCode<T>(this IEnumerable<T> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x2C21500", Offset = "0x2C1FB00", VA = "0x182C21500")]
		public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x2C213B0", Offset = "0x2C1F9B0", VA = "0x182C213B0")]
		public static bool Multiple<T>(this IEnumerable<T> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB9D0", Offset = "0x2BA9FD0", VA = "0x182BAB9D0")]
		public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x2696280", Offset = "0x2694880", VA = "0x182696280")]
		[IteratorStateMachine(typeof(<MarkLast>d__18<>))]
		public static IEnumerable<(T, bool)> MarkLast<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x2696280", Offset = "0x2694880", VA = "0x182696280")]
		[IteratorStateMachine(typeof(<FormCurrentNextPairs>d__19<>))]
		public static IEnumerable<(T, T)> FormCurrentNextPairs<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2BABCE0", Offset = "0x2BAA2E0", VA = "0x182BABCE0")]
		public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5D40", Offset = "0x2BB4340", VA = "0x182BB5D40")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5D40", Offset = "0x2BB4340", VA = "0x182BB5D40")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x214520", Offset = "0x213920")] this IEnumerable<(TKey, TValue)> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x49E930", Offset = "0x49CF30", VA = "0x18049E930")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x2694A80", Offset = "0x2693080", VA = "0x182694A80")]
		[IteratorStateMachine(typeof(<Unique>d__25<, >))]
		public static IEnumerable<T> Unique<T, U>(this IEnumerable<T> self, Func<T, U> uniqueSelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB800", Offset = "0x2BA9E00", VA = "0x182BAB800")]
		public static IEnumerable<(T, U)> Zip<T, U>(this IEnumerable<T> self, IEnumerable<U> other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x2694B10", Offset = "0x2693110", VA = "0x182694B10")]
		public static IEnumerable<V> ZipExtend<V, T, U>(this IEnumerable<T> self, IEnumerable<U> other, Func<T, U, V> zipper, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x2BABD10", Offset = "0x2BAA310", VA = "0x182BABD10")]
		public static IEnumerable<(T, U)> ZipExtend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class EquatableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2C21690", Offset = "0x2C1FC90", VA = "0x182C21690")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x1308400", Offset = "0x1306A00", VA = "0x181308400")]
			[DebuggerHidden]
			public <ToEnumerable>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2D326D0", Offset = "0x2D30CD0", VA = "0x182D326D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2DF86A0", Offset = "0x2DF6CA0", VA = "0x182DF86A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x2D32700", Offset = "0x2D30D00", VA = "0x182D32700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xEA4000", Offset = "0xEA2600", VA = "0x180EA4000", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x4A4AA0", Offset = "0x4A30A0", VA = "0x1804A4AA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2BF7660", Offset = "0x2BF5C60", VA = "0x182BF7660", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x13B5CE0", Offset = "0x13B42E0", VA = "0x1813B5CE0")]
			[DebuggerHidden]
			public <ToEnumerableInf>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x2DF84F0", Offset = "0x2DF6AF0", VA = "0x182DF84F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2DF85D0", Offset = "0x2DF6BD0", VA = "0x182DF85D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2DF8530", Offset = "0x2DF6B30", VA = "0x182DF8530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0xEA4000", Offset = "0xEA2600", VA = "0x180EA4000", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC000", Offset = "0x2BAA600", VA = "0x182BAC000")]
		[IteratorStateMachine(typeof(<ToEnumerable>d__0<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2BABF90", Offset = "0x2BAA590", VA = "0x182BABF90")]
		[IteratorStateMachine(typeof(<ToEnumerableInf>d__1<>))]
		public static IEnumerable<T> ToEnumerableInf<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x817940", Offset = "0x815F40", VA = "0x180817940")]
		public static T[] ToOneItemArray<T>(this T self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public static class IListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF40", Offset = "0x3BA540", VA = "0x1803BBF40")]
		public static T Last<T>(this IList<T> self)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1D0", Offset = "0x3BA7D0", VA = "0x1803BC1D0")]
		public static T SetLast<T>(this IList<T> self, T value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2D848A0", Offset = "0x2D82EA0", VA = "0x182D848A0")]
		public static void RemoveFirstWhere<T>(this IList<T> self, Func<T, bool> pred)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x2D84920", Offset = "0x2D82F20", VA = "0x182D84920")]
		public static void RemoveLast<T>(this IList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x3BC380", Offset = "0x3BA980", VA = "0x1803BC380")]
		public static T TakeLast<T>(this IList<T> self)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public static class IReadOnlyCollectionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x2C22D70", Offset = "0x2C21370", VA = "0x182C22D70")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public static class IReadOnlyDictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xBF5870", Offset = "0xBF3E70", VA = "0x180BF5870")]
		public static V GetValueOrDefault<V, K>(this IReadOnlyDictionary<K, V> self, K key)
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x496B90", Offset = "0x495190", VA = "0x180496B90")]
		public static V? GetValueOrNull<V, K>(this IReadOnlyDictionary<K, V> self, K key) where V : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class IReadOnlyListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3D0", Offset = "0x3BA9D0", VA = "0x1803BC3D0")]
		public static T GetValueOrDefault<T>(this IReadOnlyList<T> self, int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x496CC0", Offset = "0x4952C0", VA = "0x180496CC0")]
		public static T? GetValueOrNull<T>(this IReadOnlyList<T> self, int index) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public static class KeyValuePairExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x496E10", Offset = "0x495410", VA = "0x180496E10")]
		public static (TKey, TValue) Destructure<TKey, TValue>(this KeyValuePair<TKey, TValue> self)
		{
			return default((TKey, TValue));
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB9D0", Offset = "0x2BA9FD0", VA = "0x182BAB9D0")]
		public static IEnumerable<(TKey, TValue)> Destructure<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x245A5B0", Offset = "0x2458BB0", VA = "0x18245A5B0")]
		public static KeyValuePair<TKey, UValue> Revalue<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> self, UValue value)
		{
			return default(KeyValuePair<TKey, UValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public static class MapFieldExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2D88E20", Offset = "0x2D87420", VA = "0x182D88E20")]
		public static void AddRange<K, V>(this MapField<K, V> self, IEnumerable<KeyValuePair<K, V>> values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x7C52D0", Offset = "0x7C38D0", VA = "0x1807C52D0")]
		private static byte[] GetIntBytes(int intValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C90", Offset = "0x7C3290", VA = "0x1807C4C90")]
		public static Guid Combine(params Guid[] guidsToCombine)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5200", Offset = "0x7C3800", VA = "0x1807C5200")]
		public static Guid Create(Guid namespaceId, int index, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E00", Offset = "0x7C3400", VA = "0x1807C4E00")]
		public static Guid Create(Guid namespaceId, Guid nameGuid, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C5170", Offset = "0x7C3770", VA = "0x1807C5170")]
		public static Guid Create(Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E70", Offset = "0x7C3470", VA = "0x1807C4E70")]
		private static Guid Create(Guid namespaceId, byte[] nameBytes, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5350", Offset = "0x7C3950", VA = "0x1807C5350")]
		private static void SwapByteOrder(byte[] guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3B00", VA = "0x1807C5500")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class InternalNodeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x422CC0", Offset = "0x4212C0", VA = "0x180422CC0")]
		public InternalNodeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public static class NodeNameHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C57A0", Offset = "0x7C3DA0", VA = "0x1807C57A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F90", Offset = "0x2390", VA = "0x180002F90")]
		public PerfScope(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F90", Offset = "0x2390", VA = "0x180002F90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C6920", Offset = "0x7C4F20", VA = "0x1807C6920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C67D0", Offset = "0x7C4DD0", VA = "0x1807C67D0")]
		public RateLimiter(ITimeProvider timeProvider, int maxPerSecond, int initialSize = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C64F0", Offset = "0x7C4AF0", VA = "0x1807C64F0")]
		public bool CanExecute()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C6550", Offset = "0x7C4B50", VA = "0x1807C6550")]
		public bool ExecuteIfPossible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C6620", Offset = "0x7C4C20", VA = "0x1807C6620")]
		public void MarkExecution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C6690", Offset = "0x7C4C90", VA = "0x1807C6690")]
		private void TrimExpiredValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C07B0", Offset = "0x3BEDB0", VA = "0x1803C07B0")]
		public static T[] NewArray<T>(params T[] @params)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x245AD50", Offset = "0x2459350", VA = "0x18245AD50")]
		public static KeyValuePair<TKey, TValue> NewKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C760", Offset = "0x2C2AD60", VA = "0x182C2C760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B50", Offset = "0x7C6150", VA = "0x1807C7B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x422CC0", Offset = "0x4212C0", VA = "0x180422CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA19E00", Offset = "0xA18400", VA = "0x180A19E00")]
		public CircuitDataIdRemapper(bool remapIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA19D70", Offset = "0xA18370", VA = "0x180A19D70")]
		public CircuitDataIdRemapper(bool remapIds, Guid remapId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA19B30", Offset = "0xA18130", VA = "0x180A19B30")]
		public ByteString RemapByteStringId(ByteString originalByteString, bool onlyIfAlreadyMapped = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class CircuitTemplateHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA236A0", Offset = "0xA21CA0", VA = "0x180A236A0")]
		public static CircuitContextData RemapTemplate(CircuitContext intoContext, CircuitContextData originalTemplate, Guid remapId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA23980", Offset = "0xA21F80", VA = "0x180A23980")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA23A20", Offset = "0xA22020", VA = "0x180A23A20")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData, Matrix4x4 transformMatrix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA21B80", Offset = "0xA20180", VA = "0x180A21B80")]
		public static void AddInventionTracking(CircuitContextData templateData, ByteString instanceIdAsByteString, long inventionId, int versionNum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA23040", Offset = "0xA21640", VA = "0x180A23040")]
		public static void RemapTemplateIds(CircuitContext intoContext, CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA22C20", Offset = "0xA21220", VA = "0x180A22C20")]
		private static void RemapNodeInnerContextIdsRecursive(CircuitDataIdRemapper remapper, CircuitContextData context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA22060", Offset = "0xA20660", VA = "0x180A22060")]
		private static void RemapContextIdsRecursive(CircuitDataIdRemapper remapper, RepeatedField<CircuitContextData> contexts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA225E0", Offset = "0xA20BE0", VA = "0x180A225E0")]
		private static void RemapInventionInstanceIds(CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA22A60", Offset = "0xA21060", VA = "0x180A22A60")]
		private static void RemapNodeDataEventIds(IEnumerable<CircuitNodeData> nodeDatas, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA222E0", Offset = "0xA208E0", VA = "0x180A222E0")]
		private static void RemapEventRegistrationList(IList<EventRegistrationData> registrationList, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA237C0", Offset = "0xA21DC0", VA = "0x180A237C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C3E250", Offset = "0x2C3C850", VA = "0x182C3E250")]
		public static Create<TCircuitObject, TProtoElement> DoNotCreate<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E250", Offset = "0x2C3C850", VA = "0x182C3E250")]
		public static Dispose<TCircuitObject, TProtoElement> IDisposableDispose<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x49C470", Offset = "0x49AA70", VA = "0x18049C470")]
		public static void MergeDisposablesProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D99EB0", Offset = "0x2D984B0", VA = "0x182D99EB0")]
		public static void MergeProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, Dispose<TCircuitObject, TProtoElement> dispose, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x49C0D0", Offset = "0x49A6D0", VA = "0x18049C0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x130CE40", Offset = "0x130B440", VA = "0x18130CE40")]
			public Binder(Dependencies dependencies)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x2C2D4F0", Offset = "0x2C2BAF0", VA = "0x182C2D4F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C430", Offset = "0x1B830", VA = "0x18001C430")]
			public InjectionKey(Type injectedResourceType, string injectedResourceName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0xD0F20", Offset = "0xD0320", VA = "0x1800D0F20")]
			public bool Equals(InjectionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0xD0E60", Offset = "0xD0260", VA = "0x1800D0E60", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0xD0F90", Offset = "0xD0390", VA = "0x1800D0F90", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly Dictionary<InjectionKey, object> injectedInstancesDictionary;

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x49E930", Offset = "0x49CF30", VA = "0x18049E930")]
		public Binder<TInterface> Bind<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x80CAB0", Offset = "0x80B0B0", VA = "0x18080CAB0")]
		public TInterface GetDependency<TInterface>([Optional] string name)
		{
			return (TInterface)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA26250", Offset = "0xA24850", VA = "0x180A26250")]
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
				[Cpp2IlInjected.Address(RVA = "0x4B49C0", Offset = "0x4B2FC0", VA = "0x1804B49C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000842")]
				[Cpp2IlInjected.Address(RVA = "0x4EF3D0", Offset = "0x4ED9D0", VA = "0x1804EF3D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000843")]
				[Cpp2IlInjected.Address(RVA = "0x18E38A0", Offset = "0x18E1EA0", VA = "0x1818E38A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x2D61D80", Offset = "0x2D60380", VA = "0x182D61D80")]
			protected MemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x2D61D10", Offset = "0x2D60310", VA = "0x182D61D10", Slot = "6")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void DisposeInternal();

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x2D61B50", Offset = "0x2D60150", VA = "0x182D61B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D68B10", Offset = "0x2D67110", VA = "0x182D68B10")]
			public SymbolMemoryHandle(Memory memory, Guid address, string symbol, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x2D68810", Offset = "0x2D66E10", VA = "0x182D68810", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x2D689F0", Offset = "0x2D66FF0", VA = "0x182D689F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private class UnnamedMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x2D6C290", Offset = "0x2D6A890", VA = "0x182D6C290")]
			public UnnamedMemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x2D6BE70", Offset = "0x2D6A470", VA = "0x182D6BE70", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x2D6C050", Offset = "0x2D6A650", VA = "0x182D6C050", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C9EA00", Offset = "0x2C9D000", VA = "0x182C9EA00")]
		public Memory(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D8B0", Offset = "0x2C9BEB0", VA = "0x182C9D8B0")]
		private void OnGuidsRemapped(IReadOnlyDictionary<Guid, ShortenedGuidMap.GuidRemapping> remappedguids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x499F70", Offset = "0x498570", VA = "0x180499F70")]
		private void RemapDictionary<T>(Dictionary<Guid, RateLimitedSynchronizedField<T>> synchronizedFieldDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DC90", Offset = "0x2C9C290", VA = "0x182C9DC90")]
		private void OnHandleReleased(IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D960", Offset = "0x2C9BF60", VA = "0x182C9D960")]
		private void OnHandleReleased(string symbol, IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2C34550", Offset = "0x2C32B50", VA = "0x182C34550")]
		public IMemoryHandle AllocateNamedVariable<T>(string symbol, Guid defaultAddress, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2C35830", Offset = "0x2C33E30", VA = "0x182C35830")]
		public IMemoryHandle AllocateUnnamedVariable<T>(Guid address, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x7937B0", Offset = "0x791DB0", VA = "0x1807937B0")]
		private Guid InitializeLocal<T>(Guid address, Dictionary<Guid, T> dictionary, T value)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x791F30", VA = "0x180793930")]
		private Guid InitializeSynchronized<T>(Guid address, Dictionary<Guid, RateLimitedSynchronizedField<T>> dictionary, T initialValue)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x499F10", Offset = "0x498510", VA = "0x180499F10")]
		private void DeallocateSynchronized<T>(Guid address, RateLimitedSynchronizedField<T> field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x2C27000", Offset = "0x2C25600", VA = "0x182C27000")]
		private bool AllocateOrReference<T>(Guid defaultAddress, CircuitType valueType, Dictionary<Guid, T> typeMemory, out IMemoryHandle handle, [Optional] string variableName, [Optional] Action<Guid, T> customDispose)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x2C34B10", Offset = "0x2C33110", VA = "0x182C34B10")]
		private IMemoryHandle AllocateOrReferenceLocal<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, T> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x2C35120", Offset = "0x2C33720", VA = "0x182C35120")]
		private IMemoryHandle AllocateOrReferenceSynchronized<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, RateLimitedSynchronizedField<T>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CCE0", Offset = "0x2C9B2E0", VA = "0x182C9CCE0")]
		public IMemoryHandle AllocateBoolean(Guid defaultAddress, bool value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CD90", Offset = "0x2C9B390", VA = "0x182C9CD90")]
		public IMemoryHandle AllocateInt32(Guid defaultAddress, int value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CEF0", Offset = "0x2C9B4F0", VA = "0x182C9CEF0")]
		public IMemoryHandle AllocateSingle(Guid defaultAddress, float value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CFA0", Offset = "0x2C9B5A0", VA = "0x182C9CFA0")]
		public IMemoryHandle AllocateString(Guid defaultAddress, string value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CE40", Offset = "0x2C9B440", VA = "0x182C9CE40")]
		public IMemoryHandle AllocateOrReferenceSynchronizedBoolean(Guid defaultAddress, bool initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D050", Offset = "0x2C9B650", VA = "0x182C9D050")]
		public IMemoryHandle AllocateSynchronizedInt32(Guid defaultAddress, int initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D100", Offset = "0x2C9B700", VA = "0x182C9D100")]
		public IMemoryHandle AllocateSynchronizedSingle(Guid defaultAddress, float initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D1B0", Offset = "0x2C9B7B0", VA = "0x182C9D1B0")]
		public IMemoryHandle AllocateSynchronizedString(Guid defaultAddress, string initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D530", Offset = "0x2C9BB30", VA = "0x182C9D530")]
		public bool GetBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D590", Offset = "0x2C9BB90", VA = "0x182C9D590")]
		public int GetInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D5F0", Offset = "0x2C9BBF0", VA = "0x182C9D5F0")]
		public float GetSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D650", Offset = "0x2C9BC50", VA = "0x182C9D650")]
		public string GetString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D6B0", Offset = "0x2C9BCB0", VA = "0x182C9D6B0")]
		public bool GetSynchronizedBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D730", Offset = "0x2C9BD30", VA = "0x182C9D730")]
		public int GetSynchronizedInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D7B0", Offset = "0x2C9BDB0", VA = "0x182C9D7B0")]
		public float GetSynchronizedSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D830", Offset = "0x2C9BE30", VA = "0x182C9D830")]
		public string GetSynchronizedString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x2C27E40", Offset = "0x2C26440", VA = "0x182C27E40")]
		private bool SetValue<T>(Guid id, T value, Dictionary<Guid, T> values) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E3F0", Offset = "0x2C9C9F0", VA = "0x182C9E3F0")]
		public bool SetBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E460", Offset = "0x2C9CA60", VA = "0x182C9E460")]
		public bool SetInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E4D0", Offset = "0x2C9CAD0", VA = "0x182C9E4D0")]
		public bool SetSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E540", Offset = "0x2C9CB40", VA = "0x182C9E540")]
		public bool SetString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E5F0", Offset = "0x2C9CBF0", VA = "0x182C9E5F0")]
		public bool SetSynchronizedBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E680", Offset = "0x2C9CC80", VA = "0x182C9E680")]
		public bool SetSynchronizedInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E710", Offset = "0x2C9CD10", VA = "0x182C9E710")]
		public bool SetSynchronizedSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E7A0", Offset = "0x2C9CDA0", VA = "0x182C9E7A0")]
		public bool SetSynchronizedString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DFF0", Offset = "0x2C9C5F0", VA = "0x182C9DFF0")]
		public void RegisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E980", Offset = "0x2C9CF80", VA = "0x182C9E980")]
		public void UnregisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DDB0", Offset = "0x2C9C3B0", VA = "0x182C9DDB0")]
		private void OnValueChanged(RateLimiter rateLimiter, Guid address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E860", Offset = "0x2C9CE60", VA = "0x182C9E860")]
		private static string Truncate(string originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E8B0", Offset = "0x2C9CEB0", VA = "0x182C9E8B0")]
		public bool TryGetNamedVariable(string varName, out Guid variableAddress, out CircuitType variableType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E070", Offset = "0x2C9C670", VA = "0x182C9E070")]
		public void RemapNamedVariables(CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D260", Offset = "0x2C9B860", VA = "0x182C9D260")]
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
			[Cpp2IlInjected.Address(RVA = "0x13370", Offset = "0x12770", VA = "0x180013370")]
			public TypeConversionKey(TypeKind fromKind, TypeKind toKind)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xE3D90", Offset = "0xE3190", VA = "0x1800E3D90")]
			public bool Equals(TypeConversionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x350DB0", Offset = "0x3501B0", VA = "0x180350DB0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x350E40", Offset = "0x350240", VA = "0x180350E40", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C9F570", Offset = "0x2C9DB70", VA = "0x182C9F570")]
		public static bool IsConvertableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F300", Offset = "0x2C9D900", VA = "0x182C9F300")]
		public static Func<Node, Node, (Node, ITypeConversionNode)> GetConverterConstructor(CircuitType from, CircuitType to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F870", Offset = "0x2C9DE70", VA = "0x182C9F870")]
		public static bool SupportsDefaultValue(CircuitType signalType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F630", Offset = "0x2C9DC30", VA = "0x182C9F630")]
		public static void RegisterFriendlyName(Guid name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F420", Offset = "0x2C9DA20", VA = "0x182C9F420")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CA1760", Offset = "0x2C9FD60", VA = "0x182CA1760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0050", Offset = "0x2C9E650", VA = "0x182CA0050", Slot = "4")]
		public bool AllowsMultipleInputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0080", Offset = "0x2C9E680", VA = "0x182CA0080", Slot = "5")]
		public bool AllowsMultipleOutputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0980", Offset = "0x2C9EF80", VA = "0x182CA0980", Slot = "6")]
		public bool IsAssignableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0250", Offset = "0x2C9E850", VA = "0x182CA0250")]
		private bool IsAssignableToInternal(CircuitType from, CircuitType to, IReadOnlyList<CircuitType> fromTypeParameterAssignments, IReadOnlyList<CircuitType> toTypeParameterAssignments)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0A10", Offset = "0x2C9F010", VA = "0x182CA0A10", Slot = "7")]
		public CircuitType Narrow(CircuitType typeA, CircuitType typeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2CA00B0", Offset = "0x2C9E6B0", VA = "0x182CA00B0")]
		private static (CircuitType, IReadOnlyList<CircuitType>, bool) ExtractTypeSpecifics(CircuitType type, IReadOnlyList<CircuitType> lastAssignments)
		{
			return default((CircuitType, IReadOnlyList<CircuitType>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C9F210", Offset = "0x2C9D810", VA = "0x182C9F210")]
			public TransformModificationHandler(CircuitObject modifiedObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EE60", Offset = "0x2C9D460", VA = "0x182C9EE60")]
			public ICircuitObjectModification CreateModification(Vector3? newLocalPosition, Quaternion? newLocalRotation)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EF90", Offset = "0x2C9D590", VA = "0x182C9EF90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B70", Offset = "0x3E3170", VA = "0x1803E4B70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B80", Offset = "0x3E3180", VA = "0x1803E4B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x3E4C80", Offset = "0x3E3280", VA = "0x1803E4C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool CanSetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x2C92830", Offset = "0x2C90E30", VA = "0x182C92830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x2C927D0", Offset = "0x2C90DD0", VA = "0x182C927D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action OnDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x2C92690", Offset = "0x2C90C90", VA = "0x182C92690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0x2C92880", Offset = "0x2C90E80", VA = "0x182C92880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x2C92730", Offset = "0x2C90D30", VA = "0x182C92730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x2C92920", Offset = "0x2C90F20", VA = "0x182C92920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2C92510", Offset = "0x2C90B10", VA = "0x182C92510")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2C92310", Offset = "0x2C90910", VA = "0x182C92310")]
		internal void SetCanDestroy(bool canDestroy, CircuitTokenFlag.CircuitToken token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2C92170", Offset = "0x2C90770", VA = "0x182C92170")]
		public void RequestTransformChange(Vector3? newPosition, Quaternion? newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x491960", Offset = "0x48FF60", VA = "0x180491960")]
		public void RegisterModificationHandler<T>(T handler) where T : ICircuitObjectModificationHandler
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2C1F0A0", Offset = "0x2C1D6A0", VA = "0x182C1F0A0")]
		public bool TryGetModificationHandler<T>(out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2C1F170", Offset = "0x2C1D770", VA = "0x182C1F170")]
		public bool TryGetModificationHandler<T>(Guid handlerId, out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2C924B0", Offset = "0x2C90AB0", VA = "0x182C924B0")]
		public bool UnregisterModificationHandler(Guid guid)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2C91FA0", Offset = "0x2C905A0", VA = "0x182C91FA0")]
		public void HandleModificationRequest(Guid modificationHandlerId, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2C91F50", Offset = "0x2C90550", VA = "0x182C91F50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C920B0", Offset = "0x2C906B0", VA = "0x182C920B0")]
		public bool RequestChangeName(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x20D0E40", Offset = "0x20CF440", VA = "0x1820D0E40", Slot = "8")]
		public virtual bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x22FDFC0", Offset = "0x22FC5C0", VA = "0x1822FDFC0")]
		protected void RaiseOnNameChangedEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public abstract class CircuitObject<TProto> : CircuitObject, ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D2D0", Offset = "0x2D5B8D0", VA = "0x182D5D2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x350490", Offset = "0x34F890", VA = "0x180350490")]
		public CircuitObjectId(Guid contextId, Guid objectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x350410", Offset = "0x34F810", VA = "0x180350410", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2DCF0", Offset = "0xA2C2F0", VA = "0x180A2DCF0")]
		protected ExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA2DD20", Offset = "0xA2C320", VA = "0x180A2DD20")]
		protected ExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x2C94DA0", Offset = "0x2C933A0", VA = "0x182C94DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C95030", Offset = "0x2C93630", VA = "0x182C95030", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x4A4AA0", Offset = "0x4A30A0", VA = "0x1804A4AA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x4B49C0", Offset = "0x4B2FC0", VA = "0x1804B49C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x66FE40", Offset = "0x66E440", VA = "0x18066FE40")]
		public ExecutionScope([NotNull] CircuitContext executionScopeContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C94F90", Offset = "0x2C93590", VA = "0x182C94F90", Slot = "7")]
		public bool MarkExecution()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2845EE0", Offset = "0x28444E0", VA = "0x182845EE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x13F60", Offset = "0x13360", VA = "0x180013F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x350D20", Offset = "0x350120", VA = "0x180350D20")]
		private DisconnectionResult(DisconnectionResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x1175F0", Offset = "0x1169F0", VA = "0x1801175F0")]
		private DisconnectionResult(int indexOfDstInSrc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C94120", Offset = "0x2C92720", VA = "0x182C94120")]
		public static DisconnectionResult Ok(int indexOfDstInSrc)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C94100", Offset = "0x2C92700", VA = "0x182C94100")]
		public static DisconnectionResult ErrorNull()
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C940E0", Offset = "0x2C926E0", VA = "0x182C940E0")]
		public static DisconnectionResult ErrorNotConnected()
		{
			return default(DisconnectionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public static class GraphOp
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C99450", Offset = "0x2C97A50", VA = "0x182C99450")]
		private static ConnectionResult CanConnect(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C99A50", Offset = "0x2C98050", VA = "0x182C99A50")]
		public static ConnectionResult ConnectByRequest(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C99F80", Offset = "0x2C98580", VA = "0x182C99F80")]
		internal static ConnectionResult ConnectLocal(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A4A0", Offset = "0x2C98AA0", VA = "0x182C9A4A0")]
		internal static void ConnectLocal(CircuitContext context, Guid srcNodeId, Guid srcPortId, Guid dstNodeId, Guid dstPortId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C99CA0", Offset = "0x2C982A0", VA = "0x182C99CA0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) ConnectCore(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A660", Offset = "0x2C98C60", VA = "0x182C9A660")]
		private static bool CreatesCycle(Node srcNode, Node dstNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C0D0", Offset = "0x2C9A6D0", VA = "0x182C9C0D0")]
		private static bool IsConnected(Node srcNode, Node dstNode, OutputPort srcPort, InputPort dstPort)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C999E0", Offset = "0x2C97FE0", VA = "0x182C999E0")]
		private static DisconnectionResult CanDisconnect(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B7A0", Offset = "0x2C99DA0", VA = "0x182C9B7A0")]
		internal static DisconnectionResult DisconnectLocal(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B0F0", Offset = "0x2C996F0", VA = "0x182C9B0F0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectCore(OutputPort srcPort, InputPort dstPort, int indexOfDstInSrc)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BE70", Offset = "0x2C9A470", VA = "0x182C9BE70")]
		private static int IndexOfDstInSrc(OutputPort srcPort, InputPort dstPort)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B3D0", Offset = "0x2C999D0", VA = "0x182C9B3D0")]
		private static (IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>) DisconnectForConnect(OutputPort srcPort, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C999C0", Offset = "0x2C97FC0", VA = "0x182C999C0")]
		private static bool CanDisconnectPort(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B860", Offset = "0x2C99E60", VA = "0x182C9B860")]
		public static bool DisconnectPortByRequest(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BE00", Offset = "0x2C9A400", VA = "0x182C9BE00")]
		internal static bool DisconnectPortLocal(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BC70", Offset = "0x2C9A270", VA = "0x182C9BC70")]
		internal static void DisconnectPortLocal(CircuitContext context, Guid nodeId, Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BA90", Offset = "0x2C9A090", VA = "0x182C9BA90")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectPortCore(PortBase port)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AE30", Offset = "0x2C99430", VA = "0x182C9AE30")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyPortGroupCore(IPortGroup portGroup)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C99940", Offset = "0x2C97F40", VA = "0x182C99940")]
		private static bool CanDestroyNode(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AD70", Offset = "0x2C99370", VA = "0x182C9AD70")]
		internal static bool DestroyNodeLocal(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A800", Offset = "0x2C98E00", VA = "0x182C9A800")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyNodeCore(Node node)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BF30", Offset = "0x2C9A530", VA = "0x182C9BF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF9F30", Offset = "0x2CF8530", VA = "0x182CF9F30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		internal Dictionary<string, CircuitType> LastTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x754720", Offset = "0x752D20", VA = "0x180754720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x837240", Offset = "0x835840", VA = "0x180837240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public IEnumerable<InputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x2CF9EE0", Offset = "0x2CF84E0", VA = "0x182CF9EE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public IEnumerable<InputPort> InputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0x2CF9DD0", Offset = "0x2CF83D0", VA = "0x182CF9DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public IEnumerable<OutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x2CFA110", Offset = "0x2CF8710", VA = "0x182CFA110", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IEnumerable<OutputPort> OutputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x2CFA000", Offset = "0x2CF8600", VA = "0x182CFA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public IEnumerable<PortGroupBase<InputPort>> InputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x2CF9D80", Offset = "0x2CF8380", VA = "0x182CF9D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public IEnumerable<PortGroupBase<OutputPort>> OutputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x2CF9FB0", Offset = "0x2CF85B0", VA = "0x182CF9FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x830FF0", Offset = "0x82F5F0", VA = "0x180830FF0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CFA200", Offset = "0x2CF8800", VA = "0x182CFA200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action OnPortsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x2CF9CE0", Offset = "0x2CF82E0", VA = "0x182CF9CE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x2CFA160", Offset = "0x2CF8760", VA = "0x182CFA160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CF94E0", Offset = "0x2CF7AE0", VA = "0x182CF94E0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8A50", Offset = "0x2CF7050", VA = "0x182CF8A50")]
		public string GetNodeName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9910", Offset = "0x2CF7F10", VA = "0x182CF9910")]
		protected Node(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8B70", Offset = "0x2CF7170", VA = "0x182CF8B70")]
		public bool RequestSetPortDefaultValue(PortBase port, CircuitSignal value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8A60", Offset = "0x2CF7060", VA = "0x182CF8A60", Slot = "16")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9530", Offset = "0x2CF7B30", VA = "0x182CF9530")]
		public void SetSpecificTypes(IEnumerable<(string, CircuitType)> genericTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9870", Offset = "0x2CF7E70", VA = "0x182CF9870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "17")]
		protected virtual void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8EE0", Offset = "0x2CF74E0", VA = "0x182CF8EE0", Slot = "10")]
		public sealed override CircuitNodeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8CE0", Offset = "0x2CF72E0", VA = "0x182CF8CE0")]
		[CanBeNull]
		private InventionPieceData SerializeInventionPieceData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2CF85A0", Offset = "0x2CF6BA0", VA = "0x182CF85A0", Slot = "11")]
		public sealed override void DeserializeFromProtobuf(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7E60", Offset = "0x2CF6460", VA = "0x182CF7E60")]
		public void DeserializeConnections(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "18")]
		protected virtual void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "19")]
		protected virtual void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CF88B0", Offset = "0x2CF6EB0", VA = "0x182CF88B0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CF89B0", Offset = "0x2CF6FB0", VA = "0x182CF89B0", Slot = "20")]
		protected internal virtual (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8B30", Offset = "0x2CF7130", VA = "0x182CF8B30")]
		internal void RaiseOnPortsUpdatedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8A20", Offset = "0x2CF7020", VA = "0x182CF8A20", Slot = "21")]
		public virtual IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7DC0", Offset = "0x2CF63C0", VA = "0x182CF7DC0")]
		protected static FunctionType CTypeParams(params TypeParamConstrainedOrNot[] typeParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7BE0", Offset = "0x2CF61E0", VA = "0x182CF7BE0")]
		private static InputPort BuildInputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7CD0", Offset = "0x2CF62D0", VA = "0x182CF7CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x7E3720", Offset = "0x7E1D20", VA = "0x1807E3720")]
		public NodeConnection([NotNull] Node srcNode, [NotNull] OutputPort srcPort, [NotNull] Node dstNode, [NotNull] InputPort dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2CF78A0", Offset = "0x2CF5EA0", VA = "0x182CF78A0")]
		protected bool Equals(NodeConnection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7790", Offset = "0x2CF5D90", VA = "0x182CF7790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2CF78E0", Offset = "0x2CF5EE0", VA = "0x182CF78E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xCABB30", Offset = "0xCAA130", VA = "0x180CABB30")]
		public static bool operator !=(NodeConnection left, NodeConnection right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7A70", Offset = "0x2CF6070", VA = "0x182CF7A70", Slot = "9")]
		public NodeConnectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7740", Offset = "0x2CF5D40", VA = "0x182CF7740", Slot = "8")]
		public void DeserializeFromProtobuf(NodeConnectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2CF79A0", Offset = "0x2CF5FA0", VA = "0x182CF79A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC400", Offset = "0x3EAA00", VA = "0x1803EC400", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x2D59B00", Offset = "0x2D58100", VA = "0x182D59B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x2D59AA0", Offset = "0x2D580A0", VA = "0x182D59AA0")]
		public BasicPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x2D597D0", Offset = "0x2D57DD0", VA = "0x182D597D0")]
		internal void AddPortLocal(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2D59800", Offset = "0x2D57E00", VA = "0x182D59800", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2D59920", Offset = "0x2D57F20", VA = "0x182D59920", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D9390", Offset = "0x5D7990", VA = "0x1805D9390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2D5DBF0", Offset = "0x2D5C1F0", VA = "0x182D5DBF0")]
		public DynamicPortGroupModificationHandler(Node node, PortGroupBase<TPort> portGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D780", Offset = "0x2D5BD80", VA = "0x182D5D780")]
		public ICircuitObjectModification CreateAddModification(Guid portId, string portName, CircuitType portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D950", Offset = "0x2D5BF50", VA = "0x182D5D950")]
		public ICircuitObjectModification CreateRemoveModification(Guid portId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2D5DAC0", Offset = "0x2D5C0C0", VA = "0x182D5DAC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF0E0", Offset = "0x3DD6E0", VA = "0x1803DF0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA579D0", Offset = "0xA55FD0", VA = "0x180A579D0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E070", Offset = "0x2D5C670", VA = "0x182D5E070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2D5DE00", Offset = "0x2D5C400", VA = "0x182D5DE00")]
		public ExecNameBasedPortGroup(string execPortName, PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2D5DCD0", Offset = "0x2D5C2D0", VA = "0x182D5DCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x754720", Offset = "0x752D20", VA = "0x180754720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x478230", Offset = "0x476830", VA = "0x180478230", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E070", Offset = "0x2D5C670", VA = "0x182D5E070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x2D60F00", Offset = "0x2D5F500", VA = "0x182D60F00", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x2D60D60", Offset = "0x2D5F360", VA = "0x182D60D60")]
		public IndexBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory, string elementName, CircuitTypeOrString elementPortType, int minPortCount = 0, int maxPortCount = 64)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2D60620", Offset = "0x2D5EC20", VA = "0x182D60620", Slot = "16")]
		public override bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2D60420", Offset = "0x2D5EA20", VA = "0x182D60420")]
		public TPort AddPortLocal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2D60990", Offset = "0x2D5EF90", VA = "0x182D60990")]
		private void RemoveLastPortLocal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2D60BC0", Offset = "0x2D5F1C0", VA = "0x182D60BC0", Slot = "18")]
		protected override void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2D606E0", Offset = "0x2D5ECE0", VA = "0x182D606E0", Slot = "19")]
		protected override void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2D60A70", Offset = "0x2D5F070", VA = "0x182D60A70", Slot = "24")]
		public void RequestAddPort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2D608F0", Offset = "0x2D5EEF0", VA = "0x182D608F0", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x2D60920", Offset = "0x2D5EF20", VA = "0x182D60920", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF4690", Offset = "0x2CF2C90", VA = "0x182CF4690", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private OutputPort FirstConnectedPort
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4630", Offset = "0x2CF2C30", VA = "0x182CF4630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4590", Offset = "0x2CF2B90", VA = "0x182CF4590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool SupportsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x2CF47B0", Offset = "0x2CF2DB0", VA = "0x182CF47B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool HasCustomDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x2CF46E0", Offset = "0x2CF2CE0", VA = "0x182CF46E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public CircuitSignal DefaultSignalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4610", Offset = "0x2CF2C10", VA = "0x182CF4610")]
			get
			{
				return default(CircuitSignal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x2CF48D0", Offset = "0x2CF2ED0", VA = "0x182CF48D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action OnDefaultSignalValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x2CF44F0", Offset = "0x2CF2AF0", VA = "0x182CF44F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4830", Offset = "0x2CF2E30", VA = "0x182CF4830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xB7E0A0", Offset = "0xB7C6A0", VA = "0x180B7E0A0", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4490", Offset = "0x2CF2A90", VA = "0x182CF4490")]
		public InputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, bool canSet = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF41C0", Offset = "0x2CF27C0", VA = "0x182CF41C0", Slot = "12")]
		protected override void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4110", Offset = "0x2CF2710", VA = "0x182CF4110", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4400", Offset = "0x2CF2A00", VA = "0x182CF4400", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x2CF40A0", Offset = "0x2CF26A0", VA = "0x182CF40A0", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3F70", Offset = "0x2CF2570", VA = "0x182CF3F70")]
		private CircuitSignal DefaultValue(TypeKind kind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4330", Offset = "0x2CF2930", VA = "0x182CF4330")]
		public DefaultPortData SerializeCustomDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3FE0", Offset = "0x2CF25E0", VA = "0x182CF3FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A04C0", Offset = "0x49EAC0", VA = "0x1804A04C0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E070", Offset = "0x2D5C670", VA = "0x182D5E070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x2D62BD0", Offset = "0x2D611D0", VA = "0x182D62BD0")]
		public NameBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2D62960", Offset = "0x2D60F60", VA = "0x182D62960", Slot = "26")]
		public void RequestAddPort(string portName, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2D62270", Offset = "0x2D60870", VA = "0x182D62270", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2D62320", Offset = "0x2D60920", VA = "0x182D62320", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2D61DE0", Offset = "0x2D603E0", VA = "0x182D61DE0")]
		internal TPort AddPortLocal(string portName, CircuitTypeOrString circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x2D623D0", Offset = "0x2D609D0", VA = "0x182D623D0", Slot = "27")]
		public bool HasPort(string portName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x2D62AA0", Offset = "0x2D610A0", VA = "0x182D62AA0")]
		public bool TryGetPort(string portName, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x2D621F0", Offset = "0x2D607F0", VA = "0x182D621F0")]
		private Guid GeneratePortId(string portName)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2D62930", Offset = "0x2D60F30", VA = "0x182D62930", Slot = "25")]
		public void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x2D62410", Offset = "0x2D60A10", VA = "0x182D62410")]
		internal void MergeNamedGroup(IEnumerable<KeyValuePair<string, CircuitType>> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2D61F80", Offset = "0x2D60580", VA = "0x182D61F80", Slot = "24")]
		public void ClearPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x49AE30", Offset = "0x499430", VA = "0x18049AE30")]
		internal void OnBridgedPortRemoved<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x49AEB0", Offset = "0x4994B0", VA = "0x18049AEB0")]
		internal (IEnumerable<Action>, IEnumerable<Node>) RemoveBridgedPortCore<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x49AE00", Offset = "0x499400", VA = "0x18049AE00")]
		internal void OnBridgedPortAdded<TOtherPort>(TOtherPort otherAddedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x2C280B0", Offset = "0x2C266B0", VA = "0x182C280B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0xA2C180", Offset = "0xA2A780", VA = "0x180A2C180", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA2BED0", Offset = "0xA2A4D0", VA = "0x180A2BED0", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA2C000", Offset = "0xA2A600", VA = "0x180A2C000")]
		public OutputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, [Optional] OutputPortGetDelegate outputPortGetDelegate, [Optional] OutputPortSetDelegate outputPortSetDelegate, [Optional] OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xA2BF20", Offset = "0xA2A520", VA = "0x180A2BF20", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xA2BFC0", Offset = "0xA2A5C0", VA = "0x180A2BFC0", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0xA2BF00", Offset = "0xA2A500", VA = "0x180A2BF00", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD70", Offset = "0xA2A370", VA = "0x180A2BD70")]
		public NextExecutable GetExec()
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xA2BFB0", Offset = "0xA2A5B0", VA = "0x180A2BFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3F0", Offset = "0xA2B9F0", VA = "0x180A2D3F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		internal bool IsDynamic
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x4F4170", Offset = "0x4F2770", VA = "0x1804F4170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x4F4120", Offset = "0x4F2720", VA = "0x1804F4120")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B47D0", Offset = "0x4B2DD0", VA = "0x1804B47D0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF040", Offset = "0x3DD640", VA = "0x1803DF040", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5E0", Offset = "0xA2BBE0", VA = "0x180A2D5E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D350", Offset = "0xA2B950", VA = "0x180A2D350", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BB40", VA = "0x180A2D540", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<bool> OnIsConnectedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D2B0", Offset = "0xA2B8B0", VA = "0x180A2D2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BAA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Node GetNode(NodeConnection connection);

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0xA2D150", Offset = "0xA2B750", VA = "0x180A2D150")]
		protected PortBase(Guid portId, string portName, bool isInputPort, [Optional][CanBeNull] CircuitTypeOrString? circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xA2CC90", Offset = "0xA2B290", VA = "0x180A2CC90")]
		public void AddConnection(NodeConnection newConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xA2CF90", Offset = "0xA2B590", VA = "0x180A2CF90")]
		public bool RemoveConnection(NodeConnection connection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xA2CED0", Offset = "0xA2B4D0", VA = "0x180A2CED0")]
		public void RemoveConnectionAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5170", Offset = "0x9B3770", VA = "0x1809B5170", Slot = "12")]
		protected virtual void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0xA2CE70", Offset = "0xA2B470", VA = "0x180A2CE70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2D070", Offset = "0xA2B670", VA = "0x180A2D070", Slot = "17")]
		public NodePortData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA2CD50", Offset = "0xA2B350", VA = "0x180A2CD50", Slot = "5")]
		public void DeserializeFromProtobuf(NodePortData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA2CD80", Offset = "0xA2B380", VA = "0x180A2CD80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal static class PortBridge
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x49B9E0", Offset = "0x499FE0", VA = "0x18049B9E0")]
		internal static void BridgePortDelegates<TPortA, TPortB>(TPortA portA, TPortB portB) where TPortA : PortBase where TPortB : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA2D630", Offset = "0xA2BC30", VA = "0x180A2D630")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public IEnumerable<PortGroupBase<TPort>> AllPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x2D64E40", Offset = "0x2D63440", VA = "0x182D64E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public IEnumerable<TPort> AllPorts
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x2D64ED0", Offset = "0x2D634D0", VA = "0x182D64ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2D64C00", Offset = "0x2D63200", VA = "0x182D64C00")]
		public PortCollection(bool isInputCollection, Node node, PortCreationFactory<TPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x2D63D10", Offset = "0x2D62310", VA = "0x182D63D10")]
		public IndexBasedPortGroup<TPort> RegisterIndexedPortGroup(Guid portGroupId, PortGroupSerialization serialization, CircuitTypeOrString elementType, string elementName = "Element", [Optional] string portGroupName, int minPortCount = 0, int maxPortCount = 64)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x2D63E40", Offset = "0x2D62440", VA = "0x182D63E40")]
		public NameBasedPortGroup<TPort> RegisterNameBasedPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x2D63C00", Offset = "0x2D62200", VA = "0x182D63C00")]
		public ExecNameBasedPortGroup<TPort> RegisterExecNameBasedPortGroup(string execPortName, Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2D63B10", Offset = "0x2D62110", VA = "0x182D63B10")]
		public BasicPortGroup<TPort> RegisterBasicPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x2D63B00", Offset = "0x2D62100", VA = "0x182D63B00")]
		private Dictionary<Guid, PortGroupBase<TPort>> GetPortGroupDictionary(PortGroupSerialization serialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2D62C60", Offset = "0x2D61260", VA = "0x182D62C60")]
		private void AddPortGroup(PortGroupBase<TPort> newPortGroup, [Optional] string portGroupName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2D64650", Offset = "0x2D62C50", VA = "0x182D64650")]
		public bool TryGetPort(Guid portGuid, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x2D62C30", Offset = "0x2D61230", VA = "0x182D62C30")]
		public void AddBuiltInPort(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x2D63820", Offset = "0x2D61E20", VA = "0x182D63820", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2D640B0", Offset = "0x2D626B0", VA = "0x182D640B0", Slot = "6")]
		public PortCollectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "7")]
		protected virtual void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2D632F0", Offset = "0x2D618F0", VA = "0x182D632F0", Slot = "4")]
		public void DeserializeFromProtobuf([NotNull] PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "8")]
		protected virtual void DeserializeInternal(PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2D62F10", Offset = "0x2D61510", VA = "0x182D62F10")]
		private PortGroupBase<TPort> CreatePortGroupOnDeserialization(Guid portGroupId, PortGroupData protobufData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2C283E0", Offset = "0x2C269E0", VA = "0x182C283E0")]
		public bool TryGetPortGroup<T>(Guid portGroupId, out T portGroup) where T : PortGroupBase<TPort>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2D63F30", Offset = "0x2D62530", VA = "0x182D63F30")]
		public void RemovePortGroup(Guid groupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public sealed class InputPortCollection : PortCollection<InputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3EF0", Offset = "0x2CF24F0", VA = "0x182CF3EF0")]
		public InputPortCollection(Node node, PortCreationFactory<InputPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3C40", Offset = "0x2CF2240", VA = "0x182CF3C40", Slot = "7")]
		protected override void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CF39F0", Offset = "0x2CF1FF0", VA = "0x182CF39F0", Slot = "8")]
		protected override void DeserializeInternal(PortCollectionData collectionData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public sealed class OutputPortCollection : PortCollection<OutputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B240", Offset = "0xA29840", VA = "0x180A2B240")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D66CB0", Offset = "0x2D652B0", VA = "0x182D66CB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public IReadOnlyList<TPort> OrderedPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x3ED930", Offset = "0x3EBF30", VA = "0x1803ED930", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x10AA4B0", Offset = "0x10A8AB0", VA = "0x1810AA4B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IReadOnlyCollection<PortBase> IPortGroup.Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x1236350", Offset = "0x1234950", VA = "0x181236350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public Guid GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x9C4C10", Offset = "0x9C3210", VA = "0x1809C4C10", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF100", Offset = "0x3DD700", VA = "0x1803DF100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3F0", Offset = "0x3DD9F0", VA = "0x1803DF3F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public virtual bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7E0", Offset = "0x3EADE0", VA = "0x1803EC7E0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<TPort> OnPortAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2D66B30", Offset = "0x2D65130", VA = "0x182D66B30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2D66CD0", Offset = "0x2D652D0", VA = "0x182D66CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<TPort> OnPortRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x2D66BF0", Offset = "0x2D651F0", VA = "0x182D66BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x2D66D90", Offset = "0x2D65390", VA = "0x182D66D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D659B0", Offset = "0x2D63FB0", VA = "0x182D659B0", Slot = "16")]
		public virtual bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D668E0", Offset = "0x2D64EE0", VA = "0x182D668E0")]
		protected PortGroupBase(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D66840", Offset = "0x2D64E40", VA = "0x182D66840")]
		public bool TryGetRegisteredPort(Guid portId, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D65740", Offset = "0x2D63D40", VA = "0x182D65740")]
		protected void AddGroupPort(TPort port, [Optional] bool? isDynamicOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D66040", Offset = "0x2D64640", VA = "0x182D66040")]
		protected bool RemoveGroupPort(TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D66100", Offset = "0x2D64700", VA = "0x182D66100", Slot = "8")]
		public bool RemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D666E0", Offset = "0x2D64CE0", VA = "0x182D666E0", Slot = "17")]
		public PortGroupData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D663E0", Offset = "0x2D649E0", VA = "0x182D663E0", Slot = "18")]
		protected virtual void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D659F0", Offset = "0x2D63FF0", VA = "0x182D659F0", Slot = "10")]
		public void DeserializeFromProtobuf(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x2D65A50", Offset = "0x2D64050", VA = "0x182D65A50", Slot = "19")]
		protected virtual void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D65CE0", Offset = "0x2D642E0", VA = "0x182D65CE0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D66190", Offset = "0x2D64790", VA = "0x182D66190", Slot = "20")]
		public void RequestAddPort(Guid portId, [Optional] string portName, [Optional] CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D662E0", Offset = "0x2D648E0", VA = "0x182D662E0", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2DD20", Offset = "0xA2C320", VA = "0x180A2DD20")]
		protected PureNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2DCF0", Offset = "0xA2C2F0", VA = "0x180A2DCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940")]
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
			[Cpp2IlInjected.Address(RVA = "0x4693A0", Offset = "0x4679A0", VA = "0x1804693A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2E1A0", Offset = "0xA2C7A0", VA = "0x180A2E1A0")]
			get
			{
				return default(NextExecutable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2C4E0", VA = "0x180A2DEE0")]
		protected SingleExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA2E170", Offset = "0xA2C770", VA = "0x180A2E170")]
		protected SingleExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xA2DDD0", Offset = "0xA2C3D0", VA = "0x180A2DDD0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x1E65A20", Offset = "0x1E64020", VA = "0x181E65A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Quaternion LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C91E00", Offset = "0x2C90400", VA = "0x182C91E00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event OnLocalPositionChangedEvent OnLocalPositionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x2C91CC0", Offset = "0x2C902C0", VA = "0x182C91CC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x2C91E10", Offset = "0x2C90410", VA = "0x182C91E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event OnLocalRotationChangedEvent OnLocalRotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x2C91D60", Offset = "0x2C90360", VA = "0x182C91D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x2C91EB0", Offset = "0x2C904B0", VA = "0x182C91EB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x1650AD0", Offset = "0x164F0D0", VA = "0x181650AD0")]
		public CircuitObjectTransform(Guid circuitObjectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C91B10", Offset = "0x2C90110", VA = "0x182C91B10")]
		public void SetLocalPosition(Vector3 newLocalPosition, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C00", Offset = "0x2C90200", VA = "0x182C91C00")]
		public void SetLocalRotation(Quaternion newLocalRotation, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C91A40", Offset = "0x2C90040", VA = "0x182C91A40", Slot = "5")]
		public CircuitObjectTransformData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C91890", Offset = "0x2C8FE90", VA = "0x182C91890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0330", Offset = "0x3EE930", VA = "0x1803F0330")]
			public CircuitToken(string tokenName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x2C93960", Offset = "0x2C91F60", VA = "0x182C93960", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C93910", Offset = "0x2C91F10", VA = "0x182C93910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C93720", Offset = "0x2C91D20", VA = "0x182C93720")]
		public bool AddToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C937F0", Offset = "0x2C91DF0", VA = "0x182C937F0")]
		public bool RemoveToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C80", Offset = "0x3D8280", VA = "0x1803D9C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x13F80", Offset = "0x13380", VA = "0x180013F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x13F80", Offset = "0x13380", VA = "0x180013F80")]
		public CircuitTeam(int backingTeamId = -1)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Guid("21B7F027-68C6-4C8C-A5C3-81992622DE80")]
	public class ChangeCircuitObjectNameModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8300", Offset = "0x2CE6900", VA = "0x182CE8300")]
		public ChangeCircuitObjectNameModificationHandler(CircuitObject modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8240", Offset = "0x2CE6840", VA = "0x182CE8240")]
		public ICircuitObjectModification CreateModification(string newNodeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8290", Offset = "0x2CE6890", VA = "0x182CE8290", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D5D280", Offset = "0x2D5B880", VA = "0x182D5D280", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x130CE40", Offset = "0x130B440", VA = "0x18130CE40")]
		protected CircuitObjectModificationHandlerBase(T modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HandleModificationRequest(byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D1B0", Offset = "0x2D5B7B0", VA = "0x182D5D1B0")]
		protected ICircuitObjectModification WithPayload(string payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D230", Offset = "0x2D5B830", VA = "0x182D5D230")]
		protected ICircuitObjectModification WithPayload(IMessage payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D130", Offset = "0x2D5B730", VA = "0x182D5D130")]
		protected ICircuitObjectModification WithPayload(byte[] payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2D5D0F0", Offset = "0x2D5B6F0", VA = "0x182D5D0F0")]
		protected static string ParseStringPayload(byte[] payload)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public abstract class NodeModificationHandlerBase : CircuitObjectModificationHandlerBase<Node>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7B90", Offset = "0x2CF6190", VA = "0x182CF7B90")]
		protected NodeModificationHandlerBase(Node modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public abstract class NodeModificationHandlerBase<T> : CircuitObjectModificationHandlerBase<T> where T : Node
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x744370", Offset = "0x742970", VA = "0x180744370")]
		protected NodeModificationHandlerBase(T modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public abstract class EventModificationHandlerBase : CircuitObjectModificationHandlerBase<CircuitEventObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC720", Offset = "0x2CEAD20", VA = "0x182CEC720")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FB870", Offset = "0x5F9E70", VA = "0x1805FB870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2D0", Offset = "0x3DB8D0", VA = "0x1803DD2D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF65F0", Offset = "0x2CF4BF0", VA = "0x182CF65F0")]
		public ModificationBase(ICircuitObjectModificationHandler handler, CircuitObject modifiedObject, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0", Slot = "6")]
		public byte[] GetPayload()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2CF65B0", Offset = "0x2CF4BB0", VA = "0x182CF65B0", Slot = "7")]
		public void Send()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Guid("88EC6D1C-1F68-4A30-AD72-71A8AA1B933A")]
	public class PortDefaultValueModificationHandler : NodeModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7B90", Offset = "0x2CF6190", VA = "0x182CF7B90")]
		public PortDefaultValueModificationHandler(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBC70", Offset = "0x2CFA270", VA = "0x182CFBC70")]
		public ICircuitObjectModification CreateModification(Guid portId, CircuitSignal defaultSignal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBD40", Offset = "0x2CFA340", VA = "0x182CFBD40", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEAAD0", Offset = "0x2CE90D0", VA = "0x182CEAAD0")]
		public DebugLogNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA990", Offset = "0x2CE8F90", VA = "0x182CEA990", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE73C0", Offset = "0x2CE59C0", VA = "0x182CE73C0")]
		public BranchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7200", Offset = "0x2CE5800", VA = "0x182CE7200", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE7DB0", Offset = "0x2CE63B0", VA = "0x182CE7DB0")]
		public BreakTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7AF0", Offset = "0x2CE60F0", VA = "0x182CE7AF0")]
		private CircuitSignal GetReturn0(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7C00", Offset = "0x2CE6200", VA = "0x182CE7C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF3100", Offset = "0x2CF1700", VA = "0x182CF3100")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF3910", Offset = "0x2CF1F10", VA = "0x182CF3910")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE8850", Offset = "0x2CE6E50", VA = "0x182CE8850")]
			public CircuitBoardModificationHandler(CircuitBoard modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x2CE8350", Offset = "0x2CE6950", VA = "0x182CE8350")]
			public ICircuitObjectModification CreateExecGroupModification(string newExecGroupName, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x2CE8400", Offset = "0x2CE6A00", VA = "0x182CE8400")]
			public ICircuitObjectModification DeleteExecGroupModification(Guid execGroupId, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x2CE84D0", Offset = "0x2CE6AD0", VA = "0x182CE84D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC7E0", Offset = "0x3EADE0", VA = "0x1803EC7E0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public override bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7E0", Offset = "0x3EADE0", VA = "0x1803EC7E0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9920", Offset = "0x2CE7F20", VA = "0x182CE9920")]
		public CircuitBoard(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2CE88A0", Offset = "0x2CE6EA0", VA = "0x182CE88A0")]
		[EditableAddExecInput]
		internal ExecNameBasedPortGroup<InputPort> AddExecInput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8AA0", Offset = "0x2CE70A0", VA = "0x182CE8AA0")]
		[EditableAddExecOutput]
		internal ExecNameBasedPortGroup<OutputPort> AddExecOutput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9380", Offset = "0x2CE7980", VA = "0x182CE9380")]
		internal void RemoveExecInput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2CE94B0", Offset = "0x2CE7AB0", VA = "0x182CE94B0")]
		internal void RemoveExecOutput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8CA0", Offset = "0x2CE72A0", VA = "0x182CE8CA0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9090", Offset = "0x2CE7690", VA = "0x182CE9090", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2CE95E0", Offset = "0x2CE7BE0", VA = "0x182CE95E0", Slot = "24")]
		public override bool RequestAddInputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9680", Offset = "0x2CE7C80", VA = "0x182CE9680", Slot = "26")]
		public override bool RequestAddOutputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9720", Offset = "0x2CE7D20", VA = "0x182CE9720", Slot = "28")]
		public override bool RequestRemoveInputGroup(Guid groupId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE97D0", Offset = "0x2CE7DD0", VA = "0x182CE97D0", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2411850", Offset = "0x240FE50", VA = "0x182411850")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public virtual bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public virtual bool CanRemoveInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public virtual bool CanRemoveOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9B50", Offset = "0x2CE8150", VA = "0x182CE9B50")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9B00", Offset = "0x2CE8100", VA = "0x182CE9B00", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "24")]
		public virtual bool RequestAddInputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "26")]
		public virtual bool RequestAddOutputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "28")]
		public virtual bool RequestRemoveInputGroup(Guid portGroup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7D0", Offset = "0x3EADD0", VA = "0x1803EC7D0", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		protected HashSet<TEntryNode> CachedEntryNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x2D5CB10", Offset = "0x2D5B110", VA = "0x182D5CB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		protected HashSet<TExitNode> CachedExitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x2D5CE00", Offset = "0x2D5B400", VA = "0x182D5CE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CircuitContext ChildContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C8D0", Offset = "0x2D5AED0", VA = "0x182D5C8D0")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C860", Offset = "0x2D5AE60", VA = "0x182D5C860")]
		private void OnNodeAddedOrRemoved(CircuitContext context, Node modifiedNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C770", Offset = "0x2D5AD70", VA = "0x182D5C770")]
		private void DirtyCachedExitNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C810", Offset = "0x2D5AE10", VA = "0x182D5C810", Slot = "16")]
		public sealed override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C780", Offset = "0x2D5AD80", VA = "0x182D5C780", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "32")]
		protected virtual void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C7C0", Offset = "0x2D5ADC0", VA = "0x182D5C7C0", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		protected abstract NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5BEB0", Offset = "0x2D5A4B0", VA = "0x182D5BEB0", Slot = "34")]
		protected virtual bool AddInnerEntry(InputPort execInput, out TEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C2E0", Offset = "0x2D5A8E0", VA = "0x182D5C2E0", Slot = "35")]
		internal virtual bool AddInnerExit(OutputPort execOutput, out TExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C730", Offset = "0x2D5AD30", VA = "0x182D5C730", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940")]
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
			[Cpp2IlInjected.Address(RVA = "0x4693A0", Offset = "0x4679A0", VA = "0x1804693A0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xC5CA90", Offset = "0xC5B090", VA = "0x180C5CA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D610C0", Offset = "0x2D5F6C0", VA = "0x182D610C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9494C0", Offset = "0x947AC0", VA = "0x1809494C0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2EC0", Offset = "0x2CF14C0", VA = "0x182CF2EC0")]
		protected InnerContextEntryNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2E40", Offset = "0x2CF1440", VA = "0x182CF2E40", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF0E0", Offset = "0x3DD6E0", VA = "0x1803DF0E0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3870", Offset = "0x2CF1E70", VA = "0x182CF3870")]
		protected InnerContextExitNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF37D0", Offset = "0x2CF1DD0", VA = "0x182CF37D0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB100", Offset = "0x2CE9700", VA = "0x182CEB100")]
		public DelayNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x2CEAE30", Offset = "0x2CE9430", VA = "0x182CEAE30", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x2CEAD10", Offset = "0x2CE9310", VA = "0x182CEAD10", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x2CEAF40", Offset = "0x2CE9540", VA = "0x182CEAF40", Slot = "23")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x2CEADC0", Offset = "0x2CE93C0", VA = "0x182CEADC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CED790", Offset = "0x2CEBD90", VA = "0x182CED790")]
			public EventRegistrationNodeModificationHandler(EventNodeBase modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x2CED6A0", Offset = "0x2CEBCA0", VA = "0x182CED6A0")]
			public ICircuitObjectModification CreateSetRegistrationModification(CircuitEventBus.EventRegistration eventRegistration)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x2CED700", Offset = "0x2CEBD00", VA = "0x182CED700", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x2CECB90", Offset = "0x2CEB190", VA = "0x182CECB90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices();

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x2CECAE0", Offset = "0x2CEB0E0", VA = "0x182CECAE0")]
		protected EventNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC770", Offset = "0x2CEAD70", VA = "0x182CEC770", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC800", Offset = "0x2CEAE00", VA = "0x182CEC800")]
		private void RefreshPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "25")]
		protected virtual void RegisterNewEventRegistration([NotNull] CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "26")]
		protected virtual void UnregisterOldEventRegistration([NotNull] CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x2CECA30", Offset = "0x2CEB030", VA = "0x182CECA30")]
		protected void SetEventRegistrationFromData(EventRegistrationData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId);

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC970", Offset = "0x2CEAF70", VA = "0x182CEC970")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E40", Offset = "0x460440", VA = "0x180461E40", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x2CED420", Offset = "0x2CEBA20", VA = "0x182CED420")]
		public EventReceiverNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0xA2E1A0", Offset = "0xA2C7A0", VA = "0x180A2E1A0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x2CED300", Offset = "0x2CEB900", VA = "0x182CED300", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2CECE60", Offset = "0x2CEB460", VA = "0x182CECE60", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2CED390", Offset = "0x2CEB990", VA = "0x182CED390", Slot = "26")]
		protected override void UnregisterOldEventRegistration(CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2CECF00", Offset = "0x2CEB500", VA = "0x182CECF00", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x2CECF50", Offset = "0x2CEB550", VA = "0x182CECF50", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x2CED2D0", Offset = "0x2CEB8D0", VA = "0x182CED2D0", Slot = "25")]
		protected override void RegisterNewEventRegistration(CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x2CECF80", Offset = "0x2CEB580", VA = "0x182CECF80", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x461E40", Offset = "0x460440", VA = "0x180461E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E70", Offset = "0x460470", VA = "0x180461E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDD90", Offset = "0x2CEC390", VA = "0x182CEDD90")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId, bool sendSyncEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE160", Offset = "0x2CEC760", VA = "0x182CEE160")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDC10", Offset = "0x2CEC210", VA = "0x182CEDC10", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDBC0", Offset = "0x2CEC1C0", VA = "0x182CEDBC0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDB60", Offset = "0x2CEC160", VA = "0x182CEDB60", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x2CED880", Offset = "0x2CEBE80", VA = "0x182CED880")]
		protected void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDC40", Offset = "0x2CEC240", VA = "0x182CEDC40", Slot = "28")]
		protected virtual void SendEventInternal(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDC60", Offset = "0x2CEC260", VA = "0x182CEDC60", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2CED7E0", Offset = "0x2CEBDE0", VA = "0x182CED7E0", Slot = "19")]
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
				[Cpp2IlInjected.Address(RVA = "0x3DD2B0", Offset = "0x3DB8B0", VA = "0x1803DD2B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x2CFF1D0", Offset = "0x2CFD7D0", VA = "0x182CFF1D0")]
			public SyncedEventSenderModificationHandler(SynchedEventSenderNode modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x2CFF100", Offset = "0x2CFD700", VA = "0x182CFF100")]
			public ICircuitObjectModification CreateChangeTargetModification(SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x2CFF180", Offset = "0x2CFD780", VA = "0x182CFF180", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x4692C0", Offset = "0x4678C0", VA = "0x1804692C0")]
			get
			{
				return default(SynchronizedCircuitContext.SyncedEventTargets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF760", Offset = "0x2CFDD60", VA = "0x182CFF760")]
		public SynchedEventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF720", Offset = "0x2CFDD20", VA = "0x182CFF720", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF34C0", Offset = "0x2CF1AC0", VA = "0x182CF34C0")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2F60", Offset = "0x2CF1560", VA = "0x182CF2F60", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C3FF0", Offset = "0x4C25F0", VA = "0x1804C3FF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000AA8")]
				[Cpp2IlInjected.Address(RVA = "0x4C4530", Offset = "0x4C2B30", VA = "0x1804C4530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7A00", Offset = "0x2CE6000", VA = "0x182CE7A00")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7800", Offset = "0x2CE5E00", VA = "0x182CE7800", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7900", Offset = "0x2CE5F00", VA = "0x182CE7900")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E60", Offset = "0x460460", VA = "0x180461E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4786C0", Offset = "0x476CC0", VA = "0x1804786C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9493D0", Offset = "0x9479D0", VA = "0x1809493D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFCB0", Offset = "0x2CEE2B0", VA = "0x182CEFCB0")]
		public ForeachNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFB60", Offset = "0x2CEE160", VA = "0x182CEFB60", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF6B0", Offset = "0x2CEDCB0", VA = "0x182CEF6B0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF740", Offset = "0x2CEDD40", VA = "0x182CEF740", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF580", Offset = "0x2CEDB80", VA = "0x182CEF580", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF620", Offset = "0x2CEDC20", VA = "0x182CEF620", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFA80", Offset = "0x2CEE080", VA = "0x182CEFA80", Slot = "21")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF31E0", Offset = "0x2CF17E0", VA = "0x182CF31E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C3FF0", Offset = "0x4C25F0", VA = "0x1804C3FF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000ABF")]
				[Cpp2IlInjected.Address(RVA = "0x4C4530", Offset = "0x4C2B30", VA = "0x1804C4530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7910", Offset = "0x2CE5F10", VA = "0x182CE7910")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7880", Offset = "0x2CE5E80", VA = "0x182CE7880", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x2CE7900", Offset = "0x2CE5F00", VA = "0x182CE7900")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E60", Offset = "0x460460", VA = "0x180461E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4786C0", Offset = "0x476CC0", VA = "0x1804786C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF84B30", Offset = "0xF83130", VA = "0x180F84B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E80", Offset = "0x460480", VA = "0x180461E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEF90", Offset = "0x2CED590", VA = "0x182CEEF90")]
		public ForNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEE10", Offset = "0x2CED410", VA = "0x182CEEE10", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEB30", Offset = "0x2CED130", VA = "0x182CEEB30", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEA00", Offset = "0x2CED000", VA = "0x182CEEA00", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEAA0", Offset = "0x2CED0A0", VA = "0x182CEEAA0", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEBC0", Offset = "0x2CED1C0", VA = "0x182CEEBC0", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF08F0", Offset = "0x2CEEEF0", VA = "0x182CF08F0")]
		public GetElementNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x2CF06C0", Offset = "0x2CEECC0", VA = "0x182CF06C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF0DC0", Offset = "0x2CEF3C0", VA = "0x182CF0DC0")]
		public GetListCountNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0D40", Offset = "0x2CEF340", VA = "0x182CF0D40", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF1E20", Offset = "0x2CF0420", VA = "0x182CF1E20")]
		public HasAuthorityNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1CC0", Offset = "0x2CF02C0", VA = "0x182CF1CC0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF5A90", Offset = "0x2CF4090", VA = "0x182CF5A90")]
		public MakeListNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5960", Offset = "0x2CF3F60", VA = "0x182CF5960", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF6030", Offset = "0x2CF4630", VA = "0x182CF6030")]
		public MakeTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5E40", Offset = "0x2CF4440", VA = "0x182CF5E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x356870", Offset = "0x355C70", VA = "0x180356870")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFD620", Offset = "0x2CFBC20", VA = "0x182CFD620")]
		protected RandomNumberGeneratorNode(CircuitContext circuitContext, CircuitType numberType, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD430", Offset = "0x2CFBA30", VA = "0x182CFD430", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal);

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD530", Offset = "0x2CFBB30", VA = "0x182CFD530")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFD210", Offset = "0x2CFB810", VA = "0x182CFD210")]
		public RandomIntegerGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD130", Offset = "0x2CFB730", VA = "0x182CFD130", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFCF30", Offset = "0x2CFB530", VA = "0x182CFCF30")]
		public RandomFloatGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0x2CFCDF0", Offset = "0x2CFB3F0", VA = "0x182CFCDF0", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDE80", Offset = "0x2CFC480", VA = "0x182CFDE80")]
		public SetValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDD70", Offset = "0x2CFC370", VA = "0x182CFDD70", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFE290", Offset = "0x2CFC890", VA = "0x182CFE290")]
		public ShowNotificationNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE150", Offset = "0x2CFC750", VA = "0x182CFE150", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D67FD0", Offset = "0x2D665D0", VA = "0x182D67FD0")]
		public SwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x2D67460", Offset = "0x2D65A60", VA = "0x182D67460", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x2D66E50", Offset = "0x2D65450", VA = "0x182D66E50")]
		protected Dictionary<T, OutputPort> BuildCaseMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x2D67520", Offset = "0x2D65B20", VA = "0x182D67520", Slot = "18")]
		protected sealed override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract SwitchNodeData SerializeCaseLables(IEnumerable<T> caseLables);

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x2D672C0", Offset = "0x2D658C0", VA = "0x182D672C0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CF4C70", Offset = "0x2CF3270", VA = "0x182CF4C70", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4B10", Offset = "0x2CF3110", VA = "0x182CF4B10", Slot = "24")]
		protected override int GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4BF0", Offset = "0x2CF31F0", VA = "0x182CF4BF0")]
		public IntSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4B70", Offset = "0x2CF3170", VA = "0x182CF4B70", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<int> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0xA2BED0", Offset = "0xA2A4D0", VA = "0x180A2BED0", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CFEF10", Offset = "0x2CFD510", VA = "0x182CFEF10", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEDB0", Offset = "0x2CFD3B0", VA = "0x182CFEDB0", Slot = "24")]
		protected override string GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEE90", Offset = "0x2CFD490", VA = "0x182CFEE90")]
		public StringSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEE10", Offset = "0x2CFD410", VA = "0x182CFEE10", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<string> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x1F71140", Offset = "0x1F6F740", VA = "0x181F71140", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6D70", Offset = "0x2CF5370", VA = "0x182CF6D70")]
		public MultiInputBooleanLogicNode(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6B70", Offset = "0x2CF5170", VA = "0x182CF6B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE6FA0", Offset = "0x2CE55A0", VA = "0x182CE6FA0")]
		public AndNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6EB0", Offset = "0x2CE54B0", VA = "0x182CE6EB0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFBA10", Offset = "0x2CFA010", VA = "0x182CFBA10")]
		public OrNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB920", Offset = "0x2CF9F20", VA = "0x182CFB920", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF7500", Offset = "0x2CF5B00", VA = "0x182CF7500")]
		public NANDNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7410", Offset = "0x2CF5A10", VA = "0x182CF7410", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF7690", Offset = "0x2CF5C90", VA = "0x182CF7690")]
		public NORNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x2CF75A0", Offset = "0x2CF5BA0", VA = "0x182CF75A0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA3B0", Offset = "0x2CF89B0", VA = "0x182CFA3B0")]
		public NotNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA280", Offset = "0x2CF8880", VA = "0x182CFA280")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF2360", Offset = "0x2CF0960", VA = "0x182CF2360")]
		public IfExpressionNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2190", Offset = "0x2CF0790", VA = "0x182CF2190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF53C0", Offset = "0x2CF39C0", VA = "0x182CF53C0")]
		public MakeDictionaryNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5270", Offset = "0x2CF3870", VA = "0x182CF5270")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6730", Offset = "0x2CE4D30", VA = "0x182CE6730")]
		public AbsoluteValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6550", Offset = "0x2CE4B50", VA = "0x182CE6550", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6460", Offset = "0x2CE4A60", VA = "0x182CE6460")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6360", Offset = "0x2CE4960", VA = "0x182CE6360")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE6E10", Offset = "0x2CE5410", VA = "0x182CE6E10")]
		public AddNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6C40", Offset = "0x2CE5240", VA = "0x182CE6C40", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6C30", Offset = "0x2CE5230", VA = "0x182CE6C30", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEBA00", Offset = "0x2CEA000", VA = "0x182CEBA00")]
		public DivideNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB7D0", Offset = "0x2CE9DD0", VA = "0x182CEB7D0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB9D0", Offset = "0x2CE9FD0", VA = "0x182CEB9D0")]
		private static int SafeDivide(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB610", Offset = "0x2CE9C10", VA = "0x182CEB610", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB9B0", Offset = "0x2CE9FB0", VA = "0x182CEB9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF6AD0", Offset = "0x2CF50D0", VA = "0x182CF6AD0")]
		public ModuloNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2CF68C0", Offset = "0x2CF4EC0", VA = "0x182CF68C0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6AB0", Offset = "0x2CF50B0", VA = "0x182CF6AB0")]
		private static int SafeModulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF66E0", Offset = "0x2CF4CE0", VA = "0x182CF66E0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6A90", Offset = "0x2CF5090", VA = "0x182CF6A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF7370", Offset = "0x2CF5970", VA = "0x182CF7370")]
		public MultiplyNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF71E0", Offset = "0x2CF57E0", VA = "0x182CF71E0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7030", Offset = "0x2CF5630", VA = "0x182CF7030", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFC060", Offset = "0x2CFA660", VA = "0x182CFC060")]
		public PowerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBFB0", Offset = "0x2CFA5B0", VA = "0x182CFBFB0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBF00", Offset = "0x2CFA500", VA = "0x182CFBF00", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFF060", Offset = "0x2CFD660", VA = "0x182CFF060")]
		public SubtractNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEFE0", Offset = "0x2CFD5E0", VA = "0x182CFEFE0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEF60", Offset = "0x2CFD560", VA = "0x182CFEF60", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF6450", Offset = "0x2CF4A50", VA = "0x182CF6450")]
		public MaxNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6440", Offset = "0x2CF4A40", VA = "0x182CF6440", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6430", Offset = "0x2CF4A30", VA = "0x182CF6430", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF6510", Offset = "0x2CF4B10", VA = "0x182CF6510")]
		public MinNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6500", Offset = "0x2CF4B00", VA = "0x182CF6500", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF64F0", Offset = "0x2CF4AF0", VA = "0x182CF64F0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB4E0", Offset = "0x2CF9AE0", VA = "0x182CFB4E0")]
		public NumberNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount, int maxPortCount = int.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB300", Offset = "0x2CF9900", VA = "0x182CFB300", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB150", Offset = "0x2CF9750", VA = "0x182CFB150")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFAFF0", Offset = "0x2CF95F0", VA = "0x182CFAFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4693A0", Offset = "0x4679A0", VA = "0x1804693A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE920", Offset = "0x2CFCF20", VA = "0x182CFE920")]
		public StringFormatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE500", Offset = "0x2CFCB00", VA = "0x182CFE500")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE370", Offset = "0x2CEC970", VA = "0x182CEE370")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE280", Offset = "0x2CEC880", VA = "0x182CEE280", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE190", Offset = "0x2CEC790", VA = "0x182CEE190", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	public abstract class ExternalVariableNode<TVal> : ExternalVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2D5E0F0", Offset = "0x2D5C6F0", VA = "0x182D5E0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x947A00", VA = "0x180949400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x949980", Offset = "0x947F80", VA = "0x180949980")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x469630", Offset = "0x467C30", VA = "0x180469630")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected Memory.IMemoryHandle MemoryHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x461E40", Offset = "0x460440", VA = "0x180461E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2B90", Offset = "0x2CF1190", VA = "0x182CF2B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		internal Guid MemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2A90", Offset = "0x2CF1090", VA = "0x182CF2A90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		protected Guid DefaultMemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x2CF29A0", Offset = "0x2CF0FA0", VA = "0x182CF29A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2900", Offset = "0x2CF0F00", VA = "0x182CF2900")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2840", Offset = "0x2CF0E40", VA = "0x182CF2840", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D5FF80", Offset = "0x2D5E580", VA = "0x182D5FF80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		private string AllocateVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x2D603E0", Offset = "0x2D5E9E0", VA = "0x182D603E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FDC0", Offset = "0x2D5E3C0", VA = "0x182D5FDC0")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D5EF30", Offset = "0x2D5D530", VA = "0x182D5EF30", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract Memory.IMemoryHandle Allocate(Guid defaultAddress, string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F5B0", Offset = "0x2D5DBB0", VA = "0x182D5F5B0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ECC0", Offset = "0x2D5D2C0", VA = "0x182D5ECC0", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F2A0", Offset = "0x2D5D8A0", VA = "0x182D5F2A0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ED90", Offset = "0x2D5D390", VA = "0x182D5ED90", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FA70", Offset = "0x2D5E070", VA = "0x182D5FA70", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2D5EEA0", Offset = "0x2D5D4A0", VA = "0x182D5EEA0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE7040", Offset = "0x2CE5640", VA = "0x182CE7040")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4950", Offset = "0x2CF2F50", VA = "0x182CF4950")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEE410", Offset = "0x2CECA10", VA = "0x182CEE410")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFE470", Offset = "0x2CFCA70", VA = "0x182CFE470")]
		public StringExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[NodeTag("Networking", new string[] { })]
	public abstract class SyncedInMemoryVariableNode<T> : InMemoryVariableNode<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x2D68D60", Offset = "0x2D67360", VA = "0x182D68D60")]
		protected SyncedInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Guid("1A5331BC-5025-487E-898C-3C49EE715664")]
	public class IntInMemoryVariableNode : InMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF49E0", Offset = "0x2CF2FE0", VA = "0x182CF49E0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4A30", Offset = "0x2CF3030", VA = "0x182CF4A30")]
		public IntInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[Guid("3EE1EDFE-5520-4714-862B-98AF90F6E3DA")]
	public class PlayerInMemoryVariableNode : InMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x2CF49E0", Offset = "0x2CF2FE0", VA = "0x182CF49E0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBB60", Offset = "0x2CFA160", VA = "0x182CFBB60")]
		public PlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBB10", Offset = "0x2CFA110", VA = "0x182CFBB10")]
		private static bool SetPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x2CFBAB0", Offset = "0x2CFA0B0", VA = "0x182CFBAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFF480", Offset = "0x2CFDA80", VA = "0x182CFF480", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF8F0", Offset = "0x2CFDEF0", VA = "0x182CFF8F0")]
		public SynchedPlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF8A0", Offset = "0x2CFDEA0", VA = "0x182CFF8A0")]
		private static bool SetSynchedPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF840", Offset = "0x2CFDE40", VA = "0x182CFF840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFF480", Offset = "0x2CFDA80", VA = "0x182CFF480", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF4D0", Offset = "0x2CFDAD0", VA = "0x182CFF4D0")]
		public SyncedInMemoryIntVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
	[Guid("DCE27FE2-ABC2-4A6A-9C4E-5D829A5B83A6")]
	public class FloatInMemoryVariableNode : InMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE4A0", Offset = "0x2CECAA0", VA = "0x182CEE4A0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE4F0", Offset = "0x2CECAF0", VA = "0x182CEE4F0")]
		public FloatInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[Guid("56DCF860-9C74-4213-8859-45ABA0B96D43")]
	public class SyncedInMemoryFloatVariableNode : SyncedInMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF350", Offset = "0x2CFD950", VA = "0x182CFF350", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF3A0", Offset = "0x2CFD9A0", VA = "0x182CFF3A0")]
		public SyncedInMemoryFloatVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Guid("8065D557-B6CC-4DD1-8CFA-B7481FE7BCF1")]
	public class BoolInMemoryVariableNode : InMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE70D0", Offset = "0x2CE56D0", VA = "0x182CE70D0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7120", Offset = "0x2CE5720", VA = "0x182CE7120")]
		public BoolInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Guid("1E2CA8E7-037F-4A1A-82A7-62B81928B6A4")]
	public class SyncedInMemoryBoolVariableNode : SyncedInMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF220", Offset = "0x2CFD820", VA = "0x182CFF220", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF270", Offset = "0x2CFD870", VA = "0x182CFF270")]
		public SyncedInMemoryBoolVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Guid("797913DF-1BCF-4280-8666-F17D7782CEBB")]
	public class StringInMemoryVariableNode : InMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEC40", Offset = "0x2CFD240", VA = "0x182CFEC40", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2CFECD0", Offset = "0x2CFD2D0", VA = "0x182CFECD0")]
		public StringInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Guid("62F1B8B1-F1D3-4CEB-B0E9-57C4915BF401")]
	public class SyncedInMemoryStringVariableNode : SyncedInMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF5B0", Offset = "0x2CFDBB0", VA = "0x182CFF5B0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF640", Offset = "0x2CFDC40", VA = "0x182CFF640")]
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
			[Cpp2IlInjected.Address(RVA = "0x461EC0", Offset = "0x4604C0", VA = "0x180461EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA2F960", Offset = "0xA2DF60", VA = "0x180A2F960")]
		public ValueChangedNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA2F490", Offset = "0xA2DA90", VA = "0x180A2F490", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA2F610", Offset = "0xA2DC10", VA = "0x180A2F610", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0xA2F7B0", Offset = "0xA2DDB0", VA = "0x180A2F7B0", Slot = "23")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0xA2F820", Offset = "0xA2DE20", VA = "0x180A2F820")]
		private void UnregisterListeningNode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0xA2F660", Offset = "0xA2DC60", VA = "0x180A2F660")]
		private void OnIsConnectedChanged(bool isConnected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0xA2F660", Offset = "0xA2DC60", VA = "0x180A2F660")]
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
			[Cpp2IlInjected.Address(RVA = "0x4693A0", Offset = "0x4679A0", VA = "0x1804693A0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0xA30090", Offset = "0xA2E690", VA = "0x180A30090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2FDC0", Offset = "0xA2E3C0", VA = "0x180A2FDC0", Slot = "27")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0xA2FF70", Offset = "0xA2E570", VA = "0x180A2FF70", Slot = "22")]
		public void RegisterChangeListener(IVariableChangeListener changeListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA2FFD0", Offset = "0xA2E5D0", VA = "0x180A2FFD0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2CA20", Offset = "0xA2B020", VA = "0x180A2CA20")]
		protected ParsingNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA2C7B0", Offset = "0xA2ADB0", VA = "0x180A2C7B0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C640", Offset = "0xA2AC40", VA = "0x180A2C640")]
		public ParseIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5C0", Offset = "0xA2ABC0", VA = "0x180A2C5C0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C450", Offset = "0xA2AA50", VA = "0x180A2C450")]
		public ParseFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0xA2C3D0", Offset = "0xA2A9D0", VA = "0x180A2C3D0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C260", Offset = "0xA2A860", VA = "0x180A2C260")]
		public ParseBoolNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0xA2C190", Offset = "0xA2A790", VA = "0x180A2C190", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C43A0", Offset = "0x4C29A0", VA = "0x1804C43A0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DD940", Offset = "0x4DBF40", VA = "0x1804DD940", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0xA2E320", Offset = "0xA2C920", VA = "0x180A2E320")]
		protected TypeConversionNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0xA2E1F0", Offset = "0xA2C7F0", VA = "0x180A2E1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2ABF0", Offset = "0xA291F0", VA = "0x180A2ABF0")]
		public IntToFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA2ABB0", Offset = "0xA291B0", VA = "0x180A2ABB0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEE830", Offset = "0x2CECE30", VA = "0x182CEE830")]
		protected FloatToIntConversionNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE6A0", Offset = "0x2CECCA0", VA = "0x182CEE6A0", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE5D0", Offset = "0x2CECBD0", VA = "0x182CEE5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2DDB0", Offset = "0xA2C3B0", VA = "0x180A2DDB0")]
		public FloorToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE9A0", Offset = "0x2CECFA0", VA = "0x182CEE9A0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2DDB0", Offset = "0xA2C3B0", VA = "0x180A2DDB0")]
		public CeilToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE81E0", Offset = "0x2CE67E0", VA = "0x182CE81E0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2DDB0", Offset = "0xA2C3B0", VA = "0x180A2DDB0")]
		public RoundToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA2DD50", Offset = "0xA2C350", VA = "0x180A2DD50", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x4693A0", Offset = "0x4679A0", VA = "0x1804693A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x2CFAAB0", Offset = "0x2CF90B0", VA = "0x182CFAAB0")]
		public NumberComparisonNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA8A0", Offset = "0x2CF8EA0", VA = "0x182CFA8A0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA660", Offset = "0x2CF8C60", VA = "0x182CFA660")]
		private CircuitSignal CalculateReturnValueFloat(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA780", Offset = "0x2CF8D80", VA = "0x182CFA780")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF1B00", Offset = "0x2CF0100", VA = "0x182CF1B00")]
		public GreaterThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1A70", Offset = "0x2CF0070", VA = "0x182CF1A70", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1A60", Offset = "0x2CF0060", VA = "0x182CF1A60", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4EB0", Offset = "0x2CF34B0", VA = "0x182CF4EB0")]
		public LessThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4E20", Offset = "0x2CF3420", VA = "0x182CF4E20", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4E10", Offset = "0x2CF3410", VA = "0x182CF4E10", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF1C30", Offset = "0x2CF0230", VA = "0x182CF1C30")]
		public GreaterThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1B90", Offset = "0x2CF0190", VA = "0x182CF1B90", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1C20", Offset = "0x2CF0220", VA = "0x182CF1C20", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4FE0", Offset = "0x2CF35E0", VA = "0x182CF4FE0")]
		public LessThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4F40", Offset = "0x2CF3540", VA = "0x182CF4F40", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4FD0", Offset = "0x2CF35D0", VA = "0x182CF4FD0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEC330", Offset = "0x2CEA930", VA = "0x182CEC330")]
		public EqualsNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC1B0", Offset = "0x2CEA7B0", VA = "0x182CEC1B0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC1E0", Offset = "0x2CEA7E0", VA = "0x182CEC1E0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBBA0", Offset = "0x2CEA1A0", VA = "0x182CEBBA0")]
		private OutputPortGetDelegate GetDelegateForType(CircuitType specificType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBFA0", Offset = "0x2CEA5A0", VA = "0x182CEBFA0")]
		private CircuitSignal GetReferenceEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC0A0", Offset = "0x2CEA6A0", VA = "0x182CEC0A0")]
		private CircuitSignal GetStringEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBD40", Offset = "0x2CEA340", VA = "0x182CEBD40")]
		private CircuitSignal GetFloatEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBEA0", Offset = "0x2CEA4A0", VA = "0x182CEBEA0")]
		private CircuitSignal GetIntEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBAA0", Offset = "0x2CEA0A0", VA = "0x182CEBAA0")]
		private CircuitSignal GetBooleanEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBD00", Offset = "0x2CEA300", VA = "0x182CEBD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D00070", Offset = "0x2CFE670", VA = "0x182D00070")]
		public ToStringNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC1B0", Offset = "0x2CEA7B0", VA = "0x182CEC1B0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFEC0", Offset = "0x2CFE4C0", VA = "0x182CFFEC0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFAD0", Offset = "0x2CFE0D0", VA = "0x182CFFAD0")]
		private ConvertFunc GetDelegateForType(CircuitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFD50", Offset = "0x2CFE350", VA = "0x182CFFD50")]
		private CircuitSignal GetPlayerToString(CircuitContext context, CircuitSignal inputsignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFA00", Offset = "0x2CFE000", VA = "0x182CFFA00", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFE60", Offset = "0x2CFE460", VA = "0x182CFFE60")]
		private static CircuitSignal GetReferenceToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0xEAFE20", Offset = "0xEAE420", VA = "0x180EAFE20")]
		private static CircuitSignal GetStringToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFC90", Offset = "0x2CFE290", VA = "0x182CFFC90")]
		private static CircuitSignal GetFloatToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFCF0", Offset = "0x2CFE2F0", VA = "0x182CFFCF0")]
		private static CircuitSignal GetIntToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFA70", Offset = "0x2CFE070", VA = "0x182CFFA70")]
		private static CircuitSignal GetBooleanToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2CFFC50", Offset = "0x2CFE250", VA = "0x182CFFC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4D10", Offset = "0x2CF3310", VA = "0x182CF4D10")]
		public InvalidPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4CC0", Offset = "0x2CF32C0", VA = "0x182CF4CC0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0xEBF390", Offset = "0xEBD990", VA = "0x180EBF390", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF50C0", Offset = "0x2CF36C0", VA = "0x182CF50C0")]
		public LocalPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5070", Offset = "0x2CF3670", VA = "0x182CF5070", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0xEBF390", Offset = "0xEBD990", VA = "0x180EBF390", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF13C0", Offset = "0x2CEF9C0", VA = "0x182CF13C0")]
		public GetPlayerIsLocalNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2CF12C0", Offset = "0x2CEF8C0", VA = "0x182CF12C0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF1600", Offset = "0x2CEFC00", VA = "0x182CF1600")]
		public GetPlayerNameNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1560", Offset = "0x2CEFB60", VA = "0x182CF1560", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF03D0", Offset = "0x2CEE9D0", VA = "0x182CF03D0")]
		public GetAllPlayersNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0350", Offset = "0x2CEE950", VA = "0x182CF0350")]
		private CircuitSignal GetPlayerList(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0270", Offset = "0x2CEE870", VA = "0x182CF0270", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E40", Offset = "0x460440", VA = "0x180461E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E70", Offset = "0x460470", VA = "0x180461E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E60", Offset = "0x460460", VA = "0x180461E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4786C0", Offset = "0x476CC0", VA = "0x1804786C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC740", Offset = "0x2CFAD40", VA = "0x182CFC740")]
		public PromptLocalPlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC4C0", Offset = "0x2CFAAC0", VA = "0x182CFC4C0")]
		private CircuitSignal GetPromptResponse(IExecutionScope executionscope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC1C0", Offset = "0x2CFA7C0", VA = "0x182CFC1C0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC100", Offset = "0x2CFA700", VA = "0x182CFC100")]
		private void ExecuteAfterPrompt(OutputPort fromPort)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x246290", Offset = "0x245690")]
	[Guid("163C326E-6BB9-428A-8837-FF507D948E93")]
	public class GetPlayerHealthNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1120", Offset = "0x2CEF720", VA = "0x182CF1120")]
		public GetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1000", Offset = "0x2CEF600", VA = "0x182CF1000", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[InternalNode]
	[Guid("6B962C79-6BE2-4E2C-A517-BE998B58F9D1")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x246620", Offset = "0x245A20")]
	public class GetPlayerShieldNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x2CF18C0", Offset = "0x2CEFEC0", VA = "0x182CF18C0")]
		public GetPlayerShieldNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x2CF17A0", Offset = "0x2CEFDA0", VA = "0x182CF17A0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	[InternalNode]
	[Guid("67ACA89C-F753-4F94-87DF-1CE1D4FCB8B0")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x2469D0", Offset = "0x245DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E40", Offset = "0x460440", VA = "0x180461E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA6B0", Offset = "0x2CE8CB0", VA = "0x182CEA6B0")]
		public DamagePlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA470", Offset = "0x2CE8A70", VA = "0x182CEA470", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x2470F0", Offset = "0x2464F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E50", Offset = "0x460450", VA = "0x180461E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDB60", Offset = "0x2CFC160", VA = "0x182CFDB60")]
		public ResetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD9E0", Offset = "0x2CFBFE0", VA = "0x182CFD9E0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD2C0", Offset = "0x3DB8C0", VA = "0x1803DD2C0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AA5B0", Offset = "0x4A8BB0", VA = "0x1804AA5B0")]
		protected CircuitNetworking(IRPCSender rpcSender, IContextSynchronizedFieldFactory synchronizedFieldFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8B0", Offset = "0xA1AEB0", VA = "0x180A1C8B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA16260", Offset = "0xA14860", VA = "0x180A16260")]
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
