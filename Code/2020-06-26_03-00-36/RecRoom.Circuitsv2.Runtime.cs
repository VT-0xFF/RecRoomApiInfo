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
	[Cpp2IlInjected.Address(RVA = "0x1477380", Offset = "0x1476780", VA = "0x181477380")]
	public static Guid ToGuid(this ByteString bytes)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x14771C0", Offset = "0x14765C0", VA = "0x1814771C0")]
	public static ByteString ToByteString(this Guid guid)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1477510", Offset = "0x1476910", VA = "0x181477510")]
	public static Guid? ToGuid(this NullableBytes bytes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x14772B0", Offset = "0x14766B0", VA = "0x1814772B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF41B0", Offset = "0x2DF35B0", VA = "0x182DF41B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E60B20", Offset = "0x1E5FF20", VA = "0x181E60B20")]
		public RateLimitedSynchronizedField(SynchronizedField<T> internalField, T initialValue, RateLimiter rateLimiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xFD4B90", Offset = "0xFD3F90", VA = "0x180FD4B90")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E608E0", Offset = "0x1E5FCE0", VA = "0x181E608E0")]
		public bool Set(T newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E60610", Offset = "0x1E5FA10", VA = "0x181E60610", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E60FB0", Offset = "0x1E603B0", VA = "0x181E60FB0")]
		public bool HasReferences(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E61220", Offset = "0x1E60620", VA = "0x181E61220")]
		public bool TryGetRefCount(TKey key, out int refCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E61040", Offset = "0x1E60440", VA = "0x181E61040")]
		public void IncrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E60DC0", Offset = "0x1E601C0", VA = "0x181E60DC0")]
		public void DecrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xF99E50", Offset = "0xF99250", VA = "0x180F99E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x145F10", Offset = "0x145310", VA = "0x180145F10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613E00", VA = "0x181614A00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1614AA0", Offset = "0x1613EA0", VA = "0x181614AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16148C0", Offset = "0x1613CC0", VA = "0x1816148C0")]
		private ShortenedGuidMap(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1613FA0", Offset = "0x16133A0", VA = "0x181613FA0")]
		public static ShortenedGuidMap FromRequiredCharacters(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1614100", Offset = "0x1613500", VA = "0x181614100")]
		public string GetShortened(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16141E0", Offset = "0x16135E0", VA = "0x1816141E0")]
		private string GuidToShortenedString(Guid guid, int requiredCharacters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1614590", Offset = "0x1613990", VA = "0x181614590")]
		private string RemapGuid(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16142C0", Offset = "0x16136C0", VA = "0x1816142C0")]
		private void RemapExisting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1614820", Offset = "0x1613C20", VA = "0x181614820")]
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
			[Cpp2IlInjected.Address(RVA = "0x1602AB0", Offset = "0x1601EB0", VA = "0x181602AB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		private Base64GuidShortenerMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x16029A0", Offset = "0x1601DA0", VA = "0x1816029A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x16130E0", Offset = "0x16124E0", VA = "0x1816130E0")]
		public static bool IsEmpty(this CircuitContextData contextData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x122E350", Offset = "0x122D750", VA = "0x18122E350")]
		private static bool IsRepeatedFieldEmpty<T>(RepeatedField<T> repeatedField)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1613400", Offset = "0x1612800", VA = "0x181613400")]
		internal static Vector3 ToVector3(this Vector3Data vector3Data)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1613350", Offset = "0x1612750", VA = "0x181613350")]
		internal static Vector3Data ToVector3Data(this Vector3 vector3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1613250", Offset = "0x1612650", VA = "0x181613250")]
		internal static Quaternion ToQuaternion(this QuaternionData quaternionData)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16131A0", Offset = "0x16125A0", VA = "0x1816131A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83A160", Offset = "0x839560", VA = "0x18083A160")]
			[DebuggerHidden]
			public <DFS>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1615B10", Offset = "0x1614F10", VA = "0x181615B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x16162E0", Offset = "0x16156E0", VA = "0x1816162E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1616240", Offset = "0x1615640", VA = "0x181616240", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1616240", Offset = "0x1615640", VA = "0x181616240", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1611BA0", Offset = "0x1610FA0", VA = "0x181611BA0")]
		[IteratorStateMachine(typeof(<DFS>d__1))]
		public static IEnumerable<Node> DFS(Node root, DFSType dfsType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1611C20", Offset = "0x1611020", VA = "0x181611C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8F60", VA = "0x1803A9B60")]
			public NotRestriction(params Type[] notTypes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1612980", Offset = "0x1611D80", VA = "0x181612980")]
			protected bool Equals(NotRestriction other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x16129C0", Offset = "0x1611DC0", VA = "0x1816129C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x10B4A20", Offset = "0x10B3E20", VA = "0x1810B4A20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x12998D0", Offset = "0x1298CD0", VA = "0x1812998D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x45AF20", Offset = "0x45A320", VA = "0x18045AF20")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x147B210", Offset = "0x147A610", VA = "0x18147B210")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[NotNull]
		public Dependencies RecRoomDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B06D0", VA = "0x1803B12D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x147AEF0", Offset = "0x147A2F0", VA = "0x18147AEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CircuitContext Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x38EBB0", Offset = "0x38DFB0", VA = "0x18038EBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x42F780", Offset = "0x42EB80", VA = "0x18042F780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitContextNode ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x40FEE0", Offset = "0x40F2E0", VA = "0x18040FEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x486D40", Offset = "0x486140", VA = "0x180486D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x147AF40", Offset = "0x147A340", VA = "0x18147AF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4A8540", Offset = "0x4A7940", VA = "0x1804A8540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CircuitContext, Node> OnCircuitNodeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x147AC70", Offset = "0x147A070", VA = "0x18147AC70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x147AF90", Offset = "0x147A390", VA = "0x18147AF90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x147AD10", Offset = "0x147A110", VA = "0x18147AD10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x147B030", Offset = "0x147A430", VA = "0x18147B030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<NodeConnection> OnNodesConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x147ADB0", Offset = "0x147A1B0", VA = "0x18147ADB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x147B0D0", Offset = "0x147A4D0", VA = "0x18147B0D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NodeConnection> OnNodesDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x147AE50", Offset = "0x147A250", VA = "0x18147AE50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x147B170", Offset = "0x147A570", VA = "0x18147B170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x147AA80", Offset = "0x1479E80", VA = "0x18147AA80")]
		protected CircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1478740", Offset = "0x1477B40", VA = "0x181478740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1477850", Offset = "0x1476C50", VA = "0x181477850")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1479080", Offset = "0x1478480", VA = "0x181479080")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x14775C0", Offset = "0x14769C0", VA = "0x1814775C0")]
		protected void AddChildContext(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1479AF0", Offset = "0x1478EF0", VA = "0x181479AF0")]
		public bool SendEvent(CircuitEvent circuitEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1479B20", Offset = "0x1478F20", VA = "0x181479B20")]
		public void SendSynchronizedEvent(CircuitEvent circuitEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1479460", Offset = "0x1478860", VA = "0x181479460")]
		public void RequestCreateNewCircuitNode(Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1479830", Offset = "0x1478C30", VA = "0x181479830")]
		public void RequestDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1479670", Offset = "0x1478A70", VA = "0x181479670")]
		public void RequestCreateNewDynamicEvent(string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1479920", Offset = "0x1478D20", VA = "0x181479920")]
		public void RequestDestroyDynamicEvent(Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1478F00", Offset = "0x1478300", VA = "0x181478F00")]
		public void LocalDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1478ED0", Offset = "0x14782D0", VA = "0x181478ED0")]
		public void LocalDestroyCircuitNode([NotNull] Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1477660", Offset = "0x1476A60", VA = "0x181477660")]
		public void AddCircuitNode(Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x147A240", Offset = "0x1479640", VA = "0x18147A240")]
		protected bool TryFindNodeViaGloballyUniqueIdInternal(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1479B90", Offset = "0x1478F90", VA = "0x181479B90", Slot = "9")]
		public virtual CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1478080", Offset = "0x1477480", VA = "0x181478080")]
		internal void DeserializeTemplateData(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1478BB0", Offset = "0x1477FB0", VA = "0x181478BB0")]
		internal void InferAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1477A90", Offset = "0x1476E90", VA = "0x181477A90", Slot = "10")]
		public virtual void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1222260", Offset = "0x1221660", VA = "0x181222260")]
		public bool TryFindNode<TNode>(Guid nodeId, out TNode node) where TNode : Node
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x147A5D0", Offset = "0x14799D0", VA = "0x18147A5D0")]
		public bool TryFindNode(Guid nodeId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x147A1D0", Offset = "0x14795D0", VA = "0x18147A1D0")]
		public bool TryFindChildContext(Guid childContextId, out CircuitContext childContext)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1479340", Offset = "0x1478740", VA = "0x181479340")]
		public void RaiseOnCircuitNodesConnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x14793D0", Offset = "0x14787D0", VA = "0x1814793D0")]
		public void RaiseOnCircuitNodesDisconnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x14777F0", Offset = "0x1476BF0", VA = "0x1814777F0")]
		public void AddNodeRestriction(INodeRestriction nodeRestriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1478EA0", Offset = "0x14782A0", VA = "0x181478EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B3320", Offset = "0x8B2720", VA = "0x1808B3320")]
			public EventRegistration(CircuitContext registeredToContext, CircuitEventDefinition eventDefinition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1482EE0", Offset = "0x14822E0", VA = "0x181482EE0")]
			public void AddCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1483000", Offset = "0x1482400", VA = "0x181483000")]
			public void RemoveCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1483140", Offset = "0x1482540", VA = "0x181483140", Slot = "5")]
			public EventRegistrationData SerializeToProtobuf()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x1AB2910", Offset = "0x1AB1D10", VA = "0x181AB2910", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1041D10", Offset = "0x1041110", VA = "0x181041D10")]
			protected LimitedEventQueueBase(int maxEventsToProcessPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AD28D0", Offset = "0x1AD1CD0", VA = "0x181AD28D0")]
			public bool PushEvent(T queueEntry)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1AD2770", Offset = "0x1AD1B70", VA = "0x181AD2770", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x148D6B0", Offset = "0x148CAB0", VA = "0x18148D6B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x182180", Offset = "0x181580", VA = "0x180182180")]
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
				[Cpp2IlInjected.Address(RVA = "0x148AC40", Offset = "0x148A040", VA = "0x18148AC40", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			protected override Queue<CircuitEvent> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x148AC50", Offset = "0x148A050", VA = "0x18148AC50", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x148AAD0", Offset = "0x1489ED0", VA = "0x18148AAD0")]
			public LocalEventQueue(ITimeProvider timeProvider, int maxEventsToProcessPerFrame = 1024)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x148A940", Offset = "0x1489D40", VA = "0x18148A940")]
			public bool PushEventDelayed(CircuitEvent circuitEvent, float delay)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x148A770", Offset = "0x1489B70", VA = "0x18148A770", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x14827F0", Offset = "0x1481BF0", VA = "0x1814827F0")]
			public void AddCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1482CD0", Offset = "0x14820D0", VA = "0x181482CD0")]
			public void RemoveCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1482DF0", Offset = "0x14821F0", VA = "0x181482DF0")]
			private void RemoveHandlerInternal(Guid eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x1482950", Offset = "0x1481D50", VA = "0x181482950")]
			public void HandleEvent(CircuitEvent circuitEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14828F0", Offset = "0x1481CF0", VA = "0x1814828F0")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1482E60", Offset = "0x1482260", VA = "0x181482E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x147D7A0", Offset = "0x147CBA0", VA = "0x18147D7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x147D440", Offset = "0x147C840", VA = "0x18147D440")]
		public CircuitEventBus(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x147CAD0", Offset = "0x147BED0", VA = "0x18147CAD0")]
		public EventRegistration RegisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x147CEB0", Offset = "0x147C2B0", VA = "0x18147CEB0")]
		public EventRegistration RegisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x147CBB0", Offset = "0x147BFB0", VA = "0x18147CBB0")]
		private EventRegistration RegisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x147D3A0", Offset = "0x147C7A0", VA = "0x18147D3A0")]
		public void UnregisterDynamicCircuitEvent(Guid circuitEventDefinitionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x147D430", Offset = "0x147C830", VA = "0x18147D430")]
		public void UnregisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x147D1A0", Offset = "0x147C5A0", VA = "0x18147D1A0")]
		public void UnregisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x147D1B0", Offset = "0x147C5B0", VA = "0x18147D1B0")]
		private void UnregisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x147C220", Offset = "0x147B620", VA = "0x18147C220")]
		public IEnumerable<EventRegistration> GetListenableEvents(bool onlyPlayerListenable = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x147BB40", Offset = "0x147AF40", VA = "0x18147BB40")]
		private IReadOnlyList<EventRegistration> GetAllListenableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x147BF60", Offset = "0x147B360", VA = "0x18147BF60")]
		public EventRegistration GetListenableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x147C320", Offset = "0x147B720", VA = "0x18147C320")]
		public EventRegistration GetSendableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x147C3F0", Offset = "0x147B7F0", VA = "0x18147C3F0")]
		public IReadOnlyList<EventRegistration> GetSendableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x147CAA0", Offset = "0x147BEA0", VA = "0x18147CAA0")]
		public bool Publish(CircuitEvent outgoingEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x147C880", Offset = "0x147BC80", VA = "0x18147C880")]
		public bool PublishDelayed(CircuitEvent outgoingEvent, float delay)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x147CA20", Offset = "0x147BE20", VA = "0x18147CA20")]
		public bool PublishSynced(CircuitEvent outgoingEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x147C7A0", Offset = "0x147BBA0", VA = "0x18147C7A0")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x147C660", Offset = "0x147BA60", VA = "0x18147C660")]
		private void HandleLocalEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x147CF00", Offset = "0x147C300", VA = "0x18147CF00")]
		private void SendSyncedEvent(Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets> circuitEventAndTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x147C680", Offset = "0x147BA80", VA = "0x18147C680")]
		public void HandleReceivedSyncedEvent(SynchronizedEventData syncedEventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x147B410", Offset = "0x147A810", VA = "0x18147B410")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x147CFC0", Offset = "0x147C3C0", VA = "0x18147CFC0", Slot = "6")]
		public EventBusData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x147B8A0", Offset = "0x147ACA0", VA = "0x18147B8A0")]
		public void DeserializeFromTemplate(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x147B6A0", Offset = "0x147AAA0", VA = "0x18147B6A0", Slot = "4")]
		public void DeserializeFromProtobuf(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x147BA70", Offset = "0x147AE70", VA = "0x18147BA70")]
		private void DestroyCircuitObjectFromProtoData(CircuitEventObject circuitEventObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x147B480", Offset = "0x147A880", VA = "0x18147B480")]
		private CircuitEventObject CreateCircuitObjectFromProtoData(Guid eventId, CircuitEventObjectData protobufdata)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x147BAA0", Offset = "0x147AEA0", VA = "0x18147BAA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x147D130", Offset = "0x147C530", VA = "0x18147D130")]
		public bool TryGetDynamicEventObject(Guid eventDefEventDefinitionId, out CircuitEventObject circuitEventObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x147C740", Offset = "0x147BB40", VA = "0x18147C740")]
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
		[Cpp2IlInjected.Address(RVA = "0x147FCA0", Offset = "0x147F0A0", VA = "0x18147FCA0")]
		public CircuitEvent(Guid circuitEventTypeGuid, CircuitEventDefinition eventDefinition, IReadOnlyDictionary<string, CircuitSignal> signals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x147F350", Offset = "0x147E750", VA = "0x18147F350")]
		public SynchronizedEventData Pack()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x147F850", Offset = "0x147EC50", VA = "0x18147F850")]
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
			[Cpp2IlInjected.Address(RVA = "0x1482740", Offset = "0x1481B40", VA = "0x181482740")]
			public EventBuilder(CircuitEventDefinition definition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x14826A0", Offset = "0x1481AA0", VA = "0x1814826A0")]
			public EventBuilder WithSignal(string signalName, CircuitSignal signal)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x14825A0", Offset = "0x14819A0", VA = "0x1814825A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x147E220", Offset = "0x147D620", VA = "0x18147E220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CircuitType> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnDefinitionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x147E0E0", Offset = "0x147D4E0", VA = "0x18147E0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x147E180", Offset = "0x147D580", VA = "0x18147E180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x147E020", Offset = "0x147D420", VA = "0x18147E020")]
		public CircuitEventDefinition(string name, Guid eventDefinitionId, bool isPlayerListenable = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x147DBB0", Offset = "0x147CFB0", VA = "0x18147DBB0")]
		private bool Equals(CircuitEventDefinition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x147DAB0", Offset = "0x147CEB0", VA = "0x18147DAB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x147DBF0", Offset = "0x147CFF0", VA = "0x18147DBF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x818170", Offset = "0x817570", VA = "0x180818170")]
		public static bool operator !=(CircuitEventDefinition left, CircuitEventDefinition right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x147D7F0", Offset = "0x147CBF0", VA = "0x18147D7F0")]
		[EditableAddNamedPort(null)]
		public CircuitEventDefinition AddEventPropertyLocal(string name, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x147DCE0", Offset = "0x147D0E0", VA = "0x18147DCE0")]
		public CircuitEventDefinition RemoveEventPropertyLocal(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x147DD80", Offset = "0x147D180", VA = "0x18147DD80", Slot = "5")]
		public CircuitEventDefinitionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x147D890", Offset = "0x147CC90", VA = "0x18147D890", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitEventDefinitionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x147DC10", Offset = "0x147D010", VA = "0x18147DC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x147F1A0", Offset = "0x147E5A0", VA = "0x18147F1A0")]
		public CircuitEventObject(CircuitContext context, CircuitEventDefinition definition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x147EA50", Offset = "0x147DE50", VA = "0x18147EA50")]
		private bool Equals(CircuitEventObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x147EA90", Offset = "0x147DE90", VA = "0x18147EA90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x147EBA0", Offset = "0x147DFA0", VA = "0x18147EBA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x147EBD0", Offset = "0x147DFD0", VA = "0x18147EBD0")]
		public void RequestAddEventProperty(string name, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x147ED40", Offset = "0x147E140", VA = "0x18147ED40")]
		public void RequestRemoveEventProperty(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x147EE70", Offset = "0x147E270", VA = "0x18147EE70", Slot = "10")]
		public override CircuitEventObjectData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x147E6C0", Offset = "0x147DAC0", VA = "0x18147E6C0", Slot = "11")]
		public override void DeserializeFromProtobuf(CircuitEventObjectData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x147F150", Offset = "0x147E550", VA = "0x18147F150", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x147E5D0", Offset = "0x147D9D0", VA = "0x18147E5D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x147E5C0", Offset = "0x147D9C0", VA = "0x18147E5C0")]
		public CircuitEventObjectModificationHandler(CircuitEventObject modifiedEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x147E260", Offset = "0x147D660", VA = "0x18147E260")]
		public ICircuitObjectModification CreateAddPropertyModification(string propertyName, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x147E330", Offset = "0x147D730", VA = "0x18147E330")]
		public ICircuitObjectModification CreateRemovePropertyModification(string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x147E3D0", Offset = "0x147D7D0", VA = "0x18147E3D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x1487390", Offset = "0x1486790", VA = "0x181487390")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RateLimiter GlobalSyncedEventRateLimiter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x43CD40", Offset = "0x43C140", VA = "0x18043CD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1487320", Offset = "0x1486720", VA = "0x181487320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BufferedOperationsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x14872D0", Offset = "0x14866D0", VA = "0x1814872D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x14878B0", Offset = "0x1486CB0", VA = "0x1814878B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ObjectCircuitContext> OnObjectCircuitContextCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1487230", Offset = "0x1486630", VA = "0x181487230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1487810", Offset = "0x1486C10", VA = "0x181487810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CircuitContext, Node> OnCircuitNodeAddedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1486F10", Offset = "0x1486310", VA = "0x181486F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x14874F0", Offset = "0x14868F0", VA = "0x1814874F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1486FB0", Offset = "0x14863B0", VA = "0x181486FB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1487590", Offset = "0x1486990", VA = "0x181487590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NodeConnection> OnNodesConnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x14870F0", Offset = "0x14864F0", VA = "0x1814870F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x14876D0", Offset = "0x1486AD0", VA = "0x1814876D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NodeConnection> OnNodesDisconnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1487190", Offset = "0x1486590", VA = "0x181487190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1487770", Offset = "0x1486B70", VA = "0x181487770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CircuitContext, CircuitContext> OnContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1487050", Offset = "0x1486450", VA = "0x181487050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1487630", Offset = "0x1486A30", VA = "0x181487630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventRegisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1486DD0", Offset = "0x14861D0", VA = "0x181486DD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x14873B0", Offset = "0x14867B0", VA = "0x1814873B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventUnregisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1486E70", Offset = "0x1486270", VA = "0x181486E70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1487450", Offset = "0x1486850", VA = "0x181487450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1484B00", Offset = "0x1483F00", VA = "0x181484B00")]
		public Guid NextGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1486A70", Offset = "0x1485E70", VA = "0x181486A70")]
		public GlobalCircuitContext(ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1486B10", Offset = "0x1485F10", VA = "0x181486B10")]
		public GlobalCircuitContext(Guid contextId, ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74C260", Offset = "0x74B660", VA = "0x18074C260")]
		public void ResetMaxExecutions(int newRemaining = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1483500", Offset = "0x1482900", VA = "0x181483500", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextId, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1486970", Offset = "0x1485D70", VA = "0x181486970")]
		public bool TryFindNodeViaGloballyUniqueId(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1486920", Offset = "0x1485D20", VA = "0x181486920", Slot = "9")]
		public sealed override CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1483650", Offset = "0x1482A50", VA = "0x181483650", Slot = "10")]
		public override void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1484D20", Offset = "0x1484120", VA = "0x181484D20")]
		public void PushEditContext(CircuitContext circuitContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1484BB0", Offset = "0x1483FB0", VA = "0x181484BB0")]
		public void PopEditContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1485010", Offset = "0x1484410", VA = "0x181485010")]
		public void RaiseRegisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1485090", Offset = "0x1484490", VA = "0x181485090")]
		public void RaiseUnregisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1484EE0", Offset = "0x14842E0", VA = "0x181484EE0")]
		public void RaiseOnCircuitNodeDestroyedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1484E70", Offset = "0x1484270", VA = "0x181484E70")]
		public void RaiseOnCircuitNodeAddedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1484F50", Offset = "0x1484350", VA = "0x181484F50")]
		public void RaiseOnCircuitNodesConnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1484FB0", Offset = "0x14843B0", VA = "0x181484FB0")]
		public void RaiseOnCircuitNodesDisconnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1485110", Offset = "0x1484510", VA = "0x181485110")]
		public void RegisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1486990", Offset = "0x1485D90", VA = "0x181486990")]
		public void UnregisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1484B50", Offset = "0x1483F50", VA = "0x181484B50")]
		private void OnBufferedOpCountChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1483790", Offset = "0x1482B90", VA = "0x181483790")]
		public void MasterReinitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x14862E0", Offset = "0x14856E0", VA = "0x1814862E0")]
		[RPCMethod]
		protected void RpcReinitializeAll(CircuitContextData circuitContextData, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1485370", Offset = "0x1484770", VA = "0x181485370")]
		internal void RequestCreateNewCircuitNode(Guid contextId, Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1483990", Offset = "0x1482D90", VA = "0x181483990")]
		[RPCMethod]
		internal void MasterRpcCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1485B10", Offset = "0x1484F10", VA = "0x181485B10")]
		[RPCMethod]
		internal void RpcBufferedCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1485730", Offset = "0x1484B30", VA = "0x181485730")]
		internal void RequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1484540", Offset = "0x1483940", VA = "0x181484540")]
		[RPCMethod]
		internal void MasterRpcRequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1485DE0", Offset = "0x14851E0", VA = "0x181485DE0")]
		[RPCMethod]
		internal void RpcBufferedDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1485580", Offset = "0x1484980", VA = "0x181485580")]
		internal void RequestCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1483C60", Offset = "0x1483060", VA = "0x181483C60")]
		[RPCMethod]
		internal void MasterRpcCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1485CC0", Offset = "0x14850C0", VA = "0x181485CC0")]
		[RPCMethod]
		internal void RpcBufferedCreateNewDynamicEvent(Guid contextId, string eventName, Guid eventId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1485810", Offset = "0x1484C10", VA = "0x181485810")]
		internal void RequestDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1483F50", Offset = "0x1483350", VA = "0x181483F50")]
		[RPCMethod]
		internal void MasterRpcDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1485E40", Offset = "0x1485240", VA = "0x181485E40")]
		[RPCMethod]
		internal void RpcBufferedDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1485190", Offset = "0x1484590", VA = "0x181485190")]
		internal void RequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x14842D0", Offset = "0x14836D0", VA = "0x1814842D0")]
		[RPCMethod]
		internal void MasterRpcRequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1485F10", Offset = "0x1485310", VA = "0x181485F10")]
		[RPCMethod]
		internal void RpcConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1485970", Offset = "0x1484D70", VA = "0x181485970")]
		internal void RequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x14846A0", Offset = "0x1483AA0", VA = "0x1814846A0")]
		[RPCMethod]
		internal void MasterRpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1486390", Offset = "0x1485790", VA = "0x181486390")]
		[RPCMethod]
		internal void RpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x14865B0", Offset = "0x14859B0", VA = "0x1814865B0")]
		internal void SendObjectModification(ICircuitObjectModification nodeModificationBase)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1484110", Offset = "0x1483510", VA = "0x181484110")]
		[RPCMethod]
		internal void MasterRpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x14860E0", Offset = "0x14854E0", VA = "0x1814860E0")]
		[RPCMethod]
		internal void RpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x14848B0", Offset = "0x1483CB0", VA = "0x1814848B0")]
		public IEnumerable<CircuitObject> MasterSpawnTemplateOnAllClients(CircuitContext intoContext, CircuitContextData templateDataOriginal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1486560", Offset = "0x1485960", VA = "0x181486560")]
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
			[Cpp2IlInjected.Address(RVA = "0x445FB0", Offset = "0x4453B0", VA = "0x180445FB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18D2200", Offset = "0x18D1600", VA = "0x1818D2200")]
		public NestedCircuitContext(Guid contextId, ObjectCircuitContext parentSynchronizationContext, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18D2110", Offset = "0x18D1510", VA = "0x1818D2110", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D24A0", Offset = "0x18D18A0", VA = "0x1818D24A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x18D2540", Offset = "0x18D1940", VA = "0x1818D2540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x18D2430", Offset = "0x18D1830", VA = "0x1818D2430")]
		public ObjectCircuitContext(Guid contextId, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x18D2390", Offset = "0x18D1790", VA = "0x1818D2390")]
		public void SetSynchronizationBackend(ICircuitContextNetworking networkBackend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x18D2280", Offset = "0x18D1680", VA = "0x1818D2280", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x18D2360", Offset = "0x18D1760", VA = "0x1818D2360", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x445FB0", Offset = "0x4453B0", VA = "0x180445FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1D891F0", Offset = "0x1D885F0", VA = "0x181D891F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B6FF0", Offset = "0x4B63F0", VA = "0x1804B6FF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1D891A0", Offset = "0x1D885A0", VA = "0x181D891A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1D890D0", Offset = "0x1D884D0", VA = "0x181D890D0")]
		public SynchronizedCircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1D88A80", Offset = "0x1D87E80", VA = "0x181D88A80", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1D88990", Offset = "0x1D87D90", VA = "0x181D88990")]
		public void AddChildContextToLookup(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1D88C20", Offset = "0x1D88020", VA = "0x181D88C20")]
		public void RemoveChildContextFromLookup(Guid childContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1D88E80", Offset = "0x1D88280", VA = "0x181D88E80")]
		public void SendSynchronizedEvent(Guid fromContextId, CircuitEvent circuitEvent, SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1D88D00", Offset = "0x1D88100", VA = "0x181D88D00")]
		[RPCMethod]
		protected void RpcOnReceivedSynchronizedEvent(Guid contextId, SynchronizedEventData circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1D88AD0", Offset = "0x1D87ED0", VA = "0x181D88AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14DCF0", Offset = "0x14D0F0", VA = "0x18014DCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FloatValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x164C10", Offset = "0x164010", VA = "0x180164C10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CircuitPlayer PlayerValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x181E40", Offset = "0x181240", VA = "0x180181E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x181E70", Offset = "0x181270", VA = "0x180181E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x144CB0", Offset = "0x1440B0", VA = "0x180144CB0")]
		public object ObjectValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1567F0", Offset = "0x155BF0", VA = "0x1801567F0")]
		public T ObjectValue<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x181E20", Offset = "0x181220", VA = "0x180181E20")]
		private CircuitSignal(TypeKind circuitTypeKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1818A0", Offset = "0x180CA0", VA = "0x1801818A0")]
		public bool Equals(CircuitSignal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x181940", Offset = "0x180D40", VA = "0x180181940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x181A60", Offset = "0x180E60", VA = "0x180181A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1481AD0", Offset = "0x1480ED0", VA = "0x181481AD0")]
		public static bool operator !=(CircuitSignal left, CircuitSignal right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x181BE0", Offset = "0x180FE0", VA = "0x180181BE0")]
		public string InternalToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x181CF0", Offset = "0x1810F0", VA = "0x180181CF0")]
		internal CircuitSignalData ToSerializedSignalData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x14813E0", Offset = "0x14807E0", VA = "0x1814813E0")]
		internal static CircuitSignal FromSerializedSignalData(CircuitSignalData signalData)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x14810C0", Offset = "0x14804C0", VA = "0x1814810C0")]
		public static CircuitSignal DefaultFor(TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x14812D0", Offset = "0x14806D0", VA = "0x1814812D0")]
		public static CircuitSignal FromBool(bool newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1481360", Offset = "0x1480760", VA = "0x181481360")]
		public static CircuitSignal FromInt(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1481320", Offset = "0x1480720", VA = "0x181481320")]
		public static CircuitSignal FromFloat(float newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1481580", Offset = "0x1480980", VA = "0x181481580")]
		public static CircuitSignal FromString(string stringValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1481360", Offset = "0x1480760", VA = "0x181481360")]
		public static CircuitSignal FromPlayerID(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1481360", Offset = "0x1480760", VA = "0x181481360")]
		public static CircuitSignal FromPlayer(CircuitPlayer newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x14813A0", Offset = "0x14807A0", VA = "0x1814813A0")]
		public static CircuitSignal FromObject(object newValue, TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x14818C0", Offset = "0x1480CC0", VA = "0x1814818C0")]
		public static CircuitSignal List(List<CircuitSignal> list)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1480E20", Offset = "0x1480220", VA = "0x181480E20")]
		public static CircuitSignal CreateListFromPorts(IExecutionScope executionScope, IReadOnlyCollection<InputPort> valuePorts, bool includeUnconnected)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x181B30", Offset = "0x180F30", VA = "0x180181B30")]
		public List<CircuitSignal> GetListValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x14812D0", Offset = "0x14806D0", VA = "0x1814812D0")]
		public static explicit operator CircuitSignal(bool boolValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1481320", Offset = "0x1480720", VA = "0x181481320")]
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
		[Cpp2IlInjected.Address(RVA = "0x1481FB0", Offset = "0x14813B0", VA = "0x181481FB0")]
		public static implicit operator CircuitTypeOrString(string value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1481F80", Offset = "0x1481380", VA = "0x181481F80")]
		public static implicit operator CircuitTypeOrString(CircuitType value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x182050", Offset = "0x181450", VA = "0x180182050")]
		public CircuitType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1481E10", Offset = "0x1481210", VA = "0x181481E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D8A610", Offset = "0x1D89A10", VA = "0x181D8A610")]
		public static implicit operator TypeParamConstrainedOrNot(string name)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A6A0", Offset = "0x1D89AA0", VA = "0x181D8A6A0")]
		public static implicit operator TypeParamConstrainedOrNot([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5C260", Offset = "0x5B660")] (string, CircuitTypeOrString) fields)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x144CA0", Offset = "0x1440A0", VA = "0x180144CA0")]
		public TypeParameterType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A510", Offset = "0x1D89910", VA = "0x181D8A510")]
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
		[Cpp2IlInjected.Address(RVA = "0x14824B0", Offset = "0x14818B0", VA = "0x1814824B0")]
		public ClassFactoryTypeParams(Guid? name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x14821D0", Offset = "0x14815D0", VA = "0x1814821D0")]
		public ClassFactoryTypeParams CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x14822F0", Offset = "0x14816F0", VA = "0x1814822F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1482100", Offset = "0x1481500", VA = "0x181482100")]
		public ClassFactoryProps(Guid? name, string friendlyName, IList<TypeParameterType> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1481FF0", Offset = "0x14813F0", VA = "0x181481FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8B610", Offset = "0x1D8AA10", VA = "0x181D8B610")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8C360", Offset = "0x1D8B760", VA = "0x181D8C360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static CircuitType CInt
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C520", Offset = "0x1D8B920", VA = "0x181D8C520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static CircuitType CFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C4B0", Offset = "0x1D8B8B0", VA = "0x181D8C4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CircuitType CString
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C590", Offset = "0x1D8B990", VA = "0x181D8C590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static CircuitType CAny
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C2F0", Offset = "0x1D8B6F0", VA = "0x181D8C2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static CircuitType CExec
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C440", Offset = "0x1D8B840", VA = "0x181D8C440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CircuitType CErr
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1D8C3D0", Offset = "0x1D8B7D0", VA = "0x181D8C3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BBD0", Offset = "0x1D8AFD0", VA = "0x181D8BBD0")]
		public static AppliedGenericType CArray(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BE40", Offset = "0x1D8B240", VA = "0x181D8BE40")]
		public static AppliedGenericType CList(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BCC0", Offset = "0x1D8B0C0", VA = "0x181D8BCC0")]
		public static ClassFactoryTypeParams CClass()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BD30", Offset = "0x1D8B130", VA = "0x181D8BD30")]
		public static ClassFactoryTypeParams CClass(Guid name, string friendlyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BDD0", Offset = "0x1D8B1D0", VA = "0x181D8BDD0")]
		public static AppliedGenericType CIntersect(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BF40", Offset = "0x1D8B340", VA = "0x181D8BF40")]
		public static AppliedGenericType CTuple(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BFB0", Offset = "0x1D8B3B0", VA = "0x181D8BFB0")]
		public static TypeParameterType CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1D8C080", Offset = "0x1D8B480", VA = "0x181D8C080")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D78160", Offset = "0x1D77560", VA = "0x181D78160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1D77770", Offset = "0x1D76B70", VA = "0x181D77770", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1D77850", Offset = "0x1D76C50", VA = "0x181D77850", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1D780E0", Offset = "0x1D774E0", VA = "0x181D780E0")]
		public AppliedGenericType(GenericType originalType, IEnumerable<CircuitType> typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D780A0", Offset = "0x1D774A0", VA = "0x181D780A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D77D40", Offset = "0x1D77140", VA = "0x181D77D40", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1D77CB0", Offset = "0x1D770B0", VA = "0x181D77CB0", Slot = "10")]
		public bool Equals(AppliedGenericType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1D77E10", Offset = "0x1D77210", VA = "0x181D77E10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1D77E60", Offset = "0x1D77260", VA = "0x181D77E60", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1D77EE0", Offset = "0x1D772E0", VA = "0x181D77EE0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1D77AA0", Offset = "0x1D76EA0", VA = "0x181D77AA0")]
		public static AppliedGenericType DeserializeFromProtobuf(AppliedGenericTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ArrayType : GenericType, IEquatable<ArrayType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D78430", Offset = "0x1D77830", VA = "0x181D78430")]
		public ArrayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D783D0", Offset = "0x1D777D0", VA = "0x181D783D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D78340", Offset = "0x1D77740", VA = "0x181D78340", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D78300", Offset = "0x1D77700", VA = "0x181D78300")]
		private static string ToStringImpl(string typeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D782A0", Offset = "0x1D776A0", VA = "0x181D782A0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DF0", Offset = "0x3C01F0", VA = "0x1803C0DF0", Slot = "11")]
		public bool Equals(ArrayType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D78250", Offset = "0x1D77650", VA = "0x181D78250", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D782F0", Offset = "0x1D776F0", VA = "0x181D782F0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x5181D0", Offset = "0x5175D0", VA = "0x1805181D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x382670", VA = "0x180383270")]
		public CircuitType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B6FF0", Offset = "0x4B63F0", VA = "0x1804B6FF0", Slot = "5")]
		public virtual CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x160F380", Offset = "0x160E780", VA = "0x18160F380", Slot = "7")]
		public virtual void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x160F870", Offset = "0x160EC70", VA = "0x18160F870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x160F710", Offset = "0x160EB10", VA = "0x18160F710", Slot = "8")]
		public virtual bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x160F6C0", Offset = "0x160EAC0", VA = "0x18160F6C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x160F970", Offset = "0x160ED70", VA = "0x18160F970")]
		public static bool operator ==(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x160F990", Offset = "0x160ED90", VA = "0x18160F990")]
		public static bool operator !=(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x160F7D0", Offset = "0x160EBD0", VA = "0x18160F7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x160F7F0", Offset = "0x160EBF0", VA = "0x18160F7F0", Slot = "9")]
		public virtual CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x160F3E0", Offset = "0x160E7E0", VA = "0x18160F3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1610BA0", Offset = "0x160FFA0", VA = "0x181610BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1610A70", Offset = "0x160FE70", VA = "0x181610A70")]
		public ClassType([Optional] IEnumerable<TypeParameterType> typeParameters, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] Guid? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1610740", Offset = "0x160FB40", VA = "0x181610740", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x160F9D0", Offset = "0x160EDD0", VA = "0x18160F9D0")]
		private string ClassNameToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x16109F0", Offset = "0x160FDF0", VA = "0x1816109F0")]
		private string TypeParametersToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1610320", Offset = "0x160F720", VA = "0x181610320")]
		private string PropertiesToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x13F51C0", Offset = "0x13F45C0", VA = "0x1813F51C0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParamaterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x160FFA0", Offset = "0x160F3A0", VA = "0x18160FFA0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x160FDF0", Offset = "0x160F1F0", VA = "0x18160FDF0", Slot = "11")]
		public bool Equals(ClassType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x160FDA0", Offset = "0x160F1A0", VA = "0x18160FDA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1610190", Offset = "0x160F590", VA = "0x181610190", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1610490", Offset = "0x160F890", VA = "0x181610490", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x160FA90", Offset = "0x160EE90", VA = "0x18160FA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1611A00", Offset = "0x1610E00", VA = "0x181611A00")]
		public FunctionType(IEnumerable<TypeParameterType> typeParameters, IEnumerable<KeyValuePair<string, Parameter>> parameters, IEnumerable<KeyValuePair<string, Return>> returns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x16119D0", Offset = "0x1610DD0", VA = "0x1816119D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x16119A0", Offset = "0x1610DA0", VA = "0x1816119A0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x16113E0", Offset = "0x16107E0", VA = "0x1816113E0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x16114D0", Offset = "0x16108D0", VA = "0x1816114D0", Slot = "11")]
		public bool Equals(FunctionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1611390", Offset = "0x1610790", VA = "0x181611390", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1611580", Offset = "0x1610980", VA = "0x181611580", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1611640", Offset = "0x1610A40", VA = "0x181611640", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1611060", Offset = "0x1610460", VA = "0x181611060")]
		public static FunctionType DeserializeFromProtobuf(FunctionTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GenericType : CircuitType
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x382670", VA = "0x180383270")]
		protected GenericType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract string ToString(IReadOnlyList<CircuitType> typeParameterAssignments);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1611B30", Offset = "0x1610F30", VA = "0x181611B30")]
		public AppliedGenericType NewApplication(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1611AC0", Offset = "0x1610EC0", VA = "0x181611AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1612780", Offset = "0x1611B80", VA = "0x181612780")]
		public IntersectionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1612750", Offset = "0x1611B50", VA = "0x181612750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x16126B0", Offset = "0x1611AB0", VA = "0x1816126B0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1612660", Offset = "0x1611A60", VA = "0x181612660", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DF0", Offset = "0x3C01F0", VA = "0x1803C0DF0", Slot = "11")]
		public bool Equals(IntersectionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1612610", Offset = "0x1611A10", VA = "0x181612610", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x160F7D0", Offset = "0x160EBD0", VA = "0x18160F7D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8F60", VA = "0x1803A9B60")]
		public Parameter(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1612B70", Offset = "0x1611F70", VA = "0x181612B70", Slot = "4")]
		public bool Equals(Parameter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1612BB0", Offset = "0x1611FB0", VA = "0x181612BB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x10B4A20", Offset = "0x10B3E20", VA = "0x1810B4A20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1612C00", Offset = "0x1612000", VA = "0x181612C00")]
		public ParameterData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1612AF0", Offset = "0x1611EF0", VA = "0x181612AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E2AF0", Offset = "0x4E1EF0", VA = "0x1804E2AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5140F0", Offset = "0x5134F0", VA = "0x1805140F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1613090", Offset = "0x1612490", VA = "0x181613090")]
		public Property(CircuitType type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1612FD0", Offset = "0x16123D0", VA = "0x181612FD0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1612EA0", Offset = "0x16122A0", VA = "0x181612EA0")]
		private string GetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1612F90", Offset = "0x1612390", VA = "0x181612F90")]
		private string SetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1612D40", Offset = "0x1612140", VA = "0x181612D40", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1612DD0", Offset = "0x16121D0", VA = "0x181612DD0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1612E20", Offset = "0x1612220", VA = "0x181612E20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1612EE0", Offset = "0x16122E0", VA = "0x181612EE0")]
		public PropertyData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1612C90", Offset = "0x1612090", VA = "0x181612C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8F60", VA = "0x1803A9B60")]
		public Return(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1612B70", Offset = "0x1611F70", VA = "0x181612B70", Slot = "4")]
		public bool Equals(Return other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1613EC0", Offset = "0x16132C0", VA = "0x181613EC0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x10B4A20", Offset = "0x10B3E20", VA = "0x1810B4A20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1613F10", Offset = "0x1613310", VA = "0x181613F10")]
		public ReturnData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1613E40", Offset = "0x1613240", VA = "0x181613E40")]
		public static Return DeserializeFromProtobuf(ReturnData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class TupleType : GenericType, IEquatable<TupleType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1615110", Offset = "0x1614510", VA = "0x181615110")]
		public TupleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x16150E0", Offset = "0x16144E0", VA = "0x1816150E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1615080", Offset = "0x1614480", VA = "0x181615080", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1615030", Offset = "0x1614430", VA = "0x181615030", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DF0", Offset = "0x3C01F0", VA = "0x1803C0DF0", Slot = "11")]
		public bool Equals(TupleType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1614FE0", Offset = "0x16143E0", VA = "0x181614FE0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x160F7D0", Offset = "0x160EBD0", VA = "0x18160F7D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BD610", VA = "0x1803BE210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1615130", Offset = "0x1614530", VA = "0x181615130", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1615220", Offset = "0x1614620", VA = "0x181615220", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1615500", Offset = "0x1614900", VA = "0x181615500")]
		public TypeParameterReferenceType(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1615350", Offset = "0x1614750", VA = "0x181615350", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x16153D0", Offset = "0x16147D0", VA = "0x1816153D0", Slot = "10")]
		public bool Equals(TypeParameterReferenceType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1615300", Offset = "0x1614700", VA = "0x181615300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1615400", Offset = "0x1614800", VA = "0x181615400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1615450", Offset = "0x1614850", VA = "0x181615450", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1615280", Offset = "0x1614680", VA = "0x181615280")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x16155F0", Offset = "0x16149F0", VA = "0x1816155F0")]
		protected TypeParameterScopeType(IEnumerable<TypeParameterType> typeParameters, TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1615530", Offset = "0x1614930", VA = "0x181615530")]
		protected bool Equals(TypeParameterScopeType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1615590", Offset = "0x1614990", VA = "0x181615590", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1615A80", Offset = "0x1614E80", VA = "0x181615A80")]
		public TypeParameterType(string name, [Optional] CircuitType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1615A00", Offset = "0x1614E00", VA = "0x181615A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1615800", Offset = "0x1614C00", VA = "0x181615800", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1615740", Offset = "0x1614B40", VA = "0x181615740", Slot = "10")]
		public bool Equals(TypeParameterType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x16157B0", Offset = "0x1614BB0", VA = "0x1816157B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x16158B0", Offset = "0x1614CB0", VA = "0x1816158B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1615930", Offset = "0x1614D30", VA = "0x181615930", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1615660", Offset = "0x1614A60", VA = "0x181615660")]
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
		[Cpp2IlInjected.Address(RVA = "0x1196010", Offset = "0x1195410", VA = "0x181196010")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(params TNode[] nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1195EC0", Offset = "0x11952C0", VA = "0x181195EC0")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TNode> nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x128F2B0", Offset = "0x128E6B0", VA = "0x18128F2B0")]
		private static (Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>) GenerateConstraintsForNodes<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(IEnumerable<TNode> nodes, TUnificationArena unificationArena) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1C01DB0", Offset = "0x1C011B0", VA = "0x181C01DB0")]
		private static void GenerateConstraintsForNode<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToId, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToIdAll, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5E4C0", Offset = "0x5D8C0")] List<(int, CircuitType)> idToType, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5E6A0", Offset = "0x5DAA0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1195D60", Offset = "0x1195160", VA = "0x181195D60")]
		private static Dictionary<string, int> IdentifyTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5E9C0", Offset = "0x5DDC0")] List<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x10E88D0", Offset = "0x10E7CD0", VA = "0x1810E88D0")]
		private static IEnumerable<(TPort, int)> GetGenericPorts<TPort, TUnificationArena, TTerm, TNode, TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TPort> ports, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToTypeId) where TPort : class, ICheckablePort where TUnificationArena : IUnificationArena<TTerm> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x128FCD0", Offset = "0x128F0D0", VA = "0x18128FCD0")]
		private static (int, TTerm) GenerateOutputConstraintsAndId<TTerm, TOutputPort, TNode, TInputPort, TCheckableConnection, TUnificationArena>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5FE20", Offset = "0x5F220")] IEnumerable<(TOutputPort, int)> outputPorts, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5FF40", Offset = "0x5F340")] List<(int, CircuitType)> idToType, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((int, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1C028C0", Offset = "0x1C01CC0", VA = "0x181C028C0")]
		private static void GenerateInputConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60320", Offset = "0x5F720")] IEnumerable<(TInputPort, int)> inputPorts, TUnificationArena unificationArena, int outputPortId, TTerm outputPortUnificationTerm, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60510", Offset = "0x5F910")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x12E0AB0", Offset = "0x12DFEB0", VA = "0x1812E0AB0")]
		private static int GenerateInputConnectionConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TInputPort inputPort, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60730", Offset = "0x5FB30")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x15FE040", Offset = "0x15FD440", VA = "0x1815FE040")]
		private static TTerm GetTypeUnificationTerm<TTerm, TUnificationArena>(CircuitType type, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x608D0", Offset = "0x5FCD0")] List<(int, CircuitType)> idToType, IReadOnlyDictionary<string, int> typeParameterToId) where TUnificationArena : IUnificationArena<TTerm>
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1195650", Offset = "0x1194A50", VA = "0x181195650")]
		private static Dictionary<TNode, List<(string, CircuitType)>> GetTypeParameterAssignments<TNode, TInputPort, TOutputPort, TCheckableConnection>(ReferenceSubstitution[] substitutions, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60A70", Offset = "0x5FE70")] IEnumerable<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1C00FE0", Offset = "0x1C003E0", VA = "0x181C00FE0")]
		private static void CacheAdditionalEquivalentTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection>(TNode node, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60C50", Offset = "0x60050")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1C01710", Offset = "0x1C00B10", VA = "0x181C01710")]
		private static void GenerateConstraintsForAdditionalEquivalentTypeParameters<TUnificationArena, TTerm, TNode>(TUnificationArena unificationArena, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60CF0", Offset = "0x600F0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1D89C40", Offset = "0x1D89040", VA = "0x181D89C40")]
		private static Dictionary<int, CircuitType> ApplySubstitutions(Dictionary<int, ReferenceSubstitution> substitutions, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60DF0", Offset = "0x601F0")] IEnumerable<(int, CircuitType)> idToType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A130", Offset = "0x1D89530", VA = "0x181D8A130")]
		private static CircuitType MonomorphizeItem(ITerm type, Dictionary<int, CircuitType> idToType, Dictionary<int, CircuitType> cache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D89FE0", Offset = "0x1D893E0", VA = "0x181D89FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x144CA0", Offset = "0x1440A0", VA = "0x180144CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x144CB0", Offset = "0x1440B0", VA = "0x180144CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x145F10", Offset = "0x145310", VA = "0x180145F10")]
		public TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x237440", Offset = "0x236840", VA = "0x180237440", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x237510", Offset = "0x236910", VA = "0x180237510", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2375A0", Offset = "0x2369A0", VA = "0x1802375A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x237630", Offset = "0x236A30", VA = "0x180237630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class TypeParameterId
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x12A2BC0", Offset = "0x12A1FC0", VA = "0x1812A2BC0")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x63830", Offset = "0x62C30")]
			public readonly (Constraint, Constraint) constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Substitution substitution;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1C5020", Offset = "0x1C4420", VA = "0x1801C5020")]
			public Impl(in Constraint first, in Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1C5030", Offset = "0x1C4430", VA = "0x1801C5030")]
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
			[Cpp2IlInjected.Address(RVA = "0x136830", Offset = "0x135C30", VA = "0x180136830")]
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
			[Cpp2IlInjected.Address(RVA = "0x144CA0", Offset = "0x1440A0", VA = "0x180144CA0")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Constraint SecondConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x144CB0", Offset = "0x1440B0", VA = "0x180144CB0")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Substitution Substitution
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x144CA0", Offset = "0x1440A0", VA = "0x180144CA0")]
			get
			{
				return default(Substitution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F20", Offset = "0x1C4320", VA = "0x1801C4F20")]
		private ApplyConstraintResult(in Constraint first, in Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x16027C0", Offset = "0x1601BC0", VA = "0x1816027C0")]
		public static ApplyConstraintResult NewConstraints(in Constraint first, in Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1C4EF0", Offset = "0x1C42F0", VA = "0x1801C4EF0")]
		private ApplyConstraintResult(in Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1602870", Offset = "0x1601C70", VA = "0x181602870")]
		public static ApplyConstraintResult NewSubstitution(in Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F30", Offset = "0x1C4330", VA = "0x1801C4F30")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1602850", Offset = "0x1601C50", VA = "0x181602850")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FC0", Offset = "0x1393C0", VA = "0x180139FC0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x13CE30", Offset = "0x13C230", VA = "0x18013CE30")]
		public Arrow(TermIndex from, TermIndex to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F60", Offset = "0x1C4360", VA = "0x1801C4F60", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FC0", Offset = "0x1393C0", VA = "0x180139FC0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F70", Offset = "0x1C4370", VA = "0x1801C4F70")]
		public ApplyConstraintResult Apply(Term[] terms)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x13CE30", Offset = "0x13C230", VA = "0x18013CE30")]
		public Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1C4FA0", Offset = "0x1C43A0", VA = "0x1801C4FA0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FC0", Offset = "0x1393C0", VA = "0x180139FC0")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x13CE30", Offset = "0x13C230", VA = "0x18013CE30")]
		public Substitution(int identifier, TermIndex value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1C5090", Offset = "0x1C4490", VA = "0x1801C5090", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C5050", Offset = "0x1C4450", VA = "0x1801C5050")]
			public Impl(in Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x1C5060", Offset = "0x1C4460", VA = "0x1801C5060")]
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
			[Cpp2IlInjected.Address(RVA = "0x13CE10", Offset = "0x13C210", VA = "0x18013CE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x144CA0", Offset = "0x1440A0", VA = "0x180144CA0")]
			get
			{
				return default(Arrow);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1C5270", Offset = "0x1C4670", VA = "0x1801C5270")]
		private Term(in Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1614FA0", Offset = "0x16143A0", VA = "0x181614FA0")]
		public static Term NewArrow(in Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1C5280", Offset = "0x1C4680", VA = "0x1801C5280")]
		private Term(int identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1614FC0", Offset = "0x16143C0", VA = "0x181614FC0")]
		public static Term NewIdentifier(int identifier)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C5180", Offset = "0x1C4580", VA = "0x1801C5180", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x146D00", Offset = "0x146100", VA = "0x180146D00")]
		public TermIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1C5120", Offset = "0x1C4520", VA = "0x1801C5120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5110", Offset = "0x1C4510", VA = "0x1801C5110")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3832E0", Offset = "0x3826E0", VA = "0x1803832E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Stack<Constraint> Constraints
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1619670", Offset = "0x1618A70", VA = "0x181619670", Slot = "4")]
		public int NextId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x12E0D90", Offset = "0x12E0190", VA = "0x1812E0D90", Slot = "5")]
		public int GetId<T>(Dictionary<T, int> itemToIndex, T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x16194B0", Offset = "0x16188B0", VA = "0x1816194B0", Slot = "6")]
		public TermIndex Arrow(TermIndex from, TermIndex to)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3A6330", Offset = "0x3A5730", VA = "0x1803A6330", Slot = "7")]
		public TermIndex Identifier(int value)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1619560", Offset = "0x1618960", VA = "0x181619560", Slot = "8")]
		public void Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1619710", Offset = "0x1618B10", VA = "0x181619710", Slot = "9")]
		public ReferenceSubstitution[] Solve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x16195D0", Offset = "0x16189D0", VA = "0x1816195D0")]
		public static UnificationArena New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D7C10", Offset = "0x3D7010", VA = "0x1803D7C10", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1613960", Offset = "0x1612D60", VA = "0x181613960", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8B3320", Offset = "0x8B2720", VA = "0x1808B3320")]
		public ReferenceArrow(ITerm from, ITerm to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1613AD0", Offset = "0x1612ED0", VA = "0x181613AD0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C9370", Offset = "0x3C8770", VA = "0x1803C9370", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1613B60", Offset = "0x1612F60", VA = "0x181613B60", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x382670", VA = "0x180383270")]
		public ReferenceIdentifier(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1613C70", Offset = "0x1613070", VA = "0x181613C70", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A7C00", Offset = "0x9A7000", VA = "0x1809A7C00")]
		public ReferenceSubstitution(int identifier, ITerm value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1613DF0", Offset = "0x16131F0", VA = "0x181613DF0")]
		public ReferenceSubstitution(in Substitution substitution, Term[] terms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1613C90", Offset = "0x1613090", VA = "0x181613C90")]
		private static ITerm FromTermIndex(TermIndex termIndex, Term[] terms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1613D90", Offset = "0x1613190", VA = "0x181613D90", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x146D00", Offset = "0x146100", VA = "0x180146D00")]
			public IntBytesUnion(int intVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2421F0", Offset = "0x2415F0", VA = "0x1802421F0")]
			public IntBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2421E0", Offset = "0x2415E0", VA = "0x1802421E0")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1D784E0", Offset = "0x1D778E0", VA = "0x181D784E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D873F0", Offset = "0x1D867F0", VA = "0x181D873F0")]
		internal static bool TryGetTypeSerializer(CircuitType signalType, out ITypeSerializer typeSerializer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D87280", Offset = "0x1D86680", VA = "0x181D87280")]
		public static void SerializeSignalForSync(Stream stream, CircuitType signalType, CircuitSignal signalValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D870E0", Offset = "0x1D864E0", VA = "0x181D870E0")]
		public static CircuitSignal DeserializeSyncedSignal(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D87700", Offset = "0x1D86B00", VA = "0x181D87700")]
		public static void WriteInt(Stream stream, int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D784E0", Offset = "0x1D778E0", VA = "0x181D784E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB8F010", Offset = "0xB8E410", VA = "0x180B8F010", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D784A0", Offset = "0x1D778A0", VA = "0x181D784A0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D78440", Offset = "0x1D77840", VA = "0x181D78440", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		public BooleanSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class IntSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xB8EDD0", Offset = "0xB8E1D0", VA = "0x180B8EDD0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D78820", Offset = "0x1D77C20", VA = "0x181D78820", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D787A0", Offset = "0x1D77BA0", VA = "0x181D787A0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x164C20", Offset = "0x164020", VA = "0x180164C20")]
			public FloatBytesUnion(float floatVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2421F0", Offset = "0x2415F0", VA = "0x1802421F0")]
			public FloatBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x2421E0", Offset = "0x2415E0", VA = "0x1802421E0")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1D784E0", Offset = "0x1D778E0", VA = "0x181D784E0")]
			public static FloatBytesUnion ReadFromStream(Stream stream)
			{
				return default(FloatBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D78610", Offset = "0x1D77A10", VA = "0x181D78610", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D78710", Offset = "0x1D77B10", VA = "0x181D78710", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D78640", Offset = "0x1D77A40", VA = "0x181D78640", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		public FloatSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class StringSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D87930", Offset = "0x1D86D30", VA = "0x181D87930", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D87AB0", Offset = "0x1D86EB0", VA = "0x181D87AB0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D87960", Offset = "0x1D86D60", VA = "0x181D87960", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		public StringSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class PlayerSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D7FD80", Offset = "0x1D7F180", VA = "0x181D7FD80", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D7FE70", Offset = "0x1D7F270", VA = "0x181D7FE70", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D7FDF0", Offset = "0x1D7F1F0", VA = "0x181D7FDF0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		public PlayerSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class ListSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D797B0", Offset = "0x1D78BB0", VA = "0x181D797B0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D79A60", Offset = "0x1D78E60", VA = "0x181D79A60", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D798D0", Offset = "0x1D78CD0", VA = "0x181D798D0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C5050", Offset = "0x18C4450", VA = "0x1818C5050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x18C3D00", Offset = "0x18C3100", VA = "0x1818C3D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C65A0", Offset = "0x18C59A0", VA = "0x1818C65A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C64D0", Offset = "0x18C58D0", VA = "0x1818C64D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C6600", Offset = "0x18C5A00", VA = "0x1818C6600", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x18C6750", Offset = "0x18C5B50", VA = "0x1818C6750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x18C67F0", Offset = "0x18C5BF0", VA = "0x1818C67F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public PortCollectionData InputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PortCollectionData OutputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x3AB170", Offset = "0x3AA570", VA = "0x1803AB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public RepeatedField<NodeConnectionData> NodeConnectionDatas
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x1803B12E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x390F70", Offset = "0x390370", VA = "0x180390F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x18C67A0", Offset = "0x18C5BA0", VA = "0x1818C67A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B06D0", VA = "0x1803B12D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x42F4C0", Offset = "0x42E8C0", VA = "0x18042F4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x39FE10", Offset = "0x39F210", VA = "0x18039FE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x430EF0", Offset = "0x4302F0", VA = "0x180430EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public ByteString InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x3928D0", Offset = "0x391CD0", VA = "0x1803928D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x18C6700", Offset = "0x18C5B00", VA = "0x1818C6700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> ListensToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x395370", Offset = "0x394770", VA = "0x180395370")]
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
			[Cpp2IlInjected.Address(RVA = "0x38EBB0", Offset = "0x38DFB0", VA = "0x18038EBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40FEE0", Offset = "0x40F2E0", VA = "0x18040FEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x486D40", Offset = "0x486140", VA = "0x180486D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public VariableNodeData VariableNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445490", VA = "0x180446090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x4A1260", Offset = "0x4A0660", VA = "0x1804A1260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x18C6280", Offset = "0x18C5680", VA = "0x1818C6280")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x18C6370", Offset = "0x18C5770", VA = "0x1818C6370")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x18C5430", Offset = "0x18C4830", VA = "0x1818C5430", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x18C56B0", Offset = "0x18C4AB0", VA = "0x1818C56B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x18C5490", Offset = "0x18C4890", VA = "0x1818C5490", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x18C5710", Offset = "0x18C4B10", VA = "0x1818C5710", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x18C5CF0", Offset = "0x18C50F0", VA = "0x1818C5CF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x18C5D50", Offset = "0x18C5150", VA = "0x1818C5D50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x18C50B0", Offset = "0x18C44B0", VA = "0x1818C50B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x18C5920", Offset = "0x18C4D20", VA = "0x1818C5920", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7350", Offset = "0x18C6750", VA = "0x1818C7350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x18C6840", Offset = "0x18C5C40", VA = "0x1818C6840")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D91C40", Offset = "0x1D91040", VA = "0x181D91C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D91BC0", Offset = "0x1D90FC0", VA = "0x181D91BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D91CA0", Offset = "0x1D910A0", VA = "0x181D91CA0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x478120", Offset = "0x477520", VA = "0x180478120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x4E8560", Offset = "0x4E7960", VA = "0x1804E8560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x478130", Offset = "0x477530", VA = "0x180478130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x4E8570", Offset = "0x4E7970", VA = "0x1804E8570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x45ACA0", Offset = "0x45A0A0", VA = "0x18045ACA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x45AC90", Offset = "0x45A090", VA = "0x18045AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x573010", Offset = "0x572410", VA = "0x180573010")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1D919A0", Offset = "0x1D90DA0", VA = "0x181D919A0", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1D91A10", Offset = "0x1D90E10", VA = "0x181D91A10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x572B20", Offset = "0x571F20", VA = "0x180572B20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x572C50", Offset = "0x572050", VA = "0x180572C50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1D91AA0", Offset = "0x1D90EA0", VA = "0x181D91AA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x572E90", Offset = "0x572290", VA = "0x180572E90", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x572A70", Offset = "0x571E70", VA = "0x180572A70", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x572DB0", Offset = "0x5721B0", VA = "0x180572DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86130", Offset = "0x1D85530", VA = "0x181D86130")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D860B0", Offset = "0x1D854B0", VA = "0x181D860B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86190", Offset = "0x1D85590", VA = "0x181D86190", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x478120", Offset = "0x477520", VA = "0x180478120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x4E8560", Offset = "0x4E7960", VA = "0x1804E8560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x478130", Offset = "0x477530", VA = "0x180478130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x4E8570", Offset = "0x4E7970", VA = "0x1804E8570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x45ACA0", Offset = "0x45A0A0", VA = "0x18045ACA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x45AC90", Offset = "0x45A090", VA = "0x18045AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7D0", Offset = "0x3ADBD0", VA = "0x1803AE7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3AE870", Offset = "0x3ADC70", VA = "0x1803AE870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public QuaternionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8978E0", Offset = "0x896CE0", VA = "0x1808978E0")]
		[DebuggerNonUserCode]
		public QuaternionData(QuaternionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1D85E70", Offset = "0x1D85270", VA = "0x181D85E70", Slot = "9")]
		[DebuggerNonUserCode]
		public QuaternionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1D85EF0", Offset = "0x1D852F0", VA = "0x181D85EF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xC866B0", Offset = "0xC85AB0", VA = "0x180C866B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(QuaternionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xC86800", Offset = "0xC85C00", VA = "0x180C86800", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1D85F90", Offset = "0x1D85390", VA = "0x181D85F90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xC86AA0", Offset = "0xC85EA0", VA = "0x180C86AA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xC865E0", Offset = "0xC859E0", VA = "0x180C865E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xC86940", Offset = "0xC85D40", VA = "0x180C86940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7CF0", Offset = "0x18C70F0", VA = "0x1818C7CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7C20", Offset = "0x18C7020", VA = "0x1818C7C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7D50", Offset = "0x18C7150", VA = "0x1818C7D50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x18C7E60", Offset = "0x18C7260", VA = "0x1818C7E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public Vector3Data LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public QuaternionData LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x18C7BC0", Offset = "0x18C6FC0", VA = "0x1818C7BC0")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x18C7B00", Offset = "0x18C6F00", VA = "0x1818C7B00")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData(CircuitObjectTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x18C74B0", Offset = "0x18C68B0", VA = "0x1818C74B0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x18C7670", Offset = "0x18C6A70", VA = "0x1818C7670", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x18C75A0", Offset = "0x18C69A0", VA = "0x1818C75A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitObjectTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x18C7780", Offset = "0x18C6B80", VA = "0x1818C7780", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x18C7930", Offset = "0x18C6D30", VA = "0x1818C7930", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x18C7990", Offset = "0x18C6D90", VA = "0x1818C7990", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x18C73B0", Offset = "0x18C67B0", VA = "0x1818C73B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x18C7810", Offset = "0x18C6C10", VA = "0x1818C7810", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8500", Offset = "0x18C7900", VA = "0x1818C8500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x18C7EB0", Offset = "0x18C72B0", VA = "0x1818C7EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8DB0", Offset = "0x18C81B0", VA = "0x1818C8DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8CE0", Offset = "0x18C80E0", VA = "0x1818C8CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8E10", Offset = "0x18C8210", VA = "0x1818C8E10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public bool BackingBool
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x5D7290", Offset = "0x5D6690", VA = "0x1805D7290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x5D7260", Offset = "0x5D6660", VA = "0x1805D7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int BackingInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x3AB310", Offset = "0x3AA710", VA = "0x1803AB310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x3AB430", Offset = "0x3AA830", VA = "0x1803AB430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public float BackingFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7D0", Offset = "0x3ADBD0", VA = "0x1803AE7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3AE870", Offset = "0x3ADC70", VA = "0x1803AE870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public string BackingString
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x18C8F10", Offset = "0x18C8310", VA = "0x1818C8F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x18C8C20", Offset = "0x18C8020", VA = "0x1818C8C20")]
		[DebuggerNonUserCode]
		public CircuitSignalData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x18C8C60", Offset = "0x18C8060", VA = "0x1818C8C60")]
		[DebuggerNonUserCode]
		public CircuitSignalData(CircuitSignalData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x18C8670", Offset = "0x18C7A70", VA = "0x1818C8670", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitSignalData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x18C8780", Offset = "0x18C7B80", VA = "0x1818C8780", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x18C8720", Offset = "0x18C7B20", VA = "0x1818C8720", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitSignalData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x18C8830", Offset = "0x18C7C30", VA = "0x1818C8830", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x18C89F0", Offset = "0x18C7DF0", VA = "0x1818C89F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x18C8A50", Offset = "0x18C7E50", VA = "0x1818C8A50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x18C8560", Offset = "0x18C7960", VA = "0x1818C8560", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x18C8920", Offset = "0x18C7D20", VA = "0x1818C8920", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BE8A0", Offset = "0x18BDCA0", VA = "0x1818BE8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x18BDCD0", Offset = "0x18BD0D0", VA = "0x1818BDCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BFA00", Offset = "0x18BEE00", VA = "0x1818BFA00")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BF930", Offset = "0x18BED30", VA = "0x1818BF930")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BFA60", Offset = "0x18BEE60", VA = "0x1818BFA60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x18BFB60", Offset = "0x18BEF60", VA = "0x1818BFB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public ByteString ContextTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x18BFBB0", Offset = "0x18BEFB0", VA = "0x1818BFBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public CircuitSerializationVersion SerializationVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x3AB450", Offset = "0x3AA850", VA = "0x1803AB450")]
			get
			{
				return default(CircuitSerializationVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x3AB340", Offset = "0x3AA740", VA = "0x1803AB340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public EventBusData EventBusData
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x3AB170", Offset = "0x3AA570", VA = "0x1803AB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> NodeDatas
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x1803B12E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x390F70", Offset = "0x390370", VA = "0x180390F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A08B0", Offset = "0x39FCB0", VA = "0x1803A08B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x8B04D0", Offset = "0x8AF8D0", VA = "0x1808B04D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x18BF870", Offset = "0x18BEC70", VA = "0x1818BF870")]
		[DebuggerNonUserCode]
		public CircuitContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x18BF6F0", Offset = "0x18BEAF0", VA = "0x1818BF6F0")]
		[DebuggerNonUserCode]
		public CircuitContextData(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x18BEAF0", Offset = "0x18BDEF0", VA = "0x1818BEAF0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x18BEC90", Offset = "0x18BE090", VA = "0x1818BEC90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x18BEB50", Offset = "0x18BDF50", VA = "0x1818BEB50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x18BEE00", Offset = "0x18BE200", VA = "0x1818BEE00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x18BF300", Offset = "0x18BE700", VA = "0x1818BF300", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x18BF360", Offset = "0x18BE760", VA = "0x1818BF360", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x18BE900", Offset = "0x18BDD00", VA = "0x1818BE900", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x18BF140", Offset = "0x18BE540", VA = "0x1818BF140", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x18BEF40", Offset = "0x18BE340", VA = "0x1818BEF40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CF3D0", Offset = "0x18CE7D0", VA = "0x1818CF3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x18CD690", Offset = "0x18CCA90", VA = "0x1818CD690")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CFC30", Offset = "0x18CF030", VA = "0x1818CFC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CFB60", Offset = "0x18CEF60", VA = "0x1818CFB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CFC90", Offset = "0x18CF090", VA = "0x1818CFC90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x18CFA50", Offset = "0x18CEE50", VA = "0x1818CFA50")]
		[DebuggerNonUserCode]
		public EventBusData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x18CFAB0", Offset = "0x18CEEB0", VA = "0x1818CFAB0")]
		[DebuggerNonUserCode]
		public EventBusData(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x18CF4B0", Offset = "0x18CE8B0", VA = "0x1818CF4B0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventBusData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x18CF590", Offset = "0x18CE990", VA = "0x1818CF590", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x18CF660", Offset = "0x18CEA60", VA = "0x1818CF660", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventBusData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B10", Offset = "0x3E8F10", VA = "0x1803E9B10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x18CF800", Offset = "0x18CEC00", VA = "0x1818CF800", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x18CF860", Offset = "0x18CEC60", VA = "0x1818CF860", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x18CF430", Offset = "0x18CE830", VA = "0x1818CF430", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x18CF7A0", Offset = "0x18CEBA0", VA = "0x1818CF7A0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x18CF6E0", Offset = "0x18CEAE0", VA = "0x1818CF6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C31F0", Offset = "0x18C25F0", VA = "0x1818C31F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C3120", Offset = "0x18C2520", VA = "0x1818C3120")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C3250", Offset = "0x18C2650", VA = "0x1818C3250", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x3832E0", Offset = "0x3826E0", VA = "0x1803832E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x18C3000", Offset = "0x18C2400", VA = "0x1818C3000")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData(CircuitEventObjectData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x18C2A20", Offset = "0x18C1E20", VA = "0x1818C2A20", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x18C2B60", Offset = "0x18C1F60", VA = "0x1818C2B60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x18C2C20", Offset = "0x18C2020", VA = "0x1818C2C20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventObjectData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x18C2C90", Offset = "0x18C2090", VA = "0x1818C2C90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x18C2E40", Offset = "0x18C2240", VA = "0x1818C2E40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x18C2EA0", Offset = "0x18C22A0", VA = "0x1818C2EA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x18C2930", Offset = "0x18C1D30", VA = "0x1818C2930", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x18C2D10", Offset = "0x18C2110", VA = "0x1818C2D10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C1D10", Offset = "0x18C1110", VA = "0x1818C1D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C1C40", Offset = "0x18C1040", VA = "0x1818C1C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C1D70", Offset = "0x18C1170", VA = "0x1818C1D70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x18C1E80", Offset = "0x18C1280", VA = "0x1818C1E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x18C1ED0", Offset = "0x18C12D0", VA = "0x1818C1ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventProperty> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x18C1BA0", Offset = "0x18C0FA0", VA = "0x1818C1BA0")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x18C1B20", Offset = "0x18C0F20", VA = "0x1818C1B20")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData(CircuitEventDefinitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x18C13E0", Offset = "0x18C07E0", VA = "0x1818C13E0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x18C1480", Offset = "0x18C0880", VA = "0x1818C1480", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x18C15A0", Offset = "0x18C09A0", VA = "0x1818C15A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventDefinitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x18C1680", Offset = "0x18C0A80", VA = "0x1818C1680", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x18C1850", Offset = "0x18C0C50", VA = "0x1818C1850", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x18C18B0", Offset = "0x18C0CB0", VA = "0x1818C18B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x18C12B0", Offset = "0x18C06B0", VA = "0x1818C12B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x18C1730", Offset = "0x18C0B30", VA = "0x1818C1730", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C3AD0", Offset = "0x18C2ED0", VA = "0x1818C3AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C3A00", Offset = "0x18C2E00", VA = "0x1818C3A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C3B30", Offset = "0x18C2F30", VA = "0x1818C3B30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x18C3C40", Offset = "0x18C3040", VA = "0x1818C3C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x18C3900", Offset = "0x18C2D00", VA = "0x1818C3900")]
		[DebuggerNonUserCode]
		public CircuitEventProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x18C3940", Offset = "0x18C2D40", VA = "0x1818C3940")]
		[DebuggerNonUserCode]
		public CircuitEventProperty(CircuitEventProperty other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x18C3420", Offset = "0x18C2820", VA = "0x1818C3420", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventProperty Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x18C3560", Offset = "0x18C2960", VA = "0x1818C3560", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x18C3500", Offset = "0x18C2900", VA = "0x1818C3500", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x18C3610", Offset = "0x18C2A10", VA = "0x1818C3610", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x18C3760", Offset = "0x18C2B60", VA = "0x1818C3760", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x18C37C0", Offset = "0x18C2BC0", VA = "0x1818C37C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x18C3360", Offset = "0x18C2760", VA = "0x1818C3360", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x18C3690", Offset = "0x18C2A90", VA = "0x1818C3690", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0FA0", Offset = "0x18D03A0", VA = "0x1818D0FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0ED0", Offset = "0x18D02D0", VA = "0x1818D0ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1000", Offset = "0x18D0400", VA = "0x1818D1000", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x18D1160", Offset = "0x18D0560", VA = "0x1818D1160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public ByteString EventDefinitionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x18D1110", Offset = "0x18D0510", VA = "0x1818D1110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x18D0E60", Offset = "0x18D0260", VA = "0x1818D0E60")]
		[DebuggerNonUserCode]
		public EventRegistrationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x18D0DC0", Offset = "0x18D01C0", VA = "0x1818D0DC0")]
		[DebuggerNonUserCode]
		public EventRegistrationData(EventRegistrationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x18D0830", Offset = "0x18CFC30", VA = "0x1818D0830", Slot = "9")]
		[DebuggerNonUserCode]
		public EventRegistrationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x18D08F0", Offset = "0x18CFCF0", VA = "0x1818D08F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x18D0A20", Offset = "0x18CFE20", VA = "0x1818D0A20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventRegistrationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x18D0B00", Offset = "0x18CFF00", VA = "0x1818D0B00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x18D0C10", Offset = "0x18D0010", VA = "0x1818D0C10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x18D0C70", Offset = "0x18D0070", VA = "0x1818D0C70", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x18D0760", Offset = "0x18CFB60", VA = "0x1818D0760", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x18D0B90", Offset = "0x18CFF90", VA = "0x1818D0B90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D89AD0", Offset = "0x1D88ED0", VA = "0x181D89AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D89A50", Offset = "0x1D88E50", VA = "0x181D89A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D89B30", Offset = "0x1D88F30", VA = "0x181D89B30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x1D89BF0", Offset = "0x1D88FF0", VA = "0x181D89BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public RepeatedField<EventDataKeyValuePair> Datas
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D899C0", Offset = "0x1D88DC0", VA = "0x181D899C0")]
		[DebuggerNonUserCode]
		public SynchronizedEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1D89950", Offset = "0x1D88D50", VA = "0x181D89950")]
		[DebuggerNonUserCode]
		public SynchronizedEventData(SynchronizedEventData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1D89320", Offset = "0x1D88720", VA = "0x181D89320", Slot = "9")]
		[DebuggerNonUserCode]
		public SynchronizedEventData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D893C0", Offset = "0x1D887C0", VA = "0x181D893C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1D894D0", Offset = "0x1D888D0", VA = "0x181D894D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SynchronizedEventData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1D89590", Offset = "0x1D88990", VA = "0x181D89590", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1D89710", Offset = "0x1D88B10", VA = "0x181D89710", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D89770", Offset = "0x1D88B70", VA = "0x181D89770", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1D89240", Offset = "0x1D88640", VA = "0x181D89240", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1D89610", Offset = "0x1D88A10", VA = "0x181D89610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0550", Offset = "0x18CF950", VA = "0x1818D0550")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0480", Offset = "0x18CF880", VA = "0x1818D0480")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D05B0", Offset = "0x18CF9B0", VA = "0x1818D05B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x18D06C0", Offset = "0x18CFAC0", VA = "0x1818D06C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x18D0710", Offset = "0x18CFB10", VA = "0x1818D0710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x18D0410", Offset = "0x18CF810", VA = "0x1818D0410")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x18D0370", Offset = "0x18CF770", VA = "0x1818D0370")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair(EventDataKeyValuePair other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x18CFE60", Offset = "0x18CF260", VA = "0x1818CFE60", Slot = "9")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFC0", Offset = "0x18CF3C0", VA = "0x1818CFFC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x18CFF20", Offset = "0x18CF320", VA = "0x1818CFF20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventDataKeyValuePair other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x18D00B0", Offset = "0x18CF4B0", VA = "0x1818D00B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x18D01C0", Offset = "0x18CF5C0", VA = "0x1818D01C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x18D0220", Offset = "0x18CF620", VA = "0x1818D0220", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x18CFD90", Offset = "0x18CF190", VA = "0x1818CFD90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x18D0140", Offset = "0x18CF540", VA = "0x1818D0140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C2770", Offset = "0x18C1B70", VA = "0x1818C2770")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C26A0", Offset = "0x18C1AA0", VA = "0x1818C26A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C27D0", Offset = "0x18C1BD0", VA = "0x1818C27D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x18C28E0", Offset = "0x18C1CE0", VA = "0x1818C28E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x18C2660", Offset = "0x18C1A60", VA = "0x1818C2660")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x18C25A0", Offset = "0x18C19A0", VA = "0x1818C25A0")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData(CircuitEventModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x18C2020", Offset = "0x18C1420", VA = "0x1818C2020", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x18C2180", Offset = "0x18C1580", VA = "0x1818C2180", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x18C2110", Offset = "0x18C1510", VA = "0x1818C2110", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x18C2240", Offset = "0x18C1640", VA = "0x1818C2240", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x18C23D0", Offset = "0x18C17D0", VA = "0x1818C23D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x18C2430", Offset = "0x18C1830", VA = "0x1818C2430", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x18C1F20", Offset = "0x18C1320", VA = "0x1818C1F20", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x18C22E0", Offset = "0x18C16E0", VA = "0x1818C22E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D78E80", Offset = "0x1D78280", VA = "0x181D78E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1D78890", Offset = "0x1D77C90", VA = "0x181D78890")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D79600", Offset = "0x1D78A00", VA = "0x181D79600")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D79530", Offset = "0x1D78930", VA = "0x181D79530")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D79660", Offset = "0x1D78A60", VA = "0x181D79660", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x1D79760", Offset = "0x1D78B60", VA = "0x181D79760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x3AB450", Offset = "0x3AA850", VA = "0x1803AB450")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x3AB340", Offset = "0x3AA740", VA = "0x1803AB340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public bool OriginallyFromOtherInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x619E70", Offset = "0x619270", VA = "0x180619E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x619E80", Offset = "0x619280", VA = "0x180619E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1D79430", Offset = "0x1D78830", VA = "0x181D79430")]
		[DebuggerNonUserCode]
		public InventionPieceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1D79490", Offset = "0x1D78890", VA = "0x181D79490")]
		[DebuggerNonUserCode]
		public InventionPieceData(InventionPieceData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1D78FE0", Offset = "0x1D783E0", VA = "0x181D78FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public InventionPieceData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1D79160", Offset = "0x1D78560", VA = "0x181D79160", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1D790A0", Offset = "0x1D784A0", VA = "0x181D790A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InventionPieceData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8A1390", Offset = "0x8A0790", VA = "0x1808A1390", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1D79310", Offset = "0x1D78710", VA = "0x181D79310", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8A16E0", Offset = "0x8A0AE0", VA = "0x1808A16E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1D78EE0", Offset = "0x1D782E0", VA = "0x181D78EE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1D79260", Offset = "0x1D78660", VA = "0x181D79260", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C03A0", Offset = "0x18BF7A0", VA = "0x1818C03A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x18BFC00", Offset = "0x18BF000", VA = "0x1818BFC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C0D10", Offset = "0x18C0110", VA = "0x1818C0D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C0C40", Offset = "0x18C0040", VA = "0x1818C0C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C0D70", Offset = "0x18C0170", VA = "0x1818C0D70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x5D7290", Offset = "0x5D6690", VA = "0x1805D7290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x5D7260", Offset = "0x5D6660", VA = "0x1805D7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x18C0EC0", Offset = "0x18C02C0", VA = "0x1818C0EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public ByteString GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x18C0E70", Offset = "0x18C0270", VA = "0x1818C0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x18C0B30", Offset = "0x18BFF30", VA = "0x1818C0B30")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x18C0BA0", Offset = "0x18BFFA0", VA = "0x1818C0BA0")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData(CircuitContextNodeOperationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x18C0510", Offset = "0x18BF910", VA = "0x1818C0510", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x18C0690", Offset = "0x18BFA90", VA = "0x1818C0690", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x18C05E0", Offset = "0x18BF9E0", VA = "0x1818C05E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextNodeOperationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x18C0790", Offset = "0x18BFB90", VA = "0x1818C0790", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x18C0920", Offset = "0x18BFD20", VA = "0x1818C0920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x18C0980", Offset = "0x18BFD80", VA = "0x1818C0980", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x18C0400", Offset = "0x18BF800", VA = "0x1818C0400", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x18C0860", Offset = "0x18BFC60", VA = "0x1818C0860", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7B190", Offset = "0x1D7A590", VA = "0x181D7B190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1D79CB0", Offset = "0x1D790B0", VA = "0x181D79CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7BD50", Offset = "0x1D7B150", VA = "0x181D7BD50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7BC80", Offset = "0x1D7B080", VA = "0x181D7BC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7BDB0", Offset = "0x1D7B1B0", VA = "0x181D7BDB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1D7BEB0", Offset = "0x1D7B2B0", VA = "0x181D7BEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public ByteString ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x1D7BF50", Offset = "0x1D7B350", VA = "0x181D7BF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CircuitObjectType ModifiedObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x3AB450", Offset = "0x3AA850", VA = "0x1803AB450")]
			get
			{
				return default(CircuitObjectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x3AB340", Offset = "0x3AA740", VA = "0x1803AB340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public ByteString ModificationHandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x1D7BF00", Offset = "0x1D7B300", VA = "0x181D7BF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x1803B12E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x1D7BFA0", Offset = "0x1D7B3A0", VA = "0x181D7BFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1D7BC00", Offset = "0x1D7B000", VA = "0x181D7BC00")]
		[DebuggerNonUserCode]
		public ModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1D7BBA0", Offset = "0x1D7AFA0", VA = "0x181D7BBA0")]
		[DebuggerNonUserCode]
		public ModificationData(ModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B390", Offset = "0x1D7A790", VA = "0x181D7B390", Slot = "9")]
		[DebuggerNonUserCode]
		public ModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B420", Offset = "0x1D7A820", VA = "0x181D7B420", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B5D0", Offset = "0x1D7A9D0", VA = "0x181D7B5D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B720", Offset = "0x1D7AB20", VA = "0x181D7B720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B940", Offset = "0x1D7AD40", VA = "0x181D7B940", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B9A0", Offset = "0x1D7ADA0", VA = "0x181D7B9A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B1F0", Offset = "0x1D7A5F0", VA = "0x181D7B1F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B840", Offset = "0x1D7AC40", VA = "0x181D7B840", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D80890", Offset = "0x1D7FC90", VA = "0x181D80890")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D807C0", Offset = "0x1D7FBC0", VA = "0x181D807C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D808F0", Offset = "0x1D7FCF0", VA = "0x181D808F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1D80A00", Offset = "0x1D7FE00", VA = "0x181D80A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x1D80A50", Offset = "0x1D7FE50", VA = "0x181D80A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x3E38E0", Offset = "0x3E2CE0", VA = "0x1803E38E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x3E38F0", Offset = "0x3E2CF0", VA = "0x1803E38F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x1D80AA0", Offset = "0x1D7FEA0", VA = "0x181D80AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1D806F0", Offset = "0x1D7FAF0", VA = "0x181D806F0")]
		[DebuggerNonUserCode]
		public PortAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1D80770", Offset = "0x1D7FB70", VA = "0x181D80770")]
		[DebuggerNonUserCode]
		public PortAddress(PortAddress other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1D80010", Offset = "0x1D7F410", VA = "0x181D80010", Slot = "9")]
		[DebuggerNonUserCode]
		public PortAddress Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1D80090", Offset = "0x1D7F490", VA = "0x181D80090", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1D80200", Offset = "0x1D7F600", VA = "0x181D80200", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortAddress other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1D80320", Offset = "0x1D7F720", VA = "0x181D80320", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1D804D0", Offset = "0x1D7F8D0", VA = "0x181D804D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1D80530", Offset = "0x1D7F930", VA = "0x181D80530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1D7FEE0", Offset = "0x1D7F2E0", VA = "0x181D7FEE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1D80400", Offset = "0x1D7F800", VA = "0x181D80400", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85400", Offset = "0x1D84800", VA = "0x181D85400")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85330", Offset = "0x1D84730", VA = "0x181D85330")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85460", Offset = "0x1D84860", VA = "0x181D85460", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D7290", Offset = "0x5D6690", VA = "0x1805D7290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D7260", Offset = "0x5D6660", VA = "0x1805D7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1D85570", Offset = "0x1D84970", VA = "0x181D85570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerNonUserCode]
		public NodePortData PortData
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D85170", Offset = "0x1D84570", VA = "0x181D85170")]
		[DebuggerNonUserCode]
		public PortModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D851D0", Offset = "0x1D845D0", VA = "0x181D851D0")]
		[DebuggerNonUserCode]
		public PortModificationData(PortModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D84A30", Offset = "0x1D83E30", VA = "0x181D84A30", Slot = "9")]
		[DebuggerNonUserCode]
		public PortModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D84C90", Offset = "0x1D84090", VA = "0x181D84C90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D84BC0", Offset = "0x1D83FC0", VA = "0x181D84BC0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D84DA0", Offset = "0x1D841A0", VA = "0x181D84DA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D84F70", Offset = "0x1D84370", VA = "0x181D84F70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D84FD0", Offset = "0x1D843D0", VA = "0x181D84FD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D84930", Offset = "0x1D83D30", VA = "0x181D84930", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D84E60", Offset = "0x1D84260", VA = "0x181D84E60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D82940", Offset = "0x1D81D40", VA = "0x181D82940")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D82870", Offset = "0x1D81C70", VA = "0x181D82870")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D829A0", Offset = "0x1D81DA0", VA = "0x181D829A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1D82AB0", Offset = "0x1D81EB0", VA = "0x181D82AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D82760", Offset = "0x1D81B60", VA = "0x181D82760")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D827C0", Offset = "0x1D81BC0", VA = "0x181D827C0")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData(PortDefaultValuePayloadData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D822F0", Offset = "0x1D816F0", VA = "0x181D822F0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D823C0", Offset = "0x1D817C0", VA = "0x181D823C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D824C0", Offset = "0x1D818C0", VA = "0x181D824C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortDefaultValuePayloadData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x18CCFD0", Offset = "0x18CC3D0", VA = "0x1818CCFD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D82640", Offset = "0x1D81A40", VA = "0x181D82640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x18CD180", Offset = "0x18CC580", VA = "0x1818CD180", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D82230", Offset = "0x1D81630", VA = "0x181D82230", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D82570", Offset = "0x1D81970", VA = "0x181D82570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7C400", Offset = "0x1D7B800", VA = "0x181D7C400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D7BFF0", Offset = "0x1D7B3F0", VA = "0x181D7BFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7CEF0", Offset = "0x1D7C2F0", VA = "0x181D7CEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7CE20", Offset = "0x1D7C220", VA = "0x181D7CE20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7CF50", Offset = "0x1D7C350", VA = "0x181D7CF50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x1D7D0F0", Offset = "0x1D7C4F0", VA = "0x181D7D0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public ByteString SrcPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x1D7D140", Offset = "0x1D7C540", VA = "0x181D7D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[DebuggerNonUserCode]
		public ByteString DstNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x1D7D050", Offset = "0x1D7C450", VA = "0x181D7D050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		[DebuggerNonUserCode]
		public ByteString DstPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x1D7D0A0", Offset = "0x1D7C4A0", VA = "0x181D7D0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CDA0", Offset = "0x1D7C1A0", VA = "0x181D7CDA0")]
		[DebuggerNonUserCode]
		public NodeConnectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CD50", Offset = "0x1D7C150", VA = "0x181D7CD50")]
		[DebuggerNonUserCode]
		public NodeConnectionData(NodeConnectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C5D0", Offset = "0x1D7B9D0", VA = "0x181D7C5D0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeConnectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C7A0", Offset = "0x1D7BBA0", VA = "0x181D7C7A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C650", Offset = "0x1D7BA50", VA = "0x181D7C650", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeConnectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C940", Offset = "0x1D7BD40", VA = "0x181D7C940", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CB20", Offset = "0x1D7BF20", VA = "0x181D7CB20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CB80", Offset = "0x1D7BF80", VA = "0x181D7CB80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C460", Offset = "0x1D7B860", VA = "0x181D7C460", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CA40", Offset = "0x1D7BE40", VA = "0x181D7CA40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7D800", Offset = "0x1D7CC00", VA = "0x181D7D800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1D7D190", Offset = "0x1D7C590", VA = "0x181D7D190")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E1D0", Offset = "0x1D7D5D0", VA = "0x181D7E1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E100", Offset = "0x1D7D500", VA = "0x181D7E100")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E230", Offset = "0x1D7D630", VA = "0x181D7E230", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1D7E330", Offset = "0x1D7D730", VA = "0x181D7E330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public string PortName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1D7E380", Offset = "0x1D7D780", VA = "0x181D7E380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public CircuitTypeData GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DFD0", Offset = "0x1D7D3D0", VA = "0x181D7DFD0")]
		[DebuggerNonUserCode]
		public NodePortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E040", Offset = "0x1D7D440", VA = "0x181D7E040")]
		[DebuggerNonUserCode]
		public NodePortData(NodePortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1D7D970", Offset = "0x1D7CD70", VA = "0x181D7D970", Slot = "9")]
		[DebuggerNonUserCode]
		public NodePortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DA60", Offset = "0x1D7CE60", VA = "0x181D7DA60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DB70", Offset = "0x1D7CF70", VA = "0x181D7DB70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodePortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DC40", Offset = "0x1D7D040", VA = "0x181D7DC40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DDF0", Offset = "0x1D7D1F0", VA = "0x181D7DDF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DE50", Offset = "0x1D7D250", VA = "0x181D7DE50", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1D7D860", Offset = "0x1D7CC60", VA = "0x181D7D860", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D7DCF0", Offset = "0x1D7D0F0", VA = "0x181D7DCF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E6B0", Offset = "0x1D7DAB0", VA = "0x181D7E6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E3D0", Offset = "0x1D7D7D0", VA = "0x181D7E3D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7ECE0", Offset = "0x1D7E0E0", VA = "0x181D7ECE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7EC10", Offset = "0x1D7E010", VA = "0x181D7EC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7ED40", Offset = "0x1D7E140", VA = "0x181D7ED40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x1D7EE40", Offset = "0x1D7E240", VA = "0x181D7EE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EBB0", Offset = "0x1D7DFB0", VA = "0x181D7EBB0")]
		[DebuggerNonUserCode]
		public NullableBytes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EB30", Offset = "0x1D7DF30", VA = "0x181D7EB30")]
		[DebuggerNonUserCode]
		public NullableBytes(NullableBytes other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E790", Offset = "0x1D7DB90", VA = "0x181D7E790", Slot = "9")]
		[DebuggerNonUserCode]
		public NullableBytes Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E8D0", Offset = "0x1D7DCD0", VA = "0x181D7E8D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E840", Offset = "0x1D7DC40", VA = "0x181D7E840", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NullableBytes other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x912BA0", Offset = "0x911FA0", VA = "0x180912BA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EA10", Offset = "0x1D7DE10", VA = "0x181D7EA10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x912E10", Offset = "0x912210", VA = "0x180912E10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E710", Offset = "0x1D7DB10", VA = "0x181D7E710", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E9B0", Offset = "0x1D7DDB0", VA = "0x181D7E9B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D81550", Offset = "0x1D80950", VA = "0x181D81550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1D80AF0", Offset = "0x1D7FEF0", VA = "0x181D80AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D820D0", Offset = "0x1D814D0", VA = "0x181D820D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D82000", Offset = "0x1D81400", VA = "0x181D82000")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D82130", Offset = "0x1D81530", VA = "0x181D82130", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1D81F50", Offset = "0x1D81350", VA = "0x181D81F50")]
		[DebuggerNonUserCode]
		public PortCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1D81EB0", Offset = "0x1D812B0", VA = "0x181D81EB0")]
		[DebuggerNonUserCode]
		public PortCollectionData(PortCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1D816A0", Offset = "0x1D80AA0", VA = "0x181D816A0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1D81770", Offset = "0x1D80B70", VA = "0x181D81770", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1D81880", Offset = "0x1D80C80", VA = "0x181D81880", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1D81930", Offset = "0x1D80D30", VA = "0x181D81930", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1D81B50", Offset = "0x1D80F50", VA = "0x181D81B50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1D81BB0", Offset = "0x1D80FB0", VA = "0x181D81BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1D815B0", Offset = "0x1D809B0", VA = "0x181D815B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1D819C0", Offset = "0x1D80DC0", VA = "0x181D819C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CD4C0", Offset = "0x18CC8C0", VA = "0x1818CD4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CD440", Offset = "0x18CC840", VA = "0x1818CD440")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CD520", Offset = "0x18CC920", VA = "0x1818CD520", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x18CD5E0", Offset = "0x18CC9E0", VA = "0x1818CD5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x18CD3E0", Offset = "0x18CC7E0", VA = "0x1818CD3E0")]
		[DebuggerNonUserCode]
		public DefaultPortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x18CD2C0", Offset = "0x18CC6C0", VA = "0x1818CD2C0")]
		[DebuggerNonUserCode]
		public DefaultPortData(DefaultPortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x18CCCD0", Offset = "0x18CC0D0", VA = "0x1818CCCD0", Slot = "9")]
		[DebuggerNonUserCode]
		public DefaultPortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x18CCED0", Offset = "0x18CC2D0", VA = "0x1818CCED0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x18CCE20", Offset = "0x18CC220", VA = "0x1818CCE20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x18CCFD0", Offset = "0x18CC3D0", VA = "0x1818CCFD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x18CD120", Offset = "0x18CC520", VA = "0x1818CD120", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x18CD180", Offset = "0x18CC580", VA = "0x1818CD180", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x18CCC10", Offset = "0x18CC010", VA = "0x1818CCC10", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x18CD050", Offset = "0x18CC450", VA = "0x1818CD050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D836D0", Offset = "0x1D82AD0", VA = "0x181D836D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1D82B00", Offset = "0x1D81F00", VA = "0x181D82B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D84690", Offset = "0x1D83A90", VA = "0x181D84690")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D845C0", Offset = "0x1D839C0", VA = "0x181D845C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D846F0", Offset = "0x1D83AF0", VA = "0x181D846F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x1D84890", Offset = "0x1D83C90", VA = "0x181D84890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x3AB310", Offset = "0x3AA710", VA = "0x1803AB310")]
			get
			{
				return default(PortGroupType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB430", Offset = "0x3AA830", VA = "0x1803AB430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public RepeatedField<NodePortData> NodePortDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1D848E0", Offset = "0x1D83CE0", VA = "0x181D848E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public CircuitTypeData ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x1803B12E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x446220", Offset = "0x445620", VA = "0x180446220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		public uint NumberOfPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x446FE0", Offset = "0x4463E0", VA = "0x180446FE0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x446770", Offset = "0x445B70", VA = "0x180446770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B06D0", VA = "0x1803B12D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x1D847F0", Offset = "0x1D83BF0", VA = "0x181D847F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public string ExecName
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x39FE10", Offset = "0x39F210", VA = "0x18039FE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1D84840", Offset = "0x1D83C40", VA = "0x181D84840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1D84510", Offset = "0x1D83910", VA = "0x181D84510")]
		[DebuggerNonUserCode]
		public PortGroupData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1D84460", Offset = "0x1D83860", VA = "0x181D84460")]
		[DebuggerNonUserCode]
		public PortGroupData(PortGroupData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1D83990", Offset = "0x1D82D90", VA = "0x181D83990", Slot = "9")]
		[DebuggerNonUserCode]
		public PortGroupData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1D83BB0", Offset = "0x1D82FB0", VA = "0x181D83BB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1D83A70", Offset = "0x1D82E70", VA = "0x181D83A70", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortGroupData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1D83D30", Offset = "0x1D83130", VA = "0x181D83D30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1D84090", Offset = "0x1D83490", VA = "0x181D84090", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1D840F0", Offset = "0x1D834F0", VA = "0x181D840F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1D83730", Offset = "0x1D82B30", VA = "0x181D83730", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1D83EA0", Offset = "0x1D832A0", VA = "0x181D83EA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D87F30", Offset = "0x1D87330", VA = "0x181D87F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1D87BE0", Offset = "0x1D86FE0", VA = "0x181D87BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D88830", Offset = "0x1D87C30", VA = "0x181D88830")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D88760", Offset = "0x1D87B60", VA = "0x181D88760")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D88890", Offset = "0x1D87C90", VA = "0x181D88890", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1D88660", Offset = "0x1D87A60", VA = "0x181D88660")]
		[DebuggerNonUserCode]
		public SwitchNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1D886E0", Offset = "0x1D87AE0", VA = "0x181D886E0")]
		[DebuggerNonUserCode]
		public SwitchNodeData(SwitchNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1D88050", Offset = "0x1D87450", VA = "0x181D88050", Slot = "9")]
		[DebuggerNonUserCode]
		public SwitchNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1D88100", Offset = "0x1D87500", VA = "0x181D88100", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1D881F0", Offset = "0x1D875F0", VA = "0x181D881F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1D88290", Offset = "0x1D87690", VA = "0x181D88290", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1D88430", Offset = "0x1D87830", VA = "0x181D88430", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1D88490", Offset = "0x1D87890", VA = "0x181D88490", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1D87F90", Offset = "0x1D87390", VA = "0x181D87F90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1D882F0", Offset = "0x1D876F0", VA = "0x181D882F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8F010", Offset = "0x1D8E410", VA = "0x181D8F010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1D8C600", Offset = "0x1D8BA00", VA = "0x181D8C600")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BD520", Offset = "0x18BC920", VA = "0x1818BD520")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BD4A0", Offset = "0x18BC8A0", VA = "0x1818BD4A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18BD580", Offset = "0x18BC980", VA = "0x1818BD580", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public CircuitTypeData OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x18BD440", Offset = "0x18BC840", VA = "0x1818BD440")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x18BD370", Offset = "0x18BC770", VA = "0x1818BD370")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData(AppliedGenericTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x18BCCB0", Offset = "0x18BC0B0", VA = "0x1818BCCB0", Slot = "9")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x18BCDB0", Offset = "0x18BC1B0", VA = "0x1818BCDB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x18BCE90", Offset = "0x18BC290", VA = "0x1818BCE90", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(AppliedGenericTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x18BCF20", Offset = "0x18BC320", VA = "0x1818BCF20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x18BD0D0", Offset = "0x18BC4D0", VA = "0x1818BD0D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x18BD130", Offset = "0x18BC530", VA = "0x1818BD130", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x18BCBB0", Offset = "0x18BBFB0", VA = "0x1818BCBB0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x18BCFA0", Offset = "0x18BC3A0", VA = "0x1818BCFA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CBEB0", Offset = "0x18CB2B0", VA = "0x1818CBEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CBE30", Offset = "0x18CB230", VA = "0x1818CBE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CBF10", Offset = "0x18CB310", VA = "0x1818CBF10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3AB330", Offset = "0x3AA730", VA = "0x1803AB330")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x3AB350", Offset = "0x3AA750", VA = "0x1803AB350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData AppliedGenericType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public ClassTypeData ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		public FunctionTypeData FunctionType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x3AB170", Offset = "0x3AA570", VA = "0x1803AB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData TypeParameterReferenceType
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x1803B12E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x446220", Offset = "0x445620", VA = "0x180446220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData TypeParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x390F70", Offset = "0x390370", VA = "0x180390F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x430690", Offset = "0x42FA90", VA = "0x180430690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public CircuitTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x18CBB40", Offset = "0x18CAF40", VA = "0x1818CBB40")]
		[DebuggerNonUserCode]
		public CircuitTypeData(CircuitTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x18CB3D0", Offset = "0x18CA7D0", VA = "0x1818CB3D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x18CB4E0", Offset = "0x18CA8E0", VA = "0x1818CB4E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x18CB430", Offset = "0x18CA830", VA = "0x1818CB430", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x18CB5F0", Offset = "0x18CA9F0", VA = "0x1818CB5F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x18CB8D0", Offset = "0x18CACD0", VA = "0x1818CB8D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x18CB930", Offset = "0x18CAD30", VA = "0x1818CB930", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x18CB210", Offset = "0x18CA610", VA = "0x1818CB210", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x18CB6E0", Offset = "0x18CAAE0", VA = "0x1818CB6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCAF0", Offset = "0x18CBEF0", VA = "0x1818CCAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCA70", Offset = "0x18CBE70", VA = "0x1818CCA70")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCB50", Offset = "0x18CBF50", VA = "0x1818CCB50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x3AB170", Offset = "0x3AA570", VA = "0x1803AB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x18CC940", Offset = "0x18CBD40", VA = "0x1818CC940")]
		[DebuggerNonUserCode]
		public ClassTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x18CC9C0", Offset = "0x18CBDC0", VA = "0x1818CC9C0")]
		[DebuggerNonUserCode]
		public ClassTypeData(ClassTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x18CC100", Offset = "0x18CB500", VA = "0x1818CC100", Slot = "9")]
		[DebuggerNonUserCode]
		public ClassTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x18CC1E0", Offset = "0x18CB5E0", VA = "0x1818CC1E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x18CC2E0", Offset = "0x18CB6E0", VA = "0x1818CC2E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ClassTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x18CC390", Offset = "0x18CB790", VA = "0x1818CC390", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x18CC5D0", Offset = "0x18CB9D0", VA = "0x1818CC5D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x18CC630", Offset = "0x18CBA30", VA = "0x1818CC630", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x18CBFD0", Offset = "0x18CB3D0", VA = "0x1818CBFD0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x18CC440", Offset = "0x18CB840", VA = "0x1818CC440", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1D10", Offset = "0x18D1110", VA = "0x1818D1D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1C90", Offset = "0x18D1090", VA = "0x1818D1C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1D70", Offset = "0x18D1170", VA = "0x1818D1D70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x18D1BE0", Offset = "0x18D0FE0", VA = "0x1818D1BE0")]
		[DebuggerNonUserCode]
		public FunctionTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x18D1B40", Offset = "0x18D0F40", VA = "0x1818D1B40")]
		[DebuggerNonUserCode]
		public FunctionTypeData(FunctionTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x18D12D0", Offset = "0x18D06D0", VA = "0x1818D12D0", Slot = "9")]
		[DebuggerNonUserCode]
		public FunctionTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x18D13A0", Offset = "0x18D07A0", VA = "0x1818D13A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x18D14B0", Offset = "0x18D08B0", VA = "0x1818D14B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(FunctionTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x18D1570", Offset = "0x18D0970", VA = "0x1818D1570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x18D17D0", Offset = "0x18D0BD0", VA = "0x1818D17D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x18D1830", Offset = "0x18D0C30", VA = "0x1818D1830", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x18D11B0", Offset = "0x18D05B0", VA = "0x1818D11B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x18D1620", Offset = "0x18D0A20", VA = "0x1818D1620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7F380", Offset = "0x1D7E780", VA = "0x181D7F380")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7F2B0", Offset = "0x1D7E6B0", VA = "0x181D7F2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7F3E0", Offset = "0x1D7E7E0", VA = "0x181D7F3E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public ParameterData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F250", Offset = "0x1D7E650", VA = "0x181D7F250")]
		[DebuggerNonUserCode]
		public ParameterData(ParameterData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EF50", Offset = "0x1D7E350", VA = "0x181D7EF50", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EFE0", Offset = "0x1D7E3E0", VA = "0x181D7EFE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xF117A0", Offset = "0xF10BA0", VA = "0x180F117A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xF118D0", Offset = "0xF10CD0", VA = "0x180F118D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F130", Offset = "0x1D7E530", VA = "0x181D7F130", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xF11B80", Offset = "0xF10F80", VA = "0x180F11B80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1D7EE90", Offset = "0x1D7E290", VA = "0x181D7EE90", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F070", Offset = "0x1D7E470", VA = "0x181D7F070", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7FBC0", Offset = "0x1D7EFC0", VA = "0x181D7FBC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7FAF0", Offset = "0x1D7EEF0", VA = "0x181D7FAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D7FC20", Offset = "0x1D7F020", VA = "0x181D7FC20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x1D7FD30", Offset = "0x1D7F130", VA = "0x181D7FD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public ParameterData Value
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F9D0", Offset = "0x1D7EDD0", VA = "0x181D7F9D0")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1D7FA10", Offset = "0x1D7EE10", VA = "0x181D7FA10")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData(ParameterWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F5F0", Offset = "0x1D7E9F0", VA = "0x181D7F5F0", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F700", Offset = "0x1D7EB00", VA = "0x181D7F700", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x18C2110", Offset = "0x18C1510", VA = "0x1818C2110", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x18C2240", Offset = "0x18C1640", VA = "0x1818C2240", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F8B0", Offset = "0x1D7ECB0", VA = "0x181D7F8B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x18C2430", Offset = "0x18C1830", VA = "0x1818C2430", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F4F0", Offset = "0x1D7E8F0", VA = "0x181D7F4F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F7C0", Offset = "0x1D7EBC0", VA = "0x181D7F7C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85D00", Offset = "0x1D85100", VA = "0x181D85D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85C30", Offset = "0x1D85030", VA = "0x181D85C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D85D60", Offset = "0x1D85160", VA = "0x181D85D60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DebuggerNonUserCode]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3E38E0", Offset = "0x3E2CE0", VA = "0x1803E38E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3E38F0", Offset = "0x3E2CF0", VA = "0x1803E38F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[DebuggerNonUserCode]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x6F1FE0", Offset = "0x6F13E0", VA = "0x1806F1FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x6F2170", Offset = "0x6F1570", VA = "0x1806F2170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public PropertyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1D85BD0", Offset = "0x1D84FD0", VA = "0x181D85BD0")]
		[DebuggerNonUserCode]
		public PropertyData(PropertyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1D85680", Offset = "0x1D84A80", VA = "0x181D85680", Slot = "9")]
		[DebuggerNonUserCode]
		public PropertyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1D85710", Offset = "0x1D84B10", VA = "0x181D85710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1D857D0", Offset = "0x1D84BD0", VA = "0x181D857D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PropertyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1D85840", Offset = "0x1D84C40", VA = "0x181D85840", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1D859E0", Offset = "0x1D84DE0", VA = "0x181D859E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1D85A40", Offset = "0x1D84E40", VA = "0x181D85A40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1D855C0", Offset = "0x1D849C0", VA = "0x181D855C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1D858E0", Offset = "0x1D84CE0", VA = "0x181D858E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D866E0", Offset = "0x1D85AE0", VA = "0x181D866E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86610", Offset = "0x1D85A10", VA = "0x181D86610")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86740", Offset = "0x1D85B40", VA = "0x181D86740", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3935A0", VA = "0x1803941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
		[DebuggerNonUserCode]
		public ReturnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1D7F250", Offset = "0x1D7E650", VA = "0x181D7F250")]
		[DebuggerNonUserCode]
		public ReturnData(ReturnData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1D86310", Offset = "0x1D85710", VA = "0x181D86310", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1D863A0", Offset = "0x1D857A0", VA = "0x181D863A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xF117A0", Offset = "0xF10BA0", VA = "0x180F117A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xF118D0", Offset = "0xF10CD0", VA = "0x180F118D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1D864F0", Offset = "0x1D858F0", VA = "0x181D864F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xF11B80", Offset = "0xF10F80", VA = "0x180F11B80", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1D86250", Offset = "0x1D85650", VA = "0x181D86250", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1D86430", Offset = "0x1D85830", VA = "0x181D86430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86F20", Offset = "0x1D86320", VA = "0x181D86F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86E50", Offset = "0x1D86250", VA = "0x181D86E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D86F80", Offset = "0x1D86380", VA = "0x181D86F80", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x1D87090", Offset = "0x1D86490", VA = "0x181D87090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public ReturnData Value
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1D86D30", Offset = "0x1D86130", VA = "0x181D86D30")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1D86D70", Offset = "0x1D86170", VA = "0x181D86D70")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData(ReturnWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1D86950", Offset = "0x1D85D50", VA = "0x181D86950", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1D86A60", Offset = "0x1D85E60", VA = "0x181D86A60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x18C2110", Offset = "0x18C1510", VA = "0x1818C2110", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x18C2240", Offset = "0x18C1640", VA = "0x1818C2240", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1D86C10", Offset = "0x1D86010", VA = "0x181D86C10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x18C2430", Offset = "0x18C1830", VA = "0x1818C2430", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1D86850", Offset = "0x1D85C50", VA = "0x181D86850", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1D86B20", Offset = "0x1D85F20", VA = "0x181D86B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8AC60", Offset = "0x1D8A060", VA = "0x181D8AC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8AB90", Offset = "0x1D89F90", VA = "0x181D8AB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8ACC0", Offset = "0x1D8A0C0", VA = "0x181D8ACC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x1D8ADD0", Offset = "0x1D8A1D0", VA = "0x181D8ADD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AB50", Offset = "0x1D89F50", VA = "0x181D8AB50")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AAE0", Offset = "0x1D89EE0", VA = "0x181D8AAE0")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData(TypeParameterReferenceTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A830", Offset = "0x1D89C30", VA = "0x181D8A830", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A8C0", Offset = "0x1D89CC0", VA = "0x181D8A8C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D50", Offset = "0x3A9150", VA = "0x1803A9D50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterReferenceTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3A9EA0", Offset = "0x3A92A0", VA = "0x1803A9EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A9C0", Offset = "0x1D89DC0", VA = "0x181D8A9C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA140", Offset = "0x3A9540", VA = "0x1803AA140", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A770", Offset = "0x1D89B70", VA = "0x181D8A770", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A950", Offset = "0x1D89D50", VA = "0x181D8A950", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8B450", Offset = "0x1D8A850", VA = "0x181D8B450")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8B380", Offset = "0x1D8A780", VA = "0x181D8B380")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D8B4B0", Offset = "0x1D8A8B0", VA = "0x181D8B4B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A9290", VA = "0x1803A9E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A9220", VA = "0x1803A9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x1D8B5C0", Offset = "0x1D8A9C0", VA = "0x181D8B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public CircuitTypeData Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B340", Offset = "0x1D8A740", VA = "0x181D8B340")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B2B0", Offset = "0x1D8A6B0", VA = "0x181D8B2B0")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData(TypeParameterTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AF20", Offset = "0x1D8A320", VA = "0x181D8AF20", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AFE0", Offset = "0x1D8A3E0", VA = "0x181D8AFE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x18C2110", Offset = "0x18C1510", VA = "0x1818C2110", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x18C2240", Offset = "0x18C1640", VA = "0x1818C2240", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B190", Offset = "0x1D8A590", VA = "0x181D8B190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x18C2430", Offset = "0x18C1830", VA = "0x1818C2430", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AE20", Offset = "0x1D8A220", VA = "0x181D8AE20", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B0A0", Offset = "0x1D8A4A0", VA = "0x181D8B0A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D90FD0", Offset = "0x1D903D0", VA = "0x181D90FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1D90960", Offset = "0x1D8FD60", VA = "0x181D90960")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D917F0", Offset = "0x1D90BF0", VA = "0x181D917F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D91720", Offset = "0x1D90B20", VA = "0x181D91720")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D91850", Offset = "0x1D90C50", VA = "0x181D91850", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A6D50", Offset = "0x3A6150", VA = "0x1803A6D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D40", Offset = "0x3A6140", VA = "0x1803A6D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[DebuggerNonUserCode]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x1D91950", Offset = "0x1D90D50", VA = "0x181D91950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[DebuggerNonUserCode]
		public CircuitTypeData SymbolType
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x3AB300", Offset = "0x3AA700", VA = "0x1803AB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1D91650", Offset = "0x1D90A50", VA = "0x181D91650")]
		[DebuggerNonUserCode]
		public VariableNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1D91690", Offset = "0x1D90A90", VA = "0x181D91690")]
		[DebuggerNonUserCode]
		public VariableNodeData(VariableNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1D91100", Offset = "0x1D90500", VA = "0x181D91100", Slot = "9")]
		[DebuggerNonUserCode]
		public VariableNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1D911C0", Offset = "0x1D905C0", VA = "0x181D911C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1D91280", Offset = "0x1D90680", VA = "0x181D91280", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(VariableNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x1D912F0", Offset = "0x1D906F0", VA = "0x181D912F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1D91480", Offset = "0x1D90880", VA = "0x181D91480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1D914E0", Offset = "0x1D908E0", VA = "0x181D914E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1D91030", Offset = "0x1D90430", VA = "0x181D91030", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1D91390", Offset = "0x1D90790", VA = "0x181D91390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x160F320", Offset = "0x160E720", VA = "0x18160F320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x15E7040", Offset = "0x15E6440", VA = "0x1815E7040")]
		public static TNode CreateNode<TNode>(CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId) where TNode : Node
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x1602E30", Offset = "0x1602230", VA = "0x181602E30")]
		internal static Node CreateNodeForDeserialize(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x1602EF0", Offset = "0x16022F0", VA = "0x181602EF0")]
		public static Node CreateNode(Type nodeType, CircuitContext context, [Optional] Guid? nodeGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x16031C0", Offset = "0x16025C0", VA = "0x1816031C0")]
		public static Node CreateNode(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId, [Optional] Vector3? localPosition, [Optional] Quaternion? localRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x1602AC0", Offset = "0x1601EC0", VA = "0x181602AC0")]
		private static Node ConstructNodeInternal(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x1603D90", Offset = "0x1603190", VA = "0x181603D90")]
		public static Guid GetTypeId(Type type)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x1603640", Offset = "0x1602A40", VA = "0x181603640")]
		public static Type GetNodeType(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x1603380", Offset = "0x1602780", VA = "0x181603380")]
		public static Tuple<string, Guid>[] GetNodeTypeOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x1603E80", Offset = "0x1603280", VA = "0x181603E80")]
		public static List<string> OrderedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x1603750", Offset = "0x1602B50", VA = "0x181603750")]
		public static void GetNodesWithTags(TagSearchMethod tagSearchMethod, IEnumerable<string> activeTags, out HashSet<Type> filteredTypes, out IList<string> filteredTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x16040D0", Offset = "0x16034D0", VA = "0x1816040D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1ACB700", Offset = "0x1ACAB00", VA = "0x181ACB700")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x3832E0", Offset = "0x3826E0", VA = "0x1803832E0")]
		public void Set(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB710", Offset = "0x1ACAB10", VA = "0x181ACB710")]
		public Box(in T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x1189D70", Offset = "0x1189170", VA = "0x181189D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2555670", Offset = "0x2554A70", VA = "0x182555670")]
		public bool TryGetValue(TKey key, out HashSet<TVal> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2555390", Offset = "0x2554790", VA = "0x182555390")]
		public void Add(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x25554A0", Offset = "0x25548A0", VA = "0x1825554A0")]
		public void Remove(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2555470", Offset = "0x2554870", VA = "0x182555470")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x25556B0", Offset = "0x2554AB0", VA = "0x1825556B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xFD4B90", Offset = "0xFD3F90", VA = "0x180FD4B90", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public TVal this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2555D10", Offset = "0x2555110", VA = "0x182555D10", Slot = "18")]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2555D60", Offset = "0x2555160", VA = "0x182555D60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2555C80", Offset = "0x2555080", VA = "0x182555C80")]
		public SortedList(Func<TVal, TVal, int> valueComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2555A80", Offset = "0x2554E80", VA = "0x182555A80", Slot = "16")]
		public IEnumerator<TVal> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2555BE0", Offset = "0x2554FE0", VA = "0x182555BE0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2555730", Offset = "0x2554B30", VA = "0x182555730", Slot = "11")]
		public void Add(TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2555470", Offset = "0x2554870", VA = "0x182555470", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2555990", Offset = "0x2554D90", VA = "0x182555990", Slot = "13")]
		public bool Contains(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x25559D0", Offset = "0x2554DD0", VA = "0x1825559D0", Slot = "14")]
		public void CopyTo(TVal[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2555BA0", Offset = "0x2554FA0", VA = "0x182555BA0", Slot = "15")]
		public bool Remove(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x11B3ED0", Offset = "0x11B32D0", VA = "0x1811B3ED0", Slot = "6")]
		public int IndexOf(TVal item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2555B50", Offset = "0x2554F50", VA = "0x182555B50", Slot = "7")]
		public void Insert(int index, TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x1044410", Offset = "0x1043810", VA = "0x181044410", Slot = "8")]
		public void RemoveAt(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EditableValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3A6590", Offset = "0x3A5990", VA = "0x1803A6590")]
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
		[Cpp2IlInjected.Address(RVA = "0x5181D0", Offset = "0x5175D0", VA = "0x1805181D0")]
		public EditableAddNamedPort([Optional] string filterMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecOutput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x3A6590", Offset = "0x3A5990", VA = "0x1803A6590")]
		public EditableAddExecOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecInput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x3A6590", Offset = "0x3A5990", VA = "0x1803A6590")]
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
			[Cpp2IlInjected.Address(RVA = "0x1610E70", Offset = "0x1610270", VA = "0x181610E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x15E7C90", Offset = "0x15E7090", VA = "0x1815E7C90")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, [Optional] TVal defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x15E7A90", Offset = "0x15E6E90", VA = "0x1815E7A90")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, Func<TVal> defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5B00", Offset = "0x1BE4F00", VA = "0x181BE5B00")]
		public static void AddToNestedList<K, V>(this IDictionary<K, List<V>> self, K key, V value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5840", Offset = "0x1BE4C40", VA = "0x181BE5840")]
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
			[Cpp2IlInjected.Address(RVA = "0x2546140", Offset = "0x2545540", VA = "0x182546140", Slot = "4")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x189D070", Offset = "0x189C470", VA = "0x18189D070", Slot = "5")]
			public int GetHashCode(T obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x1897BF0", Offset = "0x1896FF0", VA = "0x181897BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x1055EA0", Offset = "0x10552A0", VA = "0x181055EA0")]
			[DebuggerHidden]
			public <Extend>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA770", Offset = "0x1AD9B70", VA = "0x181ADA770", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA3C0", Offset = "0x1AD97C0", VA = "0x181ADA3C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA840", Offset = "0x1AD9C40", VA = "0x181ADA840")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA890", Offset = "0x1AD9C90", VA = "0x181ADA890")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA720", Offset = "0x1AD9B20", VA = "0x181ADA720", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA660", Offset = "0x1AD9A60", VA = "0x181ADA660", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x10526F0", Offset = "0x1051AF0", VA = "0x1810526F0", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1FD10", Offset = "0x1F110")]
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
				[Cpp2IlInjected.Address(RVA = "0x445F80", Offset = "0x445380", VA = "0x180445F80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2556680", Offset = "0x2555A80", VA = "0x182556680", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x1855FC0", Offset = "0x18553C0", VA = "0x181855FC0")]
			[DebuggerHidden]
			public <MarkLast>d__18(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2556BA0", Offset = "0x2555FA0", VA = "0x182556BA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x2556890", Offset = "0x2555C90", VA = "0x182556890", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2556C30", Offset = "0x2556030", VA = "0x182556C30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x2556B50", Offset = "0x2555F50", VA = "0x182556B50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x25564E0", Offset = "0x25558E0", VA = "0x1825564E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, bool)> System.Collections.Generic.IEnumerable<(TValue,System.BooleanIsLast)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x11F7040", Offset = "0x11F6440", VA = "0x1811F7040", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x20B10", Offset = "0x1FF10")]
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
				[Cpp2IlInjected.Address(RVA = "0x445F80", Offset = "0x445380", VA = "0x180445F80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2556680", Offset = "0x2555A80", VA = "0x182556680", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x1855FC0", Offset = "0x18553C0", VA = "0x181855FC0")]
			[DebuggerHidden]
			public <FormCurrentNextPairs>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2556760", Offset = "0x2555B60", VA = "0x182556760", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x2555E00", Offset = "0x2555200", VA = "0x182555E00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x25567F0", Offset = "0x2555BF0", VA = "0x1825567F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x25565E0", Offset = "0x25559E0", VA = "0x1825565E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x25564E0", Offset = "0x25558E0", VA = "0x1825564E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, T)> System.Collections.Generic.IEnumerable<(TCurrent,TNext)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x11F7040", Offset = "0x11F6440", VA = "0x1811F7040", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x1055EA0", Offset = "0x10552A0", VA = "0x181055EA0")]
			[DebuggerHidden]
			public <Unique>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x2558630", Offset = "0x2557A30", VA = "0x182558630", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x2557F80", Offset = "0x2557380", VA = "0x182557F80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x25587F0", Offset = "0x2557BF0", VA = "0x1825587F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2558410", Offset = "0x2557810", VA = "0x182558410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2558360", Offset = "0x2557760", VA = "0x182558360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2401C70", Offset = "0x2401070", VA = "0x182401C70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x15E8C50", Offset = "0x15E8050", VA = "0x1815E8C50")]
		public static U AmountSwitch<U, T>(this IEnumerable<T> self, Func<U> zero, Func<T, U> one, Func<IEnumerable<T>, U> many)
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x1610ED0", Offset = "0x16102D0", VA = "0x181610ED0")]
		public static void CallAll(this IEnumerable<Action> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x10E8230", Offset = "0x10E7630", VA = "0x1810E8230")]
		public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] items)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1283010", Offset = "0x1282410", VA = "0x181283010")]
		public static string Delimit<T>(this IEnumerable<T> self, string delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x10E83F0", Offset = "0x10E77F0", VA = "0x1810E83F0")]
		public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> self, Func<T, U> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xF42220", Offset = "0xF41620", VA = "0x180F42220")]
		[IteratorStateMachine(typeof(<Extend>d__8<, >))]
		public static IEnumerable<T> Extend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x12DD840", Offset = "0x12DCC40", VA = "0x1812DD840")]
		public static int FirstIndexOf<T>(this IEnumerable<T> self, Func<T, bool> pred)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE6F860", Offset = "0xE6EC60", VA = "0x180E6F860")]
		public static T FirstOr<T>(this IEnumerable<T> self, T optB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1BE65B0", Offset = "0x1BE59B0", VA = "0x181BE65B0")]
		public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x12DDB10", Offset = "0x12DCF10", VA = "0x1812DDB10")]
		public static int SequenceGetHashCode<T>(this IEnumerable<T> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1224AB0", Offset = "0x1223EB0", VA = "0x181224AB0")]
		public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x1224960", Offset = "0x1223D60", VA = "0x181224960")]
		public static bool Multiple<T>(this IEnumerable<T> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x10E8230", Offset = "0x10E7630", VA = "0x1810E8230")]
		public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xF2F340", Offset = "0xF2E740", VA = "0x180F2F340")]
		[IteratorStateMachine(typeof(<MarkLast>d__18<>))]
		public static IEnumerable<(T, bool)> MarkLast<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xF2F340", Offset = "0xF2E740", VA = "0x180F2F340")]
		[IteratorStateMachine(typeof(<FormCurrentNextPairs>d__19<>))]
		public static IEnumerable<(T, T)> FormCurrentNextPairs<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x10E8540", Offset = "0x10E7940", VA = "0x1810E8540")]
		public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x1189DD0", Offset = "0x11891D0", VA = "0x181189DD0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x1189DD0", Offset = "0x11891D0", VA = "0x181189DD0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1C830", Offset = "0x1BC30")] this IEnumerable<(TKey, TValue)> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x1189D70", Offset = "0x1189170", VA = "0x181189D70")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x719DC0", Offset = "0x7191C0", VA = "0x180719DC0")]
		[IteratorStateMachine(typeof(<Unique>d__25<, >))]
		public static IEnumerable<T> Unique<T, U>(this IEnumerable<T> self, Func<T, U> uniqueSelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x1181020", Offset = "0x1180420", VA = "0x181181020")]
		public static IEnumerable<(T, U)> Zip<T, U>(this IEnumerable<T> self, IEnumerable<U> other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x719F70", Offset = "0x719370", VA = "0x180719F70")]
		public static IEnumerable<V> ZipExtend<V, T, U>(this IEnumerable<T> self, IEnumerable<U> other, Func<T, U, V> zipper, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x118A110", Offset = "0x1189510", VA = "0x18118A110")]
		public static IEnumerable<(T, U)> ZipExtend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class EquatableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x1224C40", Offset = "0x1224040", VA = "0x181224C40")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x1055EA0", Offset = "0x10552A0", VA = "0x181055EA0")]
			[DebuggerHidden]
			public <ToEnumerable>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x189D4E0", Offset = "0x189C8E0", VA = "0x18189D4E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x25576B0", Offset = "0x2556AB0", VA = "0x1825576B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x189D510", Offset = "0x189C910", VA = "0x18189D510", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x11C26E0", Offset = "0x11C1AE0", VA = "0x1811C26E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3AB330", Offset = "0x3AA730", VA = "0x1803AB330", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x11C9010", Offset = "0x11C8410", VA = "0x1811C9010", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x1857220", Offset = "0x1856620", VA = "0x181857220")]
			[DebuggerHidden]
			public <ToEnumerableInf>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x2557500", Offset = "0x2556900", VA = "0x182557500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x25575E0", Offset = "0x25569E0", VA = "0x1825575E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2557540", Offset = "0x2556940", VA = "0x182557540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x11C26E0", Offset = "0x11C1AE0", VA = "0x1811C26E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x10E85E0", Offset = "0x10E79E0", VA = "0x1810E85E0")]
		[IteratorStateMachine(typeof(<ToEnumerable>d__0<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x10E8570", Offset = "0x10E7970", VA = "0x1810E8570")]
		[IteratorStateMachine(typeof(<ToEnumerableInf>d__1<>))]
		public static IEnumerable<T> ToEnumerableInf<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x15F2840", Offset = "0x15F1C40", VA = "0x1815F2840")]
		public static T[] ToOneItemArray<T>(this T self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public static class IListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xE72940", Offset = "0xE71D40", VA = "0x180E72940")]
		public static T Last<T>(this IList<T> self)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xE72BD0", Offset = "0xE71FD0", VA = "0x180E72BD0")]
		public static T SetLast<T>(this IList<T> self, T value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x1BEB050", Offset = "0x1BEA450", VA = "0x181BEB050")]
		public static void RemoveFirstWhere<T>(this IList<T> self, Func<T, bool> pred)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x1BEB0D0", Offset = "0x1BEA4D0", VA = "0x181BEB0D0")]
		public static void RemoveLast<T>(this IList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xE72D80", Offset = "0xE72180", VA = "0x180E72D80")]
		public static T TakeLast<T>(this IList<T> self)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public static class IReadOnlyCollectionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x1226320", Offset = "0x1225720", VA = "0x181226320")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public static class IReadOnlyDictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x27DCF90", Offset = "0x27DC390", VA = "0x1827DCF90")]
		public static V GetValueOrDefault<V, K>(this IReadOnlyDictionary<K, V> self, K key)
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x12864C0", Offset = "0x12858C0", VA = "0x1812864C0")]
		public static V? GetValueOrNull<V, K>(this IReadOnlyDictionary<K, V> self, K key) where V : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class IReadOnlyListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xE72DD0", Offset = "0xE721D0", VA = "0x180E72DD0")]
		public static T GetValueOrDefault<T>(this IReadOnlyList<T> self, int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12865F0", Offset = "0x12859F0", VA = "0x1812865F0")]
		public static T? GetValueOrNull<T>(this IReadOnlyList<T> self, int index) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public static class KeyValuePairExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1285B40", VA = "0x181286740")]
		public static (TKey, TValue) Destructure<TKey, TValue>(this KeyValuePair<TKey, TValue> self)
		{
			return default((TKey, TValue));
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x10E8230", Offset = "0x10E7630", VA = "0x1810E8230")]
		public static IEnumerable<(TKey, TValue)> Destructure<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x1419530", Offset = "0x1418930", VA = "0x181419530")]
		public static KeyValuePair<TKey, UValue> Revalue<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> self, UValue value)
		{
			return default(KeyValuePair<TKey, UValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public static class MapFieldExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x1BEF5D0", Offset = "0x1BEE9D0", VA = "0x181BEF5D0")]
		public static void AddRange<K, V>(this MapField<K, V> self, IEnumerable<KeyValuePair<K, V>> values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x16122E0", Offset = "0x16116E0", VA = "0x1816122E0")]
		private static byte[] GetIntBytes(int intValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x1611CA0", Offset = "0x16110A0", VA = "0x181611CA0")]
		public static Guid Combine(params Guid[] guidsToCombine)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x1612210", Offset = "0x1611610", VA = "0x181612210")]
		public static Guid Create(Guid namespaceId, int index, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x1611E10", Offset = "0x1611210", VA = "0x181611E10")]
		public static Guid Create(Guid namespaceId, Guid nameGuid, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x1612180", Offset = "0x1611580", VA = "0x181612180")]
		public static Guid Create(Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x1611E80", Offset = "0x1611280", VA = "0x181611E80")]
		private static Guid Create(Guid namespaceId, byte[] nameBytes, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x1612360", Offset = "0x1611760", VA = "0x181612360")]
		private static void SwapByteOrder(byte[] guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x1612510", Offset = "0x1611910", VA = "0x181612510")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class InternalNodeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A6590", Offset = "0x3A5990", VA = "0x1803A6590")]
		public InternalNodeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public static class NodeNameHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x16127A0", Offset = "0x1611BA0", VA = "0x1816127A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x135FE0", Offset = "0x1353E0", VA = "0x180135FE0")]
		public PerfScope(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x135FE0", Offset = "0x1353E0", VA = "0x180135FE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1613910", Offset = "0x1612D10", VA = "0x181613910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x16137C0", Offset = "0x1612BC0", VA = "0x1816137C0")]
		public RateLimiter(ITimeProvider timeProvider, int maxPerSecond, int initialSize = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x16134E0", Offset = "0x16128E0", VA = "0x1816134E0")]
		public bool CanExecute()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x1613540", Offset = "0x1612940", VA = "0x181613540")]
		public bool ExecuteIfPossible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x1613610", Offset = "0x1612A10", VA = "0x181613610")]
		public void MarkExecution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x1613680", Offset = "0x1612A80", VA = "0x181613680")]
		private void TrimExpiredValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B6FF0", Offset = "0x4B63F0", VA = "0x1804B6FF0")]
		public static T[] NewArray<T>(params T[] @params)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x1426670", Offset = "0x1425A70", VA = "0x181426670")]
		public static KeyValuePair<TKey, TValue> NewKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x122FE00", Offset = "0x122F200", VA = "0x18122FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1614B40", Offset = "0x1613F40", VA = "0x181614B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A6590", Offset = "0x3A5990", VA = "0x1803A6590")]
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
		[Cpp2IlInjected.Address(RVA = "0x18C11E0", Offset = "0x18C05E0", VA = "0x1818C11E0")]
		public CircuitDataIdRemapper(bool remapIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x18C1150", Offset = "0x18C0550", VA = "0x1818C1150")]
		public CircuitDataIdRemapper(bool remapIds, Guid remapId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x18C0F10", Offset = "0x18C0310", VA = "0x1818C0F10")]
		public ByteString RemapByteStringId(ByteString originalByteString, bool onlyIfAlreadyMapped = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class CircuitTemplateHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x18CAA80", Offset = "0x18C9E80", VA = "0x1818CAA80")]
		public static CircuitContextData RemapTemplate(CircuitContext intoContext, CircuitContextData originalTemplate, Guid remapId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x18CAD60", Offset = "0x18CA160", VA = "0x1818CAD60")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x18CAE00", Offset = "0x18CA200", VA = "0x1818CAE00")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData, Matrix4x4 transformMatrix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x18C8F60", Offset = "0x18C8360", VA = "0x1818C8F60")]
		public static void AddInventionTracking(CircuitContextData templateData, ByteString instanceIdAsByteString, long inventionId, int versionNum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x18CA420", Offset = "0x18C9820", VA = "0x1818CA420")]
		public static void RemapTemplateIds(CircuitContext intoContext, CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x18CA000", Offset = "0x18C9400", VA = "0x1818CA000")]
		private static void RemapNodeInnerContextIdsRecursive(CircuitDataIdRemapper remapper, CircuitContextData context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x18C9440", Offset = "0x18C8840", VA = "0x1818C9440")]
		private static void RemapContextIdsRecursive(CircuitDataIdRemapper remapper, RepeatedField<CircuitContextData> contexts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x18C99C0", Offset = "0x18C8DC0", VA = "0x1818C99C0")]
		private static void RemapInventionInstanceIds(CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x18C9E40", Offset = "0x18C9240", VA = "0x1818C9E40")]
		private static void RemapNodeDataEventIds(IEnumerable<CircuitNodeData> nodeDatas, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x18C96C0", Offset = "0x18C8AC0", VA = "0x1818C96C0")]
		private static void RemapEventRegistrationList(IList<EventRegistrationData> registrationList, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x18CABA0", Offset = "0x18C9FA0", VA = "0x1818CABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12A1FD0", Offset = "0x12A13D0", VA = "0x1812A1FD0")]
		public static Create<TCircuitObject, TProtoElement> DoNotCreate<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x12A1FD0", Offset = "0x12A13D0", VA = "0x1812A1FD0")]
		public static Dispose<TCircuitObject, TProtoElement> IDisposableDispose<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x128BDA0", Offset = "0x128B1A0", VA = "0x18128BDA0")]
		public static void MergeDisposablesProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x128BE20", Offset = "0x128B220", VA = "0x18128BE20")]
		public static void MergeProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, Dispose<TCircuitObject, TProtoElement> dispose, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x128BA00", Offset = "0x128AE00", VA = "0x18128BA00")]
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
			[Cpp2IlInjected.Address(RVA = "0x10526B0", Offset = "0x1051AB0", VA = "0x1810526B0")]
			public Binder(Dependencies dependencies)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x1291100", Offset = "0x1290500", VA = "0x181291100")]
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
			[Cpp2IlInjected.Address(RVA = "0x145F10", Offset = "0x145310", VA = "0x180145F10")]
			public InjectionKey(Type injectedResourceType, string injectedResourceName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x224EA0", Offset = "0x2242A0", VA = "0x180224EA0")]
			public bool Equals(InjectionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x224DE0", Offset = "0x2241E0", VA = "0x180224DE0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x224F10", Offset = "0x224310", VA = "0x180224F10", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly Dictionary<InjectionKey, object> injectedInstancesDictionary;

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x1189D70", Offset = "0x1189170", VA = "0x181189D70")]
		public Binder<TInterface> Bind<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x15E7980", Offset = "0x15E6D80", VA = "0x1815E7980")]
		public TInterface GetDependency<TInterface>([Optional] string name)
		{
			return (TInterface)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x18CD630", Offset = "0x18CCA30", VA = "0x1818CD630")]
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
				[Cpp2IlInjected.Address(RVA = "0x3A6D50", Offset = "0x3A6150", VA = "0x1803A6D50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000842")]
				[Cpp2IlInjected.Address(RVA = "0x3A6D40", Offset = "0x3A6140", VA = "0x1803A6D40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000843")]
				[Cpp2IlInjected.Address(RVA = "0x45AF20", Offset = "0x45A320", VA = "0x18045AF20", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x1AD3110", Offset = "0x1AD2510", VA = "0x181AD3110")]
			protected MemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x1AD30A0", Offset = "0x1AD24A0", VA = "0x181AD30A0", Slot = "6")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void DisposeInternal();

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x1AD2EE0", Offset = "0x1AD22E0", VA = "0x181AD2EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AD9EA0", Offset = "0x1AD92A0", VA = "0x181AD9EA0")]
			public SymbolMemoryHandle(Memory memory, Guid address, string symbol, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9BA0", Offset = "0x1AD8FA0", VA = "0x181AD9BA0", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9D80", Offset = "0x1AD9180", VA = "0x181AD9D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private class UnnamedMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x1ADDEB0", Offset = "0x1ADD2B0", VA = "0x181ADDEB0")]
			public UnnamedMemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x1ADDA90", Offset = "0x1ADCE90", VA = "0x181ADDA90", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x1ADDC70", Offset = "0x1ADD070", VA = "0x181ADDC70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x148CEC0", Offset = "0x148C2C0", VA = "0x18148CEC0")]
		public Memory(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x148BD70", Offset = "0x148B170", VA = "0x18148BD70")]
		private void OnGuidsRemapped(IReadOnlyDictionary<Guid, ShortenedGuidMap.GuidRemapping> remappedguids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x12898A0", Offset = "0x1288CA0", VA = "0x1812898A0")]
		private void RemapDictionary<T>(Dictionary<Guid, RateLimitedSynchronizedField<T>> synchronizedFieldDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x148C150", Offset = "0x148B550", VA = "0x18148C150")]
		private void OnHandleReleased(IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x148BE20", Offset = "0x148B220", VA = "0x18148BE20")]
		private void OnHandleReleased(string symbol, IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x1298160", Offset = "0x1297560", VA = "0x181298160")]
		public IMemoryHandle AllocateNamedVariable<T>(string symbol, Guid defaultAddress, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x1299440", Offset = "0x1298840", VA = "0x181299440")]
		public IMemoryHandle AllocateUnnamedVariable<T>(Guid address, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x12DF1B0", Offset = "0x12DE5B0", VA = "0x1812DF1B0")]
		private Guid InitializeLocal<T>(Guid address, Dictionary<Guid, T> dictionary, T value)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x12DF330", Offset = "0x12DE730", VA = "0x1812DF330")]
		private Guid InitializeSynchronized<T>(Guid address, Dictionary<Guid, RateLimitedSynchronizedField<T>> dictionary, T initialValue)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x1289840", Offset = "0x1288C40", VA = "0x181289840")]
		private void DeallocateSynchronized<T>(Guid address, RateLimitedSynchronizedField<T> field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x122A5B0", Offset = "0x12299B0", VA = "0x18122A5B0")]
		private bool AllocateOrReference<T>(Guid defaultAddress, CircuitType valueType, Dictionary<Guid, T> typeMemory, out IMemoryHandle handle, [Optional] string variableName, [Optional] Action<Guid, T> customDispose)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x1298720", Offset = "0x1297B20", VA = "0x181298720")]
		private IMemoryHandle AllocateOrReferenceLocal<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, T> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x1298D30", Offset = "0x1298130", VA = "0x181298D30")]
		private IMemoryHandle AllocateOrReferenceSynchronized<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, RateLimitedSynchronizedField<T>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x148B1A0", Offset = "0x148A5A0", VA = "0x18148B1A0")]
		public IMemoryHandle AllocateBoolean(Guid defaultAddress, bool value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x148B250", Offset = "0x148A650", VA = "0x18148B250")]
		public IMemoryHandle AllocateInt32(Guid defaultAddress, int value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x148B3B0", Offset = "0x148A7B0", VA = "0x18148B3B0")]
		public IMemoryHandle AllocateSingle(Guid defaultAddress, float value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x148B460", Offset = "0x148A860", VA = "0x18148B460")]
		public IMemoryHandle AllocateString(Guid defaultAddress, string value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x148B300", Offset = "0x148A700", VA = "0x18148B300")]
		public IMemoryHandle AllocateOrReferenceSynchronizedBoolean(Guid defaultAddress, bool initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x148B510", Offset = "0x148A910", VA = "0x18148B510")]
		public IMemoryHandle AllocateSynchronizedInt32(Guid defaultAddress, int initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x148B5C0", Offset = "0x148A9C0", VA = "0x18148B5C0")]
		public IMemoryHandle AllocateSynchronizedSingle(Guid defaultAddress, float initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x148B670", Offset = "0x148AA70", VA = "0x18148B670")]
		public IMemoryHandle AllocateSynchronizedString(Guid defaultAddress, string initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x148B9F0", Offset = "0x148ADF0", VA = "0x18148B9F0")]
		public bool GetBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x148BA50", Offset = "0x148AE50", VA = "0x18148BA50")]
		public int GetInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x148BAB0", Offset = "0x148AEB0", VA = "0x18148BAB0")]
		public float GetSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x148BB10", Offset = "0x148AF10", VA = "0x18148BB10")]
		public string GetString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x148BB70", Offset = "0x148AF70", VA = "0x18148BB70")]
		public bool GetSynchronizedBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x148BBF0", Offset = "0x148AFF0", VA = "0x18148BBF0")]
		public int GetSynchronizedInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x148BC70", Offset = "0x148B070", VA = "0x18148BC70")]
		public float GetSynchronizedSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x148BCF0", Offset = "0x148B0F0", VA = "0x18148BCF0")]
		public string GetSynchronizedString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x122B3F0", Offset = "0x122A7F0", VA = "0x18122B3F0")]
		private bool SetValue<T>(Guid id, T value, Dictionary<Guid, T> values) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x148C8B0", Offset = "0x148BCB0", VA = "0x18148C8B0")]
		public bool SetBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x148C920", Offset = "0x148BD20", VA = "0x18148C920")]
		public bool SetInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x148C990", Offset = "0x148BD90", VA = "0x18148C990")]
		public bool SetSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x148CA00", Offset = "0x148BE00", VA = "0x18148CA00")]
		public bool SetString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x148CAB0", Offset = "0x148BEB0", VA = "0x18148CAB0")]
		public bool SetSynchronizedBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x148CB40", Offset = "0x148BF40", VA = "0x18148CB40")]
		public bool SetSynchronizedInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x148CBD0", Offset = "0x148BFD0", VA = "0x18148CBD0")]
		public bool SetSynchronizedSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x148CC60", Offset = "0x148C060", VA = "0x18148CC60")]
		public bool SetSynchronizedString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x148C4B0", Offset = "0x148B8B0", VA = "0x18148C4B0")]
		public void RegisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x148CE40", Offset = "0x148C240", VA = "0x18148CE40")]
		public void UnregisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x148C270", Offset = "0x148B670", VA = "0x18148C270")]
		private void OnValueChanged(RateLimiter rateLimiter, Guid address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x148CD20", Offset = "0x148C120", VA = "0x18148CD20")]
		private static string Truncate(string originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x148CD70", Offset = "0x148C170", VA = "0x18148CD70")]
		public bool TryGetNamedVariable(string varName, out Guid variableAddress, out CircuitType variableType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x148C530", Offset = "0x148B930", VA = "0x18148C530")]
		public void RemapNamedVariables(CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x148B720", Offset = "0x148AB20", VA = "0x18148B720")]
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
			[Cpp2IlInjected.Address(RVA = "0x13CE30", Offset = "0x13C230", VA = "0x18013CE30")]
			public TypeConversionKey(TypeKind fromKind, TypeKind toKind)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x1821B0", Offset = "0x1815B0", VA = "0x1801821B0")]
			public bool Equals(TypeConversionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x1821D0", Offset = "0x1815D0", VA = "0x1801821D0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x182260", Offset = "0x181660", VA = "0x180182260", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x148DE40", Offset = "0x148D240", VA = "0x18148DE40")]
		public static bool IsConvertableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x148DBD0", Offset = "0x148CFD0", VA = "0x18148DBD0")]
		public static Func<Node, Node, (Node, ITypeConversionNode)> GetConverterConstructor(CircuitType from, CircuitType to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x148E140", Offset = "0x148D540", VA = "0x18148E140")]
		public static bool SupportsDefaultValue(CircuitType signalType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x148DF00", Offset = "0x148D300", VA = "0x18148DF00")]
		public static void RegisterFriendlyName(Guid name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x148DCF0", Offset = "0x148D0F0", VA = "0x18148DCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1490030", Offset = "0x148F430", VA = "0x181490030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x148E920", Offset = "0x148DD20", VA = "0x18148E920", Slot = "4")]
		public bool AllowsMultipleInputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x148E950", Offset = "0x148DD50", VA = "0x18148E950", Slot = "5")]
		public bool AllowsMultipleOutputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x148F250", Offset = "0x148E650", VA = "0x18148F250", Slot = "6")]
		public bool IsAssignableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x148EB20", Offset = "0x148DF20", VA = "0x18148EB20")]
		private bool IsAssignableToInternal(CircuitType from, CircuitType to, IReadOnlyList<CircuitType> fromTypeParameterAssignments, IReadOnlyList<CircuitType> toTypeParameterAssignments)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x148F2E0", Offset = "0x148E6E0", VA = "0x18148F2E0", Slot = "7")]
		public CircuitType Narrow(CircuitType typeA, CircuitType typeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x148E980", Offset = "0x148DD80", VA = "0x18148E980")]
		private static (CircuitType, IReadOnlyList<CircuitType>, bool) ExtractTypeSpecifics(CircuitType type, IReadOnlyList<CircuitType> lastAssignments)
		{
			return default((CircuitType, IReadOnlyList<CircuitType>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x148DAE0", Offset = "0x148CEE0", VA = "0x18148DAE0")]
			public TransformModificationHandler(CircuitObject modifiedObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x148D730", Offset = "0x148CB30", VA = "0x18148D730")]
			public ICircuitObjectModification CreateModification(Vector3? newLocalPosition, Quaternion? newLocalRotation)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x148D860", Offset = "0x148CC60", VA = "0x18148D860", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x390F70", Offset = "0x390370", VA = "0x180390F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C9D20", Offset = "0x3C9120", VA = "0x1803C9D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x582D30", Offset = "0x582130", VA = "0x180582D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool CanSetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x1480C90", Offset = "0x1480090", VA = "0x181480C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x1480C30", Offset = "0x1480030", VA = "0x181480C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action OnDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x1480AF0", Offset = "0x147FEF0", VA = "0x181480AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0x1480CE0", Offset = "0x14800E0", VA = "0x181480CE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x1480B90", Offset = "0x147FF90", VA = "0x181480B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x1480D80", Offset = "0x1480180", VA = "0x181480D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x1480970", Offset = "0x147FD70", VA = "0x181480970")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x1480770", Offset = "0x147FB70", VA = "0x181480770")]
		internal void SetCanDestroy(bool canDestroy, CircuitTokenFlag.CircuitToken token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x14805D0", Offset = "0x147F9D0", VA = "0x1814805D0")]
		public void RequestTransformChange(Vector3? newPosition, Quaternion? newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x1281310", Offset = "0x1280710", VA = "0x181281310")]
		public void RegisterModificationHandler<T>(T handler) where T : ICircuitObjectModificationHandler
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x1222650", Offset = "0x1221A50", VA = "0x181222650")]
		public bool TryGetModificationHandler<T>(out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x1222720", Offset = "0x1221B20", VA = "0x181222720")]
		public bool TryGetModificationHandler<T>(Guid handlerId, out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x1480910", Offset = "0x147FD10", VA = "0x181480910")]
		public bool UnregisterModificationHandler(Guid guid)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x1480400", Offset = "0x147F800", VA = "0x181480400")]
		public void HandleModificationRequest(Guid modificationHandlerId, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x14803B0", Offset = "0x147F7B0", VA = "0x1814803B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1480510", Offset = "0x147F910", VA = "0x181480510")]
		public bool RequestChangeName(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0130", Offset = "0x5AF530", VA = "0x1805B0130", Slot = "8")]
		public virtual bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE40", Offset = "0xA4A240", VA = "0x180A4AE40")]
		protected void RaiseOnNameChangedEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public abstract class CircuitObject<TProto> : CircuitObject, ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE660", Offset = "0x1ACDA60", VA = "0x181ACE660")]
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
		[Cpp2IlInjected.Address(RVA = "0x181850", Offset = "0x180C50", VA = "0x180181850")]
		public CircuitObjectId(Guid contextId, Guid objectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x1817D0", Offset = "0x180BD0", VA = "0x1801817D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1483420", Offset = "0x1482820", VA = "0x181483420")]
		protected ExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x14833F0", Offset = "0x14827F0", VA = "0x1814833F0")]
		protected ExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x1483200", Offset = "0x1482600", VA = "0x181483200")]
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
			[Cpp2IlInjected.Address(RVA = "0x14834F0", Offset = "0x14828F0", VA = "0x1814834F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x3AB330", Offset = "0x3AA730", VA = "0x1803AB330", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D50", Offset = "0x3A6150", VA = "0x1803A6D50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x108F630", Offset = "0x108EA30", VA = "0x18108F630")]
		public ExecutionScope([NotNull] CircuitContext executionScopeContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x1483450", Offset = "0x1482850", VA = "0x181483450", Slot = "7")]
		public bool MarkExecution()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xC7B3C0", Offset = "0xC7A7C0", VA = "0x180C7B3C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x139FD0", Offset = "0x1393D0", VA = "0x180139FD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x182110", Offset = "0x181510", VA = "0x180182110")]
		private DisconnectionResult(DisconnectionResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x182120", Offset = "0x181520", VA = "0x180182120")]
		private DisconnectionResult(int indexOfDstInSrc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x1482580", Offset = "0x1481980", VA = "0x181482580")]
		public static DisconnectionResult Ok(int indexOfDstInSrc)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x1482560", Offset = "0x1481960", VA = "0x181482560")]
		public static DisconnectionResult ErrorNull()
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x1482540", Offset = "0x1481940", VA = "0x181482540")]
		public static DisconnectionResult ErrorNotConnected()
		{
			return default(DisconnectionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public static class GraphOp
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x1487910", Offset = "0x1486D10", VA = "0x181487910")]
		private static ConnectionResult CanConnect(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x1487F10", Offset = "0x1487310", VA = "0x181487F10")]
		public static ConnectionResult ConnectByRequest(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x1488440", Offset = "0x1487840", VA = "0x181488440")]
		internal static ConnectionResult ConnectLocal(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x1488960", Offset = "0x1487D60", VA = "0x181488960")]
		internal static void ConnectLocal(CircuitContext context, Guid srcNodeId, Guid srcPortId, Guid dstNodeId, Guid dstPortId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x1488160", Offset = "0x1487560", VA = "0x181488160")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) ConnectCore(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x1488B20", Offset = "0x1487F20", VA = "0x181488B20")]
		private static bool CreatesCycle(Node srcNode, Node dstNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x148A590", Offset = "0x1489990", VA = "0x18148A590")]
		private static bool IsConnected(Node srcNode, Node dstNode, OutputPort srcPort, InputPort dstPort)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x1487EA0", Offset = "0x14872A0", VA = "0x181487EA0")]
		private static DisconnectionResult CanDisconnect(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x1489C60", Offset = "0x1489060", VA = "0x181489C60")]
		internal static DisconnectionResult DisconnectLocal(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x14895B0", Offset = "0x14889B0", VA = "0x1814895B0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectCore(OutputPort srcPort, InputPort dstPort, int indexOfDstInSrc)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x148A330", Offset = "0x1489730", VA = "0x18148A330")]
		private static int IndexOfDstInSrc(OutputPort srcPort, InputPort dstPort)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1489890", Offset = "0x1488C90", VA = "0x181489890")]
		private static (IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>) DisconnectForConnect(OutputPort srcPort, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x1487E80", Offset = "0x1487280", VA = "0x181487E80")]
		private static bool CanDisconnectPort(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x1489D20", Offset = "0x1489120", VA = "0x181489D20")]
		public static bool DisconnectPortByRequest(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x148A2C0", Offset = "0x14896C0", VA = "0x18148A2C0")]
		internal static bool DisconnectPortLocal(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x148A130", Offset = "0x1489530", VA = "0x18148A130")]
		internal static void DisconnectPortLocal(CircuitContext context, Guid nodeId, Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x1489F50", Offset = "0x1489350", VA = "0x181489F50")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectPortCore(PortBase port)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x14892F0", Offset = "0x14886F0", VA = "0x1814892F0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyPortGroupCore(IPortGroup portGroup)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x1487E00", Offset = "0x1487200", VA = "0x181487E00")]
		private static bool CanDestroyNode(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x1489230", Offset = "0x1488630", VA = "0x181489230")]
		internal static bool DestroyNodeLocal(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x1488CC0", Offset = "0x14880C0", VA = "0x181488CC0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyNodeCore(Node node)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x148A3F0", Offset = "0x14897F0", VA = "0x18148A3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16B67A0", Offset = "0x16B5BA0", VA = "0x1816B67A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		internal Dictionary<string, CircuitType> LastTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x445FD0", Offset = "0x4453D0", VA = "0x180445FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x5146F0", Offset = "0x513AF0", VA = "0x1805146F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public IEnumerable<InputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x16B6750", Offset = "0x16B5B50", VA = "0x1816B6750", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public IEnumerable<InputPort> InputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0x16B6640", Offset = "0x16B5A40", VA = "0x1816B6640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public IEnumerable<OutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x16B6980", Offset = "0x16B5D80", VA = "0x1816B6980", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IEnumerable<OutputPort> OutputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x16B6870", Offset = "0x16B5C70", VA = "0x1816B6870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public IEnumerable<PortGroupBase<InputPort>> InputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x16B65F0", Offset = "0x16B59F0", VA = "0x1816B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public IEnumerable<PortGroupBase<OutputPort>> OutputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x16B6820", Offset = "0x16B5C20", VA = "0x1816B6820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x446000", Offset = "0x445400", VA = "0x180446000", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x16B6A70", Offset = "0x16B5E70", VA = "0x1816B6A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action OnPortsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x16B6550", Offset = "0x16B5950", VA = "0x1816B6550")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x16B69D0", Offset = "0x16B5DD0", VA = "0x1816B69D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x16B5D50", Offset = "0x16B5150", VA = "0x1816B5D50", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x16B52C0", Offset = "0x16B46C0", VA = "0x1816B52C0")]
		public string GetNodeName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x16B6180", Offset = "0x16B5580", VA = "0x1816B6180")]
		protected Node(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x16B53E0", Offset = "0x16B47E0", VA = "0x1816B53E0")]
		public bool RequestSetPortDefaultValue(PortBase port, CircuitSignal value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x16B52D0", Offset = "0x16B46D0", VA = "0x1816B52D0", Slot = "16")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x16B5DA0", Offset = "0x16B51A0", VA = "0x1816B5DA0")]
		public void SetSpecificTypes(IEnumerable<(string, CircuitType)> genericTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x16B60E0", Offset = "0x16B54E0", VA = "0x1816B60E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "17")]
		protected virtual void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x16B5750", Offset = "0x16B4B50", VA = "0x1816B5750", Slot = "10")]
		public sealed override CircuitNodeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x16B5550", Offset = "0x16B4950", VA = "0x1816B5550")]
		[CanBeNull]
		private InventionPieceData SerializeInventionPieceData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x16B4E90", Offset = "0x16B4290", VA = "0x1816B4E90", Slot = "11")]
		public sealed override void DeserializeFromProtobuf(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x16B4750", Offset = "0x16B3B50", VA = "0x1816B4750")]
		public void DeserializeConnections(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "18")]
		protected virtual void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "19")]
		protected virtual void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x16B51A0", Offset = "0x16B45A0", VA = "0x1816B51A0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x16B5220", Offset = "0x16B4620", VA = "0x1816B5220", Slot = "20")]
		protected internal virtual (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x16B53A0", Offset = "0x16B47A0", VA = "0x1816B53A0")]
		internal void RaiseOnPortsUpdatedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x16B5290", Offset = "0x16B4690", VA = "0x1816B5290", Slot = "21")]
		public virtual IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x16B46B0", Offset = "0x16B3AB0", VA = "0x1816B46B0")]
		protected static FunctionType CTypeParams(params TypeParamConstrainedOrNot[] typeParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x16B44D0", Offset = "0x16B38D0", VA = "0x1816B44D0")]
		private static InputPort BuildInputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x16B45C0", Offset = "0x16B39C0", VA = "0x1816B45C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x16492C0", Offset = "0x16486C0", VA = "0x1816492C0")]
		public NodeConnection([NotNull] Node srcNode, [NotNull] OutputPort srcPort, [NotNull] Node dstNode, [NotNull] InputPort dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x16B4190", Offset = "0x16B3590", VA = "0x1816B4190")]
		protected bool Equals(NodeConnection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x16B4080", Offset = "0x16B3480", VA = "0x1816B4080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x16B41D0", Offset = "0x16B35D0", VA = "0x1816B41D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x818170", Offset = "0x817570", VA = "0x180818170")]
		public static bool operator !=(NodeConnection left, NodeConnection right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x16B4360", Offset = "0x16B3760", VA = "0x1816B4360", Slot = "9")]
		public NodeConnectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x16B4030", Offset = "0x16B3430", VA = "0x1816B4030", Slot = "8")]
		public void DeserializeFromProtobuf(NodeConnectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x16B4290", Offset = "0x16B3690", VA = "0x1816B4290")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C9370", Offset = "0x3C8770", VA = "0x1803C9370", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB680", Offset = "0x1ACAA80", VA = "0x181ACB680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB620", Offset = "0x1ACAA20", VA = "0x181ACB620")]
		public BasicPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB350", Offset = "0x1ACA750", VA = "0x181ACB350")]
		internal void AddPortLocal(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB380", Offset = "0x1ACA780", VA = "0x181ACB380", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB4A0", Offset = "0x1ACA8A0", VA = "0x181ACB4A0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC9F0", Offset = "0x5EBDF0", VA = "0x1805EC9F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1ACEF80", Offset = "0x1ACE380", VA = "0x181ACEF80")]
		public DynamicPortGroupModificationHandler(Node node, PortGroupBase<TPort> portGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x1ACEB10", Offset = "0x1ACDF10", VA = "0x181ACEB10")]
		public ICircuitObjectModification CreateAddModification(Guid portId, string portName, CircuitType portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x1ACECE0", Offset = "0x1ACE0E0", VA = "0x181ACECE0")]
		public ICircuitObjectModification CreateRemoveModification(Guid portId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x1ACEE50", Offset = "0x1ACE250", VA = "0x181ACEE50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x445FE0", Offset = "0x4453E0", VA = "0x180445FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x409990", Offset = "0x408D90", VA = "0x180409990", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF400", Offset = "0x1ACE800", VA = "0x181ACF400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF190", Offset = "0x1ACE590", VA = "0x181ACF190")]
		public ExecNameBasedPortGroup(string execPortName, PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF060", Offset = "0x1ACE460", VA = "0x181ACF060")]
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
			[Cpp2IlInjected.Address(RVA = "0x445FD0", Offset = "0x4453D0", VA = "0x180445FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C10", Offset = "0x3D7010", VA = "0x1803D7C10", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF400", Offset = "0x1ACE800", VA = "0x181ACF400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x1AD2290", Offset = "0x1AD1690", VA = "0x181AD2290", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD20F0", Offset = "0x1AD14F0", VA = "0x181AD20F0")]
		public IndexBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory, string elementName, CircuitTypeOrString elementPortType, int minPortCount = 0, int maxPortCount = 64)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x1AD19B0", Offset = "0x1AD0DB0", VA = "0x181AD19B0", Slot = "16")]
		public override bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x1AD17B0", Offset = "0x1AD0BB0", VA = "0x181AD17B0")]
		public TPort AddPortLocal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1D20", Offset = "0x1AD1120", VA = "0x181AD1D20")]
		private void RemoveLastPortLocal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1F50", Offset = "0x1AD1350", VA = "0x181AD1F50", Slot = "18")]
		protected override void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1A70", Offset = "0x1AD0E70", VA = "0x181AD1A70", Slot = "19")]
		protected override void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1E00", Offset = "0x1AD1200", VA = "0x181AD1E00", Slot = "24")]
		public void RequestAddPort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1C80", Offset = "0x1AD1080", VA = "0x181AD1C80", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1CB0", Offset = "0x1AD10B0", VA = "0x181AD1CB0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x16B0F80", Offset = "0x16B0380", VA = "0x1816B0F80", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private OutputPort FirstConnectedPort
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x16B0F20", Offset = "0x16B0320", VA = "0x1816B0F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x16B0E80", Offset = "0x16B0280", VA = "0x1816B0E80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool SupportsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x16B10A0", Offset = "0x16B04A0", VA = "0x1816B10A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool HasCustomDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x16B0FD0", Offset = "0x16B03D0", VA = "0x1816B0FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public CircuitSignal DefaultSignalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x16B0F00", Offset = "0x16B0300", VA = "0x1816B0F00")]
			get
			{
				return default(CircuitSignal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x16B11C0", Offset = "0x16B05C0", VA = "0x1816B11C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action OnDefaultSignalValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x16B0DE0", Offset = "0x16B01E0", VA = "0x1816B0DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x16B1120", Offset = "0x16B0520", VA = "0x1816B1120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x16B0970", Offset = "0x16AFD70", VA = "0x1816B0970", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x16B0D80", Offset = "0x16B0180", VA = "0x1816B0D80")]
		public InputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, bool canSet = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x16B0AB0", Offset = "0x16AFEB0", VA = "0x1816B0AB0", Slot = "12")]
		protected override void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x16B0A00", Offset = "0x16AFE00", VA = "0x1816B0A00", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x16B0CF0", Offset = "0x16B00F0", VA = "0x1816B0CF0", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x16B0990", Offset = "0x16AFD90", VA = "0x1816B0990", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x16B0840", Offset = "0x16AFC40", VA = "0x1816B0840")]
		private CircuitSignal DefaultValue(TypeKind kind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x16B0C20", Offset = "0x16B0020", VA = "0x1816B0C20")]
		public DefaultPortData SerializeCustomDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x16B08B0", Offset = "0x16AFCB0", VA = "0x1816B08B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A89E0", Offset = "0x3A7DE0", VA = "0x1803A89E0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF400", Offset = "0x1ACE800", VA = "0x181ACF400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3F60", Offset = "0x1AD3360", VA = "0x181AD3F60")]
		public NameBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3CF0", Offset = "0x1AD30F0", VA = "0x181AD3CF0", Slot = "26")]
		public void RequestAddPort(string portName, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3600", Offset = "0x1AD2A00", VA = "0x181AD3600", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x1AD36B0", Offset = "0x1AD2AB0", VA = "0x181AD36B0", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3170", Offset = "0x1AD2570", VA = "0x181AD3170")]
		internal TPort AddPortLocal(string portName, CircuitTypeOrString circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3760", Offset = "0x1AD2B60", VA = "0x181AD3760", Slot = "27")]
		public bool HasPort(string portName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3E30", Offset = "0x1AD3230", VA = "0x181AD3E30")]
		public bool TryGetPort(string portName, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3580", Offset = "0x1AD2980", VA = "0x181AD3580")]
		private Guid GeneratePortId(string portName)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3CC0", Offset = "0x1AD30C0", VA = "0x181AD3CC0", Slot = "25")]
		public void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x1AD37A0", Offset = "0x1AD2BA0", VA = "0x181AD37A0")]
		internal void MergeNamedGroup(IEnumerable<KeyValuePair<string, CircuitType>> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3310", Offset = "0x1AD2710", VA = "0x181AD3310", Slot = "24")]
		public void ClearPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x128A760", Offset = "0x1289B60", VA = "0x18128A760")]
		internal void OnBridgedPortRemoved<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x128A7E0", Offset = "0x1289BE0", VA = "0x18128A7E0")]
		internal (IEnumerable<Action>, IEnumerable<Node>) RemoveBridgedPortCore<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x128A730", Offset = "0x1289B30", VA = "0x18128A730")]
		internal void OnBridgedPortAdded<TOtherPort>(TOtherPort otherAddedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x122B660", Offset = "0x122AA60", VA = "0x18122B660")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x18D34A0", Offset = "0x18D28A0", VA = "0x1818D34A0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCE0", Offset = "0x3DB0E0", VA = "0x1803DBCE0", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x18D3320", Offset = "0x18D2720", VA = "0x1818D3320")]
		public OutputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, [Optional] OutputPortGetDelegate outputPortGetDelegate, [Optional] OutputPortSetDelegate outputPortSetDelegate, [Optional] OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x18D3240", Offset = "0x18D2640", VA = "0x1818D3240", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x18D32E0", Offset = "0x18D26E0", VA = "0x1818D32E0", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x18D3220", Offset = "0x18D2620", VA = "0x1818D3220", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x18D30C0", Offset = "0x18D24C0", VA = "0x1818D30C0")]
		public NextExecutable GetExec()
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x18D32D0", Offset = "0x18D26D0", VA = "0x1818D32D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x18D4710", Offset = "0x18D3B10", VA = "0x1818D4710", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		internal bool IsDynamic
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x4043B0", Offset = "0x4037B0", VA = "0x1804043B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x8784A0", Offset = "0x8778A0", VA = "0x1808784A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3928D0", Offset = "0x391CD0", VA = "0x1803928D0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x395370", Offset = "0x394770", VA = "0x180395370", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x18D4900", Offset = "0x18D3D00", VA = "0x1818D4900")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D4670", Offset = "0x18D3A70", VA = "0x1818D4670", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x18D4860", Offset = "0x18D3C60", VA = "0x1818D4860", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<bool> OnIsConnectedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x18D45D0", Offset = "0x18D39D0", VA = "0x1818D45D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x18D47C0", Offset = "0x18D3BC0", VA = "0x1818D47C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Node GetNode(NodeConnection connection);

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x18D4470", Offset = "0x18D3870", VA = "0x1818D4470")]
		protected PortBase(Guid portId, string portName, bool isInputPort, [Optional][CanBeNull] CircuitTypeOrString? circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x18D3FB0", Offset = "0x18D33B0", VA = "0x1818D3FB0")]
		public void AddConnection(NodeConnection newConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x18D42B0", Offset = "0x18D36B0", VA = "0x1818D42B0")]
		public bool RemoveConnection(NodeConnection connection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x18D41F0", Offset = "0x18D35F0", VA = "0x1818D41F0")]
		public void RemoveConnectionAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x941D00", Offset = "0x941100", VA = "0x180941D00", Slot = "12")]
		protected virtual void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x18D4190", Offset = "0x18D3590", VA = "0x1818D4190")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D4390", Offset = "0x18D3790", VA = "0x1818D4390", Slot = "17")]
		public NodePortData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x18D4070", Offset = "0x18D3470", VA = "0x1818D4070", Slot = "5")]
		public void DeserializeFromProtobuf(NodePortData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x18D40A0", Offset = "0x18D34A0", VA = "0x1818D40A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal static class PortBridge
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x128B310", Offset = "0x128A710", VA = "0x18128B310")]
		internal static void BridgePortDelegates<TPortA, TPortB>(TPortA portA, TPortB portB) where TPortA : PortBase where TPortB : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x18D4950", Offset = "0x18D3D50", VA = "0x1818D4950")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public IEnumerable<PortGroupBase<TPort>> AllPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x1AD61D0", Offset = "0x1AD55D0", VA = "0x181AD61D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public IEnumerable<TPort> AllPorts
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD6260", Offset = "0x1AD5660", VA = "0x181AD6260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD5F90", Offset = "0x1AD5390", VA = "0x181AD5F90")]
		public PortCollection(bool isInputCollection, Node node, PortCreationFactory<TPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x1AD50A0", Offset = "0x1AD44A0", VA = "0x181AD50A0")]
		public IndexBasedPortGroup<TPort> RegisterIndexedPortGroup(Guid portGroupId, PortGroupSerialization serialization, CircuitTypeOrString elementType, string elementName = "Element", [Optional] string portGroupName, int minPortCount = 0, int maxPortCount = 64)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x1AD51D0", Offset = "0x1AD45D0", VA = "0x181AD51D0")]
		public NameBasedPortGroup<TPort> RegisterNameBasedPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4F90", Offset = "0x1AD4390", VA = "0x181AD4F90")]
		public ExecNameBasedPortGroup<TPort> RegisterExecNameBasedPortGroup(string execPortName, Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4EA0", Offset = "0x1AD42A0", VA = "0x181AD4EA0")]
		public BasicPortGroup<TPort> RegisterBasicPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4E90", Offset = "0x1AD4290", VA = "0x181AD4E90")]
		private Dictionary<Guid, PortGroupBase<TPort>> GetPortGroupDictionary(PortGroupSerialization serialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3FF0", Offset = "0x1AD33F0", VA = "0x181AD3FF0")]
		private void AddPortGroup(PortGroupBase<TPort> newPortGroup, [Optional] string portGroupName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x1AD59E0", Offset = "0x1AD4DE0", VA = "0x181AD59E0")]
		public bool TryGetPort(Guid portGuid, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x1AD3FC0", Offset = "0x1AD33C0", VA = "0x181AD3FC0")]
		public void AddBuiltInPort(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4BB0", Offset = "0x1AD3FB0", VA = "0x181AD4BB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x1AD5440", Offset = "0x1AD4840", VA = "0x181AD5440", Slot = "6")]
		public PortCollectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "7")]
		protected virtual void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x1AD4680", Offset = "0x1AD3A80", VA = "0x181AD4680", Slot = "4")]
		public void DeserializeFromProtobuf([NotNull] PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "8")]
		protected virtual void DeserializeInternal(PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD42A0", Offset = "0x1AD36A0", VA = "0x181AD42A0")]
		private PortGroupBase<TPort> CreatePortGroupOnDeserialization(Guid portGroupId, PortGroupData protobufData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x122B990", Offset = "0x122AD90", VA = "0x18122B990")]
		public bool TryGetPortGroup<T>(Guid portGroupId, out T portGroup) where T : PortGroupBase<TPort>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD52C0", Offset = "0x1AD46C0", VA = "0x181AD52C0")]
		public void RemovePortGroup(Guid groupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public sealed class InputPortCollection : PortCollection<InputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x16B07C0", Offset = "0x16AFBC0", VA = "0x1816B07C0")]
		public InputPortCollection(Node node, PortCreationFactory<InputPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x16B0510", Offset = "0x16AF910", VA = "0x1816B0510", Slot = "7")]
		protected override void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x16B02C0", Offset = "0x16AF6C0", VA = "0x1816B02C0", Slot = "8")]
		protected override void DeserializeInternal(PortCollectionData collectionData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public sealed class OutputPortCollection : PortCollection<OutputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x18D25E0", Offset = "0x18D19E0", VA = "0x1818D25E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AD8040", Offset = "0x1AD7440", VA = "0x181AD8040", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public IReadOnlyList<TPort> OrderedPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x390F60", Offset = "0x390360", VA = "0x180390F60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xFD4B90", Offset = "0xFD3F90", VA = "0x180FD4B90", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IReadOnlyCollection<PortBase> IPortGroup.Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x11B5EF0", Offset = "0x11B52F0", VA = "0x1811B5EF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public Guid GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x6BD480", Offset = "0x6BC880", VA = "0x1806BD480", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x40FEE0", Offset = "0x40F2E0", VA = "0x18040FEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x486D40", Offset = "0x486140", VA = "0x180486D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public virtual bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BD610", VA = "0x1803BE210", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<TPort> OnPortAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x1AD7EC0", Offset = "0x1AD72C0", VA = "0x181AD7EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AD8060", Offset = "0x1AD7460", VA = "0x181AD8060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<TPort> OnPortRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1AD7F80", Offset = "0x1AD7380", VA = "0x181AD7F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AD8120", Offset = "0x1AD7520", VA = "0x181AD8120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6D40", Offset = "0x1AD6140", VA = "0x181AD6D40", Slot = "16")]
		public virtual bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7C70", Offset = "0x1AD7070", VA = "0x181AD7C70")]
		protected PortGroupBase(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7BD0", Offset = "0x1AD6FD0", VA = "0x181AD7BD0")]
		public bool TryGetRegisteredPort(Guid portId, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6AD0", Offset = "0x1AD5ED0", VA = "0x181AD6AD0")]
		protected void AddGroupPort(TPort port, [Optional] bool? isDynamicOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x1AD73D0", Offset = "0x1AD67D0", VA = "0x181AD73D0")]
		protected bool RemoveGroupPort(TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7490", Offset = "0x1AD6890", VA = "0x181AD7490", Slot = "8")]
		public bool RemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7A70", Offset = "0x1AD6E70", VA = "0x181AD7A70", Slot = "17")]
		public PortGroupData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7770", Offset = "0x1AD6B70", VA = "0x181AD7770", Slot = "18")]
		protected virtual void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6D80", Offset = "0x1AD6180", VA = "0x181AD6D80", Slot = "10")]
		public void DeserializeFromProtobuf(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6DE0", Offset = "0x1AD61E0", VA = "0x181AD6DE0", Slot = "19")]
		protected virtual void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7070", Offset = "0x1AD6470", VA = "0x181AD7070", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7520", Offset = "0x1AD6920", VA = "0x181AD7520", Slot = "20")]
		public void RequestAddPort(Guid portId, [Optional] string portName, [Optional] CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7670", Offset = "0x1AD6A70", VA = "0x181AD7670", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x14833F0", Offset = "0x14827F0", VA = "0x1814833F0")]
		protected PureNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x1483420", Offset = "0x1482820", VA = "0x181483420")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0960", Offset = "0x39FD60", VA = "0x1803A0960")]
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
			[Cpp2IlInjected.Address(RVA = "0x16A9780", Offset = "0x16A8B80", VA = "0x1816A9780")]
			get
			{
				return default(NextExecutable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x18D5180", Offset = "0x18D4580", VA = "0x1818D5180")]
		protected SingleExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x18D5410", Offset = "0x18D4810", VA = "0x1818D5410")]
		protected SingleExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x18D5070", Offset = "0x18D4470", VA = "0x1818D5070", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x46C430", Offset = "0x46B830", VA = "0x18046C430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Quaternion LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x1480260", Offset = "0x147F660", VA = "0x181480260")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event OnLocalPositionChangedEvent OnLocalPositionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x1480120", Offset = "0x147F520", VA = "0x181480120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x1480270", Offset = "0x147F670", VA = "0x181480270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event OnLocalRotationChangedEvent OnLocalRotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x14801C0", Offset = "0x147F5C0", VA = "0x1814801C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x1480310", Offset = "0x147F710", VA = "0x181480310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x60D750", Offset = "0x60CB50", VA = "0x18060D750")]
		public CircuitObjectTransform(Guid circuitObjectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x147FF70", Offset = "0x147F370", VA = "0x18147FF70")]
		public void SetLocalPosition(Vector3 newLocalPosition, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x1480060", Offset = "0x147F460", VA = "0x181480060")]
		public void SetLocalRotation(Quaternion newLocalRotation, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x147FEA0", Offset = "0x147F2A0", VA = "0x18147FEA0", Slot = "5")]
		public CircuitObjectTransformData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x147FCF0", Offset = "0x147F0F0", VA = "0x18147FCF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8F60", VA = "0x1803A9B60")]
			public CircuitToken(string tokenName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x1481DC0", Offset = "0x14811C0", VA = "0x181481DC0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1481D70", Offset = "0x1481170", VA = "0x181481D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x1481B80", Offset = "0x1480F80", VA = "0x181481B80")]
		public bool AddToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x1481C50", Offset = "0x1481050", VA = "0x181481C50")]
		public bool RemoveToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3824F0", VA = "0x1803830F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x146D00", Offset = "0x146100", VA = "0x180146D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x146D00", Offset = "0x146100", VA = "0x180146D00")]
		public CircuitTeam(int backingTeamId = -1)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Guid("21B7F027-68C6-4C8C-A5C3-81992622DE80")]
	public class ChangeCircuitObjectNameModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x16A4B70", Offset = "0x16A3F70", VA = "0x1816A4B70")]
		public ChangeCircuitObjectNameModificationHandler(CircuitObject modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x16A4AB0", Offset = "0x16A3EB0", VA = "0x1816A4AB0")]
		public ICircuitObjectModification CreateModification(string newNodeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x16A4B00", Offset = "0x16A3F00", VA = "0x1816A4B00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x1ACE610", Offset = "0x1ACDA10", VA = "0x181ACE610", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x10526B0", Offset = "0x1051AB0", VA = "0x1810526B0")]
		protected CircuitObjectModificationHandlerBase(T modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HandleModificationRequest(byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE540", Offset = "0x1ACD940", VA = "0x181ACE540")]
		protected ICircuitObjectModification WithPayload(string payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE5C0", Offset = "0x1ACD9C0", VA = "0x181ACE5C0")]
		protected ICircuitObjectModification WithPayload(IMessage payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE4C0", Offset = "0x1ACD8C0", VA = "0x181ACE4C0")]
		protected ICircuitObjectModification WithPayload(byte[] payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE480", Offset = "0x1ACD880", VA = "0x181ACE480")]
		protected static string ParseStringPayload(byte[] payload)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public abstract class NodeModificationHandlerBase : CircuitObjectModificationHandlerBase<Node>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x16B4480", Offset = "0x16B3880", VA = "0x1816B4480")]
		protected NodeModificationHandlerBase(Node modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public abstract class NodeModificationHandlerBase<T> : CircuitObjectModificationHandlerBase<T> where T : Node
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x1042FA0", Offset = "0x10423A0", VA = "0x181042FA0")]
		protected NodeModificationHandlerBase(T modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public abstract class EventModificationHandlerBase : CircuitObjectModificationHandlerBase<CircuitEventObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x16A8FA0", Offset = "0x16A83A0", VA = "0x1816A8FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F80", Offset = "0x445380", VA = "0x180445F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB220", Offset = "0x3AA620", VA = "0x1803AB220", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x16B2EE0", Offset = "0x16B22E0", VA = "0x1816B2EE0")]
		public ModificationBase(ICircuitObjectModificationHandler handler, CircuitObject modifiedObject, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10", Slot = "6")]
		public byte[] GetPayload()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x16B2EA0", Offset = "0x16B22A0", VA = "0x1816B2EA0", Slot = "7")]
		public void Send()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Guid("88EC6D1C-1F68-4A30-AD72-71A8AA1B933A")]
	public class PortDefaultValueModificationHandler : NodeModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x16B4480", Offset = "0x16B3880", VA = "0x1816B4480")]
		public PortDefaultValueModificationHandler(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x16B84E0", Offset = "0x16B78E0", VA = "0x1816B84E0")]
		public ICircuitObjectModification CreateModification(Guid portId, CircuitSignal defaultSignal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x16B85B0", Offset = "0x16B79B0", VA = "0x1816B85B0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A7350", Offset = "0x16A6750", VA = "0x1816A7350")]
		public DebugLogNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x16A7210", Offset = "0x16A6610", VA = "0x1816A7210", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A3C10", Offset = "0x16A3010", VA = "0x1816A3C10")]
		public BranchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x16A3A50", Offset = "0x16A2E50", VA = "0x1816A3A50", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A4600", Offset = "0x16A3A00", VA = "0x1816A4600")]
		public BreakTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x16A4340", Offset = "0x16A3740", VA = "0x1816A4340")]
		private CircuitSignal GetReturn0(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x16A4450", Offset = "0x16A3850", VA = "0x1816A4450")]
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
			[Cpp2IlInjected.Address(RVA = "0x16AF9D0", Offset = "0x16AEDD0", VA = "0x1816AF9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16B01E0", Offset = "0x16AF5E0", VA = "0x1816B01E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16A50C0", Offset = "0x16A44C0", VA = "0x1816A50C0")]
			public CircuitBoardModificationHandler(CircuitBoard modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x16A4BC0", Offset = "0x16A3FC0", VA = "0x1816A4BC0")]
			public ICircuitObjectModification CreateExecGroupModification(string newExecGroupName, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x16A4C70", Offset = "0x16A4070", VA = "0x1816A4C70")]
			public ICircuitObjectModification DeleteExecGroupModification(Guid execGroupId, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x16A4D40", Offset = "0x16A4140", VA = "0x1816A4D40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BD610", VA = "0x1803BE210", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public override bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BD610", VA = "0x1803BE210", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x16A6190", Offset = "0x16A5590", VA = "0x1816A6190")]
		public CircuitBoard(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x16A5110", Offset = "0x16A4510", VA = "0x1816A5110")]
		[EditableAddExecInput]
		internal ExecNameBasedPortGroup<InputPort> AddExecInput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x16A5310", Offset = "0x16A4710", VA = "0x1816A5310")]
		[EditableAddExecOutput]
		internal ExecNameBasedPortGroup<OutputPort> AddExecOutput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x16A5BF0", Offset = "0x16A4FF0", VA = "0x1816A5BF0")]
		internal void RemoveExecInput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x16A5D20", Offset = "0x16A5120", VA = "0x1816A5D20")]
		internal void RemoveExecOutput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x16A5510", Offset = "0x16A4910", VA = "0x1816A5510", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x16A5900", Offset = "0x16A4D00", VA = "0x1816A5900", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x16A5E50", Offset = "0x16A5250", VA = "0x1816A5E50", Slot = "24")]
		public override bool RequestAddInputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x16A5EF0", Offset = "0x16A52F0", VA = "0x1816A5EF0", Slot = "26")]
		public override bool RequestAddOutputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x16A5F90", Offset = "0x16A5390", VA = "0x1816A5F90", Slot = "28")]
		public override bool RequestRemoveInputGroup(Guid groupId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x16A6040", Offset = "0x16A5440", VA = "0x1816A6040", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AB4D0", Offset = "0x6AA8D0", VA = "0x1806AB4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public virtual bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public virtual bool CanRemoveInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public virtual bool CanRemoveOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x16A63C0", Offset = "0x16A57C0", VA = "0x1816A63C0")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x16A6370", Offset = "0x16A5770", VA = "0x1816A6370", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "24")]
		public virtual bool RequestAddInputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "26")]
		public virtual bool RequestAddOutputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "28")]
		public virtual bool RequestRemoveInputGroup(Guid portGroup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x395360", Offset = "0x394760", VA = "0x180395360", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		protected HashSet<TEntryNode> CachedEntryNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x1ACDEA0", Offset = "0x1ACD2A0", VA = "0x181ACDEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		protected HashSet<TExitNode> CachedExitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x1ACE190", Offset = "0x1ACD590", VA = "0x181ACE190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CircuitContext ChildContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDC60", Offset = "0x1ACD060", VA = "0x181ACDC60")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDBF0", Offset = "0x1ACCFF0", VA = "0x181ACDBF0")]
		private void OnNodeAddedOrRemoved(CircuitContext context, Node modifiedNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDB00", Offset = "0x1ACCF00", VA = "0x181ACDB00")]
		private void DirtyCachedExitNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDBA0", Offset = "0x1ACCFA0", VA = "0x181ACDBA0", Slot = "16")]
		public sealed override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDB10", Offset = "0x1ACCF10", VA = "0x181ACDB10", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "32")]
		protected virtual void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDB50", Offset = "0x1ACCF50", VA = "0x181ACDB50", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		protected abstract NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x1ACD240", Offset = "0x1ACC640", VA = "0x181ACD240", Slot = "34")]
		protected virtual bool AddInnerEntry(InputPort execInput, out TEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1ACD670", Offset = "0x1ACCA70", VA = "0x181ACD670", Slot = "35")]
		internal virtual bool AddInnerExit(OutputPort execOutput, out TExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDAC0", Offset = "0x1ACCEC0", VA = "0x181ACDAC0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0960", Offset = "0x39FD60", VA = "0x1803A0960", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x461FF0", Offset = "0x4613F0", VA = "0x180461FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AD2450", Offset = "0x1AD1850", VA = "0x181AD2450")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0400", Offset = "0x39F800", VA = "0x1803A0400", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x16AF790", Offset = "0x16AEB90", VA = "0x1816AF790")]
		protected InnerContextEntryNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x16AF710", Offset = "0x16AEB10", VA = "0x1816AF710", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x445FE0", Offset = "0x4453E0", VA = "0x180445FE0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x16B0140", Offset = "0x16AF540", VA = "0x1816B0140")]
		protected InnerContextExitNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x16B00A0", Offset = "0x16AF4A0", VA = "0x1816B00A0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x16A7980", Offset = "0x16A6D80", VA = "0x1816A7980")]
		public DelayNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x16A76B0", Offset = "0x16A6AB0", VA = "0x1816A76B0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x16A7590", Offset = "0x16A6990", VA = "0x1816A7590", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x16A77C0", Offset = "0x16A6BC0", VA = "0x1816A77C0", Slot = "23")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x16A7640", Offset = "0x16A6A40", VA = "0x1816A7640")]
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
			[Cpp2IlInjected.Address(RVA = "0x16AA060", Offset = "0x16A9460", VA = "0x1816AA060")]
			public EventRegistrationNodeModificationHandler(EventNodeBase modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x16A9F70", Offset = "0x16A9370", VA = "0x1816A9F70")]
			public ICircuitObjectModification CreateSetRegistrationModification(CircuitEventBus.EventRegistration eventRegistration)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x16A9FD0", Offset = "0x16A93D0", VA = "0x1816A9FD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x16A9410", Offset = "0x16A8810", VA = "0x1816A9410")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices();

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x16A9360", Offset = "0x16A8760", VA = "0x1816A9360")]
		protected EventNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x16A8FF0", Offset = "0x16A83F0", VA = "0x1816A8FF0", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x16A9080", Offset = "0x16A8480", VA = "0x1816A9080")]
		private void RefreshPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "25")]
		protected virtual void RegisterNewEventRegistration([NotNull] CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x382660", VA = "0x180383260", Slot = "26")]
		protected virtual void UnregisterOldEventRegistration([NotNull] CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x16A92B0", Offset = "0x16A86B0", VA = "0x1816A92B0")]
		protected void SetEventRegistrationFromData(EventRegistrationData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId);

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x16A91F0", Offset = "0x16A85F0", VA = "0x1816A91F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F70", Offset = "0x445370", VA = "0x180445F70", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x16A9CF0", Offset = "0x16A90F0", VA = "0x1816A9CF0")]
		public EventReceiverNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x16A9780", Offset = "0x16A8B80", VA = "0x1816A9780", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x16A9BD0", Offset = "0x16A8FD0", VA = "0x1816A9BD0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x16A96E0", Offset = "0x16A8AE0", VA = "0x1816A96E0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x16A9C60", Offset = "0x16A9060", VA = "0x1816A9C60", Slot = "26")]
		protected override void UnregisterOldEventRegistration(CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x16A97D0", Offset = "0x16A8BD0", VA = "0x1816A97D0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x16A9820", Offset = "0x16A8C20", VA = "0x1816A9820", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x16A9BA0", Offset = "0x16A8FA0", VA = "0x1816A9BA0", Slot = "25")]
		protected override void RegisterNewEventRegistration(CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x16A9850", Offset = "0x16A8C50", VA = "0x1816A9850", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x445F70", Offset = "0x445370", VA = "0x180445F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x43CD40", Offset = "0x43C140", VA = "0x18043CD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x16AA660", Offset = "0x16A9A60", VA = "0x1816AA660")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId, bool sendSyncEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x16AAA30", Offset = "0x16A9E30", VA = "0x1816AAA30")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x16AA4E0", Offset = "0x16A98E0", VA = "0x1816AA4E0", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x16AA490", Offset = "0x16A9890", VA = "0x1816AA490", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x16AA430", Offset = "0x16A9830", VA = "0x1816AA430", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x16AA150", Offset = "0x16A9550", VA = "0x1816AA150")]
		protected void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x16AA510", Offset = "0x16A9910", VA = "0x1816AA510", Slot = "28")]
		protected virtual void SendEventInternal(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x16AA530", Offset = "0x16A9930", VA = "0x1816AA530", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x16AA0B0", Offset = "0x16A94B0", VA = "0x1816AA0B0", Slot = "19")]
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
				[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A4010", VA = "0x1803A4C10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x16BBA40", Offset = "0x16BAE40", VA = "0x1816BBA40")]
			public SyncedEventSenderModificationHandler(SynchedEventSenderNode modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x16BB970", Offset = "0x16BAD70", VA = "0x1816BB970")]
			public ICircuitObjectModification CreateChangeTargetModification(SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x16BB9F0", Offset = "0x16BADF0", VA = "0x1816BB9F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D22E0", Offset = "0x3D16E0", VA = "0x1803D22E0")]
			get
			{
				return default(SynchronizedCircuitContext.SyncedEventTargets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x16BBFD0", Offset = "0x16BB3D0", VA = "0x1816BBFD0")]
		public SynchedEventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x16BBF90", Offset = "0x16BB390", VA = "0x1816BBF90", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x16AFD90", Offset = "0x16AF190", VA = "0x1816AFD90")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x16AF830", Offset = "0x16AEC30", VA = "0x1816AF830", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0xADBC80", Offset = "0xADB080", VA = "0x180ADBC80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000AA8")]
				[Cpp2IlInjected.Address(RVA = "0xADA7B0", Offset = "0xAD9BB0", VA = "0x180ADA7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x16A4250", Offset = "0x16A3650", VA = "0x1816A4250")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0x16A4050", Offset = "0x16A3450", VA = "0x1816A4050", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x16A4150", Offset = "0x16A3550", VA = "0x1816A4150")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F20", Offset = "0x445320", VA = "0x180445F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E18E0", Offset = "0x3E0CE0", VA = "0x1803E18E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A05A0", Offset = "0x39F9A0", VA = "0x1803A05A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x16AC580", Offset = "0x16AB980", VA = "0x1816AC580")]
		public ForeachNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x16AC430", Offset = "0x16AB830", VA = "0x1816AC430", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x16ABF80", Offset = "0x16AB380", VA = "0x1816ABF80", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x16AC010", Offset = "0x16AB410", VA = "0x1816AC010", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x16ABE50", Offset = "0x16AB250", VA = "0x1816ABE50", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x16ABEF0", Offset = "0x16AB2F0", VA = "0x1816ABEF0", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x16AC350", Offset = "0x16AB750", VA = "0x1816AC350", Slot = "21")]
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
			[Cpp2IlInjected.Address(RVA = "0x16AFAB0", Offset = "0x16AEEB0", VA = "0x1816AFAB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xADBC80", Offset = "0xADB080", VA = "0x180ADBC80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000ABF")]
				[Cpp2IlInjected.Address(RVA = "0xADA7B0", Offset = "0xAD9BB0", VA = "0x180ADA7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x16A4160", Offset = "0x16A3560", VA = "0x1816A4160")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x16A40D0", Offset = "0x16A34D0", VA = "0x1816A40D0", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x16A4150", Offset = "0x16A3550", VA = "0x1816A4150")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F20", Offset = "0x445320", VA = "0x180445F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E18E0", Offset = "0x3E0CE0", VA = "0x1803E18E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F40", Offset = "0x445340", VA = "0x180445F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0800", Offset = "0x39FC00", VA = "0x1803A0800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x16AB860", Offset = "0x16AAC60", VA = "0x1816AB860")]
		public ForNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x16AB6E0", Offset = "0x16AAAE0", VA = "0x1816AB6E0", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x16AB400", Offset = "0x16AA800", VA = "0x1816AB400", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x16AB2D0", Offset = "0x16AA6D0", VA = "0x1816AB2D0", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x16AB370", Offset = "0x16AA770", VA = "0x1816AB370", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x16AB490", Offset = "0x16AA890", VA = "0x1816AB490", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AD1C0", Offset = "0x16AC5C0", VA = "0x1816AD1C0")]
		public GetElementNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x16ACF90", Offset = "0x16AC390", VA = "0x1816ACF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AD690", Offset = "0x16ACA90", VA = "0x1816AD690")]
		public GetListCountNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x16AD610", Offset = "0x16ACA10", VA = "0x1816AD610", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AE6F0", Offset = "0x16ADAF0", VA = "0x1816AE6F0")]
		public HasAuthorityNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x16AE590", Offset = "0x16AD990", VA = "0x1816AE590", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B2380", Offset = "0x16B1780", VA = "0x1816B2380")]
		public MakeListNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x16B2250", Offset = "0x16B1650", VA = "0x1816B2250", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B2920", Offset = "0x16B1D20", VA = "0x1816B2920")]
		public MakeTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x16B2730", Offset = "0x16B1B30", VA = "0x1816B2730")]
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
		[Cpp2IlInjected.Address(RVA = "0x2069E0", Offset = "0x205DE0", VA = "0x1802069E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B9E90", Offset = "0x16B9290", VA = "0x1816B9E90")]
		protected RandomNumberGeneratorNode(CircuitContext circuitContext, CircuitType numberType, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x16B9CA0", Offset = "0x16B90A0", VA = "0x1816B9CA0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal);

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x16B9DA0", Offset = "0x16B91A0", VA = "0x1816B9DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B9A80", Offset = "0x16B8E80", VA = "0x1816B9A80")]
		public RandomIntegerGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x16B99A0", Offset = "0x16B8DA0", VA = "0x1816B99A0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B97A0", Offset = "0x16B8BA0", VA = "0x1816B97A0")]
		public RandomFloatGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0x16B9660", Offset = "0x16B8A60", VA = "0x1816B9660", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x16BA6F0", Offset = "0x16B9AF0", VA = "0x1816BA6F0")]
		public SetValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x16BA5E0", Offset = "0x16B99E0", VA = "0x1816BA5E0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BAB00", Offset = "0x16B9F00", VA = "0x1816BAB00")]
		public ShowNotificationNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x16BA9C0", Offset = "0x16B9DC0", VA = "0x1816BA9C0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AD9360", Offset = "0x1AD8760", VA = "0x181AD9360")]
		public SwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD87F0", Offset = "0x1AD7BF0", VA = "0x181AD87F0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x1AD81E0", Offset = "0x1AD75E0", VA = "0x181AD81E0")]
		protected Dictionary<T, OutputPort> BuildCaseMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x1AD88B0", Offset = "0x1AD7CB0", VA = "0x181AD88B0", Slot = "18")]
		protected sealed override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract SwitchNodeData SerializeCaseLables(IEnumerable<T> caseLables);

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x1AD8650", Offset = "0x1AD7A50", VA = "0x181AD8650", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x16B1560", Offset = "0x16B0960", VA = "0x1816B1560", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x16B1400", Offset = "0x16B0800", VA = "0x1816B1400", Slot = "24")]
		protected override int GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x16B14E0", Offset = "0x16B08E0", VA = "0x1816B14E0")]
		public IntSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x16B1460", Offset = "0x16B0860", VA = "0x1816B1460", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<int> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCE0", Offset = "0x3DB0E0", VA = "0x1803DBCE0", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x16BB780", Offset = "0x16BAB80", VA = "0x1816BB780", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x16BB620", Offset = "0x16BAA20", VA = "0x1816BB620", Slot = "24")]
		protected override string GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x16BB700", Offset = "0x16BAB00", VA = "0x1816BB700")]
		public StringSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x16BB680", Offset = "0x16BAA80", VA = "0x1816BB680", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<string> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x4217B0", Offset = "0x420BB0", VA = "0x1804217B0", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x16B3660", Offset = "0x16B2A60", VA = "0x1816B3660")]
		public MultiInputBooleanLogicNode(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x16B3460", Offset = "0x16B2860", VA = "0x1816B3460")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A37F0", Offset = "0x16A2BF0", VA = "0x1816A37F0")]
		public AndNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x16A3700", Offset = "0x16A2B00", VA = "0x1816A3700", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B8280", Offset = "0x16B7680", VA = "0x1816B8280")]
		public OrNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x16B8190", Offset = "0x16B7590", VA = "0x1816B8190", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B3DF0", Offset = "0x16B31F0", VA = "0x1816B3DF0")]
		public NANDNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x16B3D00", Offset = "0x16B3100", VA = "0x1816B3D00", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B3F80", Offset = "0x16B3380", VA = "0x1816B3F80")]
		public NORNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x16B3E90", Offset = "0x16B3290", VA = "0x1816B3E90", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x16B6C20", Offset = "0x16B6020", VA = "0x1816B6C20")]
		public NotNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x16B6AF0", Offset = "0x16B5EF0", VA = "0x1816B6AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AEC30", Offset = "0x16AE030", VA = "0x1816AEC30")]
		public IfExpressionNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x16AEA60", Offset = "0x16ADE60", VA = "0x1816AEA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B1CB0", Offset = "0x16B10B0", VA = "0x1816B1CB0")]
		public MakeDictionaryNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x16B1B60", Offset = "0x16B0F60", VA = "0x1816B1B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x16A2F80", Offset = "0x16A2380", VA = "0x1816A2F80")]
		public AbsoluteValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x16A2DA0", Offset = "0x16A21A0", VA = "0x1816A2DA0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x16A2CB0", Offset = "0x16A20B0", VA = "0x1816A2CB0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x16A2BB0", Offset = "0x16A1FB0", VA = "0x1816A2BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A3660", Offset = "0x16A2A60", VA = "0x1816A3660")]
		public AddNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x16A3490", Offset = "0x16A2890", VA = "0x1816A3490", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x16A3480", Offset = "0x16A2880", VA = "0x1816A3480", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A8280", Offset = "0x16A7680", VA = "0x1816A8280")]
		public DivideNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x16A8050", Offset = "0x16A7450", VA = "0x1816A8050", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x16A8250", Offset = "0x16A7650", VA = "0x1816A8250")]
		private static int SafeDivide(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x16A7E90", Offset = "0x16A7290", VA = "0x1816A7E90", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x16A8230", Offset = "0x16A7630", VA = "0x1816A8230")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B33C0", Offset = "0x16B27C0", VA = "0x1816B33C0")]
		public ModuloNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x16B31B0", Offset = "0x16B25B0", VA = "0x1816B31B0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x16B33A0", Offset = "0x16B27A0", VA = "0x1816B33A0")]
		private static int SafeModulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x16B2FD0", Offset = "0x16B23D0", VA = "0x1816B2FD0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x16B3380", Offset = "0x16B2780", VA = "0x1816B3380")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B3C60", Offset = "0x16B3060", VA = "0x1816B3C60")]
		public MultiplyNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x16B3AD0", Offset = "0x16B2ED0", VA = "0x1816B3AD0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x16B3920", Offset = "0x16B2D20", VA = "0x1816B3920", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B88D0", Offset = "0x16B7CD0", VA = "0x1816B88D0")]
		public PowerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x16B8820", Offset = "0x16B7C20", VA = "0x1816B8820", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x16B8770", Offset = "0x16B7B70", VA = "0x1816B8770", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BB8D0", Offset = "0x16BACD0", VA = "0x1816BB8D0")]
		public SubtractNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x16BB850", Offset = "0x16BAC50", VA = "0x1816BB850", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x16BB7D0", Offset = "0x16BABD0", VA = "0x1816BB7D0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B2D40", Offset = "0x16B2140", VA = "0x1816B2D40")]
		public MaxNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x16B2D30", Offset = "0x16B2130", VA = "0x1816B2D30", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x16B2D20", Offset = "0x16B2120", VA = "0x1816B2D20", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B2E00", Offset = "0x16B2200", VA = "0x1816B2E00")]
		public MinNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x16B2DF0", Offset = "0x16B21F0", VA = "0x1816B2DF0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x16B2DE0", Offset = "0x16B21E0", VA = "0x1816B2DE0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x16B7D50", Offset = "0x16B7150", VA = "0x1816B7D50")]
		public NumberNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount, int maxPortCount = int.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x16B7B70", Offset = "0x16B6F70", VA = "0x1816B7B70", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x16B79C0", Offset = "0x16B6DC0", VA = "0x1816B79C0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x16B7860", Offset = "0x16B6C60", VA = "0x1816B7860")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0960", Offset = "0x39FD60", VA = "0x1803A0960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x16BB190", Offset = "0x16BA590", VA = "0x1816BB190")]
		public StringFormatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x16BAD70", Offset = "0x16BA170", VA = "0x1816BAD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x16AAC40", Offset = "0x16AA040", VA = "0x1816AAC40")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x16AAB50", Offset = "0x16A9F50", VA = "0x1816AAB50", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x16AAA60", Offset = "0x16A9E60", VA = "0x1816AAA60", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	public abstract class ExternalVariableNode<TVal> : ExternalVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x1ACF480", Offset = "0x1ACE880", VA = "0x181ACF480")]
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
			[Cpp2IlInjected.Address(RVA = "0x74AFB0", Offset = "0x74A3B0", VA = "0x18074AFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x74BEA0", Offset = "0x74B2A0", VA = "0x18074BEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x518FB0", Offset = "0x5183B0", VA = "0x180518FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected Memory.IMemoryHandle MemoryHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x445F70", Offset = "0x445370", VA = "0x180445F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x16AF460", Offset = "0x16AE860", VA = "0x1816AF460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		internal Guid MemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x16AF360", Offset = "0x16AE760", VA = "0x1816AF360")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		protected Guid DefaultMemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x16AF270", Offset = "0x16AE670", VA = "0x1816AF270")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x16AF1D0", Offset = "0x16AE5D0", VA = "0x1816AF1D0")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x16AF110", Offset = "0x16AE510", VA = "0x1816AF110", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AD1310", Offset = "0x1AD0710", VA = "0x181AD1310")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		private string AllocateVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD1770", Offset = "0x1AD0B70", VA = "0x181AD1770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1150", Offset = "0x1AD0550", VA = "0x181AD1150")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x1AD02C0", Offset = "0x1ACF6C0", VA = "0x181AD02C0", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract Memory.IMemoryHandle Allocate(Guid defaultAddress, string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0940", Offset = "0x1ACFD40", VA = "0x181AD0940", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0050", Offset = "0x1ACF450", VA = "0x181AD0050", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0630", Offset = "0x1ACFA30", VA = "0x181AD0630", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0120", Offset = "0x1ACF520", VA = "0x181AD0120", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0E00", Offset = "0x1AD0200", VA = "0x181AD0E00", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0230", Offset = "0x1ACF630", VA = "0x181AD0230", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A3890", Offset = "0x16A2C90", VA = "0x1816A3890")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B1240", Offset = "0x16B0640", VA = "0x1816B1240")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AACE0", Offset = "0x16AA0E0", VA = "0x1816AACE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BACE0", Offset = "0x16BA0E0", VA = "0x1816BACE0")]
		public StringExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[NodeTag("Networking", new string[] { })]
	public abstract class SyncedInMemoryVariableNode<T> : InMemoryVariableNode<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x1ADA0F0", Offset = "0x1AD94F0", VA = "0x181ADA0F0")]
		protected SyncedInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Guid("1A5331BC-5025-487E-898C-3C49EE715664")]
	public class IntInMemoryVariableNode : InMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x16B12D0", Offset = "0x16B06D0", VA = "0x1816B12D0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x16B1320", Offset = "0x16B0720", VA = "0x1816B1320")]
		public IntInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[Guid("3EE1EDFE-5520-4714-862B-98AF90F6E3DA")]
	public class PlayerInMemoryVariableNode : InMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x16B12D0", Offset = "0x16B06D0", VA = "0x1816B12D0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x16B83D0", Offset = "0x16B77D0", VA = "0x1816B83D0")]
		public PlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x16B8380", Offset = "0x16B7780", VA = "0x1816B8380")]
		private static bool SetPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x16B8320", Offset = "0x16B7720", VA = "0x1816B8320")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BBCF0", Offset = "0x16BB0F0", VA = "0x1816BBCF0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x16BC160", Offset = "0x16BB560", VA = "0x1816BC160")]
		public SynchedPlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x16BC110", Offset = "0x16BB510", VA = "0x1816BC110")]
		private static bool SetSynchedPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x16BC0B0", Offset = "0x16BB4B0", VA = "0x1816BC0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BBCF0", Offset = "0x16BB0F0", VA = "0x1816BBCF0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x16BBD40", Offset = "0x16BB140", VA = "0x1816BBD40")]
		public SyncedInMemoryIntVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
	[Guid("DCE27FE2-ABC2-4A6A-9C4E-5D829A5B83A6")]
	public class FloatInMemoryVariableNode : InMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x16AAD70", Offset = "0x16AA170", VA = "0x1816AAD70", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x16AADC0", Offset = "0x16AA1C0", VA = "0x1816AADC0")]
		public FloatInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[Guid("56DCF860-9C74-4213-8859-45ABA0B96D43")]
	public class SyncedInMemoryFloatVariableNode : SyncedInMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x16BBBC0", Offset = "0x16BAFC0", VA = "0x1816BBBC0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x16BBC10", Offset = "0x16BB010", VA = "0x1816BBC10")]
		public SyncedInMemoryFloatVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Guid("8065D557-B6CC-4DD1-8CFA-B7481FE7BCF1")]
	public class BoolInMemoryVariableNode : InMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x16A3920", Offset = "0x16A2D20", VA = "0x1816A3920", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x16A3970", Offset = "0x16A2D70", VA = "0x1816A3970")]
		public BoolInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Guid("1E2CA8E7-037F-4A1A-82A7-62B81928B6A4")]
	public class SyncedInMemoryBoolVariableNode : SyncedInMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x16BBA90", Offset = "0x16BAE90", VA = "0x1816BBA90", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x16BBAE0", Offset = "0x16BAEE0", VA = "0x1816BBAE0")]
		public SyncedInMemoryBoolVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Guid("797913DF-1BCF-4280-8666-F17D7782CEBB")]
	public class StringInMemoryVariableNode : InMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x16BB4B0", Offset = "0x16BA8B0", VA = "0x1816BB4B0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x16BB540", Offset = "0x16BA940", VA = "0x1816BB540")]
		public StringInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Guid("62F1B8B1-F1D3-4CEB-B0E9-57C4915BF401")]
	public class SyncedInMemoryStringVariableNode : SyncedInMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x16BBE20", Offset = "0x16BB220", VA = "0x1816BBE20", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x16BBEB0", Offset = "0x16BB2B0", VA = "0x1816BBEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0970", Offset = "0x39FD70", VA = "0x1803A0970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x18D6BB0", Offset = "0x18D5FB0", VA = "0x1818D6BB0")]
		public ValueChangedNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x18D66E0", Offset = "0x18D5AE0", VA = "0x1818D66E0", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x18D6860", Offset = "0x18D5C60", VA = "0x1818D6860", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x18D6A00", Offset = "0x18D5E00", VA = "0x1818D6A00", Slot = "23")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x18D6A70", Offset = "0x18D5E70", VA = "0x1818D6A70")]
		private void UnregisterListeningNode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x18D68B0", Offset = "0x18D5CB0", VA = "0x1818D68B0")]
		private void OnIsConnectedChanged(bool isConnected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x18D68B0", Offset = "0x18D5CB0", VA = "0x1818D68B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0960", Offset = "0x39FD60", VA = "0x1803A0960", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x18D72E0", Offset = "0x18D66E0", VA = "0x1818D72E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D7010", Offset = "0x18D6410", VA = "0x1818D7010", Slot = "27")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x18D71C0", Offset = "0x18D65C0", VA = "0x1818D71C0", Slot = "22")]
		public void RegisterChangeListener(IVariableChangeListener changeListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x18D7220", Offset = "0x18D6620", VA = "0x1818D7220", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D3D40", Offset = "0x18D3140", VA = "0x1818D3D40")]
		protected ParsingNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x18D3AD0", Offset = "0x18D2ED0", VA = "0x1818D3AD0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D3960", Offset = "0x18D2D60", VA = "0x1818D3960")]
		public ParseIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x18D38E0", Offset = "0x18D2CE0", VA = "0x1818D38E0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D3770", Offset = "0x18D2B70", VA = "0x1818D3770")]
		public ParseFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x18D36F0", Offset = "0x18D2AF0", VA = "0x1818D36F0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D3580", Offset = "0x18D2980", VA = "0x1818D3580")]
		public ParseBoolNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x18D34B0", Offset = "0x18D28B0", VA = "0x1818D34B0", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C9870", Offset = "0x3C8C70", VA = "0x1803C9870", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0980", Offset = "0x39FD80", VA = "0x1803A0980", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x18D5570", Offset = "0x18D4970", VA = "0x1818D5570")]
		protected TypeConversionNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x18D5440", Offset = "0x18D4840", VA = "0x1818D5440")]
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
		[Cpp2IlInjected.Address(RVA = "0x18D1FA0", Offset = "0x18D13A0", VA = "0x1818D1FA0")]
		public IntToFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x18D1F60", Offset = "0x18D1360", VA = "0x1818D1F60", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AB100", Offset = "0x16AA500", VA = "0x1816AB100")]
		protected FloatToIntConversionNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x16AAF70", Offset = "0x16AA370", VA = "0x1816AAF70", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x16AAEA0", Offset = "0x16AA2A0", VA = "0x1816AAEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A4A90", Offset = "0x16A3E90", VA = "0x1816A4A90")]
		public FloorToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x16AB270", Offset = "0x16AA670", VA = "0x1816AB270", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A4A90", Offset = "0x16A3E90", VA = "0x1816A4A90")]
		public CeilToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x16A4A30", Offset = "0x16A3E30", VA = "0x1816A4A30", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A4A90", Offset = "0x16A3E90", VA = "0x1816A4A90")]
		public RoundToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x18D5010", Offset = "0x18D4410", VA = "0x1818D5010", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0960", Offset = "0x39FD60", VA = "0x1803A0960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x16B7320", Offset = "0x16B6720", VA = "0x1816B7320")]
		public NumberComparisonNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x16B7110", Offset = "0x16B6510", VA = "0x1816B7110", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x16B6ED0", Offset = "0x16B62D0", VA = "0x1816B6ED0")]
		private CircuitSignal CalculateReturnValueFloat(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x16B6FF0", Offset = "0x16B63F0", VA = "0x1816B6FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AE3D0", Offset = "0x16AD7D0", VA = "0x1816AE3D0")]
		public GreaterThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x16AE340", Offset = "0x16AD740", VA = "0x1816AE340", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x16AE330", Offset = "0x16AD730", VA = "0x1816AE330", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B17A0", Offset = "0x16B0BA0", VA = "0x1816B17A0")]
		public LessThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x16B1710", Offset = "0x16B0B10", VA = "0x1816B1710", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x16B1700", Offset = "0x16B0B00", VA = "0x1816B1700", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16AE500", Offset = "0x16AD900", VA = "0x1816AE500")]
		public GreaterThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x16AE460", Offset = "0x16AD860", VA = "0x1816AE460", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x16AE4F0", Offset = "0x16AD8F0", VA = "0x1816AE4F0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B18D0", Offset = "0x16B0CD0", VA = "0x1816B18D0")]
		public LessThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x16B1830", Offset = "0x16B0C30", VA = "0x1816B1830", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x16B18C0", Offset = "0x16B0CC0", VA = "0x1816B18C0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A8BB0", Offset = "0x16A7FB0", VA = "0x1816A8BB0")]
		public EqualsNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x16A8A30", Offset = "0x16A7E30", VA = "0x1816A8A30", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x16A8A60", Offset = "0x16A7E60", VA = "0x1816A8A60", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x16A8420", Offset = "0x16A7820", VA = "0x1816A8420")]
		private OutputPortGetDelegate GetDelegateForType(CircuitType specificType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x16A8820", Offset = "0x16A7C20", VA = "0x1816A8820")]
		private CircuitSignal GetReferenceEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x16A8920", Offset = "0x16A7D20", VA = "0x1816A8920")]
		private CircuitSignal GetStringEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x16A85C0", Offset = "0x16A79C0", VA = "0x1816A85C0")]
		private CircuitSignal GetFloatEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x16A8720", Offset = "0x16A7B20", VA = "0x1816A8720")]
		private CircuitSignal GetIntEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x16A8320", Offset = "0x16A7720", VA = "0x1816A8320")]
		private CircuitSignal GetBooleanEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x16A8580", Offset = "0x16A7980", VA = "0x1816A8580")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BC900", Offset = "0x16BBD00", VA = "0x1816BC900")]
		public ToStringNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x16A8A30", Offset = "0x16A7E30", VA = "0x1816A8A30", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x16BC750", Offset = "0x16BBB50", VA = "0x1816BC750", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x16BC340", Offset = "0x16BB740", VA = "0x1816BC340")]
		private ConvertFunc GetDelegateForType(CircuitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x16BC5C0", Offset = "0x16BB9C0", VA = "0x1816BC5C0")]
		private CircuitSignal GetPlayerToString(CircuitContext context, CircuitSignal inputsignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x16BC270", Offset = "0x16BB670", VA = "0x1816BC270", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x16BC6D0", Offset = "0x16BBAD0", VA = "0x1816BC6D0")]
		private static CircuitSignal GetReferenceToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x16BC730", Offset = "0x16BBB30", VA = "0x1816BC730")]
		private static CircuitSignal GetStringToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x16BC500", Offset = "0x16BB900", VA = "0x1816BC500")]
		private static CircuitSignal GetFloatToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x16BC560", Offset = "0x16BB960", VA = "0x1816BC560")]
		private static CircuitSignal GetIntToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x16BC2E0", Offset = "0x16BB6E0", VA = "0x1816BC2E0")]
		private static CircuitSignal GetBooleanToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x16BC4C0", Offset = "0x16BB8C0", VA = "0x1816BC4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B1600", Offset = "0x16B0A00", VA = "0x1816B1600")]
		public InvalidPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x16B15B0", Offset = "0x16B09B0", VA = "0x1816B15B0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B10", Offset = "0x7A4F10", VA = "0x1807A5B10", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B19B0", Offset = "0x16B0DB0", VA = "0x1816B19B0")]
		public LocalPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x16B1960", Offset = "0x16B0D60", VA = "0x1816B1960", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B10", Offset = "0x7A4F10", VA = "0x1807A5B10", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x16ADC90", Offset = "0x16AD090", VA = "0x1816ADC90")]
		public GetPlayerIsLocalNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x16ADB90", Offset = "0x16ACF90", VA = "0x1816ADB90", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16ADED0", Offset = "0x16AD2D0", VA = "0x1816ADED0")]
		public GetPlayerNameNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x16ADE30", Offset = "0x16AD230", VA = "0x1816ADE30", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16ACCA0", Offset = "0x16AC0A0", VA = "0x1816ACCA0")]
		public GetAllPlayersNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x16ACC20", Offset = "0x16AC020", VA = "0x1816ACC20")]
		private CircuitSignal GetPlayerList(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x16ACB40", Offset = "0x16ABF40", VA = "0x1816ACB40", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F70", Offset = "0x445370", VA = "0x180445F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x43CD40", Offset = "0x43C140", VA = "0x18043CD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F20", Offset = "0x445320", VA = "0x180445F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E18E0", Offset = "0x3E0CE0", VA = "0x1803E18E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x16B8FB0", Offset = "0x16B83B0", VA = "0x1816B8FB0")]
		public PromptLocalPlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x16B8D30", Offset = "0x16B8130", VA = "0x1816B8D30")]
		private CircuitSignal GetPromptResponse(IExecutionScope executionscope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x16B8A30", Offset = "0x16B7E30", VA = "0x1816B8A30", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x16B8970", Offset = "0x16B7D70", VA = "0x1816B8970")]
		private void ExecuteAfterPrompt(OutputPort fromPort)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4D5D0", Offset = "0x4C9D0")]
	[Guid("163C326E-6BB9-428A-8837-FF507D948E93")]
	public class GetPlayerHealthNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x16AD9F0", Offset = "0x16ACDF0", VA = "0x1816AD9F0")]
		public GetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x16AD8D0", Offset = "0x16ACCD0", VA = "0x1816AD8D0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[InternalNode]
	[Guid("6B962C79-6BE2-4E2C-A517-BE998B58F9D1")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4EAF0", Offset = "0x4DEF0")]
	public class GetPlayerShieldNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x16AE190", Offset = "0x16AD590", VA = "0x1816AE190")]
		public GetPlayerShieldNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x16AE070", Offset = "0x16AD470", VA = "0x1816AE070", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	[InternalNode]
	[Guid("67ACA89C-F753-4F94-87DF-1CE1D4FCB8B0")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4EF00", Offset = "0x4E300")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F70", Offset = "0x445370", VA = "0x180445F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x16A6F30", Offset = "0x16A6330", VA = "0x1816A6F30")]
		public DamagePlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x16A6CF0", Offset = "0x16A60F0", VA = "0x1816A6CF0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4F610", Offset = "0x4EA10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A0720", Offset = "0x39FB20", VA = "0x1803A0720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x16BA3D0", Offset = "0x16B97D0", VA = "0x1816BA3D0")]
		public ResetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x16BA250", Offset = "0x16B9650", VA = "0x1816BA250", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x382600", VA = "0x180383200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x396DF0", Offset = "0x3961F0", VA = "0x180396DF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x12064B0", Offset = "0x12058B0", VA = "0x1812064B0")]
		protected CircuitNetworking(IRPCSender rpcSender, IContextSynchronizedFieldFactory synchronizedFieldFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x18C3C90", Offset = "0x18C3090", VA = "0x1818C3C90", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x18BD640", Offset = "0x18BCA40", VA = "0x1818BD640")]
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
